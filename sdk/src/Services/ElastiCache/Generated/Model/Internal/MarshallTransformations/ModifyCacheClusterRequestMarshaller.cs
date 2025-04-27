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
    /// ModifyCacheCluster Request Marshaller
    /// </summary>       
    public class ModifyCacheClusterRequestMarshaller : IMarshaller<IRequest, ModifyCacheClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyCacheClusterRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyCacheClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "ModifyCacheCluster");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
                if(publicRequest.IsSetAuthToken())
                {
                    request.Parameters.Add("AuthToken", StringUtils.FromString(publicRequest.AuthToken));
                }
                if(publicRequest.IsSetAuthTokenUpdateStrategy())
                {
                    request.Parameters.Add("AuthTokenUpdateStrategy", StringUtils.FromString(publicRequest.AuthTokenUpdateStrategy));
                }
                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade));
                }
                if(publicRequest.IsSetAZMode())
                {
                    request.Parameters.Add("AZMode", StringUtils.FromString(publicRequest.AZMode));
                }
                if(publicRequest.IsSetCacheClusterId())
                {
                    request.Parameters.Add("CacheClusterId", StringUtils.FromString(publicRequest.CacheClusterId));
                }
                if(publicRequest.IsSetCacheNodeIdsToRemove())
                {
                    if (publicRequest.CacheNodeIdsToRemove.Count == 0)
                        request.Parameters.Add("CacheNodeIdsToRemove", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.CacheNodeIdsToRemove)
                         {
                             request.Parameters.Add("CacheNodeIdsToRemove" + "." + "CacheNodeId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
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
                    if (publicRequest.CacheSecurityGroupNames.Count == 0)
                        request.Parameters.Add("CacheSecurityGroupNames", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.CacheSecurityGroupNames)
                         {
                             request.Parameters.Add("CacheSecurityGroupNames" + "." + "CacheSecurityGroupName" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetEngine())
                {
                    request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
                }
                if(publicRequest.IsSetEngineVersion())
                {
                    request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
                }
                if(publicRequest.IsSetIpDiscovery())
                {
                    request.Parameters.Add("IpDiscovery", StringUtils.FromString(publicRequest.IpDiscovery));
                }
                if(publicRequest.IsSetLogDeliveryConfigurations())
                {
                    if (publicRequest.LogDeliveryConfigurations.Count == 0)
                        request.Parameters.Add("LogDeliveryConfigurations", "");
                    else
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
                                        request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "DestinationDetails" + "." + "CloudWatchLogsDetails" + "." + "LogGroup", StringUtils.FromString(publicRequestlistValue.DestinationDetails.CloudWatchLogsDetails.LogGroup));
                                    }
                                }
                                if(publicRequestlistValue.DestinationDetails.IsSetKinesisFirehoseDetails())
                                {
                                    if(publicRequestlistValue.DestinationDetails.KinesisFirehoseDetails.IsSetDeliveryStream())
                                    {
                                        request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "DestinationDetails" + "." + "KinesisFirehoseDetails" + "." + "DeliveryStream", StringUtils.FromString(publicRequestlistValue.DestinationDetails.KinesisFirehoseDetails.DeliveryStream));
                                    }
                                }
                            }
                            if(publicRequestlistValue.IsSetDestinationType())
                            {
                                request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "DestinationType", StringUtils.FromString(publicRequestlistValue.DestinationType));
                            }
                            if(publicRequestlistValue.IsSetEnabled())
                            {
                                request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "Enabled", StringUtils.FromBool(publicRequestlistValue.Enabled));
                            }
                            if(publicRequestlistValue.IsSetLogFormat())
                            {
                                request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "LogFormat", StringUtils.FromString(publicRequestlistValue.LogFormat));
                            }
                            if(publicRequestlistValue.IsSetLogType())
                            {
                                request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "LogType", StringUtils.FromString(publicRequestlistValue.LogType));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNewAvailabilityZones())
                {
                    if (publicRequest.NewAvailabilityZones.Count == 0)
                        request.Parameters.Add("NewAvailabilityZones", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NewAvailabilityZones)
                         {
                             request.Parameters.Add("NewAvailabilityZones" + "." + "PreferredAvailabilityZone" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNotificationTopicArn())
                {
                    request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(publicRequest.NotificationTopicArn));
                }
                if(publicRequest.IsSetNotificationTopicStatus())
                {
                    request.Parameters.Add("NotificationTopicStatus", StringUtils.FromString(publicRequest.NotificationTopicStatus));
                }
                if(publicRequest.IsSetNumCacheNodes())
                {
                    request.Parameters.Add("NumCacheNodes", StringUtils.FromInt(publicRequest.NumCacheNodes));
                }
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
                if(publicRequest.IsSetScaleConfig())
                {
                    if(publicRequest.ScaleConfig.IsSetScaleIntervalMinutes())
                    {
                        request.Parameters.Add("ScaleConfig" + "." + "ScaleIntervalMinutes", StringUtils.FromInt(publicRequest.ScaleConfig.ScaleIntervalMinutes));
                    }
                    if(publicRequest.ScaleConfig.IsSetScalePercentage())
                    {
                        request.Parameters.Add("ScaleConfig" + "." + "ScalePercentage", StringUtils.FromInt(publicRequest.ScaleConfig.ScalePercentage));
                    }
                }
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    if (publicRequest.SecurityGroupIds.Count == 0)
                        request.Parameters.Add("SecurityGroupIds", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                         {
                             request.Parameters.Add("SecurityGroupIds" + "." + "SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSnapshotRetentionLimit())
                {
                    request.Parameters.Add("SnapshotRetentionLimit", StringUtils.FromInt(publicRequest.SnapshotRetentionLimit));
                }
                if(publicRequest.IsSetSnapshotWindow())
                {
                    request.Parameters.Add("SnapshotWindow", StringUtils.FromString(publicRequest.SnapshotWindow));
                }
            }
            return request;
        }
                    private static ModifyCacheClusterRequestMarshaller _instance = new ModifyCacheClusterRequestMarshaller();        

        internal static ModifyCacheClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyCacheClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}