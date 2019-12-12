using System;

using Xunit;
using Amazon.Util.Internal;
using System.Runtime.InteropServices;

namespace AWSSDK_NetStandard.UnitTests
{
    public class InternalSDKUtilsTests
    {
        [Fact]
        public void RuntimeInformationTest()
        {
            var framework = InternalSDKUtils.DetermineFramework();
            Assert.NotEqual("Unknown", framework);
            Assert.False(framework.Contains(" "));

            var os = InternalSDKUtils.DetermineOS();
            Assert.NotEqual("Unknown", os);
            Assert.False(os.Contains(" "));

            var platform = InternalSDKUtils.PlatformUserAgent();
            Assert.NotEqual("Unknown", platform);
            Assert.False(platform.Contains(" "));
        }
    }
}