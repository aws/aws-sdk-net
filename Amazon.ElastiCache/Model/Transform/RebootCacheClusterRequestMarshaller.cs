/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElastiCache.Model.Transform
{
    /// <summary>
    /// Reboot Cache Cluster Request Marshaller
    /// </summary>       
    public class RebootCacheClusterRequestMarshaller : IMarshaller<IRequest<RebootCacheClusterRequest>, RebootCacheClusterRequest> 
    {

        public IRequest<RebootCacheClusterRequest> Marshall(RebootCacheClusterRequest rebootCacheClusterRequest) 
        {
            IRequest<RebootCacheClusterRequest> request = new DefaultRequest<RebootCacheClusterRequest>(rebootCacheClusterRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "RebootCacheCluster");
            request.Parameters.Add("Version", "2011-07-15");
            if (rebootCacheClusterRequest != null && rebootCacheClusterRequest.IsSetCacheClusterId()) 
            {
                request.Parameters.Add("CacheClusterId", StringUtils.FromString(rebootCacheClusterRequest.CacheClusterId));
            }
            if (rebootCacheClusterRequest != null) 
            {
                List<string> cacheNodeIdsToRebootList = rebootCacheClusterRequest.CacheNodeIdsToReboot;

                int cacheNodeIdsToRebootListIndex = 1;
                foreach (string cacheNodeIdsToRebootListValue in cacheNodeIdsToRebootList) 
                { 
                    request.Parameters.Add("CacheNodeIdsToReboot.member." + cacheNodeIdsToRebootListIndex, StringUtils.FromString(cacheNodeIdsToRebootListValue));
                    cacheNodeIdsToRebootListIndex++;
                }
            }


            return request;
        }
    }
}
