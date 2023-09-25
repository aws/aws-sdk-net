using Amazon.Util.Internal;
using Amazon.Util;
using Xunit;
using Amazon.Runtime.Internal.Settings;
using System.Runtime.InteropServices;
using System.Collections.Generic;

#if NET8_0_OR_GREATER
using System.Text.Json;
#endif

namespace UnitTests.NetStandard
{
    public class JsonSerializationTests
    {
        [Fact]
        public void DeserializeCaseInsensitive()
        {
            var obj = JsonSerializerHelper.Deserialize<IAMInstanceProfileMetadata>("{\"Code\": \"foo\"}", EC2InstanceMetadataJsonSerializerContexts.Default);
            Assert.Equal("foo", obj.Code);
        }

        [Fact]
        public void RoundTripDictionary()
        {
            var original = new Dictionary<string, string>();
            original["foo"] = "bar";
            original["North"] = "South";

            var json = JsonSerializerHelper.Serialize<Dictionary<string, string>>(original, DictionaryStringStringJsonSerializerContexts.Default);
            var newDictionary = JsonSerializerHelper.Deserialize<Dictionary<string, string>>(json, DictionaryStringStringJsonSerializerContexts.Default);

            Assert.Equal(original, newDictionary);
        }

        [Fact]
        public void PrettyPrintJson()
        {
            var original = new Dictionary<string, string>();
            original["foo"] = "bar";
            original["North"] = "South";

            var json = JsonSerializerHelper.Serialize<Dictionary<string, string>>(original, DictionaryStringStringJsonSerializerContexts.Default);
            Assert.DoesNotContain("\n", json);

            json = JsonSerializerHelper.Serialize<Dictionary<string, string>>(original, new DictionaryStringStringJsonSerializerContexts(new JsonSerializerOptions {WriteIndented = true }));
            Assert.Contains("\n", json);
        }

        [Fact]
        public void PersistenceManagerConfirmSwitchToDictionaryStringString()
        {
            // The PersistenceManager is only valid for Windows storing information in the AppData folder
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return;

            var settings = new SettingsCollection();
            var oc1 = settings.NewObjectSettings("oc1");
            oc1["foo"] = "bar";

            var oc2 = settings.NewObjectSettings("Oc2");
            oc2["North"] = "South";

            PersistenceManager.Instance.SaveSettings("sdk-unit-test", settings);

            var loadSettings = PersistenceManager.Instance.GetSettings("sdk-unit-test");
            Assert.Equal("bar", loadSettings["oc1"]["foo"]);
            Assert.Equal("South", loadSettings["Oc2"]["North"]);
        }
    }
}
