#if !NETFRAMEWORK
using Amazon.Util.Internal;
using Amazon.Util;
using Amazon.Runtime.Internal.Settings;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#if NET8_0_OR_GREATER
using System.Text.Json;
#endif

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class JsonSerializationTests
    {
        [TestMethod]
        public void DeserializeCaseInsensitive()
        {
            var obj = JsonSerializerHelper.Deserialize<IAMInstanceProfileMetadata>("{\"Code\": \"foo\"}", EC2InstanceMetadataJsonSerializerContexts.Default);
            Assert.AreEqual("foo", obj.Code);
        }

        [TestMethod]
        public void RoundTripDictionary()
        {
            var original = new Dictionary<string, string>();
            original["foo"] = "bar";
            original["North"] = "South";

            var json = JsonSerializerHelper.Serialize<Dictionary<string, string>>(original, DictionaryStringStringJsonSerializerContexts.Default);
            var newDictionary = JsonSerializerHelper.Deserialize<Dictionary<string, string>>(json, DictionaryStringStringJsonSerializerContexts.Default);

            Assert.AreEqual(original.Count, newDictionary.Count);
            foreach (var kvp in original)
                Assert.AreEqual(kvp.Value, newDictionary[kvp.Key]);
        }

        [TestMethod]
        public void PrettyPrintJson()
        {
            var original = new Dictionary<string, string>();
            original["foo"] = "bar";
            original["North"] = "South";

            var json = JsonSerializerHelper.Serialize<Dictionary<string, string>>(original, DictionaryStringStringJsonSerializerContexts.Default);
            Assert.IsFalse(json.Contains("\n"));

            json = JsonSerializerHelper.Serialize<Dictionary<string, string>>(original, new DictionaryStringStringJsonSerializerContexts(new JsonSerializerOptions { WriteIndented = true }));
            Assert.IsTrue(json.Contains("\n"));
        }

        [TestMethod]
        public void PersistenceManagerConfirmSwitchToDictionaryStringString()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return;

            var settings = new SettingsCollection();
            var oc1 = settings.NewObjectSettings("oc1");
            oc1["foo"] = "bar";

            var oc2 = settings.NewObjectSettings("Oc2");
            oc2["North"] = "South";

            PersistenceManager.Instance.SaveSettings("sdk-unit-test", settings);

            var loadSettings = PersistenceManager.Instance.GetSettings("sdk-unit-test");
            Assert.AreEqual("bar", loadSettings["oc1"]["foo"]);
            Assert.AreEqual("South", loadSettings["Oc2"]["North"]);
        }
    }
}
#endif
