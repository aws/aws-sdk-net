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
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LruListTest
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LruList_AddEmpty()
        {
            var lruList = new LruList<string, string>();
            var item1 = new LruListItem<string, string>("key1", "value1");
            lruList.Add(item1);
            AssertListState(lruList, item1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LruList_AddNonEmpty()
        {
            var lruList = new LruList<string, string>();
            var item1 = new LruListItem<string, string>("key1", "value1");
            var item2 = new LruListItem<string, string>("key2", "value2");
            lruList.Add(item1);
            lruList.Add(item2);
            AssertListState(lruList, item2, item1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LruList_RemoveOneItem()
        {
            var lruList = new LruList<string, string>();
            var item1 = new LruListItem<string, string>("key1", "value1");
            lruList.Add(item1);
            lruList.Remove(item1);
            AssertDisconnected(item1);
            AssertListState(lruList);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LruList_RemoveHeadTwoItems()
        {
            var lruList = new LruList<string, string>();
            var item1 = new LruListItem<string, string>("key1", "value1");
            var item2 = new LruListItem<string, string>("key2", "value2");
            lruList.Add(item1);
            lruList.Add(item2);
            lruList.Remove(item2);
            AssertDisconnected(item2);
            AssertListState(lruList, item1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LruList_RemoveTailTwoItems()
        {
            var lruList = new LruList<string, string>();
            var item1 = new LruListItem<string, string>("key1", "value1");
            var item2 = new LruListItem<string, string>("key2", "value2");
            lruList.Add(item1);
            lruList.Add(item2);
            lruList.Remove(item1);
            AssertDisconnected(item1);
            AssertListState(lruList, item2);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LruList_RemoveHeadThreeItems()
        {
            var lruList = new LruList<string, string>();
            var item1 = new LruListItem<string, string>("key1", "value1");
            var item2 = new LruListItem<string, string>("key2", "value2");
            var item3 = new LruListItem<string, string>("key3", "value3");
            lruList.Add(item1);
            lruList.Add(item2);
            lruList.Add(item3);
            lruList.Remove(item3);
            AssertDisconnected(item3);
            AssertListState(lruList, item2, item1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LruList_RemoveTailThreeItems()
        {
            var lruList = new LruList<string, string>();
            var item1 = new LruListItem<string, string>("key1", "value1");
            var item2 = new LruListItem<string, string>("key2", "value2");
            var item3 = new LruListItem<string, string>("key3", "value3");
            lruList.Add(item1);
            lruList.Add(item2);
            lruList.Add(item3);
            lruList.Remove(item1);
            AssertDisconnected(item1);
            AssertListState(lruList, item3, item2);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LruList_RemoveMiddleThreeItems()
        {
            var lruList = new LruList<string, string>();
            var item1 = new LruListItem<string, string>("key1", "value1");
            var item2 = new LruListItem<string, string>("key2", "value2");
            var item3 = new LruListItem<string, string>("key3", "value3");
            lruList.Add(item1);
            lruList.Add(item2);
            lruList.Add(item3);
            lruList.Remove(item2);
            AssertDisconnected(item2);
            AssertListState(lruList, item3, item1);
        }

        private void AssertDisconnected(LruListItem<string, string> item)
        {
            Assert.IsNull(item.Previous);
            Assert.IsNull(item.Next);
        }

        private void AssertListState(LruList<string, string> lruList, params LruListItem<string, string>[] items)
        {
            if (items.Length == 0)
            {
                Assert.IsNull(lruList.Head);
                Assert.IsNull(lruList.Tail);
            }
            else
            {
                // check references on ends
                Assert.IsNull(lruList.Head.Previous);
                Assert.IsNull(lruList.Tail.Next);

                // make sure head and tail are correct
                Assert.AreEqual(items[0], lruList.Head);
                Assert.AreEqual(items[items.Length - 1], lruList.Tail);

                // make sure Next references are in the expected order
                for (int i = 0; i < items.Length - 1; i++)
                {
                    Assert.AreEqual(items[i].Next, items[i + 1]);
                }

                // make sure Previous references are in the expected order
                for (int i = items.Length - 1; i > 0; i--)
                {
                    Assert.AreEqual(items[i].Previous, items[i - 1]);
                }
            }
        }

    }
}
