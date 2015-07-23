using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using CommonTests.Framework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace CommonTests.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [Test]
        [Category("DynamoDB")]
        public void TestTableCalls()
        {
            RunAsSync(async () =>
            {
                // Only run these tests if we are not reusing tables
                if (ReuseTables)
                    return;
#pragma warning disable 162
                await TestTableCallsAsync();
#pragma warning restore 162

            });
        }

        private async Task TestTableCallsAsync()
        {
            var tables = GetTableNames();
            int tableCount = tables.Count;

            // Create hash-key table
            var table1Name = TableNamePrefix + "Table1";
            await Client.CreateTableAsync(
                table1Name,
                new List<KeySchemaElement>
                    {
                        new KeySchemaElement { KeyType = KeyType.HASH, AttributeName = "Id" }
                    },
                new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.N }
                    },
                new ProvisionedThroughput { ReadCapacityUnits = DefaultReadCapacity, WriteCapacityUnits = DefaultWriteCapacity });
            CreatedTables.Add(table1Name);

            // Create hash-and-range-key table
            var table2Name = TableNamePrefix + "Table2";
            await Client.CreateTableAsync(
                table2Name,
                new List<KeySchemaElement>
                    {
                        new KeySchemaElement { AttributeName = "Id", KeyType = KeyType.HASH },
                        new KeySchemaElement { AttributeName = "Name", KeyType = KeyType.RANGE }
                    },
                new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.N },
                        new AttributeDefinition { AttributeName = "Name", AttributeType = ScalarAttributeType.S }
                    },
                new ProvisionedThroughput { ReadCapacityUnits = DefaultReadCapacity, WriteCapacityUnits = DefaultWriteCapacity });
            CreatedTables.Add(table2Name);

            // Create hash-key table with global index
            var table3Name = TableNamePrefix + "Table3";
            await Client.CreateTableAsync(new CreateTableRequest
            {
                TableName = table3Name,
                AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.N },
                        new AttributeDefinition { AttributeName = "Company", AttributeType = ScalarAttributeType.S },
                        new AttributeDefinition { AttributeName = "Price", AttributeType = ScalarAttributeType.N }
                    },
                KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { KeyType = KeyType.HASH, AttributeName = "Id" }
                    },
                GlobalSecondaryIndexes = new List<GlobalSecondaryIndex>
                    {
                        new GlobalSecondaryIndex
                        {
                            IndexName = "GlobalIndex",
                            KeySchema = new List<KeySchemaElement>
                            {
                                new KeySchemaElement { AttributeName = "Company", KeyType = KeyType.HASH },
                                new KeySchemaElement { AttributeName = "Price", KeyType = KeyType.RANGE }
                            },
                            ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = 1, WriteCapacityUnits = 1 },
                            Projection = new Projection { ProjectionType = ProjectionType.ALL }
                        }
                    },
                ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = DefaultReadCapacity, WriteCapacityUnits = DefaultWriteCapacity },
            });
            CreatedTables.Add(table3Name);

            // Wait for tables to be ready before creating another table with an index
            WaitForTableStatus(Client, CreatedTables, TableStatus.ACTIVE);

            // Create hash-and-range-key table with local and global indexes
            var table4Name = TableNamePrefix + "Table4";
            await Client.CreateTableAsync(new CreateTableRequest
            {
                TableName = table4Name,
                AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.N },
                        new AttributeDefinition { AttributeName = "Name", AttributeType = ScalarAttributeType.S },
                        new AttributeDefinition { AttributeName = "Company", AttributeType = ScalarAttributeType.S },
                        new AttributeDefinition { AttributeName = "Price", AttributeType = ScalarAttributeType.N },
                        new AttributeDefinition { AttributeName = "Manager", AttributeType = ScalarAttributeType.S }
                    },
                KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { AttributeName = "Id", KeyType = KeyType.HASH },
                        new KeySchemaElement { AttributeName = "Name", KeyType = KeyType.RANGE }
                    },
                GlobalSecondaryIndexes = new List<GlobalSecondaryIndex>
                    {
                        new GlobalSecondaryIndex
                        {
                            IndexName = "GlobalIndex",
                            KeySchema = new List<KeySchemaElement>
                            {
                                new KeySchemaElement { AttributeName = "Company", KeyType = KeyType.HASH },
                                new KeySchemaElement { AttributeName = "Price", KeyType = KeyType.RANGE }
                            },
                            ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = 1, WriteCapacityUnits = 1 },
                            Projection = new Projection { ProjectionType = ProjectionType.ALL }
                        }
                    },
                LocalSecondaryIndexes = new List<LocalSecondaryIndex> 
                    {
                        new LocalSecondaryIndex
                        {
                            IndexName = "LocalIndex",
                            KeySchema = new List<KeySchemaElement>
                            {
                                new KeySchemaElement { AttributeName = "Id", KeyType = KeyType.HASH },
                                new KeySchemaElement { AttributeName = "Manager", KeyType = KeyType.RANGE }
                            },
                            Projection = new Projection
                            {
                                ProjectionType = ProjectionType.INCLUDE,
                                NonKeyAttributes = new List<string> { "Company", "Price" }
                            }
                        }
                    },
                ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = DefaultReadCapacity, WriteCapacityUnits = DefaultWriteCapacity },
            });
            CreatedTables.Add(table4Name);

            tables = GetTableNames();
            Assert.AreEqual(tableCount + 4, tables.Count);

            // Wait for tables to be ready
            WaitForTableStatus(Client, CreatedTables, TableStatus.ACTIVE);

            // Update throughput for a table
            await Client.UpdateTableAsync(
                table2Name,
                new ProvisionedThroughput
                {
                    ReadCapacityUnits = DefaultReadCapacity * 2,
                    WriteCapacityUnits = DefaultWriteCapacity * 2
                });

            // Wait for tables to be ready
            WaitForTableStatus(Client, CreatedTables, TableStatus.ACTIVE);

            // Delete new tables
            await Client.DeleteTableAsync(table1Name);
            await Client.DeleteTableAsync(table2Name);
            await Client.DeleteTableAsync(table3Name);
            await Client.DeleteTableAsync(table4Name);

            // Wait for tables to be deleted
            WaitForTableStatus(Client, new string[] { table1Name, table2Name, table3Name, table4Name }, null);

            // Count tables again
            tables = GetTableNames();
            Assert.AreEqual(tableCount, tables.Count);

            CreatedTables.Remove(table1Name);
            CreatedTables.Remove(table2Name);
            CreatedTables.Remove(table3Name);
            CreatedTables.Remove(table4Name);
        }

        [Test]
        public void TestDataCalls()
        {
            RunAsSync(async () =>
            {
                // Test hash-key table
                await TestHashTable(hashTableName);

                // Test hash-and-range-key table
                await TestHashRangeTable(hashRangeTableName);

                // Test batch gets and writes
                await TestBatchWriteGet(hashTableName, hashRangeTableName);

                // Test large batch gets and writes
                await TestLargeBatches(hashTableName);
            });
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
            Assert.AreEqual(2, nonEmptyListAV.L.Count);

            var emptyListAV = new AttributeValue();
            emptyListAV.L = null;
            // call to IsLSet = true sets L to empty list
            emptyListAV.IsLSet = true;
            Assert.AreEqual(0, emptyListAV.L.Count);
            emptyListAV.L = new List<AttributeValue>();
            // call to IsLSet = true sets L to empty list
            emptyListAV.IsLSet = true;
            Assert.AreEqual(0, emptyListAV.L.Count);

            var boolAV = new AttributeValue();
            Assert.IsFalse(boolAV.IsBOOLSet);
            boolAV.BOOL = false;
            Assert.IsTrue(boolAV.IsBOOLSet);

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
            Assert.IsTrue(item["EmptyList"].IsLSet);
            Assert.IsFalse(item["EmptyList"].IsMSet);
            Assert.IsTrue(item["EmptyMap"].IsMSet);
            Assert.IsFalse(item["EmptyMap"].IsLSet);
            Assert.IsTrue(item["BoolFalse"].IsBOOLSet);
            Assert.IsFalse(item["BoolFalse"].BOOL);
            Assert.IsTrue(item["NonEmptyList"].IsLSet);
            Assert.AreEqual(nonEmptyListAV.L.Count, item["NonEmptyList"].L.Count);

            // Get nonexistent item
            var key2 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "999" } }
            };
            var getItemResult = await Client.GetItemAsync(hashTableName, key2);
            Assert.IsFalse(getItemResult.IsItemSet);

            // Get empty item
            getItemResult = await Client.GetItemAsync(new GetItemRequest
            {
                TableName = hashTableName,
                Key = key1,
                ProjectionExpression = "Coffee"
            });
            Assert.IsTrue(getItemResult.IsItemSet);
            Assert.AreEqual(0, getItemResult.Item.Count);

            // Update item
            await Client.UpdateItemAsync(hashTableName, key1, new Dictionary<string, AttributeValueUpdate>
            {
                { "Product", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudSpotter 2.0" } } },
                { "Seller", new AttributeValueUpdate { Action = AttributeAction.DELETE } },
                { "Tags", new AttributeValueUpdate { Action = AttributeAction.ADD, Value = new AttributeValue { SS = new List<string> { "2.0" } } } }
            });

            // Get updated item
            item = (await Client.GetItemAsync(hashTableName, key1)).Item;
            Assert.IsTrue(item["Product"].S.IndexOf("2.0") >= 0);
            Assert.AreEqual(3, item["Tags"].SS.Count);
            Assert.IsFalse(item.ContainsKey("Seller"));

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
            Assert.AreEqual(1, items.Count);

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
            Assert.IsTrue(item["Product"].S.IndexOf("Debugger") >= 0);
            Assert.AreEqual(1, item["Tags"].SS.Count);
            Assert.IsFalse(item.ContainsKey("Seller"));

            // Scan all items
            items = await Scan(hashTableName, scanConditions);
            Assert.AreEqual(2, items.Count);

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
            Assert.AreEqual(1, items.Count);

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
            Assert.AreEqual(1, items.Count);

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
            var items = await Scan(hashRangeTableName, scanConditions);
            Assert.AreEqual(4, items.Count);

            // Scan in parallel
            items = await ParallelScan(hashRangeTableName, segments: 2, conditions: scanConditions);
            Assert.AreEqual(4, items.Count);

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
            Assert.AreEqual(2, items.Count);

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
            Assert.AreEqual(2, items.Count);
            Assert.AreEqual(0, items[0].Count);
            Assert.AreEqual(0, items[1].Count);

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
            Assert.AreEqual(2, items.Count);

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
            Assert.AreEqual(1, items.Count);

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
            Assert.AreEqual(1, items.Count);

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
            Assert.AreEqual(2, items.Count);

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
            Assert.AreEqual(1, items.Count);

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
            Assert.AreEqual(1, items.Count);

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
            Assert.AreEqual(2, items.Count);

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
            Assert.AreEqual(1, items.Count);

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

            Assert.AreEqual(2, hashItems.Count);
            Assert.AreEqual(3, hashRangeItems.Count);
        }
        private async Task TestLargeBatches(string hashTableName)
        {
            int itemSize = 60 * 1024;
            Assert.IsTrue(itemSize < MaxItemSize);
            int itemCount = 25;

            // DynamoDB allows 1MB of data per operation, so itemSize * writeBatchSize < 1MB
            int writeBatchSize = (int)Math.Floor((decimal)OneMB / (decimal)itemSize);

            // Write large items to table in small batches
            List<string> itemIds = new List<string>();
            for (int i = 0; i < itemCount; i += writeBatchSize)
            {
                var writtenIds = await WriteBigBatch(hashTableName, writeBatchSize, i, itemSize);
                itemIds.AddRange(writtenIds);
            }

            // Get large items from table in 1MB batches
            for (int i = 0; i < itemCount; i += MaxBatchSize)
            {
                List<string> itemsToGet = itemIds.GetRange(i, MaxBatchSize);
                if (itemsToGet.Count > 0)
                {
                    int itemsRetrieved = await GetBigBatch(hashTableName, itemsToGet);
                    Assert.AreEqual(itemsRetrieved, itemsToGet.Count);
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

        private async Task<List<Dictionary<string, AttributeValue>>> Scan(string tableName, Dictionary<string, Condition> conditions)
        {
            return await ScanHelper(tableName, conditions);
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
        private async Task<List<Dictionary<string, AttributeValue>>> ScanHelper(string tableName, Dictionary<string, Condition> conditions, int? segment = null, int? totalSegments = null)
        {
            var items = new List<Dictionary<string, AttributeValue>>();

            var request = new ScanRequest
            {
                TableName = tableName,
                ScanFilter = conditions,
                Limit = ScanLimit,
            };
            if (segment.HasValue && totalSegments.HasValue)
            {
                request.Segment = segment.Value;
                request.TotalSegments = totalSegments.Value;
            }

            ScanResponse result;
            do
            {
                result = await Client.ScanAsync(request);
                foreach (var item in result.Items)
                    items.Add(item);
                request.ExclusiveStartKey = result.LastEvaluatedKey;
            } while (result.LastEvaluatedKey != null && result.LastEvaluatedKey.Count > 0);

            return items;
        }
    }
}
