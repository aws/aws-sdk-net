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
            Assert.AreEqual(0, _search.Matches.Count);
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
            Assert.AreEqual(1, result.Count);
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
                .Setup(client => client.Scan(It.Is<ScanRequest>(x => x.ExclusiveStartKey == null)))
                .Returns(mockScanResponse);

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.Is<ScanRequest>(x => x.ExclusiveStartKey != null && x.ExclusiveStartKey.Count == 1)))
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

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_Query_ShouldUpdateMetricsAfterPage()
        {
            // Arrange
            var querySearch = new Search(SearchType.Query)
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = null
            };

            var consumed = new ConsumedCapacity
            {
                CapacityUnits = 5.0,
                ReadCapacityUnits = 4.0,
                WriteCapacityUnits = 1.0
            };

            var mockQueryResponse = new QueryResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>
                {
                    new Dictionary<string, AttributeValue>(),
                    new Dictionary<string, AttributeValue>()
                },
                LastEvaluatedKey = null,
                ScannedCount = 7,
                ConsumedCapacity = consumed
            };

            _mockDynamoDBClient
                .Setup(client => client.Query(It.IsAny<QueryRequest>()))
                .Returns(mockQueryResponse);

            querySearch.ReturnConsumedCapacity = ReturnConsumedCapacity.TOTAL;

            // Act
            var result = querySearch.GetNextSetHelper();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(querySearch.IsDone);
            Assert.AreEqual(7, querySearch.Metrics.ScannedCountLast);
            Assert.AreEqual(7, querySearch.Metrics.ScannedCountAccumulated);
            Assert.AreEqual(2, querySearch.Metrics.ItemsReturnedLast);
            Assert.AreEqual(2, querySearch.Metrics.TotalItemsReturned);
            Assert.AreSame(consumed, querySearch.Metrics.LastConsumedCapacity);
            Assert.AreEqual(1, querySearch.Metrics.ConsumedCapacityHistory.Count);
            Assert.AreEqual(5.0, querySearch.Metrics.TotalCapacityUnits);
            Assert.AreEqual(4.0, querySearch.Metrics.TotalReadCapacityUnits);
            Assert.AreEqual(1.0, querySearch.Metrics.TotalWriteCapacityUnits);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_Query_WithNullConsumedCapacity_ShouldNotAddHistory()
        {
            // Arrange
            var querySearch = new Search(SearchType.Query)
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = null
            };

            var mockQueryResponse = new QueryResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>
                {
                    new Dictionary<string, AttributeValue>()
                },
                LastEvaluatedKey = null,
                ScannedCount = 3,
                ConsumedCapacity = null
            };

            _mockDynamoDBClient
                .Setup(client => client.Query(It.IsAny<QueryRequest>()))
                .Returns(mockQueryResponse);

            // Act
            var result = querySearch.GetNextSetHelper();

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(querySearch.IsDone);
            Assert.AreEqual(3, querySearch.Metrics.ScannedCountLast);
            Assert.AreEqual(3, querySearch.Metrics.ScannedCountAccumulated);
            Assert.AreEqual(1, querySearch.Metrics.ItemsReturnedLast);
            Assert.AreEqual(1, querySearch.Metrics.TotalItemsReturned);
            Assert.IsNull(querySearch.Metrics.LastConsumedCapacity);
            Assert.AreEqual(0, querySearch.Metrics.ConsumedCapacityHistory.Count);
            Assert.IsNull(querySearch.Metrics.TotalCapacityUnits);
            Assert.IsNull(querySearch.Metrics.TotalReadCapacityUnits);
            Assert.IsNull(querySearch.Metrics.TotalWriteCapacityUnits);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_Query_SplitsKeyAndFilterConditions_AndSetsConditionalOperator()
        {
            // Arrange
            QueryRequest captured = null;
            var queryFilter = new QueryFilter();
            queryFilter.AddCondition("Id", QueryOperator.Equal, new Primitive("1"));
            queryFilter.AddCondition("Status", ScanOperator.Equal, new Primitive("Active"));
            queryFilter.AddCondition("Category", ScanOperator.Equal, new Primitive("A"));

            var querySearch = new Search(SearchType.Query)
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = queryFilter,
                ConditionalOperator = ConditionalOperatorValues.Or
            };

            var mockQueryResponse = new QueryResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>(),
                LastEvaluatedKey = null
            };

            _mockDynamoDBClient
                .Setup(client => client.Query(It.IsAny<QueryRequest>()))
                .Callback<QueryRequest>(req => captured = req)
                .Returns(mockQueryResponse);

            // Act
            _ = querySearch.GetNextSetHelper();

            // Assert
            Assert.IsNotNull(captured, "Expected QueryRequest to be captured.");
            Assert.IsNotNull(captured.KeyConditions, "Expected key conditions to be set.");
            Assert.IsTrue(captured.KeyConditions.ContainsKey("Id"));
            Assert.IsNotNull(captured.QueryFilter, "Expected query filter to be set.");
            Assert.AreEqual(2, captured.QueryFilter.Count);
            Assert.IsTrue(captured.QueryFilter.ContainsKey("Status"));
            Assert.IsTrue(captured.QueryFilter.ContainsKey("Category"));
            Assert.AreEqual(EnumMapper.Convert(ConditionalOperatorValues.Or), captured.ConditionalOperator.ToString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_Query_WithAttributesToGetAndProjectionExpression_AppliesProjectionAndNames()
        {
            // Arrange
            QueryRequest captured = null;

            var filterExpression = new Expression
            {
                ExpressionStatement = "contains(#f, :value)"
            };
            filterExpression.ExpressionAttributeNames["#f"] = "FilterAttr";
            filterExpression.ExpressionAttributeValues[":value"] = new Primitive("value");

            var projectionExpression = new Expression
            {
                ExpressionStatement = "#p"
            };
            projectionExpression.ExpressionAttributeNames["#p"] = "ProjectedAttr";

            var querySearch = new Search(SearchType.Query)
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = null,
                FilterExpression = filterExpression,
                ProjectionExpression = projectionExpression,
                AttributesToGet = new List<string> { "Id", "Status" }
            };

            var mockQueryResponse = new QueryResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>(),
                LastEvaluatedKey = null
            };

            _mockDynamoDBClient
                .Setup(client => client.Query(It.IsAny<QueryRequest>()))
                .Callback<QueryRequest>(req => captured = req)
                .Returns(mockQueryResponse);

            // Act
            _ = querySearch.GetNextSetHelper();

            // Assert
            Assert.IsNotNull(captured, "Expected QueryRequest to be captured.");
            Assert.AreEqual("#p", captured.ProjectionExpression);
            Assert.IsNull(captured.AttributesToGet);
            Assert.IsNotNull(captured.ExpressionAttributeNames);
            Assert.IsTrue(captured.ExpressionAttributeNames.ContainsKey("#p"));
            Assert.IsTrue(captured.ExpressionAttributeNames.ContainsValue("Id"));
            Assert.IsTrue(captured.ExpressionAttributeNames.ContainsValue("Status"));
            Assert.IsTrue(captured.ExpressionAttributeNames.ContainsValue("FilterAttr"));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_Scan_SetsScanFilterIndexAndConditionalOperator()
        {
            // Arrange
            ScanRequest captured = null;
            var filter = new Filter();
            filter.AddCondition("Status", new Condition
            {
                ComparisonOperator = ComparisonOperator.EQ,
                AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Active" } }
            });
            filter.AddCondition("Category", new Condition
            {
                ComparisonOperator = ComparisonOperator.EQ,
                AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "A" } }
            });

            var scanSearch = new Search(SearchType.Scan)
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = filter,
                ConditionalOperator = ConditionalOperatorValues.Or,
                IndexName = "MyIndex"
            };

            var mockScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>(),
                LastEvaluatedKey = null
            };

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Callback<ScanRequest>(req => captured = req)
                .Returns(mockScanResponse);

            // Act
            _ = scanSearch.GetNextSetHelper();

            // Assert
            Assert.IsNotNull(captured, "Expected ScanRequest to be captured.");
            Assert.IsNotNull(captured.ScanFilter, "Expected ScanFilter to be set.");
            Assert.AreEqual(2, captured.ScanFilter.Count);
            Assert.IsTrue(captured.ScanFilter.ContainsKey("Status"));
            Assert.IsTrue(captured.ScanFilter.ContainsKey("Category"));
            Assert.AreEqual("MyIndex", captured.IndexName);
            Assert.AreEqual(EnumMapper.Convert(ConditionalOperatorValues.Or), captured.ConditionalOperator.ToString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetNextSetHelper_Scan_AppliesFilterExpressionAttributesToGetAndSegments()
        {
            // Arrange
            ScanRequest captured = null;
            var filterExpression = new Expression
            {
                ExpressionStatement = "contains(#f, :value)"
            };
            filterExpression.ExpressionAttributeNames["#f"] = "FilterAttr";
            filterExpression.ExpressionAttributeValues[":value"] = new Primitive("value");

            var scanSearch = new Search(SearchType.Scan)
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = null,
                FilterExpression = filterExpression,
                AttributesToGet = new List<string> { "Id", "Status" },
                TotalSegments = 3,
                Segment = 1
            };

            var mockScanResponse = new ScanResponse
            {
                Items = new List<Dictionary<string, AttributeValue>>(),
                LastEvaluatedKey = null
            };

            _mockDynamoDBClient
                .Setup(client => client.Scan(It.IsAny<ScanRequest>()))
                .Callback<ScanRequest>(req => captured = req)
                .Returns(mockScanResponse);

            // Act
            _ = scanSearch.GetNextSetHelper();

            // Assert
            Assert.IsNotNull(captured, "Expected ScanRequest to be captured.");
            Assert.AreEqual("contains(#f, :value)", captured.FilterExpression);
            Assert.IsNotNull(captured.ExpressionAttributeNames);
            Assert.IsTrue(captured.ExpressionAttributeNames.ContainsValue("FilterAttr"));
            Assert.IsTrue(captured.ExpressionAttributeNames.ContainsValue("Id"));
            Assert.IsTrue(captured.ExpressionAttributeNames.ContainsValue("Status"));
            Assert.IsNotNull(captured.ExpressionAttributeValues);
            Assert.IsTrue(captured.ExpressionAttributeValues.ContainsKey(":value"));
            Assert.IsNull(captured.AttributesToGet);
            Assert.IsFalse(string.IsNullOrEmpty(captured.ProjectionExpression));
            Assert.AreEqual(3, captured.TotalSegments);
            Assert.AreEqual(1, captured.Segment);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetCount_Query_SetsRequestAndUpdatesMetrics()
        {
            // Arrange
            QueryRequest captured = null;
            var querySearch = new Search(SearchType.Query)
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = null,
                IndexName = "MyIndex",
                IsBackwardSearch = true
            };
            querySearch.ReturnConsumedCapacity = ReturnConsumedCapacity.TOTAL;
            querySearch.Matches.Add(new Document());

            var consumed = new ConsumedCapacity
            {
                CapacityUnits = 2.5,
                ReadCapacityUnits = 2.0,
                WriteCapacityUnits = 0.5
            };

            var mockQueryResponse = new QueryResponse
            {
                Count = 2,
                ScannedCount = 7,
                ConsumedCapacity = consumed,
                LastEvaluatedKey = null
            };

            _mockDynamoDBClient
                .Setup(client => client.Query(It.IsAny<QueryRequest>()))
                .Callback<QueryRequest>(req => captured = req)
                .Returns(mockQueryResponse);

            // Act
            var count = querySearch.Count;

            // Assert
            Assert.IsNotNull(captured, "Expected QueryRequest to be captured.");
            Assert.AreEqual(EnumMapper.Convert(SelectValues.Count), captured.Select.ToString());
            Assert.IsFalse(captured.ScanIndexForward.GetValueOrDefault());
            Assert.AreEqual("MyIndex", captured.IndexName);
            Assert.AreEqual(ReturnConsumedCapacity.TOTAL, captured.ReturnConsumedCapacity);
            Assert.AreEqual(3, count);
            Assert.AreEqual(7, querySearch.ScannedCount);
            Assert.AreEqual(7, querySearch.Metrics.ScannedCountLast);
            Assert.AreEqual(7, querySearch.Metrics.ScannedCountAccumulated);
            Assert.AreEqual(0, querySearch.Metrics.ItemsReturnedLast);
            Assert.AreEqual(0, querySearch.Metrics.TotalItemsReturned);
            Assert.AreSame(consumed, querySearch.Metrics.LastConsumedCapacity);
            Assert.AreEqual(1, querySearch.Metrics.ConsumedCapacityHistory.Count);
            Assert.AreEqual(2.5, querySearch.Metrics.TotalCapacityUnits);
            Assert.AreEqual(2.0, querySearch.Metrics.TotalReadCapacityUnits);
            Assert.AreEqual(0.5, querySearch.Metrics.TotalWriteCapacityUnits);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetCount_Query_CachesCount()
        {
            // Arrange
            var querySearch = new Search(SearchType.Query)
            {
                SourceTable = _mockTable,
                TableName = "TestTable",
                CollectResults = true,
                Filter = null
            };

            var mockQueryResponse = new QueryResponse
            {
                Count = 4,
                ScannedCount = 4,
                LastEvaluatedKey = null
            };

            _mockDynamoDBClient
                .Setup(client => client.Query(It.IsAny<QueryRequest>()))
                .Returns(mockQueryResponse);

            // Act
            var first = querySearch.Count;
            var second = querySearch.Count;

            // Assert
            Assert.AreEqual(4, first);
            Assert.AreEqual(4, second);
            _mockDynamoDBClient.Verify(client => client.Query(It.IsAny<QueryRequest>()), Times.Once);
        }
    }
}