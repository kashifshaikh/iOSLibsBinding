using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("ORStackView.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
