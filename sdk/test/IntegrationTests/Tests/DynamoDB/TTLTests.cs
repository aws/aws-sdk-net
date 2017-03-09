using System;
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
                NonEpochDate2 = EpochDate
            };
            EpochEmployee employee = numericEmployee;

            Context.Save(employee);
            var storedEmployee = Context.Load<EpochEmployee>(employee.Name, employee.Age);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            storedEmployee = Context.Load<EpochEmployee>(employee);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);


            Context.Save(numericEmployee);
            var storedNumericEmployee = Context.Load<NumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedNumericEmployee);
            ApproximatelyEqual(EpochDate, storedNumericEmployee.CreationTime);
            storedNumericEmployee = Context.Load<NumericEpochEmployee>(numericEmployee);
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

            var epochTable = Context.GetTargetTable<EpochEmployee>();
            var epochAttributes = epochTable.GetStoreAsEpoch().ToList();
            Assert.AreNotEqual(0, epochAttributes.Count);

            var epochMap = epochTable.ToAttributeMap(doc);
            Assert.IsNotNull(epochMap["CreationTime"].N);
            Assert.IsNotNull(epochMap["EpochDate2"].N);
            Assert.IsNotNull(epochMap["NonEpochDate1"].S);
            Assert.IsNotNull(epochMap["NonEpochDate2"].S);
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

            // construct tables with StoreAsEpoch
            var config = new TableConfig(hashRangeTable.TableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2" }
            };
            var epochTable = Table.LoadTable(Client, config);
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpoch, epochTable.GetStoreAsEpoch().ToList());

            config = new TableConfig(numericHashRangeTable.TableName)
            {
                AttributesToStoreAsEpoch = new List<string> { "CreationTime", "EpochDate2" }
            };
            var numericEpochTable = Table.LoadTable(Client, config);
            CollectionAssert.AreEqual(config.AttributesToStoreAsEpoch, epochTable.GetStoreAsEpoch().ToList());

            // verify ToAttributeMap calls
            var map = hashRangeTable.ToAttributeMap(CreateTestDocument());
            Assert.IsNotNull(map["CreationTime"].S);
            Assert.IsNotNull(map["EpochDate2"].S);
            Assert.IsNotNull(map["NonEpochDate"].S);

            var epochMap = epochTable.ToAttributeMap(CreateTestDocument());
            Assert.IsNotNull(epochMap["CreationTime"].N);
            Assert.IsNotNull(epochMap["EpochDate2"].N);
            Assert.IsNotNull(epochMap["NonEpochDate"].S);

            // put
            epochTable.PutItem(CreateTestDocument());
            TestWrittenData("Bob", 42, hashRangeTable, epochTable);
            numericEpochTable.PutItem(CreateTestDocument());
            // accessing this item with non-epoch table will throw an exception
            TestWrittenData(EpochDate, "Bob", null, numericEpochTable);
            var exception = AssertExtensions.ExpectException < InvalidOperationException>(() => numericHashRangeTable.GetItem(EpochDate, "Bob"));
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
                if (checkForConditionalUpdate)
                    Assert.AreEqual("yes", nonEpochDoc["ConditionalUpdate"].AsString());
            }

            var epochDoc = epochTable.GetItem(hash, range, new GetItemOperationConfig { ConsistentRead = true });
            ApproximatelyEqual(EpochDate, epochDoc["CreationTime"].AsDateTime());
            ApproximatelyEqual(EpochDate, epochDoc["EpochDate2"].AsDateTime());
            ApproximatelyEqual(EpochDate, epochDoc["NonEpochDate"].AsDateTime());
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

        private static void ApproximatelyEqual(DateTime expected, DateTime actual)
        {
            var diff = actual - expected;
            var absDiff = diff.GetAbsolute();
            Assert.IsTrue(absDiff < Epsilon, string.Format("Verifying that {0} ~= {1}", expected, actual));
        }
    }
}
