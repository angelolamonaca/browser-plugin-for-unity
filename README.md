<h1>Objective</h1>
The goal is to develop an open-source Unity plugin that incorporates browser windows into Unity scenes.
<div style="border-top: azure 2px solid"></div>
<div style="text-align: center">
<h2>State of the Art</h2>
</div>

**Open Source Projects:**

1. **Servo-Unity**
    - Developer: Philip-Lamb
    - Status: Abandoned
    - Engine: servo
    - GitHub Repo: [Servo-Unity](https://github.com/MozillaReality/servo-unity).
    - Latest Official Post: [Mozilla Blog Post](https://blog.mozvr.com/a-browser-plugin-for-unity/).
    - Description: Servo-Unity was developed by GitHub user Philip-Lamb with the support of MozillaReality. The
      project's objective was to integrate the "Servo" web rendering engine into Unity. Unfortunately, in 2020, Mozilla
      withdrew its support for the development of Servo-Unity, leading to its abandonment.

      This decision was made
      following Mozilla's layoffs of many employees, including the Servo team, as part of their restructuring to adapt
      to post-COVID-19 financial challenges and focus on new commercial services. Consequently, the governance of the
      Servo project was transferred to the Linux Foundation (source: Wikipedia).

      Following a two-year hiatus, in January 2023, the Servo project announced that it had received new external
      funding, enabling a team of developers to recommence work on the project.

      At present, the Servo team is focusing on supporting CSS2, with the latest development news detailing support for
      floats and white-space: no wrap. However, it's worth noting that Servo sometimes experiences crashes due to bugs
      or unimplemented features (source: Servo Blog).

      Although Philip-Lamb initially resumed work on Servo-Unity and even moved the repository to his personal GitHub
      account, there have been no new developments since 2021. Presently, Philip-Lamb appears to be focused on
      ARToolKit, an open-source computer tracking library for creating augmented reality applications. His public GitHub
      commits indicate that he is no longer involved with Servo projects.
    - Open
      questions: Should we fork this project? Since servo engine is not supporting newest websites with CSS2 and CSS3
      for example and the project also is abandoned
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
    - Open
      questions: What means overlying WebView? It's worth spend time studying this implementation? From my understanding
      it looks like we cannot place the browser in 3D spaces with this project
      <br/><br/>
3. **UnityOculusAndroidVRBrowser**
    - Developer: Ian Philips
    - Status: In development
    - Engine: Gecko.
    - GitHub Repo: [UnityOculusAndroidVRBrowser](https://github.com/IanPhilips/UnityOculusAndroidVRBrowser).
    - Description: This is a 3D web browser based on the GeckoView browser engine from Mozilla. It's designed for Oculus
      Go and Quest and is adapted from Eyeflite's hands-free browser. The demo project doesn't fully support controller
      buttons, and the author is not actively working on the project.
    - Open
      questions: The project has only 3 contributors, can this be a good starting point for further development?
      Since it's designed for Oculus maybe it will be difficult to adapt for other VR headsets. This repo could also be
      good as a reference for a completely new implementation from scratch
      <br/><br/>
4. **Chromium-Unity-Server**
    - Developer: Roy Dejong
    - Status: Abandoned
    - Engine: Blink
    - GitHub Repo: [Chromium-Unity-Server](https://github.com/roydejong/chromium-unity-server).
    - Description: A proxy server for an embedded Chromium browser in Unity games, but there is no documentation
      available.
    - Open
      questions: This project has no documentation, but maybe it can be a good reference? With my current Unity
      knowledge I don't know how to set up and test this implementation

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

<div style="border-top: azure 2px solid"></div>
<div style="text-align: center">
<h2>Project Roadmap</h2>
</div>

## Phase 1: Research and Planning

- **Objective:** Understand the existing solutions and define the project scope and requirements.
    - **Tasks:**
        - [x] Review existing open-source and closed-source browser plugins for Unity.
        - [x] Identify the limitations and gaps in the current solutions.
        - [x] Create a detailed project plan and timeline.
        - [ ] Define the project requirements, the opensource project for the reference and the web rendering engine.

## Phase 2: Setting Up the Development Environment

- **Objective:** Prepare the development environment and tools needed for the project.
    - **Tasks:**
        - [ ] Set up Unity and necessary plugins.
        - [ ] Learn 2D Unity basics.
        - [ ] Learn 3D Unity basics.
        - [ ] Learn VR Unity basics.

## Phase 3: Development of Core Functionality

- **Objective:** Develop the core functionality of the browser plugin.
    - **Tasks:**
        - [ ] Implement the basic browser window.
        - [ ] Implement navigation features.
        - [ ] Test and debug the core functionality.

## Phase 4: Development of Additional Features

- **Objective:** Add additional features and enhancements to the browser plugin.
    - **Tasks:**
        - [ ] Develop additional interaction features (e.g., gestures, scrolling with controllers).
        - [ ] Test and debug the additional features.

<div style="border-top: azure 2px solid"></div>
<div style="text-align: center">
<h2>Project Plan</h2>
</div>

- **Objective:** Develop an open-source Unity plugin to incorporate browser windows into Unity scenes.
- **Duration:** October 2023 - January 2024 (approximately 3 months).
- **Risks:** Limited experience with Unity could result in challenges during the development process.

# Timeline

| Start Date | End Date   | Task                                                     | Duration | Status      |
|------------|------------|----------------------------------------------------------|----------|-------------|
| 10/10/2023 | 24/10/2023 | Phase 1: Research and Planning                           | 14 days  | In progress |
| 25/10/2023 | 07/11/2023 | Phase 2: Part 1 - Setting Up the Development Environment | 13 days  | Pending     |
| 08/10/2023 | 20/11/2023 | Phase 2: Part 2 - Learn Unity basics                     | 13 days  | Pending     |
| 21/11/2023 | 20/12/2023 | Phase 3: Development of Core Functionality               | 30 days  | Pending     |
| 21/12/2023 | 07/01/2024 | Phase 4: Development of Additional Features              | 17 days  | Pending     |

<div style="border-top: azure 2px solid"></div>
<div style="text-align: center">
<h2>Conclusion</h2>
</div>
Creating a browser for Unity 3D scenes is a challenge that has seen several attempts, both in open and closed-source
communities. While open-source projects such as Servo-Unity and Unity-Webview have aimed to bridge the gap, they have
faced challenges in terms of active development and support. On the other hand, closed-source projects like the Embedded
Browser and 3D WebView have managed to provide solutions, but at a cost.

<div style="border-top: azure 2px solid; margin-top: 100px"></div>
