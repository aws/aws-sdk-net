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


    }
}