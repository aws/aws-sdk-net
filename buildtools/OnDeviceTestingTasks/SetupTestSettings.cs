using System;
using Microsoft.Build.Utilities;
using Newtonsoft.Json;
using System.IO;
using Amazon.Runtime;

namespace OnDeviceTestingTasks
{
    public class SetupTestSettings : Task
    {
        private bool _forceCreate = true;
        private string _region = "us-east-1";
        public string SettingsRelativePath { get; set; }
        public bool ForceCreate { get { return _forceCreate; } set { _forceCreate = value; } }
        public string Region { get { return _region; } set { _region = value; } }

        public override bool Execute()
        {
            if (string.IsNullOrEmpty(SettingsRelativePath))
            {
                throw new ArgumentNullException("SettingsRelativePath");
            }

            Log.LogMessage("Settings location '{0}' and ForceCreate '{1}'", SettingsRelativePath, ForceCreate);

            bool alreadyExists = File.Exists(SettingsRelativePath);
            if (alreadyExists && !ForceCreate)
            {
                Log.LogMessage("Settings file '{0}' already exists. Exiting.", SettingsRelativePath);
                return true;
            }
            if (alreadyExists)
            {
                Log.LogMessage("Removing existing settings file '{0}'.", SettingsRelativePath);
                File.Delete(SettingsRelativePath);
            }
            else
            {
                Log.LogMessage("No pre-existing settings file to remove.");
            }

            var credentials = FallbackCredentialsFactory.GetCredentials().GetCredentials();
            var settings = new Settings()
            {
                AccessKeyId = credentials.AccessKey,
                SecretAccessKey = credentials.SecretKey,
                AccountId = "",
                RegionEndpoint = Region
            };

            string json = JsonConvert.SerializeObject(settings);

            using (StreamWriter writer = File.CreateText(SettingsRelativePath))
            {
                Log.LogMessage("Writing settings to '{0}'.", SettingsRelativePath);
                writer.Write(json);
                writer.Flush();
            }
            return true;
        }
    }

    public class Settings
    {
        public string AccessKeyId;
        public string SecretAccessKey;
        public string RegionEndpoint;
        public string AccountId;
    }
}
