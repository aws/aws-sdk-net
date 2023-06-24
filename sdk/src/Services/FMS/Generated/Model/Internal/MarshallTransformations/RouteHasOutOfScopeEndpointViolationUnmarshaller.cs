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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RouteHasOutOfScopeEndpointViolation Object
    /// </summary>  
    public class RouteHasOutOfScopeEndpointViolationUnmarshaller : IUnmarshaller<RouteHasOutOfScopeEndpointViolation, XmlUnmarshallerContext>, IUnmarshaller<RouteHasOutOfScopeEndpointViolation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouteHasOutOfScopeEndpointViolation IUnmarshaller<RouteHasOutOfScopeEndpointViolation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RouteHasOutOfScopeEndpointViolation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RouteHasOutOfScopeEndpointViolation unmarshalledObject = new RouteHasOutOfScopeEndpointViolation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrentFirewallSubnetRouteTable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentFirewallSubnetRouteTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentInternetGatewayRouteTable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentInternetGatewayRouteTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallSubnetRoutes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                    unmarshalledObject.FirewallSubnetRoutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InternetGatewayId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InternetGatewayId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InternetGatewayRoutes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                    unmarshalledObject.InternetGatewayRoutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RouteTableId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RouteTableId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetAvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetAvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetAvailabilityZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetAvailabilityZoneId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViolatingRoutes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                    unmarshalledObject.ViolatingRoutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RouteHasOutOfScopeEndpointViolationUnmarshaller _instance = new RouteHasOutOfScopeEndpointViolationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteHasOutOfScopeEndpointViolationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}