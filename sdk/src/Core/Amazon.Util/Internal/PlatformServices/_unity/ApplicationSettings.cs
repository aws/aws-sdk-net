using Amazon.Util.Storage;
using Amazon.Util.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationSettings : IApplicationSettings
    {
        private KVStore kvStore;

        public ApplicationSettings()
        {
            kvStore = new PlayerPreferenceKVStore();
        }


        public void SetValue(string key, string value, ApplicationSettingsMode mode)
        {
            kvStore.Put(key, value);
        }

        public string GetValue(string key, ApplicationSettingsMode mode)
        {
            return kvStore.Get(key);
        }

        public void RemoveValue(string key, ApplicationSettingsMode mode)
        {
            kvStore.Clear(key);
        }
    }
}
