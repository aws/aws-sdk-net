using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : IClassFixture<DynamoDBTestsFixture>
    {
        const string _sampleJson = @"{
""Name"" : ""Alan"" ,
""Age"" : 31,
""CompanyName"" : ""Big River"" ,
""CurrentStatus"" : ""Active"",
""CompanyInfo"" : {
    ""Name"" : ""Big River"",
    ""Year Founded"" : 1998
} ,
""Aliases"" :
    [ ""Al"" , ""Steve"" , ""Alan-san"" ],
""IsActive"" : true,
""RetirementInfo"" : null
}";

        [Fact]
        [Trait(CategoryAttribute, "DynamoDB")]
        public async Task TestDocumentPutGet()
        {
            // Clear tables
            await SharedTestFixture.CleanupTables();

            ITable hashTable;
            ITable hashRangeTable;

            // Load tables using provided conversion schema
            LoadTables(DynamoDBEntryConversion.V2, out hashTable, out hashRangeTable);

            // JSON as top-level data
            var doc = Document.FromJson(_sampleJson);
            await hashRangeTable.PutItemAsync(doc);
            var retrievedDoc = await hashRangeTable.GetItemAsync("Alan", 31);
            Assert.True(doc.Equals(retrievedDoc));

            // JSON as nested data
            var nestedDoc = Document.FromJson(_sampleJson);
            doc = new Document();
            doc["Name"] = "Jim";
            doc["Age"] = 29;
            doc["Colleague"] = nestedDoc;
            await hashRangeTable.PutItemAsync(doc);
            retrievedDoc = await hashRangeTable.GetItemAsync("Jim", 29);
            Assert.True(doc.ForceConversion(DynamoDBEntryConversion.V2).Equals(retrievedDoc));
        }

        [Fact]
        [Trait(CategoryAttribute, "DynamoDB")]
        public static void TestDocumentJsonConversions()
        {
            // Create Document from JSON
            var doc = Document.FromJson(_sampleJson);

            // Verify types
            Assert.True(doc["Name"] is Primitive);
            Assert.True(doc["CompanyInfo"] is Document);
            Assert.True(doc["Aliases"] is DynamoDBList);
            Assert.True(doc["IsActive"] is DynamoDBBool);
            Assert.True(doc["RetirementInfo"] is DynamoDBNull);

            // Verify conversions produce identical JSON
            var json = doc.ToJson();
            CompareJson(_sampleJson, json);
            var prettyJson = doc.ToJsonPretty();
            CompareJson(_sampleJson, prettyJson);
            CompareJson(json, prettyJson);
        }

        [Fact]
        [Trait(CategoryAttribute, "DynamoDB")]
        public static void TestDocumentBinaryDecoding()
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
            Assert.NotNull(p);
            Assert.Equal(DynamoDBEntryType.String, p.Type);

            p = rt["BinaryString"] as Primitive;
            Assert.NotNull(p);
            Assert.Equal(DynamoDBEntryType.String, p.Type);

            var s = rt["BinarySet"] as DynamoDBList;
            Assert.NotNull(s);
            Assert.Equal(2, s.Entries.Count);
            for (int i = 0; i < s.Entries.Count; i++)
            {
                var entry = s.Entries[i];
                Assert.True(entry is Primitive);
                Assert.Equal(DynamoDBEntryType.String, (entry as Primitive).Type);
                Assert.Equal(base64SetContents[i], entry.AsString());
            }

            var l = rt["BinaryList"] as DynamoDBList;
            Assert.NotNull(l);
            Assert.Equal(2, l.Entries.Count);
            for (int i = 0; i < l.Entries.Count; i++)
            {
                var entry = l.Entries[i];
                Assert.True(entry is Primitive);
                Assert.Equal(DynamoDBEntryType.String, (entry as Primitive).Type);
                Assert.Equal(base64SetContents[i], entry.AsString());
            }

            // Add a base64 set (SS, with base64 items)
            rt["BinarySet2"] = base64Set;

            // Decode all base64-encoded attributes
            rt.DecodeBase64Attributes("Binary", "BinarySet", "BinaryList", "BinarySet2", "BinaryString", "FakeAttribute");

            // Test to make sure attributes are binary
            var dp = rt["Binary"] as Primitive;
            Assert.NotNull(dp);
            Assert.Equal(DynamoDBEntryType.Binary, dp.Type);
            Assert.Equal(binaryData, dp.AsByteArray());

            dp = rt["BinaryString"] as Primitive;
            Assert.NotNull(dp);
            Assert.Equal(DynamoDBEntryType.Binary, dp.Type);
            Assert.Equal(binaryData, dp.AsByteArray());

            var dl = rt["BinaryList"] as DynamoDBList;
            Assert.NotNull(dl);
            Assert.Equal(2, dl.Entries.Count);
            for (int i = 0; i < dl.Entries.Count; i++)
            {
                var entry = dl.Entries[i];
                Assert.True(entry is Primitive);
                Assert.Equal(DynamoDBEntryType.Binary, (entry as Primitive).Type);
                Assert.Equal(entry.AsByteArray(), binarySetContents[i]);
            }

            dl = rt["BinarySet"] as DynamoDBList;
            Assert.NotNull(dl);
            Assert.Equal(2, dl.Entries.Count);
            for (int i = 0; i < dl.Entries.Count; i++)
            {
                var entry = dl.Entries[i];
                Assert.True(entry is Primitive);
                Assert.Equal(DynamoDBEntryType.Binary, (entry as Primitive).Type);
                Assert.Equal(entry.AsByteArray(), binarySetContents[i]);
            }

            var ds = rt["BinarySet2"] as PrimitiveList;
            Assert.NotNull(ds);
            Assert.Equal(2, ds.Entries.Count);
            Assert.Equal(DynamoDBEntryType.Binary, ds.Type);
            for (int i = 0; i < ds.Entries.Count; i++)
            {
                var entry = ds.Entries[i];
                Assert.True(entry is Primitive);
                Assert.Equal(DynamoDBEntryType.Binary, (entry as Primitive).Type);
                Assert.Equal(entry.AsByteArray(), binarySetContents[i]);
            }

            rt["FakeBinaryData"] = "this is fake";
            AssertExtensions.ExpectException(() => rt.DecodeBase64Attributes("FakeBinaryData"));
        }

        /// <summary>
        /// Compares two JSON strings by converting text->JSON->text and comparing the final forms
        /// </summary>
        private static void CompareJson(string jsonA, string jsonB)
        {
            var a = JsonDocument.Parse(jsonA);
            var b = JsonDocument.Parse(jsonB);

            var streamA = new MemoryStream();
            var writerA = new Utf8JsonWriter(streamA);
            a.WriteTo(writerA);

            var streamB = new MemoryStream();
            var writerB = new Utf8JsonWriter(streamA);
            b.WriteTo(writerB);

            var aRt = Encoding.UTF8.GetString(streamA.ToArray());
            var bRt = Encoding.UTF8.GetString(streamB.ToArray());

            Assert.Equal(aRt, bRt);
        }
    }
}
