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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AttributeValue Object
    /// </summary>  
    public class AttributeValueUnmarshaller : IJsonUnmarshaller<AttributeValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AttributeValue Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AttributeValue unmarshalledObject = new AttributeValue();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("B", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    unmarshalledObject.B = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BOOL", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.BOOL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BS", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MemoryStream, MemoryStreamUnmarshaller>(MemoryStreamUnmarshaller.Instance);
                    unmarshalledObject.BS = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("L", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AttributeValue, AttributeValueUnmarshaller>(AttributeValueUnmarshaller.Instance);
                    unmarshalledObject.L = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("M", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.Instance, AttributeValueUnmarshaller.Instance);
                    unmarshalledObject.M = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("N", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.N = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NS", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NS = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NULL", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.NULL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SS", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SS = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AttributeValueUnmarshaller _instance = new AttributeValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AttributeValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}