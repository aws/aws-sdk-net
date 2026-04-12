using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    [Flags]
    public enum DynamoDBTestTables
    {
        Nested             = 1,
        Hash               = 2,
        HashRange          = 4,
        NumericHashRange   = 8,
        CompositeHashRange = 16,
        All = Nested | Hash | HashRange | NumericHashRange | CompositeHashRange
    }

    public class DynamoDBFixture : IAsyncLifetime
    {
        public static IEnumerable<object[]> Conversions => new[]
        {
            new object[] { DynamoDBEntryConversion.V1 },
            new object[] { DynamoDBEntryConversion.V2 }
        };

        private static readonly object ConfigureMappingLock = new object();
        private static bool _mappingsConfigured;

        private readonly string _tablePrefix;

        public const string DefaultTTLAttribute = "TTL";
        public const int OneMB = 1024 * 1024;
        public const int MaxItemSize = 65 * 1024;
        public const int MaxBatchSize = 25;
        public const int ScanLimit = 1;

        protected virtual DynamoDBTestTables TablesToCreate => DynamoDBTestTables.All;

        public string TableNamePrefix => _tablePrefix;

        public AmazonDynamoDBClient Client { get; private set; }
        public string NestedTableName { get; private set; }
        public string HashTableName { get; private set; }
        public string HashRangeTableName { get; private set; }
        public string NumericHashRangeTableName { get; private set; }
        public string CompositeHashRangeTableName { get; private set; }

        public DynamoDBFixture()
        {
            _tablePrefix = "DotNetTests-" + Guid.NewGuid().ToString("N") + "-";
        }

        /// <summary>
        /// Programmatically configures DynamoDB context mappings that were previously
        /// defined in App.config. This is necessary because .NET 8 does not support
        /// the aws config section. These mappings provide table targets and property
        /// overrides for unannotated model types (Employee, VersionedEmployee, etc.).
        /// </summary>
        private static void ConfigureDynamoDBMappings()
        {
            lock (ConfigureMappingLock)
            {
                if (_mappingsConfigured)
                {
                    return;
                }

                // Table alias: FakeTable -> HashRangeTable
                AWSConfigsDynamoDB.Context.AddAlias(new TableAlias("FakeTable", "HashRangeTable"));

                // Employee -> HashRangeTable with property overrides
                var employeeMapping = new TypeMapping(typeof(Employee), "HashRangeTable");
                employeeMapping.AddProperty(new PropertyConfig("ManagerName") { Attribute = "Manager" });
                employeeMapping.AddProperty(new PropertyConfig("CompanyName") { Attribute = "Company" });
                employeeMapping.AddProperty(new PropertyConfig("InternalId") { Ignore = true });
                employeeMapping.AddProperty(new PropertyConfig("CurrentStatus") { Attribute = "Status", Converter = typeof(StatusConverter) });
                AWSConfigsDynamoDB.Context.AddMapping(employeeMapping);

                // PartiallyAnnotatedEmployee -> HashRangeTable with same property overrides
                var partialMapping = new TypeMapping(typeof(PartiallyAnnotatedEmployee), "HashRangeTable");
                partialMapping.AddProperty(new PropertyConfig("ManagerName") { Attribute = "Manager" });
                partialMapping.AddProperty(new PropertyConfig("CompanyName") { Attribute = "Company" });
                partialMapping.AddProperty(new PropertyConfig("InternalId") { Ignore = true });
                partialMapping.AddProperty(new PropertyConfig("CurrentStatus") { Attribute = "Status", Converter = typeof(StatusConverter) });
                AWSConfigsDynamoDB.Context.AddMapping(partialMapping);

                // VersionedEmployee -> FakeTable (aliases to HashRangeTable) with version property
                var versionedMapping = new TypeMapping(typeof(VersionedEmployee), "FakeTable");
                versionedMapping.AddProperty(new PropertyConfig("Version") { Version = true });
                AWSConfigsDynamoDB.Context.AddMapping(versionedMapping);

                // Employee2 -> HashRangeTable (no property overrides)
                AWSConfigsDynamoDB.Context.AddMapping(new TypeMapping(typeof(Employee2), "HashRangeTable"));

                // Employee3 -> HashRangeTable (no property overrides)
                AWSConfigsDynamoDB.Context.AddMapping(new TypeMapping(typeof(Employee3), "HashRangeTable"));

                // EpochEmployee -> HashRangeTable (EpochDate2 StoreAsEpoch is already annotated on the class)
                AWSConfigsDynamoDB.Context.AddMapping(new TypeMapping(typeof(EpochEmployee), "HashRangeTable"));

                _mappingsConfigured = true;
            }
        }

        public virtual async ValueTask InitializeAsync()
        {
            ConfigureDynamoDBMappings();

            Client = new AmazonDynamoDBClient();

            if (Includes(DynamoDBTestTables.Nested))
            {
                NestedTableName = _tablePrefix + "NestedTable";
            }

            if (Includes(DynamoDBTestTables.Hash))
            {
                HashTableName = _tablePrefix + "HashTable";
            }

            if (Includes(DynamoDBTestTables.HashRange))
            {
                HashRangeTableName = _tablePrefix + "HashRangeTable";
            }

            if (Includes(DynamoDBTestTables.NumericHashRange))
            {
                NumericHashRangeTableName = _tablePrefix + "NumericHashRangeTable";
            }

            if (Includes(DynamoDBTestTables.CompositeHashRange))
            {
                CompositeHashRangeTableName = _tablePrefix + "CompositeHashRangeTable";
            }

            await CreateTestTables();
        }

        public async ValueTask DisposeAsync()
        {
            var tables = ActiveTableNames().ToList();
            await WaitForTableStatus(tables, TableStatus.ACTIVE);
            await Task.WhenAll(tables.Select(t => Client.DeleteTableAsync(t)));
            await WaitForTableStatus(tables, null);

            Client?.Dispose();
        }

        public async Task CleanupTables()
        {
            await Task.WhenAll(ActiveTableNames().Select(ClearTable));
        }

        public async Task ClearTable(string tableName)
        {
            var table = Table.LoadTable(Client, tableName, DynamoDBEntryConversion.V1, true);
            var keyNames = table.Keys.Keys.ToList();

            var keys = await table.Scan(new ScanOperationConfig
            {
                AttributesToGet = keyNames,
                Select = SelectValues.SpecificAttributes,
                ConsistentRead = true
            }).GetRemainingAsync();

            var batchWrite = table.CreateBatchWrite();
            foreach (var key in keys)
            {
                batchWrite.AddKeyToDelete(key);
            }

            await batchWrite.ExecuteAsync();
        }

        private async Task CreateTestTables()
        {
            var createTasks = new List<Task>();

            if (Includes(DynamoDBTestTables.Nested))
            {
                createTasks.Add(CreateNestedTable());
            }

            if (Includes(DynamoDBTestTables.Hash))
            {
                createTasks.Add(CreateHashTable());
            }

            if (Includes(DynamoDBTestTables.HashRange))
            {
                createTasks.Add(CreateHashRangeTable());
            }

            if (Includes(DynamoDBTestTables.NumericHashRange))
            {
                createTasks.Add(CreateNumericHashRangeTable());
            }

            if (Includes(DynamoDBTestTables.CompositeHashRange))
            {
                createTasks.Add(CreateCompositeHashRangeTable());
            }
            
            await Task.WhenAll(createTasks);
            await Task.WhenAll(ActiveTableNames().Select(EnsureTTL));
        }

        private IEnumerable<string> ActiveTableNames()
        {
            if (NestedTableName != null)
            {
                yield return NestedTableName;
            }

            if (HashTableName != null)
            {
                yield return HashTableName;
            }

            if (HashRangeTableName != null)
            {
                yield return HashRangeTableName;
            }

            if (NumericHashRangeTableName != null)
            {
                yield return NumericHashRangeTableName;
            }
    
            if (CompositeHashRangeTableName != null)
            {
                yield return CompositeHashRangeTableName;
            }
        }

        private bool Includes(DynamoDBTestTables table) => (TablesToCreate & table) == table;

        private async Task CreateNestedTable()
        {
            await Client.CreateTableAsync(new CreateTableRequest
            {
                TableName = NestedTableName,
                AttributeDefinitions = new List<AttributeDefinition>
                {
                    new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.S }
                },
                KeySchema = new List<KeySchemaElement>
                {
                    new KeySchemaElement { KeyType = KeyType.HASH, AttributeName = "Id" }
                },
                BillingMode = BillingMode.PAY_PER_REQUEST
            });

            await WaitForTableStatus(NestedTableName, TableStatus.ACTIVE);
        }

        private async Task CreateHashTable()
        {
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
                        Projection = new Projection { ProjectionType = ProjectionType.ALL }
                    }
                },
                BillingMode = BillingMode.PAY_PER_REQUEST
            });

            await WaitForTableStatus(HashTableName, TableStatus.ACTIVE);
        }

        private async Task CreateHashRangeTable()
        {
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

            await WaitForTableStatus(HashRangeTableName, TableStatus.ACTIVE);
        }

        private async Task CreateNumericHashRangeTable()
        {
            await Client.CreateTableAsync(new CreateTableRequest
            {
                TableName = NumericHashRangeTableName,
                AttributeDefinitions = new List<AttributeDefinition>
                {
                    new AttributeDefinition { AttributeName = "CreationTime", AttributeType = ScalarAttributeType.N },
                    new AttributeDefinition { AttributeName = "Name", AttributeType = ScalarAttributeType.S }
                },
                KeySchema = new List<KeySchemaElement>
                {
                    new KeySchemaElement { AttributeName = "CreationTime", KeyType = KeyType.HASH },
                    new KeySchemaElement { AttributeName = "Name", KeyType = KeyType.RANGE }
                },
                BillingMode = BillingMode.PAY_PER_REQUEST
            });

            await WaitForTableStatus(NumericHashRangeTableName, TableStatus.ACTIVE);
        }

        private async Task CreateCompositeHashRangeTable()
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

            var globalSecondaryIndexes = new List<GlobalSecondaryIndex>
            {
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
                TableName = CompositeHashRangeTableName,
                AttributeDefinitions = attributeDefinitions,
                KeySchema = new List<KeySchemaElement>
                {
                    new KeySchemaElement("Id", KeyType.HASH),
                    new KeySchemaElement("Status", KeyType.RANGE)
                },
                GlobalSecondaryIndexes = globalSecondaryIndexes,
                BillingMode = BillingMode.PAY_PER_REQUEST
            });

            await WaitForTableStatus(CompositeHashRangeTableName, TableStatus.ACTIVE);
        }

        public async Task EnsureTTL(string tableName)
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

        public async Task<TimeToLiveDescription> GetTTL(string tableName)
        {
            var response = await Client.DescribeTimeToLiveAsync(new DescribeTimeToLiveRequest { TableName = tableName });
            return response.TimeToLiveDescription;
        }

        public Task WaitForTableStatus(string tableName, TableStatus status)
        {
            return WaitForTableStatus(new[] { tableName }, status);
        }

        public async Task WaitForTableStatus(IEnumerable<string> tableNames, TableStatus status)
        {
            var tablesList = new List<string>(tableNames);

            async Task<bool> testFunction()
            {
                bool allReady = true;
                foreach (var tableName in tablesList.ToArray())
                {
                    var tableStatus = await GetStatus(tableName);
                    allReady &= tableStatus == status;
                    if (allReady)
                        tablesList.Remove(tableName);

                    if (!allReady)
                        break;
                }
                return allReady;
            }

            await UtilityMethods.WaitUntilAsync(testFunction);
        }

        public async Task<TableStatus> GetStatus(string tableName)
        {
            try
            {
                return (await Client.DescribeTableAsync(tableName)).Table.TableStatus;
            }
            catch (ResourceNotFoundException)
            {
                return null;
            }
        }
    }

}
