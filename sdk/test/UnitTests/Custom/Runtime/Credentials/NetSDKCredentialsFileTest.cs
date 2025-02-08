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
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal.Settings;
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Amazon;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class NetSDKCredentialsFileTest
    {
        private const string ReservedFieldExceptionFormat = "The profile properties cannot contain reserved names as keys: {0}";
        private const string CredentialsFieldExceptionFormat = "The profile properties dictionary cannot contain a key named {0} because it is in the name mapping dictionary.";

        private const string AWSCredentialsProfileType = "AWS";
        private const string SAMLRoleProfileType = "SAML";
        private const string ProfileTag = "PROFILE_TAG";
        private const string SomeOtherKey = "SomeOtherKey";
        private const string SomeOtherValue = "some_other_value";

        private static readonly Guid UniqueKey = Guid.NewGuid();

        private static readonly string BasicProfileText = new StringBuilder()
            .AppendLine("{")
            .AppendLine("    \"" + UniqueKey + "\" : {")
            .AppendLine("        \"DisplayName\" : \"ProfileName1\",")
            .AppendLine("        \"SessionType\" : \"AWS\",")
            .AppendLine("        \"AWSAccessKey\" : \"access_key_id\",")
            .AppendLine("        \"AWSSecretKey\" : \"secret_key_id\",")
            .AppendLine("        \"" + SomeOtherKey + "\" : \"" + SomeOtherValue + "\",")
            .AppendLine("    }")
            .AppendLine("}").ToString();

        private static readonly string SessionProfileText = new StringBuilder()
            .AppendLine("{")
            .AppendLine("    \"" + UniqueKey + "\" : {")
            .AppendLine("        \"DisplayName\" : \"ProfileName1\",")
            .AppendLine("        \"AWSAccessKey\" : \"access_key_id\",")
            .AppendLine("        \"AWSSecretKey\" : \"secret_key_id\",")
            .AppendLine("        \"SessionToken\" : \"session_token\",")
            .AppendLine("        \"" + SomeOtherKey + "\" : \"" + SomeOtherValue + "\"")
            .AppendLine("    }")
            .AppendLine("}").ToString();

        private static readonly string SessionProfileTextAfterUpdate = new StringBuilder()
            .AppendLine("{")
            .AppendLine("      \"" + UniqueKey + "\" : {")
            .AppendLine("          \"DisplayName\" : \"ProfileName1\",")
            .AppendLine("          \"AWSAccessKey\": \"access_key_id\",")
            .AppendLine("          \"AWSSecretKey\": \"secret_key_id\",")
            .AppendLine("          \"ProfileType\": \"AWS\",")
            .AppendLine("          \"" + SomeOtherKey + "\": \"" + SomeOtherValue + "\"")
            .AppendLine("    }")
            .Append("}").ToString();

        private static readonly string RegionOnlyProfileText = new StringBuilder()
            .AppendLine("{")
            .AppendLine("    \"" + UniqueKey + "\" : {")
            .AppendLine("        \"DisplayName\" : \"RegionOnlyProfile\",")
            .AppendLine("        \"Region\" : \"us-east-1\",")
            .AppendLine("    }")
            .AppendLine("}").ToString();

        private static readonly string DefaultConfigurationModeNameOnlyProfileText = new StringBuilder()
            .AppendLine("{")
            .AppendLine("    \"" + UniqueKey + "\" : {")
            .AppendLine("        \"DisplayName\" : \"DefaultConfigurationModeNameOnlyProfile\",")
            .AppendLine("        \"DefaultsMode\" : \"InRegion\",")
            .AppendLine("    }")
            .AppendLine("}").ToString();

        private static readonly string InvalidProfileText = new StringBuilder()
            .AppendLine("{")
            .AppendLine("    \"" + UniqueKey + "\" : {")
            .AppendLine("        \"DisplayName\" : \"InvalidProfile\",")
            .AppendLine("        \"SessionType\" : \"AWS\",")
            .AppendLine("        \"AWSAccessKey\" : \"access_key_id\",")
            .AppendLine("    }")
            .AppendLine("}").ToString();

        private static readonly string LegacyCredentialsTypeProfileText = new StringBuilder()
            .AppendLine("{")
            .AppendLine("    \"" + UniqueKey + "\" : {")
            .AppendLine("        \"DisplayName\" : \"LegacyCredentialsTypeProfile\",")
            .AppendLine("        \"CredentialsType\" : \"the_credentials_type\",")
            .AppendLine("    }")
            .AppendLine("}").ToString();

        [TestMethod]
        public void TestAllProfileTypes()
        {
            foreach (CredentialProfileType type in Enum.GetValues(typeof(CredentialProfileType)))
            {
                using (var tester = new NetSDKCredentialsFileTestFixture())
                {
                    var profileName = type.ToString() + Guid.NewGuid().ToString();
                    var originalProfile = CredentialProfileTestHelper.GetRandomProfile(profileName, type);
                    Assert.IsTrue(originalProfile.CanCreateAWSCredentials);
                    Assert.IsNotNull(CredentialProfileUtils.GetUniqueKey(originalProfile));

                    tester.ProfileStore.RegisterProfile(originalProfile);

                    var readProfile = tester.TestTryGetProfile(profileName, true, true);
                    Assert.AreEqual(originalProfile, readProfile);

                    //Making sure that the endpoint_discovery_enabled field is set to the default
                    Assert.IsNull(readProfile.EndpointDiscoveryEnabled);

                    // make sure the ProfileType is written, even though it's ignored
                    var expectedType = type.ToString();
                    if (type == CredentialProfileType.Basic)
                    {
                        expectedType = AWSCredentialsProfileType;
                    } else if (type == CredentialProfileType.SAMLRole ||
                        type == CredentialProfileType.SAMLRoleUserIdentity)
                    {
                        expectedType = SAMLRoleProfileType;
                    }
                    tester.AssertJsonProperty(profileName, SettingsConstants.ProfileTypeField, expectedType);
                }
            }
        }

        [TestMethod]
        public void RegisterProfileReservedPropertyName1()
        {
            TestReservedPropertyName(ReservedFieldExceptionFormat, "DisplayName");
        }

        [TestMethod]
        public void RegisterProfileReservedPropertyName2()
        {
            TestReservedPropertyName(ReservedFieldExceptionFormat, "ProfileType");
        }

        [TestMethod]
        public void RegisterProfileReservedPropertyName3()
        {
            TestReservedPropertyName(CredentialsFieldExceptionFormat, "RoleArn");
        }

        [TestMethod]
        public void RegisterProfileReservedPropertyName4()
        {
            TestReservedPropertyName(ReservedFieldExceptionFormat, "Region");
        }

        [TestMethod]
        public void RegisterProfileReservedPropertyNameIgnoreCase()
        {
            TestReservedPropertyName(CredentialsFieldExceptionFormat, "rolearn");
        }

        private void TestReservedPropertyName(string exceptionFormat, string propertyName)
        {
            AssertExtensions.ExpectException(() =>
            {
                using (var tester = new NetSDKCredentialsFileTestFixture())
                {
                    var profileName = Guid.NewGuid().ToString();
                    var profile = CredentialProfileTestHelper.GetRandomProfile(profileName, CredentialProfileType.Basic);
                    var properties = CredentialProfileUtils.GetProperties(profile);
                    properties.Add(propertyName, "aargh!");
                    tester.ProfileStore.RegisterProfile(profile);
                }
            }, typeof(ArgumentException), string.Format(CultureInfo.InvariantCulture, exceptionFormat, propertyName));
        }

        [TestMethod]
        public void ProfileNotFound()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                tester.TestTryGetProfile("DoesNotExist", false, false);
            }
        }

        [TestMethod]
        public void CredentialProfileStorePropertyIsSet()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                var writeProfile = new CredentialProfile("test_profile", new CredentialProfileOptions
                {
                    AccessKey = "access_key",
                    SecretKey = "secret_key"
                });
                Assert.IsNull(writeProfile.CredentialProfileStore);
                tester.ProfileStore.RegisterProfile(writeProfile);
                Assert.IsTrue(object.ReferenceEquals(tester.ProfileStore, writeProfile.CredentialProfileStore));

                CredentialProfile readProfile;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("test_profile", out readProfile));
                Assert.IsTrue(object.ReferenceEquals(tester.ProfileStore, readProfile.CredentialProfileStore));
            }
        }

        [TestMethod]
        public void ReadDefaultConfigurationModeNameOnlyProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(DefaultConfigurationModeNameOnlyProfileText))
            {
                var profile = tester.TestTryGetProfile("DefaultConfigurationModeNameOnlyProfile", expectProfile: true, expectValidProfile: false);

                Assert.AreEqual(DefaultConfigurationMode.InRegion.ToString(), profile.DefaultConfigurationModeName);
            }
        }

        [TestMethod]
        public void ReadRegionOnlyProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(RegionOnlyProfileText))
            {
                tester.TestTryGetProfile("RegionOnlyProfile", true, false);
            }
        }

        [TestMethod]
        public void WriteRegionOnlyProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                var emptyOptions = new CredentialProfileOptions();
                var profile = new CredentialProfile("RegionOnlyProfile", emptyOptions);
                profile.Region = RegionEndpoint.USGovCloudWest1;
                tester.ProfileStore.RegisterProfile(profile);

                var readProfile = tester.TestTryGetProfile("RegionOnlyProfile", true, false);
                Assert.AreEqual(RegionEndpoint.USGovCloudWest1, readProfile.Region);
                Assert.IsTrue((bool)ReflectionHelpers.Invoke(readProfile.Options, "IsEmpty"));
            }
        }

        [TestMethod]
        public void WriteEndpointDiscoveryEnabledOnlyProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                var emptyOptions = new CredentialProfileOptions();
                var profile = new CredentialProfile("EndpointDiscoveryEnabledOnlyProfile", emptyOptions);
                profile.EndpointDiscoveryEnabled = true;
                tester.ProfileStore.RegisterProfile(profile);

                var readProfile = tester.TestTryGetProfile("EndpointDiscoveryEnabledOnlyProfile", true, false);
                Assert.IsTrue(readProfile.EndpointDiscoveryEnabled.HasValue);
                Assert.IsTrue(readProfile.EndpointDiscoveryEnabled.Value);
            }
        }

        [TestMethod]
        public void WriteRegionCredentialsUntouched()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                // write the whole profile - credentials options and region
                var basicOptions = new CredentialProfileOptions
                {
                    AccessKey = "access_key",
                    SecretKey = "secret_key"
                };
                var profile = new CredentialProfile("WriteRegionKeepOptionsProfile", basicOptions);
                profile.Region = RegionEndpoint.USGovCloudWest1;
                tester.ProfileStore.RegisterProfile(profile);

                // now write just the region
                var emptyOptions = new CredentialProfileOptions();
                var regionOnlyProfile = new CredentialProfile("WriteRegionKeepOptionsProfile", basicOptions);
                profile.Region = RegionEndpoint.APSouth1;
                tester.ProfileStore.RegisterProfile(profile);

                // Make sure it has the original options and the new region
                var readProfile = tester.TestTryGetProfile("WriteRegionKeepOptionsProfile", true, true);
                Assert.AreEqual("access_key", readProfile.Options.AccessKey);
                Assert.AreEqual("secret_key", readProfile.Options.SecretKey);
                Assert.AreEqual(RegionEndpoint.APSouth1, readProfile.Region);
            }
        }

        [TestMethod]
        public void InvalidProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(InvalidProfileText))
            {
                tester.TestTryGetProfile("InvalidProfile", true, false);
            }
        }

        [TestMethod]
        public void LegacyCredentialsTypeProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(LegacyCredentialsTypeProfileText))
            {
                var profile = tester.TestTryGetProfile("LegacyCredentialsTypeProfile", true, false);
                var credentialType = CredentialProfileUtils.GetProperty(profile, "CredentialsType");
                Assert.AreEqual("the_credentials_type", credentialType);
            }
        }

        [TestMethod]
        public void ReadUniqueKeyProperty()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(LegacyCredentialsTypeProfileText))
            {
                var profile = tester.TestTryGetProfile("LegacyCredentialsTypeProfile", true, false);
                Assert.AreEqual(UniqueKey.ToString("D"), CredentialProfileUtils.GetUniqueKey(profile));
            }
        }

        [TestMethod]
        public void UnregisterProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                // register
                tester.ProfileStore.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(Guid.NewGuid(),
                    CredentialProfileType.Basic.ToString(),
                    CredentialProfileTestHelper.GetRandomOptions(CredentialProfileType.Basic)));
                // check that it's there
                tester.TestTryGetProfile(CredentialProfileType.Basic.ToString(), true, true);

                // unregister
                tester.ProfileStore.UnregisterProfile(CredentialProfileType.Basic.ToString());
                // check that it's not there
                tester.TestTryGetProfile(CredentialProfileType.Basic.ToString(), false, false);

            }
        }

        [TestMethod]
        public void ListProfileNamesEmpty()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                var profileNames = tester.ProfileStore.ListProfileNames();
                Assert.AreEqual(0, profileNames.Count);
            }
        }

        [TestMethod]
        public void ListProfileNames()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                tester.ProfileStore.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(Guid.NewGuid(),
                       "SessionProfile", CredentialProfileTestHelper.GetRandomOptions(CredentialProfileType.Session)));

                var profileNames = tester.ProfileStore.ListProfileNames();
                Assert.AreEqual(1, profileNames.Count);
                Assert.IsTrue(profileNames.Contains("SessionProfile"));
            }
        }

        [TestMethod]
        public void ListProfileNamesExcludeInvalid()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(InvalidProfileText))
            {
                tester.ProfileStore.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(
                    Guid.NewGuid(),  "SessionProfile",
                    CredentialProfileTestHelper.GetRandomOptions(CredentialProfileType.Session)));

                var profileNames = tester.ProfileStore.ListProfileNames();
                Assert.AreEqual(1, profileNames.Count);
                Assert.IsTrue(profileNames.Contains("SessionProfile"));
            }
        }

        [TestMethod]
        public void ListProfilesEmpty()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                var profiles = tester.ProfileStore.ListProfiles();
                Assert.AreEqual(0, profiles.Count);
            }
        }

        [TestMethod]
        public void ListProfiles()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                tester.ProfileStore.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(
                    Guid.NewGuid(), "SessionProfile", CredentialProfileTestHelper.GetRandomOptions(CredentialProfileType.Session)));

                var profiles = tester.ProfileStore.ListProfiles();
                Assert.AreEqual(1, profiles.Count);
                Assert.AreEqual("SessionProfile", profiles[0].Name);
            }
        }

        [TestMethod]
        public void ListProfilesExcludeInvalid()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(InvalidProfileText))
            {
                tester.ProfileStore.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(
                    Guid.NewGuid(), "SessionProfile", CredentialProfileTestHelper.GetRandomOptions(CredentialProfileType.Session)));

                var profiles = tester.ProfileStore.ListProfiles();
                Assert.AreEqual(1, profiles.Count);
                Assert.AreEqual("SessionProfile", profiles[0].Name);
            }
        }

        [TestMethod]
        public void UpdateProfileType()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(SessionProfileText))
            {
                var options = new CredentialProfileOptions
                {
                    AccessKey = "access_key_id",
                    SecretKey = "secret_key_id"
                };
                var newProfile = new CredentialProfile("ProfileName1", options);
                tester.ProfileStore.RegisterProfile(newProfile);
                // we don't care about the spacing
                tester.AssertFileContentsIgnoreWhitespace(tester.MainFilename, SessionProfileTextAfterUpdate);
            }
        }

        [TestMethod]
        public void RenameProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                // read the profile
                CredentialProfile before;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName1", out before));

                // rename it
                tester.ProfileStore.RenameProfile("ProfileName1", "ProfileName2");

                // make sure there isn't one with the original name
                CredentialProfile profile1Reread;
                Assert.IsFalse(tester.ProfileStore.TryGetProfile("ProfileName1", out profile1Reread));

                // make sure one with the new name exists
                CredentialProfile after;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName2", out after));
                Assert.AreNotEqual(before.Name, after.Name);

                // make sure the unique key is the same as before the rename
                Assert.AreEqual(CredentialProfileUtils.GetUniqueKey(before), CredentialProfileUtils.GetUniqueKey(after));

                // make sure everything is the same, except for the name
                ReflectionHelpers.Invoke(after, "Name", before.Name);
                Assert.AreEqual(before, after);
            }
        }

        [TestMethod]
        public void RenameProfileFromEqualsTo()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                // read the profile
                CredentialProfile before;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName1", out before));

                // rename it with the same name
                tester.ProfileStore.RenameProfile("ProfileName1", "ProfileName1");

                // make sure it's still there
                CredentialProfile after;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName1", out after));

                // make sure everything is the same
                Assert.AreEqual(before, after);
            }
        }

        [TestMethod]
        public void RenameProfileSourceDoesNotExist()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.ProfileStore.RenameProfile("ProfileNameX", "ProfileName2");
                }, typeof(ArgumentException), "Cannot rename object. The source object 'ProfileNameX' does not exist.");
            }
        }

        [TestMethod]
        public void RenameProfileTargetAlreadyExists()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                RegisteOtherProfile(tester);
                AssertExtensions.ExpectException(() =>
                {
                    tester.ProfileStore.RenameProfile("OtherProfile", "ProfileName1");
                }, typeof(ArgumentException), "Cannot rename object. The destination object 'ProfileName1' already exists.");
            }
        }

        [TestMethod]
        public void RenameProfileTargetAlreadyExistsForce()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                Create2Profiles(tester);
                tester.ProfileStore.RenameProfile("profile1", "profile2", true);

                CredentialProfile readProfile;
                Assert.IsFalse(tester.ProfileStore.TryGetProfile("profile1", out readProfile));
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("profile2", out readProfile));
                Assert.AreEqual(readProfile.Options.AccessKey, "access_key1");
                Assert.AreEqual(readProfile.Options.SecretKey, "secret_key1");
            }
        }

        [TestMethod]
        public void CopyProfile()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                // read the profile
                CredentialProfile profile1;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName1", out profile1));

                // copy it
                tester.ProfileStore.CopyProfile("ProfileName1", "ProfileName2");

                // make sure the original is untouched
                CredentialProfile profile1Reread;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName1", out profile1Reread));
                Assert.AreEqual(profile1, profile1Reread);

                // make sure the copy exists
                CredentialProfile profile2;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName2", out profile2));

                // make sure the name and unique key of the copy are different from the original
                Assert.AreNotEqual(profile1.Name, profile2.Name);
                Assert.AreNotEqual(CredentialProfileUtils.GetUniqueKey(profile1), CredentialProfileUtils.GetUniqueKey(profile2));

                // make sure everything else on the copy is the same as the original
                CredentialProfileUtils.SetUniqueKey(profile2, new Guid(CredentialProfileUtils.GetUniqueKey(profile1)));
                ReflectionHelpers.Invoke(profile2, "Name", profile1.Name);
                Assert.AreEqual(profile1, profile2);

                //make sure the additional key came along
                var someOtherValue1 = CredentialProfileUtils.GetProperty(profile1, SomeOtherKey);
                var someOtherValue2 = CredentialProfileUtils.GetProperty(profile2, SomeOtherKey);
                Assert.AreEqual(SomeOtherValue, someOtherValue1);
                Assert.AreEqual(someOtherValue1, someOtherValue2);
            }
        }

        [TestMethod]
        public void CopyProfileFromEqualsTo()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                // read the profile
                CredentialProfile profile1;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName1", out profile1));

                // copy it
                tester.ProfileStore.CopyProfile("ProfileName1", "ProfileName1");

                // make sure the original is untouched
                CredentialProfile profile1Reread;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("ProfileName1", out profile1Reread));
                Assert.AreEqual(profile1, profile1Reread);
            }
        }

        [TestMethod]
        public void CopyProfileSourceDoesNotExist()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.ProfileStore.CopyProfile("ProfileNameX", "ProfileName2");
                }, typeof(ArgumentException), "Cannot copy object. The source object 'ProfileNameX' does not exist.");
            }
        }

        [TestMethod]
        public void CopyProfileTargetAlreadyExists()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                RegisteOtherProfile(tester);
                AssertExtensions.ExpectException(() =>
                {
                    tester.ProfileStore.CopyProfile("OtherProfile", "ProfileName1");
                }, typeof(ArgumentException), "Cannot copy object. The destination object 'ProfileName1' already exists.");
            }
        }

        [TestMethod]
        public void CopyProfileTargetAlreadyExistsForce()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                Create2Profiles(tester);
                tester.ProfileStore.CopyProfile("profile1", "profile2", true);

                CredentialProfile readProfile;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("profile1", out readProfile));
                Assert.AreEqual(readProfile.Options.AccessKey, "access_key1");
                Assert.AreEqual(readProfile.Options.SecretKey, "secret_key1");

                Assert.IsTrue(tester.ProfileStore.TryGetProfile("profile2", out readProfile));
                Assert.AreEqual(readProfile.Options.AccessKey, "access_key1");
                Assert.AreEqual(readProfile.Options.SecretKey, "secret_key1");
            }
        }



        private static void Create2Profiles(NetSDKCredentialsFileTestFixture tester)
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
            tester.ProfileStore.RegisterProfile(profile1);
            tester.ProfileStore.RegisterProfile(profile2);
        }

        private static void RegisteOtherProfile(NetSDKCredentialsFileTestFixture tester)
        {
            var options = new CredentialProfileOptions
            {
                AccessKey = "ak",
                SecretKey = "sk"
            };
            tester.ProfileStore.RegisterProfile(new CredentialProfile("OtherProfile", options));
        }
    }
}
