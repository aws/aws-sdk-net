using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AWSSDK.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [Test]
        [Category("DynamoDB")]
        [Category("Integration")]
        [Category("WWW")]
        public void TestTableCalls()
        {

            // Only run these tests if we are not reusing tables
            if (ReuseTables)
                return;
#pragma warning disable 162
            TestTableCallsSync();
#pragma warning restore 162

        }

        private void TestTableCallsSync()
        {
            var tables = GetTableNames();
            int tableCount = tables.Count;
            var ars = new AutoResetEvent(false);
            var exception = new Exception();
            // Create hash-key table
            var table1Name = TableNamePrefix + "Table1";
            Client.CreateTableAsync(
                new CreateTableRequest()
                {
                    TableName = table1Name,
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { KeyType = KeyType.HASH, AttributeName = "Id" }
                    },
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.N }
                    },
                    ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = DefaultReadCapacity, WriteCapacityUnits = DefaultWriteCapacity }
                }, (result) =>
                {
                    exception = result.Exception;
                    ars.Set();
                }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            CreatedTables.Add(table1Name);

            // Create hash-and-range-key table
            var table2Name = TableNamePrefix + "Table2";
            Client.CreateTableAsync(new CreateTableRequest()
            {


                TableName = table2Name,
                KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { AttributeName = "Id", KeyType = KeyType.HASH },
                        new KeySchemaElement { AttributeName = "Name", KeyType = KeyType.RANGE }
                    },
                AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.N },
                        new AttributeDefinition { AttributeName = "Name", AttributeType = ScalarAttributeType.S }
                    },
                ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = DefaultReadCapacity, WriteCapacityUnits = DefaultWriteCapacity }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            CreatedTables.Add(table2Name);

            // Create hash-key table with global index
            var table3Name = TableNamePrefix + "Table3";
            Client.CreateTableAsync(new CreateTableRequest
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
           }, (result) =>
           {
               exception = result.Exception;
               ars.Set();
           }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            CreatedTables.Add(table3Name);

            // Wait for tables to be ready before creating another table with an index
            WaitForTableStatus(Client, CreatedTables, TableStatus.ACTIVE);

            // Create hash-and-range-key table with local and global indexes
            var table4Name = TableNamePrefix + "Table4";
            Client.CreateTableAsync(new CreateTableRequest
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
           }, (result) =>
           {
               exception = result.Exception;
               ars.Set();
           }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            CreatedTables.Add(table4Name);

            // Disabling this check because new tables may be created by test runs executing in parallel on other devices.
            //tables = GetTableNames();
            //Assert.AreEqual(tableCount + 4, tables.Count);

            // Wait for tables to be ready
            WaitForTableStatus(Client, CreatedTables, TableStatus.ACTIVE);

            // Update throughput for a table
            Client.UpdateTableAsync(new UpdateTableRequest()
            {
                TableName = table2Name,
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = DefaultReadCapacity * 2,
                    WriteCapacityUnits = DefaultWriteCapacity * 2
                }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            // Wait for tables to be ready
            WaitForTableStatus(Client, CreatedTables, TableStatus.ACTIVE);

            // Delete new tables
            Client.DeleteTableAsync(new DeleteTableRequest() { TableName = table1Name }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
            Client.DeleteTableAsync(new DeleteTableRequest() { TableName = table2Name }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            Client.DeleteTableAsync(new DeleteTableRequest() { TableName = table3Name }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            Client.DeleteTableAsync(new DeleteTableRequest() { TableName = table4Name }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            // Wait for tables to be deleted
            WaitForTableStatus(Client, new string[] { table1Name, table2Name, table3Name, table4Name }, null);

            // Disabling this check because new tables may be created by test runs executing in parallel on other devices.
            //// Count tables again
            //tables = GetTableNames();
            //Assert.AreEqual(tableCount, tables.Count);

            CreatedTables.Remove(table1Name);
            CreatedTables.Remove(table2Name);
            CreatedTables.Remove(table3Name);
            CreatedTables.Remove(table4Name);
        }

        [Test]
        public void TestDataCalls()
        {

            // Test hash-key table
            TestHashTable(hashTableName);

            // Test hash-and-range-key table
            TestHashRangeTable(hashRangeTableName);

            // Test batch gets and writes
            TestBatchWriteGet(hashTableName, hashRangeTableName);

            // Test large batch gets and writes
            TestLargeBatches(hashTableName);

        }

        private void TestHashTable(string hashTableName)
        {
            // Put item
            var ars = new AutoResetEvent(false);
            var exception = new Exception();

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
            Utils.AssertFalse(boolAV.IsBOOLSet);
            boolAV.BOOL = false;
            Utils.AssertTrue(boolAV.IsBOOLSet);

            Client.PutItemAsync(
                new PutItemRequest()
                {
                    TableName = hashTableName,
                    Item = new Dictionary<string, AttributeValue>
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
            }
                }, (result) =>
                {
                    exception = result.Exception;
                    ars.Set();
                }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            // Get item
            var key1 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "1" } }
            };

            Dictionary<string, AttributeValue> item = null;

            Client.GetItemAsync(new GetItemRequest() { TableName = hashTableName, Key = key1 }, (result) =>
            {
                exception = result.Exception;
                item = result.Response.Item;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(item);

            // Verify empty collections and value type
            Utils.AssertTrue(item["EmptyList"].IsLSet);
            Utils.AssertFalse(item["EmptyList"].IsMSet);
            Utils.AssertTrue(item["EmptyMap"].IsMSet);
            Utils.AssertFalse(item["EmptyMap"].IsLSet);
            Utils.AssertTrue(item["BoolFalse"].IsBOOLSet);
            Utils.AssertFalse(item["BoolFalse"].BOOL);
            Utils.AssertTrue(item["NonEmptyList"].IsLSet);
            Assert.AreEqual(nonEmptyListAV.L.Count, item["NonEmptyList"].L.Count);

            // Get nonexistent item
            var key2 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "999" } }
            };
            GetItemResponse getItemResult = null;

            Client.GetItemAsync(new GetItemRequest() { TableName = hashTableName, Key = key2 }, (result) =>
            {
                exception = result.Exception;
                getItemResult = result.Response;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(getItemResult);

            Utils.AssertFalse(getItemResult.IsItemSet);

            // Get empty item
            Client.GetItemAsync(new GetItemRequest
           {
               TableName = hashTableName,
               Key = key1,
               ProjectionExpression = "Coffee"
           }, (result) =>
           {
               exception = result.Exception;
               getItemResult = result.Response;
               ars.Set();
           }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(getItemResult);

            Utils.AssertTrue(getItemResult.IsItemSet);
            Assert.AreEqual(0, getItemResult.Item.Count);

            // Update item
            Client.UpdateItemAsync(new UpdateItemRequest()
            {
                TableName = hashTableName,
                Key = key1,
                AttributeUpdates = new Dictionary<string, AttributeValueUpdate>
            {
                { "Product", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudSpotter 2.0" } } },
                { "Seller", new AttributeValueUpdate { Action = AttributeAction.DELETE } },
                { "Tags", new AttributeValueUpdate { Action = AttributeAction.ADD, Value = new AttributeValue { SS = new List<string> { "2.0" } } } }
            }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            // Get updated item
            Client.GetItemAsync(new GetItemRequest() { TableName = hashTableName, Key = key1 }, (result) =>
            {
                exception = result.Exception;
                item = result.Response.Item;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(item);

            Utils.AssertTrue(item["Product"].S.IndexOf("2.0") >= 0);
            Assert.AreEqual(3, item["Tags"].SS.Count);
            Utils.AssertFalse(item.ContainsKey("Seller"));

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
            Assert.AreEqual(1, items.Count);

            // Update non-existent item
            key2 = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = "2" } }
            };
            Client.UpdateItemAsync(new UpdateItemRequest()
            {
                TableName = hashTableName,
                Key = key2,
                AttributeUpdates = new Dictionary<string, AttributeValueUpdate>
                {
                    { "Product", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudDebugger" } } },
                    { "Company", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "CloudsAreGrate" } } },
                    { "Tags", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { SS = new List<string> { "Test" } } } },
                    { "Price", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { N = "42" } } }
                }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            // Get updated item
            Client.GetItemAsync(new GetItemRequest() { TableName = hashTableName, Key = key2 }, (result) =>
            {
                exception = result.Exception;
                item = result.Response.Item;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(item);

            Utils.AssertTrue(item["Product"].S.IndexOf("Debugger") >= 0);
            Assert.AreEqual(1, item["Tags"].SS.Count);
            Utils.AssertFalse(item.ContainsKey("Seller"));

            // Scan all items
            items = Scan(hashTableName, scanConditions);
            Assert.AreEqual(2, items.Count);

            // Query global index
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(1, items.Count);

            // Scan global index
            Client.ScanAsync(new ScanRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(1, items.Count);

        }
        private void TestHashRangeTable(string hashRangeTableName)
        {
            var ars = new AutoResetEvent(false);
            var exception = new Exception();
            // Put items
            Client.PutItemAsync(new PutItemRequest()
            {
                TableName = hashRangeTableName,
                Item = new Dictionary<string, AttributeValue>
                {
                    { "Name", new AttributeValue { S = "Alan" } },
                    { "Age", new AttributeValue { N = "31" } },
                    { "Company", new AttributeValue { S = "Big River" } },
                    { "Score", new AttributeValue { N = "120" } },
                    { "Manager", new AttributeValue { S = "Barbara"} }
                }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            Client.PutItemAsync(new PutItemRequest()
            {
                TableName = hashRangeTableName,
                Item = new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Chuck" } },
                { "Age", new AttributeValue { N = "30" } },
                { "Company", new AttributeValue { S = "Big River" } },
                { "Score", new AttributeValue { N = "94" } },
                { "Manager", new AttributeValue { S = "Barbara"} }
            }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            Client.PutItemAsync(new PutItemRequest()
            {
                TableName = hashRangeTableName,
                Item = new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Diane" } },
                { "Age", new AttributeValue { N = "40" } },
                { "Company", new AttributeValue { S = "Madeira" } },
                { "Score", new AttributeValue { N = "140" } },
                { "Manager", new AttributeValue { S = "Eva"} }
            }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

            Client.PutItemAsync(new PutItemRequest()
            {
                TableName = hashRangeTableName,
                Item = new Dictionary<string, AttributeValue>
            {
                { "Name", new AttributeValue { S = "Diane" } },
                { "Age", new AttributeValue { N = "24" } },
                { "Company", new AttributeValue { S = "Madeira" } },
                { "Score", new AttributeValue { N = "101" } },
                { "Manager", new AttributeValue { S = "Francis"} }
            }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);

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
            Assert.AreEqual(4, items.Count);

            // Scan in parallel
            items = ParallelScan(hashRangeTableName, segments: 2, conditions: scanConditions);
            Assert.AreEqual(4, items.Count);

            // Query table with no range-key condition
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(2, items.Count);

            // Query table with no range-key condition and no returned attributes
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(2, items.Count);
            Assert.AreEqual(0, items[0].Count);
            Assert.AreEqual(0, items[1].Count);

            // Query table with hash-key condition expression
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(2, items.Count);

            // Query table with key condition expression
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(1, items.Count);

            // Query global index
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(1, items.Count);

            // Query local index with no range-key condition
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(2, items.Count);

            // Query local index with range-key condition
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            // Query local index with a query filter
            Client.QueryAsync(new QueryRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(1, items.Count);

            // Scan global index
            Client.ScanAsync(new ScanRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(1, items.Count);

            // Scan local index with no range-key condition
            Client.ScanAsync(new ScanRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(2, items.Count);

            // Scan local index with range-key condition
            Client.ScanAsync(new ScanRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            // Scan local index with a non-key condition
            Client.ScanAsync(new ScanRequest
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
            }, (result) =>
            {
                exception = result.Exception;
                items = result.Response.Items;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);
            Assert.IsNotNull(items);

            Assert.AreEqual(1, items.Count);

        }
        private void TestBatchWriteGet(string hashTableName, string hashRangeTableName)
        {
            var ars = new AutoResetEvent(false);
            var exception = new Exception();
            // Put 1 item and delete 2 items across 2 tables
            Client.BatchWriteItemAsync(new BatchWriteItemRequest()
            {
                RequestItems = new Dictionary<string, List<WriteRequest>>
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
            }
            }, (result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);

            // Get 5 items across 2 tables

            BatchGetItemResponse batchGetResult = null;
            Client.BatchGetItemAsync(new BatchGetItemRequest()
            {
                RequestItems = new Dictionary<string, KeysAndAttributes>
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
            }
            }, (result) =>
            {
                exception = result.Exception;
                batchGetResult = result.Response;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(exception);


            var tableItems = batchGetResult.Responses;
            var hashItems = tableItems[hashTableName];
            var hashRangeItems = tableItems[hashRangeTableName];

            Assert.AreEqual(2, hashItems.Count);
            Assert.AreEqual(3, hashRangeItems.Count);
        }

        private void TestLargeBatches(string hashTableName)
        {
            int itemSize = 60 * 1024;
            Utils.AssertTrue(itemSize < MaxItemSize);
            int itemCount = 25;

            // DynamoDB allows 1MB of data per operation, so itemSize * writeBatchSize < 1MB
            int writeBatchSize = (int)Math.Floor((decimal)OneMB / (decimal)itemSize);

            // Write large items to table in small batches
            List<string> itemIds = new List<string>();
            for (int i = 0; i < itemCount; i += writeBatchSize)
            {
                var writtenIds = WriteBigBatch(hashTableName, writeBatchSize, i, itemSize);
                itemIds.AddRange(writtenIds);
            }

            // Get large items from table in 1MB batches
            for (int i = 0; i < itemCount; i += MaxBatchSize)
            {
                List<string> itemsToGet = itemIds.GetRange(i, MaxBatchSize);
                if (itemsToGet.Count > 0)
                {
                    int itemsRetrieved = GetBigBatch(hashTableName, itemsToGet);
                    Assert.AreEqual(itemsRetrieved, itemsToGet.Count);
                }
            }
        }

        private List<string> WriteBigBatch(string hashTableName, int items, int itemsStartingIndex, int itemSize)
        {
            var exception = new Exception();
            var ars = new AutoResetEvent(false);

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
            BatchWriteItemResponse result = null;

            do
            {
                Client.BatchWriteItemAsync(request, (r) =>
                {
                    exception = r.Exception;
                    result = r.Response;
                    ars.Set();
                }, options);
                ars.WaitOne();
                Assert.IsNull(exception);

                request.RequestItems = result.UnprocessedItems;
            } while (result.UnprocessedItems != null && result.UnprocessedItems.Count > 0);

            return itemIds;
        }
        private int GetBigBatch(string hashTableName, List<string> idsToGet)
        {
            var exception = new Exception();
            var ars = new AutoResetEvent(false);

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
            BatchGetItemResponse result = null;

            int itemsRetrieved = 0;
            do
            {
                Client.BatchGetItemAsync(request, (r) =>
                {
                    exception = r.Exception;
                    result = r.Response;
                    ars.Set();
                }, options);
                ars.WaitOne();
                Assert.IsNull(exception);

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
            var exception = new Exception();
            var ars = new AutoResetEvent(false);

            var request = new ListTablesRequest();
            ListTablesResponse response = null;
            do
            {
                Client.ListTablesAsync(request, (r) =>
                {
                    exception = r.Exception;
                    response = r.Response;
                    ars.Set();
                }, options);
                ars.WaitOne();
                Assert.IsNull(exception);

                foreach (var tableName in response.TableNames)
                    yield return tableName;

                request.ExclusiveStartTableName = response.LastEvaluatedTableName;
            } while (!string.IsNullOrEmpty(response.LastEvaluatedTableName));
        }

        private List<Dictionary<string, AttributeValue>> Scan(string tableName, Dictionary<string, Condition> conditions)
        {
            return ScanHelper(tableName, conditions);
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
        private List<Dictionary<string, AttributeValue>> ScanHelper(string tableName, Dictionary<string, Condition> conditions, int? segment = null, int? totalSegments = null)
        {
            var exception = new Exception();
            var ars = new AutoResetEvent(false);

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

            ScanResponse result = null;
            do
            {
                Client.ScanAsync(request, (r) =>
               {
                   exception = r.Exception;
                   result = r.Response;
                   ars.Set();
               }, options);
                ars.WaitOne();
                Assert.IsNull(exception);

                foreach (var item in result.Items)
                    items.Add(item);
                request.ExclusiveStartKey = result.LastEvaluatedKey;
            } while (result.LastEvaluatedKey != null && result.LastEvaluatedKey.Count > 0);

            return items;
        }
    }
}