/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Settings;
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

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
                    Assert.IsNotNull(originalProfile.UniqueKey);

                    tester.ProfileStore.RegisterProfile(originalProfile);

                    var readProfile = tester.TestTryGetProfile(profileName, true, true);
                    Assert.AreEqual(originalProfile, readProfile);

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
                Assert.AreEqual(UniqueKey, profile.UniqueKey);
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
                Assert.AreEqual(before.UniqueKey, after.UniqueKey);

                // make sure everything is the same, except for the name
                ReflectionHelpers.Invoke(after, "Name", before.Name);
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
                }, typeof(ArgumentException), "Cannot rename object. The source object ProfileNameX does not exist.");
            }
        }

        [TestMethod]
        public void RenameProfileTargetAlreadyExists()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.ProfileStore.RenameProfile("ProfileName1", "ProfileName1");
                }, typeof(ArgumentException), "Cannot rename object. The destination object ProfileName1 already exists.");
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
                Assert.AreNotEqual(profile1.UniqueKey, profile2.UniqueKey);

                // make sure everything else on the copy is the same as the original
                ReflectionHelpers.Invoke(profile2, "SetUniqueKeyInternal", profile1.UniqueKey);
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
        public void CopyProfileSourceDoesNotExist()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.ProfileStore.CopyProfile("ProfileNameX", "ProfileName2");
                }, typeof(ArgumentException), "Cannot copy object. The source object ProfileNameX does not exist.");
            }
        }

        [TestMethod]
        public void CopyProfileTargetAlreadyExists()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture(BasicProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.ProfileStore.CopyProfile("ProfileName1", "ProfileName1");
                }, typeof(ArgumentException), "Cannot copy object. The destination object ProfileName1 already exists.");
            }
        }

        [TestMethod]
        public void TestReadCompatibilityBasic()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                // write with old ProfileManager
                ProfileManager.RegisterProfile("BasicProfile", "AccessKey", "SecretKey");

                // read with new NetSDKCredentialsFile
                CredentialProfile profile;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("BasicProfile", out profile));
                Assert.IsNotNull(profile);
                Assert.AreEqual("BasicProfile", profile.Name);
                Assert.AreEqual("AccessKey", profile.Options.AccessKey);
                Assert.AreEqual("SecretKey", profile.Options.SecretKey);
                Assert.AreEqual(CredentialProfileType.Basic, CredentialProfileTypeDetector.DetectProfileType(profile.Options).Value);
            }
        }

        [TestMethod]
        public void TestWriteCompatibilityBasic()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                // write with new NetSDKCredentialsFile
                CredentialProfile profile = CredentialProfileTestHelper.GetCredentialProfile(
                    Guid.NewGuid(), "BasicProfile", CredentialProfileTestHelper.GetRandomOptions(CredentialProfileType.Basic));
                tester.ProfileStore.RegisterProfile(profile);

                // read with old ProfileManager
                AWSCredentials credentials;
                Assert.IsTrue(ProfileManager.TryGetAWSCredentials("BasicProfile", out credentials));
                Assert.IsNotNull(credentials);
                var immutableCredentials = credentials.GetCredentials();
                Assert.AreEqual(profile.Options.AccessKey, immutableCredentials.AccessKey);
                Assert.AreEqual(profile.Options.SecretKey, immutableCredentials.SecretKey);
            }
        }

        [TestMethod]
        public void TestReadCompatibilitySAML()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                // write with old ProfileManager
                ProfileManager.RegisterSAMLEndpoint("EndpointName", new Uri("https://somesamlendpoint/"), null);
                ProfileManager.RegisterSAMLRoleProfile("SAMLProfile", "EndpointName", "RoleArn", "UserIdentity");

                // read with new NetSDKCredentialsFile
                CredentialProfile profile;
                Assert.IsTrue(tester.ProfileStore.TryGetProfile("SAMLProfile", out profile));
                Assert.IsNotNull(profile);
                Assert.AreEqual("SAMLProfile", profile.Name);
                Assert.AreEqual("EndpointName", profile.Options.EndpointName);
                Assert.AreEqual("RoleArn", profile.Options.RoleArn);
                Assert.AreEqual("UserIdentity", profile.Options.UserIdentity);
                Assert.AreEqual(CredentialProfileType.SAMLRoleUserIdentity, CredentialProfileTypeDetector.DetectProfileType(profile.Options).Value);
            }
        }

        [TestMethod]
        public void TestWriteCompatibilitySAML()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                // write with new NetSDKCredentialsFile
                CredentialProfile profile = CredentialProfileTestHelper.GetCredentialProfile(
                    Guid.NewGuid(), "SAMLProfile", CredentialProfileTestHelper.GetRandomOptions(CredentialProfileType.SAMLRoleUserIdentity));
                tester.ProfileStore.RegisterProfile(profile);

                // TODO do this with the new SAML Endpoint Manager
                ProfileManager.RegisterSAMLEndpoint(profile.Options.EndpointName, new Uri("https://somesamlendpoint/"), null);

                // read with old ProfileManager
                SAMLRoleProfile samlProfile;
                Assert.IsTrue(ProfileManager.TryGetProfile("SAMLProfile", out samlProfile));
                Assert.IsNotNull(samlProfile);
                Assert.AreEqual(profile.Options.EndpointName, samlProfile.EndpointSettings.Name);
                Assert.AreEqual(profile.Options.RoleArn, samlProfile.RoleArn);
                Assert.AreEqual(profile.Options.UserIdentity, samlProfile.UserIdentity);
            }
        }

        [TestMethod]
        public void TestWriteCompatibilitySession()
        {
            using (var tester = new NetSDKCredentialsFileTestFixture())
            {
                // write a type that's not supported by ProfileManager
                tester.ProfileStore.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(
                    Guid.NewGuid(), "SessionProfile", CredentialProfileTestHelper.GetRandomOptions(CredentialProfileType.Session)));

                // make sure profile manager can't read it as a basic profile, and that there aren't any errors.
                AWSCredentials credentials;
                Assert.IsFalse(ProfileManager.TryGetAWSCredentials("SessionProfile", out credentials));
                Assert.IsNull(credentials);

                // make sure profile manager can't read it as a SAML profile, and that there aren't any errors.
                SAMLRoleProfile samlProfile;
                Assert.IsFalse(ProfileManager.TryGetProfile("SessionProfile", out samlProfile));
                Assert.IsNull(samlProfile);
            }
        }
    }
}
