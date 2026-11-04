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
    /// CreateReplicationGroup Request Marshaller
    /// </summary>
    public partial class CreateReplicationGroupRequestMarshaller : IMarshaller<IRequest, CreateReplicationGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReplicationGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateReplicationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateReplicationGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetAtRestEncryptionEnabled())
            {
                request.Parameters.Add("AtRestEncryptionEnabled", StringUtils.FromBool(publicRequest.AtRestEncryptionEnabled.Value));
            }
            if (publicRequest.IsSetAuthToken())
            {
                request.Parameters.Add("AuthToken", StringUtils.FromString(publicRequest.AuthToken));
            }
            if (publicRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade.Value));
            }
            if (publicRequest.IsSetAutomaticFailoverEnabled())
            {
                request.Parameters.Add("AutomaticFailoverEnabled", StringUtils.FromBool(publicRequest.AutomaticFailoverEnabled.Value));
            }
            if (publicRequest.IsSetCacheNodeType())
            {
                request.Parameters.Add("CacheNodeType", StringUtils.FromString(publicRequest.CacheNodeType));
            }
            if (publicRequest.IsSetCacheParameterGroupName())
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(publicRequest.CacheParameterGroupName));
            }
            if (publicRequest.IsSetCacheSecurityGroupNames())
            {
                if (publicRequest.CacheSecurityGroupNames.Count == 0)
                {
                    request.Parameters.Add("CacheSecurityGroupNames", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.CacheSecurityGroupNames)
                    {
                        request.Parameters.Add("CacheSecurityGroupNames" + ".CacheSecurityGroupName" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetCacheSubnetGroupName())
            {
                request.Parameters.Add("CacheSubnetGroupName", StringUtils.FromString(publicRequest.CacheSubnetGroupName));
            }
            if (publicRequest.IsSetClusterMode())
            {
                request.Parameters.Add("ClusterMode", StringUtils.FromString(publicRequest.ClusterMode));
            }
            if (publicRequest.IsSetDataTieringEnabled())
            {
                request.Parameters.Add("DataTieringEnabled", StringUtils.FromBool(publicRequest.DataTieringEnabled.Value));
            }
            if (publicRequest.IsSetDurability())
            {
                request.Parameters.Add("Durability", StringUtils.FromString(publicRequest.Durability));
            }
            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
            }
            if (publicRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
            }
            if (publicRequest.IsSetGlobalReplicationGroupId())
            {
                request.Parameters.Add("GlobalReplicationGroupId", StringUtils.FromString(publicRequest.GlobalReplicationGroupId));
            }
            if (publicRequest.IsSetIpDiscovery())
            {
                request.Parameters.Add("IpDiscovery", StringUtils.FromString(publicRequest.IpDiscovery));
            }
            if (publicRequest.IsSetKmsKeyId())
            {
                request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
            }
            if (publicRequest.IsSetLogDeliveryConfigurations())
            {
                if (publicRequest.LogDeliveryConfigurations.Count == 0)
                {
                    request.Parameters.Add("LogDeliveryConfigurations", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.LogDeliveryConfigurations)
                    {
                        if (item0.IsSetDestinationDetails())
                        {
                            if (item0.DestinationDetails.IsSetCloudWatchLogsDetails())
                            {
                                if (item0.DestinationDetails.CloudWatchLogsDetails.IsSetLogGroup())
                                {
                                    request.Parameters.Add("LogDeliveryConfigurations" + ".LogDeliveryConfigurationRequest" + "." + index0 + ".DestinationDetails" + ".CloudWatchLogsDetails" + ".LogGroup", StringUtils.FromString(item0.DestinationDetails.CloudWatchLogsDetails.LogGroup));
                                }
                            }
                            if (item0.DestinationDetails.IsSetKinesisFirehoseDetails())
                            {
                                if (item0.DestinationDetails.KinesisFirehoseDetails.IsSetDeliveryStream())
                                {
                                    request.Parameters.Add("LogDeliveryConfigurations" + ".LogDeliveryConfigurationRequest" + "." + index0 + ".DestinationDetails" + ".KinesisFirehoseDetails" + ".DeliveryStream", StringUtils.FromString(item0.DestinationDetails.KinesisFirehoseDetails.DeliveryStream));
                                }
                            }
                        }
                        if (item0.IsSetDestinationType())
                        {
                            request.Parameters.Add("LogDeliveryConfigurations" + ".LogDeliveryConfigurationRequest" + "." + index0 + ".DestinationType", StringUtils.FromString(item0.DestinationType));
                        }
                        if (item0.IsSetEnabled())
                        {
                            request.Parameters.Add("LogDeliveryConfigurations" + ".LogDeliveryConfigurationRequest" + "." + index0 + ".Enabled", StringUtils.FromBool(item0.Enabled.Value));
                        }
                        if (item0.IsSetLogFormat())
                        {
                            request.Parameters.Add("LogDeliveryConfigurations" + ".LogDeliveryConfigurationRequest" + "." + index0 + ".LogFormat", StringUtils.FromString(item0.LogFormat));
                        }
                        if (item0.IsSetLogType())
                        {
                            request.Parameters.Add("LogDeliveryConfigurations" + ".LogDeliveryConfigurationRequest" + "." + index0 + ".LogType", StringUtils.FromString(item0.LogType));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetMultiAZEnabled())
            {
                request.Parameters.Add("MultiAZEnabled", StringUtils.FromBool(publicRequest.MultiAZEnabled.Value));
            }
            if (publicRequest.IsSetNetworkType())
            {
                request.Parameters.Add("NetworkType", StringUtils.FromString(publicRequest.NetworkType));
            }
            if (publicRequest.IsSetNodeGroupConfiguration())
            {
                if (publicRequest.NodeGroupConfiguration.Count == 0)
                {
                    request.Parameters.Add("NodeGroupConfiguration", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.NodeGroupConfiguration)
                    {
                        if (item0.IsSetNodeGroupId())
                        {
                            request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".NodeGroupId", StringUtils.FromString(item0.NodeGroupId));
                        }
                        if (item0.IsSetPrimaryAvailabilityZone())
                        {
                            request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".PrimaryAvailabilityZone", StringUtils.FromString(item0.PrimaryAvailabilityZone));
                        }
                        if (item0.IsSetPrimaryOutpostArn())
                        {
                            request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".PrimaryOutpostArn", StringUtils.FromString(item0.PrimaryOutpostArn));
                        }
                        if (item0.IsSetReplicaAvailabilityZones())
                        {
                            if (item0.ReplicaAvailabilityZones.Count == 0)
                            {
                                request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".ReplicaAvailabilityZones", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ReplicaAvailabilityZones)
                                {
                                    request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".ReplicaAvailabilityZones" + ".AvailabilityZone" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetReplicaCount())
                        {
                            request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".ReplicaCount", StringUtils.FromInt(item0.ReplicaCount.Value));
                        }
                        if (item0.IsSetReplicaOutpostArns())
                        {
                            if (item0.ReplicaOutpostArns.Count == 0)
                            {
                                request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".ReplicaOutpostArns", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ReplicaOutpostArns)
                                {
                                    request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".ReplicaOutpostArns" + ".OutpostArn" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetSlots())
                        {
                            request.Parameters.Add("NodeGroupConfiguration" + ".NodeGroupConfiguration" + "." + index0 + ".Slots", StringUtils.FromString(item0.Slots));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetNotificationTopicArn())
            {
                request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(publicRequest.NotificationTopicArn));
            }
            if (publicRequest.IsSetNumCacheClusters())
            {
                request.Parameters.Add("NumCacheClusters", StringUtils.FromInt(publicRequest.NumCacheClusters.Value));
            }
            if (publicRequest.IsSetNumNodeGroups())
            {
                request.Parameters.Add("NumNodeGroups", StringUtils.FromInt(publicRequest.NumNodeGroups.Value));
            }
            if (publicRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port.Value));
            }
            if (publicRequest.IsSetPreferredCacheClusterAZs())
            {
                if (publicRequest.PreferredCacheClusterAZs.Count == 0)
                {
                    request.Parameters.Add("PreferredCacheClusterAZs", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PreferredCacheClusterAZs)
                    {
                        request.Parameters.Add("PreferredCacheClusterAZs" + ".AvailabilityZone" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
            }
            if (publicRequest.IsSetPrimaryClusterId())
            {
                request.Parameters.Add("PrimaryClusterId", StringUtils.FromString(publicRequest.PrimaryClusterId));
            }
            if (publicRequest.IsSetReplicasPerNodeGroup())
            {
                request.Parameters.Add("ReplicasPerNodeGroup", StringUtils.FromInt(publicRequest.ReplicasPerNodeGroup.Value));
            }
            if (publicRequest.IsSetReplicationGroupDescription())
            {
                request.Parameters.Add("ReplicationGroupDescription", StringUtils.FromString(publicRequest.ReplicationGroupDescription));
            }
            if (publicRequest.IsSetReplicationGroupId())
            {
                request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
            }
            if (publicRequest.IsSetSecurityGroupIds())
            {
                if (publicRequest.SecurityGroupIds.Count == 0)
                {
                    request.Parameters.Add("SecurityGroupIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupIds" + ".SecurityGroupId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetServerlessCacheSnapshotName())
            {
                request.Parameters.Add("ServerlessCacheSnapshotName", StringUtils.FromString(publicRequest.ServerlessCacheSnapshotName));
            }
            if (publicRequest.IsSetSnapshotArns())
            {
                if (publicRequest.SnapshotArns.Count == 0)
                {
                    request.Parameters.Add("SnapshotArns", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SnapshotArns)
                    {
                        request.Parameters.Add("SnapshotArns" + ".SnapshotArn" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSnapshotName())
            {
                request.Parameters.Add("SnapshotName", StringUtils.FromString(publicRequest.SnapshotName));
            }
            if (publicRequest.IsSetSnapshotRetentionLimit())
            {
                request.Parameters.Add("SnapshotRetentionLimit", StringUtils.FromInt(publicRequest.SnapshotRetentionLimit.Value));
            }
            if (publicRequest.IsSetSnapshotWindow())
            {
                request.Parameters.Add("SnapshotWindow", StringUtils.FromString(publicRequest.SnapshotWindow));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTransitEncryptionEnabled())
            {
                request.Parameters.Add("TransitEncryptionEnabled", StringUtils.FromBool(publicRequest.TransitEncryptionEnabled.Value));
            }
            if (publicRequest.IsSetTransitEncryptionMode())
            {
                request.Parameters.Add("TransitEncryptionMode", StringUtils.FromString(publicRequest.TransitEncryptionMode));
            }
            if (publicRequest.IsSetUserGroupIds())
            {
                if (publicRequest.UserGroupIds.Count == 0)
                {
                    request.Parameters.Add("UserGroupIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.UserGroupIds)
                    {
                        request.Parameters.Add("UserGroupIds" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateReplicationGroupRequestMarshaller _instance = new();

        internal static CreateReplicationGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateReplicationGroupRequestMarshaller Instance => _instance;
    }
}
