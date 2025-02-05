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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsRdsDbInstanceDetails Marshaller
    /// </summary>
    public class AwsRdsDbInstanceDetailsMarshaller : IRequestMarshaller<AwsRdsDbInstanceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRdsDbInstanceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllocatedStorage())
            {
                context.Writer.WritePropertyName("AllocatedStorage");
                context.Writer.WriteNumberValue(requestObject.AllocatedStorage.Value);
            }

            if(requestObject.IsSetAssociatedRoles())
            {
                context.Writer.WritePropertyName("AssociatedRoles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAssociatedRolesListValue in requestObject.AssociatedRoles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbInstanceAssociatedRoleMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssociatedRolesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAutoMinorVersionUpgrade())
            {
                context.Writer.WritePropertyName("AutoMinorVersionUpgrade");
                context.Writer.WriteBooleanValue(requestObject.AutoMinorVersionUpgrade.Value);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.WriteStringValue(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetBackupRetentionPeriod())
            {
                context.Writer.WritePropertyName("BackupRetentionPeriod");
                context.Writer.WriteNumberValue(requestObject.BackupRetentionPeriod.Value);
            }

            if(requestObject.IsSetCACertificateIdentifier())
            {
                context.Writer.WritePropertyName("CACertificateIdentifier");
                context.Writer.WriteStringValue(requestObject.CACertificateIdentifier);
            }

            if(requestObject.IsSetCharacterSetName())
            {
                context.Writer.WritePropertyName("CharacterSetName");
                context.Writer.WriteStringValue(requestObject.CharacterSetName);
            }

            if(requestObject.IsSetCopyTagsToSnapshot())
            {
                context.Writer.WritePropertyName("CopyTagsToSnapshot");
                context.Writer.WriteBooleanValue(requestObject.CopyTagsToSnapshot.Value);
            }

            if(requestObject.IsSetDBClusterIdentifier())
            {
                context.Writer.WritePropertyName("DBClusterIdentifier");
                context.Writer.WriteStringValue(requestObject.DBClusterIdentifier);
            }

            if(requestObject.IsSetDBInstanceClass())
            {
                context.Writer.WritePropertyName("DBInstanceClass");
                context.Writer.WriteStringValue(requestObject.DBInstanceClass);
            }

            if(requestObject.IsSetDBInstanceIdentifier())
            {
                context.Writer.WritePropertyName("DBInstanceIdentifier");
                context.Writer.WriteStringValue(requestObject.DBInstanceIdentifier);
            }

            if(requestObject.IsSetDbInstancePort())
            {
                context.Writer.WritePropertyName("DbInstancePort");
                context.Writer.WriteNumberValue(requestObject.DbInstancePort.Value);
            }

            if(requestObject.IsSetDbInstanceStatus())
            {
                context.Writer.WritePropertyName("DbInstanceStatus");
                context.Writer.WriteStringValue(requestObject.DbInstanceStatus);
            }

            if(requestObject.IsSetDbiResourceId())
            {
                context.Writer.WritePropertyName("DbiResourceId");
                context.Writer.WriteStringValue(requestObject.DbiResourceId);
            }

            if(requestObject.IsSetDBName())
            {
                context.Writer.WritePropertyName("DBName");
                context.Writer.WriteStringValue(requestObject.DBName);
            }

            if(requestObject.IsSetDbParameterGroups())
            {
                context.Writer.WritePropertyName("DbParameterGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDbParameterGroupsListValue in requestObject.DbParameterGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbParameterGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectDbParameterGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDbSecurityGroups())
            {
                context.Writer.WritePropertyName("DbSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDbSecurityGroupsListValue in requestObject.DbSecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectDbSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDbSubnetGroup())
            {
                context.Writer.WritePropertyName("DbSubnetGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbSubnetGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.DbSubnetGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeletionProtection())
            {
                context.Writer.WritePropertyName("DeletionProtection");
                context.Writer.WriteBooleanValue(requestObject.DeletionProtection.Value);
            }

            if(requestObject.IsSetDomainMemberships())
            {
                context.Writer.WritePropertyName("DomainMemberships");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDomainMembershipsListValue in requestObject.DomainMemberships)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbDomainMembershipMarshaller.Instance;
                    marshaller.Marshall(requestObjectDomainMembershipsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnabledCloudWatchLogsExports())
            {
                context.Writer.WritePropertyName("EnabledCloudWatchLogsExports");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnabledCloudWatchLogsExportsListValue in requestObject.EnabledCloudWatchLogsExports)
                {
                        context.Writer.WriteStringValue(requestObjectEnabledCloudWatchLogsExportsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("Endpoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbInstanceEndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.Endpoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.WriteStringValue(requestObject.Engine);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(requestObject.EngineVersion);
            }

            if(requestObject.IsSetEnhancedMonitoringResourceArn())
            {
                context.Writer.WritePropertyName("EnhancedMonitoringResourceArn");
                context.Writer.WriteStringValue(requestObject.EnhancedMonitoringResourceArn);
            }

            if(requestObject.IsSetIAMDatabaseAuthenticationEnabled())
            {
                context.Writer.WritePropertyName("IAMDatabaseAuthenticationEnabled");
                context.Writer.WriteBooleanValue(requestObject.IAMDatabaseAuthenticationEnabled.Value);
            }

            if(requestObject.IsSetInstanceCreateTime())
            {
                context.Writer.WritePropertyName("InstanceCreateTime");
                context.Writer.WriteStringValue(requestObject.InstanceCreateTime);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("Iops");
                context.Writer.WriteNumberValue(requestObject.Iops.Value);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLatestRestorableTime())
            {
                context.Writer.WritePropertyName("LatestRestorableTime");
                context.Writer.WriteStringValue(requestObject.LatestRestorableTime);
            }

            if(requestObject.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("LicenseModel");
                context.Writer.WriteStringValue(requestObject.LicenseModel);
            }

            if(requestObject.IsSetListenerEndpoint())
            {
                context.Writer.WritePropertyName("ListenerEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbInstanceEndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.ListenerEndpoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMasterUsername())
            {
                context.Writer.WritePropertyName("MasterUsername");
                context.Writer.WriteStringValue(requestObject.MasterUsername);
            }

            if(requestObject.IsSetMaxAllocatedStorage())
            {
                context.Writer.WritePropertyName("MaxAllocatedStorage");
                context.Writer.WriteNumberValue(requestObject.MaxAllocatedStorage.Value);
            }

            if(requestObject.IsSetMonitoringInterval())
            {
                context.Writer.WritePropertyName("MonitoringInterval");
                context.Writer.WriteNumberValue(requestObject.MonitoringInterval.Value);
            }

            if(requestObject.IsSetMonitoringRoleArn())
            {
                context.Writer.WritePropertyName("MonitoringRoleArn");
                context.Writer.WriteStringValue(requestObject.MonitoringRoleArn);
            }

            if(requestObject.IsSetMultiAz())
            {
                context.Writer.WritePropertyName("MultiAz");
                context.Writer.WriteBooleanValue(requestObject.MultiAz.Value);
            }

            if(requestObject.IsSetOptionGroupMemberships())
            {
                context.Writer.WritePropertyName("OptionGroupMemberships");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOptionGroupMembershipsListValue in requestObject.OptionGroupMemberships)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbOptionGroupMembershipMarshaller.Instance;
                    marshaller.Marshall(requestObjectOptionGroupMembershipsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPendingModifiedValues())
            {
                context.Writer.WritePropertyName("PendingModifiedValues");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbPendingModifiedValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.PendingModifiedValues, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPerformanceInsightsEnabled())
            {
                context.Writer.WritePropertyName("PerformanceInsightsEnabled");
                context.Writer.WriteBooleanValue(requestObject.PerformanceInsightsEnabled.Value);
            }

            if(requestObject.IsSetPerformanceInsightsKmsKeyId())
            {
                context.Writer.WritePropertyName("PerformanceInsightsKmsKeyId");
                context.Writer.WriteStringValue(requestObject.PerformanceInsightsKmsKeyId);
            }

            if(requestObject.IsSetPerformanceInsightsRetentionPeriod())
            {
                context.Writer.WritePropertyName("PerformanceInsightsRetentionPeriod");
                context.Writer.WriteNumberValue(requestObject.PerformanceInsightsRetentionPeriod.Value);
            }

            if(requestObject.IsSetPreferredBackupWindow())
            {
                context.Writer.WritePropertyName("PreferredBackupWindow");
                context.Writer.WriteStringValue(requestObject.PreferredBackupWindow);
            }

            if(requestObject.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                context.Writer.WriteStringValue(requestObject.PreferredMaintenanceWindow);
            }

            if(requestObject.IsSetProcessorFeatures())
            {
                context.Writer.WritePropertyName("ProcessorFeatures");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProcessorFeaturesListValue in requestObject.ProcessorFeatures)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbProcessorFeatureMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessorFeaturesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPromotionTier())
            {
                context.Writer.WritePropertyName("PromotionTier");
                context.Writer.WriteNumberValue(requestObject.PromotionTier.Value);
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.WriteBooleanValue(requestObject.PubliclyAccessible.Value);
            }

            if(requestObject.IsSetReadReplicaDBClusterIdentifiers())
            {
                context.Writer.WritePropertyName("ReadReplicaDBClusterIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReadReplicaDBClusterIdentifiersListValue in requestObject.ReadReplicaDBClusterIdentifiers)
                {
                        context.Writer.WriteStringValue(requestObjectReadReplicaDBClusterIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetReadReplicaDBInstanceIdentifiers())
            {
                context.Writer.WritePropertyName("ReadReplicaDBInstanceIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReadReplicaDBInstanceIdentifiersListValue in requestObject.ReadReplicaDBInstanceIdentifiers)
                {
                        context.Writer.WriteStringValue(requestObjectReadReplicaDBInstanceIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetReadReplicaSourceDBInstanceIdentifier())
            {
                context.Writer.WritePropertyName("ReadReplicaSourceDBInstanceIdentifier");
                context.Writer.WriteStringValue(requestObject.ReadReplicaSourceDBInstanceIdentifier);
            }

            if(requestObject.IsSetSecondaryAvailabilityZone())
            {
                context.Writer.WritePropertyName("SecondaryAvailabilityZone");
                context.Writer.WriteStringValue(requestObject.SecondaryAvailabilityZone);
            }

            if(requestObject.IsSetStatusInfos())
            {
                context.Writer.WritePropertyName("StatusInfos");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatusInfosListValue in requestObject.StatusInfos)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbStatusInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatusInfosListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStorageEncrypted())
            {
                context.Writer.WritePropertyName("StorageEncrypted");
                context.Writer.WriteBooleanValue(requestObject.StorageEncrypted.Value);
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("StorageType");
                context.Writer.WriteStringValue(requestObject.StorageType);
            }

            if(requestObject.IsSetTdeCredentialArn())
            {
                context.Writer.WritePropertyName("TdeCredentialArn");
                context.Writer.WriteStringValue(requestObject.TdeCredentialArn);
            }

            if(requestObject.IsSetTimezone())
            {
                context.Writer.WritePropertyName("Timezone");
                context.Writer.WriteStringValue(requestObject.Timezone);
            }

            if(requestObject.IsSetVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("VpcSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVpcSecurityGroupsListValue in requestObject.VpcSecurityGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbInstanceVpcSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcSecurityGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsRdsDbInstanceDetailsMarshaller Instance = new AwsRdsDbInstanceDetailsMarshaller();

    }
}