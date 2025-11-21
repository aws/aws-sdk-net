using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

using Xunit;

namespace Amazon.DNXCore.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : IClassFixture<DynamoDBTestsFixture>
    {
        public const string CategoryAttribute = "Category";

        private AmazonDynamoDBClient Client = null;
        private DynamoDBTestsFixture SharedTestFixture = null;

        public DynamoDBTests(DynamoDBTestsFixture fixture)
        {
            SharedTestFixture = fixture;
            Client = fixture.Client;
        }

        public void Dispose()
        {
            SharedTestFixture.CleanupTables().Wait();
        }
    }

    public class DynamoDBTestsFixture : TestBase<AmazonDynamoDBClient>
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

        protected override void Dispose(bool disposing)
        {
#pragma warning disable CS0162
            if (!ReuseTables)
                RemoveCreatedTables().Wait();
#pragma warning restore CS0162
            base.Dispose(disposing);
            if (Context != null)
                Context.Dispose();

            Client.BeforeRequestEvent -= ClientBeforeRequestEvent;
        }

        static readonly object CONFIGURE_MAPPING_LOCK = new object();
        public DynamoDBTestsFixture()
        {
            lock (CONFIGURE_MAPPING_LOCK)
            {
                if(!AWSConfigsDynamoDB.Context.TableAliases.ContainsKey("FakeTable"))
                {
                    // .NET Core does not support config files yet, so programmatically configure the settings.  See App.45.config
                    AWSConfigsDynamoDB.Context.AddAlias(new TableAlias("FakeTable", "HashRangeTable"));
                    TypeMapping mapping = new TypeMapping(typeof(DynamoDBTests.Employee), "HashRangeTable");
                    mapping.AddProperty(new PropertyConfig("ManagerName") { Attribute = "Manager" });
                    mapping.AddProperty(new PropertyConfig("CompanyName") { Attribute = "Company" });
                    mapping.AddProperty(new PropertyConfig("InternalId") { Ignore = true });
                    mapping.AddProperty(new PropertyConfig("CurrentStatus") { Attribute = "Status", Converter = typeof(DynamoDBTests.StatusConverter) });
                    AWSConfigsDynamoDB.Context.AddMapping(mapping);

                    mapping = new TypeMapping(typeof(DynamoDBTests.VersionedEmployee), "FakeTable");
                    mapping.AddProperty(new PropertyConfig("Version") { Version = true });
                    AWSConfigsDynamoDB.Context.AddMapping(mapping);
                    AWSConfigsDynamoDB.Context.AddMapping(new TypeMapping(typeof(DynamoDBTests.Employee2), "FakeTable"));
                    AWSConfigsDynamoDB.Context.AddMapping(new TypeMapping(typeof(DynamoDBTests.Employee3), "FakeTable"));
                }

                CreateTestTables().Wait();

                Client.BeforeRequestEvent += ClientBeforeRequestEvent;

                // Since tables have a variable prefix, configure the prefix for the process
                AWSConfigsDynamoDB.Context.TableNamePrefix = TableNamePrefix;

                // Construct single context object to use for all operations
                CreateContext(DynamoDBEntryConversion.V1);
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
                    Assert.True(false, "Attempting to describe table that has already been described");
            }
        }
        
        public async Task CleanupTables()
        {
            await ClearTable(hashTableName);
            await ClearTable(hashRangeTableName);
        }

        public void CreateContext(DynamoDBEntryConversion conversion)
        {
            var config = new DynamoDBv2.DataModel.DynamoDBContextConfig
            {
                //IgnoreNullValues = true
                Conversion = conversion
            };
            Context = new DynamoDBContext(Client, config);
        }

        public string hashTableName;
        public string hashRangeTableName;
        public DynamoDBContext Context = null;

        public static int OneMB = 1024 * 1024;
        public static int MaxItemSize = 65 * 1024;
        public static int MaxBatchSize = 25;

        /// <summary>
        /// Setting this value to true will configure the tests to not
        /// delete the tables after the test has finished.
        /// </summary>
        public const bool ReuseTables = true;
        public const int DefaultReadCapacity = 50;
        public const int DefaultWriteCapacity = 50;

        public const int ScanLimit = 1;
        public static readonly string BaseTableNamePrefix = "DotNetTests";
        public static readonly string TableNamePrefix = BaseTableNamePrefix + "-" +
            (ReuseTables ? string.Empty : + DateTime.UtcNow.ToFileTime() + "-");
        public List<string> CreatedTables = new List<string>();

        public async Task ClearTable(string tableName)
        {
            var table = Table.LoadTable(Client, tableName, DynamoDBEntryConversion.V1);
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
                batchWrite.AddKeyToDelete(key);

            // Execute batch write
            await batchWrite.ExecuteAsync();
        }

        public async Task CreateTestTables()
        {
            hashTableName = TableNamePrefix + "HashTable";
            hashRangeTableName = TableNamePrefix + "HashRangeTable";
            bool createHashTable = true;
            bool createHashRangeTable = true;

            if (ReuseTables)
            {
                if (await GetStatus(hashTableName) != null)
                {
                    await WaitForTableStatus(hashTableName, TableStatus.ACTIVE);
                    createHashTable = false;
                }
                if (await GetStatus(hashRangeTableName) != null)
                {
                    await WaitForTableStatus(hashRangeTableName, TableStatus.ACTIVE);
                    createHashRangeTable = false;
                }
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
                    BillingMode = BillingMode.PAY_PER_REQUEST,
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
                    BillingMode = BillingMode.PAY_PER_REQUEST,
                });
                CreatedTables.Add(hashRangeTableName);

                // Wait for table to be ready
                await WaitForTableStatus(hashRangeTableName, TableStatus.ACTIVE);
            }
        }
        public async Task RemoveCreatedTables()
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

        public Task WaitForTableStatus(string tableName, TableStatus status)
        {
            return WaitForTableStatus(new string[] { tableName }, status);
        }
        public Task WaitForTableStatus(IEnumerable<string> tableNames, TableStatus status)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Waiting for tables [{0}] to reach status {1}",
                    string.Join(", ", tableNames.ToArray()), status);
                var tablesList = new List<string>(tableNames);

                Func<bool> testFunction = () =>
                {
                    bool allReady = true;
                    foreach (var tableName in tablesList.ToArray())
                    {
                        var tableStatus = GetStatus(tableName).Result;
                        allReady &= (tableStatus == status);
                        if (allReady)
                            tablesList.Remove(tableName);

                        if (!allReady)
                            break;
                    }

                    return allReady;
                };

                UtilityMethods.WaitUntil(testFunction);
                Console.WriteLine("All tables ready");
            });
        }
        public async Task<TableStatus> GetStatus(string tableName)
        {
            TableStatus status = null;
            try
            {
                status = (await Client.DescribeTableAsync(tableName)).Table.TableStatus;
            }
            catch(ResourceNotFoundException)
            {
                status = null;
            }

            return status;
        }
    }
}
