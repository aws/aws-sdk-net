using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DataModelSearchVectorsTableTests : IClassFixture<DataModelSearchVectorsTableFixture>
    {
        private readonly DataModelSearchVectorsTableFixture _fixture;
        private readonly DynamoDBContext _context;

        public DataModelSearchVectorsTableTests(DataModelSearchVectorsTableFixture fixture)
        {
            _fixture = fixture;
            _context = new DynamoDBContext(_fixture.Client, new DynamoDBContextConfig
            {
                TableNamePrefix = _fixture.TableNamePrefix,
                Conversion = DynamoDBEntryConversion.V2 
            });
        }

        [Fact]
        public async Task SearchVectorsAsync_ReturnsOnlyIndexedItems()
        {
            var search = _context.SearchVectorsAsync<SearchVectorsEntity>(
                DataModelSearchVectorsTableFixture.CreateSearchVector(0),10,
                new SearchVectorsConfig
                {
                    IndexName = "VectorIndexNoHash"
                });

            var results = await search.GetAsync();
            var ids = results.Select(r => r.Item.Id).ToList();

            Assert.NotEmpty(results);
            Assert.All(ids, id => Assert.Contains(id, new[] { "1", "2", "21", "3", "4", "6" }));
            Assert.DoesNotContain("5", ids);
            Assert.DoesNotContain("7", ids);
        }

        [Fact]
        public async Task SearchVectorsAsync_AppliesHashAndInlineFilterConditions()
        {
            var searchCondition = new ContextExpression();
            searchCondition.SetFilter<SearchVectorsEntity>(e => e.VectorHash == "catalog-a" && e.VectorInlineFilter2 == 20);

            var search = _context.SearchVectorsAsync<SearchVectorsEntity>(
                DataModelSearchVectorsTableFixture.CreateSearchVector(1), 10,
                new SearchVectorsConfig
                {
                    IndexName = "VectorIndex",
                    SearchConditionExpression = searchCondition
                });

            var results = await search.GetAsync();
            var ids = results.Select(r => r.Item.Id).ToList();

            Assert.NotEmpty(results);
            Assert.All(ids, id => Assert.Equal("2", id));
        }

        [Fact]
        public async Task SearchVectorsAsync_MapsNonIndexedDataInResults()
        {
            var search = _context.SearchVectorsAsync<SearchVectorsEntity>(
                DataModelSearchVectorsTableFixture.CreateSearchVector(0), 10,
                new SearchVectorsConfig
                {
                    IndexName = "VectorIndexNoHash"
                });

            var results = await search.GetAsync();
            var first = results.FirstOrDefault(r => r.Item.Id == "1");

            Assert.NotNull(first);
            Assert.Equal("meta-1", first.Item.NonIndexedData);
        }

        [Fact]
        public async Task FromSearchVectorsAsync_ReturnsOnlyIndexedItems()
        {
            var request = new SearchVectorsOperationRequest
            {
                IndexName = "VectorIndexNoHash",
                SearchVector = DataModelSearchVectorsTableFixture.CreateSearchVector(0),
                TopK = 10
            };

            var search = _context.FromSearchVectorsAsync<SearchVectorsEntity>(request, new FromSearchVectorsConfig());

            var results = await search.GetAsync();
            var ids = results.Select(r => r.Item.Id).ToList();

            Assert.NotEmpty(results);
            Assert.All(ids, id => Assert.Contains(id, new[] { "1", "2", "21", "3", "4", "6" }));
            Assert.DoesNotContain("5", ids);
            Assert.DoesNotContain("7", ids);
        }

        [Fact]
        public async Task FromSearchVectorsAsync_AppliesSearchConditionExpression()
        {
            var request = new SearchVectorsOperationRequest
            {
                IndexName = "VectorIndex",
                SearchVector = DataModelSearchVectorsTableFixture.CreateSearchVector(1),
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
            };

            var search = _context.FromSearchVectorsAsync<SearchVectorsEntity>(request, new FromSearchVectorsConfig());

            var results = await search.GetAsync();
            var ids = results.Select(r => r.Item.Id).ToList();

            Assert.NotEmpty(results);
            Assert.All(ids, id => Assert.Equal("2", id));
        }


    }
}
