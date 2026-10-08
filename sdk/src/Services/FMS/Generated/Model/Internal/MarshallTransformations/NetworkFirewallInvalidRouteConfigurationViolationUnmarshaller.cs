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
    /// Response Unmarshaller for NetworkFirewallInvalidRouteConfigurationViolation Object
    /// </summary>  
    public class NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller : ICborUnmarshaller<NetworkFirewallInvalidRouteConfigurationViolation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NetworkFirewallInvalidRouteConfigurationViolation Unmarshall(CborUnmarshallerContext context)
        {
            NetworkFirewallInvalidRouteConfigurationViolation unmarshalledObject = new NetworkFirewallInvalidRouteConfigurationViolation();
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
                    case "ActualFirewallEndpoint":
                        {
                            context.AddPathSegment("ActualFirewallEndpoint");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ActualFirewallEndpoint = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActualFirewallSubnetId":
                        {
                            context.AddPathSegment("ActualFirewallSubnetId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ActualFirewallSubnetId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActualFirewallSubnetRoutes":
                        {
                            context.AddPathSegment("ActualFirewallSubnetRoutes");
                            var unmarshaller = new CborListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                            unmarshalledObject.ActualFirewallSubnetRoutes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActualInternetGatewayRoutes":
                        {
                            context.AddPathSegment("ActualInternetGatewayRoutes");
                            var unmarshaller = new CborListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance);
                            unmarshalledObject.ActualInternetGatewayRoutes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AffectedSubnets":
                        {
                            context.AddPathSegment("AffectedSubnets");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.AffectedSubnets = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
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
                    case "ExpectedFirewallEndpoint":
                        {
                            context.AddPathSegment("ExpectedFirewallEndpoint");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ExpectedFirewallEndpoint = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ExpectedFirewallSubnetId":
                        {
                            context.AddPathSegment("ExpectedFirewallSubnetId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ExpectedFirewallSubnetId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ExpectedFirewallSubnetRoutes":
                        {
                            context.AddPathSegment("ExpectedFirewallSubnetRoutes");
                            var unmarshaller = new CborListUnmarshaller<ExpectedRoute, ExpectedRouteUnmarshaller>(ExpectedRouteUnmarshaller.Instance);
                            unmarshalledObject.ExpectedFirewallSubnetRoutes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ExpectedInternetGatewayRoutes":
                        {
                            context.AddPathSegment("ExpectedInternetGatewayRoutes");
                            var unmarshaller = new CborListUnmarshaller<ExpectedRoute, ExpectedRouteUnmarshaller>(ExpectedRouteUnmarshaller.Instance);
                            unmarshalledObject.ExpectedInternetGatewayRoutes = unmarshaller.Unmarshall(context);
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
                    case "IsRouteTableUsedInDifferentAZ":
                        {
                            context.AddPathSegment("IsRouteTableUsedInDifferentAZ");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.IsRouteTableUsedInDifferentAZ = unmarshaller.Unmarshall(context);
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
                    case "ViolatingRoute":
                        {
                            context.AddPathSegment("ViolatingRoute");
                            var unmarshaller = RouteUnmarshaller.Instance;
                            unmarshalledObject.ViolatingRoute = unmarshaller.Unmarshall(context);
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