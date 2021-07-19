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
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Documents.Internal.Transform
{
    /// <summary>
    /// Dedicated Json Marshaller for <see cref="Document"/>.
    /// </summary>
    public class DocumentMarshaller
    {
        public static DocumentMarshaller Instance { get; } = new DocumentMarshaller();
        private DocumentMarshaller() { }

        public void Write(JsonWriter writer, Document doc)
        {
            switch (doc.Type)
            {
                case DocumentType.Null:
                    // explicitly write null
                    writer.Write(null);
                    return;
                case DocumentType.Bool:
                    writer.Write(doc.AsBool());
                    return;
                case DocumentType.Double:
                    writer.Write(doc.AsDouble());
                    return;
                case DocumentType.Int:
                    writer.Write(doc.AsInt());
                    return;
                case DocumentType.String:
                    writer.Write(doc.AsString());
                    return;
                case DocumentType.List:
                    writer.WriteArrayStart();
                    foreach (var item in doc.AsList())
                        Write(writer, item);
                    writer.WriteArrayEnd();
                    return;
                case DocumentType.Long:
                    writer.Write(doc.AsLong());
                    return;
                case DocumentType.Dictionary:
                    writer.WriteObjectStart();
                    foreach (var kvp in doc.AsDictionary())
                    {
                        writer.WritePropertyName(kvp.Key);
                        Write(writer, kvp.Value);
                    }

                    writer.WriteObjectEnd();
                    return;
                default:
                    throw new ArgumentException($"Unknown Document Type: {doc.Type}");
            }
        }
    }
}