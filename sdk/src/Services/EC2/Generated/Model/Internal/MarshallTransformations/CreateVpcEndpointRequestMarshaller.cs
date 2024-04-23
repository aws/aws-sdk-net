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
    /// CreateVpcEndpoint Request Marshaller
    /// </summary>       
    public class CreateVpcEndpointRequestMarshaller : IMarshaller<IRequest, CreateVpcEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVpcEndpointRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVpcEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateVpcEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDnsOptions())
                {
                    if(publicRequest.DnsOptions.IsSetDnsRecordIpType())
                    {
                        request.Parameters.Add("DnsOptions" + "." + "DnsRecordIpType", StringUtils.FromString(publicRequest.DnsOptions.DnsRecordIpType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DnsOptions.IsSetPrivateDnsOnlyForInboundResolverEndpoint())
                    {
                        request.Parameters.Add("DnsOptions" + "." + "PrivateDnsOnlyForInboundResolverEndpoint", StringUtils.FromBool(publicRequest.DnsOptions.PrivateDnsOnlyForInboundResolverEndpoint));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIpAddressType())
                {
                    request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPolicyDocument())
                {
                    request.Parameters.Add("PolicyDocument", StringUtils.FromString(publicRequest.PolicyDocument));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPrivateDnsEnabled())
                {
                    request.Parameters.Add("PrivateDnsEnabled", StringUtils.FromBool(publicRequest.PrivateDnsEnabled));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRouteTableIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.RouteTableIds)
                    {
                        request.Parameters.Add("RouteTableId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetServiceName())
                {
                    request.Parameters.Add("ServiceName", StringUtils.FromString(publicRequest.ServiceName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSubnetConfigurations())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SubnetConfigurations)
                    {
                        if(publicRequestlistValue.IsSetIpv4())
                        {
                            request.Parameters.Add("SubnetConfiguration" + "." + publicRequestlistValueIndex + "." + "Ipv4", StringUtils.FromString(publicRequestlistValue.Ipv4));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv6())
                        {
                            request.Parameters.Add("SubnetConfiguration" + "." + publicRequestlistValueIndex + "." + "Ipv6", StringUtils.FromString(publicRequestlistValue.Ipv6));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetSubnetId())
                        {
                            request.Parameters.Add("SubnetConfiguration" + "." + publicRequestlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValue.SubnetId));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSubnetIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SubnetIds)
                    {
                        request.Parameters.Add("SubnetId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVpcEndpointType())
                {
                    request.Parameters.Add("VpcEndpointType", StringUtils.FromString(publicRequest.VpcEndpointType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVpcId())
                {
                    request.Parameters.Add("VpcId", StringUtils.FromString(publicRequest.VpcId));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static CreateVpcEndpointRequestMarshaller _instance = new CreateVpcEndpointRequestMarshaller();        

        internal static CreateVpcEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVpcEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}