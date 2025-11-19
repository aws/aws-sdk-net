using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LoginAWSCredentialsTest
    {
        [TestMethod]
        public void Constructor_ValidOptions_SetsPropertiesCorrectly()
        {
            var options = new LoginAWSCredentialsOptions
            {
                LoginSession = "test-session",
                Region = "us-east-1",
                ProfileName = "test-profile"
            };

            var credentials = new LoginAWSCredentials(options);

            Assert.AreEqual(options, credentials.Options);
        }

        [TestMethod]
        public void Constructor_NullOptions_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new LoginAWSCredentials(null));
        }

        [TestMethod]
        public void Constructor_NullLoginSession_ThrowsArgumentNullException()
        {
            var options = new LoginAWSCredentialsOptions
            {
                LoginSession = null,
                Region = "us-east-1",
                ProfileName = "test-profile"
            };

            Assert.ThrowsException<ArgumentNullException>(() => new LoginAWSCredentials(options));
        }
    }
}