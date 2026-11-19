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
    /// UpdateSecurityGroupRuleDescriptionsIngress Request Marshaller
    /// </summary>
    public partial class UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller : IMarshaller<IRequest, UpdateSecurityGroupRuleDescriptionsIngressRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSecurityGroupRuleDescriptionsIngressRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateSecurityGroupRuleDescriptionsIngressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "UpdateSecurityGroupRuleDescriptionsIngress");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetGroupId())
            {
                request.Parameters.Add("GroupId", StringUtils.FromString(publicRequest.GroupId));
            }
            if (publicRequest.IsSetGroupName())
            {
                request.Parameters.Add("GroupName", StringUtils.FromString(publicRequest.GroupName));
            }
            if (publicRequest.IsSetIpPermissions())
            {
                if (publicRequest.IpPermissions.Count == 0)
                {
                    request.Parameters.Add("IpPermissions", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.IpPermissions)
                    {
                        if (item0.IsSetFromPort())
                        {
                            request.Parameters.Add("IpPermissions" + "." + index0 + ".FromPort", StringUtils.FromInt(item0.FromPort.Value));
                        }
                        if (item0.IsSetIpProtocol())
                        {
                            request.Parameters.Add("IpPermissions" + "." + index0 + ".IpProtocol", StringUtils.FromString(item0.IpProtocol));
                        }
                        if (item0.IsSetIpv4Ranges())
                        {
                            if (item0.Ipv4Ranges.Count == 0)
                            {
                                request.Parameters.Add("IpPermissions" + "." + index0 + ".IpRanges", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Ipv4Ranges)
                                {
                                    if (item1.IsSetCidrIp())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".IpRanges" + "." + index1 + ".CidrIp", StringUtils.FromString(item1.CidrIp));
                                    }
                                    if (item1.IsSetDescription())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".IpRanges" + "." + index1 + ".Description", StringUtils.FromString(item1.Description));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetIpv6Ranges())
                        {
                            if (item0.Ipv6Ranges.Count == 0)
                            {
                                request.Parameters.Add("IpPermissions" + "." + index0 + ".Ipv6Ranges", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Ipv6Ranges)
                                {
                                    if (item1.IsSetCidrIpv6())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Ipv6Ranges" + "." + index1 + ".CidrIpv6", StringUtils.FromString(item1.CidrIpv6));
                                    }
                                    if (item1.IsSetDescription())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Ipv6Ranges" + "." + index1 + ".Description", StringUtils.FromString(item1.Description));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetPrefixListIds())
                        {
                            if (item0.PrefixListIds.Count == 0)
                            {
                                request.Parameters.Add("IpPermissions" + "." + index0 + ".PrefixListIds", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.PrefixListIds)
                                {
                                    if (item1.IsSetDescription())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".PrefixListIds" + "." + index1 + ".Description", StringUtils.FromString(item1.Description));
                                    }
                                    if (item1.IsSetId())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".PrefixListIds" + "." + index1 + ".PrefixListId", StringUtils.FromString(item1.Id));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetToPort())
                        {
                            request.Parameters.Add("IpPermissions" + "." + index0 + ".ToPort", StringUtils.FromInt(item0.ToPort.Value));
                        }
                        if (item0.IsSetUserIdGroupPairs())
                        {
                            if (item0.UserIdGroupPairs.Count == 0)
                            {
                                request.Parameters.Add("IpPermissions" + "." + index0 + ".Groups", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.UserIdGroupPairs)
                                {
                                    if (item1.IsSetDescription())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Groups" + "." + index1 + ".Description", StringUtils.FromString(item1.Description));
                                    }
                                    if (item1.IsSetGroupId())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Groups" + "." + index1 + ".GroupId", StringUtils.FromString(item1.GroupId));
                                    }
                                    if (item1.IsSetGroupName())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Groups" + "." + index1 + ".GroupName", StringUtils.FromString(item1.GroupName));
                                    }
                                    if (item1.IsSetPeeringStatus())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Groups" + "." + index1 + ".PeeringStatus", StringUtils.FromString(item1.PeeringStatus));
                                    }
                                    if (item1.IsSetUserId())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Groups" + "." + index1 + ".UserId", StringUtils.FromString(item1.UserId));
                                    }
                                    if (item1.IsSetVpcId())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Groups" + "." + index1 + ".VpcId", StringUtils.FromString(item1.VpcId));
                                    }
                                    if (item1.IsSetVpcPeeringConnectionId())
                                    {
                                        request.Parameters.Add("IpPermissions" + "." + index0 + ".Groups" + "." + index1 + ".VpcPeeringConnectionId", StringUtils.FromString(item1.VpcPeeringConnectionId));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSecurityGroupRuleDescriptions())
            {
                if (publicRequest.SecurityGroupRuleDescriptions.Count == 0)
                {
                    request.Parameters.Add("SecurityGroupRuleDescription", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroupRuleDescriptions)
                    {
                        if (item0.IsSetDescription())
                        {
                            request.Parameters.Add("SecurityGroupRuleDescription" + "." + index0 + ".Description", StringUtils.FromString(item0.Description));
                        }
                        if (item0.IsSetSecurityGroupRuleId())
                        {
                            request.Parameters.Add("SecurityGroupRuleDescription" + "." + index0 + ".SecurityGroupRuleId", StringUtils.FromString(item0.SecurityGroupRuleId));
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller _instance = new();

        internal static UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller Instance => _instance;
    }
}
