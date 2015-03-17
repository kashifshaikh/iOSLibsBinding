using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("DejalActivityView.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
