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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GatewayInstance Object
    /// </summary>  
    public class GatewayInstanceUnmarshaller : IUnmarshaller<GatewayInstance, XmlUnmarshallerContext>, IUnmarshaller<GatewayInstance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GatewayInstance IUnmarshaller<GatewayInstance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GatewayInstance Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            GatewayInstance unmarshalledObject = new GatewayInstance();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bridgePlacement", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BridgePlacement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gatewayArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gatewayInstanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayInstanceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceMessages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MessageDetail, MessageDetailUnmarshaller>(MessageDetailUnmarshaller.Instance);
                    unmarshalledObject.InstanceMessages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runningBridgeCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RunningBridgeCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GatewayInstanceUnmarshaller _instance = new GatewayInstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GatewayInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}