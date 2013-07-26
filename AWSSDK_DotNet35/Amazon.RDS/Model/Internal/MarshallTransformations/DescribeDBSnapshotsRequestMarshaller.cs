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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe D B Snapshots Request Marshaller
    /// </summary>       
    public class DescribeDBSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeDBSnapshotsRequest>
    {
        public IRequest Marshall(DescribeDBSnapshotsRequest describeDBSnapshotsRequest)
        {
            IRequest request = new DefaultRequest(describeDBSnapshotsRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeDBSnapshots");
            request.Parameters.Add("Version", "2013-05-15");
            if (describeDBSnapshotsRequest != null && describeDBSnapshotsRequest.IsSetDBInstanceIdentifier())
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(describeDBSnapshotsRequest.DBInstanceIdentifier));
            }
            if (describeDBSnapshotsRequest != null && describeDBSnapshotsRequest.IsSetDBSnapshotIdentifier())
            {
                request.Parameters.Add("DBSnapshotIdentifier", StringUtils.FromString(describeDBSnapshotsRequest.DBSnapshotIdentifier));
            }
            if (describeDBSnapshotsRequest != null && describeDBSnapshotsRequest.IsSetSnapshotType())
            {
                request.Parameters.Add("SnapshotType", StringUtils.FromString(describeDBSnapshotsRequest.SnapshotType));
            }
            if (describeDBSnapshotsRequest != null && describeDBSnapshotsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeDBSnapshotsRequest.MaxRecords));
            }
            if (describeDBSnapshotsRequest != null && describeDBSnapshotsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeDBSnapshotsRequest.Marker));
            }

            return request;
        }
    }
}
