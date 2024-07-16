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
                   It.IsAny<IEnumerable<ScanCondition>>(),
                   It.IsAny<DynamoDBOperationConfig>()))
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
                .ReturnsAsync(new ScanResponse { Items = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // This calls the low-level ScanAsync, which should be valid on the mocked client
            await table.Scan(new ScanOperationConfig()).GetNextSetAsync();
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

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_LoadTable_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync LoadTable
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => Table.LoadTable(mockClient.Object, "TestTable"));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_PutItem_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var document = new Document();
            document["Id"] = "123";

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync PutItem
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => table.PutItem(document));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_GetItem_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync GetItem
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => table.GetItem("123"));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_UpdateItem_Throwsc()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var document = new Document();
            document["Id"] = "123";

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync UpdateItem
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => table.UpdateItem(document, "123"));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_DeleteItem_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync DeleteItem
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => table.DeleteItem("123"));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_Query_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync Query
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => table.Query("123", new QueryFilter()).GetNextSet());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_Scan_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync Scan
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => table.Scan(new ScanOperationConfig()).GetNextSet());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_BatchGet_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var batchGet = table.CreateBatchGet();
            batchGet.AddKey("123");

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync BatchGetItem
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => batchGet.Execute());

        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_BatchWrite_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var document = new Document();
            document["Id"] = "123";

            var batchWrite = table.CreateBatchWrite();
            batchWrite.AddDocumentToPut(document);

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync BatchWriteItem
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => batchWrite.Execute());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_TransactGet_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var transactGet = table.CreateTransactGet();
            transactGet.AddKey("123");

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync TransactGetItems
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => transactGet.Execute());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_TransactWrite_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var document = new Document();
            document["Id"] = "123";

            var transactWrite = table.CreateTransactWrite();
            transactWrite.AddDocumentToPut(document);

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync TransactWriteItems
            // that this still relies on, so we expect it to fail
            Assert.ThrowsException<InvalidOperationException>(() => transactWrite.Execute());
        }
#endif
    }
}
