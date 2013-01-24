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

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Modify Cache Cluster Request Marshaller
    /// </summary>       
    public class ModifyCacheClusterRequestMarshaller : IMarshaller<IRequest, ModifyCacheClusterRequest>
    {
        public IRequest Marshall(ModifyCacheClusterRequest modifyCacheClusterRequest)
        {
            IRequest request = new DefaultRequest(modifyCacheClusterRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "ModifyCacheCluster");
            request.Parameters.Add("Version", "2012-11-15");
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetCacheClusterId())
            {
                request.Parameters.Add("CacheClusterId", StringUtils.FromString(modifyCacheClusterRequest.CacheClusterId));
            }
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetNumCacheNodes())
            {
                request.Parameters.Add("NumCacheNodes", StringUtils.FromInt(modifyCacheClusterRequest.NumCacheNodes));
            }
            if (modifyCacheClusterRequest != null)
            {
                List<string> cacheNodeIdsToRemoveList = modifyCacheClusterRequest.CacheNodeIdsToRemove;

                int cacheNodeIdsToRemoveListIndex = 1;
                foreach (string cacheNodeIdsToRemoveListValue in cacheNodeIdsToRemoveList)
                { 
                    request.Parameters.Add("CacheNodeIdsToRemove.member." + cacheNodeIdsToRemoveListIndex, StringUtils.FromString(cacheNodeIdsToRemoveListValue));
                    cacheNodeIdsToRemoveListIndex++;
                }
            }
            if (modifyCacheClusterRequest != null)
            {
                List<string> cacheSecurityGroupNamesList = modifyCacheClusterRequest.CacheSecurityGroupNames;

                int cacheSecurityGroupNamesListIndex = 1;
                foreach (string cacheSecurityGroupNamesListValue in cacheSecurityGroupNamesList)
                { 
                    request.Parameters.Add("CacheSecurityGroupNames.member." + cacheSecurityGroupNamesListIndex, StringUtils.FromString(cacheSecurityGroupNamesListValue));
                    cacheSecurityGroupNamesListIndex++;
                }
            }
            if (modifyCacheClusterRequest != null)
            {
                List<string> securityGroupIdsList = modifyCacheClusterRequest.SecurityGroupIds;

                int securityGroupIdsListIndex = 1;
                foreach (string securityGroupIdsListValue in securityGroupIdsList)
                { 
                    request.Parameters.Add("SecurityGroupIds.member." + securityGroupIdsListIndex, StringUtils.FromString(securityGroupIdsListValue));
                    securityGroupIdsListIndex++;
                }
            }
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(modifyCacheClusterRequest.PreferredMaintenanceWindow));
            }
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetNotificationTopicArn())
            {
                request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(modifyCacheClusterRequest.NotificationTopicArn));
            }
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetCacheParameterGroupName())
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(modifyCacheClusterRequest.CacheParameterGroupName));
            }
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetNotificationTopicStatus())
            {
                request.Parameters.Add("NotificationTopicStatus", StringUtils.FromString(modifyCacheClusterRequest.NotificationTopicStatus));
            }
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(modifyCacheClusterRequest.ApplyImmediately));
            }
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(modifyCacheClusterRequest.EngineVersion));
            }
            if (modifyCacheClusterRequest != null && modifyCacheClusterRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(modifyCacheClusterRequest.AutoMinorVersionUpgrade));
            }

            return request;
        }
    }
}
