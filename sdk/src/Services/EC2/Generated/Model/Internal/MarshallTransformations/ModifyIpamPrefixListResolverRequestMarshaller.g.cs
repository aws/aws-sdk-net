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
    /// ModifyIpamPrefixListResolver Request Marshaller
    /// </summary>
    public partial class ModifyIpamPrefixListResolverRequestMarshaller : IMarshaller<IRequest, ModifyIpamPrefixListResolverRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyIpamPrefixListResolverRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyIpamPrefixListResolverRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyIpamPrefixListResolver");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetIpamPrefixListResolverId())
            {
                request.Parameters.Add("IpamPrefixListResolverId", StringUtils.FromString(publicRequest.IpamPrefixListResolverId));
            }
            if (publicRequest.IsSetRules())
            {
                if (publicRequest.Rules.Count == 0)
                {
                    request.Parameters.Add("Rule", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Rules)
                    {
                        if (item0.IsSetConditions())
                        {
                            if (item0.Conditions.Count == 0)
                            {
                                request.Parameters.Add("Rule" + "." + index0 + ".Condition", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Conditions)
                                {
                                    if (item1.IsSetCidr())
                                    {
                                        request.Parameters.Add("Rule" + "." + index0 + ".Condition" + "." + index1 + ".Cidr", StringUtils.FromString(item1.Cidr));
                                    }
                                    if (item1.IsSetIpamPoolId())
                                    {
                                        request.Parameters.Add("Rule" + "." + index0 + ".Condition" + "." + index1 + ".IpamPoolId", StringUtils.FromString(item1.IpamPoolId));
                                    }
                                    if (item1.IsSetOperation())
                                    {
                                        request.Parameters.Add("Rule" + "." + index0 + ".Condition" + "." + index1 + ".Operation", StringUtils.FromString(item1.Operation));
                                    }
                                    if (item1.IsSetResourceId())
                                    {
                                        request.Parameters.Add("Rule" + "." + index0 + ".Condition" + "." + index1 + ".ResourceId", StringUtils.FromString(item1.ResourceId));
                                    }
                                    if (item1.IsSetResourceOwner())
                                    {
                                        request.Parameters.Add("Rule" + "." + index0 + ".Condition" + "." + index1 + ".ResourceOwner", StringUtils.FromString(item1.ResourceOwner));
                                    }
                                    if (item1.IsSetResourceRegion())
                                    {
                                        request.Parameters.Add("Rule" + "." + index0 + ".Condition" + "." + index1 + ".ResourceRegion", StringUtils.FromString(item1.ResourceRegion));
                                    }
                                    if (item1.IsSetResourceTag())
                                    {
                                        if (item1.ResourceTag.IsSetKey())
                                        {
                                            request.Parameters.Add("Rule" + "." + index0 + ".Condition" + "." + index1 + ".ResourceTag" + ".Key", StringUtils.FromString(item1.ResourceTag.Key));
                                        }
                                        if (item1.ResourceTag.IsSetValue())
                                        {
                                            request.Parameters.Add("Rule" + "." + index0 + ".Condition" + "." + index1 + ".ResourceTag" + ".Value", StringUtils.FromString(item1.ResourceTag.Value));
                                        }
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetIpamScopeId())
                        {
                            request.Parameters.Add("Rule" + "." + index0 + ".IpamScopeId", StringUtils.FromString(item0.IpamScopeId));
                        }
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("Rule" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetRuleType())
                        {
                            request.Parameters.Add("Rule" + "." + index0 + ".RuleType", StringUtils.FromString(item0.RuleType));
                        }
                        if (item0.IsSetStaticCidr())
                        {
                            request.Parameters.Add("Rule" + "." + index0 + ".StaticCidr", StringUtils.FromString(item0.StaticCidr));
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

        private static readonly ModifyIpamPrefixListResolverRequestMarshaller _instance = new();

        internal static ModifyIpamPrefixListResolverRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyIpamPrefixListResolverRequestMarshaller Instance => _instance;
    }
}
