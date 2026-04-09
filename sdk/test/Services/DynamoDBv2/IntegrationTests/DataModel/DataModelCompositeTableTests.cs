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
    public class DataModelCompositeTableTests : IClassFixture<DataModelCompositeTableFixture>
    {
        private readonly DataModelCompositeTableFixture _fixture;

        public DataModelCompositeTableTests(DataModelCompositeTableFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestCompositeHashRangeTable(DynamoDBEntryConversion conversion)
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = conversion;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                // Query GSI1 with single hash key
                var queryConditional1 = QueryConditional.HashKeyEqualTo("UserName", "bob");
                var results1 = await context.QueryAsync<CompositeHashRangeEntity>(queryConditional1, new QueryConfig
                {
                    IndexName = "GSI1",
                    QueryFilter = new List<ScanCondition>
                    {
                        new ScanCondition("OrderId", ScanOperator.Equal, "order-2")
                    }
                }).GetNextSetAsync();
                Assert.Equal(2, results1.Count);
                Assert.True(results1.All(r => r.UserName == "bob"));

                // Query GSI1: composite-range behavior — Timestamp > 1000 (should return 1001,1002,1003)
                var queryGsi1Range = QueryConditional.HashKeyEqualTo("UserName", "alice")
                    .AndRangeKeyGreaterThan("Timestamp", 1000);
                var gsi1RangeResults = await context.QueryAsync<CompositeHashRangeEntity>(queryGsi1Range, new QueryConfig { IndexName = "GSI1" }).GetNextSetAsync();
                Assert.Equal(3, gsi1RangeResults.Count);
                Assert.Equal(new[] { 1001, 1002, 1003 }, gsi1RangeResults.Select(r => r.Timestamp).ToArray());

                // Query GSI1 with descending order
                var gsi1DescResults = await context.QueryAsync<CompositeHashRangeEntity>(queryGsi1Range, new QueryConfig { IndexName = "GSI1", BackwardQuery = true }).GetNextSetAsync();
                Assert.Equal(3, gsi1DescResults.Count);
                Assert.Equal(1003, gsi1DescResults.First().Timestamp);

                // Query GSI2 with all hash keys (UserName + OrderId)
                var queryConditional2 = QueryConditional.HashKeyEqualTo("UserName", "bob").AndHashKeyEqualTo("OrderId", "order-2");
                var results2 = await context.QueryAsync<CompositeHashRangeEntity>(queryConditional2,
                    new QueryConfig
                    {
                        IndexName = "GSI2"
                    })
                    .GetNextSetAsync();
                Assert.Equal(2, results2.Count);
                Assert.True(results2.All(r => r.UserName == "bob" && r.OrderId == "order-2"));

                // Query GSI2 with all hash keys (UserName + OrderId) and QueryFilter
                var results21 = await context.QueryAsync<CompositeHashRangeEntity>(queryConditional2,
                    new QueryConfig
                    {
                        IndexName = "GSI2",
                        QueryFilter = new List<ScanCondition>
                        {
                            new ScanCondition("Timestamp", ScanOperator.GreaterThan, 1004)
                        }
                    }).GetNextSetAsync();
                Assert.Equal(1, results21.Count);
                Assert.True(results21.All(r => r.UserName == "bob" && r.OrderId == "order-2"));

                // Query GSI2 with all hash keys and first range key
                var queryConditional2Range = QueryConditional.HashKeyEqualTo("UserName", "bob").AndHashKeyEqualTo("OrderId", "order-2").AndRangeKeyGreaterThan("Timestamp", 1004);
                var results2Range = await context.QueryAsync<CompositeHashRangeEntity>(queryConditional2Range, new QueryConfig { IndexName = "GSI2" }).GetNextSetAsync();
                Assert.Equal(1, results2Range.Count);
                Assert.True(results2Range.All(r => r.UserName == "bob" && r.OrderId == "order-2" && r.Timestamp > 1004));

                // Query GSI2 with hash keys and Timestamp < 1003 (for alice/order-1 -> should return 1000,1001,1002)
                var queryGsi2Alice = QueryConditional.HashKeyEqualTo("UserName", "alice").AndHashKeyEqualTo("OrderId", "order-1").AndRangeKeyLessThan("Timestamp", 1003);
                var gsi2AliceResults = await context.QueryAsync<CompositeHashRangeEntity>(queryGsi2Alice, new QueryConfig { IndexName = "GSI2" }).GetNextSetAsync();
                Assert.Equal(3, gsi2AliceResults.Count);
                Assert.Equal(new[] { 1000, 1001, 1002 }, gsi2AliceResults.Select(r => r.Timestamp).ToArray());

                // Query GSI3 with all hash keys
                var queryConditional3 = QueryConditional.HashKeyEqualTo("UserName", "bob").AndHashKeyEqualTo("Region", "us-east-1");
                var results3 = await context.QueryAsync<CompositeHashRangeEntity>(queryConditional3, new QueryConfig { IndexName = "GSI3" }).GetNextSetAsync();
                Assert.Equal(2, results3.Count);
                Assert.True(results3.All(r => r.UserName == "bob" && r.Region == "us-east-1"));

                // Query GSI3 with all hash keys and first range key (Status equal)
                var queryConditional3Range = QueryConditional.HashKeyEqualTo("UserName", "bob").AndHashKeyEqualTo("Region", "us-east-1").AndRangeKeyEqualTo("Status", "shipped");
                var results3Range = await context.QueryAsync<CompositeHashRangeEntity>(queryConditional3Range, new QueryConfig { IndexName = "GSI3" }).GetNextSetAsync();
                Assert.Equal(1, results3Range.Count);
                Assert.True(results3Range.All(r => r.UserName == "bob" && r.Region == "us-east-1" && r.Status == "shipped"));

                // Query GSI4 with all hash keys
                var queryConditional4 = QueryConditional.HashKeyEqualTo("Id", 41).AndHashKeyEqualTo("UserName", "charlie").AndHashKeyEqualTo("OrderId", "order-3").AndHashKeyEqualTo("Region", "us-central");
                var results4 = await context.QueryAsync<CompositeHashRangeEntity>(queryConditional4, new QueryConfig { IndexName = "GSI4" }).GetNextSetAsync();
                Assert.Equal(2, results4.Count);
                Assert.True(results4.All(r => r.Id == 41 && r.UserName == "charlie" && r.OrderId == "order-3" && r.Region == "us-central"));

                // Query GSI4 with all hash keys and first range key (Status equal)
                var queryConditional4Range = QueryConditional.HashKeyEqualTo("Id", 41).AndHashKeyEqualTo("UserName", "charlie").AndHashKeyEqualTo("OrderId", "order-3")
                    .AndHashKeyEqualTo("Region", "us-central").AndRangeKeyEqualTo("Status", "active");
                var results4Range = await context.QueryAsync<CompositeHashRangeEntity>(queryConditional4Range, new QueryConfig { IndexName = "GSI4" }).GetNextSetAsync();
                Assert.Equal(1, results4Range.Count);
                Assert.True(results4Range.All(r => r.Id == 41 && r.UserName == "charlie" && r.OrderId == "order-3" && r.Region == "us-central" && r.Status == "active"));

                // Additional composite-range check on GSI4: Priority > 2 should return both items for Id=41/charlie/order-3/region
                var queryGsi4Priority = QueryConditional.HashKeyEqualTo("Id", 41)
                    .AndHashKeyEqualTo("UserName", "charlie")
                    .AndHashKeyEqualTo("OrderId", "order-3")
                    .AndHashKeyEqualTo("Region", "us-central")
                    .AndRangeKeyEqualTo("Status", "active")
                    .AndRangeKeyEqualTo("Category", "clothing")
                    .AndRangeKeyGreaterThan("Amount", 200);
                var gsi4PriorityResults = await context.QueryAsync<CompositeHashRangeEntity>(queryGsi4Priority, new QueryConfig { IndexName = "GSI4" }).GetNextSetAsync();
                Assert.Equal(0, gsi4PriorityResults.Count);
            }
        }
    }
}
