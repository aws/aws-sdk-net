using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Xunit;
using Moq;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using System.Diagnostics;
using Amazon;

namespace AWSSDK.EnvFallBackTests
{
    public class UnitTests
    {
        CSMFallbackConfigChain CSMFallbackConfigChain { get; set; }
        public UnitTests()
        {
            CSMFallbackConfigChain = new CSMFallbackConfigChain();
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "EnvironmentVariable")]
        [Trait("Category", "Valid")]
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
            Assert.True(CSMConfiguration.Enabled);
            Assert.Equal(31000, CSMConfiguration.Port);
            Assert.Equal(string.Empty, CSMConfiguration.ClientId);
            Assert.Equal("environment variable", CSMFallbackConfigChain.ConfigSource);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "EnvironmentVariable")]
        [Trait("Category", "Valid")]
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
            Assert.True(CSMConfiguration.Enabled);
            Assert.Equal(90, CSMConfiguration.Port);
            Assert.Equal("Test", CSMConfiguration.ClientId);
            Assert.Equal("environment variable", CSMFallbackConfigChain.ConfigSource);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "EnvironmentVariable")]
        [Trait("Category", "Invalid")]

        public void EnvInValidEnabledValue()
        {
            var environment = new Mock<IEnvironmentVariableRetriever>();
            var environmentDict = new Dictionary<string, string>()
            {
                //Enabled flag should be a bool
                { "AWS_CSM_ENABLED", "foo"},
                { "AWS_CSM_PORT", "90" },
                { "AWS_CSM_CLIENT_ID", "Test" }
            };
            environment.Setup(foo => foo.GetEnvironmentVariable(It.IsAny<string>())).Returns<string>(key => environmentDict[key]);

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new EnvironmentVariableCSMConfigs(environment.Object, CSMFallbackConfigChain) };

            Assert.False(CSMFallbackConfigChain.GetCSMConfig().Enabled);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "EnvironmentVariable")]
        [Trait("Category", "Invalid")]

        public void EnvInValidPortValue()
        {
            var environment = new Mock<IEnvironmentVariableRetriever>();
            var environmentDict = new Dictionary<string, string>()
            {
                { "AWS_CSM_ENABLED", "true"},
                //Port should be an int
                { "AWS_CSM_PORT", "foo" },
                { "AWS_CSM_CLIENT_ID", "Test" }
            };
            environment.Setup(foo => foo.GetEnvironmentVariable(It.IsAny<string>())).Returns<string>(key => environmentDict[key]);

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new EnvironmentVariableCSMConfigs(environment.Object, CSMFallbackConfigChain) };

            var csmConfig = CSMFallbackConfigChain.GetCSMConfig();
            Assert.True(csmConfig.Enabled);
            Assert.Equal(31000, csmConfig.Port);
        }
    }
}
