using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

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