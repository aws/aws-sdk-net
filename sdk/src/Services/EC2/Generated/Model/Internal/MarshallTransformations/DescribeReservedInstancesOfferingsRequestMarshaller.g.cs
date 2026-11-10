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
    /// DescribeReservedInstancesOfferings Request Marshaller
    /// </summary>
    public partial class DescribeReservedInstancesOfferingsRequestMarshaller : IMarshaller<IRequest, DescribeReservedInstancesOfferingsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeReservedInstancesOfferingsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeReservedInstancesOfferingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeReservedInstancesOfferings");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
            }
            if (publicRequest.IsSetAvailabilityZoneId())
            {
                request.Parameters.Add("AvailabilityZoneId", StringUtils.FromString(publicRequest.AvailabilityZoneId));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetFilters())
            {
                if (publicRequest.Filters.Count == 0)
                {
                    request.Parameters.Add("Filter", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Filters)
                    {
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("Filter" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValues())
                        {
                            if (item0.Values.Count == 0)
                            {
                                request.Parameters.Add("Filter" + "." + index0 + ".Value", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Values)
                                {
                                    request.Parameters.Add("Filter" + "." + index0 + ".Value" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetIncludeMarketplace())
            {
                request.Parameters.Add("IncludeMarketplace", StringUtils.FromBool(publicRequest.IncludeMarketplace.Value));
            }
            if (publicRequest.IsSetInstanceTenancy())
            {
                request.Parameters.Add("InstanceTenancy", StringUtils.FromString(publicRequest.InstanceTenancy));
            }
            if (publicRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
            }
            if (publicRequest.IsSetMaxDuration())
            {
                request.Parameters.Add("MaxDuration", StringUtils.FromLong(publicRequest.MaxDuration.Value));
            }
            if (publicRequest.IsSetMaxInstanceCount())
            {
                request.Parameters.Add("MaxInstanceCount", StringUtils.FromInt(publicRequest.MaxInstanceCount.Value));
            }
            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }
            if (publicRequest.IsSetMinDuration())
            {
                request.Parameters.Add("MinDuration", StringUtils.FromLong(publicRequest.MinDuration.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetOfferingClass())
            {
                request.Parameters.Add("OfferingClass", StringUtils.FromString(publicRequest.OfferingClass));
            }
            if (publicRequest.IsSetOfferingType())
            {
                request.Parameters.Add("OfferingType", StringUtils.FromString(publicRequest.OfferingType));
            }
            if (publicRequest.IsSetProductDescription())
            {
                request.Parameters.Add("ProductDescription", StringUtils.FromString(publicRequest.ProductDescription));
            }
            if (publicRequest.IsSetReservedInstancesOfferingIds())
            {
                if (publicRequest.ReservedInstancesOfferingIds.Count == 0)
                {
                    request.Parameters.Add("ReservedInstancesOfferingId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ReservedInstancesOfferingIds)
                    {
                        request.Parameters.Add("ReservedInstancesOfferingId" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly DescribeReservedInstancesOfferingsRequestMarshaller _instance = new();

        internal static DescribeReservedInstancesOfferingsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeReservedInstancesOfferingsRequestMarshaller Instance => _instance;
    }
}
