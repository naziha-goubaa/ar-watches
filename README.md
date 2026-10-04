# ARWatches

## Augmented Reality Smartwatch Visualization Application

ARWatches is an **Augmented Reality (AR)** application developed with **Unity, C# and Vuforia Engine**. The project allows users to visualize different smartwatch and wristwatch models as 3D virtual objects through an augmented reality experience.

The application combines **3D modeling resources, augmented reality tracking, interactive model management, wrist positioning and occlusion techniques** to provide a more immersive visualization of watches.

---

## Table of Contents

- [Project Overview](#project-overview)
- [Objectives](#objectives)
- [Main Features](#main-features)
- [Technologies](#technologies)
- [Project Architecture](#project-architecture)
- [Application Workflow](#application-workflow)
- [Augmented Reality](#augmented-reality)
- [Watch Models](#watch-models)
- [Wrist Tracking and Positioning](#wrist-tracking-and-positioning)
- [Occlusion System](#occlusion-system)
- [Project Structure](#project-structure)
- [Main Scripts](#main-scripts)
- [Assets and Resources](#assets-and-resources)
- [Installation](#installation)
- [Running the Project](#running-the-project)
- [Vuforia Configuration](#vuforia-configuration)
- [AR Marker](#ar-marker)
- [Demonstration](#demonstration)
- [Technical Challenges](#technical-challenges)
- [Skills Developed](#skills-developed)
- [Possible Improvements](#possible-improvements)
- [Project Limitations](#project-limitations)
- [Git Workflow](#git-workflow)
- [Author](#author)
- [Repository](#repository)
- [License and Assets](#license-and-assets)
- [Conclusion](#conclusion)

---

# Project Overview

ARWatches is an experimental **Augmented Reality application for watch visualization**.

The project was developed to explore how virtual 3D watch models can be integrated into a real-world environment using a camera and an AR framework.

The application contains several watch models and supporting resources. Users can interact with the available models and visualize them through the Unity AR scene.

The project focuses particularly on:

- Augmented Reality;
- 3D object visualization;
- AR marker detection;
- smartwatch and wristwatch models;
- wrist positioning;
- occlusion;
- shaders;
- Unity prefabs;
- interactive model management.

---

# Objectives

The main objectives of ARWatches are to:

1. Discover and apply the fundamental concepts of Augmented Reality.
2. Integrate **Vuforia Engine** into a Unity project.
3. Detect an AR marker through a camera.
4. Display 3D virtual objects in a real environment.
5. Integrate several watch models into the same application.
6. Organize and manage multiple 3D assets.
7. Allow the user to navigate between available watch models.
8. Position virtual watches around the user's wrist.
9. Experiment with occlusion and depth masking.
10. Improve the visual integration between virtual objects and the real environment.
11. Develop a complete Unity project using C# scripts and reusable prefabs.

---

# Main Features

## 1. Augmented Reality

The application uses **Vuforia Engine** to implement augmented reality functionality.

The project includes a dedicated Vuforia configuration and an AR marker that can be used to detect the target and display virtual content.

---

## 2. 3D Watch Visualization

The application contains several 3D watch models that can be loaded and displayed inside the Unity scene.

The project includes models such as:

- Apple Watch Series 7
- Apple Watch Series 8
- Bausele White Oceanmoon Watch
- Digital Watch
- Hand Watch
- Seiko Watch
- Smart Watch KW-19
- Wrist Watch
- Additional watch variants and prefabs

---

## 3. Watch Selection and Management

The project contains dedicated C# scripts for managing the watch models.

The main management components include:

```text
WatchData.cs
WatchManager.cs
These components are used to organize the available watch models and manage their use within the application.

4. Interactive Menu

A dedicated menu script is included in the project:

Menu.cs

It provides the logic required for navigation and interaction with the application's watch selection interface.

5. Wrist Positioning

The project contains dedicated scripts for wrist-related functionality:

Wrist.cs
WristOcclusion.cs

These scripts are used as part of the system responsible for positioning and integrating the virtual watch around the wrist.

6. Occlusion

ARWatches includes several shaders and materials designed to experiment with occlusion and depth masking.

Important resources include:

CylinderMask.shader
CylinderMaskFixed.shader
DepthMaskFixed.shader

The occlusion system aims to make the virtual watch appear more naturally integrated with the user's wrist and the surrounding scene.

7. Multiple 3D Assets

The project contains a large collection of:

3D models;
prefabs;
materials;
textures;
shaders;
preview images;
Unity metadata files;
runtime resources.

This allows the application to support multiple watch designs while keeping the project organized.

Technologies
Technology	Purpose
Unity	Main development and 3D engine
C#	Application and interaction logic
Vuforia Engine	Augmented Reality functionality
Unity 3D	3D object management and rendering
Shaders	Occlusion and graphical effects
TextMesh Pro	Text rendering and UI elements
Git	Version control
GitHub	Source code hosting and project portfolio
Application Workflow

The general workflow of the application can be summarized as follows:

                ┌───────────────────────┐
                │     Launch Unity      │
                │      Application      │
                └───────────┬───────────┘
                            │
                            ▼
                ┌───────────────────────┐
                │   Initialize AR /     │
                │       Vuforia         │
                └───────────┬───────────┘
                            │
                            ▼
                ┌───────────────────────┐
                │   Detect AR Marker    │
                │      / Target         │
                └───────────┬───────────┘
                            │
                            ▼
                ┌───────────────────────┐
                │ Display Virtual Watch │
                │       Model           │
                └───────────┬───────────┘
                            │
                            ▼
                ┌───────────────────────┐
                │ Select / Manage Watch │
                │        Model          │
                └───────────┬───────────┘
                            │
                            ▼
                ┌───────────────────────┐
                │ Position Virtual Watch│
                │      on the Wrist     │
                └───────────┬───────────┘
                            │
                            ▼
                ┌───────────────────────┐
                │ Apply Occlusion and   │
                │      Rendering        │
                └───────────────────────┘
Augmented Reality

The AR functionality is based on Vuforia Engine integrated into Unity.

The project contains:

Assets/Resources/VuforiaConfiguration.asset

This configuration is used by the Unity project for the Vuforia environment.

The project also contains an AR marker:

Assets/Mko_Marker.jpg

The marker can be used during testing to trigger the AR content.

Watch Models

The project includes several watch models and variants.

Examples include:

Apple Watch Series 7
Apple Watch Series 8
Bausele White Oceanmoon Watch
Digital Watch
Hand Watch
Seiko Watch
Smart Watch KW-19
Wrist Watch

The project stores watch resources in several locations.

Main directories:

Assets/Watches/
Assets/Prefabs/
Assets/Resources/WatchPreviews/
Watch Prefabs

Several reusable Unity prefabs are included in the project.

Examples include:

Assets/Prefabs/

and:

Assets/Resources/WatchCard.prefab

Prefabs make it possible to reuse configured watch objects without rebuilding their components manually.

Watch Previews

Preview images are available in:

Assets/Resources/WatchPreviews/

These images are associated with the different watch models and can be used by the application's interface to present the available models.

Wrist Tracking and Positioning

The project contains specific scripts related to wrist positioning:

Assets/Wrist.cs
Assets/WristOcclusion.cs

The purpose of these components is to support the positioning and visual integration of the virtual watch around the wrist.

The wrist-related system is an important part of the project because a watch should not simply appear as a floating object in the scene. Its position should be consistent with the user's wrist and the surrounding visual context.

Occlusion System

One of the technical aspects of ARWatches is the use of occlusion and depth masking.

The project includes:

Assets/CylinderMask.shader
Assets/CylinderMaskFixed.shader
Assets/DepthMaskFixed.shader

Additional materials are available in:

Assets/Materials/

These resources are used to experiment with masking and depth-related rendering.

The objective is to improve the visual relationship between the virtual watch and the real wrist.

Project Structure

The main project structure is:

ARWatches/
│
├── Assets/
│   │
│   ├── Editor/
│   │   └── Migration/
│   │
│   ├── Materials/
│   │   ├── CylinderMask.mat
│   │   ├── CylinderMaskFixed.mat
│   │   └── ...
│   │
│   ├── Prefabs/
│   │   ├── Apple Watch prefabs
│   │   ├── Digital Watch.prefab
│   │   ├── Seiko Watch prefabs
│   │   ├── Smart Watch prefabs
│   │   └── ...
│   │
│   ├── Resources/
│   │   ├── VuforiaConfiguration.asset
│   │   ├── WatchCard.prefab
│   │   └── WatchPreviews/
│   │
│   ├── Scenes/
│   │   └── SampleScene.unity
│   │
│   ├── StreamingAssets/
│   │   └── Runtime resources
│   │
│   ├── TextMesh Pro/
│   │   └── Text and rendering resources
│   │
│   ├── Watches/
│   │   └── 3D watch assets
│   │
│   ├── scripts/
│   │   ├── Menu.cs
│   │   ├── WatchData.cs
│   │   └── WatchManager.cs
│   │
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
Main Scripts
Menu.cs

Location:

Assets/scripts/Menu.cs

This script manages menu-related functionality and application navigation.

WatchData.cs

Location:

Assets/scripts/WatchData.cs

This component is used to represent and organize information associated with the different watch models.

WatchManager.cs

Location:

Assets/scripts/WatchManager.cs

This script manages the watch models available within the application.

It is part of the main logic responsible for handling different watch objects.

Wrist.cs

Location:

Assets/Wrist.cs

This script is dedicated to wrist-related functionality and contributes to the positioning of the virtual watch.

WristOcclusion.cs

Location:

Assets/WristOcclusion.cs

This script is associated with the occlusion functionality used to improve the integration of the virtual watch with the wrist.

Assets and Resources

The project contains several categories of Unity resources.

Materials

Located in:

Assets/Materials/

These resources define the appearance and rendering properties of objects.

Prefabs

Located in:

Assets/Prefabs/

Prefabs contain reusable configured Unity objects.

Scenes

The main scene is:

Assets/Scenes/SampleScene.unity
StreamingAssets

The project contains runtime resources in:

Assets/StreamingAssets/

These resources are required by parts of the project and are included in the repository.

TextMesh Pro

The project includes TextMesh Pro resources:

Assets/TextMesh Pro/

These resources support text rendering and UI presentation.

Installation
Prerequisites

Before opening the project, make sure that the development environment includes:

Unity Hub;
a compatible Unity version;
Vuforia Engine support;
a camera for AR testing;
sufficient storage for the Unity project and 3D assets.
Checking the Unity Version

The Unity version associated with the project is defined in:

ProjectSettings/ProjectVersion.txt

It is recommended to use the Unity version specified by this file or a compatible version.

Clone the Repository

Clone the project using:

git clone https://github.com/naziha-goubaa/ar-watches.git

Navigate to the project:

cd ar-watches
Open the Project in Unity
Install Unity Hub.
Install the Unity version compatible with the project.
Open Unity Hub.
Select Add or Open.
Select the cloned ar-watches directory.
Wait for Unity to import the assets.
Open the main scene:
Assets/Scenes/SampleScene.unity
Running the Project

After opening the project:

Open the main scene.
Verify the Vuforia configuration.
Connect or enable a suitable camera.
Place the AR marker in front of the camera.
Start the scene using the Play button.
Test the detection and display of the virtual content.
Navigate through the available watch models.
Vuforia Configuration

The project contains a Vuforia configuration file:

Assets/Resources/VuforiaConfiguration.asset

Depending on the Vuforia configuration and development environment, additional setup may be required.

Before running the project on another machine, verify:

Vuforia integration;
AR camera configuration;
target/marker configuration;
required Vuforia settings;
platform compatibility.

Private credentials or license information should not be committed to a public repository.

AR Marker

The project includes the following marker:

Assets/Mko_Marker.jpg

For testing:

Display or print the marker.
Launch the Unity application.
Point the camera toward the marker.
Keep the marker clearly visible.
Wait for recognition.
Observe the virtual content.

Good lighting and a clear view of the marker can improve tracking conditions.

Demonstration

A demonstration video is included in the repository:

demo/Démo projet ARWatches.mp4

The video demonstrates the ARWatches application and its augmented reality functionality.

Technical Challenges

Developing an AR application with 3D content introduces several technical challenges.

Object positioning

Virtual objects must be positioned correctly relative to the real environment.

For a watch application, the positioning must also remain coherent with the wrist.

Tracking stability

AR tracking can be affected by:

lighting;
camera quality;
target visibility;
movement;
viewing angle;
distance from the target.
3D asset management

The project contains numerous 3D models, textures, materials and prefabs.

Managing these resources requires a clear project structure.

Rendering and performance

3D models, textures, shaders and AR processing can affect application performance.

Optimization is therefore important, especially for mobile deployment.

Occlusion

Making a virtual watch appear naturally integrated with the wrist requires appropriate depth and masking techniques.

The project explores this problem through custom shaders and wrist-related scripts.

Skills Developed

The project provides practical experience in several areas.

Unity Development
Unity Editor
Scene management
Prefabs
Materials
Textures
GameObjects
Asset organization
3D rendering
C# Programming
C# scripting
Object-oriented programming
Component-based architecture
Interaction logic
Data management
Unity scripting
Augmented Reality
Vuforia Engine
AR marker detection
Camera-based AR
Virtual object placement
AR interaction
Tracking concepts
3D Development
3D models
Materials
Textures
Prefabs
Shaders
Rendering
Occlusion
Software Engineering
Project organization
Git version control
GitHub repository management
Technical documentation
Asset management
Project Limitations

The project is primarily a practical and educational AR prototype.

Depending on the target platform and development environment, the following aspects may require additional configuration:

Vuforia setup;
camera configuration;
device compatibility;
Unity version compatibility;
performance optimization;
AR tracking conditions.

The exact behavior may also vary depending on the camera, device and lighting conditions.

Possible Improvements

Future versions could include:

User Experience
Improve the interface design.
Add smoother transitions between models.
Add watch categories.
Add a search or filtering system.
Add a favorites system.
Watch Customization
Change watch colors.
Change straps.
Change watch faces.
Customize materials.
Add additional smartwatch models.
Augmented Reality
Improve wrist positioning.
Improve tracking stability.
Improve occlusion.
Improve depth handling.
Support additional AR tracking techniques.
Performance
Optimize 3D models.
Compress textures.
Reduce unnecessary assets.
Optimize shaders.
Improve mobile performance.
Application Features
Add product information.
Add watch specifications.
Add a comparison system.
Add screenshots from the AR experience.
Add a virtual try-on workflow.
Add support for additional mobile platforms.
Git Workflow

The project is managed using Git.

The main branch is:

main

The repository is hosted on GitHub.

To retrieve the latest version:

git pull

To check the current status:

git status

To create a new change:

git add .
git commit -m "Describe the change"
git push
Repository

The complete project is available on GitHub:

https://github.com/naziha-goubaa/ar-watches

Project Information
Item	Information
Project	ARWatches
Domain	Augmented Reality
Application Type	3D AR Visualization
Engine	Unity
Programming Language	C#
AR Framework	Vuforia Engine
Main Content	3D Watch Models
Version Control	Git
Repository	GitHub
Author	Naziha Goubaa
Author
Naziha Goubaa

Computer Science / Software Engineering Student

GitHub:

https://github.com/naziha-goubaa

License and Third-Party Assets

This repository contains multiple 3D models, textures, materials, Unity resources and other assets.

Some assets may originate from third-party sources and may include their own license files.

For example, some watch model directories contain:

license.txt

Before redistributing, modifying or using individual third-party assets commercially, their respective licenses and usage conditions should be checked.

The project source code and third-party assets should therefore be considered separately when determining redistribution rights.

Acknowledgements

The project relies on technologies and resources from the Unity and Vuforia ecosystems.

Special consideration is given to the third-party 3D assets and resources included in the project. Their respective licenses should be respected.

Conclusion

ARWatches is a practical Augmented Reality project developed with Unity, C# and Vuforia Engine.

The project demonstrates how virtual 3D watch models can be integrated into an AR experience and positioned around the wrist.

It combines several technical areas:

Augmented Reality;
Vuforia Engine;
Unity development;
C# programming;
3D models;
prefabs;
materials and textures;
custom shaders;
wrist positioning;
occlusion;
interactive model management;
Git and GitHub.

The project represents practical experience in AR application development, interactive 3D development and Unity-based software engineering.
