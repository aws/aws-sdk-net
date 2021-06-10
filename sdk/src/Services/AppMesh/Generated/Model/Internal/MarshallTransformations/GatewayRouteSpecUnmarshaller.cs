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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GatewayRouteSpec Object
    /// </summary>  
    public class GatewayRouteSpecUnmarshaller : IUnmarshaller<GatewayRouteSpec, XmlUnmarshallerContext>, IUnmarshaller<GatewayRouteSpec, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GatewayRouteSpec IUnmarshaller<GatewayRouteSpec, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GatewayRouteSpec Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            GatewayRouteSpec unmarshalledObject = new GatewayRouteSpec();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("grpcRoute", targetDepth))
                {
                    var unmarshaller = GrpcGatewayRouteUnmarshaller.Instance;
                    unmarshalledObject.GrpcRoute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("http2Route", targetDepth))
                {
                    var unmarshaller = HttpGatewayRouteUnmarshaller.Instance;
                    unmarshalledObject.Http2Route = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("httpRoute", targetDepth))
                {
                    var unmarshaller = HttpGatewayRouteUnmarshaller.Instance;
                    unmarshalledObject.HttpRoute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("priority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GatewayRouteSpecUnmarshaller _instance = new GatewayRouteSpecUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GatewayRouteSpecUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}