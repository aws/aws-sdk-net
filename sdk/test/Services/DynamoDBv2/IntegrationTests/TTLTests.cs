using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class TTLTests : IClassFixture<TTLTablesFixture>, IAsyncLifetime
    {
        private readonly TTLTablesFixture _fixture;

        private static readonly DateTime EpochDate = DateTime.UtcNow.Date.AddDays(7);
        private static readonly TimeSpan Epsilon = TimeSpan.FromSeconds(1);
        private static readonly int EpochSeconds = AWSSDKUtils.ConvertToUnixEpochSeconds(EpochDate);
        private static readonly DateTime LongEpochDate = new DateTime(2039, 1, 1, 2, 13, 23, DateTimeKind.Utc);
        private static readonly long LongEpochSeconds = long.Parse(AWSSDKUtils.ConvertToUnixEpochSecondsString(LongEpochDate));

        public TTLTests(TTLTablesFixture fixture)
        {
            _fixture = fixture;
        }

        public async ValueTask InitializeAsync() => await _fixture.CleanupTables();

        public ValueTask DisposeAsync() => default;

        private DynamoDBContext CreateContext(DynamoDBEntryConversion conversion)
        {
            return new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = conversion;
                    x.DisableFetchingTableMetadata = false;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                    x.ConsistentRead = true;
                })
                .Build();
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestStoreAsEpoch(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateContext(conversion))
            {
            var numericEmployee = new NumericEpochEmployee
            {
                Name = "Bob",
                Age = 45,
                CreationTime = EpochDate,
                EpochDate2 = EpochDate,
                NonEpochDate1 = EpochDate,
                NonEpochDate2 = EpochDate,
                NullableEpochDate2 = EpochDate,
                LongEpochDate1 = LongEpochDate,
                LongEpochDate2 = LongEpochDate.AddMonths(3),
                NullableLongEpochDate2 = LongEpochDate.AddMonths(-3)
            };
            EpochEmployee employee = numericEmployee;

            await context.SaveAsync(employee);
            var storedEmployee = await context.LoadAsync<EpochEmployee>(employee.Name, employee.Age);
            Assert.NotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            Assert.Null(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedEmployee.LongEpochDate2);
            Assert.Null(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);
            storedEmployee = await context.LoadAsync(employee);
            Assert.NotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            Assert.Null(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedEmployee.LongEpochDate2);
            Assert.Null(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);

            await context.SaveAsync(numericEmployee);
            var storedNumericEmployee = await context.LoadAsync<NumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.NotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
            Assert.Null(storedNumericEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedNumericEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedNumericEmployee.LongEpochDate2);
            Assert.Null(storedNumericEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);

            storedNumericEmployee = await context.LoadAsync(numericEmployee);
            Assert.NotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
            Assert.Null(storedNumericEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedNumericEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedNumericEmployee.LongEpochDate2);
            Assert.Null(storedNumericEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedNumericEmployee.NullableLongEpochDate2.Value);

            var doc = context.ToDocument(employee);
            ApproximatelyEqual(EpochDate, doc["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["EpochDate2"].AsDateTime());
            Assert.Null(doc["NullableEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(EpochDate, doc["NullableEpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["NonEpochDate2"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, doc["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), doc["LongEpochDate2"].AsDateTime());
            Assert.Null(doc["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), doc["NullableLongEpochDate2"].AsDateTime());

            var docV1 = doc.ForceConversion(DynamoDBEntryConversion.V1);
            ApproximatelyEqual(EpochDate, docV1["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["EpochDate2"].AsDateTime());
            Assert.Null(docV1["NullableEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(EpochDate, docV1["NullableEpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["NonEpochDate2"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, docV1["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), docV1["LongEpochDate2"].AsDateTime());
            Assert.Null(docV1["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), docV1["NullableLongEpochDate2"].AsDateTime());

            var docV2 = doc.ForceConversion(DynamoDBEntryConversion.V2);
            ApproximatelyEqual(EpochDate, docV2["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["EpochDate2"].AsDateTime());
            Assert.Null(docV2["NullableEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(EpochDate, docV2["NullableEpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["NonEpochDate2"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, docV2["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), docV2["LongEpochDate2"].AsDateTime());
            Assert.Null(docV2["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), docV2["NullableLongEpochDate2"].AsDateTime());

            var epochTable = context.GetTargetTable<EpochEmployee>() as Table; // Do an explicit cast since we want to access internal methods.
            var epochAttributes = epochTable.GetStoreAsEpoch().ToList();
            Assert.NotEqual(0, epochAttributes.Count);

            var epochMap = epochTable.ToAttributeMap(doc);
            Assert.NotNull(epochMap["CreationTime"].N);
            Assert.NotNull(epochMap["EpochDate2"].N);
            Assert.NotNull(epochMap["NonEpochDate1"].S);
            Assert.NotNull(epochMap["NonEpochDate2"].S);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestStoreAsAnnotatedEpoch(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateContext(conversion))
            {
                var numericEmployee = new AnnotatedNumEpochEmployee
                {
                    Name = "Bob",
                    Age = 45,
                    CreationTime = EpochDate,
                    EpochDate2 = EpochDate,
                    NonEpochDate1 = EpochDate,
                    NonEpochDate2 = EpochDate
                };
                AnnotatedEpochEmployee employee = numericEmployee;

                await context.SaveAsync(employee);
                var storedEmployee = await context.LoadAsync<AnnotatedEpochEmployee>(employee.CreationTime, employee.Name);
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
                storedEmployee = await context.LoadAsync(employee);
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);

                await context.SaveAsync(numericEmployee);
                var storedNumericEmployee = await context.LoadAsync<AnnotatedNumEpochEmployee>(employee.CreationTime, employee.Name);
                Assert.NotNull(storedNumericEmployee);
                ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
                storedNumericEmployee = await context.LoadAsync(numericEmployee);
                Assert.NotNull(storedNumericEmployee);
                ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);

                var doc = context.ToDocument(employee);
                ApproximatelyEqual(EpochDate, doc["CreationTime"].AsDateTime());
                ApproximatelyEqual(EpochDate, doc["EpochDate2"].AsDateTime());
                ApproximatelyEqual(EpochDate, doc["NonEpochDate1"].AsDateTime());
                ApproximatelyEqual(EpochDate, doc["NonEpochDate2"].AsDateTime());

                var docV1 = doc.ForceConversion(DynamoDBEntryConversion.V1);
                ApproximatelyEqual(EpochDate, docV1["CreationTime"].AsDateTime());
                ApproximatelyEqual(EpochDate, docV1["EpochDate2"].AsDateTime());
                ApproximatelyEqual(EpochDate, docV1["NonEpochDate1"].AsDateTime());
                ApproximatelyEqual(EpochDate, docV1["NonEpochDate2"].AsDateTime());

                var docV2 = doc.ForceConversion(DynamoDBEntryConversion.V2);
                ApproximatelyEqual(EpochDate, docV2["CreationTime"].AsDateTime());
                ApproximatelyEqual(EpochDate, docV2["EpochDate2"].AsDateTime());
                ApproximatelyEqual(EpochDate, docV2["NonEpochDate1"].AsDateTime());
                ApproximatelyEqual(EpochDate, docV2["NonEpochDate2"].AsDateTime());

                var epochTable = context.GetTargetTable<AnnotatedEpochEmployee>() as Table;
                var epochAttributes = epochTable.GetStoreAsEpoch().ToList();
                Assert.NotEqual(0, epochAttributes.Count);

                var epochMap = epochTable.ToAttributeMap(doc);
                Assert.NotNull(epochMap["CreationTime"].N);
                Assert.NotNull(epochMap["EpochDate2"].N);
                Assert.NotNull(epochMap["NonEpochDate1"].S);
                Assert.NotNull(epochMap["NonEpochDate2"].S);
            }
        }

        [Fact]
        public async Task TestAsDateTimeUtc()
        {
            var config = new TableConfig(_fixture.NumericHashRangeTableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2" },
                AttributesToStoreAsEpochLong = new List<string> { "LongEpochDate" }
            };
            var numericEpochTable = Table.LoadTable(_fixture.Client, config);

            var currTime = DateTime.Now;
            var currTimeUtc = currTime.ToUniversalTime();
            var longEpochTimeUtc = new DateTime(2039, 1, 1, 13, 56, 34).ToUniversalTime();

            await numericEpochTable.PutItemAsync(new Document
            {
                ["Name"] = "Bob",
                ["CreationTime"] = currTime,
                ["EpochDate2"] = currTime,
                ["NonEpochDate"] = currTime,
                ["LongEpochDate"] = longEpochTimeUtc
            });

            var storedDoc = await numericEpochTable.GetItemAsync(currTime, "Bob", new GetItemOperationConfig { ConsistentRead = true });
            ApproximatelyEqual(currTimeUtc, storedDoc["CreationTime"].AsDateTimeUtc());
            ApproximatelyEqual(currTimeUtc, storedDoc["EpochDate2"].AsDateTimeUtc());
            ApproximatelyEqual(currTimeUtc, storedDoc["NonEpochDate"].AsDateTimeUtc());
            ApproximatelyEqual(longEpochTimeUtc, storedDoc["LongEpochDate"].AsDateTimeUtc());
        }

        [Fact]
        public async Task TestStoreAsEpochDocument()
        {
            var hashRangeTable = Table.LoadTable(_fixture.Client, _fixture.HashRangeTableName);
            var numericHashRangeTable = Table.LoadTable(_fixture.Client, _fixture.NumericHashRangeTableName);

            // verify conversions
            var e1 = DateTimeToEpochSeconds((Primitive) EpochDate, "test") as Primitive;
            Assert.NotNull(e1);
            Assert.Equal(DynamoDBEntryType.Numeric, e1.Type);
            Assert.Equal(EpochSeconds, e1.AsInt());

            var e2 = EpochSecondsToDateTime((Primitive) EpochSeconds, "test") as Primitive;
            Assert.NotNull(e2);
            Assert.Equal(DynamoDBEntryType.String, e2.Type);
            ApproximatelyEqual(EpochDate, e2.AsDateTime());

            // verify conversions for LongEpoch
            var longEpoch1 = DateTimeToEpochSecondsLong((Primitive) LongEpochDate, "test") as Primitive;
            Assert.NotNull(longEpoch1);
            Assert.Equal(DynamoDBEntryType.Numeric, longEpoch1.Type);
            Assert.Equal(LongEpochSeconds, longEpoch1.AsLong());

            var longEpoch2 = EpochSecondsLongToDateTime((Primitive) LongEpochSeconds, "test") as Primitive;
            Assert.NotNull(longEpoch2);
            Assert.Equal(DynamoDBEntryType.String, longEpoch2.Type);
            ApproximatelyEqual(LongEpochDate, longEpoch2.AsDateTime());

            // construct tables with StoreAsEpoch and StoreAsEpochLong
            var config = new TableConfig(hashRangeTable.TableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2", "NullableEpochDate1", "NullableEpochDate2" },
                AttributesToStoreAsEpochLong = new List<string> { "LongEpochDate", "NullableLongEpochDate1", "NullableLongEpochDate2" }
            };
            var epochTable = Table.LoadTable(_fixture.Client, config) as Table; // Do an explicit cast since we want to access internal methods.
            Assert.Equal(config.AttributesToStoreAsEpoch, epochTable.GetStoreAsEpoch().ToList());
            Assert.Equal(config.AttributesToStoreAsEpochLong, epochTable.GetStoreAsEpochLong().ToList());

            config = new TableConfig(numericHashRangeTable.TableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2", "NullableEpochDate1", "NullableEpochDate2" },
                AttributesToStoreAsEpochLong = new List<string> { "LongEpochDate", "NullableLongEpochDate1", "NullableLongEpochDate2" }
            };
            var numericEpochTable = Table.LoadTable(_fixture.Client, config) as Table; // Do an explicit cast since we want to access internal methods.
            Assert.Equal(config.AttributesToStoreAsEpoch, numericEpochTable.GetStoreAsEpoch().ToList());
            Assert.Equal(config.AttributesToStoreAsEpochLong, numericEpochTable.GetStoreAsEpochLong().ToList());

            // verify ToAttributeMap calls
            var map = hashRangeTable.ToAttributeMap(CreateTestDocument());
            Assert.NotNull(map["CreationTime"].S);
            Assert.NotNull(map["EpochDate2"].S);
            Assert.NotNull(map["NonEpochDate"].S);
            Assert.NotNull(map["NullableEpochDate1"].S);
            Assert.False(map.ContainsKey("NullableEpochDate2"));
            Assert.NotNull(map["LongEpochDate"].S);
            Assert.NotNull(map["NullableLongEpochDate1"].S);
            Assert.False(map.ContainsKey("NullableLongEpochDate2"));

            var epochMap = epochTable.ToAttributeMap(CreateTestDocument());
            Assert.NotNull(epochMap["CreationTime"].N);
            Assert.NotNull(epochMap["EpochDate2"].N);
            Assert.NotNull(epochMap["NonEpochDate"].S);
            Assert.NotNull(epochMap["NullableEpochDate1"].N);
            Assert.NotNull(epochMap["LongEpochDate"].N);
            Assert.NotNull(epochMap["NullableLongEpochDate1"].N);

            // put
            await epochTable.PutItemAsync(CreateTestDocument());
            await TestWrittenData("Bob", 42, hashRangeTable, epochTable);
            await numericEpochTable.PutItemAsync(CreateTestDocument());

            // accessing this item with non-epoch table will throw an exception
            await TestWrittenData(EpochDate, "Bob", null, numericEpochTable);
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => numericHashRangeTable.GetItemAsync(EpochDate, "Bob"));
            Assert.Contains("hash key CreationTime, is inconsistent with specified hash key value.", exception.Message);

            // conditional put
            await epochTable.PutItemAsync(CreateTestDocument());
            var newDoc = CreateTestDocument();
            newDoc["ConditionalUpdate"] = "yes";

            var expectedState = new ExpectedState();
            expectedState.AddExpected("CreationTime", ScanOperator.Equal, EpochDate);
            await epochTable.PutItemAsync(newDoc, new PutItemOperationConfig { ExpectedState = expectedState });
            await TestWrittenData("Bob", 42, hashRangeTable, epochTable, checkForConditionalUpdate: true);

            // update
            await epochTable.UpdateItemAsync(CreateTestDocument());
            await TestWrittenData("Bob", 42, hashRangeTable, epochTable);

            // conditional update
            await epochTable.UpdateItemAsync(CreateTestDocument());
            newDoc = CreateTestDocument();
            newDoc["ConditionalUpdate"] = "yes";
            expectedState = new ExpectedState();
            expectedState.AddExpected("CreationTime", ScanOperator.Equal, EpochDate);
            await epochTable.UpdateItemAsync(newDoc, new UpdateItemOperationConfig { ExpectedState = expectedState });
            await TestWrittenData("Bob", 42, hashRangeTable, epochTable, checkForConditionalUpdate: true);

            // second item for batch operations
            var doc2 = new Document
            {
                ["Name"] = "Bob",
                ["Age"] = 43,
                ["CreationTime"] = EpochDate,
                ["EpochDate2"] = EpochDate,
                ["NonEpochDate"] = EpochDate,
                ["NullableEpochDate1"] = (DateTime?)EpochDate,
                ["NullableEpochDate2"] = (DateTime?)null,
                ["LongEpochDate"] = LongEpochDate,
                ["NullableLongEpochDate1"] = (DateTime?)LongEpochDate,
                ["NullableLongEpochDate2"] = (DateTime?)null
            };

            // batchWrite epoch seconds
            var batchWrite = epochTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(CreateTestDocument());
            batchWrite.AddDocumentToPut(doc2);
            await batchWrite.ExecuteAsync();
            await TestWrittenData("Bob", 42, hashRangeTable, epochTable);
            await TestWrittenData("Bob", 43, hashRangeTable, epochTable);
            // execute again, since TestWrittenData deletes the items
            await batchWrite.ExecuteAsync();

            // batchGet epoch seconds as DateTime
            var epochBatchGet = epochTable.CreateBatchGet();
            epochBatchGet.ConsistentRead = true;
            epochBatchGet.AddKey("Bob", 42);
            epochBatchGet.AddKey("Bob", 43);
            await epochBatchGet.ExecuteAsync();
            TestForDateTime(epochBatchGet.Results);

            // batchGet epoch seconds as int
            var batchGet = hashRangeTable.CreateBatchGet();
            batchGet.ConsistentRead = true;
            batchGet.AddKey("Bob", 42);
            batchGet.AddKey("Bob", 43);
            await batchGet.ExecuteAsync();
            TestForInts(batchGet.Results);

            // batchWrite ISO-8601
            batchWrite = hashRangeTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(CreateTestDocument());
            batchWrite.AddDocumentToPut(doc2);
            await batchWrite.ExecuteAsync();

            // batchGet ISO-8601 as DateTime
            epochBatchGet = epochTable.CreateBatchGet();
            epochBatchGet.ConsistentRead = true;
            epochBatchGet.AddKey("Bob", 42);
            epochBatchGet.AddKey("Bob", 43);
            await epochBatchGet.ExecuteAsync();
            TestForDateTime(epochBatchGet.Results);

            // batchGet ISO-8601 as DateTime with non-epoch table
            batchGet = hashRangeTable.CreateBatchGet();
            batchGet.ConsistentRead = true;
            batchGet.AddKey("Bob", 42);
            batchGet.AddKey("Bob", 43);
            await batchGet.ExecuteAsync();
            TestForDateTime(batchGet.Results);

            // write epoch seconds data data for Scan and Query
            batchWrite = epochTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(CreateTestDocument());
            batchWrite.AddDocumentToPut(doc2);
            await batchWrite.ExecuteAsync();

            // query
            var toTest = await hashRangeTable.Query("Bob", new QueryFilter()).GetRemainingAsync();
            TestForInts(toTest);
            toTest = await epochTable.Query("Bob", new QueryFilter()).GetRemainingAsync();
            TestForDateTime(toTest);

            // scan, condition is epoch seconds attribute
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("CreationTime", ScanOperator.Equal, EpochDate);
            toTest = await hashRangeTable.Scan(scanFilter).GetRemainingAsync();
            Assert.Equal(0, toTest.Count);
            toTest = await epochTable.Scan(scanFilter).GetRemainingAsync();
            TestForDateTime(toTest);

            // scan, condition is Name
            scanFilter = new ScanFilter();
            scanFilter.AddCondition("Name", ScanOperator.Equal, "Bob");
            toTest = await hashRangeTable.Scan(scanFilter).GetRemainingAsync();
            TestForInts(toTest);
            toTest = await epochTable.Scan(scanFilter).GetRemainingAsync();
            TestForDateTime(toTest);
        }

        private Document CreateTestDocument() => new Document
        {
            ["Name"] = "Bob",
            ["Age"] = 42,
            ["CreationTime"] = EpochDate,
            ["EpochDate2"] = EpochDate,
            ["NonEpochDate"] = EpochDate,
            ["NullableEpochDate1"] = (DateTime?)EpochDate,
            ["NullableEpochDate2"] = (DateTime?)null,
            ["LongEpochDate"] = LongEpochDate,
            ["NullableLongEpochDate1"] = (DateTime?)LongEpochDate,
            ["NullableLongEpochDate2"] = (DateTime?)null
        };

        private static async Task TestWrittenData(Primitive hash, Primitive range, ITable hashRangeTable, ITable epochTable, bool checkForConditionalUpdate = false)
        {
            if (hashRangeTable != null)
            {
                var nonEpochDoc = await hashRangeTable.GetItemAsync(hash, range, new GetItemOperationConfig { ConsistentRead = true });
                Assert.Equal(EpochSeconds, nonEpochDoc["CreationTime"].AsInt());
                Assert.Equal(EpochSeconds, nonEpochDoc["EpochDate2"].AsInt());
                ApproximatelyEqual(EpochDate, nonEpochDoc["NonEpochDate"].AsDateTime());
                Assert.Equal(EpochSeconds, nonEpochDoc["NullableEpochDate1"].AsInt());
                Assert.Equal(LongEpochSeconds, nonEpochDoc["LongEpochDate"].AsLong());
                Assert.Equal(LongEpochSeconds, nonEpochDoc["NullableLongEpochDate1"].AsLong());
                Assert.False(nonEpochDoc.ContainsKey("NullableLongEpochDate2"));
                if (checkForConditionalUpdate)
                {
                    Assert.Equal("yes", nonEpochDoc["ConditionalUpdate"].AsString());
                }
            }

            var epochDoc = await epochTable.GetItemAsync(hash, range, new GetItemOperationConfig { ConsistentRead = true });
            ApproximatelyEqual(EpochDate, epochDoc["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, epochDoc["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, epochDoc["NonEpochDate"].AsDateTime());
            ApproximatelyEqual(EpochDate, epochDoc["NullableEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, epochDoc["LongEpochDate"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, epochDoc["NullableLongEpochDate1"].AsDateTime());
            if (checkForConditionalUpdate)
            {
                Assert.Equal("yes", epochDoc["ConditionalUpdate"].AsString());
            }

            await epochTable.DeleteItemAsync(hash, range);
        }

        private static void TestForInts(List<Document> nonEpochDocs)
        {
            Assert.NotEqual(0, nonEpochDocs.Count);
            foreach (var ed in nonEpochDocs)
            {
                Assert.Equal(EpochSeconds, ed["CreationTime"].AsInt());
                Assert.Equal(EpochSeconds, ed["EpochDate2"].AsInt());
                ApproximatelyEqual(EpochDate, ed["NonEpochDate"].AsDateTime());
                Assert.Equal(EpochSeconds, ed["NullableEpochDate1"].AsInt());
                Assert.Equal(LongEpochSeconds, ed["LongEpochDate"].AsLong());
                Assert.Equal(LongEpochSeconds, ed["NullableLongEpochDate1"].AsLong());
            }
        }

        private static void TestForDateTime(List<Document> epochDocs)
        {
            Assert.NotEqual(0, epochDocs.Count);
            foreach (var ed in epochDocs)
            {
                ApproximatelyEqual(EpochDate, ed["CreationTime"].AsDateTime());
                ApproximatelyEqual(EpochDate, ed["EpochDate2"].AsDateTime());
                ApproximatelyEqual(EpochDate, ed["NonEpochDate"].AsDateTime());
                ApproximatelyEqual(EpochDate, ed["NullableEpochDate1"].AsDateTime());
                ApproximatelyEqual(LongEpochDate, ed["LongEpochDate"].AsDateTime());
                ApproximatelyEqual(LongEpochDate, ed["NullableLongEpochDate1"].AsDateTime());
            }
        }

        public static DynamoDBEntry EpochSecondsToDateTime(DynamoDBEntry entry, string attributeName)
        {
            var method = typeof(Document)
                .GetMethod("EpochSecondsToDateTime", BindingFlags.Static | BindingFlags.NonPublic);
            return method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
        }

        public static DynamoDBEntry DateTimeToEpochSeconds(DynamoDBEntry entry, string attributeName)
        {
            var method = typeof(Document)
                .GetMethod("DateTimeToEpochSeconds", BindingFlags.Static | BindingFlags.NonPublic);
            return method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
        }

        public static DynamoDBEntry DateTimeToEpochSecondsLong(DynamoDBEntry entry, string attributeName)
        {
            var method = typeof(Document)
                .GetMethod("DateTimeToEpochSecondsLong", BindingFlags.Static | BindingFlags.NonPublic);
            return method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
        }

        public static DynamoDBEntry EpochSecondsLongToDateTime(DynamoDBEntry entry, string attributeName)
        {
            var method = typeof(Document)
                .GetMethod("EpochSecondsLongToDateTime", BindingFlags.Static | BindingFlags.NonPublic);
            return method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
        }

        private static void ApproximatelyEqual(DateTime expected, DateTime actual)
        {
            var diff = actual - expected;
            var absDiff = diff.GetAbsolute();
            Assert.True(absDiff < Epsilon, string.Format("Verifying that {0} ~= {1}", expected, actual));
        }
    }
}
