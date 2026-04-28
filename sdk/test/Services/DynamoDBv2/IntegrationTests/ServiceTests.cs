using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class ServiceTests : IClassFixture<HashTablesFixture>, IAsyncLifetime
    {
        private readonly HashTablesFixture _fixture;

        public ServiceTests(HashTablesFixture fixture)
        {
            _fixture = fixture;
        }

        public async ValueTask InitializeAsync() => await _fixture.CleanupTables();

        public ValueTask DisposeAsync() => default;

        [Fact]
        public async Task TestDataCalls()
        {
            // Test hash-key table
            await TestHashTable(_fixture.HashTableName);

            // Test hash-and-range-key table
            await TestHashRangeTable(_fixture.HashRangeTableName);

            // Test batch gets and writes
            await TestBatchWriteGet(_fixture.HashTableName, _fixture.HashRangeTableName);

            // Test large batch gets and writes
            await TestLargeBatches(_fixture.HashTableName);
        }

        private async Task TestHashTable(string hashTableName)
        {
            // Put item
            var nonEmptyListAV = new AttributeValue
            {
                L = new List<AttributeValue>
                {
                    new AttributeValue { S = "Data" },
                    new AttributeValue { N = "12" }
                },
                // optional call to IsLSet = true, no-op
                IsLSet = true
            };
            Assert.Equal(2, nonEmptyListAV.L.Count);

            var emptyListAV = new AttributeValue
            {
                L = null,
                // call to IsLSet = true sets L to empty list. This is testing legacy behavior in V3 where
                // Users would explicit set IsLSet to confirm an empty array is sent to the request.
                IsLSet = true
            };
            Assert.Equal(0, emptyListAV.L.Count);

            // Create a new AttributeValue to confirm that the empty collection will be sent even
            // if IsLSet is not set.
            emptyListAV = new AttributeValue
            {
                L = new List<AttributeValue>()
            };
            Assert.Equal(0, emptyListAV.L.Count);

            var boolAV = new AttributeValue();
            Assert.False(boolAV.IsBOOLSet);
            boolAV.BOOL = false;
            Assert.True(boolAV.IsBOOLSet);

            await _fixture.Client.PutItemAsync(hashTableName, new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "1" } },
                { "Product", new AttributeValue { S = "CloudSpotter" } },
                { "Company", new AttributeValue { S = "CloudsAreGrate" } },
                { "Tags", new AttributeValue { SS = new List<string> { "Prod", "1.0" } } },
                { "Seller", new AttributeValue { S = "Big River" } },
                { "Price", new AttributeValue { N = "900" } },
                { "Null", new AttributeValue { NULL = true } },
                { "EmptyList", emptyListAV },
                { "NonEmptyList", nonEmptyListAV },
                { "EmptyMap", new AttributeValue { IsMSet = true } },
                { "BoolFalse", boolAV }
            });

            // Get item
            var key1 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "1" } }
            };
            var item = (await _fixture.Client.GetItemAsync(new GetItemRequest { TableName = hashTableName, Key = key1, ConsistentRead = true })).Item;

            // Verify empty collections and value type
            Assert.True(item["EmptyList"].IsLSet);
            Assert.False(item["EmptyList"].IsMSet);
            Assert.True(item["EmptyMap"].IsMSet);
            Assert.False(item["EmptyMap"].IsLSet);
            Assert.True(item["BoolFalse"].IsBOOLSet);
            Assert.False(item["BoolFalse"].BOOL.Value);
            Assert.True(item["NonEmptyList"].IsLSet);
            Assert.Equal(nonEmptyListAV.L.Count, item["NonEmptyList"].L.Count);

            // Get nonexistent item
            var key2 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "999" } }
            };
            var getItemResult = await _fixture.Client.GetItemAsync(new GetItemRequest { TableName = hashTableName, Key = key2, ConsistentRead = true });
            Assert.False(getItemResult.IsItemSet);

            // Get empty item
            getItemResult = await _fixture.Client.GetItemAsync(new GetItemRequest
            {
                TableName = hashTableName,
                Key = key1,
                ConsistentRead = true,
                ProjectionExpression = "Coffee"
            });
            Assert.True(getItemResult.IsItemSet);
            Assert.Equal(0, getItemResult.Item.Count);

            // Update item
            await _fixture.Client.UpdateItemAsync(hashTableName, key1, new Dictionary<string, AttributeValueUpdate>
            {
                { "Product", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudSpotter 2.0" } } },
                { "Seller", new AttributeValueUpdate { Action = AttributeAction.DELETE } },
                { "Tags", new AttributeValueUpdate { Action = AttributeAction.ADD, Value = new AttributeValue { SS = new List<string> { "2.0" } } } }
            });

            // Get updated item
            item = (await _fixture.Client.GetItemAsync(new GetItemRequest { TableName = hashTableName, Key = key1, ConsistentRead = true })).Item;
            Assert.True(item["Product"].S.IndexOf("2.0") >= 0);
            Assert.Equal(3, item["Tags"].SS.Count);
            Assert.False(item.ContainsKey("Seller"));

            // Scan all items
            var scanConditions = new Dictionary<string, Condition>
            {
                {
                    "Company",
                    new Condition
                    {
                        ComparisonOperator = ComparisonOperator.GE,
                        AttributeValueList = new List<AttributeValue>
                        {
                            new AttributeValue { S = "Cloud" }
                        }
                    }
                }
            };
            var items = await Scan(hashTableName, scanConditions);
            Assert.Equal(1, items.Count);

            // Update non-existent item
            key2 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "2" } }
            };
            await _fixture.Client.UpdateItemAsync(hashTableName, key2,
                new Dictionary<string, AttributeValueUpdate>
                {
                    { "Product", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudDebugger" } } },
                    { "Company", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudsAreGrate" } } },
                    { "Tags", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { SS = new List<string> { "Test" } } } },
                    { "Price", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { N = "42" } } }
                });

            // Get updated item
            item = (await _fixture.Client.GetItemAsync(new GetItemRequest { TableName = hashTableName, Key = key2, ConsistentRead = true })).Item;
            Assert.True(item["Product"].S.IndexOf("Debugger") >= 0);
            Assert.Equal(1, item["Tags"].SS.Count);
            Assert.False(item.ContainsKey("Seller"));

            // Scan all items
            items = await Scan(hashTableName, scanConditions);
            Assert.Equal(2, items.Count);

            // Query global index
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashTableName,
                IndexName = "GlobalIndex",
                KeyConditions = new Dictionary<string, Condition>
                {
                    // First Query condition must be HashKey EQ [Value]
                    {
                        "Company",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "CloudsAreGrate" } }
                        }
                    },
                    // Second Query condition must be RangeKey [Conditon] [Value]
                    {
                        "Price",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.GT,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { N = "50" } }
                        }
                    }
                }
            })).Items;
            Assert.Equal(1, items.Count);

            // Scan global index
            items = (await _fixture.Client.ScanAsync(new ScanRequest
            {
                TableName = hashTableName,
                IndexName = "GlobalIndex",
                ScanFilter = new Dictionary<string, Condition>
                {
                    // First condition will be HashKey EQ [Value]
                    {
                        "Company",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "CloudsAreGrate" } }
                        }
                    },
                    // Second condition will be RangeKey [Conditon] [Value]
                    {
                        "Price",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.GT,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { N = "50" } }
                        }
                    }
                }
            })).Items;
            Assert.Equal(1, items.Count);
        }

        private async Task TestHashRangeTable(string hashRangeTableName)
        {
            // Put items
            await _fixture.Client.PutItemAsync(hashRangeTableName, new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Alan" } },
                { "Age", new AttributeValue { N = "31" } },
                { "Company", new AttributeValue { S = "Big River" } },
                { "Score", new AttributeValue { N = "120" } },
                { "Manager", new AttributeValue { S = "Barbara"} }
            });
            await _fixture.Client.PutItemAsync(hashRangeTableName, new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Chuck" } },
                { "Age", new AttributeValue { N = "30" } },
                { "Company", new AttributeValue { S = "Big River" } },
                { "Score", new AttributeValue { N = "94" } },
                { "Manager", new AttributeValue { S = "Barbara"} }
            });
            await _fixture.Client.PutItemAsync(hashRangeTableName, new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Diane" } },
                { "Age", new AttributeValue { N = "40" } },
                { "Company", new AttributeValue { S = "Madeira" } },
                { "Score", new AttributeValue { N = "140" } },
                { "Manager", new AttributeValue { S = "Eva"} }
            });
            await _fixture.Client.PutItemAsync(hashRangeTableName, new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Diane" } },
                { "Age", new AttributeValue { N = "24" } },
                { "Company", new AttributeValue { S = "Madeira" } },
                { "Score", new AttributeValue { N = "101" } },
                { "Manager", new AttributeValue { S = "Francis"} }
            });

            // Scan all items
            var scanConditions = new Dictionary<string, Condition>
            {
                {
                    "Company",
                    new Condition
                    {
                        ComparisonOperator = ComparisonOperator.GE,
                        AttributeValueList = new List<AttributeValue>
                        {
                            new AttributeValue { S = "Big" }
                        }
                    }
                }
            };
            var items = await Scan(hashRangeTableName, scanConditions);
            Assert.Equal(4, items.Count);

            // Scan in parallel
            items = await ParallelScan(hashRangeTableName, segments: 2, conditions: scanConditions);
            Assert.Equal(4, items.Count);

            // Query table with no range-key condition
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashRangeTableName,
                KeyConditions = new Dictionary<string, Condition>
                {
                    // First Query condition must be HashKey EQ [Value]
                    {
                        "Name",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Diane" } }
                        }
                    },
                }
            })).Items;
            Assert.Equal(2, items.Count);

            // Query table with no range-key condition and no returned attributes
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashRangeTableName,
                KeyConditions = new Dictionary<string, Condition>
                {
                    // First Query condition must be HashKey EQ [Value]
                    {
                        "Name",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Diane" } }
                        }
                    },
                },
                ProjectionExpression = "Coffee"
            })).Items;
            Assert.Equal(2, items.Count);
            Assert.Equal(0, items[0].Count);
            Assert.Equal(0, items[1].Count);

            // Query table with hash-key condition expression
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashRangeTableName,
                KeyConditionExpression = "#H = :val",
                ExpressionAttributeNames = new Dictionary<string, string>
                {
                    { "#H", "Name"}
                },
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    { ":val", new AttributeValue { S = "Diane" } }
                }
            })).Items;
            Assert.Equal(2, items.Count);

            // Query table with key condition expression
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashRangeTableName,
                KeyConditionExpression = "#H = :name and #R > :age",
                ExpressionAttributeNames = new Dictionary<string, string>
                {
                    { "#H", "Name" },
                    { "#R", "Age" }
                },
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    { ":name", new AttributeValue { S = "Diane" } },
                    { ":age", new AttributeValue { N = "30" } }
                }
            })).Items;
            Assert.Equal(1, items.Count);

            // Query global index
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashRangeTableName,
                IndexName = "GlobalIndex",
                KeyConditions = new Dictionary<string, Condition>
                {
                    // First Query condition must be HashKey EQ [Value]
                    {
                        "Company",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Big River" } }
                        }
                    },
                    // Second Query condition must be RangeKey [Conditon] [Value]
                    {
                        "Score",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.GT,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { N = "100" } }
                        }
                    }
                }
            })).Items;
            Assert.Equal(1, items.Count);

            // Query local index with no range-key condition
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashRangeTableName,
                IndexName = "LocalIndex",
                KeyConditions = new Dictionary<string, Condition>
                {
                    // First Query condition must be HashKey EQ [Value]
                    {
                        "Name",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Diane" } }
                        }
                    },
                }
            })).Items;
            Assert.Equal(2, items.Count);

            // Query local index with range-key condition
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashRangeTableName,
                IndexName = "LocalIndex",
                KeyConditions = new Dictionary<string, Condition>
                {
                    // First Query condition must be HashKey EQ [Value]
                    {
                        "Name",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Diane" } }
                        }
                    },
                    // Second Query condition must be RangeKey [Conditon] [Value]
                    {
                        "Manager",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Francis" } }
                        }
                    }
                }
            })).Items;
            Assert.Equal(1, items.Count);

            // Query local index with a query filter
            items = (await _fixture.Client.QueryAsync(new QueryRequest
            {
                TableName = hashRangeTableName,
                IndexName = "LocalIndex",
                KeyConditions = new Dictionary<string, Condition>
                {
                    // First Query condition must be HashKey EQ [Value]
                    {
                        "Name",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Diane" } }
                        }
                    }
                },
                QueryFilter = new Dictionary<string, Condition>
                {
                    // QueryFilter conditions must be non-key attributes
                    {
                        "Score",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.GT,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { N = "120" } }
                        }
                    }
                }
            })).Items;
            Assert.Equal(1, items.Count);

            // Scan global index
            items = (await _fixture.Client.ScanAsync(new ScanRequest
            {
                TableName = hashRangeTableName,
                IndexName = "GlobalIndex",
                ScanFilter = new Dictionary<string, Condition>
                {
                    // First condition will be HashKey EQ [Value]
                    {
                        "Company",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Big River" } }
                        }
                    },
                    // Second condition will be RangeKey [Conditon] [Value]
                    {
                        "Score",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.GT,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { N = "100" } }
                        }
                    }
                }
            })).Items;
            Assert.Equal(1, items.Count);

            // Scan local index with no range-key condition
            items = (await _fixture.Client.ScanAsync(new ScanRequest
            {
                TableName = hashRangeTableName,
                IndexName = "LocalIndex",
                ScanFilter = new Dictionary<string, Condition>
                {
                    // First condition will be HashKey EQ [Value]
                    {
                        "Name",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Diane" } }
                        }
                    },
                }
            })).Items;
            Assert.Equal(2, items.Count);

            // Scan local index with range-key condition
            items = (await _fixture.Client.ScanAsync(new ScanRequest
            {
                TableName = hashRangeTableName,
                IndexName = "LocalIndex",
                ScanFilter = new Dictionary<string, Condition>
                {
                    // First condition will be HashKey EQ [Value]
                    {
                        "Name",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Diane" } }
                        }
                    },
                    // Second condition will be RangeKey [Conditon] [Value]
                    {
                        "Manager",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Francis" } }
                        }
                    }
                }
            })).Items;
            Assert.Equal(1, items.Count);

            // Scan local index with a non-key condition
            items = (await _fixture.Client.ScanAsync(new ScanRequest
            {
                TableName = hashRangeTableName,
                IndexName = "LocalIndex",
                ScanFilter = new Dictionary<string, Condition>
                {
                    // First condition will be HashKey EQ [Value]
                    {
                        "Name",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.EQ,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { S = "Diane" } }
                        }
                    },
                    // Non-key attributes condition
                    {
                        "Score",
                        new Condition
                        {
                            ComparisonOperator = ComparisonOperator.GT,
                            AttributeValueList = new List<AttributeValue> { new AttributeValue { N = "120" } }
                        }
                    }
                }
            })).Items;
            Assert.Equal(1, items.Count);
        }

        private async Task TestBatchWriteGet(string hashTableName, string hashRangeTableName)
        {
            // Put 1 item and delete 2 items across 2 tables
            await _fixture.Client.BatchWriteItemAsync(new Dictionary<string, List<WriteRequest>>
            {
                {
                    hashTableName,
                    new List<WriteRequest>
                    {
                        new WriteRequest
                        {
                            PutRequest = new PutRequest
                            {
                                Item = new Dictionary<string,AttributeValue>
                                {
                                    { "Id", new AttributeValue { N = "6" } },
                                    { "Product", new AttributeValue { S = "CloudVerifier" } },
                                    { "Company", new AttributeValue { S = "CloudsAreGrate" } },
                                }
                            }
                        },
                        new WriteRequest
                        {
                            DeleteRequest = new DeleteRequest
                            {
                                Key = new Dictionary<string,AttributeValue>
                                {
                                    { "Id", new AttributeValue { N = "2" } }
                                }
                            }
                        }
                    }
                },
                {
                    hashRangeTableName,
                    new List<WriteRequest>
                    {
                        new WriteRequest
                        {
                            DeleteRequest = new DeleteRequest
                            {
                                Key = new Dictionary<string,AttributeValue>
                                {
                                    { "Name", new AttributeValue { S = "Diane" } },
                                    { "Age", new AttributeValue { N = "24" } },
                                }
                            }
                        }
                    }
                }
            });

            // Get 5 items across 2 tables
            var batchGetResult = await _fixture.Client.BatchGetItemAsync(new Dictionary<string, KeysAndAttributes>
            {
                {
                    hashTableName,
                    new KeysAndAttributes
                    {
                        Keys = new List<Dictionary<string,AttributeValue>>
                        {
                            new Dictionary<string, AttributeValue>
                            {
                                { "Id", new AttributeValue { N = "1" } }
                            },
                            new Dictionary<string, AttributeValue>
                            {
                                { "Id", new AttributeValue { N = "6" } }
                            }
                        }
                    }
                },
                {
                    hashRangeTableName,
                    new KeysAndAttributes
                    {
                        Keys = new List<Dictionary<string,AttributeValue>>
                        {
                            new Dictionary<string, AttributeValue>
                            {
                                { "Name", new AttributeValue { S = "Alan" } },
                                { "Age", new AttributeValue { N = "31" } }
                            },
                            new Dictionary<string, AttributeValue>
                            {
                                { "Name", new AttributeValue { S = "Chuck" } },
                                { "Age", new AttributeValue { N = "30" } }
                            },
                            new Dictionary<string, AttributeValue>
                            {
                                { "Name", new AttributeValue { S = "Diane" } },
                                { "Age", new AttributeValue { N = "40" } }
                            }
                        }
                    }
                }
            });

            var tableItems = batchGetResult.Responses;
            var hashItems = tableItems[hashTableName];
            var hashRangeItems = tableItems[hashRangeTableName];

            Assert.Equal(2, hashItems.Count);
            Assert.Equal(3, hashRangeItems.Count);
        }

        private async Task TestLargeBatches(string hashTableName)
        {
            int itemSize = 60 * 1024;
            Assert.True(itemSize < DynamoDBFixture.MaxItemSize);
            int itemCount = 25;

            // DynamoDB allows 1MB of data per operation, so itemSize * writeBatchSize < 1MB
            int writeBatchSize = (int)Math.Floor((decimal)DynamoDBFixture.OneMB / (decimal)itemSize);

            // Write large items to table in small batches
            List<string> itemIds = new List<string>();
            for (int i = 0; i < itemCount; i += writeBatchSize)
            {
                // Use itemCount - i so the last batch only writes the remaining items,
                // avoiding writing more items than itemCount total.
                int batchCount = Math.Min(writeBatchSize, itemCount - i);
                var writtenIds = await WriteBigBatch(hashTableName, batchCount, i, itemSize);
                itemIds.AddRange(writtenIds);
            }

            // Get large items from table in 1MB batches
            for (int i = 0; i < itemCount; i += DynamoDBFixture.MaxBatchSize)
            {
                // Use itemCount - i so the last batch only reads the remaining items.
                List<string> itemsToGet = itemIds.GetRange(i, Math.Min(DynamoDBFixture.MaxBatchSize, itemCount - i));
                if (itemsToGet.Count > 0)
                {
                    int itemsRetrieved = await GetBigBatch(hashTableName, itemsToGet);
                    Assert.Equal(itemsToGet.Count, itemsRetrieved);
                }
            }
        }

        private async Task<List<string>> WriteBigBatch(string hashTableName, int items, int itemsStartingIndex, int itemSize)
        {
            var itemData = new string('@', itemSize);
            var itemIds = new List<string>();
            var writeRequests = new List<WriteRequest>();

            for (int i = 0; i < items; i++)
            {
                var itemId = (itemsStartingIndex + i).ToString();
                itemIds.Add(itemId);

                var writeRequest = new WriteRequest
                {
                    PutRequest = new PutRequest
                    {
                        Item = new Dictionary<string, AttributeValue>
                        {
                            { "Id", new AttributeValue { N = itemId } },
                            { "Data", new AttributeValue { S = itemData }}
                        }
                    }
                };
                writeRequests.Add(writeRequest);
            }

            var request = new BatchWriteItemRequest
            {
                RequestItems = new Dictionary<string, List<WriteRequest>>
                {
                    { hashTableName, writeRequests }
                }
            };
            BatchWriteItemResponse result;

            do
            {
                result = await _fixture.Client.BatchWriteItemAsync(request);
                request.RequestItems = result.UnprocessedItems;
            } while (result.UnprocessedItems != null && result.UnprocessedItems.Count > 0);

            return itemIds;
        }

        private async Task<int> GetBigBatch(string hashTableName, List<string> idsToGet)
        {
            var keys = new List<Dictionary<string, AttributeValue>>();
            foreach (var id in idsToGet)
            {
                keys.Add(new Dictionary<string, AttributeValue>
                {
                    { "Id", new AttributeValue { N = id } }
                });
            }

            var request = new BatchGetItemRequest
            {
                RequestItems = new Dictionary<string, KeysAndAttributes>
                {
                    { hashTableName, new KeysAndAttributes { Keys = keys, ConsistentRead = true } }
                }
            };

            BatchGetItemResponse result;
            int itemsRetrieved = 0;
            do
            {
                result = await _fixture.Client.BatchGetItemAsync(request);
                itemsRetrieved += result.Responses[hashTableName].Count;

                request.RequestItems = result.UnprocessedKeys;
            } while (result.UnprocessedKeys != null && result.UnprocessedKeys.Count > 0);

            return itemsRetrieved;
        }

        private async Task<List<Dictionary<string, AttributeValue>>> Scan(string tableName, Dictionary<string, Condition> conditions)
        {
            return (await ScanHelper(tableName, conditions)).ToList();
        }

        private async Task<List<Dictionary<string, AttributeValue>>> ParallelScan(string tableName, int segments, Dictionary<string, Condition> conditions)
        {
            var allItems = new List<Dictionary<string, AttributeValue>>();
            for (int i = 0; i < segments; i++)
            {
                var segmentResults = await ScanHelper(tableName, conditions, i, segments);
                allItems.AddRange(segmentResults);
            }

            return allItems;
        }

        private async Task<IEnumerable<Dictionary<string, AttributeValue>>> ScanHelper(string tableName, Dictionary<string, Condition> conditions, int? segment = null, int? totalSegments = null)
        {
            var request = new ScanRequest
            {
                TableName = tableName,
                ScanFilter = conditions,
                Limit = DynamoDBFixture.ScanLimit,
                ConsistentRead = true,
            };

            if (segment.HasValue && totalSegments.HasValue)
            {
                request.Segment = segment.Value;
                request.TotalSegments = totalSegments.Value;
            }

            var items = new List<Dictionary<string, AttributeValue>>();

            ScanResponse result;
            do
            {
                result = await _fixture.Client.ScanAsync(request);
                if (result.Items != null)
                {
                    items.AddRange(result.Items);
                }
                request.ExclusiveStartKey = result.LastEvaluatedKey;
            } while (result.LastEvaluatedKey != null && result.LastEvaluatedKey.Count > 0);

            return items;
        }
    }
}
