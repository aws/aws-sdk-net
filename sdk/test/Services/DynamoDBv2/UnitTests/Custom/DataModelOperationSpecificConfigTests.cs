using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// These tests serve as a reminder to developers and reviewers to 
    /// ensure that new DynamoDB operation-specific properties are plumbed
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
            Assert.AreEqual(4, typeof(BaseOperationConfig).GetProperties().Length);
        }

        [TestMethod]
        public void BatchGetConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(6, typeof(BatchGetConfig).GetProperties().Length);
        }

        [TestMethod]
        public void BatchGetConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.BatchGetItem(It.Is<BatchGetItemRequest>(request => request.RequestItems.ContainsKey("OperationPrefix-TableName"))))
               .Returns(new BatchGetItemResponse { Responses = new(), UnprocessedKeys = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var batchGetConfig = new BatchGetConfig() { TableNamePrefix = "OperationPrefix-" };

            var batchGet = context.CreateBatchGet<DataModel>(batchGetConfig);
            batchGet.AddKey("123", "Name");
            batchGet.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void BatchGetConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.BatchGetItem(It.Is<BatchGetItemRequest>(request => request.RequestItems.ContainsKey("TableName"))))
               .Returns(new BatchGetItemResponse { Responses = new(), UnprocessedKeys = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var batchGetConfig = new BatchGetConfig() { TableNamePrefix = "" };

            var batchGet = context.CreateBatchGet<DataModel>(batchGetConfig);
            batchGet.AddKey("123", "Name");
            batchGet.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void BatchWriteConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(6, typeof(BatchWriteConfig).GetProperties().Length);
        }

        [TestMethod]
        public void BatchWriteConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.BatchWriteItem(It.Is<BatchWriteItemRequest>(x => x.RequestItems.ContainsKey("OperationPrefix-TableName"))))
               .Returns(new BatchWriteItemResponse { UnprocessedItems = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var batchWriteConfig = new BatchWriteConfig() { TableNamePrefix = "OperationPrefix-" };

            var batchWrite = context.CreateBatchWrite<DataModel>(batchWriteConfig);
            batchWrite.AddPutItem(new DataModel { Id = "123", Name = "Name" });
            batchWrite.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void BatchWriteConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.BatchWriteItem(It.Is<BatchWriteItemRequest>(x => x.RequestItems.ContainsKey("TableName"))))
               .Returns(new BatchWriteItemResponse { UnprocessedItems = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var batchWriteConfig = new BatchWriteConfig() { TableNamePrefix = "" };

            var batchWrite = context.CreateBatchWrite<DataModel>(batchWriteConfig);
            batchWrite.AddPutItem(new DataModel { Id = "123", Name = "Name" });
            batchWrite.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void TransactGetConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(5, typeof(TransactGetConfig).GetProperties().Length);
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
            transactGet.AddKey("123", "Name");
            transactGet.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void TransactGetConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItems(It.Is<TransactGetItemsRequest>(x => x.TransactItems[0].Get.TableName == "TableName")))
               .Returns(new TransactGetItemsResponse { Responses = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var transactGetConfig = new TransactGetConfig() { TableNamePrefix = "" };

            var transactGet = context.CreateTransactGet<DataModel>(transactGetConfig);
            transactGet.AddKey("123", "Name");
            transactGet.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void TransactWriteConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(5, typeof(TransactWriteConfig).GetProperties().Length);
        }

        [TestMethod]
        public void TransactWriteConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactWriteItems(It.Is<TransactWriteItemsRequest>(x => x.TransactItems[0].Put.TableName == "OperationPrefix-TableName")))
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

        [TestMethod]
        public void TransactWriteConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactWriteItems(It.Is<TransactWriteItemsRequest>(x => x.TransactItems[0].Put.TableName == "TableName")))
               .Returns(new TransactWriteItemsResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var transactWriteConfig = new TransactWriteConfig { TableNamePrefix = "" };

            var transactWrite = context.CreateTransactWrite<DataModel>(transactWriteConfig);
            transactWrite.AddSaveItem(new DataModel { Id = "123" });
            transactWrite.Execute();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void QueryConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(11, typeof(QueryConfig).GetProperties().Length);
        }

        [TestMethod]
        public void QueryConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.Query(It.Is<QueryRequest>(request => request.TableName == "OperationPrefix-TableName")))
               .Returns(new QueryResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var queryConfig = new QueryConfig() { TableNamePrefix = "OperationPrefix-" };

            var query = context.Query<DataModel>("123", queryConfig);
            query.ToList();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void QueryConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.Query(It.Is<QueryRequest>(request => request.TableName == "TableName")))
               .Returns(new QueryResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var queryConfig = new QueryConfig() { TableNamePrefix = "" };

            var query = context.Query<DataModel>("123", queryConfig);
            query.ToList();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void FromQueryConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(5, typeof(FromQueryConfig).GetProperties().Length);
        }

        [TestMethod]
        public void FromQueryConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.Query(It.Is<QueryRequest>(request => request.TableName == "OperationPrefix-TableName")))
               .Returns(new QueryResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var queryOperationConfig = new QueryOperationConfig()
            {
                Filter = new QueryFilter("Id", QueryOperator.Equal, "123")
            };

            var fromQueryConfig = new FromQueryConfig() { TableNamePrefix = "OperationPrefix-" };

            var query = context.FromQuery<DataModel>(queryOperationConfig, fromQueryConfig);
            query.ToList();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void FromQueryConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.Query(It.Is<QueryRequest>(request => request.TableName == "TableName")))
               .Returns(new QueryResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var queryOperationConfig = new QueryOperationConfig()
            {
                Filter = new QueryFilter("Id", QueryOperator.Equal, "123")
            };

            var fromQueryConfig = new FromQueryConfig() { TableNamePrefix = "" };

            var query = context.FromQuery<DataModel>(queryOperationConfig, fromQueryConfig);
            query.ToList();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void ScanConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(9, typeof(ScanConfig).GetProperties().Length);
        }

        [TestMethod]
        public void ScanConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.Scan(It.Is<ScanRequest>(request => request.TableName == "OperationPrefix-TableName")))
               .Returns(new ScanResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var scanConfig = new ScanConfig() { TableNamePrefix = "OperationPrefix-" };

            var scan = context.Scan<DataModel>(new ScanCondition[0], scanConfig);
            scan.ToList();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void ScanConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.Scan(It.Is<ScanRequest>(request => request.TableName == "TableName")))
               .Returns(new ScanResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var scanConfig = new ScanConfig() { TableNamePrefix = "" };

            var scan = context.Scan<DataModel>(new ScanCondition[0], scanConfig);
            scan.ToList();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void FromScanConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(5, typeof(FromScanConfig).GetProperties().Length);
        }

        [TestMethod]
        public void FromScanConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.Scan(It.Is<ScanRequest>(request => request.TableName == "OperationPrefix-TableName")))
               .Returns(new ScanResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var fromScanConfig = new FromScanConfig() { TableNamePrefix = "OperationPrefix-" };

            var scan = context.FromScan<DataModel>(new ScanOperationConfig(), fromScanConfig);
            scan.ToList();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void FromScanConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.Scan(It.Is<ScanRequest>(request => request.TableName == "TableName")))
               .Returns(new ScanResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var fromScanConfig = new FromScanConfig() { TableNamePrefix = "" };

            var scan = context.FromScan<DataModel>(new ScanOperationConfig(), fromScanConfig);
            scan.ToList();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void DeleteConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(5, typeof(DeleteConfig).GetProperties().Length);
        }

        [TestMethod]
        public void DeleteConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.DeleteItem(It.Is<DeleteItemRequest>(request => request.TableName == "OperationPrefix-TableName")))
               .Returns(new DeleteItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var deleteConfig = new DeleteConfig() { TableNamePrefix = "OperationPrefix-" };

            context.Delete<DataModel>("123", "Name", deleteConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void DeleteConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.DeleteItem(It.Is<DeleteItemRequest>(request => request.TableName == "TableName")))
               .Returns(new DeleteItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var deleteConfig = new DeleteConfig() { TableNamePrefix = "" };

            context.Delete<DataModel>("123", "Name", deleteConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void SaveConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(6, typeof(SaveConfig).GetProperties().Length);
        }

        [TestMethod]
        public void SaveConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.UpdateItem(It.Is<UpdateItemRequest>(request => request.TableName == "OperationPrefix-TableName")))
               .Returns(new UpdateItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var saveConfig = new SaveConfig() { TableNamePrefix = "OperationPrefix-" };

            context.Save(new DataModel { Id = "123", Name = "Name" }, saveConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void SaveConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.UpdateItem(It.Is<UpdateItemRequest>(request => request.TableName == "TableName")))
               .Returns(new UpdateItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var saveConfig = new SaveConfig() { TableNamePrefix = "" };

            context.Save(new DataModel { Id = "123", Name = "Name" }, saveConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void LoadConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(6, typeof(LoadConfig).GetProperties().Length);
        }

        [TestMethod]
        public void LoadConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.GetItem(It.Is<GetItemRequest>(request => request.TableName == "OperationPrefix-TableName")))
               .Returns(new GetItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var loadConfig = new LoadConfig() { TableNamePrefix = "OperationPrefix-" };

            context.Load<DataModel>("123", "Name", loadConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void LoadConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.GetItem(It.Is<GetItemRequest>(request => request.TableName == "TableName")))
               .Returns(new GetItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var loadConfig = new LoadConfig() { TableNamePrefix = "" };

            context.Load<DataModel>("123", "Name", loadConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void ToDocumentConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(5, typeof(ToDocumentConfig).GetProperties().Length);
        }

        [TestMethod]
        public void FromDocumentConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(5, typeof(FromDocumentConfig).GetProperties().Length);
        }

        [TestMethod]
        public void GetTargetTableConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(4, typeof(GetTargetTableConfig).GetProperties().Length);
        }

        [DynamoDBTable("TableName")]
        private class DataModel
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBRangeKey]
            public string Name { get; set; }
        }
    }
}
