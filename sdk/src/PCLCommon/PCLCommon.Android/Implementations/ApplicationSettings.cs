using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Amazon.Common
{
    public class ApplicationSettings : IApplicationSettings
    {
        public void SetValue(string key, string value, ApplicationSettingsMode mode)
        {
            throw new NotImplementedException();
        }

        public string GetValue(string key, ApplicationSettingsMode mode)
        {
            throw new NotImplementedException();
        }
    }
}