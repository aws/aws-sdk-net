#if !NETFRAMEWORK
using Amazon.Runtime;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public sealed class DefaultInstanceProfileAWSCredentialsTests
    {
        [TestMethod]
        public async Task GetCredentialsAsync_FetchesFromIMDS_WhenNoCached()
        {
            var expectedAccessKey = "AK123";
            var expectedSecret = "SK123";
            var expectedToken = "T123";

            var stub = new SimpleStubImds
            {
                CredentialsToReturn = new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials(expectedAccessKey, expectedSecret, expectedToken),
                    DateTime.UtcNow.AddMinutes(30))
            };

            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, TimeSpan.FromSeconds(5));

            var creds = await provider.GetCredentialsAsync().ConfigureAwait(false);

            Assert.AreEqual(expectedAccessKey, creds.AccessKey);
            Assert.AreEqual(expectedSecret, creds.SecretKey);
            Assert.AreEqual(expectedToken, creds.Token);
        }

        [TestMethod]
        public void GetCredentials_UsesCachedCredentials_WhenValid()
        {
            var initiallyReturned = new RefreshingAWSCredentials.CredentialsRefreshState(
                new ImmutableCredentials("AK_A", "SK_A", "T_A"),
                DateTime.UtcNow.AddMinutes(30));

            var laterReturned = new RefreshingAWSCredentials.CredentialsRefreshState(
                new ImmutableCredentials("AK_B", "SK_B", "T_B"),
                DateTime.UtcNow.AddMinutes(30));

            var stub = new SimpleStubImds
            {
                CredentialsToReturn = initiallyReturned
            };

            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, TimeSpan.FromSeconds(5));

            var first = provider.GetCredentials();
            Assert.AreEqual("AK_A", first.AccessKey);

            stub.CredentialsToReturn = laterReturned;
            var second = provider.GetCredentials();
            Assert.AreEqual("AK_A", second.AccessKey);
        }

        [TestMethod]
        public async Task GetCredentialsAsync_ConcurrentRequests_OnlyOneFetch()
        {
            var stub = new CountingDelayStubImds(delayMs: 100);
            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, TimeSpan.FromSeconds(-1));

            var tasks = Enumerable.Range(0, 5)
                .Select(_ => provider.GetCredentialsAsync())
                .ToArray();

            await Task.WhenAll(tasks).ConfigureAwait(false);

            foreach (var t in tasks)
                Assert.AreEqual("CONCURRENT_AK", t.Result.AccessKey);

            Assert.AreEqual(1, stub.FetchAsyncCallCount);
        }

        [TestMethod]
        public async Task GetCredentialsAsync_ConcurrentRequests_TimerRefreshed()
        {
            var stub = new CountingDelayStubImds(delayMs: 100);
            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, TimeSpan.FromSeconds(1));

            await Task.Delay(2000).ConfigureAwait(false);

            var tasks = Enumerable.Range(0, 5)
                .Select(_ => provider.GetCredentialsAsync())
                .ToArray();

            await Task.WhenAll(tasks).ConfigureAwait(false);

            foreach (var t in tasks)
                Assert.AreEqual("CONCURRENT_AK", t.Result.AccessKey);

            Assert.AreEqual(0, stub.FetchAsyncCallCount);
            Assert.IsTrue(stub.FetchCallCount > 0);
        }

        [TestMethod]
        public async Task GetCredentialsAsync_ReturnsExpiredCredentials()
        {
            var expectedAccessKey = "AK123";
            var expectedSecret = "SK123";
            var expectedToken = "T123";

            var stub = new SimpleStubImds
            {
                CredentialsToReturn = new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials(expectedAccessKey, expectedSecret, expectedToken),
                    DateTime.UtcNow.AddMinutes(-30))
            };

            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, TimeSpan.FromSeconds(-1));

            var creds = await provider.GetCredentialsAsync().ConfigureAwait(false);

            Assert.AreEqual(expectedAccessKey, creds.AccessKey);
            Assert.AreEqual(expectedSecret, creds.SecretKey);
            Assert.AreEqual(expectedToken, creds.Token);
        }

        [TestMethod]
        public void GetCredentials_ReturnsExpiredCredentials()
        {
            var expectedAccessKey = "AK123";
            var expectedSecret = "SK123";
            var expectedToken = "T123";

            var stub = new SimpleStubImds
            {
                CredentialsToReturn = new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials(expectedAccessKey, expectedSecret, expectedToken),
                    DateTime.UtcNow.AddMinutes(-30))
            };

            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, TimeSpan.FromSeconds(-1));

            var creds = provider.GetCredentials();

            Assert.AreEqual(expectedAccessKey, creds.AccessKey);
            Assert.AreEqual(expectedSecret, creds.SecretKey);
            Assert.AreEqual(expectedToken, creds.Token);
        }

        [TestMethod]
        public async Task GetCredentials_RecoverExpired()
        {
            var endCheckForExpiration = DateTime.UtcNow.AddSeconds(3);
            var stub = new SimulatedIMDSOutageStubImds(TimeSpan.FromSeconds(5));

            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, TimeSpan.FromSeconds(-1));

            while (DateTime.UtcNow < endCheckForExpiration)
            {
                var creds = provider.GetCredentials();

                Assert.IsTrue(creds.AccessKey.StartsWith("OUTAGE"));
                Assert.IsTrue(creds.SecretKey.StartsWith("OUTAGE"));
                Assert.IsTrue(creds.Token.StartsWith("OUTAGE"));
            }
            Assert.IsTrue(stub.CombinedFetchCallCount > 0);

            stub.CombinedFetchCallCount = 0;
            await Task.Delay(TimeSpan.FromSeconds(3));

            var currentCredentials = provider.GetCredentials();
            Assert.IsTrue(stub.CombinedFetchCallCount > 0);

            Assert.IsTrue(currentCredentials.AccessKey.StartsWith("CURRENT"));
            Assert.IsTrue(currentCredentials.SecretKey.StartsWith("CURRENT"));
            Assert.IsTrue(currentCredentials.Token.StartsWith("CURRENT"));
        }

        [TestMethod]
        public async Task GetCredentialsAsync_RecoverExpired()
        {
            var endCheckForExpiration = DateTime.UtcNow.AddSeconds(3);
            var stub = new SimulatedIMDSOutageStubImds(TimeSpan.FromSeconds(5));

            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(stub, TimeSpan.FromSeconds(-1));

            while (DateTime.UtcNow < endCheckForExpiration)
            {
                var creds = await provider.GetCredentialsAsync();

                Assert.IsTrue(creds.AccessKey.StartsWith("OUTAGE"));
                Assert.IsTrue(creds.SecretKey.StartsWith("OUTAGE"));
                Assert.IsTrue(creds.Token.StartsWith("OUTAGE"));
            }
            Assert.IsTrue(stub.CombinedFetchCallCount > 0);

            stub.CombinedFetchCallCount = 0;
            await Task.Delay(TimeSpan.FromSeconds(3));

            var currentCredentials = await provider.GetCredentialsAsync();
            Assert.IsTrue(stub.CombinedFetchCallCount > 0);

            Assert.IsTrue(currentCredentials.AccessKey.StartsWith("CURRENT"));
            Assert.IsTrue(currentCredentials.SecretKey.StartsWith("CURRENT"));
            Assert.IsTrue(currentCredentials.Token.StartsWith("CURRENT"));
        }

        #region Test stubs

        private class SimpleStubImds : DefaultInstanceProfileAWSCredentials.IIMDSAccessMethods
        {
            public RefreshingAWSCredentials.CredentialsRefreshState CredentialsToReturn { get; set; }

            public RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
            {
                return CredentialsToReturn;
            }

            public Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync()
            {
                return Task.FromResult(CredentialsToReturn);
            }

            public void CheckIsIMDSEnabled()
            {
            }
        }

        private class CountingDelayStubImds : DefaultInstanceProfileAWSCredentials.IIMDSAccessMethods
        {
            private readonly int _delayMs;
            public int FetchAsyncCallCount;
            public int FetchCallCount;

            public CountingDelayStubImds(int delayMs)
            {
                _delayMs = delayMs;
            }

            public RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
            {
                Interlocked.Increment(ref FetchCallCount);
                return new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials("CONCURRENT_AK", "CONCURRENT_SK", "CONCURRENT_T"),
                    DateTime.UtcNow.AddMinutes(30));
            }

            public async Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync()
            {
                Interlocked.Increment(ref FetchAsyncCallCount);
                await Task.Delay(_delayMs).ConfigureAwait(false);
                return new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials("CONCURRENT_AK", "CONCURRENT_SK", "CONCURRENT_T"),
                    DateTime.UtcNow.AddMinutes(30));
            }

            public void CheckIsIMDSEnabled()
            {
            }
        }

        private class SimulatedIMDSOutageStubImds : DefaultInstanceProfileAWSCredentials.IIMDSAccessMethods
        {
            TimeSpan _expirationLength;
            DateTime? _imdsOutageEndTime;
            RefreshingAWSCredentials.CredentialsRefreshState _expiredCredentials;
            public int CombinedFetchCallCount;

            public SimulatedIMDSOutageStubImds(TimeSpan expirationLength)
            {
                _expirationLength = expirationLength;
            }

            public RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
            {
                Interlocked.Increment(ref CombinedFetchCallCount);

                if (_expiredCredentials == null)
                {
                    _expiredCredentials = new RefreshingAWSCredentials.CredentialsRefreshState(
                        new ImmutableCredentials("OUTAGE_AK", "OUTAGE_SK", "OUTAGE_T"),
                        DateTime.UtcNow.AddMinutes(-30));

                    _imdsOutageEndTime = DateTime.UtcNow.Add(_expirationLength);
                }

                if (DateTime.UtcNow < _imdsOutageEndTime)
                {
                    return _expiredCredentials;
                }

                return new RefreshingAWSCredentials.CredentialsRefreshState(
                        new ImmutableCredentials("CURRENT_AK", "CURRENT_SK", "CURRENT_T"),
                        DateTime.UtcNow.AddMinutes(30));
            }

            public Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync()
            {
                return Task.FromResult(FetchCredentials());
            }

            public void CheckIsIMDSEnabled()
            {
            }
        }

        #endregion
    }
}
#endif
