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
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the <see cref="CachedProfileCredentialResolver"/> cache invalidation
    /// when credentials are stored in the .NET SDK encrypted store (RegisteredAccounts.json).
    /// </summary>
    [TestClass]
    public class CachedProfileCredentialResolverNetSdkTests
    {
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
                    NetSdkBasicProfileJson("netsdk-profile", "AKID_UPDATED", "SECRET_UPDATED"));
                // due to flakiness in this test where the test runs too quickly, we will wind the clock forward for this file.
                File.SetLastWriteTimeUtc(Path.Combine(fixture.DirectoryPath, "RegisteredAccounts.json"), DateTime.UtcNow + TimeSpan.FromSeconds(5));
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
                    NetSdkBasicProfileJson("netsdk-profile", "AKID_UPDATED", "SECRET_UPDATED"));
                // due to flakiness in this test where the test runs too quickly, we will wind the clock forward for this file.
                File.SetLastWriteTimeUtc(Path.Combine(fixture.DirectoryPath, "RegisteredAccounts.json"), DateTime.UtcNow + TimeSpan.FromSeconds(5));
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
                    Assert.ThrowsException<AmazonClientException>(() => resolver.ResolveIdentity(config));
                }
            }
            finally
            {
                AWSConfigs.DisableLegacyPersistenceStore = savedValue;
            }
        }
    }
}
