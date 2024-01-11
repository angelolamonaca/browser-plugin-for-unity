using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using PuppeteerSharp;
using Unity.VisualScripting;
using UnityEngine;

public class HeadlessBrowserController : MonoBehaviour
{
    private int viewportWidth = 1000;
    private int viewportHeight = 500;
    private int screenshotQuality = 90;
    private IBrowser browser;
    private IPage page;
    private Texture2D texture;
    private CancellationTokenSource cancellationTokenSource;
    private decimal mouseX;
    private decimal mouseY;
    private decimal mouseYBeforeStartScrolling;
    private bool isScrolling = false;

    public void MoveMouse(decimal x, decimal y)
    {
        mouseX = x;
        mouseY = y;
    }

    public void ScrollIfNeeded()
    {
        if (isScrolling)
        {
            if (mouseYBeforeStartScrolling - mouseY > 0)
            {
                page.Mouse.WheelAsync(0, 1);
            }
            else
            {
                page.Mouse.WheelAsync(0, -1);
            }
        }
    }

    public void ClickMouse()
    {
        page.Mouse.ClickAsync(mouseX, mouseY);
    }

    public void StartScrollAction()
    {
        mouseYBeforeStartScrolling = mouseY;
        isScrolling = true;
    }

    public void EndsScrollAction()
    {
        isScrolling = false;
    }

    async void Start()
    {
        cancellationTokenSource = new CancellationTokenSource();
        await LaunchBrowser();
        texture = new Texture2D(1, 1);
        StartCoroutine(UpdateTextureCoroutine());
    }

    async Task LaunchBrowser()
    {
        using var browserFetcher = new BrowserFetcher();
        await browserFetcher.DownloadAsync();
        browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
        page = await browser.NewPageAsync();
        await page.SetViewportAsync(new ViewPortOptions { Width = viewportWidth, Height = viewportHeight }); // Set a lower resolution
        await page.GoToAsync("https://www.google.com/search?q=how+to+wheel+puppeteer&rlz=1C1VDKB_enIT1067IT1067&oq=how+to+wheel+puppeteer&gs_lcrp=EgZjaHJvbWUyBggAEEUYOdIBCDYxNzNqMGo5qAIAsAIA&sourceid=chrome&ie=UTF-8");
    }

    IEnumerator UpdateTextureCoroutine()
    {
        while (!cancellationTokenSource.IsCancellationRequested)
        {

            // Start the async task
            Task updateTextureTask = UpdateTexture();

            // Wait until the async task is complete
            yield return new WaitUntil(() => updateTextureTask.IsCompleted);

            // Optionally, handle exceptions if the task failed
            if (updateTextureTask.IsFaulted)
            {
                //UnityEngine.Debug.LogError($"Error in UpdateTexture: {updateTextureTask.Exception}");
            }
        }
    }

    async Task UpdateTexture()
    {
        var updateStopwatch = new Stopwatch(); // Stopwatch for screenshot capture
        var captureStopwatch = new Stopwatch(); // Stopwatch for screenshot capture
        var applyStopwatch = new Stopwatch(); // Stopwatch for texture load and apply

        try
        {
            updateStopwatch.Start(); // Start timing the screenshot capture
            captureStopwatch.Start(); // Start timing the screenshot capture
            byte[] screenshot = await page.ScreenshotDataAsync(new ScreenshotOptions { Type = ScreenshotType.Jpeg, Quality = screenshotQuality });
            captureStopwatch.Stop(); // Stop timing the screenshot capture

            //UnityEngine.Debug.Log($"Screenshot capture time: {captureStopwatch.ElapsedMilliseconds} ms");

            applyStopwatch.Start(); // Start timing the texture load and apply
            if (texture.LoadImage(screenshot))
            {
                gameObject.GetComponent<Renderer>().material.mainTexture = texture;
            }
            applyStopwatch.Stop(); // Stop timing the texture load and apply
            updateStopwatch.Stop(); // Stop timing the texture load and apply

            //UnityEngine.Debug.Log($"Texture load and apply time: {applyStopwatch.ElapsedMilliseconds} ms");
            //UnityEngine.Debug.Log($"Updates/frames per second: {1000 / updateStopwatch.ElapsedMilliseconds} ups/fps");
        }
        catch (System.Exception e)
        {
            //UnityEngine.Debug.LogError($"Error in UpdateTexture: {e.Message}");
        }
        finally
        {
            captureStopwatch.Reset(); // Reset the capture stopwatch
            applyStopwatch.Reset(); // Reset the apply stopwatch
        }
    }


    void OnDestroy()
    {
        cancellationTokenSource.Cancel();
        browser?.Dispose();
        if (texture != null)
        {
            Destroy(texture);
        }
    }
}
