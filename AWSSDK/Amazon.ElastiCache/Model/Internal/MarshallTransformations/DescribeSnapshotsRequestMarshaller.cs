/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Describe Snapshots Request Marshaller
    /// </summary>       
    public class DescribeSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeSnapshotsRequest>
    {
        public IRequest Marshall(DescribeSnapshotsRequest describeSnapshotsRequest)
        {
            IRequest request = new DefaultRequest(describeSnapshotsRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "DescribeSnapshots");
            request.Parameters.Add("Version", "2014-03-24");
            if (describeSnapshotsRequest != null && describeSnapshotsRequest.IsSetCacheClusterId())
            {
                request.Parameters.Add("CacheClusterId", StringUtils.FromString(describeSnapshotsRequest.CacheClusterId));
            }
            if (describeSnapshotsRequest != null && describeSnapshotsRequest.IsSetSnapshotName())
            {
                request.Parameters.Add("SnapshotName", StringUtils.FromString(describeSnapshotsRequest.SnapshotName));
            }
            if (describeSnapshotsRequest != null && describeSnapshotsRequest.IsSetSnapshotSource())
            {
                request.Parameters.Add("SnapshotSource", StringUtils.FromString(describeSnapshotsRequest.SnapshotSource));
            }
            if (describeSnapshotsRequest != null && describeSnapshotsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeSnapshotsRequest.Marker));
            }
            if (describeSnapshotsRequest != null && describeSnapshotsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeSnapshotsRequest.MaxRecords));
            }

            return request;
        }
    }
}
