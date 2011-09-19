/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Create Cache Cluster Request Marshaller
    /// </summary>       
    public class CreateCacheClusterRequestMarshaller : IMarshaller<IRequest<CreateCacheClusterRequest>, CreateCacheClusterRequest> 
    {

        public IRequest<CreateCacheClusterRequest> Marshall(CreateCacheClusterRequest createCacheClusterRequest) 
        {
            IRequest<CreateCacheClusterRequest> request = new DefaultRequest<CreateCacheClusterRequest>(createCacheClusterRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "CreateCacheCluster");
            request.Parameters.Add("Version", "2011-07-15");
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetCacheClusterId()) 
            {
                request.Parameters.Add("CacheClusterId", StringUtils.FromString(createCacheClusterRequest.CacheClusterId));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetNumCacheNodes()) 
            {
                request.Parameters.Add("NumCacheNodes", StringUtils.FromInt(createCacheClusterRequest.NumCacheNodes));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetCacheNodeType()) 
            {
                request.Parameters.Add("CacheNodeType", StringUtils.FromString(createCacheClusterRequest.CacheNodeType));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetEngine()) 
            {
                request.Parameters.Add("Engine", StringUtils.FromString(createCacheClusterRequest.Engine));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetEngineVersion()) 
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(createCacheClusterRequest.EngineVersion));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetCacheParameterGroupName()) 
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(createCacheClusterRequest.CacheParameterGroupName));
            }
            if (createCacheClusterRequest != null) 
            {
                List<string> cacheSecurityGroupNamesList = createCacheClusterRequest.CacheSecurityGroupNames;

                int cacheSecurityGroupNamesListIndex = 1;
                foreach (string cacheSecurityGroupNamesListValue in cacheSecurityGroupNamesList) 
                { 
                    request.Parameters.Add("CacheSecurityGroupNames.member." + cacheSecurityGroupNamesListIndex, StringUtils.FromString(cacheSecurityGroupNamesListValue));
                    cacheSecurityGroupNamesListIndex++;
                }
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetPreferredAvailabilityZone()) 
            {
                request.Parameters.Add("PreferredAvailabilityZone", StringUtils.FromString(createCacheClusterRequest.PreferredAvailabilityZone));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetPreferredMaintenanceWindow()) 
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(createCacheClusterRequest.PreferredMaintenanceWindow));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetPort()) 
            {
                request.Parameters.Add("Port", StringUtils.FromInt(createCacheClusterRequest.Port));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetNotificationTopicArn()) 
            {
                request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(createCacheClusterRequest.NotificationTopicArn));
            }
            if (createCacheClusterRequest != null && createCacheClusterRequest.IsSetAutoMinorVersionUpgrade()) 
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(createCacheClusterRequest.AutoMinorVersionUpgrade));
            }


            return request;
        }
    }
}
