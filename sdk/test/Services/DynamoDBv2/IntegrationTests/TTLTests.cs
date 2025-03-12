﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Util;
using ThirdParty.Json.LitJson;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        #region Private members

        private static readonly DateTime EpochDate = DateTime.Now.AddDays(7);
        private static readonly TimeSpan Epsilon = TimeSpan.FromSeconds(1);
        private static readonly int EpochSeconds = AWSSDKUtils.ConvertToUnixEpochSeconds(EpochDate);
        private static readonly DateTime LongEpochDate = new DateTime(2039, 1, 1, 2, 13, 23, DateTimeKind.Local);
        private static readonly long LongEpochSeconds = long.Parse(AWSSDKUtils.ConvertToUnixEpochSecondsString(LongEpochDate));

        #endregion

        public void TestStoreAsEpoch()
        {
            var numericEmployee = new NumericEpochEmployee
            {
                Name = "Bob",
                Age = 45,
                CreationTime = EpochDate,
                EpochDate2 = EpochDate,
                NonEpochDate1 = EpochDate,
                NonEpochDate2 = EpochDate,
                LongEpochDate1 = LongEpochDate,
                LongEpochDate2 = LongEpochDate.AddMonths(3),
                NullableLongEpochDate2 = LongEpochDate.AddMonths(-3)
            };
            EpochEmployee employee = numericEmployee;

            Context.Save(employee);
            var storedEmployee = Context.Load<EpochEmployee>(employee.Name, employee.Age);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            ApproximatelyEqual(LongEpochDate, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);
            storedEmployee = Context.Load<EpochEmployee>(employee);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            ApproximatelyEqual(LongEpochDate, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);

            Context.Save(numericEmployee);
            var storedNumericEmployee = Context.Load<NumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
            ApproximatelyEqual(LongEpochDate, storedNumericEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedNumericEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedEmployee.NullableLongEpochDate2.Value);

            storedNumericEmployee = Context.Load<NumericEpochEmployee>(numericEmployee);
            Assert.IsNotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
            ApproximatelyEqual(LongEpochDate, storedNumericEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(3), storedNumericEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), storedNumericEmployee.NullableLongEpochDate2.Value);

            var doc = Context.ToDocument(employee);
            ApproximatelyEqual(EpochDate, doc["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, doc["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, doc["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), doc["LongEpochDate2"].AsDateTime());
            Assert.IsNull(doc["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), doc["NullableLongEpochDate2"].AsDateTime());

            var docV1 = doc.ForceConversion(DynamoDBEntryConversion.V1);
            ApproximatelyEqual(EpochDate, docV1["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV1["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, docV1["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), docV1["LongEpochDate2"].AsDateTime());
            Assert.IsNull(docV1["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), docV1["NullableLongEpochDate2"].AsDateTime());

            var docV2 = doc.ForceConversion(DynamoDBEntryConversion.V2);
            ApproximatelyEqual(EpochDate, docV2["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(EpochDate, docV2["NonEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, docV2["LongEpochDate1"].AsDateTime());
            ApproximatelyEqual(LongEpochDate.AddMonths(3), docV2["LongEpochDate2"].AsDateTime());
            Assert.IsNull(docV2["NullableLongEpochDate1"].AsPrimitive().Value);
            ApproximatelyEqual(LongEpochDate.AddMonths(-3), docV2["NullableLongEpochDate2"].AsDateTime());

            var epochTable = Context.GetTargetTable<EpochEmployee>();
            var epochAttributes = epochTable.GetStoreAsEpoch().ToList();
            var epochLongAttributes = epochTable.GetStoreAsEpochLong().ToList();
            Assert.AreNotEqual(0, epochAttributes.Count);
            Assert.AreNotEqual(0, epochLongAttributes.Count);

            var epochMap = epochTable.ToAttributeMap(doc);
            Assert.IsNotNull(epochMap["CreationTime"].N);
            Assert.IsNotNull(epochMap["EpochDate2"].N);
            Assert.IsNotNull(epochMap["NonEpochDate1"].S);
            Assert.IsNotNull(epochMap["NonEpochDate2"].S);
            Assert.IsNotNull(epochMap["LongEpochDate1"].N);
            Assert.IsNotNull(epochMap["LongEpochDate2"].N);
            Assert.IsFalse(epochMap.ContainsKey("NullableLongEpochDate1"));
            Assert.IsNotNull(epochMap["NullableLongEpochDate2"].N);

            var exceptionThrown = Assert.ThrowsException<InvalidOperationException>(() =>
            {
                var badNumericEmployee = new BadNumericEpochEmployee
                {
                    Name = "Bob",
                    Age = 45,
                    CreationTime = EpochDate,
                    EpochDate2 = EpochDate,
                    NonEpochDate1 = EpochDate,
                    NonEpochDate2 = EpochDate,
                    LongEpochDate1 = LongEpochDate,
                    LongEpochDate2 = LongEpochDate.AddMonths(3),
                    BadLongEpochDate = LongEpochDate
                };

                Context.Save(badNumericEmployee);
            });
            Assert.AreEqual("BadLongEpochDate must not set both StoreAsEpoch and StoreAsEpochLong as true at the same time.", exceptionThrown.Message);
        }

        public void TestStoreAsEpoch(Table hashRangeTable, Table numericHashRangeTable)
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
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2" },
                AttributesToStoreAsEpochLong = new List<string> { "LongEpochDate", "NullableLongEpochDate1", "NullableLongEpochDate2" }
            };
            var epochTable = Table.LoadTable(Client, config);
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpoch, epochTable.GetStoreAsEpoch().ToList());
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpochLong, epochTable.GetStoreAsEpochLong().ToList());

            config = new TableConfig(numericHashRangeTable.TableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2" },
                AttributesToStoreAsEpochLong = new List<string> { "LongEpochDate", "NullableLongEpochDate1", "NullableLongEpochDate2" }
            };
            var numericEpochTable = Table.LoadTable(Client, config);
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpoch, numericEpochTable.GetStoreAsEpoch().ToList());
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpochLong, numericEpochTable.GetStoreAsEpochLong().ToList());

            // verify ToAttributeMap calls
            var map = hashRangeTable.ToAttributeMap(CreateTestDocument());
            Assert.IsNotNull(map["CreationTime"].S);
            Assert.IsNotNull(map["EpochDate2"].S);
            Assert.IsNotNull(map["NonEpochDate"].S);
            Assert.IsNotNull(map["LongEpochDate"].S);
            Assert.IsNotNull(map["NullableLongEpochDate1"].S);
            Assert.IsFalse(map.ContainsKey("NullableLongEpochDate2"));

            var epochMap = epochTable.ToAttributeMap(CreateTestDocument());
            Assert.IsNotNull(epochMap["CreationTime"].N);
            Assert.IsNotNull(epochMap["EpochDate2"].N);
            Assert.IsNotNull(epochMap["NonEpochDate"].S);
            Assert.IsNotNull(epochMap["LongEpochDate"].N);

            // put
            epochTable.PutItem(CreateTestDocument());
            TestWrittenData("Bob", 42, hashRangeTable, epochTable);
            numericEpochTable.PutItem(CreateTestDocument());
            // accessing this item with non-epoch table will throw an exception
            TestWrittenData(EpochDate, "Bob", null, numericEpochTable);
            var exception = AssertExtensions.ExpectException<InvalidOperationException>(() => numericHashRangeTable.GetItem(EpochDate, "Bob"));
            Assert.IsTrue(exception.Message.Contains("hash key CreationTime, is inconsistent with specified hash key value."));

            // conditional put
            epochTable.PutItem(CreateTestDocument());
            var newDoc = CreateTestDocument();
            newDoc["ConditionalUpdate"] = "yes";
            var expectedState = new ExpectedState();
            expectedState.AddExpected("CreationTime", ScanOperator.Equal, EpochDate);
            epochTable.PutItem(newDoc, new PutItemOperationConfig { ExpectedState = expectedState });
            TestWrittenData("Bob", 42, hashRangeTable, epochTable, checkForConditionalUpdate: true);

            // update
            epochTable.UpdateItem(CreateTestDocument());
            TestWrittenData("Bob", 42, hashRangeTable, epochTable);

            // conditional update
            epochTable.UpdateItem(CreateTestDocument());
            newDoc = CreateTestDocument();
            newDoc["ConditionalUpdate"] = "yes";
            expectedState = new ExpectedState();
            expectedState.AddExpected("CreationTime", ScanOperator.Equal, EpochDate);
            epochTable.UpdateItem(newDoc, new UpdateItemOperationConfig { ExpectedState = expectedState });
            TestWrittenData("Bob", 42, hashRangeTable, epochTable, checkForConditionalUpdate: true);

            // second item for batch operations
            var doc2 = new Document();
            doc2["Name"] = "Bob";
            doc2["Age"] = 43;
            doc2["CreationTime"] = EpochDate;
            doc2["EpochDate2"] = EpochDate;
            doc2["NonEpochDate"] = EpochDate;
            doc2["LongEpochDate"] = LongEpochDate;
            doc2["NullableLongEpochDate1"] = (DateTime?) LongEpochDate;
            doc2["NullableLongEpochDate2"] = (DateTime?) null;

            // batchWrite epoch seconds
            var batchWrite = epochTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(CreateTestDocument());
            batchWrite.AddDocumentToPut(doc2);
            batchWrite.Execute();
            TestWrittenData("Bob", 42, hashRangeTable, epochTable);
            TestWrittenData("Bob", 43, hashRangeTable, epochTable);
            // execute again, since TestWrittenData deletes the items
            batchWrite.Execute();

            // batchGet epoch seconds as DateTime
            var epochBatchGet = epochTable.CreateBatchGet();
            epochBatchGet.ConsistentRead = true;
            epochBatchGet.AddKey("Bob", 42);
            epochBatchGet.AddKey("Bob", 43);
            epochBatchGet.Execute();
            TestForDateTime(epochBatchGet.Results);

            // batchGet epoch seconds as int
            var batchGet = hashRangeTable.CreateBatchGet();
            batchGet.ConsistentRead = true;
            batchGet.AddKey("Bob", 42);
            batchGet.AddKey("Bob", 43);
            batchGet.Execute();
            TestForInts(batchGet.Results);

            // batchWrite ISO-8601
            batchWrite = hashRangeTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(CreateTestDocument());
            batchWrite.AddDocumentToPut(doc2);
            batchWrite.Execute();

            // batchGet ISO-8601 as DateTime
            epochBatchGet = epochTable.CreateBatchGet();
            epochBatchGet.ConsistentRead = true;
            epochBatchGet.AddKey("Bob", 42);
            epochBatchGet.AddKey("Bob", 43);
            epochBatchGet.Execute();
            TestForDateTime(epochBatchGet.Results);

            // batchGet ISO-8601 as DateTime with non-epoch table
            batchGet = hashRangeTable.CreateBatchGet();
            batchGet.ConsistentRead = true;
            batchGet.AddKey("Bob", 42);
            batchGet.AddKey("Bob", 43);
            batchGet.Execute();
            TestForDateTime(batchGet.Results);

            // write epoch seconds data data for Scan and Query
            batchWrite = epochTable.CreateBatchWrite();
            batchWrite.AddDocumentToPut(CreateTestDocument());
            batchWrite.AddDocumentToPut(doc2);
            batchWrite.Execute();

            // query
            var toTest = hashRangeTable.Query("Bob", new QueryFilter()).GetRemaining();
            TestForInts(toTest);
            toTest = epochTable.Query("Bob", new QueryFilter()).GetRemaining();
            TestForDateTime(toTest);

            //// query, filter is epoch seconds attribute
            //var queryFilter = new QueryFilter("CreationTime", QueryOperator.Equal, EpochDate);
            //toTest = numericHashRangeTable.Query(queryFilter).GetRemaining();
            //TestForDateTime(toTest);

            // scan, condition is epoch seconds attribute
            var scanFilter = new ScanFilter();
            scanFilter.AddCondition("CreationTime", ScanOperator.Equal, EpochDate);
            toTest = hashRangeTable.Scan(scanFilter).GetRemaining();
            Assert.AreEqual(0, toTest.Count);
            toTest = epochTable.Scan(scanFilter).GetRemaining();
            TestForDateTime(toTest);

            // scan, condition is Name
            scanFilter = new ScanFilter();
            scanFilter.AddCondition("Name", ScanOperator.Equal, "Bob");
            toTest = hashRangeTable.Scan(scanFilter).GetRemaining();
            TestForInts(toTest);
            toTest = epochTable.Scan(scanFilter).GetRemaining();
            TestForDateTime(toTest);
        }

        private static Document CreateTestDocument()
        {
            var doc = new Document();
            doc["Name"] = "Bob";
            doc["Age"] = 42;
            doc["CreationTime"] = EpochDate;
            doc["EpochDate2"] = EpochDate;
            doc["NonEpochDate"] = EpochDate;
            doc["LongEpochDate"] = LongEpochDate;
            doc["NullableLongEpochDate1"] = (DateTime?) LongEpochDate;
            doc["NullableLongEpochDate2"] = (DateTime?) null;
            return doc;
        }
        private static void TestWrittenData(Primitive hash, Primitive range, Table hashRangeTable, Table epochTable, bool checkForConditionalUpdate = false)
        {
            if (hashRangeTable != null)
            {
                var nonEpochDoc = hashRangeTable.GetItem(hash, range, new GetItemOperationConfig { ConsistentRead = true });
                Assert.AreEqual(EpochSeconds, nonEpochDoc["CreationTime"].AsInt());
                Assert.AreEqual(EpochSeconds, nonEpochDoc["EpochDate2"].AsInt());
                ApproximatelyEqual(EpochDate, nonEpochDoc["NonEpochDate"].AsDateTime());
                Assert.AreEqual(LongEpochSeconds, nonEpochDoc["LongEpochDate"].AsLong());
                Assert.AreEqual(LongEpochSeconds, nonEpochDoc["NullableLongEpochDate1"].AsLong());
                Assert.IsFalse(nonEpochDoc.ContainsKey("NullableLongEpochDate2"));
                if (checkForConditionalUpdate)
                    Assert.AreEqual("yes", nonEpochDoc["ConditionalUpdate"].AsString());
            }

            var epochDoc = epochTable.GetItem(hash, range, new GetItemOperationConfig { ConsistentRead = true });
            ApproximatelyEqual(EpochDate, epochDoc["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, epochDoc["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, epochDoc["NonEpochDate"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, epochDoc["LongEpochDate"].AsDateTime());
            ApproximatelyEqual(LongEpochDate, epochDoc["NullableLongEpochDate1"].AsDateTime());
            if (checkForConditionalUpdate)
                Assert.AreEqual("yes", epochDoc["ConditionalUpdate"].AsString());

            epochTable.DeleteItem(hash, range);
        }
        private static void TestForInts(List<Document> nonEpochDocs)
        {
            Assert.AreNotEqual(0, nonEpochDocs.Count);
            foreach (var ed in nonEpochDocs)
            {
                Assert.AreEqual(EpochSeconds, ed["CreationTime"].AsInt());
                Assert.AreEqual(EpochSeconds, ed["EpochDate2"].AsInt());
                ApproximatelyEqual(EpochDate, ed["NonEpochDate"].AsDateTime());
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
                ApproximatelyEqual(LongEpochDate, ed["LongEpochDate"].AsDateTime());
                ApproximatelyEqual(LongEpochDate, ed["NullableLongEpochDate1"].AsDateTime());
            }
        }

        // internal static DynamoDBEntry EpochSecondsToDateTime(DynamoDBEntry entry, string attributeName)
        public static DynamoDBEntry EpochSecondsToDateTime(DynamoDBEntry entry, string attributeName)
        {
            var method = typeof(Document)
                .GetMethod("EpochSecondsToDateTime", BindingFlags.Static | BindingFlags.NonPublic);
            var result = method.Invoke(null, new object[] { entry, attributeName }) as DynamoDBEntry;
            return result;
        }
        // internal static DynamoDBEntry DateTimeToEpochSeconds(DynamoDBEntry entry, string attributeName)
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
