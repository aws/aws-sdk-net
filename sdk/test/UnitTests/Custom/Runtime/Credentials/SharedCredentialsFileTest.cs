/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;
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

        private static readonly string SessionProfileText = new StringBuilder()
            .AppendLine("[session_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("aws_session_token=session_aws_session_token")
            .ToString();

        private static readonly CredentialProfileOptions SessionProfileOptions = new CredentialProfileOptions()
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

        private static readonly CredentialProfileOptions SessionProfileOptionsUpdated = new CredentialProfileOptions()
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

        private static readonly CredentialProfileOptions AssumeRoleMfaProfileOptions = new CredentialProfileOptions()
        {
            SourceProfile = "basic_profile",
            RoleArn = "assume_role_arn",
            MfaSerial = "mfa_serial_number"
        };

        private static readonly string BasicProfileConfigText = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .AppendLine("aws_secret_access_key=basic_aws_secret_access_key")
            .AppendLine("region=ca-central-1")
            .Append("vs_toolkit_artifact_guid=" + UniqueKey)
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

        private static readonly CredentialProfileOptions BasicProfileOptions = new CredentialProfileOptions()
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

        private static readonly CredentialProfileOptions BasicProfilePrecedenceOptions = new CredentialProfileOptions()
        {
            AccessKey = "basic_aws_access_key_id_CREDENTIALS_FILE",
            SecretKey = "basic_aws_secret_access_key"
        };

        private static readonly string InvalidProfileText = new StringBuilder()
            .AppendLine("[invalid_profile]")
            .AppendLine("invalid_key=invalid_value")
            .ToString();

        private static readonly CredentialProfileOptions SAMLRoleProfileOptions = new CredentialProfileOptions()
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

        private static readonly CredentialProfileOptions UpdatedProfileTypeOptionsBefore = new CredentialProfileOptions()
        {
            AccessKey = "session_aws_access_key_id",
            SecretKey = "session_aws_secret_access_key",
            Token = "session_aws_session_token"
        };

        private static readonly Dictionary<string, string> UpdatedProfileTypePropertiesBeforeAndAfter = new Dictionary<string, string>()
        {
            { "property", "value" }
        };

        private static readonly string UpdatedProfileTypeTextAfter = new StringBuilder()
            .AppendLine("[updated_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("property=value")
            .ToString();

        private static readonly CredentialProfileOptions UpdatedProfileTypeOptionsAfter = new CredentialProfileOptions()
        {
            AccessKey = "session_aws_access_key_id",
            SecretKey = "session_aws_secret_access_key"
        };

        private static readonly CredentialProfileOptions UpdatedProfileWithPropertiesOptions = new CredentialProfileOptions()
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

        private static readonly Dictionary<string,string> UpdatedProfileWithPropertiesBefore = new Dictionary<string, string>()
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

        private static readonly Dictionary<string, string> UpdatedProfileWithPropertiesAfter = new Dictionary<string, string>()
        {
            { "property1", "value1" },
            { "property2", null },
            { "property3", "valueZ" },
            { "property4", "value4" }
        };

        private static readonly CredentialProfileOptions InvalidProfileOptions = new CredentialProfileOptions();

        private static readonly string BasicProfileTextForCopyAndRename = new StringBuilder()
            .AppendLine("[basic_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .AppendLine("# comment")
            .AppendLine("; other comment")
            .AppendLine("property=value")
            .ToString();

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
                var properties = new Dictionary<string, string>()
                {
                    { propertyName, "aargh!" }
                };
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertWriteProfile("basic_profile", BasicProfileOptions, properties, BasicProfileCredentialsText);
                }, typeof(ArgumentException), "The profile properties dictionary cannot contain a key named "+ propertyName +
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

        [TestMethod]
        public void ReadInvalidProfile()
        {
            using (var tester = new SharedCredentialsFileTestFixture(InvalidProfileText))
            {
                tester.TestTryGetProfile("invalid_profile", true, false);
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
        public void ListProfilesExcludeInvalid()
        {
            using (var tester = new SharedCredentialsFileTestFixture(SessionProfileText + Environment.NewLine + InvalidProfileText))
            {
                var profiles = tester.CredentialsFile.ListProfiles();
                Assert.AreEqual(1, profiles.Count);
                Assert.AreEqual("session_profile", profiles[0].Name);
            }
        }

        [TestMethod]
        public void RenameProfile()
        {
            RenameProfile(false);
        }

        [TestMethod]
        public void RenameProfileWithUniqueKey()
        {
            RenameProfile(true);
        }

        public void RenameProfile(bool addUniqueKey)
        {
            var profileText = BasicProfileTextForCopyAndRename;

            if (addUniqueKey)
                profileText += "vs_toolkit_artifact_guid=" + UniqueKey;

            using (var tester = new SharedCredentialsFileTestFixture(profileText))
            {
                // read the profile
                CredentialProfile before;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("basic_profile", out before));

                // rename it
                tester.CredentialsFile.RenameProfile("basic_profile", "basic_profile2");

                // make sure there isn't one with the original name
                CredentialProfile profile1Reread;
                Assert.IsFalse(tester.CredentialsFile.TryGetProfile("basic_profile", out profile1Reread));

                // make sure one with the new name exists
                CredentialProfile after;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("basic_profile2", out after));
                Assert.AreNotEqual(before.Name, after.Name);

                // make sure the unique key is the same as before the rename
                if (addUniqueKey)
                    Assert.AreEqual(UniqueKey, CredentialProfileUtils.GetUniqueKey(before));
                else
                    Assert.IsNull(CredentialProfileUtils.GetUniqueKey(before));
                Assert.AreEqual(CredentialProfileUtils.GetUniqueKey(before), CredentialProfileUtils.GetUniqueKey(after));

                // make sure everything is the same, except for the name
                ReflectionHelpers.Invoke(after, "Name", before.Name);
                Assert.AreEqual(before, after);

                // make sure comments and other properties are unchanged after the rename
                tester.AssertCredentialsFileContents(profileText.Replace("basic_profile", "basic_profile2"));
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
            using (var tester = new SharedCredentialsFileTestFixture(BasicProfileTextForCopyAndRename))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.CredentialsFile.RenameProfile("basic_profile", "basic_profile");
                }, typeof(ArgumentException), "Cannot rename section. The destination section basic_profile already exists.");
            }
        }

        [TestMethod]
        public void CopyProfile()
        {
            CopyProfile(false, false);
        }

        [TestMethod]
        public void CopyProfileWithUniqueKey()
        {
            CopyProfile(true, false);
        }

        [TestMethod]
        public void CopyProfileWithUniqueKeyAndANotherSection()
        {
            CopyProfile(true, true);
        }

        public void CopyProfile(bool addUniqueKey, bool addAnotherSection)
        {
            var profileText = BasicProfileTextForCopyAndRename;

            if (addUniqueKey)
                profileText += "vs_toolkit_artifact_guid=" + UniqueKey + Environment.NewLine;

            var anotherSection = addAnotherSection ? "[another_section]" + Environment.NewLine + "propertyx=valuex" + Environment.NewLine: "";

                using (var tester = new SharedCredentialsFileTestFixture(profileText + anotherSection))
            {
                // read the profile
                CredentialProfile profile1;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("basic_profile", out profile1));

                // copy it
                tester.CredentialsFile.CopyProfile("basic_profile", "basic_profile2");

                // make sure the original is untouched
                CredentialProfile profile1Reread;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("basic_profile", out profile1Reread));
                Assert.AreEqual(profile1, profile1Reread);

                // make sure the copy exists
                CredentialProfile profile2;
                Assert.IsTrue(tester.CredentialsFile.TryGetProfile("basic_profile2", out profile2));

                // make sure the name the copy is different from the original
                Assert.AreNotEqual(profile1.Name, profile2.Name);


                // make sure the unique key is the changed or not present
                if (addUniqueKey)
                {
                    Assert.AreEqual(UniqueKey, CredentialProfileUtils.GetUniqueKey(profile1));
                    Assert.AreNotEqual(CredentialProfileUtils.GetUniqueKey(profile1), CredentialProfileUtils.GetUniqueKey(profile2));
                }
                else
                {
                    Assert.IsNull(CredentialProfileUtils.GetUniqueKey(profile1));
                    Assert.IsNull(CredentialProfileUtils.GetUniqueKey(profile2));
                }

                // make sure the comments and everything got copied
                var contentsAfter = (profileText + anotherSection).TrimEnd() + Environment.NewLine;
                if (addUniqueKey)
                {
                    contentsAfter += profileText.Replace("basic_profile", "basic_profile2")
                    .Replace(CredentialProfileUtils.GetUniqueKey(profile1).ToString(), CredentialProfileUtils.GetUniqueKey(profile2).ToString()).TrimEnd();
                }
                else
                {
                    contentsAfter += profileText.Replace("basic_profile", "basic_profile2");
                }
                tester.AssertCredentialsFileContents(contentsAfter);

                // make sure everything else on the copy is the same as the original
                CredentialProfileUtils.SetUniqueKey(profile2, CredentialProfileUtils.GetUniqueKey(profile1));
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
            using (var tester = new SharedCredentialsFileTestFixture(BasicProfileTextForCopyAndRename))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.CredentialsFile.CopyProfile("basic_profile", "basic_profile");
                }, typeof(ArgumentException), "Cannot copy section. The destination section basic_profile already exists.");
            }
        }

    }
}
