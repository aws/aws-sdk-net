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
    /// ModifyCacheCluster Request Marshaller
    /// </summary>
    public partial class ModifyCacheClusterRequestMarshaller : IMarshaller<IRequest, ModifyCacheClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyCacheClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyCacheClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyCacheCluster");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetAZMode())
            {
                request.Parameters.Add("AZMode", StringUtils.FromString(publicRequest.AZMode));
            }
            if (publicRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately.Value));
            }
            if (publicRequest.IsSetAuthToken())
            {
                request.Parameters.Add("AuthToken", StringUtils.FromString(publicRequest.AuthToken));
            }
            if (publicRequest.IsSetAuthTokenUpdateStrategy())
            {
                request.Parameters.Add("AuthTokenUpdateStrategy", StringUtils.FromString(publicRequest.AuthTokenUpdateStrategy));
            }
            if (publicRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade.Value));
            }
            if (publicRequest.IsSetCacheClusterId())
            {
                request.Parameters.Add("CacheClusterId", StringUtils.FromString(publicRequest.CacheClusterId));
            }
            if (publicRequest.IsSetCacheNodeIdsToRemove())
            {
                if (publicRequest.CacheNodeIdsToRemove.Count == 0)
                {
                    request.Parameters.Add("CacheNodeIdsToRemove", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.CacheNodeIdsToRemove)
                    {
                        request.Parameters.Add("CacheNodeIdsToRemove" + ".CacheNodeId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
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
            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
            }
            if (publicRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
            }
            if (publicRequest.IsSetIpDiscovery())
            {
                request.Parameters.Add("IpDiscovery", StringUtils.FromString(publicRequest.IpDiscovery));
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
            if (publicRequest.IsSetNewAvailabilityZones())
            {
                if (publicRequest.NewAvailabilityZones.Count == 0)
                {
                    request.Parameters.Add("NewAvailabilityZones", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.NewAvailabilityZones)
                    {
                        request.Parameters.Add("NewAvailabilityZones" + ".PreferredAvailabilityZone" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetNotificationTopicArn())
            {
                request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(publicRequest.NotificationTopicArn));
            }
            if (publicRequest.IsSetNotificationTopicStatus())
            {
                request.Parameters.Add("NotificationTopicStatus", StringUtils.FromString(publicRequest.NotificationTopicStatus));
            }
            if (publicRequest.IsSetNumCacheNodes())
            {
                request.Parameters.Add("NumCacheNodes", StringUtils.FromInt(publicRequest.NumCacheNodes.Value));
            }
            if (publicRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
            }
            if (publicRequest.IsSetScaleConfig())
            {
                if (publicRequest.ScaleConfig.IsSetScaleIntervalMinutes())
                {
                    request.Parameters.Add("ScaleConfig" + ".ScaleIntervalMinutes", StringUtils.FromInt(publicRequest.ScaleConfig.ScaleIntervalMinutes.Value));
                }
                if (publicRequest.ScaleConfig.IsSetScalePercentage())
                {
                    request.Parameters.Add("ScaleConfig" + ".ScalePercentage", StringUtils.FromInt(publicRequest.ScaleConfig.ScalePercentage.Value));
                }
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
            if (publicRequest.IsSetSnapshotRetentionLimit())
            {
                request.Parameters.Add("SnapshotRetentionLimit", StringUtils.FromInt(publicRequest.SnapshotRetentionLimit.Value));
            }
            if (publicRequest.IsSetSnapshotWindow())
            {
                request.Parameters.Add("SnapshotWindow", StringUtils.FromString(publicRequest.SnapshotWindow));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyCacheClusterRequestMarshaller _instance = new();

        internal static ModifyCacheClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyCacheClusterRequestMarshaller Instance => _instance;
    }
}
