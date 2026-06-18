using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
        public async Task BatchGetConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.BatchGetItemAsync(It.Is<BatchGetItemRequest>(request => request.RequestItems.ContainsKey("OperationPrefix-TableName")), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new BatchGetItemResponse { Responses = new(), UnprocessedKeys = new() })
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
            await batchGet.ExecuteAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task BatchGetConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.BatchGetItemAsync(It.Is<BatchGetItemRequest>(request => request.RequestItems.ContainsKey("TableName")), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new BatchGetItemResponse { Responses = new(), UnprocessedKeys = new() })
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
            await batchGet.ExecuteAsync();

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
        public async Task BatchWriteConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.BatchWriteItemAsync(It.Is<BatchWriteItemRequest>(x => x.RequestItems.ContainsKey("OperationPrefix-TableName")), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new BatchWriteItemResponse { UnprocessedItems = new() })
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
            await batchWrite.ExecuteAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task BatchWriteConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.BatchWriteItemAsync(It.Is<BatchWriteItemRequest>(x => x.RequestItems.ContainsKey("TableName")), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new BatchWriteItemResponse { UnprocessedItems = new() })
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
            await batchWrite.ExecuteAsync();

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
        public async Task TransactGetConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItemsAsync(It.Is<TransactGetItemsRequest>(x => x.TransactItems[0].Get.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new TransactGetItemsResponse { Responses = new() })
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
            await transactGet.ExecuteAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task TransactGetConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItemsAsync(It.Is<TransactGetItemsRequest>(x => x.TransactItems[0].Get.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new TransactGetItemsResponse { Responses = new() })
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
            await transactGet.ExecuteAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void TransactWriteConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(6, typeof(TransactWriteConfig).GetProperties().Length);
        }

        [TestMethod]
        public async Task TransactWriteConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactWriteItemsAsync(It.Is<TransactWriteItemsRequest>(x => x.TransactItems[0].Put.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new TransactWriteItemsResponse())
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
            await transactWrite.ExecuteAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task TransactWriteConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactWriteItemsAsync(It.Is<TransactWriteItemsRequest>(x => x.TransactItems[0].Put.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new TransactWriteItemsResponse())
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
            await transactWrite.ExecuteAsync();

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
        public async Task QueryConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.QueryAsync(It.Is<QueryRequest>(request => request.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new QueryResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var queryConfig = new QueryConfig() { TableNamePrefix = "OperationPrefix-" };

            var query = context.QueryAsync<DataModel>("123", queryConfig);
            await query.GetRemainingAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task QueryConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.QueryAsync(It.Is<QueryRequest>(request => request.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new QueryResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var queryConfig = new QueryConfig() { TableNamePrefix = "" };

            var query = context.QueryAsync<DataModel>("123", queryConfig);
            await query.GetRemainingAsync();

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
        public async Task FromQueryConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.QueryAsync(It.Is<QueryRequest>(request => request.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new QueryResponse { Items = new() })
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

            var query = context.FromQueryAsync<DataModel>(queryOperationConfig, fromQueryConfig);
            await query.GetRemainingAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task FromQueryConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.QueryAsync(It.Is<QueryRequest>(request => request.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new QueryResponse { Items = new() })
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

            var query = context.FromQueryAsync<DataModel>(queryOperationConfig, fromQueryConfig);
            await query.GetRemainingAsync();

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
        public async Task ScanConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.ScanAsync(It.Is<ScanRequest>(request => request.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new ScanResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var scanConfig = new ScanConfig() { TableNamePrefix = "OperationPrefix-" };

            var scan = context.ScanAsync<DataModel>(new ScanCondition[0], scanConfig);
            await scan.GetRemainingAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task ScanConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.ScanAsync(It.Is<ScanRequest>(request => request.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new ScanResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var scanConfig = new ScanConfig() { TableNamePrefix = "" };

            var scan = context.ScanAsync<DataModel>(new ScanCondition[0], scanConfig);
            await scan.GetRemainingAsync();

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
        public async Task FromScanConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.ScanAsync(It.Is<ScanRequest>(request => request.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new ScanResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var fromScanConfig = new FromScanConfig() { TableNamePrefix = "OperationPrefix-" };

            var scan = context.FromScanAsync<DataModel>(new ScanOperationConfig(), fromScanConfig);
            await scan.GetRemainingAsync();

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task FromScanConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.ScanAsync(It.Is<ScanRequest>(request => request.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new ScanResponse { Items = new() })
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var fromScanConfig = new FromScanConfig() { TableNamePrefix = "" };

            var scan = context.FromScanAsync<DataModel>(new ScanOperationConfig(), fromScanConfig);
            await scan.GetRemainingAsync();

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
        public async Task DeleteConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.DeleteItemAsync(It.Is<DeleteItemRequest>(request => request.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new DeleteItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var deleteConfig = new DeleteConfig() { TableNamePrefix = "OperationPrefix-" };

            await context.DeleteAsync<DataModel>("123", "Name", deleteConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task DeleteConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.DeleteItemAsync(It.Is<DeleteItemRequest>(request => request.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new DeleteItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var deleteConfig = new DeleteConfig() { TableNamePrefix = "" };

            await context.DeleteAsync<DataModel>("123", "Name", deleteConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public void SaveConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(7, typeof(SaveConfig).GetProperties().Length);
        }

        [TestMethod]
        public async Task SaveConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.UpdateItemAsync(It.Is<UpdateItemRequest>(request => request.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new UpdateItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var saveConfig = new SaveConfig() { TableNamePrefix = "OperationPrefix-" };

            await context.SaveAsync(new DataModel { Id = "123", Name = "Name" }, saveConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task SaveConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.UpdateItemAsync(It.Is<UpdateItemRequest>(request => request.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new UpdateItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var saveConfig = new SaveConfig() { TableNamePrefix = "" };

            await context.SaveAsync(new DataModel { Id = "123", Name = "Name" }, saveConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task SaveConfig_OverridesTableName_Async_TypeOverload()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.UpdateItemAsync(
                    It.Is<UpdateItemRequest>(request => request.TableName == "OperationPrefix-TableName"),
                    It.IsAny<CancellationToken>()))
               .ReturnsAsync(new UpdateItemResponse())
               .Verifiable();

            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var saveConfig = new SaveConfig() { TableNamePrefix = "OperationPrefix-" };

            await context.SaveAsync(typeof(DataModel), new DataModel { Id = "123", Name = "Name" }, saveConfig, CancellationToken.None);

            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task SaveAsync_TypeOverload_WithNullValue_DoesNotCallUpdateItemAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                DisableFetchingTableMetadata = true
            });

            await context.SaveAsync(valueType: typeof(DataModel), value: null, cancellationToken: CancellationToken.None);

            mockClient.Verify(client => client.UpdateItemAsync(It.IsAny<UpdateItemRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [TestMethod]
        public void LoadConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(6, typeof(LoadConfig).GetProperties().Length);
        }

        [TestMethod]
        public async Task LoadConfig_OverridesTableName()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.GetItemAsync(It.Is<GetItemRequest>(request => request.TableName == "OperationPrefix-TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new GetItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var loadConfig = new LoadConfig() { TableNamePrefix = "OperationPrefix-" };

            await context.LoadAsync<DataModel>("123", "Name", loadConfig);

            // We expect the setup with the correct prefix to have been called, otherwise an exception would have been thrown
            mockClient.VerifyAll();
        }

        [TestMethod]
        public async Task LoadConfig_RemoveTablePrefix()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(client => client.GetItemAsync(It.Is<GetItemRequest>(request => request.TableName == "TableName"), It.IsAny<CancellationToken>()))
               .ReturnsAsync(new GetItemResponse())
               .Verifiable();

            // Set a prefix on the context config, but we'll override it on the operation config so we don't expect it to be used
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig
            {
                TableNamePrefix = "ContextPrefix-",
                DisableFetchingTableMetadata = true
            });

            var loadConfig = new LoadConfig() { TableNamePrefix = "" };

            await context.LoadAsync<DataModel>("123", "Name", loadConfig);

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
