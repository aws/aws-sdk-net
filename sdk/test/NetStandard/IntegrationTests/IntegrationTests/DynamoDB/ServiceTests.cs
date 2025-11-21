using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;

using Xunit;

namespace Amazon.DNXCore.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : IClassFixture<DynamoDBTestsFixture>
    {
        [Fact]
        [Trait(CategoryAttribute, "DynamoDB")]
        public async Task TestDataCalls()
        {
            await SharedTestFixture.CleanupTables();

            // Test hash-key table
            await TestHashTable(SharedTestFixture.hashTableName);

            // Test hash-and-range-key table
            await TestHashRangeTable(SharedTestFixture.hashRangeTableName);

            // Test batch gets and writes
            await TestBatchWriteGet(SharedTestFixture.hashTableName, SharedTestFixture.hashRangeTableName);

            // Test large batch gets and writes
            await TestLargeBatches(SharedTestFixture.hashTableName);
        }

        private async Task TestHashTable(string hashTableName)
        {
            // Put item
            var nonEmptyListAV = new AttributeValue();
            nonEmptyListAV.L = new List<AttributeValue>
            {
                new AttributeValue { S = "Data" },
                new AttributeValue { N = "12" }
            };
            // optional call to IsLSet = true, no-op
            nonEmptyListAV.IsLSet = true;
            Assert.Equal(2, nonEmptyListAV.L.Count);

            var emptyListAV = new AttributeValue();
            emptyListAV.L = null;
            // call to IsLSet = true sets L to empty list
            emptyListAV.IsLSet = true;
            Assert.Empty(emptyListAV.L);
            emptyListAV.L = new List<AttributeValue>();
            // call to IsLSet = true sets L to empty list
            emptyListAV.IsLSet = true;
            Assert.Empty(emptyListAV.L);

            var boolAV = new AttributeValue();
            Assert.False(boolAV.IsBOOLSet);
            boolAV.BOOL = false;
            Assert.True(boolAV.IsBOOLSet);

            await Client.PutItemAsync(hashTableName, new Dictionary<string, AttributeValue>
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
            var item = (await Client.GetItemAsync(hashTableName, key1)).Item;

            // Verify empty collections and value type
            Assert.True(item["EmptyList"].IsLSet);
            Assert.False(item["EmptyList"].IsMSet);
            Assert.True(item["EmptyMap"].IsMSet);
            Assert.False(item["EmptyMap"].IsLSet);
            Assert.True(item["BoolFalse"].IsBOOLSet);
            Assert.False(item["BoolFalse"].BOOL);
            Assert.True(item["NonEmptyList"].IsLSet);
            Assert.Equal(nonEmptyListAV.L.Count, item["NonEmptyList"].L.Count);

            // Get nonexistent item
            var key2 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "999" } }
            };
            var getItemResult = await Client.GetItemAsync(hashTableName, key2);
            Assert.False(getItemResult.IsItemSet);

            // Get empty item
            getItemResult = await Client.GetItemAsync(new GetItemRequest
            {
                TableName = hashTableName,
                Key = key1,
                ProjectionExpression = "Coffee"
            });
            Assert.True(getItemResult.IsItemSet);
            Assert.Empty(getItemResult.Item);

            // Update item
            await Client.UpdateItemAsync(hashTableName, key1, new Dictionary<string, AttributeValueUpdate>
            {
                { "Product", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudSpotter 2.0" } } },
                { "Seller", new AttributeValueUpdate { Action = AttributeAction.DELETE } },
                { "Tags", new AttributeValueUpdate { Action = AttributeAction.ADD, Value = new AttributeValue { SS = new List<string> { "2.0" } } } }
            });

            // Get updated item
            item = (await Client.GetItemAsync(hashTableName, key1)).Item;
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
            var items = Scan(hashTableName, scanConditions);
            Assert.Single(items);

            // Update non-existent item
            key2 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "2" } }
            };
            await Client.UpdateItemAsync(hashTableName, key2,
                new Dictionary<string, AttributeValueUpdate>
                {
                    { "Product", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudDebugger" } } },
                    { "Company", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudsAreGrate" } } },
                    { "Tags", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { SS = new List<string> { "Test" } } } },
                    { "Price", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { N = "42" } } }
                });

            // Get updated item
            item = (await Client.GetItemAsync(hashTableName, key2)).Item;
            Assert.True(item["Product"].S.IndexOf("Debugger") >= 0);
            Assert.Single(item["Tags"].SS);
            Assert.False(item.ContainsKey("Seller"));

            // Scan all items
            items = Scan(hashTableName, scanConditions);
            Assert.Equal(2, items.Count);

            // Query global index
            items = (await Client.QueryAsync(new QueryRequest
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
            Assert.Single(items);

            // Scan global index
            items = (await Client.ScanAsync(new ScanRequest
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
            Assert.Single(items);

        }
        private async Task TestHashRangeTable(string hashRangeTableName)
        {
            // Put items
            await Client.PutItemAsync(hashRangeTableName, new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Alan" } },
                { "Age", new AttributeValue { N = "31" } },
                { "Company", new AttributeValue { S = "Big River" } },
                { "Score", new AttributeValue { N = "120" } },
                { "Manager", new AttributeValue { S = "Barbara"} }
            });
            await Client.PutItemAsync(hashRangeTableName, new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Chuck" } },
                { "Age", new AttributeValue { N = "30" } },
                { "Company", new AttributeValue { S = "Big River" } },
                { "Score", new AttributeValue { N = "94" } },
                { "Manager", new AttributeValue { S = "Barbara"} }
            });
            await Client.PutItemAsync(hashRangeTableName, new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Diane" } },
                { "Age", new AttributeValue { N = "40" } },
                { "Company", new AttributeValue { S = "Madeira" } },
                { "Score", new AttributeValue { N = "140" } },
                { "Manager", new AttributeValue { S = "Eva"} }
            });
            await Client.PutItemAsync(hashRangeTableName, new Dictionary<string, AttributeValue>
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
            var items = Scan(hashRangeTableName, scanConditions);
            Assert.Equal(4, items.Count);

            // Scan in parallel
            items = ParallelScan(hashRangeTableName, segments: 2, conditions: scanConditions);
            Assert.Equal(4, items.Count);

            // Query table with no range-key condition
            items = (await Client.QueryAsync(new QueryRequest
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
            items = (await Client.QueryAsync(new QueryRequest
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
            Assert.Empty(items[0]);
            Assert.Empty(items[1]);

            // Query table with hash-key condition expression
            items = (await Client.QueryAsync(new QueryRequest
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
            items = (await Client.QueryAsync(new QueryRequest
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
            Assert.Single(items);

            // Query global index
            items = (await Client.QueryAsync(new QueryRequest
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
            Assert.Single(items);

            // Query local index with no range-key condition
            items = (await Client.QueryAsync(new QueryRequest
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
            items = (await Client.QueryAsync(new QueryRequest
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

            // Query local index with a query filter
            items = (await Client.QueryAsync(new QueryRequest
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
            Assert.Single(items);

            // Scan global index
            items = (await Client.ScanAsync(new ScanRequest
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
            Assert.Single(items);

            // Scan local index with no range-key condition
            items = (await Client.ScanAsync(new ScanRequest
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
            items = (await Client.ScanAsync(new ScanRequest
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

            // Scan local index with a non-key condition
            items = (await Client.ScanAsync(new ScanRequest
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
            Assert.Single(items);

        }
        private async Task TestBatchWriteGet(string hashTableName, string hashRangeTableName)
        {
            // Put 1 item and delete 2 items across 2 tables
            await Client.BatchWriteItemAsync(new Dictionary<string, List<WriteRequest>>
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
            var batchGetResult = await Client.BatchGetItemAsync(new Dictionary<string, KeysAndAttributes>
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
            Assert.True(itemSize < DynamoDBTestsFixture.MaxItemSize);
            int itemCount = 25;

            // DynamoDB allows 1MB of data per operation, so itemSize * writeBatchSize < 1MB
            int writeBatchSize = (int)Math.Floor((decimal)DynamoDBTestsFixture.OneMB / (decimal)itemSize);

            // Write large items to table in small batches
            List<string> itemIds = new List<string>();
            for (int i = 0; i < itemCount; i += writeBatchSize)
            {
                var writtenIds = await WriteBigBatch(hashTableName, writeBatchSize, i, itemSize);
                itemIds.AddRange(writtenIds);
            }

            // Get large items from table in 1MB batches
            for (int i = 0; i < itemCount; i += DynamoDBTestsFixture.MaxBatchSize)
            {
                List<string> itemsToGet = itemIds.GetRange(i, DynamoDBTestsFixture.MaxBatchSize);
                if (itemsToGet.Count > 0)
                {
                    int itemsRetrieved = await GetBigBatch(SharedTestFixture.hashTableName, itemsToGet);
                    Assert.Equal(itemsRetrieved, itemsToGet.Count);
                }
            }
        }

        private async Task<List<string>> WriteBigBatch(string hashTableName, int items, int itemsStartingIndex, int itemSize)
        {
            List<string> itemIds = new List<string>();
            string itemData = new string('@', itemSize);

            List<WriteRequest> writeRequests = new List<WriteRequest>();
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
                result = await Client.BatchWriteItemAsync(request);
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
                    { hashTableName, new KeysAndAttributes { Keys = keys } }
                }
            };
            BatchGetItemResponse result;

            int itemsRetrieved = 0;
            do
            {
                result = await Client.BatchGetItemAsync(request);
                itemsRetrieved += result.Responses[hashTableName].Count;

                request.RequestItems = result.UnprocessedKeys;
            } while (result.UnprocessedKeys != null && result.UnprocessedKeys.Count > 0);

            return itemsRetrieved;
        }

        private List<string> GetTableNames()
        {
            return GetTableNamesHelper().ToList();
        }
        private IEnumerable<string> GetTableNamesHelper()
        {
            var request = new ListTablesRequest();
            ListTablesResponse response;
            do
            {
                response = Client.ListTablesAsync(request).Result;
                foreach (var tableName in response.TableNames)
                    yield return tableName;

                request.ExclusiveStartTableName = response.LastEvaluatedTableName;
            } while (!string.IsNullOrEmpty(response.LastEvaluatedTableName));
        }

        private List<Dictionary<string, AttributeValue>> Scan(string tableName, Dictionary<string, Condition> conditions)
        {
            return ScanHelper(tableName, conditions).ToList();
        }
        private List<Dictionary<string, AttributeValue>> ParallelScan(string tableName, int segments, Dictionary<string, Condition> conditions)
        {
            var allItems = new List<Dictionary<string, AttributeValue>>();
            for (int i = 0; i < segments; i++)
            {
                var segmentResults = ScanHelper(tableName, conditions, i, segments);
                allItems.AddRange(segmentResults);
            }

            return allItems;
        }
        private IEnumerable<Dictionary<string, AttributeValue>> ScanHelper(string tableName, Dictionary<string, Condition> conditions, int? segment = null, int? totalSegments = null)
        {
            var request = new ScanRequest
            {
                TableName = tableName,
                ScanFilter = conditions,
                Limit = DynamoDBTestsFixture.ScanLimit,
            };
            if (segment.HasValue && totalSegments.HasValue)
            {
                request.Segment = segment.Value;
                request.TotalSegments = totalSegments.Value;
            }

            ScanResponse result;
            do
            {
                result = Client.ScanAsync(request).Result;
                foreach (var item in result.Items)
                    yield return item;
                request.ExclusiveStartKey = result.LastEvaluatedKey;
            } while (result.LastEvaluatedKey != null && result.LastEvaluatedKey.Count > 0);
        }


    }
}
