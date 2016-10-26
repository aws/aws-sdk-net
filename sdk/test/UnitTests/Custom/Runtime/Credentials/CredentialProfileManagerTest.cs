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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CredentialProfileManagerTest
    {
        private const string BasicProfileName = "BasicProfile";

        private static readonly CredentialProfileOptions BasicProfileOptions = new CredentialProfileOptions()
        {
            AccessKey = "AccessKey",
            SecretKey = "SecretKey"
        };

        private static readonly CredentialProfileOptions BasicProfileNewOptions = new CredentialProfileOptions()
        {
            AccessKey = "AccessKeyNew",
            SecretKey = "SecretKeyNew"
        };

        [TestMethod]
        public void CredentialsFileOnly_TestDefaultProfileOperations()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(false, true))
            {
                fixture.ProfileManager.RegisterDefaultProfile(BasicProfileOptions);

                fixture.AssertProfileExistsCredentials(CredentialProfileManager.DefaultProfileName);
                fixture.AssertProfileDoesNotExistSDK(CredentialProfileManager.DefaultProfileName);

                CredentialProfile defaultProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetDefaultProfile(out defaultProfile));
                Assert.IsNotNull(defaultProfile);

                fixture.ProfileManager.UnregisterDefaultProfile();

                fixture.AssertProfileDoesNotExistCredentials(CredentialProfileManager.DefaultProfileName);
                fixture.AssertProfileDoesNotExistSDK(CredentialProfileManager.DefaultProfileName);
            }
        }

        [TestMethod]
        public void CredentialsFileOnly_TestRegisterProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(false, true))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                fixture.AssertProfileExistsCredentials(BasicProfileName);
                fixture.AssertProfileDoesNotExistSDK(BasicProfileName);
            }
        }

        [TestMethod]
        public void CredentialsFileOnly_TestTryGetProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(false, true))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                CredentialProfile profile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out profile));
                Assert.IsNotNull(profile);
                Assert.AreEqual(BasicProfileName, profile.Name);
                fixture.AssertProfileStoreType(profile, typeof(SharedCredentialsFile));
            }
        }

        [TestMethod]
        public void CredentialsFileOnly_TestUnregisterProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(false, true))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                CredentialProfile profile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out profile));
                Assert.IsNotNull(profile);
                Assert.AreEqual(BasicProfileName, profile.Name);

                fixture.ProfileManager.UnregisterProfile(BasicProfileName);

                fixture.AssertProfileDoesNotExist(BasicProfileName);
            }
        }

        [TestMethod]
        public void CredentialsFileOnly_List()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(false, true))
            {
                var expected = new HashSet<string>();
                for (int i = 0; i < 10; i++)
                {
                    var name = BasicProfileName + i.ToString();
                    fixture.ProfileManager.RegisterProfile(name, BasicProfileOptions);
                    expected.Add(name);
                }

                var actualListNames = new HashSet<string>(fixture.ProfileManager.ListProfileNames());
                Assert.IsTrue(expected.SetEquals(actualListNames));

                var actualListProfiles = new HashSet<string>(fixture.ProfileManager.ListProfiles().Select(p => p.Name).ToList());
                Assert.IsTrue(expected.SetEquals(actualListProfiles));
            }
        }

        [TestMethod]
        public void DefaultToSDK_TestRegisterProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, false))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                fixture.AssertProfileDoesNotExistCredentials(BasicProfileName);
                fixture.AssertProfileExistsSDK(BasicProfileName);
            }
        }

        [TestMethod]
        public void DefaultToSDK_TestTryGetProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, false))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                CredentialProfile profile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out profile));
                Assert.IsNotNull(profile);
                Assert.AreEqual(BasicProfileName, profile.Name);
                fixture.AssertProfileStoreType(profile, typeof(AWSSDKProfileStore));
            }
        }

        [TestMethod]
        public void DefaultToSDK_TestTryGetProfile_FallbackToSharedCredentialsFile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, false))
            {
                // put directly into shared credentials file without using profile manager
                fixture.SharedCredentialsFixture.CredentialsFile.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(
                    BasicProfileName, BasicProfileOptions, fixture.SharedCredentialsFixture.CredentialsFile));

                CredentialProfile firstProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out firstProfile));
                Assert.IsNotNull(firstProfile);
                Assert.AreEqual(BasicProfileName, firstProfile.Name);
                Assert.AreEqual(BasicProfileOptions.AccessKey, firstProfile.Options.AccessKey);
                fixture.AssertProfileStoreType(firstProfile, typeof(SharedCredentialsFile));

                // make sure that if we change something on the
                // profile and persist that it actually goes to the credentials file
                firstProfile.Options.AccessKey = "NewAccessKey";
                firstProfile.Persist();

                CredentialProfile secondProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out secondProfile));
                Assert.IsNotNull(secondProfile);
                Assert.AreEqual(firstProfile.Name, secondProfile.Name);
                Assert.AreNotEqual(BasicProfileOptions.AccessKey, secondProfile.Options.AccessKey);
                Assert.AreEqual(firstProfile.Options.AccessKey, secondProfile.Options.AccessKey);
                fixture.AssertProfileStoreType(firstProfile, typeof(SharedCredentialsFile));
            }
        }

        [TestMethod]
        public void DefaultToSDK_TestTryGetProfile_PreferSDK()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, false))
            {
                // put directly into shared credentials file
                fixture.SharedCredentialsFixture.CredentialsFile.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(
                    BasicProfileName, BasicProfileOptions, fixture.SharedCredentialsFixture.CredentialsFile));

                CredentialProfile firstProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out firstProfile));
                Assert.IsNotNull(firstProfile);
                Assert.AreEqual(BasicProfileName, firstProfile.Name);
                fixture.AssertProfileStoreType(firstProfile, typeof(SharedCredentialsFile));

                // register a new one in the SDK store
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileNewOptions);

                // make sure we get the new one, and that it came from the SDK store
                CredentialProfile secondProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out secondProfile));
                Assert.IsNotNull(secondProfile);
                Assert.AreEqual(BasicProfileName, secondProfile.Name);
                Assert.AreEqual(BasicProfileNewOptions.AccessKey, secondProfile.Options.AccessKey);
                fixture.AssertProfileStoreType(secondProfile, typeof(AWSSDKProfileStore));
            }
        }

        [TestMethod]
        public void DefaultToSDK_TestUnregisterProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, false))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                CredentialProfile profile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out profile));
                Assert.IsNotNull(profile);
                Assert.AreEqual(BasicProfileName, profile.Name);

                fixture.ProfileManager.UnregisterProfile(BasicProfileName);

                fixture.AssertProfileDoesNotExist(BasicProfileName);
            }
        }

        [TestMethod]
        public void DefaultToSDK_List()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, false))
            {
                var expected = new HashSet<string>();
                for (int i = 0; i < 10; i++)
                {
                    var name = BasicProfileName + i.ToString();
                    fixture.ProfileManager.RegisterProfile(name, BasicProfileOptions);
                    expected.Add(name);
                }

                var actualListNames = new HashSet<string>(fixture.ProfileManager.ListProfileNames());
                Assert.IsTrue(expected.SetEquals(actualListNames));

                var actualListProfiles = new HashSet<string>(fixture.ProfileManager.ListProfiles().Select(p => p.Name).ToList());
                Assert.IsTrue(expected.SetEquals(actualListProfiles));
            }
        }

        [TestMethod]
        public void DefaultToCredentialsFile_TestRegisterProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, true))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                fixture.AssertProfileExistsCredentials(BasicProfileName);
                fixture.AssertProfileDoesNotExistSDK(BasicProfileName);
            }
        }

        [TestMethod]
        public void DefaultToCredentialsFile_TestTryGetProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, true))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                CredentialProfile profile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out profile));
                Assert.IsNotNull(profile);
                Assert.AreEqual(BasicProfileName, profile.Name);
                fixture.AssertProfileStoreType(profile, typeof(SharedCredentialsFile));
            }
        }

        [TestMethod]
        public void DefaultToCredentialsFile_TestTryGetProfile_FallbackToSDK()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, true))
            {
                // put directly into encrypted store file without using profile manager
                fixture.SdkFixture.ProfileStore.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(
                    BasicProfileName, BasicProfileOptions, fixture.SharedCredentialsFixture.CredentialsFile));

                CredentialProfile firstProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out firstProfile));
                Assert.IsNotNull(firstProfile);
                Assert.AreEqual(BasicProfileName, firstProfile.Name);
                Assert.AreEqual(BasicProfileOptions.AccessKey, firstProfile.Options.AccessKey);
                fixture.AssertProfileStoreType(firstProfile, typeof(AWSSDKProfileStore));

                // make sure that if we change something on the
                // profile and persist that it actually goes to the encrypted store
                firstProfile.Options.AccessKey = "NewAccessKey";
                firstProfile.Persist();

                CredentialProfile secondProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out secondProfile));
                Assert.IsNotNull(secondProfile);
                Assert.AreEqual(firstProfile.Name, secondProfile.Name);
                Assert.AreNotEqual(BasicProfileOptions.AccessKey, secondProfile.Options.AccessKey);
                Assert.AreEqual(firstProfile.Options.AccessKey, secondProfile.Options.AccessKey);
                fixture.AssertProfileStoreType(firstProfile, typeof(AWSSDKProfileStore));
            }
        }

        [TestMethod]
        public void DefaultToCredentialsFile_TestTryGetProfile_PreferCredentialsFile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, true))
            {
                // put directly into encrypted store
                fixture.SdkFixture.ProfileStore.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(
                    BasicProfileName, BasicProfileOptions, fixture.SharedCredentialsFixture.CredentialsFile));

                CredentialProfile firstProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out firstProfile));
                Assert.IsNotNull(firstProfile);
                Assert.AreEqual(BasicProfileName, firstProfile.Name);
                fixture.AssertProfileStoreType(firstProfile, typeof(AWSSDKProfileStore));

                // register a new one in the shared credentials file
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileNewOptions);

                // make sure we get the new one, and that it came from the credentials file
                CredentialProfile secondProfile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out secondProfile));
                Assert.IsNotNull(secondProfile);
                Assert.AreEqual(BasicProfileName, secondProfile.Name);
                Assert.AreEqual(BasicProfileNewOptions.AccessKey, secondProfile.Options.AccessKey);
                fixture.AssertProfileStoreType(secondProfile, typeof(SharedCredentialsFile));
            }
        }

        [TestMethod]
        public void DefaultToCredentialsFile_TestUnregisterProfile()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, true))
            {
                fixture.ProfileManager.RegisterProfile(BasicProfileName, BasicProfileOptions);

                CredentialProfile profile;
                Assert.IsTrue(fixture.ProfileManager.TryGetProfile(BasicProfileName, out profile));
                Assert.IsNotNull(profile);
                Assert.AreEqual(BasicProfileName, profile.Name);

                fixture.ProfileManager.UnregisterProfile(BasicProfileName);

                fixture.AssertProfileDoesNotExist(BasicProfileName);
            }
        }

        [TestMethod]
        public void DefaultToCredentialsFile_List()
        {
            using (var fixture = new CredentialProfileManagerTestFixture(true, true))
            {
                var expected = new HashSet<string>();
                for (int i = 0; i < 10; i++)
                {
                    var name = BasicProfileName + i.ToString();
                    fixture.ProfileManager.RegisterProfile(name, BasicProfileOptions);
                    expected.Add(name);
                }

                var actualListNames = new HashSet<string>(fixture.ProfileManager.ListProfileNames());
                Assert.IsTrue(expected.SetEquals(actualListNames));

                var actualListProfiles = new HashSet<string>(fixture.ProfileManager.ListProfiles().Select(p => p.Name).ToList());
                Assert.IsTrue(expected.SetEquals(actualListProfiles));
            }
        }
    }
}
