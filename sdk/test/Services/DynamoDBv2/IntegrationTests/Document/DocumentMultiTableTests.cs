using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DocumentMultiTableTests : IClassFixture<HashTablesFixture>, IAsyncLifetime
    {
        private readonly HashTablesFixture _fixture;

        public DocumentMultiTableTests(HashTablesFixture fixture) => _fixture = fixture;

        public async ValueTask InitializeAsync() => await _fixture.CleanupTables();

        public ValueTask DisposeAsync() => default;

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestMultiTableOperations(DynamoDBEntryConversion conversion)
        {
            // Load tables
            Table.TryLoadTable(_fixture.Client, _fixture.HashTableName, conversion, true, out ITable hashTable);
            var hashRangeTable = Table.LoadTable(_fixture.Client, _fixture.HashRangeTableName, conversion, true);

            await TestMultiTableDocumentBatchWriteHelper(hashTable, hashRangeTable);
            await TestMultiTableDocumentTransactWriteHelper(hashTable, hashRangeTable, conversion);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestMultiTableViaBuilder(DynamoDBEntryConversion conversion)
        {
            var hashTable = new TableBuilder(_fixture.Client, _fixture.HashTableName, conversion, true, null)
                .AddHashKey("Id", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Price", DynamoDBEntryType.Numeric)
                .Build();

            var hashRangeTable = new TableBuilder(_fixture.Client, _fixture.HashRangeTableName, conversion, true, null)
                .AddHashKey("Name", DynamoDBEntryType.String)
                .AddRangeKey("Age", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Score", DynamoDBEntryType.Numeric)
                .AddLocalSecondaryIndex("LocalIndex", "Manager", DynamoDBEntryType.String)
                .Build();

            await TestMultiTableDocumentBatchWriteHelper(hashTable, hashRangeTable);
            await TestMultiTableDocumentTransactWriteHelper(hashTable, hashRangeTable, conversion);
        }

        private async Task TestMultiTableDocumentBatchWriteHelper(ITable hashTable, ITable hashRangeTable)
        {
            var multiTableDocumentBatchWrite = new MultiTableDocumentBatchWrite();

            var doc1a = new Document
            {
                ["Id"] = 5101,
                ["Data"] = Guid.NewGuid().ToString()
            };

            var doc1b = new Document
            {
                ["Id"] = 5102,
                ["Data"] = Guid.NewGuid().ToString()
            };

            {
                var writer = hashTable.CreateBatchWrite();
                writer.AddDocumentToPut(doc1a);
                writer.AddDocumentToPut(doc1b);
                multiTableDocumentBatchWrite.AddBatch(writer);
            }

            var doc2a = new Document
            {
                ["Id"] = 5201,
                ["Data"] = Guid.NewGuid().ToString()
            };

            var doc2b = new Document
            {
                ["Id"] = 5202,
                ["Data"] = Guid.NewGuid().ToString()
            };

            {
                var writer = hashTable.CreateBatchWrite();
                writer.AddDocumentToPut(doc2a);
                writer.AddDocumentToPut(doc2b);
                multiTableDocumentBatchWrite.AddBatch(writer);
            }

            var doc3a = new Document
            {
                ["Name"] = "Gunnar",
                ["Age"] = 77,
                ["Job"] = "Retired",
                ["Data"] = Guid.NewGuid().ToString()
            };

            {
                var writer = hashRangeTable.CreateBatchWrite();
                writer.AddDocumentToPut(doc3a);
                multiTableDocumentBatchWrite.AddBatch(writer);
            }

            await multiTableDocumentBatchWrite.ExecuteAsync();
            Document getDoc;
            var consistentRead = new GetItemOperationConfig { ConsistentRead = true };

            getDoc = await hashTable.GetItemAsync(5101, consistentRead);
            Assert.Equal(doc1a["Data"].AsString(), getDoc["Data"].AsString());

            getDoc = await hashTable.GetItemAsync(5102, consistentRead);
            Assert.Equal(doc1b["Data"].AsString(), getDoc["Data"].AsString());

            getDoc = await hashTable.GetItemAsync(5201, consistentRead);
            Assert.Equal(doc2a["Data"].AsString(), getDoc["Data"].AsString());

            getDoc = await hashTable.GetItemAsync(5202, consistentRead);
            Assert.Equal(doc2b["Data"].AsString(), getDoc["Data"].AsString());

            getDoc = await hashRangeTable.GetItemAsync("Gunnar", 77, consistentRead);
            Assert.Equal(doc3a["Data"].AsString(), getDoc["Data"].AsString());

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
            await multiTableDocumentBatchWrite.ExecuteAsync();
        }

        private async Task TestMultiTableDocumentTransactWriteHelper(ITable hashTable, ITable hashRangeTable, DynamoDBEntryConversion conversion)
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

            await multiTableDocumentTransactWrite.ExecuteAsync();

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

                await multiTableDocumentTransactGet.ExecuteAsync();
                Assert.Equal(2, hTransactGet.Results.Count);
                Assert.Equal(2, hrTransactGet.Results.Count);
                Assert.True(AreValuesEqual(hDoc1, hTransactGet.Results[0], conversion));
                Assert.True(AreValuesEqual(hDoc2, hTransactGet.Results[1], conversion));
                Assert.True(AreValuesEqual(hrDoc1, hrTransactGet.Results[0], conversion));
                Assert.True(AreValuesEqual(hrDoc2, hrTransactGet.Results[1], conversion));
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

            await multiTableDocumentTransactWrite.ExecuteAsync();

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

                await multiTableDocumentTransactGet.ExecuteAsync();
                Assert.Equal(2, hTransactGet.Results.Count);
                Assert.Equal(2, hrTransactGet.Results.Count);
                Assert.False(AreValuesEqual(hDoc1, hTransactGet.Results[0], conversion));
                hDoc1["Price"] = 1001;
                hDoc1.Remove("Garbage");
                Assert.True(AreValuesEqual(hDoc1, hTransactGet.Results[0], conversion));
                Assert.False(AreValuesEqual(hDoc2, hTransactGet.Results[1], conversion));
                hDoc2["Price"] = 501;
                hDoc2.Remove("Garbage");
                Assert.True(AreValuesEqual(hDoc2, hTransactGet.Results[1], conversion));
                Assert.False(AreValuesEqual(hrDoc1, hrTransactGet.Results[0], conversion));
                hrDoc1["Score"] = 101;
                hrDoc1.Remove("Garbage");
                Assert.True(AreValuesEqual(hrDoc1, hrTransactGet.Results[0], conversion));
                Assert.False(AreValuesEqual(hrDoc2, hrTransactGet.Results[1], conversion));
                hrDoc2["Score"] = 151;
                hrDoc2.Remove("Garbage");
                Assert.True(AreValuesEqual(hrDoc2, hrTransactGet.Results[1], conversion));
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

            await multiTableDocumentTransactWrite.ExecuteAsync();

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

                await multiTableDocumentTransactGet.ExecuteAsync();
                Assert.Equal(0, hTransactGet.Results.Count);
                Assert.Equal(0, hrTransactGet.Results.Count);
            }
        }

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
