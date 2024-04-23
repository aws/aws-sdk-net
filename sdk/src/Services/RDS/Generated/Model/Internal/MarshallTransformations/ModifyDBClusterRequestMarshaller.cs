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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDBCluster Request Marshaller
    /// </summary>       
    public class ModifyDBClusterRequestMarshaller : IMarshaller<IRequest, ModifyDBClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBClusterRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyDBClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ModifyDBCluster");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllocatedStorage())
                {
                    request.Parameters.Add("AllocatedStorage", StringUtils.FromInt(publicRequest.AllocatedStorage));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAllowEngineModeChange())
                {
                    request.Parameters.Add("AllowEngineModeChange", StringUtils.FromBool(publicRequest.AllowEngineModeChange));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAllowMajorVersionUpgrade())
                {
                    request.Parameters.Add("AllowMajorVersionUpgrade", StringUtils.FromBool(publicRequest.AllowMajorVersionUpgrade));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAwsBackupRecoveryPointArn())
                {
                    request.Parameters.Add("AwsBackupRecoveryPointArn", StringUtils.FromString(publicRequest.AwsBackupRecoveryPointArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetBacktrackWindow())
                {
                    request.Parameters.Add("BacktrackWindow", StringUtils.FromLong(publicRequest.BacktrackWindow));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetBackupRetentionPeriod())
                {
                    request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(publicRequest.BackupRetentionPeriod));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCACertificateIdentifier())
                {
                    request.Parameters.Add("CACertificateIdentifier", StringUtils.FromString(publicRequest.CACertificateIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCloudwatchLogsExportConfiguration())
                {
                    if(publicRequest.CloudwatchLogsExportConfiguration.IsSetDisableLogTypes())
                    {
                        int publicRequestCloudwatchLogsExportConfigurationlistValueIndex = 1;
                        foreach(var publicRequestCloudwatchLogsExportConfigurationlistValue in publicRequest.CloudwatchLogsExportConfiguration.DisableLogTypes)
                        {
                            request.Parameters.Add("CloudwatchLogsExportConfiguration" + "." + "DisableLogTypes" + "." + "member" + "." + publicRequestCloudwatchLogsExportConfigurationlistValueIndex, StringUtils.FromString(publicRequestCloudwatchLogsExportConfigurationlistValue));
                            publicRequestCloudwatchLogsExportConfigurationlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.CloudwatchLogsExportConfiguration.IsSetEnableLogTypes())
                    {
                        int publicRequestCloudwatchLogsExportConfigurationlistValueIndex = 1;
                        foreach(var publicRequestCloudwatchLogsExportConfigurationlistValue in publicRequest.CloudwatchLogsExportConfiguration.EnableLogTypes)
                        {
                            request.Parameters.Add("CloudwatchLogsExportConfiguration" + "." + "EnableLogTypes" + "." + "member" + "." + publicRequestCloudwatchLogsExportConfigurationlistValueIndex, StringUtils.FromString(publicRequestCloudwatchLogsExportConfigurationlistValue));
                            publicRequestCloudwatchLogsExportConfigurationlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCopyTagsToSnapshot())
                {
                    request.Parameters.Add("CopyTagsToSnapshot", StringUtils.FromBool(publicRequest.CopyTagsToSnapshot));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBClusterIdentifier())
                {
                    request.Parameters.Add("DBClusterIdentifier", StringUtils.FromString(publicRequest.DBClusterIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBClusterInstanceClass())
                {
                    request.Parameters.Add("DBClusterInstanceClass", StringUtils.FromString(publicRequest.DBClusterInstanceClass));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBClusterParameterGroupName())
                {
                    request.Parameters.Add("DBClusterParameterGroupName", StringUtils.FromString(publicRequest.DBClusterParameterGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBInstanceParameterGroupName())
                {
                    request.Parameters.Add("DBInstanceParameterGroupName", StringUtils.FromString(publicRequest.DBInstanceParameterGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDeletionProtection())
                {
                    request.Parameters.Add("DeletionProtection", StringUtils.FromBool(publicRequest.DeletionProtection));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomain())
                {
                    request.Parameters.Add("Domain", StringUtils.FromString(publicRequest.Domain));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomainIAMRoleName())
                {
                    request.Parameters.Add("DomainIAMRoleName", StringUtils.FromString(publicRequest.DomainIAMRoleName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableGlobalWriteForwarding())
                {
                    request.Parameters.Add("EnableGlobalWriteForwarding", StringUtils.FromBool(publicRequest.EnableGlobalWriteForwarding));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableHttpEndpoint())
                {
                    request.Parameters.Add("EnableHttpEndpoint", StringUtils.FromBool(publicRequest.EnableHttpEndpoint));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableIAMDatabaseAuthentication())
                {
                    request.Parameters.Add("EnableIAMDatabaseAuthentication", StringUtils.FromBool(publicRequest.EnableIAMDatabaseAuthentication));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableLimitlessDatabase())
                {
                    request.Parameters.Add("EnableLimitlessDatabase", StringUtils.FromBool(publicRequest.EnableLimitlessDatabase));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableLocalWriteForwarding())
                {
                    request.Parameters.Add("EnableLocalWriteForwarding", StringUtils.FromBool(publicRequest.EnableLocalWriteForwarding));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnablePerformanceInsights())
                {
                    request.Parameters.Add("EnablePerformanceInsights", StringUtils.FromBool(publicRequest.EnablePerformanceInsights));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEngineMode())
                {
                    request.Parameters.Add("EngineMode", StringUtils.FromString(publicRequest.EngineMode));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEngineVersion())
                {
                    request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIops())
                {
                    request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetManageMasterUserPassword())
                {
                    request.Parameters.Add("ManageMasterUserPassword", StringUtils.FromBool(publicRequest.ManageMasterUserPassword));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMasterUserPassword())
                {
                    request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMasterUserSecretKmsKeyId())
                {
                    request.Parameters.Add("MasterUserSecretKmsKeyId", StringUtils.FromString(publicRequest.MasterUserSecretKmsKeyId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMonitoringInterval())
                {
                    request.Parameters.Add("MonitoringInterval", StringUtils.FromInt(publicRequest.MonitoringInterval));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMonitoringRoleArn())
                {
                    request.Parameters.Add("MonitoringRoleArn", StringUtils.FromString(publicRequest.MonitoringRoleArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNetworkType())
                {
                    request.Parameters.Add("NetworkType", StringUtils.FromString(publicRequest.NetworkType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNewDBClusterIdentifier())
                {
                    request.Parameters.Add("NewDBClusterIdentifier", StringUtils.FromString(publicRequest.NewDBClusterIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOptionGroupName())
                {
                    request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPerformanceInsightsKMSKeyId())
                {
                    request.Parameters.Add("PerformanceInsightsKMSKeyId", StringUtils.FromString(publicRequest.PerformanceInsightsKMSKeyId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPerformanceInsightsRetentionPeriod())
                {
                    request.Parameters.Add("PerformanceInsightsRetentionPeriod", StringUtils.FromInt(publicRequest.PerformanceInsightsRetentionPeriod));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPreferredBackupWindow())
                {
                    request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(publicRequest.PreferredBackupWindow));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRotateMasterUserPassword())
                {
                    request.Parameters.Add("RotateMasterUserPassword", StringUtils.FromBool(publicRequest.RotateMasterUserPassword));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetScalingConfiguration())
                {
                    if(publicRequest.ScalingConfiguration.IsSetAutoPause())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "AutoPause", StringUtils.FromBool(publicRequest.ScalingConfiguration.AutoPause));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ScalingConfiguration.IsSetMaxCapacity())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "MaxCapacity", StringUtils.FromInt(publicRequest.ScalingConfiguration.MaxCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ScalingConfiguration.IsSetMinCapacity())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "MinCapacity", StringUtils.FromInt(publicRequest.ScalingConfiguration.MinCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ScalingConfiguration.IsSetSecondsBeforeTimeout())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "SecondsBeforeTimeout", StringUtils.FromInt(publicRequest.ScalingConfiguration.SecondsBeforeTimeout));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ScalingConfiguration.IsSetSecondsUntilAutoPause())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "SecondsUntilAutoPause", StringUtils.FromInt(publicRequest.ScalingConfiguration.SecondsUntilAutoPause));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ScalingConfiguration.IsSetTimeoutAction())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "TimeoutAction", StringUtils.FromString(publicRequest.ScalingConfiguration.TimeoutAction));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetServerlessV2ScalingConfiguration())
                {
                    if(publicRequest.ServerlessV2ScalingConfiguration.IsSetMaxCapacity())
                    {
                        request.Parameters.Add("ServerlessV2ScalingConfiguration" + "." + "MaxCapacity", StringUtils.FromDouble(publicRequest.ServerlessV2ScalingConfiguration.MaxCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ServerlessV2ScalingConfiguration.IsSetMinCapacity())
                    {
                        request.Parameters.Add("ServerlessV2ScalingConfiguration" + "." + "MinCapacity", StringUtils.FromDouble(publicRequest.ServerlessV2ScalingConfiguration.MinCapacity));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetStorageType())
                {
                    request.Parameters.Add("StorageType", StringUtils.FromString(publicRequest.StorageType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ModifyDBClusterRequestMarshaller _instance = new ModifyDBClusterRequestMarshaller();        

        internal static ModifyDBClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDBClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}