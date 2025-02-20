# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.0.15] - 2019-10-25

Update Hololens 2 remoting dlls to support standalone remoting

## [1.0.14] - 2019-08-26

Update Remoting dlls to allow for Hololens 2 remoting

## [1.0.13] - 2019-07-24

Fix .meta file issues for x64 remoting plugins
Move remoting plugins into x86_64 folder
Add Hololens 2 Remoting dll

## [1.0.12] - 2019-06-04

Remoting functionality is now compatible with HoloLens 2 devices using recent enough versions of Unity. Minimum compatible versions:
- 2019.3.0a6
- 2019.2.0b5
- 2019.1.6
- 2018.4.2

## [1.0.11] - 2019-05-30

Remove Documentation.meta file

## [1.0.10] - 2019-05-28

Fix AudioPluginMsHRTF.dll dependencies so that it can load on Hololens 2.

## [1.0.9] - 2019-04-18

Add AudioPluginMSHRTF.dll for arm64

## [1.0.8] - 2019-01-09

Update the PerceptionSimulationManager.dll for HoloLens simulation in the editor

## [1.0.7] - 2018-12-04

Update assembly definition to only include WSA references
Update License files

## [1.0.6] - 2018-10-23

Update the 64-bit PerceptionRemotingPlugin.dll 

## [1.0.5] - 2018-07-17

Update the PerceptionSimulationManager.dll and the simulation rooms for HoloLens simulation in the editor

## [1.0.4] - 2018-06-01

Add Editor to the Runtime assembly defintion so that it compiles in the Editor regardless of the selected platform.

## [1.0.3] - 2018-05-17

Remove HolographicStreamerDesktop.dll and update the .meta to point to HolographicStreamer.dll

## [1.0.2] - 2018-05-17

Update perception simulation library and add the holographic streamer library for UWP only.
Update Unity compatible versions to 2018.3 only

## [1.0.1] - 2018-05-03

Update runtime .asmdef to remove Editor as it's not necessary

## [1.0.0] - 2018-04-20

First official version of the package.
Update name to com.unity.xr.windowsmr.metro

## [0.0.4] - 2018-04-04

Update Runtime assembly definition file to only support the specific platforms that WindowsMR scripts should work on.

## [0.0.3] - 2018-03-29

Update Assembly definitions for Editor and Runtime

## [0.0.2] - 2018-03-28

Update package name to com.unity.windowsmr.metro

## [0.0.1] - 2018-01-10

### This is the first release of *Unity Windows Mixed Reality Package*.

*Short description of this release*
This is the first test iteration of the WindowsMR XR Package using the Package Manager process. This package is a replica of the builds.zip hosted at:
https://ono.unity3d.com/unity-extra/vr-hololens-external#trunk

We are bringing over all libraries from the builds.zip to be included and distributed through the package manager.