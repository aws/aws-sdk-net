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
    /// Response Unmarshaller for Gateway Object
    /// </summary>  
    public class GatewayUnmarshaller : IUnmarshaller<Gateway, XmlUnmarshallerContext>, IUnmarshaller<Gateway, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Gateway IUnmarshaller<Gateway, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Gateway Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Gateway unmarshalledObject = new Gateway();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("egressCidrBlocks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EgressCidrBlocks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gatewayArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gatewayMessages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MessageDetail, MessageDetailUnmarshaller>(MessageDetailUnmarshaller.Instance);
                    unmarshalledObject.GatewayMessages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gatewayState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GatewayNetwork, GatewayNetworkUnmarshaller>(GatewayNetworkUnmarshaller.Instance);
                    unmarshalledObject.Networks = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GatewayUnmarshaller _instance = new GatewayUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GatewayUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}