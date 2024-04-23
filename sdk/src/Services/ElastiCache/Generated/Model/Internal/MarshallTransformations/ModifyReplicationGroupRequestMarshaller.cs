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
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyReplicationGroup Request Marshaller
    /// </summary>       
    public class ModifyReplicationGroupRequestMarshaller : IMarshaller<IRequest, ModifyReplicationGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyReplicationGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyReplicationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "ModifyReplicationGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAuthToken())
                {
                    request.Parameters.Add("AuthToken", StringUtils.FromString(publicRequest.AuthToken));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAuthTokenUpdateStrategy())
                {
                    request.Parameters.Add("AuthTokenUpdateStrategy", StringUtils.FromString(publicRequest.AuthTokenUpdateStrategy));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAutomaticFailoverEnabled())
                {
                    request.Parameters.Add("AutomaticFailoverEnabled", StringUtils.FromBool(publicRequest.AutomaticFailoverEnabled));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCacheNodeType())
                {
                    request.Parameters.Add("CacheNodeType", StringUtils.FromString(publicRequest.CacheNodeType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCacheParameterGroupName())
                {
                    request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(publicRequest.CacheParameterGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCacheSecurityGroupNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.CacheSecurityGroupNames)
                    {
                        request.Parameters.Add("CacheSecurityGroupNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetClusterMode())
                {
                    request.Parameters.Add("ClusterMode", StringUtils.FromString(publicRequest.ClusterMode));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEngineVersion())
                {
                    request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIpDiscovery())
                {
                    request.Parameters.Add("IpDiscovery", StringUtils.FromString(publicRequest.IpDiscovery));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLogDeliveryConfigurations())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LogDeliveryConfigurations)
                    {
                        if(publicRequestlistValue.IsSetDestinationDetails())
                        {
                            if(publicRequestlistValue.DestinationDetails.IsSetCloudWatchLogsDetails())
                            {
                                if(publicRequestlistValue.DestinationDetails.CloudWatchLogsDetails.IsSetLogGroup())
                                {
                                    request.Parameters.Add("LogDeliveryConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DestinationDetails" + "." + "CloudWatchLogsDetails" + "." + "LogGroup", StringUtils.FromString(publicRequestlistValue.DestinationDetails.CloudWatchLogsDetails.LogGroup));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.DestinationDetails.IsSetKinesisFirehoseDetails())
                            {
                                if(publicRequestlistValue.DestinationDetails.KinesisFirehoseDetails.IsSetDeliveryStream())
                                {
                                    request.Parameters.Add("LogDeliveryConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DestinationDetails" + "." + "KinesisFirehoseDetails" + "." + "DeliveryStream", StringUtils.FromString(publicRequestlistValue.DestinationDetails.KinesisFirehoseDetails.DeliveryStream));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetDestinationType())
                        {
                            request.Parameters.Add("LogDeliveryConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DestinationType", StringUtils.FromString(publicRequestlistValue.DestinationType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetEnabled())
                        {
                            request.Parameters.Add("LogDeliveryConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Enabled", StringUtils.FromBool(publicRequestlistValue.Enabled));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetLogFormat())
                        {
                            request.Parameters.Add("LogDeliveryConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LogFormat", StringUtils.FromString(publicRequestlistValue.LogFormat));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetLogType())
                        {
                            request.Parameters.Add("LogDeliveryConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LogType", StringUtils.FromString(publicRequestlistValue.LogType));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMultiAZEnabled())
                {
                    request.Parameters.Add("MultiAZEnabled", StringUtils.FromBool(publicRequest.MultiAZEnabled));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNodeGroupId())
                {
                    request.Parameters.Add("NodeGroupId", StringUtils.FromString(publicRequest.NodeGroupId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNotificationTopicArn())
                {
                    request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(publicRequest.NotificationTopicArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNotificationTopicStatus())
                {
                    request.Parameters.Add("NotificationTopicStatus", StringUtils.FromString(publicRequest.NotificationTopicStatus));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPrimaryClusterId())
                {
                    request.Parameters.Add("PrimaryClusterId", StringUtils.FromString(publicRequest.PrimaryClusterId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRemoveUserGroups())
                {
                    request.Parameters.Add("RemoveUserGroups", StringUtils.FromBool(publicRequest.RemoveUserGroups));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetReplicationGroupDescription())
                {
                    request.Parameters.Add("ReplicationGroupDescription", StringUtils.FromString(publicRequest.ReplicationGroupDescription));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetReplicationGroupId())
                {
                    request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshotRetentionLimit())
                {
                    request.Parameters.Add("SnapshotRetentionLimit", StringUtils.FromInt(publicRequest.SnapshotRetentionLimit));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshottingClusterId())
                {
                    request.Parameters.Add("SnapshottingClusterId", StringUtils.FromString(publicRequest.SnapshottingClusterId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshotWindow())
                {
                    request.Parameters.Add("SnapshotWindow", StringUtils.FromString(publicRequest.SnapshotWindow));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTransitEncryptionEnabled())
                {
                    request.Parameters.Add("TransitEncryptionEnabled", StringUtils.FromBool(publicRequest.TransitEncryptionEnabled));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTransitEncryptionMode())
                {
                    request.Parameters.Add("TransitEncryptionMode", StringUtils.FromString(publicRequest.TransitEncryptionMode));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetUserGroupIdsToAdd())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.UserGroupIdsToAdd)
                    {
                        request.Parameters.Add("UserGroupIdsToAdd" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetUserGroupIdsToRemove())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.UserGroupIdsToRemove)
                    {
                        request.Parameters.Add("UserGroupIdsToRemove" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ModifyReplicationGroupRequestMarshaller _instance = new ModifyReplicationGroupRequestMarshaller();        

        internal static ModifyReplicationGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyReplicationGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}