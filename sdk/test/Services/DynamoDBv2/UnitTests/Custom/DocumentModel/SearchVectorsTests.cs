using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class SearchVectorsTests
    {
        private Mock<IAmazonDynamoDB> _ddbClientMock;
        private Table _table;

        [TestInitialize]
        public void Setup()
        {
            _ddbClientMock = new Mock<IAmazonDynamoDB>(MockBehavior.Strict);

            var clientConfigMock = new Mock<IClientConfig>();
            clientConfigMock.SetupGet(c => c.RegionEndpoint).Returns((RegionEndpoint)null);
            clientConfigMock.SetupGet(c => c.ServiceURL).Returns((string)null);
            _ddbClientMock.SetupGet(c => c.Config).Returns(clientConfigMock.Object);

            _table = new TableBuilder(_ddbClientMock.Object, "TestTable")
                .AddHashKey("Id", DynamoDBEntryType.String)
                .Build();
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task GetTopKHelperAsync_WhenSourceTableIsNull_ThrowsInvalidOperationException()
        {
            var search = new SearchVectors();

            var ex = await Assert.ThrowsExactlyAsync<InvalidOperationException>(
                () => search.GetHelperAsync(CancellationToken.None));

            Assert.AreEqual("SourceTable must be set for vector search.", ex.Message);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetTopKHelper_WhenSourceTableIsNull_ThrowsInvalidOperationException()
        {
            var search = new SearchVectors();

            var ex = Assert.ThrowsExactly<InvalidOperationException>(() => search.GetHelper());

            Assert.AreEqual("SourceTable must be set for vector search.", ex.Message);
        }

#if NETCOREAPP

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void GetTopKHelper_WhenClientIsNotAmazonDynamoDBClientOnNetCore_ThrowsInvalidOperationException()
        {
            var search = CreateValidSearchVectors();

            var ex = Assert.ThrowsExactly<InvalidOperationException>(() => search.GetHelper());

            Assert.AreEqual("Calling synchronous Get() from .NET or .NET Core requires initializing the Table with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when calling GetAsync instead.", ex.Message);
        }
#endif

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task GetTopKHelperAsync_WhenTopKIsNotPositive_ThrowsArgumentOutOfRangeException()
        {
            var search = CreateValidSearchVectors();
            search.TopK = 0;

            var ex = await Assert.ThrowsExactlyAsync<ArgumentOutOfRangeException>(
                () => search.GetHelperAsync(CancellationToken.None));

            StringAssert.Contains(ex.Message, "TopK must be greater than 0.");
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task GetTopKHelperAsync_WhenSearchVectorMissing_ThrowsInvalidOperationException()
        {
            var search = CreateValidSearchVectors();
            search.SearchVector = null;

            var ex = await Assert.ThrowsExactlyAsync<InvalidOperationException>(
                () => search.GetHelperAsync(CancellationToken.None));

            Assert.AreEqual("SearchVector must be set and contain at least one value.", ex.Message);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task GetTopKHelperAsync_WhenSuccessful_UpdatesMatchesAndMetrics()
        {
            SearchVectorsRequest capturedRequest = null;
            var consumed = new VectorCapacity
            {
                VectorSearchRequestBytes = 2.5,
                VectorWriteRequestBytes = 1.25
            };

            _ddbClientMock
                .Setup(c => c.SearchVectorsAsync(It.IsAny<SearchVectorsRequest>(), It.IsAny<CancellationToken>()))
                .Callback<SearchVectorsRequest, CancellationToken>((request, _) => capturedRequest = request)
                .ReturnsAsync(new SearchVectorsResponse
                {
                    SearchResults = new List<SearchResultItem>
                    {
                        new SearchResultItem
                        {
                            Item = new Dictionary<string, AttributeValue>
                            {
                                ["Id"] = new AttributeValue { S = "id-1" }
                            },
                            Score = 0.99d
                        }
                    },
                    ConsumedCapacity = consumed
                });

            var search = CreateValidSearchVectors();
            search.TopK = 3;

            var results = await search.GetHelperAsync(CancellationToken.None);

            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual("TestTable", capturedRequest.TableName);
            Assert.AreEqual("VectorIndex", capturedRequest.IndexName);
            Assert.AreEqual(3, capturedRequest.TopK);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(1, search.Matches.Count);
            Assert.AreEqual(0.99d, results[0].Score);
            Assert.AreEqual("id-1", results[0].Document["Id"].AsString());

            Assert.AreEqual(1, search.Metrics.ItemsReturnedLast);
            Assert.AreEqual(1, search.Metrics.TotalItemsReturned);
            Assert.AreSame(consumed, search.Metrics.LastConsumedCapacity);
            Assert.AreEqual(1, search.Metrics.ConsumedCapacityHistory.Count);
            Assert.AreEqual(2.5, search.Metrics.TotalVectorSearchRequestBytes);
            Assert.AreEqual(1.25, search.Metrics.TotalVectorWriteRequestBytes);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task GetTopKHelperAsync_AppliesExpressionsAndReturnConsumedCapacityToRequest()
        {
            SearchVectorsRequest capturedRequest = null;

            _ddbClientMock
                .Setup(c => c.SearchVectorsAsync(It.IsAny<SearchVectorsRequest>(), It.IsAny<CancellationToken>()))
                .Callback<SearchVectorsRequest, CancellationToken>((request, _) => capturedRequest = request)
                .ReturnsAsync(new SearchVectorsResponse
                {
                    SearchResults = new List<SearchResultItem>()
                });

            var search = CreateValidSearchVectors();
            search.ReturnConsumedCapacity = ReturnConsumedCapacity.INDEXES;
            search.SearchConditionExpression = new Expression
            {
                ExpressionStatement = "#A = :a",
                ExpressionAttributeNames = new Dictionary<string, string>
                {
                    ["#A"] = "AttrA"
                },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                {
                    [":a"] = new Primitive("value-a")
                }
            };
            search.ProjectionExpression = new Expression
            {
                ExpressionStatement = "#B",
                ExpressionAttributeNames = new Dictionary<string, string>
                {
                    ["#B"] = "AttrB"
                }
            };

            _ = await search.GetHelperAsync(CancellationToken.None);

            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(ReturnConsumedCapacity.INDEXES, capturedRequest.ReturnConsumedCapacity);
            Assert.AreEqual("#A = :a", capturedRequest.SearchConditionExpression);
            Assert.AreEqual("#B", capturedRequest.ProjectionExpression);
            Assert.AreEqual("AttrA", capturedRequest.ExpressionAttributeNames["#A"]);
            Assert.AreEqual("AttrB", capturedRequest.ExpressionAttributeNames["#B"]);
            Assert.IsTrue(capturedRequest.ExpressionAttributeValues.ContainsKey(":a"));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task GetTopKHelperAsync_SerializesSearchVectorWithRoundTripPrecision()
        {
            SearchVectorsRequest capturedRequest = null;

            _ddbClientMock
                .Setup(c => c.SearchVectorsAsync(It.IsAny<SearchVectorsRequest>(), It.IsAny<CancellationToken>()))
                .Callback<SearchVectorsRequest, CancellationToken>((request, _) => capturedRequest = request)
                .ReturnsAsync(new SearchVectorsResponse
                {
                    SearchResults = new List<SearchResultItem>()
                });

            var value = 1.2345678f;
            var search = CreateValidSearchVectors();
            search.SearchVector = new List<float> { value };

            _ = await search.GetHelperAsync(CancellationToken.None);

            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(1, capturedRequest.SearchVector.Count);
            Assert.AreEqual(value.ToString("R", CultureInfo.InvariantCulture), capturedRequest.SearchVector[0].N);
        }

        private SearchVectors CreateValidSearchVectors()
        {
            return new SearchVectors
            {
                SourceTable = _table,
                TableName = "TestTable",
                IndexName = "VectorIndex",
                TopK = 1,
                SearchVector = new List<float> { 1.0f }
            };
        }
    }
}
