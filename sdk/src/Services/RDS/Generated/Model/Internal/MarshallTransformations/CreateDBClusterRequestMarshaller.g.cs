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
    /// CreateDBCluster Request Marshaller
    /// </summary>
    public partial class CreateDBClusterRequestMarshaller : IMarshaller<IRequest, CreateDBClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDBClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDBClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateDBCluster");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetAllocatedStorage())
            {
                request.Parameters.Add("AllocatedStorage", StringUtils.FromInt(publicRequest.AllocatedStorage.Value));
            }
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
            if (publicRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade.Value));
            }
            if (publicRequest.IsSetAvailabilityZones())
            {
                if (publicRequest.AvailabilityZones.Count == 0)
                {
                    request.Parameters.Add("AvailabilityZones", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AvailabilityZones)
                    {
                        request.Parameters.Add("AvailabilityZones" + ".AvailabilityZone" + "." + index0, StringUtils.FromString(item0));
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
            if (publicRequest.IsSetCACertificateIdentifier())
            {
                request.Parameters.Add("CACertificateIdentifier", StringUtils.FromString(publicRequest.CACertificateIdentifier));
            }
            if (publicRequest.IsSetCharacterSetName())
            {
                request.Parameters.Add("CharacterSetName", StringUtils.FromString(publicRequest.CharacterSetName));
            }
            if (publicRequest.IsSetClusterScalabilityType())
            {
                request.Parameters.Add("ClusterScalabilityType", StringUtils.FromString(publicRequest.ClusterScalabilityType));
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
            if (publicRequest.IsSetDBSystemId())
            {
                request.Parameters.Add("DBSystemId", StringUtils.FromString(publicRequest.DBSystemId));
            }
            if (publicRequest.IsSetDatabaseInsightsMode())
            {
                request.Parameters.Add("DatabaseInsightsMode", StringUtils.FromString(publicRequest.DatabaseInsightsMode));
            }
            if (publicRequest.IsSetDatabaseName())
            {
                request.Parameters.Add("DatabaseName", StringUtils.FromString(publicRequest.DatabaseName));
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
            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
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
            if (publicRequest.IsSetGlobalClusterIdentifier())
            {
                request.Parameters.Add("GlobalClusterIdentifier", StringUtils.FromString(publicRequest.GlobalClusterIdentifier));
            }
            if (publicRequest.IsSetIops())
            {
                request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops.Value));
            }
            if (publicRequest.IsSetKmsKeyId())
            {
                request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
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
            if (publicRequest.IsSetPreSignedUrl())
            {
                request.Parameters.Add("PreSignedUrl", StringUtils.FromString(publicRequest.PreSignedUrl));
            }
            if (publicRequest.IsSetPreferredBackupWindow())
            {
                request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(publicRequest.PreferredBackupWindow));
            }
            if (publicRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
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
            if (publicRequest.IsSetReplicationSourceIdentifier())
            {
                request.Parameters.Add("ReplicationSourceIdentifier", StringUtils.FromString(publicRequest.ReplicationSourceIdentifier));
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
            if (publicRequest.IsSetStorageEncrypted())
            {
                request.Parameters.Add("StorageEncrypted", StringUtils.FromBool(publicRequest.StorageEncrypted.Value));
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
            if (publicRequest.IsSetWithExpressConfiguration())
            {
                request.Parameters.Add("WithExpressConfiguration", StringUtils.FromBool(publicRequest.WithExpressConfiguration.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateDBClusterRequestMarshaller _instance = new();

        internal static CreateDBClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDBClusterRequestMarshaller Instance => _instance;
    }
}
