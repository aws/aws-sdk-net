using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#pragma warning disable CS0162
namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [TestClass]
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        public static string TableCacheIdentifier = typeof(Table).FullName;

        private static ICache<string, TableDescription> _tableCache = null;
        public static ICache<string, TableDescription> TableCache
        {
            get
            {
                if (_tableCache == null)
                    _tableCache = SdkCache.GetCache<string, TableDescription>(
                        Client, TableCacheIdentifier, StringComparer.Ordinal);
                return _tableCache;
            }
        }


        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            if (!ReuseTables)
            {
                await RemoveCreatedTables();
            }

            BaseClean();
            Context?.Dispose();
            Client.BeforeRequestEvent -= ClientBeforeRequestEvent;
        }

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext testContext)
        {
            await CreateTestTables();

            Client.BeforeRequestEvent += ClientBeforeRequestEvent;

            // Since tables have a variable prefix, configure the prefix for the process
            AWSConfigsDynamoDB.Context.TableNamePrefix = TableNamePrefix;

            // Construct single context object to use for all operations
            CreateContext(DynamoDBEntryConversion.V1, false);
        }

        private static void ClientBeforeRequestEvent(object sender, RequestEventArgs e)
        {
            var wsrea = e as WebServiceRequestEventArgs ?? throw new InvalidOperationException();
            var request = wsrea.Request;

            if (request is DescribeTableRequest describeTableRequest)
            {
                var keys = TableCache.Keys;
                if (keys.Contains(describeTableRequest.TableName))
                {
                    Assert.Fail("Attempting to describe table that has already been described");
                }
            }
        }

        [TestCleanup]
        public async Task CleanupTables()
        {
            var clearTasks = new List<Task>
            {
                ClearTable(hashTableName),
                ClearTable(nestedTableName),
                ClearTable(hashRangeTableName),
                ClearTable(numericHashRangeTableName),
                ClearTable(compositeHashRangeTableName)
            };

            await Task.WhenAll(clearTasks);
        }

        public static void CreateContext(DynamoDBEntryConversion conversion, bool isEmptyStringValueEnabled, bool disableFetchingTableMetadata = false)
        {
            Context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => Client)
                .ConfigureContext(x =>
                {
                    //x.IgnoreNullValues = true;
                    x.IsEmptyStringValueEnabled = isEmptyStringValueEnabled;
                    x.Conversion = conversion;
                    x.DisableFetchingTableMetadata = disableFetchingTableMetadata;
                })
                .Build();
        }

        public static string nestedTableName;
        public static string hashTableName;
        public static string hashRangeTableName;
        public static string numericHashRangeTableName;
        public static string compositeHashRangeTableName;
        public static DynamoDBContext Context = null;

        public static int OneMB = 1024 * 1024;
        public static int MaxItemSize = 65 * 1024;
        public static int MaxBatchSize = 25;

        /// <summary>
        /// Setting this value to true will configure the tests to not
        /// delete the tables after the test has finished.
        /// </summary>
        public const bool ReuseTables = true;
        public const string DefaultTTLAttribute = "TTL";

        public const int ScanLimit = 1;
        public static readonly string BaseTableNamePrefix = "DotNetTests";
        public static readonly string TableNamePrefix = BaseTableNamePrefix + "-" +
            (ReuseTables ? string.Empty : + DateTime.UtcNow.ToFileTime() + "-");
        public static List<string> CreatedTables = new List<string>();

        public static async Task ClearTable(string tableName)
        {
            var table = Table.LoadTable(Client, tableName, DynamoDBEntryConversion.V1, true);
            var keyNames = table.Keys.Keys.ToList();
            
            // Retrieve all keys
            var keys = await table.Scan(new ScanOperationConfig
            {
                AttributesToGet = keyNames,
                Select = SelectValues.SpecificAttributes,
                ConsistentRead = true
            }).GetRemainingAsync();

            // Populate BatchWrite to delete all keys
            var batchWrite = table.CreateBatchWrite();
            foreach (var key in keys)
            {
                batchWrite.AddKeyToDelete(key);
            }

            // Execute batch write
            await batchWrite.ExecuteAsync();
        }

        public static async Task CreateTestTables()
        {
            nestedTableName = TableNamePrefix + "NestedTable";
            hashTableName = TableNamePrefix + "HashTable";
            hashRangeTableName = TableNamePrefix + "HashRangeTable";
            numericHashRangeTableName = TableNamePrefix + "NumericHashRangeTable";
            compositeHashRangeTableName = TableNamePrefix + "CompositeHashRangeTable";
            bool createNestedTable = true;
            bool createHashTable = true;
            bool createHashRangeTable = true;
            bool createNumericHashRangeTable = true;
            bool createCompositeHashRangeTable = true;

            if (ReuseTables)
            {
                if ((await GetStatus(nestedTableName)) != null)
                {
                    await WaitForTableStatus(nestedTableName, TableStatus.ACTIVE);
                    createNestedTable = false;
                }
                if ((await GetStatus(hashTableName)) != null)
                {
                    await WaitForTableStatus(hashTableName, TableStatus.ACTIVE);
                    createHashTable = false;
                }
                if ((await GetStatus(hashRangeTableName)) != null)
                {
                    await WaitForTableStatus(hashRangeTableName, TableStatus.ACTIVE);
                    createHashRangeTable = false;
                }
                if ((await GetStatus(numericHashRangeTableName)) != null)
                {
                    await WaitForTableStatus(numericHashRangeTableName, TableStatus.ACTIVE);
                    createNumericHashRangeTable = false;
                }
                if ((await GetStatus(compositeHashRangeTableName)) != null)
                {
                    await WaitForTableStatus(compositeHashRangeTableName, TableStatus.ACTIVE);
                    createCompositeHashRangeTable = false;
                }
            }

            if (createNestedTable)
            {
                // Create hash-key table with global index
                await Client.CreateTableAsync(new CreateTableRequest
                {
                    TableName = nestedTableName,
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.S },
                    },
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { KeyType = KeyType.HASH, AttributeName = "Id" }
                    },
                    BillingMode = BillingMode.PAY_PER_REQUEST
                });
                CreatedTables.Add(nestedTableName);

                // Wait for table to be ready
                await WaitForTableStatus(nestedTableName, TableStatus.ACTIVE);
            }

            if (createHashTable)
            {
                // Create hash-key table with global index
                await Client.CreateTableAsync(new CreateTableRequest
                {
                    TableName = hashTableName,
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
                            Projection = new Projection { ProjectionType = ProjectionType.ALL }
                        }
                    },
                    BillingMode = BillingMode.PAY_PER_REQUEST
                });
                CreatedTables.Add(hashTableName);

                // Wait for table to be ready
                await WaitForTableStatus(hashTableName, TableStatus.ACTIVE);
            }

            if (createHashRangeTable)
            {
                // Create hash-and-range-key table with local and global indexes
                await Client.CreateTableAsync(new CreateTableRequest
                {
                    TableName = hashRangeTableName,
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Name", AttributeType = ScalarAttributeType.S },
                        new AttributeDefinition { AttributeName = "Age", AttributeType = ScalarAttributeType.N },
                        new AttributeDefinition { AttributeName = "Company", AttributeType = ScalarAttributeType.S },
                        new AttributeDefinition { AttributeName = "Score", AttributeType = ScalarAttributeType.N },
                        new AttributeDefinition { AttributeName = "Manager", AttributeType = ScalarAttributeType.S }
                    },
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { AttributeName = "Name", KeyType = KeyType.HASH },
                        new KeySchemaElement { AttributeName = "Age", KeyType = KeyType.RANGE }
                    },
                    GlobalSecondaryIndexes = new List<GlobalSecondaryIndex>
                    {
                        new GlobalSecondaryIndex
                        {
                            IndexName = "GlobalIndex",
                            KeySchema = new List<KeySchemaElement>
                            {
                                new KeySchemaElement { AttributeName = "Company", KeyType = KeyType.HASH },
                                new KeySchemaElement { AttributeName = "Score", KeyType = KeyType.RANGE }
                            },
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
                                new KeySchemaElement { AttributeName = "Name", KeyType = KeyType.HASH },
                                new KeySchemaElement { AttributeName = "Manager", KeyType = KeyType.RANGE }
                            },
                            Projection = new Projection
                            {
                                ProjectionType = ProjectionType.INCLUDE,
                                NonKeyAttributes = new List<string> { "Company", "Score" }
                            }
                        }
                    },
                    BillingMode = BillingMode.PAY_PER_REQUEST
                });
                CreatedTables.Add(hashRangeTableName);

                // Wait for table to be ready
                await WaitForTableStatus(hashRangeTableName, TableStatus.ACTIVE);
            }

            if (createNumericHashRangeTable)
            {
                // Create hash-and-range-key table with local and global indexes
                await Client.CreateTableAsync(new CreateTableRequest
                {
                    TableName = numericHashRangeTableName,
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "CreationTime", AttributeType = ScalarAttributeType.N },
                        new AttributeDefinition { AttributeName = "Name", AttributeType = ScalarAttributeType.S },
                    },
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { AttributeName = "CreationTime", KeyType = KeyType.HASH },
                        new KeySchemaElement { AttributeName = "Name", KeyType = KeyType.RANGE }
                    },
                    BillingMode = BillingMode.PAY_PER_REQUEST
                });
                CreatedTables.Add(numericHashRangeTableName);

                // Wait for table to be ready
                await WaitForTableStatus(numericHashRangeTableName, TableStatus.ACTIVE);
            }

            if (createCompositeHashRangeTable)
            {
                var attributeDefinitions = new List<AttributeDefinition>
                {
                    new AttributeDefinition("Id", ScalarAttributeType.N),
                    new AttributeDefinition("UserName", ScalarAttributeType.S),
                    new AttributeDefinition("OrderId", ScalarAttributeType.S),
                    new AttributeDefinition("Timestamp", ScalarAttributeType.N),
                    new AttributeDefinition("Region", ScalarAttributeType.S),
                    new AttributeDefinition("Status", ScalarAttributeType.S),
                    new AttributeDefinition("Amount", ScalarAttributeType.N),
                    new AttributeDefinition("Category", ScalarAttributeType.S),
                    new AttributeDefinition("Priority", ScalarAttributeType.N)
                };
                // GSI definitions with variations in number of keys
                var globalSecondaryIndexes = new List<GlobalSecondaryIndex>
                {
                    // GSI1: HASH + RANGE
                    new GlobalSecondaryIndex
                    {
                        IndexName = "GSI1",
                        KeySchema = new List<KeySchemaElement>
                        {
                            new KeySchemaElement("UserName", KeyType.HASH),
                            new KeySchemaElement("Timestamp", KeyType.RANGE)
                        },
                        Projection = new Projection { ProjectionType = ProjectionType.ALL }
                    },
                    // GSI2: 2HASH + RANGE
                    new GlobalSecondaryIndex
                    {
                        IndexName = "GSI2",
                        KeySchema = new List<KeySchemaElement>
                        {
                            new KeySchemaElement("UserName", KeyType.HASH),
                            new KeySchemaElement("OrderId", KeyType.HASH),
                            new KeySchemaElement("Timestamp", KeyType.RANGE)
                        },
                        Projection = new Projection { ProjectionType = ProjectionType.ALL }
                    },
                    // GSI3: 2HASH + 2RANGE
                    new GlobalSecondaryIndex
                    {
                        IndexName = "GSI3",
                        KeySchema = new List<KeySchemaElement>
                        {
                            new KeySchemaElement("UserName", KeyType.HASH),
                            new KeySchemaElement("Region", KeyType.HASH),
                            new KeySchemaElement("Status", KeyType.RANGE),
                            new KeySchemaElement("Category", KeyType.RANGE)
                        },
                        Projection = new Projection { ProjectionType = ProjectionType.ALL }
                    },
                    // GSI4:  4HASH + 4RANGE
                    new GlobalSecondaryIndex
                    {
                        IndexName = "GSI4",
                        KeySchema = new List<KeySchemaElement>
                        {
                            new KeySchemaElement("Id", KeyType.HASH),
                            new KeySchemaElement("UserName", KeyType.HASH),
                            new KeySchemaElement("OrderId", KeyType.HASH),
                            new KeySchemaElement("Region", KeyType.HASH),
                            new KeySchemaElement("Status", KeyType.RANGE),
                            new KeySchemaElement("Category", KeyType.RANGE),
                            new KeySchemaElement("Amount", KeyType.RANGE),
                            new KeySchemaElement("Priority", KeyType.RANGE)
                        },
                        Projection = new Projection { ProjectionType = ProjectionType.ALL }
                    }
                };
                await Client.CreateTableAsync(new CreateTableRequest
                {
                    TableName = compositeHashRangeTableName,
                    AttributeDefinitions = attributeDefinitions,
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement("Id", KeyType.HASH),
                        new KeySchemaElement("Status", KeyType.RANGE)
                    },
                    GlobalSecondaryIndexes = globalSecondaryIndexes,
                    BillingMode = BillingMode.PAY_PER_REQUEST
                });
                CreatedTables.Add(compositeHashRangeTableName);
                await WaitForTableStatus(compositeHashRangeTableName, TableStatus.ACTIVE);
            }


            // Make sure TTL is enabled for the tables and is on the correct attribute
            await EnsureTTL(nestedTableName);
            await EnsureTTL(hashTableName);
            await EnsureTTL(hashRangeTableName);
            await EnsureTTL(numericHashRangeTableName);
            await EnsureTTL(compositeHashRangeTableName);
        }

        public static async Task RemoveCreatedTables()
        {
            if (CreatedTables.Count > 0)
            {
                // Wait for all tables to be active first
                await WaitForTableStatus(CreatedTables, TableStatus.ACTIVE);

                foreach (var table in CreatedTables)
                {
                    await Client.DeleteTableAsync(table);
                }

                // Wait for tables to be deleted
                await WaitForTableStatus(CreatedTables, null);

                CreatedTables.Clear();
            }
        }

        public static async Task EnsureTTL(string tableName)
        {
            async Task<bool> testFunction()
            {
                var ttl = await GetTTL(tableName);
                return ttl.TimeToLiveStatus == TimeToLiveStatus.ENABLED && string.Equals(ttl.AttributeName, DefaultTTLAttribute);
            }

            if (await testFunction())
            {
                return;
            }

            await Client.UpdateTimeToLiveAsync(new UpdateTimeToLiveRequest
            {
                TableName = tableName,
                TimeToLiveSpecification = new TimeToLiveSpecification
                {
                    Enabled = true,
                    AttributeName = DefaultTTLAttribute
                }
            });

            await UtilityMethods.WaitUntilAsync(testFunction);
        }

        public static async Task<TimeToLiveDescription> GetTTL(string tableName)
        {
            var response = await Client.DescribeTimeToLiveAsync(new DescribeTimeToLiveRequest { TableName = tableName });
            return response.TimeToLiveDescription;
        }

        public static Task WaitForTableStatus(string tableName, TableStatus status)
        {
            return WaitForTableStatus(new string[] { tableName }, status);
        }

        public static async Task WaitForTableStatus(IEnumerable<string> tableNames, TableStatus status)
        {
            Console.WriteLine("Waiting for tables [{0}] to reach status {1}", string.Join(", ", tableNames.ToArray()), status);
            var tablesList = new List<string>(tableNames);

            async Task<bool> testFunction()
            {
                bool allReady = true;
                foreach (var tableName in tablesList.ToArray())
                {
                    var tableStatus = await GetStatus(tableName);
                    allReady &= tableStatus == status;
                    if (allReady)
                    {
                        tablesList.Remove(tableName);
                    }

                    if (!allReady)
                    {
                        break;
                    }
                }

                return allReady;
            }

            await UtilityMethods.WaitUntilAsync(testFunction);
            Console.WriteLine("All tables ready");
        }

        public static async Task<TableStatus> GetStatus(string tableName)
        {
            TableStatus status;
            try
            {
                status = (await Client.DescribeTableAsync(tableName)).Table.TableStatus;
            }
            catch (ResourceNotFoundException)
            {
                status = null;
            }

            return status;
        }
    }
}
