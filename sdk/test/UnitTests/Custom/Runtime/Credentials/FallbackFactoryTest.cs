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
using Amazon.Util;
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
        private const string AWS_USE_DUALSTACK_ENDPOINT_ENVIRONMENT_VARIABLE = "AWS_USE_DUALSTACK_ENDPOINT";
        private const string AWS_DISABLE_REQUEST_COMPRESSION = "AWS_DISABLE_REQUEST_COMPRESSION";
        private const string AWS_REQUEST_MIN_COMPRESSION_SIZE_BYTES = "AWS_REQUEST_MIN_COMPRESSION_SIZE_BYTES";
        private const string AWS_EC2_METADATA_V1_DISABLED = "AWS_EC2_METADATA_V1_DISABLED";
        private const string AWS_SDK_UA_APP_ID = "AWS_SDK_UA_APP_ID";
        private const string AWS_ACCOUNT_ID_ENDPOINT_MODE = "AWS_ACCOUNT_ID_ENDPOINT_MODE";
        private const string AWS_REQUEST_CHECKSUM_CALCULATION = "AWS_REQUEST_CHECKSUM_CALCULATION";
        private const string AWS_RESPONSE_CHECKSUM_VALIDATION = "AWS_RESPONSE_CHECKSUM_VALIDATION";
        private const string AWS_USE_FIPS_ENDPOINT_ENVIRONMENT_VARIABLE = EnvironmentVariableInternalConfiguration.ENVIRONMENT_VARIABLE_AWS_USE_FIPS_ENDPOINT;
        private const long DefaultMinCompressionSizeBytes = 10240;

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
            .AppendLine("[awsConfigsAwsProfileName]")
            .AppendLine("region=eu-north-1")
            .AppendLine("aws_access_key_id=awsprofilename_aws_access_key_id")
            .AppendLine("aws_secret_access_key=awsprofilename_aws_secret_access_key")
            .AppendLine("[retries]")
            .AppendLine("max_attempts=100")
            .AppendLine("retry_mode=standard")
            .AppendLine("[dualstack-enabled]")
            .AppendLine("use_dualstack_endpoint=true")
            .AppendLine("[dualstack-disabled]")
            .AppendLine("use_dualstack_endpoint=false")
            .AppendLine("[fips-enabled]")
            .AppendLine("use_fips_endpoint=true")
            .AppendLine("[fips-disabled]")
            .AppendLine("use_fips_endpoint=false")
            .AppendLine("[request-compression-enabled]")
            .AppendLine("disable_request_compression=false")
            .AppendLine("[request-compression-disabled]")
            .AppendLine("disable_request_compression=true")
            .AppendLine("[min_compression_size_bytes]")
            .AppendLine("request_min_compression_size_bytes=128")
            .AppendLine("[set_sdk_ua_app_id]")
            .AppendLine("sdk_ua_app_id=myAppId")
            .AppendLine("[ec-metadata-v1-enabled]")
            .AppendLine("ec2_metadata_v1_disabled=false")
            .AppendLine("[ec-metadata-v1-disabled]")
            .AppendLine("ec2_metadata_v1_disabled=true")
            .AppendLine("[account_id_endpoint_mode_disabled]")
            .AppendLine("account_id_endpoint_mode=disabled")
            .AppendLine("[account_id_endpoint_mode_required]")
            .AppendLine("account_id_endpoint_mode=required")
            .AppendLine("[request_checksum_calculation_when_supported]")
            .AppendLine("request_checksum_calculation=when_supported")
            .AppendLine("[request_checksum_calculation_when_required]")
            .AppendLine("request_checksum_calculation=when_required")
            .AppendLine("[request_checksum_calculation_invalid]")
            .AppendLine("request_checksum_calculation=always")
            .AppendLine("[response_checksum_validation_when_supported]")
            .AppendLine("response_checksum_validation=when_supported")
            .AppendLine("[response_checksum_validation_when_required]")
            .AppendLine("response_checksum_validation=when_required")
            .AppendLine("[response_checksum_validation_invalid]")
            .AppendLine("response_checksum_validation=always")
            .ToString();

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void TestDefaultProfile(string awsProfileValue)
        {
            using (new FallbackFactoryTestFixture(ProfileText, awsProfileValue))
            {
                var creds = FallbackCredentialsFactory.GetCredentials();
                Assert.AreEqual("default_aws_access_key_id", creds.GetCredentials().AccessKey);

                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.USWest2, region);

                var enabled = FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled;
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
            var newEnvVariables = new Dictionary<string, string>()
            {
                { EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_REGION, string.Empty },
                { EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_DEFAULT_REGION, string.Empty },
            };

            using (new FallbackFactoryTestFixture(ProfileText, "other", newEnvVariables))
            {
                var creds = FallbackCredentialsFactory.GetCredentials();
                Assert.AreEqual("other_aws_access_key_id", creds.GetCredentials().AccessKey);

                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.USWest1, region);


                var enabled = FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled;
                Assert.IsTrue(enabled.HasValue);
                Assert.IsFalse(enabled.Value);
            }
        }

        [TestMethod]
        public void TestOther2Profile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, "other2"))
            {
                var enabled = FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled;
                Assert.IsTrue(enabled.HasValue);
                Assert.IsTrue(enabled.Value);
            }
        }
        
        [TestMethod]
        public void TestProcessCredentialProfile()
        {
            var newEnvVariables = new Dictionary<string, string>()
            {
                { EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_REGION, string.Empty },
                { EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_DEFAULT_REGION, string.Empty },
            };

            using (new FallbackFactoryTestFixture(ProfileText, "processCredential", newEnvVariables))
            {
                var credentials = FallbackCredentialsFactory.GetCredentials().GetCredentials();
                Assert.AreEqual(ProcessAWSCredentialsTest.ActualAccessKey, credentials.AccessKey);
                Assert.AreEqual(ProcessAWSCredentialsTest.ActualSecretKey, credentials.SecretKey);
                
                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.USWest1, region);
            }
        }

        [TestMethod]
        public void TestAwsConfigsAwsProfileNameProfile()
        {
            var newEnvVariables = new Dictionary<string, string>()
            {
                { EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_REGION, string.Empty },
                { EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_DEFAULT_REGION, string.Empty },
            };

            using (new FallbackFactoryTestFixture(ProfileText, "awsConfigsAwsProfileName", newEnvVariables, true))
            {
                var creds = FallbackCredentialsFactory.GetCredentials();
                Assert.AreEqual("awsprofilename_aws_access_key_id", creds.GetCredentials().AccessKey);
                Assert.AreEqual("awsprofilename_aws_secret_access_key", creds.GetCredentials().SecretKey);

                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.EUNorth1, region);
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
                var enabled = FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled;
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

        [DataTestMethod]
        [DataRow(true, false, "dualstack-disabled", true)]  // service client should supersede conflicting env var and profile values
        [DataRow(false, true, "dualstack-enabled", false)]
        [DataRow(null, true, "dualstack-disabled", true)]   // env var should supersede conflicting profile value
        [DataRow(null, false, "dualstack-enabled", false)]
        [DataRow(null, null, "dualstack-enabled", true)]    // profile should drive value
        [DataRow(null, null, "dualstack-disabled", false)]
        [DataRow(null, null, "default", false)]             // should default to false when no config values specified
        public void TestDualstackConfigurationHierarchy(bool? clientConfigValue, bool? envVarValue, string profileName, bool expectedUseDualstackEndpointValue)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            if (clientConfigValue.HasValue)
            {
                config.UseDualstackEndpoint = clientConfigValue.Value;
            }

            var envVariables = new Dictionary<string, string>();
            if (envVarValue.HasValue)
            {
                envVariables.Add(AWS_USE_DUALSTACK_ENDPOINT_ENVIRONMENT_VARIABLE, envVarValue.Value.ToString());
            }

            using (new FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedUseDualstackEndpointValue, config.UseDualstackEndpoint);
            }
        }

        [DataTestMethod]
        [DataRow(true, false, "request-compression-disabled", true)]  // service client should supersede conflicting env var and profile values
        [DataRow(false, true, "request-compression-enabled", false)]
        [DataRow(null, true, "request-compression-disabled", true)]   // env var should supersede conflicting profile value
        [DataRow(null, false, "request-compression-enabled", false)]
        [DataRow(null, null, "request-compression-enabled", false)]    // profile should drive value
        [DataRow(null, null, "request-compression-disabled", true)]
        [DataRow(null, null, "default", false)]             // should default to false when no config values specified
        public void TestDisableCompressionConfigurationHierarchy(bool? clientConfigValue, bool? envVarValue, string profileName, bool expectedRequestCompressionValue)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            if (clientConfigValue.HasValue)
            {
                config.DisableRequestCompression = clientConfigValue.Value;
            }

            var envVariables = new Dictionary<string, string>();
            if (envVarValue.HasValue)
            {
                envVariables.Add(AWS_DISABLE_REQUEST_COMPRESSION, envVarValue.Value.ToString());
            }

            using (new FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedRequestCompressionValue, config.DisableRequestCompression);
            }
        }

        [DataTestMethod]
        [DataRow(3L, 2L, "min_compression_size_bytes", 3)]  // service client should supersede conflicting env var and profile values
        [DataRow(null, 2L, "min_compression_size_bytes", 2)]
        [DataRow(null, null, "min_compression_size_bytes", 128)]   // env var should supersede conflicting profile value
        [DataRow(null, null, "default", DefaultMinCompressionSizeBytes)]  // should default to DefaultMinCompressionSizeBytes when no config values specified
        public void TestMinCompressionSizeBytesConfigurationHierarchy(long? clientConfigValue, long? envVarValue, string profileName, long expectedMinCompressionSizeValue)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            if (clientConfigValue.HasValue)
            {
                config.RequestMinCompressionSizeBytes = clientConfigValue.Value;
            }

            var envVariables = new Dictionary<string, string>();
            if (envVarValue.HasValue)
            {
                envVariables.Add(AWS_REQUEST_MIN_COMPRESSION_SIZE_BYTES, envVarValue.Value.ToString());
            }

            using (new FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedMinCompressionSizeValue, config.RequestMinCompressionSizeBytes);
            }
        }

        [DataTestMethod]
        [DataRow("test123", "test12345", "set_sdk_ua_app_id", "test123")]  // service client should supersede conflicting env var and profile values
        [DataRow(null, "test12345", "set_sdk_ua_app_id", "test12345")]   // env var should supersede conflicting profile value
        [DataRow(null, null, "set_sdk_ua_app_id", "myAppId")]  // Use app id configured for the profile
        [DataRow(null, null, null, null)]  // should default to DefaultMinCompressionSizeBytes when no config values specified
        public void TestClientAppIdConfigurationHierarchy(string clientConfigValue, string envVarValue, string profileName, string expectedValue)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            if (clientConfigValue != null)
            {
                config.ClientAppId = clientConfigValue;
            }

            var envVariables = new Dictionary<string, string>();
            if (envVarValue != null)
            {
                envVariables.Add(AWS_SDK_UA_APP_ID, envVarValue);
            }

            using (new FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedValue, config.ClientAppId);
            }
        }

        [DataTestMethod]
        [DataRow(true, false, "fips-disabled", true)]  // service client should supersede conflicting env var and profile values
        [DataRow(false, true, "fips-enabled", false)]
        [DataRow(null, true, "fips-disabled", true)]   // env var should supersede conflicting profile value
        [DataRow(null, false, "fips-enabled", false)]
        [DataRow(null, null, "fips-enabled", true)]    // profile should drive value
        [DataRow(null, null, "fips-disabled", false)]
        [DataRow(null, null, "default", false)]             // should default to false when no config values specified
        public void TestFIPSConfigurationHierarchy(bool? clientConfigValue, bool? envVarValue, string profileName, bool expectedUseFIPSEndpointValue)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            if (clientConfigValue.HasValue)
            {
                config.UseFIPSEndpoint = clientConfigValue.Value;
            }

            var envVariables = new Dictionary<string, string>();
            if (envVarValue.HasValue)
            {
                envVariables.Add(AWS_USE_FIPS_ENDPOINT_ENVIRONMENT_VARIABLE, envVarValue.Value.ToString());
            }

            using (new FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedUseFIPSEndpointValue, config.UseFIPSEndpoint);
            }
        }

        /// <summary>
        /// Tests the precedence of the account id endpoint mode configuration hierarchy.
        /// </summary>
        /// <param name="clientConfigValue"></param>
        /// <param name="envVarValue"></param>
        /// <param name="profileName"></param>
        /// <param name="expectedAccountIdEndpointMode"></param>
        [DataTestMethod]
        [DataRow(AccountIdEndpointMode.REQUIRED, "PREFERRED", "account_id_endpoint_mode_required", AccountIdEndpointMode.REQUIRED)]  // service client should supersede conflicting env var and profile values
        [DataRow(null, "", "default", AccountIdEndpointMode.PREFERRED)] // default value should be preferred
        [DataRow(null, "REQUIRED", "account_id_endpoint_mode_disabled", AccountIdEndpointMode.REQUIRED)]   // env var should supersede conflicting profile value
        [DataRow(null, "DISABLED", "account_id_endpoint_mode_required", AccountIdEndpointMode.DISABLED)]
        [DataRow(null, null, "account_id_endpoint_mode_disabled", AccountIdEndpointMode.DISABLED)]    // profile should drive value
        [DataRow(null, null, "account_id_endpoint_mode_required", AccountIdEndpointMode.REQUIRED)]
        [DataRow(null, null, "default", AccountIdEndpointMode.PREFERRED)]             // should default to false when no config values specified
        public void TestAccountIdEndpointMode(AccountIdEndpointMode? clientConfigValue, string envVarValue, string profileName, AccountIdEndpointMode expectedAccountIdEndpointMode)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            if (clientConfigValue.HasValue)
            {
                config.AccountIdEndpointMode = clientConfigValue.Value;
            }

            var envVariables = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(envVarValue))
            {
                envVariables.Add(AWS_ACCOUNT_ID_ENDPOINT_MODE, envVarValue);
            }

            using (new FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedAccountIdEndpointMode, config.AccountIdEndpointMode);
            }
        }

        [DataTestMethod]
        [DataRow(RequestChecksumCalculation.WHEN_REQUIRED, RequestChecksumCalculation.WHEN_SUPPORTED, "request_checksum_calculation_when_supported", RequestChecksumCalculation.WHEN_REQUIRED)] // service client should supersede conflicting env var and profile values
        [DataRow(RequestChecksumCalculation.WHEN_SUPPORTED, RequestChecksumCalculation.WHEN_REQUIRED, "request_checksum_calculation_when_required", RequestChecksumCalculation.WHEN_SUPPORTED)]
        [DataRow(null, RequestChecksumCalculation.WHEN_REQUIRED, "request_checksum_calculation_when_supported", RequestChecksumCalculation.WHEN_REQUIRED)] // env var should supersede conflicting profile value
        [DataRow(null, RequestChecksumCalculation.WHEN_SUPPORTED, "request_checksum_calculation_when_required", RequestChecksumCalculation.WHEN_SUPPORTED)]
        [DataRow(null, null, "request_checksum_calculation_when_required", RequestChecksumCalculation.WHEN_REQUIRED)] // profile should drive value
        [DataRow(null, null, "request_checksum_calculation_when_supported", RequestChecksumCalculation.WHEN_SUPPORTED)] 
        [DataRow(null, null, "request_checksum_calculation_invalid", RequestChecksumCalculation.WHEN_SUPPORTED)] // should default to RequestChecksumCalculation.WHEN_SUPPORTED when invalid profile value specified
        [DataRow(null, null, "default", RequestChecksumCalculation.WHEN_SUPPORTED)] // should default to RequestChecksumCalculation.WHEN_SUPPORTED when no config values specified
        public void TestRequestChecksumCalculationConfigurationHierarchy(RequestChecksumCalculation? clientConfigValue, RequestChecksumCalculation? envVarValue, string profileName, RequestChecksumCalculation expectedRequestChecksumCalculationValue)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            if (clientConfigValue.HasValue)
            {
                config.RequestChecksumCalculation = clientConfigValue.Value;
            }

            var envVariables = new Dictionary<string, string>();
            if (envVarValue.HasValue)
            {
                envVariables.Add(AWS_REQUEST_CHECKSUM_CALCULATION, envVarValue.Value.ToString());
            }

            using (new FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedRequestChecksumCalculationValue, config.RequestChecksumCalculation);
            }
        }

        [DataTestMethod]
        [DataRow(ResponseChecksumValidation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "response_checksum_validation_when_supported", ResponseChecksumValidation.WHEN_REQUIRED)] // service client should supersede conflicting env var and profile values
        [DataRow(ResponseChecksumValidation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "response_checksum_validation_when_required", ResponseChecksumValidation.WHEN_SUPPORTED)]
        [DataRow(null, ResponseChecksumValidation.WHEN_REQUIRED, "response_checksum_validation_when_supported", ResponseChecksumValidation.WHEN_REQUIRED)] // env var should supersede conflicting profile value
        [DataRow(null, ResponseChecksumValidation.WHEN_SUPPORTED, "response_checksum_validation_when_required", ResponseChecksumValidation.WHEN_SUPPORTED)]
        [DataRow(null, null, "response_checksum_validation_when_required", ResponseChecksumValidation.WHEN_REQUIRED)] // profile should drive value
        [DataRow(null, null, "response_checksum_validation_when_supported", ResponseChecksumValidation.WHEN_SUPPORTED)]
        [DataRow(null, null, "response_checksum_validation_invalid", ResponseChecksumValidation.WHEN_SUPPORTED)] // should default to ResponseChecksumValidation.WHEN_SUPPORTED when invalid profile value specified
        [DataRow(null, null, "default", ResponseChecksumValidation.WHEN_SUPPORTED)] // should default to ResponseChecksumValidation.WHEN_SUPPORTED when no config values specified
        public void TestResponseChecksumValidationConfigurationHierarchy(ResponseChecksumValidation? clientConfigValue, ResponseChecksumValidation? envVarValue, string profileName, ResponseChecksumValidation expectedResponseChecksumValidationValue)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            if (clientConfigValue.HasValue)
            {
                config.ResponseChecksumValidation = clientConfigValue.Value;
            }

            var envVariables = new Dictionary<string, string>();
            if (envVarValue.HasValue)
            {
                envVariables.Add(AWS_RESPONSE_CHECKSUM_VALIDATION, envVarValue.Value.ToString());
            }

            using (new FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedResponseChecksumValidationValue, config.ResponseChecksumValidation);
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
                return req.DurationSeconds.Equals(dummyOptions.DurationSeconds) &&
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
                return req.DurationSeconds.Equals(dummyOptions.DurationSeconds) &&
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
            var mockClient = new Mock<ICoreAmazonSTS>();
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
            var mockClient = new Mock<ICoreAmazonSTS>();
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
            var mockClient = new Mock<ICoreAmazonSTS>();
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
            var mockClient = new Mock<ICoreAmazonSTS>();
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

        // Further FallbackFactory tests involving retries live in AWSSDK.UnitTests.SecurityToken.Custom.FallbackCredentialsFactorySTSTests.
        public class AssumeRoleWithWebIdentityTestCredentials : AssumeRoleWithWebIdentityCredentials
        {
            public ICoreAmazonSTS Client { get; set; }
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

            protected override ICoreAmazonSTS CreateClient()
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
            private readonly CredentialProfileStoreChain originalConfigurationChain;

            private readonly string originalAWSProfileValue;

            private readonly string originalAwsconfigAwsProfileName;
            private readonly string originalAwsconfigAwsProfilesLocation;


            private readonly Dictionary<string, string> originalEnvironmentVariables = new Dictionary<string, string>();

            public FallbackFactoryTestFixture(string sharedCredsFileContent, string awsProfileValue, Dictionary<string, string> newEnvironmentVariables = null, bool setAwsConfigsProfileValue = false)
            {
                sharedFixture = new SharedCredentialsFileTestFixture(sharedCredsFileContent);
                netSdkFixture = new NetSDKCredentialsFileTestFixture();

                originalCredsChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalRegionChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));


                originalConfigurationChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackInternalConfigurationFactory), "_credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackInternalConfigurationFactory), "_credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalAWSProfileValue = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
                if (!setAwsConfigsProfileValue) Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, awsProfileValue);

                if (newEnvironmentVariables != null)
                {
                    foreach (var envVariable in newEnvironmentVariables)
                    {
                        var originalValue = Environment.GetEnvironmentVariable(envVariable.Key);
                        Environment.SetEnvironmentVariable(envVariable.Key, envVariable.Value);
                        originalEnvironmentVariables.Add(envVariable.Key, originalValue);
                    }
                }

                originalAwsconfigAwsProfileName = AWSConfigs.AWSProfileName;
                originalAwsconfigAwsProfilesLocation = AWSConfigs.AWSProfilesLocation;
                if (setAwsConfigsProfileValue)
                {
                    AWSConfigs.AWSProfileName = awsProfileValue;
                    AWSConfigs.AWSProfilesLocation = sharedFixture.CredentialsFilePath;
                }

                try
                {
                    // reset before use to ensure the new credentialProfileChains are used.
                    FallbackCredentialsFactory.Reset();
                    FallbackRegionFactory.Reset();
                    FallbackInternalConfigurationFactory.Reset();
                }
                catch (Exception ex)
                {   // If any exceptions happen during the intial resets, perhaps due to invalid config
                    // dispose right away to reset back to the initial configuration
                    Dispose();
                    throw ex;
                }
            }

            public void Dispose()
            {
                foreach (var envVariable in originalEnvironmentVariables)
                {
                    Environment.SetEnvironmentVariable(envVariable.Key, envVariable.Value);
                }

                Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, originalAWSProfileValue);

                AWSConfigs.AWSProfileName = originalAwsconfigAwsProfileName;
                AWSConfigs.AWSProfilesLocation = originalAwsconfigAwsProfilesLocation;

                ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain", originalRegionChain);
                ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain", originalCredsChain);
                ReflectionHelpers.Invoke(typeof(FallbackInternalConfigurationFactory), "_credentialProfileChain", originalConfigurationChain);

                netSdkFixture.Dispose();
                sharedFixture.Dispose();

                FallbackCredentialsFactory.Reset();
                FallbackRegionFactory.Reset();
                FallbackInternalConfigurationFactory.Reset();
            }
        }
    }
}
