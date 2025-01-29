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

/*
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RetrievalFilter Object
    /// </summary>  
    public class RetrievalFilterUnmarshaller : IJsonUnmarshaller<RetrievalFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RetrievalFilter Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RetrievalFilter unmarshalledObject = new RetrievalFilter();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("andAll", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RetrievalFilter, RetrievalFilterUnmarshaller>(RetrievalFilterUnmarshaller.Instance);
                    unmarshalledObject.AndAll = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("equals", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.Equals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("greaterThan", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.GreaterThan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("greaterThanOrEquals", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.GreaterThanOrEquals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("in", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.In = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lessThan", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.LessThan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lessThanOrEquals", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.LessThanOrEquals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listContains", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.ListContains = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notEquals", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.NotEquals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notIn", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.NotIn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("orAll", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RetrievalFilter, RetrievalFilterUnmarshaller>(RetrievalFilterUnmarshaller.Instance);
                    unmarshalledObject.OrAll = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startsWith", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.StartsWith = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stringContains", targetDepth))
                {
                    var unmarshaller = FilterAttributeUnmarshaller.Instance;
                    unmarshalledObject.StringContains = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RetrievalFilterUnmarshaller _instance = new RetrievalFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RetrievalFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}