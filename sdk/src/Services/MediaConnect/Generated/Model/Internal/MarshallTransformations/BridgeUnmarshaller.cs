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
    /// Response Unmarshaller for Bridge Object
    /// </summary>  
    public class BridgeUnmarshaller : IUnmarshaller<Bridge, XmlUnmarshallerContext>, IUnmarshaller<Bridge, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Bridge IUnmarshaller<Bridge, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Bridge Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Bridge unmarshalledObject = new Bridge();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bridgeArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BridgeArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bridgeMessages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MessageDetail, MessageDetailUnmarshaller>(MessageDetailUnmarshaller.Instance);
                    unmarshalledObject.BridgeMessages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bridgeState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BridgeState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("egressGatewayBridge", targetDepth))
                {
                    var unmarshaller = EgressGatewayBridgeUnmarshaller.Instance;
                    unmarshalledObject.EgressGatewayBridge = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ingressGatewayBridge", targetDepth))
                {
                    var unmarshaller = IngressGatewayBridgeUnmarshaller.Instance;
                    unmarshalledObject.IngressGatewayBridge = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BridgeOutput, BridgeOutputUnmarshaller>(BridgeOutputUnmarshaller.Instance);
                    unmarshalledObject.Outputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("placementArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlacementArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceFailoverConfig", targetDepth))
                {
                    var unmarshaller = FailoverConfigUnmarshaller.Instance;
                    unmarshalledObject.SourceFailoverConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BridgeSource, BridgeSourceUnmarshaller>(BridgeSourceUnmarshaller.Instance);
                    unmarshalledObject.Sources = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BridgeUnmarshaller _instance = new BridgeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BridgeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}