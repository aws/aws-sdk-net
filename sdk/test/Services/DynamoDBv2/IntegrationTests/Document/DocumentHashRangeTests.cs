using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DocumentHashRangeTests : IClassFixture<HashRangeTableFixture>, IAsyncLifetime
    {
        private readonly HashRangeTableFixture _fixture;

        public DocumentHashRangeTests(HashRangeTableFixture fixture)
        {
            _fixture = fixture;
        }

        public async ValueTask InitializeAsync() => await _fixture.CleanupTables();

        public ValueTask DisposeAsync() => default;

        private ITable LoadHashRangeTable(DynamoDBEntryConversion conversion)
        {
            return Table.LoadTable(_fixture.Client, _fixture.HashRangeTableName, conversion, true);
        }

        private ITable BuildHashRangeTable(DynamoDBEntryConversion conversion)
        {
            return new TableBuilder(_fixture.Client, _fixture.HashRangeTableName, conversion, true, null)
                .AddHashKey("Name", DynamoDBEntryType.String)
                .AddRangeKey("Age", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Score", DynamoDBEntryType.Numeric)
                .AddLocalSecondaryIndex("LocalIndex", "Manager", DynamoDBEntryType.String)
                .Build();
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public void TestHashRangeTableStructure(DynamoDBEntryConversion conversion)
        {
            AssertExtensions.ExpectException(() => Table.LoadTable(_fixture.Client, "FakeHashRangeTableThatShouldNotExist", conversion, true));
            var hashRangeTable = Table.LoadTable(_fixture.Client, _fixture.HashRangeTableName, conversion, true);
            Assert.NotNull(hashRangeTable);
            Assert.Equal(_fixture.HashRangeTableName, hashRangeTable.TableName);
            Assert.Equal(5, hashRangeTable.Attributes.Count);
            Assert.Equal(1, hashRangeTable.GlobalSecondaryIndexes.Count);
            Assert.Equal(1, hashRangeTable.GlobalSecondaryIndexNames.Count);
            Assert.Equal(1, hashRangeTable.HashKeys.Count);
            Assert.Equal(1, hashRangeTable.RangeKeys.Count);
            Assert.Equal(2, hashRangeTable.Keys.Count);
            Assert.Equal(1, hashRangeTable.LocalSecondaryIndexes.Count);
            Assert.Equal(2, hashRangeTable.LocalSecondaryIndexes["LocalIndex"].KeySchema.Count);
            Assert.Equal(1, hashRangeTable.LocalSecondaryIndexNames.Count);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableOperations_HashRangeTable(DynamoDBEntryConversion conversion)
        {
            await TestHashRangeTableHelper(LoadHashRangeTable(conversion), conversion);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableViaBuilder_HashRangeTable(DynamoDBEntryConversion conversion)
        {
            await TestHashRangeTableHelper(BuildHashRangeTable(conversion), conversion);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableOperations_ExpressionsOnQuery(DynamoDBEntryConversion conversion)
        {
            await TestExpressionsOnQueryHelper(LoadHashRangeTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableViaBuilder_ExpressionsOnQuery(DynamoDBEntryConversion conversion)
        {
            await TestExpressionsOnQueryHelper(BuildHashRangeTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableOperations_ExpressionsOnScan(DynamoDBEntryConversion conversion)
        {
            await TestExpressionsOnScanHelper(LoadHashRangeTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableViaBuilder_ExpressionsOnScan(DynamoDBEntryConversion conversion)
        {
            await TestExpressionsOnScanHelper(BuildHashRangeTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableOperations_ScanConsumedCapacity(DynamoDBEntryConversion conversion)
        {
            await TestScanDocumentOperationRequestReturnConsumedCapacityHelper(LoadHashRangeTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableViaBuilder_ScanConsumedCapacity(DynamoDBEntryConversion conversion)
        {
            await TestScanDocumentOperationRequestReturnConsumedCapacityHelper(BuildHashRangeTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableOperations_Pagination(DynamoDBEntryConversion conversion)
        {
            await TestPaginationHelper(LoadHashRangeTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashRangeTableViaBuilder_Pagination(DynamoDBEntryConversion conversion)
        {
            await TestPaginationHelper(BuildHashRangeTable(conversion));
        }

        private async Task TestPaginationHelper(ITable hashRangeTable)
        {
            var itemCount = 10;
            var batchWrite = hashRangeTable.CreateBatchWrite();
            var name = "Borg";

            // Put items
            for (int i = 0; i < itemCount; i++)
            {
                batchWrite.AddDocumentToPut(new Document
                {
                    ["Name"] = name,
                    ["Age"] = 1 + i,
                    ["Company"] = "Big River",
                    ["Score"] = 120 + i,
                    ["IsTester"] = true,
                    ["Manager"] = "Kirk"
                });
            }
            await batchWrite.ExecuteAsync();

            // Paginated scan
            {
                var search = hashRangeTable.Scan(new ScanOperationConfig
                {
                    Limit = 1
                });

                var tokens = new List<string>();
                var retrievedCount = await VerifyPagination(search, tokens);
                Assert.Equal(itemCount, retrievedCount);
                Assert.Equal(itemCount, tokens.Count);

                var currentToken = tokens[4];
                search = hashRangeTable.Scan(new ScanOperationConfig
                {
                    Limit = 1,
                    PaginationToken = currentToken
                });
                var items = await search.GetNextSetAsync();
                Assert.Equal(1, items.Count);
                Assert.NotEqual(currentToken, search.PaginationToken);
            }

            // Paginated query
            {
                var filter = new QueryFilter("Name", QueryOperator.Equal, name);
                var search = hashRangeTable.Query(new QueryOperationConfig
                {
                    Limit = 1,
                    Filter = filter
                });

                var tokens = new List<string>();
                var retrievedCount = await VerifyPagination(search, tokens);
                Assert.Equal(itemCount, retrievedCount);
                Assert.Equal(itemCount, tokens.Count);

                var currentToken = tokens[4];
                search = hashRangeTable.Query(new QueryOperationConfig
                {
                    Limit = 1,
                    Filter = filter,
                    PaginationToken = currentToken
                });
                var items = await search.GetNextSetAsync();
                Assert.Equal(1, items.Count);
                Assert.NotEqual(currentToken, search.PaginationToken);
            }
        }

        private static async Task<int> VerifyPagination(ISearch search, List<string> tokens)
        {
            int count = 0;
            do
            {
                var items = await search.GetNextSetAsync();
                var token = search.PaginationToken;
                count += items.Count;

                if (!search.IsDone)
                {
                    tokens.Add(token);
                    Assert.NotEqual(0, items.Count);
                    Assert.False(string.IsNullOrEmpty(token));
                }
            } while (!search.IsDone);

            return count;
        }

        private async Task TestHashRangeTableHelper(ITable hashRangeTable, DynamoDBEntryConversion conversion)
        {
            // Put an item
            Document doc1 = new Document
            {
                ["Name"] = "Alan",
                ["Age"] = 31,
                ["Company"] = "Big River",
                ["Score"] = 120,
                ["IsTester"] = true,
                ["Manager"] = "Barbara",
                ["Aliases"] = new HashSet<string> { "Al", "Steve" },
                ["PastManagers"] = new List<string> { "Carl", "Karl" }
            };
            await hashRangeTable.PutItemAsync(doc1);

            // Update a non-existent item creates the item
            Document doc2 = new Document();
            doc2["Name"] = "Chuck";
            doc2["Age"] = 30;
            doc2["Company"] = "Big River";
            doc2["Score"] = 94;
            doc1["IsTester"] = false;
            doc2["Manager"] = "Barbara";
            doc2["Aliases"] = new HashSet<string> { "Charles" };
            await hashRangeTable.UpdateItemAsync(doc2);

            // Save more items
            Document doc3 = new Document();
            doc3["Name"] = "Diane";
            doc3["Age"] = 40;
            doc3["Company"] = "Madeira";
            doc1["IsTester"] = true;
            doc3["Score"] = 140;
            doc3["Manager"] = "Eva";
            await hashRangeTable.UpdateItemAsync(doc3);
            var oldDoc3 = doc3.Clone() as Document;

            // Changing the range key will force a creation of a new item
            doc3["Age"] = 24;
            doc3["Score"] = 101;
            await hashRangeTable.UpdateItemAsync(doc3);

            // Get item
            var consistentRead = new GetItemOperationConfig { ConsistentRead = true };
            var retrieved = await hashRangeTable.GetItemAsync("Alan", 31, consistentRead);

            // Verify retrieved document
            Assert.True(AreValuesEqual(doc1, retrieved, conversion));
            var tagsRetrieved = retrieved["Aliases"];
            Assert.True(tagsRetrieved is PrimitiveList);
            Assert.Equal(2, tagsRetrieved.AsPrimitiveList().Entries.Count);

            // Test bool storage for different conversions
            var isTesterRetrieved = retrieved["IsTester"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.Equal("1", isTesterRetrieved.AsPrimitive().Value as string);
            else
                Assert.True(isTesterRetrieved is DynamoDBBool);

            // Test HashSet<string> storage for different conversions
            var pastManagersRetrieved = retrieved["PastManagers"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.Equal(2, pastManagersRetrieved.AsPrimitiveList().Entries.Count);
            else
                Assert.Equal(2, pastManagersRetrieved.AsDynamoDBList().Entries.Count);

            // Get item using GetItem overloads that expect a key in different ways
            retrieved = await hashRangeTable.GetItemAsync(doc2, consistentRead);
            Assert.True(AreValuesEqual(doc2, retrieved, conversion));
            retrieved = await hashRangeTable.GetItemAsync(oldDoc3, consistentRead);
            Assert.True(AreValuesEqual(oldDoc3, retrieved, conversion));
            retrieved = await hashRangeTable.GetItemAsync("Diane", 24, consistentRead);
            Assert.True(AreValuesEqual(doc3, retrieved, conversion));

            // Scan the hash-and-range-key table
            var items = await hashRangeTable.Scan(new ScanOperationConfig { ConsistentRead = true }).GetRemainingAsync();
            Assert.Equal(4, items.Count);

            // Scan by pages
            var search = hashRangeTable.Scan(new ScanOperationConfig { Limit = 1, ConsistentRead = true });
            items.Clear();
            while (!search.IsDone)
            {
                var set = await search.GetNextSetAsync();
                items.AddRange(set);
            }
            Assert.Equal(4, items.Count);

            // Scan in parallel
            var segment1 = await hashRangeTable.Scan(new ScanOperationConfig { Segment = 0, TotalSegments = 2, ConsistentRead = true }).GetRemainingAsync();
            var segment2 = await hashRangeTable.Scan(new ScanOperationConfig { Segment = 1, TotalSegments = 2, ConsistentRead = true }).GetRemainingAsync();
            Assert.Equal(4, segment1.Count + segment2.Count);

            // Query items
            items = await hashRangeTable.Query("Diane", new QueryFilter()).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            var queryConfig = new QueryOperationConfig
            {
                KeyExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#N", "Name" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v", "Diane" }
                    },
                    ExpressionStatement = "#N = :v"
                }
            };
            items = await hashRangeTable.Query(queryConfig).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            queryConfig = new QueryOperationConfig
            {
                KeyExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#N", "Name" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v", "Diane" }
                    },
                    ExpressionStatement = "#N = :v"
                },
                FilterExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#S", "Score" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v2", 120 }
                    },
                    ExpressionStatement = "#S > :v2"
                }
            };
            items = await hashRangeTable.Query(queryConfig).GetRemainingAsync();
            Assert.Equal(1, items.Count);

            queryConfig = new QueryOperationConfig
            {
                KeyExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#N", "Name" },
                        { "#A", "Age" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v2", 120 }
                    },
                    ExpressionStatement = "#N = :v and #A < :v2"
                },
                FilterExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#S", "Score" },
                        { "#A", "Age" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v", "Diane" },
                    },
                    ExpressionStatement = "#S < :v2"
                }
            };
            items = await hashRangeTable.Query(queryConfig).GetRemainingAsync();
            Assert.Equal(1, items.Count);

            // Query local index
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Diane")
            }).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            // GSI updates are eventually consistent; wait until all 4 items are indexed before querying.
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                var indexed = await hashRangeTable.Scan(new ScanOperationConfig { IndexName = "GlobalIndex" }).GetRemainingAsync();
                return indexed.Count >= 4;
            }, sleepSeconds: 1, maxWaitSeconds: 30);

            // Query global index
            var queryFilter = new QueryFilter("Company", QueryOperator.Equal, "Big River");
            queryFilter.AddCondition("Score", QueryOperator.GreaterThan, 100);
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemainingAsync();
            Assert.Equal(1, items.Count);

            // Additional Query scenarios using QueryDocumentOperationRequest
            // 1) Basic key condition expression
            var req1 = new QueryDocumentOperationRequest
            {
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#N", "Name" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "Diane" } },
                    ExpressionStatement = "#N = :v"
                }
            };
            items = await hashRangeTable.Query(req1).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            // 2) Key condition + filter expression
            var req2 = new QueryDocumentOperationRequest
            {
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#N", "Name" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "Diane" } },
                    ExpressionStatement = "#N = :v"
                },
                FilterExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#S", "Score" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v2", 120 } },
                    ExpressionStatement = "#S > :v2"
                }
            };
            items = await hashRangeTable.Query(req2).GetRemainingAsync();
            Assert.Equal(1, items.Count);

            // 3) ProjectionExpression + Select specific attributes
            var req3 = new QueryDocumentOperationRequest
            {
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#N", "Name" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "Diane" } },
                    ExpressionStatement = "#N = :v"
                },
                ProjectionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#A", "Age" } },
                    ExpressionStatement = "#A"
                },
                Select = SelectValues.SpecificAttributes
            };
            items = await hashRangeTable.Query(req3).GetRemainingAsync();
            Assert.Equal(2, items.Count);
            Assert.Equal(1, items[0].Count);
            Assert.True(items[0].ContainsKey("Age"));

            // 4) IndexName + key condition expression (querying local index)
            var req4 = new QueryDocumentOperationRequest
            {
                IndexName = "LocalIndex",
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#N", "Name" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "Diane" } },
                    ExpressionStatement = "#N = :v"
                }
            };
            items = await hashRangeTable.Query(req4).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            // 5) Select Count
            var req5 = new QueryDocumentOperationRequest
            {
                KeyConditionExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string> { { "#N", "Name" } },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "Diane" } },
                    ExpressionStatement = "#N = :v"
                },
                Select = SelectValues.Count
            };
            var searchCount = hashRangeTable.Query(req5);
            var docsCount = await searchCount.GetRemainingAsync();
            Assert.Equal(2, searchCount.Count);
            Assert.Equal(0, docsCount.Count);


            // Scan local index
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Name", ScanOperator.Equal, "Diane");
            items = await hashRangeTable.Scan(new ScanOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = scanFilter,
                ConsistentRead = true
            }).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            // Scan global index
            scanFilter = new ScanFilter();
            scanFilter.AddCondition("Company", ScanOperator.Equal, "Big River");
            scanFilter.AddCondition("Score", ScanOperator.GreaterThan, 100);
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemainingAsync();
            Assert.Equal(1, items.Count);
        }

        private async Task TestExpressionsOnQueryHelper(ITable hashRangeTable)
        {
            Document doc1 = new Document
            {
                ["Name"] = "Gunnar",
                ["Age"] = 77,
                ["Job"] = "Retired"
            };
            await hashRangeTable.PutItemAsync(doc1);

            Document doc2 = new Document
            {
                ["Name"] = "Gunnar",
                ["Age"] = 45,
                ["Job"] = "Electrician"
            };
            await hashRangeTable.PutItemAsync(doc2);

            var expression = new Expression
            {
                ExpressionStatement = "Job = :job",
                ExpressionAttributeValues = { [":job"] = "Retired" }
            };

            var search = hashRangeTable.Query("Gunnar", expression);
            var docs = await search.GetRemainingAsync();
            Assert.Equal(1, docs.Count);
            Assert.Equal(77, docs[0]["Age"].AsInt());

            search = hashRangeTable.Query(new QueryOperationConfig
            {
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Gunnar"),
                FilterExpression = expression,
                AttributesToGet = new List<string> { "Age" },
                Select = SelectValues.SpecificAttributes
            });
            docs = await search.GetRemainingAsync();
            Assert.Equal(1, docs.Count);
            Assert.Equal(1, docs[0].Count);
            Assert.Equal(77, docs[0]["Age"].AsInt());

            await hashRangeTable.DeleteItemAsync(doc1);
            await hashRangeTable.DeleteItemAsync(doc2);
        }

        private async Task TestExpressionsOnScanHelper(ITable hashRangeTable)
        {
            await _fixture.ClearTable(_fixture.HashRangeTableName);

            Document doc1 = new Document
            {
                ["Name"] = "Lewis",
                ["Age"] = 6,
                ["School"] = "Elementary"
            };
            await hashRangeTable.PutItemAsync(doc1);

            Document doc2 = new Document
            {
                ["Name"] = "Frida",
                ["Age"] = 3,
                ["School"] = "Preschool"
            };
            await hashRangeTable.PutItemAsync(doc2);

            var expression = new Expression
            {
                ExpressionStatement = "Age > :age",
                ExpressionAttributeValues = { [":age"] = 5 }
            };

            var search = hashRangeTable.Scan(new ScanOperationConfig
            {
                FilterExpression = expression,
                ConsistentRead = true
            });
            var docs = await search.GetRemainingAsync();
            Assert.Equal(1, docs.Count);
            Assert.Equal("Elementary", docs[0]["School"].AsString());

            search = hashRangeTable.Scan(new ScanOperationConfig
            {
                FilterExpression = expression,
                Select = SelectValues.SpecificAttributes,
                AttributesToGet = new List<string> { "School" },
                ConsistentRead = true
            });
            docs = await search.GetRemainingAsync();
            Assert.Equal(1, docs.Count);
            Assert.Equal(1, docs[0].Count);
            Assert.Equal("Elementary", docs[0]["School"].AsString());

            await hashRangeTable.DeleteItemAsync(doc1);
            await hashRangeTable.DeleteItemAsync(doc2);
        }

        private async Task TestScanDocumentOperationRequestReturnConsumedCapacityHelper(ITable hashRangeTable)
        {
            await _fixture.ClearTable(_fixture.HashRangeTableName);

            var doc1 = new Document
            {
                ["Name"] = "Lewis",
                ["Age"] = 6,
                ["School"] = "Elementary",
                ["Company"] = "Big River",
                ["Score"] = 110,
                ["Manager"] = "Kirk"
            };
            await hashRangeTable.PutItemAsync(doc1);

            var doc2 = new Document
            {
                ["Name"] = "Frida",
                ["Age"] = 3,
                ["School"] = "Preschool",
                ["Company"] = "Big River",
                ["Score"] = 120,
                ["Manager"] = "Kirk"
            };
            await hashRangeTable.PutItemAsync(doc2);

            var expression = new Expression
            {
                ExpressionStatement = "Age > :age",
                ExpressionAttributeValues = { [":age"] = 5 }
            };

            var totalSearch = hashRangeTable.Scan(new ScanDocumentOperationRequest
            {
                FilterExpression = expression,
                ConsistentRead = true,
                ReturnConsumedCapacity = ReturnConsumedCapacity.TOTAL
            });

            var totalDocs = await totalSearch.GetRemainingAsync();
            Assert.Equal(1, totalDocs.Count);
            Assert.NotNull(totalSearch.Metrics);
            Assert.NotNull(totalSearch.Metrics.LastConsumedCapacity);
            Assert.True(totalSearch.Metrics.ConsumedCapacityHistory.Count > 0);
            Assert.True(totalSearch.Metrics.TotalCapacityUnits.HasValue || totalSearch.Metrics.TotalReadCapacityUnits.HasValue);

            ISearch indexSearch = null;
            List<Document> indexDocs = null;
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                indexSearch = hashRangeTable.Scan(new ScanDocumentOperationRequest
                {
                    FilterExpression = expression,
                    IndexName = "GlobalIndex",
                    ReturnConsumedCapacity = ReturnConsumedCapacity.INDEXES
                });
                indexDocs = await indexSearch.GetRemainingAsync();
                return indexDocs.Count == 1;
            }, sleepSeconds: 1, maxWaitSeconds: 10);
            Assert.Equal(1, indexDocs.Count);
            Assert.NotNull(indexSearch.Metrics);
            Assert.NotNull(indexSearch.Metrics.LastConsumedCapacity);
            Assert.True(indexSearch.Metrics.ConsumedCapacityHistory.Count > 0);
            Assert.NotNull(indexSearch.Metrics.LastConsumedCapacity.GlobalSecondaryIndexes);
            Assert.True(indexSearch.Metrics.LastConsumedCapacity.GlobalSecondaryIndexes.ContainsKey("GlobalIndex"));

            await hashRangeTable.DeleteItemAsync(doc1);
            await hashRangeTable.DeleteItemAsync(doc2);
        }

        private bool AreValuesEqual(Document docA, Document docB, DynamoDBEntryConversion conversion = null)
        {
            if (conversion != null)
            {
                docA = docA.ForceConversion(conversion);
                docB = docB.ForceConversion(conversion);
            }

            if (ReferenceEquals(docA, docB))
            {
                return true;
            }

            return docA.Equals(docB);
        }
    }
}
