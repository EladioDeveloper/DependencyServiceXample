﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependencyService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(DependencyService.Droid.Services.DeviceOrientationService))]
namespace DependencyService.Droid.Services
{
    class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 ||
                orientation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}