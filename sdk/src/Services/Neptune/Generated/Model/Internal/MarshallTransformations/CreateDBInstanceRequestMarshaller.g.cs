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

using Amazon.Neptune.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDBInstance Request Marshaller
    /// </summary>
    public partial class CreateDBInstanceRequestMarshaller : IMarshaller<IRequest, CreateDBInstanceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDBInstanceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDBInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptune");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateDBInstance");
            request.Parameters.Add("Version", "2014-10-31");

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
            if (publicRequest.IsSetCharacterSetName())
            {
                request.Parameters.Add("CharacterSetName", StringUtils.FromString(publicRequest.CharacterSetName));
            }
            if (publicRequest.IsSetCopyTagsToSnapshot())
            {
                request.Parameters.Add("CopyTagsToSnapshot", StringUtils.FromBool(publicRequest.CopyTagsToSnapshot.Value));
            }
            if (publicRequest.IsSetDBClusterIdentifier())
            {
                request.Parameters.Add("DBClusterIdentifier", StringUtils.FromString(publicRequest.DBClusterIdentifier));
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
            if (publicRequest.IsSetEnablePerformanceInsights())
            {
                request.Parameters.Add("EnablePerformanceInsights", StringUtils.FromBool(publicRequest.EnablePerformanceInsights.Value));
            }
            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
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
            if (publicRequest.IsSetMasterUserPassword())
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
            }
            if (publicRequest.IsSetMasterUsername())
            {
                request.Parameters.Add("MasterUsername", StringUtils.FromString(publicRequest.MasterUsername));
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
            if (publicRequest.IsSetOptionGroupName())
            {
                request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
            }
            if (publicRequest.IsSetPerformanceInsightsKMSKeyId())
            {
                request.Parameters.Add("PerformanceInsightsKMSKeyId", StringUtils.FromString(publicRequest.PerformanceInsightsKMSKeyId));
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
            if (publicRequest.IsSetPromotionTier())
            {
                request.Parameters.Add("PromotionTier", StringUtils.FromInt(publicRequest.PromotionTier.Value));
            }
            if (publicRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible.Value));
            }
            if (publicRequest.IsSetStorageEncrypted())
            {
                request.Parameters.Add("StorageEncrypted", StringUtils.FromBool(publicRequest.StorageEncrypted.Value));
            }
            if (publicRequest.IsSetStorageType())
            {
                request.Parameters.Add("StorageType", StringUtils.FromString(publicRequest.StorageType));
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
            if (publicRequest.IsSetTdeCredentialArn())
            {
                request.Parameters.Add("TdeCredentialArn", StringUtils.FromString(publicRequest.TdeCredentialArn));
            }
            if (publicRequest.IsSetTdeCredentialPassword())
            {
                request.Parameters.Add("TdeCredentialPassword", StringUtils.FromString(publicRequest.TdeCredentialPassword));
            }
            if (publicRequest.IsSetTimezone())
            {
                request.Parameters.Add("Timezone", StringUtils.FromString(publicRequest.Timezone));
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

        private static readonly CreateDBInstanceRequestMarshaller _instance = new();

        internal static CreateDBInstanceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDBInstanceRequestMarshaller Instance => _instance;
    }
}
