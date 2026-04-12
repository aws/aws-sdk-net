using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ReturnValuesOnConditionCheckFailure = Amazon.DynamoDBv2.DocumentModel.ReturnValuesOnConditionCheckFailure;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DocumentHashTableTests : IClassFixture<HashTableFixture>, IAsyncLifetime
    {
        private readonly HashTableFixture _fixture;
        private static readonly Random _rng = new Random();

        public DocumentHashTableTests(HashTableFixture fixture) => _fixture = fixture;

        public async ValueTask InitializeAsync() => await _fixture.CleanupTables();

        public ValueTask DisposeAsync() => default;

        private ITable LoadHashTable(DynamoDBEntryConversion conversion)
        {
            Table.TryLoadTable(_fixture.Client, _fixture.HashTableName, conversion, true, out ITable hashTable);
            return hashTable;
        }

        private ITable BuildHashTable(DynamoDBEntryConversion conversion)
        {
            return new TableBuilder(_fixture.Client, _fixture.HashTableName, conversion, true, null)
                .AddHashKey("Id", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Price", DynamoDBEntryType.Numeric)
                .Build();
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public void TestHashTableStructure(DynamoDBEntryConversion conversion)
        {
            Assert.False(Table.TryLoadTable(_fixture.Client, "FakeHashTableThatShouldNotExist", conversion, true, out ITable hashTable));
            Assert.True(Table.TryLoadTable(_fixture.Client, _fixture.HashTableName, conversion, true, out hashTable));
            Assert.NotNull(hashTable);
            Assert.Equal(_fixture.HashTableName, hashTable.TableName);
            Assert.Equal(3, hashTable.Attributes.Count);
            Assert.Equal(1, hashTable.GlobalSecondaryIndexes.Count);
            Assert.Equal(1, hashTable.GlobalSecondaryIndexNames.Count);
            Assert.Equal(1, hashTable.HashKeys.Count);
            Assert.Equal(0, hashTable.RangeKeys.Count);
            Assert.Equal(1, hashTable.Keys.Count);
            Assert.Equal(0, hashTable.LocalSecondaryIndexes.Count);
            Assert.Equal(0, hashTable.LocalSecondaryIndexNames.Count);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_EmptyString(DynamoDBEntryConversion conversion)
        {
            await TestEmptyStringHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_EmptyString(DynamoDBEntryConversion conversion)
        {
            await TestEmptyStringHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_EmptyCollections(DynamoDBEntryConversion conversion)
        {
            await TestEmptyCollectionsHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_EmptyCollections(DynamoDBEntryConversion conversion)
        {
            await TestEmptyCollectionsHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_HashTable(DynamoDBEntryConversion conversion)
        {
            await TestHashTableHelper(LoadHashTable(conversion), conversion);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_HashTable(DynamoDBEntryConversion conversion)
        {
            await TestHashTableHelper(BuildHashTable(conversion), conversion);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_LargeBatch(DynamoDBEntryConversion conversion)
        {
            await TestLargeBatchOperationsHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_LargeBatch(DynamoDBEntryConversion conversion)
        {
            await TestLargeBatchOperationsHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionsOnTransactWrite(DynamoDBEntryConversion conversion)
        {
            var table = LoadHashTable(conversion);
            await RunWithRetry(() => TestExpressionsOnTransactWriteHelper(table, conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionsOnTransactWrite(DynamoDBEntryConversion conversion)
        {
            var table = BuildHashTable(conversion);
            await RunWithRetry(() => TestExpressionsOnTransactWriteHelper(table, conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_SelectCountOnQuery(DynamoDBEntryConversion conversion)
        {
            await TestSelectCountOnQueryHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_SelectCountOnQuery(DynamoDBEntryConversion conversion)
        {
            await TestSelectCountOnQueryHelper(BuildHashTable(conversion));
        }

#if NETFRAMEWORK
        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionUpdate(DynamoDBEntryConversion conversion)
        {
            await TestExpressionUpdateHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionUpdate(DynamoDBEntryConversion conversion)
        {
            await TestExpressionUpdateHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionUpdateWithoutValues(DynamoDBEntryConversion conversion)
        {
            await TestExpressionUpdateWithoutValuesHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionUpdateWithoutValues(DynamoDBEntryConversion conversion)
        {
            await TestExpressionUpdateWithoutValuesHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionPut(DynamoDBEntryConversion conversion)
        {
            await TestExpressionPutHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionPut(DynamoDBEntryConversion conversion)
        {
            await TestExpressionPutHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionPutWithoutValues(DynamoDBEntryConversion conversion)
        {
            await TestExpressionPutWithoutValuesHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionPutWithoutValues(DynamoDBEntryConversion conversion)
        {
            await TestExpressionPutWithoutValuesHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionsOnDelete(DynamoDBEntryConversion conversion)
        {
            await TestExpressionsOnDeleteHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionsOnDelete(DynamoDBEntryConversion conversion)
        {
            await TestExpressionsOnDeleteHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionPutWithDocumentOperationRequest(DynamoDBEntryConversion conversion)
        {
            await TestExpressionPutWithDocumentOperationRequestHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionPutWithDocumentOperationRequest(DynamoDBEntryConversion conversion)
        {
            await TestExpressionPutWithDocumentOperationRequestHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionUpdateWithDocumentOperationRequest(DynamoDBEntryConversion conversion)
        {
            await TestExpressionUpdateWithDocumentOperationRequestHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionUpdateWithDocumentOperationRequest(DynamoDBEntryConversion conversion)
        {
            await TestExpressionUpdateWithDocumentOperationRequestHelper(BuildHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableOperations_ExpressionsOnDeleteWithDocumentOperationRequest(DynamoDBEntryConversion conversion)
        {
            await TestExpressionsOnDeleteWithDocumentOperationRequestHelper(LoadHashTable(conversion));
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestHashTableViaBuilder_ExpressionsOnDeleteWithDocumentOperationRequest(DynamoDBEntryConversion conversion)
        {
            await TestExpressionsOnDeleteWithDocumentOperationRequestHelper(BuildHashTable(conversion));
        }
#endif

        private async Task TestEmptyStringHelper(ITable hashTable)
        {
            var companyInfo = new DynamoDBList();
            companyInfo.Add(string.Empty);

            await hashTable.PutItemAsync(new Document
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
            });

            var savedProduct = await hashTable.GetItemAsync(1, new GetItemOperationConfig { ConsistentRead = true });
            Assert.Equal(1, savedProduct["Id"].AsInt());
            Assert.Equal(string.Empty, savedProduct["Name"].AsString());
            Assert.Equal(string.Empty, savedProduct["Components"].AsListOfString()[0]);
            Assert.Equal(string.Empty, savedProduct["CompanyInfo"].AsListOfDynamoDBEntry()[0].AsString());
            Assert.Equal(string.Empty, savedProduct["Map"].AsDocument()["Position"].AsString());
        }

        private async Task TestEmptyCollectionsHelper(ITable hashTable)
        {
            Document doc = new Document
            {
                ["Id"] = 1,
                ["EmptyList"] = new DynamoDBList(),
                ["EmptyMap"] = new Document()
            };

            await hashTable.PutItemAsync(doc);
            Document retrieved = await hashTable.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true });

            Assert.True(retrieved.TryGetValue("EmptyMap", out DynamoDBEntry mapEntry));
            Assert.NotNull(mapEntry);
            Assert.NotNull(mapEntry.AsDocument());
            Assert.Equal(0, mapEntry.AsDocument().Count);

            Assert.True(retrieved.TryGetValue("EmptyList", out DynamoDBEntry listEntry));
            Assert.NotNull(listEntry);
            Assert.NotNull(listEntry.AsDynamoDBList());
            Assert.Equal(0, listEntry.AsDynamoDBList().Entries.Count);
        }

        private async Task TestHashTableHelper(ITable hashTable, DynamoDBEntryConversion conversion)
        {
            // Put an item
            Document doc = new Document
            {
                ["Id"] = 1,
                ["Product"] = "CloudSpotter",
                ["Company"] = "CloudsAreGrate",
                ["IsPublic"] = true,
                ["Price"] = 1200,
                ["Tags"] = new HashSet<string> { "Prod", "1.0" },
                ["Aliases"] = new List<string> { "CS", "Magic" },
                ["Developers"] = new List<Document>
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
                },
                ["Garbage"] = "asdf"
            };
            Assert.Equal("asdf", doc["Garbage"].AsString());
            await hashTable.PutItemAsync(doc);

            // Get the item by hash key
            Document retrieved = await hashTable.GetItemAsync(1, new GetItemOperationConfig { ConsistentRead = true });
            Assert.False(AreValuesEqual(doc, retrieved));
            var convertedDoc = doc.ForceConversion(conversion);
            Assert.True(AreValuesEqual(convertedDoc, retrieved));

            // Get the item by document
            retrieved = await hashTable.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true });

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
            Assert.Null(doc["Garbage"].AsString());
            await hashTable.UpdateItemAsync(doc);
            retrieved = await hashTable.GetItemAsync(1, new GetItemOperationConfig { ConsistentRead = true });
            Assert.False(AreValuesEqual(doc, retrieved, conversion));
            doc.Remove("Garbage");
            Assert.True(AreValuesEqual(doc, retrieved, conversion));
            developers = retrieved["Developers"].AsListOfDocument();
            Assert.Equal(1, developers.Count);

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

            // GSI updates are eventually consistent; wait until both items are indexed before querying.
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                var indexed = await hashTable.Scan(new ScanOperationConfig { IndexName = "GlobalIndex" }).GetRemainingAsync();
                return indexed.Count >= 2;
            }, sleepSeconds: 1, maxWaitSeconds: 30);

            // Query against GlobalIndex
            var queryFilter = new QueryFilter("Company", QueryOperator.Equal, "CloudsAreGrate");
            queryFilter.AddCondition("Price", QueryOperator.GreaterThan, 100);
            search = hashTable.Query(new QueryOperationConfig
            {
                IndexName = "GlobalIndex",
                Filter = queryFilter
            });
            items = await search.GetRemainingAsync();
            Assert.Equal(1, items.Count);

            // Scan for specific tag
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("Tags", ScanOperator.Contains, "2.0");
            search = hashTable.Scan(scanFilter);
            items = await search.GetRemainingAsync();
            Assert.Equal(1, items.Count);

            // Delete the item by hash key
            await hashTable.DeleteItemAsync(1);
            Assert.Null(await hashTable.GetItemAsync(1, new GetItemOperationConfig { ConsistentRead = true }));

            // Delete the item by document
            await hashTable.DeleteItemAsync(doc2);
            Assert.Null(await hashTable.GetItemAsync(doc2, new GetItemOperationConfig { ConsistentRead = true }));

            // Scan the hash-key table to confirm it is empty
            items = await hashTable.Scan(new ScanOperationConfig { ConsistentRead = true }).GetRemainingAsync();
            Assert.Equal(0, items.Count);

            // Batch-put items
            var batchWrite = hashTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(doc);
            batchWrite.AddDocumentToPut(doc2);
            await batchWrite.ExecuteAsync();

            // Batch-get items
            var batchGet = hashTable.CreateBatchGet();
            batchGet.ConsistentRead = true;
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
            batchGet.ConsistentRead = true;
            batchGet.AddKey(1);
            batchGet.AddKey(doc2);
            await batchGet.ExecuteAsync();
            Assert.Equal(0, batchGet.Results.Count);

            // Transact-put items
            var transactWrite = hashTable.CreateTransactWrite();
            doc["Garbage"] = "asdf";
            Assert.Equal("asdf", doc["Garbage"].AsString());
            doc2["Garbage"] = "hjkl";
            Assert.Equal("hjkl", doc2["Garbage"].AsString());
            transactWrite.AddDocumentToPut(doc);
            transactWrite.AddDocumentToPut(doc2);
            await transactWrite.ExecuteAsync();

            // Transact-get items
            var transactGet = hashTable.CreateTransactGet();
            transactGet.AddKey(1);
            transactGet.AddKey(doc2);
            await transactGet.ExecuteAsync();
            Assert.Equal(2, transactGet.Results.Count);
            Assert.True(AreValuesEqual(doc, transactGet.Results[0], conversion));
            // Remove Tags attribute before comparison, because it has a null value, so it was not added
            doc2.Remove("Tags");
            Assert.True(AreValuesEqual(doc2, transactGet.Results[1], conversion));

            // Transact-update items
            transactWrite = hashTable.CreateTransactWrite();
            doc["Price"] = doc["Price"].AsInt() + 1;
            doc["Garbage"] = null;
            Assert.Null(doc["Garbage"].AsString());
            transactWrite.AddDocumentToUpdate(doc);
            transactWrite.AddDocumentToUpdate(new Document
            {
                ["Price"] = doc2["Price"].AsInt() + 1,
                ["Garbage"] = null
            }, 2);
            await transactWrite.ExecuteAsync();

            // Transact-get updated items
            transactGet = hashTable.CreateTransactGet();
            transactGet.AddKey(doc);
            transactGet.AddKey(2);
            await transactGet.ExecuteAsync();
            Assert.Equal(2, transactGet.Results.Count);
            Assert.False(AreValuesEqual(doc, transactGet.Results[0], conversion));
            doc.Remove("Garbage");
            Assert.True(AreValuesEqual(doc, transactGet.Results[0], conversion));
            Assert.False(AreValuesEqual(doc2, transactGet.Results[1], conversion));
            doc2["Price"] = doc2["Price"].AsInt() + 1;
            doc2.Remove("Garbage");
            Assert.True(AreValuesEqual(doc2, transactGet.Results[1], conversion));

            // Transact-delete items
            transactWrite = hashTable.CreateTransactWrite();
            transactWrite.AddItemToDelete(doc);
            transactWrite.AddKeyToDelete(2);
            await transactWrite.ExecuteAsync();

            // Transact-get non-existent items
            transactGet = hashTable.CreateTransactGet();
            transactGet.AddKey(1);
            transactGet.AddKey(doc2);
            await transactGet.ExecuteAsync();
            Assert.Equal(0, transactGet.Results.Count);

            // Scan the hash-key table to confirm it is empty
            items = await hashTable.Scan(new ScanOperationConfig { ConsistentRead = true }).GetRemainingAsync();
            Assert.Equal(0, items.Count);
        }

        private async Task TestLargeBatchOperationsHelper(ITable hashTable)
        {
            int itemCount = 30;
            int itemSize = 40 * 1024;
            string textData = new string('@', itemSize);
            MemoryStream data = new MemoryStream(Encoding.UTF8.GetBytes(textData));

            // Write all items
            var batchWrite = hashTable.CreateBatchWrite();
            for (int i = 0; i < itemCount; i++)
            {
                batchWrite.AddDocumentToPut(new Document
                {
                    ["Id"] = i,
                    ["Data"] = data
                });
            }
            await batchWrite.ExecuteAsync();

            // Scan table, but retrieve only keys
            var ids = await hashTable.Scan(new ScanOperationConfig
            {
                AttributesToGet = new List<string> { "Id" },
                Select = SelectValues.SpecificAttributes,
                ConsistentRead = true
            }).GetRemainingAsync();
            Assert.Equal(itemCount, ids.Count);

            // Batch-get all items
            var batchGet = hashTable.CreateBatchGet();
            foreach (var id in ids)
            {
                batchGet.AddKey(id);
            }
            await batchGet.ExecuteAsync();
            Assert.Equal(itemCount, batchGet.Results.Count);

            // Batch-delete all items
            batchWrite = hashTable.CreateBatchWrite();
            foreach (var id in ids)
            {
                batchWrite.AddKeyToDelete(id);
            }
            await batchWrite.ExecuteAsync();

            // Scan table to confirm it is empty
            var items = await hashTable.Scan(new ScanOperationConfig { ConsistentRead = true }).GetRemainingAsync();
            Assert.Equal(0, items.Count);
        }

#if NETFRAMEWORK
        private async Task TestExpressionsOnDeleteHelper(ITable hashTable)
        {
            Document doc1 = new Document
            {
                ["Id"] = 13,
                ["Price"] = 6
            };
            await hashTable.PutItemAsync(doc1);

            var expression = new Expression
            {
                ExpressionStatement = "Price > :price",
                ExpressionAttributeValues = { [":price"] = 7 }
            };
            var config = new DeleteItemOperationConfig { ConditionalExpression = expression };
            Assert.False(hashTable.TryDeleteItem(doc1, config));

            expression.ExpressionAttributeValues[":price"] = 4;
            Assert.True(hashTable.TryDeleteItem(doc1, config));
        }
#endif

        private static async Task RunWithRetry(Func<Task> action, int delayInSeconds = 10)
        {
            // This is unfortunate but when running in CodeBuild some transactions that were expected to fail
            // with "ConditionalCheckFailed" would get a "ThrottlingError" instead (and would succeed immediately on retry).
            try { await action(); }
            catch { await Task.Delay(TimeSpan.FromSeconds(delayInSeconds)); await action(); }
        }

        private async Task TestExpressionsOnTransactWriteHelper(ITable hashTable, DynamoDBEntryConversion conversion)
        {
            int id1 = _rng.Next(7000, 9996);
            int id2 = id1 + 1, id3 = id1 + 2, id4 = id1 + 3;

            var doc1 = new Document
            {
                ["Id"] = id1,
                ["Price"] = 50,
                ["Garbage"] = "asdf"
            };

            var doc2 = new Document
            {
                ["Id"] = id2,
                ["Price"] = 100,
                ["Garbage"] = "hjkl"
            };

            var doc3 = new Document
            {
                ["Id"] = id3,
                ["Price"] = 500,
                ["Garbage"] = "xcvb"
            };

            var doc4 = new Document
            {
                ["Id"] = id4,
                ["Price"] = 1500,
                ["Garbage"] = "qwer"
            };

            {
                // null expression attribute values should be allowed for parity with CLI behavior
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(doc4);
                await transactWrite.ExecuteAsync();
                var transactWrite2 = hashTable.CreateTransactWrite();
                var updateExpression = new Expression
                {
                    ExpressionStatement = "SET #price = Price",
                    ExpressionAttributeNames = new Dictionary<string, string> { ["#price"] = "Price" },
                    ExpressionAttributeValues = null
                };

                var conditionalExpression = new Expression
                {
                    ExpressionStatement = "attribute_exists(#Id)",
                    ExpressionAttributeNames = new Dictionary<string, string> { ["#Id"] = "Id" },
                    ExpressionAttributeValues = null
                };

                var config = new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = conditionalExpression
                };

                transactWrite2.AddDocumentToUpdate(doc4, updateExpression, config);
                await transactWrite2.ExecuteAsync();
            }

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
                transactWrite.AddDocumentToUpdate(doc3, hashKey: id3, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "attribute_not_exists(#id) AND #price <> :price",
                        ExpressionAttributeNames = { ["#id"] = "Id", ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());
                Assert.NotNull(ex);
                Assert.Equal(3, ex.CancellationReasons.Count);
                Assert.Equal(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[0].Code);

                if (AWSConfigs.InitializeCollections)
                {
                    Assert.Equal(0, ex.CancellationReasons[0].Item.Count);
                    Assert.Equal(0, ex.CancellationReasons[1].Item.Count);
                    Assert.Equal(0, ex.CancellationReasons[2].Item.Count);
                    Assert.Equal(0, transactWrite.ConditionCheckFailedItems.Count);
                }
                else
                {
                    Assert.Null(ex.CancellationReasons[0].Item);
                    Assert.Null(ex.CancellationReasons[1].Item);
                    Assert.Null(ex.CancellationReasons[2].Item);
                }

                Assert.Equal(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[1].Code);
                Assert.Equal("None", ex.CancellationReasons[2].Code);
                Assert.Equal(0, transactWrite.ConditionCheckFailedItems.Count);
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(id1);
                transactGet.AddKey(id2);
                transactGet.AddKey(id3);
                await transactGet.ExecuteAsync();
                Assert.Equal(0, transactGet.Results.Count);
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
                transactWrite.AddDocumentToUpdate(doc3, hashKey: id3, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "attribute_not_exists(#id) AND #price <> :price",
                        ExpressionAttributeNames = { ["#id"] = "Id", ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                await transactWrite.ExecuteAsync();
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(id1);
                transactGet.AddKey(id2);
                transactGet.AddKey(id3);
                await transactGet.ExecuteAsync();
                Assert.Equal(3, transactGet.Results.Count);
                Assert.True(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.True(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                Assert.True(AreValuesEqual(doc3, transactGet.Results[2], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddKeyToConditionCheck(hashKey: id1, new TransactWriteItemOperationConfig
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
                }, hashKey: id2, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 99 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                transactWrite.AddKeyToDelete(hashKey: id3, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });
                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());
                Assert.NotNull(ex);
                Assert.Equal(3, ex.CancellationReasons.Count);
                Assert.Equal(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[0].Code);
                Assert.NotEqual(0, ex.CancellationReasons[0].Item.Count);
                Assert.Equal(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[1].Code);
                Assert.NotEqual(0, ex.CancellationReasons[1].Item.Count);
                Assert.Equal("None", ex.CancellationReasons[2].Code);

                if (AWSConfigs.InitializeCollections)
                    Assert.Equal(0, ex.CancellationReasons[2].Item.Count);
                else
                    Assert.Null(ex.CancellationReasons[2].Item);

                Assert.Equal(2, transactWrite.ConditionCheckFailedItems.Count);
                Assert.True(AreValuesEqual(doc1, transactWrite.ConditionCheckFailedItems[0], conversion));
                Assert.True(AreValuesEqual(doc2, transactWrite.ConditionCheckFailedItems[1], conversion));
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(id1);
                transactGet.AddKey(id2);
                transactGet.AddKey(id3);
                await transactGet.ExecuteAsync();
                Assert.Equal(3, transactGet.Results.Count);
                Assert.True(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.True(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                Assert.True(AreValuesEqual(doc3, transactGet.Results[2], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(new Document
                {
                    ["Id"] = id1,
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
                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());
                Assert.NotNull(ex);
                Assert.Equal(3, ex.CancellationReasons.Count);
                Assert.Equal("None", ex.CancellationReasons[0].Code);
                Assert.Equal("None", ex.CancellationReasons[1].Code);
                Assert.Equal(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[2].Code);
                Assert.NotEqual(0, ex.CancellationReasons[2].Item.Count);
                Assert.Equal(1, transactWrite.ConditionCheckFailedItems.Count);
                Assert.True(AreValuesEqual(doc3, transactWrite.ConditionCheckFailedItems[0], conversion));

                if (AWSConfigs.InitializeCollections)
                {
                    Assert.Equal(0, ex.CancellationReasons[0].Item.Count);
                    Assert.Equal(0, ex.CancellationReasons[1].Item.Count);
                }
                else
                {
                    Assert.Null(ex.CancellationReasons[0].Item);
                    Assert.Null(ex.CancellationReasons[1].Item);
                }
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(id1);
                transactGet.AddKey(id2);
                transactGet.AddKey(id3);
                await transactGet.ExecuteAsync();
                Assert.Equal(3, transactGet.Results.Count);
                Assert.True(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.True(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                Assert.True(AreValuesEqual(doc3, transactGet.Results[2], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToPut(new Document
                {
                    ["Id"] = id1,
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
                    ["Id"] = id2,
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
                transactWrite.AddKeyToDelete(key: new Document { ["Id"] = id3 }, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 500 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                await transactWrite.ExecuteAsync();
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(id1);
                transactGet.AddKey(id2);
                transactGet.AddKey(id3);
                await transactGet.ExecuteAsync();
                Assert.Equal(2, transactGet.Results.Count);
                Assert.False(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                doc1["Price"] = 51;
                doc1.Remove("Garbage");
                Assert.True(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.False(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                doc2["Price"] = 101;
                doc2.Remove("Garbage");
                Assert.True(AreValuesEqual(doc2, transactGet.Results[1], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                AssertExtensions.ExpectException<ArgumentException>(() => transactWrite.AddDocumentToUpdate(hashKey: id1,
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
                AssertExtensions.ExpectException<ArgumentException>(() => transactWrite.AddDocumentToUpdate(hashKey: id1,
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
                transactWrite.AddDocumentToUpdate(hashKey: id1,
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
                transactWrite.AddDocumentToUpdate(hashKey: id2,
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
                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());
                Assert.NotNull(ex);
                Assert.Equal(2, ex.CancellationReasons.Count);
                Assert.Equal("None", ex.CancellationReasons[0].Code);
                Assert.Equal(BatchStatementErrorCodeEnum.ConditionalCheckFailed.Value, ex.CancellationReasons[1].Code);
                Assert.NotEqual(0, ex.CancellationReasons[1].Item.Count);
                Assert.Equal(1, transactWrite.ConditionCheckFailedItems.Count);
                Assert.True(AreValuesEqual(doc2, transactWrite.ConditionCheckFailedItems[0], conversion));
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(id1);
                transactGet.AddKey(id2);
                await transactGet.ExecuteAsync();
                Assert.Equal(2, transactGet.Results.Count);
                Assert.True(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.True(AreValuesEqual(doc2, transactGet.Results[1], conversion));
            }

            {
                var transactWrite = hashTable.CreateTransactWrite();
                transactWrite.AddDocumentToUpdate(hashKey: id1,
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
                transactWrite.AddDocumentToUpdate(hashKey: id2,
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

                await transactWrite.ExecuteAsync();
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(id1);
                transactGet.AddKey(id2);
                await transactGet.ExecuteAsync();
                Assert.Equal(2, transactGet.Results.Count);
                Assert.False(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                doc1["Price"] = 52;
                Assert.True(AreValuesEqual(doc1, transactGet.Results[0], conversion));
                Assert.False(AreValuesEqual(doc2, transactGet.Results[1], conversion));
                doc2["Price"] = 102;
                Assert.True(AreValuesEqual(doc2, transactGet.Results[1], conversion));
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
                transactWrite.AddKeyToDelete(hashKey: id2, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = new Expression
                    {
                        ExpressionStatement = "#price = :price",
                        ExpressionAttributeNames = { ["#price"] = "Price" },
                        ExpressionAttributeValues = { [":price"] = 102 }
                    },
                    ReturnValuesOnConditionCheckFailure = ReturnValuesOnConditionCheckFailure.AllOldAttributes
                });

                await transactWrite.ExecuteAsync();
            }

            {
                var transactGet = hashTable.CreateTransactGet();
                transactGet.AddKey(id1);
                transactGet.AddKey(id2);
                transactGet.AddKey(id3);
                await transactGet.ExecuteAsync();
                Assert.Equal(0, transactGet.Results.Count);
            }
        }

#if NETFRAMEWORK
        private async Task TestExpressionPutHelper(ITable hashTable)
        {
            Document doc = new Document
            {
                ["Id"] = DateTime.UtcNow.Ticks,
                ["name"] = "condition-form"
            };
            await hashTable.PutItemAsync(doc);

            Expression expression = new Expression
            {
                ExpressionStatement = "attribute_not_exists(referencecounter) or referencecounter = :cond1",
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                {
                    { ":cond1", 0 }
                }
            };
            PutItemOperationConfig config = new PutItemOperationConfig
            {
                ConditionalExpression = expression
            };

            doc["update-test"] = 1;
            Assert.True(hashTable.TryPutItem(doc, config));

            doc["referencecounter"] = 0;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = null;
            Assert.True(hashTable.TryPutItem(doc, config));

            // Make sure removing attributes works
            doc = await hashTable.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true });
            Assert.False(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = 3;
            Assert.False(hashTable.TryPutItem(doc, config));

            await hashTable.DeleteItemAsync(doc);
        }

        private async Task TestExpressionPutWithoutValuesHelper(ITable hashTable)
        {
            var doc = new Document
            {
                ["Id"] = DateTime.UtcNow.Ticks
            };

            Assert.True(hashTable.TryPutItem(doc, new PutItemOperationConfig
            {
                ConditionalExpression = new Expression
                {
                    ExpressionStatement = "attribute_not_exists(Id)"
                }
            }));
            await hashTable.DeleteItemAsync(doc);
        }

        private async Task TestExpressionUpdateHelper(ITable hashTable)
        {
            Document doc = new Document
            {
                ["Id"] = DateTime.UtcNow.Ticks,
                ["name"] = "condition-form"
            };
            await hashTable.PutItemAsync(doc);

            Expression expression = new Expression
            {
                ExpressionStatement = "attribute_not_exists(referencecounter) or referencecounter = :cond1",
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                {
                    { ":cond1", 0 }
                }
            };

            UpdateItemOperationConfig config = new UpdateItemOperationConfig
            {
                ConditionalExpression = expression
            };

            doc["update-test"] = 1;
            Assert.True(hashTable.TryUpdateItem(doc, config));

            doc["referencecounter"] = 0;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = null;
            Assert.True(hashTable.TryUpdateItem(doc, config));

            // Make sure removing attributes works
            doc = await hashTable.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true });
            Assert.False(doc.Contains("update-test"));

            doc["referencecounter"] = 1;
            await hashTable.UpdateItemAsync(doc);

            doc["update-test"] = 3;
            Assert.False(hashTable.TryUpdateItem(doc, config));

            doc = await hashTable.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true });
            Assert.False(doc.Contains("update-test"));

            await hashTable.DeleteItemAsync(doc);
        }

        private async Task TestExpressionUpdateWithoutValuesHelper(ITable hashTable)
        {
            var doc = new Document
            {
                ["Id"] = DateTime.UtcNow.Ticks,
                ["currentVersion"] = null,
            };

            var config = new UpdateItemOperationConfig
            {
                ConditionalExpression = new Expression
                {
                    ExpressionStatement = "attribute_not_exists(updateVersion)",
                }
            };

            Assert.True(hashTable.TryUpdateItem(doc, config));
            await hashTable.DeleteItemAsync(doc);
        }
#endif

        private async Task TestSelectCountOnQueryHelper(ITable hashTable)
        {
            await hashTable.PutItemAsync(new Document
            {
                ["Id"] = 1,
                ["Data"] = Guid.NewGuid().ToString()
            });

            var search = hashTable.Query(new QueryOperationConfig
            {
                KeyExpression = new Expression
                {
                    ExpressionStatement = "Id = :id",
                    ExpressionAttributeValues = { [":id"] = 1 }
                },
                Select = SelectValues.Count
            });

            var docs = await search.GetRemainingAsync();
            Assert.Equal(1, search.Count);
            Assert.Equal(0, docs.Count);
        }

#if NETFRAMEWORK
        private async Task TestExpressionPutWithDocumentOperationRequestHelper(ITable table)
        {
            var doc = new Document
            {
                ["Id"] = DateTime.UtcNow.Ticks,
                ["name"] = "docop-conditional-form"
            };

            await table.PutItemAsync(doc);

            var conditionalExpression = new Expression
            {
                ExpressionStatement = "attribute_not_exists(referencecounter) OR referencecounter = :zero",
                ExpressionAttributeValues = { [":zero"] = 0 }
            };

            var putRequest = new PutItemDocumentOperationRequest
            {
                Document = doc,
                ConditionalExpression = conditionalExpression
            };

            doc["update-test"] = 1;
            Assert.True(table.TryPutItem(putRequest));

            doc["referencecounter"] = 0;
            await table.UpdateItemAsync(doc);

            doc["update-test"] = null;
            Assert.True(table.TryPutItem(new PutItemDocumentOperationRequest { Document = doc, ConditionalExpression = conditionalExpression }));

            var reloaded = await table.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true });
            Assert.False(reloaded.Contains("update-test"));

            doc["referencecounter"] = 1;
            await table.UpdateItemAsync(doc);

            doc["update-test"] = 3;
            Assert.False(table.TryPutItem(new PutItemDocumentOperationRequest { Document = doc, ConditionalExpression = conditionalExpression }));

            await table.DeleteItemAsync(doc);
        }

        private async Task TestExpressionUpdateWithDocumentOperationRequestHelper(ITable table)
        {
            var doc = new Document
            {
                ["Id"] = DateTime.UtcNow.Ticks,
                ["name"] = "docop-update-conditional"
            };
            await table.PutItemAsync(doc);

            var conditionalExpression = new Expression
            {
                ExpressionStatement = "attribute_not_exists(referencecounter) OR referencecounter = :zero",
                ExpressionAttributeValues = { [":zero"] = 0 }
            };

            doc["update-test"] = 1;
            Assert.True(table.TryUpdateItem(new UpdateItemDocumentOperationRequest
            {
                Document = doc,
                ConditionalExpression = conditionalExpression
            }));

            doc["referencecounter"] = 0;
            await table.UpdateItemAsync(doc);

            doc["update-test"] = null;
            Assert.True(table.TryUpdateItem(new UpdateItemDocumentOperationRequest
            {
                Document = doc,
                ConditionalExpression = conditionalExpression
            }));

            var reloaded = await table.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true });
            Assert.False(reloaded.Contains("update-test"));

            doc["referencecounter"] = 1;
            await table.UpdateItemAsync(doc);

            doc["update-test"] = 3;
            Assert.False(table.TryUpdateItem(new UpdateItemDocumentOperationRequest
            {
                Document = doc,
                ConditionalExpression = conditionalExpression
            }));

            await table.DeleteItemAsync(doc);
        }

        private async Task TestExpressionsOnDeleteWithDocumentOperationRequestHelper(ITable table)
        {
            var doc = new Document
            {
                ["Id"] = 9001,
                ["Price"] = 6
            };
            await table.PutItemAsync(doc);

            var key = new Dictionary<string, DynamoDBEntry>
            {
                { "Id", doc["Id"] }
            };

            var expression = new Expression
            {
                ExpressionStatement = "Price > :price",
                ExpressionAttributeValues = { [":price"] = 7 }
            };

            var failingRequest = new DeleteItemDocumentOperationRequest
            {
                Key = key,
                ConditionalExpression = expression,
                ReturnValues = ReturnValues.AllOldAttributes
            };

            Assert.False(table.TryDeleteItem(failingRequest));
            Assert.NotNull(await table.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true }));

            expression.ExpressionAttributeValues[":price"] = 4;

            var succeedingRequest = new DeleteItemDocumentOperationRequest
            {
                Key = key,
                ConditionalExpression = expression,
                ReturnValues = ReturnValues.AllOldAttributes
            };

            var oldAttributes = await table.DeleteItemAsync(succeedingRequest);
            Assert.NotNull(oldAttributes);
            Assert.Equal(6, oldAttributes["Price"].AsInt());

            Assert.Null(await table.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true }));
        }
#endif

        private bool AreValuesEqual(Document docA, Document docB, DynamoDBEntryConversion conversion = null)
        {
            if (conversion != null)
            {
                docA = docA.ForceConversion(conversion);
                docB = docB.ForceConversion(conversion);
            }

            if (ReferenceEquals(docA, docB))
            {
                return true;
            }

            return docA.Equals(docB);
        }
    }
}
