using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Util;
using System.Reflection;
using Amazon.Util.Internal;
using System;

namespace AWSSDK.UnitTests.Custom.Custom.Util
{
    [TestClass]
    public class InternalSDKUtilsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestValidateAndTranformUserAgent()
        {
            var transformedString = InternalSDKUtils.ReplaceInvalidUserAgentCharacters(
                "aws-sdk-dotnet-45 md/a)s-sdk-dotnet-core#3.7.202.18 ((((A/2.0 OS/Win32NT#10.0.22000.0 lang/.NET_Runtime#4.0 md/.NET_Framework#4.0"
                );

            var expectedString =
                "aws-sdk-dotnet-45 md/a-s-sdk-dotnet-core#3.7.202.18 ----A/2.0 OS/Win32NT#10.0.22000.0 lang/.NET_Runtime#4.0 md/.NET_Framework#4.0";
            Assert.AreEqual(expectedString, transformedString);
        }
    }
}
