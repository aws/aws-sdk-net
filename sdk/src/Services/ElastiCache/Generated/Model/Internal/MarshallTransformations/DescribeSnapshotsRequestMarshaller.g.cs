/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.ElastiCache.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeSnapshots Request Marshaller
    /// </summary>
    public partial class DescribeSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeSnapshotsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeSnapshotsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeSnapshots");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetCacheClusterId())
            {
                request.Parameters.Add("CacheClusterId", StringUtils.FromString(publicRequest.CacheClusterId));
            }
            if (publicRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            }
            if (publicRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords.Value));
            }
            if (publicRequest.IsSetReplicationGroupId())
            {
                request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
            }
            if (publicRequest.IsSetShowNodeGroupConfig())
            {
                request.Parameters.Add("ShowNodeGroupConfig", StringUtils.FromBool(publicRequest.ShowNodeGroupConfig.Value));
            }
            if (publicRequest.IsSetSnapshotName())
            {
                request.Parameters.Add("SnapshotName", StringUtils.FromString(publicRequest.SnapshotName));
            }
            if (publicRequest.IsSetSnapshotSource())
            {
                request.Parameters.Add("SnapshotSource", StringUtils.FromString(publicRequest.SnapshotSource));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeSnapshotsRequestMarshaller _instance = new();

        internal static DescribeSnapshotsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeSnapshotsRequestMarshaller Instance => _instance;
    }
}
