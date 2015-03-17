using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("PureLayout.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
