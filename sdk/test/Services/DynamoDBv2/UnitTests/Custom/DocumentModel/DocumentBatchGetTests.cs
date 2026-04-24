using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class DocumentBatchGetTests
    {
        private Mock<IAmazonDynamoDB> ddbClientMock;
        private Table addressTable;
        private Table personTable;

        [TestInitialize]
        public void Setup()
        {
            ddbClientMock = new Mock<IAmazonDynamoDB>(MockBehavior.Strict);

            var clientConfigMock = new Mock<IClientConfig>();
            clientConfigMock.SetupGet(c => c.RegionEndpoint).Returns((Amazon.RegionEndpoint)null);
            clientConfigMock.SetupGet(c => c.ServiceURL).Returns((string)null);
            ddbClientMock.SetupGet(c => c.Config).Returns(clientConfigMock.Object);

            addressTable = CreateTable(ddbClientMock.Object, "AddressTable");
            personTable = CreateTable(ddbClientMock.Object, "PersonTable");
        }

        [TestMethod]
        public async Task ExecuteAsync_MultiTableBatch_MapsRetrievedItemsToDocuments()
        {
            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(CreateBatchGetItemResponse());

            var (addressBatch, personBatch) = CreateBatches(addressTable, personTable);

            var multiBatch = new MultiTableDocumentBatchGet(addressBatch, personBatch);

            await multiBatch.ExecuteAsync();

            AssertBatchResults(addressBatch, "A1", "A2");
            AssertBatchResults(personBatch, "P1", "P2");

            ddbClientMock.Verify(
                c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()),
                Times.Once);
        }

        [TestMethod]
        public void Execute_MultiTableBatch_MapsRetrievedItemsToDocuments()
        {
            ddbClientMock
                .Setup(c => c.BatchGetItem(It.IsAny<BatchGetItemRequest>()))
                .Returns(CreateBatchGetItemResponse());

            var (addressBatch, personBatch) = CreateBatches(addressTable, personTable);

            var multiBatch = new MultiTableDocumentBatchGet(addressBatch, personBatch);

            multiBatch.Execute();

            AssertBatchResults(addressBatch, "A1", "A2");
            AssertBatchResults(personBatch, "P1", "P2");

            ddbClientMock.Verify(
                c => c.BatchGetItem(It.IsAny<BatchGetItemRequest>()),
                Times.Once);
        }

        [TestMethod]
        public async Task GetItemsAsync_WhenBatchesIsNull_ReturnsEmptyResults()
        {
            var multiBatchGet = new MultiBatchGet
            {
                Batches = null
            };

            var results = await multiBatchGet.GetItemsAsync();

            Assert.IsNotNull(results);
            Assert.AreEqual(0, results.Count);
        }

        [TestMethod]
        public async Task GetItemsAsync_WhenMultipleBatchesTargetSameTable_ThrowsException()
        {
            var firstBatch = (DocumentBatchGet)addressTable.CreateBatchGet();
            firstBatch.AddKey(new Primitive("A1"));

            var secondBatch = (DocumentBatchGet)addressTable.CreateBatchGet();
            secondBatch.AddKey(new Primitive("A2"));

            var multiBatchGet = new MultiBatchGet
            {
                Batches = new List<DocumentBatchGet> { firstBatch, secondBatch }
            };

            await Assert.ThrowsExceptionAsync<AmazonDynamoDBException>(() => multiBatchGet.GetItemsAsync());
        }

        [TestMethod]
        public async Task GetItemsAsync_WhenRequestHitsMaxItems_ProcessesOneTablePerCall()
        {
            var requestTableNamesPerCall = new List<List<string>>();
            var requestKeyCountPerCall = new List<int>();

            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((BatchGetItemRequest request, CancellationToken _) =>
                {
                    requestTableNamesPerCall.Add(request.RequestItems.Keys.ToList());
                    requestKeyCountPerCall.Add(request.RequestItems.Values.Sum(v => v.Keys.Count));

                    return new BatchGetItemResponse
                    {
                        Responses = new Dictionary<string, List<Dictionary<string, AttributeValue>>>(),
                        UnprocessedKeys = new Dictionary<string, KeysAndAttributes>()
                    };
                });

            var addressBatch = CreateBatchWithKeys(addressTable, "A", MultiBatchGet.MaxItemsPerCall);

            var multiBatchGet = new MultiBatchGet
            {
                Batches = new List<DocumentBatchGet> { addressBatch }
            };

            var results = await multiBatchGet.GetItemsAsync();

            Assert.AreEqual(0, results.Count);
            Assert.AreEqual(1, requestTableNamesPerCall.Count);
            Assert.IsTrue(requestTableNamesPerCall.All(tables => tables.Count == 1));
            Assert.IsTrue(requestKeyCountPerCall.All(count => count == MultiBatchGet.MaxItemsPerCall));

            var allRequestedTables = requestTableNamesPerCall.SelectMany(t => t).ToList();
            CollectionAssert.AreEquivalent(new List<string> { "AddressTable" }, allRequestedTables);
        }

        [TestMethod]
        public async Task GetItemsAsync_WhenBatchesIsEmpty_ReturnsEmptyResults()
        {
            var multiBatchGet = new MultiBatchGet
            {
                Batches = new List<DocumentBatchGet>()
            };

            var results = await multiBatchGet.GetItemsAsync();

            Assert.IsNotNull(results);
            Assert.AreEqual(0, results.Count);
        }

        private static (IDocumentBatchGet AddressBatch, IDocumentBatchGet PersonBatch) CreateBatches(Table addressTable, Table personTable)
        {
            var addressBatch = addressTable.CreateBatchGet();
            addressBatch.AddKey(new Primitive("A1"));
            addressBatch.AddKey(new Primitive("A2"));

            var personBatch = personTable.CreateBatchGet();
            personBatch.AddKey(new Primitive("P1"));
            personBatch.AddKey(new Primitive("P2"));

            return (addressBatch, personBatch);
        }

        private static DocumentBatchGet CreateBatchWithKeys(Table table, string keyPrefix, int count)
        {
            var batch = (DocumentBatchGet)table.CreateBatchGet();
            for (var i = 1; i <= count; i++)
            {
                batch.AddKey(new Primitive($"{keyPrefix}{i}"));
            }

            return batch;
        }

        private static BatchGetItemResponse CreateBatchGetItemResponse()
        {
            return new BatchGetItemResponse
            {
                Responses = new Dictionary<string, List<Dictionary<string, AttributeValue>>>
                {
                    ["AddressTable"] = new List<Dictionary<string, AttributeValue>>
                    {
                        new Dictionary<string, AttributeValue>
                        {
                            ["Id"] = new AttributeValue { S = "A1" },
                            ["Zip"] = new AttributeValue { S = "12345" }
                        },
                        new Dictionary<string, AttributeValue>
                        {
                            ["Id"] = new AttributeValue { S = "A2" },
                            ["Zip"] = new AttributeValue { S = "67890" }
                        }
                    },
                    ["PersonTable"] = new List<Dictionary<string, AttributeValue>>
                    {
                        new Dictionary<string, AttributeValue>
                        {
                            ["Id"] = new AttributeValue { S = "P1" },
                            ["Name"] = new AttributeValue { S = "Ada" }
                        },
                        new Dictionary<string, AttributeValue>
                        {
                            ["Id"] = new AttributeValue { S = "P2" },
                            ["Name"] = new AttributeValue { S = "Grace" }
                        }
                    }
                },
                UnprocessedKeys = new Dictionary<string, KeysAndAttributes>()
            };
        }

        private static void AssertBatchResults(IDocumentBatchGet batch, params string[] expectedIds)
        {
            Assert.AreEqual(expectedIds.Length, batch.Results.Count);
            CollectionAssert.AreEquivalent(expectedIds, batch.Results.Select(d => d["Id"].AsString()).ToList());
        }

        private static Table CreateTable(IAmazonDynamoDB client, string tableName)
        {
            var config = new TableConfig(tableName);
            var table = new Table(client, config);

            table.ClearTableData();
            table.Keys.Add("Id", new KeyDescription { IsHash = true, Type = DynamoDBEntryType.String });
            table.HashKeys.Add("Id");

            return table;
        }
    }
}
