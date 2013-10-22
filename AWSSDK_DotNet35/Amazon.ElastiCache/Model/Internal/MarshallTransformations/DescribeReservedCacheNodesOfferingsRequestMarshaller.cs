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

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Reserved Cache Nodes Offerings Request Marshaller
    /// </summary>       
    public class DescribeReservedCacheNodesOfferingsRequestMarshaller : IMarshaller<IRequest, DescribeReservedCacheNodesOfferingsRequest>
    {
        public IRequest Marshall(DescribeReservedCacheNodesOfferingsRequest describeReservedCacheNodesOfferingsRequest)
        {
            IRequest request = new DefaultRequest(describeReservedCacheNodesOfferingsRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "DescribeReservedCacheNodesOfferings");
            request.Parameters.Add("Version", "2013-06-15");
            if (describeReservedCacheNodesOfferingsRequest != null && describeReservedCacheNodesOfferingsRequest.IsSetReservedCacheNodesOfferingId())
            {
                request.Parameters.Add("ReservedCacheNodesOfferingId", StringUtils.FromString(describeReservedCacheNodesOfferingsRequest.ReservedCacheNodesOfferingId));
            }
            if (describeReservedCacheNodesOfferingsRequest != null && describeReservedCacheNodesOfferingsRequest.IsSetCacheNodeType())
            {
                request.Parameters.Add("CacheNodeType", StringUtils.FromString(describeReservedCacheNodesOfferingsRequest.CacheNodeType));
            }
            if (describeReservedCacheNodesOfferingsRequest != null && describeReservedCacheNodesOfferingsRequest.IsSetDuration())
            {
                request.Parameters.Add("Duration", StringUtils.FromString(describeReservedCacheNodesOfferingsRequest.Duration));
            }
            if (describeReservedCacheNodesOfferingsRequest != null && describeReservedCacheNodesOfferingsRequest.IsSetProductDescription())
            {
                request.Parameters.Add("ProductDescription", StringUtils.FromString(describeReservedCacheNodesOfferingsRequest.ProductDescription));
            }
            if (describeReservedCacheNodesOfferingsRequest != null && describeReservedCacheNodesOfferingsRequest.IsSetOfferingType())
            {
                request.Parameters.Add("OfferingType", StringUtils.FromString(describeReservedCacheNodesOfferingsRequest.OfferingType));
            }
            if (describeReservedCacheNodesOfferingsRequest != null && describeReservedCacheNodesOfferingsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeReservedCacheNodesOfferingsRequest.MaxRecords));
            }
            if (describeReservedCacheNodesOfferingsRequest != null && describeReservedCacheNodesOfferingsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeReservedCacheNodesOfferingsRequest.Marker));
            }

            return request;
        }
    }
}
