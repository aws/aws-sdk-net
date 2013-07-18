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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Cluster Snapshots Request Marshaller
    /// </summary>       
    public class DescribeClusterSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeClusterSnapshotsRequest>
    {
        public IRequest Marshall(DescribeClusterSnapshotsRequest describeClusterSnapshotsRequest)
        {
            IRequest request = new DefaultRequest(describeClusterSnapshotsRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DescribeClusterSnapshots");
            request.Parameters.Add("Version", "2012-12-01");
            if (describeClusterSnapshotsRequest != null && describeClusterSnapshotsRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(describeClusterSnapshotsRequest.ClusterIdentifier));
            }
            if (describeClusterSnapshotsRequest != null && describeClusterSnapshotsRequest.IsSetSnapshotIdentifier())
            {
                request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(describeClusterSnapshotsRequest.SnapshotIdentifier));
            }
            if (describeClusterSnapshotsRequest != null && describeClusterSnapshotsRequest.IsSetSnapshotType())
            {
                request.Parameters.Add("SnapshotType", StringUtils.FromString(describeClusterSnapshotsRequest.SnapshotType));
            }
            if (describeClusterSnapshotsRequest != null && describeClusterSnapshotsRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTime(describeClusterSnapshotsRequest.StartTime));
            }
            if (describeClusterSnapshotsRequest != null && describeClusterSnapshotsRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTime(describeClusterSnapshotsRequest.EndTime));
            }
            if (describeClusterSnapshotsRequest != null && describeClusterSnapshotsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeClusterSnapshotsRequest.MaxRecords));
            }
            if (describeClusterSnapshotsRequest != null && describeClusterSnapshotsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeClusterSnapshotsRequest.Marker));
            }
            if (describeClusterSnapshotsRequest != null && describeClusterSnapshotsRequest.IsSetOwnerAccount())
            {
                request.Parameters.Add("OwnerAccount", StringUtils.FromString(describeClusterSnapshotsRequest.OwnerAccount));
            }

            return request;
        }
    }
}
