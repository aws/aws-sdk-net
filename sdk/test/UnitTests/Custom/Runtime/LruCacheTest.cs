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
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LruCacheTest
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestLruCacheTryGetValue()
        {
            RegionEndpoint regionEndpoint;
            var lru = new LruCache<string, RegionEndpoint>(5);

            lru.AddOrUpdate("my-bucket-us-east-1", RegionEndpoint.USEast1);
            lru.AddOrUpdate("my-bucket-us-west-2", RegionEndpoint.USWest2);
            lru.AddOrUpdate("my-bucket-ap-northeast-2", RegionEndpoint.APNortheast2);
            lru.AddOrUpdate("my-bucket-sa-east-1", RegionEndpoint.SAEast1);

            lru.TryGetValue("my-bucket-us-west-2", out regionEndpoint);
            Assert.AreEqual(RegionEndpoint.USWest2, regionEndpoint);

            lru.TryGetValue("my-bucket-ap-northeast-2", out regionEndpoint);
            Assert.AreEqual(RegionEndpoint.APNortheast2, regionEndpoint);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TryGetValueEmpty()
        {
            var cache = GetCache(5, 0);
            AssertCache(cache, 0, 0);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TryGetValueOne()
        {
            var cache = GetCache(5, 1);
            AssertCache(cache, 0, 1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TryGetValueUpdated()
        {
            var cache = GetCache(5, 5);
            cache.AddOrUpdate("key0", "value1");
            Assert.AreEqual(5, cache.Count);
            AssertInCache(cache, "key0", "value1");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AddOrUpdateAtLimit()
        {
            var cache = GetCache(5, 5);
            AssertCache(cache, 0, 5);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AddOrUpdateEvictOne()
        {
            var cache = GetCache(5, 6);
            AssertCache(cache, 1, 5);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestEviction()
        {
            RegionEndpoint regionEndpoint;
            var lru = new LruCache<string, RegionEndpoint>(5);

            lru.AddOrUpdate("my-bucket-us-west-2", RegionEndpoint.USWest2);

            lru.TryGetValue("my-bucket-us-west-2", out regionEndpoint);
            Assert.AreEqual(RegionEndpoint.USWest2, regionEndpoint);

            lru.Evict("my-bucket-us-west-2");

            var found = lru.TryGetValue("my-bucket-us-west-2", out regionEndpoint);
            Assert.IsFalse(found, "Cache entry was not evicted");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestFindOldestItem()
        {
            var cache = new LruCache<string, string>(10);
            cache.AddOrUpdate("key1", "value1");
            cache.AddOrUpdate("key2", "value2");
            cache.AddOrUpdate("key3", "value3");

            // current order: key1 -> key2 -> key3
            Assert.AreEqual("key1", cache.FindOldestItem().Key);

            cache.AddOrUpdate("key1", "value1Updated");

            // current order: key2 -> key3 -> key1
            Assert.AreEqual("key2", cache.FindOldestItem().Key);

            cache.Evict("key2");

            // current order: key3 -> key1
            Assert.AreEqual("key3", cache.FindOldestItem().Key);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestEvictExpiredLRUListItems()
        {
            var oldUtcNowSource = GetUtcNowSource();
            var currentDateTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            try
            {
                var cache = new LruCache<string, string>(10);

                //0th second
                SetUtcNowSource(() => currentDateTime);
                cache.AddOrUpdate("key1", "value1");

                //5th second
                SetUtcNowSource(() => currentDateTime.AddSeconds(5));
                cache.AddOrUpdate("key2", "value2");

                //10th second
                SetUtcNowSource(() => currentDateTime.AddSeconds(10));
                cache.AddOrUpdate("key3", "value3");

                //16th second
                SetUtcNowSource(() => currentDateTime.AddSeconds(16));

                //Evict cache keys that are more than 10 seconds old
                cache.EvictExpiredLRUListItems(10);

                AssertNotInCache(cache, "key1");
                AssertNotInCache(cache, "key2");
                AssertInCache(cache, "key3", "value3");
            }
            finally
            {
                SetUtcNowSource(oldUtcNowSource);
            }
        }

        private static Func<DateTime> GetUtcNowSource()
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            return (Func<DateTime>)field.GetValue(null);
        }

        private static void SetUtcNowSource(Func<DateTime> source)
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            field.SetValue(null, source);
        }

        private LruCache<string, string> GetCache(int maxItems, int count)
        {
            var cache = new LruCache<string, string>(maxItems);
            for (int i = 0; i < count; i++)
            {
                cache.AddOrUpdate("key" + i, "value" + i);
            }
            return cache;
        }

        private void AssertCache(LruCache<string, string> cache, int start, int count)
        {
            Assert.AreEqual(count, cache.Count);
            for (int i = -10; i < start + count + 10; i++)
            {
                if (i >= start && i < start + count)
                {
                    AssertInCache(cache, "key" + i, "value" + i);
                }
                else
                {
                    AssertNotInCache(cache, "key" + i);
                }
            }
        }

        private void AssertNotInCache(LruCache<string, string> cache, string key)
        {
            string value = null;
            Assert.IsFalse(cache.TryGetValue(key, out value));
            Assert.IsNull(value);
        }

        private void AssertInCache(LruCache<string, string> cache, string key, string expectedValue)
        {
            string value = null;
            Assert.IsTrue(cache.TryGetValue(key, out value));
            Assert.AreEqual(expectedValue, value);
        }
    }
}
