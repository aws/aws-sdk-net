using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// These tests that new DynamoDB operation-specific properties are plumbed
    /// into the internal code paths correctly
    /// </summary>
    [TestClass]
    public class DataModelOperationSpecificConfigTests
    {
        [TestMethod]
        public void BaseOperationConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(6, typeof(BaseOperationConfig).GetProperties().Length);
        }

        [TestMethod]
        public void BatchGetConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(8, typeof(BatchGetConfig).GetProperties().Length);
        }

        [TestMethod]
        public void BatchGetConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.BatchGetItem(It.Is<BatchGetItemRequest>(request => request.RequestItems.ContainsKey("OperationPrefix-TableName"))))
               .Returns(new BatchGetItemResponse { Responses = new(), UnprocessedKeys = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig { 
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var batchGetConfig = new BatchGetConfig() { TableNamePrefix = "OperationPrefix-" };

            var batchGet = context.CreateBatchGet<DataModel>(batchGetConfig);
            batchGet.AddKey("123");
            batchGet.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void BatchWriteConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(8, typeof(BatchWriteConfig).GetProperties().Length);
        }

        [TestMethod]
        public void BatchWriteConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.BatchWriteItem(It.Is<BatchWriteItemRequest>(x => x.RequestItems.ContainsKey("OperationPrefix-TableName"))))
               .Returns(new BatchWriteItemResponse {  UnprocessedItems = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var batchWriteConfig = new BatchWriteConfig() { TableNamePrefix = "OperationPrefix-" };

            var batchWrite = context.CreateBatchWrite<DataModel>(batchWriteConfig);
            batchWrite.AddPutItem(new DataModel { Id = "123" });
            batchWrite.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void TransactGetConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(7, typeof(TransactGetConfig).GetProperties().Length);
        }

        [TestMethod]
        public void TransactGetConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItems(It.Is<TransactGetItemsRequest>(x => x.TransactItems[0].Get.TableName == "OperationPrefix-TableName")))
               .Returns(new TransactGetItemsResponse { Responses = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var transactGetConfig = new TransactGetConfig() { TableNamePrefix = "OperationPrefix-" };

            var transactGet = context.CreateTransactGet<DataModel>(transactGetConfig);
            transactGet.AddKey("123");
            transactGet.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void TransactWriteConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(7, typeof(TransactWriteConfig).GetProperties().Length);
        }

        [TestMethod]
        public void TransactWriteConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactWriteItems(It.Is<TransactWriteItemsRequest>(x => x.TransactItems[0].Update.TableName == "OperationPrefix-TableName")))
               .Returns(new TransactWriteItemsResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var transactWriteConfig = new TransactWriteConfig { TableNamePrefix = "OperationPrefix-" };

            var transactWrite = context.CreateTransactWrite<DataModel>(transactWriteConfig);
            transactWrite.AddSaveItem(new DataModel { Id = "123" });
            transactWrite.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [DynamoDBTable("TableName")]
        private class DataModel
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
        }
    }
}
