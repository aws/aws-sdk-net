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
    /// Response Unmarshaller for EC2CreateRouteAction Object
    /// </summary>  
    public class EC2CreateRouteActionUnmarshaller : ICborUnmarshaller<EC2CreateRouteAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EC2CreateRouteAction Unmarshall(CborUnmarshallerContext context)
        {
            EC2CreateRouteAction unmarshalledObject = new EC2CreateRouteAction();
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
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DestinationCidrBlock":
                        {
                            context.AddPathSegment("DestinationCidrBlock");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DestinationCidrBlock = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DestinationIpv6CidrBlock":
                        {
                            context.AddPathSegment("DestinationIpv6CidrBlock");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DestinationIpv6CidrBlock = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DestinationPrefixListId":
                        {
                            context.AddPathSegment("DestinationPrefixListId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DestinationPrefixListId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GatewayId":
                        {
                            context.AddPathSegment("GatewayId");
                            var unmarshaller = ActionTargetUnmarshaller.Instance;
                            unmarshalledObject.GatewayId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RouteTableId":
                        {
                            context.AddPathSegment("RouteTableId");
                            var unmarshaller = ActionTargetUnmarshaller.Instance;
                            unmarshalledObject.RouteTableId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VpcEndpointId":
                        {
                            context.AddPathSegment("VpcEndpointId");
                            var unmarshaller = ActionTargetUnmarshaller.Instance;
                            unmarshalledObject.VpcEndpointId = unmarshaller.Unmarshall(context);
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


        private static EC2CreateRouteActionUnmarshaller _instance = new EC2CreateRouteActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EC2CreateRouteActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}