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
using Amazon.Runtime.Credentials;
using Amazon.Runtime.Internal.Settings;
using Amazon.S3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the <see cref="CachedProfileCredentialResolver"/> covering:
    /// - Cache invalidation with the .NET SDK encrypted store (RegisteredAccounts.json)
    /// - Monotonic change token invalidation ensuring multiple profiles sharing the same
    ///   backing file are independently invalidated
    /// - Config file changes trigger invalidation
    /// - Multiple sequential file modifications are all detected
    /// </summary>
    [TestClass]
    public class CachedProfileCredentialResolverTests
    {
        #region NetSDK Store Tests

        private static readonly Guid UniqueKey = Guid.NewGuid();

        /// <summary>
        /// Builds a minimal NetSDK credentials file (RegisteredAccounts.json) with a single
        /// basic profile containing the given access/secret key.
        /// </summary>
        private static string NetSdkBasicProfileJson(string profileName, string accessKey, string secretKey) =>
            new StringBuilder()
                .AppendLine("{")
                .AppendLine($"    \"{UniqueKey}\" : {{")
                .AppendLine($"        \"DisplayName\" : \"{profileName}\",")
                .AppendLine($"        \"SessionType\" : \"AWS\",")
                .AppendLine($"        \"AWSAccessKey\" : \"{accessKey}\",")
                .AppendLine($"        \"AWSSecretKey\" : \"{secretKey}\"")
                .AppendLine("    }")
                .AppendLine("}")
                .ToString();

        /// <summary>
        /// Verifies that when a profile is resolved from the .NET SDK encrypted store,
        /// the cached credentials are returned on the second call (same object reference).
        /// </summary>
        [TestMethod]
        public void NetSdkProfile_SecondSyncCall_ReturnsCachedInstance()
        {
            using (var fixture = new NetSDKCredentialsFileTestFixture(
                NetSdkBasicProfileJson("netsdk-profile", "AKID_NET1", "SECRET_NET1")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                // Profile.Location is null → CredentialProfileStoreChain searches NetSDK first.
                var config = new AmazonS3Config
                {
                    Profile = new Profile("netsdk-profile")
                };

                var first = resolver.ResolveIdentity(config);
                var second = resolver.ResolveIdentity(config);

                Assert.IsNotNull(first);
                Assert.IsNotNull(second);
                Assert.AreSame(first, second,
                    "Expected the second call to return the same cached credentials object from NetSDK store.");
            }
        }

        /// <summary>
        /// Verifies that when the RegisteredAccounts.json backing file is modified on disk,
        /// the cache detects the change and re-resolves, returning fresh credentials.
        /// </summary>
        [TestMethod]
        public void NetSdkProfile_FileModified_ReturnsNewCredentials()
        {
            using (var fixture = new NetSDKCredentialsFileTestFixture(
                NetSdkBasicProfileJson("netsdk-profile", "AKID_ORIGINAL", "SECRET_ORIGINAL")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("netsdk-profile")
                };

                var original = resolver.ResolveIdentity(config);
                Assert.IsNotNull(original);
                Assert.AreEqual("AKID_ORIGINAL", original.GetCredentials().AccessKey);

                // Mutate the RegisteredAccounts.json file with updated credentials.
                fixture.SetFileContents(
                    NetSdkBasicProfileJson("netsdk-profile", "AKID_UPDATED", "SECRET_UPDATED"), delayMs: 500);
                var updated = resolver.ResolveIdentity(config);
                Assert.IsNotNull(updated);
                Assert.AreNotSame(original, updated,
                    "After modifying the NetSDK credentials file the resolver should return a new credentials object.");
                Assert.AreEqual("AKID_UPDATED", updated.GetCredentials().AccessKey);
            }
        }

        /// <summary>
        /// Same as the sync test but exercises the async path.
        /// </summary>
        [TestMethod]
        public async Task NetSdkProfile_FileModifiedAsync_ReturnsNewCredentials()
        {
            using (var fixture = new NetSDKCredentialsFileTestFixture(
                NetSdkBasicProfileJson("netsdk-profile", "AKID_ORIGINAL", "SECRET_ORIGINAL")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("netsdk-profile")
                };

                var original = await resolver.ResolveIdentityAsync(config);
                Assert.IsNotNull(original);
                Assert.AreEqual("AKID_ORIGINAL", original.GetCredentials().AccessKey);

                // Mutate the RegisteredAccounts.json file.
                fixture.SetFileContents(
                    NetSdkBasicProfileJson("netsdk-profile", "AKID_UPDATED", "SECRET_UPDATED"), delayMs: 500);
                var updated = await resolver.ResolveIdentityAsync(config);
                Assert.IsNotNull(updated);
                Assert.AreNotSame(original, updated,
                    "After modifying the NetSDK credentials file the async resolver should return new credentials.");
                Assert.AreEqual("AKID_UPDATED", updated.GetCredentials().AccessKey);
            }
        }

        /// <summary>
        /// Verifies that after a file modification triggers re-resolution, subsequent calls
        /// with no further file changes return the new cached credentials (same reference).
        /// </summary>
        [TestMethod]
        public void NetSdkProfile_FileModifiedThenStable_CachesAfterRefresh()
        {
            using (var fixture = new NetSDKCredentialsFileTestFixture(
                NetSdkBasicProfileJson("netsdk-profile", "AKID_V1", "SECRET_V1")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("netsdk-profile")
                };

                var v1 = resolver.ResolveIdentity(config);

                // Modify → cache invalidated.
                fixture.SetFileContents(
                    NetSdkBasicProfileJson("netsdk-profile", "AKID_V2", "SECRET_V2"));

                var v2 = resolver.ResolveIdentity(config);
                Assert.AreNotSame(v1, v2, "Should have re-resolved after NetSDK file change.");

                // Now the file is stable — subsequent calls should hit cache.
                var v2Again = resolver.ResolveIdentity(config);
                Assert.AreSame(v2, v2Again,
                    "Credentials should be cached again after re-resolution from NetSDK store.");
            }
        }

        /// <summary>
        /// Verifies that when DisableLegacyPersistenceStore is true, the NetSDK file
        /// is not tracked for invalidation (the cache only monitors shared credentials/config files).
        /// This is an indirect test: with the legacy store disabled, the CredentialProfileStoreChain
        /// won't find the profile in the NetSDK store, so it should throw.
        /// </summary>
        [TestMethod]
        public void NetSdkProfile_DisableLegacyPersistenceStore_FallsBackToSharedFile()
        {
            var savedValue = AWSConfigs.DisableLegacyPersistenceStore;
            try
            {
                AWSConfigs.DisableLegacyPersistenceStore = true;

                using (var fixture = new NetSDKCredentialsFileTestFixture(
                    NetSdkBasicProfileJson("netsdk-only-profile", "AKID", "SECRET")))
                using (var resolver = new DefaultAWSCredentialsIdentityResolver())
                {
                    var config = new AmazonS3Config
                    {
                        Profile = new Profile("netsdk-only-profile")
                    };

                    // With the legacy store disabled, the profile only exists in the NetSDK file
                    // which is skipped → should throw.
                    Assert.ThrowsExactly<AmazonClientException>(() => resolver.ResolveIdentity(config));
                }
            }
            finally
            {
                AWSConfigs.DisableLegacyPersistenceStore = savedValue;
            }
        }

        #endregion

        #region Shared File Change Token Tests

        /// <summary>
        /// When two profiles (A and B) live in the same credentials file, modifying the file
        /// should invalidate BOTH profiles' caches. This is the core bug that the change token
        /// fix addresses — previously, resolving profile A would reset the shared watcher flag,
        /// causing profile B to miss the invalidation.
        /// </summary>
        [TestMethod]
        public void MultipleProfiles_SharedFile_BothInvalidatedOnChange()
        {
            var credentialsContent = string.Join(Environment.NewLine,
                "[profile-a]",
                "aws_access_key_id = AKID_A_V1",
                "aws_secret_access_key = SECRET_A_V1",
                "",
                "[profile-b]",
                "aws_access_key_id = AKID_B_V1",
                "aws_secret_access_key = SECRET_B_V1");

            using (var fixture = new SharedCredentialsFileTestFixture(credentialsContent))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var configA = new AmazonS3Config { Profile = new Profile("profile-a", fixture.CredentialsFilePath) };
                var configB = new AmazonS3Config { Profile = new Profile("profile-b", fixture.CredentialsFilePath) };

                // Initial resolution — both should resolve successfully.
                var credsA1 = resolver.ResolveIdentity(configA);
                var credsB1 = resolver.ResolveIdentity(configB);
                Assert.AreEqual("AKID_A_V1", credsA1.GetCredentials().AccessKey);
                Assert.AreEqual("AKID_B_V1", credsB1.GetCredentials().AccessKey);

                // Verify both are cached (same reference returned).
                Assert.AreSame(credsA1, resolver.ResolveIdentity(configA));
                Assert.AreSame(credsB1, resolver.ResolveIdentity(configB));

                // Modify the shared credentials file.
                var updatedContent = string.Join(Environment.NewLine,
                    "[profile-a]",
                    "aws_access_key_id = AKID_A_V2",
                    "aws_secret_access_key = SECRET_A_V2",
                    "",
                    "[profile-b]",
                    "aws_access_key_id = AKID_B_V2",
                    "aws_secret_access_key = SECRET_B_V2");
                fixture.UpdateCredentialsFile(updatedContent);

                // Resolve profile A first — this should NOT prevent profile B from detecting the change.
                var credsA2 = resolver.ResolveIdentity(configA);
                Assert.AreEqual("AKID_A_V2", credsA2.GetCredentials().AccessKey,
                    "Profile A should see updated credentials after file change.");
                Assert.AreNotSame(credsA1, credsA2, "Profile A should have re-resolved.");

                var credsB2 = resolver.ResolveIdentity(configB);
                Assert.AreEqual("AKID_B_V2", credsB2.GetCredentials().AccessKey,
                    "Profile B should also see updated credentials after file change (not stale V1).");
                Assert.AreNotSame(credsB1, credsB2, "Profile B should have re-resolved.");
            }
        }

        /// <summary>
        /// Verifies the same multi-profile invalidation scenario works via the async path.
        /// </summary>
        [TestMethod]
        public async Task MultipleProfiles_SharedFile_BothInvalidatedOnChangeAsync()
        {
            var credentialsContent = string.Join(Environment.NewLine,
                "[profile-a]",
                "aws_access_key_id = AKID_A_V1",
                "aws_secret_access_key = SECRET_A_V1",
                "",
                "[profile-b]",
                "aws_access_key_id = AKID_B_V1",
                "aws_secret_access_key = SECRET_B_V1");

            using (var fixture = new SharedCredentialsFileTestFixture(credentialsContent))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var configA = new AmazonS3Config { Profile = new Profile("profile-a", fixture.CredentialsFilePath) };
                var configB = new AmazonS3Config { Profile = new Profile("profile-b", fixture.CredentialsFilePath) };

                var credsA1 = await resolver.ResolveIdentityAsync(configA);
                var credsB1 = await resolver.ResolveIdentityAsync(configB);
                Assert.AreEqual("AKID_A_V1", credsA1.GetCredentials().AccessKey);
                Assert.AreEqual("AKID_B_V1", credsB1.GetCredentials().AccessKey);

                // Modify the shared credentials file.
                var updatedContent = string.Join(Environment.NewLine,
                    "[profile-a]",
                    "aws_access_key_id = AKID_A_V2",
                    "aws_secret_access_key = SECRET_A_V2",
                    "",
                    "[profile-b]",
                    "aws_access_key_id = AKID_B_V2",
                    "aws_secret_access_key = SECRET_B_V2");
                fixture.UpdateCredentialsFile(updatedContent);

                // Resolve A first, then B — both should see the update.
                var credsA2 = await resolver.ResolveIdentityAsync(configA);
                var credsB2 = await resolver.ResolveIdentityAsync(configB);
                Assert.AreEqual("AKID_A_V2", credsA2.GetCredentials().AccessKey);
                Assert.AreEqual("AKID_B_V2", credsB2.GetCredentials().AccessKey);
            }
        }

        /// <summary>
        /// When two profiles share the same credentials file but only one profile's data is
        /// modified, both entries are invalidated (the watcher is per-file, not per-profile),
        /// but after re-resolution the unchanged profile still resolves to the same key values.
        /// </summary>
        [TestMethod]
        public void SharedFile_OnlyOneProfileDataChanged_BothReResolveButUnchangedKeepsValue()
        {
            var credentialsContent = string.Join(Environment.NewLine,
                "[changing-profile]",
                "aws_access_key_id = AKID_CHANGING_V1",
                "aws_secret_access_key = SECRET_CHANGING_V1",
                "",
                "[stable-profile]",
                "aws_access_key_id = AKID_STABLE",
                "aws_secret_access_key = SECRET_STABLE");

            using (var fixture = new SharedCredentialsFileTestFixture(credentialsContent))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var changingConfig = new AmazonS3Config { Profile = new Profile("changing-profile", fixture.CredentialsFilePath) };
                var stableConfig = new AmazonS3Config { Profile = new Profile("stable-profile", fixture.CredentialsFilePath) };

                var changing1 = resolver.ResolveIdentity(changingConfig);
                var stable1 = resolver.ResolveIdentity(stableConfig);
                Assert.AreEqual("AKID_CHANGING_V1", changing1.GetCredentials().AccessKey);
                Assert.AreEqual("AKID_STABLE", stable1.GetCredentials().AccessKey);

                // Modify the file — only change the first profile's keys, keep stable-profile the same.
                var updatedContent = string.Join(Environment.NewLine,
                    "[changing-profile]",
                    "aws_access_key_id = AKID_CHANGING_V2",
                    "aws_secret_access_key = SECRET_CHANGING_V2",
                    "",
                    "[stable-profile]",
                    "aws_access_key_id = AKID_STABLE",
                    "aws_secret_access_key = SECRET_STABLE");
                fixture.UpdateCredentialsFile(updatedContent);

                // Both profiles are invalidated (same file changed), so both re-resolve.
                var changing2 = resolver.ResolveIdentity(changingConfig);
                Assert.AreEqual("AKID_CHANGING_V2", changing2.GetCredentials().AccessKey);
                Assert.AreNotSame(changing1, changing2, "Changing profile should have re-resolved.");

                // Stable profile also re-resolves (file changed), but the key value is the same.
                var stable2 = resolver.ResolveIdentity(stableConfig);
                Assert.AreEqual("AKID_STABLE", stable2.GetCredentials().AccessKey,
                    "Stable profile should still have the same access key after re-resolution.");
                Assert.AreNotSame(stable1, stable2,
                    "Stable profile should have re-resolved (new object) since the file was modified.");
            }
        }

        /// <summary>
        /// Verifies that multiple sequential file modifications are all detected correctly.
        /// Each modification should cause re-resolution on the next access for all profiles.
        /// </summary>
        [TestMethod]
        public void MultipleSequentialChanges_AllDetected()
        {
            var v1Content = string.Join(Environment.NewLine,
                "[my-profile]",
                "aws_access_key_id = AKID_V1",
                "aws_secret_access_key = SECRET_V1");

            using (var fixture = new SharedCredentialsFileTestFixture(v1Content))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config { Profile = new Profile("my-profile", fixture.CredentialsFilePath) };

                var creds1 = resolver.ResolveIdentity(config);
                Assert.AreEqual("AKID_V1", creds1.GetCredentials().AccessKey);

                // Change 1
                fixture.UpdateCredentialsFile(string.Join(Environment.NewLine,
                    "[my-profile]",
                    "aws_access_key_id = AKID_V2",
                    "aws_secret_access_key = SECRET_V2"));

                var creds2 = resolver.ResolveIdentity(config);
                Assert.AreEqual("AKID_V2", creds2.GetCredentials().AccessKey);
                Assert.AreNotSame(creds1, creds2);

                // Change 2
                fixture.UpdateCredentialsFile(string.Join(Environment.NewLine,
                    "[my-profile]",
                    "aws_access_key_id = AKID_V3",
                    "aws_secret_access_key = SECRET_V3"));

                var creds3 = resolver.ResolveIdentity(config);
                Assert.AreEqual("AKID_V3", creds3.GetCredentials().AccessKey);
                Assert.AreNotSame(creds2, creds3);

                // Change 3
                fixture.UpdateCredentialsFile(string.Join(Environment.NewLine,
                    "[my-profile]",
                    "aws_access_key_id = AKID_V4",
                    "aws_secret_access_key = SECRET_V4"));

                var creds4 = resolver.ResolveIdentity(config);
                Assert.AreEqual("AKID_V4", creds4.GetCredentials().AccessKey);
                Assert.AreNotSame(creds3, creds4);
            }
        }

        /// <summary>
        /// Verifies that when no file change occurs, the cached credentials remain stable
        /// (same object reference returned) across many calls.
        /// </summary>
        [TestMethod]
        public void NoChange_CacheRemainsStable()
        {
            var content = string.Join(Environment.NewLine,
                "[stable-profile]",
                "aws_access_key_id = AKID_STABLE",
                "aws_secret_access_key = SECRET_STABLE");

            using (var fixture = new SharedCredentialsFileTestFixture(content))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config { Profile = new Profile("stable-profile", fixture.CredentialsFilePath) };

                var first = resolver.ResolveIdentity(config);
                for (int i = 0; i < 100; i++)
                {
                    var subsequent = resolver.ResolveIdentity(config);
                    Assert.AreSame(first, subsequent,
                        $"Iteration {i}: Expected same cached reference when file has not changed.");
                }
            }
        }

        /// <summary>
        /// After a file change triggers re-resolution, subsequent calls (with no further changes)
        /// should return the new cached credentials consistently for ALL profiles sharing the file.
        /// </summary>
        [TestMethod]
        public void MultipleProfiles_AfterReResolution_BothCacheNewCredentials()
        {
            var content = string.Join(Environment.NewLine,
                "[alpha]",
                "aws_access_key_id = AKID_ALPHA_V1",
                "aws_secret_access_key = SECRET_ALPHA_V1",
                "",
                "[beta]",
                "aws_access_key_id = AKID_BETA_V1",
                "aws_secret_access_key = SECRET_BETA_V1");

            using (var fixture = new SharedCredentialsFileTestFixture(content))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var configAlpha = new AmazonS3Config { Profile = new Profile("alpha", fixture.CredentialsFilePath) };
                var configBeta = new AmazonS3Config { Profile = new Profile("beta", fixture.CredentialsFilePath) };

                resolver.ResolveIdentity(configAlpha);
                resolver.ResolveIdentity(configBeta);

                // Modify the file.
                var updatedContent = string.Join(Environment.NewLine,
                    "[alpha]",
                    "aws_access_key_id = AKID_ALPHA_V2",
                    "aws_secret_access_key = SECRET_ALPHA_V2",
                    "",
                    "[beta]",
                    "aws_access_key_id = AKID_BETA_V2",
                    "aws_secret_access_key = SECRET_BETA_V2");
                fixture.UpdateCredentialsFile(updatedContent);
                // Both profiles re-resolve.
                var alphaV2 = resolver.ResolveIdentity(configAlpha);
                var betaV2 = resolver.ResolveIdentity(configBeta);
                Assert.AreEqual("AKID_ALPHA_V2", alphaV2.GetCredentials().AccessKey);
                Assert.AreEqual("AKID_BETA_V2", betaV2.GetCredentials().AccessKey);

                // Now verify the new values are cached (no more file changes).
                Assert.AreSame(alphaV2, resolver.ResolveIdentity(configAlpha),
                    "Alpha should be cached after re-resolution.");
                Assert.AreSame(betaV2, resolver.ResolveIdentity(configBeta),
                    "Beta should be cached after re-resolution.");
            }
        }

        #endregion
    }
}
