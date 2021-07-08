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
    /// Response Unmarshaller for NetworkFirewallInvalidRouteConfigurationViolation Object
    /// </summary>  
    public class NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller : IUnmarshaller<NetworkFirewallInvalidRouteConfigurationViolation, XmlUnmarshallerContext>, IUnmarshaller<NetworkFirewallInvalidRouteConfigurationViolation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkFirewallInvalidRouteConfigurationViolation IUnmarshaller<NetworkFirewallInvalidRouteConfigurationViolation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkFirewallInvalidRouteConfigurationViolation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetworkFirewallInvalidRouteConfigurationViolation unmarshalledObject = new NetworkFirewallInvalidRouteConfigurationViolation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActualFirewallEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActualFirewallEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActualFirewallSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActualFirewallSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActualFirewallSubnetRoutes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                    unmarshalledObject.ActualFirewallSubnetRoutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActualInternetGatewayRoutes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                    unmarshalledObject.ActualInternetGatewayRoutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AffectedSubnets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AffectedSubnets = unmarshaller.Unmarshall(context);
                    continue;
                }
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
                if (context.TestExpression("ExpectedFirewallEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpectedFirewallEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedFirewallSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpectedFirewallSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedFirewallSubnetRoutes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExpectedRoute, ExpectedRouteUnmarshaller>(ExpectedRouteUnmarshaller.Instance);
                    unmarshalledObject.ExpectedFirewallSubnetRoutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedInternetGatewayRoutes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExpectedRoute, ExpectedRouteUnmarshaller>(ExpectedRouteUnmarshaller.Instance);
                    unmarshalledObject.ExpectedInternetGatewayRoutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InternetGatewayId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InternetGatewayId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsRouteTableUsedInDifferentAZ", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsRouteTableUsedInDifferentAZ = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RouteTableId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RouteTableId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViolatingRoute", targetDepth))
                {
                    var unmarshaller = RouteUnmarshaller.Instance;
                    unmarshalledObject.ViolatingRoute = unmarshaller.Unmarshall(context);
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


        private static NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller _instance = new NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}