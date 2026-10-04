# ARWatches

## Augmented Reality Watch Visualization Application

ARWatches is an augmented reality application developed with **Unity**, **C#**, and **Vuforia Engine**. The project allows users to visualize and interact with different 3D watch models through an augmented reality experience.

The application combines image-based AR tracking, 3D watch models, wrist positioning, occlusion techniques, interactive menus, and computer-vision-related assets.

---

## 1. Project Overview

The main objective of ARWatches is to provide an interactive augmented reality experience for visualizing different watch models.

Using a compatible camera-enabled mobile device, the application can detect an AR marker and display a selected virtual watch in the augmented environment.

The project includes several 3D watch models, dedicated C# scripts, AR resources, shaders, materials, textures, and computer vision assets.

---

## 2. Main Features

- Augmented reality watch visualization
- Image-based AR tracking
- Multiple 3D watch models
- Watch selection and management
- Interactive menu
- Wrist positioning functionality
- Wrist occlusion support
- 3D materials and textures
- Vuforia Engine configuration
- Computer vision model assets
- Demonstration video

---

## 3. Technologies Used

| Technology | Role |
|---|---|
| Unity | Application and 3D development |
| C# | Application scripting |
| Vuforia Engine | Augmented reality and image tracking |
| 3D Models | Virtual watch visualization |
| Unity Shaders | Occlusion and AR rendering |
| Computer Vision Assets | Detection and tracking resources |

---

## 4. Watch Selection and Management

The project contains dedicated C# scripts for managing the available watch models.

### WatchData.cs

`WatchData.cs` contains the data structure used to represent information associated with the different watch models.

### WatchManager.cs

`WatchManager.cs` manages the available watch models and their selection within the application.

These scripts are located in:

```text
Assets/scripts/
```

---

## 5. Interactive Menu

The project includes a dedicated menu script.

### Menu.cs

`Menu.cs` provides the logic required for navigation and interaction with the application's features.

The script is located in:

```text
Assets/scripts/Menu.cs
```

---

## 6. Wrist Positioning and Occlusion

The project contains dedicated scripts related to wrist functionality.

### Wrist.cs

`Wrist.cs` is used for wrist-related positioning functionality within the AR experience.

### WristOcclusion.cs

`WristOcclusion.cs` contributes to the occlusion and positioning system used to integrate the virtual watch more naturally into the augmented environment.

The scripts are located in:

```text
Assets/Wrist.cs
Assets/WristOcclusion.cs
```

---

## 7. 3D Watch Models

The project includes several 3D watch models that can be selected and displayed in the augmented reality experience.

The available models include:

- Apple Watch Series 7
- Apple Watch Series 8
- Bausele White Oceanmoon Watch
- Digital Watch
- Seiko Watch
- Smart Watch KW-19
- Wrist Watch
- Watch Test

The models are organized inside the Unity `Assets` directory and are associated with their corresponding prefabs, materials, meshes, and textures.

Main resource directories:

```text
Assets/Watches/
Assets/Prefabs/
Assets/Resources/WatchPreviews/
```

---

## 8. Augmented Reality Assets

The project contains the resources required for the AR experience, including:

- Vuforia configuration
- AR marker
- 3D watch models
- Prefabs
- Materials
- Textures
- Occlusion shaders
- Unity scenes

The main AR marker included in the project is:

```text
Assets/Mko_Marker.jpg
```

The Vuforia configuration is located at:

```text
Assets/Resources/VuforiaConfiguration.asset
```

---

## 9. Shaders and Occlusion

The project includes custom shader resources used for rendering and occlusion:

```text
Assets/CylinderMaskFixed.shader
Assets/DepthMaskFixed.shader
Assets/Materials/CylinderMask.mat
Assets/Materials/CylinderMaskFixed.mat
```

These resources are part of the AR rendering system and support the visual integration of virtual objects into the augmented environment.

---

## 10. Computer Vision and ML Assets

The project contains a collection of pre-trained model resources under:

```text
Assets/StreamingAssets/
```

These resources include models related to:

- Face detection
- Face landmarks
- Hand detection
- Hand landmarks
- Pose detection
- Segmentation
- Object detection
- Gesture recognition
- Audio classification

Examples include:

```text
blaze_face_short_range.bytes
deeplab_v3.bytes
efficientdet_lite0_float16.bytes
face_detection_full_range.bytes
face_landmark.bytes
gesture_recognizer.bytes
hand_landmark_full.bytes
pose_detection.bytes
pose_landmark_full.bytes
ssd_mobilenet_v2_float32.bytes
ssdlite_object_detection.bytes
yamnet_audio_classifier_with_metadata.bytes
```

---

## 11. Project Structure

```text
ARWatches/
│
├── Assets/
│   ├── Editor/
│   ├── Materials/
│   ├── Prefabs/
│   ├── Resources/
│   │   └── WatchPreviews/
│   ├── Scenes/
│   ├── StreamingAssets/
│   ├── TextMesh Pro/
│   ├── Watches/
│   ├── scripts/
│   │   ├── Menu.cs
│   │   ├── WatchData.cs
│   │   └── WatchManager.cs
│   ├── Wrist.cs
│   ├── WristOcclusion.cs
│   ├── Mko_Marker.jpg
│   └── ...
│
├── demo/
│   └── Démo projet ARWatches.mp4
│
├── .gitignore
│
└── README.md
```

---

## 12. Demo

A demonstration video is included in the repository:

```text
demo/Démo projet ARWatches.mp4
```

The demonstration presents the ARWatches application and its augmented reality interaction with the virtual watch models.

---

## 13. How to Open the Project

### Requirements

- Unity
- Vuforia Engine
- A compatible camera-enabled device
- A mobile device suitable for augmented reality testing

### Steps

1. Clone the repository.
2. Open **Unity Hub**.
3. Add the cloned `ARWatches` project to Unity Hub.
4. Open the project using the appropriate Unity version.
5. Open the available Unity scene.
6. Verify the Vuforia configuration.
7. Connect a compatible mobile device.
8. Build and run the application.
9. Point the device camera toward the AR marker.
10. Interact with the available watch models.

---

## 14. AR Marker

The project contains an image marker used by the augmented reality system:

```text
Assets/Mko_Marker.jpg
```

The marker is used as part of the image-based AR tracking process.

For testing, the marker should be visible to the device camera under suitable lighting conditions.

---

## 15. Main C# Scripts

The main custom scripts included in the project are:

```text
Assets/scripts/Menu.cs
Assets/scripts/WatchData.cs
Assets/scripts/WatchManager.cs
Assets/Wrist.cs
Assets/WristOcclusion.cs
```

### Responsibilities

**Menu.cs**
- Handles menu-related interaction and navigation.

**WatchData.cs**
- Represents information associated with the available watches.

**WatchManager.cs**
- Manages the available watch models and their selection.

**Wrist.cs**
- Handles wrist-related functionality.

**WristOcclusion.cs**
- Supports wrist positioning and occlusion-related functionality.

---

## 16. Unity Scene

The project includes the main Unity scene:

```text
Assets/Scenes/SampleScene.unity
```

This scene contains the Unity objects and components required for the AR application.

---

## 17. Repository Contents

This repository contains the main project resources required to explore the ARWatches application, including:

- Unity source files
- C# scripts
- Unity scenes
- 3D watch models
- Prefabs
- Materials
- Textures
- AR marker
- Vuforia configuration
- Shaders
- Computer vision model assets
- Demonstration video

---

## 18. Third-Party Assets

The project contains third-party 3D assets and resources.

Where available, the original license files have been retained inside the corresponding asset directories.

For example:

```text
Assets/Watches/
```

contains license files associated with some of the included watch models.

Before redistributing individual third-party assets outside this repository, their respective license terms should be checked.

---

## 19. Project Status

ARWatches is an academic augmented reality prototype developed with Unity and Vuforia Engine.

The repository is intended to document and showcase the project, its source code, Unity assets, augmented reality components, and demonstration.

---

## 20. Author

**Naziha Goubaa**

GitHub: https://github.com/naziha-goubaa

---

## 21. Repository

GitHub repository:

https://github.com/naziha-goubaa/ar-watches
