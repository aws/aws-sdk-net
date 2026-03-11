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
        #region Serialize Primitives

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeNull()
        {
            var json = JsonSerializer.Serialize(new Document());
            Assert.AreEqual("null", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeBool()
        {
            Assert.AreEqual("true", JsonSerializer.Serialize(new Document(true)));
            Assert.AreEqual("false", JsonSerializer.Serialize(new Document(false)));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeInt()
        {
            Assert.AreEqual("42", JsonSerializer.Serialize(new Document(42)));
            Assert.AreEqual("0", JsonSerializer.Serialize(new Document(0)));
            Assert.AreEqual("-1", JsonSerializer.Serialize(new Document(-1)));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeLong()
        {
            var json = JsonSerializer.Serialize(new Document(long.MaxValue));
            Assert.AreEqual(long.MaxValue.ToString(), json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeDouble()
        {
            Assert.AreEqual("12.34", JsonSerializer.Serialize(new Document(12.34)));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeString()
        {
            Assert.AreEqual("\"hello\"", JsonSerializer.Serialize(new Document("hello")));
            Assert.AreEqual("\"\"", JsonSerializer.Serialize(new Document("")));
        }

        #endregion

        #region Serialize Collections

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeList()
        {
            var doc = new Document(1, 2, 3);
            Assert.AreEqual("[1,2,3]", JsonSerializer.Serialize(doc));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeDictionary()
        {
            var doc = new Document(new Dictionary<string, Document>
            {
                { "key", new Document("value") }
            });
            Assert.AreEqual("{\"key\":\"value\"}", JsonSerializer.Serialize(doc));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeNestedComplex()
        {
            var doc = new Document(new Dictionary<string, Document>
            {
                { "name", new Document("test") },
                { "count", new Document(42) },
                { "active", new Document(true) },
                { "tags", new Document(new Document("a"), new Document("b")) },
                { "nested", new Document(new Dictionary<string, Document>
                    {
                        { "inner", new Document(99) }
                    })
                }
            });

            var json = JsonSerializer.Serialize(doc);
            Assert.AreEqual(
                "{\"name\":\"test\",\"count\":42,\"active\":true,\"tags\":[\"a\",\"b\"],\"nested\":{\"inner\":99}}",
                json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeEmptyList()
        {
            var doc = new Document(new List<Document>());
            Assert.AreEqual("[]", JsonSerializer.Serialize(doc));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeEmptyDictionary()
        {
            var doc = new Document(new Dictionary<string, Document>());
            Assert.AreEqual("{}", JsonSerializer.Serialize(doc));
        }

        #endregion

        #region Deserialize Primitives

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeNull()
        {
            var doc = JsonSerializer.Deserialize<Document>("null");
            Assert.IsTrue(doc.IsNull());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeBool()
        {
            var doc = JsonSerializer.Deserialize<Document>("true");
            Assert.IsTrue(doc.IsBool());
            Assert.AreEqual(true, doc.AsBool());

            doc = JsonSerializer.Deserialize<Document>("false");
            Assert.IsTrue(doc.IsBool());
            Assert.AreEqual(false, doc.AsBool());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeInt()
        {
            var doc = JsonSerializer.Deserialize<Document>("42");
            Assert.IsTrue(doc.IsInt());
            Assert.AreEqual(42, doc.AsInt());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeLong()
        {
            var doc = JsonSerializer.Deserialize<Document>(long.MaxValue.ToString());
            Assert.IsTrue(doc.IsLong());
            Assert.AreEqual(long.MaxValue, doc.AsLong());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeDouble()
        {
            var doc = JsonSerializer.Deserialize<Document>("12.34");
            Assert.IsTrue(doc.IsDouble());
            Assert.AreEqual(12.34, doc.AsDouble());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeString()
        {
            var doc = JsonSerializer.Deserialize<Document>("\"hello\"");
            Assert.IsTrue(doc.IsString());
            Assert.AreEqual("hello", doc.AsString());
        }

        #endregion

        #region Deserialize Collections

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeList()
        {
            var doc = JsonSerializer.Deserialize<Document>("[1,2,3]");
            Assert.IsTrue(doc.IsList());
            Assert.AreEqual(3, doc.AsList().Count);
            Assert.AreEqual(1, doc.AsList()[0].AsInt());
            Assert.AreEqual(2, doc.AsList()[1].AsInt());
            Assert.AreEqual(3, doc.AsList()[2].AsInt());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeDictionary()
        {
            var doc = JsonSerializer.Deserialize<Document>("{\"key\":\"value\",\"num\":42}");
            Assert.IsTrue(doc.IsDictionary());
            Assert.AreEqual("value", doc.AsDictionary()["key"].AsString());
            Assert.AreEqual(42, doc.AsDictionary()["num"].AsInt());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeEmptyList()
        {
            var doc = JsonSerializer.Deserialize<Document>("[]");
            Assert.IsTrue(doc.IsList());
            Assert.AreEqual(0, doc.AsList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeEmptyDictionary()
        {
            var doc = JsonSerializer.Deserialize<Document>("{}");
            Assert.IsTrue(doc.IsDictionary());
            Assert.AreEqual(0, doc.AsDictionary().Count);
        }

        #endregion

        #region Regression Tests (Issue #3694)

        /// <summary>
        /// This is the core regression test for GitHub issue #3694.
        /// Before the fix, JsonSerializer.Serialize on an object containing a Document property
        /// would throw InvalidDocumentTypeConversionException because STJ treated Document
        /// as a collection via its IEnumerable interfaces.
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
        public void SerializeObjectContainingNullDocument()
        {
            var wrapper = new DocumentWrapper
            {
                Name = "test",
                Metadata = new Document()
            };

            var json = JsonSerializer.Serialize(wrapper);
            Assert.AreEqual("{\"Name\":\"test\",\"Metadata\":null}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeObjectContainingDictionaryDocument()
        {
            var wrapper = new DocumentWrapper
            {
                Name = "test",
                Metadata = new Document(new Dictionary<string, Document>
                {
                    { "key1", new Document("value1") },
                    { "key2", new Document(42) }
                })
            };

            var json = JsonSerializer.Serialize(wrapper);
            Assert.AreEqual("{\"Name\":\"test\",\"Metadata\":{\"key1\":\"value1\",\"key2\":42}}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SerializeObjectContainingListDocument()
        {
            var wrapper = new DocumentWrapper
            {
                Name = "test",
                Metadata = new Document(1, 2, 3)
            };

            var json = JsonSerializer.Serialize(wrapper);
            Assert.AreEqual("{\"Name\":\"test\",\"Metadata\":[1,2,3]}", json);
        }

        /// <summary>
        /// Tests serialization of Dictionary&lt;string, Document&gt; — the metadata scenario
        /// from issue comments where customers store Bedrock metadata.
        /// </summary>
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

        #endregion

        #region Round-Trip

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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RoundTripPrimitives()
        {
            // Each primitive type round-trips correctly
            AssertRoundTrip(new Document(), doc => doc.IsNull());
            AssertRoundTrip(new Document(true), doc => doc.IsBool() && doc.AsBool() == true);
            AssertRoundTrip(new Document(42), doc => doc.IsInt() && doc.AsInt() == 42);
            AssertRoundTrip(new Document(long.MaxValue), doc => doc.IsLong() && doc.AsLong() == long.MaxValue);
            AssertRoundTrip(new Document(3.14), doc => doc.IsDouble() && doc.AsDouble() == 3.14);
            AssertRoundTrip(new Document("hello"), doc => doc.IsString() && doc.AsString() == "hello");
        }

        #endregion

        #region FromObject Compatibility

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FromObjectWithDocumentInput()
        {
            var original = new Document(42);
            var result = Document.FromObject(original);

            // FromObject serializes the Document via the converter, then parses the resulting JSON.
            // An int Document serializes as "42", which FromObject(JsonElement) parses back.
            // Note: FromObject uses TryGetInt64 first, so the result is a Long, not Int.
            Assert.IsTrue(result.IsLong());
            Assert.AreEqual(42L, result.AsLong());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FromObjectWithComplexDocument()
        {
            var original = new Document(new Dictionary<string, Document>
            {
                { "key", new Document("value") }
            });

            var result = Document.FromObject(original);
            Assert.IsTrue(result.IsDictionary());
            Assert.AreEqual("value", result.AsDictionary()["key"].AsString());
        }

        #endregion

        #region Post-Review Fixes

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeIntMaxBoundary()
        {
            // int.MaxValue fits in an int
            var doc = JsonSerializer.Deserialize<Document>(int.MaxValue.ToString());
            Assert.IsTrue(doc.IsInt());
            Assert.AreEqual(int.MaxValue, doc.AsInt());

            // int.MaxValue + 1 overflows int, should deserialize as long
            long oneOverMax = (long)int.MaxValue + 1;
            doc = JsonSerializer.Deserialize<Document>(oneOverMax.ToString());
            Assert.IsTrue(doc.IsLong());
            Assert.AreEqual(oneOverMax, doc.AsLong());
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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FromObjectWithNullDocument()
        {
            var nullDoc = new Document();
            var result = Document.FromObject(nullDoc);
            Assert.IsTrue(result.IsNull());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FromObjectWithListDocument()
        {
            var listDoc = new Document(1, 2, 3);
            var result = Document.FromObject(listDoc);
            Assert.IsTrue(result.IsList());
            Assert.AreEqual(3, result.AsList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DeserializeDuplicateKeys()
        {
            // JSON with duplicate keys should use last-write-wins semantics
            var json = "{\"key\":\"first\",\"key\":\"second\"}";
            var doc = JsonSerializer.Deserialize<Document>(json);
            Assert.IsTrue(doc.IsDictionary());
            Assert.AreEqual("second", doc.AsDictionary()["key"].AsString());
        }

        #endregion

        #region Helpers

        private static void AssertRoundTrip(Document original, System.Func<Document, bool> validate)
        {
            var json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<Document>(json);
            Assert.IsTrue(validate(deserialized),
                $"Round-trip failed for Document type {original.Type}. JSON: {json}");
        }

        private class DocumentWrapper
        {
            public string Name { get; set; }
            public Document Metadata { get; set; }
        }

        #endregion
    }
}
