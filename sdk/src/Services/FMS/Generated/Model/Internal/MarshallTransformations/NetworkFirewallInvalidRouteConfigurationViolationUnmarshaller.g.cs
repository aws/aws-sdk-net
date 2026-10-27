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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.FMS.Model;
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
    public partial class NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller : ICborUnmarshaller<NetworkFirewallInvalidRouteConfigurationViolation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public NetworkFirewallInvalidRouteConfigurationViolation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new NetworkFirewallInvalidRouteConfigurationViolation();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "ActualFirewallEndpoint":
                        context.AddPathSegment("ActualFirewallEndpoint");
                        unmarshalledObject.ActualFirewallEndpoint = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActualFirewallSubnetId":
                        context.AddPathSegment("ActualFirewallSubnetId");
                        unmarshalledObject.ActualFirewallSubnetId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActualFirewallSubnetRoutes":
                        context.AddPathSegment("ActualFirewallSubnetRoutes");
                        unmarshalledObject.ActualFirewallSubnetRoutes = new CborListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActualInternetGatewayRoutes":
                        context.AddPathSegment("ActualInternetGatewayRoutes");
                        unmarshalledObject.ActualInternetGatewayRoutes = new CborListUnmarshaller<Route, RouteUnmarshaller>(RouteUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AffectedSubnets":
                        context.AddPathSegment("AffectedSubnets");
                        unmarshalledObject.AffectedSubnets = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CurrentFirewallSubnetRouteTable":
                        context.AddPathSegment("CurrentFirewallSubnetRouteTable");
                        unmarshalledObject.CurrentFirewallSubnetRouteTable = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CurrentInternetGatewayRouteTable":
                        context.AddPathSegment("CurrentInternetGatewayRouteTable");
                        unmarshalledObject.CurrentInternetGatewayRouteTable = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExpectedFirewallEndpoint":
                        context.AddPathSegment("ExpectedFirewallEndpoint");
                        unmarshalledObject.ExpectedFirewallEndpoint = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExpectedFirewallSubnetId":
                        context.AddPathSegment("ExpectedFirewallSubnetId");
                        unmarshalledObject.ExpectedFirewallSubnetId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExpectedFirewallSubnetRoutes":
                        context.AddPathSegment("ExpectedFirewallSubnetRoutes");
                        unmarshalledObject.ExpectedFirewallSubnetRoutes = new CborListUnmarshaller<ExpectedRoute, ExpectedRouteUnmarshaller>(ExpectedRouteUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExpectedInternetGatewayRoutes":
                        context.AddPathSegment("ExpectedInternetGatewayRoutes");
                        unmarshalledObject.ExpectedInternetGatewayRoutes = new CborListUnmarshaller<ExpectedRoute, ExpectedRouteUnmarshaller>(ExpectedRouteUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InternetGatewayId":
                        context.AddPathSegment("InternetGatewayId");
                        unmarshalledObject.InternetGatewayId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IsRouteTableUsedInDifferentAZ":
                        context.AddPathSegment("IsRouteTableUsedInDifferentAZ");
                        unmarshalledObject.IsRouteTableUsedInDifferentAZ = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RouteTableId":
                        context.AddPathSegment("RouteTableId");
                        unmarshalledObject.RouteTableId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ViolatingRoute":
                        context.AddPathSegment("ViolatingRoute");
                        unmarshalledObject.ViolatingRoute = RouteUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcId":
                        context.AddPathSegment("VpcId");
                        unmarshalledObject.VpcId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

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
        public static NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller Instance => _instance;
    }
}
