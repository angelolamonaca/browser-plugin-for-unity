using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BrowserRaycaster : MonoBehaviour
{
    public HeadlessBrowserController browserController;
    private decimal mouseX;
    private decimal mouseY;

    void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            // Check if hit the specific object (e.g., tagged as "BrowserQuad")
            if (hit.collider.gameObject.CompareTag("BrowserQuad"))
            {
                Vector2 localCoordinates = GetLocalCoordinates(hit);
                // Debug.Log("Local Coordinates: " + localCoordinates);
                Vector2 normalizedCoordinates = normalizeCoordinates(localCoordinates, new Vector2(3, 1.5f));
                // Debug.Log("Normalized Coordinates: " + normalizedCoordinates);
                Vector2 browserCoordinates = mapToBrowserCoordinates(normalizedCoordinates, new Vector2(1000, 500));
                Debug.Log("Browser Coordinates: " + browserCoordinates);
                mouseX = (decimal)browserCoordinates.x;
                mouseY = (decimal)browserCoordinates.y;
                browserController.MoveMouse(mouseX, mouseY);
            }
        }
        browserController.ScrollIfNeeded();
    }

    private Vector2 GetLocalCoordinates(RaycastHit hit)
    {
        // Convert hit point to local coordinates relative to the quad
        Vector3 localHitPoint = hit.collider.transform.InverseTransformPoint(hit.point);
        return new Vector2(localHitPoint.x, localHitPoint.y);
    }

    private Vector2 normalizeCoordinates(Vector2 localHitCoordinates, Vector2 quadScale)
    {
        return new Vector2(
                    localHitCoordinates.x  + 0.5f,
                    localHitCoordinates.y  + 0.5f
                );
    }

    private Vector2 mapToBrowserCoordinates(Vector2 normalizedCoordinates, Vector2 browserResolution)
    {
        // Map normalized coordinates to browser resolution
        Vector2 browserCoordinates = new Vector2(
            normalizedCoordinates.x * browserResolution.x,
            (1 - normalizedCoordinates.y) * browserResolution.y
        );

        return browserCoordinates;
    }
}
