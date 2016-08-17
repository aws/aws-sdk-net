using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using ThirdParty.Json.LitJson;
using System.IO;


namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        const string sampleJson = @"{
""Name"" : ""Alan"" ,
""Age"" : 31,
""CompanyName"" : ""Big River"" ,
""CurrentStatus"" : ""Active""
""CompanyInfo"" : {
    ""Name"" : ""Big River"" ,
    ""Year Founded"" : 1998,
} ,
""Aliases"" :
    [ ""Al"" , ""Steve"" , ""Alan-san"" ],
""IsActive"" : true,
""RetirementInfo"" : null
}";
        
        [TestMethod]
        [TestCategory("DynamoDB")]
        public void TestJSON()
        {
            TestJsonConversions();

            TestBinaryDecoding();

            TestPutGet();
        }

        private void TestPutGet()
        {
            // Clear tables
            CleanupTables();

            Table hashTable;
            Table hashRangeTable;

            // Load tables using provided conversion schema
            LoadTables(DynamoDBEntryConversion.V2, out hashTable, out hashRangeTable);

            // JSON as top-level data
            var doc = Document.FromJson(sampleJson);
            hashRangeTable.PutItem(doc);
            var retrievedDoc = hashRangeTable.GetItem("Alan", 31);
            Assert.IsTrue(doc.Equals(retrievedDoc));

            // JSON as nested data
            var nestedDoc = Document.FromJson(sampleJson);
            doc = new Document();
            doc["Name"] = "Jim";
            doc["Age"] = 29;
            doc["Colleague"] = nestedDoc;
            hashRangeTable.PutItem(doc);
            retrievedDoc = hashRangeTable.GetItem("Jim", 29);
            Assert.IsTrue(doc.ForceConversion(DynamoDBEntryConversion.V2).Equals(retrievedDoc));
        }

        private static void TestJsonConversions()
        {
            // Create Document from JSON
            var doc = Document.FromJson(sampleJson);

            // Verify types
            Assert.IsTrue(doc["Name"] is Primitive);            
            Assert.IsTrue(doc["CompanyInfo"] is Document);
            Assert.IsTrue(doc["Aliases"] is DynamoDBList);
            Assert.IsTrue(doc["IsActive"] is DynamoDBBool);
            Assert.IsTrue(doc["RetirementInfo"] is DynamoDBNull);

            // Verify conversions produce identical JSON
            var json = doc.ToJson();
            CompareJson(sampleJson, json);
            var prettyJson = doc.ToJsonPretty();
            CompareJson(sampleJson, prettyJson);
            CompareJson(json, prettyJson);
        }

        private static void TestBinaryDecoding()
        {
            // Test data
            var data = "Hello world!";
            var binaryData = Encoding.UTF8.GetBytes(data);
            var base64Data = Convert.ToBase64String(binaryData);
            var ms = new MemoryStream(binaryData);
            var binaryDataPrimitive = new Primitive(ms);

            var data2 = "Big River";
            var binaryData2 = Encoding.UTF8.GetBytes(data2);
            var base64Data2 = Convert.ToBase64String(binaryData2);
            var ms2 = new MemoryStream(binaryData2);
            var binaryData2Primitive = new Primitive(binaryData2);

            var binarySet = new PrimitiveList(DynamoDBEntryType.Binary);
            binarySet.Add(binaryDataPrimitive);
            binarySet.Add(binaryData2Primitive);
            var binarySetContents = binarySet.AsListOfByteArray();

            var binaryList = new DynamoDBList();
            binaryList.Add(binaryDataPrimitive);
            binaryList.Add(binaryData2Primitive);
            var binaryListContents = binaryList.AsListOfByteArray();

            var base64Set = new PrimitiveList(DynamoDBEntryType.String);
            base64Set.Add(base64Data);
            base64Set.Add(base64Data2);
            var base64SetContents = new List<string> { base64Data, base64Data2 };

            // Populate document
            var doc = new Document();
            doc["Binary"] = binaryData;
            doc["BinarySet"] = binarySet;
            doc["BinaryList"] = binaryList;
            doc["BinaryString"] = base64Data;

            // Convert document to JSON
            var json = doc.ToJson();
            var prettyJson = doc.ToJsonPretty();
            CompareJson(json, prettyJson);

            // Back to a document
            var rt = Document.FromJson(json);
            
            // Test to make sure binary data is strings
            var p = rt["Binary"] as Primitive;
            Assert.IsNotNull(p);
            Assert.AreEqual(DynamoDBEntryType.String, p.Type);

            p = rt["BinaryString"] as Primitive;
            Assert.IsNotNull(p);
            Assert.AreEqual(DynamoDBEntryType.String, p.Type);

            var s = rt["BinarySet"] as DynamoDBList;
            Assert.IsNotNull(s);
            Assert.AreEqual(2, s.Entries.Count);
            for (int i = 0; i < s.Entries.Count; i++)
            {
                var entry = s.Entries[i];
                Assert.IsTrue(entry is Primitive);
                Assert.AreEqual(DynamoDBEntryType.String, (entry as Primitive).Type);
                Assert.AreEqual(base64SetContents[i], entry.AsString());
            }

            var l = rt["BinaryList"] as DynamoDBList;
            Assert.IsNotNull(l);
            Assert.AreEqual(2, l.Entries.Count);
            for (int i = 0; i < l.Entries.Count; i++)
            {
                var entry = l.Entries[i];
                Assert.IsTrue(entry is Primitive);
                Assert.AreEqual(DynamoDBEntryType.String, (entry as Primitive).Type);
                Assert.AreEqual(base64SetContents[i], entry.AsString());
            }

            // Add a base64 set (SS, with base64 items)
            rt["BinarySet2"] = base64Set;

            // Decode all base64-encoded attributes
            rt.DecodeBase64Attributes("Binary", "BinarySet", "BinaryList", "BinarySet2", "BinaryString", "FakeAttribute");

            // Test to make sure attributes are binary
            var dp = rt["Binary"] as Primitive;
            Assert.IsNotNull(dp);
            Assert.AreEqual(DynamoDBEntryType.Binary, dp.Type);
            CollectionAssert.AreEqual(binaryData, dp.AsByteArray());

            dp = rt["BinaryString"] as Primitive;
            Assert.IsNotNull(dp);
            Assert.AreEqual(DynamoDBEntryType.Binary, dp.Type);
            CollectionAssert.AreEqual(binaryData, dp.AsByteArray());

            var dl = rt["BinaryList"] as DynamoDBList;
            Assert.IsNotNull(dl);
            Assert.AreEqual(2, dl.Entries.Count);
            for (int i = 0; i < dl.Entries.Count; i++)
            {
                var entry = dl.Entries[i];
                Assert.IsTrue(entry is Primitive);
                Assert.AreEqual(DynamoDBEntryType.Binary, (entry as Primitive).Type);
                CollectionAssert.AreEqual(entry.AsByteArray(), binarySetContents[i]);
            }

            dl = rt["BinarySet"] as DynamoDBList;
            Assert.IsNotNull(dl);
            Assert.AreEqual(2, dl.Entries.Count);
            for (int i = 0; i < dl.Entries.Count; i++)
            {
                var entry = dl.Entries[i];
                Assert.IsTrue(entry is Primitive);
                Assert.AreEqual(DynamoDBEntryType.Binary, (entry as Primitive).Type);
                CollectionAssert.AreEqual(entry.AsByteArray(), binarySetContents[i]);
            }

            var ds = rt["BinarySet2"] as PrimitiveList;
            Assert.IsNotNull(ds);
            Assert.AreEqual(2, ds.Entries.Count);
            Assert.AreEqual(DynamoDBEntryType.Binary, ds.Type);
            for (int i = 0; i < ds.Entries.Count; i++)
            {
                var entry = ds.Entries[i];
                Assert.IsTrue(entry is Primitive);
                Assert.AreEqual(DynamoDBEntryType.Binary, (entry as Primitive).Type);
                CollectionAssert.AreEqual(entry.AsByteArray(), binarySetContents[i]);
            }

            rt["FakeBinaryData"] = "this is fake";
            AssertExtensions.ExpectException(() => rt.DecodeBase64Attributes("FakeBinaryData"));
        }

        // Compares two JSON strings by converting text->JSON->text and comparing the final forms
        private static void CompareJson(string jsonA, string jsonB)
        {
            var a = JsonMapper.ToObject(jsonA);
            var b = JsonMapper.ToObject(jsonB);

            var aRt = a.ToJson();
            var bRt = b.ToJson();

            Assert.AreEqual(aRt, bRt);
        }
    }
}
