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
    /// CreateSnapshots Request Marshaller
    /// </summary>
    public partial class CreateSnapshotsRequestMarshaller : IMarshaller<IRequest, CreateSnapshotsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSnapshotsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateSnapshots");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetCopyTagsFromSource())
            {
                request.Parameters.Add("CopyTagsFromSource", StringUtils.FromString(publicRequest.CopyTagsFromSource));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetInstanceSpecification())
            {
                if (publicRequest.InstanceSpecification.IsSetExcludeBootVolume())
                {
                    request.Parameters.Add("InstanceSpecification" + ".ExcludeBootVolume", StringUtils.FromBool(publicRequest.InstanceSpecification.ExcludeBootVolume.Value));
                }
                if (publicRequest.InstanceSpecification.IsSetExcludeDataVolumeIds())
                {
                    if (publicRequest.InstanceSpecification.ExcludeDataVolumeIds.Count == 0)
                    {
                        request.Parameters.Add("InstanceSpecification" + ".ExcludeDataVolumeId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceSpecification.ExcludeDataVolumeIds)
                        {
                            request.Parameters.Add("InstanceSpecification" + ".ExcludeDataVolumeId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceSpecification.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceSpecification" + ".InstanceId", StringUtils.FromString(publicRequest.InstanceSpecification.InstanceId));
                }
            }
            if (publicRequest.IsSetLocation())
            {
                request.Parameters.Add("Location", StringUtils.FromString(publicRequest.Location));
            }
            if (publicRequest.IsSetOutpostArn())
            {
                request.Parameters.Add("OutpostArn", StringUtils.FromString(publicRequest.OutpostArn));
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

        private static readonly CreateSnapshotsRequestMarshaller _instance = new();

        internal static CreateSnapshotsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateSnapshotsRequestMarshaller Instance => _instance;
    }
}
