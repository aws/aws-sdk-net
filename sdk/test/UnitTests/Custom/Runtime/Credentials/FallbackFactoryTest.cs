/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
#if ASYNC_AWAIT
using System.Threading.Tasks;
#endif

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class FallbackFactoryTest
    {
        private const string AWS_ENABLE_ENDPOINT_DISCOVERY_ENVIRONMENT_VARIABLE = "AWS_ENABLE_ENDPOINT_DISCOVERY";
        private const string AWS_RETRY_MODE_ENVIRONMENT_VARIABLE = "AWS_RETRY_MODE";
        private const string AWS_MAX_ATTEMPTS_ENVIRONMENT_VARIABLE = "AWS_MAX_ATTEMPTS";

        private static readonly string ProfileText = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("region=us-west-2")
            .AppendLine("aws_access_key_id=default_aws_access_key_id")
            .AppendLine("aws_secret_access_key=default_aws_secret_access_key")
            .AppendLine("[other]")
            .AppendLine("region=us-west-1")
            .AppendLine("aws_access_key_id=other_aws_access_key_id")
            .AppendLine("aws_secret_access_key=other_aws_secret_access_key")
            .AppendLine("endpoint_discovery_enabled=false")
            .AppendLine("[other2]")
            .AppendLine("region=us-west-1")
            .AppendLine("aws_access_key_id=other2_aws_access_key_id")
            .AppendLine("aws_secret_access_key=other2_aws_secret_access_key")
            .AppendLine("endpoint_discovery_enabled=true")
            .AppendLine("[processCredential]")
            .AppendLine("region=us-west-1")
            .AppendLine($"credential_process = {ProcessAWSCredentialsTest.Executable} {ProcessAWSCredentialsTest.ArgumentsBasic} {ProcessAWSCredentialsTest.ValidVersionNumber}")
            .AppendLine("[retries]")
            .AppendLine("max_attempts=100")
            .AppendLine("retry_mode=standard")            
            .ToString();

        [TestMethod]
        public void TestDefaultProfile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, null))
            {
                var creds = FallbackCredentialsFactory.GetCredentials();
                Assert.AreEqual("default_aws_access_key_id", creds.GetCredentials().AccessKey);

                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.USWest2, region);

                var enabled = FallbackEndpointDiscoveryEnabledFactory.GetEnabled();
                Assert.IsFalse(enabled.HasValue);

                enabled = FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled;
                Assert.IsFalse(enabled.HasValue);

                var retryMode = FallbackInternalConfigurationFactory.RetryMode;
                Assert.IsFalse(retryMode.HasValue);

                var maxAttempts = FallbackInternalConfigurationFactory.MaxAttempts;
                Assert.IsFalse(maxAttempts.HasValue);
            }
        }               

        [TestMethod]
        public void TestOtherProfile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, "other"))
            {
                var creds = FallbackCredentialsFactory.GetCredentials();
                Assert.AreEqual("other_aws_access_key_id", creds.GetCredentials().AccessKey);

                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.USWest1, region);

                var enabled = FallbackEndpointDiscoveryEnabledFactory.GetEnabled();
                Assert.IsTrue(enabled.HasValue);
                Assert.IsFalse(enabled.Value);

                enabled = FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled;
                Assert.IsTrue(enabled.HasValue);
                Assert.IsFalse(enabled.Value);
            }
        }

        [TestMethod]
        public void TestOther2Profile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, "other2"))
            {                
                var enabled = FallbackEndpointDiscoveryEnabledFactory.GetEnabled();
                Assert.IsTrue(enabled.HasValue);
                Assert.IsTrue(enabled.Value);

                enabled = FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled;
                Assert.IsTrue(enabled.HasValue);
                Assert.IsTrue(enabled.Value);
            }
        }
        
        [TestMethod]
        public void TestProcessCredentialProfile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, "processCredential"))
            {
                var credentials = FallbackCredentialsFactory.GetCredentials().GetCredentials();
                Assert.AreEqual(ProcessAWSCredentialsTest.ActualAccessKey, credentials.AccessKey);
                Assert.AreEqual(ProcessAWSCredentialsTest.ActualSecretKey, credentials.SecretKey);
                
                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.USWest1, region);
            }
        }

        [TestMethod]
        public void TestRetriesProfile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, "retries"))
            {
                var retryMode = FallbackInternalConfigurationFactory.RetryMode;
                Assert.IsTrue(retryMode.HasValue);
                Assert.AreEqual(RequestRetryMode.Standard, retryMode.Value);

                var maxAttempts = FallbackInternalConfigurationFactory.MaxAttempts;
                Assert.IsTrue(maxAttempts.HasValue);
                Assert.AreEqual(100, maxAttempts.Value);                                
            }
        }

        [TestMethod]
        public void TestEnableEndpointDiscoveryEnvVariable()
        {
            var envVariables = new Dictionary<string, string>()
            {
                {  AWS_ENABLE_ENDPOINT_DISCOVERY_ENVIRONMENT_VARIABLE, "false" }                
            };

            using (new FallbackFactoryTestFixture(ProfileText, "other2", envVariables))
            {
                var enabled = FallbackEndpointDiscoveryEnabledFactory.GetEnabled();
                Assert.IsTrue(enabled.HasValue);
                Assert.IsFalse(enabled.Value);

                enabled = FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled;
                Assert.IsTrue(enabled.HasValue);
                Assert.IsFalse(enabled.Value);
            }
        }

        [TestMethod]
        public void TestRetriesConfigurationEnvVariables()
        {
            var envVariables = new Dictionary<string, string>()
            {                
                {  AWS_RETRY_MODE_ENVIRONMENT_VARIABLE, "adaptive" },
                {  AWS_MAX_ATTEMPTS_ENVIRONMENT_VARIABLE, "6" }
            };

            using (new FallbackFactoryTestFixture(ProfileText, "retries", envVariables))
            {
                var retryMode = FallbackInternalConfigurationFactory.RetryMode;
                Assert.IsTrue(retryMode.HasValue);
                Assert.AreEqual(RequestRetryMode.Adaptive, retryMode.Value);

                var maxAttempts = FallbackInternalConfigurationFactory.MaxAttempts;
                Assert.IsTrue(maxAttempts.HasValue);
                Assert.AreEqual(6, maxAttempts.Value);
            }
        }

        /// <summary>
        /// Tests that the properties in the AssumeRoleWithWebIdentityCredentialsObject are used for
        /// the AssumeRoleWithWebIdentity call.
        /// The WebIdentityTokenFile should be read and its value used.
        /// </summary>
        [TestMethod]
        public void TestAssumeRoleWithWebIdentityCredentialsPropertiesUsedInSTSCall()
        {
#region Setup
            // Set up request variables
            var dummyToken = "dummyToken";
            var dummyRoleArn = "dummyRoleArn";
            var dummyRoleSessionName = "dummyRoleSessionName";
            var dummyOptions = new AssumeRoleWithWebIdentityCredentialsOptions();
            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, dummyToken);
            var equalityCheck = new Func<AssumeRoleWithWebIdentityRequest, bool>(req =>
            {
                return req.DurationSeconds.Equals(dummyOptions.DurationSeconds ?? 0) &&
                string.Equals(req.Policy, dummyOptions.Policy) &&
                Equals(req.PolicyArns, dummyOptions.PolicyArns) &&
                Equals(req.ProviderId, dummyOptions.ProviderId) &&
                req.RoleArn.Equals(dummyRoleArn) &&
                req.RoleSessionName.Equals(dummyRoleSessionName) &&
                req.WebIdentityToken.Equals(dummyToken);
            });
            var envVariables = new Dictionary<string, string>()
            {
                {  AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, webIdentityTokenFilePath },
                {  AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, dummyRoleArn },
                {  AssumeRoleWithWebIdentityCredentials.RoleSessionNameEnvVariable, dummyRoleSessionName },
            };
            // Set up response
            var dummyAccessKeyId = "dummyAccessKeyId";
            var dummySecretAccessKey = "dummySecretAccessKey";
            var dummySessionToken = "dummySessionToken";
            var dummyExpiration = DateTime.UtcNow.AddDays(1);
            var forcedResponse = new AssumeRoleWithWebIdentityResponse()
            {
                Credentials = new Credentials(dummyAccessKeyId, dummySecretAccessKey, dummySessionToken, dummyExpiration)
            };
            // Setup service client mock
            var mock = new Mock<AmazonSecurityTokenServiceClient>();
            Expression<Func<AmazonSecurityTokenServiceClient, AssumeRoleWithWebIdentityResponse>> stsCall =
                c => c.AssumeRoleWithWebIdentity(It.Is<AssumeRoleWithWebIdentityRequest>(req => equalityCheck(req)));
            mock.Setup(stsCall).Returns(forcedResponse);
            // Setup credentials
            using (var testCredentials = new AssumeRoleWithWebIdentityTestCredentials(webIdentityTokenFilePath, dummyRoleArn, dummyRoleSessionName, dummyOptions)
            {
                Client = mock.Object
            })
            {
                using (new FallbackFactoryTestFixture(ProfileText, "default", envVariables))
                {
#endregion Setup

#region Act
                    testCredentials.GetCredentials();
#endregion Act
                }
            }

            // Verify that the credential properties were used for the STS call
            mock.Verify(stsCall, Times.Once);
        }

#if ASYNC_AWAIT
        /// <summary>
        /// Tests that the properties in the AssumeRoleWithWebIdentityCredentialsObject are used for
        /// the AssumeRoleWithWebIdentityAsync call.
        /// The WebIdentityTokenFile should be read and its value used.
        /// </summary>
        [TestMethod]
        public async Task TestAssumeRoleWithWebIdentityCredentialsPropertiesUsedInAsyncSTSCallAsync()
        {
#region Setup
            // Set up request variables
            var dummyToken = "dummyToken";
            var dummyRoleArn = "dummyRoleArn";
            var dummyRoleSessionName = "dummyRoleSessionName";
            var dummyOptions = new AssumeRoleWithWebIdentityCredentialsOptions();
            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, dummyToken);
            var equalityCheck = new Func<AssumeRoleWithWebIdentityRequest, bool>(req =>
            {
                return req.DurationSeconds.Equals(dummyOptions.DurationSeconds ?? 0) &&
                string.Equals(req.Policy, dummyOptions.Policy) &&
                Equals(req.PolicyArns, dummyOptions.PolicyArns) &&
                Equals(req.ProviderId, dummyOptions.ProviderId) &&
                req.RoleArn.Equals(dummyRoleArn) &&
                req.RoleSessionName.Equals(dummyRoleSessionName) &&
                req.WebIdentityToken.Equals(dummyToken);
            });
            var envVariables = new Dictionary<string, string>()
            {
                {  AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, webIdentityTokenFilePath },
                {  AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, dummyRoleArn },
                {  AssumeRoleWithWebIdentityCredentials.RoleSessionNameEnvVariable, dummyRoleSessionName },
            };
            // Set up response
            var dummyAccessKeyId = "dummyAccessKeyId";
            var dummySecretAccessKey = "dummySecretAccessKey";
            var dummySessionToken = "dummySessionToken";
            var dummyExpiration = DateTime.UtcNow.AddDays(1);
            var forcedResponse = new AssumeRoleWithWebIdentityResponse()
            {
                Credentials = new Credentials(dummyAccessKeyId, dummySecretAccessKey, dummySessionToken, dummyExpiration)
            };
            // Setup service client mock
            var mock = new Mock<AmazonSecurityTokenServiceClient>();
            Expression<Func<AmazonSecurityTokenServiceClient, Task<AssumeRoleWithWebIdentityResponse>>> stsCall = c => c.AssumeRoleWithWebIdentityAsync(It.Is<AssumeRoleWithWebIdentityRequest>(req => equalityCheck(req)), new System.Threading.CancellationToken());
            mock.Setup(stsCall).Returns(Task.FromResult(forcedResponse));
            // Setup credentials
            using (var testCredentials = new AssumeRoleWithWebIdentityTestCredentials(webIdentityTokenFilePath, dummyRoleArn, dummyRoleSessionName, dummyOptions)
            {
                Client = mock.Object
            })
            {
                using (new FallbackFactoryTestFixture(ProfileText, "default", envVariables))
                {
#endregion Setup

#region Act
                    await testCredentials.GetCredentialsAsync().ConfigureAwait(false);
#endregion Act
                }
            }

            // Verify that the credential properties were used for the STS call
            mock.Verify(stsCall, Times.Once);
        }
#endif

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_FromEnvironmentVariables()
        {
#region Setup
            var webIdentityToken = "Dummy.OIDC.Token";
            var roleArn = "someRoleArn";
            var roleSessionName = "someRoleSessionName";

            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, webIdentityToken);

            var envVariables = new Dictionary<string, string>()
            {
                {  AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, webIdentityTokenFilePath },
                {  AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, roleArn },
                {  AssumeRoleWithWebIdentityCredentials.RoleSessionNameEnvVariable, roleSessionName },
            };

            AssumeRoleWithWebIdentityTestCredentials webIdentityCredentials;
            var mockClient = new Mock<ICoreAmazonSTS_WebIdentity>();
            mockClient.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                .Returns(new AssumeRoleImmutableCredentials("dummyAccessKeyId", "dummySecret", "dummyToken", DateTime.UtcNow.AddDays(1)));
            using (new FallbackFactoryTestFixture(ProfileText, "default", envVariables))
            {
#endregion Setup

#region Act
                var awsCredentials = FallbackCredentialsFactory.GetCredentials();
                webIdentityCredentials = new AssumeRoleWithWebIdentityTestCredentials((AssumeRoleWithWebIdentityCredentials)awsCredentials, null)
                {
                    Client = mockClient.Object
                };
                webIdentityCredentials.GetCredentials();
#endregion Act
            }

#region Assert
            Assert.AreEqual(webIdentityTokenFilePath, webIdentityCredentials.WebIdentityTokenFile);
            Assert.AreEqual(roleArn, webIdentityCredentials.RoleArn);
            Assert.AreEqual(roleSessionName, webIdentityCredentials.RoleSessionName);
#endregion Assert

            webIdentityCredentials.Dispose();
        }

        private string GetAssumeRoleWithWebIdentityProfileText(string tokenFilePath)
        {
            return new StringBuilder()
            .AppendLine("[default]")
            .AppendLine($"web_identity_token_file={tokenFilePath}")
            .AppendLine("role_arn=some-arn-2")
            .AppendLine("role_session_name=some-session-name-2")
            .ToString();
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_FromSharedProfile()
        {
#region Setup
            var webIdentityToken = "Dummy.OIDC.Token";
            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, webIdentityToken);
            var profileText = GetAssumeRoleWithWebIdentityProfileText(webIdentityTokenFilePath);
            AssumeRoleWithWebIdentityTestCredentials webIdentityCredentials;
            var mockClient = new Mock<ICoreAmazonSTS_WebIdentity>();
            mockClient.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                .Returns(new AssumeRoleImmutableCredentials("dummyAccessKeyId", "dummySecret", "dummyToken", DateTime.UtcNow.AddDays(1)));
            using (new FallbackFactoryTestFixture(profileText, "default"))
            {
#endregion Setup

#region Act
                var awsCredentials = FallbackCredentialsFactory.GetCredentials();
                webIdentityCredentials = new AssumeRoleWithWebIdentityTestCredentials((AssumeRoleWithWebIdentityCredentials)awsCredentials, null)
                {
                    Client = mockClient.Object
                };
                webIdentityCredentials.GetCredentials();
#endregion Act
            }

#region Assert
            Assert.AreEqual(webIdentityTokenFilePath, webIdentityCredentials.WebIdentityTokenFile);
            Assert.AreEqual("some-arn-2", webIdentityCredentials.RoleArn);
            Assert.AreEqual("some-session-name-2", webIdentityCredentials.RoleSessionName);
#endregion Assert

            webIdentityCredentials.Dispose();
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_DefinedBothInEnvAndConfig()
        {
#region Setup
            var webIdentityToken = "Dummy.OIDC.Token";
            var webIdentityToken2 = "Dummy.OIDC.Token2";
            var roleArn = "someRoleArn";
            var roleSessionName = "someRoleSessionName";

            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, webIdentityToken);
            var webIdentityTokenFilePath2 = Path.Combine(currentDirectory, "my-token2.jwt");
            File.WriteAllText(webIdentityTokenFilePath2, webIdentityToken2);

            var envVariables = new Dictionary<string, string>()
            {
                {  AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, webIdentityTokenFilePath },
                {  AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, roleArn },
                {  AssumeRoleWithWebIdentityCredentials.RoleSessionNameEnvVariable, roleSessionName },
            };

            var profileText = GetAssumeRoleWithWebIdentityProfileText(webIdentityTokenFilePath2);
            AssumeRoleWithWebIdentityTestCredentials webIdentityCredentials;
            var mockClient = new Mock<ICoreAmazonSTS_WebIdentity>();
            mockClient.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                .Returns(new AssumeRoleImmutableCredentials("dummyAccessKeyId", "dummySecret", "dummyToken", DateTime.UtcNow.AddDays(1)));
            using (new FallbackFactoryTestFixture(profileText, "default", envVariables))
            {
#endregion Setup

#region Action
                var awsCredentials = FallbackCredentialsFactory.GetCredentials();
                webIdentityCredentials = new AssumeRoleWithWebIdentityTestCredentials((AssumeRoleWithWebIdentityCredentials)awsCredentials, null)
                {
                    Client = mockClient.Object
                };
                webIdentityCredentials.GetCredentials();
#endregion Action
            }

#region Assert
            Assert.AreEqual(webIdentityTokenFilePath, webIdentityCredentials.WebIdentityTokenFile);
            Assert.AreEqual(roleArn, webIdentityCredentials.RoleArn);
            Assert.AreEqual(roleSessionName, webIdentityCredentials.RoleSessionName);
#endregion Assert

            webIdentityCredentials.Dispose();
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_TokenDoesNotExistAtGivenLocation()
        {
#region Setup
            var roleArn = "someRoleArn";
            var roleSessionName = "someRoleSessionName";
            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");

            var retry = 1;
            while (retry-- > 0) {
                try
                {
                    File.Delete(webIdentityTokenFilePath);
                    break;
                }
                catch
                {
                    retry--;
                }
            }

            var envVariables = new Dictionary<string, string>()
            {
                {  AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, webIdentityTokenFilePath },
                {  AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, roleArn },
                {  AssumeRoleWithWebIdentityCredentials.RoleSessionNameEnvVariable, roleSessionName },
            };

            using (new FallbackFactoryTestFixture(ProfileText, "default", envVariables))
            {
#endregion Setup
                try
                {
                    var credentials = FallbackCredentialsFactory.GetCredentials();
#region Assert
                    Assert.IsInstanceOfType(credentials, typeof(AssumeRoleWithWebIdentityCredentials));
                    credentials.GetCredentials();
                }
                catch (Exception e)
                {
                    Assert.IsTrue(e.Message.Contains("A token could not be loaded from the WebIdentityTokenFile."));
#endregion Assert
                }
            }
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_SessionNameNotProvided()
        {
#region Setup
            var webIdentityToken = "Dummy.OIDC.Token";
            var roleArn = "someRoleArn";
            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, webIdentityToken);

            var envVariables = new Dictionary<string, string>()
            {
                {  AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, webIdentityTokenFilePath },
                {  AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, roleArn },
                {  AssumeRoleWithWebIdentityCredentials.RoleSessionNameEnvVariable, "" },
            };

            AssumeRoleWithWebIdentityTestCredentials webIdentityCredentials;
            AssumeRoleWithWebIdentityTestCredentials webIdentityCredentials2;
            var mockClient = new Mock<ICoreAmazonSTS_WebIdentity>();
            mockClient.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                .Returns(new AssumeRoleImmutableCredentials("dummyAccessKeyId", "dummySecret", "dummyToken", DateTime.UtcNow.AddDays(1)));
            using (new FallbackFactoryTestFixture(ProfileText, "default", envVariables))
            {
#endregion Setup

#region Action
                // Get credentials once
                var awsCredentials = FallbackCredentialsFactory.GetCredentials();
                webIdentityCredentials = new AssumeRoleWithWebIdentityTestCredentials((AssumeRoleWithWebIdentityCredentials)awsCredentials, null)
                {
                    Client = mockClient.Object
                };
                webIdentityCredentials.GetCredentials();
                // Get credentials again
                var awsCredentials2 = FallbackCredentialsFactory.GetCredentials();
                webIdentityCredentials2 = new AssumeRoleWithWebIdentityTestCredentials((AssumeRoleWithWebIdentityCredentials)awsCredentials, null)
                {
                    Client = mockClient.Object
                };
                webIdentityCredentials2.GetCredentials();
#endregion Action
            }

#region Assert
            Assert.AreEqual(webIdentityTokenFilePath, webIdentityCredentials.WebIdentityTokenFile);
            Assert.AreEqual(roleArn, webIdentityCredentials.RoleArn);
            var guidRoleSessionName = webIdentityCredentials.RoleSessionName;
            Assert.IsTrue(Guid.TryParse(guidRoleSessionName, out Guid guid));
            Assert.AreEqual(guidRoleSessionName, webIdentityCredentials2.RoleSessionName);
#endregion Assert

            webIdentityCredentials.Dispose();
            webIdentityCredentials2.Dispose();
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_TokenPathIsNotAbsolute()
        {
            Assert.ThrowsException<ArgumentException>(() => new AssumeRoleWithWebIdentityCredentials("myToken.jwt", "someRoleArn", "someRoleSessionName"));
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_SessionNameInvalid()
        {
            var roleSessionName = "invalid()#Session%name";
            var roleArn = "someRoleArn";
            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new AssumeRoleWithWebIdentityCredentials(webIdentityTokenFilePath, roleArn, roleSessionName));
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_NullRoleArn()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            Assert.ThrowsException<ArgumentNullException>(() => new AssumeRoleWithWebIdentityCredentials(webIdentityTokenFilePath, null, "validRoleSessionName"));
        }

        /// Further FallbackFactory tests involving retries live in AWSSDK.UnitTests.SecurityToken.NET45.Custom.FallbackCredentialsFactorySTSTests.

        public class AssumeRoleWithWebIdentityTestCredentials : AssumeRoleWithWebIdentityCredentials
        {
            public ICoreAmazonSTS_WebIdentity Client { get; set; }
            public AssumeRoleWithWebIdentityTestCredentials(string webIdentityTokenFile, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
                : base(webIdentityTokenFile, roleArn, roleSessionName, options)
            {
                Client = base.CreateClient();
            }

            public AssumeRoleWithWebIdentityTestCredentials(AssumeRoleWithWebIdentityCredentials baseCreds, AssumeRoleWithWebIdentityCredentialsOptions options)
                : base(baseCreds.WebIdentityTokenFile, baseCreds.RoleArn, baseCreds.RoleSessionName, options)
            {
                Client = base.CreateClient();
            }

            protected override ICoreAmazonSTS_WebIdentity CreateClient()
            {
                return Client;
            }
        }

        public class FallbackFactoryTestFixture : IDisposable
        {
            private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";            

            private readonly SharedCredentialsFileTestFixture sharedFixture;
            private readonly NetSDKCredentialsFileTestFixture netSdkFixture;

            private readonly CredentialProfileStoreChain originalCredsChain;
            private readonly CredentialProfileStoreChain originalRegionChain;
            private readonly CredentialProfileStoreChain originalEndpointDiscoveryEnabledChain;
            private readonly CredentialProfileStoreChain originalConfigurationChain;

            private readonly string originalAWSProfileValue;            
            
            private readonly Dictionary<string, string> originalEnvironmentVariables = new Dictionary<string, string>();

            public FallbackFactoryTestFixture(string sharedCredsFileContent, string awsProfileValue, Dictionary<string, string> newEnvironmentVariables = null)
            {
                sharedFixture = new SharedCredentialsFileTestFixture(sharedCredsFileContent);
                netSdkFixture = new NetSDKCredentialsFileTestFixture();

                originalCredsChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalRegionChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalEndpointDiscoveryEnabledChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackEndpointDiscoveryEnabledFactory), "credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackEndpointDiscoveryEnabledFactory), "credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalConfigurationChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackInternalConfigurationFactory), "_credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackInternalConfigurationFactory), "_credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalAWSProfileValue = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
                Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, awsProfileValue);
                                                
                if (newEnvironmentVariables != null)
                {
                    foreach (var envVariable in newEnvironmentVariables)
                    {
                        var originalValue = Environment.GetEnvironmentVariable(envVariable.Key);
                        Environment.SetEnvironmentVariable(envVariable.Key, envVariable.Value);
                        originalEnvironmentVariables.Add(envVariable.Key, originalValue);
                    }
                }

                // reset before use to ensure the new credentialProfileChains are used.
                FallbackCredentialsFactory.Reset();
                FallbackRegionFactory.Reset();
                FallbackEndpointDiscoveryEnabledFactory.Reset();
                FallbackInternalConfigurationFactory.Reset();
            }

            public void Dispose()
            {
                foreach (var envVariable in originalEnvironmentVariables)
                {
                    Environment.SetEnvironmentVariable(envVariable.Key, envVariable.Value);
                }

                Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, originalAWSProfileValue);                

                ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain", originalRegionChain);
                ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain", originalCredsChain);
                ReflectionHelpers.Invoke(typeof(FallbackEndpointDiscoveryEnabledFactory), "credentialProfileChain", originalEndpointDiscoveryEnabledChain);
                ReflectionHelpers.Invoke(typeof(FallbackInternalConfigurationFactory), "_credentialProfileChain", originalConfigurationChain);

                netSdkFixture.Dispose();
                sharedFixture.Dispose();

                FallbackCredentialsFactory.Reset();
                FallbackRegionFactory.Reset();
                FallbackEndpointDiscoveryEnabledFactory.Reset();
                FallbackInternalConfigurationFactory.Reset();
            }
        }
    }
}
