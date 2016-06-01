using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using System.IO;
using ThirdParty.Json.LitJson;
using System.Xml;
using NUnit.Framework;
using AWSSDK.Tests.Framework;

namespace AWSSDK.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [Test]
        [Category("DynamoDB")]
        [Category("Integration")]
        [Category("WWW")]
        public void TestTableOperations()
        {
            Client.BeforeRequestEvent += ClientBeforeRequestEvent;
            try
            {
                foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
                {
                    // Clear tables
                    CleanupTables();

                    Table hashTable;
                    Table hashRangeTable;

                    // Load tables using provided conversion schema
                    LoadTables(conversion, out hashTable, out hashRangeTable);

                    // Test saving and loading empty lists and maps
                    TestEmptyCollections(hashTable);

                    // Test operations on hash-key table
                    TestHashTable(hashTable, conversion);

                    // Test operations on hash-and-range-key table
                    TestHashRangeTable(hashRangeTable, conversion);

                    // Test large batch writes and gets
                    TestLargeBatchOperations(hashTable);

                    // Test expressions for update
                    TestExpressionUpdate(hashTable);

                    // Test expressions for put
                    TestExpressionPut(hashTable);

                    // Test expressions for delete
                    TestExpressionsOnDelete(hashTable);

                    // Test expressions for query
                    TestExpressionsOnQuery(hashRangeTable);

                    // Test expressions for scan
                    TestExpressionsOnScan(hashRangeTable);
                }
            }
            finally
            {
                Client.BeforeRequestEvent -= ClientBeforeRequestEvent;
            }
        }

        private void TestEmptyCollections(Table hashTable)
        {
            Document doc = new Document();
            doc["Id"] = 1;
            doc["EmptyList"] = new DynamoDBList();
            doc["EmptyMap"] = new Document();

            var ars = new AutoResetEvent(false);
            var ex = new Exception();
            hashTable.PutItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);


            Document retrieved = null;
            ex = new Exception();
            hashTable.GetItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.IsNull(ex);

            DynamoDBEntry mapEntry;
            Utils.AssertTrue(retrieved.TryGetValue("EmptyMap", out mapEntry));
            Assert.IsNotNull(mapEntry);
            Assert.IsNotNull(mapEntry.AsDocument());
            Assert.AreEqual(0, mapEntry.AsDocument().Count);

            DynamoDBEntry listEntry;
            Utils.AssertTrue(retrieved.TryGetValue("EmptyList", out listEntry));
            Assert.IsNotNull(listEntry);
            Assert.IsNotNull(listEntry.AsDynamoDBList());
            Assert.AreEqual(0, listEntry.AsDynamoDBList().Entries.Count);
        }

        private void TestHashTable(Table hashTable, DynamoDBEntryConversion conversion)
        {
            // Put an item
            Document doc = new Document();
            doc["Id"] = 1;
            doc["Product"] = "CloudSpotter";
            doc["Company"] = "CloudsAreGrate";
            doc["IsPublic"] = true;
            doc["Price"] = 1200;
            doc["Tags"] = new HashSet<string> { "Prod", "1.0" };
            doc["Aliases"] = new List<string> { "CS", "Magic" };
            doc["Developers"] = new List<Document>
            {
                new Document(new Dictionary<string,DynamoDBEntry>
                {
                    { "Name", "Alan" },
                    { "Age", 29 }
                }),
                new Document(new Dictionary<string,DynamoDBEntry>
                {
                    { "Name", "Franco" },
                    { "Age", 32 }
                })
            };
            doc["Garbage"] = "asdf";
            Assert.AreEqual("asdf", doc["Garbage"].AsString());

            var ars = new AutoResetEvent(false);
            var ex = new Exception();

            hashTable.PutItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Get the item by hash key
            Document retrieved = null;
            ex = new Exception();
            hashTable.GetItemAsync(1, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Utils.AssertFalse(AreValuesEqual(doc, retrieved));
            var convertedDoc = doc.ForceConversion(conversion);
            Utils.AssertTrue(AreValuesEqual(convertedDoc, retrieved));

            // Get the item by document
            ex = new Exception();
            hashTable.GetItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Verify retrieved document
            Utils.AssertTrue(AreValuesEqual(convertedDoc, retrieved, conversion));
            var tagsRetrieved = retrieved["Tags"];
            Utils.AssertTrue(tagsRetrieved is PrimitiveList);
            Assert.AreEqual(2, tagsRetrieved.AsPrimitiveList().Entries.Count);
            // Test bool storage for different conversions
            var isPublicRetrieved = retrieved["IsPublic"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.AreEqual("1", isPublicRetrieved.AsPrimitive().Value as string);
            else
                Utils.AssertTrue(isPublicRetrieved is DynamoDBBool);
            // Test HashSet<string> storage for different conversions
            var aliasesRetrieved = retrieved["Aliases"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.AreEqual(2, aliasesRetrieved.AsPrimitiveList().Entries.Count);
            else
                Assert.AreEqual(2, aliasesRetrieved.AsDynamoDBList().Entries.Count);
            List<Document> developers = retrieved["Developers"].AsListOfDocument();
            Assert.AreEqual(2, developers.Count);
            ExpectException<InvalidCastException>(() => aliasesRetrieved.AsListOfDocument());

            // Update the item
            doc["Tags"] = new List<string> { "Prod", "1.0", "2.0" };
            doc["Developers"] = new DynamoDBList(new List<DynamoDBEntry>
            {
                new Document(new Dictionary<string,DynamoDBEntry>
                {
                    { "Name", "Alan" },
                    { "Age", 29 }
                })
            });
            // Delete the Garbage attribute
            doc["Garbage"] = null;
            Assert.IsNull(doc["Garbage"].AsString());
            ex = new Exception();
            hashTable.UpdateItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            ex = new Exception();
            hashTable.GetItemAsync(1, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Utils.AssertFalse(AreValuesEqual(doc, retrieved, conversion));
            doc.Remove("Garbage");
            Utils.AssertTrue(AreValuesEqual(doc, retrieved, conversion));
            developers = retrieved["Developers"].AsListOfDocument();
            Assert.AreEqual(1, developers.Count);

            // Create new, circularly-referencing item            
            Document doc2 = doc.ForceConversion(conversion);
            doc2["Id"] = doc2["Id"].AsInt() + 1;
            doc2["Price"] = 94;
            doc2["Tags"] = null;
            doc2["IsPublic"] = false;
            doc2["Parent"] = doc2;

            ex = null;
            hashTable.UpdateItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNotNull(ex);

            // Remove circular reference and save new item
            doc2.Remove("Parent");

            ex = new Exception();
            hashTable.UpdateItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Scan the hash-key table
            List<Document> items = null;
            ex = new Exception();
            hashTable.Scan(new ScanFilter()).GetRemainingAsync((result) =>
            {
                items = result.Result;
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Assert.AreEqual(2, items.Count);

            // Scan by pages
            var search = hashTable.Scan(new ScanOperationConfig { Limit = 1 });
            items.Clear();
            List<Document> set = null;
            while (!search.IsDone)
            {
                ex = new Exception();
                search.GetNextSetAsync((result) =>
                {
                    ex = result.Exception;
                    set = result.Result;
                    ars.Set();
                }, options);
                ars.WaitOne();
                Assert.IsNull(ex);
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

            ex = new Exception();
            search.GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Assert.AreEqual(1, items.Count);

            // Scan for specific tag
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Tags", ScanOperator.Contains, "2.0");
            search = hashTable.Scan(scanFilter);
            ex = new Exception();
            search.GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(1, items.Count);

            // Delete the item by hash key
            ex = new Exception();
            hashTable.DeleteItemAsync(1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            ex = new Exception();
            Document item = null;
            hashTable.GetItemAsync(1, (result) =>
            {
                ex = result.Exception;
                item = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.IsNull(ex);
            Assert.IsNull(item);

            // Delete the item by document
            ex = new Exception();
            hashTable.DeleteItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            ex = new Exception();
            hashTable.GetItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                item = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.IsNull(item);

            // Scan the hash-key table to confirm it is empty
            ex = new Exception();
            hashTable.Scan(new ScanFilter()).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(0, items.Count);

            // Batch-put items
            var batchWrite = hashTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(doc);
            batchWrite.AddDocumentToPut(doc2);
            ex = new Exception();
            batchWrite.ExecuteAsync((result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Batch-get items
            var batchGet = hashTable.CreateBatchGet();
            batchGet.AddKey(1);
            batchGet.AddKey(doc2);
            ex = new Exception();
            batchGet.ExecuteAsync((result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Assert.AreEqual(2, batchGet.Results.Count);

            // Batch-delete items
            batchWrite = hashTable.CreateBatchWrite();
            batchWrite.AddItemToDelete(doc);
            batchWrite.AddKeyToDelete(2);
            ex = new Exception();
            batchWrite.ExecuteAsync((result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Batch-get non-existent items
            batchGet = hashTable.CreateBatchGet();
            batchGet.AddKey(1);
            batchGet.AddKey(doc2);
            ex = new Exception();
            batchGet.ExecuteAsync((result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(0, batchGet.Results.Count);

            // Scan the hash-key table to confirm it is empty
            hashTable.Scan(new ScanFilter()).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(0, items.Count);
        }
        private void TestHashRangeTable(Table hashRangeTable, DynamoDBEntryConversion conversion)
        {
            var ex = new Exception();
            var ars = new AutoResetEvent(false);
            // Put an item
            Document doc1 = new Document();
            doc1["Name"] = "Alan";
            doc1["Age"] = 31;
            doc1["Company"] = "Big River";
            doc1["Score"] = 120;
            doc1["IsTester"] = true;
            doc1["Manager"] = "Barbara";
            doc1["Aliases"] = new HashSet<string> { "Al", "Steve" };
            doc1["PastManagers"] = new List<string> { "Carl", "Karl" };
            hashRangeTable.PutItemAsync(doc1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Update a non-existent item creates the item
            Document doc2 = new Document();
            doc2["Name"] = "Chuck";
            doc2["Age"] = 30;
            doc2["Company"] = "Big River";
            doc2["Score"] = 94;
            doc1["IsTester"] = false;
            doc2["Manager"] = "Barbara";
            doc2["Aliases"] = new HashSet<string> { "Charles" };
            ex = new Exception();
            hashRangeTable.UpdateItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Save more items
            Document doc3 = new Document();
            doc3["Name"] = "Diane";
            doc3["Age"] = 40;
            doc3["Company"] = "Madeira";
            doc1["IsTester"] = true;
            doc3["Score"] = 140;
            doc3["Manager"] = "Eva";
            ex = new Exception();
            hashRangeTable.UpdateItemAsync(doc3, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            var oldDoc3 = doc3.Clone() as Document;

            // Changing the range key will force a creation of a new item
            doc3["Age"] = 24;
            doc3["Score"] = 101;
            ex = new Exception();
            hashRangeTable.UpdateItemAsync(doc3, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Get item
            Document retrieved = null;
            hashRangeTable.GetItemAsync("Alan", 31, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            // Verify retrieved document
            Utils.AssertTrue(AreValuesEqual(doc1, retrieved, conversion));
            var tagsRetrieved = retrieved["Aliases"];
            Utils.AssertTrue(tagsRetrieved is PrimitiveList);
            Assert.AreEqual(2, tagsRetrieved.AsPrimitiveList().Entries.Count);
            // Test bool storage for different conversions
            var isTesterRetrieved = retrieved["IsTester"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.AreEqual("1", isTesterRetrieved.AsPrimitive().Value as string);
            else
                Utils.AssertTrue(isTesterRetrieved is DynamoDBBool);
            // Test HashSet<string> storage for different conversions
            var pastManagersRetrieved = retrieved["PastManagers"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.AreEqual(2, pastManagersRetrieved.AsPrimitiveList().Entries.Count);
            else
                Assert.AreEqual(2, pastManagersRetrieved.AsDynamoDBList().Entries.Count);

            // Get item using GetItem overloads that expect a key in different ways
            ex = new Exception();
            hashRangeTable.GetItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Utils.AssertTrue(AreValuesEqual(doc2, retrieved, conversion));
            ex = new Exception();
            hashRangeTable.GetItemAsync(oldDoc3, new GetItemOperationConfig { ConsistentRead = true }, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Utils.AssertTrue(AreValuesEqual(oldDoc3, retrieved, conversion));
            ex = new Exception();
            hashRangeTable.GetItemAsync("Diane", 24, new GetItemOperationConfig { ConsistentRead = true }, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Utils.AssertTrue(AreValuesEqual(doc3, retrieved, conversion));

            // Scan the hash-and-range-key table
            ex = new Exception();
            List<Document> items = null;
            hashRangeTable.Scan(new ScanFilter()).GetRemainingAsync((result) =>
              {
                  ex = result.Exception;
                  items = result.Result;
                  ars.Set();
              }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(4, items.Count);

            // Scan by pages
            var search = hashRangeTable.Scan(new ScanOperationConfig { Limit = 1 });
            items.Clear();
            List<Document> set = null;
            while (!search.IsDone)
            {
                ex = new Exception();
                search.GetNextSetAsync((result) =>
                {
                    ex = result.Exception;
                    set = result.Result;
                    ars.Set();
                }, options);
                ars.WaitOne();
                Assert.IsNull(ex);
                items.AddRange(set);
            }
            Assert.AreEqual(4, items.Count);

            // Scan in parallel
            List<Document> segment1 = null, segment2 = null;

            ex = new Exception();
            hashRangeTable.Scan(new ScanOperationConfig { Segment = 0, TotalSegments = 2 }).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                segment1 = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            ex = new Exception();
            hashRangeTable.Scan(new ScanOperationConfig { Segment = 1, TotalSegments = 2 }).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                segment2 = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(4, segment1.Count + segment2.Count);

            // Query items

            ex = new Exception();
            hashRangeTable.Query("Diane", new QueryFilter()).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(2, items.Count);

            var queryConfig = new QueryOperationConfig
            {
                KeyExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#N", "Name" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v", "Diane" }
                    },
                    ExpressionStatement = "#N = :v"
                }
            };

            ex = new Exception();
            hashRangeTable.Query(queryConfig).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(2, items.Count);

            queryConfig = new QueryOperationConfig
            {
                KeyExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#N", "Name" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v", "Diane" }
                    },
                    ExpressionStatement = "#N = :v"
                },
                FilterExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#S", "Score" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v2", 120 }
                    },
                    ExpressionStatement = "#S > :v2"
                }
            };
            ex = new Exception();
            hashRangeTable.Query(queryConfig).GetRemainingAsync((result) =>
             {
                 ex = result.Exception;
                 items = result.Result;
                 ars.Set();
             }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(1, items.Count);

            queryConfig = new QueryOperationConfig
            {
                KeyExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#N", "Name" },
                        { "#A", "Age" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v2", 120 }
                    },
                    ExpressionStatement = "#N = :v and #A < :v2"
                },
                FilterExpression = new Expression
                {
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#S", "Score" },
                        { "#A", "Age" }
                    },
                    ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                    {
                        { ":v", "Diane" },
                    },
                    ExpressionStatement = "#S < :v2"
                }
            };
            ex = new Exception();
            hashRangeTable.Query(queryConfig).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(1, items.Count);



            // Query local index
            ex = new Exception();
            hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Diane")
            }).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(2, items.Count);

            // Query global index
            var queryFilter = new QueryFilter("Company", QueryOperator.Equal, "Big River");
            queryFilter.AddCondition("Score", QueryOperator.GreaterThan, 100);
            ex = new Exception();
            hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(1, items.Count);

            // Scan local index
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Name", ScanOperator.Equal, "Diane"); ex = new Exception();
            hashRangeTable.Scan(new ScanOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = scanFilter
            }).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(2, items.Count);

            // Scan global index
            scanFilter = new ScanFilter();
            scanFilter.AddCondition("Company", ScanOperator.Equal, "Big River");
            scanFilter.AddCondition("Score", ScanOperator.GreaterThan, 100);
            ex = new Exception();
            hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(1, items.Count);
        }
        private void TestLargeBatchOperations(Table hashTable)
        {
            var ars = new AutoResetEvent(false);
            var ex = new Exception();
            int itemCount = 30;
            int itemSize = 40 * 1024;
            string textData = new string('@', itemSize);
            MemoryStream data = new MemoryStream(Encoding.UTF8.GetBytes(textData));

            // Write all items
            var batchWrite = hashTable.CreateBatchWrite();
            for (int i = 0; i < itemCount; i++)
            {
                var doc = new Document();
                doc["Id"] = i;
                doc["Data"] = data;
                batchWrite.AddDocumentToPut(doc);
            }

            batchWrite.ExecuteAsync((result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Thread.Sleep(TimeSpan.FromSeconds(1)); // Wait for the eventual consistence of the batch add to catch up.

            // Scan table, but retrieve only keys
            List<Document> ids = null;
            ex = new Exception();
            hashTable.Scan(new ScanOperationConfig
            {
                AttributesToGet = new List<string> { "Id" },
                Select = SelectValues.SpecificAttributes
            }).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                ids = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(itemCount, ids.Count);

            // Batch-get all items
            var batchGet = hashTable.CreateBatchGet();
            ex = new Exception();
            foreach (var id in ids)
                batchGet.AddKey(id);


            batchGet.ExecuteAsync((result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(itemCount, batchGet.Results.Count);

            // Batch-delete all items
            batchWrite = hashTable.CreateBatchWrite();

            foreach (var id in ids)
                batchWrite.AddKeyToDelete(id);


            ex = new Exception();
            batchWrite.ExecuteAsync((result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Thread.Sleep(TimeSpan.FromSeconds(1)); // Wait for the eventual consistence of the batch add to catch up.

            // Scan table to confirm it is empty
            List<Document> items = null;
            hashTable.Scan(new ScanFilter()).GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                items = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(0, items.Count);
        }

        private void TestExpressionsOnDelete(Table hashTable)
        {
            var ex = new Exception();
            var ars = new AutoResetEvent(false);

            Document doc1 = new Document();
            doc1["Id"] = 13;
            doc1["Price"] = 6;
            hashTable.PutItemAsync(doc1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Price > :price";
            expression.ExpressionAttributeValues[":price"] = 7;

            DeleteItemOperationConfig config = new DeleteItemOperationConfig();
            config.ConditionalExpression = expression;

            //Utils.AssertFalse(hashTable.TryDeleteItem(doc1, config));
            hashTable.DeleteItemAsync(doc1, config, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNotNull(ex);

            expression.ExpressionAttributeValues[":price"] = 4;
            //Utils.AssertTrue(hashTable.TryDeleteItem(doc1, config));
            hashTable.DeleteItemAsync(doc1, config, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
        }

        private void TestExpressionsOnQuery(Table hashRangeTable)
        {
            var ex = new Exception();
            var ars = new AutoResetEvent(false);


            Document doc1 = new Document();
            doc1["Name"] = "Gunnar";
            doc1["Age"] = 77;
            doc1["Job"] = "Retired";
            hashRangeTable.PutItemAsync(doc1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Document doc2 = new Document();
            doc2["Name"] = "Gunnar";
            doc2["Age"] = 45;
            doc2["Job"] = "Electrician";
            ex = new Exception();
            hashRangeTable.PutItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Job = :job";
            expression.ExpressionAttributeValues[":job"] = "Retired";

            var search = hashRangeTable.Query("Gunnar", expression);
            List<Document> docs = null;
            ex = new Exception();
            search.GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                docs = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(77, docs[0]["Age"].AsInt());

            search = hashRangeTable.Query(new QueryOperationConfig
            {
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Gunnar"),
                FilterExpression = expression,
                AttributesToGet = new List<string> { "Age" },
                Select = SelectValues.SpecificAttributes
            });
            ex = new Exception();
            search.GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                docs = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(1, docs[0].Count);
            Assert.AreEqual(77, docs[0]["Age"].AsInt());

            ex = new Exception();
            hashRangeTable.DeleteItemAsync(doc1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            ex = new Exception();
            hashRangeTable.DeleteItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
        }

        private void TestExpressionsOnScan(Table hashRangeTable)
        {
            var ex = new Exception();
            var ars = new AutoResetEvent(false);


            ClearTable(hashRangeTableName);

            Document doc1 = new Document();
            doc1["Name"] = "Lewis";
            doc1["Age"] = 6;
            doc1["School"] = "Elementary";
            hashRangeTable.PutItemAsync(doc1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Document doc2 = new Document();
            doc2["Name"] = "Frida";
            doc2["Age"] = 3;
            doc2["School"] = "Preschool";
            hashRangeTable.PutItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Age > :age";
            expression.ExpressionAttributeValues[":age"] = 5;

            var search = hashRangeTable.Scan(expression);
            ex = new Exception();
            List<Document> docs = null;
            search.GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                docs = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual("Elementary", docs[0]["School"].AsString());

            search = hashRangeTable.Scan(new ScanOperationConfig
            {
                FilterExpression = expression,
                Select = SelectValues.SpecificAttributes,
                AttributesToGet = new List<string> { "School" }
            });
            ex = new Exception();
            search.GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                docs = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(1, docs[0].Count);
            Assert.AreEqual("Elementary", docs[0]["School"].AsString());
            ex = new Exception();
            hashRangeTable.DeleteItemAsync(doc1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            ex = new Exception();
            hashRangeTable.DeleteItemAsync(doc2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
        }

        private void TestExpressionPut(Table hashTable)
        {
            var ex = new Exception();
            var ars = new AutoResetEvent(false);

            Document doc = new Document();

            doc["Id"] = DateTime.Now.Ticks;
            doc["name"] = "condition-form";

            hashTable.PutItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Expression expression = new Expression
            {
                ExpressionStatement = "attribute_not_exists(referencecounter) or referencecounter = :cond1",
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                        {
                            {":cond1", 0}
                        }
            };
            PutItemOperationConfig config = new PutItemOperationConfig
            {
                ConditionalExpression = expression
            };

            doc["update-test"] = 1;
            //Utils.AssertTrue(hashTable.TryPutItem(doc, config));
            ex = new Exception();
            hashTable.PutItemAsync(doc, config, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            doc["referencecounter"] = 0;
            hashTable.UpdateItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            doc["update-test"] = null;

            ex = new Exception();
            hashTable.PutItemAsync(doc, config, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Make sure removing attributes works
            ex = new Exception();
            hashTable.GetItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                doc = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Utils.AssertFalse(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            ex = new Exception();
            hashTable.UpdateItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            doc["update-test"] = 3;
            //Utils.AssertFalse(hashTable.TryPutItem(doc, config));
            ex = null;
            hashTable.PutItemAsync(doc, config, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNotNull(ex);

            ex = new Exception();
            hashTable.DeleteItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
        }

        private void TestExpressionUpdate(Table hashTable)
        {
            var ex = new Exception();
            var ars = new AutoResetEvent(false);

            Document doc = new Document();

            doc["Id"] = DateTime.Now.Ticks;
            doc["name"] = "condition-form";
            hashTable.PutItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Expression expression = new Expression
            {
                ExpressionStatement = "attribute_not_exists(referencecounter) or referencecounter = :cond1",
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                        {
                            {":cond1", 0}
                        }
            };
            UpdateItemOperationConfig config = new UpdateItemOperationConfig
            {
                ConditionalExpression = expression
            };

            doc["update-test"] = 1;
            //Utils.AssertTrue(hashTable.TryUpdateItem(doc, config));
            hashTable.UpdateItemAsync(doc, config, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            doc["referencecounter"] = 0;
            ex = new Exception();
            hashTable.UpdateItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            doc["update-test"] = null;
            //Utils.AssertTrue(hashTable.TryUpdateItem(doc, config));
            ex = new Exception();
            hashTable.UpdateItemAsync(doc, config, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Make sure removing attributes works
            hashTable.GetItemAsync(doc, (result) =>
             {
                 ex = result.Exception;
                 doc = result.Result;
                 ars.Set();
             }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Utils.AssertFalse(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            ex = new Exception();
            hashTable.UpdateItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            doc["update-test"] = 3;
            //Utils.AssertFalse(hashTable.TryUpdateItem(doc, config));
            ex = null;
            hashTable.UpdateItemAsync(doc, config, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNotNull(ex);

            ex = new Exception();
            hashTable.GetItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                doc = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Utils.AssertFalse(doc.Contains("update-test"));

            ex = new Exception();
            hashTable.DeleteItemAsync(doc, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
        }


        private bool AreValuesEqual(Document docA, Document docB, DynamoDBEntryConversion conversion = null)
        {
            if (conversion != null)
            {
                docA = docA.ForceConversion(conversion);
                docB = docB.ForceConversion(conversion);
            }

            if (object.ReferenceEquals(docA, docB))
                return true;
            return docA.Equals(docB);
        }
        private void LoadTables(DynamoDBEntryConversion conversion, out Table hashTable, out Table hashRangeTable)
        {
            var ars = new AutoResetEvent(false);
            var ex = new Exception();
            TableCache.Clear();


            // Load table using TryLoadTable API
            hashTable = null;
            Table t = null;
            Table.LoadTableAsync(Client, "FakeHashTableThatShouldNotExist", conversion, (result) =>
            {
                t = result.Result;
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(t);

            ex = new Exception();
            Table.LoadTableAsync(Client, hashTableName, conversion, (result) =>
            {
                t = result.Result;
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.IsNotNull(t);
            hashTable = t;

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
            ex = null;
            Table.LoadTableAsync(Client, "FakeHashRangeTableThatShouldNotExist", conversion, (result) =>
            {
                t = result.Result;
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNotNull(ex);

            Table.LoadTableAsync(Client, hashRangeTableName, conversion, (result) =>
                    {
                        t = result.Result;
                        ex = result.Exception;
                        ars.Set();
                    }, options);
            ars.WaitOne();
            hashRangeTable = t;
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
