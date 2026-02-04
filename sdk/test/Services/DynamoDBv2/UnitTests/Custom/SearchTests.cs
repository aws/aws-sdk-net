using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Expression = Amazon.DynamoDBv2.DocumentModel.Expression;

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

        /// <summary>
        /// Verifies that when a Search has a FilterExpression but no ScanFilter conditions,
        /// the ScanRequest sent to DynamoDB does NOT include an empty ScanFilter.
        /// This prevents the error: "Can not use both expression and non-expression parameters"
        /// Regression test for: https://github.com/aws/aws-sdk-net/issues/XXXX
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetCount_WithFilterExpressionOnly_ShouldNotSetScanFilter()
        {
            // Arrange - Create a Search with FilterExpression but no ScanFilter
            ScanRequest capturedRequest = null;

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Callback<ScanRequest>(req => capturedRequest = req)
                .Returns(new ScanResponse { Count = 5, ScannedCount = 10 });

            var search = new Search
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                FilterExpression = new Expression
                {
                    ExpressionStatement = "#V >= :num",
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#V", "Views" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":num", new Primitive("10", true) } }
                }
                // Note: Filter is not set (null), simulating a scan with only FilterExpression
            };

            // Act
            var count = search.Count;

            // Assert
            Assert.IsNotNull(capturedRequest, "ScanRequest should have been captured");
            Assert.IsFalse(capturedRequest.IsSetScanFilter(), "ScanFilter should NOT be set when only FilterExpression is used");
            Assert.IsNotNull(capturedRequest.FilterExpression, "FilterExpression should be set");
            Assert.AreEqual(5, count);
        }

        /// <summary>
        /// Verifies that GetNextSetHelper does not set ScanFilter when only FilterExpression is used.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_WithFilterExpressionOnly_ShouldNotSetScanFilter()
        {
            // Arrange
            ScanRequest capturedRequest = null;

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Callback<ScanRequest>(req => capturedRequest = req)
                .Returns(new ScanResponse
                {
                    Items = new List<Dictionary<string, AttributeValue>> { new() },
                    LastEvaluatedKey = null,
                    ScannedCount = 1
                });

            var search = new Search
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                FilterExpression = new Expression
                {
                    ExpressionStatement = "#V >= :num",
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#V", "Views" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":num", new Primitive("10", true) } }
                }
                // Note: Filter is not set (null)
            };

            // Act
            var result = search.GetNextSetHelper();

            // Assert
            Assert.IsNotNull(capturedRequest, "ScanRequest should have been captured");
            Assert.IsFalse(capturedRequest.IsSetScanFilter(), "ScanFilter should NOT be set when only FilterExpression is used");
            Assert.IsNotNull(capturedRequest.FilterExpression, "FilterExpression should be set");
            Assert.AreEqual(1, result.Count);
        }
    }
}
