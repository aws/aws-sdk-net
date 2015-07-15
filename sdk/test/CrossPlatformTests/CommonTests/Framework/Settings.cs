using Amazon;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CommonTests.Framework
{
    public static class Settings
    {
        public static AWSCredentials Credentials { get; private set; }
        public static RegionEndpoint RegionEndpoint { get; private set; }
        public static string ResultsBucket { get; private set; }
        public static string ResultsTopic { get; private set; }

        private const string DefaultRegion = "us-west-2";

        static Settings()
        {
            LoadSettings();
        }

        private static void SetDefaults()
        {
            Credentials = new AnonymousAWSCredentials();
            RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(DefaultRegion);
        }
        private static void LoadSettings(string settingsResourcePartialName = "settings.json")
        {
            SetDefaults();

            var storedSettings = GetStoredSettings(settingsResourcePartialName);
            if (storedSettings == null)
                return;

            try
            {
                var ic = new ImmutableCredentials(storedSettings.AccessKeyId, storedSettings.SecretAccessKey, storedSettings.SessionToken);
                Credentials = new StoredCredentials(ic);
            }
            catch(Exception e)
            {
                Console.WriteError("Unable to parse get credentials from settings file, defaulting to anonymous credentials. Exception: {0}", e.ToString());
                Credentials = new AnonymousAWSCredentials();
            }

            try
            {
                RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(storedSettings.RegionEndpoint);
            }
            catch(Exception e)
            {
                Console.WriteError("Unable to parse RegionEndpoint from settings file, defaulting to {0}. Exception: {1}", DefaultRegion, e.ToString());
                RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(DefaultRegion);
            }
            ResultsBucket = storedSettings.ResultsBucket;
            ResultsTopic = storedSettings.ResultsTopic;
        }

        private static StoredSettings GetStoredSettings(string settingsResourcePartialName)
        {
            StoredSettings storedSettings;
            try
            {
                var settingsStream = UtilityMethods.GetResourceStream(settingsResourcePartialName);
                string json;
                using (var reader = new StreamReader(settingsStream))
                {
                    json = reader.ReadToEnd();
                }
                storedSettings = ThirdParty.Json.LitJson.JsonMapper.ToObject<StoredSettings>(json);
            }
            catch(Exception e)
            {
                Console.WriteError("Unable to load settings file. Exception: {0}", e.ToString());
                storedSettings = null;
            }
            return storedSettings;
        }

        private class StoredCredentials : AWSCredentials
        {
            private ImmutableCredentials credentials;

            public StoredCredentials(ImmutableCredentials ic)
            {
                credentials = ic;
            }

            public override ImmutableCredentials GetCredentials()
            {
 	            return credentials.Copy();
            }
        }

        private class StoredSettings
        {
            public string AccessKeyId { get; set; }
            public string SecretAccessKey { get; set; }
            public string SessionToken { get; set; }

            public string RegionEndpoint { get; set; }

            public string ResultsBucket { get; set; }
            public string ResultsTopic { get; set; }
        }
    }
}
