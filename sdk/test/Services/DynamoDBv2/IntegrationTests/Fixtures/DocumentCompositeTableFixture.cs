using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Extends <see cref="CompositeHashRangeFixture"/> by seeding the composite table with
    /// the fixed dataset used by <see cref="DocumentCompositeTableTests"/>.
    /// Data is written once during fixture setup so tests are read-only and GSI propagation
    /// is complete before the first test method runs.
    /// </summary>
    public class DocumentCompositeTableFixture : CompositeHashRangeFixture
    {
        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();
            await SeedTableAsync();
        }

        private async Task SeedTableAsync()
        {
            var table = Table.LoadTable(Client, CompositeHashRangeTableName, DynamoDBEntryConversion.V2, true);
            var docs = new List<Document>
            {
                new Document 
                { 
                    ["Id"] = 1,
                    ["UserName"] = "alice", 
                    ["OrderId"] = "order-100", 
                    ["Timestamp"] = 1000, 
                    ["Region"] = "us-east-1",
                    ["Status"] = "pending",
                    ["Amount"] = 50,
                    ["Category"] = "books",
                    ["Priority"] = 1
                },
                new Document 
                { 
                    ["Id"] = 2,
                    ["UserName"] = "bob",
                    ["OrderId"] = "order-100", 
                    ["Timestamp"] = 1001, 
                    ["Region"] = "us-west-1",
                    ["Status"] = "shipped",
                    ["Amount"] = 75,
                    ["Category"] = "electronics",
                    ["Priority"] = 2 
                },
                new Document
                { 
                    ["Id"] = 21,
                    ["UserName"] = "bob",
                    ["OrderId"] = "order-100",
                    ["Timestamp"] = 1000, 
                    ["Region"] = "us-west-1",
                    ["Status"] = "delivered", 
                    ["Amount"] = 85,
                    ["Category"] = "electronics", 
                    ["Priority"] = 3 
                },
                new Document 
                {
                    ["Id"] = 3,
                    ["UserName"] = "alice", 
                    ["OrderId"] = "order-102", 
                    ["Timestamp"] = 1002, 
                    ["Region"] = "us-east-1",
                    ["Status"] = "delivered", 
                    ["Amount"] = 120, 
                    ["Category"] = "books",
                    ["Priority"] = 3 
                },
                new Document 
                {
                    ["Id"] = 4,
                    ["UserName"] = "carol", 
                    ["OrderId"] = "order-103", 
                    ["Timestamp"] = 1003, 
                    ["Region"] = "eu-central-1", 
                    ["Status"] = "pending",
                    ["Amount"] = 200, ["Category"] = "clothing",
                    ["Priority"] = 4 
                },
            };

            foreach (var doc in docs)
            {
                await table.PutItemAsync(doc);
            }

            // All 4 GSIs are eventually consistent. Poll until every GSI reflects all 5 items
            // before allowing any test to run.
            var gsiNames = new[] { "GSI1", "GSI2", "GSI3", "GSI4" };
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                foreach (var gsi in gsiNames)
                {
                    var results = await table.Scan(new ScanOperationConfig { IndexName = gsi }).GetRemainingAsync();
                    if (results.Count != 5)
                    {
                        return false;
                    }
                }

                return true;
            }, sleepSeconds: 1, maxWaitSeconds: 10);
        }
    }
}
