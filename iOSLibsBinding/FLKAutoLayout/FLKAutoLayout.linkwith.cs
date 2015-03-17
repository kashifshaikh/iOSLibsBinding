using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("FLKAutoLayout.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
