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

using Amazon.IdentityManagement.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimulatePrincipalPolicy Request Marshaller
    /// </summary>
    public partial class SimulatePrincipalPolicyRequestMarshaller : IMarshaller<IRequest, SimulatePrincipalPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SimulatePrincipalPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SimulatePrincipalPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SimulatePrincipalPolicy");
            request.Parameters.Add("Version", "2010-05-08");

            if (publicRequest.IsSetActionNames())
            {
                if (publicRequest.ActionNames.Count == 0)
                {
                    request.Parameters.Add("ActionNames", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ActionNames)
                    {
                        request.Parameters.Add("ActionNames" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetCallerArn())
            {
                request.Parameters.Add("CallerArn", StringUtils.FromString(publicRequest.CallerArn));
            }
            if (publicRequest.IsSetContextEntries())
            {
                if (publicRequest.ContextEntries.Count == 0)
                {
                    request.Parameters.Add("ContextEntries", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ContextEntries)
                    {
                        if (item0.IsSetContextKeyName())
                        {
                            request.Parameters.Add("ContextEntries" + ".member" + "." + index0 + ".ContextKeyName", StringUtils.FromString(item0.ContextKeyName));
                        }
                        if (item0.IsSetContextKeyType())
                        {
                            request.Parameters.Add("ContextEntries" + ".member" + "." + index0 + ".ContextKeyType", StringUtils.FromString(item0.ContextKeyType));
                        }
                        if (item0.IsSetContextKeyValues())
                        {
                            if (item0.ContextKeyValues.Count == 0)
                            {
                                request.Parameters.Add("ContextEntries" + ".member" + "." + index0 + ".ContextKeyValues", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ContextKeyValues)
                                {
                                    request.Parameters.Add("ContextEntries" + ".member" + "." + index0 + ".ContextKeyValues" + ".member" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            }
            if (publicRequest.IsSetMaxItems())
            {
                request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems.Value));
            }
            if (publicRequest.IsSetPermissionsBoundaryPolicyInputList())
            {
                if (publicRequest.PermissionsBoundaryPolicyInputList.Count == 0)
                {
                    request.Parameters.Add("PermissionsBoundaryPolicyInputList", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PermissionsBoundaryPolicyInputList)
                    {
                        request.Parameters.Add("PermissionsBoundaryPolicyInputList" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPolicyExclusionList())
            {
                if (publicRequest.PolicyExclusionList.Count == 0)
                {
                    request.Parameters.Add("PolicyExclusionList", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PolicyExclusionList)
                    {
                        if (item0.IsSetInlinePolicyIdentifier())
                        {
                            if (item0.InlinePolicyIdentifier.IsSetAttachmentName())
                            {
                                request.Parameters.Add("PolicyExclusionList" + ".member" + "." + index0 + ".InlinePolicyIdentifier" + ".AttachmentName", StringUtils.FromString(item0.InlinePolicyIdentifier.AttachmentName));
                            }
                            if (item0.InlinePolicyIdentifier.IsSetAttachmentType())
                            {
                                request.Parameters.Add("PolicyExclusionList" + ".member" + "." + index0 + ".InlinePolicyIdentifier" + ".AttachmentType", StringUtils.FromString(item0.InlinePolicyIdentifier.AttachmentType));
                            }
                            if (item0.InlinePolicyIdentifier.IsSetPolicyName())
                            {
                                request.Parameters.Add("PolicyExclusionList" + ".member" + "." + index0 + ".InlinePolicyIdentifier" + ".PolicyName", StringUtils.FromString(item0.InlinePolicyIdentifier.PolicyName));
                            }
                        }
                        if (item0.IsSetPolicyArn())
                        {
                            request.Parameters.Add("PolicyExclusionList" + ".member" + "." + index0 + ".PolicyArn", StringUtils.FromString(item0.PolicyArn));
                        }
                        if (item0.IsSetPolicyType())
                        {
                            request.Parameters.Add("PolicyExclusionList" + ".member" + "." + index0 + ".PolicyType", StringUtils.FromString(item0.PolicyType));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPolicyInputList())
            {
                if (publicRequest.PolicyInputList.Count == 0)
                {
                    request.Parameters.Add("PolicyInputList", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PolicyInputList)
                    {
                        request.Parameters.Add("PolicyInputList" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPolicySourceArn())
            {
                request.Parameters.Add("PolicySourceArn", StringUtils.FromString(publicRequest.PolicySourceArn));
            }
            if (publicRequest.IsSetResourceArns())
            {
                if (publicRequest.ResourceArns.Count == 0)
                {
                    request.Parameters.Add("ResourceArns", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ResourceArns)
                    {
                        request.Parameters.Add("ResourceArns" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetResourceHandlingOption())
            {
                request.Parameters.Add("ResourceHandlingOption", StringUtils.FromString(publicRequest.ResourceHandlingOption));
            }
            if (publicRequest.IsSetResourceOwner())
            {
                request.Parameters.Add("ResourceOwner", StringUtils.FromString(publicRequest.ResourceOwner));
            }
            if (publicRequest.IsSetResourcePolicy())
            {
                request.Parameters.Add("ResourcePolicy", StringUtils.FromString(publicRequest.ResourcePolicy));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly SimulatePrincipalPolicyRequestMarshaller _instance = new();

        internal static SimulatePrincipalPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SimulatePrincipalPolicyRequestMarshaller Instance => _instance;
    }
}
