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
    /// CreateFlowLogs Request Marshaller
    /// </summary>
    public partial class CreateFlowLogsRequestMarshaller : IMarshaller<IRequest, CreateFlowLogsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFlowLogsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateFlowLogsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateFlowLogs");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetDeliverCrossAccountRole())
            {
                request.Parameters.Add("DeliverCrossAccountRole", StringUtils.FromString(publicRequest.DeliverCrossAccountRole));
            }
            if (publicRequest.IsSetDeliverLogsPermissionArn())
            {
                request.Parameters.Add("DeliverLogsPermissionArn", StringUtils.FromString(publicRequest.DeliverLogsPermissionArn));
            }
            if (publicRequest.IsSetDestinationOptions())
            {
                if (publicRequest.DestinationOptions.IsSetFileFormat())
                {
                    request.Parameters.Add("DestinationOptions" + ".FileFormat", StringUtils.FromString(publicRequest.DestinationOptions.FileFormat));
                }
                if (publicRequest.DestinationOptions.IsSetHiveCompatiblePartitions())
                {
                    request.Parameters.Add("DestinationOptions" + ".HiveCompatiblePartitions", StringUtils.FromBool(publicRequest.DestinationOptions.HiveCompatiblePartitions.Value));
                }
                if (publicRequest.DestinationOptions.IsSetPerHourPartition())
                {
                    request.Parameters.Add("DestinationOptions" + ".PerHourPartition", StringUtils.FromBool(publicRequest.DestinationOptions.PerHourPartition.Value));
                }
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetLogDestination())
            {
                request.Parameters.Add("LogDestination", StringUtils.FromString(publicRequest.LogDestination));
            }
            if (publicRequest.IsSetLogDestinationType())
            {
                request.Parameters.Add("LogDestinationType", StringUtils.FromString(publicRequest.LogDestinationType));
            }
            if (publicRequest.IsSetLogFormat())
            {
                request.Parameters.Add("LogFormat", StringUtils.FromString(publicRequest.LogFormat));
            }
            if (publicRequest.IsSetLogGroupName())
            {
                request.Parameters.Add("LogGroupName", StringUtils.FromString(publicRequest.LogGroupName));
            }
            if (publicRequest.IsSetMaxAggregationInterval())
            {
                request.Parameters.Add("MaxAggregationInterval", StringUtils.FromInt(publicRequest.MaxAggregationInterval.Value));
            }
            if (publicRequest.IsSetResourceIds())
            {
                if (publicRequest.ResourceIds.Count == 0)
                {
                    request.Parameters.Add("ResourceId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ResourceIds)
                    {
                        request.Parameters.Add("ResourceId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetResourceType())
            {
                request.Parameters.Add("ResourceType", StringUtils.FromString(publicRequest.ResourceType));
            }
            if (publicRequest.IsSetTagFieldSpecifications())
            {
                if (publicRequest.TagFieldSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagFieldSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagFieldSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagFieldSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTagKeys())
                        {
                            if (item0.TagKeys.Count == 0)
                            {
                                request.Parameters.Add("TagFieldSpecification" + "." + index0 + ".TagKey", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.TagKeys)
                                {
                                    request.Parameters.Add("TagFieldSpecification" + "." + index0 + ".TagKey" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
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
            if (publicRequest.IsSetTrafficType())
            {
                request.Parameters.Add("TrafficType", StringUtils.FromString(publicRequest.TrafficType));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateFlowLogsRequestMarshaller _instance = new();

        internal static CreateFlowLogsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateFlowLogsRequestMarshaller Instance => _instance;
    }
}
