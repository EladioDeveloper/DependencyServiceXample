using DependencyService.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace DependencyService.ViewModels
{
    public class DependencyServiceViewModel
    {
        public DependencyServiceViewModel()
        {
            Orientation = Xamarin.Forms.DependencyService.Get<IDeviceOrientationService>().GetOrientation();
        }
        public DeviceOrientation Orientation { get; set; }
    }
}
