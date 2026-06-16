using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.Runtime.CSM
{
    [TestClass]
    public class CSMSharedProfileFallbackTests
    {
        CSMFallbackConfigChain CSMFallbackConfigChain { get; set; }

        [TestInitialize]
        public void Setup()
        {
            CSMFallbackConfigChain = new CSMFallbackConfigChain();
        }

        [TestMethod]
        [TestCategory("CSM")]
        [TestCategory("SharedProfile")]
        [TestCategory("Valid")]
        public void SharedProfileDefaultValues()
        {
            var profileProperties = new Dictionary<string, string>
            {
                { "csm_enabled", "true"}
            };

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new ProfileCSMConfigs(CSMFallbackConfigChain, "Test", profileProperties) };
            var CSMConfiguration = CSMFallbackConfigChain.GetCSMConfig();
            Assert.IsTrue(CSMConfiguration.Enabled);
            Assert.AreEqual(31000, CSMConfiguration.Port);
            Assert.AreEqual(string.Empty, CSMConfiguration.ClientId);
            Assert.AreEqual("shared profile", CSMFallbackConfigChain.ConfigSource);
        }

        [TestMethod]
        [TestCategory("CSM")]
        [TestCategory("SharedProfile")]
        [TestCategory("Valid")]
        public void SharedProfileSetValues()
        {
            var profileProperties = new Dictionary<string, string>
            {
                { "csm_enabled", "true"},
                { "csm_clientid", "Test"},
                { "csm_port", "90"}
            };

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new ProfileCSMConfigs(CSMFallbackConfigChain, "Test", profileProperties) };
            var CSMConfiguration = CSMFallbackConfigChain.GetCSMConfig();
            Assert.IsTrue(CSMConfiguration.Enabled);
            Assert.AreEqual(90, CSMConfiguration.Port);
            Assert.AreEqual("Test", CSMConfiguration.ClientId);
            Assert.AreEqual("shared profile", CSMFallbackConfigChain.ConfigSource);
        }

        [TestMethod]
        [TestCategory("CSM")]
        [TestCategory("SharedProfile")]
        [TestCategory("Invalid")]
        public void SharedProfileInValidEnabledValue()
        {
            var profileProperties = new Dictionary<string, string>
            {
                { "csm_enabled", "foo"},
                { "csm_clientid", "90" },
                { "csm_port", "Test" }
            };

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new ProfileCSMConfigs(CSMFallbackConfigChain, "Test", profileProperties) };
            Assert.IsFalse(CSMFallbackConfigChain.GetCSMConfig().Enabled);
        }

        [TestMethod]
        [TestCategory("CSM")]
        [TestCategory("SharedProfile")]
        [TestCategory("Invalid")]
        public void SharedProfileInValidPortValue()
        {
            var profileProperties = new Dictionary<string, string>
            {
                { "csm_enabled", "true"},
                { "csm_clientid", "foo" },
                { "csm_port", "Test" }
            };

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new ProfileCSMConfigs(CSMFallbackConfigChain, "Test", profileProperties) };
            var csmConfig = CSMFallbackConfigChain.GetCSMConfig();
            Assert.IsTrue(csmConfig.Enabled);
            Assert.AreEqual(31000, csmConfig.Port);
        }
    }
}
