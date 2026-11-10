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
    /// ModifyVpcEndpoint Request Marshaller
    /// </summary>
    public partial class ModifyVpcEndpointRequestMarshaller : IMarshaller<IRequest, ModifyVpcEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpcEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyVpcEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyVpcEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAddRouteTableIds())
            {
                if (publicRequest.AddRouteTableIds.Count == 0)
                {
                    request.Parameters.Add("AddRouteTableId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AddRouteTableIds)
                    {
                        request.Parameters.Add("AddRouteTableId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetAddSecurityGroupIds())
            {
                if (publicRequest.AddSecurityGroupIds.Count == 0)
                {
                    request.Parameters.Add("AddSecurityGroupId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AddSecurityGroupIds)
                    {
                        request.Parameters.Add("AddSecurityGroupId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetAddSubnetIds())
            {
                if (publicRequest.AddSubnetIds.Count == 0)
                {
                    request.Parameters.Add("AddSubnetId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AddSubnetIds)
                    {
                        request.Parameters.Add("AddSubnetId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
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
            if (publicRequest.IsSetRemoveRouteTableIds())
            {
                if (publicRequest.RemoveRouteTableIds.Count == 0)
                {
                    request.Parameters.Add("RemoveRouteTableId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RemoveRouteTableIds)
                    {
                        request.Parameters.Add("RemoveRouteTableId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetRemoveSecurityGroupIds())
            {
                if (publicRequest.RemoveSecurityGroupIds.Count == 0)
                {
                    request.Parameters.Add("RemoveSecurityGroupId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RemoveSecurityGroupIds)
                    {
                        request.Parameters.Add("RemoveSecurityGroupId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetRemoveSubnetIds())
            {
                if (publicRequest.RemoveSubnetIds.Count == 0)
                {
                    request.Parameters.Add("RemoveSubnetId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RemoveSubnetIds)
                    {
                        request.Parameters.Add("RemoveSubnetId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetResetPolicy())
            {
                request.Parameters.Add("ResetPolicy", StringUtils.FromBool(publicRequest.ResetPolicy.Value));
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
            if (publicRequest.IsSetVpcEndpointId())
            {
                request.Parameters.Add("VpcEndpointId", StringUtils.FromString(publicRequest.VpcEndpointId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyVpcEndpointRequestMarshaller _instance = new();

        internal static ModifyVpcEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyVpcEndpointRequestMarshaller Instance => _instance;
    }
}
