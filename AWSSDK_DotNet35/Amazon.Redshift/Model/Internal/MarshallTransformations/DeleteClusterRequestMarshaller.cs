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
    /// Delete Cluster Request Marshaller
    /// </summary>       
    public class DeleteClusterRequestMarshaller : IMarshaller<IRequest, DeleteClusterRequest>
    {
        public IRequest Marshall(DeleteClusterRequest deleteClusterRequest)
        {
            IRequest request = new DefaultRequest(deleteClusterRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DeleteCluster");
            request.Parameters.Add("Version", "2012-12-01");
            if (deleteClusterRequest != null && deleteClusterRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(deleteClusterRequest.ClusterIdentifier));
            }
            if (deleteClusterRequest != null && deleteClusterRequest.IsSetSkipFinalClusterSnapshot())
            {
                request.Parameters.Add("SkipFinalClusterSnapshot", StringUtils.FromBool(deleteClusterRequest.SkipFinalClusterSnapshot));
            }
            if (deleteClusterRequest != null && deleteClusterRequest.IsSetFinalClusterSnapshotIdentifier())
            {
                request.Parameters.Add("FinalClusterSnapshotIdentifier", StringUtils.FromString(deleteClusterRequest.FinalClusterSnapshotIdentifier));
            }

            return request;
        }
    }
}
