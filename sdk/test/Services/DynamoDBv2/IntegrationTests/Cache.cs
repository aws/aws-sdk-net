using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [TestClass]
    public class CacheTests
    {
        private const string TABLENAME = "cache-test-table";
        private string testTableName = null;
        private static AmazonDynamoDBClient client = DynamoDBTests.Client;
        private static bool lastUseSdkCacheValue;

        [TestInitialize]
        public async Task Init()
        {
            lastUseSdkCacheValue = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = true;
            SdkCache.Clear();

            testTableName = UtilityMethods.GenerateName("CacheTest");
            await CreateTable(testTableName, true);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            var allTables = (await DynamoDBTests.Client.ListTablesAsync()).TableNames;
            
            if (allTables.Contains(TABLENAME))
            {
                await DeleteTable(TABLENAME);
            }

            if (allTables.Contains(testTableName))
            {
                await DeleteTable(testTableName);
            }

            AWSConfigs.UseSdkCache = lastUseSdkCacheValue;
            SdkCache.Clear();
        }

#if NETFRAMEWORK
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestCache()
        {
            TableDescription creator(string tn) => client.DescribeTable(tn).Table;

            var tableName = testTableName;
            var tableCache = SdkCache.GetCache<string, TableDescription>(client, DynamoDBTests.TableCacheIdentifier, StringComparer.Ordinal);
            Assert.AreEqual(0, tableCache.ItemCount);

            using (var counter = new ServiceResponseCounter(client))
            {
                var table = tableCache.GetValue(tableName, creator);
                Assert.AreEqual(1, counter.ResponseCount);
                Assert.AreEqual(1, tableCache.ItemCount);

                // verify the item is still there
                table = tableCache.GetValue(tableName, creator);
                Assert.AreEqual(1, counter.ResponseCount);

                // verify item was reloaded
                tableCache.Clear(tableName);
                table = tableCache.GetValue(tableName, creator);
                Assert.AreEqual(2, counter.ResponseCount);
                Assert.AreEqual(1, tableCache.ItemCount);

                // test item expiration
                tableCache.MaximumItemLifespan = TimeSpan.FromSeconds(1);
                Thread.Sleep(tableCache.MaximumItemLifespan);
                table = tableCache.GetValue(tableName, creator);
                Assert.AreEqual(3, counter.ResponseCount);
                Assert.AreEqual(1, tableCache.ItemCount);
            }
        }
#endif

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void MultipleClientsTest()
        {
            Table.ClearTableCache();
            var tableName = testTableName;

            ITable table;
            using (var nc = new AmazonDynamoDBClient())
            {
                table = Table.LoadTable(nc, tableName);
            }

            Table.ClearTableCache();
            table = Table.LoadTable(client, tableName);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task ChangingTableTest()
        {
            var item = new Document(new Dictionary<string, DynamoDBEntry>
            {
                { "Id", 42 },
                { "Name", "Floyd" },
                { "Coffee", "Yes" }
            });
            var tableCache = SdkCache.GetCache<string, TableDescription>(client, DynamoDBTests.TableCacheIdentifier, StringComparer.Ordinal);

            await CreateTable(TABLENAME, defaultKeys: true);
            var table = Table.LoadTable(client, TABLENAME);
            await table.PutItemAsync(item);

            using (var counter = new ServiceResponseCounter(client))
            {
                var doc = await table.GetItemAsync(42, "Floyd");
                Assert.IsNotNull(doc);
                Assert.AreNotEqual(0, doc.Count);
                Assert.AreEqual(1, counter.ResponseCount);
                AssertExtensions.ExpectException(() => table.GetItem("Floyd", 42));

                var oldTableDescription = tableCache.GetValue(TABLENAME, null);

                await DeleteTable(TABLENAME);
                await CreateTable(TABLENAME, defaultKeys: false);

                await table.PutItemAsync(item);
                AssertExtensions.ExpectException(() => table.GetItem(42, "Yes"));

                counter.Reset();
                Table.ClearTableCache();
                table = Table.LoadTable(client, TABLENAME);
                doc = await table.GetItemAsync(42, "Yes");
                Assert.IsNotNull(doc);
                Assert.AreNotEqual(0, doc.Count);
                Assert.AreEqual(2, counter.ResponseCount);

                counter.Reset();
                Table.ClearTableCache();
                PutItem(tableCache, TABLENAME, oldTableDescription);
                table = Table.LoadTable(client, TABLENAME);
                doc = tableCache.UseCache(TABLENAME,
                    () => table.GetItem(42, "Yes"),
                    () => table = Table.LoadTable(client, TABLENAME),
                    shouldRetryForException: null);

                Assert.IsNotNull(doc);
                Assert.AreNotEqual(0, doc.Count);
                Assert.AreEqual(2, counter.ResponseCount);
            }
        }

        private async Task CreateTable(string name, bool defaultKeys)
        {
            var keySchema = new List<KeySchemaElement>
            {
                new KeySchemaElement
                {
                    AttributeName = "Id",
                    KeyType = KeyType.HASH
                },
                new KeySchemaElement
                {
                    AttributeName = defaultKeys ? "Name" : "Coffee",
                    KeyType = KeyType.RANGE
                }
            };

            var attributes = new List<AttributeDefinition>
            {
                new AttributeDefinition
                {
                    AttributeName = "Id",
                    AttributeType = ScalarAttributeType.N
                },
                new AttributeDefinition
                {
                    AttributeName = defaultKeys ? "Name" : "Coffee",
                    AttributeType = ScalarAttributeType.S
                }
            };

            await client.CreateTableAsync(new CreateTableRequest
            {
                TableName = name,
                KeySchema = keySchema,
                AttributeDefinitions = attributes,
                BillingMode = BillingMode.PAY_PER_REQUEST
            });

            await DynamoDBTests.WaitForTableStatus(name, TableStatus.ACTIVE);
        }

        private async Task DeleteTable(string name)
        {
            await client.DeleteTableAsync(name);
            await DynamoDBTests.WaitForTableStatus(name, null);
        }
       
        private void PutItem<TKey,TValue>(ICache<TKey,TValue> cache, TKey key, TValue value)
        {
            cache.Clear(key);
            cache.GetValue(key, k => value);
        }
    }
}
