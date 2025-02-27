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
using System.Text.Json;

namespace Amazon.Runtime.Documents.Internal.Transform
{
    /// <summary>
    /// Dedicated Json Marshaller for <see cref="Document"/>.
    /// </summary>
    public class DocumentMarshaller
    {
        public static DocumentMarshaller Instance { get; } = new DocumentMarshaller();
        private DocumentMarshaller() { }

        public void Write(Utf8JsonWriter writer, Document doc)
        {
            switch (doc.Type)
            {
                case DocumentType.Null:
                    // explicitly write null
                    writer.WriteNullValue();
                    return;
                case DocumentType.Bool:
                    writer.WriteBooleanValue(doc.AsBool());
                    return;
                case DocumentType.Double:
                    writer.WriteNumberValue(doc.AsDouble());
                    return;
                case DocumentType.Int:
                    writer.WriteNumberValue(doc.AsInt());
                    return;
                case DocumentType.String:
                    writer.WriteStringValue(doc.AsString());
                    return;
                case DocumentType.List:
                    writer.WriteStartArray();
                    foreach (var item in doc.AsList())
                        Write(writer, item);
                    writer.WriteEndArray();
                    return;
                case DocumentType.Long:
                    writer.WriteNumberValue(doc.AsLong());
                    return;
                case DocumentType.Dictionary:
                    writer.WriteStartObject();
                    foreach (var kvp in doc.AsDictionary())
                    {
                        writer.WritePropertyName(kvp.Key);
                        Write(writer, kvp.Value);
                    }

                    writer.WriteEndObject();
                    return;
                default:
                    throw new ArgumentException($"Unknown Document Type: {doc.Type}");
            }
        }
    }
}