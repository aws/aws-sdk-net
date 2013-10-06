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
    /// Restore From Cluster Snapshot Request Marshaller
    /// </summary>       
    public class RestoreFromClusterSnapshotRequestMarshaller : IMarshaller<IRequest, RestoreFromClusterSnapshotRequest>
    {
        public IRequest Marshall(RestoreFromClusterSnapshotRequest restoreFromClusterSnapshotRequest)
        {
            IRequest request = new DefaultRequest(restoreFromClusterSnapshotRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "RestoreFromClusterSnapshot");
            request.Parameters.Add("Version", "2012-12-01");
            if (restoreFromClusterSnapshotRequest != null && restoreFromClusterSnapshotRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(restoreFromClusterSnapshotRequest.ClusterIdentifier));
            }
            if (restoreFromClusterSnapshotRequest != null && restoreFromClusterSnapshotRequest.IsSetSnapshotIdentifier())
            {
                request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(restoreFromClusterSnapshotRequest.SnapshotIdentifier));
            }
            if (restoreFromClusterSnapshotRequest != null && restoreFromClusterSnapshotRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(restoreFromClusterSnapshotRequest.Port));
            }
            if (restoreFromClusterSnapshotRequest != null && restoreFromClusterSnapshotRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(restoreFromClusterSnapshotRequest.AvailabilityZone));
            }
            if (restoreFromClusterSnapshotRequest != null && restoreFromClusterSnapshotRequest.IsSetAllowVersionUpgrade())
            {
                request.Parameters.Add("AllowVersionUpgrade", StringUtils.FromBool(restoreFromClusterSnapshotRequest.AllowVersionUpgrade));
            }
            if (restoreFromClusterSnapshotRequest != null && restoreFromClusterSnapshotRequest.IsSetClusterSubnetGroupName())
            {
                request.Parameters.Add("ClusterSubnetGroupName", StringUtils.FromString(restoreFromClusterSnapshotRequest.ClusterSubnetGroupName));
            }
            if (restoreFromClusterSnapshotRequest != null && restoreFromClusterSnapshotRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(restoreFromClusterSnapshotRequest.PubliclyAccessible));
            }
            if (restoreFromClusterSnapshotRequest != null && restoreFromClusterSnapshotRequest.IsSetOwnerAccount())
            {
                request.Parameters.Add("OwnerAccount", StringUtils.FromString(restoreFromClusterSnapshotRequest.OwnerAccount));
            }

            return request;
        }
    }
}
