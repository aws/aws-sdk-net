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
    /// ModifySecurityGroupRules Request Marshaller
    /// </summary>
    public partial class ModifySecurityGroupRulesRequestMarshaller : IMarshaller<IRequest, ModifySecurityGroupRulesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifySecurityGroupRulesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifySecurityGroupRulesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifySecurityGroupRules");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetGroupId())
            {
                request.Parameters.Add("GroupId", StringUtils.FromString(publicRequest.GroupId));
            }
            if (publicRequest.IsSetSecurityGroupRules())
            {
                if (publicRequest.SecurityGroupRules.Count == 0)
                {
                    request.Parameters.Add("SecurityGroupRule", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroupRules)
                    {
                        if (item0.IsSetSecurityGroupRule())
                        {
                            if (item0.SecurityGroupRule.IsSetCidrIpv4())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRule" + ".CidrIpv4", StringUtils.FromString(item0.SecurityGroupRule.CidrIpv4));
                            }
                            if (item0.SecurityGroupRule.IsSetCidrIpv6())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRule" + ".CidrIpv6", StringUtils.FromString(item0.SecurityGroupRule.CidrIpv6));
                            }
                            if (item0.SecurityGroupRule.IsSetDescription())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRule" + ".Description", StringUtils.FromString(item0.SecurityGroupRule.Description));
                            }
                            if (item0.SecurityGroupRule.IsSetFromPort())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRule" + ".FromPort", StringUtils.FromInt(item0.SecurityGroupRule.FromPort.Value));
                            }
                            if (item0.SecurityGroupRule.IsSetIpProtocol())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRule" + ".IpProtocol", StringUtils.FromString(item0.SecurityGroupRule.IpProtocol));
                            }
                            if (item0.SecurityGroupRule.IsSetPrefixListId())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRule" + ".PrefixListId", StringUtils.FromString(item0.SecurityGroupRule.PrefixListId));
                            }
                            if (item0.SecurityGroupRule.IsSetReferencedGroupId())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRule" + ".ReferencedGroupId", StringUtils.FromString(item0.SecurityGroupRule.ReferencedGroupId));
                            }
                            if (item0.SecurityGroupRule.IsSetToPort())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRule" + ".ToPort", StringUtils.FromInt(item0.SecurityGroupRule.ToPort.Value));
                            }
                        }
                        if (item0.IsSetSecurityGroupRuleId())
                        {
                            request.Parameters.Add("SecurityGroupRule" + "." + index0 + ".SecurityGroupRuleId", StringUtils.FromString(item0.SecurityGroupRuleId));
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

        private static readonly ModifySecurityGroupRulesRequestMarshaller _instance = new();

        internal static ModifySecurityGroupRulesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifySecurityGroupRulesRequestMarshaller Instance => _instance;
    }
}
