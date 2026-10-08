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
    /// Response Unmarshaller for NetworkFirewallUnexpectedGatewayRoutesViolation Object
    /// </summary>  
    public class NetworkFirewallUnexpectedGatewayRoutesViolationUnmarshaller : ICborUnmarshaller<NetworkFirewallUnexpectedGatewayRoutesViolation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NetworkFirewallUnexpectedGatewayRoutesViolation Unmarshall(CborUnmarshallerContext context)
        {
            NetworkFirewallUnexpectedGatewayRoutesViolation unmarshalledObject = new NetworkFirewallUnexpectedGatewayRoutesViolation();
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
                    case "GatewayId":
                        {
                            context.AddPathSegment("GatewayId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GatewayId = unmarshaller.Unmarshall(context);
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


        private static NetworkFirewallUnexpectedGatewayRoutesViolationUnmarshaller _instance = new NetworkFirewallUnexpectedGatewayRoutesViolationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkFirewallUnexpectedGatewayRoutesViolationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}