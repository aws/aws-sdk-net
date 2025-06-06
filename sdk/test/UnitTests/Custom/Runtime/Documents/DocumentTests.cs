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
using System.Linq;
using Amazon.Runtime.Documents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DocumentTests
    {
        /// <summary>
        /// Validates that an empty <see cref="Document"/> has its
        /// <see cref="Document.Type"/> initialized to <see cref="DocumentType.Null"/>.
        /// <para />
        /// If this breaks, check the ordering of <see cref="DocumentType"/>
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NewDocumentIsNull()
        {
            var document = new Document();
            
            Assert.IsTrue(document.IsNull());
        }

        /// <summary>
        /// Initializes each type of <see cref="Document"/> and then validates
        /// a) the <see cref="Document.Type"/> is set correctly and b) calling the associated
        /// AsX() method correctly returns the backing value.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DocumentInitialization()
        {
            // null
            var doc = new Document();
            AssertIsDocumentType(doc, DocumentType.Null);

            // bool
            doc = true;
            AssertIsDocumentType(doc, DocumentType.Bool);
            Assert.AreEqual(true, doc.AsBool());
            
            // double
            doc = double.MaxValue;
            AssertIsDocumentType(doc, DocumentType.Double);
            Assert.AreEqual(double.MaxValue, doc.AsDouble());
            
            // int
            doc = int.MaxValue;
            AssertIsDocumentType(doc, DocumentType.Int);
            Assert.AreEqual(int.MaxValue, doc.AsInt());
            
            // long
            doc = long.MaxValue;
            AssertIsDocumentType(doc, DocumentType.Long);
            Assert.AreEqual(long.MaxValue, doc.AsLong());

            // string
            doc = "hello world";
            AssertIsDocumentType(doc, DocumentType.String);
            Assert.AreEqual("hello world", doc.AsString());
            
            // list
            doc = new Document
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
            AssertIsDocumentType(doc, DocumentType.List);
            AssertIsDocumentType(doc.AsList()[0], DocumentType.Null);
            AssertIsDocumentType(doc.AsList()[1], DocumentType.Bool);
            AssertIsDocumentType(doc.AsList()[2], DocumentType.Double);
            AssertIsDocumentType(doc.AsList()[3], DocumentType.Int);
            AssertIsDocumentType(doc.AsList()[4], DocumentType.Long);
            AssertIsDocumentType(doc.AsList()[5], DocumentType.String);
            AssertIsDocumentType(doc.AsList()[6], DocumentType.List);
            AssertIsDocumentType(doc.AsList()[7], DocumentType.Dictionary);

            // dictionary
            doc = new Document
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
            AssertIsDocumentType(doc, DocumentType.Dictionary);
            AssertIsDocumentType(doc.AsDictionary()["0"], DocumentType.Null);
            AssertIsDocumentType(doc.AsDictionary()["1"], DocumentType.Bool);
            AssertIsDocumentType(doc.AsDictionary()["2"], DocumentType.Double);
            AssertIsDocumentType(doc.AsDictionary()["3"], DocumentType.Int);
            AssertIsDocumentType(doc.AsDictionary()["4"], DocumentType.Long);
            AssertIsDocumentType(doc.AsDictionary()["5"], DocumentType.String);
            AssertIsDocumentType(doc.AsDictionary()["6"], DocumentType.List);
            AssertIsDocumentType(doc.AsDictionary()["7"], DocumentType.Dictionary);
            
            //special case: empty list/dictionary
            doc = new Document(new List<Document>());
            AssertIsDocumentType(doc, DocumentType.List);
            
            doc = new Document(new Dictionary<string, Document>());
            AssertIsDocumentType(doc, DocumentType.Dictionary);
        }
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Equality()
        {
            // documents are equal based on backing value
            Assert.AreEqual(new Document(true), new Document(true));
            Assert.AreEqual(new Document(42), new Document(42));
            Assert.AreEqual(new Document(42d), new Document(42d));
            Assert.AreEqual(new Document(42L), new Document(42L));
            Assert.AreEqual(new Document("42"), new Document("42"));
            
            // different types are not equal
            Assert.AreNotEqual(new Document("42"), new Document(42));
            Assert.AreNotEqual(new Document("true"), new Document(true));
            
            // collections use reference equality
            var a = new Document(1, 2, 3);
            var b = a;
            var x = new Document(1, 2, 3);
            Assert.AreEqual(a, b);
            Assert.AreNotEqual(a, x);
            
            a = new Document{{"Hello", "World"}};
            b = a;
            x = new Document{{"Hello", "World"}};
            Assert.AreEqual(a, b);
            Assert.AreNotEqual(a, x);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ListCollectionInitializer()
        {
            var listDoc = new Document
            {
                "foo", "bar", "baz"
            };
            
            Assert.IsTrue(listDoc.IsList());
            Assert.AreEqual(3, listDoc.AsList().Count);
            Assert.AreEqual("bar", listDoc.AsList().ElementAt(1));
        }
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DictionaryCollectionInitializer()
        {
            var dictionaryDoc = new Document
            {
                {"foo", "42 things"},
                {"bar", "12 other"},
                {"baz", "true words"}
            };

            Assert.IsTrue(dictionaryDoc.IsDictionary());
            Assert.AreEqual("true words", dictionaryDoc.AsDictionary()["baz"]);
        }

        /// <summary>
        /// Ensures that calling an AsX() method that doesn't
        /// match the <see cref="Document.Type"/> results in a thrown
        /// <see cref="InvalidDocumentTypeConversionException"/>
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void InvalidDocumentTypeConversionTests()
        {
            // ensure all AsX() when Type is null
            var doc = new Document();
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsBool());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsDictionary());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsDouble());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsInt());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsList());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsLong());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsString());
            
            // ensure all AsX() except AsInt() throw when Type is Int
            doc = new Document(42);
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsBool());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsDictionary());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsDouble());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsList());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsLong());
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsString());
            
            // ensure AsInt() throws when type is not Int 
            doc = new Document("hello");
            Assert.ThrowsException<InvalidDocumentTypeConversionException>(() => doc.AsInt());
        }
        
        private void AssertIsDocumentType(Document doc, DocumentType t)
        {
            if (t == DocumentType.Bool)
                Assert.IsTrue(doc.IsBool());
            else
                Assert.IsFalse(doc.IsBool());
            
            if (t == DocumentType.Dictionary)
                Assert.IsTrue(doc.IsDictionary());
            else
                Assert.IsFalse(doc.IsDictionary());
            
            if (t == DocumentType.Double)
                Assert.IsTrue(doc.IsDouble());
            else
                Assert.IsFalse(doc.IsDouble());

            if (t == DocumentType.Int)
                Assert.IsTrue(doc.IsInt());
            else
                Assert.IsFalse(doc.IsInt());
            
            if (t == DocumentType.List)
                Assert.IsTrue(doc.IsList());
            else
                Assert.IsFalse(doc.IsList());
            
            if (t == DocumentType.Long)
                Assert.IsTrue(doc.IsLong());
            else
                Assert.IsFalse(doc.IsLong());
            
            if (t == DocumentType.Null)
                Assert.IsTrue(doc.IsNull());
            else
                Assert.IsFalse(doc.IsNull());
            
            if (t == DocumentType.String)
                Assert.IsTrue(doc.IsString());
            else
                Assert.IsFalse(doc.IsString());
        }
                /// <summary>
        /// Tests that enumerating a Dictionary type Document works correctly
        /// This tests the fix for WebAuthn serialization errors
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void EnumerateDictionaryDocument()
        {
            // Create a dictionary document
            var doc = new Document
            {
                {"key1", "value1"},
                {"key2", 42},
                {"key3", true}
            };

            // Ensure we can enumerate the document as IEnumerable<Document>
            var values = new List<Document>();
            foreach (var item in (IEnumerable<Document>)doc)
            {
                values.Add(item);
            }

            // Should enumerate dictionary values
            Assert.AreEqual(3, values.Count);
            Assert.IsTrue(values.Any(v => v.IsString() && v.AsString() == "value1"));
            Assert.IsTrue(values.Any(v => v.IsInt() && v.AsInt() == 42));
            Assert.IsTrue(values.Any(v => v.IsBool() && v.AsBool() == true));
        }

        /// <summary>
        /// Tests that enumerating a List type Document still works correctly
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void EnumerateListDocument()
        {
            // Create a list document
            var doc = new Document("value1", 42, true);

            // Ensure we can enumerate the document
            var values = new List<Document>();
            foreach (var item in (IEnumerable<Document>)doc)
            {
                values.Add(item);
            }

            // Should enumerate list items in order
            Assert.AreEqual(3, values.Count);
            Assert.IsTrue(values[0].IsString() && values[0].AsString() == "value1");
            Assert.IsTrue(values[1].IsInt() && values[1].AsInt() == 42);
            Assert.IsTrue(values[2].IsBool() && values[2].AsBool() == true);
        }

        /// <summary>
        /// Tests that enumerating non-collection type Documents returns the document itself
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void EnumerateNonCollectionDocument()
        {
            // Test with various non-collection types
            var stringDoc = new Document("test");
            var intDoc = new Document(42);
            var boolDoc = new Document(true);
            var nullDoc = new Document();

            // Each should enumerate to a single item - itself
            var stringValues = ((IEnumerable<Document>)stringDoc).ToList();
            Assert.AreEqual(1, stringValues.Count);
            Assert.AreEqual(stringDoc, stringValues[0]);

            var intValues = ((IEnumerable<Document>)intDoc).ToList();
            Assert.AreEqual(1, intValues.Count);
            Assert.AreEqual(intDoc, intValues[0]);

            var boolValues = ((IEnumerable<Document>)boolDoc).ToList();
            Assert.AreEqual(1, boolValues.Count);
            Assert.AreEqual(boolDoc, boolValues[0]);

            var nullValues = ((IEnumerable<Document>)nullDoc).ToList();
            Assert.AreEqual(1, nullValues.Count);
            Assert.AreEqual(nullDoc, nullValues[0]);
        }

        /// <summary>
        /// Tests that LINQ operations work correctly on Dictionary documents
        /// This specifically tests the WebAuthn scenario
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LinqOperationsOnDictionaryDocument()
        {
            // Create a complex dictionary document similar to WebAuthn responses
            var doc = new Document
            {
                {"credentialId", "abc123"},
                {"publicKey", "key-data"},
                {"signCount", 5},
                {"userVerified", true},
                {"attestationObject", new Document
                    {
                        {"fmt", "packed"},
                        {"authData", "auth-data-bytes"}
                    }
                }
            };

            // Cast to IEnumerable<Document> to use LINQ operations
            var enumerable = (IEnumerable<Document>)doc;

            // Test that we can use LINQ operations
            var count = enumerable.Count();
            Assert.AreEqual(5, count);

            // Test FirstOrDefault
            var first = enumerable.FirstOrDefault();
            Assert.IsNotNull(first);

            // Test Any
            Assert.IsTrue(enumerable.Any());

            // Test Where (filtering)
            var stringValues = enumerable.Where(d => d.IsString()).ToList();
            Assert.IsTrue(stringValues.Count >= 2); // At least credentialId and publicKey

            // Test Select (projection)
            var types = enumerable.Select(d => d.Type).ToList();
            Assert.AreEqual(5, types.Count);
        }
    }
}