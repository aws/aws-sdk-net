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
using Amazon.Runtime.CredentialManagement.Internal;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SharedCredentialsFileTest
    {
        private static readonly Guid UniqueKey = Guid.NewGuid();

        private static class SampleValues
        {
            public const string SsoAccountId = "sso_account_id";
            public const string SsoRegion = "sso_region";
            public const string SsoRoleName = "sso_role_name";
            public const string SsoStartUrl = "sso_start_url";
            public const string SsoSession = "sso_session";
        }

        private static readonly string DefaultProfileText = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("aws_access_key_id=aws_access_key_id")
            .AppendLine("aws_secret_access_key=aws_secret_access_key")
            .ToString();

        private static readonly string SessionProfileText = new StringBuilder()
            .AppendLine("[session_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("aws_session_token=session_aws_session_token")
            .ToString();

        private static readonly string ProfileSessionProfileText = new StringBuilder()
            .AppendLine("[profile session_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("aws_session_token=session_aws_session_token")
            .ToString();

        private static readonly CredentialProfileOptions SessionProfileOptions = new CredentialProfileOptions
        {
            AccessKey = "session_aws_access_key_id",
            SecretKey = "session_aws_secret_access_key",
            Token = "session_aws_session_token"
        };

        private static readonly string SessionProfileTextUpdated = new StringBuilder()
            .AppendLine("[session_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("aws_session_token=session_aws_session_token_UPDATED")
            .ToString();

        private static readonly CredentialProfileOptions SessionProfileOptionsUpdated = new CredentialProfileOptions
        {
            AccessKey = "session_aws_access_key_id",
            SecretKey = "session_aws_secret_access_key",
            Token = "session_aws_session_token_UPDATED"
        };

        private static readonly string AssumeRoleMfaProfileText = new StringBuilder()
            .AppendLine("[assume_role_mfa_profile]")
            .AppendLine("mfa_serial=mfa_serial_number")
            .AppendLine("role_arn=assume_role_arn")
            .Append("source_profile=basic_profile")
            .ToString();

        private static readonly CredentialProfileOptions AssumeRoleMfaProfileOptions = new CredentialProfileOptions
        {
            SourceProfile = "basic_profile",
            RoleArn = "assume_role_arn",
            MfaSerial = "mfa_serial_number"
        };

#if !BCL35
        private static readonly string SsoProfileText = new StringBuilder()
            .AppendLine("[sso]")
            .AppendLine($"sso_account_id={SampleValues.SsoAccountId}")
            .AppendLine($"sso_region={SampleValues.SsoRegion}")
            .AppendLine($"sso_role_name={SampleValues.SsoRoleName}")
            .Append($"sso_start_url={SampleValues.SsoStartUrl}")
            .ToString();

        private static readonly string SsoSplitProfileText = new StringBuilder()
            .AppendLine("[profile sso]")
            .AppendLine($"sso_account_id={SampleValues.SsoAccountId}")
            .AppendLine($"sso_role_name={SampleValues.SsoRoleName}")
            .AppendLine($"sso_session = {SampleValues.SsoSession}")
            .AppendLine()
            .AppendLine($"[sso-session {SampleValues.SsoSession}]")
            .AppendLine($"sso_region={SampleValues.SsoRegion}")
            .Append($"sso_start_url={SampleValues.SsoStartUrl}")
            .ToString();

        private static readonly string SsoSplitProfileMissingSessionText = new StringBuilder()
            .AppendLine("[profile sso]")
            .AppendLine($"sso_account_id={SampleValues.SsoAccountId}")
            .AppendLine($"sso_role_name={SampleValues.SsoRoleName}")
            .AppendLine($"sso_session = {SampleValues.SsoSession}")
            .AppendLine()
            .ToString();

        private static readonly string SsoProfileCredentialsText = new StringBuilder()
            .AppendLine("[sso]")
            .AppendLine("aws_access_key_id=aws_access_key_id")
            .AppendLine("aws_secret_access_key=aws_secret_access_key")
            .ToString();

        private static readonly string UpdatedCredentialsText = new StringBuilder()
            .AppendLine("[sso]")
            .AppendLine("aws_access_key_id=updated_aws_access_key_id")
            .AppendLine("aws_secret_access_key=updated_aws_secret_access_key")
            .ToString();

        private static readonly string UpdatedSsoSplitProfileText = new StringBuilder()
            .AppendLine("[profile sso]")
            .AppendLine($"sso_account_id=updated_{SampleValues.SsoAccountId}")
            .AppendLine($"sso_role_name=updated_{SampleValues.SsoRoleName}")
            .AppendLine($"sso_session = {SampleValues.SsoSession}")
            .AppendLine()
            .AppendLine($"[sso-session {SampleValues.SsoSession}]")
            .AppendLine($"sso_region={SampleValues.SsoRegion}")
            .Append($"sso_start_url={SampleValues.SsoStartUrl}")
            .ToString();

        private static readonly CredentialProfileOptions SsoProfileOptions = new CredentialProfileOptions
        {
            SsoAccountId = SampleValues.SsoAccountId,
            SsoRegion = SampleValues.SsoRegion,
            SsoRoleName = SampleValues.SsoRoleName,
            SsoStartUrl = SampleValues.SsoStartUrl,
        };

        private static readonly CredentialProfileOptions SsoProfileWithSessionOptions = new CredentialProfileOptions
        {
            SsoAccountId = SampleValues.SsoAccountId,
            SsoRegion = SampleValues.SsoRegion,
            SsoRoleName = SampleValues.SsoRoleName,
            SsoStartUrl = SampleValues.SsoStartUrl,
            SsoSession = SampleValues.SsoSession
        };

        private static readonly CredentialProfileOptions UpdatedSsoSplitProfileWithCredentialsOptions = new CredentialProfileOptions
        {
            AccessKey = "updated_aws_access_key_id",
            SecretKey = "updated_aws_secret_access_key",
            SsoAccountId = $"updated_{SampleValues.SsoAccountId}",
            SsoRoleName = $"updated_{SampleValues.SsoRoleName}",
            SsoSession = SampleValues.SsoSession,
            SsoRegion = SampleValues.SsoRegion,
            SsoStartUrl = SampleValues.SsoStartUrl,
        };
#endif

        private static readonly string BasicProfileConfigText = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .AppendLine("aws_secret_access_key=basic_aws_secret_access_key")
            .AppendLine("region=ca-central-1")
            .Append("toolkit_artifact_guid=" + UniqueKey)
            .ToString();

        private static readonly string BasicProfileCredentialsText =
            BasicProfileConfigText.Replace("[profile ", "[");

        private static readonly string LegacyBasicProfileCredentialsText = new StringBuilder()
            .AppendLine("[basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .AppendLine("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly string BasicProfileTextConfigPartial = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly string BasicProfileTextCredentialsPartial = new StringBuilder()
            .AppendLine("[basic_profile]")
            .Append("aws_access_key_id=basic_aws_access_key_id")
            .ToString();

        private static readonly CredentialProfileOptions BasicProfileOptions = new CredentialProfileOptions
        {
            AccessKey = "basic_aws_access_key_id",
            SecretKey = "basic_aws_secret_access_key"
        };

        private static readonly string BasicProfileTextCredentialsPrecedence = new StringBuilder()
            .AppendLine("[basic_profile]")
            .Append("aws_access_key_id=basic_aws_access_key_id_CREDENTIALS_FILE")
            .ToString();

        private static readonly string BasicProfileTextConfigPrecedence = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id_CONFIG_FILE")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly CredentialProfileOptions BasicProfilePrecedenceOptions = new CredentialProfileOptions
        {
            AccessKey = "basic_aws_access_key_id_CREDENTIALS_FILE",
            SecretKey = "basic_aws_secret_access_key"
        };

        private static readonly string InvalidProfileText = new StringBuilder()
            .AppendLine("[invalid_profile]")
            .AppendLine("aws_access_key_id=invalid_access_key")
            .AppendLine("invalid_key=invalid_value")
            .ToString();

        private static readonly string RegionOnlyProfileText = new StringBuilder()
            .AppendLine("[region_only_profile]")
            .AppendLine("region=us-east-1")
            .ToString();

        private static readonly string DefaultConfigurationModeOnlyProfileText = new StringBuilder()
            .AppendLine("[default_configuration_mode_only_profile]")
            .Append("defaults_mode=in-region")
            .ToString();

       private static readonly string EndpointDiscoveryEnabledOnlyProfileText = new StringBuilder()
            .AppendLine("[endpoint_discovery_enabled_only_profile]")
            .Append("endpoint_discovery_enabled=true")
            .ToString();

        private static readonly string EndpointDiscoveryEnabledOnlyProfileText_Invalid = new StringBuilder()
            .AppendLine("[endpoint_discovery_enabled_only_profile]")
            .AppendLine("endpoint_discovery_enabled=notvalid")
            .ToString();

        private static readonly string RetriesLegacyModeProfileText = new StringBuilder()
            .AppendLine("[retries_legacymode_profile_text]")
            .Append("retry_mode=legacy")
            .ToString();

        private static readonly string RetriesStandardModeProfileText = new StringBuilder()
            .AppendLine("[retries_standardmode_profile_text]")
            .Append("retry_mode=standard")
            .ToString();

        private static readonly string RetriesAdaptiveModeProfileText = new StringBuilder()
            .AppendLine("[retries_adaptivemode_profile_text]")
            .Append("retry_mode=adaptive")
            .ToString();

        private static readonly string RetriesInvalidModeProfileText = new StringBuilder()
            .AppendLine("[retries_invalidmode_profile_text]")
            .Append("retry_mode=invalid_mode")
            .ToString();

        private static readonly string RetriesMaxAttemptsProfileText = new StringBuilder()
            .AppendLine("[retries_max_attempts_profile_text]")
            .Append("max_attempts=100")
            .ToString();


        private static readonly CredentialProfileOptions SAMLRoleProfileOptions = new CredentialProfileOptions
        {
            EndpointName = "endpoint_name",
            RoleArn = "saml_arn",
            UserIdentity = "user_identity"
        };

        private static readonly string UpdatedProfileTypeTextBefore = new StringBuilder()
            .AppendLine("[updated_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .AppendLine("aws_session_token=session_aws_session_token")
            .Append("property=value")
            .ToString();

        private static readonly CredentialProfileOptions UpdatedProfileTypeOptionsBefore = new CredentialProfileOptions
        {
            AccessKey = "session_aws_access_key_id",
            SecretKey = "session_aws_secret_access_key",
            Token = "session_aws_session_token"
        };

        private static readonly Dictionary<string, string> UpdatedProfileTypePropertiesBeforeAndAfter = new Dictionary<string, string>
        {
            { "property", "value" }
        };

        private static readonly string UpdatedProfileTypeTextAfter = new StringBuilder()
            .AppendLine("[updated_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("property=value")
            .ToString();

        private static readonly CredentialProfileOptions UpdatedProfileTypeOptionsAfter = new CredentialProfileOptions
        {
            AccessKey = "session_aws_access_key_id",
            SecretKey = "session_aws_secret_access_key"
        };

        private static readonly CredentialProfileOptions UpdatedProfileWithPropertiesOptions = new CredentialProfileOptions
        {
            AccessKey = "session_aws_access_key_id",
            SecretKey = "session_aws_secret_access_key"
        };

        private static readonly string UpdatedProfileWithPropertiesTextBefore = new StringBuilder()
            .AppendLine("[basic_profile]")
            .AppendLine("property1=value1")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .AppendLine("property3=value3")
            .Append("property2=value2")
            .ToString();

        private static readonly Dictionary<string, string> UpdatedProfileWithPropertiesBefore = new Dictionary<string, string>
        {
            { "property1", "value1" },
            { "property2", "value2" },
            { "property3", "value3" }
        };

        private static readonly string UpdatedProfileWithPropertiesTextAfter = new StringBuilder()
            .AppendLine("[basic_profile]")
            .AppendLine("property1=value1")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .AppendLine("property3=valueZ")
            .Append("property4=value4")
            .ToString();

        private static readonly Dictionary<string, string> UpdatedProfileWithPropertiesAfter = new Dictionary<string, string>
        {
            { "property1", "value1" },
            { "property2", null },
            { "property3", "valueZ" },
            { "property4", "value4" }
        };

        private static readonly CredentialProfileOptions InvalidProfileOptions = new CredentialProfileOptions
        {
            AccessKey = "invalid_access_key"
        };

        private static readonly CredentialProfileOptions RegionOnlyProfileOptions = new CredentialProfileOptions();

        private static readonly CredentialProfileOptions EndpointDiscoveryEnabledOnlyProfileOptions = new CredentialProfileOptions();

        private static readonly CredentialProfileOptions RetriesOnlyProfileOptions = new CredentialProfileOptions();

        private static readonly string OtherProfileTextForCopyAndRename = new StringBuilder()
            .AppendLine("[other_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .ToString();

        private static readonly string BasicProfileTextForCopyAndRename = new StringBuilder()
            .AppendLine("[basic_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .AppendLine("# comment")
            .AppendLine("; other comment")
            .AppendLine("property=value")
            .ToString();

        [TestMethod]
        public void ReadDefaultConfigProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(null, DefaultProfileText))
            {
                tester.TestTryGetProfile("default", true, true);
            }
        }

        [TestMethod]
        public void ReadBasicProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(BasicProfileCredentialsText))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions, RegionEndpoint.CACentral1, UniqueKey);
            }
        }

        [TestMethod]
        public void WriteBasicProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfile("basic_profile", BasicProfileOptions, RegionEndpoint.CACentral1, UniqueKey, BasicProfileCredentialsText);
            }
        }

        [TestMethod]
        public void CredentialProfileStorePropertyIsSet()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                var writeProfile = new CredentialProfile("test_profile", new CredentialProfileOptions
                {
                    AccessKey = "access_key",
                    SecretKey = "secret_key"
                });
                Assert.IsNull(writeProfile.CredentialProfileStore);
                tester.CredentialsFile.RegisterProfile(writeProfile);
                Assert.IsTrue(object.ReferenceEquals(tester.CredentialsFile, writeProfile.CredentialProfileStore));

                CredentialProfile readProfile;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("test_profile", out readProfile));
                Assert.IsTrue(object.ReferenceEquals(tester.CredentialsFile, readProfile.CredentialProfileStore));
            }
        }

        [TestMethod]
        public void WriteBasicProfileReservedPropertyName()
        {
            TestReservedProperty("aws_access_key_id");
        }

        [TestMethod]
        public void WriteBasicProfileReservedPropertyNameIgnoreCase()
        {
            TestReservedProperty("Aws_Access_Key_ID");
        }

        private void TestReservedProperty(string propertyName)
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                var properties = new Dictionary<string, string>
                {
                    { propertyName, "aargh!" }
                };
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertWriteProfile("basic_profile", BasicProfileOptions, properties, BasicProfileCredentialsText);
                }, typeof(ArgumentException), "The profile properties dictionary cannot contain a key named " + propertyName +
                " because it is in the name mapping dictionary.");
            }
        }

        [TestMethod]
        public void ReadSessionProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText))
            {
                tester.ReadAndAssertProfile("session_profile", SessionProfileOptions);
            }
        }

        [TestMethod]
        public void WriteSessionProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfile("session_profile", SessionProfileOptions, SessionProfileText);
            }
        }

        [TestMethod]
        public void ReadAssumeRoleMfaProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(AssumeRoleMfaProfileText))
            {
                tester.ReadAndAssertProfile("assume_role_mfa_profile", AssumeRoleMfaProfileOptions);
            }
        }

        [TestMethod]
        public void WriteAssumeRoleMfaProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfile("assume_role_mfa_profile", AssumeRoleMfaProfileOptions, AssumeRoleMfaProfileText);
            }
        }

#if !BCL35
        [TestMethod]
        public void ReadSsoProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SsoProfileText, ""))
            {
                tester.ReadAndAssertProfile("sso", SsoProfileOptions);
            }
        }

        [TestMethod]
        public void ReadSsoSplitProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture("[sso]\r\n", SsoSplitProfileText))
            {
                tester.ReadAndAssertProfile("sso", SsoProfileWithSessionOptions);
            }
        }

        [TestMethod]
        public void UpdateSsoSplitProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SsoProfileCredentialsText, SsoSplitProfileText))
            {
                tester.AssertSsoSplitProfileWithCredentials("sso", UpdatedSsoSplitProfileWithCredentialsOptions, UpdatedCredentialsText, UpdatedSsoSplitProfileText);
            }
        }

        [TestMethod]
        public void ReadSsoSplitProfileMissingSession()
        {
            Exception exception = null;
            try
            {
                using (var tester = new SharedCredentialsFileTestFixture("[sso]", SsoSplitProfileMissingSessionText))
                {
                    tester.ReadAndAssertProfile("sso", SsoProfileWithSessionOptions);
                }
            }
            catch (Exception e)
            {
                exception = e;
            }

            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
            Assert.AreEqual("Invalid Configuration.  Failed to find sso_session [sso_session]", exception.Message);
        }

        [TestMethod]
        public void WriteSsoProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfile("sso", SsoProfileOptions, SsoProfileText);
            }
        }
#endif

        [TestMethod]
        public void ReadRegionOnlyProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(RegionOnlyProfileText))
            {
                tester.TestTryGetProfile("region_only_profile", true, false);
            }
        }

        [TestMethod]
        public void WriteRegionOnlyProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(RegionOnlyProfileText))
            {
                tester.AssertWriteProfile("region_only_profile", RegionOnlyProfileOptions, RegionOnlyProfileText);
            }
        }

        [TestMethod]
        public void ReadDefaultConfigurationModeNameOnlyProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(DefaultConfigurationModeOnlyProfileText))
            {
                var profile = tester.TestTryGetProfile("default_configuration_mode_only_profile", true, false);

                Assert.AreEqual("in-region", profile.DefaultConfigurationModeName);
            }
        }

        [TestMethod]
        public void ReadEndpointDiscoveryEnabledOnlyProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(EndpointDiscoveryEnabledOnlyProfileText))
            {
                tester.TestTryGetProfile("endpoint_discovery_enabled_only_profile", true, false);
            }
        }

        [TestMethod]
        public void WriteEndpointDiscoveryEnabledOnlyProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfile("endpoint_discovery_enabled_only_profile", EndpointDiscoveryEnabledOnlyProfileOptions, true, EndpointDiscoveryEnabledOnlyProfileText);
            }
        }

        [TestMethod]
        public void ReadInvalidEndpointDiscoveryEnabledOnlyProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(EndpointDiscoveryEnabledOnlyProfileText_Invalid))
            {
                CredentialProfile profile1;
                Assert.IsFalse(tester.CredentialsFile.TryGetProfile("endpoint_discovery_enabled_only_profile", out profile1));
            }
        }

        [TestMethod]
        public void ReadRetriesLegacyModeProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(RetriesLegacyModeProfileText))
            {
                tester.TestTryGetProfile("retries_legacymode_profile_text", true, false);
            }
        }

        [TestMethod]
        public void WriteRetriesLegacyModeProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfileRetryMode("retries_legacymode_profile_text", RetriesOnlyProfileOptions, RequestRetryMode.Legacy, RetriesLegacyModeProfileText);
            }
        }

        [TestMethod]
        public void ReadRetriesStandardModeProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(RetriesStandardModeProfileText))
            {
                tester.TestTryGetProfile("retries_standardmode_profile_text", true, false);
            }
        }

        [TestMethod]
        public void WriteRetriesStandardModeProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfileRetryMode("retries_standardmode_profile_text", RetriesOnlyProfileOptions, RequestRetryMode.Standard, RetriesStandardModeProfileText);
            }
        }

        [TestMethod]
        public void ReadRetriesAdaptiveModeProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(RetriesAdaptiveModeProfileText))
            {
                tester.TestTryGetProfile("retries_adaptivemode_profile_text", true, false);
            }
        }

        [TestMethod]
        public void WriteRetriesAdaptiveModeProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfileRetryMode("retries_adaptivemode_profile_text", RetriesOnlyProfileOptions, RequestRetryMode.Adaptive, RetriesAdaptiveModeProfileText);
            }
        }

        [TestMethod]
        public void ReadRetriesInvalidModeProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(RetriesInvalidModeProfileText))
            {
                CredentialProfile profile1;
                Assert.IsFalse(tester.CredentialsFile.TryGetProfile("retries_invalidmode_profile_text", out profile1));
            }
        }

        [TestMethod]
        public void ReadRetriesMaxAttemptsProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(RetriesMaxAttemptsProfileText))
            {
                tester.TestTryGetProfile("retries_max_attempts_profile_text", true, false);
            }
        }

        [TestMethod]
        public void WriteRetriesMaxAttemptsProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfileMaxAttempts("retries_max_attempts_profile_text", RetriesOnlyProfileOptions, 100, RetriesMaxAttemptsProfileText);
            }
        }


        [TestMethod]
        public void ReadInvalidProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(InvalidProfileText))
            {
                tester.TestTryGetProfile("invalid_profile", true, false);
            }
        }

        [TestMethod]
        public void WriteRegionCredentialsUntouched()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                // write the whole profile - credentials options and region
                var basicOptions = new CredentialProfileOptions
                {
                    AccessKey = "access_key",
                    SecretKey = "secret_key"
                };
                var profile = new CredentialProfile("WriteRegionKeepOptionsProfile", basicOptions);
                profile.Region = RegionEndpoint.USGovCloudWest1;
                tester.CredentialsFile.RegisterProfile(profile);

                // now write just the region
                var emptyOptions = new CredentialProfileOptions();
                var regionOnlyProfile = new CredentialProfile("WriteRegionKeepOptionsProfile", basicOptions);
                profile.Region = RegionEndpoint.APSouth1;
                tester.CredentialsFile.RegisterProfile(profile);

                // Make sure it has the original options and the new region
                var readProfile = tester.TestTryGetProfile("WriteRegionKeepOptionsProfile", true, true);
                Assert.AreEqual("access_key", readProfile.Options.AccessKey);
                Assert.AreEqual("secret_key", readProfile.Options.SecretKey);
                Assert.AreEqual(RegionEndpoint.APSouth1, readProfile.Region);
            }
        }

        [TestMethod]
        public void WriteInvalidProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(InvalidProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertWriteProfile("invalid_profile", InvalidProfileOptions, InvalidProfileText);
                }, typeof(ArgumentException), new Regex("The CredentialProfile provided is not a valid profile."));
            }
        }

        [TestMethod]
        public void ReadProfileDoesNotExist()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.TestTryGetProfile("profile_does_not_exist", false, false);
            }
        }

        [TestMethod]
        public void UpdateProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText))
            {
                tester.ReadAndAssertProfile("session_profile", SessionProfileOptions);
                tester.AssertWriteProfile("session_profile", SessionProfileOptionsUpdated, SessionProfileTextUpdated);
            }
        }

        [TestMethod]
        public void UpdateProfileDifferentType()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                tester.AssertWriteProfile("updated_profile", UpdatedProfileTypeOptionsBefore,
                    UpdatedProfileTypePropertiesBeforeAndAfter, UpdatedProfileTypeTextBefore);
                tester.AssertWriteProfile("updated_profile", UpdatedProfileTypeOptionsAfter,
                    UpdatedProfileTypePropertiesBeforeAndAfter, UpdatedProfileTypeTextAfter);
            }
        }

        [TestMethod]
        public void UpdateProfileWithProperties()
        {
            using (var tester = new SharedCredentialsFileTestFixture(UpdatedProfileWithPropertiesTextBefore))
            {
                tester.ReadAndAssertProfile("basic_profile", UpdatedProfileWithPropertiesOptions, UpdatedProfileWithPropertiesBefore);
                tester.AssertWriteProfile("basic_profile", UpdatedProfileWithPropertiesOptions, UpdatedProfileWithPropertiesAfter, UpdatedProfileWithPropertiesTextAfter);
            }
        }

        [TestMethod]
        public void DeleteProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText + Environment.NewLine + BasicProfileCredentialsText))
            {
                tester.CredentialsFile.UnregisterProfile("session_profile");
                tester.AssertCredentialsFileContents(BasicProfileCredentialsText);
            }
        }

        [TestMethod]
        public void ReadBasicProfileConfig()
        {
            using (var tester = new SharedCredentialsFileTestFixture(null, BasicProfileConfigText))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions, RegionEndpoint.CACentral1, UniqueKey);
            }
        }

        [TestMethod]
        public void ReadBasicProfileAllConfigExtraSpacesAndTabInName()
        {
            var basicProfileInConfigWithWhitespace = BasicProfileConfigText.Replace("profile basic_profile", "profile \t basic_profile");
            using (var tester = new SharedCredentialsFileTestFixture(null, basicProfileInConfigWithWhitespace))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions, RegionEndpoint.CACentral1, UniqueKey);
            }
        }

        [TestMethod]
        public void ReadBasicProfileAllConfigForgotProfileKeyword()
        {
            using (var tester = new SharedCredentialsFileTestFixture(null, BasicProfileCredentialsText))
            {
                CredentialProfile profile = null;
                Assert.IsFalse(tester.CredentialsFile.TryGetProfile("basic_profile", out profile));
                Assert.IsNull(profile);
            }
        }

        [TestMethod]
        public void DontReadBasicProfileFromIncompleteName()
        {
            // make sure that searching for "basic_pr" gives us nothing because the profile is really named "basic_profile"
            using (var tester = new SharedCredentialsFileTestFixture(null, BasicProfileConfigText))
            {
                CredentialProfile profile = null;
                Assert.IsFalse(tester.CredentialsFile.TryGetProfile("basic_pr", out profile));
                Assert.IsNull(profile);
            }
        }

        [TestMethod]
        public void ReadBasicProfileConfigInvalidGuid()
        {
            using (var tester = new SharedCredentialsFileTestFixture(null, BasicProfileConfigText.Replace(UniqueKey.ToString(), "blah")))
            {
                tester.TestTryGetProfile("basic_profile", false, false);
            }
        }


        [TestMethod]
        public void ReadBasicProfileSplit()
        {
            using (var tester = new SharedCredentialsFileTestFixture(
                BasicProfileTextCredentialsPartial, BasicProfileTextConfigPartial))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions);
            }
        }

        [TestMethod]
        public void ReadBasicProfileCredentialsTakesPrecedence()
        {
            using (var tester = new SharedCredentialsFileTestFixture(
                BasicProfileTextCredentialsPrecedence, BasicProfileTextConfigPrecedence))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfilePrecedenceOptions);
            }
        }

        [TestMethod]
        public void ReadUnsupportedProfileType()
        {
            HashSet<CredentialProfileType> originalWhitelist = null;
            var field = typeof(SharedCredentialsFile).GetField("ProfileTypeWhitelist", BindingFlags.NonPublic | BindingFlags.Static);
            try
            {
                // Instead of trying to read an unsupported profile type we remove the list of supported types and read one of those.
                // We do this because the check in the TryGetProfile method is there for future safety, and won't fail otherwise.

                //mock ProfileTypeWhitelist
                originalWhitelist = (HashSet<CredentialProfileType>)field.GetValue(null);
                field.SetValue(null, new HashSet<CredentialProfileType>());

                using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText))
                {
                    tester.TestTryGetProfile("session_profile", false, false);
                }
            }
            finally
            {
                // unmock ProfileTypeWhitelist
                field.SetValue(null, originalWhitelist);
            }
        }
        [TestMethod]
        public void ReadAWSSharedCredentialVariableFile()
        {
            try
            {
                using (var tester = new SharedCredentialsFileTestFixture(DefaultProfileText, isSharedCredentialsVarProvided: true))
                {
                    tester.TestTryGetProfile("default", true, true);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_SHARED_CREDENTIALS_FILE", null);
                //call static constructor again with reflection to reset the constructor
                Type sharedCredentialsFile = typeof(SharedCredentialsFile);
                sharedCredentialsFile.TypeInitializer.Invoke(null, null);
            }

        }
        [TestMethod]
        public void ReadAWSConfigFileVariableFile()
        {
            try
            {
                using (var tester = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: BasicProfileConfigText,isSharedCredentialsVarProvided:true, isSharedConfigVarProvided: true))
                {
                    tester.TestTryGetProfile("basic_profile", true, true);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_CONFIG_FILE", null);
                //call static constructor again with reflection to reset the constructor
                Type AWSConfigFile = typeof(SharedCredentialsFile);
                AWSConfigFile.TypeInitializer.Invoke(null, null);
            }
        }

        [TestMethod]
        public void ReadAWSConfigAndCredentialFileVariable()
        {
            try
            {
                using (var tester = new SharedCredentialsFileTestFixture(credentialsFileContents: BasicProfileTextCredentialsPrecedence, configFileContents: BasicProfileTextConfigPrecedence, isSharedConfigVarProvided: true, isSharedCredentialsVarProvided: true))
                {
                    tester.ReadAndAssertProfile("basic_profile", BasicProfilePrecedenceOptions);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_CONFIG_FILE", null);
                Environment.SetEnvironmentVariable("AWS_SHARED_CREDENTIALS_FILE", null);
                Type AWSConfigFile = typeof(SharedCredentialsFile);
                AWSConfigFile.TypeInitializer.Invoke(null, null);
                Type sharedCredentialsFile = typeof(SharedCredentialsFile);
                sharedCredentialsFile.TypeInitializer.Invoke(null, null);
            }
        }

        [TestMethod]
        public void ReadBasicProfileSplitForAWSConfigAndCredentialFileVariable()
        {
            try
            {
                using (var tester = new SharedCredentialsFileTestFixture(BasicProfileTextCredentialsPartial, BasicProfileTextConfigPartial, isSharedCredentialsVarProvided: true, isSharedConfigVarProvided: true))
                {
                    tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_CONFIG_FILE", null);
                Environment.SetEnvironmentVariable("AWS_SHARED_CREDENTIALS_FILE", null);
                Type AWSConfigFile = typeof(SharedCredentialsFile);
                AWSConfigFile.TypeInitializer.Invoke(null, null);
                Type sharedCredentialsFile = typeof(SharedCredentialsFile);
                sharedCredentialsFile.TypeInitializer.Invoke(null, null);
            }
        }

        [TestMethod]
        public void ReadBasicProfileSplitForAWSConfigVariable()
        {
            try
            {
                using (var tester = new SharedCredentialsFileTestFixture(credentialsFileContents: BasicProfileTextCredentialsPartial, configFileContents: BasicProfileTextConfigPartial, isSharedConfigVarProvided: true))
                {
                    tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_CONFIG_FILE", null);
                Type AWSConfigFile = typeof(SharedCredentialsFile);
                AWSConfigFile.TypeInitializer.Invoke(null, null);
            }
        }

        [TestMethod]
        public void ReadBasicProfileSplitForAWSCredentialsVariable()
        {
            try
            {
                using (var tester = new SharedCredentialsFileTestFixture(credentialsFileContents: BasicProfileTextCredentialsPartial,configFileContents: BasicProfileTextConfigPartial, isSharedCredentialsVarProvided: true))
                {
                    tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_SHARED_CREDENTIALS_FILE", null);
                Type sharedCredentialsFile = typeof(SharedCredentialsFile);
                sharedCredentialsFile.TypeInitializer.Invoke(null, null);
            }
        }

        [TestMethod]
        public void WriteUnsupportedProfileType()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertWriteProfile("saml_role_profile", SAMLRoleProfileOptions, null);
                }, typeof(ArgumentException), new Regex("SharedCredentialsFile does not support the SAMLRoleUserIdentity profile type."));
            }
        }

        [TestMethod]
        public void ListProfileNamesEmpty()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                var profileNames = tester.CredentialsFile.ListProfileNames();
                Assert.AreEqual(0, profileNames.Count);
            }
        }

        [TestMethod]
        public void ListProfileNames()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText))
            {
                var profileNames = tester.CredentialsFile.ListProfileNames();
                Assert.AreEqual(1, profileNames.Count);
                Assert.IsTrue(profileNames.Contains("session_profile"));
            }
        }

        [TestMethod]
        public void ListProfileNamesIncludeConfig()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText, BasicProfileConfigText))
            {
                var profileNames = tester.CredentialsFile.ListProfileNames();
                Assert.AreEqual(2, profileNames.Count);
                Assert.IsTrue(profileNames.Contains("session_profile"));
                Assert.IsTrue(profileNames.Contains("basic_profile"));
            }
        }

        [TestMethod]
        public void ListProfileNamesExcludeInvalid()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText + Environment.NewLine + InvalidProfileText))
            {
                var profileNames = tester.CredentialsFile.ListProfileNames();
                Assert.AreEqual(1, profileNames.Count);
                Assert.IsTrue(profileNames.Contains("session_profile"));
            }
        }

        [TestMethod]
        public void ListProfilesEmpty()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                var profiles = tester.CredentialsFile.ListProfiles();
                Assert.AreEqual(0, profiles.Count);
            }
        }

        [TestMethod]
        public void ListProfiles()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText))
            {
                var profiles = tester.CredentialsFile.ListProfiles();
                Assert.AreEqual(1, profiles.Count);
                Assert.AreEqual("session_profile", profiles[0].Name);
            }
        }

        [TestMethod]
        public void ListProfilesIncludeConfig()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText, BasicProfileConfigText))
            {
                var profiles = tester.CredentialsFile.ListProfiles();
                Assert.AreEqual(2, profiles.Count);
                var profileNames = profiles.Select(p => p.Name).ToList();
                Assert.IsTrue(profileNames.Contains("session_profile"));
                Assert.IsTrue(profileNames.Contains("basic_profile"));
            }
        }


        [TestMethod]
        public void ListProfilesWithProfileKeyword()
        {
            using (var tester = new SharedCredentialsFileTestFixture(ProfileSessionProfileText))
            {
                var profiles = tester.CredentialsFile.ListProfiles();
                Assert.AreEqual(1, profiles.Count);
                var profileNames = profiles.Select(p => p.Name).ToList();
                Assert.IsTrue(profileNames.Contains("session_profile"));
                tester.TestTryGetProfile("session_profile", true, true);
            }
        }

        [TestMethod]
        public void ListProfilesExcludeInvalidNoCredentials()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText + Environment.NewLine + InvalidProfileText))
            {
                var profiles = tester.CredentialsFile.ListProfiles();
                Assert.AreEqual(1, profiles.Count);
                Assert.AreEqual("session_profile", profiles[0].Name);
            }
        }

        [TestMethod]
        public void ListProfilesExcludeInvalidDuplicateProperty()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText + Environment.NewLine + "aws_session_token=session_aws_session_token"))
            {
                var profiles = tester.CredentialsFile.ListProfiles();
                Assert.AreEqual(0, profiles.Count);
            }
        }

        [TestMethod]
        public void RenameProfile()
        {
            RenameProfile(false, false);
        }

        [TestMethod]
        public void RenameProfileFromEqualsTo()
        {
            RenameProfile(false, true);
        }

        [TestMethod]
        public void RenameProfileWithUniqueKey()
        {
            RenameProfile(true, false);
        }

        public void RenameProfile(bool addUniqueKey, bool useSameName)
        {
            var profileText = BasicProfileTextForCopyAndRename;
            var fromName = "basic_profile";
            var toName = fromName + (useSameName ? "" : "2");

            if (addUniqueKey)
                profileText += "toolkit_artifact_guid=" + UniqueKey;

            using (var tester = new SharedCredentialsFileTestFixture(profileText))
            {
                // read the profile
                CredentialProfile before;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile(fromName, out before));

                // rename it
                tester.CredentialsFile.RenameProfile(fromName, toName);

                CredentialProfile profile1Reread;
                if (useSameName)
                    Assert.IsTrue(tester.CredentialsFile.TryGetProfile(fromName, out profile1Reread));
                else
                    Assert.IsFalse(tester.CredentialsFile.TryGetProfile(fromName, out profile1Reread));

                // make sure one with the new name exists
                CredentialProfile after;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile(toName, out after));

                if (useSameName)
                    Assert.AreEqual(before.Name, after.Name);
                else
                    Assert.AreNotEqual(before.Name, after.Name);

                // make sure the unique key is the same as before the rename
                if (addUniqueKey)
                    Assert.AreEqual(UniqueKey.ToString("D"), CredentialProfileUtils.GetUniqueKey(before));
                else
                    Assert.IsNull(CredentialProfileUtils.GetUniqueKey(before));
                Assert.AreEqual(CredentialProfileUtils.GetUniqueKey(before), CredentialProfileUtils.GetUniqueKey(after));

                // make sure everything is the same (except for the name if it's a real rename)
                if (!useSameName)
                    ReflectionHelpers.Invoke(after, "Name", before.Name);
                Assert.AreEqual(before, after);

                // make sure comments and other properties are unchanged after the rename
                tester.AssertCredentialsFileContents(profileText.Replace(fromName, toName));
            }
        }

        [TestMethod]
        public void RenameProfileSourceDoesNotExist()
        {
            using (var tester = new SharedCredentialsFileTestFixture(BasicProfileTextForCopyAndRename))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.CredentialsFile.RenameProfile("basic_profilex", "basic_profile2");
                }, typeof(ArgumentException), "Cannot rename section. The source section basic_profilex does not exist.");
            }
        }

        [TestMethod]
        public void RenameProfileTargetAlreadyExists()
        {
            using (var tester = new SharedCredentialsFileTestFixture(OtherProfileTextForCopyAndRename + BasicProfileTextForCopyAndRename))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.CredentialsFile.RenameProfile("other_profile", "basic_profile");
                }, typeof(ArgumentException), new Regex("Cannot rename section. The destination section basic_profile already exists."));
            }
        }

        [TestMethod]
        public void RenameProfileTargetAlreadyExistsForce()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                Create2Profiles(tester);
                tester.CredentialsFile.RenameProfile("profile1", "profile2", true);

                CredentialProfile readProfile;
                Assert.IsFalse(tester.CredentialsFile.TryGetProfile("profile1", out readProfile));
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("profile2", out readProfile));
                Assert.AreEqual(readProfile.Options.AccessKey, "access_key1");
                Assert.AreEqual(readProfile.Options.SecretKey, "secret_key1");
            }
        }

        [TestMethod]
        public void CopyProfile()
        {
            CopyProfile(false, false, false);
        }

        [TestMethod]
        public void CopyProfileFromEqualsTo()
        {
            CopyProfile(false, false, true);
        }

        [TestMethod]
        public void CopyProfileWithUniqueKey()
        {
            CopyProfile(true, false, false);
        }

        [TestMethod]
        public void CopyProfileWithUniqueKeyAndANotherSection()
        {
            CopyProfile(true, true, false);
        }

        public void CopyProfile(bool addUniqueKey, bool addAnotherSection, bool useSameName)
        {
            var profileText = BasicProfileTextForCopyAndRename;
            var fromName = "basic_profile";
            var toName = fromName + (useSameName ? "" : "2");

            if (addUniqueKey)
                profileText += "toolkit_artifact_guid=" + UniqueKey + Environment.NewLine;

            var anotherSection = addAnotherSection ? "[another_section]" + Environment.NewLine + "propertyx=valuex" + Environment.NewLine : "";

            using (var tester = new SharedCredentialsFileTestFixture(profileText + anotherSection))
            {
                // read the profile
                CredentialProfile profile1;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile(fromName, out profile1));

                // copy it
                tester.CredentialsFile.CopyProfile(fromName, toName);

                // make sure the original is untouched
                CredentialProfile profile1Reread;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile(fromName, out profile1Reread));
                Assert.AreEqual(profile1, profile1Reread);

                // make sure the copy exists
                CredentialProfile profile2;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile(toName, out profile2));

                if (useSameName)
                    Assert.AreEqual(profile1.Name, profile2.Name);
                else
                    Assert.AreNotEqual(profile1.Name, profile2.Name);


                if (addUniqueKey)
                {
                    if (useSameName)
                    {
                        Assert.AreEqual(UniqueKey.ToString("D"), CredentialProfileUtils.GetUniqueKey(profile1));
                        Assert.AreEqual(CredentialProfileUtils.GetUniqueKey(profile1), CredentialProfileUtils.GetUniqueKey(profile2));
                    }
                    else
                    {
                        Assert.AreEqual(UniqueKey.ToString("D"), CredentialProfileUtils.GetUniqueKey(profile1));
                        Assert.AreNotEqual(CredentialProfileUtils.GetUniqueKey(profile1), CredentialProfileUtils.GetUniqueKey(profile2));
                    }
                }
                else
                {
                    Assert.IsNull(CredentialProfileUtils.GetUniqueKey(profile1));
                    Assert.IsNull(CredentialProfileUtils.GetUniqueKey(profile2));
                }

                var contentsAfter = profileText;

                if (!useSameName)
                {
                    // make sure the comments and everything got copied
                    contentsAfter = (contentsAfter + anotherSection).TrimEnd() + Environment.NewLine;
                    if (addUniqueKey)
                    {
                        contentsAfter += profileText.Replace(fromName, toName)
                        .Replace(CredentialProfileUtils.GetUniqueKey(profile1).ToString(), CredentialProfileUtils.GetUniqueKey(profile2).ToString()).TrimEnd();
                    }
                    else
                    {
                        contentsAfter += profileText.Replace(fromName, toName);
                    }
                }

                tester.AssertCredentialsFileContents(contentsAfter);

                // make sure everything else on the copy is the same as the original
                string profile1Guid = CredentialProfileUtils.GetUniqueKey(profile1);
                CredentialProfileUtils.SetUniqueKey(profile2, profile1Guid == null ? (Guid?)null : new Guid(profile1Guid));
                ReflectionHelpers.Invoke(profile2, "Name", profile1.Name);
                Assert.AreEqual(profile1, profile2);

                //make sure the additional key came along
                var value1 = CredentialProfileUtils.GetProperty(profile1, "property");
                var value2 = CredentialProfileUtils.GetProperty(profile2, "property");
                Assert.AreEqual("value", value1);
                Assert.AreEqual(value1, value2);
            }
        }

        [TestMethod]
        public void CopyProfileSourceDoesNotExist()
        {
            using (var tester = new SharedCredentialsFileTestFixture(BasicProfileTextForCopyAndRename))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.CredentialsFile.CopyProfile("basic_profilex", "basic_profile2");
                }, typeof(ArgumentException), "Cannot copy section. The source section basic_profilex does not exist.");
            }
        }

        [TestMethod]
        public void CopyProfileTargetAlreadyExists()
        {
            using (var tester = new SharedCredentialsFileTestFixture(OtherProfileTextForCopyAndRename + BasicProfileTextForCopyAndRename))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.CredentialsFile.CopyProfile("other_profile", "basic_profile");
                }, typeof(ArgumentException), new Regex("Cannot copy section. The destination section basic_profile already exists."));
            }
        }

        [TestMethod]
        public void CopyProfileTargetAlreadyExistsForce()
        {
            using (var tester = new SharedCredentialsFileTestFixture())
            {
                Create2Profiles(tester);
                tester.CredentialsFile.CopyProfile("profile1", "profile2", true);

                CredentialProfile readProfile;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("profile1", out readProfile));
                Assert.AreEqual(readProfile.Options.AccessKey, "access_key1");
                Assert.AreEqual(readProfile.Options.SecretKey, "secret_key1");

                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("profile2", out readProfile));
                Assert.AreEqual(readProfile.Options.AccessKey, "access_key1");
                Assert.AreEqual(readProfile.Options.SecretKey, "secret_key1");
            }
        }
        private static void Create2Profiles(SharedCredentialsFileTestFixture tester)
        {
            var options1 = new CredentialProfileOptions
            {
                AccessKey = "access_key1",
                SecretKey = "secret_key1"
            };
            CredentialProfile profile1 = new CredentialProfile("profile1", options1);

            var options2 = new CredentialProfileOptions
            {
                AccessKey = "access_key2",
                SecretKey = "secret_key2"
            };

            CredentialProfile profile2 = new CredentialProfile("profile2", options2);
            tester.CredentialsFile.RegisterProfile(profile1);
            tester.CredentialsFile.RegisterProfile(profile2);
        }
    }
}
