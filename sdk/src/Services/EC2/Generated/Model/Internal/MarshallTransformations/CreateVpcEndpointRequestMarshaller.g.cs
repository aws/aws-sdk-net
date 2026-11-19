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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateVpcEndpoint Request Marshaller
    /// </summary>
    public partial class CreateVpcEndpointRequestMarshaller : IMarshaller<IRequest, CreateVpcEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVpcEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateVpcEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateVpcEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetDnsOptions())
            {
                if (publicRequest.DnsOptions.IsSetDnsRecordIpType())
                {
                    request.Parameters.Add("DnsOptions" + ".DnsRecordIpType", StringUtils.FromString(publicRequest.DnsOptions.DnsRecordIpType));
                }
                if (publicRequest.DnsOptions.IsSetPrivateDnsOnlyForInboundResolverEndpoint())
                {
                    request.Parameters.Add("DnsOptions" + ".PrivateDnsOnlyForInboundResolverEndpoint", StringUtils.FromBool(publicRequest.DnsOptions.PrivateDnsOnlyForInboundResolverEndpoint.Value));
                }
                if (publicRequest.DnsOptions.IsSetPrivateDnsPreference())
                {
                    request.Parameters.Add("DnsOptions" + ".PrivateDnsPreference", StringUtils.FromString(publicRequest.DnsOptions.PrivateDnsPreference));
                }
                if (publicRequest.DnsOptions.IsSetPrivateDnsSpecifiedDomains())
                {
                    if (publicRequest.DnsOptions.PrivateDnsSpecifiedDomains.Count == 0)
                    {
                        request.Parameters.Add("DnsOptions" + ".PrivateDnsSpecifiedDomain", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.DnsOptions.PrivateDnsSpecifiedDomains)
                        {
                            request.Parameters.Add("DnsOptions" + ".PrivateDnsSpecifiedDomain" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetIpAddressType())
            {
                request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
            }
            if (publicRequest.IsSetPolicyDocument())
            {
                request.Parameters.Add("PolicyDocument", StringUtils.FromString(publicRequest.PolicyDocument));
            }
            if (publicRequest.IsSetPrivateDnsEnabled())
            {
                request.Parameters.Add("PrivateDnsEnabled", StringUtils.FromBool(publicRequest.PrivateDnsEnabled.Value));
            }
            if (publicRequest.IsSetResourceConfigurationArn())
            {
                request.Parameters.Add("ResourceConfigurationArn", StringUtils.FromString(publicRequest.ResourceConfigurationArn));
            }
            if (publicRequest.IsSetRouteTableIds())
            {
                if (publicRequest.RouteTableIds.Count == 0)
                {
                    request.Parameters.Add("RouteTableId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RouteTableIds)
                    {
                        request.Parameters.Add("RouteTableId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSecurityGroupIds())
            {
                if (publicRequest.SecurityGroupIds.Count == 0)
                {
                    request.Parameters.Add("SecurityGroupId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetServiceName())
            {
                request.Parameters.Add("ServiceName", StringUtils.FromString(publicRequest.ServiceName));
            }
            if (publicRequest.IsSetServiceNetworkArn())
            {
                request.Parameters.Add("ServiceNetworkArn", StringUtils.FromString(publicRequest.ServiceNetworkArn));
            }
            if (publicRequest.IsSetServiceRegion())
            {
                request.Parameters.Add("ServiceRegion", StringUtils.FromString(publicRequest.ServiceRegion));
            }
            if (publicRequest.IsSetSubnetConfigurations())
            {
                if (publicRequest.SubnetConfigurations.Count == 0)
                {
                    request.Parameters.Add("SubnetConfiguration", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SubnetConfigurations)
                    {
                        if (item0.IsSetIpv4())
                        {
                            request.Parameters.Add("SubnetConfiguration" + "." + index0 + ".Ipv4", StringUtils.FromString(item0.Ipv4));
                        }
                        if (item0.IsSetIpv6())
                        {
                            request.Parameters.Add("SubnetConfiguration" + "." + index0 + ".Ipv6", StringUtils.FromString(item0.Ipv6));
                        }
                        if (item0.IsSetSubnetId())
                        {
                            request.Parameters.Add("SubnetConfiguration" + "." + index0 + ".SubnetId", StringUtils.FromString(item0.SubnetId));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSubnetIds())
            {
                if (publicRequest.SubnetIds.Count == 0)
                {
                    request.Parameters.Add("SubnetId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SubnetIds)
                    {
                        request.Parameters.Add("SubnetId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetVpcEndpointType())
            {
                request.Parameters.Add("VpcEndpointType", StringUtils.FromString(publicRequest.VpcEndpointType));
            }
            if (publicRequest.IsSetVpcId())
            {
                request.Parameters.Add("VpcId", StringUtils.FromString(publicRequest.VpcId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateVpcEndpointRequestMarshaller _instance = new();

        internal static CreateVpcEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateVpcEndpointRequestMarshaller Instance => _instance;
    }
}
