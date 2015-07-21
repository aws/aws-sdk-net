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
using CommonTests.Framework;
using System.Threading.Tasks;


namespace CommonTests.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [Test]
        [Category("DynamoDB")]
        public void TestTableOperations()
        {
            RunAsSync(async () =>
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
                    await TestEmptyCollections(hashTable);

                    // Test operations on hash-key table
                    await TestHashTable(hashTable, conversion);

                    // Test operations on hash-and-range-key table
                    await TestHashRangeTable(hashRangeTable, conversion);

                    // Test large batch writes and gets
                    await TestLargeBatchOperations(hashTable);

                    // Test expressions for update
                    await TestExpressionUpdate(hashTable);

                    // Test expressions for put
                    await TestExpressionPut(hashTable);

                    // Test expressions for delete
                    await TestExpressionsOnDelete(hashTable);

                    // Test expressions for query
                    await TestExpressionsOnQuery(hashRangeTable);

                    // Test expressions for scan
                    await TestExpressionsOnScan(hashRangeTable);
                }
            });
        }

        private async Task TestEmptyCollections(Table hashTable)
        {
            Document doc = new Document();
            doc["Id"] = 1;
            doc["EmptyList"] = new DynamoDBList();
            doc["EmptyMap"] = new Document();
            await hashTable.PutItemAsync(doc);

            Document retrieved = await hashTable.GetItemAsync(doc);

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

        private async Task TestHashTable(Table hashTable, DynamoDBEntryConversion conversion)
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
            await hashTable.PutItemAsync(doc);

            // Get the item by hash key
            Document retrieved = await hashTable.GetItemAsync(1);
            Assert.IsFalse(AreValuesEqual(doc, retrieved));
            var convertedDoc = doc.ForceConversion(conversion);
            Assert.IsTrue(AreValuesEqual(convertedDoc, retrieved));

            // Get the item by document
            retrieved = await hashTable.GetItemAsync(doc);
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
            AssertExtensions.ExpectException<InvalidCastException>(() => aliasesRetrieved.AsListOfDocument());

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
            await hashTable.UpdateItemAsync(doc);
            retrieved = await hashTable.GetItemAsync(1);
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
            await AssertExtensions.ExpectExceptionAsync(hashTable.UpdateItemAsync(doc2));
            // Remove circular reference and save new item
            doc2.Remove("Parent");
            await hashTable.UpdateItemAsync(doc2);

            // Scan the hash-key table
            var items = await hashTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.AreEqual(2, items.Count);

            // Scan by pages
            var search = hashTable.Scan(new ScanOperationConfig { Limit = 1 });
            items.Clear();
            while (!search.IsDone)
            {
                var set = await search.GetNextSetAsync();
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
            items = await search.GetRemainingAsync();
            Assert.AreEqual(1, items.Count);

            // Scan for specific tag
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Tags", ScanOperator.Contains, "2.0");
            search = hashTable.Scan(scanFilter);
            items = await search.GetRemainingAsync();
            Assert.AreEqual(1, items.Count);

            // Delete the item by hash key
            await hashTable.DeleteItemAsync(1);
            Assert.IsNull(await hashTable.GetItemAsync(1));

            // Delete the item by document
            await hashTable.DeleteItemAsync(doc2);
            Assert.IsNull(await hashTable.GetItemAsync(doc2));

            // Scan the hash-key table to confirm it is empty
            items = await hashTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.AreEqual(0, items.Count);

            // Batch-put items
            var batchWrite = hashTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(doc);
            batchWrite.AddDocumentToPut(doc2);
            await batchWrite.ExecuteAsync();

            // Batch-get items
            var batchGet = hashTable.CreateBatchGet();
            batchGet.AddKey(1);
            batchGet.AddKey(doc2);
            await batchGet.ExecuteAsync();
            Assert.AreEqual(2, batchGet.Results.Count);

            // Batch-delete items
            batchWrite = hashTable.CreateBatchWrite();
            batchWrite.AddItemToDelete(doc);
            batchWrite.AddKeyToDelete(2);
            await batchWrite.ExecuteAsync();

            // Batch-get non-existent items
            batchGet = hashTable.CreateBatchGet();
            batchGet.AddKey(1);
            batchGet.AddKey(doc2);
            await batchGet.ExecuteAsync();
            Assert.AreEqual(0, batchGet.Results.Count);

            // Scan the hash-key table to confirm it is empty
            items = await hashTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.AreEqual(0, items.Count);
        }
        private async Task TestHashRangeTable(Table hashRangeTable, DynamoDBEntryConversion conversion)
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
            await hashRangeTable.PutItemAsync(doc1);

            // Update a non-existent item creates the item
            Document doc2 = new Document();
            doc2["Name"] = "Chuck";
            doc2["Age"] = 30;
            doc2["Company"] = "Big River";
            doc2["Score"] = 94;
            doc1["IsTester"] = false;
            doc2["Manager"] = "Barbara";
            doc2["Aliases"] = new HashSet<string> { "Charles" };
            await hashRangeTable.UpdateItemAsync(doc2);

            // Save more items
            Document doc3 = new Document();
            doc3["Name"] = "Diane";
            doc3["Age"] = 40;
            doc3["Company"] = "Madeira";
            doc1["IsTester"] = true;
            doc3["Score"] = 140;
            doc3["Manager"] = "Eva";
            await hashRangeTable.UpdateItemAsync(doc3);
            var oldDoc3 = doc3.Clone() as Document;

            // Changing the range key will force a creation of a new item
            doc3["Age"] = 24;
            doc3["Score"] = 101;
            await hashRangeTable.UpdateItemAsync(doc3);

            // Get item
            var retrieved = await hashRangeTable.GetItemAsync("Alan", 31);
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
            retrieved = await hashRangeTable.GetItemAsync(doc2);
            Assert.IsTrue(AreValuesEqual(doc2, retrieved, conversion));
            retrieved = await hashRangeTable.GetItemAsync(oldDoc3, new GetItemOperationConfig { ConsistentRead = true });
            Assert.IsTrue(AreValuesEqual(oldDoc3, retrieved, conversion));
            retrieved = await hashRangeTable.GetItemAsync("Diane", 24, new GetItemOperationConfig { ConsistentRead = true });
            Assert.IsTrue(AreValuesEqual(doc3, retrieved, conversion));

            // Scan the hash-and-range-key table
            var items = await hashRangeTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.AreEqual(4, items.Count);

            // Scan by pages
            var search = hashRangeTable.Scan(new ScanOperationConfig { Limit = 1 });
            items.Clear();
            while(!search.IsDone)
            {
                var set = await search.GetNextSetAsync();
                items.AddRange(set);
            }
            Assert.AreEqual(4, items.Count);

            // Scan in parallel
            var segment1 = await hashRangeTable.Scan(new ScanOperationConfig { Segment = 0, TotalSegments = 2 }).GetRemainingAsync();
            var segment2 = await hashRangeTable.Scan(new ScanOperationConfig { Segment = 1, TotalSegments = 2 }).GetRemainingAsync();
            Assert.AreEqual(4, segment1.Count + segment2.Count);

            // Query items
            items = await hashRangeTable.Query("Diane", new QueryFilter()).GetRemainingAsync();
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
            items = await hashRangeTable.Query(queryConfig).GetRemainingAsync();
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
            items = await hashRangeTable.Query(queryConfig).GetRemainingAsync();
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
            items = await hashRangeTable.Query(queryConfig).GetRemainingAsync();
            Assert.AreEqual(1, items.Count);



            // Query local index
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Diane")
            }).GetRemainingAsync();
            Assert.AreEqual(2, items.Count);

            // Query global index
            var queryFilter = new QueryFilter("Company", QueryOperator.Equal, "Big River");
            queryFilter.AddCondition("Score", QueryOperator.GreaterThan, 100);
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemainingAsync();
            Assert.AreEqual(1, items.Count);

            // Scan local index
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Name", ScanOperator.Equal, "Diane");
            items = await hashRangeTable.Scan(new ScanOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = scanFilter
            }).GetRemainingAsync();
            Assert.AreEqual(2, items.Count);

            // Scan global index
            scanFilter = new ScanFilter();
            scanFilter.AddCondition("Company", ScanOperator.Equal, "Big River");
            scanFilter.AddCondition("Score", ScanOperator.GreaterThan, 100);
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemainingAsync();
            Assert.AreEqual(1, items.Count);
        }
        private async Task TestLargeBatchOperations(Table hashTable)
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
            await batchWrite.ExecuteAsync();

            UtilityMethods.Sleep(TimeSpan.FromSeconds(1)); // Wait for the eventual consistence of the batch add to catch up.
           
            // Scan table, but retrieve only keys
            var ids = await hashTable.Scan(new ScanOperationConfig
            {
                AttributesToGet = new List<string> { "Id" },
                Select = SelectValues.SpecificAttributes
            }).GetRemainingAsync();
            Assert.AreEqual(itemCount, ids.Count);

            // Batch-get all items
            var batchGet = hashTable.CreateBatchGet();
            foreach (var id in ids)
                batchGet.AddKey(id);
            await batchGet.ExecuteAsync();
            Assert.AreEqual(itemCount, batchGet.Results.Count);

            // Batch-delete all items
            batchWrite = hashTable.CreateBatchWrite();
            foreach (var id in ids)
                batchWrite.AddKeyToDelete(id);
            await batchWrite.ExecuteAsync();

            UtilityMethods.Sleep(TimeSpan.FromSeconds(1)); // Wait for the eventual consistence of the batch add to catch up.

            // Scan table to confirm it is empty
            var items = await hashTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.AreEqual(0, items.Count);
        }

        private async Task TestExpressionsOnDelete(Table hashTable)
        {
            Document doc1 = new Document();
            doc1["Id"] = 13;
            doc1["Price"] = 6;
            await hashTable.PutItemAsync(doc1);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Price > :price";
            expression.ExpressionAttributeValues[":price"] = 7;

            DeleteItemOperationConfig config = new DeleteItemOperationConfig();
            config.ConditionalExpression = expression;

            //Assert.IsFalse(hashTable.TryDeleteItem(doc1, config));
            await AssertExtensions.ExpectExceptionAsync(hashTable.DeleteItemAsync(doc1, config));

            expression.ExpressionAttributeValues[":price"] = 4;
            //Assert.IsTrue(hashTable.TryDeleteItem(doc1, config));
            await hashTable.DeleteItemAsync(doc1, config);
        }

        private async Task TestExpressionsOnQuery(Table hashRangeTable)
        {
            Document doc1 = new Document();
            doc1["Name"] = "Gunnar";
            doc1["Age"] = 77;
            doc1["Job"] = "Retired";
            await hashRangeTable.PutItemAsync(doc1);

            Document doc2 = new Document();
            doc2["Name"] = "Gunnar";
            doc2["Age"] = 45;
            doc2["Job"] = "Electrician";
            await hashRangeTable.PutItemAsync(doc2);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Job = :job";
            expression.ExpressionAttributeValues[":job"] = "Retired";

            var search = hashRangeTable.Query("Gunnar", expression);
            var docs = await search.GetRemainingAsync();
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(77, docs[0]["Age"].AsInt());

            search = hashRangeTable.Query(new QueryOperationConfig
            {
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Gunnar"),
                FilterExpression = expression,
                AttributesToGet = new List<string> { "Age" },
                Select = SelectValues.SpecificAttributes
            });
            docs = await search.GetRemainingAsync();
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(1, docs[0].Count);
            Assert.AreEqual(77, docs[0]["Age"].AsInt());

            await hashRangeTable.DeleteItemAsync(doc1);
            await hashRangeTable.DeleteItemAsync(doc2);
        }

        private async Task TestExpressionsOnScan(Table hashRangeTable)
        {
            await ClearTable(hashRangeTableName);

            Document doc1 = new Document();
            doc1["Name"] = "Lewis";
            doc1["Age"] = 6;
            doc1["School"] = "Elementary";
            await hashRangeTable.PutItemAsync(doc1);

            Document doc2 = new Document();
            doc2["Name"] = "Frida";
            doc2["Age"] = 3;
            doc2["School"] = "Preschool";
            await hashRangeTable.PutItemAsync(doc2);

            Expression expression = new Expression();
            expression.ExpressionStatement = "Age > :age";
            expression.ExpressionAttributeValues[":age"] = 5;

            var search = hashRangeTable.Scan(expression);
            var docs = await search.GetRemainingAsync();
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual("Elementary", docs[0]["School"].AsString());

            search = hashRangeTable.Scan(new ScanOperationConfig
            {
                FilterExpression = expression,
                Select = SelectValues.SpecificAttributes,
                AttributesToGet = new List<string> { "School" }
            });
            docs = await search.GetRemainingAsync();
            Assert.AreEqual(1, docs.Count);
            Assert.AreEqual(1, docs[0].Count);
            Assert.AreEqual("Elementary", docs[0]["School"].AsString());

            await hashRangeTable.DeleteItemAsync(doc1);
            await hashRangeTable.DeleteItemAsync(doc2);
        }

        private async Task TestExpressionPut(Table hashTable)
        {
            Document doc = new Document();

            doc["Id"] = DateTime.Now.Ticks;
            doc["name"] = "condition-form";
            await hashTable.PutItemAsync(doc);

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
            //Assert.IsTrue(hashTable.TryPutItem(doc, config));
            await hashTable.PutItemAsync(doc, config);

            doc["referencecounter"] = 0;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = null;
            //Assert.IsTrue(hashTable.TryPutItem(doc, config));
            await hashTable.PutItemAsync(doc, config);

            // Make sure removing attributes works
            doc = await hashTable.GetItemAsync(doc);
            Assert.IsFalse(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = 3;
            //Assert.IsFalse(hashTable.TryPutItem(doc, config));
            await AssertExtensions.ExpectExceptionAsync(hashTable.PutItemAsync(doc, config));

            await hashTable.DeleteItemAsync(doc);
        }

        private async Task TestExpressionUpdate(Table hashTable)
        {
            Document doc = new Document();

            doc["Id"] = DateTime.Now.Ticks;
            doc["name"] = "condition-form";
            await hashTable.PutItemAsync(doc);

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
            //Assert.IsTrue(hashTable.TryUpdateItem(doc, config));
            await hashTable.UpdateItemAsync(doc, config);

            doc["referencecounter"] = 0;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = null;
            //Assert.IsTrue(hashTable.TryUpdateItem(doc, config));
            await hashTable.UpdateItemAsync(doc, config);

            // Make sure removing attributes works
            doc = await hashTable.GetItemAsync(doc);
            Assert.IsFalse(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = 3;
            //Assert.IsFalse(hashTable.TryUpdateItem(doc, config));
            await AssertExtensions.ExpectExceptionAsync(hashTable.UpdateItemAsync(doc, config));

            doc = await hashTable.GetItemAsync(doc);
            Assert.IsFalse(doc.Contains("update-test"));

            await hashTable.DeleteItemAsync(doc);
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
