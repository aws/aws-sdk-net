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
    /// CreateTrafficMirrorFilterRule Request Marshaller
    /// </summary>
    public partial class CreateTrafficMirrorFilterRuleRequestMarshaller : IMarshaller<IRequest, CreateTrafficMirrorFilterRuleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrafficMirrorFilterRuleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateTrafficMirrorFilterRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateTrafficMirrorFilterRule");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDestinationCidrBlock())
            {
                request.Parameters.Add("DestinationCidrBlock", StringUtils.FromString(publicRequest.DestinationCidrBlock));
            }
            if (publicRequest.IsSetDestinationPortRange())
            {
                if (publicRequest.DestinationPortRange.IsSetFromPort())
                {
                    request.Parameters.Add("DestinationPortRange" + ".FromPort", StringUtils.FromInt(publicRequest.DestinationPortRange.FromPort.Value));
                }
                if (publicRequest.DestinationPortRange.IsSetToPort())
                {
                    request.Parameters.Add("DestinationPortRange" + ".ToPort", StringUtils.FromInt(publicRequest.DestinationPortRange.ToPort.Value));
                }
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetProtocol())
            {
                request.Parameters.Add("Protocol", StringUtils.FromInt(publicRequest.Protocol.Value));
            }
            if (publicRequest.IsSetRuleAction())
            {
                request.Parameters.Add("RuleAction", StringUtils.FromString(publicRequest.RuleAction));
            }
            if (publicRequest.IsSetRuleNumber())
            {
                request.Parameters.Add("RuleNumber", StringUtils.FromInt(publicRequest.RuleNumber.Value));
            }
            if (publicRequest.IsSetSourceCidrBlock())
            {
                request.Parameters.Add("SourceCidrBlock", StringUtils.FromString(publicRequest.SourceCidrBlock));
            }
            if (publicRequest.IsSetSourcePortRange())
            {
                if (publicRequest.SourcePortRange.IsSetFromPort())
                {
                    request.Parameters.Add("SourcePortRange" + ".FromPort", StringUtils.FromInt(publicRequest.SourcePortRange.FromPort.Value));
                }
                if (publicRequest.SourcePortRange.IsSetToPort())
                {
                    request.Parameters.Add("SourcePortRange" + ".ToPort", StringUtils.FromInt(publicRequest.SourcePortRange.ToPort.Value));
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
            if (publicRequest.IsSetTrafficDirection())
            {
                request.Parameters.Add("TrafficDirection", StringUtils.FromString(publicRequest.TrafficDirection));
            }
            if (publicRequest.IsSetTrafficMirrorFilterId())
            {
                request.Parameters.Add("TrafficMirrorFilterId", StringUtils.FromString(publicRequest.TrafficMirrorFilterId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateTrafficMirrorFilterRuleRequestMarshaller _instance = new();

        internal static CreateTrafficMirrorFilterRuleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTrafficMirrorFilterRuleRequestMarshaller Instance => _instance;
    }
}
