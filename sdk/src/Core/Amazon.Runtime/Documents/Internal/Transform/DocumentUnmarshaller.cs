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
using Amazon.Runtime.Internal.Transform;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Documents.Internal.Transform
{
    /// <summary>
    /// Dedicated <see cref="IUnmarshaller{T,R}"/> for <see cref="Document"/>.
    /// </summary>
    /// <remarks>
    /// Per the Document Spec, Xml is not supported.
    /// </remarks>
    public class DocumentUnmarshaller : IUnmarshaller<Document, JsonUnmarshallerContext>, IUnmarshaller<Document, XmlUnmarshallerContext>
    {
        public static DocumentUnmarshaller Instance { get; } = new DocumentUnmarshaller();
        private DocumentUnmarshaller() { }

        public Document Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            switch (context.CurrentTokenType)
            {
                case JsonToken.Null:
                case JsonToken.None:
                    return new Document();
                case JsonToken.Boolean:
                    return new Document(bool.Parse(context.ReadText()));
                case JsonToken.Double:
                    return new Document(double.Parse(context.ReadText()));
                case JsonToken.Int:
                    return new Document(int.Parse(context.ReadText()));
                case JsonToken.Long:
                    return new Document(long.Parse(context.ReadText()));
                case JsonToken.String:
                    return new Document(context.ReadText());
                case JsonToken.ArrayStart:
                    var list = new List<Document>();

                    while (!context.Peek(JsonToken.ArrayEnd))
                        list.Add(Unmarshall(context));

                    context.Read(); // Read ArrayEnd
                    return new Document(list);
                case JsonToken.ObjectStart:
                    var dict = new Dictionary<string, Document>();

                    while (!context.Peek(JsonToken.ObjectEnd))
                    {
                        // Only supported Object is Dictionary<string, Document>

                        var key = StringUnmarshaller.Instance.Unmarshall(context);
                        var value = Unmarshall(context);

                        dict.Add(key, value);
                    }

                    context.Read(); // Read ObjectEnd

                    return new Document(dict);
                default:
                    throw new ArgumentException($"Unknown JSON type: {context.CurrentTokenType}");
            }
        }

        /// <remarks>
        /// Document Types does not support xml.  However, Generic Type constraints for
        /// <see cref="ListUnmarshaller{I,IUnmarshaller}"/> require implementing both
        /// json and xml unmarshalling support.
        /// </remarks>
        Document IUnmarshaller<Document, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext input)
        {
            throw new NotImplementedException("Document is not supported in Xml Protocol");
        }
    }
}