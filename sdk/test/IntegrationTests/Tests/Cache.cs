using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Text;
using System.IO;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CacheTests
    {
        private const string tableName = "cache-test-table";
        private static AmazonDynamoDBClient client = AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.Client;
        private static bool lastUseSdkCacheValue;

        [TestInitialize]
        public void Init()
        {
            lastUseSdkCacheValue = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = true;
            SdkCache.Clear();
        }

        [TestCleanup]
        public void Cleanup()
        {
            var tableExists = true;

            //var status = AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.GetStatus(tableName);
            //tableExists = (status != null);

            var allTables = AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.Client.ListTables().TableNames;
            tableExists = allTables.Contains(tableName);

            if (tableExists)
                DeleteTable();

            AWSConfigs.UseSdkCache = lastUseSdkCacheValue;
            SdkCache.Clear();
        }


        [TestMethod]
        public void TestCache()
        {
            Func<string, TableDescription> creator = tn => client.DescribeTable(tn).Table;

            var tableName = GetTableName();
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

        [TestMethod]
        public void MultipleClientsTest()
        {
            Table.ClearTableCache();
            var tableName = GetTableName();

            Table table;
            using (var nc = new AmazonDynamoDBClient())
            {
                table = Table.LoadTable(nc, tableName);
            }

            Table.ClearTableCache();
            table = Table.LoadTable(client, tableName);
        }

        [TestMethod]
        public void ChangingTableTest()
        {
            var item = new Document(new Dictionary<string, DynamoDBEntry>
            {
                { "Id", 42 },
                { "Name", "Floyd" },
                { "Coffee", "Yes" }
            });
            var tableCache = SdkCache.GetCache<string, TableDescription>(client, DynamoDBTests.TableCacheIdentifier, StringComparer.Ordinal);

            CreateTable(defaultKeys: true);
            var table = Table.LoadTable(client, tableName);
            table.PutItem(item);

            using (var counter = new ServiceResponseCounter(client))
            {
                var doc = table.GetItem(42, "Floyd");
                Assert.IsNotNull(doc);
                Assert.AreNotEqual(0, doc.Count);
                Assert.AreEqual(1, counter.ResponseCount);
                AssertExtensions.ExpectException(() => table.GetItem("Floyd", 42));

                var oldTableDescription = tableCache.GetValue(tableName, null);

                DeleteTable();
                CreateTable(defaultKeys: false);

                table.PutItem(item);
                AssertExtensions.ExpectException(() => table.GetItem(42, "Yes"));

                counter.Reset();
                Table.ClearTableCache();
                table = Table.LoadTable(client, tableName);
                doc = table.GetItem(42, "Yes");
                Assert.IsNotNull(doc);
                Assert.AreNotEqual(0, doc.Count);
                Assert.AreEqual(2, counter.ResponseCount);

                counter.Reset();
                Table.ClearTableCache();
                PutItem(tableCache, tableName, oldTableDescription);
                table = Table.LoadTable(client, tableName);
                doc = tableCache.UseCache(tableName,
                    () => table.GetItem(42, "Yes"),
                    () => table = Table.LoadTable(client, tableName),
                    shouldRetryForException: null);

                Assert.IsNotNull(doc);
                Assert.AreNotEqual(0, doc.Count);
                Assert.AreEqual(2, counter.ResponseCount);
            }
        }

        private void CreateTable(bool defaultKeys)
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

            client.CreateTable(new CreateTableRequest
            {
                TableName = tableName,
                KeySchema = keySchema,
                AttributeDefinitions = attributes,
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 5,
                    WriteCapacityUnits = 5
                }
            });

            AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.WaitForTableStatus(tableName, TableStatus.ACTIVE);
        }
        private void DeleteTable()
        {
            client.DeleteTable(tableName);
            AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.WaitForTableStatus(tableName, null);
        }
        private static string GetTableName()
        {
            var tables = client.ListTables().TableNames;
            Assert.AreNotEqual(0, tables.Count);
            var tableName = tables.First();

            return tableName;
        }
        private void PutItem<TKey,TValue>(ICache<TKey,TValue> cache, TKey key, TValue value)
        {
            cache.Clear(key);
            cache.GetValue(key, k => value);
        }
    }
}
