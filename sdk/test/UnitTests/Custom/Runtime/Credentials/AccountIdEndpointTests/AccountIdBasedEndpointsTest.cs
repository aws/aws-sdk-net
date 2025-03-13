using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.SSO.Internal;
using System.Net;
using Amazon;
using Amazon.SecurityToken.SAML;
using System.Net.Mail;
using Amazon.Runtime.Credentials;
using System.Security.Principal;
using Amazon.SSO;
using Amazon.SSO.Model;
using Amazon.Runtime.CredentialManagement;
using Amazon.CloudWatch;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using System.IO;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AccountIdBasedEndpointsTest
    {

        private static readonly string ProjectPath =
            Regex.Match(Directory.GetCurrentDirectory(), @"^.*?(?=\\bin\\)").Captures[0].Value;

        public static readonly string Executable = Path.Combine(ProjectPath, @"Custom\Util\get_credentials.sh");
        private static bool _isWindows = false;
        //AssumeRoleAWSCredentials.GetCredentials() calls CredentialsFromAssumeRoleAuthentication

        static AccountIdBasedEndpointsTest()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Executable = Path.Combine(ProjectPath, @"Custom\Util\get_credentials.bat");
                _isWindows = true;
            }
        }


        [TestMethod]
        public void StsAssumeRoleAccountId()
        {
            var request = new AssumeRoleRequest
            {
                RoleArn = "arn:aws:sts::123456789001:assumed-role/assume-role-integration-test-role/Name",
                RoleSessionName = "testSession"
            };
            var expectedResponse = new AssumeRoleResponse
            {
                Credentials = new Credentials
                {
                    AccessKeyId = "foo",
                    SecretAccessKey = "bar",
                    SessionToken = "baz",
                    Expiration = DateTime.UtcNow.AddHours(1)
                },
                AssumedRoleUser = new AssumedRoleUser
                {
                    Arn = "arn:aws:sts::123456789001:assumed-role/assume-role-integration-test-role/Name",
                    AssumedRoleId = "roleId"
                }
            };
            var mockStsClient = new Mock<IAmazonSecurityTokenService>();
            mockStsClient.Setup(x => x.AssumeRole(It.IsAny<AssumeRoleRequest>())).Returns(expectedResponse);
            var testableAmazonStsClient = new TestableAmazonSTSClient(mockStsClient.Object);
            var actualCreds = testableAmazonStsClient.CredentialsFromAssumeRoleAuthentication("arn:aws:sts::123456789001:assumed-role/assume-role-integration-test-role/Name", "testSession", new AssumeRoleAWSCredentialsOptions());
            Assert.AreEqual<string>("123456789001", actualCreds.AccountId);
            Assert.AreEqual<string>("foo", actualCreds.AccessKey);
            Assert.AreEqual<string>("bar", actualCreds.SecretKey);
            Assert.AreEqual<string>("baz", actualCreds.Token);
        }

        //GetCredentials on 
        [TestMethod]
        public void StsAssumeRoleWithSamlAccountId()
        {
            var expectedResponse = new AssumeRoleWithSAMLResponse
            {
                Credentials = new Credentials
                {
                    AccessKeyId = "foo",
                    SecretAccessKey = "bar",
                    SessionToken = "baz"
                },
                AssumedRoleUser = new AssumedRoleUser
                {
                    Arn = "arn:aws:sts::123456789001:assumed-role/assume-role-integration-test-role/Name",
                    AssumedRoleId = "roleId"
                }
            };
            var mockStsClient = new Mock<IAmazonSecurityTokenService>();
            mockStsClient.Setup(x => x.AssumeRoleWithSAML(It.IsAny<AssumeRoleWithSAMLRequest>())).Returns(expectedResponse);

            var testableAmazonStsClient = new TestableAmazonSTSClient(mockStsClient.Object);
            var actualCreds = testableAmazonStsClient.CredentialsFromSAMLAuthentication("foo", "bar", "fizz", TimeSpan.FromHours(1), null);
            Assert.AreEqual<string>("123456789001", actualCreds.AccountId);
            Assert.AreEqual<string>("foo", actualCreds.AccessKey);
            Assert.AreEqual<string>("bar", actualCreds.SecretKey);
            Assert.AreEqual<string>("baz", actualCreds.Token);
        }

        [TestMethod]
        public void StsAssumeRoleWithWebIdentityAccountId()
        {
            var expectedResponse = new AssumeRoleWithWebIdentityResponse
            {
                Credentials = new Credentials
                {
                    AccessKeyId = "foo",
                    SecretAccessKey = "bar",
                    SessionToken = "baz"
                },
                AssumedRoleUser = new AssumedRoleUser
                {
                    Arn = "arn:aws:sts::123456789001:assumed-role/assume-role-integration-test-role/Name",
                    AssumedRoleId = "roleId"
                }
            };
            var mockStsClient = new Mock<IAmazonSecurityTokenService>();
            mockStsClient.Setup(x => x.AssumeRoleWithWebIdentity(It.IsAny<AssumeRoleWithWebIdentityRequest>())).Returns(expectedResponse);

            var testableAmazonStsClient = new TestableAmazonSTSClient(mockStsClient.Object);
            var actualCreds = testableAmazonStsClient.CredentialsFromAssumeRoleWithWebIdentityAuthentication("token", "any-arn", "test-arn", null);
            Assert.AreEqual<string>("123456789001", actualCreds.AccountId);
            Assert.AreEqual<string>("foo", actualCreds.AccessKey);
            Assert.AreEqual<string>("bar", actualCreds.SecretKey);
            Assert.AreEqual<string>("baz", actualCreds.Token);
        }

        /// <summary>
        /// When environment is configured with web identity, find account ID in response
        /// In the sdk flow, AssumeRoleWithWebIdentityCredentials.FromEnvironmentVariable() will be called, which sets the access key, secret access key and web identity
        /// token file path and role arn. The response from AssumeRoleWithWebIdentity is what is used to populate account id and not what is set in the env variable.
        /// </summary>
        // STS:5"
        [TestMethod]
        public void EnvironmentVariableConfiguredWithWebIdentitySetsAccountId()
        {
            var beforeAwsWebIdentityTokenFileEnvVar = Environment.GetEnvironmentVariable(AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable);
            var beforeAwsRoleArn = Environment.GetEnvironmentVariable(AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable);
            var beforeAwsAccountId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID);
            var beforeAwsAccessKeyId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            var beforeAwsSecretAccessKey = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            try
            {
                Environment.SetEnvironmentVariable(AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, "some_path");
                Environment.SetEnvironmentVariable(AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, "arn:aws:iam::123456789001:role");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, "123456789002");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "foo");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "bar");

                var mockStsClient = new Mock<IAmazonSecurityTokenService>();
                var expectedResponse = new AssumeRoleWithWebIdentityResponse
                {
                    Credentials = new Credentials
                    {
                        AccessKeyId = "foo",
                        SecretAccessKey = "bar",
                        SessionToken = "baz"
                    },
                    AssumedRoleUser = new AssumedRoleUser
                    {
                        Arn = "arn:aws:iam::123456789001:role",
                        AssumedRoleId = "roleId"
                    }
                };
                mockStsClient.Setup(x => x.AssumeRoleWithWebIdentity(It.IsAny<AssumeRoleWithWebIdentityRequest>())).Returns(expectedResponse);
                var testableAmazonStsClient = new TestableAmazonSTSClient(mockStsClient.Object);
                var actualCreds = testableAmazonStsClient.CredentialsFromAssumeRoleWithWebIdentityAuthentication("token", "any-arn", "test-arn", null);

                Assert.AreEqual<string>("123456789001", actualCreds.AccountId);
            }
            finally
            {
                Environment.SetEnvironmentVariable(AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, beforeAwsWebIdentityTokenFileEnvVar);
                Environment.SetEnvironmentVariable(AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, beforeAwsRoleArn);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, beforeAwsAccountId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, beforeAwsAccessKeyId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, beforeAwsSecretAccessKey);
            }
        }
        /// <summary>
        /// When calling Sso::GetCredentials successfully, find account ID in request
        /// SSO:1
        /// </summary>
        [TestMethod]
        public void SsoSuccessfulGetCredentialsFindsAccountIdInRequest()
        {
            var mockSsoClient = new Mock<IAmazonSSO>();
            var getRoleCredentialsRequest = new GetRoleCredentialsRequest
            {
                AccountId = "123456789001",
                RoleName = "anything",
                AccessToken = "anything"
            };
            var expectedResponse = new GetRoleCredentialsResponse
            {
                RoleCredentials = new RoleCredentials
                {
                    AccessKeyId = "foo",
                    SecretAccessKey = "bar",
                    SessionToken = "baz"
                }
            };
            mockSsoClient.Setup(client => client.GetRoleCredentials(It.IsAny<GetRoleCredentialsRequest>())).Returns(expectedResponse);

            var credentials = CoreAmazonSSO.CredentialsFromSsoAccessToken(
                mockSsoClient.Object,
                getRoleCredentialsRequest.AccountId,
                getRoleCredentialsRequest.RoleName,
                getRoleCredentialsRequest.AccessToken,
          null);

            Assert.AreEqual<string>("123456789001", credentials.AccountId);
            Assert.AreEqual<string>("foo", credentials.AccessKey);
            Assert.AreEqual<string>("bar", credentials.SecretKey);
            Assert.AreEqual<string>("baz", credentials.Token);
        }
        /// <summary>
        /// SSO:2
        /// When calling Sso::GetCredentials unsuccessfully, does not find account ID
        /// </summary>
        [TestMethod]
        public void SsoUnsuccessfulCallDoesNotFindAccountIdInRequest()
        {
            var mockSsoClient = new Mock<IAmazonSSO>();
            var getRoleCredentialsRequest = new GetRoleCredentialsRequest
            {
                AccountId = "123456789001",
                RoleName = "anything",
                AccessToken = "anything"
            };
            var expectedResponse = new ResourceNotFoundException("The request resource doesn't exist");
            mockSsoClient.Setup(client => client.GetRoleCredentials(It.IsAny<GetRoleCredentialsRequest>())).Throws(expectedResponse);
            ImmutableCredentials credentials = null;
            // expecting this call to fail and assert that credentials is null
            try
            {
                credentials = CoreAmazonSSO.CredentialsFromSsoAccessToken(
                    mockSsoClient.Object,
                    getRoleCredentialsRequest.AccountId,
                    getRoleCredentialsRequest.RoleName,
                    getRoleCredentialsRequest.AccessToken,
                    null);
            }
                
            catch (ResourceNotFoundException e)
            {
                Assert.IsNull(credentials);
                Assert.IsNotNull(e);
            }
        }

        private static string cfg1 = new StringBuilder().AppendLine("[profile assume-role]")
            .AppendLine("role_arn = arn:aws:iam::123456789002:role/MyRole")
            .AppendLine("source_profile = assume-creds")
            .AppendLine("[profile assume-creds]")
            .AppendLine("aws_access_key_id = abc123")
            .AppendLine("aws_secret_access_key = def456")
            .AppendLine("aws_account_id = 123456789001")
            .ToString();
        [TestMethod]
        public void AssumeRoleProfileReturnsCorrectAccountId()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg1))
            {
                sharedCredentialsFile.CredentialsFile.TryGetProfile("assume-role", out CredentialProfile profile);
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("assume-role", out AWSCredentials creds);
                Assert.IsInstanceOfType(creds, typeof(AssumeRoleAWSCredentials));
                //AssumeRoleAWSCredentials.GetCredentials() will call CredentialsFromAssumeRoleAuthentication
                var mockStsClient = new Mock<IAmazonSecurityTokenService>();
                var expectedResponse = new AssumeRoleResponse
                {
                    Credentials = new Credentials
                    {
                        AccessKeyId = "foo",
                        SecretAccessKey = "bar",
                        SessionToken = "baz",
                    },
                    AssumedRoleUser = new AssumedRoleUser
                    {
                        Arn = "arn:aws:iam::123456789002:role/MyRole",
                        AssumedRoleId = "roleId"
                    }
                };
                mockStsClient.Setup(x => x.AssumeRole(It.IsAny<AssumeRoleRequest>())).Returns(expectedResponse);
                var testableAmazonStsClient = new TestableAmazonSTSClient(mockStsClient.Object);
                var actualCreds = testableAmazonStsClient.CredentialsFromAssumeRoleAuthentication("anything", "anything", null);
                Assert.AreEqual<string>("123456789002", actualCreds.AccountId);
                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
                Assert.AreEqual<string>("baz", actualCreds.Token);
            }
        }
        private static string cfg2 = new StringBuilder()
            .AppendLine("[profile final-role]")
            .AppendLine("role_arn = arn:aws:iam::123456789003:role/MyRole")
            .AppendLine("source_profile = chained-role")
            .AppendLine("[profile chained-role]")
            .AppendLine("role_arn = arn:aws:iam::123456789002:role/MyRole")
            .AppendLine("source_profile = assume-creds")
            .AppendLine("[profile assume-creds]")
            .AppendLine("aws_access_key_id = abc123")
            .AppendLine("aws_secret_access_key = def456")
            .AppendLine("aws_account_id = 123456789001")
            .ToString();
        [TestMethod]
        public void AssumeRoleChainedProfilesReturnCorrectAccountId()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg2))
            {
                sharedCredentialsFile.CredentialsFile.TryGetProfile("final-role", out CredentialProfile profile);
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("final-role", out AWSCredentials creds);
                Assert.IsNotNull(creds);
                Assert.IsInstanceOfType(creds, typeof(AssumeRoleAWSCredentials));
                //AssumeRoleAWSCredentials.GetCredentials() will call CredentialsFromAssumeRoleAuthentication
                var mockStsClient = new Mock<IAmazonSecurityTokenService>();
                var expectedResponse = new AssumeRoleResponse
                {
                    Credentials = new Credentials
                    {
                        AccessKeyId = "foo",
                        SecretAccessKey = "bar",
                        SessionToken = "baz",
                    },
                    AssumedRoleUser = new AssumedRoleUser
                    {
                        Arn = "arn:aws:iam::123456789003:role/MyRole",
                        AssumedRoleId = "roleId"
                    }
                };
                mockStsClient.Setup(x => x.AssumeRole(It.IsAny<AssumeRoleRequest>())).Returns(expectedResponse);
                var testableAmazonStsClient = new TestableAmazonSTSClient(mockStsClient.Object);
                var actualCreds = testableAmazonStsClient.CredentialsFromAssumeRoleAuthentication("anything", "anything", null);
                Assert.AreEqual<string>("123456789003", actualCreds.AccountId);
                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
                Assert.AreEqual<string>("baz", actualCreds.Token);
            }
        }
        private static string cfg3 = new StringBuilder()
            .AppendLine("[profile test-role]")
            .AppendLine("role_arn = arn:aws:iam::123456789003:role/MyRole")
            .AppendLine("credential_source = Environment")
            .AppendLine("aws_account_id = 123456789001")
            .ToString();
        // When profile is configured with role, accountid and env var credentials_source, find account ID in call response
        [TestMethod]
        public void AccountIdInResponseTakesPrecedenceOverEnvVariables()
        {
            var beforeAwsAccountId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID);
            var beforeAwsAccessKeyId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            var beforeAwsSecretAccessKey = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            try
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, "123456789002");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "foo");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "bar");
                using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg3))
                {
                    var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                    chain.TryGetAWSCredentials("test-role", out AWSCredentials creds);
                    Assert.IsNotNull(creds);
                    Assert.IsInstanceOfType(creds, typeof(AssumeRoleAWSCredentials));

                    var mockStsClient = new Mock<IAmazonSecurityTokenService>();
                    var expectedResponse = new AssumeRoleResponse
                    {
                        Credentials = new Credentials
                        {
                            AccessKeyId = "foo",
                            SecretAccessKey = "bar",
                            SessionToken = "baz",
                        },
                        AssumedRoleUser = new AssumedRoleUser
                        {
                            Arn = "arn:aws:iam::123456789003:role/MyRole",
                            AssumedRoleId = "roleId"
                        }
                    };

                    mockStsClient.Setup(x => x.AssumeRole(It.IsAny<AssumeRoleRequest>())).Returns(expectedResponse);
                    var testableAmazonStsClient = new TestableAmazonSTSClient(mockStsClient.Object);
                    var actualCreds = testableAmazonStsClient.CredentialsFromAssumeRoleAuthentication("anything", "anything", null);
                    Assert.AreEqual<string>("123456789003", actualCreds.AccountId);
                    Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                    Assert.AreEqual<string>("bar", actualCreds.SecretKey);
                    Assert.AreEqual<string>("baz", actualCreds.Token);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, beforeAwsAccountId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, beforeAwsAccessKeyId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, beforeAwsSecretAccessKey);
            }
        }
        private static string cfg4 = new StringBuilder()
            .AppendLine("[profile test-role]")
            .AppendLine("role_arn = arn:aws:iam::123456789003:role/MyRole")
            .AppendLine("web_identity_token_file = C:\\temp\\")
            .AppendLine("credential_source = Environment")
            .AppendLine("aws_account_id = 123456789001")
            .ToString();

        // When profile is configured with web identity, find account ID in response
        [TestMethod]
        public void FindAccountIdInResponseWhenProfileIsConfiguredWithWebIdentity()
        {
            var beforeAwsAccountId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID);
            var beforeAwsAccessKeyId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            var beforeAwsSecretAccessKey = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);

            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg4))
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, "123456789002");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "foo");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "bar");
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("test-role", out AWSCredentials creds);
                Assert.IsNotNull(creds);
                Assert.IsInstanceOfType(creds, typeof(AssumeRoleWithWebIdentityCredentials));

                var expectedResponse = new AssumeRoleWithWebIdentityResponse
                {
                    AssumedRoleUser = new AssumedRoleUser
                    {
                        Arn = "arn:aws:iam::123456789003:role"
                    },
                    Credentials = new Credentials
                    {
                        AccessKeyId = "foo",
                        SecretAccessKey = "bar",
                        SessionToken = "baz"
                    }
                };

                var mockStsClient = new Mock<IAmazonSecurityTokenService>();
                mockStsClient.Setup(client => client.AssumeRoleWithWebIdentity(It.IsAny<AssumeRoleWithWebIdentityRequest>())).Returns(expectedResponse);
                var testableAmazonStsClient = new TestableAmazonSTSClient(mockStsClient.Object);
                var actualCreds = testableAmazonStsClient.CredentialsFromAssumeRoleWithWebIdentityAuthentication("any", "any", "any", null);
                Assert.AreEqual<string>("123456789003", actualCreds.AccountId);
            }
        }

        private static string cfg5 = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("aws_access_key_id = foo")
            .AppendLine("aws_secret_access_key = bar")
            .AppendLine("aws_account_id = 123456789001")
            .ToString();
        
        [TestMethod]
        public void AccountIdConfiguredInProfileWorks()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg5))
            {
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("default", out AWSCredentials creds);
                Assert.IsNotNull(creds);
                var immutableCreds = creds.GetCredentials();
                Assert.AreEqual<string>("123456789001", immutableCreds.AccountId);
                Assert.AreEqual<string>("foo", immutableCreds.AccessKey);
                Assert.AreEqual<string>("bar", immutableCreds.SecretKey);

            }
        }

        private static string cfg6 = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("aws_access_key_id = foo")
            .AppendLine("aws_secret_access_key = bar")
            .ToString();

        [TestMethod]
        public void AccountIdNotFoundInProfileIfUnavailable()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg6))
            {
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("default", out AWSCredentials creds);
                Assert.IsNotNull(creds);
                var actualCreds = creds.GetCredentials();
                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
                Assert.IsNull(actualCreds.AccountId);
            }
        }

        private static string cfg7 = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("aws_access_key_id = foo")
            .AppendLine("aws_secret_access_key = bar")
            .AppendLine("aws_session_token = baz")
            .AppendLine("aws_account_id = 123456789001")
            .ToString();
        [TestMethod]
        public void AccountIdFoundInSessionProfile()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg7))
            {
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("default", out AWSCredentials creds);
                Assert.IsNotNull(creds);
                var actualCreds = creds.GetCredentials();

                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
                Assert.AreEqual<string>("baz", actualCreds.Token);
                Assert.AreEqual<string>("123456789001", actualCreds.AccountId);
            }
        }

        private static string cfg8 = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("aws_access_key_id = foo")
            .AppendLine("aws_secret_access_key = bar")
            .AppendLine("aws_session_token = baz")
            .ToString();

        [TestMethod]
        public void AccountIdNotFoundInSessionProfileIfUnavailable()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg8))
            {
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("default", out AWSCredentials creds);
                Assert.IsNotNull(creds);
                var actualCreds = creds.GetCredentials();

                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
                Assert.AreEqual<string>("baz", actualCreds.Token);
                Assert.IsNull(actualCreds.AccountId);
            }
        }

        [TestMethod]
        public void StaticCredsWithAcctIdWorks()
        {
            var creds = new ImmutableCredentials("foo", "bar", null, "123456789001");
            Assert.AreEqual<string>("123456789001", creds.AccountId);
            Assert.AreEqual<string>("foo", creds.AccessKey);
            Assert.AreEqual<string>("bar", creds.SecretKey);
        }

        [TestMethod]
        public void StaticCredsWithNoAcctIdWorks()
        {
            var creds = new ImmutableCredentials("foo", "bar", null);
            Assert.AreEqual<string>("foo", creds.AccessKey);
            Assert.AreEqual<string>("bar", creds.SecretKey);
            Assert.IsNull(creds.AccountId);
        }

        [TestMethod]
        public void SessionCredsWithAcctIdWorks()
        {
            var temp = new SessionAWSCredentials("foo", "bar", "baz", "123456789001");
            var creds = temp.GetCredentials();
            Assert.AreEqual<string>("123456789001", creds.AccountId);
            Assert.AreEqual<string>("foo", creds.AccessKey);
            Assert.AreEqual<string>("bar", creds.SecretKey);
            Assert.AreEqual<string>("baz", creds.Token);
        }

        [TestMethod]
        public void EnvVarsContainingAcctIdWorks()
        {
            var beforeAwsAccountId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID);
            var beforeAwsAccessKeyId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            var beforeAwsSecretAccessKey = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            try
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, "123456789001");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "foo");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "bar");
                DefaultAWSCredentialsIdentityResolver resolver = new DefaultAWSCredentialsIdentityResolver();
                AWSCredentials creds = resolver.ResolveIdentity();
                var actualCreds = creds.GetCredentials();
                Assert.AreEqual<string>("123456789001", actualCreds.AccountId);
                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
            }
            finally
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, beforeAwsAccountId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, beforeAwsAccessKeyId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, beforeAwsSecretAccessKey);
            }
        }
        [TestMethod]
        public void EnvVarsContainingNoAcctIdWorks()
        {
            var beforeAwsAccessKeyId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            var beforeAwsSecretAccessKey = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            try
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "foo");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "bar");
                DefaultAWSCredentialsIdentityResolver resolver = new DefaultAWSCredentialsIdentityResolver();
                AWSCredentials creds = resolver.ResolveIdentity();
                var actualCreds = creds.GetCredentials();
                Assert.IsNull(actualCreds.AccountId);
                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
            }
            finally
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, beforeAwsAccessKeyId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, beforeAwsSecretAccessKey);
            }
        }
        [TestMethod]
        public void EnvVarsContainingAcctIdAndTokenWorks()
        {
            var beforeAwsAccountId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID);
            var beforeAwsAccessKeyId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            var beforeAwsSecretAccessKey = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            var beforeSessionToken = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN);
            try
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, "123456789001");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "foo");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "bar");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, "baz");
                DefaultAWSCredentialsIdentityResolver resolver = new DefaultAWSCredentialsIdentityResolver();
                AWSCredentials creds = resolver.ResolveIdentity();
                var actualCreds = creds.GetCredentials();
                Assert.AreEqual<string>("123456789001", actualCreds.AccountId);
                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
                Assert.AreEqual<string>("baz", actualCreds.Token);
            }
            finally
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCOUNT_ID, beforeAwsAccountId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, beforeAwsAccessKeyId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, beforeAwsSecretAccessKey);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, beforeSessionToken);
            }
        }

        [TestMethod]
        public void EnvVarsContainingTokenAndNoAcctIdWorks()
        {
            var beforeAwsAccessKeyId = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            var beforeAwsSecretAccessKey = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            var beforeSessionToken = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN);
            try
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "foo");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "bar");
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, "baz");
                DefaultAWSCredentialsIdentityResolver resolver = new DefaultAWSCredentialsIdentityResolver();
                AWSCredentials creds = resolver.ResolveIdentity();
                var actualCreds = creds.GetCredentials();
                Assert.IsNull(actualCreds.AccountId);
                Assert.AreEqual<string>("foo", actualCreds.AccessKey);
                Assert.AreEqual<string>("bar", actualCreds.SecretKey);
                Assert.AreEqual<string>("baz", actualCreds.Token);
            }
            finally
            {
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, beforeAwsAccessKeyId);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, beforeAwsSecretAccessKey);
                Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, beforeSessionToken);
            }
        }

        private static string process1 = new StringBuilder()
            .AppendLine("{\"Version\": 1,")
            .AppendLine("\"AccessKeyId\":\"foo\",")
            .AppendLine("\"SecretAccessKey\":\"bar\",")
            .AppendLine("\"SessionToken\":\"baz\",")
            .AppendLine("\"AccountId\":\"123456789001\",")
            .AppendLine("}")
            .ToString();

        //PRO:1
        [TestMethod]
        public void ProcessCredentialsProviderWithAccountIdWorks()
        {
            ProcessCredentialVersion1 processCreds = JsonSerializerHelper.Deserialize<ProcessCredentialVersion1>(process1, ProcessCredentialVersion1JsonSerializerContexts.Default);
            ImmutableCredentials immutableCreds = new ImmutableCredentials(processCreds.AccessKeyId, processCreds.SecretAccessKey, processCreds.SessionToken, processCreds.AccountId);
            Assert.AreEqual<string>("123456789001", immutableCreds.AccountId);
            Assert.AreEqual<string>("foo", immutableCreds.AccessKey);
            Assert.AreEqual<string>("bar", immutableCreds.SecretKey);
            Assert.AreEqual<string>("baz", immutableCreds.Token);
        }
        private static string process2 = new StringBuilder()
            .AppendLine("{\"Version\": 1,")
            .AppendLine("\"AccessKeyId\":\"foo\",")
            .AppendLine("\"SecretAccessKey\":\"bar\",")
            .AppendLine("\"SessionToken\":\"baz\",")
            .AppendLine("}")
            .ToString();

        //PRO:2
        [TestMethod]
        public void ProcessCredsWithNoAcctIdWorks()
        {
            ProcessCredentialVersion1 processCreds = JsonSerializerHelper.Deserialize<ProcessCredentialVersion1>(process2, ProcessCredentialVersion1JsonSerializerContexts.Default);
            ImmutableCredentials immutableCreds = new ImmutableCredentials(processCreds.AccessKeyId, processCreds.SecretAccessKey, processCreds.SessionToken, processCreds.AccountId);
            Assert.IsNull(immutableCreds.AccountId);
            Assert.AreEqual<string>("foo", immutableCreds.AccessKey);
            Assert.AreEqual<string>("bar", immutableCreds.SecretKey);
            Assert.AreEqual<string>("baz", immutableCreds.Token);
        }

        [TestMethod]
        public void ProcessCredsFromCredentialProcess()
        {
            //CFG10
            var cfg10 = new StringBuilder()
                .AppendLine("[profile process-role]")
                .AppendFormat("credential_process = {0}\n", Executable)
                .ToString();

            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg10))
            {
                var processScript = new ProcessScript
                {
                    Version = "1",
                    AccessKey = "foo",
                    SecretKey = "bar",
                    Token = "baz",
                    AccountId = "123456789002"
                };

                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("process-role", out AWSCredentials creds);
                Assert.IsInstanceOfType(creds, typeof(ProcessAWSCredentials));
                if (_isWindows)
                    WriteWindowsProcessCredentialScript(processScript);
                else
                    WriteLinuxProcessCredentialScript(processScript);

                ImmutableCredentials immutableCreds = creds.GetCredentials();
                Assert.AreEqual<string>("foo", immutableCreds.AccessKey);
                Assert.AreEqual<string>("bar", immutableCreds.SecretKey);
                Assert.AreEqual<string>("baz", immutableCreds.Token);
                Assert.AreEqual<string>("123456789002", immutableCreds.AccountId);
            }
        }

        /// <summary>
        /// CFG11
        /// </summary>
        [TestMethod]
        public void ProcessCredsFromCredentialProcessWithAccountId()
        {
             var cfg11 = new StringBuilder()
                .AppendLine("[profile process-role]")
                .AppendFormat("credential_process = {0}\n", Executable)
                .AppendLine("aws_account_id = 123456789001")
                .ToString();
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg11))
            {

                var processScript = new ProcessScript
                {
                    Version = "1",
                    AccessKey = "foo",
                    SecretKey = "bar",
                    Token = "baz",
                    AccountId = "123456789002"
                };

                if (_isWindows)
                    WriteWindowsProcessCredentialScript(processScript);
                else
                    WriteLinuxProcessCredentialScript(processScript);
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("process-role", out AWSCredentials creds);
                Assert.IsInstanceOfType(creds, typeof(ProcessAWSCredentials));

                var immutableCreds = creds.GetCredentials();
                Assert.AreEqual<string>("foo", immutableCreds.AccessKey);
                Assert.AreEqual<string>("bar", immutableCreds.SecretKey);
                Assert.AreEqual<string>("baz", immutableCreds.Token);
                Assert.AreEqual<string>("123456789002", immutableCreds.AccountId);
            }
        }

        [TestMethod]
        public void ProcessCredsNoAcctIdWorks()
        {
            // Since executable can change from a shell script to a batch file cfg cannot be a static string
            var cfg12 = new StringBuilder()
                .AppendLine("[profile process-role]")
                .AppendFormat("credential_process = {0}\n", Executable)
                .AppendLine("aws_account_id = 123456789001")
                .ToString();
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg12))
            {
                var processScript = new ProcessScript
                {
                    AccessKey = "foo",
                    SecretKey = "bar",
                    Token = "baz",
                    Version = "1"
                };
                if (_isWindows)
                    WriteWindowsProcessCredentialScript(processScript);
                else
                    WriteLinuxProcessCredentialScript(processScript);
                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("process-role", out AWSCredentials creds);
                Assert.IsInstanceOfType(creds, typeof(ProcessAWSCredentials));
                var immutableCreds = creds.GetCredentials();
                Assert.AreEqual<string>("foo", immutableCreds.AccessKey);
                Assert.AreEqual<string>("bar", immutableCreds.SecretKey);
                Assert.AreEqual<string>("baz", immutableCreds.Token);
                Assert.AreEqual<string>("123456789001", immutableCreds.AccountId);
            }
        }

        [TestMethod]
        public void ProcessWithTokenAndNoAcctIdWorks()
        {
            var cfg13 = new StringBuilder()
                .AppendLine("[profile process-role]")
                .AppendFormat("credential_process = {0}\n", Executable)
                .ToString();
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg13))
            {
                var processScript = new ProcessScript
                {
                    Version = "1",
                    AccessKey = "foo",
                    SecretKey = "bar",
                    Token = "baz"
                };
                if (_isWindows)
                    WriteWindowsProcessCredentialScript(processScript);
                else
                    WriteLinuxProcessCredentialScript(processScript);

                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("process-role", out AWSCredentials creds);
                Assert.IsInstanceOfType(creds, typeof(ProcessAWSCredentials));

                var immutableCreds = creds.GetCredentials();
                Assert.AreEqual<string>("foo", immutableCreds.AccessKey);
                Assert.AreEqual<string>("bar", immutableCreds.SecretKey);
                Assert.AreEqual<string>("baz", immutableCreds.Token);
                Assert.IsNull(immutableCreds.AccountId);
            }
        }

        [TestMethod]
        public void ProcessWithAcctIdWorks()
        {
            var cfg14 = new StringBuilder()
                .AppendLine("[profile process-role]")
                .AppendFormat("credential_process = {0}\n", Executable)
                .ToString();

            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: cfg14))
            {
                var processScript = new ProcessScript
                {
                    Version = "1",
                    AccessKey = "foo",
                    SecretKey = "bar",
                    AccountId = "123456789001"
                };
                if (_isWindows)
                    WriteWindowsProcessCredentialScript(processScript);
                else
                    WriteLinuxProcessCredentialScript(processScript);

                var chain = new CredentialProfileStoreChain(sharedCredentialsFile.ConfigFilePath);
                chain.TryGetAWSCredentials("process-role", out AWSCredentials creds);
                Assert.IsInstanceOfType(creds, typeof(ProcessAWSCredentials));
                var immutableCreds = creds.GetCredentials();
                Assert.AreEqual<string>("foo", immutableCreds.AccessKey);
                Assert.AreEqual<string>("bar", immutableCreds.SecretKey);
                Assert.AreEqual<string>("", immutableCreds.Token);
                Assert.AreEqual<string>("123456789001", immutableCreds.AccountId);
            }
        }


        private static void WriteLinuxProcessCredentialScript(ProcessScript processScript)
        {
            string expirationDate = DateTime.UtcNow.AddDays(5).ToString("yyyy-MM-ddTHH:mm:ssZ");
            using (var streamWriter = File.CreateText(Executable))
            {
                streamWriter.WriteLine("#!/usr/bin/env bash");
                streamWriter.WriteLine("echo \'{\';");
                streamWriter.WriteLine("echo \'\"Version\":{0},\';", processScript.Version);
                streamWriter.WriteLine("echo \'\"AccessKeyId\":\"{0}\"\',;", processScript.AccessKey);
                streamWriter.WriteLine("echo \'\"SecretAccessKey\": \"{0}\"\',;", processScript.SecretKey);
                if (!string.IsNullOrEmpty(processScript.Token))
                {
                    streamWriter.WriteLine("echo \'\"SessionToken\": \"{0}\"\',;",processScript.Token);
                    streamWriter.WriteLine("echo \'\"Expiration\": \"{0}\"\',;", expirationDate);
                }
                if (!string.IsNullOrEmpty(processScript.AccountId))
                {
                    streamWriter.WriteLine("echo \'\"AccountId\": \"{0}\"\',;", processScript.AccountId);
                }
                streamWriter.WriteLine("echo \'}\';");
            }
        }

        private static void WriteWindowsProcessCredentialScript(ProcessScript processScript)
        {
            string expirationDate = DateTime.UtcNow.AddDays(5).ToString("yyyy-MM-ddTHH:mm:ssZ");
            using (var streamWriter = File.CreateText(Executable))
            {
                streamWriter.WriteLine("@echo off");
                streamWriter.WriteLine("echo {");
                streamWriter.WriteLine("echo \"Version\":{0},", processScript.Version);
                streamWriter.WriteLine("echo \"AccessKeyId\":\"{0}\",", processScript.AccessKey);
                streamWriter.WriteLine("echo \"SecretAccessKey\": \"{0}\",", processScript.SecretKey);
                if (!string.IsNullOrEmpty(processScript.Token))
                {
                    streamWriter.WriteLine("echo \"SessionToken\": \"{0}\",", processScript.Token);
                    streamWriter.WriteLine("echo \"Expiration\": \"{0}\",", expirationDate);
                }
                if (!string.IsNullOrEmpty(processScript.AccountId))
                {
                    streamWriter.WriteLine("echo \"AccountId\": \"{0}\"", processScript.AccountId);
                }
                streamWriter.WriteLine("echo }");
            }
        }
        private class ProcessScript
        {
            public string Version { get; set; }
            public string AccessKey { get; set; }
            public string SecretKey { get; set; }
            public string Token { get; set; }
            public string AccountId { get; set; }
        }
    }

    // A testable implementation of ICoreAmazonSTS which can accept an injected mocked client
    public class TestableAmazonSTSClient : ICoreAmazonSTS, ICoreAmazonSTS_WebIdentity
    {
        private readonly IAmazonSecurityTokenService _stsClient;

        public TestableAmazonSTSClient(IAmazonSecurityTokenService stsClient)
        {
            _stsClient = stsClient;
        }

        public AssumeRoleImmutableCredentials CredentialsFromAssumeRoleAuthentication(string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
        {
            try
            {
                var request = new AssumeRoleRequest
                {
                    RoleArn = roleArn,
                    RoleSessionName = roleSessionName
                };
                if (options != null)
                {
                    request.ExternalId = options.ExternalId;
                    request.SerialNumber = options.MfaSerialNumber;
                    request.TokenCode = options.MfaTokenCode;
                    request.Policy = options.Policy;
                    request.SourceIdentity = options.SourceIdentity;

                    if (options.DurationSeconds.HasValue)
                    {
                        request.DurationSeconds = options.DurationSeconds.Value;
                    }

                    if (options.Tags != null && options.Tags.Count > 0)
                    {
                        request.Tags = options.Tags.Select(kv => new Tag() { Key = kv.Key, Value = kv.Value }).ToList();
                    }

                    if (options.TransitiveTagKeys != null && options.TransitiveTagKeys.Count > 0)
                    {
                        request.TransitiveTagKeys = options.TransitiveTagKeys;
                    }
                }
                var response = _stsClient.AssumeRole(request);

                return new AssumeRoleImmutableCredentials(
                    response.Credentials.AccessKeyId,
                    response.Credentials.SecretAccessKey,
                    response.Credentials.SessionToken,
                    response.Credentials.Expiration.GetValueOrDefault(),
                    Arn.Parse(response.AssumedRoleUser.Arn).AccountId
                    );
            }

            catch (Exception e)
            {
                var msg = "Error calling AssumeRole for role " + roleArn;
                var exception = new AmazonClientException(msg, e);
                throw exception;
            }
        }

        public AssumeRoleImmutableCredentials CredentialsFromAssumeRoleWithWebIdentityAuthentication(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
        {
            var request = new AssumeRoleWithWebIdentityRequest
            {
                WebIdentityToken = webIdentityToken,
                RoleArn = roleArn,
                RoleSessionName = roleSessionName
            };
            var response = _stsClient.AssumeRoleWithWebIdentity(request);
            return new AssumeRoleImmutableCredentials(response.Credentials.AccessKeyId, response.Credentials.SecretAccessKey,
                response.Credentials.SessionToken, response.Credentials.Expiration.GetValueOrDefault(), Arn.Parse(response.AssumedRoleUser.Arn).AccountId);
        }

        public Task<AssumeRoleImmutableCredentials> CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
        {
            throw new NotImplementedException();
        }

        //What we really want to test is if the account id is properly populated after an AssumeRoleWithSAML call and not all the SAML assertion logic, so skip that.
        public SAMLImmutableCredentials CredentialsFromSAMLAuthentication(string endpoint, string authenticationType, string roleArn, TimeSpan credentialDuration, ICredentials userCredential)
        {
            var assumeSamlRequest = new AssumeRoleWithSAMLRequest
            {
                SAMLAssertion = "AssertionDocument",
                RoleArn = roleArn,
                PrincipalArn = "prinicpalArn",
                DurationSeconds = 0
            };

            var response = _stsClient.AssumeRoleWithSAML(assumeSamlRequest);

            return new SAMLImmutableCredentials(response.Credentials.GetCredentials(),
                                                response.Credentials.Expiration.GetValueOrDefault().ToUniversalTime(),
                                                response.Subject,
                                                Arn.Parse(response.AssumedRoleUser.Arn).AccountId);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
