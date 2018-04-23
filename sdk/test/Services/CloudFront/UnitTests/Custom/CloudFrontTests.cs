using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudFront;
using Json.LitJson;
using System.IO;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class CloudFrontTests
    {
        /// <summary>
        /// This test verifies if the AssemblyVersionOverride is set for CloudFront in _sdk-versions.json
        /// and it matches the DLL's assembly version.
        /// This test can be removed when the SDK version is bumped to 3.4.x.
        /// </summary>
        [TestMethod]
        [TestCategory("CloudFront")]
        public void ValidateCloudFrontAssemblyVersion()
        {
            string repoRoot = Directory.GetCurrentDirectory();
            do
            {
                if (Directory.Exists(Path.Combine(repoRoot, "generator")))
                {
                    break;
                }

                var directoryInfo = Directory.GetParent(repoRoot);
                repoRoot = directoryInfo != null ? directoryInfo.FullName : null;
            } while (repoRoot != null);

            string versionsFilePath = Path.Combine(repoRoot, "generator", "ServiceModels", "_sdk-versions.json");
            var content = File.ReadAllText(versionsFilePath);
            var metadata = JsonMapper.ToObject(File.ReadAllText(versionsFilePath));

            var cloudFrontVersion = metadata["ServiceVersions"]["CloudFront"];
            if (cloudFrontVersion["AssemblyVersionOverride"] != null)
            {
                var manifestAssemblyVersion = new Version(cloudFrontVersion["AssemblyVersionOverride"].ToString());

                var assemblyVersion = typeof(AmazonCloudFrontClient).Assembly.GetName().Version;

                Assert.AreEqual(manifestAssemblyVersion, assemblyVersion);
            }
            else
            {
                Assert.Fail(@"Attribute AssemblyVersionOverride is missing for CloudFront in generator\ServiceModels\_sdk-versions.json.");
            }
        }

        /// <summary>
        /// Test to verify fix for misconfigured AmazonCloudFrontCookieSigner.Protocols flags enum.
        /// </summary>
        [TestMethod]
        [TestCategory("CloudFront")]
        public void TestProtocolEnum()
        {
            var http = AmazonCloudFrontCookieSigner.Protocols.Http;
            var https = AmazonCloudFrontCookieSigner.Protocols.Https;
            var httpAndHttps = AmazonCloudFrontCookieSigner.Protocols.Http | AmazonCloudFrontCookieSigner.Protocols.Https;

            Assert.IsTrue(Evaluate(httpAndHttps));
            Assert.IsFalse(Evaluate(http));
            Assert.IsFalse(Evaluate(https));
        }

        private static bool Evaluate(AmazonCloudFrontCookieSigner.Protocols protocol)
        {
            return protocol ==
                (AmazonCloudFrontCookieSigner.Protocols.Http | AmazonCloudFrontCookieSigner.Protocols.Https);
        }
    }
}