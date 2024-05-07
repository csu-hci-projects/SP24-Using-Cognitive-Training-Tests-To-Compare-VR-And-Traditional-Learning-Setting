# SP24-Using-Cognitive-Training-Tests-To-Compare-VR-And-Traditional-Learning-Setting

Overview of Project - Youtube Link:
https://youtu.be/61O-AFgparI 

Project Code & Experiment- Youtube Link:
https://youtu.be/6uuER0EpQzk

GitHub Link: https://github.com/csu-hci-projects/SP24-Using-Cognitive-Training-Tests-To-Compare-VR-And-Traditional-Learning-Setting

Below is a sample README file for your Unity VR project that uses the Oculus Integration (Deprecated) package. This README includes instructions on how to run and compile the project, as well as the resources needed.

---

# Unity VR Project - Oculus Integration

## Overview
This project is a Virtual Reality (VR) experience developed using Unity and the Oculus Integration (Deprecated) package. This document provides all necessary instructions to set up, compile, and run the project using Unity Editor version 2022.3.20f1.

## Prerequisites
Before you begin, ensure you have the following software and hardware:

- **Unity Editor 2022.3.20f1** - Download and install from [Unity Download Archive](https://unity3d.com/get-unity/download/archive).
- **Oculus Integration (Deprecated)** - Available from the Unity Asset Store. Note that while deprecated, this package is required for this project.
- **VR-Ready PC** - Ensure your PC meets the minimum requirements for VR development specified by Oculus.
- **Oculus VR Headset** - This project is designed for Oculus hardware.

## Setup Instructions

### 1. Installing Unity
Download and install Unity version 2022.3.20f1. During installation, make sure to include the following components:
- Windows Build Support (IL2CPP)
- Android Build Support (IL2CPP)

### 2. Clone or Download the Project
Clone this repository to your local machine or download it as a ZIP file and extract it.

### 3. Open the Project
Open Unity Hub, go to the 'Projects' tab, and click on 'Add'. Browse to the project folder you cloned or extracted and select it to open in Unity Editor.

### 4. Import Oculus Integration Package
Navigate to the Unity Asset Store and download the Oculus Integration (Deprecated) package. Import it into your project:
- Open the Asset Store inside Unity.
- Search for "Oculus Integration (Deprecated)" and download it.
- Import the package into your project when prompted.

## Compilation Instructions

### Building the Project
To build the project for Oculus:
1. Go to `File > Build Settings`.
2. Select the platform you are building for (Android for Oculus(Meta) Quest).
3. Click on `Player Settings` and ensure the XR Plugin Management is configured to use Oculus.
4. Return to the Build Settings window and click `Build`.
5. Choose a location to save the built application and wait for the build process to complete.

## Running the Project

### On PC
- Ensure your Oculus(Meta) VR headset is connected to your PC.
- Run the built application. The Unity Editor will detect the connected Oculus device and start displaying the VR environment.

## Resources Needed
- Unity Editor 2022.3.20f1
- Oculus Integration (Deprecated) package
- Oculus VR hardware (e.g., Oculus Quest 2)
- VR-Ready PC