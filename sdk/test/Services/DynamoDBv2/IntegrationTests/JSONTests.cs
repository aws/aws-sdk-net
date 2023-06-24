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

        const string sampleJsonArray = @"[{
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
},
{
""Name"" : ""George P. Burdell"" ,
""Age"" : 87,
""CompanyName"" : ""Georgia Tech"" ,
""CurrentStatus"" : ""Active""
""CompanyInfo"" : {
    ""Name"" : ""Georgia Tech"" ,
    ""Year Founded"" : 1885,
} ,
""Aliases"" :
    [ ""Buzz"" , ""Ed"" , ""Rat"" ],
""IsActive"" : true,
""RetirementInfo"" : {
        ""Year"": 1987,
        ""Status"": ""Graduated""
    }
}]";

        
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestJSON()
        {
            TestJsonConversions();

            TestBinaryDecoding();

            TestPutGet();

            TestArrayMethods();

            TestFromJsonCanHandleAllDataTypes();
        }

        private void TestPutGet()
        {
            // Clear tables
            CleanupTables();

            Table hashTable;
            Table hashRangeTable;
            Table numericHashRangeTable;

            // Load tables using provided conversion schema
            LoadTables(DynamoDBEntryConversion.V2, out hashTable, out hashRangeTable, out numericHashRangeTable);

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

        private static void TestArrayMethods()
        {
            var docs = TestArrayRoundTrip(sampleJsonArray);
            TestArrayRoundTrip(docs.ToJsonPretty());
        }

        private static IEnumerable<Document> TestArrayRoundTrip(string jsonArray) {
            var docs = Document.FromJsonArray(jsonArray) as IEnumerable<Document>;
            
            Assert.IsNotNull(docs);
            Assert.AreEqual(2, docs.Count());
            var first = docs.First();
            // Verify types
            Assert.IsTrue(first["Name"] is Primitive);            
            Assert.IsTrue(first["Age"] is Primitive);            
            Assert.IsTrue(first["CompanyInfo"] is Document);
            Assert.IsTrue(first["Aliases"] is DynamoDBList);
            Assert.IsTrue(first["IsActive"] is DynamoDBBool);
            Assert.IsTrue(first["RetirementInfo"] is DynamoDBNull);
            // Value tests
            Assert.AreEqual("Alan", (string)first["Name"]);
            Assert.AreEqual(31, (int)first["Age"]);       
            Assert.IsNotNull(first["CompanyInfo"] as Document);
            Assert.AreEqual("Big River", (string)first["CompanyInfo"].AsDocument()["Name"]);
            Assert.IsTrue((bool)first["IsActive"]);
            Assert.IsNull(first["RetirementInfo"].AsDocument());

            var second = docs.Skip(1).First();
            Assert.IsTrue(second["Name"] is Primitive);     
            Assert.IsTrue(second["Age"] is Primitive);            
            Assert.IsTrue(second["CompanyInfo"] is Document);
            Assert.IsTrue(second["Aliases"] is DynamoDBList);
            Assert.IsTrue(second["IsActive"] is DynamoDBBool);
            Assert.IsNotNull(second["RetirementInfo"].AsDocument());
            Assert.IsTrue(second["RetirementInfo"].AsDocument()["Year"] is Primitive);
            Assert.IsTrue(second["RetirementInfo"].AsDocument()["Status"] is Primitive);
            // Value tests
            Assert.AreEqual("George P. Burdell", (string)second["Name"]);
            Assert.AreEqual(87, (int)second["Age"]);       
            Assert.IsNotNull(second["CompanyInfo"].AsDocument());
            Assert.AreEqual("Georgia Tech", (string)(second["CompanyInfo"] as Document)["Name"]);
            Assert.IsTrue((bool)second["IsActive"]);
            Assert.IsNotNull(second["RetirementInfo"].AsDocument());
            Assert.AreEqual(1987, (int)second["RetirementInfo"].AsDocument()["Year"]);       
            Assert.AreEqual("Graduated", (string)second["RetirementInfo"].AsDocument()["Status"]);     

            // Test round-tripping
            string json = docs.ToJson();
            CompareJson(jsonArray, json);  
            string prettyJson = docs.ToJsonPretty();
            CompareJson(jsonArray, prettyJson);

            return docs;
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

        private static void TestFromJsonCanHandleAllDataTypes()
        {
            var json = @"
                {
                  ""StringValue"": ""test string"",
                  ""BoolValue"": true,
                  ""IntValue"": 200,
                  ""DateValue"": ""2022-12-29T12:46:14.097Z"",
                  ""NullableBoolValue"": null,
                  ""NullableIntValue"": null,
                  ""NullableDateValue"": null,
                  ""SubData"": null,
                  ""SubData2"": {
                    ""StringValue"": null,
                    ""NullableBoolValue"": false,
                    ""NullableIntValue"": 500,
                    ""NullableDateValue"": ""2022-12-28T12:46:14.097Z""
                  }
                }";

            using (var dbClient = new AmazonDynamoDBClient())
            using (var context = new DynamoDBContext(dbClient))
            {
                var document = Document.FromJson(json);
                var container = context.FromDocument<DataContainer>(document);

                Assert.IsNotNull(container);
                Assert.AreEqual(container.StringValue, "test string");
                Assert.AreEqual(container.BoolValue, true);
                Assert.AreEqual(container.IntValue, 200);
                Assert.AreEqual(container.DateValue, DateTime.Parse("2022-12-29T12:46:14.097Z"));
                Assert.IsNull(container.NullableBoolValue);
                Assert.IsNull(container.NullableIntValue);
                Assert.IsNull(container.NullableDateValue);
                Assert.IsNull(container.SubData);
                Assert.IsNotNull(container.SubData2);
                Assert.IsNull(container.SubData2.StringValue);
                Assert.IsNotNull(container.SubData2.NullableIntValue);
            }
        }

        private class DataContainer
        {
            public string StringValue { get; set; }
            public bool BoolValue { get; set; }
            public int IntValue { get; set; }
            public DateTime DateValue { get; set; }

            public bool? NullableBoolValue { get; set; }
            public int? NullableIntValue { get; set; }
            public DateTime? NullableDateValue { get; set; }

            public SubContainer SubData { get; set; }
            public SubContainer SubData2 { get; set; }

            public class SubContainer
            {
                public string StringValue { get; set; }
                public bool? NullableBoolValue { get; set; }
                public int? NullableIntValue { get; set; }
                public DateTime? NullableDateValue { get; set; }
            }
        }
    }
}
