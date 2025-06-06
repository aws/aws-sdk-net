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


using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using ThirdParty.RuntimeBackports;
using System.Text.Json;
namespace Amazon.Runtime.Documents
{
    /// <summary>
    /// A specialized type that is used to carry open content.  A <see cref="Document"/> can represent primitives like
    /// <see cref="bool"/>, <see cref="double"/> <see cref="int"/>, <see cref="long"/> and <see cref="string"/>, complex objects
    /// (represented as a Dictionary&lt;string,Document&gt;) and lists of <see cref="Document"/>.
    /// <para />
    /// When working with a <see cref="Document"/> it's necessary to first convert it to its backing type via one of the provided AsX() methods.
    /// Type checking can be done via IsX() method.
    /// <example><code><![CDATA[
    /// public void ConsumeDocument(Document doc)
    /// {
    ///    if (doc.IsInt())
    ///    {
    ///       int intValue = doc.AsInt();
    ///       // do work with intValue
    ///    }
    ///    else if (doc.IsString())
    ///    {
    ///       string stringValue = doc.AsString();
    ///       // do work with stringValue
    ///    }
    /// }
    /// ]]></code></example>
    /// </summary>
    /// <remarks>
    /// Document Types specification specifies support for arbitrary precision integers.  However, the dotnet implementation
    /// is limited to representing numbers as either <see cref="double"/>, <see cref="int"/> or <see cref="long"/>.
    /// </remarks>
    public partial struct Document : IEquatable<Document>, IEnumerable<Document>, IEnumerable<KeyValuePair<string, Document>>
    {
        private readonly bool _dataBool;
        private readonly double _dataDouble;
        private readonly int _dataInt;
        private readonly long _dataLong;
        private readonly string _dataString;
        private List<Document> _dataList;
        private Dictionary<string, Document> _dataDictionary;

        public DocumentType Type { get; private set; }

        #region Constructors
        public Document(bool value) : this()
        {
            Type = DocumentType.Bool;
            _dataBool = value;
        }
        public Document(double value) : this()
        {
            Type = DocumentType.Double;
            _dataDouble = value;
        }
        public Document(int value) : this()
        {
            Type = DocumentType.Int;
            _dataInt = value;
        }
        public Document(long value) : this()
        {
            Type = DocumentType.Long;
            _dataLong = value;
        }
        public Document(string value) : this()
        {
            Type = DocumentType.String;
            _dataString = value;
        }
        public Document(List<Document> values) : this()
        {
            Type = DocumentType.List;
            _dataList = values;
        }
        public Document(params Document[] values) : this(values.ToList()) { }
        public Document(Dictionary<string, Document> values) : this()
        {
            Type = DocumentType.Dictionary;
            _dataDictionary = values;
        }
        #endregion

        #region Implicit Conversion Operators

        public static implicit operator Document(bool value) => new Document(value);
        public static implicit operator Document(double value) => new Document(value);
        public static implicit operator Document(int value) => new Document(value);
        public static implicit operator Document(long value) => new Document(value);
        public static implicit operator Document(string value) => new Document(value);
        public static implicit operator Document(Document[] values) => new Document(values);
        public static implicit operator Document(Dictionary<string, Document> values) => new Document(values);
        #endregion

        #region Type Checking/Conversion
        /// <summary>
        /// Returns true if <see cref="Type"/> is <see cref="DocumentType.Bool"/>
        /// </summary>
        public bool IsBool() => Type == DocumentType.Bool;
        /// <summary>
        /// Returns the Document's backing value as a <see cref="bool"/>.
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.Bool"/></exception>
        public bool AsBool()
        {
            AssertIsType(DocumentType.Bool);

            return _dataBool;
        }
        
        /// <summary>
        /// Returns true if <see cref="Type"/> is <see cref="DocumentType.Dictionary"/>
        /// </summary>
        public bool IsDictionary() => Type == DocumentType.Dictionary;
        /// <summary>
        /// Returns the Document's backing value.
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.Dictionary"/></exception>
        public Dictionary<string, Document> AsDictionary()
        {
            AssertIsType(DocumentType.Dictionary);

            return _dataDictionary;
        }

        /// <summary>
        /// Returns true if <see cref="Type"/> is <see cref="DocumentType.Double"/>
        /// </summary>
        public bool IsDouble() => Type == DocumentType.Double;
        /// <summary>
        /// Returns the Document's backing value as a <see cref="Double"/>.
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.Double"/></exception>
        public double AsDouble()
        {
            AssertIsType(DocumentType.Double);

            return _dataDouble;
        }

        /// <summary>
        /// Returns true if <see cref="Type"/> is <see cref="DocumentType.Int"/>
        /// </summary>
        public bool IsInt() => Type == DocumentType.Int;
        /// <summary>
        /// Returns the Document's backing value as a <see cref="int"/>.
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.Int"/></exception>
        public int AsInt()
        {
            AssertIsType(DocumentType.Int);

            return _dataInt;
        }

        /// <summary>
        /// Returns true if <see cref="Type"/> is <see cref="DocumentType.List"/>
        /// </summary>
        public bool IsList() => Type == DocumentType.List;
        /// <summary>
        /// Returns the Document's backing value as a <see cref="List{Document}"/>.
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.List"/></exception>
        public List<Document> AsList()
        {
            AssertIsType(DocumentType.List);

            return _dataList;
        }

        /// <summary>
        /// Returns true if <see cref="Type"/> is <see cref="DocumentType.Long"/>
        /// </summary>
        public bool IsLong() => Type == DocumentType.Long;
        /// <summary>
        /// Returns the Document's backing value as a <see cref="long"/>.
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.Long"/></exception>
        public long AsLong()
        {
            AssertIsType(DocumentType.Long);

            return _dataLong;
        }

        /// <summary>
        /// Returns true if <see cref="Type"/> is <see cref="DocumentType.Null"/>
        /// </summary>
        public bool IsNull() => Type == DocumentType.Null;

        /// <summary>
        /// Returns true if <see cref="Type"/> is <see cref="DocumentType.String"/>
        /// </summary>
        public bool IsString() => Type == DocumentType.String;
        /// <summary>
        /// Returns the Document's backing value as a <see cref="string"/>.
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.String"/></exception>
        public string AsString()
        {
            AssertIsType(DocumentType.String);

            return _dataString;
        }

        private void AssertIsType(DocumentType type)
        {
            if (Type != type)
                throw new InvalidDocumentTypeConversionException(type, Type);
        }
        #endregion

        #region Equality

        public bool Equals(Document other)
        {
            if (Type != other.Type)
                return false;

            switch (Type)
            {
                case DocumentType.Null:
                    return true;

                case DocumentType.Bool:
                    return _dataBool == other.AsBool();
                case DocumentType.Double:
                    return _dataDouble.Equals(other.AsDouble());
                case DocumentType.Int:
                    return _dataInt == other.AsInt();
                case DocumentType.Long:
                    return _dataLong == other.AsLong();
                case DocumentType.String:
                    return _dataString.Equals(other.AsString());

                // use reference equality 
                case DocumentType.List:
                    return _dataList.Equals(other.AsList());
                case DocumentType.Dictionary:
                    return _dataDictionary.Equals(other.AsDictionary());
                
                default:
                    return false;
            }
        }

        public bool Equals(Document? other)
        {
            if (!other.HasValue)
                return false;

            return Equals(other.Value);
        }
        
        public override bool Equals(object obj)
        {
            return Equals(obj as Document?);
        }

        public override int GetHashCode() => base.GetHashCode();
        public static bool operator ==(Document left, Document right) => left.Equals(right);
        public static bool operator !=(Document left, Document right) => !left.Equals(right);
        #endregion

        #region Collection Initializers
        IEnumerator<Document> IEnumerable<Document>.GetEnumerator()
        {
            if (Type == DocumentType.List)
                return AsList().GetEnumerator();

            if (Type == DocumentType.Dictionary)
                return AsDictionary().Values.GetEnumerator();

            return new[] { this }.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (Type == DocumentType.List)
                return AsList().GetEnumerator();

            if (Type == DocumentType.Dictionary)
                return AsDictionary().GetEnumerator();

            return new[]{this}.GetEnumerator();
        }

        /// <summary>
        /// This method is meant to support Collection Initializers and should not be used directly.
        /// Use <see cref="AsList"/>.Add() instead.
        /// <para />
        /// Supports:
        /// <code><![CDATA[
        /// request.Document = new Document
        /// {
        ///     "foo", "bar", "baz"
        /// };
        /// ]]></code>
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.List"/></exception>
        public void Add(Document document)
        {
            // special type case to support collection initializer
            if (Type == DocumentType.Null)
            {
                Type = DocumentType.List;
                _dataList = new List<Document>();
            }

            AssertIsType(DocumentType.List);
            _dataList.Add(document);
        }

        IEnumerator<KeyValuePair<string, Document>> IEnumerable<KeyValuePair<string, Document>>.GetEnumerator()
        {
            return AsDictionary().GetEnumerator();
        }

        /// <summary>
        /// This method is meant to support Collection Initializers and should not be used directly.
        /// Use <see cref="AsDictionary"/>.Add() instead.
        /// <para />
        /// Supports:
        /// <code><![CDATA[
        /// request.Document = new Document
        /// {
        ///     {"foo", 42},
        ///     {"bar", 12},
        ///     {"baz", true}
        /// };
        /// ]]></code>
        /// </summary>
        /// <exception cref="InvalidDocumentTypeConversionException">Thrown if <see cref="Type"/> is not <see cref="DocumentType.Dictionary"/></exception>
        public void Add(string key, Document value)
        {
            // special type case to support collection initializer
            if (Type == DocumentType.Null)
            {
                _dataDictionary = new Dictionary<string, Document>();
                Type = DocumentType.Dictionary;
            }

            AssertIsType(DocumentType.Dictionary);
            _dataDictionary.Add(key, value);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            switch (Type)
            {
                case DocumentType.Bool:
                    return _dataBool.ToString();

                case DocumentType.Dictionary:
                    return "Document dictionary";

                case DocumentType.Double:
                    return _dataDouble.ToString(CultureInfo.CurrentCulture);

                case DocumentType.Int:
                    return _dataInt.ToString();
                
                case DocumentType.List:
                    return "Document list";

                case DocumentType.Long:
                    return _dataLong.ToString();
                
                case DocumentType.Null:
                    return "Document null value";

                case DocumentType.String:
                    return _dataString;
            }

            return base.ToString();
        }
        #endregion

        #region FromObject
        /// <summary>
        /// Convenience method for generating <see cref="Document"/> objects from a strongly typed
        /// or anonymous object.
        /// <example><code><![CDATA[
        /// var document = Document.FromObject(new {
        ///    Hello = "World",
        ///    Nested = new {
        ///       Example = true,
        ///       Number = 42
        ///    }
        /// });
        /// ]]> </code></example>
        /// This method uses reflection to analyze <paramref name="o"/> and is therefor not intended
        /// for performance critical work.  Additionally, if <paramref name="o"/> is a known primitive (ie <see cref="int"/>),
        /// using a <see cref="Document"/> constructor directly will be more performant.
        /// </summary> 
        [RequiresUnreferencedCode("FromObject is not currently supported for Native AOT compilation due unbounded reflection required.")]
        public static Document FromObject(object o)
        {
            string jsonString = JsonSerializer.Serialize(o);
            using JsonDocument jsonDoc = JsonDocument.Parse(jsonString);

            return FromObject(jsonDoc.RootElement);
        }

        [RequiresUnreferencedCode("FromObject is not currently supported for Native AOT compilation due unbounded reflection required.")]
        private static Document FromObject(JsonElement jsonElement)
        {
            switch (jsonElement.ValueKind)
            {
                case JsonValueKind.Undefined:
                case JsonValueKind.Null:
                    return new Document();
                case JsonValueKind.False:
                case JsonValueKind.True:
                    return new Document(jsonElement.GetBoolean());
                case JsonValueKind.Number:
                    if (jsonElement.TryGetInt64(out long longValue))
                        return new Document(longValue);
                    if (jsonElement.TryGetDouble(out double doubleValue))
                        return new Document(doubleValue);
                    throw new NotSupportedException("Unsupported number format");
                case JsonValueKind.String:
                    return new Document(jsonElement.GetString());
                case JsonValueKind.Array:
                    return new Document(jsonElement.EnumerateArray().Select(FromObject).ToArray());
                case JsonValueKind.Object:
                    var dictionary = new Dictionary<string, Document>();
                    Copy(jsonElement, dictionary);
                    return new Document(dictionary);
            }

            throw new NotSupportedException($"Couldn't convert {jsonElement.ValueKind}");
        }

        [RequiresUnreferencedCode("FromObject is not currently supported for Native AOT compilation due unbounded reflection required.")]
        private static void Copy(JsonElement jsonElement, Dictionary<string, Document> target)
        {
            foreach (JsonProperty property in jsonElement.EnumerateObject())
            {
                target[property.Name] = FromObject(property.Value);
            }
        }
        #endregion
    }
}
