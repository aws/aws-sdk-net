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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceConnectService Object
    /// </summary>  
    public class ServiceConnectServiceUnmarshaller : IUnmarshaller<ServiceConnectService, XmlUnmarshallerContext>, IUnmarshaller<ServiceConnectService, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceConnectService IUnmarshaller<ServiceConnectService, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServiceConnectService Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ServiceConnectService unmarshalledObject = new ServiceConnectService();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("clientAliases", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServiceConnectClientAlias, ServiceConnectClientAliasUnmarshaller>(ServiceConnectClientAliasUnmarshaller.Instance);
                    unmarshalledObject.ClientAliases = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("discoveryName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DiscoveryName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ingressPortOverride", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.IngressPortOverride = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PortName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ServiceConnectServiceUnmarshaller _instance = new ServiceConnectServiceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceConnectServiceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}