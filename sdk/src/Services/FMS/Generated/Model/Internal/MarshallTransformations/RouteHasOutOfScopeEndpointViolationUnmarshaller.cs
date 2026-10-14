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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RouteHasOutOfScopeEndpointViolation Object
    /// </summary>  
    public class RouteHasOutOfScopeEndpointViolationUnmarshaller : ICborUnmarshaller<RouteHasOutOfScopeEndpointViolation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteHasOutOfScopeEndpointViolation Unmarshall(CborUnmarshallerContext context)
        {
            RouteHasOutOfScopeEndpointViolation unmarshalledObject = new RouteHasOutOfScopeEndpointViolation();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "CurrentFirewallSubnetRouteTable":
                        {
                            context.AddPathSegment("CurrentFirewallSubnetRouteTable");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentFirewallSubnetRouteTable = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CurrentInternetGatewayRouteTable":
                        {
                            context.AddPathSegment("CurrentInternetGatewayRouteTable");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentInternetGatewayRouteTable = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FirewallSubnetId":
                        {
                            context.AddPathSegment("FirewallSubnetId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FirewallSubnetId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FirewallSubnetRoutes":
                        {
                            context.AddPathSegment("FirewallSubnetRoutes");
                            var unmarshaller = new CborListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                            unmarshalledObject.FirewallSubnetRoutes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InternetGatewayId":
                        {
                            context.AddPathSegment("InternetGatewayId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InternetGatewayId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InternetGatewayRoutes":
                        {
                            context.AddPathSegment("InternetGatewayRoutes");
                            var unmarshaller = new CborListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                            unmarshalledObject.InternetGatewayRoutes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RouteTableId":
                        {
                            context.AddPathSegment("RouteTableId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RouteTableId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SubnetAvailabilityZone":
                        {
                            context.AddPathSegment("SubnetAvailabilityZone");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SubnetAvailabilityZone = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SubnetAvailabilityZoneId":
                        {
                            context.AddPathSegment("SubnetAvailabilityZoneId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SubnetAvailabilityZoneId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SubnetId":
                        {
                            context.AddPathSegment("SubnetId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ViolatingRoutes":
                        {
                            context.AddPathSegment("ViolatingRoutes");
                            var unmarshaller = new CborListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                            unmarshalledObject.ViolatingRoutes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VpcId":
                        {
                            context.AddPathSegment("VpcId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
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