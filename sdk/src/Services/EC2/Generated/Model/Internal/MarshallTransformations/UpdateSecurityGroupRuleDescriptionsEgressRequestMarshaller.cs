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
    /// UpdateSecurityGroupRuleDescriptionsEgress Request Marshaller
    /// </summary>       
    public class UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller : IMarshaller<IRequest, UpdateSecurityGroupRuleDescriptionsEgressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSecurityGroupRuleDescriptionsEgressRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSecurityGroupRuleDescriptionsEgressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "UpdateSecurityGroupRuleDescriptionsEgress");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetGroupId())
                {
                    request.Parameters.Add("GroupId", StringUtils.FromString(publicRequest.GroupId));
                }
                if(publicRequest.IsSetGroupName())
                {
                    request.Parameters.Add("GroupName", StringUtils.FromString(publicRequest.GroupName));
                }
                if(publicRequest.IsSetIpPermissions())
                {
                    if (publicRequest.IpPermissions.Count == 0)
                        request.Parameters.Add("IpPermissions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.IpPermissions)
                         {
                            if(publicRequestlistValue.IsSetFromPort())
                            {
                                request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "FromPort", StringUtils.FromInt(publicRequestlistValue.FromPort));
                            }
                            if(publicRequestlistValue.IsSetIpProtocol())
                            {
                                request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpProtocol", StringUtils.FromString(publicRequestlistValue.IpProtocol));
                            }
                            if(publicRequestlistValue.IsSetIpv4Ranges())
                            {
                                if (publicRequestlistValue.Ipv4Ranges.Count == 0)
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpRanges", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv4Ranges)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetCidrIp())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpRanges" + "." + publicRequestlistValuelistValueIndex + "." + "CidrIp", StringUtils.FromString(publicRequestlistValuelistValue.CidrIp));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetDescription())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpRanges" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetIpv6Ranges())
                            {
                                if (publicRequestlistValue.Ipv6Ranges.Count == 0)
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Ipv6Ranges", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv6Ranges)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetCidrIpv6())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Ipv6Ranges" + "." + publicRequestlistValuelistValueIndex + "." + "CidrIpv6", StringUtils.FromString(publicRequestlistValuelistValue.CidrIpv6));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetDescription())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Ipv6Ranges" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetPrefixListIds())
                            {
                                if (publicRequestlistValue.PrefixListIds.Count == 0)
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "PrefixListIds", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PrefixListIds)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetDescription())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "PrefixListIds" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetId())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "PrefixListIds" + "." + publicRequestlistValuelistValueIndex + "." + "PrefixListId", StringUtils.FromString(publicRequestlistValuelistValue.Id));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetToPort())
                            {
                                request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "ToPort", StringUtils.FromInt(publicRequestlistValue.ToPort));
                            }
                            if(publicRequestlistValue.IsSetUserIdGroupPairs())
                            {
                                if (publicRequestlistValue.UserIdGroupPairs.Count == 0)
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.UserIdGroupPairs)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetDescription())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetGroupId())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "GroupId", StringUtils.FromString(publicRequestlistValuelistValue.GroupId));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetGroupName())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "GroupName", StringUtils.FromString(publicRequestlistValuelistValue.GroupName));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetPeeringStatus())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "PeeringStatus", StringUtils.FromString(publicRequestlistValuelistValue.PeeringStatus));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetUserId())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestlistValuelistValue.UserId));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetVpcId())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "VpcId", StringUtils.FromString(publicRequestlistValuelistValue.VpcId));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetVpcPeeringConnectionId())
                                        {
                                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "VpcPeeringConnectionId", StringUtils.FromString(publicRequestlistValuelistValue.VpcPeeringConnectionId));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSecurityGroupRuleDescriptions())
                {
                    if (publicRequest.SecurityGroupRuleDescriptions.Count == 0)
                        request.Parameters.Add("SecurityGroupRuleDescription", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroupRuleDescriptions)
                         {
                            if(publicRequestlistValue.IsSetDescription())
                            {
                                request.Parameters.Add("SecurityGroupRuleDescription" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                            }
                            if(publicRequestlistValue.IsSetSecurityGroupRuleId())
                            {
                                request.Parameters.Add("SecurityGroupRuleDescription" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRuleId", StringUtils.FromString(publicRequestlistValue.SecurityGroupRuleId));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller _instance = new UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller();        

        internal static UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}