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
using System.Collections.Specialized;
using System.Linq;
using System.Text.Json;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Documents.Internal.Transform
{
    /// <summary>
    /// Dedicated <see cref="IJsonUnmarshaller{T,TJsonUnmarshallerContext}"/> for <see cref="Document"/>.
    /// </summary>
    /// <remarks>
    /// Per the Document Spec, Xml is not supported.
    /// </remarks>
    public class DocumentUnmarshaller : IJsonUnmarshaller<Document, JsonUnmarshallerContext>
    {
        public static DocumentUnmarshaller Instance { get; } = new DocumentUnmarshaller();
        private DocumentUnmarshaller() { }

        public Document Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            switch (context.CurrentTokenType)
            {
                case JsonTokenType.Null:
                case JsonTokenType.None:
                    return new Document();
                case JsonTokenType.True:
                case JsonTokenType.False:
                    return new Document(reader.Reader.GetBoolean());
                case JsonTokenType.Number:
                    if (reader.Reader.TryGetInt32(out int intValue))
                    {
                        return new Document(intValue);
                    }
                    else if (reader.Reader.TryGetInt64(out long longValue))
                    {
                        return new Document(longValue);
                    }
                    else if (reader.Reader.TryGetDouble(out double doubleValue))
                    {
                        return new Document(doubleValue);
                    }
                    else
                    {
                        throw new JsonException("Unsupported number type.");
                    }
                case JsonTokenType.String:
                    return new Document(reader.Reader.GetString());
                case JsonTokenType.StartArray:
                    var list = new List<Document>();

                    while (!context.Peek(JsonTokenType.EndArray, ref reader))
                        list.Add(Unmarshall(context, ref reader));

                    context.Read(ref reader); // Read ArrayEnd
                    return new Document(list);
                case JsonTokenType.StartObject:
                    var dict = new Dictionary<string, Document>();

                    while (!context.Peek(JsonTokenType.EndObject, ref reader))
                    {
                        // Only supported Object is Dictionary<string, Document>

                        var key = StringUnmarshaller.Instance.Unmarshall(context, ref reader);
                        var value = Unmarshall(context, ref reader);

                        dict.Add(key, value);
                    }

                    context.Read(ref reader); // Read ObjectEnd

                    return new Document(dict);
                default:
                    throw new ArgumentException($"Unknown JSON type: {context.CurrentTokenType}");
            }
        }
    }
}