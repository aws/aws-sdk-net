#if NET8_0_OR_GREATER
using System;
using System.Threading;
using Amazon;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.HttpClientTests
{
    /// <summary>
    /// Tests for ClientConfig.PooledConnectionLifetime and its AWSConfigs global default.
    /// </summary>
    [TestClass]
    [TestCategory("Core")]
    public class PooledConnectionLifetimeTests
    {
        private TimeSpan? _originalGlobal;

        [TestInitialize]
        public void Setup()
        {
            // AWSConfigs.PooledConnectionLifetime is process-wide static state, and ClientConfig reads
            // it in a field initializer. Save and restore it so these tests cannot leak into others.
            _originalGlobal = AWSConfigs.PooledConnectionLifetime;
            AWSConfigs.PooledConnectionLifetime = null;
        }

        [TestCleanup]
        public void Cleanup()
        {
            AWSConfigs.PooledConnectionLifetime = _originalGlobal;
        }

        [TestMethod]
        public void DefaultsToNull()
        {
            // Null means the SDK leaves SocketsHttpHandler at .NET's infinite default,
            // so upgrading does not change behavior for anyone who has not opted in.
            Assert.IsNull(new MyClientConfig().PooledConnectionLifetime);
        }

        [TestMethod]
        public void SeededFromAWSConfigsGlobal()
        {
            AWSConfigs.PooledConnectionLifetime = TimeSpan.FromMinutes(5);

            Assert.AreEqual(TimeSpan.FromMinutes(5), new MyClientConfig().PooledConnectionLifetime);
        }

        [TestMethod]
        public void GlobalIsReadAtConstructionNotAtAccess()
        {
            // The global seeds the field initializer, so a config constructed before the global is
            // set keeps its own value. Documents the same semantics AWSConfigs.HttpClientFactory has.
            var before = new MyClientConfig();
            AWSConfigs.PooledConnectionLifetime = TimeSpan.FromMinutes(5);
            var after = new MyClientConfig();

            Assert.IsNull(before.PooledConnectionLifetime);
            Assert.AreEqual(TimeSpan.FromMinutes(5), after.PooledConnectionLifetime);
        }

        [TestMethod]
        public void PerClientValueOverridesGlobal()
        {
            AWSConfigs.PooledConnectionLifetime = TimeSpan.FromMinutes(5);

            var config = new MyClientConfig { PooledConnectionLifetime = TimeSpan.FromMinutes(1) };

            Assert.AreEqual(TimeSpan.FromMinutes(1), config.PooledConnectionLifetime);
        }

        [TestMethod]
        public void AcceptsInfiniteTimeout()
        {
            // A caller must be able to force infinite back on when the global sets a finite default.
            AWSConfigs.PooledConnectionLifetime = TimeSpan.FromMinutes(5);

            var config = new MyClientConfig { PooledConnectionLifetime = Timeout.InfiniteTimeSpan };

            Assert.AreEqual(Timeout.InfiniteTimeSpan, config.PooledConnectionLifetime);
        }

        [TestMethod]
        public void RejectsZero()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => new MyClientConfig { PooledConnectionLifetime = TimeSpan.Zero });
        }

        [TestMethod]
        public void RejectsNegative()
        {
            // -1ms is InfiniteTimeout and allowed; any other negative is not.
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => new MyClientConfig { PooledConnectionLifetime = TimeSpan.FromSeconds(-30) });
        }

        [TestMethod]
        public void RejectsNull()
        {
            // Consistent with ConnectTimeout: the setter validates, so null cannot be assigned
            // through it even though null is the unset state of the backing field.
            Assert.ThrowsExactly<ArgumentNullException>(
                () => new MyClientConfig { PooledConnectionLifetime = null });
        }

        [TestMethod]
        public void UniqueStringUnchangedWhenUnset()
        {
            // Guards backward compatibility: configs that never set the property must produce the
            // same cache key as before, so existing cached HttpClients are not invalidated.
            var config = new MyClientConfig { HttpClientCacheSize = 1234321, HttpClientFactory = null };

            Assert.AreEqual(
                "AllowAutoRedirect:TrueCacheSize:1234321",
                ClientConfigStaticMethodTests.CreateConfigUniqueString(config));
        }

        [TestMethod]
        public void UniqueStringDiffersByPooledConnectionLifetime()
        {
            // The regression this property is most likely to introduce: if the cache key ignores
            // PooledConnectionLifetime, two configs differing only by it share one cached
            // HttpClient and the second config's setting is silently discarded.
            var five = new MyClientConfig
            {
                HttpClientFactory = null,
                PooledConnectionLifetime = TimeSpan.FromMinutes(5)
            };
            var one = new MyClientConfig
            {
                HttpClientFactory = null,
                PooledConnectionLifetime = TimeSpan.FromMinutes(1)
            };
            var unset = new MyClientConfig { HttpClientFactory = null };

            var fiveKey = ClientConfigStaticMethodTests.CreateConfigUniqueString(five);
            var oneKey = ClientConfigStaticMethodTests.CreateConfigUniqueString(one);
            var unsetKey = ClientConfigStaticMethodTests.CreateConfigUniqueString(unset);

            Assert.AreNotEqual(fiveKey, oneKey);
            Assert.AreNotEqual(fiveKey, unsetKey);
            Assert.AreNotEqual(oneKey, unsetKey);
        }
    }
}
#endif
