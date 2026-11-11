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
    /// CreateCapacityReservation Request Marshaller
    /// </summary>
    public partial class CreateCapacityReservationRequestMarshaller : IMarshaller<IRequest, CreateCapacityReservationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCapacityReservationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateCapacityReservationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateCapacityReservation");
            request.Parameters.Add("Version", "2016-11-15");

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
            if (publicRequest.IsSetCommitmentDuration())
            {
                request.Parameters.Add("CommitmentDuration", StringUtils.FromLong(publicRequest.CommitmentDuration.Value));
            }
            if (publicRequest.IsSetDeliveryPreference())
            {
                request.Parameters.Add("DeliveryPreference", StringUtils.FromString(publicRequest.DeliveryPreference));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEbsOptimized())
            {
                request.Parameters.Add("EbsOptimized", StringUtils.FromBool(publicRequest.EbsOptimized.Value));
            }
            if (publicRequest.IsSetEndDate())
            {
                request.Parameters.Add("EndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate.Value));
            }
            if (publicRequest.IsSetEndDateType())
            {
                request.Parameters.Add("EndDateType", StringUtils.FromString(publicRequest.EndDateType));
            }
            if (publicRequest.IsSetEphemeralStorage())
            {
                request.Parameters.Add("EphemeralStorage", StringUtils.FromBool(publicRequest.EphemeralStorage.Value));
            }
            if (publicRequest.IsSetInstanceCount())
            {
                request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount.Value));
            }
            if (publicRequest.IsSetInstanceMatchCriteria())
            {
                request.Parameters.Add("InstanceMatchCriteria", StringUtils.FromString(publicRequest.InstanceMatchCriteria));
            }
            if (publicRequest.IsSetInstancePlatform())
            {
                request.Parameters.Add("InstancePlatform", StringUtils.FromString(publicRequest.InstancePlatform));
            }
            if (publicRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
            }
            if (publicRequest.IsSetOutpostArn())
            {
                request.Parameters.Add("OutpostArn", StringUtils.FromString(publicRequest.OutpostArn));
            }
            if (publicRequest.IsSetPlacementGroupArn())
            {
                request.Parameters.Add("PlacementGroupArn", StringUtils.FromString(publicRequest.PlacementGroupArn));
            }
            if (publicRequest.IsSetStartDate())
            {
                request.Parameters.Add("StartDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartDate.Value));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecifications", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecifications" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecifications" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecifications" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecifications" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTenancy())
            {
                request.Parameters.Add("Tenancy", StringUtils.FromString(publicRequest.Tenancy));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateCapacityReservationRequestMarshaller _instance = new();

        internal static CreateCapacityReservationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateCapacityReservationRequestMarshaller Instance => _instance;
    }
}
