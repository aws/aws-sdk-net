using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        #region Private members

        private static readonly DateTime EpochDate = DateTime.UtcNow.AddDays(7);
        private static readonly TimeSpan Epsilon = TimeSpan.FromSeconds(1);
        private static readonly int EpochSeconds = AWSSDKUtils.ConvertToUnixEpochSeconds(EpochDate);
        private static readonly DateTime LongEpochDate = new DateTime(2039, 1, 1, 2, 13, 23, DateTimeKind.Utc);
        private static readonly long LongEpochSeconds = long.Parse(AWSSDKUtils.ConvertToUnixEpochSecondsString(LongEpochDate));

        #endregion

        public async Task TestStoreAsEpoch()
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

            await Context.SaveAsync(employee);
            var storedEmployee = await Context.LoadAsync<EpochEmployee>(employee.Name, employee.Age);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);
            storedEmployee = await Context.LoadAsync(employee);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);

            await Context.SaveAsync(numericEmployee);
            var storedNumericEmployee = await Context.LoadAsync<NumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
            Assert.IsNull(storedNumericEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedNumericEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedNumericEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);

            storedNumericEmployee = await Context.LoadAsync(numericEmployee);
            Assert.IsNotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
            Assert.IsNull(storedNumericEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedNumericEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedNumericEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedNumericEmployee.NullableLongEpochDate2.Value);

            var doc = Context.ToDocument(employee);
            ApproximatelyEqual(EpochDate, doc["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["EpochDate2"].AsDateTime());
            Assert.IsNull(doc["NullableEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(EpochDate, doc["NullableEpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, doc["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), doc["LongEpochDate2"].AsDateTime());
            Assert.IsNull(doc["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), doc["NullableLongEpochDate2"].AsDateTime());

            var docV1 = doc.ForceConversion(DynamoDBEntryConversion.V1);
            ApproximatelyEqual(EpochDate, docV1["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["EpochDate2"].AsDateTime());
            Assert.IsNull(docV1["NullableEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(EpochDate, docV1["NullableEpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, docV1["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), docV1["LongEpochDate2"].AsDateTime());
            Assert.IsNull(docV1["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), docV1["NullableLongEpochDate2"].AsDateTime());

            var docV2 = doc.ForceConversion(DynamoDBEntryConversion.V2);
            ApproximatelyEqual(EpochDate, docV2["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["EpochDate2"].AsDateTime());
            Assert.IsNull(docV2["NullableEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(EpochDate, docV2["NullableEpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, docV2["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), docV2["LongEpochDate2"].AsDateTime());
            Assert.IsNull(docV2["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), docV2["NullableLongEpochDate2"].AsDateTime());

            var epochTable = Context.GetTargetTable<EpochEmployee>() as Table; // Do an explicit cast since we want to access internal methods.
            var epochAttributes = epochTable.GetStoreAsEpoch().ToList();
            Assert.AreNotEqual(0, epochAttributes.Count);

            var epochMap = epochTable.ToAttributeMap(doc);
            Assert.IsNotNull(epochMap["CreationTime"].N);
            Assert.IsNotNull(epochMap["EpochDate2"].N);
            Assert.IsNotNull(epochMap["NonEpochDate1"].S);
            Assert.IsNotNull(epochMap["NonEpochDate2"].S);
        }

        public async Task TestStoreAsAnnotatedEpoch()
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

            await Context.SaveAsync(employee);
            var storedEmployee = await Context.LoadAsync<AnnotatedEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            storedEmployee = await Context.LoadAsync(employee);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);

            await Context.SaveAsync(numericEmployee);
            var storedNumericEmployee = await Context.LoadAsync<AnnotatedNumEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
            storedNumericEmployee = await Context.LoadAsync(numericEmployee);
            Assert.IsNotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);

            var doc = Context.ToDocument(employee);
            ApproximatelyEqual(EpochDate, doc["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["NonEpochDate1"].AsDateTime());

            var docV1 = doc.ForceConversion(DynamoDBEntryConversion.V1);
            ApproximatelyEqual(EpochDate, docV1["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["NonEpochDate1"].AsDateTime());

            var docV2 = doc.ForceConversion(DynamoDBEntryConversion.V1);
            ApproximatelyEqual(EpochDate, docV2["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["NonEpochDate1"].AsDateTime());

            var epochTable = Context.GetTargetTable<AnnotatedEpochEmployee>() as Table;
            var epochAttributes = epochTable.GetStoreAsEpoch().ToList();
            Assert.AreNotEqual(0, epochAttributes.Count);

            var epochMap = epochTable.ToAttributeMap(doc);
            Assert.IsNotNull(epochMap["CreationTime"].N);
            Assert.IsNotNull(epochMap["EpochDate2"].N);
            Assert.IsNotNull(epochMap["NonEpochDate1"].S);
            Assert.IsNotNull(epochMap["NonEpochDate2"].S);
        }

        public async Task TestStoreAsEpoch(ITable hashRangeTable, ITable numericHashRangeTable)
        {
            // verify conversions
            var e1 = DateTimeToEpochSeconds((Primitive) EpochDate, "test") as Primitive;
            Assert.IsNotNull(e1);
            Assert.AreEqual(DynamoDBEntryType.Numeric, e1.Type);
            Assert.AreEqual(EpochSeconds, e1.AsInt());

            var e2 = EpochSecondsToDateTime((Primitive) EpochSeconds, "test") as Primitive;
            Assert.IsNotNull(e2);
            Assert.AreEqual(DynamoDBEntryType.String, e2.Type);
            ApproximatelyEqual(EpochDate, e2.AsDateTime());

            // verify conversions for LongEpoch
            var longEpoch1 = DateTimeToEpochSecondsLong((Primitive) LongEpochDate, "test") as Primitive;
            Assert.IsNotNull(longEpoch1);
            Assert.AreEqual(DynamoDBEntryType.Numeric, longEpoch1.Type);
            Assert.AreEqual(LongEpochSeconds, longEpoch1.AsLong());

            var longEpoch2 = EpochSecondsLongToDateTime((Primitive) LongEpochSeconds, "test") as Primitive;
            Assert.IsNotNull(longEpoch2);
            Assert.AreEqual(DynamoDBEntryType.String, longEpoch2.Type);
            ApproximatelyEqual(LongEpochDate, longEpoch2.AsDateTime());

            // construct tables with StoreAsEpoch and StoreAsEpochLong
            var config = new TableConfig(hashRangeTable.TableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2", "NullableEpochDate1", "NullableEpochDate2" },
                AttributesToStoreAsEpochLong = new List<string> { "LongEpochDate", "NullableLongEpochDate1", "NullableLongEpochDate2" }
            };
            var epochTable = Table.LoadTable(Client, config) as Table; // Do an explicit cast since we want to access internal methods.
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpoch, epochTable.GetStoreAsEpoch().ToList());
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpochLong, epochTable.GetStoreAsEpochLong().ToList());

            config = new TableConfig(numericHashRangeTable.TableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2", "NullableEpochDate1", "NullableEpochDate2" },
                AttributesToStoreAsEpochLong = new List<string> { "LongEpochDate", "NullableLongEpochDate1", "NullableLongEpochDate2" }
            };
            var numericEpochTable = Table.LoadTable(Client, config) as Table; // Do an explicit cast since we want to access internal methods.
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpoch, numericEpochTable.GetStoreAsEpoch().ToList());
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpochLong, numericEpochTable.GetStoreAsEpochLong().ToList());

            // verify ToAttributeMap calls
            var map = hashRangeTable.ToAttributeMap(CreateTestDocument());
            Assert.IsNotNull(map["CreationTime"].S);
            Assert.IsNotNull(map["EpochDate2"].S);
            Assert.IsNotNull(map["NonEpochDate"].S);
            Assert.IsNotNull(map["NullableEpochDate1"].S);
            Assert.IsFalse(map.ContainsKey("NullableEpochDate2"));
            Assert.IsNotNull(map["LongEpochDate"].S);
            Assert.IsNotNull(map["NullableLongEpochDate1"].S);
            Assert.IsFalse(map.ContainsKey("NullableLongEpochDate2"));

            var epochMap = epochTable.ToAttributeMap(CreateTestDocument());
            Assert.IsNotNull(epochMap["CreationTime"].N);
            Assert.IsNotNull(epochMap["EpochDate2"].N);
            Assert.IsNotNull(epochMap["NonEpochDate"].S);
            Assert.IsNotNull(epochMap["NullableEpochDate1"].N);
            Assert.IsNotNull(epochMap["LongEpochDate"].N);
            Assert.IsNotNull(epochMap["NullableLongEpochDate1"].N);

            // put
            await epochTable.PutItemAsync(CreateTestDocument());
            await TestWrittenData("Bob", 42, hashRangeTable, epochTable);
            await numericEpochTable.PutItemAsync(CreateTestDocument());

            // accessing this item with non-epoch table will throw an exception
            await TestWrittenData(EpochDate, "Bob", null, numericEpochTable);
            var exception = await Assert.ThrowsExceptionAsync<InvalidOperationException>(() => numericHashRangeTable.GetItemAsync(EpochDate, "Bob"));
            Assert.IsTrue(exception.Message.Contains("hash key CreationTime, is inconsistent with specified hash key value."));

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
            Assert.AreEqual(0, toTest.Count);
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

        private static Document CreateTestDocument() => new Document
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
                Assert.AreEqual(EpochSeconds, nonEpochDoc["CreationTime"].AsInt());
                Assert.AreEqual(EpochSeconds, nonEpochDoc["EpochDate2"].AsInt());
                ApproximatelyEqual(EpochDate, nonEpochDoc["NonEpochDate"].AsDateTime());
                Assert.AreEqual(EpochSeconds, nonEpochDoc["NullableEpochDate1"].AsInt());
                Assert.AreEqual(LongEpochSeconds, nonEpochDoc["LongEpochDate"].AsLong());
                Assert.AreEqual(LongEpochSeconds, nonEpochDoc["NullableLongEpochDate1"].AsLong());
                Assert.IsFalse(nonEpochDoc.ContainsKey("NullableLongEpochDate2"));
                if (checkForConditionalUpdate)
                {
                    Assert.AreEqual("yes", nonEpochDoc["ConditionalUpdate"].AsString());
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
                Assert.AreEqual("yes", epochDoc["ConditionalUpdate"].AsString());
            }

            await epochTable.DeleteItemAsync(hash, range);
        }

        private static void TestForInts(List<Document> nonEpochDocs)
        {
            Assert.AreNotEqual(0, nonEpochDocs.Count);
            foreach (var ed in nonEpochDocs)
            {
                Assert.AreEqual(EpochSeconds, ed["CreationTime"].AsInt());
                Assert.AreEqual(EpochSeconds, ed["EpochDate2"].AsInt());
                ApproximatelyEqual(EpochDate, ed["NonEpochDate"].AsDateTime());
                Assert.AreEqual(EpochSeconds, ed["NullableEpochDate1"].AsInt());
                Assert.AreEqual(LongEpochSeconds, ed["LongEpochDate"].AsLong());
                Assert.AreEqual(LongEpochSeconds, ed["NullableLongEpochDate1"].AsLong());
            }
        }

        private static void TestForDateTime(List<Document> epochDocs)
        {
            Assert.AreNotEqual(0, epochDocs.Count);
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
            var result = method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
            return result;
        }

        public static DynamoDBEntry DateTimeToEpochSeconds(DynamoDBEntry entry, string attributeName)
        {
            var method = typeof(Document)
                .GetMethod("DateTimeToEpochSeconds", BindingFlags.Static | BindingFlags.NonPublic);
            var result = method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
            return result;
        }

        public static DynamoDBEntry DateTimeToEpochSecondsLong(DynamoDBEntry entry, string attributeName)
        {
            var method = typeof(Document)
                .GetMethod("DateTimeToEpochSecondsLong", BindingFlags.Static | BindingFlags.NonPublic);
            var result = method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
            return result;
        }

        public static DynamoDBEntry EpochSecondsLongToDateTime(DynamoDBEntry entry, string attributeName)
        {
            var method = typeof(Document)
                .GetMethod("EpochSecondsLongToDateTime", BindingFlags.Static | BindingFlags.NonPublic);
            var result = method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
            return result;
        }

        private static void ApproximatelyEqual(DateTime expected, DateTime actual)
        {
            var diff = actual - expected;
            var absDiff = diff.GetAbsolute();
            Assert.IsTrue(absDiff < Epsilon, string.Format("Verifying that {0} ~= {1}", expected, actual));
        }
    }
}
