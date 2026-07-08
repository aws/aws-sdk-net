#if !NETFRAMEWORK
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public sealed class RefreshingAWSCredentialsTests
    {
        private MockTimeProvider _mockProvider;
        private readonly DateTime _baseTimeUtc = new DateTime(1970, 1, 1).ToUniversalTime();
        private readonly TimeSpan _lifetime = TimeSpan.FromMinutes(60);

        [TestInitialize]
        public void Initialize() => _mockProvider = new MockTimeProvider();

        [TestMethod]
        [DataRow(59.5)]
        [DataRow(60)]
        [DataRow(75)]
        public void ConcurrentCallsToGetCredentialsOnlyGeneratesNewCredentialsOnce(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            mockCredentials.CloseGenerateCredentialsGate();
            var concurrentCredentialTasks = Task.WhenAll(
                Enumerable.Range(1, 5).Select(i => Task.Run(() => mockCredentials.GetCredentials()))
            );

            mockCredentials.OpenGenerateCredentialsGate();
            var allCreds = concurrentCredentialTasks.Result;
            Assert.AreNotEqual(initialCreds, allCreds[0]);

            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
            for (var i = 1; i < allCreds.Length; i++)
            {
                Assert.AreEqual(allCreds[0], allCreds[i]);
            }
        }

        [TestMethod]
        [DataRow(59.5)]
        [DataRow(60)]
        [DataRow(75)]
        public async Task ConcurrentCallsToGetCredentialsOnlyGeneratesNewCredentialsOnceAsync(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            mockCredentials.CloseGenerateCredentialsGate();
            var concurrentCredentialTasks = Task.WhenAll(
                Enumerable.Range(1, 5).Select(i => mockCredentials.GetCredentialsAsync())
            );

            mockCredentials.OpenGenerateCredentialsGate();
            var allCreds = await concurrentCredentialTasks;

            Assert.AreNotEqual(initialCreds, allCreds[0]);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
            for (var i = 1; i < allCreds.Length; i++)
            {
                Assert.AreEqual(allCreds[0], allCreds[i]);
            }
        }

        [TestMethod]
        [DataRow(15, 1, 60)]
        [DataRow(5, 10, 51)]
        public void CredentialsAreRefreshedImmediatelyWhenExpired(int preemptInMinutes, int bufferInMinutes, double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(preemptInMinutes),
                ExpirationBuffer = TimeSpan.FromMinutes(bufferInMinutes),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            var credsAfterExpiration = mockCredentials.GetCredentials();
            Assert.AreNotEqual(initialCreds, credsAfterExpiration);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        [DataRow(15, 1, 60)]
        [DataRow(5, 10, 51)]
        public async Task CredentialsAreRefreshedImmediatelyWhenExpiredAsync(int preemptInMinutes, int bufferInMinutes, double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(preemptInMinutes),
                ExpirationBuffer = TimeSpan.FromMinutes(bufferInMinutes),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            var credsAfterExpiration = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreNotEqual(initialCreds, credsAfterExpiration);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        [DataRow(45.5)]
        [DataRow(50)]
        [DataRow(58.5)]
        public void CredentialsAreRefreshedInBackgroundDuringPreemptyExpiryPeriod(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            var previousState = mockCredentials.CurrentState;
            var credsDuringPreemptExpiry = mockCredentials.GetCredentials();
            Assert.AreEqual(initialCreds, credsDuringPreemptExpiry);

            Assert.IsTrue(SpinWait.SpinUntil(() => !ReferenceEquals(mockCredentials.CurrentState, previousState), 1_000));

            var credsAfterRefresh = mockCredentials.GetCredentials();
            Assert.AreNotEqual(credsAfterRefresh, credsDuringPreemptExpiry);
            AssertCredentialsWereRefreshedAtCurrentTime(mockCredentials);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        [DataRow(45.5)]
        [DataRow(50)]
        [DataRow(58.5)]
        public async Task CredentialsAreRefreshedInBackgroundDuringPreemptyExpiryPeriodAsync(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            var previousState = mockCredentials.CurrentState;
            var credsDuringPreemptExpiry = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreEqual(initialCreds, credsDuringPreemptExpiry);

            Assert.IsTrue(SpinWait.SpinUntil(() => !ReferenceEquals(mockCredentials.CurrentState, previousState), 1_000));

            var credsAfterRefresh = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);
            Assert.AreNotEqual(credsAfterRefresh, credsDuringPreemptExpiry);
            AssertCredentialsWereRefreshedAtCurrentTime(mockCredentials);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        public void ConcurrentCallsDuringPreemptWindowOnlyGeneratesNewCredentialsOnce()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();
            var previousState = mockCredentials.CurrentState;

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(50);
            mockCredentials.CloseGenerateCredentialsGate();

            var tasks = Enumerable.Range(1, 5)
                .Select(_ => Task.Run(() => mockCredentials.GetCredentials()))
                .ToArray();
            mockCredentials.OpenGenerateCredentialsGate();
            Task.WaitAll(tasks);

            Assert.IsTrue(SpinWait.SpinUntil(() => !ReferenceEquals(mockCredentials.CurrentState, previousState), 1_000));

            var credsAfterRefresh = mockCredentials.GetCredentials();
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
            Assert.AreNotEqual(initialCreds, credsAfterRefresh);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(30)]
        [DataRow(44)] // Exactly minimumLifetime remaining is not considered expired-within.
        public void GetCredentialsReturnsCurrentCredentialsWhenMinimumLifetimeIsSatisfied(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            var creds = mockCredentials.GetCredentials(TimeSpan.FromMinutes(15));

            Assert.AreEqual(initialCreds, creds);
            Assert.AreEqual(1, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(30)]
        [DataRow(44)] // Exactly minimumLifetime remaining is not considered expired-within.
        public async Task GetCredentialsReturnsCurrentCredentialsWhenMinimumLifetimeIsSatisfiedAsync(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            var creds = await mockCredentials.GetCredentialsAsync(TimeSpan.FromMinutes(15)).ConfigureAwait(false);

            Assert.AreEqual(initialCreds, creds);
            Assert.AreEqual(1, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        [DataRow(44.5)] // Credentials expire within the minimum lifetime.
        [DataRow(58)]   // Credentials are close to expiration.
        [DataRow(75)]   // Credentials are fully expired.
        public void GetCredentialsRegeneratesCredentialsExpiringWithinMinimumLifetime(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            var creds = mockCredentials.GetCredentials(TimeSpan.FromMinutes(15));

            Assert.AreNotEqual(initialCreds, creds);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
            AssertCredentialsWereRefreshedAtCurrentTime(mockCredentials);
        }

        [TestMethod]
        [DataRow(44.5)] // Credentials expire within the minimum lifetime.
        [DataRow(58)]   // Credentials are close to expiration.
        [DataRow(75)]   // Credentials are fully expired.
        public async Task GetCredentialsRegeneratesCredentialsExpiringWithinMinimumLifetimeAsync(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            var creds = await mockCredentials.GetCredentialsAsync(TimeSpan.FromMinutes(15)).ConfigureAwait(false);

            Assert.AreNotEqual(initialCreds, creds);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
            AssertCredentialsWereRefreshedAtCurrentTime(mockCredentials);
        }

        [TestMethod]
        public void GetCredentialsGeneratesCredentialsWhenNoneExist()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var creds = mockCredentials.GetCredentials(TimeSpan.FromMinutes(15));

            Assert.IsNotNull(creds);
            Assert.AreEqual(1, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        public async Task GetCredentialsGeneratesCredentialsWhenNoneExistAsync()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var creds = await mockCredentials.GetCredentialsAsync(TimeSpan.FromMinutes(15)).ConfigureAwait(false);

            Assert.IsNotNull(creds);
            Assert.AreEqual(1, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        public void GetCredentialsRegeneratesOnEveryCallWhenMinimumLifetimeExceedsSessionDuration()
        {
            // A provider whose sessions are shorter than the requested minimum lifetime can never
            // satisfy it; GetCredentials still returns the freshest credentials available on every call.
            var mockCredentials = new MockRefreshingAWSCredentials(TimeSpan.FromMinutes(10), _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var firstCreds = mockCredentials.GetCredentials(TimeSpan.FromMinutes(15));
            var secondCreds = mockCredentials.GetCredentials(TimeSpan.FromMinutes(15));

            Assert.AreNotEqual(firstCreds, secondCreds);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        public async Task GetCredentialsRegeneratesOnEveryCallWhenMinimumLifetimeExceedsSessionDurationAsync()
        {
            // A provider whose sessions are shorter than the requested minimum lifetime can never
            // satisfy it; GetCredentials still returns the freshest credentials available on every call.
            var mockCredentials = new MockRefreshingAWSCredentials(TimeSpan.FromMinutes(10), _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var firstCreds = await mockCredentials.GetCredentialsAsync(TimeSpan.FromMinutes(15)).ConfigureAwait(false);
            var secondCreds = await mockCredentials.GetCredentialsAsync(TimeSpan.FromMinutes(15)).ConfigureAwait(false);

            Assert.AreNotEqual(firstCreds, secondCreds);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
        }

        [TestMethod]
        public void ConcurrentCallsToGetCredentialsOnlyGeneratesNewCredentialsOnce()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(50);
            mockCredentials.CloseGenerateCredentialsGate();
            var concurrentCredentialTasks = Task.WhenAll(
                Enumerable.Range(1, 5).Select(i => Task.Run(() => mockCredentials.GetCredentials(TimeSpan.FromMinutes(15))))
            );

            mockCredentials.OpenGenerateCredentialsGate();
            var allCreds = concurrentCredentialTasks.Result;

            Assert.AreNotEqual(initialCreds, allCreds[0]);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
            for (var i = 1; i < allCreds.Length; i++)
            {
                Assert.AreEqual(allCreds[0], allCreds[i]);
            }
        }

        [TestMethod]
        public async Task ConcurrentCallsToGetCredentialsOnlyGeneratesNewCredentialsOnceAsync()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(50);
            mockCredentials.CloseGenerateCredentialsGate();
            var concurrentCredentialTasks = Task.WhenAll(
                Enumerable.Range(1, 5).Select(i => mockCredentials.GetCredentialsAsync(TimeSpan.FromMinutes(15)))
            );

            mockCredentials.OpenGenerateCredentialsGate();
            var allCreds = await concurrentCredentialTasks;

            Assert.AreNotEqual(initialCreds, allCreds[0]);
            Assert.AreEqual(2, mockCredentials.GeneratedTokenCount);
            for (var i = 1; i < allCreds.Length; i++)
            {
                Assert.AreEqual(allCreds[0], allCreds[i]);
            }
        }

        [TestMethod]
        public void GetCredentialsRejectsNegativeMinimumLifetime()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => mockCredentials.GetCredentials(TimeSpan.FromMinutes(-1)));
        }

        [TestMethod]
        public async Task GetCredentialsRejectsNegativeMinimumLifetimeAsync()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider);
            await Assert.ThrowsExactlyAsync<ArgumentOutOfRangeException>(() => mockCredentials.GetCredentialsAsync(TimeSpan.FromMinutes(-1)));
        }

        private void AssertCredentialsWereRefreshedAtCurrentTime(MockRefreshingAWSCredentials mockCredentials)
        {
            Assert.AreEqual(_mockProvider.CorrectedUtcNow + _lifetime - mockCredentials.ExpirationBuffer, mockCredentials.CurrentState.Expiration);
        }

        private class MockTimeProvider : ITimeProvider
        {
            public DateTime CorrectedUtcNow { get; set; }
        }

        private sealed class MockRefreshingAWSCredentials : RefreshingAWSCredentials
        {
            private readonly TimeSpan _credentialsLifetime;
            private readonly ManualResetEventSlim _generateCredsEvent;
            private int _tokenCounter;

            public MockRefreshingAWSCredentials(TimeSpan credentialsLifetime, ITimeProvider timeProvider)
                : base(timeProvider)
            {
                _credentialsLifetime = credentialsLifetime;
                _generateCredsEvent = new ManualResetEventSlim(initialState: true);
                _tokenCounter = 0;
            }

            public CredentialsRefreshState CurrentState => base.currentState;

            public int GeneratedTokenCount => _tokenCounter;

            public void OpenGenerateCredentialsGate()
            {
                _generateCredsEvent.Set();
            }

            public void CloseGenerateCredentialsGate()
            {
                _generateCredsEvent.Reset();
            }

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                _generateCredsEvent.Wait();

                var credentials = new ImmutableCredentials("access_key_id", "secret_access_key", $"token_{Interlocked.Increment(ref _tokenCounter)}");
                var expiration = _timeProvider.CorrectedUtcNow + _credentialsLifetime;
                return new CredentialsRefreshState(credentials, expiration, _timeProvider);
            }

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                return Task.Run(GenerateNewCredentials);
            }
        }
    }
}
#endif
