using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

using Amazon.Runtime.Internal.Util;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;
using Xunit;
using Amazon.DynamoDBv2.DataModel;

namespace Amazon.DNXCore.IntegrationTests.DynamoDB
{
    public class DynamoDBTestSession : IDisposable
    {        
        public static int OneMB = 1024 * 1024;
        public static int MaxItemSize = 65 * 1024;
        public static int MaxBatchSize = 25;

        public const int DefaultReadCapacity = 5;
        public const int DefaultWriteCapacity = 5;
        public const int ScanLimit = 1;

        public string HashTableName;
        public string HashRangeTableName;
#pragma warning disable 429
        public string TableNamePrefix;
#pragma warning restore 429


        List<string> _createdTables = new List<string>();
        List<DynamoDBContext> _contexts = new List<DynamoDBContext>();

        public string Prefix { get; set; }

        public AmazonDynamoDBClient Client { get; set; }

        public DynamoDBTestSession(string testName, AmazonDynamoDBClient client)
        {
            Prefix = UtilityMethods.GenerateName(testName);
            TableNamePrefix = string.Format("{0}-{1}-", UtilityMethods.SDK_TEST_PREFIX, Prefix);
            Client = client;

            Client.BeforeRequestEvent += ClientBeforeRequestEvent;
        }

        public async Task CreateTestTables(int readCapacity = DefaultReadCapacity, int writeCapacity = DefaultWriteCapacity)
        {
            HashTableName = TableNamePrefix + "HashTable";
            HashRangeTableName = TableNamePrefix + "HashRangeTable";

            bool createHashTable = true;
            bool createHashRangeTable = true;
            
            if (createHashTable)
            {
                // Create hash-key table with global index
                await Client.CreateTableAsync(new CreateTableRequest
                {
                    TableName = HashTableName,
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
                    ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = readCapacity, WriteCapacityUnits = writeCapacity },
                });
                _createdTables.Add(HashTableName);

                // Wait for table to be ready
                WaitForTableStatus(Client, HashTableName, TableStatus.ACTIVE);
            }

            if (createHashRangeTable)
            {
                // Create hash-and-range-key table with local and global indexes
                await Client.CreateTableAsync(new CreateTableRequest
                {
                    TableName = HashRangeTableName,
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
                    ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = readCapacity, WriteCapacityUnits = writeCapacity },
                });
                _createdTables.Add(HashRangeTableName);

                // Wait for table to be ready
                WaitForTableStatus(Client, HashRangeTableName, TableStatus.ACTIVE);
            }
        }

        public static void WaitForTableStatus(IAmazonDynamoDB client, string tableName, TableStatus status, bool failIfNotCompleted = true)
        {
            WaitForTableStatus(client, new string[] { tableName }, status, failIfNotCompleted);
        }

        public static void WaitForTableStatus(IAmazonDynamoDB client, IEnumerable<string> tableNames,
            TableStatus status, bool failIfNotCompleted = true)
        {
            Console.WriteLine("Waiting for tables [{0}] to reach status {1}",
                string.Join(", ", tableNames.ToArray()), status);
            var tablesList = new List<string>(tableNames);

            Func<bool> testFunction = () =>
            {
                bool allReady = true;
                foreach (var tableName in tablesList.ToArray())
                {
                    var tableStatus = GetStatus(client, tableName).Result;
                    allReady &= (tableStatus == status);
                    if (allReady)
                        tablesList.Remove(tableName);

                    if (!allReady)
                        break;
                }

                return allReady;
            };

            UtilityMethods.WaitUntil(testFunction, 5, 100, failIfNotCompleted);

            Console.WriteLine("All tables ready");
        }

        public static async Task<TableStatus> GetStatus(IAmazonDynamoDB client, string tableName)
        {
            TableStatus status = null;
            try
            {
                status = (await client.DescribeTableAsync(tableName)).Table.TableStatus;
            }
            catch (ResourceNotFoundException)
            {
                status = null;
            }

            return status;
        }

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
                    AssertExtensions.Fail("Attempting to describe table that has already been described");
            }
        }

        public DynamoDBContext CreateContext(DynamoDBEntryConversion conversion)
        {
            var config = new DynamoDBContextConfig
            {
                //IgnoreNullValues = true
                Conversion = conversion,
                TableNamePrefix = TableNamePrefix

            };
            var context = new DynamoDBContext(Client, config);
            _contexts.Add(context);
            return context;
        }

        public void Dispose()
        {
            Client.BeforeRequestEvent -= ClientBeforeRequestEvent;

            // Delete tables
            foreach (var tableName in _createdTables)
            {
                Client.DeleteTableAsync(tableName).Wait();
            }

            foreach (var context in _contexts)
            {
                context.Dispose();
            }

            _createdTables.Clear();
        }
    }
}
