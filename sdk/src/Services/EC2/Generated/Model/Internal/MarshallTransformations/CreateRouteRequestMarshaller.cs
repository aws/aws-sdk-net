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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// CreateRoute Request Marshaller
    /// </summary>       
    public class CreateRouteRequestMarshaller : IMarshaller<IRequest, CreateRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRouteRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateRoute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCarrierGatewayId())
                {
                    request.Parameters.Add("CarrierGatewayId", StringUtils.FromString(publicRequest.CarrierGatewayId));
                }
                if(publicRequest.IsSetDestinationCidrBlock())
                {
                    request.Parameters.Add("DestinationCidrBlock", StringUtils.FromString(publicRequest.DestinationCidrBlock));
                }
                if(publicRequest.IsSetDestinationIpv6CidrBlock())
                {
                    request.Parameters.Add("DestinationIpv6CidrBlock", StringUtils.FromString(publicRequest.DestinationIpv6CidrBlock));
                }
                if(publicRequest.IsSetDestinationPrefixListId())
                {
                    request.Parameters.Add("DestinationPrefixListId", StringUtils.FromString(publicRequest.DestinationPrefixListId));
                }
                if(publicRequest.IsSetEgressOnlyInternetGatewayId())
                {
                    request.Parameters.Add("EgressOnlyInternetGatewayId", StringUtils.FromString(publicRequest.EgressOnlyInternetGatewayId));
                }
                if(publicRequest.IsSetGatewayId())
                {
                    request.Parameters.Add("GatewayId", StringUtils.FromString(publicRequest.GatewayId));
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetLocalGatewayId())
                {
                    request.Parameters.Add("LocalGatewayId", StringUtils.FromString(publicRequest.LocalGatewayId));
                }
                if(publicRequest.IsSetNatGatewayId())
                {
                    request.Parameters.Add("NatGatewayId", StringUtils.FromString(publicRequest.NatGatewayId));
                }
                if(publicRequest.IsSetNetworkInterfaceId())
                {
                    request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceId));
                }
                if(publicRequest.IsSetRouteTableId())
                {
                    request.Parameters.Add("RouteTableId", StringUtils.FromString(publicRequest.RouteTableId));
                }
                if(publicRequest.IsSetTransitGatewayId())
                {
                    request.Parameters.Add("TransitGatewayId", StringUtils.FromString(publicRequest.TransitGatewayId));
                }
                if(publicRequest.IsSetVpcEndpointId())
                {
                    request.Parameters.Add("VpcEndpointId", StringUtils.FromString(publicRequest.VpcEndpointId));
                }
                if(publicRequest.IsSetVpcPeeringConnectionId())
                {
                    request.Parameters.Add("VpcPeeringConnectionId", StringUtils.FromString(publicRequest.VpcPeeringConnectionId));
                }
            }
            return request;
        }
                    private static CreateRouteRequestMarshaller _instance = new CreateRouteRequestMarshaller();        

        internal static CreateRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}