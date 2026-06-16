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
    public class DocumentCompositeTableTests : IClassFixture<DocumentCompositeTableFixture>
    {
        private readonly DocumentCompositeTableFixture _fixture;

        public DocumentCompositeTableTests(DocumentCompositeTableFixture fixture) => _fixture = fixture;

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestCompositeHashRangeTableOperations(DynamoDBEntryConversion conversion)
        {
            // Load table with structural assertions
            var compositeHashRangeTable = Table.LoadTable(_fixture.Client, _fixture.CompositeHashRangeTableName, conversion, true);
            Assert.NotNull(compositeHashRangeTable);
            Assert.Equal(_fixture.CompositeHashRangeTableName, compositeHashRangeTable.TableName);
            Assert.Equal(9, compositeHashRangeTable.Attributes.Count);
            Assert.Equal(4, compositeHashRangeTable.GlobalSecondaryIndexes.Count);
            Assert.Equal(4, compositeHashRangeTable.GlobalSecondaryIndexNames.Count);
            Assert.Equal(1, compositeHashRangeTable.HashKeys.Count);
            Assert.Equal(1, compositeHashRangeTable.RangeKeys.Count);
            Assert.Equal(2, compositeHashRangeTable.Keys.Count);

            await TestCompositeHashRangeTableHelper(compositeHashRangeTable, conversion);
        }

        private async Task TestCompositeHashRangeTableHelper(ITable compositeHashRangeTable, DynamoDBEntryConversion conversion)
        {
            // Query GSI1
            var gsi1Filter = new QueryFilter("UserName", QueryOperator.Equal, "alice");
            gsi1Filter.AddCondition("Timestamp", QueryOperator.GreaterThan, 1000);
            var items = await compositeHashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GSI1",
                Filter = gsi1Filter
            }).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.True(items.All(d => d["UserName"].AsString() == "alice"));

            var req1 = new QueryDocumentOperationRequest
            {
                IndexName = "GSI1",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#U", "UserName" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "alice" } },
                    ExpressionStatement = "#U = :v"
                }
            };
            items = await compositeHashRangeTable.Query(req1).GetRemainingAsync();
            Assert.Equal(2, items.Count);
            Assert.True(items.All(d => d["UserName"].AsString() == "alice"));

            var req2 = new QueryDocumentOperationRequest
            {
                IndexName = "GSI1",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#U", "UserName" }, { "#T", "Timestamp" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "alice" }, { ":v2", 1000 } },
                    ExpressionStatement = "#U = :v AND #T > :v2"
                }
            };
            items = await compositeHashRangeTable.Query(req2).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal(1002, items[0]["Timestamp"].AsInt());

            // 3) ProjectionExpression + Select specific attributes (GSI1, project OrderId)
            var req3 = new QueryDocumentOperationRequest
            {
                IndexName = "GSI1",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#U", "UserName" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "alice" } },
                    ExpressionStatement = "#U = :v"
                },
                ProjectionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#O", "OrderId" } },
                    ExpressionStatement = "#O"
                },
                Select = SelectValues.SpecificAttributes
            };
            items = await compositeHashRangeTable.Query(req3).GetRemainingAsync();
            Assert.Equal(2, items.Count);
            Assert.Equal(1, items[0].Count);
            Assert.True(items[0].ContainsKey("OrderId"));

            // 5) Select Count (GSI1)
            var req5 = new QueryDocumentOperationRequest
            {
                IndexName = "GSI1",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#U", "UserName" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "alice" } },
                    ExpressionStatement = "#U = :v"
                },
                Select = SelectValues.Count
            };
            var searchCount = compositeHashRangeTable.Query(req5);
            var docsCount = await searchCount.GetRemainingAsync();
            Assert.Equal(2, searchCount.Count);
            Assert.Equal(0, docsCount.Count);

            // Query GSI2: UserName + OrderId + Timestamp
            var gsi2Filter = new QueryFilter("OrderId", QueryOperator.Equal, "order-100");
            gsi2Filter.AddCondition("UserName", QueryOperator.Equal, "bob"); ;
            items = await compositeHashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GSI2",
                Filter = gsi2Filter
            }).GetRemainingAsync();
            Assert.Equal(2, items.Count);
            Assert.True(items.All(d => d["UserName"].AsString() == "bob"));
            Assert.True(items.All(d => d["OrderId"].AsString() == "order-100"));

            var reqGsi2 = new QueryDocumentOperationRequest
            {
                IndexName = "GSI2",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#O", "OrderId" }, { "#U", "UserName" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":o", "order-100" }, { ":u", "bob" } },
                    ExpressionStatement = "#O = :o AND #U = :u"
                }
            };
            items = await compositeHashRangeTable.Query(reqGsi2).GetRemainingAsync();
            Assert.Equal(2, items.Count);
            Assert.True(items.All(d => d["UserName"].AsString() == "bob"));
            Assert.True(items.All(d => d["OrderId"].AsString() == "order-100"));

            var gsi2Filter2 = new QueryFilter("OrderId", QueryOperator.Equal, "order-100");
            gsi2Filter2.AddCondition("UserName", QueryOperator.Equal, "bob");
            gsi2Filter2.AddCondition("Timestamp", QueryOperator.GreaterThan, 1000);

            items = await compositeHashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GSI2",
                Filter = gsi2Filter2
            }).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal("order-100", items[0]["OrderId"].AsString());

            var reqGsi2Filter = new QueryDocumentOperationRequest
            {
                IndexName = "GSI2",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#O", "OrderId" }, { "#U", "UserName" }, { "#T", "Timestamp" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":o", "order-100" }, { ":u", "bob" }, { ":t", 1000 } },
                    ExpressionStatement = "#O = :o AND #U = :u AND #T > :t"
                }
            };
            items = await compositeHashRangeTable.Query(reqGsi2Filter).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal("order-100", items[0]["OrderId"].AsString());

            // Query GSI3: UserName + Region + Status + Category
            var gsi3Filter = new QueryFilter("Region", QueryOperator.Equal, "us-west-1");
            gsi3Filter.AddCondition("UserName", QueryOperator.Equal, "bob");
            gsi3Filter.AddCondition("Status", QueryOperator.Equal, "delivered");
            items = await compositeHashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GSI3",
                Filter = gsi3Filter
            }).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal(21, items[0]["Id"].AsInt());

            var reqGsi3 = new QueryDocumentOperationRequest
            {
                IndexName = "GSI3",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#R", "Region" }, { "#U", "UserName" }, { "#S", "Status" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":r", "us-west-1" }, { ":u", "bob" }, { ":s", "delivered" } },
                    ExpressionStatement = "#R = :r AND #U = :u AND #S = :s"
                }
            };
            items = await compositeHashRangeTable.Query(reqGsi3).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal(21, items[0]["Id"].AsInt());

            // Query GSI3 with all 4 keys: Region + UserName + Status + Category
            var gsi3Filter4Keys = new QueryFilter("Region", QueryOperator.Equal, "us-west-1");
            gsi3Filter4Keys.AddCondition("UserName", QueryOperator.Equal, "bob");
            gsi3Filter4Keys.AddCondition("Status", QueryOperator.Equal, "delivered");
            gsi3Filter4Keys.AddCondition("Category", QueryOperator.Equal, "electronics");
            items = await compositeHashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GSI3",
                Filter = gsi3Filter4Keys
            }).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal(21, items[0]["Id"].AsInt());

            var reqGsi3FourKeys = new QueryDocumentOperationRequest
            {
                IndexName = "GSI3",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#R", "Region" }, { "#U", "UserName" }, { "#S", "Status" }, { "#C", "Category" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":r", "us-west-1" }, { ":u", "bob" }, { ":s", "delivered" }, { ":c", "electronics" } },
                    ExpressionStatement = "#R = :r AND #U = :u AND #S = :s AND #C = :c"
                }
            };
            items = await compositeHashRangeTable.Query(reqGsi3FourKeys).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal(21, items[0]["Id"].AsInt());

            // Query GSI4 with all 8 keys: Id + UserName + OrderId + Region (HASH) + Status + Category + Amount + Priority (RANGE)
            var gsi4Filter = new QueryFilter("Id", QueryOperator.Equal, 21);
            gsi4Filter.AddCondition("UserName", QueryOperator.Equal, "bob");
            gsi4Filter.AddCondition("OrderId", QueryOperator.Equal, "order-100");
            gsi4Filter.AddCondition("Region", QueryOperator.Equal, "us-west-1");
            gsi4Filter.AddCondition("Status", QueryOperator.Equal, "delivered");
            gsi4Filter.AddCondition("Category", QueryOperator.Equal, "electronics");
            gsi4Filter.AddCondition("Amount", QueryOperator.Equal, 85);
            gsi4Filter.AddCondition("Priority", QueryOperator.Equal, 3);
            items = await compositeHashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GSI4",
                Filter = gsi4Filter
            }).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal(21, items[0]["Id"].AsInt());

            var reqGsi4 = new QueryDocumentOperationRequest
            {
                IndexName = "GSI4",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#I", "Id" }, { "#U", "UserName" }, { "#O", "OrderId" }, { "#R", "Region" },
                        { "#S", "Status" }, { "#C", "Category" }, { "#A", "Amount" }, { "#P", "Priority" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":i", 21 }, { ":u", "bob" }, { ":o", "order-100" }, { ":r", "us-west-1" },
                        { ":s", "delivered" }, { ":c", "electronics" }, { ":a", 85 }, { ":p", 3 }
                    },
                    ExpressionStatement = "#I = :i AND #U = :u AND #O = :o AND #R = :r AND #S = :s AND #C = :c AND #A = :a AND #P = :p"
                }
            };
            items = await compositeHashRangeTable.Query(reqGsi4).GetRemainingAsync();
            Assert.Equal(1, items.Count);
            Assert.Equal(21, items[0]["Id"].AsInt());

            // GSI4 with rightmost range key using GreaterThan
            var reqGsi4GreaterThan = new QueryDocumentOperationRequest
            {
                IndexName = "GSI4",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#I", "Id" }, { "#U", "UserName" }, { "#O", "OrderId" }, { "#R", "Region" },
                        { "#S", "Status" }, { "#C", "Category" }, { "#A", "Amount" }, { "#P", "Priority" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":i", 21 }, { ":u", "bob" }, { ":o", "order-100" }, { ":r", "us-west-1" },
                        { ":s", "delivered" }, { ":c", "electronics" }, { ":a", 85 }, { ":p", 2 }
                    },
                    ExpressionStatement = "#I = :i AND #U = :u AND #O = :o AND #R = :r AND #S = :s AND #C = :c AND #A = :a AND #P > :p"
                }
            };
            items = await compositeHashRangeTable.Query(reqGsi4GreaterThan).GetRemainingAsync();
            Assert.Equal(1, items.Count);

            // GSI3 with rightmost range key using BeginsWith
            var reqGsi3BeginsWith = new QueryDocumentOperationRequest
            {
                IndexName = "GSI3",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#U", "UserName" }, { "#R", "Region" }, { "#S", "Status" }, { "#C", "Category" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":u", "bob" }, { ":r", "us-west-1" }, { ":s", "delivered" }, { ":c", "ele" } },
                    ExpressionStatement = "#U = :u AND #R = :r AND #S = :s AND begins_with(#C, :c)"
                }
            };
            items = await compositeHashRangeTable.Query(reqGsi3BeginsWith).GetRemainingAsync();
            Assert.Equal(1, items.Count);

            // GSI4 with partial range keys and LessThan on rightmost
            var reqGsi4Partial = new QueryDocumentOperationRequest
            {
                IndexName = "GSI4",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#I", "Id" }, { "#U", "UserName" }, { "#O", "OrderId" }, { "#R", "Region" },
                        { "#S", "Status" }, { "#C", "Category" }, { "#A", "Amount" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":i", 21 }, { ":u", "bob" }, { ":o", "order-100" }, { ":r", "us-west-1" },
                        { ":s", "delivered" }, { ":c", "electronics" }, { ":a", 100 }
                    },
                    ExpressionStatement = "#I = :i AND #U = :u AND #O = :o AND #R = :r AND #S = :s AND #C = :c AND #A < :a"
                }
            };
            items = await compositeHashRangeTable.Query(reqGsi4Partial).GetRemainingAsync();
            Assert.Equal(1, items.Count);
        }
    }
}
