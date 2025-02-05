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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ThingDocument Object
    /// </summary>  
    public class ThingDocumentUnmarshaller : IJsonUnmarshaller<ThingDocument, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ThingDocument Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ThingDocument unmarshalledObject = new ThingDocument();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("attributes", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("connectivity", targetDepth))
                {
                    var unmarshaller = ThingConnectivityUnmarshaller.Instance;
                    unmarshalledObject.Connectivity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deviceDefender", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceDefender = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("shadow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Shadow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("thingGroupNames", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ThingGroupNames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("thingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ThingId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("thingName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ThingName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("thingTypeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ThingTypeName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ThingDocumentUnmarshaller _instance = new ThingDocumentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ThingDocumentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}