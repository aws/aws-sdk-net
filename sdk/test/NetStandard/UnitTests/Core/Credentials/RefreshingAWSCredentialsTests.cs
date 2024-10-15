using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Xunit;

namespace UnitTests.NetStandard.Core.Credentials
{
    public sealed class RefreshingAWSCredentialsTests : IDisposable
    {
        private readonly Func<DateTime> _resetUtcNowSource;

        public RefreshingAWSCredentialsTests()
        {
            _resetUtcNowSource = AWSConfigs.utcNowSource;
        }

        [Fact]
        public void ConcurrentCallsToGetExpiredCrendentialsOnlyGeneratesNewCredentialsOnce()
        {
            var baseTimeUtc = new DateTime(1970, 1, 1).ToUniversalTime();
            var lifetime = TimeSpan.FromMinutes(60);
            var mockCredentials = new MockRefreshingAWSCredentials(lifetime)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            AWSConfigs.utcNowSource = () => baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();
            
            AWSConfigs.utcNowSource = () => baseTimeUtc + lifetime;

            mockCredentials.CloseGenerateCredentialsGate(); // prevent GenerateNewCredentials from returning

            var concurrentCredentialTasks = Task.WhenAll(
                    Enumerable.Range(1, 5)
                        .Select(i => Task.Run(() => mockCredentials.GetCredentials()))
                    );

            mockCredentials.OpenGenerateCredentialsGate(); // allow GenerateNewCredentials to complete

            var allCreds = concurrentCredentialTasks.Result;
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
            var baseTimeUtc = new DateTime(1970, 1, 1).ToUniversalTime();
            var lifetime = TimeSpan.FromMinutes(60);
            var mockCredentials = new MockRefreshingAWSCredentials(lifetime)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            AWSConfigs.utcNowSource = () => baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            AWSConfigs.utcNowSource = () => baseTimeUtc + lifetime;
            var credsAfterExpiration = mockCredentials.GetCredentials();
            Assert.NotEqual(initialCreds, credsAfterExpiration);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
        }

        [Fact]
        public async Task CredentialsAreRefreshedInImmediatelyWhenExpiredAsync()
        {
            var baseTimeUtc = new DateTime(1970, 1, 1).ToUniversalTime();
            var lifetime = TimeSpan.FromMinutes(60);
            var mockCredentials = new MockRefreshingAWSCredentials(lifetime)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            AWSConfigs.utcNowSource = () => baseTimeUtc;
            var initialCreds = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);

            AWSConfigs.utcNowSource = () => baseTimeUtc + lifetime;
            var credsAfterExpiration = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);
            Assert.NotEqual(initialCreds, credsAfterExpiration);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
        }

        [Fact]
        public async Task ConcurrentCallsToGetExpiredCrendentialsOnlyGeneratesNewCredentialsOnceAsync()
        {
            var baseTimeUtc = new DateTime(1970, 1, 1).ToUniversalTime();
            var lifetime = TimeSpan.FromMinutes(60);
            var mockCredentials = new MockRefreshingAWSCredentials(lifetime)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            AWSConfigs.utcNowSource = () => baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();
            
            AWSConfigs.utcNowSource = () => baseTimeUtc + lifetime;

            mockCredentials.CloseGenerateCredentialsGate(); // prevent GenerateNewCredentials from returning

            var concurrentCredentialTasks = Task.WhenAll(
                    Enumerable.Range(1, 5)
                        .Select(i => mockCredentials.GetCredentialsAsync())
                    );

            mockCredentials.OpenGenerateCredentialsGate(); // allow GenerateNewCredentials to complete

            var allCreds = await concurrentCredentialTasks;

            Assert.NotEqual(initialCreds, allCreds[0]);

            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
            for (var i = 1; i < allCreds.Length; i++)
            {
                Assert.Equal(allCreds[0], allCreds[i]);
            }
        }

        [Fact]
        public void CredentialsAreRefreshedInBackgroundDuringPreemptyExpiryPeriod()
        {
            var baseTimeUtc = new DateTime(1970, 1, 1).ToUniversalTime();
            var lifetime = TimeSpan.FromMinutes(60);
            var mockCredentials = new MockRefreshingAWSCredentials(lifetime)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            AWSConfigs.utcNowSource = () => baseTimeUtc;
            var initialCreds = mockCredentials.GetCredentials();

            AWSConfigs.utcNowSource = () => baseTimeUtc + TimeSpan.FromMinutes(50);
            var previousState = mockCredentials.CurrentState;
            var credsDuringPreemptExpiry = mockCredentials.GetCredentials();
            Assert.Equal(initialCreds, credsDuringPreemptExpiry);

            // wait for background refresh to complete
            Assert.True(SpinWait.SpinUntil(() => !ReferenceEquals(mockCredentials.CurrentState, previousState), 1_000));

            var credsAfterRefresh = mockCredentials.GetCredentials();
            Assert.NotEqual(credsAfterRefresh, credsDuringPreemptExpiry);
            Assert.Equal(AWSConfigs.utcNowSource() + lifetime - mockCredentials.PreemptExpiryTime, mockCredentials.CurrentState.Expiration);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
        }

        [Fact]
        public async Task CredentialsAreRefreshedInBackgroundDuringPreemptyExpiryPeriodAsync()
        {
            var baseTimeUtc = new DateTime(1970, 1, 1).ToUniversalTime();
            var lifetime = TimeSpan.FromMinutes(60);
            var mockCredentials = new MockRefreshingAWSCredentials(lifetime)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(15),
            };

            AWSConfigs.utcNowSource = () => baseTimeUtc;
            var initialCreds = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);

            AWSConfigs.utcNowSource = () => baseTimeUtc + TimeSpan.FromMinutes(50);
            var previousState = mockCredentials.CurrentState;
            var credsDuringPreemptExpiry = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);
            Assert.Equal(initialCreds, credsDuringPreemptExpiry);

            // wait for background refresh to complete
            Assert.True(SpinWait.SpinUntil(() => !ReferenceEquals(mockCredentials.CurrentState, previousState), 1_000));

            var credsAfterRefresh = await mockCredentials.GetCredentialsAsync().ConfigureAwait(false);
            Assert.NotEqual(credsAfterRefresh, credsDuringPreemptExpiry);
            Assert.Equal(AWSConfigs.utcNowSource() + lifetime - mockCredentials.PreemptExpiryTime, mockCredentials.CurrentState.Expiration);
            Assert.Equal(2, mockCredentials.GeneratedTokenCount);
        }

        public void Dispose()
        {
            AWSConfigs.utcNowSource = _resetUtcNowSource;
        }

        // using a hand-written mock in order to have access to the protected fields
        private sealed class MockRefreshingAWSCredentials : RefreshingAWSCredentials
        {
            private readonly TimeSpan _credentialsLifetime;
            private readonly ManualResetEventSlim _generateCredsEvent;
            private int _tokenCounter;

            public MockRefreshingAWSCredentials(TimeSpan credentialsLifetime)
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
                return new CredentialsRefreshState
                {
                    Credentials = new ImmutableCredentials("access_key_id", "secret_access_key", $"token_{Interlocked.Increment(ref _tokenCounter)}"),
                    Expiration = AWSConfigs.utcNowSource() + _credentialsLifetime,
                };
            }

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                return Task.Run(GenerateNewCredentials);
            }
        }
    }
}
