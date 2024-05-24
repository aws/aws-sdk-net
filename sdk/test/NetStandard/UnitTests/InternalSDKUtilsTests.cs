using System;
using Xunit;
using Amazon.Util.Internal;
using Moq;
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

        [Fact]
        public void DetermineFrameworkHandlesNonconventionalVersions()
        {
            // Arrange
            var mockWrapper = new Mock<IRuntimeInformationWrapper>();
            mockWrapper.Setup(w => w.FrameworkDescription).Returns("01-12-2024");
            InternalSDKUtils.SetRuntimeInformationWrapper(mockWrapper.Object);

            // Act
            var framework = InternalSDKUtils.DetermineFramework();

            // Assert
            Assert.Equal("Unknown md/framework-raw-version#01-12-2024", framework);
            InternalSDKUtils.ResetRuntimeInformationWrapper();
        }

        [Fact]
        public void DetermineFrameworkHandlesNonconventionalVersions2()
        {
            // Arrange
            var mockWrapper = new Mock<IRuntimeInformationWrapper>();
            mockWrapper.Setup(w => w.FrameworkDescription).Returns("-EX25+1");
            InternalSDKUtils.SetRuntimeInformationWrapper(mockWrapper.Object);

            // Act
            var framework = InternalSDKUtils.DetermineFramework();

            // Assert
            Assert.Equal("Unknown md/framework-raw-version#-EX25+1", framework);
            InternalSDKUtils.ResetRuntimeInformationWrapper();
        }

        [Fact]
        public void DetermineFrameworkHandlesConventionalVersion()
        {
            // Arrange
            var mockWrapper = new Mock<IRuntimeInformationWrapper>();
            mockWrapper.Setup(w => w.FrameworkDescription).Returns("8.0.0");
            InternalSDKUtils.SetRuntimeInformationWrapper(mockWrapper.Object);

            // Act
            var framework = InternalSDKUtils.DetermineFramework();

            // Assert
            Assert.Equal(".NET_Core#8.0.0", framework);
            InternalSDKUtils.ResetRuntimeInformationWrapper();
        }

        [Fact]
        public void DetermineFrameworkReturnsUnknownIfExceptionIsThrown()
        {
            // Arrange
            var mockWrapper = new Mock<IRuntimeInformationWrapper>();
            mockWrapper.Setup(w => w.FrameworkDescription).Throws<ArgumentException>();
            InternalSDKUtils.SetRuntimeInformationWrapper(mockWrapper.Object);

            // Act
            var framework = InternalSDKUtils.DetermineFramework();

            // Assert
            Assert.Equal("Unknown", framework);
            InternalSDKUtils.ResetRuntimeInformationWrapper();
        }
    }
}