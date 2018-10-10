using Amazon;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ThirdParty.Json.LitJson;

namespace Amazon.Extensions.CognitoAuthentication.IntegrationTests
{
    public static class Settings
    {
        public static RegionEndpoint RegionEndpoint { get; private set; }
        public static StoredSettings storedSettings { get;  private set;}
        private const string DefaultRegion = "us-west-2";

        static Settings()
        {
            LoadSettings();
        }

        private static void SetDefaults()
        {
            RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(DefaultRegion);
        }

        private static void LoadSettings(string settingsResourcePartialName = "settings.json")
        {
            SetDefaults();

            storedSettings = GetStoredSettings(settingsResourcePartialName);
            if (storedSettings == null)
            {
                return;      
            }

            try
            {
                RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(storedSettings.RegionEndpointString);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unable to parse RegionEndpoint from settings file, defaulting to {0}. Exception: {1}", DefaultRegion, e.ToString());
                RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(DefaultRegion);
            }
        }

        public static Stream GetResourceStream(string resourceName)
        {
            Assembly assembly = typeof(Settings).GetTypeInfo().Assembly;
            var resource = FindResourceName(resourceName);
            Stream stream = assembly.GetManifestResourceStream(resource);
            return stream;
        }

        public static string FindResourceName(string partialName)
        {
            return FindResourceName(s => s.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0).Single();
        }

        public static IEnumerable<string> FindResourceName(Predicate<string> match)
        {
            Assembly assembly = typeof(Settings).GetTypeInfo().Assembly;
            var allResources = assembly.GetManifestResourceNames();
            foreach (var resource in allResources)
            {
                if (match(resource))
                    yield return resource;
            }
        }

        private static StoredSettings GetStoredSettings(string settingsResourcePartialName)
        {
            StoredSettings storedSettings;
            try
            {
                var settingsStream = GetResourceStream(settingsResourcePartialName);
                string json;
                using (var reader = new StreamReader(settingsStream))
                {
                    json = reader.ReadToEnd();
                }

                storedSettings = JsonMapper.ToObject<StoredSettings>(json);
            }
            catch (JsonException e)
            {
                Console.WriteLine("Unable to load settings file. JsonException: {0}", e.ToString());
                storedSettings = null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to load settings file. Exception: {0}", e.ToString());
                storedSettings = null;
            }
            return storedSettings;
        }

        public class StoredSettings
        {
            public string AccessKeyId { get; set; }
            public string SecretAccessKey { get; set; }
            public string RegionEndpointString { get; set; }
       }
    }
}
