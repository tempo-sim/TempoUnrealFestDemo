# TempoUnrealFestDemo
Tempo's demo for UnrealFest 2024

Tempo is a free and open-source suite of Unreal Engine plugins for simulation.
We built this demo to give you a preview of what Tempo can do.

The demo is a simple city driving simulator in a real environment (Denver, CO).
It relies on a number of third-party plugins and data sources including:
- Cesium for Unreal plugin's streaming 3D map tiles
- Aerometrex's high-quality Denver model
- Epic's CitySample vehicles content pack

Basic controls:
- W,A,S,D,Q,E and click/drag: Control the spectator
- Tab: Attach the spectator to a vehicle
- Scroll: While attached, control distance to the vehicle
- Esc: Detach the spectator from a vehicle
- Space: Pause and play
- Enter: Step time

The demo also includes Tempo's Python API. You must have Python (>=3.9) installed to use it.
- In the same folder as this README file there should be two folders: `tempo_py` and `example_clients`.
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
tg.set_time_of_day(hour=8)
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

We hope you enjoy the demo and are inspired to build your own simulator!
Interested in learning more about Tempo? Visit us:

[temposimulation.com](http://temposimulation.com)

[github.com/tempo-sim/Tempo](http://github.com/tempo-sim/Tempo)