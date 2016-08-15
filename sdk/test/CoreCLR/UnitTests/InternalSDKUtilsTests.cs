using System;

using Xunit;
using Amazon.Util.Internal;
using System.Runtime.InteropServices;

namespace AWSSDK_CoreCLR.UnitTests
{
    public class InternalSDKUtilsTests
    {
        [Fact]
        public void RuntimeInformationTest()
        {
            var runtime = InternalSDKUtils.DetermineRuntime();
            Assert.NotEqual("Unknown", runtime);
            Assert.False(runtime.Contains(" "));

            var framework = InternalSDKUtils.DetermineFramework();
            Assert.NotEqual("Unknown", framework);
            Assert.False(framework.Contains(" "));

            var os = InternalSDKUtils.DetermineOS();
            Assert.NotEqual("Unknown", os);
            Assert.False(os.Contains(" "));

            var osver = InternalSDKUtils.DetermineOSVersion();
            Assert.NotEqual("Unknown", osver);
            Assert.False(osver.Contains(" "));

            var platform = InternalSDKUtils.PlatformUserAgent();
            Assert.NotEqual("Unknown", platform);
            Assert.False(platform.Contains(" "));

            Assert.Equal(platform, os + "_" + osver);
            Assert.Equal(RuntimeInformation.FrameworkDescription.Trim().Replace(' ', '_'), runtime + "_" + framework);
        }

        [Fact]
        public void GetValidSubstringOrUnknownTest()
        {
            Assert.Equal("Unknown", InternalSDKUtils.GetValidSubstringOrUnknown("", 0, 0));
            Assert.Equal("Unknown", InternalSDKUtils.GetValidSubstringOrUnknown("a b c", -1, 0));
            Assert.Equal("Unknown", InternalSDKUtils.GetValidSubstringOrUnknown("a b c", 0, 10));
            Assert.Equal("a_b_c", InternalSDKUtils.GetValidSubstringOrUnknown("a b c", 0, 5));
        }
    }
}