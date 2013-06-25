using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libAQGridView.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]