# CENG 454 HW2 - Sky-High Prototype II: Threat Corridor 🛩️🚀

## Student Information
- **Full Name:** Mehmet Anil ULKU
- **Student ID:** 220441001
- **Course:** CENG 454 - Game Programming (Spring 2025-2026)
- **University:** Turkish Aeronautical Association University (UTAA)

## Project Overview
This project extends the HW1 aircraft prototype into a playable threat-corridor scenario. The pilot takes off from a runway, crosses a terrain map, enters hostile airspace, receives a HUD warning, survives a delayed ground-launched missile threat, escapes the zone, and lands safely at a landing strip.

## Gameplay Flow
1. **Takeoff** - Start on the runway and gain altitude
2. **Fly to Danger Zone** - Navigate toward the mountainous region
3. **HUD Warning** - "ENTERED A DANGER ZONE!" appears on screen
4. **Missile Launch** - After 5 seconds, a homing missile launches from the ground
5. **Escape** - Fly out of the danger zone to destroy the missile
6. **Landing** - Return to the landing strip to complete the mission

## Controls
| Key | Action |
|-----|--------|
| Space | Thrust / Accelerate |
| W/S (Vertical) | Pitch up/down |
| A/D (Horizontal) | Yaw left/right |
| Q/E | Roll left/right |

## Architecture
The project follows the **Single Responsibility Principle** with separate scripts for each system:

| Script | Responsibility |
|--------|---------------|
| `FlightController.cs` | Aircraft movement and physics |
| `FlightExamManager.cs` | Mission state tracking and HUD updates |
| `DangerZoneController.cs` | Zone entry/exit detection and missile countdown |
| `MissileLauncher.cs` | Missile instantiation at launch point |
| `MissileHoming.cs` | Missile pursuit behavior (rotation + forward movement) |
| `AircraftThreatHandler.cs` | Missile collision response and respawn |
| `TakeoffTrigger.cs` | Takeoff area detection |
| `LandingTrigger.cs` | Landing validation and mission completion |

## Git Workflow
- **Release v1.0** - HW1 baseline import
- `feature/terrain-runway` - Terrain, runway, landing area, danger zone setup
- `feature/danger-zone-warning` - HUD warning system and zone triggers
- `feature/missile-launcher` - Missile system, audio, and threat handler
- `feature/landing-mission-flow` - Takeoff/landing validation and mission completion

## Tools & Technologies
- **Engine:** Unity 6
- **Language:** C#
- **Version Control:** Git + GitHub + Git LFS
- **UI:** TextMeshPro for HUD elements
- **Audio:** Freesound community audio clips

## How to Run
1. Clone the repository
2. Open `UnityProject` folder with Unity 6
3. Open `Assets/Scenes/SampleScene.unity`
4. Press Play

## Assets Used
- CruiseFighter aircraft model (Gamer Squid)
- Missiles Pack (3D models only)
- Low Poly Missile Launcher (3D model only)
- FastSky (skybox)
- Procedural Terrain Painter
- Generic Aircraft Models (runway)
- Freesound Community (audio clips)
