using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LoginAWSCredentialsTest
    {
        private static string _cacheDirectory;
        private static string _savedCacheDirectory;

        // LoginAWSCredentials reads AWS_LOGIN_CACHE_DIRECTORY once, when its static token cache is created.
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            _cacheDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(_cacheDirectory);
            _savedCacheDirectory = Environment.GetEnvironmentVariable("AWS_LOGIN_CACHE_DIRECTORY");
            Environment.SetEnvironmentVariable("AWS_LOGIN_CACHE_DIRECTORY", _cacheDirectory);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Environment.SetEnvironmentVariable("AWS_LOGIN_CACHE_DIRECTORY", _savedCacheDirectory);
            Directory.Delete(_cacheDirectory, true);
        }

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
        public void GetCredentials_ValidCachedTokenWithoutRegion_ReturnsCachedCredentials()
        {
            var loginSession = Guid.NewGuid().ToString();
            var cacheFile = Path.Combine(_cacheDirectory, AWSSDKUtils.ToHex(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(loginSession)), true) + ".json");
            File.WriteAllText(cacheFile, $@"{{
                ""accessToken"": {{
                    ""accessKeyId"": ""cached-access-key"",
                    ""secretAccessKey"": ""cached-secret-key"",
                    ""sessionToken"": ""cached-session-token"",
                    ""accountId"": ""012345678901"",
                    ""expiresAt"": ""{DateTime.UtcNow.AddHours(1):yyyy-MM-ddTHH:mm:ssZ}""
                }},
                ""refreshToken"": ""refresh-token"",
                ""clientId"": ""arn:aws:signin:::devtools/same-device"",
                ""dpopKey"": ""dpop-key""
            }}");
            try
            {
                var credentials = new LoginAWSCredentials(new LoginAWSCredentialsOptions { LoginSession = loginSession });

                Assert.AreEqual("cached-access-key", credentials.GetCredentials().AccessKey);
                Assert.IsNull(credentials.Options.Region);
            }
            finally
            {
                File.Delete(cacheFile);
            }
        }

        [TestMethod]
        public void Constructor_NullOptions_ThrowsArgumentNullException()
        {
            Assert.ThrowsExactly<ArgumentNullException>(() => new LoginAWSCredentials(null));
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

            Assert.ThrowsExactly<ArgumentNullException>(() => new LoginAWSCredentials(options));
        }
    }
}