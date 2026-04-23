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
using Amazon.S3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DefaultCredentialsResolverTests
    {
        private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";

        private string _cachedContainersUriVariable;
        private string _cachedProfileVariable;
        private string _cachedAccessTokenVariable;
        private string _cachedSecretKeyVariable;
        private string _cachedSessionTokenVariable;

        [TestInitialize]
        public void TestInitialize()
        {
            // When running these tests on CodeBuild, we need to clear the "AWS_CONTAINER_CREDENTIALS_RELATIVE_URI" variable
            // to prevent using the container credentials provider.
            _cachedContainersUriVariable = Environment.GetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, null);

            _cachedProfileVariable = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
            _cachedAccessTokenVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            _cachedSecretKeyVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            _cachedSessionTokenVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, _cachedContainersUriVariable);
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, _cachedProfileVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, _cachedAccessTokenVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, _cachedSecretKeyVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, _cachedSessionTokenVariable);
        }

        [TestMethod]
        public void CredentialsAreReevaluatedWhenEnvVarsAreSet()
        {
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, null);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, null);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, null);

            // By setting the environment variables to null, the identity resolver will use either basic credentials (from the default 
            // profile) or session credentials (when using an IAM role - for example, in CodeBuild).
            var identityResolver = new DefaultAWSCredentialsIdentityResolver();
            var initialIdentity = identityResolver.ResolveIdentity(clientConfig: null);
            Assert.IsFalse(initialIdentity is EnvironmentVariablesAWSCredentials);

            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "updated_aws_access_key_id");
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "updated_aws_secret_access_key");
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, "updated_aws_session_token");

            var updatedIdentity = identityResolver.ResolveIdentity(clientConfig: null);
            Assert.IsTrue(updatedIdentity is EnvironmentVariablesAWSCredentials);
        }

        [TestMethod]
        public void CredentialsAreReevaluatedWhenProfileChanges()
        {
            using (var identityResolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var initialIdentity = identityResolver.ResolveIdentity(clientConfig: null);
                Assert.IsFalse(initialIdentity is DefaultInstanceProfileAWSCredentials);

                // Since the specified profile does not exist, the identity resolver will throw an exception.
                Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, "non-existent-profile");
                Assert.ThrowsException<ProfileNotFoundException>(() => identityResolver.ResolveIdentity(clientConfig: null));
            }
        }

        /// <summary>
        /// Reported in https://github.com/aws/aws-sdk-net/issues/4028
        /// <para />
        /// If the name property in the "Profile" property is not set (which can happen when its value
        /// is only set in a non-production environment), the resolver should not throw an exception and 
        /// move to the next provider in the chain (which in this test will be the access / secret key pair
        /// set in the environment variables).
        /// </summary>
        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void CredentialsResolver_HandlesEmptyProfileNameInConfig(string profileName)
        {
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "foo");
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "bar");

            using (var identityResolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var resolvedIdentity = identityResolver.ResolveIdentity(new AmazonS3Config
                {
                    Profile = new Profile(profileName)
                });

                Assert.IsNotNull(resolvedIdentity);
                Assert.IsTrue(resolvedIdentity is EnvironmentVariablesAWSCredentials);
            }
        }

        #region Profile Credential Caching Tests

        private static string BasicProfileText(string profileName, string accessKey, string secretKey) =>
            $"[{profileName}]\naws_access_key_id = {accessKey}\naws_secret_access_key = {secretKey}\n";

        /// <summary>
        /// Verifies that a second synchronous call to ResolveIdentity with the same profile
        /// returns the cached credentials (same object reference) without re-reading the disk.
        /// </summary>
        [TestMethod]
        public void ProfileCredentials_SecondSyncCall_ReturnsCachedInstance()
        {
            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("test-profile", "AKID_FIRST", "SECRET_FIRST")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("test-profile", fixture.CredentialsFilePath)
                };

                var first = resolver.ResolveIdentity(config);
                var second = resolver.ResolveIdentity(config);

                Assert.IsNotNull(first);
                Assert.IsNotNull(second);
                // The exact same cached object should be returned on the second call.
                Assert.AreSame(first, second, "Expected the second call to return the same cached credentials object.");
            }
        }

        /// <summary>
        /// Verifies that a second asynchronous call to ResolveIdentityAsync with the same profile
        /// returns the cached credentials (same object reference) without re-reading the disk.
        /// </summary>
        [TestMethod]
        public async Task ProfileCredentials_SecondAsyncCall_ReturnsCachedInstance()
        {
            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("test-profile", "AKID_FIRST", "SECRET_FIRST")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("test-profile", fixture.CredentialsFilePath)
                };

                var first = await resolver.ResolveIdentityAsync(config);
                var second = await resolver.ResolveIdentityAsync(config);

                Assert.IsNotNull(first);
                Assert.IsNotNull(second);
                Assert.AreSame(first, second, "Expected the second async call to return the same cached credentials object.");
            }
        }

        /// <summary>
        /// Verifies that the cached credentials are shared across the sync and async paths
        /// when they use the same resolver instance and profile key.
        /// </summary>
        [TestMethod]
        public async Task ProfileCredentials_MixedSyncAndAsyncCalls_ShareCache()
        {
            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("test-profile", "AKID_MIXED", "SECRET_MIXED")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("test-profile", fixture.CredentialsFilePath)
                };

                var syncResult = resolver.ResolveIdentity(config);
                var asyncResult = await resolver.ResolveIdentityAsync(config);

                Assert.AreSame(syncResult, asyncResult, "Sync and async paths should share the same cached credentials.");
            }
        }

        /// <summary>
        /// Verifies that different profile names result in independent cache entries.
        /// </summary>
        [TestMethod]
        public void ProfileCredentials_DifferentProfiles_AreCachedIndependently()
        {
            var contents = BasicProfileText("profile-a", "AKID_A", "SECRET_A") +
                           BasicProfileText("profile-b", "AKID_B", "SECRET_B");

            using (var fixture = new SharedCredentialsFileTestFixture(contents))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var configA = new AmazonS3Config { Profile = new Profile("profile-a", fixture.CredentialsFilePath) };
                var configB = new AmazonS3Config { Profile = new Profile("profile-b", fixture.CredentialsFilePath) };

                var credsA = resolver.ResolveIdentity(configA);
                var credsB = resolver.ResolveIdentity(configB);

                Assert.IsNotNull(credsA);
                Assert.IsNotNull(credsB);
                Assert.AreNotSame(credsA, credsB, "Different profiles should produce different credential objects.");

                // Both should still be individually cached.
                var credsA2 = resolver.ResolveIdentity(configA);
                var credsB2 = resolver.ResolveIdentity(configB);
                Assert.AreSame(credsA, credsA2);
                Assert.AreSame(credsB, credsB2);
            }
        }

        /// <summary>
        /// Verifies that when the backing credentials file is modified between
        /// ResolveIdentity calls, the cache detects the change and returns fresh credentials.
        /// </summary>
        [TestMethod]
        public void ProfileCredentials_FileModified_ReturnsNewCredentials()
        {
            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("test-profile", "AKID_ORIGINAL", "SECRET_ORIGINAL")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("test-profile", fixture.CredentialsFilePath)
                };

                var original = resolver.ResolveIdentity(config);
                Assert.IsNotNull(original);

                // Mutate the credentials file.
                File.WriteAllText(fixture.CredentialsFilePath, BasicProfileText("test-profile", "AKID_UPDATED", "SECRET_UPDATED"));

                var updated = resolver.ResolveIdentity(config);
                Assert.IsNotNull(updated);
                Assert.AreNotSame(original, updated,
                    "After modifying the credentials file the resolver should return a new credentials object.");
                Assert.AreEqual<string>("AKID_UPDATED", updated.GetCredentials().AccessKey);
            }
        }

        /// <summary>
        /// Same as the sync test but exercises the async path.
        /// </summary>
        [TestMethod]
        public async Task ProfileCredentials_FileModifiedAsync_ReturnsNewCredentials()
        {
            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("test-profile", "AKID_ORIGINAL", "SECRET_ORIGINAL")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("test-profile", fixture.CredentialsFilePath)
                };

                var original = await resolver.ResolveIdentityAsync(config).ConfigureAwait(false);
                Assert.IsNotNull(original);

                // Mutate the credentials file.
                File.WriteAllText(fixture.CredentialsFilePath, BasicProfileText("test-profile", "AKID_UPDATED", "SECRET_UPDATED"));

                var updated = resolver.ResolveIdentity(config);
                Assert.IsNotNull(updated);
                Assert.AreNotSame(original, updated,
                    "After modifying the credentials file the resolver should return a new credentials object.");
                Assert.AreEqual<string>("AKID_UPDATED", updated.GetCredentials().AccessKey);
            }
        }
        /// <summary>
        /// Verifies that when the file has NOT changed between calls, the cache
        /// continues to return the original cached object even after the file was
        /// previously updated. This ensures the snapshot timestamp is refreshed correctly.
        /// </summary>
        [TestMethod]
        public void ProfileCredentials_FileModifiedThenStable_CachesAfterRefresh()
        {
            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("test-profile", "AKID_V1", "SECRET_V1")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("test-profile", fixture.CredentialsFilePath)
                };

                // First resolution – populates cache.
                var v1 = resolver.ResolveIdentity(config);

                // Modify file → cache invalidated.
                File.WriteAllText(fixture.CredentialsFilePath, BasicProfileText("test-profile", "AKID_V2", "SECRET_V2"));

                var v2 = resolver.ResolveIdentity(config);
                Assert.AreNotSame(v1, v2, "Should have re-resolved after file change.");

                // Now the file is stable – subsequent calls should hit cache.
                var v2Again = resolver.ResolveIdentity(config);
                Assert.AreSame(v2, v2Again, "Credentials should be cached again after re-resolution.");
            }
        }

        /// <summary>
        /// Verifies that when a non-existent profile is requested, the resolver throws
        /// <see cref="AmazonClientException"/> and subsequent calls with the same bad
        /// profile also throw (i.e. zombie entries are cleaned up from the cache).
        /// </summary>
        [TestMethod]
        public void ProfileCredentials_NonExistentProfile_ThrowsAndCleansUpEntry()
        {
            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("real-profile", "AKID", "SECRET")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("non-existent-profile", fixture.CredentialsFilePath)
                };

                Assert.ThrowsException<AmazonClientException>(() => resolver.ResolveIdentity(config));

                // The zombie entry should have been removed, so calling again should
                // still throw (not hang on a disposed semaphore).
                Assert.ThrowsException<AmazonClientException>(() => resolver.ResolveIdentity(config));
            }
        }

        #endregion

        #region Threading / Concurrency Tests for Profile Credential Cache

        /// <summary>
        /// Launches many concurrent synchronous threads that all call ResolveIdentity with the
        /// same profile. Verifies that all threads receive the same cached credentials object,
        /// proving that only one thread performed the actual resolution and stored the result.
        /// </summary>
        [TestMethod]
        public void ProfileCredentials_ConcurrentSyncCalls_OnlyOneWritesToCache()
        {
            const int threadCount = 32;

            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("concurrent-profile", "AKID_CONCURRENT", "SECRET_CONCURRENT")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("concurrent-profile", fixture.CredentialsFilePath)
                };

                var barrier = new ManualResetEventSlim(false);
                var results = new AWSCredentials[threadCount];
                var tasks = new Task[threadCount];

                for (int i = 0; i < threadCount; i++)
                {
                    int index = i;
                    tasks[index] = Task.Run(() =>
                    {
                        barrier.Wait();
                        results[index] = resolver.ResolveIdentity(config);
                    });
                }

                // Release all threads simultaneously to maximise contention.
                barrier.Set();
                Task.WaitAll(tasks);

                // Every thread should have received a non-null result.
                for (int i = 0; i < threadCount; i++)
                {
                    Assert.IsNotNull(results[i], $"Thread {i} returned null credentials.");
                }

                // All results should be the exact same object reference,
                // proving the cache was written once and read by all others.
                var expected = results[0];
                for (int i = 1; i < threadCount; i++)
                {
                    Assert.AreSame(expected, results[i],
                        $"Thread {i} received a different credentials object than thread 0. " +
                        "This suggests the cache was written more than once.");
                }
            }
        }

        /// <summary>
        /// Same as the synchronous variant, but exercises the async code path
        /// (SemaphoreSlim.WaitAsync) which avoids blocking thread pool threads.
        /// </summary>
        [TestMethod]
        public async Task ProfileCredentials_ConcurrentAsyncCalls_OnlyOneWritesToCache()
        {
            const int concurrency = 32;

            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("async-concurrent-profile", "AKID_ASYNC", "SECRET_ASYNC")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("async-concurrent-profile", fixture.CredentialsFilePath)
                };

                var barrier = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
                var tasks = new Task<AWSCredentials>[concurrency];

                for (int i = 0; i < concurrency; i++)
                {
                    tasks[i] = Task.Run(async () =>
                    {
                        await barrier.Task.ConfigureAwait(false);
                        return await resolver.ResolveIdentityAsync(config).ConfigureAwait(false);
                    });
                }

                // Release all tasks simultaneously.
                barrier.SetResult(true);
                await Task.WhenAll(tasks).ConfigureAwait(false);

                for (int i = 0; i < concurrency; i++)
                {
                    Assert.IsNotNull(tasks[i].Result, $"Task {i} returned null credentials.");
                }

                var expected = tasks[0].Result;
                for (int i = 1; i < concurrency; i++)
                {
                    Assert.AreSame(expected, tasks[i].Result,
                        $"Task {i} received a different credentials object than task 0.");
                }
            }
        }

        /// <summary>
        /// Verifies that concurrent callers targeting different profiles resolve
        /// independently and do not interfere with each other's cache entries.
        /// </summary>
        [TestMethod]
        public void ProfileCredentials_ConcurrentDifferentProfiles_ResolveIndependently()
        {
            const int profileCount = 8;
            const int callsPerProfile = 8;

            // Build a single credentials file containing all profiles.
            var sb = new System.Text.StringBuilder();
            for (int p = 0; p < profileCount; p++)
            {
                sb.Append(BasicProfileText($"profile-{p}", $"AKID_{p}", $"SECRET_{p}"));
            }

            using (var fixture = new SharedCredentialsFileTestFixture(sb.ToString()))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var totalTasks = profileCount * callsPerProfile;
                var barrier = new ManualResetEventSlim(false);
                var results = new AWSCredentials[totalTasks];
                var tasks = new Task[totalTasks];

                for (int p = 0; p < profileCount; p++)
                {
                    for (int c = 0; c < callsPerProfile; c++)
                    {
                        int taskIndex = p * callsPerProfile + c;
                        int profileIndex = p;
                        tasks[taskIndex] = Task.Run(() =>
                        {
                            var cfg = new AmazonS3Config
                            {
                                Profile = new Profile($"profile-{profileIndex}", fixture.CredentialsFilePath)
                            };
                            barrier.Wait();
                            results[taskIndex] = resolver.ResolveIdentity(cfg);
                        });
                    }
                }

                barrier.Set();
                Task.WaitAll(tasks);

                // For each profile, all calls should return the same cached object.
                for (int p = 0; p < profileCount; p++)
                {
                    var firstForProfile = results[p * callsPerProfile];
                    Assert.IsNotNull(firstForProfile, $"Profile {p} returned null credentials.");
                    for (int c = 1; c < callsPerProfile; c++)
                    {
                        Assert.AreSame(firstForProfile, results[p * callsPerProfile + c],
                            $"Profile {p}, call {c} returned a different credentials object.");
                    }
                }

                // Different profiles should have different credentials objects.
                for (int p = 1; p < profileCount; p++)
                {
                    Assert.AreNotSame(results[0], results[p * callsPerProfile],
                        $"Profile 0 and profile {p} should have different credentials objects.");
                }
            }
        }

        /// <summary>
        /// Verifies that under concurrent access, when the file changes mid-flight,
        /// all threads that observe the file change converge on a single new credentials
        /// object (i.e. only one re-resolution occurs per invalidation).
        /// </summary>
        [TestMethod]
        public void ProfileCredentials_ConcurrentCallsAfterFileChange_AllGetSameNewObject()
        {
            const int threadCount = 32;

            using (var fixture = new SharedCredentialsFileTestFixture(BasicProfileText("refresh-profile", "AKID_OLD", "SECRET_OLD")))
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                var config = new AmazonS3Config
                {
                    Profile = new Profile("refresh-profile", fixture.CredentialsFilePath)
                };

                // Populate the cache with the original credentials.
                var original = resolver.ResolveIdentity(config);
                Assert.IsNotNull(original);

                // Modify the file so the cache is invalidated on next read.
                File.WriteAllText(fixture.CredentialsFilePath, BasicProfileText("refresh-profile", "AKID_NEW", "SECRET_NEW"));

                // Now launch many threads that all compete to re-resolve.
                var barrier = new ManualResetEventSlim(false);
                var results = new AWSCredentials[threadCount];
                var tasks = new Task[threadCount];

                for (int i = 0; i < threadCount; i++)
                {
                    int index = i;
                    tasks[index] = Task.Run(() =>
                    {
                        barrier.Wait();
                        results[index] = resolver.ResolveIdentity(config);
                    });
                }

                barrier.Set();
                Task.WaitAll(tasks);

                // Every result should be non-null and different from the original.
                for (int i = 0; i < threadCount; i++)
                {
                    Assert.IsNotNull(results[i], $"Thread {i} returned null.");
                    Assert.AreNotSame(original, results[i],
                        $"Thread {i} still returned the stale cached credentials.");
                }

                // All threads should have converged on the same new object.
                var expected = results[0];
                for (int i = 1; i < threadCount; i++)
                {
                    Assert.AreSame(expected, results[i],
                        $"Thread {i} resolved a different new credentials object than thread 0.");
                }
            }
        }

        #endregion
    }
}
