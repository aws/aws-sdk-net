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
            Assert.DoesNotContain(" ", framework);

            var os = InternalSDKUtils.DetermineOS();
            Assert.NotEqual("Unknown", os);
            Assert.DoesNotContain(" ", os);

            var platform = InternalSDKUtils.PlatformUserAgent();
            Assert.NotEqual("Unknown", platform);
            Assert.Contains("md/ARCH", platform);
        }
                
        [Theory]
        [InlineData(@"c:\a\b\c\test.txt", @"c:\a\b\c", true)]
        [InlineData(@"c:\a\b\c\..\test.txt", @"c:\a\b\c", false)]
        [InlineData(@"c:\a\b\c\..\ctest.txt", @"c:\a\b\c", false)]
        [InlineData(@"c:\a\b\c\test.txt", @"c:\a\b\c\", true)]
        [InlineData(@"c:\a\b\c\..\test.txt", @"c:\a\b\c\", false)]
        [InlineData(@"c:\a\b\c\..\ctest.txt", @"c:\a\b\c\", false)]
        [InlineData(@"/home/a/b/c/test.txt", @"/home/a/b/c", true)]
        [InlineData(@"/home/a/b/c/../test.txt", @"/home/a/b/c", false)]
        [InlineData(@"/home/a/b/c/../ctest.txt", @"/home/a/b/c", false)]
        [InlineData(@"/home/a/b/c/test.txt", @"/home/a/b/c/", true)]
        [InlineData(@"/home/a/b/c/../test.txt", @"/home/a/b/c/", false)]
        [InlineData(@"/home/a/b/c/../ctest.txt", @"/home/a/b/c/", false)]
        [InlineData(@"c:\a\b\c\\test.txt", @"c:\a\b\c", true)]
        [InlineData(@"c:/a/b/c/test.txt", @"c:\a\b\c", true)]
        [InlineData(@"c:/a/b/c/test.txt", @"c:/a/b/c", true)]
        [InlineData(@"c:\a\b\c\d\test.txt", @"c:\a\b\c", true)]
        [InlineData(@"c:\a\b\c\d/test.txt", @"c:\a\b\c", true)]
        public void IsFilePathRootedWithDirectoryPathTests(string filePath, string directoryPath, bool expectedResult)
        {
            var result = InternalSDKUtils.IsFilePathRootedWithDirectoryPath(filePath, directoryPath);
            Assert.Equal(expectedResult, result);
        }
    }
}