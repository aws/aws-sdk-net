using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests <see cref="ProfileTokenProvider"/>
    /// </summary>
    [TestClass]
    public class ProfileTokenProviderTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        [DynamicData(nameof(TestCases), DynamicDataSourceType.Method)]
        public void SharedProfileConfigurationAndResolutionTests(TestCase testCase)
        {
            using (var fixture = testCase.BuildTestFixture())
            {
                var sharedConfigFile = fixture.CredentialsFile;

                var profileName = testCase.Config.GetPrimaryProfileName();

                var mockSSOTokenManger = new Mock<ISSOTokenManager>();
                mockSSOTokenManger
                    .Setup(x => x.GetToken(It.IsAny<SSOTokenManagerGetTokenOptions>()))
                    .Returns(new SsoToken());

                var mockSSOTokenProviderFactory = new Mock<ISSOTokenProviderFactory>();
                mockSSOTokenProviderFactory
                    .Setup(x => x.Build(It.Is<CredentialProfile>(p => p.Name == profileName)))
                    .Returns(
                        new SSOTokenProvider(
                            mockSSOTokenManger.Object,
                            "session",
                            "startUrl",
                            "region"));

                var provider = new ProfileTokenProvider(
                    mockSSOTokenProviderFactory.Object,
                    sharedConfigFile,
                    profileName);

                AWSToken token = null;
                bool success = false;
                Exception exception = null;

                try
                {
                    success = provider.TryResolveToken(out token);
                }
                catch (Exception e)
                {
                    exception = e;
                }

                Assert.AreEqual(testCase.Resolves, success);

                if (null == testCase.AssertException)
                {
                    Assert.IsNull(exception, $"Unexpected exception was thrown: {exception?.Message}");
                }
                else
                {
                    Assert.IsNotNull(exception);
                    testCase.AssertException(exception);
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        [DynamicData(nameof(TestCases), DynamicDataSourceType.Method)]
        public async Task SharedProfileConfigurationAndResolutionTestsAsync(TestCase testCase)
        {
            using (var fixture = testCase.BuildTestFixture())
            {
                var sharedConfigFile = fixture.CredentialsFile;

                var profileName = testCase.Config.GetPrimaryProfileName();

                var mockSSOTokenManger = new Mock<ISSOTokenManager>();
                mockSSOTokenManger
                    .Setup(x =>
                        x.GetTokenAsync(
                            It.IsAny<SSOTokenManagerGetTokenOptions>(),
                            It.IsAny<CancellationToken>()))
                    .Returns(Task.FromResult(new SsoToken()));

                var mockSSOTokenProviderFactory = new Mock<ISSOTokenProviderFactory>();
                mockSSOTokenProviderFactory
                    .Setup(x => x.Build(It.Is<CredentialProfile>(p => p.Name == profileName)))
                    .Returns(
                        new SSOTokenProvider(
                            mockSSOTokenManger.Object,
                            "session",
                            "startUrl",
                            "region"));

                var provider = new ProfileTokenProvider(
                    mockSSOTokenProviderFactory.Object,
                    sharedConfigFile,
                    profileName);

                AWSToken token = null;
                bool success = false;
                Exception exception = null;

                try
                {
                    var result = await provider.TryResolveTokenAsync();

                    success = result.Success;
                    token = result.Value;
                }
                catch (Exception e)
                {
                    exception = e;
                }

                Assert.AreEqual(testCase.Resolves, success);

                if (null == testCase.AssertException)
                {
                    Assert.IsNull(exception, $"Unexpected exception was thrown: {exception?.Message}");
                }
                else
                {
                    Assert.IsNotNull(exception);
                    testCase.AssertException(exception);
                }
            }
        }
        
        public static IEnumerable<object[]> TestCases()
        {
            // Full valid profile
            yield return new object[] { new TestCase
            {
                Config = new TestCaseConfig
                {
                    Profiles = new []
                    {
                        "[test]\r\n" + 
                        "sso_session = admin"
                    },
                    SSOSessions = new []
                    {
                        "[sso-session admin]\r\n" +
                        "sso_region = us-east-1\r\n" + 
                        "sso_start_url = https://d-abc123.awsapps.com/start"
                    }
                },
                Resolves = true
            }};
            
            // Non-SSO profiles are skipped
            yield return new object[] { new TestCase
            {
                Config = new TestCaseConfig
                {
                    Profiles = new []
                    {
                        "[test]\r\n" +
                        "region = us-west-2"
                    }
                },
                Resolves = false
            }};

            // Only start URL is invalid
            yield return new object[] { new TestCase
            {
                Config = new TestCaseConfig
                {
                    Profiles = new []
                    {
                        "[test]\r\n" +
                        "sso_session = admin"
                    },
                    SSOSessions = new []
                    {
                        "[sso-session admin]\r\n" +
                        "sso_start_url = https://d-abc123.awsapps.com/start"
                    }
                },
                Resolves = false,
                AssertException = e =>
                {
                    Assert.IsInstanceOfType(e, typeof(AmazonClientException));
                    Assert.IsTrue(e.Message.StartsWith("Invalid Configuration"));
                }
            }};

            // Only sso_region is invalid
            yield return new object[] { new TestCase
            {
                Config = new TestCaseConfig
                {
                    Profiles = new []
                    {
                        "[test]\r\n" +
                        "sso_session = admin"
                    },
                    SSOSessions = new []
                    {
                        "[sso-session admin]\r\n" +
                        "sso_region = us-east-1\r\n"
                    }
                },
                Resolves = false,
                AssertException = e =>
                {
                    Assert.IsInstanceOfType(e, typeof(AmazonClientException));
                    Assert.IsTrue(e.Message.StartsWith("Invalid Configuration"));
                }
            }};

            // Specified sso-session must exist
            yield return new object[] { new TestCase
            {
                Config = new TestCaseConfig
                {
                    Profiles = new []
                    {
                        "[test]\r\n" +
                        "sso_session = dev"
                    },
                    SSOSessions = new []
                    {
                        "[sso-session admin]\r\n" +
                        "sso_region = us-east-1\r\n" +
                        "sso_start_url = https://d-abc123.awsapps.com/start"
                    }
                },
                Resolves = false,
                AssertException = e =>
                {
                    Assert.IsInstanceOfType(e, typeof(AmazonClientException));
                    Assert.IsTrue(e.Message.StartsWith("Invalid Configuration"));
                }
            }};

            // The sso_session must be specified
            yield return new object[] { new TestCase
            {
                Config = new TestCaseConfig
                {
                    Profiles = new []
                    {
                        "[test]\r\n" +
                        "region = us-west-2"
                    },
                    SSOSessions = new []
                    {
                        "[sso-session admin]\r\n" +
                        "sso_region = us-east-1\r\n" +
                        "sso_start_url = https://d-abc123.awsapps.com/start"
                    }
                },
                Resolves = false
            }};
        }

        public class TestCase
        {
            public TestCaseConfig Config { get; set; }
            public bool Resolves { get; set; }
            public Action<Exception> AssertException { get; set; }

            public SharedCredentialsFileTestFixture BuildTestFixture()
            {
                return new SharedCredentialsFileTestFixture(
                    string.Join(Environment.NewLine, Config.Profiles),
                    string.Join(Environment.NewLine, Config.SSOSessions));
            }
        }

        public class TestCaseConfig
        {
            public string[] Profiles { get; set; } = new string[0];
            public string[] SSOSessions { get; set; } = new string[0];

            public string GetPrimaryProfileName()
            {
                var firstProfile = Profiles[0];
                var firstProfileName = firstProfile.Split(new [] {Environment.NewLine}, StringSplitOptions.None).First();

                return new string(firstProfileName.ToCharArray().Where(char.IsLetterOrDigit).ToArray());
            }
        }
    }
}