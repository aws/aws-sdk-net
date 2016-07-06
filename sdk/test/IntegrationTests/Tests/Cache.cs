﻿using System;
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
        private const string TABLENAME = "cache-test-table";
        private string testTableName = null;
        private static AmazonDynamoDBClient client = AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.Client;
        private static bool lastUseSdkCacheValue;

        [TestInitialize]
        public void Init()
        {
            lastUseSdkCacheValue = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = true;
            SdkCache.Clear();

            testTableName = UtilityMethods.GenerateName("CacheTest");
            CreateTable(testTableName, true);
        }

        [TestCleanup]
        public void Cleanup()
        {
            var tableExists = true;

            //var status = AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.GetStatus(tableName);
            //tableExists = (status != null);

            var allTables = AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.Client.ListTables().TableNames;
            tableExists = allTables.Contains(TABLENAME);

            if (tableExists)
                DeleteTable(TABLENAME);

            if (allTables.Contains(testTableName))
                DeleteTable(testTableName);

            AWSConfigs.UseSdkCache = lastUseSdkCacheValue;
            SdkCache.Clear();
        }


        [TestMethod]
        [TestCategory("DynamoDB")]
        public void TestCache()
        {
            Func<string, TableDescription> creator = tn => client.DescribeTable(tn).Table;

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

        [TestMethod]
        [TestCategory("DynamoDB")]
        public void MultipleClientsTest()
        {
            Table.ClearTableCache();
            var tableName = testTableName;

            Table table;
            using (var nc = new AmazonDynamoDBClient())
            {
                table = Table.LoadTable(nc, tableName);
            }

            Table.ClearTableCache();
            table = Table.LoadTable(client, tableName);
        }

        [TestMethod]
        [TestCategory("DynamoDB")]
        public void ChangingTableTest()
        {
            var item = new Document(new Dictionary<string, DynamoDBEntry>
            {
                { "Id", 42 },
                { "Name", "Floyd" },
                { "Coffee", "Yes" }
            });
            var tableCache = SdkCache.GetCache<string, TableDescription>(client, DynamoDBTests.TableCacheIdentifier, StringComparer.Ordinal);

            CreateTable(TABLENAME, defaultKeys: true);
            var table = Table.LoadTable(client, TABLENAME);
            table.PutItem(item);

            using (var counter = new ServiceResponseCounter(client))
            {
                var doc = table.GetItem(42, "Floyd");
                Assert.IsNotNull(doc);
                Assert.AreNotEqual(0, doc.Count);
                Assert.AreEqual(1, counter.ResponseCount);
                AssertExtensions.ExpectException(() => table.GetItem("Floyd", 42));

                var oldTableDescription = tableCache.GetValue(TABLENAME, null);

                DeleteTable(TABLENAME);
                CreateTable(TABLENAME, defaultKeys: false);

                table.PutItem(item);
                AssertExtensions.ExpectException(() => table.GetItem(42, "Yes"));

                counter.Reset();
                Table.ClearTableCache();
                table = Table.LoadTable(client, TABLENAME);
                doc = table.GetItem(42, "Yes");
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

        private void CreateTable(string name, bool defaultKeys)
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
                TableName = name,
                KeySchema = keySchema,
                AttributeDefinitions = attributes,
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 5,
                    WriteCapacityUnits = 5
                }
            });

            AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.WaitForTableStatus(name, TableStatus.ACTIVE);
        }
        private void DeleteTable(string name)
        {
            client.DeleteTable(name);
            AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests.WaitForTableStatus(name, null);
        }
       
        private void PutItem<TKey,TValue>(ICache<TKey,TValue> cache, TKey key, TValue value)
        {
            cache.Clear(key);
            cache.GetValue(key, k => value);
        }
    }
}
