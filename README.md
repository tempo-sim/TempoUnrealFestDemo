# TempoUnrealFestDemo
Tempo's demo for UnrealFest 2024

[Tempo](https://github.com/tempo-sim/Tempo/) is a free and open-source suite of Unreal Engine plugins for simulation.

We built this demo to give you a preview of what Tempo can do. Tempo is designed to work for many types of simulations. This particular demo is a simple city driving simulator in a real location (Denver, CO).

Interested in learning more about Tempo? Visit us at [temposimulation.com](http://temposimulation.com)

## Pre-Built Releases
[You can find pre-built releases of the demo here](https://drive.google.com/drive/folders/1dqdmuhC0qEBxhdnEvxWI3AdmlIzjFbyg?usp=drive_link)
### Windows:
- Run `Windows/TempoUnrealFestDemo.exe`
### Linux:
- Run `Linux/TempoUnrealFestDemo.sh`
### Mac:
- Run `TempoUnrealFestDemo.app`
- The app is not notarized by Apple, so you must do the special [dance](https://support.apple.com/guide/mac-help/open-a-mac-app-from-an-unknown-developer-mh40616/15.0/mac/15.0) to open it

## About the Demo
The demo relies on a number of third-party plugins and data sources including:
- [Cesium for Unreal](https://cesium.com/platform/cesium-for-unreal/)'s streaming 3D map tiles
- [Aerometrex](https://aerometrex.com.au/)'s high-quality Denver model
- Epic's [City Sample Vehicles](https://www.unrealengine.com/marketplace/en-US/product/city-sample-vehicles?sessionInvalidated=true) content pack
Note that Tempo is not tied to any of the above directly. You can find examples of integrating Tempo with other content sources and plugins on our website. This project highlights its versatility, showing exactly what was required to adapt Tempo to this content.

## Basic Controls
- W,A,S,D,Q,E and click/drag: Control the spectator
- Tab: Attach the spectator to a vehicle
- Scroll: While attached, control distance to the vehicle
- Esc: Detach the spectator from a vehicle
- Space: Pause and play
- Enter: Step time # Only works in Fixed Step time mode

## Python API
The demo also includes Tempo's Python API. You must have Python (>=3.9) installed to use it.
- In the same folder as this README file there are two folders: `tempo_py` and `example_clients`.
- Make a Python virtual environment `python3 -m venv <your_venv>` and [activate](https://docs.python.org/3/library/venv.html#how-venvs-work) it.
- Run `pip install <path_to_tempo_py>`

Here are some fun things you can try:
- Try using the `tempo` package directly from the Python interpreter (run `python`):
```
import tempo.tempo_time as tt
tt.pause()
tt.play()
tt.step() # Only works in Fixed Step time mode

import tempo.tempo_geographic as tg
tg.set_time_of_day(hour=6) # Sunrise
tg.set_time_of_day(hour=12) # Noon
tg.set_time_of_day(hour=20) # Sunset
tg.set_time_of_day(hour=0) # Midnight
tg.set_day_cycle_relative_rate(10000) # Speed up day/night cycles
tg.set_day_cycle_relative_rate(1) # Back to normal
```
- Try streaming camera images with the provided `CameraPreview.py` client:
```
python <path_to_example_clients>/CameraPreview.py --name SpectatorCamera --type color
```
Try `depth` and `label` image types too. You can stream any combination of cameras and image types simultaneously. While the spectator is attached to a vehicle, you can also stream that vehicle's cameras (by name). Every vehicle has 8 cameras, named:
```
FollowCamera
FrontCenterCamera
FrontLeftCamera
FrontRightCamera
RearCenterCamera
RearRightCamera
RearLeftCamera
DriverCamera
```
- Try visualizing lane graph and traffic controller states with the provided `LaneGraphPreview.py` client:
```
python <path_to_example_clients>/LaneGraphPreview.py
```
## Thanks!
We hope you enjoy the demo and are inspired to build your own simulator!
