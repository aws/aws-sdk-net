/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Replace Route Request Marshaller
    /// </summary>       
    public class ReplaceRouteRequestMarshaller : IMarshaller<IRequest, ReplaceRouteRequest>
    {
        public IRequest Marshall(ReplaceRouteRequest replaceRouteRequest)
        {
            IRequest request = new DefaultRequest(replaceRouteRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ReplaceRoute");
            request.Parameters.Add("Version", "2013-10-15");
            if (replaceRouteRequest != null && replaceRouteRequest.IsSetRouteTableId())
            {
                request.Parameters.Add("RouteTableId", StringUtils.FromString(replaceRouteRequest.RouteTableId));
            }
            if (replaceRouteRequest != null && replaceRouteRequest.IsSetDestinationCidrBlock())
            {
                request.Parameters.Add("DestinationCidrBlock", StringUtils.FromString(replaceRouteRequest.DestinationCidrBlock));
            }
            if (replaceRouteRequest != null && replaceRouteRequest.IsSetGatewayId())
            {
                request.Parameters.Add("GatewayId", StringUtils.FromString(replaceRouteRequest.GatewayId));
            }
            if (replaceRouteRequest != null && replaceRouteRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(replaceRouteRequest.InstanceId));
            }
            if (replaceRouteRequest != null && replaceRouteRequest.IsSetNetworkInterfaceId())
            {
                request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(replaceRouteRequest.NetworkInterfaceId));
            }

            return request;
        }
    }
}
