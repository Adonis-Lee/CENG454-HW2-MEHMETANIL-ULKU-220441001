# CENG 454 HW1 - Sky-High Prototype 🛩️

![Flight Environment](Gameplay.png)

## Overview
This repository contains the first homework project for **CENG 454**. It is a 3D flight simulation prototype developed in Unity, featuring 3-axis flight control, custom speed-based gravity physics, and a procedurally textured environment.

**Author:** Mehmet Anil ULKU ([@Adonis-Lee](https://github.com/Adonis-Lee))  
**Student ID:** 220441001

## Features ✨
- **3-Axis Flight Control:** Independent control over pitch, yaw, and roll using standard input axes and keys.
- **Custom Flight Physics:** Thrust mechanics with speed-based pseudo-gravity (the aircraft loses altitude when speed decreases).
- **3D Assets:** Includes the imported `CruiseFighter` model managed via Git LFS.
- **Environment:** Procedural terrain with grass and cliff textures, integrated with a FastSky URP compatible skybox.
- **Camera:** Dynamic aircraft tracking implemented via Cinemachine.

## Controls 🎮
| Action | Key Binding |
| :--- | :--- |
| **Pitch (Nose Up/Down)** | `W` / `S` or `Up` / `Down Arrows` |
| **Yaw (Turn Left/Right)** | `A` / `D` or `Left` / `Right Arrows` |
| **Roll (Bank Left/Right)** | `Q` / `E` |
| **Thrust (Accelerate)** | `Space` |

## Technical & Workflow Details ⚙️
- **Version Control:** Strict feature-branch workflow (e.g., `feat/pitch-yaw-control`).
- **Git LFS:** Configured for large binary assets (`.fbx`, `.png`, `.wav`).
- **Unity Settings:**
  - Version Control: `Visible Meta Files`
  - Asset Serialization: `Force Text`
- **Code Quality:** Continuous physics and input handling inside `Update()` strictly scaled with `Time.deltaTime` for frame-independent movement.

## Getting Started 🚀
1. Clone the repository:
   ```bash
   git clone [https://github.com/Adonis-Lee/CENG454-HW1-MEHMETANIL-ULKU-220441001.git](https://github.com/Adonis-Lee/CENG454-HW1-MEHMETANIL-ULKU-220441001.git)
