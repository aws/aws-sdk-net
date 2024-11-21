using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_NetStandard.UnitTests
{
    public class DynamoDBTests
    {
        [Fact]
        [Trait("Category", "DynamoDBv2.Model.AttributeValue")]
        public void AttributeValueIsBOOLSetTest()
        {
            var boolAV = new AttributeValue();
            Assert.False(boolAV.IsBOOLSet);
            Assert.False(boolAV.BOOL.HasValue);

            boolAV.BOOL = false;
            Assert.True(boolAV.IsBOOLSet);
            Assert.False(boolAV.BOOL);

            boolAV.BOOL = true;
            Assert.True(boolAV.IsBOOLSet);
            Assert.True(boolAV.BOOL);

            boolAV.IsBOOLSet = true;
            Assert.True(boolAV.IsBOOLSet);
            Assert.True(boolAV.BOOL);

            boolAV.IsBOOLSet = false;
            Assert.False(boolAV.IsBOOLSet);
            Assert.False(boolAV.BOOL.HasValue);
        }

        #region MockingTests

        [Fact]
        [Trait("Category", "DynamoDBv2")]
        public async Task TestMockingTableClient_PutItemAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            var document = new Document();
            document["Id"] = "123";

            // This calls the low-level PutItemAsync, which should be valid on the mocked client
            await table.PutItemAsync(document);
        }

        [Fact]
        [Trait("Category", "DynamoDBv2")]
        public async Task TestMockingTableClient_GetItemAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.GetItemAsync(It.IsAny<GetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new GetItemResponse { Item = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // This calls the low-level GetItemAsync, which should be valid on the mocked client
            await table.GetItemAsync("123");
        }

        [Fact]
        [Trait("Category", "DynamoDBv2")]
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

        [Fact]
        [Trait("Category", "DynamoDBv2")]
        public async Task TestMockingTableClient_DeleteItemAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.DeleteItemAsync(It.IsAny<DeleteItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new DeleteItemResponse { Attributes = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // This calls the low-level DeleteItemAsync, which should be valid on the mocked client
            await table.DeleteItemAsync("123");
        }

        [Fact]
        [Trait("Category", "DynamoDBv2")]
        public async Task TestMockingTableClient_QueryAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.QueryAsync(It.IsAny<QueryRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new QueryResponse { Items = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // This calls the low-level QueryAsync, which should be valid on the mocked client
            await table.Query("123", new QueryFilter()).GetNextSetAsync();
        }

        [Fact]
        [Trait("Category", "DynamoDBv2")]
        public async Task TestMockingTableClient_ScanAsync()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.ScanAsync(It.IsAny<ScanRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ScanResponse { Items = new() });

            var table = new TableBuilder(mockClient.Object, "TestTable").AddHashKey("Id", DynamoDBEntryType.String).Build();

            // This calls the low-level ScanAsync, which should be valid on the mocked client
            await table.Scan(new ScanOperationConfig()).GetNextSetAsync();
        }

        [Fact]
        [Trait("Category", "DynamoDBv2")]
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

        [Fact]
        [Trait("Category", "DynamoDBv2")]
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

        [Fact]
        [Trait("Category", "DynamoDBv2")]
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

        [Fact]
        [Trait("Category", "DynamoDBv2")]
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

        [Fact]
        [Trait("Category", "DynamoDBv2")]
        public void TestMockingTableClient_LoadTable_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.Config).Returns(new AmazonDynamoDBConfig());

            // Because we're in ASYNC_AWAIT, the mock client doesn't expose the internal sync LoadTable
            // that this still relies on, so we expect it to fail
            Assert.Throws<InvalidOperationException>(() => Table.LoadTable(mockClient.Object, "TestTable"));
        }
        #endregion

        /// <summary>
        /// Verifies that non-public properties are set when converting a Document to a .NET object
        /// </summary>
        /// <remarks>
        /// This test is duplicated for .NET Framework and .NET since we once had a 
        /// bug where behavior differed. See https://github.com/aws/aws-sdk-net/issues/1848
        /// </remarks>
        [Fact]
        [Trait("Category", "DynamoDBv2")]
        public void FromDocument_NonPublicProperties()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig { DisableFetchingTableMetadata = true} );

            var document = new Document();
            document["pk"] = "Primary";
            document["private"] = "Private Value";
            document["internal"] = "Internal Value";
            document["protected"] = "Protected Value";

            var model = context.FromDocument<DataModelWithMixedAccessibility>(document.ForceConversion(DynamoDBEntryConversion.V2));

            Assert.Equal("Private Value", model.PublicAccessToPrivate);
            Assert.Equal("Internal Value", model.Internal);
            Assert.Equal("Protected Value", model.PublicAccessToProtected);
        }

        [DynamoDBTable("MockTable")]
        public class DataModelWithMixedAccessibility
        {
            [DynamoDBHashKey("pk")]
            public string pk { get; set; }

            [DynamoDBProperty("private")]
            private string _private { get; set; }

            public string PublicAccessToPrivate => _private;

            [DynamoDBProperty("internal")]
            internal string Internal { get; set; }

            [DynamoDBProperty("protected")]
            protected string _protected { get; set; }

            public string PublicAccessToProtected => _protected;
        }
    }
}
