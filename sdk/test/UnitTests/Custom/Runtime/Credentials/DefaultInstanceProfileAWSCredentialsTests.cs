using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials;
using Amazon.Util.Internal;
using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for <see cref="DefaultInstanceProfileAWSCredentials"/>, a <see cref="RefreshingAWSCredentials"/> that
    /// only resolves credentials from IMDS in GenerateNewCredentials; the advisory window, refresh backoff,
    /// static-stability serve-cache, and invalidation are owned by the base lifecycle. Time comes from a mock clock;
    /// background refreshes and concurrent callers are awaited with timeouts that only elapse when a test fails.
    /// <para />
    /// Also verifies how providers are shared: the container/EC2 fallback path of a resolver reuses one provider per
    /// resolver instance, and the assume-role credential_source=Ec2InstanceMetadata path constructs a fresh provider
    /// per resolution.
    /// </summary>
    [TestClass]
    public sealed class DefaultInstanceProfileAWSCredentialsTests
    {
        private static readonly DateTime Base = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static readonly TimeSpan Lifetime60 = TimeSpan.FromMinutes(60);
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);

        private static DefaultInstanceProfileAWSCredentials NewProvider(StubImds stub, MockTimeProvider clock) =>
            DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, clock);

        #region Basic fetch / cache

        [TestMethod]
        public void GetCredentials_NoCache_FetchesFromIMDS()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var creds = provider.GetCredentials();

            AssertCredentials(1, creds);
            Assert.AreEqual(1, stub.FetchCount);
        }

        [TestMethod]
        public async Task GetCredentialsAsync_NoCache_FetchesFromIMDS()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var creds = await provider.GetCredentialsAsync().ConfigureAwait(false);

            AssertCredentials(1, creds);
            Assert.AreEqual(1, stub.FetchCount);
        }

        [TestMethod]
        public void GetCredentials_Valid_ReturnsCachedNoSecondFetch()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var first = provider.GetCredentials();
            clock.CorrectedUtcNow = Base + TimeSpan.FromMinutes(30); // still Valid (advisory at Base+45)
            var second = provider.GetCredentials();

            Assert.AreEqual(first, second);
            Assert.AreEqual(1, stub.FetchCount);
        }

        [TestMethod]
        public void GetCredentialsAsync_ConcurrentInitialFetch_OnlyOneImdsCall()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            // The IMDS call waits on the gate, so every caller starts while the first one is still fetching: the first
            // holds the refresh lock and the others wait for it.
            var tasks = new Task<ImmutableCredentials>[8];
            stub.CloseGate();
            try
            {
                for (int i = 0; i < tasks.Length; i++)
                    tasks[i] = provider.GetCredentialsAsync();
                Assert.IsTrue(SpinWait.SpinUntil(() => stub.FetchCount == 1, WaitTimeout), "the first caller did not reach IMDS");
                Assert.IsFalse(tasks.Any(t => t.IsCompleted), "every caller must wait for the fetch in progress");
            }
            finally
            {
                stub.OpenGate();
            }
            Assert.IsTrue(Task.WaitAll(tasks, WaitTimeout), "the callers did not finish");

            foreach (var t in tasks)
                AssertCredentials(1, t.Result);
            Assert.AreEqual(1, stub.FetchCount); // single-flight: exactly one source call
        }

        [TestMethod] // Concurrent callers in the advisory window are served at once while one background refresh runs.
        public void GetCredentialsAsync_ConcurrentRequestsInAdvisoryWindow_ServedCachedAndRefreshedOnce()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);
            var initial = provider.GetCredentials(); // AK1
            clock.CorrectedUtcNow = Base + TimeSpan.FromMinutes(50); // Advisory

            stub.CloseGate();
            try
            {
                var tasks = Enumerable.Range(0, 5).Select(_ => provider.GetCredentialsAsync()).ToArray();
                // The background refresh cannot finish while the gate is closed, so every caller received the cached
                // credentials without waiting for it.
                Assert.IsTrue(Task.WaitAll(tasks, WaitTimeout), "advisory callers must not wait for the refresh");
                foreach (var t in tasks)
                    Assert.AreSame(initial, t.Result);
                Assert.IsTrue(SpinWait.SpinUntil(() => stub.FetchCount == 2, WaitTimeout), "the background refresh did not reach IMDS");
            }
            finally
            {
                stub.OpenGate();
            }

            Assert.IsTrue(SpinWait.SpinUntil(() => !ReferenceEquals(initial, provider.GetCredentials()), WaitTimeout),
                "the background refresh did not publish");
            AssertCredentials(2, provider.GetCredentials());
            Assert.AreEqual(2, stub.FetchCount, "exactly one background refresh");
        }

        #endregion

        #region (b) Advisory window

        [TestMethod] // The 60-min IMDS lifetime maps to the 15-min advisory window of the lifetime table.
        public void AdvisoryWindow_60MinLifetime_ComputesFifteenMinuteWindow()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            provider.GetCredentials(); // finalizes the window for this generation
            Assert.AreEqual(TimeSpan.FromMinutes(15), provider.PreemptExpiryTime);
        }

        [TestMethod] // Inside the advisory window the provider serves cached immediately and refreshes in the background.
        public void Advisory_InsideWindow_ServesCachedThenBackgroundRefreshes()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var initial = provider.GetCredentials(); // AK1, fetch #1
            clock.CorrectedUtcNow = Base + TimeSpan.FromMinutes(50); // Advisory (advisory at Base+45, Expiration Base+59)

            var during = provider.GetCredentials();
            Assert.AreEqual(initial, during, "advisory phase must serve the cached credentials immediately");

            // A single background refresh runs off the caller's thread and publishes fresh credentials.
            Assert.IsTrue(SpinWait.SpinUntil(() => stub.FetchCount >= 2, WaitTimeout), "background advisory refresh did not run");
            Assert.IsTrue(SpinWait.SpinUntil(() => provider.GetCredentials().AccessKey == "AK2", WaitTimeout),
                "a later call must observe the background-refreshed credentials");
            Assert.AreEqual(2, stub.FetchCount);
        }

        #endregion

        #region (a) Static stability on IMDS outage + refresh backoff

        [TestMethod]
        public void StaticStability_ImdsOutage_ServesCachedWithBackoff_Sync()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var initial = provider.GetCredentials(); // AK1, fetch #1
            clock.CorrectedUtcNow = Base + TimeSpan.FromMinutes(61); // Expired
            stub.FailNextNFetches(10);

            var served = provider.GetCredentials(); // mandatory refresh fails -> static stability serves cached
            Assert.AreEqual(initial, served, "an IMDS outage must serve the cached credentials (static stability)");

            var fetchesAfterOutage = stub.FetchCount;
            provider.GetCredentials(); // within refresh backoff -> no further IMDS attempt
            Assert.AreEqual(fetchesAfterOutage, stub.FetchCount, "refresh backoff must suppress a further IMDS call");
        }

        [TestMethod]
        public async Task StaticStability_ImdsOutage_ServesCachedWithBackoff_Async()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var initial = await provider.GetCredentialsAsync().ConfigureAwait(false);
            clock.CorrectedUtcNow = Base + TimeSpan.FromMinutes(61);
            stub.FailNextNFetches(10);

            var served = await provider.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreEqual(initial, served);

            var fetchesAfterOutage = stub.FetchCount;
            await provider.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreEqual(fetchesAfterOutage, stub.FetchCount);
        }

        [TestMethod] // An IMDS response whose credentials are already expired is treated as a failed refresh.
        public void ExpiredImdsResponse_WithCache_TreatedAsFailure_ServesCached()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var initial = provider.GetCredentials(); // AK1
            clock.CorrectedUtcNow = Base + TimeSpan.FromMinutes(61); // Expired
            stub.ReturnAlreadyExpiredOnce();                          // next fetch reports an expired credential

            var served = provider.GetCredentials();
            Assert.AreEqual(initial, served, "an already-expired IMDS response is a failed refresh; cached is retained");
        }

        [TestMethod] // With nothing cached, an already-expired IMDS response is still returned (IMDS static stability).
        public void GetCredentials_ReturnsExpiredCredentials()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            stub.ReturnAlreadyExpiredOnce();
            var provider = NewProvider(stub, clock);

            var creds = provider.GetCredentials();

            Assert.AreEqual("AK1", creds.AccessKey);
            Assert.AreEqual("sk1", creds.SecretKey);
            Assert.AreEqual("tok1", creds.Token);
        }

        [TestMethod]
        public async Task GetCredentialsAsync_ReturnsExpiredCredentials()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            stub.ReturnAlreadyExpiredOnce();
            var provider = NewProvider(stub, clock);

            var creds = await provider.GetCredentialsAsync().ConfigureAwait(false);

            Assert.AreEqual("AK1", creds.AccessKey);
            Assert.AreEqual("sk1", creds.SecretKey);
            Assert.AreEqual("tok1", creds.Token);
        }

        #endregion

        #region (c) Invalidation

        [TestMethod]
        public void Invalidate_MatchingKey_NextCallRefreshes()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var initial = provider.GetCredentials(); // AK1
            clock.CorrectedUtcNow = Base + TimeSpan.FromMinutes(5); // Valid

            provider.Invalidate(initial);
            var refreshed = provider.GetCredentials();

            Assert.AreEqual("AK2", refreshed.AccessKey, "Invalidate must route the next call to a mandatory refresh");
        }

        [TestMethod]
        public void Invalidate_NonMatchingKey_NoOp()
        {
            var clock = new MockTimeProvider { CorrectedUtcNow = Base };
            var stub = new StubImds(clock, Lifetime60);
            var provider = NewProvider(stub, clock);

            var initial = provider.GetCredentials();
            clock.CorrectedUtcNow = Base + TimeSpan.FromMinutes(5);

            provider.Invalidate(new ImmutableCredentials("SOME_OTHER_KEY", "s", "t"));
            var again = provider.GetCredentials();

            Assert.AreEqual(initial, again);
            Assert.AreEqual(1, stub.FetchCount);
        }

        #endregion

        #region Singleton removal

        [TestMethod] // The process-wide static singleton is gone: no public/internal Instance accessor remains.
        public void StaticSingleton_Removed_NoInstanceAccessor()
        {
            var type = typeof(DefaultInstanceProfileAWSCredentials);
            Assert.IsNull(type.GetProperty("Instance", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static),
                "the static Instance property must not exist");
            Assert.IsNull(type.GetField("_instance", BindingFlags.NonPublic | BindingFlags.Static),
                "the static _instance field must not exist");
        }

        #endregion

        #region (d) Container path is resolver-owned (shared per resolver)

        [TestMethod]
        public void ContainerPath_ResolverOwned_SharesSingleInstancePerResolver()
        {
            using var resolver = new DefaultAWSCredentialsIdentityResolver();
            var method = typeof(DefaultAWSCredentialsIdentityResolver).GetMethod(
                "GetOrCreateInstanceProfileCredentials", BindingFlags.Instance | BindingFlags.NonPublic);
            Assert.IsNotNull(method, "GetOrCreateInstanceProfileCredentials must exist on the resolver");

            var first = method.Invoke(resolver, null);
            var second = method.Invoke(resolver, null);

            Assert.IsInstanceOfType(first, typeof(DefaultInstanceProfileAWSCredentials));
            Assert.AreSame(first, second,
                "the resolver must reuse a single instance-profile provider");
        }

        #endregion

        #region (e) Static assume-role path yields a fresh instance per resolution

        [TestMethod]
        public void AssumeRoleEc2InstanceMetadataPath_ConstructsFreshInstancePerResolution()
        {
            var method = typeof(AWSCredentialsFactory).GetMethod(
                "GetCredentialSourceAWSCredentials",
                BindingFlags.Static | BindingFlags.NonPublic,
                binder: null,
                types: new[] { typeof(string), typeof(bool) },
                modifiers: null);
            Assert.IsNotNull(method, "GetCredentialSourceAWSCredentials(string, bool) must exist");

            var a = method.Invoke(null, new object[] { "Ec2InstanceMetadata", true });
            var b = method.Invoke(null, new object[] { "Ec2InstanceMetadata", true });

            Assert.IsInstanceOfType(a, typeof(DefaultInstanceProfileAWSCredentials));
            Assert.IsInstanceOfType(b, typeof(DefaultInstanceProfileAWSCredentials));
            Assert.AreNotSame(a, b,
                "the assume-role credential_source=Ec2InstanceMetadata path must construct a fresh provider per resolution");
        }

        #endregion

        private static void AssertCredentials(int generation, ImmutableCredentials credentials)
        {
            Assert.AreEqual("AK" + generation, credentials.AccessKey);
            Assert.AreEqual("sk" + generation, credentials.SecretKey);
            Assert.AreEqual("tok" + generation, credentials.Token);
        }

        #region Test doubles

        private sealed class MockTimeProvider : ITimeProvider
        {
            public DateTime CorrectedUtcNow { get; set; }
        }

        /// <summary>
        /// Deterministic IMDS access stub. Returns a distinct access key per fetch with a fixed lifetime
        /// measured against the mock clock; supports injectable outages (throws), an already-expired
        /// response, and a gate that holds fetches until the test opens it. Every generated state carries the mock clock so the base lifecycle's staleness checks are
        /// driven by the test clock rather than wall-clock time.
        /// </summary>
        private sealed class StubImds : DefaultInstanceProfileAWSCredentials.IIMDSAccessMethods
        {
            private readonly MockTimeProvider _clock;
            private readonly TimeSpan _lifetime;
            private readonly ManualResetEventSlim _gate = new ManualResetEventSlim(initialState: true);
            private int _fetchCount;
            private int _failuresRemaining;
            private bool _returnExpiredOnce;

            public StubImds(MockTimeProvider clock, TimeSpan lifetime)
            {
                _clock = clock;
                _lifetime = lifetime;
            }

            public int FetchCount => Volatile.Read(ref _fetchCount);
            public void FailNextNFetches(int n) => _failuresRemaining = n;
            public void ReturnAlreadyExpiredOnce() => _returnExpiredOnce = true;
            public void CloseGate() => _gate.Reset();
            public void OpenGate() => _gate.Set();

            public RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
            {
                var n = Interlocked.Increment(ref _fetchCount);
                if (!_gate.Wait(WaitTimeout + WaitTimeout))
                    throw new TimeoutException("The test did not open the gate.");

                if (_failuresRemaining > 0)
                {
                    _failuresRemaining--;
                    throw new AmazonServiceException("Simulated IMDS outage.");
                }

                DateTime expiration;
                if (_returnExpiredOnce)
                {
                    _returnExpiredOnce = false;
                    expiration = _clock.CorrectedUtcNow - TimeSpan.FromMinutes(5); // already expired
                }
                else
                {
                    expiration = _clock.CorrectedUtcNow + _lifetime;
                }

                return new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials("AK" + n, "sk" + n, "tok" + n),
                    expiration,
                    _clock);
            }

            public Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync()
            {
                return Task.Run(() => FetchCredentials());
            }

            public void CheckIsIMDSEnabled()
            {
            }
        }

        #endregion
    }
}
