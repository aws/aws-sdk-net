#if NETFRAMEWORK
using Amazon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime.CSM
{
    [TestClass]
    public class CSMConfigTests
    {
        [TestInitialize]
        public void Setup()
        {
            AWSConfigs.CSMConfig.CSMEnabled = true;
        }

        [TestCleanup]
        public void Cleanup()
        {
            AWSConfigs.CSMConfig.CSMEnabled = null;
        }

        [TestMethod]
        [TestCategory("CSM")]
        public void CSMCanBeEnabledViaConfig()
        {
            Assert.IsTrue(AWSConfigs.CSMConfig.CSMEnabled.HasValue);
            Assert.IsTrue(AWSConfigs.CSMConfig.CSMEnabled.Value);
        }

        [TestMethod]
        [TestCategory("CSM")]
        public void CSMEnabledCanBeOverridden()
        {
            Assert.IsTrue(AWSConfigs.CSMConfig.CSMEnabled.Value);
            AWSConfigs.CSMConfig.CSMEnabled = false;
            Assert.IsFalse(AWSConfigs.CSMConfig.CSMEnabled.Value);
        }
    }
}
#endif
