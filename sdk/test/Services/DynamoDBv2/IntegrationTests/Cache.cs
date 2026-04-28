using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
#if NETFRAMEWORK
    [Collection("Serial")]
    [Trait("Category", "DynamoDBv2")]
    public class CacheTests : IAsyncLifetime
    {
        private static readonly string TableCacheIdentifier = typeof(Table).FullName;
        private const string TABLENAME = "cache-test-table";

        private string _testTableName;
        private AmazonDynamoDBClient _client;
        private bool _lastUseSdkCacheValue;

        public async ValueTask InitializeAsync()
        {
            _client = new AmazonDynamoDBClient();
            _lastUseSdkCacheValue = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = true;
            SdkCache.Clear();

            _testTableName = UtilityMethods.GenerateName("CacheTest");
            await CreateTable(_testTableName, defaultKeys: true);
        }

        public async ValueTask DisposeAsync()
        {
            var allTables = (await _client.ListTablesAsync()).TableNames;
            if (allTables.Contains(TABLENAME))
            {
                await DeleteTable(TABLENAME);
            }

            if (allTables.Contains(_testTableName))
            {
                await DeleteTable(_testTableName);
            }

            AWSConfigs.UseSdkCache = _lastUseSdkCacheValue;
            SdkCache.Clear();
            _client?.Dispose();
        }

        [Fact]
        public void TestCache()
        {
            TableDescription creator(string tn) => _client.DescribeTable(tn).Table;

            var tableName = _testTableName;
            var tableCache = SdkCache.GetCache<string, TableDescription>(_client, TableCacheIdentifier, StringComparer.Ordinal);
            Assert.Equal(0, tableCache.ItemCount);

            using (var counter = new ServiceResponseCounter(_client))
            {
                var table = tableCache.GetValue(tableName, creator);
                Assert.Equal(1, counter.ResponseCount);
                Assert.Equal(1, tableCache.ItemCount);

                // verify the item is still there
                table = tableCache.GetValue(tableName, creator);
                Assert.Equal(1, counter.ResponseCount);

                // verify item was reloaded
                tableCache.Clear(tableName);
                table = tableCache.GetValue(tableName, creator);
                Assert.Equal(2, counter.ResponseCount);
                Assert.Equal(1, tableCache.ItemCount);

                // test item expiration
                tableCache.MaximumItemLifespan = TimeSpan.FromSeconds(1);
                Thread.Sleep(tableCache.MaximumItemLifespan);
                table = tableCache.GetValue(tableName, creator);
                Assert.Equal(3, counter.ResponseCount);
                Assert.Equal(1, tableCache.ItemCount);
            }
        }

        [Fact]
        public void MultipleClientsTest()
        {
            Table.ClearTableCache();
            var tableName = _testTableName;

            ITable table;
            using (var nc = new AmazonDynamoDBClient())
            {
                table = Table.LoadTable(nc, tableName);
            }

            Table.ClearTableCache();
            table = Table.LoadTable(_client, tableName);
        }

        [Fact]
        public async Task ChangingTableTest()
        {
            var item = new Document(new Dictionary<string, DynamoDBEntry>
            {
                { "Id", 42 },
                { "Name", "Floyd" },
                { "Coffee", "Yes" }
            });
            var tableCache = SdkCache.GetCache<string, TableDescription>(_client, TableCacheIdentifier, StringComparer.Ordinal);

            await CreateTable(TABLENAME, defaultKeys: true);
            var table = Table.LoadTable(_client, TABLENAME);
            await table.PutItemAsync(item);

            using (var counter = new ServiceResponseCounter(_client))
            {
                var consistentRead = new GetItemOperationConfig { ConsistentRead = true };
                var doc = await table.GetItemAsync(42, "Floyd", consistentRead);
                Assert.NotNull(doc);
                Assert.NotEqual(0, doc.Count);
                Assert.Equal(1, counter.ResponseCount);
                AssertExtensions.ExpectException(() => table.GetItem("Floyd", 42));

                var oldTableDescription = tableCache.GetValue(TABLENAME, null);

                await DeleteTable(TABLENAME);
                await CreateTable(TABLENAME, defaultKeys: false);

                await table.PutItemAsync(item);
                AssertExtensions.ExpectException(() => table.GetItem(42, "Yes"));

                counter.Reset();
                Table.ClearTableCache();
                table = Table.LoadTable(_client, TABLENAME);
                doc = await table.GetItemAsync(42, "Yes", consistentRead);
                Assert.NotNull(doc);
                Assert.NotEqual(0, doc.Count);
                Assert.Equal(2, counter.ResponseCount);

                counter.Reset();
                Table.ClearTableCache();
                PutItem(tableCache, TABLENAME, oldTableDescription);
                table = Table.LoadTable(_client, TABLENAME);
                doc = tableCache.UseCache(TABLENAME,
                    () => table.GetItem(42, "Yes"),
                    () => table = Table.LoadTable(_client, TABLENAME),
                    shouldRetryForException: null);

                Assert.NotNull(doc);
                Assert.NotEqual(0, doc.Count);
                Assert.Equal(2, counter.ResponseCount);
            }
        }

        private async Task CreateTable(string name, bool defaultKeys)
        {
            await _client.CreateTableAsync(new CreateTableRequest
            {
                TableName = name,
                KeySchema = new List<KeySchemaElement>
                {
                    new KeySchemaElement { AttributeName = "Id", KeyType = KeyType.HASH },
                    new KeySchemaElement { AttributeName = defaultKeys ? "Name" : "Coffee", KeyType = KeyType.RANGE }
                },
                AttributeDefinitions = new List<AttributeDefinition>
                {
                    new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.N },
                    new AttributeDefinition { AttributeName = defaultKeys ? "Name" : "Coffee", AttributeType = ScalarAttributeType.S }
                },
                BillingMode = BillingMode.PAY_PER_REQUEST
            });

            await WaitForTableStatus(name, TableStatus.ACTIVE);
        }

        private async Task DeleteTable(string name)
        {
            await _client.DeleteTableAsync(name);
            await WaitForTableStatus(name, null);
        }

        private void PutItem<TKey, TValue>(ICache<TKey, TValue> cache, TKey key, TValue value)
        {
            cache.Clear(key);
            cache.GetValue(key, k => value);
        }

        private async Task WaitForTableStatus(string tableName, TableStatus status)
        {
            async Task<bool> testFunction()
            {
                try
                {
                    var tableStatus = (await _client.DescribeTableAsync(tableName)).Table.TableStatus;
                    return tableStatus == status;
                }
                catch (ResourceNotFoundException)
                {
                    return status == null;
                }
            }

            await UtilityMethods.WaitUntilAsync(testFunction);
        }
    }
#endif
}
