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

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreDBClusterToPointInTime Request Marshaller
    /// </summary>
    public partial class RestoreDBClusterToPointInTimeRequestMarshaller : IMarshaller<IRequest, RestoreDBClusterToPointInTimeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreDBClusterToPointInTimeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RestoreDBClusterToPointInTimeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RestoreDBClusterToPointInTime");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetAssociatedRoles())
            {
                if (publicRequest.AssociatedRoles.Count == 0)
                {
                    request.Parameters.Add("AssociatedRoles", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AssociatedRoles)
                    {
                        if (item0.IsSetFeatureName())
                        {
                            request.Parameters.Add("AssociatedRoles" + ".DBClusterAssociatedRole" + "." + index0 + ".FeatureName", StringUtils.FromString(item0.FeatureName));
                        }
                        if (item0.IsSetRoleArn())
                        {
                            request.Parameters.Add("AssociatedRoles" + ".DBClusterAssociatedRole" + "." + index0 + ".RoleArn", StringUtils.FromString(item0.RoleArn));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetBacktrackWindow())
            {
                request.Parameters.Add("BacktrackWindow", StringUtils.FromLong(publicRequest.BacktrackWindow.Value));
            }
            if (publicRequest.IsSetBackupRetentionPeriod())
            {
                request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(publicRequest.BackupRetentionPeriod.Value));
            }
            if (publicRequest.IsSetCopyTagsToSnapshot())
            {
                request.Parameters.Add("CopyTagsToSnapshot", StringUtils.FromBool(publicRequest.CopyTagsToSnapshot.Value));
            }
            if (publicRequest.IsSetDBClusterIdentifier())
            {
                request.Parameters.Add("DBClusterIdentifier", StringUtils.FromString(publicRequest.DBClusterIdentifier));
            }
            if (publicRequest.IsSetDBClusterInstanceClass())
            {
                request.Parameters.Add("DBClusterInstanceClass", StringUtils.FromString(publicRequest.DBClusterInstanceClass));
            }
            if (publicRequest.IsSetDBClusterParameterGroupName())
            {
                request.Parameters.Add("DBClusterParameterGroupName", StringUtils.FromString(publicRequest.DBClusterParameterGroupName));
            }
            if (publicRequest.IsSetDBSubnetGroupName())
            {
                request.Parameters.Add("DBSubnetGroupName", StringUtils.FromString(publicRequest.DBSubnetGroupName));
            }
            if (publicRequest.IsSetDeletionProtection())
            {
                request.Parameters.Add("DeletionProtection", StringUtils.FromBool(publicRequest.DeletionProtection.Value));
            }
            if (publicRequest.IsSetDomain())
            {
                request.Parameters.Add("Domain", StringUtils.FromString(publicRequest.Domain));
            }
            if (publicRequest.IsSetDomainIAMRoleName())
            {
                request.Parameters.Add("DomainIAMRoleName", StringUtils.FromString(publicRequest.DomainIAMRoleName));
            }
            if (publicRequest.IsSetEnableCloudwatchLogsExports())
            {
                if (publicRequest.EnableCloudwatchLogsExports.Count == 0)
                {
                    request.Parameters.Add("EnableCloudwatchLogsExports", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.EnableCloudwatchLogsExports)
                    {
                        request.Parameters.Add("EnableCloudwatchLogsExports" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetEnableIAMDatabaseAuthentication())
            {
                request.Parameters.Add("EnableIAMDatabaseAuthentication", StringUtils.FromBool(publicRequest.EnableIAMDatabaseAuthentication.Value));
            }
            if (publicRequest.IsSetEnableInternetAccessGateway())
            {
                request.Parameters.Add("EnableInternetAccessGateway", StringUtils.FromBool(publicRequest.EnableInternetAccessGateway.Value));
            }
            if (publicRequest.IsSetEnablePerformanceInsights())
            {
                request.Parameters.Add("EnablePerformanceInsights", StringUtils.FromBool(publicRequest.EnablePerformanceInsights.Value));
            }
            if (publicRequest.IsSetEnableVPCNetworking())
            {
                request.Parameters.Add("EnableVPCNetworking", StringUtils.FromBool(publicRequest.EnableVPCNetworking.Value));
            }
            if (publicRequest.IsSetEngineLifecycleSupport())
            {
                request.Parameters.Add("EngineLifecycleSupport", StringUtils.FromString(publicRequest.EngineLifecycleSupport));
            }
            if (publicRequest.IsSetEngineMode())
            {
                request.Parameters.Add("EngineMode", StringUtils.FromString(publicRequest.EngineMode));
            }
            if (publicRequest.IsSetIops())
            {
                request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops.Value));
            }
            if (publicRequest.IsSetKmsKeyId())
            {
                request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
            }
            if (publicRequest.IsSetMonitoringInterval())
            {
                request.Parameters.Add("MonitoringInterval", StringUtils.FromInt(publicRequest.MonitoringInterval.Value));
            }
            if (publicRequest.IsSetMonitoringRoleArn())
            {
                request.Parameters.Add("MonitoringRoleArn", StringUtils.FromString(publicRequest.MonitoringRoleArn));
            }
            if (publicRequest.IsSetNetworkType())
            {
                request.Parameters.Add("NetworkType", StringUtils.FromString(publicRequest.NetworkType));
            }
            if (publicRequest.IsSetOptionGroupName())
            {
                request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
            }
            if (publicRequest.IsSetPerformanceInsightsKMSKeyId())
            {
                request.Parameters.Add("PerformanceInsightsKMSKeyId", StringUtils.FromString(publicRequest.PerformanceInsightsKMSKeyId));
            }
            if (publicRequest.IsSetPerformanceInsightsRetentionPeriod())
            {
                request.Parameters.Add("PerformanceInsightsRetentionPeriod", StringUtils.FromInt(publicRequest.PerformanceInsightsRetentionPeriod.Value));
            }
            if (publicRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port.Value));
            }
            if (publicRequest.IsSetPreferredBackupWindow())
            {
                request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(publicRequest.PreferredBackupWindow));
            }
            if (publicRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible.Value));
            }
            if (publicRequest.IsSetRdsCustomClusterConfiguration())
            {
                if (publicRequest.RdsCustomClusterConfiguration.IsSetInterconnectSubnetId())
                {
                    request.Parameters.Add("RdsCustomClusterConfiguration" + ".InterconnectSubnetId", StringUtils.FromString(publicRequest.RdsCustomClusterConfiguration.InterconnectSubnetId));
                }
                if (publicRequest.RdsCustomClusterConfiguration.IsSetReplicaMode())
                {
                    request.Parameters.Add("RdsCustomClusterConfiguration" + ".ReplicaMode", StringUtils.FromString(publicRequest.RdsCustomClusterConfiguration.ReplicaMode));
                }
                if (publicRequest.RdsCustomClusterConfiguration.IsSetTransitGatewayMulticastDomainId())
                {
                    request.Parameters.Add("RdsCustomClusterConfiguration" + ".TransitGatewayMulticastDomainId", StringUtils.FromString(publicRequest.RdsCustomClusterConfiguration.TransitGatewayMulticastDomainId));
                }
            }
            if (publicRequest.IsSetRestoreToTime())
            {
                request.Parameters.Add("RestoreToTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.RestoreToTime.Value));
            }
            if (publicRequest.IsSetRestoreType())
            {
                request.Parameters.Add("RestoreType", StringUtils.FromString(publicRequest.RestoreType));
            }
            if (publicRequest.IsSetScalingConfiguration())
            {
                if (publicRequest.ScalingConfiguration.IsSetAutoPause())
                {
                    request.Parameters.Add("ScalingConfiguration" + ".AutoPause", StringUtils.FromBool(publicRequest.ScalingConfiguration.AutoPause.Value));
                }
                if (publicRequest.ScalingConfiguration.IsSetMaxCapacity())
                {
                    request.Parameters.Add("ScalingConfiguration" + ".MaxCapacity", StringUtils.FromInt(publicRequest.ScalingConfiguration.MaxCapacity.Value));
                }
                if (publicRequest.ScalingConfiguration.IsSetMinCapacity())
                {
                    request.Parameters.Add("ScalingConfiguration" + ".MinCapacity", StringUtils.FromInt(publicRequest.ScalingConfiguration.MinCapacity.Value));
                }
                if (publicRequest.ScalingConfiguration.IsSetSecondsBeforeTimeout())
                {
                    request.Parameters.Add("ScalingConfiguration" + ".SecondsBeforeTimeout", StringUtils.FromInt(publicRequest.ScalingConfiguration.SecondsBeforeTimeout.Value));
                }
                if (publicRequest.ScalingConfiguration.IsSetSecondsUntilAutoPause())
                {
                    request.Parameters.Add("ScalingConfiguration" + ".SecondsUntilAutoPause", StringUtils.FromInt(publicRequest.ScalingConfiguration.SecondsUntilAutoPause.Value));
                }
                if (publicRequest.ScalingConfiguration.IsSetTimeoutAction())
                {
                    request.Parameters.Add("ScalingConfiguration" + ".TimeoutAction", StringUtils.FromString(publicRequest.ScalingConfiguration.TimeoutAction));
                }
            }
            if (publicRequest.IsSetServerlessV2ScalingConfiguration())
            {
                if (publicRequest.ServerlessV2ScalingConfiguration.IsSetMaxCapacity())
                {
                    request.Parameters.Add("ServerlessV2ScalingConfiguration" + ".MaxCapacity", StringUtils.FromDouble(publicRequest.ServerlessV2ScalingConfiguration.MaxCapacity.Value));
                }
                if (publicRequest.ServerlessV2ScalingConfiguration.IsSetMinCapacity())
                {
                    request.Parameters.Add("ServerlessV2ScalingConfiguration" + ".MinCapacity", StringUtils.FromDouble(publicRequest.ServerlessV2ScalingConfiguration.MinCapacity.Value));
                }
                if (publicRequest.ServerlessV2ScalingConfiguration.IsSetSecondsUntilAutoPause())
                {
                    request.Parameters.Add("ServerlessV2ScalingConfiguration" + ".SecondsUntilAutoPause", StringUtils.FromInt(publicRequest.ServerlessV2ScalingConfiguration.SecondsUntilAutoPause.Value));
                }
            }
            if (publicRequest.IsSetSourceDBClusterIdentifier())
            {
                request.Parameters.Add("SourceDBClusterIdentifier", StringUtils.FromString(publicRequest.SourceDBClusterIdentifier));
            }
            if (publicRequest.IsSetSourceDbClusterResourceId())
            {
                request.Parameters.Add("SourceDbClusterResourceId", StringUtils.FromString(publicRequest.SourceDbClusterResourceId));
            }
            if (publicRequest.IsSetStorageType())
            {
                request.Parameters.Add("StorageType", StringUtils.FromString(publicRequest.StorageType));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecifications", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecifications" + ".item" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecifications" + ".item" + "." + index0 + ".Tags", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecifications" + ".item" + "." + index0 + ".Tags" + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecifications" + ".item" + "." + index0 + ".Tags" + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
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
            if (publicRequest.IsSetUseLatestRestorableTime())
            {
                request.Parameters.Add("UseLatestRestorableTime", StringUtils.FromBool(publicRequest.UseLatestRestorableTime.Value));
            }
            if (publicRequest.IsSetVpcSecurityGroupIds())
            {
                if (publicRequest.VpcSecurityGroupIds.Count == 0)
                {
                    request.Parameters.Add("VpcSecurityGroupIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + ".VpcSecurityGroupId" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly RestoreDBClusterToPointInTimeRequestMarshaller _instance = new();

        internal static RestoreDBClusterToPointInTimeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RestoreDBClusterToPointInTimeRequestMarshaller Instance => _instance;
    }
}
