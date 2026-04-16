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
    /// Tests that verify cancellation token behaviour in <see cref="DefaultAWSCredentialsIdentityResolver"/>.
    /// Covers: pre-cancelled tokens, timeout-bound tokens, and ensuring a hanging credential
    /// provider does not block indefinitely when a token is supplied.
    /// </summary>
    [TestClass]
    public class CancellationTokenCredentialResolutionTests
    {
        private List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator> _cachedGenerators;
        private string _cachedContainersUriVariable;
        private string _cachedAccessKeyVariable;
        private string _cachedSecretKeyVariable;
        private string _cachedSessionTokenVariable;

        [TestInitialize]
        public void TestInitialize()
        {
            _cachedGenerators = AWSConfigs.AWSCredentialsGenerators;
            _cachedContainersUriVariable = Environment.GetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable);
            _cachedAccessKeyVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            _cachedSecretKeyVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            _cachedSessionTokenVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN);

            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, null);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, null);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, null);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, null);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            AWSConfigs.AWSCredentialsGenerators = _cachedGenerators;
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, _cachedContainersUriVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, _cachedAccessKeyVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, _cachedSecretKeyVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, _cachedSessionTokenVariable);
        }

        /// <summary>
        /// A pre-cancelled token should cause ResolveIdentity to throw OperationCanceledException
        /// immediately without invoking the credential generator at all.
        /// </summary>
        [TestMethod]
        public void ResolveIdentity_PreCancelledToken_ThrowsOperationCanceledException()
        {
            int generatorCallCount = 0;
            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () =>
                {
                    Interlocked.Increment(ref generatorCallCount);
                    return new BasicAWSCredentials("key", "secret");
                }
            };

            using (var cts = new CancellationTokenSource())
            {
                cts.Cancel();

                var resolver = new DefaultAWSCredentialsIdentityResolver();
                Assert.ThrowsException<OperationCanceledException>(
                    () => resolver.ResolveIdentity(clientConfig: null, cts.Token));

                Assert.AreEqual(0, generatorCallCount, "Generator should not be called when token is already cancelled.");
            }
        }

        /// <summary>
        /// A pre-cancelled token should cause ResolveIdentityAsync to throw OperationCanceledException
        /// immediately without invoking the credential generator at all.
        /// </summary>
        [TestMethod]
        public async Task ResolveIdentityAsync_PreCancelledToken_ThrowsOperationCanceledException()
        {
            int generatorCallCount = 0;
            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () =>
                {
                    Interlocked.Increment(ref generatorCallCount);
                    return new BasicAWSCredentials("key", "secret");
                }
            };

            using (var cts = new CancellationTokenSource())
            {
                cts.Cancel();

                var resolver = new DefaultAWSCredentialsIdentityResolver();
                var ex = await Assert.ThrowsExceptionAsync<TaskCanceledException>(
                    () => resolver.ResolveIdentityAsync(clientConfig: null, cts.Token));
                Assert.IsInstanceOfType(ex, typeof(OperationCanceledException));

                Assert.AreEqual(0, generatorCallCount, "Generator should not be called when token is already cancelled.");
            }
        }

        /// <summary>
        /// Simulates a hanging credential provider (e.g. IMDS with no timeout). A second thread
        /// holds the semaphore while a slow generator runs. The waiting thread should be unblocked
        /// by the cancellation token rather than hanging forever.
        /// </summary>
        [TestMethod]
        public void ResolveIdentity_HangingProvider_CancelledWhileWaitingForLock_ThrowsOperationCanceledException()
        {
            var generatorStarted = new ManualResetEventSlim(false);
            var generatorCanProceed = new ManualResetEventSlim(false);

            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () =>
                {
                    generatorStarted.Set();
                    // Simulate a hanging network call — only unblocks when the test signals it.
                    generatorCanProceed.Wait();
                    return new BasicAWSCredentials("key", "secret");
                }
            };

            var resolver = new DefaultAWSCredentialsIdentityResolver();

            // First thread acquires the lock and hangs inside the generator.
            var firstThread = Task.Run(() => resolver.ResolveIdentity(clientConfig: null));
            generatorStarted.Wait(); // Ensure the first thread holds the lock.

            // Second thread tries to resolve with a short timeout — should be cancelled.
            using (var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(200)))
            {
                Assert.ThrowsException<OperationCanceledException>(
                    () => resolver.ResolveIdentity(clientConfig: null, cts.Token));
            }

            // Unblock the first thread so the test can clean up.
            generatorCanProceed.Set();
            firstThread.Wait();
        }

        /// <summary>
        /// Same as the sync hanging test but exercises the async path.
        /// </summary>
        [TestMethod]
        public async Task ResolveIdentityAsync_HangingProvider_CancelledWhileWaitingForLock_ThrowsOperationCanceledException()
        {
            var generatorStarted = new ManualResetEventSlim(false);
            var generatorCanProceed = new ManualResetEventSlim(false);

            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () =>
                {
                    generatorStarted.Set();
                    generatorCanProceed.Wait();
                    return new BasicAWSCredentials("key", "secret");
                }
            };

            var resolver = new DefaultAWSCredentialsIdentityResolver();

            var firstTask = Task.Run(() => resolver.ResolveIdentityAsync(clientConfig: null));
            generatorStarted.Wait();

            using (var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(200)))
            {
                Exception caughtEx = null;
                try
                {
                    await resolver.ResolveIdentityAsync(clientConfig: null, cts.Token);
                }
                catch (OperationCanceledException ex)
                {
                    caughtEx = ex;
                }
                Assert.IsNotNull(caughtEx, "Expected OperationCanceledException or TaskCanceledException to be thrown.");
            }

            generatorCanProceed.Set();
            await firstTask;
        }

        /// <summary>
        /// Verifies that when a valid token is supplied and the generator completes before the
        /// timeout, credentials are returned successfully.
        /// </summary>
        [TestMethod]
        public void ResolveIdentity_WithNonExpiredToken_ReturnsCredentials()
        {
            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () => new BasicAWSCredentials("key", "secret")
            };

            using (var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5)))
            {
                var resolver = new DefaultAWSCredentialsIdentityResolver();

                var credentials = resolver.ResolveIdentity(clientConfig: null, cts.Token);

                Assert.IsNotNull(credentials);
                Assert.IsInstanceOfType(credentials, typeof(BasicAWSCredentials));
            }
        }

        /// <summary>
        /// Verifies that when a valid token is supplied and the generator completes before the
        /// timeout, credentials are returned successfully via the async path.
        /// </summary>
        [TestMethod]
        public async Task ResolveIdentityAsync_WithNonExpiredToken_ReturnsCredentials()
        {
            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () => new BasicAWSCredentials("key", "secret")
            };

            using (var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5)))
            {
                var resolver = new DefaultAWSCredentialsIdentityResolver();

                var credentials = await resolver.ResolveIdentityAsync(clientConfig: null, cts.Token);

                Assert.IsNotNull(credentials);
                Assert.IsInstanceOfType(credentials, typeof(BasicAWSCredentials));
            }
        }

        /// <summary>
        /// Verifies that cached credentials are returned immediately even when a pre-cancelled
        /// token is passed, since the fast path does not touch the semaphore.
        /// </summary>
        [TestMethod]
        public void ResolveIdentity_CachedCredentials_PreCancelledToken_ReturnsCachedCredentials()
        {
            AWSConfigs.AWSCredentialsGenerators = new List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator>
            {
                () => new BasicAWSCredentials("key", "secret")
            };

            var resolver = new DefaultAWSCredentialsIdentityResolver();

            // Warm the cache.
            resolver.ResolveIdentity(clientConfig: null);

            // A pre-cancelled token should still return cached credentials since the fast
            // path returns before ever touching the semaphore.
            using (var cts = new CancellationTokenSource())
            {
                cts.Cancel();

                var credentials = resolver.ResolveIdentity(clientConfig: null, cts.Token);
                Assert.IsNotNull(credentials);
                Assert.IsInstanceOfType(credentials, typeof(BasicAWSCredentials));
            }
        }
    }
}
