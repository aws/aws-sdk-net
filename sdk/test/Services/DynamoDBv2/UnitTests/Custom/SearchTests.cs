using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class SearchTests
    {
        private readonly Table _mockTable;
        private readonly Mock<IAmazonDynamoDB> _mockDynamoDBClient;
        private readonly Search _search;

        public SearchTests()
        {
            _mockDynamoDBClient = new Mock<IAmazonDynamoDB>();
            _mockTable = new TableBuilder(_mockDynamoDBClient.Object, "TestTable")
                .AddHashKey("Id", DynamoDBEntryType.String).Build();

            // Initialize Search with mocked dependencies
            _search = new Search
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = new Filter()
            };
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void Reset_ShouldResetSearchState()
        {
            // Arrange
            _search.Matches.Add(new Document());

            // Act
            _search.Reset();

            // Assert
            Assert.AreEqual(0,_search.Matches.Count);
            Assert.IsFalse(_search.IsDone);
            Assert.IsNull(_search.NextKey);
            Assert.IsTrue(_search.CollectResults);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_ShouldReturnDocuments()
        {
            // Arrange
            var mockDocument = new Document();
            var mockScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>> { new Dictionary<string, AttributeValue>() },
                LastEvaluatedKey = null,
                ScannedCount = 10,
            };

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Returns(mockScanResponse);

            // Act
            var result = _search.GetNextSetHelper();

            // Assert
            Assert.AreEqual(1,result.Count);
            Assert.AreEqual(mockDocument, result[0]);
            Assert.IsTrue(_search.IsDone);
            Assert.AreEqual(10, _search.ScannedCount);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetRemainingHelper_ShouldReturnAllDocuments()
        {
            // Arrange
            var mockDocument = new Document();
            var mockScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>> { new Dictionary<string, AttributeValue>() },
                LastEvaluatedKey = new Dictionary<string, AttributeValue>()
                {
                    {"test",new AttributeValue("test")}
                },
                ScannedCount = 10,
            }; 
            
            var mockLastScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>> { new Dictionary<string, AttributeValue>() },
                LastEvaluatedKey = null,
                ScannedCount = 20,
            };

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.Is<ScanRequest>(x=> x.ExclusiveStartKey==null)))
                .Returns(mockScanResponse);

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.Is<ScanRequest>(x=> x.ExclusiveStartKey != null && x.ExclusiveStartKey.Count==1)))
                .Returns(mockLastScanResponse);


            // Act
            var result = _search.GetRemainingHelper();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(mockDocument, result[0]);
            Assert.IsTrue(_search.IsDone);
            Assert.AreEqual(30, _search.ScannedCount);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetCount_ShouldReturnCorrectCount()
        {
            // Arrange// Arrange
            var mockScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>> { new(), new() },
                LastEvaluatedKey = null,
                Count = 2,
                ScannedCount = 10,
            };

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Returns(mockScanResponse);
            _search.Reset();
            // Act
            var count = _search.Count;

            // Assert
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_ShouldUpdateMetricsAfterPage()
        {
            // Arrange
            var consumed = new ConsumedCapacity
            {
                CapacityUnits = 3.5,
                ReadCapacityUnits = 2.0,
                WriteCapacityUnits = 1.5
            };

            var mockScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>
                {
                    new Dictionary<string, AttributeValue>(),
                    new Dictionary<string, AttributeValue>()
                },
                // No more pages -> IsDone = true
                LastEvaluatedKey = null,
                ScannedCount = 10,
                ConsumedCapacity = consumed
            };

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Returns(mockScanResponse);

            _search.Reset();
            _search.ReturnConsumedCapacity = ReturnConsumedCapacity.TOTAL;

            // Act
            var result = _search.GetNextSetHelper();

            // Assert item count to ensure we exercised the path
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(_search.IsDone);

            // Assert metrics aggregation populated by UpdateMetricsAfterPage
            Assert.AreEqual(10, _search.Metrics.ScannedCountLast);
            Assert.AreEqual(10, _search.Metrics.ScannedCountAccumulated);
            Assert.AreEqual(2, _search.Metrics.ItemsReturnedLast);
            Assert.AreEqual(2, _search.Metrics.TotalItemsReturned);
            Assert.AreSame(consumed, _search.Metrics.LastConsumedCapacity);
            Assert.AreEqual(1, _search.Metrics.ConsumedCapacityHistory.Count);
            Assert.AreEqual(3.5, _search.Metrics.TotalCapacityUnits);
            Assert.AreEqual(2.0, _search.Metrics.TotalReadCapacityUnits);
            Assert.AreEqual(1.5, _search.Metrics.TotalWriteCapacityUnits);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_SetsReturnConsumedCapacity_WhenNotNone()
        {
            // Arrange - capture the outgoing ScanRequest
            ScanRequest captured = null;

            var mockScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>(),
                LastEvaluatedKey = null,
            };

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Callback<ScanRequest>(req => captured = req)
                .Returns(mockScanResponse);

            _search.Reset();
            _search.ReturnConsumedCapacity = ReturnConsumedCapacity.INDEXES;

            // Act
            _ = _search.GetNextSetHelper();

            // Assert: ReturnConsumedCapacity is forwarded to the request
            Assert.IsNotNull(captured, "Expected ScanRequest to be captured.");
            Assert.AreEqual(ReturnConsumedCapacity.INDEXES, captured.ReturnConsumedCapacity);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_DoesNotSetReturnConsumedCapacity_WhenNone()
        {
            // Arrange - capture the outgoing ScanRequest
            ScanRequest captured = null;

            var mockScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>(),
                LastEvaluatedKey = null,
            };

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Callback<ScanRequest>(req => captured = req)
                .Returns(mockScanResponse);

            _search.Reset();
            _search.ReturnConsumedCapacity = ReturnConsumedCapacity.NONE;

            // Act
            _ = _search.GetNextSetHelper();

            // Assert: when NONE, the property should remain null (not set)
            Assert.IsNotNull(captured, "Expected ScanRequest to be captured.");
            Assert.IsNull(captured.ReturnConsumedCapacity);
        }

    }
}