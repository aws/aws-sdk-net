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
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDBInstance Request Marshaller
    /// </summary>       
    public class ModifyDBInstanceRequestMarshaller : IMarshaller<IRequest, ModifyDBInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBInstanceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyDBInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ModifyDBInstance");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllocatedStorage())
                {
                    request.Parameters.Add("AllocatedStorage", StringUtils.FromInt(publicRequest.AllocatedStorage));
                }
                if(publicRequest.IsSetAllowMajorVersionUpgrade())
                {
                    request.Parameters.Add("AllowMajorVersionUpgrade", StringUtils.FromBool(publicRequest.AllowMajorVersionUpgrade));
                }
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
                if(publicRequest.IsSetAutomationMode())
                {
                    request.Parameters.Add("AutomationMode", StringUtils.FromString(publicRequest.AutomationMode));
                }
                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade));
                }
                if(publicRequest.IsSetAwsBackupRecoveryPointArn())
                {
                    request.Parameters.Add("AwsBackupRecoveryPointArn", StringUtils.FromString(publicRequest.AwsBackupRecoveryPointArn));
                }
                if(publicRequest.IsSetBackupRetentionPeriod())
                {
                    request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(publicRequest.BackupRetentionPeriod));
                }
                if(publicRequest.IsSetCACertificateIdentifier())
                {
                    request.Parameters.Add("CACertificateIdentifier", StringUtils.FromString(publicRequest.CACertificateIdentifier));
                }
                if(publicRequest.IsSetCertificateRotationRestart())
                {
                    request.Parameters.Add("CertificateRotationRestart", StringUtils.FromBool(publicRequest.CertificateRotationRestart));
                }
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
                    if(publicRequest.CloudwatchLogsExportConfiguration.IsSetEnableLogTypes())
                    {
                        int publicRequestCloudwatchLogsExportConfigurationlistValueIndex = 1;
                        foreach(var publicRequestCloudwatchLogsExportConfigurationlistValue in publicRequest.CloudwatchLogsExportConfiguration.EnableLogTypes)
                        {
                            request.Parameters.Add("CloudwatchLogsExportConfiguration" + "." + "EnableLogTypes" + "." + "member" + "." + publicRequestCloudwatchLogsExportConfigurationlistValueIndex, StringUtils.FromString(publicRequestCloudwatchLogsExportConfigurationlistValue));
                            publicRequestCloudwatchLogsExportConfigurationlistValueIndex++;
                        }
                    }
                }
                if(publicRequest.IsSetCopyTagsToSnapshot())
                {
                    request.Parameters.Add("CopyTagsToSnapshot", StringUtils.FromBool(publicRequest.CopyTagsToSnapshot));
                }
                if(publicRequest.IsSetDBInstanceClass())
                {
                    request.Parameters.Add("DBInstanceClass", StringUtils.FromString(publicRequest.DBInstanceClass));
                }
                if(publicRequest.IsSetDBInstanceIdentifier())
                {
                    request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(publicRequest.DBInstanceIdentifier));
                }
                if(publicRequest.IsSetDBParameterGroupName())
                {
                    request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(publicRequest.DBParameterGroupName));
                }
                if(publicRequest.IsSetDBPortNumber())
                {
                    request.Parameters.Add("DBPortNumber", StringUtils.FromInt(publicRequest.DBPortNumber));
                }
                if(publicRequest.IsSetDBSecurityGroups())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.DBSecurityGroups)
                    {
                        request.Parameters.Add("DBSecurityGroups" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetDBSubnetGroupName())
                {
                    request.Parameters.Add("DBSubnetGroupName", StringUtils.FromString(publicRequest.DBSubnetGroupName));
                }
                if(publicRequest.IsSetDeletionProtection())
                {
                    request.Parameters.Add("DeletionProtection", StringUtils.FromBool(publicRequest.DeletionProtection));
                }
                if(publicRequest.IsSetDomain())
                {
                    request.Parameters.Add("Domain", StringUtils.FromString(publicRequest.Domain));
                }
                if(publicRequest.IsSetDomainIAMRoleName())
                {
                    request.Parameters.Add("DomainIAMRoleName", StringUtils.FromString(publicRequest.DomainIAMRoleName));
                }
                if(publicRequest.IsSetEnableCustomerOwnedIp())
                {
                    request.Parameters.Add("EnableCustomerOwnedIp", StringUtils.FromBool(publicRequest.EnableCustomerOwnedIp));
                }
                if(publicRequest.IsSetEnableIAMDatabaseAuthentication())
                {
                    request.Parameters.Add("EnableIAMDatabaseAuthentication", StringUtils.FromBool(publicRequest.EnableIAMDatabaseAuthentication));
                }
                if(publicRequest.IsSetEnablePerformanceInsights())
                {
                    request.Parameters.Add("EnablePerformanceInsights", StringUtils.FromBool(publicRequest.EnablePerformanceInsights));
                }
                if(publicRequest.IsSetEngineVersion())
                {
                    request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
                }
                if(publicRequest.IsSetIops())
                {
                    request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops));
                }
                if(publicRequest.IsSetLicenseModel())
                {
                    request.Parameters.Add("LicenseModel", StringUtils.FromString(publicRequest.LicenseModel));
                }
                if(publicRequest.IsSetManageMasterUserPassword())
                {
                    request.Parameters.Add("ManageMasterUserPassword", StringUtils.FromBool(publicRequest.ManageMasterUserPassword));
                }
                if(publicRequest.IsSetMasterUserPassword())
                {
                    request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
                }
                if(publicRequest.IsSetMasterUserSecretKmsKeyId())
                {
                    request.Parameters.Add("MasterUserSecretKmsKeyId", StringUtils.FromString(publicRequest.MasterUserSecretKmsKeyId));
                }
                if(publicRequest.IsSetMaxAllocatedStorage())
                {
                    request.Parameters.Add("MaxAllocatedStorage", StringUtils.FromInt(publicRequest.MaxAllocatedStorage));
                }
                if(publicRequest.IsSetMonitoringInterval())
                {
                    request.Parameters.Add("MonitoringInterval", StringUtils.FromInt(publicRequest.MonitoringInterval));
                }
                if(publicRequest.IsSetMonitoringRoleArn())
                {
                    request.Parameters.Add("MonitoringRoleArn", StringUtils.FromString(publicRequest.MonitoringRoleArn));
                }
                if(publicRequest.IsSetMultiAZ())
                {
                    request.Parameters.Add("MultiAZ", StringUtils.FromBool(publicRequest.MultiAZ));
                }
                if(publicRequest.IsSetNetworkType())
                {
                    request.Parameters.Add("NetworkType", StringUtils.FromString(publicRequest.NetworkType));
                }
                if(publicRequest.IsSetNewDBInstanceIdentifier())
                {
                    request.Parameters.Add("NewDBInstanceIdentifier", StringUtils.FromString(publicRequest.NewDBInstanceIdentifier));
                }
                if(publicRequest.IsSetOptionGroupName())
                {
                    request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
                }
                if(publicRequest.IsSetPerformanceInsightsKMSKeyId())
                {
                    request.Parameters.Add("PerformanceInsightsKMSKeyId", StringUtils.FromString(publicRequest.PerformanceInsightsKMSKeyId));
                }
                if(publicRequest.IsSetPerformanceInsightsRetentionPeriod())
                {
                    request.Parameters.Add("PerformanceInsightsRetentionPeriod", StringUtils.FromInt(publicRequest.PerformanceInsightsRetentionPeriod));
                }
                if(publicRequest.IsSetPreferredBackupWindow())
                {
                    request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(publicRequest.PreferredBackupWindow));
                }
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
                if(publicRequest.IsSetProcessorFeatures())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ProcessorFeatures)
                    {
                        if(publicRequestlistValue.IsSetName())
                        {
                            request.Parameters.Add("ProcessorFeatures" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("ProcessorFeatures" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetPromotionTier())
                {
                    request.Parameters.Add("PromotionTier", StringUtils.FromInt(publicRequest.PromotionTier));
                }
                if(publicRequest.IsSetPubliclyAccessible())
                {
                    request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible));
                }
                if(publicRequest.IsSetReplicaMode())
                {
                    request.Parameters.Add("ReplicaMode", StringUtils.FromString(publicRequest.ReplicaMode));
                }
                if(publicRequest.IsSetResumeFullAutomationModeMinutes())
                {
                    request.Parameters.Add("ResumeFullAutomationModeMinutes", StringUtils.FromInt(publicRequest.ResumeFullAutomationModeMinutes));
                }
                if(publicRequest.IsSetRotateMasterUserPassword())
                {
                    request.Parameters.Add("RotateMasterUserPassword", StringUtils.FromBool(publicRequest.RotateMasterUserPassword));
                }
                if(publicRequest.IsSetStorageThroughput())
                {
                    request.Parameters.Add("StorageThroughput", StringUtils.FromInt(publicRequest.StorageThroughput));
                }
                if(publicRequest.IsSetStorageType())
                {
                    request.Parameters.Add("StorageType", StringUtils.FromString(publicRequest.StorageType));
                }
                if(publicRequest.IsSetTdeCredentialArn())
                {
                    request.Parameters.Add("TdeCredentialArn", StringUtils.FromString(publicRequest.TdeCredentialArn));
                }
                if(publicRequest.IsSetTdeCredentialPassword())
                {
                    request.Parameters.Add("TdeCredentialPassword", StringUtils.FromString(publicRequest.TdeCredentialPassword));
                }
                if(publicRequest.IsSetUseDefaultProcessorFeatures())
                {
                    request.Parameters.Add("UseDefaultProcessorFeatures", StringUtils.FromBool(publicRequest.UseDefaultProcessorFeatures));
                }
                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static ModifyDBInstanceRequestMarshaller _instance = new ModifyDBInstanceRequestMarshaller();        

        internal static ModifyDBInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDBInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}