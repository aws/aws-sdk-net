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
    /// Modify Replication Group Request Marshaller
    /// </summary>       
    public class ModifyReplicationGroupRequestMarshaller : IMarshaller<IRequest, ModifyReplicationGroupRequest>
    {
        public IRequest Marshall(ModifyReplicationGroupRequest modifyReplicationGroupRequest)
        {
            IRequest request = new DefaultRequest(modifyReplicationGroupRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "ModifyReplicationGroup");
            request.Parameters.Add("Version", "2013-06-15");
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetReplicationGroupId())
            {
                request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(modifyReplicationGroupRequest.ReplicationGroupId));
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetReplicationGroupDescription())
            {
                request.Parameters.Add("ReplicationGroupDescription", StringUtils.FromString(modifyReplicationGroupRequest.ReplicationGroupDescription));
            }
            if (modifyReplicationGroupRequest != null)
            {
                List<string> cacheSecurityGroupNamesList = modifyReplicationGroupRequest.CacheSecurityGroupNames;

                int cacheSecurityGroupNamesListIndex = 1;
                foreach (string cacheSecurityGroupNamesListValue in cacheSecurityGroupNamesList)
                { 
                    request.Parameters.Add("CacheSecurityGroupNames.member." + cacheSecurityGroupNamesListIndex, StringUtils.FromString(cacheSecurityGroupNamesListValue));
                    cacheSecurityGroupNamesListIndex++;
                }
            }
            if (modifyReplicationGroupRequest != null)
            {
                List<string> securityGroupIdsList = modifyReplicationGroupRequest.SecurityGroupIds;

                int securityGroupIdsListIndex = 1;
                foreach (string securityGroupIdsListValue in securityGroupIdsList)
                { 
                    request.Parameters.Add("SecurityGroupIds.member." + securityGroupIdsListIndex, StringUtils.FromString(securityGroupIdsListValue));
                    securityGroupIdsListIndex++;
                }
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(modifyReplicationGroupRequest.PreferredMaintenanceWindow));
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetNotificationTopicArn())
            {
                request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(modifyReplicationGroupRequest.NotificationTopicArn));
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetCacheParameterGroupName())
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(modifyReplicationGroupRequest.CacheParameterGroupName));
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetNotificationTopicStatus())
            {
                request.Parameters.Add("NotificationTopicStatus", StringUtils.FromString(modifyReplicationGroupRequest.NotificationTopicStatus));
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(modifyReplicationGroupRequest.ApplyImmediately));
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(modifyReplicationGroupRequest.EngineVersion));
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(modifyReplicationGroupRequest.AutoMinorVersionUpgrade));
            }
            if (modifyReplicationGroupRequest != null && modifyReplicationGroupRequest.IsSetPrimaryClusterId())
            {
                request.Parameters.Add("PrimaryClusterId", StringUtils.FromString(modifyReplicationGroupRequest.PrimaryClusterId));
            }

            return request;
        }
    }
}
