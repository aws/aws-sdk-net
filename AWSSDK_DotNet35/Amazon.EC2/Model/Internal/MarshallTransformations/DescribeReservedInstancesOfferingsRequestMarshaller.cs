/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Reserved Instances Offerings Request Marshaller
    /// </summary>       
    public class DescribeReservedInstancesOfferingsRequestMarshaller : IMarshaller<IRequest, DescribeReservedInstancesOfferingsRequest>
    {
        public IRequest Marshall(DescribeReservedInstancesOfferingsRequest describeReservedInstancesOfferingsRequest)
        {
            IRequest request = new DefaultRequest(describeReservedInstancesOfferingsRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DescribeReservedInstancesOfferings");
            request.Parameters.Add("Version", "2013-10-15");
            if (describeReservedInstancesOfferingsRequest != null)
            {
                List<string> reservedInstancesOfferingIdsList = describeReservedInstancesOfferingsRequest.ReservedInstancesOfferingIds;

                int reservedInstancesOfferingIdsListIndex = 1;
                foreach (string reservedInstancesOfferingIdsListValue in reservedInstancesOfferingIdsList)
                { 
                    request.Parameters.Add("ReservedInstancesOfferingId." + reservedInstancesOfferingIdsListIndex, StringUtils.FromString(reservedInstancesOfferingIdsListValue));
                    reservedInstancesOfferingIdsListIndex++;
                }
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(describeReservedInstancesOfferingsRequest.InstanceType));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(describeReservedInstancesOfferingsRequest.AvailabilityZone));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetProductDescription())
            {
                request.Parameters.Add("ProductDescription", StringUtils.FromString(describeReservedInstancesOfferingsRequest.ProductDescription));
            }

            if (describeReservedInstancesOfferingsRequest != null)
            {
                List<Filter> filtersList = describeReservedInstancesOfferingsRequest.Filters;
                int filtersListIndex = 1;
                foreach (Filter filtersListValue in filtersList)
                {
                    if (filtersListValue != null && filtersListValue.IsSetName())
                    {
                        request.Parameters.Add("Filter." + filtersListIndex + ".Name", StringUtils.FromString(filtersListValue.Name));
                    }
                    if (filtersListValue != null)
                    {
                        List<string> valuesList = filtersListValue.Values;

                        int valuesListIndex = 1;
                        foreach (string valuesListValue in valuesList)
                        { 
                            request.Parameters.Add("Filter." + filtersListIndex + ".Value." + valuesListIndex, StringUtils.FromString(valuesListValue));
                            valuesListIndex++;
                        }
                    }

                    filtersListIndex++;
                }
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetInstanceTenancy())
            {
                request.Parameters.Add("InstanceTenancy", StringUtils.FromString(describeReservedInstancesOfferingsRequest.InstanceTenancy));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetOfferingType())
            {
                request.Parameters.Add("OfferingType", StringUtils.FromString(describeReservedInstancesOfferingsRequest.OfferingType));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeReservedInstancesOfferingsRequest.NextToken));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(describeReservedInstancesOfferingsRequest.MaxResults));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetIncludeMarketplace())
            {
                request.Parameters.Add("IncludeMarketplace", StringUtils.FromBool(describeReservedInstancesOfferingsRequest.IncludeMarketplace));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetMinDuration())
            {
                request.Parameters.Add("MinDuration", StringUtils.FromLong(describeReservedInstancesOfferingsRequest.MinDuration));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetMaxDuration())
            {
                request.Parameters.Add("MaxDuration", StringUtils.FromLong(describeReservedInstancesOfferingsRequest.MaxDuration));
            }
            if (describeReservedInstancesOfferingsRequest != null && describeReservedInstancesOfferingsRequest.IsSetMaxInstanceCount())
            {
                request.Parameters.Add("MaxInstanceCount", StringUtils.FromInt(describeReservedInstancesOfferingsRequest.MaxInstanceCount));
            }

            return request;
        }
    }
}
