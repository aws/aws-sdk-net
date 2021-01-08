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
    /// Response Unmarshaller for RouteSpec Object
    /// </summary>  
    public class RouteSpecUnmarshaller : IUnmarshaller<RouteSpec, XmlUnmarshallerContext>, IUnmarshaller<RouteSpec, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouteSpec IUnmarshaller<RouteSpec, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RouteSpec Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RouteSpec unmarshalledObject = new RouteSpec();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("grpcRoute", targetDepth))
                {
                    var unmarshaller = GrpcRouteUnmarshaller.Instance;
                    unmarshalledObject.GrpcRoute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("http2Route", targetDepth))
                {
                    var unmarshaller = HttpRouteUnmarshaller.Instance;
                    unmarshalledObject.Http2Route = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("httpRoute", targetDepth))
                {
                    var unmarshaller = HttpRouteUnmarshaller.Instance;
                    unmarshalledObject.HttpRoute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("priority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tcpRoute", targetDepth))
                {
                    var unmarshaller = TcpRouteUnmarshaller.Instance;
                    unmarshalledObject.TcpRoute = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RouteSpecUnmarshaller _instance = new RouteSpecUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteSpecUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}