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
    /// CreateNetworkInsightsPath Request Marshaller
    /// </summary>
    public partial class CreateNetworkInsightsPathRequestMarshaller : IMarshaller<IRequest, CreateNetworkInsightsPathRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkInsightsPathRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateNetworkInsightsPathRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateNetworkInsightsPath");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDestination())
            {
                request.Parameters.Add("Destination", StringUtils.FromString(publicRequest.Destination));
            }
            if (publicRequest.IsSetDestinationIp())
            {
                request.Parameters.Add("DestinationIp", StringUtils.FromString(publicRequest.DestinationIp));
            }
            if (publicRequest.IsSetDestinationPort())
            {
                request.Parameters.Add("DestinationPort", StringUtils.FromInt(publicRequest.DestinationPort.Value));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetFilterAtDestination())
            {
                if (publicRequest.FilterAtDestination.IsSetDestinationAddress())
                {
                    request.Parameters.Add("FilterAtDestination" + ".DestinationAddress", StringUtils.FromString(publicRequest.FilterAtDestination.DestinationAddress));
                }
                if (publicRequest.FilterAtDestination.IsSetDestinationPortRange())
                {
                    if (publicRequest.FilterAtDestination.DestinationPortRange.IsSetFromPort())
                    {
                        request.Parameters.Add("FilterAtDestination" + ".DestinationPortRange" + ".FromPort", StringUtils.FromInt(publicRequest.FilterAtDestination.DestinationPortRange.FromPort.Value));
                    }
                    if (publicRequest.FilterAtDestination.DestinationPortRange.IsSetToPort())
                    {
                        request.Parameters.Add("FilterAtDestination" + ".DestinationPortRange" + ".ToPort", StringUtils.FromInt(publicRequest.FilterAtDestination.DestinationPortRange.ToPort.Value));
                    }
                }
                if (publicRequest.FilterAtDestination.IsSetSourceAddress())
                {
                    request.Parameters.Add("FilterAtDestination" + ".SourceAddress", StringUtils.FromString(publicRequest.FilterAtDestination.SourceAddress));
                }
                if (publicRequest.FilterAtDestination.IsSetSourcePortRange())
                {
                    if (publicRequest.FilterAtDestination.SourcePortRange.IsSetFromPort())
                    {
                        request.Parameters.Add("FilterAtDestination" + ".SourcePortRange" + ".FromPort", StringUtils.FromInt(publicRequest.FilterAtDestination.SourcePortRange.FromPort.Value));
                    }
                    if (publicRequest.FilterAtDestination.SourcePortRange.IsSetToPort())
                    {
                        request.Parameters.Add("FilterAtDestination" + ".SourcePortRange" + ".ToPort", StringUtils.FromInt(publicRequest.FilterAtDestination.SourcePortRange.ToPort.Value));
                    }
                }
            }
            if (publicRequest.IsSetFilterAtSource())
            {
                if (publicRequest.FilterAtSource.IsSetDestinationAddress())
                {
                    request.Parameters.Add("FilterAtSource" + ".DestinationAddress", StringUtils.FromString(publicRequest.FilterAtSource.DestinationAddress));
                }
                if (publicRequest.FilterAtSource.IsSetDestinationPortRange())
                {
                    if (publicRequest.FilterAtSource.DestinationPortRange.IsSetFromPort())
                    {
                        request.Parameters.Add("FilterAtSource" + ".DestinationPortRange" + ".FromPort", StringUtils.FromInt(publicRequest.FilterAtSource.DestinationPortRange.FromPort.Value));
                    }
                    if (publicRequest.FilterAtSource.DestinationPortRange.IsSetToPort())
                    {
                        request.Parameters.Add("FilterAtSource" + ".DestinationPortRange" + ".ToPort", StringUtils.FromInt(publicRequest.FilterAtSource.DestinationPortRange.ToPort.Value));
                    }
                }
                if (publicRequest.FilterAtSource.IsSetSourceAddress())
                {
                    request.Parameters.Add("FilterAtSource" + ".SourceAddress", StringUtils.FromString(publicRequest.FilterAtSource.SourceAddress));
                }
                if (publicRequest.FilterAtSource.IsSetSourcePortRange())
                {
                    if (publicRequest.FilterAtSource.SourcePortRange.IsSetFromPort())
                    {
                        request.Parameters.Add("FilterAtSource" + ".SourcePortRange" + ".FromPort", StringUtils.FromInt(publicRequest.FilterAtSource.SourcePortRange.FromPort.Value));
                    }
                    if (publicRequest.FilterAtSource.SourcePortRange.IsSetToPort())
                    {
                        request.Parameters.Add("FilterAtSource" + ".SourcePortRange" + ".ToPort", StringUtils.FromInt(publicRequest.FilterAtSource.SourcePortRange.ToPort.Value));
                    }
                }
            }
            if (publicRequest.IsSetProtocol())
            {
                request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
            }
            if (publicRequest.IsSetSource())
            {
                request.Parameters.Add("Source", StringUtils.FromString(publicRequest.Source));
            }
            if (publicRequest.IsSetSourceIp())
            {
                request.Parameters.Add("SourceIp", StringUtils.FromString(publicRequest.SourceIp));
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

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateNetworkInsightsPathRequestMarshaller _instance = new();

        internal static CreateNetworkInsightsPathRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateNetworkInsightsPathRequestMarshaller Instance => _instance;
    }
}
