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
    /// Describe Reserved Cache Nodes Request Marshaller
    /// </summary>       
    public class DescribeReservedCacheNodesRequestMarshaller : IMarshaller<IRequest, DescribeReservedCacheNodesRequest>
    {
        public IRequest Marshall(DescribeReservedCacheNodesRequest describeReservedCacheNodesRequest)
        {
            IRequest request = new DefaultRequest(describeReservedCacheNodesRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "DescribeReservedCacheNodes");
            request.Parameters.Add("Version", "2013-06-15");
            if (describeReservedCacheNodesRequest != null && describeReservedCacheNodesRequest.IsSetReservedCacheNodeId())
            {
                request.Parameters.Add("ReservedCacheNodeId", StringUtils.FromString(describeReservedCacheNodesRequest.ReservedCacheNodeId));
            }
            if (describeReservedCacheNodesRequest != null && describeReservedCacheNodesRequest.IsSetReservedCacheNodesOfferingId())
            {
                request.Parameters.Add("ReservedCacheNodesOfferingId", StringUtils.FromString(describeReservedCacheNodesRequest.ReservedCacheNodesOfferingId));
            }
            if (describeReservedCacheNodesRequest != null && describeReservedCacheNodesRequest.IsSetCacheNodeType())
            {
                request.Parameters.Add("CacheNodeType", StringUtils.FromString(describeReservedCacheNodesRequest.CacheNodeType));
            }
            if (describeReservedCacheNodesRequest != null && describeReservedCacheNodesRequest.IsSetDuration())
            {
                request.Parameters.Add("Duration", StringUtils.FromString(describeReservedCacheNodesRequest.Duration));
            }
            if (describeReservedCacheNodesRequest != null && describeReservedCacheNodesRequest.IsSetProductDescription())
            {
                request.Parameters.Add("ProductDescription", StringUtils.FromString(describeReservedCacheNodesRequest.ProductDescription));
            }
            if (describeReservedCacheNodesRequest != null && describeReservedCacheNodesRequest.IsSetOfferingType())
            {
                request.Parameters.Add("OfferingType", StringUtils.FromString(describeReservedCacheNodesRequest.OfferingType));
            }
            if (describeReservedCacheNodesRequest != null && describeReservedCacheNodesRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeReservedCacheNodesRequest.MaxRecords));
            }
            if (describeReservedCacheNodesRequest != null && describeReservedCacheNodesRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeReservedCacheNodesRequest.Marker));
            }

            return request;
        }
    }
}
