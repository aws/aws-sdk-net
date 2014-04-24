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
    /// Create Snapshot Request Marshaller
    /// </summary>       
    public class CreateSnapshotRequestMarshaller : IMarshaller<IRequest, CreateSnapshotRequest>
    {
        public IRequest Marshall(CreateSnapshotRequest createSnapshotRequest)
        {
            IRequest request = new DefaultRequest(createSnapshotRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "CreateSnapshot");
            request.Parameters.Add("Version", "2014-03-24");
            if (createSnapshotRequest != null && createSnapshotRequest.IsSetCacheClusterId())
            {
                request.Parameters.Add("CacheClusterId", StringUtils.FromString(createSnapshotRequest.CacheClusterId));
            }
            if (createSnapshotRequest != null && createSnapshotRequest.IsSetSnapshotName())
            {
                request.Parameters.Add("SnapshotName", StringUtils.FromString(createSnapshotRequest.SnapshotName));
            }

            return request;
        }
    }
}
