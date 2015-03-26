/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplaceRoute Request Marshaller
    /// </summary>       
    public class ReplaceRouteRequestMarshaller : IMarshaller<IRequest, ReplaceRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReplaceRouteRequest)input);
        }
    
        public IRequest Marshall(ReplaceRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ReplaceRoute");
            request.Parameters.Add("Version", "2014-10-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDestinationCidrBlock())
                {
                    request.Parameters.Add("DestinationCidrBlock", StringUtils.FromString(publicRequest.DestinationCidrBlock));
                }
                if(publicRequest.IsSetGatewayId())
                {
                    request.Parameters.Add("GatewayId", StringUtils.FromString(publicRequest.GatewayId));
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetNetworkInterfaceId())
                {
                    request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceId));
                }
                if(publicRequest.IsSetRouteTableId())
                {
                    request.Parameters.Add("RouteTableId", StringUtils.FromString(publicRequest.RouteTableId));
                }
                if(publicRequest.IsSetVpcPeeringConnectionId())
                {
                    request.Parameters.Add("VpcPeeringConnectionId", StringUtils.FromString(publicRequest.VpcPeeringConnectionId));
                }
            }
            return request;
        }
    }
}