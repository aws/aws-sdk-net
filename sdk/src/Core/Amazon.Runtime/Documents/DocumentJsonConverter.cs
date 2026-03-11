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
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Amazon.Runtime.Documents.Internal.Transform;

namespace Amazon.Runtime.Documents
{
    /// <summary>
    /// Custom <see cref="JsonConverter{T}"/> for <see cref="Document"/> that prevents
    /// System.Text.Json from treating Document as a collection (due to its IEnumerable implementations)
    /// and instead serializes/deserializes it according to its actual document type.
    /// </summary>
    internal sealed class DocumentJsonConverter : JsonConverter<Document>
    {
        /// <inheritdoc/>
        public override Document Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return ReadDocument(ref reader);
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, Document value, JsonSerializerOptions options)
        {
            DocumentMarshaller.Instance.Write(writer, value);
        }

        private static Document ReadDocument(ref Utf8JsonReader reader)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.Null:
                    return new Document();

                case JsonTokenType.True:
                case JsonTokenType.False:
                    return new Document(reader.GetBoolean());

                case JsonTokenType.Number:
                    if (reader.TryGetInt32(out int intValue))
                        return new Document(intValue);
                    if (reader.TryGetInt64(out long longValue))
                        return new Document(longValue);
                    if (reader.TryGetDouble(out double doubleValue))
                        return new Document(doubleValue);
                    throw new JsonException("Unsupported number type.");

                case JsonTokenType.String:
                    return new Document(reader.GetString());

                case JsonTokenType.StartArray:
                    var list = new List<Document>();
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                            break;
                        list.Add(ReadDocument(ref reader));
                    }
                    return new Document(list);

                case JsonTokenType.StartObject:
                    var dict = new Dictionary<string, Document>();
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndObject)
                            break;
                        if (reader.TokenType != JsonTokenType.PropertyName)
                            throw new JsonException($"Expected PropertyName but got {reader.TokenType}");
                        var key = reader.GetString();
                        reader.Read();
                        dict[key] = ReadDocument(ref reader);
                    }
                    return new Document(dict);

                default:
                    throw new JsonException($"Unexpected JSON token type: {reader.TokenType}");
            }
        }
    }
}
