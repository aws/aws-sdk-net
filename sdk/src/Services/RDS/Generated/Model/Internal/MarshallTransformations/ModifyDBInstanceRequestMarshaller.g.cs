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
    /// ModifyDBInstance Request Marshaller
    /// </summary>
    public partial class ModifyDBInstanceRequestMarshaller : IMarshaller<IRequest, ModifyDBInstanceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBInstanceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyDBInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyDBInstance");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetAdditionalStorageVolumes())
            {
                if (publicRequest.AdditionalStorageVolumes.Count == 0)
                {
                    request.Parameters.Add("AdditionalStorageVolumes", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AdditionalStorageVolumes)
                    {
                        if (item0.IsSetAllocatedStorage())
                        {
                            request.Parameters.Add("AdditionalStorageVolumes" + ".member" + "." + index0 + ".AllocatedStorage", StringUtils.FromInt(item0.AllocatedStorage.Value));
                        }
                        if (item0.IsSetIOPS())
                        {
                            request.Parameters.Add("AdditionalStorageVolumes" + ".member" + "." + index0 + ".IOPS", StringUtils.FromInt(item0.IOPS.Value));
                        }
                        if (item0.IsSetMaxAllocatedStorage())
                        {
                            request.Parameters.Add("AdditionalStorageVolumes" + ".member" + "." + index0 + ".MaxAllocatedStorage", StringUtils.FromInt(item0.MaxAllocatedStorage.Value));
                        }
                        if (item0.IsSetSetForDelete())
                        {
                            request.Parameters.Add("AdditionalStorageVolumes" + ".member" + "." + index0 + ".SetForDelete", StringUtils.FromBool(item0.SetForDelete.Value));
                        }
                        if (item0.IsSetStorageThroughput())
                        {
                            request.Parameters.Add("AdditionalStorageVolumes" + ".member" + "." + index0 + ".StorageThroughput", StringUtils.FromInt(item0.StorageThroughput.Value));
                        }
                        if (item0.IsSetStorageType())
                        {
                            request.Parameters.Add("AdditionalStorageVolumes" + ".member" + "." + index0 + ".StorageType", StringUtils.FromString(item0.StorageType));
                        }
                        if (item0.IsSetVolumeName())
                        {
                            request.Parameters.Add("AdditionalStorageVolumes" + ".member" + "." + index0 + ".VolumeName", StringUtils.FromString(item0.VolumeName));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetAllocatedStorage())
            {
                request.Parameters.Add("AllocatedStorage", StringUtils.FromInt(publicRequest.AllocatedStorage.Value));
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
            if (publicRequest.IsSetAutomationMode())
            {
                request.Parameters.Add("AutomationMode", StringUtils.FromString(publicRequest.AutomationMode));
            }
            if (publicRequest.IsSetAwsBackupRecoveryPointArn())
            {
                request.Parameters.Add("AwsBackupRecoveryPointArn", StringUtils.FromString(publicRequest.AwsBackupRecoveryPointArn));
            }
            if (publicRequest.IsSetBackupRetentionPeriod())
            {
                request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(publicRequest.BackupRetentionPeriod.Value));
            }
            if (publicRequest.IsSetCACertificateIdentifier())
            {
                request.Parameters.Add("CACertificateIdentifier", StringUtils.FromString(publicRequest.CACertificateIdentifier));
            }
            if (publicRequest.IsSetCertificateRotationRestart())
            {
                request.Parameters.Add("CertificateRotationRestart", StringUtils.FromBool(publicRequest.CertificateRotationRestart.Value));
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
            if (publicRequest.IsSetDBCapacityReservationIdentifier())
            {
                request.Parameters.Add("DBCapacityReservationIdentifier", StringUtils.FromString(publicRequest.DBCapacityReservationIdentifier));
            }
            if (publicRequest.IsSetDBInstanceClass())
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(publicRequest.DBInstanceClass));
            }
            if (publicRequest.IsSetDBInstanceIdentifier())
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(publicRequest.DBInstanceIdentifier));
            }
            if (publicRequest.IsSetDBParameterGroupName())
            {
                request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(publicRequest.DBParameterGroupName));
            }
            if (publicRequest.IsSetDBPortNumber())
            {
                request.Parameters.Add("DBPortNumber", StringUtils.FromInt(publicRequest.DBPortNumber.Value));
            }
            if (publicRequest.IsSetDBSecurityGroups())
            {
                if (publicRequest.DBSecurityGroups.Count == 0)
                {
                    request.Parameters.Add("DBSecurityGroups", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DBSecurityGroups)
                    {
                        request.Parameters.Add("DBSecurityGroups" + ".DBSecurityGroupName" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDBSubnetGroupName())
            {
                request.Parameters.Add("DBSubnetGroupName", StringUtils.FromString(publicRequest.DBSubnetGroupName));
            }
            if (publicRequest.IsSetDatabaseInsightsMode())
            {
                request.Parameters.Add("DatabaseInsightsMode", StringUtils.FromString(publicRequest.DatabaseInsightsMode));
            }
            if (publicRequest.IsSetDedicatedLogVolume())
            {
                request.Parameters.Add("DedicatedLogVolume", StringUtils.FromBool(publicRequest.DedicatedLogVolume.Value));
            }
            if (publicRequest.IsSetDeletionProtection())
            {
                request.Parameters.Add("DeletionProtection", StringUtils.FromBool(publicRequest.DeletionProtection.Value));
            }
            if (publicRequest.IsSetDisableDomain())
            {
                request.Parameters.Add("DisableDomain", StringUtils.FromBool(publicRequest.DisableDomain.Value));
            }
            if (publicRequest.IsSetDomain())
            {
                request.Parameters.Add("Domain", StringUtils.FromString(publicRequest.Domain));
            }
            if (publicRequest.IsSetDomainAuthSecretArn())
            {
                request.Parameters.Add("DomainAuthSecretArn", StringUtils.FromString(publicRequest.DomainAuthSecretArn));
            }
            if (publicRequest.IsSetDomainDnsIps())
            {
                if (publicRequest.DomainDnsIps.Count == 0)
                {
                    request.Parameters.Add("DomainDnsIps", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DomainDnsIps)
                    {
                        request.Parameters.Add("DomainDnsIps" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDomainFqdn())
            {
                request.Parameters.Add("DomainFqdn", StringUtils.FromString(publicRequest.DomainFqdn));
            }
            if (publicRequest.IsSetDomainIAMRoleName())
            {
                request.Parameters.Add("DomainIAMRoleName", StringUtils.FromString(publicRequest.DomainIAMRoleName));
            }
            if (publicRequest.IsSetDomainOu())
            {
                request.Parameters.Add("DomainOu", StringUtils.FromString(publicRequest.DomainOu));
            }
            if (publicRequest.IsSetEnableCustomerOwnedIp())
            {
                request.Parameters.Add("EnableCustomerOwnedIp", StringUtils.FromBool(publicRequest.EnableCustomerOwnedIp.Value));
            }
            if (publicRequest.IsSetEnableIAMDatabaseAuthentication())
            {
                request.Parameters.Add("EnableIAMDatabaseAuthentication", StringUtils.FromBool(publicRequest.EnableIAMDatabaseAuthentication.Value));
            }
            if (publicRequest.IsSetEnablePerformanceInsights())
            {
                request.Parameters.Add("EnablePerformanceInsights", StringUtils.FromBool(publicRequest.EnablePerformanceInsights.Value));
            }
            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
            }
            if (publicRequest.IsSetEngineLifecycleSupport())
            {
                request.Parameters.Add("EngineLifecycleSupport", StringUtils.FromString(publicRequest.EngineLifecycleSupport));
            }
            if (publicRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
            }
            if (publicRequest.IsSetIops())
            {
                request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops.Value));
            }
            if (publicRequest.IsSetLicenseModel())
            {
                request.Parameters.Add("LicenseModel", StringUtils.FromString(publicRequest.LicenseModel));
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
            if (publicRequest.IsSetMaxAllocatedStorage())
            {
                request.Parameters.Add("MaxAllocatedStorage", StringUtils.FromInt(publicRequest.MaxAllocatedStorage.Value));
            }
            if (publicRequest.IsSetMonitoringInterval())
            {
                request.Parameters.Add("MonitoringInterval", StringUtils.FromInt(publicRequest.MonitoringInterval.Value));
            }
            if (publicRequest.IsSetMonitoringRoleArn())
            {
                request.Parameters.Add("MonitoringRoleArn", StringUtils.FromString(publicRequest.MonitoringRoleArn));
            }
            if (publicRequest.IsSetMultiAZ())
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(publicRequest.MultiAZ.Value));
            }
            if (publicRequest.IsSetMultiTenant())
            {
                request.Parameters.Add("MultiTenant", StringUtils.FromBool(publicRequest.MultiTenant.Value));
            }
            if (publicRequest.IsSetNetworkType())
            {
                request.Parameters.Add("NetworkType", StringUtils.FromString(publicRequest.NetworkType));
            }
            if (publicRequest.IsSetNewDBInstanceIdentifier())
            {
                request.Parameters.Add("NewDBInstanceIdentifier", StringUtils.FromString(publicRequest.NewDBInstanceIdentifier));
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
            if (publicRequest.IsSetPreferredBackupWindow())
            {
                request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(publicRequest.PreferredBackupWindow));
            }
            if (publicRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
            }
            if (publicRequest.IsSetProcessorFeatures())
            {
                if (publicRequest.ProcessorFeatures.Count == 0)
                {
                    request.Parameters.Add("ProcessorFeatures", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ProcessorFeatures)
                    {
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("ProcessorFeatures" + ".ProcessorFeature" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("ProcessorFeatures" + ".ProcessorFeature" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPromotionTier())
            {
                request.Parameters.Add("PromotionTier", StringUtils.FromInt(publicRequest.PromotionTier.Value));
            }
            if (publicRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible.Value));
            }
            if (publicRequest.IsSetReplicaMode())
            {
                request.Parameters.Add("ReplicaMode", StringUtils.FromString(publicRequest.ReplicaMode));
            }
            if (publicRequest.IsSetResumeFullAutomationModeMinutes())
            {
                request.Parameters.Add("ResumeFullAutomationModeMinutes", StringUtils.FromInt(publicRequest.ResumeFullAutomationModeMinutes.Value));
            }
            if (publicRequest.IsSetRotateMasterUserPassword())
            {
                request.Parameters.Add("RotateMasterUserPassword", StringUtils.FromBool(publicRequest.RotateMasterUserPassword.Value));
            }
            if (publicRequest.IsSetStorageThroughput())
            {
                request.Parameters.Add("StorageThroughput", StringUtils.FromInt(publicRequest.StorageThroughput.Value));
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
            if (publicRequest.IsSetTdeCredentialArn())
            {
                request.Parameters.Add("TdeCredentialArn", StringUtils.FromString(publicRequest.TdeCredentialArn));
            }
            if (publicRequest.IsSetTdeCredentialPassword())
            {
                request.Parameters.Add("TdeCredentialPassword", StringUtils.FromString(publicRequest.TdeCredentialPassword));
            }
            if (publicRequest.IsSetUseDefaultProcessorFeatures())
            {
                request.Parameters.Add("UseDefaultProcessorFeatures", StringUtils.FromBool(publicRequest.UseDefaultProcessorFeatures.Value));
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

        private static readonly ModifyDBInstanceRequestMarshaller _instance = new();

        internal static ModifyDBInstanceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyDBInstanceRequestMarshaller Instance => _instance;
    }
}
