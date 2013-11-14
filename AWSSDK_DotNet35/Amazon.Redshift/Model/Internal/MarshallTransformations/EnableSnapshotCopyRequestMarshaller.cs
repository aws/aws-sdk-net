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
    /// Enable Snapshot Copy Request Marshaller
    /// </summary>       
    public class EnableSnapshotCopyRequestMarshaller : IMarshaller<IRequest, EnableSnapshotCopyRequest>
    {
        public IRequest Marshall(EnableSnapshotCopyRequest enableSnapshotCopyRequest)
        {
            IRequest request = new DefaultRequest(enableSnapshotCopyRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "EnableSnapshotCopy");
            request.Parameters.Add("Version", "2012-12-01");
            if (enableSnapshotCopyRequest != null && enableSnapshotCopyRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(enableSnapshotCopyRequest.ClusterIdentifier));
            }
            if (enableSnapshotCopyRequest != null && enableSnapshotCopyRequest.IsSetDestinationRegion())
            {
                request.Parameters.Add("DestinationRegion", StringUtils.FromString(enableSnapshotCopyRequest.DestinationRegion));
            }
            if (enableSnapshotCopyRequest != null && enableSnapshotCopyRequest.IsSetRetentionPeriod())
            {
                request.Parameters.Add("RetentionPeriod", StringUtils.FromInt(enableSnapshotCopyRequest.RetentionPeriod));
            }

            return request;
        }
    }
}
