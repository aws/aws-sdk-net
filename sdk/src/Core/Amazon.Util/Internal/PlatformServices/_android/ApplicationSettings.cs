using System;

using Android.App;
using Android.Content;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationSettings : IApplicationSettings
    {
        private const string SETTINGS_STORE_NAME = "AWSSDK_SETTINGS";

        // Application settings mode are curently not supported on android
        public void SetValue(string key, string value, ApplicationSettingsMode mode)
        {
            var sharedPreferences = Application.Context.GetSharedPreferences(SETTINGS_STORE_NAME, FileCreationMode.Private);
            var sharedPreferencesEditor = sharedPreferences.Edit();
            sharedPreferencesEditor.PutString(key, value);
            sharedPreferencesEditor.Commit();
        }

        public string GetValue(string key, ApplicationSettingsMode mode)
        {
            var sharedPreferences = Application.Context.GetSharedPreferences(SETTINGS_STORE_NAME, FileCreationMode.Private);
            return sharedPreferences.GetString(key, string.Empty);
        }

        public void RemoveValue(string key, ApplicationSettingsMode mode)
        {
            var sharedPreferences = Application.Context.GetSharedPreferences(SETTINGS_STORE_NAME, FileCreationMode.Private);
            var sharedPreferencesEditor = sharedPreferences.Edit();
            sharedPreferencesEditor.Remove(key);
            sharedPreferencesEditor.Commit();
        }

    }
}