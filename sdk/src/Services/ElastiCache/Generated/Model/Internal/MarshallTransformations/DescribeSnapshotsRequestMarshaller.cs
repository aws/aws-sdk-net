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

/*
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeSnapshots Request Marshaller
    /// </summary>       
    public class DescribeSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeSnapshotsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeSnapshotsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "DescribeSnapshots");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCacheClusterId())
                {
                    request.Parameters.Add("CacheClusterId", StringUtils.FromString(publicRequest.CacheClusterId));
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetReplicationGroupId())
                {
                    request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
                }
                if(publicRequest.IsSetShowNodeGroupConfig())
                {
                    request.Parameters.Add("ShowNodeGroupConfig", StringUtils.FromBool(publicRequest.ShowNodeGroupConfig));
                }
                if(publicRequest.IsSetSnapshotName())
                {
                    request.Parameters.Add("SnapshotName", StringUtils.FromString(publicRequest.SnapshotName));
                }
                if(publicRequest.IsSetSnapshotSource())
                {
                    request.Parameters.Add("SnapshotSource", StringUtils.FromString(publicRequest.SnapshotSource));
                }
            }
            return request;
        }
                    private static DescribeSnapshotsRequestMarshaller _instance = new DescribeSnapshotsRequestMarshaller();        

        internal static DescribeSnapshotsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeSnapshotsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}