using System;
using System.Collections.Generic;
using System.Linq;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using NUnit.Framework;
using AWSSDK.Tests.Framework;
using System.Threading;


namespace AWSSDK.IntegrationTests.DynamoDB
{
    [TestFixture(TestOf = typeof(DynamoDBTests))]
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        public static string TableCacheIdentifier = typeof(Table).FullName;

        private ICache<string, TableDescription> _tableCache = null;
        public ICache<string, TableDescription> TableCache
        {
            get
            {
                if (_tableCache == null)
                    _tableCache = SdkCache.GetCache<string, TableDescription>(
                        Client, TableCacheIdentifier, StringComparer.Ordinal);
                return _tableCache;
            }
        }


        [OneTimeSetUp]
        public void ClassInitialize()
        {
            ConfigureContext();

            CreateTestTables();

            // Since tables have a variable prefix, configure the prefix for the process
            AWSConfigsDynamoDB.Context.TableNamePrefix = TableNamePrefix;

            // Construct single context object to use for all operations
            CreateContext(DynamoDBEntryConversion.V1);

        }

        [OneTimeTearDown]
        public void ClassCleanup()
        {
#pragma warning disable 162
            if (!ReuseTables)
                RemoveCreatedTables();
#pragma warning restore 162
            
            //BaseClean();
            if (Context != null)
                Context.Dispose();
        }

        private void ClientBeforeRequestEvent(object sender, Amazon.Runtime.RequestEventArgs e)
        {
            var client = sender as AmazonServiceClient;
            if (client == null)
                throw new InvalidOperationException();

            var wsrea = e as WebServiceRequestEventArgs;
            if (wsrea == null)
                throw new InvalidOperationException();

            var request = wsrea.Request;

            var describeTableRequest = request as DescribeTableRequest;
            if (describeTableRequest != null)
            {
                var keys = TableCache.Keys;
                if (keys.Contains(describeTableRequest.TableName))
                    Assert.Fail("Attempting to describe table that has already been described");
            }
        }

        [TearDown]
        public void CleanupTables()
        {
            ClearTable(hashTableName);
            ClearTable(hashRangeTableName);
        }

        public void CreateContext(DynamoDBEntryConversion conversion)
        {
            var config = new DynamoDBContextConfig
            {
                //IgnoreNullValues = true
                Conversion = conversion
            };
            Context = new DynamoDBContext(Client, config);
        }

        public static string hashTableName;
        public static string hashRangeTableName;
        public static DynamoDBContext Context = null;

        public static int OneMB = 1024 * 1024;
        public static int MaxItemSize = 65 * 1024;
        public static int MaxBatchSize = 25;

        /// <summary>
        /// Setting this value to true will configure the tests to not
        /// delete the tables after the test has finished.
        /// </summary>
        public const bool ReuseTables = false;
        public const int DefaultReadCapacity = 50;
        public const int DefaultWriteCapacity = 50;

        public const int ScanLimit = 1;
        public static readonly string BaseTableNamePrefix = "DotNetTests";
#pragma warning disable 429
        protected readonly string TableNamePrefix =
            BaseTableNamePrefix + "-" +
                (ReuseTables ? string.Empty : DateTime.Now.ToFileTime() + "-");
#pragma warning restore 429
        public static List<string> CreatedTables = new List<string>();

        public void ClearTable(string tableName)
        {
            Table table = null;

            AutoResetEvent ars = new AutoResetEvent(false);
            var exception = new Exception();
            Table.LoadTableAsync(Client, tableName, DynamoDBEntryConversion.V1, (result) =>
            {
                exception = result.Exception;
                if (exception == null)
                    table = result.Result;

                ars.Set();
            }, options);
            ars.WaitOne();

            if (exception is ResourceNotFoundException)
            {
                //table doesnt exist, nothing to clear
                return;
            }

            Assert.IsNull(exception);

            var keyNames = table.Keys.Keys.ToList();

            // Retrieve all keys
            var search = table.Scan(new ScanOperationConfig
            {
                AttributesToGet = keyNames,
                Select = SelectValues.SpecificAttributes
            });

            List<Document> keys = null;
            search.GetRemainingAsync((result) =>
            {
                keys = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();

            // Populate BatchWrite to delete all keys
            var batchWrite = table.CreateBatchWrite();
            foreach (var key in keys)
                batchWrite.AddKeyToDelete(key);

            // Execute batch write
            exception = new Exception();
            batchWrite.ExecuteAsync((result) =>
            {
                exception = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(exception);
        }

        public void CreateTestTables()
        {
            var ars = new AutoResetEvent(false);
            var exception = new Exception();

            hashTableName = TableNamePrefix + "HashTable";
            hashRangeTableName = TableNamePrefix + "HashRangeTable";
            bool createHashTable = true;
            bool createHashRangeTable = true;
            if (ReuseTables)
            {
                if (GetStatus(Client, hashTableName) != null)
                {
                    WaitForTableStatus(Client, hashTableName, TableStatus.ACTIVE);
                    createHashTable = false;
                }
                if (GetStatus(Client, hashRangeTableName) != null)
                {
                    WaitForTableStatus(Client, hashRangeTableName, TableStatus.ACTIVE);
                    createHashRangeTable = false;
                }
            }

            if (createHashTable)
            {
                // Create hash-key table with global index
                Client.CreateTableAsync(new CreateTableRequest
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

                CreatedTables.Add(hashTableName);

                // Wait for table to be ready
                WaitForTableStatus(Client, hashTableName, TableStatus.ACTIVE);
            }

            if (createHashRangeTable)
            {
                // Create hash-and-range-key table with local and global indexes
                Client.CreateTableAsync(new CreateTableRequest
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
                    ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = DefaultReadCapacity, WriteCapacityUnits = DefaultWriteCapacity },
                }, (result) =>
                {
                    exception = result.Exception;
                    ars.Set();
                }, options);

                ars.WaitOne();
                Assert.IsNull(exception);

                CreatedTables.Add(hashRangeTableName);

                // Wait for table to be ready
                WaitForTableStatus(Client, hashRangeTableName, TableStatus.ACTIVE);
            }
        }

        public void RemoveCreatedTables()
        {
            var ars = new AutoResetEvent(false);
            var exception = new Exception();

            if (CreatedTables.Count > 0)
            {
                // Wait for all tables to be active first
                WaitForTableStatus(Client, CreatedTables, TableStatus.ACTIVE);

                foreach (var table in CreatedTables)
                {
                    Client.DeleteTableAsync(new DeleteTableRequest()
                    {
                        TableName = table
                    }, (result) =>
                    {
                        exception = result.Exception;
                        ars.Set();
                    }, options);

                    ars.WaitOne();
                    Assert.IsNull(exception);
                }

                // Wait for tables to be deleted
                WaitForTableStatus(Client, CreatedTables, null);

                CreatedTables.Clear();
            }
        }

        public static void WaitForTableStatus(AmazonDynamoDBClient client, string tableName, TableStatus status)
        {
            WaitForTableStatus(client, new string[] { tableName }, status);
        }

        public static void WaitForTableStatus(AmazonDynamoDBClient client, IEnumerable<string> tableNames, TableStatus status)
        {
            Console.WriteLine("Waiting for tables [{0}] to reach status {1}",
                string.Join(", ", tableNames.ToArray()), status);
            var tablesList = new List<string>(tableNames);

            Func<bool> testFunction = () =>
            {
                bool allReady = true;
                foreach (var tableName in tablesList.ToArray())
                {
                    var tableStatus = GetStatus(client, tableName);
                    allReady &= (tableStatus == status);
                    if (allReady)
                        tablesList.Remove(tableName);

                    if (!allReady)
                        break;
                }

                return allReady;
            };

            WaitUntil(testFunction, 5, 600);

            Console.WriteLine("All tables ready");
        }
        public static TableStatus GetStatus(AmazonDynamoDBClient client, string tableName)
        {
            var ars = new AutoResetEvent(false);
            var responseException = new Exception();

            TableStatus status = null;
            client.DescribeTableAsync(new DescribeTableRequest() { TableName = tableName }, (result) =>
            {
                responseException = result.Exception;
                if (responseException == null)
                {
                    status = result.Response.Table.TableStatus;
                }
                ars.Set();
            }, options);

            ars.WaitOne();

            if (responseException != null)            {
                if (responseException is ResourceNotFoundException)
                {
                    return null;
                }
                Utils.AssertExceptionIsNull(responseException);
            }
            return status;
        }
    }
}
