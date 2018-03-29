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
    /// CreateReplicationGroup Request Marshaller
    /// </summary>       
    public class CreateReplicationGroupRequestMarshaller : IMarshaller<IRequest, CreateReplicationGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReplicationGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReplicationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "CreateReplicationGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAtRestEncryptionEnabled())
                {
                    request.Parameters.Add("AtRestEncryptionEnabled", StringUtils.FromBool(publicRequest.AtRestEncryptionEnabled));
                }
                if(publicRequest.IsSetAuthToken())
                {
                    request.Parameters.Add("AuthToken", StringUtils.FromString(publicRequest.AuthToken));
                }
                if(publicRequest.IsSetAutomaticFailoverEnabled())
                {
                    request.Parameters.Add("AutomaticFailoverEnabled", StringUtils.FromBool(publicRequest.AutomaticFailoverEnabled));
                }
                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade));
                }
                if(publicRequest.IsSetCacheNodeType())
                {
                    request.Parameters.Add("CacheNodeType", StringUtils.FromString(publicRequest.CacheNodeType));
                }
                if(publicRequest.IsSetCacheParameterGroupName())
                {
                    request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(publicRequest.CacheParameterGroupName));
                }
                if(publicRequest.IsSetCacheSecurityGroupNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.CacheSecurityGroupNames)
                    {
                        request.Parameters.Add("CacheSecurityGroupNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetCacheSubnetGroupName())
                {
                    request.Parameters.Add("CacheSubnetGroupName", StringUtils.FromString(publicRequest.CacheSubnetGroupName));
                }
                if(publicRequest.IsSetEngine())
                {
                    request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
                }
                if(publicRequest.IsSetEngineVersion())
                {
                    request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
                }
                if(publicRequest.IsSetNodeGroupConfiguration())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.NodeGroupConfiguration)
                    {
                        if(publicRequestlistValue.IsSetPrimaryAvailabilityZone())
                        {
                            request.Parameters.Add("NodeGroupConfiguration" + "." + "member" + "." + publicRequestlistValueIndex + "." + "PrimaryAvailabilityZone", StringUtils.FromString(publicRequestlistValue.PrimaryAvailabilityZone));
                        }
                        if(publicRequestlistValue.IsSetReplicaAvailabilityZones())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.ReplicaAvailabilityZones)
                            {
                                request.Parameters.Add("NodeGroupConfiguration" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ReplicaAvailabilityZones" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetReplicaCount())
                        {
                            request.Parameters.Add("NodeGroupConfiguration" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ReplicaCount", StringUtils.FromInt(publicRequestlistValue.ReplicaCount));
                        }
                        if(publicRequestlistValue.IsSetSlots())
                        {
                            request.Parameters.Add("NodeGroupConfiguration" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Slots", StringUtils.FromString(publicRequestlistValue.Slots));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetNotificationTopicArn())
                {
                    request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(publicRequest.NotificationTopicArn));
                }
                if(publicRequest.IsSetNumCacheClusters())
                {
                    request.Parameters.Add("NumCacheClusters", StringUtils.FromInt(publicRequest.NumCacheClusters));
                }
                if(publicRequest.IsSetNumNodeGroups())
                {
                    request.Parameters.Add("NumNodeGroups", StringUtils.FromInt(publicRequest.NumNodeGroups));
                }
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
                if(publicRequest.IsSetPreferredCacheClusterAZs())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.PreferredCacheClusterAZs)
                    {
                        request.Parameters.Add("PreferredCacheClusterAZs" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
                if(publicRequest.IsSetPrimaryClusterId())
                {
                    request.Parameters.Add("PrimaryClusterId", StringUtils.FromString(publicRequest.PrimaryClusterId));
                }
                if(publicRequest.IsSetReplicasPerNodeGroup())
                {
                    request.Parameters.Add("ReplicasPerNodeGroup", StringUtils.FromInt(publicRequest.ReplicasPerNodeGroup));
                }
                if(publicRequest.IsSetReplicationGroupDescription())
                {
                    request.Parameters.Add("ReplicationGroupDescription", StringUtils.FromString(publicRequest.ReplicationGroupDescription));
                }
                if(publicRequest.IsSetReplicationGroupId())
                {
                    request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
                }
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetSnapshotArns())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SnapshotArns)
                    {
                        request.Parameters.Add("SnapshotArns" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetSnapshotName())
                {
                    request.Parameters.Add("SnapshotName", StringUtils.FromString(publicRequest.SnapshotName));
                }
                if(publicRequest.IsSetSnapshotRetentionLimit())
                {
                    request.Parameters.Add("SnapshotRetentionLimit", StringUtils.FromInt(publicRequest.SnapshotRetentionLimit));
                }
                if(publicRequest.IsSetSnapshotWindow())
                {
                    request.Parameters.Add("SnapshotWindow", StringUtils.FromString(publicRequest.SnapshotWindow));
                }
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTransitEncryptionEnabled())
                {
                    request.Parameters.Add("TransitEncryptionEnabled", StringUtils.FromBool(publicRequest.TransitEncryptionEnabled));
                }
            }
            return request;
        }
                    private static CreateReplicationGroupRequestMarshaller _instance = new CreateReplicationGroupRequestMarshaller();        

        internal static CreateReplicationGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReplicationGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}