using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Xunit;
using Moq;
using System;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    public class LoginAWSCredentialsTest
    {
        [Fact]
        public void Constructor_ValidOptions_SetsPropertiesCorrectly()
        {
            var options = new LoginAWSCredentialsOptions
            {
                LoginSession = "test-session",
                Region = "us-east-1",
                ProfileName = "test-profile"
            };

            var credentials = new LoginAWSCredentials(options);

            Assert.Equal(options, credentials.Options);
        }

        [Fact]
        public void Constructor_NullOptions_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new LoginAWSCredentials(null));
        }

        [Fact]
        public void Constructor_NullLoginSession_ThrowsArgumentNullException()
        {
            var options = new LoginAWSCredentialsOptions
            {
                LoginSession = null,
                Region = "us-east-1",
                ProfileName = "test-profile"
            };

            Assert.Throws<ArgumentNullException>(() => new LoginAWSCredentials(options));
        }
    }
}