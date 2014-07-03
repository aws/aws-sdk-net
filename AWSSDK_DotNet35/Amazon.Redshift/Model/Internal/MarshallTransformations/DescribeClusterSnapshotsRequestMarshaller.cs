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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeClusterSnapshots Request Marshaller
    /// </summary>       
    public class DescribeClusterSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeClusterSnapshotsRequest>
    {
        public IRequest Marshall(DescribeClusterSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "DescribeClusterSnapshots");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTime(publicRequest.EndTime));
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetOwnerAccount())
                {
                    request.Parameters.Add("OwnerAccount", StringUtils.FromString(publicRequest.OwnerAccount));
                }
                if(publicRequest.IsSetSnapshotIdentifier())
                {
                    request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(publicRequest.SnapshotIdentifier));
                }
                if(publicRequest.IsSetSnapshotType())
                {
                    request.Parameters.Add("SnapshotType", StringUtils.FromString(publicRequest.SnapshotType));
                }
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTime(publicRequest.StartTime));
                }
            }
            return request;
        }
    }
}