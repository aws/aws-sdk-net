using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using System.IO;


namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [TestMethod]
        [TestCategory("DynamoDB")]
        public void TestTableOperations()
        {
            Table hashTable;
            Table hashRangeTable;
            LoadTables(out hashTable, out hashRangeTable);

            // Scan the tables to confirm they are empty
            var items = hashTable.Scan(new ScanFilter()).GetRemaining();
            Assert.AreEqual(0, items.Count);
            items = hashRangeTable.Scan(new ScanFilter()).GetRemaining();
            Assert.AreEqual(0, items.Count);

            // Test operations on hash-key table
            TestHashTable(hashTable);

            // Test operations on hash-and-range-key table
            TestHashRangeTable(hashRangeTable);

            // Test large batch writes and gets
            TestLargeBatchOperations(hashTable);
        }

        private void TestHashTable(Table hashTable)
        {
            // Put an item
            Document doc = new Document();
            doc["Id"] = 1;
            doc["Product"] = "CloudSpotter";
            doc["Company"] = "CloudsAreGrate";
            doc["Price"] = 1200;
            doc["Tags"] = new List<string> { "Prod", "1.0" };
            hashTable.PutItem(doc);

            // Get the item by hash key
            Document retrieved = hashTable.GetItem(1);
            Assert.IsTrue(AreValuesEqual(doc, retrieved));
            // Get the item by document
            retrieved = hashTable.GetItem(doc);
            Assert.IsTrue(AreValuesEqual(doc, retrieved));

            // Update the item
            doc["Tags"] = new List<string> { "Prod", "1.0", "2.0" };
            hashTable.UpdateItem(doc);
            retrieved = hashTable.GetItem(1);
            Assert.IsTrue(AreValuesEqual(doc, retrieved));

            // Create new item
            Document doc2 = Document.FromAttributeMap(doc.ToAttributeMap());
            doc2["Id"] = doc2["Id"].AsInt() + 1;
            doc2["Price"] = 94;
            doc2["Tags"] = null;
            hashTable.UpdateItem(doc2);

            // Scan the hash-key table
            var items = hashTable.Scan(new ScanFilter()).GetRemaining();
            Assert.AreEqual(2, items.Count);

            // Scan by pages
            var search = hashTable.Scan(new ScanOperationConfig { Limit = 1 });
            items.Clear();
            while (!search.IsDone)
            {
                var set = search.GetNextSet();
                items.AddRange(set);
            }
            Assert.AreEqual(2, items.Count);

            // Query against GlobalIndex
            var queryFilter = new QueryFilter("Company", QueryOperator.Equal, "CloudsAreGrate");
            queryFilter.AddCondition("Price", QueryOperator.GreaterThan, 100);
            search = hashTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            });
            items = search.GetRemaining();
            Assert.AreEqual(1, items.Count);

            // Scan for specific tag
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Tags", ScanOperator.Contains, "2.0");
            search = hashTable.Scan(scanFilter);
            items = search.GetRemaining();
            Assert.AreEqual(1, items.Count);

            // Delete the item by hash key
            hashTable.DeleteItem(1);
            Assert.IsNull(hashTable.GetItem(1));

            // Delete the item by document
            hashTable.DeleteItem(doc2);
            Assert.IsNull(hashTable.GetItem(doc2));

            // Scan the hash-key table to confirm it is empty
            items = hashTable.Scan(new ScanFilter()).GetRemaining();
            Assert.AreEqual(0, items.Count);

            // Batch-put items
            var batchWrite = hashTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(doc);
            batchWrite.AddDocumentToPut(doc2);
            batchWrite.Execute();

            // Batch-get items
            var batchGet = hashTable.CreateBatchGet();
            batchGet.AddKey(1);
            batchGet.AddKey(doc2);
            batchGet.Execute();
            Assert.AreEqual(2, batchGet.Results.Count);

            // Batch-delete items
            batchWrite = hashTable.CreateBatchWrite();
            batchWrite.AddItemToDelete(doc);
            batchWrite.AddKeyToDelete(2);
            batchWrite.Execute();

            // Batch-get non-existent items
            batchGet = hashTable.CreateBatchGet();
            batchGet.AddKey(1);
            batchGet.AddKey(doc2);
            batchGet.Execute();
            Assert.AreEqual(0, batchGet.Results.Count);

            // Scan the hash-key table to confirm it is empty
            items = hashTable.Scan(new ScanFilter()).GetRemaining();
            Assert.AreEqual(0, items.Count);
        }
        private void TestHashRangeTable(Table hashRangeTable)
        {
            // Put an item
            Document doc1 = new Document();
            doc1["Name"] = "Alan";
            doc1["Age"] = 31;
            doc1["Company"] = "Big River";
            doc1["Score"] = 120;
            doc1["Manager"] = "Barbara";
            doc1["Aliases"] = new List<string> { "Al", "Steve" };
            hashRangeTable.PutItem(doc1);

            // Update a non-existent item creates the item
            Document doc2 = new Document();
            doc2["Name"] = "Chuck";
            doc2["Age"] = 30;
            doc2["Company"] = "Big River";
            doc2["Score"] = 94;
            doc2["Manager"] = "Barbara";
            doc2["Aliases"] = new List<string> { "Charles" };
            hashRangeTable.UpdateItem(doc2);

            // Save more items
            Document doc3 = new Document();
            doc3["Name"] = "Diane";
            doc3["Age"] = 40;
            doc3["Company"] = "Madeira";
            doc3["Score"] = 140;
            doc3["Manager"] = "Eva";
            hashRangeTable.UpdateItem(doc3);
            var oldDoc3 = Document.FromAttributeMap(doc3.ToAttributeMap());

            // Changing the range key will force a creation of a new item
            doc3["Age"] = 24;
            doc3["Score"] = 101;
            hashRangeTable.UpdateItem(doc3);

            // Get items
            var retrieved = hashRangeTable.GetItem("Alan", 31);
            Assert.IsTrue(AreValuesEqual(doc1, retrieved));
            retrieved = hashRangeTable.GetItem(doc2);
            Assert.IsTrue(AreValuesEqual(doc2, retrieved));
            retrieved = hashRangeTable.GetItem(oldDoc3, new GetItemOperationConfig { ConsistentRead = true });
            Assert.IsTrue(AreValuesEqual(oldDoc3, retrieved));
            retrieved = hashRangeTable.GetItem("Diane", 24, new GetItemOperationConfig { ConsistentRead = true });
            Assert.IsTrue(AreValuesEqual(doc3, retrieved));

            // Scan the hash-and-range-key table
            var items = hashRangeTable.Scan(new ScanFilter()).GetRemaining();
            Assert.AreEqual(4, items.Count);

            // Scan by pages
            var search = hashRangeTable.Scan(new ScanOperationConfig { Limit = 1 });
            items.Clear();
            while(!search.IsDone)
            {
                var set = search.GetNextSet();
                items.AddRange(set);
            }
            Assert.AreEqual(4, items.Count);

            // Scan in parallel
            var segment1 = hashRangeTable.Scan(new ScanOperationConfig { Segment = 0, TotalSegments = 2 }).GetRemaining();
            var segment2 = hashRangeTable.Scan(new ScanOperationConfig { Segment = 1, TotalSegments = 2 }).GetRemaining();
            Assert.AreEqual(4, segment1.Count + segment2.Count);

            // Query items
            items = hashRangeTable.Query("Diane", new QueryFilter()).GetRemaining();
            Assert.AreEqual(2, items.Count);

            // Query local index
            items = hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Diane")
            }).GetRemaining();
            Assert.AreEqual(2, items.Count);

            // Query global index
            var queryFilter = new QueryFilter("Company", QueryOperator.Equal, "Big River");
            queryFilter.AddCondition("Score", QueryOperator.GreaterThan, 100);
            items = hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemaining();
            Assert.AreEqual(1, items.Count);
        }
        private void TestLargeBatchOperations(Table hashTable)
        {
            int itemCount = 30;
            int itemSize = 40 * 1024;
            string textData = new string('@', itemSize);
            MemoryStream data = new MemoryStream(Encoding.UTF8.GetBytes(textData));

            // Write all items
            var batchWrite = hashTable.CreateBatchWrite();
            for(int i=0;i<itemCount;i++)
            {
                var doc = new Document();
                doc["Id"] = i;
                doc["Data"] = data;
                batchWrite.AddDocumentToPut(doc);
            }
            batchWrite.Execute();

            Thread.Sleep(100); // Wait for the eventual consistence of the batch add to catch up.
           
            // Scan table, but retrieve only keys
            var ids = hashTable.Scan(new ScanOperationConfig
            {
                AttributesToGet = new List<string> { "Id" },
                Select = SelectValues.SpecificAttributes
            }).GetRemaining();
            Assert.AreEqual(itemCount, ids.Count);

            // Batch-get all items
            var batchGet = hashTable.CreateBatchGet();
            foreach (var id in ids)
                batchGet.AddKey(id);
            batchGet.Execute();
            Assert.AreEqual(itemCount, batchGet.Results.Count);

            // Batch-delete all items
            batchWrite = hashTable.CreateBatchWrite();
            foreach (var id in ids)
                batchWrite.AddKeyToDelete(id);
            batchWrite.Execute();

            Thread.Sleep(100); // Wait for the eventual consistence of the batch add to catch up.

            // Scan table to confirm it is empty
            var items = hashTable.Scan(new ScanFilter()).GetRemaining();
            Assert.AreEqual(0, items.Count);
        }

        private bool AreValuesEqual(Document docA, Document docB)
        {
            if (object.ReferenceEquals(docA, docB))
                return true;
            if (docA.Count != docB.Count)
                return false;
            if (docA.Keys.Count != docB.Keys.Count)
                return false;
            if (docA.Keys.Except(docB.Keys).Count() > 0)
                return false;
            foreach (var key in docA.Keys)
            {
                var a = docA[key];
                var b = docB[key];

                var aPrimitive = a.AsPrimitive();
                var bPrimitive = b.AsPrimitive();
                if (aPrimitive != null || bPrimitive != null)
                {
                    if (aPrimitive == null || bPrimitive == null)
                        return false;

                    if (!aPrimitive.Equals(bPrimitive))
                        return false;
                }

                var aList = a.AsPrimitiveList();
                var bList = b.AsPrimitiveList();
                if (aList != null || bList != null)
                {
                    if (aList == null || bList == null)
                        return false;

                    if (!aList.Equals(bList))
                        return false;
                }
            }

            return true;
        }
        private void LoadTables(out Table hashTable, out Table hashRangeTable)
        {
            // Load table using TryLoadTable API
            hashTable = null;
            Assert.IsFalse(Table.TryLoadTable(Client, "FakeHashTableThatShouldNotExist", out hashTable));
            Assert.IsTrue(Table.TryLoadTable(Client, hashTableName, out hashTable));

            Assert.IsNotNull(hashTable);
            Assert.AreEqual(hashTableName, hashTable.TableName);
            Assert.AreEqual(3, hashTable.Attributes.Count);
            Assert.AreEqual(1, hashTable.GlobalSecondaryIndexes.Count);
            Assert.AreEqual(1, hashTable.GlobalSecondaryIndexes["GlobalIndex"].ProvisionedThroughput.ReadCapacityUnits);
            Assert.AreEqual(1, hashTable.GlobalSecondaryIndexNames.Count);
            Assert.AreEqual(1, hashTable.HashKeys.Count);
            Assert.AreEqual(0, hashTable.RangeKeys.Count);
            Assert.AreEqual(1, hashTable.Keys.Count);
            Assert.AreEqual(0, hashTable.LocalSecondaryIndexes.Count);
            Assert.AreEqual(0, hashTable.LocalSecondaryIndexNames.Count);

            // Load table using LoadTable API (may throw an exception)
            AssertExtensions.ExpectException(() => Table.LoadTable(Client, "FakeHashRangeTableThatShouldNotExist"));
            hashRangeTable = Table.LoadTable(Client, hashRangeTableName);
            Assert.IsNotNull(hashRangeTable);
            Assert.AreEqual(hashRangeTableName, hashRangeTable.TableName);
            Assert.AreEqual(5, hashRangeTable.Attributes.Count);
            Assert.AreEqual(1, hashRangeTable.GlobalSecondaryIndexes.Count);
            Assert.AreEqual(1, hashRangeTable.GlobalSecondaryIndexes["GlobalIndex"].ProvisionedThroughput.ReadCapacityUnits);
            Assert.AreEqual(1, hashRangeTable.GlobalSecondaryIndexNames.Count);
            Assert.AreEqual(1, hashRangeTable.HashKeys.Count);
            Assert.AreEqual(1, hashRangeTable.RangeKeys.Count);
            Assert.AreEqual(2, hashRangeTable.Keys.Count);
            Assert.AreEqual(1, hashRangeTable.LocalSecondaryIndexes.Count);
            Assert.AreEqual(2, hashRangeTable.LocalSecondaryIndexes["LocalIndex"].KeySchema.Count);
            Assert.AreEqual(1, hashRangeTable.LocalSecondaryIndexNames.Count);
        }
    }
}
