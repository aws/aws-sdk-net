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

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class TransactGetProjectionTests
    {
        private DynamoDBContext CreateContext(Mock<IAmazonDynamoDB> mockClient)
        {
            return new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                DisableFetchingTableMetadata = true
            });
        }

        [TestMethod]
        public void AddKey_HashAndRange_AppliesProjectionExpression()
        {
            TransactGetItemsRequest captured = null;
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItems(It.IsAny<TransactGetItemsRequest>()))
                .Callback<TransactGetItemsRequest>(r => captured = r)
                .Returns(new TransactGetItemsResponse { Responses = new List<ItemResponse>() });

            var context = CreateContext(mockClient);
            var transactGet = context.CreateTransactGet<ProjectionModel>();
            transactGet.AddKey("hash1", "range1");
            transactGet.Execute();

            Assert.IsNotNull(captured);
            Assert.AreEqual(1, captured.TransactItems.Count);
            var get = captured.TransactItems[0].Get;
            Assert.IsNotNull(get.ProjectionExpression);
            Assert.IsTrue(get.ExpressionAttributeNames.Count > 0);
        }

        [TestMethod]
        public void AddKey_HashOnly_AppliesProjectionExpression()
        {
            TransactGetItemsRequest captured = null;
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItems(It.IsAny<TransactGetItemsRequest>()))
                .Callback<TransactGetItemsRequest>(r => captured = r)
                .Returns(new TransactGetItemsResponse { Responses = new List<ItemResponse>() });

            var context = CreateContext(mockClient);
            var transactGet = context.CreateTransactGet<HashOnlyProjectionModel>();
            transactGet.AddKey("hash1");
            transactGet.Execute();

            Assert.IsNotNull(captured);
            Assert.AreEqual(1, captured.TransactItems.Count);
            var get = captured.TransactItems[0].Get;
            Assert.IsNotNull(get.ProjectionExpression);
            Assert.IsTrue(get.ExpressionAttributeNames.Count > 0);
        }

        [TestMethod]
        public void AddKey_ObjectKey_AppliesProjectionExpression()
        {
            TransactGetItemsRequest captured = null;
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItems(It.IsAny<TransactGetItemsRequest>()))
                .Callback<TransactGetItemsRequest>(r => captured = r)
                .Returns(new TransactGetItemsResponse { Responses = new List<ItemResponse>() });

            var context = CreateContext(mockClient);
            var transactGet = context.CreateTransactGet<ProjectionModel>();
            transactGet.AddKey(new ProjectionModel { Id = "hash1", Sort = "range1" });
            transactGet.Execute();

            Assert.IsNotNull(captured);
            Assert.AreEqual(1, captured.TransactItems.Count);
            var get = captured.TransactItems[0].Get;
            Assert.IsNotNull(get.ProjectionExpression);
            Assert.IsTrue(get.ExpressionAttributeNames.Count > 0);
        }

        [TestMethod]
        public void AddKeys_Batch_AppliesProjectionForEachKey()
        {
            TransactGetItemsRequest captured = null;
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItems(It.IsAny<TransactGetItemsRequest>()))
                .Callback<TransactGetItemsRequest>(r => captured = r)
                .Returns(new TransactGetItemsResponse { Responses = new List<ItemResponse>() });

            var context = CreateContext(mockClient);
            var transactGet = context.CreateTransactGet<ProjectionModel>();
            transactGet.AddKeys(new List<ProjectionModel>
            {
                new ProjectionModel { Id = "hash1", Sort = "range1" },
                new ProjectionModel { Id = "hash2", Sort = "range2" },
                new ProjectionModel { Id = "hash3", Sort = "range3" }
            });
            transactGet.Execute();

            Assert.IsNotNull(captured);
            Assert.AreEqual(3, captured.TransactItems.Count);
            foreach (var item in captured.TransactItems)
            {
                Assert.IsNotNull(item.Get.ProjectionExpression);
                Assert.IsTrue(item.Get.ExpressionAttributeNames.Count > 0);
            }
        }

        [TestMethod]
        public void MultiTable_DifferentTypes_GetIndependentProjections()
        {
            TransactGetItemsRequest captured = null;
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItems(It.IsAny<TransactGetItemsRequest>()))
                .Callback<TransactGetItemsRequest>(r => captured = r)
                .Returns(new TransactGetItemsResponse { Responses = new List<ItemResponse>() });

            var context = CreateContext(mockClient);

            var transactGetA = context.CreateTransactGet<ProjectionModel>();
            transactGetA.AddKey("hashA", "rangeA");

            var transactGetB = context.CreateTransactGet<DifferentProjectionModel>();
            transactGetB.AddKey("hashB", "rangeB");

            var multiGet = transactGetA.Combine(transactGetB);
            multiGet.Execute();

            Assert.IsNotNull(captured);
            Assert.AreEqual(2, captured.TransactItems.Count);

            var getA = captured.TransactItems[0].Get;
            var getB = captured.TransactItems[1].Get;

            Assert.IsNotNull(getA.ProjectionExpression);
            Assert.IsNotNull(getB.ProjectionExpression);
            Assert.AreNotEqual(getA.ProjectionExpression, getB.ProjectionExpression);
        }

        [TestMethod]
        public void AddKey_ModelWithNoProperties_ProjectionIsEmpty()
        {
            TransactGetItemsRequest captured = null;
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItems(It.IsAny<TransactGetItemsRequest>()))
                .Callback<TransactGetItemsRequest>(r => captured = r)
                .Returns(new TransactGetItemsResponse { Responses = new List<ItemResponse>() });

            var context = CreateContext(mockClient);
            var transactGet = context.CreateTransactGet<MinimalModel>();
            transactGet.AddKey("hash1");
            transactGet.Execute();

            Assert.IsNotNull(captured);
            Assert.AreEqual(1, captured.TransactItems.Count);
            var get = captured.TransactItems[0].Get;
            Assert.IsNotNull(get.ProjectionExpression);
        }

        [DynamoDBTable("ProjectionTable")]
        private class ProjectionModel
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBRangeKey]
            public string Sort { get; set; }

            [DynamoDBProperty("data_field")]
            public string Data { get; set; }

            [DynamoDBProperty("status_field")]
            public string Status { get; set; }
        }

        [DynamoDBTable("HashOnlyTable")]
        private class HashOnlyProjectionModel
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBProperty("value_field")]
            public string Value { get; set; }
        }

        [DynamoDBTable("DifferentTable")]
        private class DifferentProjectionModel
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBRangeKey]
            public string Sort { get; set; }

            [DynamoDBProperty("other_field")]
            public string Other { get; set; }
        }

        [DynamoDBTable("MinimalTable")]
        private class MinimalModel
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
        }
    }
}
