/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Collections.Generic;
using System.Text.Json;
using Amazon.Runtime.Documents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DocumentJsonConverterTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializePrimitives()
        {
            Assert.AreEqual("null", JsonSerializer.Serialize(new Document()));
            Assert.AreEqual("true", JsonSerializer.Serialize(new Document(true)));
            Assert.AreEqual("false", JsonSerializer.Serialize(new Document(false)));
            Assert.AreEqual("42", JsonSerializer.Serialize(new Document(42)));
            Assert.AreEqual(long.MaxValue.ToString(), JsonSerializer.Serialize(new Document(long.MaxValue)));
            Assert.AreEqual("12.34", JsonSerializer.Serialize(new Document(12.34)));
            Assert.AreEqual("\"hello\"", JsonSerializer.Serialize(new Document("hello")));
            Assert.AreEqual("\"\"", JsonSerializer.Serialize(new Document("")));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeCollections()
        {
            Assert.AreEqual("[1,2,3]", JsonSerializer.Serialize(new Document(1, 2, 3)));
            Assert.AreEqual("[]", JsonSerializer.Serialize(new Document(new List<Document>())));

            var dict = new Document(new Dictionary<string, Document>
            {
                { "key", new Document("value") }
            });
            Assert.AreEqual("{\"key\":\"value\"}", JsonSerializer.Serialize(dict));
            Assert.AreEqual("{}", JsonSerializer.Serialize(new Document(new Dictionary<string, Document>())));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializePrimitives()
        {
            Assert.IsTrue(JsonSerializer.Deserialize<Document>("null").IsNull());

            var boolDoc = JsonSerializer.Deserialize<Document>("true");
            Assert.IsTrue(boolDoc.IsBool());
            Assert.AreEqual(true, boolDoc.AsBool());

            var intDoc = JsonSerializer.Deserialize<Document>("42");
            Assert.IsTrue(intDoc.IsInt());
            Assert.AreEqual(42, intDoc.AsInt());

            // int.MaxValue fits in int; int.MaxValue + 1 promotes to long
            Assert.IsTrue(JsonSerializer.Deserialize<Document>(int.MaxValue.ToString()).IsInt());
            long oneOverMax = (long)int.MaxValue + 1;
            var longBoundary = JsonSerializer.Deserialize<Document>(oneOverMax.ToString());
            Assert.IsTrue(longBoundary.IsLong());
            Assert.AreEqual(oneOverMax, longBoundary.AsLong());

            var longDoc = JsonSerializer.Deserialize<Document>(long.MaxValue.ToString());
            Assert.IsTrue(longDoc.IsLong());
            Assert.AreEqual(long.MaxValue, longDoc.AsLong());

            var doubleDoc = JsonSerializer.Deserialize<Document>("12.34");
            Assert.IsTrue(doubleDoc.IsDouble());
            Assert.AreEqual(12.34, doubleDoc.AsDouble());

            var stringDoc = JsonSerializer.Deserialize<Document>("\"hello\"");
            Assert.IsTrue(stringDoc.IsString());
            Assert.AreEqual("hello", stringDoc.AsString());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeCollections()
        {
            var list = JsonSerializer.Deserialize<Document>("[1,2,3]");
            Assert.IsTrue(list.IsList());
            Assert.AreEqual(3, list.AsList().Count);
            Assert.AreEqual(1, list.AsList()[0].AsInt());

            var emptyList = JsonSerializer.Deserialize<Document>("[]");
            Assert.IsTrue(emptyList.IsList());
            Assert.AreEqual(0, emptyList.AsList().Count);

            var dict = JsonSerializer.Deserialize<Document>("{\"key\":\"value\",\"num\":42}");
            Assert.IsTrue(dict.IsDictionary());
            Assert.AreEqual("value", dict.AsDictionary()["key"].AsString());
            Assert.AreEqual(42, dict.AsDictionary()["num"].AsInt());

            var emptyDict = JsonSerializer.Deserialize<Document>("{}");
            Assert.IsTrue(emptyDict.IsDictionary());
            Assert.AreEqual(0, emptyDict.AsDictionary().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RoundTripComplex()
        {
            var original = new Document(new Dictionary<string, Document>
            {
                { "string", new Document("hello") },
                { "int", new Document(42) },
                { "long", new Document(long.MaxValue) },
                { "double", new Document(3.14) },
                { "bool", new Document(true) },
                { "null", new Document() },
                { "list", new Document(new Document(1), new Document("two"), new Document(false)) },
                { "nested", new Document(new Dictionary<string, Document>
                    {
                        { "inner", new Document(99) }
                    })
                }
            });

            var json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<Document>(json);

            Assert.IsTrue(deserialized.IsDictionary());
            var dict = deserialized.AsDictionary();

            Assert.AreEqual("hello", dict["string"].AsString());
            Assert.AreEqual(42, dict["int"].AsInt());
            Assert.AreEqual(long.MaxValue, dict["long"].AsLong());
            Assert.AreEqual(3.14, dict["double"].AsDouble());
            Assert.AreEqual(true, dict["bool"].AsBool());
            Assert.IsTrue(dict["null"].IsNull());

            var list = dict["list"].AsList();
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual(1, list[0].AsInt());
            Assert.AreEqual("two", list[1].AsString());
            Assert.AreEqual(false, list[2].AsBool());

            Assert.AreEqual(99, dict["nested"].AsDictionary()["inner"].AsInt());
        }

        /// <summary>
        /// Regression test for GitHub issue #3694.
        /// STJ treated Document as a collection via its IEnumerable interfaces,
        /// throwing InvalidDocumentTypeConversionException during serialization.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeObjectContainingDocument()
        {
            var wrapper = new DocumentWrapper
            {
                Name = "test",
                Metadata = new Document("hello")
            };

            var json = JsonSerializer.Serialize(wrapper);
            Assert.AreEqual("{\"Name\":\"test\",\"Metadata\":\"hello\"}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeDictionaryOfDocuments()
        {
            var metadata = new Dictionary<string, Document>
            {
                { "score", new Document(0.5) },
                { "source", new Document("bedrock") },
                { "active", new Document(true) }
            };

            var json = JsonSerializer.Serialize(metadata);
            Assert.AreEqual("{\"score\":0.5,\"source\":\"bedrock\",\"active\":true}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeListOfDocuments()
        {
            var list = new List<Document>
            {
                new Document(1),
                new Document("two"),
                new Document(true)
            };

            var json = JsonSerializer.Serialize(list);
            Assert.AreEqual("[1,\"two\",true]", json);
        }

        #region Customer Scenario Validation (Issues #3694, #3837, #4078)

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeFilterAttributeScenario()
        {
            // Issue #3694: FilterAttribute with Document string value
            var filter = new FilterAttributeLike
            {
                Key = "TeamId",
                Value = new Document("TestTeamId")
            };

            var json = JsonSerializer.Serialize(filter);
            Assert.AreEqual("{\"Key\":\"TeamId\",\"Value\":\"TestTeamId\"}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeDocumentFromObjectScenario()
        {
            // Issue #4078: FromObject on anonymous object then Serialize
            var document = Document.FromObject(new
            {
                type = "object",
                properties = new
                {
                    query = new { type = "string" }
                }
            });

            var json = JsonSerializer.Serialize(document);
            var roundTripped = JsonSerializer.Deserialize<Document>(json);
            Assert.IsTrue(roundTripped.IsDictionary());
            Assert.AreEqual("object", roundTripped.AsDictionary()["type"].AsString());
        }

        #endregion

        #region Helpers

        private class DocumentWrapper
        {
            public string Name { get; set; }
            public Document Metadata { get; set; }
        }

        private class FilterAttributeLike
        {
            public string Key { get; set; }
            public Document Value { get; set; }
        }

        #endregion
    }
}
