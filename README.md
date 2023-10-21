**Objective:**
The goal is to develop an open-source Unity plugin that incorporates browser windows into Unity scenes.

**State of the Art:**

**Open Source Projects:**

1. **Servo-Unity**
    - Developer: Philip-Lamb
    - Status: Abandoned
    - Engine: servo
    - GitHub Repo: [Servo-Unity](https://github.com/MozillaReality/servo-unity).
    - Latest Official Post: [Mozilla Blog Post](https://blog.mozvr.com/a-browser-plugin-for-unity/).
    - Description: Servo-Unity was developed by GitHub user Philip-Lamb with the support of MozillaReality. The
      project's objective was to integrate the "Servo" web rendering engine into Unity. Unfortunately, in 2020, Mozilla
      withdrew its support for the development of Servo-Unity, leading to its abandonment. This decision was made
      following Mozilla's layoffs of many employees, including the Servo team, as part of their restructuring to adapt
      to post-COVID-19 financial challenges and focus on new commercial services. Consequently, the governance of the
      Servo project was transferred to the Linux Foundation (source: Wikipedia).
      Following a two-year hiatus, in January 2023, the Servo project announced that it had received new external
      funding, enabling a team of developers to recommence work on the project. Their GitHub repo can be found here. At
      present, the Servo team is focusing on supporting CSS2, with the latest development news detailing support for
      floats and white-space: no wrap. However, it's worth noting that Servo sometimes experiences crashes due to bugs
      or unimplemented features (source: Servo Blog).
      Although Philip-Lamb initially resumed work on Servo-Unity and even moved the repository to his personal GitHub
      account, there have been no new developments since 2021. Presently, Philip-Lamb appears to be focused on
      ARToolKit, an open-source computer tracking library for creating augmented reality applications. His public GitHub
      commits indicate that he is no longer involved with Servo projects.
      <br/><br/>
2. **Unity-Webview**
    - Developer: Gree
    - Status: In development
    - Engine: unknown
    - GitHub Repo: [Unity-Webview](https://github.com/gree/unity-webview).
    - Derived from: Keijiro-san's
      Repo [Unity-Webview-Integration](https://github.com/keijiro/unity-webview-integration).
    - Description: This plugin overlays WebView components on Unity's rendering view. It supports Android, iOS, Unity
      Web Player, and Mac, but not Windows. The limitation of this plugin is that it doesn't support 3D views.
      <br/><br/>
3. **UnityOculusAndroidVRBrowser**
    - Developer: Ian Philips
    - Status: In development
    - Engine: Gecko.
    - GitHub Repo: [UnityOculusAndroidVRBrowser](https://github.com/IanPhilips/UnityOculusAndroidVRBrowser).
    - Description: This is a 3D web browser based on the GeckoView browser engine from Mozilla. It's designed for Oculus
      Go and Quest and is adapted from Eyeflite's hands-free browser. The demo project doesn't fully support controller
      buttons, and the author is not actively working on the project.
      <br/><br/>
4. **Chromium-Unity-Server**
    - Developer: Roy Dejong
    - Status: Abandoned
    - Engine: Blink
    - GitHub Repo: [Chromium-Unity-Server](https://github.com/roydejong/chromium-unity-server).
    - Description: A proxy server for an embedded Chromium browser in Unity games, but there is no documentation
      available.

<br/><br/>

**Closed Source Projects:**

1. **Embedded Browser**
    - Engine: Blink (Chromium - Chrome).
    - [Link to Asset Store](https://assetstore.unity.com/packages/tools/gui/embedded-browser-55459).
      <br/><br/>
2. **3D WebView for Android with Gecko Engine**
    - Engine: Gecko (Firefox).
    - [Link to Asset Store](https://assetstore.unity.com/packages/tools/gui/3d-webview-for-android-with-gecko-engine-web-browser-158778).
      <br/><br/>
3. **3D WebView for Windows and MacOS**
    - Engine: Gecko (Firefox).
    - [Link to Asset Store](https://assetstore.unity.com/packages/tools/gui/3d-webview-for-windows-and-macos-web-browser-154144).

<br/><br/>

**Conclusion:**

Creating a browser for Unity 3D scenes is a challenge that has seen several attempts, both in open and closed-source
communities. While open-source projects such as Servo-Unity and Unity-Webview have aimed to bridge the gap, they have
faced challenges in terms of active development and support. On the other hand, closed-source projects like the Embedded
Browser and 3D WebView have managed to provide solutions, but at a cost.
