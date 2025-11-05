using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Util.Internal;
using Xunit;

namespace UnitTests.NetStandard.Core.Credentials
{
    public sealed class RefreshingAWSCredentialsTests
    {
        private readonly MockTimeProvider _mockProvider;
        private readonly DateTime _baseTimeUtc = new DateTime(1970, 1, 1).ToUniversalTime();
        private readonly TimeSpan _lifetime = TimeSpan.FromMinutes(60);

        public RefreshingAWSCredentialsTests() => _mockProvider = new MockTimeProvider();

        [Theory]
        [InlineData(59.5)] // Credentials are not expired yet but just entered the ExpirationBuffer
        [InlineData(60)] // Credentials have just expired
        [InlineData(75)] // Credentials are way past expiration
        public void ConcurrentCallsToGetCrendentialsOnlyGeneratesNewCredentialsOnce(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            // Prevent GenerateNewCredentials from returning.
            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            mockCredentials.CloseGenerateCredentialsGate();
            var concurrentCredentialTasks = Task.WhenAll(
                Enumerable.Range(1, 5).Select(i => Task.Run(() => mockCredentials.GetCredentials()))
            );

            // Allow GenerateNewCredentials to complete.
            mockCredentials.OpenGenerateCredentialsGate(); 
            var allCreds = concurrentCredentialTasks.Result;
            Assert.NotEqual(initialCreds, allCreds[0]);

            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
            for (var i = 1; i < allCreds.Length; i++)
            {
                Assert.Equal(allCreds[0], allCreds[i]);
            }
        }

        [Theory]
        [InlineData(59.5)] // Credentials are not expired yet but just entered the ExpirationBuffer
        [InlineData(60)] // Credentials have just expired
        [InlineData(75)] // Credentials are way past expiration
        public async Task ConcurrentCallsToGetCrendentialsOnlyGeneratesNewCredentialsOnceAsync(double instantInMinutes)
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            // Prevent GenerateNewCredentials from returning.
            _mockProvider.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(instantInMinutes);
            mockCredentials.CloseGenerateCredentialsGate();
            var concurrentCredentialTasks = Task.WhenAll(
                Enumerable.Range(1, 5).Select(i => mockCredentials.GetCredentialsAsync())
            );

            // Allow GenerateNewCredentials to complete.
            mockCredentials.OpenGenerateCredentialsGate();
            var allCreds = await concurrentCredentialTasks;

            Assert.NotEqual(initialCreds, allCreds[0]);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
            for (var i = 1; i < allCreds.Length; i++)
            {
                Assert.Equal(allCreds[0], allCreds[i]);
            }
        }

        [Fact]
        public void CredentialsAreRefreshedInImmediatelyWhenExpired()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + _lifetime;
            var credsAfterExpiration = mockCredentials.GetCredentials();
            Assert.NotEqual(initialCreds, credsAfterExpiration);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
        }

        [Fact]
        public async Task CredentialsAreRefreshedInImmediatelyWhenExpiredAsync()
        {
            var mockCredentials = new MockRefreshingAWSCredentials(_lifetime, _mockProvider)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            _mockProvider.CorrectedUtcNow = _baseTimeUtc;
            var initialCreds = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);

            _mockProvider.CorrectedUtcNow = _baseTimeUtc + _lifetime;
            var credsAfterExpiration = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);
            Assert.NotEqual(initialCreds, credsAfterExpiration);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
        }

        [Theory]
        [InlineData(45.5)] // Credentials just entered the preempt expiry period
        [InlineData(50)]
        [InlineData(58.5)] // Credentials are still within the preempt expiry period but before the expiration buffer
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
            Assert.Equal(initialCreds, credsDuringPreemptExpiry);

            // wait for background refresh to complete
            Assert.True(SpinWait.SpinUntil(() => !ReferenceEquals(mockCredentials.CurrentState, previousState), 1_000));

            var credsAfterRefresh = mockCredentials.GetCredentials();
            Assert.NotEqual(credsAfterRefresh, credsDuringPreemptExpiry);
            Assert.Equal(_mockProvider.CorrectedUtcNow + _lifetime - mockCredentials.ExpirationBuffer, mockCredentials.CurrentState.Expiration);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
        }

        [Theory]
        [InlineData(45.5)] // Credentials just entered the preempt expiry period
        [InlineData(50)]
        [InlineData(58.5)] // Credentials are still within the preempt expiry period but before the expiration buffer
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
            Assert.Equal(initialCreds, credsDuringPreemptExpiry);

            // wait for background refresh to complete
            Assert.True(SpinWait.SpinUntil(() => !ReferenceEquals(mockCredentials.CurrentState, previousState), 1_000));

            var credsAfterRefresh = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);
            Assert.NotEqual(credsAfterRefresh, credsDuringPreemptExpiry);
            Assert.Equal(_mockProvider.CorrectedUtcNow + _lifetime - mockCredentials.ExpirationBuffer, mockCredentials.CurrentState.Expiration);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
        }

        private class MockTimeProvider : ITimeProvider
        {
            public DateTime CorrectedUtcNow { get; set; }
        }

        // using a hand-written mock in order to have access to the protected fields
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

            public bool IsGenerateCredentialsGateClosed => !_generateCredsEvent.IsSet;

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
