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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstancePortState Object
    /// </summary>  
    public class InstancePortStateUnmarshaller : IJsonUnmarshaller<InstancePortState, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InstancePortState Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InstancePortState unmarshalledObject = new InstancePortState();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cidrListAliases", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CidrListAliases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cidrs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Cidrs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fromPort", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FromPort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ipv6Cidrs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ipv6Cidrs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("protocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Protocol = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("toPort", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ToPort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstancePortStateUnmarshaller _instance = new InstancePortStateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstancePortStateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}