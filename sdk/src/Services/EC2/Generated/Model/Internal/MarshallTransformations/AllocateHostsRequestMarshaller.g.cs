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
    /// AllocateHosts Request Marshaller
    /// </summary>
    public partial class AllocateHostsRequestMarshaller : IMarshaller<IRequest, AllocateHostsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AllocateHostsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AllocateHostsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AllocateHosts");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAssetIds())
            {
                if (publicRequest.AssetIds.Count == 0)
                {
                    request.Parameters.Add("AssetId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AssetIds)
                    {
                        request.Parameters.Add("AssetId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetAutoPlacement())
            {
                request.Parameters.Add("AutoPlacement", StringUtils.FromString(publicRequest.AutoPlacement));
            }
            if (publicRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
            }
            if (publicRequest.IsSetAvailabilityZoneId())
            {
                request.Parameters.Add("AvailabilityZoneId", StringUtils.FromString(publicRequest.AvailabilityZoneId));
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetCpuOptions())
            {
                if (publicRequest.CpuOptions.IsSetAmdSevSnp())
                {
                    request.Parameters.Add("CpuOptions" + ".AmdSevSnp", StringUtils.FromString(publicRequest.CpuOptions.AmdSevSnp));
                }
            }
            if (publicRequest.IsSetHostMaintenance())
            {
                request.Parameters.Add("HostMaintenance", StringUtils.FromString(publicRequest.HostMaintenance));
            }
            if (publicRequest.IsSetHostRecovery())
            {
                request.Parameters.Add("HostRecovery", StringUtils.FromString(publicRequest.HostRecovery));
            }
            if (publicRequest.IsSetInstanceFamily())
            {
                request.Parameters.Add("InstanceFamily", StringUtils.FromString(publicRequest.InstanceFamily));
            }
            if (publicRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
            }
            if (publicRequest.IsSetOutpostArn())
            {
                request.Parameters.Add("OutpostArn", StringUtils.FromString(publicRequest.OutpostArn));
            }
            if (publicRequest.IsSetQuantity())
            {
                request.Parameters.Add("Quantity", StringUtils.FromInt(publicRequest.Quantity.Value));
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

        private static readonly AllocateHostsRequestMarshaller _instance = new();

        internal static AllocateHostsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AllocateHostsRequestMarshaller Instance => _instance;
    }
}
