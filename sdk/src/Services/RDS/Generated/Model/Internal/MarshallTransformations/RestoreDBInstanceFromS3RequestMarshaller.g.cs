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
    /// RestoreDBInstanceFromS3 Request Marshaller
    /// </summary>
    public partial class RestoreDBInstanceFromS3RequestMarshaller : IMarshaller<IRequest, RestoreDBInstanceFromS3Request>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreDBInstanceFromS3Request)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RestoreDBInstanceFromS3Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RestoreDBInstanceFromS3");
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
            if (publicRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade.Value));
            }
            if (publicRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
            }
            if (publicRequest.IsSetBackupRetentionPeriod())
            {
                request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(publicRequest.BackupRetentionPeriod.Value));
            }
            if (publicRequest.IsSetCACertificateIdentifier())
            {
                request.Parameters.Add("CACertificateIdentifier", StringUtils.FromString(publicRequest.CACertificateIdentifier));
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
            if (publicRequest.IsSetDBName())
            {
                request.Parameters.Add("DBName", StringUtils.FromString(publicRequest.DBName));
            }
            if (publicRequest.IsSetDBParameterGroupName())
            {
                request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(publicRequest.DBParameterGroupName));
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
            if (publicRequest.IsSetKmsKeyId())
            {
                request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
            }
            if (publicRequest.IsSetLicenseModel())
            {
                request.Parameters.Add("LicenseModel", StringUtils.FromString(publicRequest.LicenseModel));
            }
            if (publicRequest.IsSetManageMasterUserPassword())
            {
                request.Parameters.Add("ManageMasterUserPassword", StringUtils.FromBool(publicRequest.ManageMasterUserPassword.Value));
            }
            if (publicRequest.IsSetMasterUserPassword())
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
            }
            if (publicRequest.IsSetMasterUserSecretKmsKeyId())
            {
                request.Parameters.Add("MasterUserSecretKmsKeyId", StringUtils.FromString(publicRequest.MasterUserSecretKmsKeyId));
            }
            if (publicRequest.IsSetMasterUsername())
            {
                request.Parameters.Add("MasterUsername", StringUtils.FromString(publicRequest.MasterUsername));
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
            if (publicRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible.Value));
            }
            if (publicRequest.IsSetS3BucketName())
            {
                request.Parameters.Add("S3BucketName", StringUtils.FromString(publicRequest.S3BucketName));
            }
            if (publicRequest.IsSetS3IngestionRoleArn())
            {
                request.Parameters.Add("S3IngestionRoleArn", StringUtils.FromString(publicRequest.S3IngestionRoleArn));
            }
            if (publicRequest.IsSetS3Prefix())
            {
                request.Parameters.Add("S3Prefix", StringUtils.FromString(publicRequest.S3Prefix));
            }
            if (publicRequest.IsSetSourceEngine())
            {
                request.Parameters.Add("SourceEngine", StringUtils.FromString(publicRequest.SourceEngine));
            }
            if (publicRequest.IsSetSourceEngineVersion())
            {
                request.Parameters.Add("SourceEngineVersion", StringUtils.FromString(publicRequest.SourceEngineVersion));
            }
            if (publicRequest.IsSetStorageEncrypted())
            {
                request.Parameters.Add("StorageEncrypted", StringUtils.FromBool(publicRequest.StorageEncrypted.Value));
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

        private static readonly RestoreDBInstanceFromS3RequestMarshaller _instance = new();

        internal static RestoreDBInstanceFromS3RequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RestoreDBInstanceFromS3RequestMarshaller Instance => _instance;
    }
}
