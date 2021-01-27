using Amazon;
using Amazon.Internal;
using Json.LitJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RegionEndpointTests
    {
        private static class SampleValues
        {
            public const string SampleRegionDisplayName = "US west too";
            public const string SampleHostName = "host-name";
            public const string SampleAuthRegion = "auth-region";
            public const string SampleDnsSuffix = "dns-suffix";
        }

        private const string TestRegionSystemName = "us-west-2";
        private const string TestService = "lambda";

        [TestCleanup]
        public void Cleanup()
        {
            // Reset the RegionEndpoint static maps so that other tests don't use
            // sample data from this test.
            RegionEndpoint.Reload(null);
        }

        [TestMethod]
        public void Reload()
        {
            var initialRegionEndpoint = RegionEndpoint.USWest2;
            var initialTestServiceEndpoint = initialRegionEndpoint.GetEndpointForService(TestService);

            // Get and Mutate the manifest
            var rootData = GetEndpointsManifest();
            ApplySampleValuesToManifest(rootData);

            // Reload with this mutated manifest
            var json = rootData.ToJson();
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                RegionEndpoint.Reload(ms);
            }

            // Verify the SDK resolves regions and endpoints against the mutated data
            var regionEndpoint = RegionEndpoint.GetBySystemName(TestRegionSystemName);
            Assert.IsNotNull(regionEndpoint);
            Assert.AreEqual(SampleValues.SampleRegionDisplayName, regionEndpoint.DisplayName);
            Assert.AreEqual(SampleValues.SampleDnsSuffix, regionEndpoint.PartitionDnsSuffix);
            var endpoint = regionEndpoint.GetEndpointForService(TestService);
            Assert.IsNotNull(endpoint);
            Assert.AreEqual(SampleValues.SampleAuthRegion, endpoint.AuthRegion);
            Assert.AreEqual(SampleValues.SampleHostName, endpoint.Hostname);

            // Verify the initial region-endpoint is unaffected
            Assert.AreNotEqual(initialRegionEndpoint.DisplayName, regionEndpoint.DisplayName);
            Assert.AreNotEqual(initialTestServiceEndpoint.AuthRegion, endpoint.AuthRegion);
            Assert.AreNotEqual(initialTestServiceEndpoint.Hostname, endpoint.Hostname);
        }

        private JsonData GetEndpointsManifest()
        {
            using (var stream = GetStream())
            using (var reader = new StreamReader(stream))
            {
                return JsonMapper.ToObject(reader);
            }
        }

        private Stream GetStream()
        {
            // Load endpoints.json from AWSSDK.Core
            var assembly = typeof(RegionEndpointProviderV3).Assembly;
            // The resource may be called Amazon.endpoints.json or Core.endpoints.json
            var resourceName = assembly.GetManifestResourceNames().Single(r => r.EndsWith(".endpoints.json"));
            return assembly.GetManifestResourceStream(resourceName);
        }

        private JsonData GetAwsPartition(JsonData rootData)
        {
            foreach (JsonData jsonData in rootData["partitions"])
            {
                if (jsonData["partition"].ToString() == "aws")
                {
                    return jsonData;
                }
            }

            return null;
        }

        /// <summary>
        /// Takes endpoints.json contents, and modifies them with sample values
        /// </summary>
        private void ApplySampleValuesToManifest(JsonData rootData)
        {
            // Change things that help us verify that the SDK is reloading the manifest contents.
            // In this case, we'll change things about the Oregon region, and its lambda service endpoints.
            var awsPartition = GetAwsPartition(rootData);
            awsPartition["dnsSuffix"] = SampleValues.SampleDnsSuffix;
            awsPartition["regions"][TestRegionSystemName]["description"] = SampleValues.SampleRegionDisplayName;

            var service = awsPartition["services"][TestService]["endpoints"][TestRegionSystemName];
            service["hostname"] = SampleValues.SampleHostName;
            service["credentialScope"] = new JsonData { ["region"] = SampleValues.SampleAuthRegion };
        }
    }
}