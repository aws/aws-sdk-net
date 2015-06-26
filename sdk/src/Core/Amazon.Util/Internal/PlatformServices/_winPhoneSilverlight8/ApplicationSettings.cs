using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationSettings : IApplicationSettings
    {
        public void SetValue(string key, string value, ApplicationSettingsMode mode)
        {
            switch (mode)
            {
                case ApplicationSettingsMode.Local:
                    Windows.Storage.ApplicationData.Current.LocalSettings.Values[key] = value;
                    break;
                case ApplicationSettingsMode.Roaming:
                    Windows.Storage.ApplicationData.Current.RoamingSettings.Values[key] = value;
                    break;
            }
        }

        public string GetValue(string key, ApplicationSettingsMode mode)
        {
            switch (mode)
            {
                case ApplicationSettingsMode.Local:
                    return Windows.Storage.ApplicationData.Current.LocalSettings.Values[key] as string;

                case ApplicationSettingsMode.Roaming:
                    return Windows.Storage.ApplicationData.Current.RoamingSettings.Values[key] as string;

                default:
                    return null;
            }
        }

        public void RemoveValue(string key, ApplicationSettingsMode mode)
        {
            switch (mode)
            {
                case ApplicationSettingsMode.Local:
                    Windows.Storage.ApplicationData.Current.LocalSettings.Values.Remove(key);
                    break;
                case ApplicationSettingsMode.Roaming:
                    Windows.Storage.ApplicationData.Current.RoamingSettings.Values.Remove(key);
                    break;
            }
        }
    }
}
