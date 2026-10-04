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