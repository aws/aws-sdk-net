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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplaceRoute Request Marshaller
    /// </summary>       
    public class ReplaceRouteRequestMarshaller : IMarshaller<IRequest, ReplaceRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReplaceRouteRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReplaceRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ReplaceRoute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCarrierGatewayId())
                {
                    request.Parameters.Add("CarrierGatewayId", StringUtils.FromString(publicRequest.CarrierGatewayId));
                }
                if(publicRequest.IsSetCoreNetworkArn())
                {
                    request.Parameters.Add("CoreNetworkArn", StringUtils.FromString(publicRequest.CoreNetworkArn));
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
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
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
                if(publicRequest.IsSetLocalTarget())
                {
                    request.Parameters.Add("LocalTarget", StringUtils.FromBool(publicRequest.LocalTarget));
                }
                if(publicRequest.IsSetNatGatewayId())
                {
                    request.Parameters.Add("NatGatewayId", StringUtils.FromString(publicRequest.NatGatewayId));
                }
                if(publicRequest.IsSetNetworkInterfaceId())
                {
                    request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceId));
                }
                if(publicRequest.IsSetOdbNetworkArn())
                {
                    request.Parameters.Add("OdbNetworkArn", StringUtils.FromString(publicRequest.OdbNetworkArn));
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
                    private static ReplaceRouteRequestMarshaller _instance = new ReplaceRouteRequestMarshaller();        

        internal static ReplaceRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplaceRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}