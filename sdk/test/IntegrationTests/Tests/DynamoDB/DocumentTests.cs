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
using ThirdParty.Json.LitJson;
using System.Xml;


namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [TestMethod]
        [TestCategory("DynamoDB")]
        public void TestTableOperations()
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

                // Test Query and Scan manual pagination
                TestPagination(hashRangeTable);
            }
        }

        private void TestPagination(Table hashRangeTable)
        {
            var itemCount = 10;
            var batchWrite = hashRangeTable.CreateBatchWrite();
            var name = "Borg";
            // Put items
            for (int i = 0; i < itemCount; i++)
            {
                Document doc = new Document();
                doc["Name"] = name;
                doc["Age"] = 1 + i;
                doc["Company"] = "Big River";
                doc["Score"] = 120 + i;
                doc["IsTester"] = true;
                doc["Manager"] = "Kirk";
                batchWrite.AddDocumentToPut(doc);
            }
            batchWrite.Execute();

            // Paginated scan
            {
                var request = new ScanOperationConfig
                {
                    Limit = 1
                };
                var search = hashRangeTable.Scan(request);
                var tokens = new List<string>();
                var retrievedCount = VerifyPagination(search, tokens);
                Assert.AreEqual(retrievedCount, itemCount);
                Assert.AreEqual(itemCount, tokens.Count);

                var token4 = tokens[4];
                var token5 = tokens[5];
                search = hashRangeTable.Scan(new ScanOperationConfig
                {
                    Limit = 1,
                    PaginationToken = token4
                });
                search.GetNextSet();
                Assert.AreNotEqual(token4, search.PaginationToken);
                Assert.AreEqual(token5, search.PaginationToken);
            }

            // Paginated query
            {
                var filter = new QueryFilter("Name", QueryOperator.Equal, name);
                var request = new QueryOperationConfig
                {
                    Limit = 1,
                    Filter = filter
                };
                var search = hashRangeTable.Query(request);

                var tokens = new List<string>();
                var retrievedCount = VerifyPagination(search, tokens);
                Assert.AreEqual(retrievedCount, itemCount);
                Assert.AreEqual(itemCount, tokens.Count);

                var token4 = tokens[4];
                var token5 = tokens[5];
                search = hashRangeTable.Query(new QueryOperationConfig
                {
                    Limit = 1,
                    Filter = filter,
                    PaginationToken = token4
                });
                search.GetNextSet();
                Assert.AreNotEqual(token4, search.PaginationToken);
                Assert.AreEqual(token5, search.PaginationToken);
            }
        }

        private static int VerifyPagination(Search search, List<string> tokens)
        {
            int count = 0;
            do
            {
                var items = search.GetNextSet();
                var token = search.PaginationToken;
                count += items.Count;

                if (!search.IsDone)
                {
                    tokens.Add(token);
                    Assert.AreNotEqual(0, items.Count);
                    Assert.IsFalse(string.IsNullOrEmpty(token));
                }
            } while (!search.IsDone);

            return count;
        }

        private void TestEmptyCollections(Table hashTable)
        {
            Document doc = new Document();
            doc["Id"] = 1;
            doc["EmptyList"] = new DynamoDBList();
            doc["EmptyMap"] = new Document();
            hashTable.PutItem(doc);

            Document retrieved = hashTable.GetItem(doc);

            DynamoDBEntry mapEntry;
            Assert.IsTrue(retrieved.TryGetValue("EmptyMap", out mapEntry));
            Assert.IsNotNull(mapEntry);
            Assert.IsNotNull(mapEntry.AsDocument());
            Assert.AreEqual(0, mapEntry.AsDocument().Count);

            DynamoDBEntry listEntry;
            Assert.IsTrue(retrieved.TryGetValue("EmptyList", out listEntry));
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
            hashTable.PutItem(doc);

            // Get the item by hash key
            Document retrieved = hashTable.GetItem(1);
            Assert.IsFalse(AreValuesEqual(doc, retrieved));
            var convertedDoc = doc.ForceConversion(conversion);
            Assert.IsTrue(AreValuesEqual(convertedDoc, retrieved));

            // Get the item by document
            retrieved = hashTable.GetItem(doc);
            // Verify retrieved document
            Assert.IsTrue(AreValuesEqual(convertedDoc, retrieved, conversion));
            var tagsRetrieved = retrieved["Tags"];
            Assert.IsTrue(tagsRetrieved is PrimitiveList);
            Assert.AreEqual(2, tagsRetrieved.AsPrimitiveList().Entries.Count);
            // Test bool storage for different conversions
            var isPublicRetrieved = retrieved["IsPublic"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.AreEqual("1", isPublicRetrieved.AsPrimitive().Value as string);
            else
                Assert.IsTrue(isPublicRetrieved is DynamoDBBool);
            // Test HashSet<string> storage for different conversions
            var aliasesRetrieved = retrieved["Aliases"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.AreEqual(2, aliasesRetrieved.AsPrimitiveList().Entries.Count);
            else
                Assert.AreEqual(2, aliasesRetrieved.AsDynamoDBList().Entries.Count);
            List<Document> developers = retrieved["Developers"].AsListOfDocument();
            Assert.AreEqual(2, developers.Count);
            AssertExtensions.ExpectException(() => aliasesRetrieved.AsListOfDocument(), typeof(InvalidCastException));

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
            hashTable.UpdateItem(doc);
            retrieved = hashTable.GetItem(1);
            Assert.IsFalse(AreValuesEqual(doc, retrieved, conversion));
            doc.Remove("Garbage");
            Assert.IsTrue(AreValuesEqual(doc, retrieved, conversion));
            developers = retrieved["Developers"].AsListOfDocument();
            Assert.AreEqual(1, developers.Count);

            // Create new, circularly-referencing item            
            Document doc2 = doc.ForceConversion(conversion);
            doc2["Id"] = doc2["Id"].AsInt() + 1;
            doc2["Price"] = 94;
            doc2["Tags"] = null;
            doc2["IsPublic"] = false;
            doc2["Parent"] = doc2;
            AssertExtensions.ExpectException(() => hashTable.UpdateItem(doc2));
            // Remove circular reference and save new item
            doc2.Remove("Parent");
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
        private void TestHashRangeTable(Table hashRangeTable, DynamoDBEntryConversion conversion)
        {
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
            hashRangeTable.PutItem(doc1);

            // Update a non-existent item creates the item
            Document doc2 = new Document();
            doc2["Name"] = "Chuck";
            doc2["Age"] = 30;
            doc2["Company"] = "Big River";
            doc2["Score"] = 94;
            doc1["IsTester"] = false;
            doc2["Manager"] = "Barbara";
            doc2["Aliases"] = new HashSet<string> { "Charles" };
            hashRangeTable.UpdateItem(doc2);

            // Save more items
            Document doc3 = new Document();
            doc3["Name"] = "Diane";
            doc3["Age"] = 40;
            doc3["Company"] = "Madeira";
            doc1["IsTester"] = true;
            doc3["Score"] = 140;
            doc3["Manager"] = "Eva";
            hashRangeTable.UpdateItem(doc3);
            var oldDoc3 = doc3.Clone() as Document;

            // Changing the range key will force a creation of a new item
            doc3["Age"] = 24;
            doc3["Score"] = 101;
            hashRangeTable.UpdateItem(doc3);

            // Get item
            var retrieved = hashRangeTable.GetItem("Alan", 31);
            // Verify retrieved document
            Assert.IsTrue(AreValuesEqual(doc1, retrieved, conversion));
            var tagsRetrieved = retrieved["Aliases"];
            Assert.IsTrue(tagsRetrieved is PrimitiveList);
            Assert.AreEqual(2, tagsRetrieved.AsPrimitiveList().Entries.Count);
            // Test bool storage for different conversions
            var isTesterRetrieved = retrieved["IsTester"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.AreEqual("1", isTesterRetrieved.AsPrimitive().Value as string);
            else
                Assert.IsTrue(isTesterRetrieved is DynamoDBBool);
            // Test HashSet<string> storage for different conversions
            var pastManagersRetrieved = retrieved["PastManagers"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.AreEqual(2, pastManagersRetrieved.AsPrimitiveList().Entries.Count);
            else
                Assert.AreEqual(2, pastManagersRetrieved.AsDynamoDBList().Entries.Count);

            // Get item using GetItem overloads that expect a key in different ways
            retrieved = hashRangeTable.GetItem(doc2);
            Assert.IsTrue(AreValuesEqual(doc2, retrieved, conversion));
            retrieved = hashRangeTable.GetItem(oldDoc3, new GetItemOperationConfig { ConsistentRead = true });
            Assert.IsTrue(AreValuesEqual(oldDoc3, retrieved, conversion));
            retrieved = hashRangeTable.GetItem("Diane", 24, new GetItemOperationConfig { ConsistentRead = true });
            Assert.IsTrue(AreValuesEqual(doc3, retrieved, conversion));

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
            items = hashRangeTable.Query(queryConfig).GetRemaining();
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
            items = hashRangeTable.Query(queryConfig).GetRemaining();
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
            items = hashRangeTable.Query(queryConfig).GetRemaining();
            Assert.AreEqual(1, items.Count);



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

            // Scan local index
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Name", ScanOperator.Equal, "Diane");
            items = hashRangeTable.Scan(new ScanOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = scanFilter
            }).GetRemaining();
            Assert.AreEqual(2, items.Count);

            // Scan global index
            scanFilter = new ScanFilter();
            scanFilter.AddCondition("Company", ScanOperator.Equal, "Big River");
            scanFilter.AddCondition("Score", ScanOperator.GreaterThan, 100);
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

            Thread.Sleep(TimeSpan.FromSeconds(1)); // Wait for the eventual consistence of the batch add to catch up.
           
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

        private void TestExpressionsOnDelete(Table hashTable)
        {
            Document doc1 = new Document();
            doc1["Id"] = 13;
            doc1["Price"] = 6;
            hashTable.PutItem(doc1);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Price > :price";
            expression.ExpressionAttributeValues[":price"] = 7;

            DeleteItemOperationConfig config = new DeleteItemOperationConfig();
            config.ConditionalExpression = expression;

            Assert.IsFalse(hashTable.TryDeleteItem(doc1, config));

            expression.ExpressionAttributeValues[":price"] = 4;
            Assert.IsTrue(hashTable.TryDeleteItem(doc1, config));
        }

        private void TestExpressionsOnQuery(Table hashRangeTable)
        {
            Document doc1 = new Document();
            doc1["Name"] = "Gunnar";
            doc1["Age"] = 77;
            doc1["Job"] = "Retired";
            hashRangeTable.PutItem(doc1);

            Document doc2 = new Document();
            doc2["Name"] = "Gunnar";
            doc2["Age"] = 45;
            doc2["Job"] = "Electrician";
            hashRangeTable.PutItem(doc2);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Job = :job";
            expression.ExpressionAttributeValues[":job"] = "Retired";

            var search = hashRangeTable.Query("Gunnar", expression);
            var docs = search.GetRemaining();
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(77, docs[0]["Age"].AsInt());

            search = hashRangeTable.Query(new QueryOperationConfig
            {
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Gunnar"),
                FilterExpression = expression,
                AttributesToGet = new List<string> { "Age" },
                Select = SelectValues.SpecificAttributes
            });
            docs = search.GetRemaining();
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(1, docs[0].Count);
            Assert.AreEqual(77, docs[0]["Age"].AsInt());

            hashRangeTable.DeleteItem(doc1);
            hashRangeTable.DeleteItem(doc2);
        }

        private void TestExpressionsOnScan(Table hashRangeTable)
        {
            ClearTable(hashRangeTableName);

            Document doc1 = new Document();
            doc1["Name"] = "Lewis";
            doc1["Age"] = 6;
            doc1["School"] = "Elementary";
            hashRangeTable.PutItem(doc1);

            Document doc2 = new Document();
            doc2["Name"] = "Frida";
            doc2["Age"] = 3;
            doc2["School"] = "Preschool";
            hashRangeTable.PutItem(doc2);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Age > :age";
            expression.ExpressionAttributeValues[":age"] = 5;

            var search = hashRangeTable.Scan(expression);
            var docs = search.GetRemaining();
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual("Elementary", docs[0]["School"].AsString());

            search = hashRangeTable.Scan(new ScanOperationConfig
            {
                FilterExpression = expression,
                Select = SelectValues.SpecificAttributes,
                AttributesToGet = new List<string> { "School" }
            });
            docs = search.GetRemaining();
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(1, docs[0].Count);
            Assert.AreEqual("Elementary", docs[0]["School"].AsString());

            hashRangeTable.DeleteItem(doc1);
            hashRangeTable.DeleteItem(doc2);
        }

        private void TestExpressionPut(Table hashTable)
        {
            Document doc = new Document();

            doc["Id"] = DateTime.Now.Ticks;
            doc["name"] = "condition-form";
            hashTable.PutItem(doc);

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
            Assert.IsTrue(hashTable.TryPutItem(doc, config));

            doc["referencecounter"] = 0;
            hashTable.UpdateItem(doc);

            doc["update-test"] = null;
            Assert.IsTrue(hashTable.TryPutItem(doc, config));

            // Make sure removing attributes works
            doc = hashTable.GetItem(doc);
            Assert.IsFalse(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            hashTable.UpdateItem(doc);

            doc["update-test"] = 3;
            Assert.IsFalse(hashTable.TryPutItem(doc, config));

            hashTable.DeleteItem(doc);
        }

        private void TestExpressionUpdate(Table hashTable)
        {
            Document doc = new Document();

            doc["Id"] = DateTime.Now.Ticks;
            doc["name"] = "condition-form";
            hashTable.PutItem(doc);

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
            Assert.IsTrue(hashTable.TryUpdateItem(doc, config));

            doc["referencecounter"] = 0;
            hashTable.UpdateItem(doc);

            doc["update-test"] = null;
            Assert.IsTrue(hashTable.TryUpdateItem(doc, config));

            // Make sure removing attributes works
            doc = hashTable.GetItem(doc);
            Assert.IsFalse(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            hashTable.UpdateItem(doc);

            doc["update-test"] = 3;
            Assert.IsFalse(hashTable.TryUpdateItem(doc, config));

            doc = hashTable.GetItem(doc);
            Assert.IsFalse(doc.Contains("update-test"));

            hashTable.DeleteItem(doc);
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
            TableCache.Clear();

            using (var counter = CountServiceResponses(Client))
            {
                // Load table using TryLoadTable API
                hashTable = null;
                Assert.IsFalse(Table.TryLoadTable(Client, "FakeHashTableThatShouldNotExist", conversion, out hashTable));
                Assert.AreEqual(0, counter.ResponseCount);
                Assert.IsTrue(Table.TryLoadTable(Client, hashTableName, conversion, out hashTable));
                Assert.AreEqual(1, counter.ResponseCount);

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
                AssertExtensions.ExpectException(() => Table.LoadTable(Client, "FakeHashRangeTableThatShouldNotExist", conversion));
                Assert.AreEqual(1, counter.ResponseCount);
                hashRangeTable = Table.LoadTable(Client, hashRangeTableName, conversion);
                Assert.AreEqual(2, counter.ResponseCount);
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
}
