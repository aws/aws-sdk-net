using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Extends <see cref="CompositeHashRangeFixture"/> by seeding the composite table with
    /// the fixed dataset used by <see cref="DataModelCompositeTableTests"/>.
    /// Data is written once during fixture setup so tests are read-only and GSI propagation
    /// is complete before the first test method runs.
    /// </summary>
    public class DataModelCompositeTableFixture : CompositeHashRangeFixture
    {
        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();
            await SeedTableAsync();
        }

        private async Task SeedTableAsync()
        {
            var context = new DynamoDBContext(Client, new DynamoDBContextConfig
            {
                TableNamePrefix = TableNamePrefix
            });

            var entity1 = new CompositeHashRangeEntity
            {
                Id = 1,
                Status = "active",
                UserName = "alice",
                Timestamp = 1000,
                OrderId = "order-1",
                Region = "us-west-2",
                Category = "electronics",
                Amount = 100,
                Priority = 4
            };
            var entity11 = new CompositeHashRangeEntity
            {
                Id = 1,
                Status = "pending",
                UserName = "alice",
                Timestamp = 1001,
                OrderId = "order-1",
                Region = "us-west-2",
                Category = "electronics",
                Amount = 100,
                Priority = 1
            };
            var entity21 = new CompositeHashRangeEntity
            {
                Id = 21,
                Status = "active",
                UserName = "alice",
                Timestamp = 1002,
                OrderId = "order-1",
                Region = "us-west-1",
                Category = "electronics",
                Amount = 100,
                Priority = 2
            };
            var entity22 = new CompositeHashRangeEntity
            {
                Id = 21,
                Status = "pending",
                UserName = "alice",
                Timestamp = 1003,
                OrderId = "order-1",
                Region = "us-west-2",
                Category = "electronics",
                Amount = 100,
                Priority = 3
            };
            var entity31 = new CompositeHashRangeEntity
            {
                Id = 31,
                Status = "shipped",
                UserName = "bob",
                Timestamp = 1004,
                OrderId = "order-2",
                Region = "us-east-1",
                Category = "books",
                Amount = 150,
                Priority = 1
            };
            var entity32 = new CompositeHashRangeEntity
            {
                Id = 31,
                Status = "delivered",
                UserName = "bob",
                Timestamp = 1005,
                OrderId = "order-2",
                Region = "us-east-1",
                Category = "books",
                Amount = 150,
                Priority = 2
            };
            var entity41 = new CompositeHashRangeEntity
            {
                Id = 41,
                Status = "active",
                UserName = "charlie",
                Timestamp = 1006,
                OrderId = "order-3",
                Region = "us-central",
                Category = "clothing",
                Amount = 75,
                Priority = 3
            };
            var entity42 = new CompositeHashRangeEntity
            {
                Id = 41,
                Status = "completed",
                UserName = "charlie",
                Timestamp = 1007,
                OrderId = "order-3",
                Region = "us-central",
                Category = "clothing",
                Amount = 75,
                Priority = 4
            };

            await context.SaveAsync(entity1);
            await context.SaveAsync(entity11);
            await context.SaveAsync(entity21);
            await context.SaveAsync(entity22);
            await context.SaveAsync(entity31);
            await context.SaveAsync(entity32);
            await context.SaveAsync(entity41);
            await context.SaveAsync(entity42);

            // All 4 GSIs are eventually consistent. Poll until every GSI reflects all 8 items
            // before allowing any test to run.
            var table = Table.LoadTable(Client, CompositeHashRangeTableName, DynamoDBEntryConversion.V2, true);
            var gsiNames = new[] { "GSI1", "GSI2", "GSI3", "GSI4" };

            await UtilityMethods.WaitUntilAsync(async () =>
            {
                foreach (var gsi in gsiNames)
                {
                    var results = await table.Scan(new ScanOperationConfig { IndexName = gsi }).GetRemainingAsync();
                    if (results.Count != 8)
                    {
                        return false;
                    }
                }

                return true;
            }, sleepSeconds: 1, maxWaitSeconds: 10);
        }
    }
}
