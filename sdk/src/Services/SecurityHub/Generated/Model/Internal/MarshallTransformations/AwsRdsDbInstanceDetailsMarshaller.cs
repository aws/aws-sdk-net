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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAllocatedStorage())
            {
                context.Writer.WritePropertyName("AllocatedStorage");
                context.Writer.Write(requestObject.AllocatedStorage);
            }

            if(requestObject.IsSetAssociatedRoles())
            {
                context.Writer.WritePropertyName("AssociatedRoles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssociatedRolesListValue in requestObject.AssociatedRoles)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbInstanceAssociatedRoleMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssociatedRolesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAutoMinorVersionUpgrade())
            {
                context.Writer.WritePropertyName("AutoMinorVersionUpgrade");
                context.Writer.Write(requestObject.AutoMinorVersionUpgrade);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.Write(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetBackupRetentionPeriod())
            {
                context.Writer.WritePropertyName("BackupRetentionPeriod");
                context.Writer.Write(requestObject.BackupRetentionPeriod);
            }

            if(requestObject.IsSetCACertificateIdentifier())
            {
                context.Writer.WritePropertyName("CACertificateIdentifier");
                context.Writer.Write(requestObject.CACertificateIdentifier);
            }

            if(requestObject.IsSetCharacterSetName())
            {
                context.Writer.WritePropertyName("CharacterSetName");
                context.Writer.Write(requestObject.CharacterSetName);
            }

            if(requestObject.IsSetCopyTagsToSnapshot())
            {
                context.Writer.WritePropertyName("CopyTagsToSnapshot");
                context.Writer.Write(requestObject.CopyTagsToSnapshot);
            }

            if(requestObject.IsSetDBClusterIdentifier())
            {
                context.Writer.WritePropertyName("DBClusterIdentifier");
                context.Writer.Write(requestObject.DBClusterIdentifier);
            }

            if(requestObject.IsSetDBInstanceClass())
            {
                context.Writer.WritePropertyName("DBInstanceClass");
                context.Writer.Write(requestObject.DBInstanceClass);
            }

            if(requestObject.IsSetDBInstanceIdentifier())
            {
                context.Writer.WritePropertyName("DBInstanceIdentifier");
                context.Writer.Write(requestObject.DBInstanceIdentifier);
            }

            if(requestObject.IsSetDbInstancePort())
            {
                context.Writer.WritePropertyName("DbInstancePort");
                context.Writer.Write(requestObject.DbInstancePort);
            }

            if(requestObject.IsSetDbInstanceStatus())
            {
                context.Writer.WritePropertyName("DbInstanceStatus");
                context.Writer.Write(requestObject.DbInstanceStatus);
            }

            if(requestObject.IsSetDbiResourceId())
            {
                context.Writer.WritePropertyName("DbiResourceId");
                context.Writer.Write(requestObject.DbiResourceId);
            }

            if(requestObject.IsSetDBName())
            {
                context.Writer.WritePropertyName("DBName");
                context.Writer.Write(requestObject.DBName);
            }

            if(requestObject.IsSetDbParameterGroups())
            {
                context.Writer.WritePropertyName("DbParameterGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDbParameterGroupsListValue in requestObject.DbParameterGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbParameterGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectDbParameterGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDbSecurityGroups())
            {
                context.Writer.WritePropertyName("DbSecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDbSecurityGroupsListValue in requestObject.DbSecurityGroups)
                {
                        context.Writer.Write(requestObjectDbSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDbSubnetGroup())
            {
                context.Writer.WritePropertyName("DbSubnetGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbSubnetGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.DbSubnetGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeletionProtection())
            {
                context.Writer.WritePropertyName("DeletionProtection");
                context.Writer.Write(requestObject.DeletionProtection);
            }

            if(requestObject.IsSetDomainMemberships())
            {
                context.Writer.WritePropertyName("DomainMemberships");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDomainMembershipsListValue in requestObject.DomainMemberships)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbDomainMembershipMarshaller.Instance;
                    marshaller.Marshall(requestObjectDomainMembershipsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnabledCloudWatchLogsExports())
            {
                context.Writer.WritePropertyName("EnabledCloudWatchLogsExports");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnabledCloudWatchLogsExportsListValue in requestObject.EnabledCloudWatchLogsExports)
                {
                        context.Writer.Write(requestObjectEnabledCloudWatchLogsExportsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("Endpoint");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbInstanceEndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.Endpoint, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.Write(requestObject.Engine);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.Write(requestObject.EngineVersion);
            }

            if(requestObject.IsSetEnhancedMonitoringResourceArn())
            {
                context.Writer.WritePropertyName("EnhancedMonitoringResourceArn");
                context.Writer.Write(requestObject.EnhancedMonitoringResourceArn);
            }

            if(requestObject.IsSetIAMDatabaseAuthenticationEnabled())
            {
                context.Writer.WritePropertyName("IAMDatabaseAuthenticationEnabled");
                context.Writer.Write(requestObject.IAMDatabaseAuthenticationEnabled);
            }

            if(requestObject.IsSetInstanceCreateTime())
            {
                context.Writer.WritePropertyName("InstanceCreateTime");
                context.Writer.Write(requestObject.InstanceCreateTime);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("Iops");
                context.Writer.Write(requestObject.Iops);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLatestRestorableTime())
            {
                context.Writer.WritePropertyName("LatestRestorableTime");
                context.Writer.Write(requestObject.LatestRestorableTime);
            }

            if(requestObject.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("LicenseModel");
                context.Writer.Write(requestObject.LicenseModel);
            }

            if(requestObject.IsSetListenerEndpoint())
            {
                context.Writer.WritePropertyName("ListenerEndpoint");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbInstanceEndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.ListenerEndpoint, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMasterUsername())
            {
                context.Writer.WritePropertyName("MasterUsername");
                context.Writer.Write(requestObject.MasterUsername);
            }

            if(requestObject.IsSetMaxAllocatedStorage())
            {
                context.Writer.WritePropertyName("MaxAllocatedStorage");
                context.Writer.Write(requestObject.MaxAllocatedStorage);
            }

            if(requestObject.IsSetMonitoringInterval())
            {
                context.Writer.WritePropertyName("MonitoringInterval");
                context.Writer.Write(requestObject.MonitoringInterval);
            }

            if(requestObject.IsSetMonitoringRoleArn())
            {
                context.Writer.WritePropertyName("MonitoringRoleArn");
                context.Writer.Write(requestObject.MonitoringRoleArn);
            }

            if(requestObject.IsSetMultiAz())
            {
                context.Writer.WritePropertyName("MultiAz");
                context.Writer.Write(requestObject.MultiAz);
            }

            if(requestObject.IsSetOptionGroupMemberships())
            {
                context.Writer.WritePropertyName("OptionGroupMemberships");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOptionGroupMembershipsListValue in requestObject.OptionGroupMemberships)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbOptionGroupMembershipMarshaller.Instance;
                    marshaller.Marshall(requestObjectOptionGroupMembershipsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPendingModifiedValues())
            {
                context.Writer.WritePropertyName("PendingModifiedValues");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbPendingModifiedValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.PendingModifiedValues, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPerformanceInsightsEnabled())
            {
                context.Writer.WritePropertyName("PerformanceInsightsEnabled");
                context.Writer.Write(requestObject.PerformanceInsightsEnabled);
            }

            if(requestObject.IsSetPerformanceInsightsKmsKeyId())
            {
                context.Writer.WritePropertyName("PerformanceInsightsKmsKeyId");
                context.Writer.Write(requestObject.PerformanceInsightsKmsKeyId);
            }

            if(requestObject.IsSetPerformanceInsightsRetentionPeriod())
            {
                context.Writer.WritePropertyName("PerformanceInsightsRetentionPeriod");
                context.Writer.Write(requestObject.PerformanceInsightsRetentionPeriod);
            }

            if(requestObject.IsSetPreferredBackupWindow())
            {
                context.Writer.WritePropertyName("PreferredBackupWindow");
                context.Writer.Write(requestObject.PreferredBackupWindow);
            }

            if(requestObject.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                context.Writer.Write(requestObject.PreferredMaintenanceWindow);
            }

            if(requestObject.IsSetProcessorFeatures())
            {
                context.Writer.WritePropertyName("ProcessorFeatures");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProcessorFeaturesListValue in requestObject.ProcessorFeatures)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbProcessorFeatureMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessorFeaturesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPromotionTier())
            {
                context.Writer.WritePropertyName("PromotionTier");
                context.Writer.Write(requestObject.PromotionTier);
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.Write(requestObject.PubliclyAccessible);
            }

            if(requestObject.IsSetReadReplicaDBClusterIdentifiers())
            {
                context.Writer.WritePropertyName("ReadReplicaDBClusterIdentifiers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReadReplicaDBClusterIdentifiersListValue in requestObject.ReadReplicaDBClusterIdentifiers)
                {
                        context.Writer.Write(requestObjectReadReplicaDBClusterIdentifiersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetReadReplicaDBInstanceIdentifiers())
            {
                context.Writer.WritePropertyName("ReadReplicaDBInstanceIdentifiers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReadReplicaDBInstanceIdentifiersListValue in requestObject.ReadReplicaDBInstanceIdentifiers)
                {
                        context.Writer.Write(requestObjectReadReplicaDBInstanceIdentifiersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetReadReplicaSourceDBInstanceIdentifier())
            {
                context.Writer.WritePropertyName("ReadReplicaSourceDBInstanceIdentifier");
                context.Writer.Write(requestObject.ReadReplicaSourceDBInstanceIdentifier);
            }

            if(requestObject.IsSetSecondaryAvailabilityZone())
            {
                context.Writer.WritePropertyName("SecondaryAvailabilityZone");
                context.Writer.Write(requestObject.SecondaryAvailabilityZone);
            }

            if(requestObject.IsSetStatusInfos())
            {
                context.Writer.WritePropertyName("StatusInfos");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatusInfosListValue in requestObject.StatusInfos)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbStatusInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatusInfosListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStorageEncrypted())
            {
                context.Writer.WritePropertyName("StorageEncrypted");
                context.Writer.Write(requestObject.StorageEncrypted);
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("StorageType");
                context.Writer.Write(requestObject.StorageType);
            }

            if(requestObject.IsSetTdeCredentialArn())
            {
                context.Writer.WritePropertyName("TdeCredentialArn");
                context.Writer.Write(requestObject.TdeCredentialArn);
            }

            if(requestObject.IsSetTimezone())
            {
                context.Writer.WritePropertyName("Timezone");
                context.Writer.Write(requestObject.Timezone);
            }

            if(requestObject.IsSetVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("VpcSecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVpcSecurityGroupsListValue in requestObject.VpcSecurityGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbInstanceVpcSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcSecurityGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsRdsDbInstanceDetailsMarshaller Instance = new AwsRdsDbInstanceDetailsMarshaller();

    }
}