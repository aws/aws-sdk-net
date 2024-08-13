using Amazon.AutoScaling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ServiceSpecificDefaultConfigurationTest
    {
        /// <summary>
        /// This test is meant to guard against regressions.
        /// In an early implementation, <see cref="AmazonAutoScalingDefaultConfiguration.GetAllConfigurations"/>
        /// had a static initializer race condition resulting in a collection containing only
        /// <c>null</c> items being returned.
        /// </summary>
        [TestMethod]
        public void AllConfigurationItemsAreNotNull()
        {
            var allConfiguration = AmazonAutoScalingDefaultConfiguration.GetAllConfigurations();

            foreach (var configuration in allConfiguration)
                Assert.IsNotNull(configuration);
        }
    }
}