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
    /// ModifyDBCluster Request Marshaller
    /// </summary>
    public partial class ModifyDBClusterRequestMarshaller : IMarshaller<IRequest, ModifyDBClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyDBClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyDBCluster");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetAllocatedStorage())
            {
                request.Parameters.Add("AllocatedStorage", StringUtils.FromInt(publicRequest.AllocatedStorage.Value));
            }
            if (publicRequest.IsSetAllowEngineModeChange())
            {
                request.Parameters.Add("AllowEngineModeChange", StringUtils.FromBool(publicRequest.AllowEngineModeChange.Value));
            }
            if (publicRequest.IsSetAllowMajorVersionUpgrade())
            {
                request.Parameters.Add("AllowMajorVersionUpgrade", StringUtils.FromBool(publicRequest.AllowMajorVersionUpgrade.Value));
            }
            if (publicRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately.Value));
            }
            if (publicRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade.Value));
            }
            if (publicRequest.IsSetAwsBackupRecoveryPointArn())
            {
                request.Parameters.Add("AwsBackupRecoveryPointArn", StringUtils.FromString(publicRequest.AwsBackupRecoveryPointArn));
            }
            if (publicRequest.IsSetBacktrackWindow())
            {
                request.Parameters.Add("BacktrackWindow", StringUtils.FromLong(publicRequest.BacktrackWindow.Value));
            }
            if (publicRequest.IsSetBackupRetentionPeriod())
            {
                request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(publicRequest.BackupRetentionPeriod.Value));
            }
            if (publicRequest.IsSetCACertificateIdentifier())
            {
                request.Parameters.Add("CACertificateIdentifier", StringUtils.FromString(publicRequest.CACertificateIdentifier));
            }
            if (publicRequest.IsSetCloudwatchLogsExportConfiguration())
            {
                if (publicRequest.CloudwatchLogsExportConfiguration.IsSetDisableLogTypes())
                {
                    if (publicRequest.CloudwatchLogsExportConfiguration.DisableLogTypes.Count == 0)
                    {
                        request.Parameters.Add("CloudwatchLogsExportConfiguration" + ".DisableLogTypes", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.CloudwatchLogsExportConfiguration.DisableLogTypes)
                        {
                            request.Parameters.Add("CloudwatchLogsExportConfiguration" + ".DisableLogTypes" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.CloudwatchLogsExportConfiguration.IsSetEnableLogTypes())
                {
                    if (publicRequest.CloudwatchLogsExportConfiguration.EnableLogTypes.Count == 0)
                    {
                        request.Parameters.Add("CloudwatchLogsExportConfiguration" + ".EnableLogTypes", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.CloudwatchLogsExportConfiguration.EnableLogTypes)
                        {
                            request.Parameters.Add("CloudwatchLogsExportConfiguration" + ".EnableLogTypes" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
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
            if (publicRequest.IsSetDBInstanceParameterGroupName())
            {
                request.Parameters.Add("DBInstanceParameterGroupName", StringUtils.FromString(publicRequest.DBInstanceParameterGroupName));
            }
            if (publicRequest.IsSetDatabaseInsightsMode())
            {
                request.Parameters.Add("DatabaseInsightsMode", StringUtils.FromString(publicRequest.DatabaseInsightsMode));
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
            if (publicRequest.IsSetEnableGlobalWriteForwarding())
            {
                request.Parameters.Add("EnableGlobalWriteForwarding", StringUtils.FromBool(publicRequest.EnableGlobalWriteForwarding.Value));
            }
            if (publicRequest.IsSetEnableHttpEndpoint())
            {
                request.Parameters.Add("EnableHttpEndpoint", StringUtils.FromBool(publicRequest.EnableHttpEndpoint.Value));
            }
            if (publicRequest.IsSetEnableIAMDatabaseAuthentication())
            {
                request.Parameters.Add("EnableIAMDatabaseAuthentication", StringUtils.FromBool(publicRequest.EnableIAMDatabaseAuthentication.Value));
            }
            if (publicRequest.IsSetEnableLimitlessDatabase())
            {
                request.Parameters.Add("EnableLimitlessDatabase", StringUtils.FromBool(publicRequest.EnableLimitlessDatabase.Value));
            }
            if (publicRequest.IsSetEnableLocalWriteForwarding())
            {
                request.Parameters.Add("EnableLocalWriteForwarding", StringUtils.FromBool(publicRequest.EnableLocalWriteForwarding.Value));
            }
            if (publicRequest.IsSetEnablePerformanceInsights())
            {
                request.Parameters.Add("EnablePerformanceInsights", StringUtils.FromBool(publicRequest.EnablePerformanceInsights.Value));
            }
            if (publicRequest.IsSetEngineLifecycleSupport())
            {
                request.Parameters.Add("EngineLifecycleSupport", StringUtils.FromString(publicRequest.EngineLifecycleSupport));
            }
            if (publicRequest.IsSetEngineMode())
            {
                request.Parameters.Add("EngineMode", StringUtils.FromString(publicRequest.EngineMode));
            }
            if (publicRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
            }
            if (publicRequest.IsSetIops())
            {
                request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops.Value));
            }
            if (publicRequest.IsSetManageMasterUserPassword())
            {
                request.Parameters.Add("ManageMasterUserPassword", StringUtils.FromBool(publicRequest.ManageMasterUserPassword.Value));
            }
            if (publicRequest.IsSetMasterUserAuthenticationType())
            {
                request.Parameters.Add("MasterUserAuthenticationType", StringUtils.FromString(publicRequest.MasterUserAuthenticationType));
            }
            if (publicRequest.IsSetMasterUserPassword())
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
            }
            if (publicRequest.IsSetMasterUserSecretKmsKeyId())
            {
                request.Parameters.Add("MasterUserSecretKmsKeyId", StringUtils.FromString(publicRequest.MasterUserSecretKmsKeyId));
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
            if (publicRequest.IsSetNewDBClusterIdentifier())
            {
                request.Parameters.Add("NewDBClusterIdentifier", StringUtils.FromString(publicRequest.NewDBClusterIdentifier));
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
            if (publicRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
            }
            if (publicRequest.IsSetRotateMasterUserPassword())
            {
                request.Parameters.Add("RotateMasterUserPassword", StringUtils.FromBool(publicRequest.RotateMasterUserPassword.Value));
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
            if (publicRequest.IsSetStorageType())
            {
                request.Parameters.Add("StorageType", StringUtils.FromString(publicRequest.StorageType));
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

        private static readonly ModifyDBClusterRequestMarshaller _instance = new();

        internal static ModifyDBClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyDBClusterRequestMarshaller Instance => _instance;
    }
}
