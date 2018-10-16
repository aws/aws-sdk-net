using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Xunit;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using System.Diagnostics;
using Amazon;
using Amazon.Runtime.CredentialManagement;

namespace AWSSDK.SharedProfileFallBackTests
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
        [Trait("Category", "SharedProfile")]
        [Trait("Category", "Valid")]
        public void SharedProfileDefaultValues()
        {
            var profileProperties = new Dictionary<string, string>
            {
                { "csm_enabled", "true"}
            };

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new ProfileCSMConfigs(CSMFallbackConfigChain, "Test", profileProperties) };
            var CSMConfiguration = CSMFallbackConfigChain.GetCSMConfig();
            Assert.True(CSMConfiguration.Enabled);
            Assert.Equal(31000, CSMConfiguration.Port);
            Assert.Equal(string.Empty, CSMConfiguration.ClientId);
            Assert.Equal("shared profile", CSMFallbackConfigChain.ConfigSource);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "SharedProfile")]
        [Trait("Category", "Valid")]
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
            Assert.True(CSMConfiguration.Enabled);
            Assert.Equal(90, CSMConfiguration.Port);
            Assert.Equal("Test", CSMConfiguration.ClientId);
            Assert.Equal("shared profile", CSMFallbackConfigChain.ConfigSource);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "SharedProfile")]
        [Trait("Category", "Invalid")]

        public void SharedProfileInValidEnabledValue()
        {
            var profileProperties = new Dictionary<string, string>
            {
                //Enabled flag should be a bool
                { "csm_enabled", "foo"},
                { "csm_clientid", "90" },
                { "csm_port", "Test" }
            };

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new ProfileCSMConfigs(CSMFallbackConfigChain, "Test", profileProperties) };
            Assert.False(CSMFallbackConfigChain.GetCSMConfig().Enabled);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "SharedProfile")]
        [Trait("Category", "Invalid")]

        public void EnvInValidPortValue()
        {
            var profileProperties = new Dictionary<string, string>
            {
                { "csm_enabled", "true"},
                //Port should be an int
                { "csm_clientid", "foo" },
                { "csm_port", "Test" }
            };

            CSMFallbackConfigChain.AllGenerators = new List<CSMFallbackConfigChain.ConfigurationSource>() { () => new ProfileCSMConfigs(CSMFallbackConfigChain, "Test", profileProperties) };
            var csmConfig = CSMFallbackConfigChain.GetCSMConfig();
            Assert.True(csmConfig.Enabled);
            Assert.Equal(31000, csmConfig.Port);
        }
    }
}
