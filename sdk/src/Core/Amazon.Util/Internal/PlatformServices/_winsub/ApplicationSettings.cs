
using System.Collections.Generic;
using System.Linq;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationSettings : IApplicationSettings
    {
        static Dictionary<string, string> _localSettings = new Dictionary<string, string>();
        static object _lock = new object();      

     public void SetValue(string key, string value, ApplicationSettingsMode mode)
        {
            lock (_lock)
            {
                _localSettings[key] = value;
            }         
        }

        public string GetValue(string key, ApplicationSettingsMode mode)
        {
            lock (_lock)
            {
                if (_localSettings.Keys.Contains(key))
                    return _localSettings[key];
                return null;
            }
        }
 
        public void RemoveValue(string key, ApplicationSettingsMode mode)
        {
            lock (_lock)
            {
                if (_localSettings.Keys.Contains(key))
                    _localSettings.Remove(key);
            }
        }
    }
}
