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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Credentials;
using Amazon.Util;
using Amazon.Util.Internal;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the EC2 instance metadata (IMDS) credential providers and the credential chains that create them:
    /// <list type="bullet">
    /// <item>an already-expired response to the initial fetch is served (IMDS static stability) without arming the
    /// refresh backoff, so the next call contacts IMDS again; the backoff applies only once that refresh fails. Other
    /// providers that use the refresh lifecycle serve such a response the same way;</item>
    /// <item>with IMDS disabled, FallbackCredentialsFactory fails over to anonymous credentials or
    /// "Unable to find credentials" at resolution time;</item>
    /// <item>disposing a DefaultAWSCredentialsIdentityResolver does not break the IMDS credentials it returned.</item>
    /// </list>
    /// Timing is driven by a mock clock (or the SDK clock faked through AWSConfigs), so no real time passes.
    /// </summary>
    [TestClass]
    [DoNotParallelize]
    public sealed class CredentialRefreshImdsTests
    {
        private static readonly DateTime BaseUtc = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static readonly TimeSpan Lifetime60 = TimeSpan.FromMinutes(60);
        private static readonly TimeSpan Backoff = TimeSpan.FromMinutes(7.5); // deterministic, inside [60s,600s]

        private MockTimeProvider _clock;

        [TestInitialize]
        public void Initialize() => _clock = new MockTimeProvider { CorrectedUtcNow = BaseUtc };

        private void SetNow(double minutesFromBase) =>
            _clock.CorrectedUtcNow = BaseUtc + TimeSpan.FromMinutes(minutesFromBase);

        private DefaultInstanceProfileAWSCredentials NewImdsProvider(StubImds stub)
        {
            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, _clock);
            provider.RefreshBackoffGenerator = () => Backoff;
            return provider;
        }

        #region Initial fetch returns already-expired IMDS credentials

        // The expired initial response arms no refresh backoff: the next call contacts IMDS again. When IMDS still
        // returns expired credentials, that failed refresh arms the backoff, and IMDS is not contacted again until it
        // elapses.
        [TestMethod]
        public void DefaultInstanceProfile_InitialFetchExpired_ServedThenImdsPolledOnNextCall_BackoffOnlyAfterFailedRefresh()
        {
            var stub = new StubImds(_clock) { ReturnExpired = true };
            var provider = NewImdsProvider(stub);

            var initial = provider.GetCredentials();
            Assert.AreEqual("AK1", initial.AccessKey, "the expired initial IMDS credentials must be served");
            Assert.AreEqual(1, stub.FetchCount);
            Assert.AreEqual((DateTime?)(BaseUtc - StubImds.ExpiredBy), provider.Expiration, "Expiration must report when they expired");

            SetNow(1); // no backoff after the initial fetch: the expired cached credentials are refreshed now
            Assert.AreSame(initial, provider.GetCredentials(), "an expired response must not replace cached credentials");
            Assert.AreEqual(2, stub.FetchCount, "the next call must contact IMDS again");

            SetNow(8); // inside the backoff armed by the failed refresh at 1 min (1 + 7.5)
            Assert.AreSame(initial, provider.GetCredentials());
            Assert.AreEqual(2, stub.FetchCount, "IMDS must not be polled again during the refresh backoff");

            stub.ReturnExpired = false;
            SetNow(9); // the backoff has elapsed
            var refreshed = provider.GetCredentials();
            Assert.AreEqual("AK3", refreshed.AccessKey, "a fresh IMDS response must replace the expired credentials");
            Assert.AreEqual(3, stub.FetchCount);

            SetNow(30); // fresh credentials are valid: normal lifecycle, no further IMDS call
            Assert.AreSame(refreshed, provider.GetCredentials());
            Assert.AreEqual(3, stub.FetchCount);
        }

        [TestMethod]
        public async Task DefaultInstanceProfile_InitialFetchExpired_ServedThenImdsPolledOnNextCall_BackoffOnlyAfterFailedRefresh_Async()
        {
            var stub = new StubImds(_clock) { ReturnExpired = true };
            var provider = NewImdsProvider(stub);

            var initial = await provider.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreEqual("AK1", initial.AccessKey, "the expired initial IMDS credentials must be served");
            Assert.AreEqual(1, stub.FetchCount);
            Assert.AreEqual((DateTime?)(BaseUtc - StubImds.ExpiredBy), provider.Expiration, "Expiration must report when they expired");

            SetNow(1);
            Assert.AreSame(initial, await provider.GetCredentialsAsync().ConfigureAwait(false),
                "an expired response must not replace cached credentials");
            Assert.AreEqual(2, stub.FetchCount, "the next call must contact IMDS again");

            SetNow(8);
            Assert.AreSame(initial, await provider.GetCredentialsAsync().ConfigureAwait(false));
            Assert.AreEqual(2, stub.FetchCount, "IMDS must not be polled again during the refresh backoff");

            stub.ReturnExpired = false;
            SetNow(9);
            var refreshed = await provider.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreEqual("AK3", refreshed.AccessKey, "a fresh IMDS response must replace the expired credentials");
            Assert.AreEqual(3, stub.FetchCount);

            SetNow(30);
            Assert.AreSame(refreshed, await provider.GetCredentialsAsync().ConfigureAwait(false));
            Assert.AreEqual(3, stub.FetchCount);
        }

        // The expired initial response is refreshed on the next call; IMDS keeps returning expired credentials, so each
        // of those refreshes fails and re-arms the backoff.
        [TestMethod]
        public void DefaultInstanceProfile_InitialFetchExpired_StillExpiredOnEveryRefresh_KeepsServingAndBacksOffAfterEachFailure()
        {
            var stub = new StubImds(_clock) { ReturnExpired = true };
            var provider = NewImdsProvider(stub);

            var initial = provider.GetCredentials(); // AK1, fetch #1

            SetNow(1); // next call; IMDS still returns expired credentials (AK2)
            Assert.AreSame(initial, provider.GetCredentials(), "an expired response must not replace cached credentials");
            Assert.AreEqual(2, stub.FetchCount);

            SetNow(9); // past the backoff armed at 1 min (1 + 7.5); IMDS still returns expired credentials (AK3)
            Assert.AreSame(initial, provider.GetCredentials());
            Assert.AreEqual(3, stub.FetchCount);

            SetNow(16); // inside the re-armed backoff (9 + 7.5)
            Assert.AreSame(initial, provider.GetCredentials());
            Assert.AreEqual(3, stub.FetchCount, "the failed refresh must re-arm the backoff");

            SetNow(17); // past the re-armed backoff
            provider.GetCredentials();
            Assert.AreEqual(4, stub.FetchCount);
        }

        [TestMethod]
        public async Task DefaultInstanceProfile_InitialFetchExpired_StillExpiredOnEveryRefresh_KeepsServingAndBacksOffAfterEachFailure_Async()
        {
            var stub = new StubImds(_clock) { ReturnExpired = true };
            var provider = NewImdsProvider(stub);

            var initial = await provider.GetCredentialsAsync().ConfigureAwait(false);

            SetNow(1);
            Assert.AreSame(initial, await provider.GetCredentialsAsync().ConfigureAwait(false),
                "an expired response must not replace cached credentials");
            Assert.AreEqual(2, stub.FetchCount);

            SetNow(9);
            Assert.AreSame(initial, await provider.GetCredentialsAsync().ConfigureAwait(false));
            Assert.AreEqual(3, stub.FetchCount);

            SetNow(16);
            Assert.AreSame(initial, await provider.GetCredentialsAsync().ConfigureAwait(false));
            Assert.AreEqual(3, stub.FetchCount, "the failed refresh must re-arm the backoff");

            SetNow(17);
            await provider.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreEqual(4, stub.FetchCount);
        }

        // Callers queued behind the initial fetch find the expired credentials it cached, so the first of them runs the
        // mandatory refresh (IMDS call #2). IMDS still returns expired credentials, so that refresh fails and arms the
        // backoff, and every remaining caller is served from the cache without contacting IMDS. Callers that start
        // after the initial fetch has completed take the same path, so the count is exact whatever the interleaving.
        [TestMethod]
        public void DefaultInstanceProfile_InitialFetchExpired_ConcurrentCallers_InitialFetchAndOneFailedRefresh()
        {
            var stub = new StubImds(_clock) { ReturnExpired = true };
            var provider = NewImdsProvider(stub);

            var tasks = new Task<ImmutableCredentials>[8];
            for (int i = 0; i < tasks.Length; i++)
                tasks[i] = Task.Run(() => provider.GetCredentialsAsync());
            Assert.IsTrue(Task.WaitAll(tasks, TimeSpan.FromSeconds(30)), "the callers did not finish");

            foreach (var t in tasks)
                Assert.AreEqual("AK1", t.Result.AccessKey, "an expired refresh response must not replace the cached credentials");
            Assert.AreEqual(2, stub.FetchCount,
                "exactly the initial fetch and one mandatory refresh; the refresh backoff it armed must serve the other callers from the cache");
        }

        [TestMethod]
        public void InstanceProfile_InitialFetchExpired_ServedThenImdsPolledOnNextCall_BackoffOnlyAfterFailedRefresh()
        {
            var now = BaseUtc;
            using (new AWSConfigsDateFaker(() => now))
            {
                var provider = new StubInstanceProfileCredentials { ReturnExpired = true };
                provider.RefreshBackoffGenerator = () => Backoff;

                var initial = provider.GetCredentials();
                Assert.AreEqual("IP1", initial.AccessKey, "the expired initial IMDS credentials must be served");

                now = BaseUtc.AddMinutes(1); // no backoff after the initial fetch: IMDS is contacted again
                Assert.AreSame(initial, provider.GetCredentials(), "an expired response must not replace cached credentials");
                Assert.AreEqual(2, provider.FetchCount, "the next call must contact IMDS again");

                now = BaseUtc.AddMinutes(5); // inside the backoff armed by the failed refresh (1 + 7.5)
                Assert.AreSame(initial, provider.GetCredentials());
                Assert.AreEqual(2, provider.FetchCount, "IMDS must not be polled again during the refresh backoff");

                provider.ReturnExpired = false;
                now = BaseUtc.AddMinutes(9);
                Assert.AreEqual("IP3", provider.GetCredentials().AccessKey);
                Assert.AreEqual(3, provider.FetchCount);
            }
        }

        [TestMethod]
        public async Task InstanceProfile_InitialFetchExpired_ServedThenImdsPolledOnNextCall_BackoffOnlyAfterFailedRefresh_Async()
        {
            var now = BaseUtc;
            using (new AWSConfigsDateFaker(() => now))
            {
                var provider = new StubInstanceProfileCredentials { ReturnExpired = true };
                provider.RefreshBackoffGenerator = () => Backoff;

                var initial = await provider.GetCredentialsAsync().ConfigureAwait(false);
                Assert.AreEqual("IP1", initial.AccessKey, "the expired initial IMDS credentials must be served");

                now = BaseUtc.AddMinutes(1);
                Assert.AreSame(initial, await provider.GetCredentialsAsync().ConfigureAwait(false),
                    "an expired response must not replace cached credentials");
                Assert.AreEqual(2, provider.FetchCount, "the next call must contact IMDS again");

                now = BaseUtc.AddMinutes(5);
                Assert.AreSame(initial, await provider.GetCredentialsAsync().ConfigureAwait(false));
                Assert.AreEqual(2, provider.FetchCount, "IMDS must not be polled again during the refresh backoff");

                provider.ReturnExpired = false;
                now = BaseUtc.AddMinutes(9);
                Assert.AreEqual("IP3", (await provider.GetCredentialsAsync().ConfigureAwait(false)).AccessKey);
                Assert.AreEqual(3, provider.FetchCount);
            }
        }

        // A provider other than IMDS that uses the refresh lifecycle serves an expired initial response too, and the
        // next call refreshes it at once: a fresh response replaces it.
        [TestMethod]
        public void NonImdsProvider_InitialFetchExpired_ServedThenRefreshedOnNextCall()
        {
            var provider = new ExpiredFirstCredentials(_clock);

            var initial = provider.GetCredentials();
            Assert.AreEqual("OTHER1", initial.AccessKey, "the expired initial credentials must be served, not fail the fetch");
            Assert.AreEqual((DateTime?)(BaseUtc - StubImds.ExpiredBy), provider.Expiration, "Expiration must report when they expired");
            Assert.AreEqual(1, provider.FetchCount);

            provider.ReturnExpired = false;
            var refreshed = provider.GetCredentials(); // same instant: no backoff was armed
            Assert.AreEqual("OTHER2", refreshed.AccessKey, "the next call must refresh the expired credentials");
            Assert.AreEqual(2, provider.FetchCount);
            Assert.AreSame(refreshed, provider.GetCredentials(), "the fresh credentials are cached");
            Assert.AreEqual(2, provider.FetchCount);
        }

        [TestMethod]
        public async Task NonImdsProvider_InitialFetchExpired_ServedThenRefreshedOnNextCall_Async()
        {
            var provider = new ExpiredFirstCredentials(_clock);

            var initial = await provider.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreEqual("OTHER1", initial.AccessKey, "the expired initial credentials must be served, not fail the fetch");
            Assert.AreEqual((DateTime?)(BaseUtc - StubImds.ExpiredBy), provider.Expiration, "Expiration must report when they expired");
            Assert.AreEqual(1, provider.FetchCount);

            provider.ReturnExpired = false;
            var refreshed = await provider.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreEqual("OTHER2", refreshed.AccessKey, "the next call must refresh the expired credentials");
            Assert.AreEqual(2, provider.FetchCount);
            Assert.AreSame(refreshed, await provider.GetCredentialsAsync().ConfigureAwait(false), "the fresh credentials are cached");
            Assert.AreEqual(2, provider.FetchCount);
        }

        [TestMethod]
        public void DefaultResolver_InitialImdsFetchExpired_ReturnsImdsProvider()
        {
            var stub = new StubImds(_clock) { ReturnExpired = true };
            var provider = NewImdsProvider(stub);

            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                ReflectionHelpers.Invoke(resolver, "_instanceProfileCredentials", provider);

                var resolved = InvokeContainerEC2CredentialsWrapper(resolver);

                Assert.AreSame(provider, resolved, "the EC2 step of the default chain must accept the expired IMDS credentials");
                Assert.AreEqual(1, stub.FetchCount, "resolving the chain fetches once");

                // The expired credentials armed no backoff, so the next call refreshes them; IMDS still returns
                // expired credentials, so the cached ones are served.
                Assert.AreEqual("AK1", resolved.GetCredentials().AccessKey);
                Assert.AreEqual(2, stub.FetchCount, "the next call must refresh the expired credentials");
            }
        }

        #endregion

        #region Scheduled refresh of the default IMDS provider

        // The default IMDS provider looks for newer credentials on a timer (every 2 minutes in production), even while
        // the cached credentials are valid, so credentials that IMDS rotates in are picked up without any call to
        // GetCredentials. A test-created provider gets the timer only when an interval is passed, so the run here pairs
        // a provider with a short interval and one without; both stubs return valid credentials with a new access key
        // on every fetch. Waiting for the timed provider to fetch twice more proves that its timer has fired while the
        // untimed provider has had the same time to fetch, and it never does. The waits are bounded by a timeout that
        // only elapses when the test fails.
        [TestMethod]
        public void DefaultInstanceProfile_ScheduledRefresh_FetchesWithoutCallsAndCachesRotatedCredentials_OnlyWhenIntervalGiven()
        {
            Assert.IsTrue(EC2InstanceMetadata.IsIMDSEnabled, "precondition: the scheduled refresh runs only while IMDS is enabled");
            var timedStub = new StubImds(_clock);
            var untimedStub = new StubImds(_clock);
            var timed = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(
                timedStub, _clock, TimeSpan.FromMilliseconds(50));
            var untimed = NewImdsProvider(untimedStub);
            try
            {
                Assert.AreEqual("AK1", timed.GetCredentials().AccessKey);
                Assert.AreEqual("AK1", untimed.GetCredentials().AccessKey);

                // No further GetCredentials calls: only the timer can contact IMDS. The cached credentials stay valid
                // (the mock clock does not move), so these are proactive refreshes, not window-driven ones.
                Assert.IsTrue(SpinWait.SpinUntil(() => timedStub.FetchCount >= 3, TimeSpan.FromSeconds(30)),
                    "the scheduled refresh did not contact IMDS");
                Assert.AreEqual(1, untimedStub.FetchCount, "without an interval the provider must not refresh on a schedule");

                // A rotated access key from IMDS replaces the cached one.
                Assert.IsTrue(SpinWait.SpinUntil(() => timed.GetCredentials().AccessKey != "AK1", TimeSpan.FromSeconds(30)),
                    "the rotated credentials from the scheduled refresh were not cached");
                Assert.AreEqual("AK1", untimed.GetCredentials().AccessKey);
                Assert.AreEqual(1, untimedStub.FetchCount);
            }
            finally
            {
                timed.Dispose(); // stops the timer
                untimed.Dispose();
            }
        }

        #endregion

        #region FallbackCredentialsFactory with IMDS disabled

        [TestMethod]
        public void FallbackCredentialsFactory_ImdsDisabled_FallbackToAnonymous_ReturnsAnonymousCredentials()
        {
            using (new FallbackFactoryTest.FallbackFactoryTestFixture("", "imds-tests-nonexistent-profile", ImdsDisabledIsolatedEnvironment()))
            {
                Assert.IsFalse(EC2InstanceMetadata.IsIMDSEnabled, "precondition: IMDS disabled via AWS_EC2_METADATA_DISABLED");

                var creds = FallbackCredentialsFactory.GetCredentials(fallbackToAnonymous: true);
                Assert.IsInstanceOfType(creds, typeof(AnonymousAWSCredentials));

                // The IMDS provider was not cached either: a second resolution walks the chain again.
                Assert.IsInstanceOfType(FallbackCredentialsFactory.GetCredentials(fallbackToAnonymous: true), typeof(AnonymousAWSCredentials));
            }
        }

        [TestMethod]
        public void FallbackCredentialsFactory_ImdsDisabled_NoFallback_ThrowsUnableToFindCredentials()
        {
            using (new FallbackFactoryTest.FallbackFactoryTestFixture("", "imds-tests-nonexistent-profile", ImdsDisabledIsolatedEnvironment()))
            {
                Assert.IsFalse(EC2InstanceMetadata.IsIMDSEnabled, "precondition: IMDS disabled via AWS_EC2_METADATA_DISABLED");

                var ex = Assert.ThrowsExactly<AmazonServiceException>(() => FallbackCredentialsFactory.GetCredentials(fallbackToAnonymous: false));
                StringAssert.StartsWith(ex.Message, "Unable to find credentials");
                StringAssert.Contains(ex.Message, "Unable to retrieve credentials.", "the IMDS step must report that IMDS is disabled");
            }
        }

        private static Dictionary<string, string> ImdsDisabledIsolatedEnvironment() => new Dictionary<string, string>
        {
            ["AWS_EC2_METADATA_DISABLED"] = "true",
            ["AWS_ACCESS_KEY_ID"] = null,
            ["AWS_SECRET_ACCESS_KEY"] = null,
            ["AWS_SESSION_TOKEN"] = null,
            ["AWS_ACCESS_KEY"] = null,
            ["AWS_SECRET_KEY"] = null,
            ["AWS_ACCOUNT_ID"] = null,
            ["AWS_WEB_IDENTITY_TOKEN_FILE"] = null,
            ["AWS_ROLE_ARN"] = null,
            ["AWS_ROLE_SESSION_NAME"] = null,
            ["AWS_CONTAINER_CREDENTIALS_RELATIVE_URI"] = null,
            ["AWS_CONTAINER_CREDENTIALS_FULL_URI"] = null,
        };

        #endregion

        #region Disposing DefaultAWSCredentialsIdentityResolver

        [TestMethod]
        public void DisposingResolver_ImdsCredentialsItReturned_KeepRefreshing()
        {
            var stub = new StubImds(_clock);
            var provider = NewImdsProvider(stub);

            AWSCredentials handedOut;
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                ReflectionHelpers.Invoke(resolver, "_instanceProfileCredentials", provider);
                handedOut = InvokeContainerEC2CredentialsWrapper(resolver); // fetch #1, AK1
            }

            SetNow(61); // past expiration: the next call is a blocking (mandatory) refresh
            Assert.AreEqual("AK2", handedOut.GetCredentials().AccessKey,
                "credentials returned by a disposed resolver must keep working");
            Assert.AreEqual(2, stub.FetchCount);
        }

        [TestMethod]
        public async Task DisposingResolver_ImdsCredentialsItReturned_KeepRefreshing_Async()
        {
            var stub = new StubImds(_clock);
            var provider = NewImdsProvider(stub);

            AWSCredentials handedOut;
            using (var resolver = new DefaultAWSCredentialsIdentityResolver())
            {
                ReflectionHelpers.Invoke(resolver, "_instanceProfileCredentials", provider);
                handedOut = InvokeContainerEC2CredentialsWrapper(resolver);
            }

            SetNow(61);
            Assert.AreEqual("AK2", (await handedOut.GetCredentialsAsync().ConfigureAwait(false)).AccessKey,
                "credentials returned by a disposed resolver must keep working");
            Assert.AreEqual(2, stub.FetchCount);
        }

        #endregion

        #region Helpers and test doubles

        /// <summary>
        /// Runs the EC2 step of the resolver's default chain with the container credential variables cleared, so the
        /// step goes to the resolver's instance-metadata provider.
        /// </summary>
        private static AWSCredentials InvokeContainerEC2CredentialsWrapper(DefaultAWSCredentialsIdentityResolver resolver)
        {
            var relativeUri = Environment.GetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable);
            var fullUri = Environment.GetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, null);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable, null);
            try
            {
                return (AWSCredentials)ReflectionHelpers.Invoke(resolver, "ContainerEC2CredentialsWrapper");
            }
            finally
            {
                Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, relativeUri);
                Environment.SetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable, fullUri);
            }
        }

        private sealed class MockTimeProvider : ITimeProvider
        {
            public DateTime CorrectedUtcNow { get; set; }
        }

        /// <summary>
        /// IMDS access stub. Each fetch returns a distinct access key (AK1, AK2, ...) that is either already expired or
        /// valid for 60 minutes, measured against the mock clock.
        /// </summary>
        private sealed class StubImds : DefaultInstanceProfileAWSCredentials.IIMDSAccessMethods
        {
            internal static readonly TimeSpan ExpiredBy = TimeSpan.FromMinutes(30);

            private readonly MockTimeProvider _clock;
            private int _fetchCount;

            public StubImds(MockTimeProvider clock)
            {
                _clock = clock;
            }

            public bool ReturnExpired { get; set; }
            public int FetchCount => Volatile.Read(ref _fetchCount);

            public RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
            {
                var n = Interlocked.Increment(ref _fetchCount);
                var now = _clock.CorrectedUtcNow;
                var expiration = ReturnExpired ? now - ExpiredBy : now + Lifetime60;
                return new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials("AK" + n, "sk" + n, "tok" + n), expiration, _clock);
            }

            public Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync()
            {
                return Task.Run(() => FetchCredentials());
            }

            public void CheckIsIMDSEnabled()
            {
            }
        }

        /// <summary>
        /// An <see cref="InstanceProfileAWSCredentials"/> whose IMDS call is replaced by canned responses, timed by the
        /// SDK clock (faked by the test through <see cref="AWSConfigsDateFaker"/>).
        /// </summary>
        private sealed class StubInstanceProfileCredentials : InstanceProfileAWSCredentials
        {
            private int _fetchCount;

            public StubInstanceProfileCredentials() : base("dummyRole") { }

            public bool ReturnExpired { get; set; }
            public int FetchCount => Volatile.Read(ref _fetchCount);

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var n = Interlocked.Increment(ref _fetchCount);
                var now = AWSSDKUtils.CorrectedUtcNow;
                var expiration = ReturnExpired ? now - StubImds.ExpiredBy : now + Lifetime60;
                return new CredentialsRefreshState(new ImmutableCredentials("IP" + n, "sk" + n, "tok" + n), expiration);
            }

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                return Task.FromResult(GenerateNewCredentials());
            }
        }

        /// <summary>
        /// An in-scope provider other than IMDS whose responses have already expired until the test sets
        /// <see cref="ReturnExpired"/> to false. Each fetch returns a distinct access key (OTHER1, OTHER2, ...).
        /// </summary>
        private sealed class ExpiredFirstCredentials : RefreshingAWSCredentials
        {
            private int _fetchCount;

            public ExpiredFirstCredentials(ITimeProvider timeProvider) : base(timeProvider)
            {
                RefreshBackoffGenerator = () => Backoff;
            }

            public bool ReturnExpired { get; set; } = true;
            public int FetchCount => Volatile.Read(ref _fetchCount);

            protected override bool UsesManagedRefreshLifecycle => true;

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var n = Interlocked.Increment(ref _fetchCount);
                var now = _timeProvider.CorrectedUtcNow;
                var expiration = ReturnExpired ? now - StubImds.ExpiredBy : now + Lifetime60;
                return new CredentialsRefreshState(
                    new ImmutableCredentials("OTHER" + n, "sk" + n, "tok" + n), expiration, _timeProvider);
            }

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                return Task.FromResult(GenerateNewCredentials());
            }
        }

        #endregion
    }
}
