using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using System.IO;
using ReturnValuesOnConditionCheckFailure = Amazon.DynamoDBv2.DocumentModel.ReturnValuesOnConditionCheckFailure;
using Amazon;


namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestTableOperations()
        {
            foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                // Clear tables
                CleanupTables();

                ITable hashTable;
                ITable hashRangeTable;
                ITable numericHashRangeTable;

                // Load tables using provided conversion schema
                LoadTables(conversion, out hashTable, out hashRangeTable, out numericHashRangeTable);

                TestEmptyString(hashTable);

                // Test saving and loading empty lists and maps
                TestEmptyCollections(hashTable);

                // Test operations on hash-key table
                TestHashTable(hashTable, conversion);

                // Test operations on hash-and-range-key table
                TestHashRangeTable(hashRangeTable, conversion);

                // Test using multiple test batch writer
                TestMultiTableDocumentBatchWrite(hashTable, hashRangeTable);

                // Test multi-table transactional operations
                TestMultiTableDocumentTransactWrite(hashTable, hashRangeTable, conversion);

                // Test large batch writes and gets
                TestLargeBatchOperations(hashTable);

                // Test expressions for update
                TestExpressionUpdate(hashTable);

                // Test expressions for put
                TestExpressionPut(hashTable);
                TestExpressionPutWithoutValues(hashTable);

                // Test expressions for delete
                TestExpressionsOnDelete(hashTable);

                // Test expressions for transactional operations
                TestExpressionsOnTransactWrite(hashTable, conversion);

                // Test expressions for query
                TestExpressionsOnQuery(hashRangeTable);

                // Test expressions for scan
                TestExpressionsOnScan(hashRangeTable);

                // Test Query and Scan manual pagination
                TestPagination(hashRangeTable);

                // Test storing some attributes as epoch seconds
                TestStoreAsEpoch(hashRangeTable, numericHashRangeTable);

                // Test that attributes stored as Datetimes can be retrieved in UTC.
                TestAsDateTimeUtc(numericHashRangeTable);

                // Test Count on Query
                TestSelectCountOnQuery(hashTable);
            }
        }

        /// <summary>
        /// Runs the same tests as <see cref="TestTableOperations"/>, but with 
        /// static table definitions that avoid the internal <see cref="IAmazonDynamoDB.DescribeTable(string)" /> call to populate the cache
        /// </summary>
        [TestMethod]
        public void TestTableOperationsViaBuilder()
        {
            foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                // Clear tables
                CleanupTables();

                var hashTable = new TableBuilder(Client, "DotNetTests-HashTable", conversion, true, null)
                    .AddHashKey("Id", DynamoDBEntryType.Numeric)
                    .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Price", DynamoDBEntryType.Numeric)
                    .Build();


                var hashRangeTable = new TableBuilder(Client, "DotNetTests-HashRangeTable", conversion, true, null)
                    .AddHashKey("Name", DynamoDBEntryType.String)
                    .AddRangeKey("Age", DynamoDBEntryType.Numeric)
                    .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Score", DynamoDBEntryType.Numeric)
                    .AddLocalSecondaryIndex("LocalIndex", "Manager", DynamoDBEntryType.String)
                    .Build();
                
                var numericHashRangeTable = new TableBuilder(Client, "DotNetTests-NumericHashRangeTable", conversion, true, null)
                    .AddHashKey("CreationTime", DynamoDBEntryType.Numeric)
                    .AddRangeKey("Name", DynamoDBEntryType.String)
                    .Build();

                TestEmptyString(hashTable);

                // Test saving and loading empty lists and maps
                TestEmptyCollections(hashTable);

                // Test operations on hash-key table
                TestHashTable(hashTable, conversion);

                // Test operations on hash-and-range-key table
                TestHashRangeTable(hashRangeTable, conversion);

                // Test using multiple test batch writer
                TestMultiTableDocumentBatchWrite(hashTable, hashRangeTable);

                // Test multi-table transactional operations
                TestMultiTableDocumentTransactWrite(hashTable, hashRangeTable, conversion);

                // Test large batch writes and gets
                TestLargeBatchOperations(hashTable);

                // Test expressions for update
                TestExpressionUpdate(hashTable);

                // Test expressions for put
                TestExpressionPut(hashTable);
                TestExpressionPutWithoutValues(hashTable);

                // Test expressions for delete
                TestExpressionsOnDelete(hashTable);

                // Test expressions for transactional operations
                TestExpressionsOnTransactWrite(hashTable, conversion);

                // Test expressions for query
                TestExpressionsOnQuery(hashRangeTable);

                // Test expressions for scan
                TestExpressionsOnScan(hashRangeTable);

                // Test Query and Scan manual pagination
                TestPagination(hashRangeTable);

                // Test storing some attributes as epoch seconds
                TestStoreAsEpoch(hashRangeTable, numericHashRangeTable);

                // Test that attributes stored as Datetimes can be retrieved in UTC.
                TestAsDateTimeUtc(numericHashRangeTable);
            }
        }

        private void TestAsDateTimeUtc(ITable numericHashRangeTable)
        {
            var config = new TableConfig(numericHashRangeTable.TableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2" },
                AttributesToStoreAsEpochLong = new List<string> { "LongEpochDate" }
            };
#pragma warning disable CS0618 // Disable the warning for the deprecated DynamoDBContext constructors
            var numericEpochTable = Table.LoadTable(Client, config);
#pragma warning restore CS0618 // Re-enable the warning

            // Capture current time
            var currTime = DateTime.Now;
            var currTimeUtc = currTime.ToUniversalTime();
            var longEpochTimeUtc = new DateTime(2039, 1, 1, 13, 56, 34).ToUniversalTime();

            // Save Item
            var doc = new Document();
            doc["Name"] = "Bob";
            doc["Age"] = 42;
            doc["CreationTime"] = currTime;
            doc["EpochDate2"] = currTime;
            doc["NonEpochDate"] = currTime;
            doc["LongEpochDate"] = longEpochTimeUtc;
            numericEpochTable.PutItem(doc);

            // Load Item
            var storedDoc = numericEpochTable.GetItem(currTime, "Bob", new GetItemOperationConfig { ConsistentRead = true});
            ApproximatelyEqual(currTimeUtc, storedDoc["CreationTime"].AsDateTimeUtc());
            ApproximatelyEqual(currTimeUtc, storedDoc["EpochDate2"].AsDateTimeUtc());
            ApproximatelyEqual(currTimeUtc, storedDoc["NonEpochDate"].AsDateTimeUtc());
            ApproximatelyEqual(longEpochTimeUtc, storedDoc["LongEpochDate"].AsDateTimeUtc());
        }

        private void TestEmptyString(ITable hashTable)
        {
            var companyInfo = new DynamoDBList();
            companyInfo.Add(string.Empty);

            var product = new Document
            {
                ["Id"] = 1,
                ["Name"] = string.Empty,
                ["Components"] = new List<string> // SS
                {
                    string.Empty
                },
                ["CompanyInfo"] = new DynamoDBList() // L
                {
                    Entries = { string.Empty }
                },
                ["Map"] = new Document() // M
                {
                    {"Position", string.Empty}
                }
            };
            hashTable.PutItem(product);

            var savedProduct = hashTable.GetItem(1);

            Assert.AreEqual(1, savedProduct["Id"].AsInt());
            Assert.AreEqual(string.Empty, savedProduct["Name"].AsString());
            Assert.AreEqual(string.Empty, savedProduct["Components"].AsListOfString()[0]);
            Assert.AreEqual(string.Empty, savedProduct["CompanyInfo"].AsListOfDynamoDBEntry()[0].AsString());
            Assert.AreEqual(string.Empty, savedProduct["Map"].AsDocument()["Position"].AsString());
        }

        private void TestPagination(ITable hashRangeTable)
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

        private static int VerifyPagination(ISearch search, List<string> tokens)
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

        private void TestEmptyCollections(ITable hashTable)
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

        private void TestHashTable(ITable hashTable, DynamoDBEntryConversion conversion)
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

            // Transact-put items
            var transactWrite = hashTable.CreateTransactWrite();
            doc["Garbage"] = "asdf";
            Assert.AreEqual("asdf", doc["Garbage"].AsString());
            doc2["Garbage"] = "hjkl";
            Assert.AreEqual("hjkl", doc2["Garbage"].AsString());
            transactWrite.AddDocumentToPut(doc);
            transactWrite.AddDocumentToPut(doc2);
            transactWrite.Execute();

            // Transact-get items
            var transactGet = hashTable.CreateTransactGet();
            transactGet.AddKey(1);
            transactGet.AddKey(doc2);
            transactGet.Execute();
            Assert.AreEqual(2, transactGet.Results.Count);
            Assert.IsTrue(AreValuesEqual(doc, transactGet.Results[0], conversion));
            // Remove Tags attribute before comparison, because it has a null value, so it was not added
            doc2.Remove("Tags");
            Assert.IsTrue(AreValuesEqual(doc2, transactGet.Results[1], conversion));

            // Transact-update items
            transactWrite = hashTable.CreateTransactWrite();
            doc["Price"] = doc["Price"].AsInt() + 1;
            doc["Garbage"] = null;
            Assert.IsNull(doc["Garbage"].AsString());
            transactWrite.AddDocumentToUpdate(doc);
            transactWrite.AddDocumentToUpdate(new Document
            {
                ["Price"] = doc2["Price"].AsInt() + 1,
                ["Garbage"] = null
            }, 2);
            transactWrite.Execute();

            // Transact-get updated items
            transactGet = hashTable.CreateTransactGet();
            transactGet.AddKey(doc);
            transactGet.AddKey(2);
            transactGet.Execute();
            Assert.AreEqual(2, transactGet.Results.Count);
            Assert.IsFalse(AreValuesEqual(doc, transactGet.Results[0], conversion));
            doc.Remove("Garbage");
            Assert.IsTrue(AreValuesEqual(doc, transactGet.Results[0], conversion));
            Assert.IsFalse(AreValuesEqual(doc2, transactGet.Results[1], conversion));
            doc2["Price"] = doc2["Price"].AsInt() + 1;
            doc2.Remove("Garbage");
            Assert.IsTrue(AreValuesEqual(doc2, transactGet.Results[1], conversion));

            // Transact-delete items
            transactWrite = hashTable.CreateTransactWrite();
            transactWrite.AddItemToDelete(doc);
            transactWrite.AddKeyToDelete(2);
            transactWrite.Execute();

            // Transact-get non-existent items
            transactGet = hashTable.CreateTransactGet();
            transactGet.AddKey(1);
            transactGet.AddKey(doc2);
            transactGet.Execute();
            Assert.AreEqual(0, transactGet.Results.Count);

            // Scan the hash-key table to confirm it is empty
            items = hashTable.Scan(new ScanFilter()).GetRemaining();
            Assert.AreEqual(0, items.Count);
        }
        private void TestHashRangeTable(ITable hashRangeTable, DynamoDBEntryConversion conversion)
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
        private void TestLargeBatchOperations(ITable hashTable)
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

        private void TestMultiTableDocumentBatchWrite(ITable hashTable, ITable hashRangeTable)
        {
            var multiTableDocumentBatchWrite = new MultiTableDocumentBatchWrite();

            var doc1a = new Document();
            doc1a["Id"] = 5101;
            doc1a["Data"] = Guid.NewGuid().ToString();
            var doc1b = new Document();
            doc1b["Id"] = 5102;
            doc1b["Data"] = Guid.NewGuid().ToString();
            {
                var writer = hashTable.CreateBatchWrite();
                writer.AddDocumentToPut(doc1a);
                writer.AddDocumentToPut(doc1b);
                multiTableDocumentBatchWrite.AddBatch(writer);
            }

            var doc2a = new Document();
            doc2a["Id"] = 5201;
            doc2a["Data"] = Guid.NewGuid().ToString();
            var doc2b = new Document();
            doc2b["Id"] = 5202;
            doc2b["Data"] = Guid.NewGuid().ToString();
            {
                var writer = hashTable.CreateBatchWrite();
                writer.AddDocumentToPut(doc2a);
                writer.AddDocumentToPut(doc2b);
                multiTableDocumentBatchWrite.AddBatch(writer);
            }

            var doc3a = new Document();
            doc3a["Name"] = "Gunnar";
            doc3a["Age"] = 77;
            doc3a["Job"] = "Retired";
            doc3a["Data"] = Guid.NewGuid().ToString();
            {
                var writer = hashRangeTable.CreateBatchWrite();
                writer.AddDocumentToPut(doc3a);
                multiTableDocumentBatchWrite.AddBatch(writer);
            }


            multiTableDocumentBatchWrite.Execute();

            Document getDoc;

            getDoc = hashTable.GetItem(5101);
            Assert.AreEqual(doc1a["Data"].AsString(), getDoc["Data"].AsString());

            getDoc = hashTable.GetItem(5102);
            Assert.AreEqual(doc1b["Data"].AsString(), getDoc["Data"].AsString());

            getDoc = hashTable.GetItem(5201);
            Assert.AreEqual(doc2a["Data"].AsString(), getDoc["Data"].AsString());

            getDoc = hashTable.GetItem(5202);
            Assert.AreEqual(doc2b["Data"].AsString(), getDoc["Data"].AsString());

            getDoc = hashRangeTable.GetItem("Gunnar", 77);
            Assert.AreEqual(doc3a["Data"].AsString(), getDoc["Data"].AsString());

            multiTableDocumentBatchWrite = new MultiTableDocumentBatchWrite();
            {
                var deleteWriter = hashTable.CreateBatchWrite();
                deleteWriter.AddItemToDelete(doc1a);
                deleteWriter.AddItemToDelete(doc1b);
                deleteWriter.AddItemToDelete(doc2a);
                deleteWriter.AddItemToDelete(doc2b);
                multiTableDocumentBatchWrite.AddBatch(deleteWriter);
            }
            {
                var deleteWriter = hashRangeTable.CreateBatchWrite();
                deleteWriter.AddItemToDelete(doc3a);
                multiTableDocumentBatchWrite.AddBatch(deleteWriter);
            }
            multiTableDocumentBatchWrite.Execute();
        }

        private void TestMultiTableDocumentTransactWrite(ITable hashTable, ITable hashRangeTable, DynamoDBEntryConversion conversion)
        {
            // Test multi-table transactional put
            var multiTableDocumentTransactWrite = new MultiTableDocumentTransactWrite();

            var hDoc1 = new Document
            {
                ["Id"] = 6001,
                ["Data"] = Guid.NewGuid().ToString(),
                ["Price"] = 1000,
                ["Garbage"] = "asdf"
            };

            var hDoc2 = new Document
            {
                ["Id"] = 6002,
                ["Data"] = Guid.NewGuid().ToString(),
                ["Price"] = 500,
                ["Garbage"] = "hjkl"
            };

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(hDoc1);
                transactWrite.AddDocumentToPut(hDoc2);
                multiTableDocumentTransactWrite.AddTransactionPart(transactWrite);
            }

            var hrDoc1 = new Document
            {
                ["Name"] = "Alan",
                ["Age"] = 30,
                ["Data"] = Guid.NewGuid().ToString(),
                ["Score"] = 100,
                ["Garbage"] = "xcvb"
            };

            var hrDoc2 = new Document
            {
                ["Name"] = "Diane",
                ["Age"] = 40,
                ["Data"] = Guid.NewGuid().ToString(),
                ["Score"] = 150,
                ["Garbage"] = "qwer"
            };

            {
                var transactWrite = hashRangeTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(hrDoc1);
                transactWrite.AddDocumentToPut(hrDoc2);
                multiTableDocumentTransactWrite.AddTransactionPart(transactWrite);
            }

            multiTableDocumentTransactWrite.Execute();

            {
                var multiTableDocumentTransactGet = new MultiTableDocumentTransactGet();

                var hTransactGet = hashTable.CreateTransactGet();
                hTransactGet.AddKey(hashKey: 6001);
                hTransactGet.AddKey(hashKey: 6002);
                multiTableDocumentTransactGet.AddTransactionPart(hTransactGet);

                var hrTransactGet = hashRangeTable.CreateTransactGet();
                hrTransactGet.AddKey(hashKey: "Alan", rangeKey: 30);
                hrTransactGet.AddKey(hashKey: "Diane", rangeKey: 40);
                multiTableDocumentTransactGet.AddTransactionPart(hrTransactGet);

                multiTableDocumentTransactGet.Execute();
                Assert.AreEqual(2, hTransactGet.Results.Count);
                Assert.AreEqual(2, hrTransactGet.Results.Count);
                Assert.IsTrue(AreValuesEqual(hDoc1, hTransactGet.Results[0], conversion));
                Assert.IsTrue(AreValuesEqual(hDoc2, hTransactGet.Results[1], conversion));
                Assert.IsTrue(AreValuesEqual(hrDoc1, hrTransactGet.Results[0], conversion));
                Assert.IsTrue(AreValuesEqual(hrDoc2, hrTransactGet.Results[1], conversion));
            }

            // Test multi-table transactional update
            multiTableDocumentTransactWrite = new MultiTableDocumentTransactWrite();

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToUpdate(new Document
                {
                    ["Price"] = 1001,
                    ["Garbage"] = null
                }, hashKey: 6001);
                transactWrite.AddDocumentToUpdate(new Document
                {
                    ["Price"] = 501,
                    ["Garbage"] = null
                }, key: new Document { ["Id"] = 6002 });
                multiTableDocumentTransactWrite.AddTransactionPart(transactWrite);
            }

            {
                var transactWrite = hashRangeTable.CreateTransactWrite();
                transactWrite.AddDocumentToUpdate(new Document
                {
                    ["Score"] = 101,
                    ["Garbage"] = null
                }, hashKey: "Alan", rangeKey: 30);
                transactWrite.AddDocumentToUpdate(new Document
                {
                    ["Score"] = 151,
                    ["Garbage"] = null
                }, key: new Document { ["Name"] = "Diane", ["Age"] = 40 });
                multiTableDocumentTransactWrite.AddTransactionPart(transactWrite);
            }

            multiTableDocumentTransactWrite.Execute();

            {
                var multiTableDocumentTransactGet = new MultiTableDocumentTransactGet();

                var hTransactGet = hashTable.CreateTransactGet();
                hTransactGet.AddKey(key: new Document { ["Id"] = 6001 });
                hTransactGet.AddKey(key: new Document { ["Id"] = 6002 });
                multiTableDocumentTransactGet.AddTransactionPart(hTransactGet);

                var hrTransactGet = hashRangeTable.CreateTransactGet();
                hrTransactGet.AddKey(key: new Document { ["Name"] = "Alan", ["Age"] = 30 });
                hrTransactGet.AddKey(key: new Document { ["Name"] = "Diane", ["Age"] = 40 });
                multiTableDocumentTransactGet.AddTransactionPart(hrTransactGet);

                multiTableDocumentTransactGet.Execute();
                Assert.AreEqual(2, hTransactGet.Results.Count);
                Assert.AreEqual(2, hrTransactGet.Results.Count);
                Assert.IsFalse(AreValuesEqual(hDoc1, hTransactGet.Results[0], conversion));
                hDoc1["Price"] = 1001;
                hDoc1.Remove("Garbage");
                Assert.IsTrue(AreValuesEqual(hDoc1, hTransactGet.Results[0], conversion));
                Assert.IsFalse(AreValuesEqual(hDoc2, hTransactGet.Results[1], conversion));
                hDoc2["Price"] = 501;
                hDoc2.Remove("Garbage");
                Assert.IsTrue(AreValuesEqual(hDoc2, hTransactGet.Results[1], conversion));
                Assert.IsFalse(AreValuesEqual(hrDoc1, hrTransactGet.Results[0], conversion));
                hrDoc1["Score"] = 101;
                hrDoc1.Remove("Garbage");
                Assert.IsTrue(AreValuesEqual(hrDoc1, hrTransactGet.Results[0], conversion));
                Assert.IsFalse(AreValuesEqual(hrDoc2, hrTransactGet.Results[1], conversion));
                hrDoc2["Score"] = 151;
                hrDoc2.Remove("Garbage");
                Assert.IsTrue(AreValuesEqual(hrDoc2, hrTransactGet.Results[1], conversion));
            }

            // Test multi-table transactional delete
            multiTableDocumentTransactWrite = new MultiTableDocumentTransactWrite();

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddKeyToDelete(hashKey: 6001);
                transactWrite.AddKeyToDelete(key: new Document { ["Id"] = 6002 });
                multiTableDocumentTransactWrite.AddTransactionPart(transactWrite);
            }

            {
                var transactWrite = hashRangeTable.CreateTransactWrite();
                transactWrite.AddKeyToDelete(hashKey: "Alan", rangeKey: 30);
                transactWrite.AddKeyToDelete(new Document { ["Name"] = "Diane", ["Age"] = 40 });
                multiTableDocumentTransactWrite.AddTransactionPart(transactWrite);
            }

            multiTableDocumentTransactWrite.Execute();

            {
                var multiTableDocumentTransactGet = new MultiTableDocumentTransactGet();

                var hTransactGet = hashTable.CreateTransactGet();
                hTransactGet.AddKey(hashKey: 6001);
                hTransactGet.AddKey(hashKey: 6002);
                multiTableDocumentTransactGet.AddTransactionPart(hTransactGet);

                var hrTransactGet = hashRangeTable.CreateTransactGet();
                hrTransactGet.AddKey(hashKey: "Alan", rangeKey: 30);
                hrTransactGet.AddKey(hashKey: "Diane", rangeKey: 40);
                multiTableDocumentTransactGet.AddTransactionPart(hrTransactGet);

                multiTableDocumentTransactGet.Execute();
                Assert.AreEqual(0, hTransactGet.Results.Count);
                Assert.AreEqual(0, hrTransactGet.Results.Count);
            }
        }

        private void TestExpressionsOnDelete(ITable hashTable)
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

        private void TestExpressionsOnTransactWrite(ITable hashTable, DynamoDBEntryConversion conversion)
        {
            var doc1 = new Document
            {
                ["Id"] = 7001,
                ["Price"] = 50,
                ["Garbage"] = "asdf"
            };

            var doc2 = new Document
            {
                ["Id"] = 7002,
                ["Price"] = 100,
                ["Garbage"] = "hjkl"
            };

            var doc3 = new Document
            {
                ["Id"] = 7003,
                ["Price"] = 500,
                ["Garbage"] = "xcvb"
            };

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(doc1, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 50 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddDocumentToUpdate(doc2, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "attribute_exists(#id)",
                        ExpressionAttributeNames = { ["#id"] = "Id" }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddDocumentToUpdate(doc3, hashKey: 7003, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "attribute_not_exists(#id) AND #price <> :price",
                        ExpressionAttributeNames = { ["#id"] = "Id", ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                var ex = AssertExtensions.ExpectException<TransactionCanceledException>(() => transactWrite.Execute());
                Assert.IsNotNull(ex);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[0].Code);

                if (AWSConfigs.InitializeCollections)
                {
                    Assert.AreEqual(0, ex.CancellationReasons[0].Item.Count);
                    Assert.AreEqual(0, ex.CancellationReasons[1].Item.Count);
                    Assert.AreEqual(0, ex.CancellationReasons[2].Item.Count);
                    Assert.AreEqual(0, transactWrite.ConditionCheckFailedItems.Count);
                }
                else
                {
                    Assert.IsNull(ex.CancellationReasons[0].Item);
                    Assert.IsNull(ex.CancellationReasons[1].Item);
                    Assert.IsNull(ex.CancellationReasons[2].Item);
                    
                }

                Assert.AreEqual(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[1].Code);
                Assert.AreEqual("None", ex.CancellationReasons[2].Code);
                Assert.AreEqual(0, transactWrite.ConditionCheckFailedItems.Count);
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(7001);
                transactGet.AddKey(7002);
                transactGet.AddKey(7003);
                transactGet.Execute();
                Assert.AreEqual(0, transactGet.Results.Count);
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(doc1, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price <> :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 50 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddDocumentToUpdate(doc2, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "attribute_not_exists(#id)",
                        ExpressionAttributeNames = { ["#id"] = "Id" }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddDocumentToUpdate(doc3, hashKey: 7003, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "attribute_not_exists(#id) AND #price <> :price",
                        ExpressionAttributeNames = { ["#id"] = "Id", ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                transactWrite.Execute();
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(7001);
                transactGet.AddKey(7002);
                transactGet.AddKey(7003);
                transactGet.Execute();
                Assert.AreEqual(3, transactGet.Results.Count);
                Assert.IsTrue(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.IsTrue(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                Assert.IsTrue(AreValuesEqual(doc3, transactGet.Results[2], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddKeyToConditionCheck(hashKey: 7001, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price <> :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 50 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddDocumentToUpdate(new Document
                {
                    ["Price"] = 101,
                    ["Garbage"] = null
                }, hashKey: 7002, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 99 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddKeyToDelete(hashKey: 7003, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                var ex = AssertExtensions.ExpectException<TransactionCanceledException>(() => transactWrite.Execute());
                Assert.IsNotNull(ex);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[0].Code);
                Assert.AreNotEqual(0, ex.CancellationReasons[0].Item.Count);
                Assert.AreEqual(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[1].Code);
                Assert.AreNotEqual(0, ex.CancellationReasons[1].Item.Count);
                Assert.AreEqual("None", ex.CancellationReasons[2].Code);

                if (AWSConfigs.InitializeCollections)
                    Assert.AreEqual(0, ex.CancellationReasons[2].Item.Count);
                else
                    Assert.IsNull(ex.CancellationReasons[2].Item);

                Assert.AreEqual(2, transactWrite.ConditionCheckFailedItems.Count);
                Assert.IsTrue(AreValuesEqual(doc1, transactWrite.ConditionCheckFailedItems[0], conversion));
                Assert.IsTrue(AreValuesEqual(doc2, transactWrite.ConditionCheckFailedItems[1], conversion));
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(7001);
                transactGet.AddKey(7002);
                transactGet.AddKey(7003);
                transactGet.Execute();
                Assert.AreEqual(3, transactGet.Results.Count);
                Assert.IsTrue(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.IsTrue(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                Assert.IsTrue(AreValuesEqual(doc3, transactGet.Results[2], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(new Document
                {
                    ["Id"] = 7001,
                    ["Price"] = 51
                }, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 50 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddItemToConditionCheck(doc2, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 100 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddItemToDelete(doc3, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price <> :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                var ex = AssertExtensions.ExpectException<TransactionCanceledException>(() => transactWrite.Execute());
                Assert.IsNotNull(ex);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual("None", ex.CancellationReasons[1].Code);
                Assert.AreEqual(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[2].Code);
                Assert.AreNotEqual(0, ex.CancellationReasons[2].Item.Count);
                Assert.AreEqual(1, transactWrite.ConditionCheckFailedItems.Count);
                Assert.IsTrue(AreValuesEqual(doc3, transactWrite.ConditionCheckFailedItems[0], conversion));

                if (AWSConfigs.InitializeCollections)
                {
                    Assert.AreEqual(0, ex.CancellationReasons[0].Item.Count);
                    Assert.AreEqual(0, ex.CancellationReasons[1].Item.Count);
                }
                else
                {
                    Assert.IsNull(ex.CancellationReasons[0].Item);
                    Assert.IsNull(ex.CancellationReasons[1].Item);
                }
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(7001);
                transactGet.AddKey(7002);
                transactGet.AddKey(7003);
                transactGet.Execute();
                Assert.AreEqual(3, transactGet.Results.Count);
                Assert.IsTrue(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.IsTrue(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                Assert.IsTrue(AreValuesEqual(doc3, transactGet.Results[2], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(new Document
                {
                    ["Id"] = 7001,
                    ["Price"] = 51
                }, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 50 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddDocumentToUpdate(new Document
                {
                    ["Id"] = 7002,
                    ["Price"] = 101,
                    ["Garbage"] = null
                }, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 100 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddKeyToDelete(key: new Document { ["Id"] = 7003 }, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                transactWrite.Execute();
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(7001);
                transactGet.AddKey(7002);
                transactGet.AddKey(7003);
                transactGet.Execute();
                Assert.AreEqual(2, transactGet.Results.Count);
                Assert.IsFalse(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                doc1["Price"] = 51;
                doc1.Remove("Garbage");
                Assert.IsTrue(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.IsFalse(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                doc2["Price"] = 101;
                doc2.Remove("Garbage");
                Assert.IsTrue(AreValuesEqual(doc2, transactGet.Results[1], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                AssertExtensions.ExpectException<ArgumentException>(() => transactWrite.AddDocumentToUpdate(hashKey: 7001,
                    new Expression
                    {
                        ExpressionStatement = "SET #garbage = :garbage",
                        ExpressionAttributeNames = { ["#garbage"] = "Garbage" },
                        ExpressionAttributeValues = { [":garbage"] = "asdf" }
                    },
                    new TransactWriteItemOperationConfig
                    {
                        ConditionalExpression = new Expression
                        {
                            ExpressionStatement = "#garbage <> :garbage",
                            ExpressionAttributeNames = { ["#garbage"] = "Garbage2" },
                            ExpressionAttributeValues = { [":garbage"] = "asdf" }
                        },
                        ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                    }));
                AssertExtensions.ExpectException<ArgumentException>(() => transactWrite.AddDocumentToUpdate(hashKey: 7001,
                    new Expression
                    {
                        ExpressionStatement = "SET #garbage = :garbage",
                        ExpressionAttributeNames = { ["#garbage"] = "Garbage" },
                        ExpressionAttributeValues = { [":garbage"] = "asdf" }
                    },
                    new TransactWriteItemOperationConfig
                    {
                        ConditionalExpression = new Expression
                        {
                            ExpressionStatement = "#garbage <> :garbage",
                            ExpressionAttributeNames = { ["#garbage"] = "Garbage" },
                            ExpressionAttributeValues = { [":garbage"] = "hjkl" }
                        },
                        ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                    }));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToUpdate(hashKey: 7001,
                    new Expression
                    {
                        ExpressionStatement = "SET #price = #price + :inc",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":inc"] = 1 }
                    },
                    new TransactWriteItemOperationConfig
                    {
                        ConditionalExpression = new Expression
                        {
                            ExpressionStatement = "#price = :price",
                            ExpressionAttributeNames = { ["#price"] = "Price" },
                            ExpressionAttributeValues = { [":price"] = 51 }
                        },
                        ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                    });
                transactWrite.AddDocumentToUpdate(hashKey: 7002,
                    new Expression
                    {
                        ExpressionStatement = "SET #price = #price + :inc",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":inc"] = 1 }
                    },
                    new TransactWriteItemOperationConfig
                    {
                        ConditionalExpression = new Expression
                        {
                            ExpressionStatement = "#price = :price",
                            ExpressionAttributeNames = { ["#price"] = "Price" },
                            ExpressionAttributeValues = { [":price"] = 100 }
                        },
                        ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                    });

                var ex = AssertExtensions.ExpectException<TransactionCanceledException>(() => transactWrite.Execute());
                Assert.IsNotNull(ex);
                Assert.AreEqual(2, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[1].Code);
                Assert.AreNotEqual(0, ex.CancellationReasons[1].Item.Count);
                Assert.AreEqual(1, transactWrite.ConditionCheckFailedItems.Count);
                Assert.IsTrue(AreValuesEqual(doc2, transactWrite.ConditionCheckFailedItems[0], conversion));
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(7001);
                transactGet.AddKey(7002);
                transactGet.Execute();
                Assert.AreEqual(2, transactGet.Results.Count);
                Assert.IsTrue(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.IsTrue(AreValuesEqual(doc2, transactGet.Results[1], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToUpdate(hashKey: 7001,
                    new Expression
                    {
                        ExpressionStatement = "SET #price = #price + :inc",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":inc"] = 1 }
                    },
                    new TransactWriteItemOperationConfig
                    {
                        ConditionalExpression = new Expression
                        {
                            ExpressionStatement = "#price = :price",
                            ExpressionAttributeNames = { ["#price"] = "Price" },
                            ExpressionAttributeValues = { [":price"] = 51 }
                        },
                        ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                    });
                transactWrite.AddDocumentToUpdate(hashKey: 7002,
                    new Expression
                    {
                        ExpressionStatement = "SET #price = #price + :inc",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":inc"] = 1 }
                    },
                    new TransactWriteItemOperationConfig
                    {
                        ConditionalExpression = new Expression
                        {
                            ExpressionStatement = "#price = :price",
                            ExpressionAttributeNames = { ["#price"] = "Price" },
                            ExpressionAttributeValues = { [":price"] = 101 }
                        },
                        ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                    });

                transactWrite.Execute();
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(7001);
                transactGet.AddKey(7002);
                transactGet.Execute();
                Assert.AreEqual(2, transactGet.Results.Count);
                Assert.IsFalse(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                doc1["Price"] = 52;
                Assert.IsTrue(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.IsFalse(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                doc2["Price"] = 102;
                Assert.IsTrue(AreValuesEqual(doc2, transactGet.Results[1], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddItemToDelete(doc1, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 52 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddKeyToDelete(hashKey: 7002, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 102 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                transactWrite.Execute();
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(7001);
                transactGet.AddKey(7002);
                transactGet.AddKey(7003);
                transactGet.Execute();
                Assert.AreEqual(0, transactGet.Results.Count);
            }
        }

        private void TestExpressionsOnQuery(ITable hashRangeTable)
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

        private void TestExpressionsOnScan(ITable hashRangeTable)
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

        private void TestExpressionPut(ITable hashTable)
        {
            Document doc = new Document();

            doc["Id"] = DateTime.UtcNow.Ticks;
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

        private void TestExpressionPutWithoutValues(ITable hashTable)
        {
            var doc = new Document
            {
                ["Id"] = DateTime.UtcNow.Ticks
            };

            var expression = new Expression
            {
                ExpressionStatement = "attribute_not_exists(Id)"
            };

            var config = new PutItemOperationConfig
            {
                ConditionalExpression = expression
            };

            Assert.IsTrue(hashTable.TryPutItem(doc, config));
            hashTable.DeleteItem(doc);
        }

        private void TestExpressionUpdate(ITable hashTable)
        {
            Document doc = new Document();

            doc["Id"] = DateTime.UtcNow.Ticks;
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

        private void TestSelectCountOnQuery(ITable hashTable)
        {
            Document doc = new Document();
            doc["Id"] = 1;
            doc["Data"] = Guid.NewGuid().ToString();

            hashTable.PutItem(doc);
            
            var expression = new Expression
            {
                ExpressionStatement = "Id = :id",
                ExpressionAttributeValues = { [":id"] = 1 }
            };

            var search = hashTable.Query(new QueryOperationConfig
            {
                KeyExpression = expression,
                Select = SelectValues.Count
            });

            var docs = search.GetRemaining();
            Assert.AreEqual(1, search.Count);
            Assert.AreEqual(0, docs.Count);
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
        private void LoadTables(DynamoDBEntryConversion conversion, out ITable hashTable, out ITable hashRangeTable, out ITable numericHashRangeTable)
        {
            TableCache.Clear();

            using (var counter = CountServiceResponses(Client))
            {
                // Load table using TryLoadTable API
                hashTable = null;
#pragma warning disable CS0618 // Disable the warning for the deprecated DynamoDBContext constructors
                Assert.IsFalse(Table.TryLoadTable(Client, "FakeHashTableThatShouldNotExist", conversion, true, out hashTable));
#pragma warning restore CS0618 // Re-enable the warning
                Assert.AreEqual(0, counter.ResponseCount);
#pragma warning disable CS0618 // Disable the warning for the deprecated DynamoDBContext constructors
                Assert.IsTrue(Table.TryLoadTable(Client, hashTableName, conversion, true, out hashTable));
#pragma warning restore CS0618 // Re-enable the warning
                Assert.AreEqual(1, counter.ResponseCount);

                Assert.IsNotNull(hashTable);
                Assert.AreEqual(hashTableName, hashTable.TableName);
                Assert.AreEqual(3, hashTable.Attributes.Count);
                Assert.AreEqual(1, hashTable.GlobalSecondaryIndexes.Count);
                Assert.AreEqual(1, hashTable.GlobalSecondaryIndexNames.Count);
                Assert.AreEqual(1, hashTable.HashKeys.Count);
                Assert.AreEqual(0, hashTable.RangeKeys.Count);
                Assert.AreEqual(1, hashTable.Keys.Count);
                Assert.AreEqual(0, hashTable.LocalSecondaryIndexes.Count);
                Assert.AreEqual(0, hashTable.LocalSecondaryIndexNames.Count);

#pragma warning disable CS0618 // Disable the warning for the deprecated DynamoDBContext constructors
                // Load table using LoadTable API (may throw an exception)
                AssertExtensions.ExpectException(() => Table.LoadTable(Client, "FakeHashRangeTableThatShouldNotExist", conversion, true));
#pragma warning restore CS0618 // Re-enable the warning
                Assert.AreEqual(1, counter.ResponseCount);
#pragma warning disable CS0618 // Disable the warning for the deprecated DynamoDBContext constructors
                hashRangeTable = Table.LoadTable(Client, hashRangeTableName, conversion, true);
#pragma warning restore CS0618 // Re-enable the warning
                Assert.AreEqual(2, counter.ResponseCount);
                Assert.IsNotNull(hashRangeTable);
                Assert.AreEqual(hashRangeTableName, hashRangeTable.TableName);
                Assert.AreEqual(5, hashRangeTable.Attributes.Count);
                Assert.AreEqual(1, hashRangeTable.GlobalSecondaryIndexes.Count);
                Assert.AreEqual(1, hashRangeTable.GlobalSecondaryIndexNames.Count);
                Assert.AreEqual(1, hashRangeTable.HashKeys.Count);
                Assert.AreEqual(1, hashRangeTable.RangeKeys.Count);
                Assert.AreEqual(2, hashRangeTable.Keys.Count);
                Assert.AreEqual(1, hashRangeTable.LocalSecondaryIndexes.Count);
                Assert.AreEqual(2, hashRangeTable.LocalSecondaryIndexes["LocalIndex"].KeySchema.Count);
                Assert.AreEqual(1, hashRangeTable.LocalSecondaryIndexNames.Count);

#pragma warning disable CS0618 // Disable the warning for the deprecated DynamoDBContext constructors
                numericHashRangeTable = Table.LoadTable(Client, numericHashRangeTableName, conversion, true);
#pragma warning restore CS0618 // Re-enable the warning
                Assert.AreEqual(1, numericHashRangeTable.HashKeys.Count);
                Assert.AreEqual(1, numericHashRangeTable.RangeKeys.Count);
                Assert.AreEqual(2, numericHashRangeTable.Keys.Count);
                Assert.IsTrue(numericHashRangeTable.Keys.ContainsKey("CreationTime"));
                Assert.IsTrue(numericHashRangeTable.Keys.ContainsKey("Name"));
            }
        }
    }
}
