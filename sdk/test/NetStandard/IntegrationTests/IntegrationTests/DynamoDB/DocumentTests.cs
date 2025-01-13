using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using System.IO;
using System.Xml;

using Xunit;

namespace Amazon.DNXCore.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : IClassFixture<DynamoDBTestsFixture>
    {
        [Fact]
        [Trait(CategoryAttribute, "DynamoDB")]
        public async Task TestTableOperations()
        {
            foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                // Clear tables
                await SharedTestFixture.CleanupTables();

                ITable hashTable;
                ITable hashRangeTable;

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

                // Test Query and Scan manual pagination
                await TestPagination(hashRangeTable);
            }
        }

        private async Task TestPagination(ITable hashRangeTable)
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
            await batchWrite.ExecuteAsync();

            // Paginated scan
            {
                var request = new ScanOperationConfig
                {
                    Limit = 1
                };
                var search = hashRangeTable.Scan(request);
                var tokens = new List<string>();
                var retrievedCount = await VerifyPagination(search, tokens);
                Assert.Equal(retrievedCount, itemCount);
                Assert.Equal(itemCount, tokens.Count);

                var token4 = tokens[4];
                var token5 = tokens[5];
                search = hashRangeTable.Scan(new ScanOperationConfig
                {
                    Limit = 1,
                    PaginationToken = token4
                });
                await search.GetNextSetAsync();
                Assert.NotEqual(token4, search.PaginationToken);
                Assert.Equal(token5, search.PaginationToken);
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
                var retrievedCount = await VerifyPagination(search, tokens);
                Assert.Equal(retrievedCount, itemCount);
                Assert.Equal(itemCount, tokens.Count);

                var token4 = tokens[4];
                var token5 = tokens[5];
                search = hashRangeTable.Query(new QueryOperationConfig
                {
                    Limit = 1,
                    Filter = filter,
                    PaginationToken = token4
                });
                await search.GetNextSetAsync();
                Assert.NotEqual(token4, search.PaginationToken);
                Assert.Equal(token5, search.PaginationToken);
            }
        }

        private static async Task<int> VerifyPagination(ISearch search, List<string> tokens)
        {
            int count = 0;
            do
            {
                var items = await search.GetNextSetAsync();
                var token = search.PaginationToken;
                count += items.Count;

                if (!search.IsDone)
                {
                    tokens.Add(token);
                    Assert.NotEmpty(items);
                    Assert.False(string.IsNullOrEmpty(token));
                }
            } while (!search.IsDone);

            return count;
        }

        private async Task TestEmptyCollections(ITable hashTable)
        {
            Document doc = new Document();
            doc["Id"] = 1;
            doc["EmptyList"] = new DynamoDBList();
            doc["EmptyMap"] = new Document();
            await hashTable.PutItemAsync(doc);

            Document retrieved = await hashTable.GetItemAsync(doc);

            DynamoDBEntry mapEntry;
            Assert.True(retrieved.TryGetValue("EmptyMap", out mapEntry));
            Assert.NotNull(mapEntry);
            Assert.NotNull(mapEntry.AsDocument());
            Assert.Empty(mapEntry.AsDocument());

            DynamoDBEntry listEntry;
            Assert.True(retrieved.TryGetValue("EmptyList", out listEntry));
            Assert.NotNull(listEntry);
            Assert.NotNull(listEntry.AsDynamoDBList());
            Assert.Empty(listEntry.AsDynamoDBList().Entries);
        }

        private async Task TestHashTable(ITable hashTable, DynamoDBEntryConversion conversion)
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
            Assert.Equal("asdf", doc["Garbage"].AsString());
            await hashTable.PutItemAsync(doc);

            // Get the item by hash key
            Document retrieved = await hashTable.GetItemAsync(1);
            Assert.False(AreValuesEqual(doc, retrieved));
            var convertedDoc = doc.ForceConversion(conversion);
            Assert.True(AreValuesEqual(convertedDoc, retrieved));

            // Get the item by document
            retrieved = await hashTable.GetItemAsync(doc);
            // Verify retrieved document
            Assert.True(AreValuesEqual(convertedDoc, retrieved, conversion));
            var tagsRetrieved = retrieved["Tags"];
            Assert.True(tagsRetrieved is PrimitiveList);
            Assert.Equal(2, tagsRetrieved.AsPrimitiveList().Entries.Count);
            // Test bool storage for different conversions
            var isPublicRetrieved = retrieved["IsPublic"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.Equal("1", isPublicRetrieved.AsPrimitive().Value as string);
            else
                Assert.True(isPublicRetrieved is DynamoDBBool);
            // Test HashSet<string> storage for different conversions
            var aliasesRetrieved = retrieved["Aliases"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.Equal(2, aliasesRetrieved.AsPrimitiveList().Entries.Count);
            else
                Assert.Equal(2, aliasesRetrieved.AsDynamoDBList().Entries.Count);
            List<Document> developers = retrieved["Developers"].AsListOfDocument();
            Assert.Equal(2, developers.Count);
            Assert.Throws<InvalidCastException>(() => aliasesRetrieved.AsListOfDocument());

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
            Assert.Null(doc["Garbage"].AsString());
            await hashTable.UpdateItemAsync(doc);
            retrieved = await hashTable.GetItemAsync(1);
            Assert.False(AreValuesEqual(doc, retrieved, conversion));
            doc.Remove("Garbage");
            Assert.True(AreValuesEqual(doc, retrieved, conversion));
            developers = retrieved["Developers"].AsListOfDocument();
            Assert.Single(developers);

            // Create new, circularly-referencing item            
            Document doc2 = doc.ForceConversion(conversion);
            doc2["Id"] = doc2["Id"].AsInt() + 1;
            doc2["Price"] = 94;
            doc2["Tags"] = null;
            doc2["IsPublic"] = false;
            doc2["Parent"] = doc2;
            await Assert.ThrowsAsync<InvalidOperationException>(() => hashTable.UpdateItemAsync(doc2));
            // Remove circular reference and save new item
            doc2.Remove("Parent");
            await hashTable.UpdateItemAsync(doc2);

            // Scan the hash-key table
            var items = await hashTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            // Scan by pages
            var search = hashTable.Scan(new ScanOperationConfig { Limit = 1 });
            items.Clear();
            while (!search.IsDone)
            {
                var set = await search.GetNextSetAsync();
                items.AddRange(set);
            }
            Assert.Equal(2, items.Count);

            // Query against GlobalIndex
            var queryFilter = new QueryFilter("Company", QueryOperator.Equal, "CloudsAreGrate");
            queryFilter.AddCondition("Price", QueryOperator.GreaterThan, 100);
            search = hashTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            });
            items = await search.GetRemainingAsync();
            Assert.Single(items);

            // Scan for specific tag
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Tags", ScanOperator.Contains, "2.0");
            search = hashTable.Scan(scanFilter);
            items = await search.GetRemainingAsync();
            Assert.Single(items);

            // Delete the item by hash key
            await hashTable.DeleteItemAsync(1);
            Assert.Null(await hashTable.GetItemAsync(1));

            // Delete the item by document
            await hashTable.DeleteItemAsync(doc2);
            Assert.Null(await hashTable.GetItemAsync(doc2));

            // Scan the hash-key table to confirm it is empty
            items = await hashTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.Empty(items);

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
            Assert.Equal(2, batchGet.Results.Count);

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
            Assert.Empty(batchGet.Results);

            // Scan the hash-key table to confirm it is empty
            items = await hashTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.Empty(items);
        }
        private async Task TestHashRangeTable(ITable hashRangeTable, DynamoDBEntryConversion conversion)
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
            Assert.True(AreValuesEqual(doc1, retrieved, conversion));
            var tagsRetrieved = retrieved["Aliases"];
            Assert.True(tagsRetrieved is PrimitiveList);
            Assert.Equal(2, tagsRetrieved.AsPrimitiveList().Entries.Count);
            // Test bool storage for different conversions
            var isTesterRetrieved = retrieved["IsTester"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.Equal("1", isTesterRetrieved.AsPrimitive().Value as string);
            else
                Assert.True(isTesterRetrieved is DynamoDBBool);
            // Test HashSet<string> storage for different conversions
            var pastManagersRetrieved = retrieved["PastManagers"];
            if (conversion == DynamoDBEntryConversion.V1)
                Assert.Equal(2, pastManagersRetrieved.AsPrimitiveList().Entries.Count);
            else
                Assert.Equal(2, pastManagersRetrieved.AsDynamoDBList().Entries.Count);

            // Get item using GetItem overloads that expect a key in different ways
            retrieved = await hashRangeTable.GetItemAsync(doc2);
            Assert.True(AreValuesEqual(doc2, retrieved, conversion));
            retrieved = await hashRangeTable.GetItemAsync(oldDoc3, new GetItemOperationConfig { ConsistentRead = true });
            Assert.True(AreValuesEqual(oldDoc3, retrieved, conversion));
            retrieved = await hashRangeTable.GetItemAsync("Diane", 24, new GetItemOperationConfig { ConsistentRead = true });
            Assert.True(AreValuesEqual(doc3, retrieved, conversion));

            // Scan the hash-and-range-key table
            var items = await hashRangeTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.Equal(4, items.Count);

            // Scan by pages
            var search = hashRangeTable.Scan(new ScanOperationConfig { Limit = 1 });
            items.Clear();
            while(!search.IsDone)
            {
                var set = await search.GetNextSetAsync();
                items.AddRange(set);
            }
            Assert.Equal(4, items.Count);

            // Scan in parallel
            var segment1 = await hashRangeTable.Scan(new ScanOperationConfig { Segment = 0, TotalSegments = 2 }).GetRemainingAsync();
            var segment2 = await hashRangeTable.Scan(new ScanOperationConfig { Segment = 1, TotalSegments = 2 }).GetRemainingAsync();
            Assert.Equal(4, segment1.Count + segment2.Count);

            // Query items
            items = await hashRangeTable.Query("Diane", new QueryFilter()).GetRemainingAsync();
            Assert.Equal(2, items.Count);

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
            Assert.Equal(2, items.Count);

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
            Assert.Single(items);

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
            Assert.Single(items);



            // Query local index
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Diane")
            }).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            // Query global index
            var queryFilter = new QueryFilter("Company", QueryOperator.Equal, "Big River");
            queryFilter.AddCondition("Score", QueryOperator.GreaterThan, 100);
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemainingAsync();
            Assert.Single(items);

            // Scan local index
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Name", ScanOperator.Equal, "Diane");
            items = await hashRangeTable.Scan(new ScanOperationConfig
            {
                IndexName = "LocalIndex",
                Filter = scanFilter
            }).GetRemainingAsync();
            Assert.Equal(2, items.Count);

            // Scan global index
            scanFilter = new ScanFilter();
            scanFilter.AddCondition("Company", ScanOperator.Equal, "Big River");
            scanFilter.AddCondition("Score", ScanOperator.GreaterThan, 100);
            items = await hashRangeTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            }).GetRemainingAsync();
            Assert.Single(items);
        }
        private async Task TestLargeBatchOperations(ITable hashTable)
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

            Thread.Sleep(TimeSpan.FromSeconds(1)); // Wait for the eventual consistence of the batch add to catch up.
           
            // Scan table, but retrieve only keys
            var ids = await hashTable.Scan(new ScanOperationConfig
            {
                AttributesToGet = new List<string> { "Id" },
                Select = SelectValues.SpecificAttributes
            }).GetRemainingAsync();
            Assert.Equal(itemCount, ids.Count);

            // Batch-get all items
            var batchGet = hashTable.CreateBatchGet();
            foreach (var id in ids)
                batchGet.AddKey(id);
            await batchGet.ExecuteAsync();
            Assert.Equal(itemCount, batchGet.Results.Count);

            // Batch-delete all items
            batchWrite = hashTable.CreateBatchWrite();
            foreach (var id in ids)
                batchWrite.AddKeyToDelete(id);
            await batchWrite.ExecuteAsync();

            Thread.Sleep(100); // Wait for the eventual consistence of the batch add to catch up.

            // Scan table to confirm it is empty
            var items = await hashTable.Scan(new ScanFilter()).GetRemainingAsync();
            Assert.Empty(items);
        }

        private async Task TestExpressionsOnDelete(ITable hashTable)
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

            await Assert.ThrowsAsync<ConditionalCheckFailedException>(() => hashTable.DeleteItemAsync(doc1, config));

            expression.ExpressionAttributeValues[":price"] = 4;
            await hashTable.DeleteItemAsync(doc1, config);
        }

        private async Task TestExpressionsOnQuery(ITable hashRangeTable)
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
            Assert.Single(docs);
            Assert.Equal(77, docs[0]["Age"].AsInt());

            search = hashRangeTable.Query(new QueryOperationConfig
            {
                Filter = new QueryFilter("Name", QueryOperator.Equal, "Gunnar"),
                FilterExpression = expression,
                AttributesToGet = new List<string> { "Age" },
                Select = SelectValues.SpecificAttributes
            });
            docs = await search.GetRemainingAsync();
            Assert.Single(docs);
            Assert.Single(docs[0]);
            Assert.Equal(77, docs[0]["Age"].AsInt());

            await hashRangeTable.DeleteItemAsync(doc1);
            await hashRangeTable.DeleteItemAsync(doc2);
        }

        private async Task TestExpressionsOnScan(ITable hashRangeTable)
        {
            await SharedTestFixture.ClearTable(SharedTestFixture.hashRangeTableName);

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
            Assert.Single(docs);
            Assert.Equal("Elementary", docs[0]["School"].AsString());

            search = hashRangeTable.Scan(new ScanOperationConfig
            {
                FilterExpression = expression,
                Select = SelectValues.SpecificAttributes,
                AttributesToGet = new List<string> { "School" }
            });
            docs = await search.GetRemainingAsync();
            Assert.Single(docs);
            Assert.Single(docs[0]);
            Assert.Equal("Elementary", docs[0]["School"].AsString());

            await hashRangeTable.DeleteItemAsync(doc1);
            await hashRangeTable.DeleteItemAsync(doc2);
        }

        private async Task TestExpressionPut(ITable hashTable)
        {
            Document doc = new Document();

            doc["Id"] = DateTime.UtcNow.Ticks;
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
            await hashTable.PutItemAsync(doc, config);

            doc["referencecounter"] = 0;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = null;
            await hashTable.PutItemAsync(doc, config);

            // Make sure removing attributes works
            doc = await hashTable.GetItemAsync(doc);
            Assert.False(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = 3;
            await Assert.ThrowsAsync<Amazon.DynamoDBv2.Model.ConditionalCheckFailedException>(() => hashTable.PutItemAsync(doc, config));

            await hashTable.DeleteItemAsync(doc);
        }

        private async Task TestExpressionUpdate(ITable hashTable)
        {
            Document doc = new Document();

            doc["Id"] = DateTime.UtcNow.Ticks;
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
            await hashTable.UpdateItemAsync(doc, config);

            doc["referencecounter"] = 0;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = null;
            await hashTable.UpdateItemAsync(doc, config);

            // Make sure removing attributes works
            doc = await hashTable.GetItemAsync(doc);
            Assert.False(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = 3;
            await Assert.ThrowsAsync<Amazon.DynamoDBv2.Model.ConditionalCheckFailedException>(() => hashTable.UpdateItemAsync(doc, config));

            doc = await hashTable.GetItemAsync(doc);
            Assert.False(doc.Contains("update-test"));

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
        private void LoadTables(DynamoDBEntryConversion conversion, out ITable hashTable, out ITable hashRangeTable)
        {
            SharedTestFixture.TableCache.Clear();

            using (var counter = DynamoDBTestsFixture.CountServiceResponses(Client))
            {
                // Load table using TryLoadTable API
                hashTable = null;
                Assert.False(Table.TryLoadTable(Client, "FakeHashTableThatShouldNotExist", conversion, out hashTable));
                Assert.Equal(0, counter.ResponseCount);
                Assert.True(Table.TryLoadTable(Client, SharedTestFixture.hashTableName, conversion, out hashTable));
                Assert.Equal(1, counter.ResponseCount);

                Assert.NotNull(hashTable);
                Assert.Equal(SharedTestFixture.hashTableName, hashTable.TableName);
                Assert.Equal(3, hashTable.Attributes.Count);
                Assert.Single(hashTable.GlobalSecondaryIndexes);
                Assert.Single(hashTable.GlobalSecondaryIndexNames);
                Assert.Single(hashTable.HashKeys);
                Assert.Empty(hashTable.RangeKeys);
                Assert.Single(hashTable.Keys);
                Assert.Empty(hashTable.LocalSecondaryIndexes);
                Assert.Empty(hashTable.LocalSecondaryIndexNames);

                // Load table using LoadTable API (may throw an exception)
                Assert.Throws<ResourceNotFoundException>(() => Table.LoadTable(Client, "FakeHashRangeTableThatShouldNotExist", conversion));
                Assert.Equal(1, counter.ResponseCount);
                hashRangeTable = Table.LoadTable(Client, SharedTestFixture.hashRangeTableName, conversion);
                Assert.Equal(2, counter.ResponseCount);
                Assert.NotNull(hashRangeTable);
                Assert.Equal(SharedTestFixture.hashRangeTableName, hashRangeTable.TableName);
                Assert.Equal(5, hashRangeTable.Attributes.Count);
                Assert.Single(hashRangeTable.GlobalSecondaryIndexes);
                Assert.Single(hashRangeTable.GlobalSecondaryIndexNames);
                Assert.Single(hashRangeTable.HashKeys);
                Assert.Single(hashRangeTable.RangeKeys);
                Assert.Equal(2, hashRangeTable.Keys.Count);
                Assert.Single(hashRangeTable.LocalSecondaryIndexes);
                Assert.Equal(2, hashRangeTable.LocalSecondaryIndexes["LocalIndex"].KeySchema.Count);
                Assert.Single(hashRangeTable.LocalSecondaryIndexNames);
            }
        }
    }
}
