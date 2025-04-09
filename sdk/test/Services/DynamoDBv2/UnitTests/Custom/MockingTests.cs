using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Tests related to the mockabilty of the doucment and object mapper programming models
    /// </summary>
    [TestClass]
    public class MockingTests
    {

#if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingAsyncSeach()
        {
            var mockDBContext = new Mock<IDynamoDBContext>();
            mockDBContext
                .Setup(x => x.ScanAsync<DataItem>(
                   It.IsAny<IEnumerable<ScanCondition>>()))
                .Returns(
                   new MockAsyncSearch<DataItem>() // Return mock version of AsyncSearch
                );

            var search = mockDBContext.Object.ScanAsync<DataItem>(new List<ScanCondition>());
            Assert.IsInstanceOfType(search, typeof(MockAsyncSearch<DataItem>));

            var items = await search.GetNextSetAsync();
            Assert.AreEqual(0, items.Count());
        }

        public class DataItem
        {
            public string Id { get; set; }
        }

        public class MockAsyncSearch<T> : AsyncSearch<T>
        {
            public override Task<List<T>> GetNextSetAsync(CancellationToken cancellationToken = default)
            {
                return Task.FromResult(new List<T>());
            }
        }
#endif

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_PutItemAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var document = new Document();
            document["Id"] = "123";

            // This calls the low-level PutItemAsync, which should be valid on the mocked client
            await table.PutItemAsync(document);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_GetItemAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.GetItemAsync(It.IsAny<GetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new GetItemResponse { Item = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // This calls the low-level GetItemAsync, which should be valid on the mocked client
            await table.GetItemAsync("123");
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_UpdateItemAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.UpdateItemAsync(It.IsAny<UpdateItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new UpdateItemResponse { Attributes = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var document = new Document();
            document["Id"] = "123";

            // This calls the low-level UpdateItemAsync, which should be valid on the mocked client
            await table.UpdateItemAsync(document, "123");
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_DeleteItemAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.DeleteItemAsync(It.IsAny<DeleteItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new DeleteItemResponse { Attributes = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // This calls the low-level DeleteItemAsync, which should be valid on the mocked client
            await table.DeleteItemAsync("123");
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_QueryAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.QueryAsync(It.IsAny<QueryRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new QueryResponse { Items = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // This calls the low-level QueryAsync, which should be valid on the mocked client
            await table.Query("123", new QueryFilter()).GetNextSetAsync();
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_ScanAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.ScanAsync(It.IsAny<ScanRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ScanResponse
                {
                    Items = new(),
                    ScannedCount = 2
                });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var search = table.Scan(new ScanFilter());
            // This calls the low-level ScanAsync, which should be valid on the mocked client
            await search.GetNextSetAsync();
            Assert.AreEqual(2,search.ScannedCount);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_BatchGetAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new BatchGetItemResponse { Responses = new(), UnprocessedKeys = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var batchGet = table.CreateBatchGet();
            batchGet.AddKey("123");

            // This calls the low-level BatchGetItemAsync, which should be valid on the mocked client
            await batchGet.ExecuteAsync();
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_BatchWriteAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.BatchWriteItemAsync(It.IsAny<BatchWriteItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new BatchWriteItemResponse { UnprocessedItems = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();


            var document = new Document();
            document["Id"] = "123";

            var batchWrite = table.CreateBatchWrite();
            batchWrite.AddDocumentToPut(document);

            // This calls the low-level BatchWriteItemAsync, which should be valid on the mocked client
            await batchWrite.ExecuteAsync();
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_TransactGetAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.TransactGetItemsAsync(It.IsAny<TransactGetItemsRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new TransactGetItemsResponse { Responses = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var transactGet = table.CreateTransactGet();
            transactGet.AddKey("123");

            // This calls the low-level TransactGetItemsAsync, which should be valid on the mocked client
            await transactGet.ExecuteAsync();
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingTableClient_TransactWriteAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var document = new Document();
            document["Id"] = "123";

            var transactWrite = table.CreateTransactWrite();
            transactWrite.AddDocumentToPut(document);

            // This calls the low-level TransactWriteItemsAsync, which should be valid on the mocked client
            await transactWrite.ExecuteAsync();
        }

    }
}
