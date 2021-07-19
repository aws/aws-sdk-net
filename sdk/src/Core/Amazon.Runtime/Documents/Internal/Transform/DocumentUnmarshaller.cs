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
    public class DocumentUnmarshaller : IUnmarshaller<Document, JsonUnmarshallerContext>
    {
        public static DocumentUnmarshaller Instance { get; } = new DocumentUnmarshaller();
        private DocumentUnmarshaller() { }

        public Document Unmarshall(JsonUnmarshallerContext context)
        {
            var jsonData = context.ToJsonData();

            return MapFromJsonObject(jsonData);
        }
        
        private static Document MapFromJsonObject(IJsonWrapper jsonWrapper)
        {
            if (null == jsonWrapper)
                return new Document();

            switch (jsonWrapper.GetJsonType())
            {
                case JsonType.None:
                    return new Document();
                case JsonType.Boolean:
                    return new Document(jsonWrapper.GetBoolean());
                case JsonType.Double:
                    return new Document(jsonWrapper.GetDouble());
                case JsonType.Int:
                    return new Document(jsonWrapper.GetInt());
                case JsonType.Long:
                    return new Document(jsonWrapper.GetLong());
                case JsonType.String:
                    return new Document(jsonWrapper.GetString());
                case JsonType.Array:
                    return new Document((jsonWrapper as IList).Cast<IJsonWrapper>().Select(MapFromJsonObject).ToList());
                case JsonType.Object:
                    return new Document(MapDictionary(jsonWrapper));
                default:
                    throw new ArgumentException($"Unknown JSON type: {jsonWrapper.GetJsonType()}");
            }
        }
        private static Dictionary<string, Document> MapDictionary(IOrderedDictionary dictionary)
        {
            return dictionary.Keys.Cast<object>()
                .ToDictionary(
                    key => key.ToString(),
                    key => MapFromJsonObject((IJsonWrapper) dictionary[key]));
        }
    }
}