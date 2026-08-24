using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DocumentSearchVectorsTableTests : IClassFixture<DocumentSearchVectorsTableFixture>
    {
        private readonly DocumentSearchVectorsTableFixture _fixture;

        public DocumentSearchVectorsTableTests(DocumentSearchVectorsTableFixture fixture) => _fixture = fixture;

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TableSearchVectors_GetTopKAsync_ReturnsOnlyIndexedItems(DynamoDBEntryConversion conversion)
        {
            var table = Table.LoadTable(_fixture.Client, _fixture.SearchVectorsTableName, conversion, true);
            var search = table.SearchVectors(new SearchVectorsOperationRequest
            {
                IndexName = "VectorIndexNoHash",
                SearchVector = DocumentSearchVectorsTableFixture.CreateSearchVector(0),
                TopK = 10
            });

            var results = await search.GetAsync();
            var ids = results.Select(r => r.Document["Id"].AsString()).ToList();

            Assert.NotEmpty(results);
            Assert.All(ids, id => Assert.Contains(id, new[] { "1", "2", "21", "3", "4", "6" }));
            Assert.DoesNotContain("5", ids);
            Assert.DoesNotContain("7", ids);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TableSearchVectors_GetTopKAsync_AppliesHashAndInlineFilterConditions(DynamoDBEntryConversion conversion)
        {
            var table = Table.LoadTable(_fixture.Client, _fixture.SearchVectorsTableName, conversion, true);
            var search = table.SearchVectors(new SearchVectorsOperationRequest
            {
                IndexName = "VectorIndex",
                SearchVector = DocumentSearchVectorsTableFixture.CreateSearchVector(1),
                TopK = 10,
                SearchConditionExpression = new Expression
                {
                    ExpressionStatement = "#H = :h AND #F2 = :f2",
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#H", "VectorHash" },
                        { "#F2", "VectorInlineFilter2" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":h", "catalog-a" },
                        { ":f2", 20 }
                    }
                }
            });

            var results = await search.GetAsync();
            var ids = results.Select(r => r.Document["Id"].AsString()).ToList();

            Assert.NotEmpty(results);
            Assert.All(ids, id => Assert.Equal("2", id));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TableSearchVectors_GetTopKAsync_AppliesProjectionAndTracksMetrics(DynamoDBEntryConversion conversion)
        {
            var table = Table.LoadTable(_fixture.Client, _fixture.SearchVectorsTableName, conversion, true);
            var search = table.SearchVectors(new SearchVectorsOperationRequest
            {
                IndexName = "VectorIndexNoHash",
                SearchVector = DocumentSearchVectorsTableFixture.CreateSearchVector(2),
                ReturnConsumedCapacity = ReturnConsumedCapacity.TOTAL,
                TopK = 2,
                ProjectionExpression = new Expression
                {
                    ExpressionStatement = "#I, #F1",
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#I", "Id" },
                        { "#F1", "VectorInlineFilter1" }
                    }
                }
            });

            var results = await search.GetAsync();

            Assert.NotEmpty(results);
            Assert.All(results, item =>
            {
                Assert.All(item.Document.Keys, key => Assert.Contains(key, new[] { "Id", "VectorInlineFilter1" }));
            });

            Assert.Equal(results.Count, search.Metrics.ItemsReturnedLast);
            Assert.True(search.Metrics.TotalItemsReturned >= results.Count);
        }
    }
}
