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
using Amazon.Runtime.Credentials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests that verify credential resolution under high concurrency
    /// does not fail due to multiple threads simultaneously walking the
    /// credential chain. This specifically tests the single-flight pattern
    /// in <see cref="DefaultAWSCredentialsIdentityResolver"/> where only
    /// one thread resolves credentials while others wait and reuse the result.
    /// </summary>
    [TestClass]
    public class ConcurrentCredentialResolutionTests
    {
        private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";

        private string _cachedContainersUriVariable;
        private string _cachedProfileVariable;
        private string _cachedAccessTokenVariable;
        private string _cachedSecretKeyVariable;
        private string _cachedSessionTokenVariable;
        private List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator> _cachedGenerators;

        [TestInitialize]
        public void TestInitialize()
        {
            _cachedContainersUriVariable = Environment.GetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, null);

            _cachedProfileVariable = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
            _cachedAccessTokenVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            _cachedSecretKeyVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            _cachedSessionTokenVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN);

            _cachedGenerators = AWSConfigs.AWSCredentialsGenerators;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, _cachedContainersUriVariable);
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, _cachedProfileVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, _cachedAccessTokenVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, _cachedSecretKeyVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, _cachedSessionTokenVariable);

            AWSConfigs.AWSCredentialsGenerators = _cachedGenerators;
        }

        /// <summary>
        /// Simulates 64 concurrent credential resolution requests against a
        /// slow credential provider (e.g., IMDS on EC2). Verifies that all
        /// concurrent callers succeed and only one actually walks the chain.
        /// This tests the fix for the issue where high concurrency on first use
        /// would overwhelm the IMDS endpoint.
        /// </summary>
        [TestMethod]
        public void ConcurrentSyncResolution_AllTasksSucceed_OnlyOneChainWalk()
        {
            const int concurrency = 64;
            int generatorCallCount = 0;

            // Simulate a slow credential provider (like IMDS) that takes some time
            // to return. Only one invocation should go through; others should
            // get the cached result.
            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () =>
                {
                    Interlocked.Increment(ref generatorCallCount);
                    // Simulate network latency of IMDS
                    Thread.Sleep(100);
                    return new BasicAWSCredentials("test-access-key", "test-secret-key");
                }
            };

            var resolver = new DefaultAWSCredentialsIdentityResolver();
            var tasks = new Task<AWSCredentials>[concurrency];
            var barrier = new ManualResetEventSlim(false);

            // Launch all tasks, have them wait at a barrier, then release simultaneously
            for (int i = 0; i < concurrency; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    barrier.Wait();
                    return resolver.ResolveIdentity(clientConfig: null);
                });
            }

            // Release all threads simultaneously to maximize contention
            barrier.Set();

            Task.WaitAll(tasks);

            // All tasks should have succeeded
            for (int i = 0; i < concurrency; i++)
            {
                Assert.IsNotNull(tasks[i].Result, $"Task {i} returned null credentials");
                Assert.IsInstanceOfType(tasks[i].Result, typeof(BasicAWSCredentials));
            }

            // The generator should have been called exactly once due to single-flight pattern
            Assert.AreEqual(1, generatorCallCount,
                $"Expected generator to be called exactly once, but it was called {generatorCallCount} times. " +
                "This indicates the single-flight pattern is not working correctly.");
        }

        /// <summary>
        /// Same as the sync test but exercises the async path via ResolveIdentityAsync,
        /// which uses SemaphoreSlim.WaitAsync to avoid blocking thread pool threads.
        /// </summary>
        [TestMethod]
        public async Task ConcurrentAsyncResolution_AllTasksSucceed_OnlyOneChainWalk()
        {
            const int concurrency = 64;
            int generatorCallCount = 0;

            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () =>
                {
                    Interlocked.Increment(ref generatorCallCount);
                    Thread.Sleep(100);
                    return new BasicAWSCredentials("test-access-key", "test-secret-key");
                }
            };

            var resolver = new DefaultAWSCredentialsIdentityResolver();
            var tasks = new Task<AWSCredentials>[concurrency];
            var barrier = new TaskCompletionSource<bool>();

            for (int i = 0; i < concurrency; i++)
            {
                tasks[i] = Task.Run(async () =>
                {
                    await barrier.Task.ConfigureAwait(false);
                    return await resolver.ResolveIdentityAsync(clientConfig: null).ConfigureAwait(false);
                });
            }

            // Release all tasks simultaneously
            barrier.SetResult(true);

            await Task.WhenAll(tasks).ConfigureAwait(false);

            for (int i = 0; i < concurrency; i++)
            {
                Assert.IsNotNull(tasks[i].Result, $"Task {i} returned null credentials");
                Assert.IsInstanceOfType(tasks[i].Result, typeof(BasicAWSCredentials));
            }

            Assert.AreEqual(1, generatorCallCount,
                $"Expected generator to be called exactly once, but it was called {generatorCallCount} times.");
        }

        /// <summary>
        /// Verifies that when the first concurrent credential resolution fails,
        /// each subsequent caller that enters the lock also attempts resolution
        /// (i.e. a failure is not cached). Then verifies that once credentials
        /// succeed, the result is cached and the generator is not called again.
        /// </summary>
        [TestMethod]
        public void ConcurrentResolution_FailureThenSuccess_RetriesCorrectly()
        {
            int generatorCallCount = 0;
            bool shouldFail = true;

            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () =>
                {
                    int count = Interlocked.Increment(ref generatorCallCount);
                    if (shouldFail)
                    {
                        throw new InvalidOperationException("Simulated IMDS failure");
                    }
                    return new BasicAWSCredentials("test-access-key", "test-secret-key");
                }
            };

            var resolver = new DefaultAWSCredentialsIdentityResolver();

            // First resolution attempt should fail
            Assert.ThrowsException<AmazonClientException>(() => resolver.ResolveIdentity(clientConfig: null));

            // Fix the provider and try again - should succeed
            shouldFail = false;
            var credentials = resolver.ResolveIdentity(clientConfig: null);
            Assert.IsNotNull(credentials);
            Assert.IsInstanceOfType(credentials, typeof(BasicAWSCredentials));

            // Third call should use cached credentials without calling the generator again
            int callsBeforeThirdAttempt = generatorCallCount;
            var cachedCredentials = resolver.ResolveIdentity(clientConfig: null);
            Assert.IsNotNull(cachedCredentials);
            Assert.AreEqual(callsBeforeThirdAttempt, generatorCallCount,
                "Generator should not be called again when credentials are cached");
        }
    }
}
