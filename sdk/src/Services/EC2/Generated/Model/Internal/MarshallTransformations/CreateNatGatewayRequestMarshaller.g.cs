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
    /// CreateNatGateway Request Marshaller
    /// </summary>
    public partial class CreateNatGatewayRequestMarshaller : IMarshaller<IRequest, CreateNatGatewayRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNatGatewayRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateNatGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateNatGateway");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAllocationId())
            {
                request.Parameters.Add("AllocationId", StringUtils.FromString(publicRequest.AllocationId));
            }
            if (publicRequest.IsSetAvailabilityMode())
            {
                request.Parameters.Add("AvailabilityMode", StringUtils.FromString(publicRequest.AvailabilityMode));
            }
            if (publicRequest.IsSetAvailabilityZoneAddresses())
            {
                if (publicRequest.AvailabilityZoneAddresses.Count == 0)
                {
                    request.Parameters.Add("AvailabilityZoneAddress", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AvailabilityZoneAddresses)
                    {
                        if (item0.IsSetAllocationIds())
                        {
                            if (item0.AllocationIds.Count == 0)
                            {
                                request.Parameters.Add("AvailabilityZoneAddress" + "." + index0 + ".AllocationId", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.AllocationIds)
                                {
                                    request.Parameters.Add("AvailabilityZoneAddress" + "." + index0 + ".AllocationId" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetAvailabilityZone())
                        {
                            request.Parameters.Add("AvailabilityZoneAddress" + "." + index0 + ".AvailabilityZone", StringUtils.FromString(item0.AvailabilityZone));
                        }
                        if (item0.IsSetAvailabilityZoneId())
                        {
                            request.Parameters.Add("AvailabilityZoneAddress" + "." + index0 + ".AvailabilityZoneId", StringUtils.FromString(item0.AvailabilityZoneId));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetConnectivityType())
            {
                request.Parameters.Add("ConnectivityType", StringUtils.FromString(publicRequest.ConnectivityType));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetPrivateIpAddress())
            {
                request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(publicRequest.PrivateIpAddress));
            }
            if (publicRequest.IsSetSecondaryAllocationIds())
            {
                if (publicRequest.SecondaryAllocationIds.Count == 0)
                {
                    request.Parameters.Add("SecondaryAllocationId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecondaryAllocationIds)
                    {
                        request.Parameters.Add("SecondaryAllocationId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSecondaryPrivateIpAddressCount())
            {
                request.Parameters.Add("SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequest.SecondaryPrivateIpAddressCount.Value));
            }
            if (publicRequest.IsSetSecondaryPrivateIpAddresses())
            {
                if (publicRequest.SecondaryPrivateIpAddresses.Count == 0)
                {
                    request.Parameters.Add("SecondaryPrivateIpAddress", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecondaryPrivateIpAddresses)
                    {
                        request.Parameters.Add("SecondaryPrivateIpAddress" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSubnetId())
            {
                request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
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
            if (publicRequest.IsSetVpcId())
            {
                request.Parameters.Add("VpcId", StringUtils.FromString(publicRequest.VpcId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateNatGatewayRequestMarshaller _instance = new();

        internal static CreateNatGatewayRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateNatGatewayRequestMarshaller Instance => _instance;
    }
}
