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
    /// Delete Cluster Snapshot Request Marshaller
    /// </summary>       
    public class DeleteClusterSnapshotRequestMarshaller : IMarshaller<IRequest, DeleteClusterSnapshotRequest>
    {
        public IRequest Marshall(DeleteClusterSnapshotRequest deleteClusterSnapshotRequest)
        {
            IRequest request = new DefaultRequest(deleteClusterSnapshotRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DeleteClusterSnapshot");
            request.Parameters.Add("Version", "2012-12-01");
            if (deleteClusterSnapshotRequest != null && deleteClusterSnapshotRequest.IsSetSnapshotIdentifier())
            {
                request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(deleteClusterSnapshotRequest.SnapshotIdentifier));
            }
            if (deleteClusterSnapshotRequest != null && deleteClusterSnapshotRequest.IsSetSnapshotClusterIdentifier())
            {
                request.Parameters.Add("SnapshotClusterIdentifier", StringUtils.FromString(deleteClusterSnapshotRequest.SnapshotClusterIdentifier));
            }

            return request;
        }
    }
}
