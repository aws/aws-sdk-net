using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.Runtime.CSM
{
    [TestClass]
    public class CSMEnvironmentVariableFallbackTests
    {
        CSMFallbackConfigChain CSMFallbackConfigChain { get; set; }

        [TestInitialize]
        public void Setup()
        {
            CSMFallbackConfigChain = new CSMFallbackConfigChain();
        }

        [TestMethod]
        [TestCategory("CSM")]
        [TestCategory("EnvironmentVariable")]
        [TestCategory("Valid")]
        public void EnvDefaultValues()
        {
            var environment = new Mock<IEnvironmentVariableRetriever>();
            var environmentDict = new Dictionary<string, string>()
            {
                { "AWS_CSM_ENABLED", "true"},
                { "AWS_CSM_PORT", string.Empty },
                { "AWS_CSM_CLIENT_ID", string.Empty }
            };

            environment.Setup(foo => foo.GetEnvironmentVariable(It.IsAny<string>())).Returns<string>(key => environmentDict[key]);

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new EnvironmentVariableCSMConfigs(environment.Object, CSMFallbackConfigChain) };

            var CSMConfiguration = CSMFallbackConfigChain.GetCSMConfig();
            Assert.IsTrue(CSMConfiguration.Enabled);
            Assert.AreEqual(31000, CSMConfiguration.Port);
            Assert.AreEqual(string.Empty, CSMConfiguration.ClientId);
            Assert.AreEqual("environment variable", CSMFallbackConfigChain.ConfigSource);
        }

        [TestMethod]
        [TestCategory("CSM")]
        [TestCategory("EnvironmentVariable")]
        [TestCategory("Valid")]
        public void EnvSetValues()
        {
            var environment = new Mock<IEnvironmentVariableRetriever>();
            var environmentDict = new Dictionary<string, string>()
            {
                { "AWS_CSM_ENABLED", "true"},
                { "AWS_CSM_PORT", "90" },
                { "AWS_CSM_CLIENT_ID", "Test" }
            };

            environment.Setup(foo => foo.GetEnvironmentVariable(It.IsAny<string>())).Returns<string>(key => environmentDict[key]);

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new EnvironmentVariableCSMConfigs(environment.Object, CSMFallbackConfigChain) };

            var CSMConfiguration = CSMFallbackConfigChain.GetCSMConfig();
            Assert.IsTrue(CSMConfiguration.Enabled);
            Assert.AreEqual(90, CSMConfiguration.Port);
            Assert.AreEqual("Test", CSMConfiguration.ClientId);
            Assert.AreEqual("environment variable", CSMFallbackConfigChain.ConfigSource);
        }

        [TestMethod]
        [TestCategory("CSM")]
        [TestCategory("EnvironmentVariable")]
        [TestCategory("Invalid")]
        public void EnvInValidEnabledValue()
        {
            var environment = new Mock<IEnvironmentVariableRetriever>();
            var environmentDict = new Dictionary<string, string>()
            {
                { "AWS_CSM_ENABLED", "foo"},
                { "AWS_CSM_PORT", "90" },
                { "AWS_CSM_CLIENT_ID", "Test" }
            };
            environment.Setup(foo => foo.GetEnvironmentVariable(It.IsAny<string>())).Returns<string>(key => environmentDict[key]);

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new EnvironmentVariableCSMConfigs(environment.Object, CSMFallbackConfigChain) };

            Assert.IsFalse(CSMFallbackConfigChain.GetCSMConfig().Enabled);
        }

        [TestMethod]
        [TestCategory("CSM")]
        [TestCategory("EnvironmentVariable")]
        [TestCategory("Invalid")]
        public void EnvInValidPortValue()
        {
            var environment = new Mock<IEnvironmentVariableRetriever>();
            var environmentDict = new Dictionary<string, string>()
            {
                { "AWS_CSM_ENABLED", "true"},
                { "AWS_CSM_PORT", "foo" },
                { "AWS_CSM_CLIENT_ID", "Test" }
            };
            environment.Setup(foo => foo.GetEnvironmentVariable(It.IsAny<string>())).Returns<string>(key => environmentDict[key]);

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new EnvironmentVariableCSMConfigs(environment.Object, CSMFallbackConfigChain) };

            var csmConfig = CSMFallbackConfigChain.GetCSMConfig();
            Assert.IsTrue(csmConfig.Enabled);
            Assert.AreEqual(31000, csmConfig.Port);
        }
    }
}
