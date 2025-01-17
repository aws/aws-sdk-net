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
using System.IO;
using System.Text;
using Amazon.Runtime.Documents;
using Amazon.Runtime.Documents.Internal.Transform;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Amazon.Runtime.Internal.Util;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DocumentMarshallingTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void BasicMarshalTest()
        {
            var json = Marshall(new Document());
            Assert.AreEqual("{\"document\":null}", json);
            
            json = Marshall(new Document(true));
            Assert.AreEqual("{\"document\":true}", json);
            
            json = Marshall(new Document(42));
            Assert.AreEqual("{\"document\":42}", json);
            
            json = Marshall(new Document(12.34));
            Assert.AreEqual("{\"document\":12.34}", json);
            
            json = Marshall(new Document(long.MaxValue));
            Assert.AreEqual($"{{\"document\":{long.MaxValue}}}", json);
            
            json = Marshall(new Document("Hello World"));
            Assert.AreEqual("{\"document\":\"Hello World\"}", json);
            
            json = Marshall(new Document(1,2,3,4));
            Assert.AreEqual("{\"document\":[1,2,3,4]}", json);

            var complexDocument = Document.FromObject(new
            {
                Number = 12,
                Child = new
                {
                    Hello = "World"
                }
            });
            json = Marshall(complexDocument);
            Assert.AreEqual("{\"document\":{\"Number\":12,\"Child\":{\"Hello\":\"World\"}}}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void MarshallDiverseListDocument()
        {
            var doc = new Document
            {
                new Document(),
                true,
                double.MaxValue,
                int.MaxValue,
                long.MaxValue,
                "string",
                new Document(1,2,3),
                Document.FromObject(new {Hello = "World"})
            };
            
            var json = Marshall(doc);
            Assert.AreEqual("{\"document\":[null,true,1.7976931348623157E+308,2147483647,9223372036854775807,\"string\",[1,2,3],{\"Hello\":\"World\"}]}", json);
        }
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void MarshallDiverseDictionaryDocument()
        {
            var doc = new Document
            {
                {"0", new Document()},
                {"1", true},
                {"2", double.MaxValue},
                {"3", int.MaxValue},
                {"4", long.MaxValue},
                {"5", "string"},
                {"6", new Document(1, 2, 3)},
                {"7", Document.FromObject(new {Hello = "World"})}
            };
            
            var json = Marshall(doc);
            Assert.AreEqual("{\"document\":{\"0\":null,\"1\":true,\"2\":1.7976931348623157E+308,\"3\":2147483647,\"4\":9223372036854775807,\"5\":\"string\",\"6\":[1,2,3],\"7\":{\"Hello\":\"World\"}}}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void MarshallDiverseObjectFromObjectDocument()
        {
            var doc = new Document
            {
                new Document(),
                true,
                double.MaxValue,
                int.MaxValue,
                long.MaxValue,
                "string",
                new Document(1,2,3),
                Document.FromObject(new
                    {
                        foo = new {
                            baz = new int[] { 3, 4 }
                        }
                    }
                )
            };
            
            var json = Marshall(doc);
            Assert.AreEqual("{\"document\":[null,true,1.7976931348623157E+308,2147483647,9223372036854775807,\"string\",[1,2,3],{\"foo\":{\"baz\":[3,4]}}]}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void MarshallDiverseObjectDocument()
        {
            var doc = new Document
            {
                new Document(),
                true,
                double.MaxValue,
                int.MaxValue,
                long.MaxValue,
                "string",
                new Document(1,2,3),
                new Document(new Dictionary<string, Document>
                {
                    { "foo", new Document(new Dictionary<string, Document>
                        {
                            {"baz", new Document(3, 4) }
                        })
                    }
                })
            };
            
            var json = Marshall(doc);
            Assert.AreEqual("{\"document\":[null,true,1.7976931348623157E+308,2147483647,9223372036854775807,\"string\",[1,2,3],{\"foo\":{\"baz\":[3,4]}}]}", json);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void BasicUnmarshalTest()
        {
            var doc = Unmarshall("{\"document\":null}");
            Assert.IsTrue(doc.IsNull());
            
            doc = Unmarshall("{\"document\":true}");
            Assert.IsTrue(doc.IsBool());
            Assert.AreEqual(true, doc.AsBool());
            
            doc = Unmarshall("{\"document\":42}");
            Assert.IsTrue(doc.IsInt());
            Assert.AreEqual(42, doc.AsInt());
            
            doc = Unmarshall("{\"document\":12.34}");
            Assert.IsTrue(doc.IsDouble());
            Assert.AreEqual(12.34, doc.AsDouble());
            
            doc = Unmarshall($"{{\"document\":{long.MaxValue}}}");
            Assert.IsTrue(doc.IsLong());
            Assert.AreEqual(long.MaxValue, doc.AsLong());
            
            doc = Unmarshall("{\"document\":\"Hello World\"}");
            Assert.IsTrue(doc.IsString());
            Assert.AreEqual("Hello World", doc.AsString());
            
            doc = Unmarshall("{\"document\":[1,\"two\",3,4]}");
            Assert.IsTrue(doc.IsList());
            Assert.AreEqual(4, doc.AsList().Count);
            Assert.AreEqual(1, doc.AsList()[0]);
            Assert.AreEqual("two", doc.AsList()[1]);
            
            doc = Unmarshall("{\"document\":{\"Number\":12,\"Child\":{\"Hello\":\"World\"}}}");
            Assert.IsTrue(doc.IsDictionary());
            Assert.AreEqual(12, doc.AsDictionary()["Number"].AsInt());
            Assert.AreEqual("World", doc.AsDictionary()["Child"].AsDictionary()["Hello"].AsString());
        }
        
        private string Marshall(Document d)
        {
            var stream = new MemoryStream();
            var jsonWriter = new Utf8JsonWriter(stream);
            jsonWriter.WriteStartObject();
            jsonWriter.WritePropertyName("document");
            DocumentMarshaller.Instance.Write(jsonWriter, d);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();
            return Encoding.UTF8.GetString(stream.ToArray());
        }

        private Document Unmarshall(string json)
        {
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var context = new JsonUnmarshallerContext(ms, false,null);
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(ms);
            // simulate reading property name
            context.Read(ref reader);
            context.ReadAtDepth(context.CurrentDepth, ref reader);
            var temp = context.TestExpression("document", context.CurrentDepth);
            
            return DocumentUnmarshaller.Instance.Unmarshall(context, ref reader);
        }
    }
}