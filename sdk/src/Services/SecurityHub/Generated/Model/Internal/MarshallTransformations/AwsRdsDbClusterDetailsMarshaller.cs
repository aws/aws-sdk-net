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
    /// AwsRdsDbClusterDetails Marshaller
    /// </summary>
    public class AwsRdsDbClusterDetailsMarshaller : IRequestMarshaller<AwsRdsDbClusterDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRdsDbClusterDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActivityStreamStatus())
            {
                context.Writer.WritePropertyName("ActivityStreamStatus");
                context.Writer.WriteStringValue(requestObject.ActivityStreamStatus);
            }

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

                    var marshaller = AwsRdsDbClusterAssociatedRoleMarshaller.Instance;
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

            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.WriteStringValue(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBackupRetentionPeriod())
            {
                context.Writer.WritePropertyName("BackupRetentionPeriod");
                context.Writer.WriteNumberValue(requestObject.BackupRetentionPeriod.Value);
            }

            if(requestObject.IsSetClusterCreateTime())
            {
                context.Writer.WritePropertyName("ClusterCreateTime");
                context.Writer.WriteStringValue(requestObject.ClusterCreateTime);
            }

            if(requestObject.IsSetCopyTagsToSnapshot())
            {
                context.Writer.WritePropertyName("CopyTagsToSnapshot");
                context.Writer.WriteBooleanValue(requestObject.CopyTagsToSnapshot.Value);
            }

            if(requestObject.IsSetCrossAccountClone())
            {
                context.Writer.WritePropertyName("CrossAccountClone");
                context.Writer.WriteBooleanValue(requestObject.CrossAccountClone.Value);
            }

            if(requestObject.IsSetCustomEndpoints())
            {
                context.Writer.WritePropertyName("CustomEndpoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomEndpointsListValue in requestObject.CustomEndpoints)
                {
                        context.Writer.WriteStringValue(requestObjectCustomEndpointsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDbClusterIdentifier())
            {
                context.Writer.WritePropertyName("DbClusterIdentifier");
                context.Writer.WriteStringValue(requestObject.DbClusterIdentifier);
            }

            if(requestObject.IsSetDbClusterMembers())
            {
                context.Writer.WritePropertyName("DbClusterMembers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDbClusterMembersListValue in requestObject.DbClusterMembers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbClusterMemberMarshaller.Instance;
                    marshaller.Marshall(requestObjectDbClusterMembersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDbClusterOptionGroupMemberships())
            {
                context.Writer.WritePropertyName("DbClusterOptionGroupMemberships");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDbClusterOptionGroupMembershipsListValue in requestObject.DbClusterOptionGroupMemberships)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbClusterOptionGroupMembershipMarshaller.Instance;
                    marshaller.Marshall(requestObjectDbClusterOptionGroupMembershipsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDbClusterParameterGroup())
            {
                context.Writer.WritePropertyName("DbClusterParameterGroup");
                context.Writer.WriteStringValue(requestObject.DbClusterParameterGroup);
            }

            if(requestObject.IsSetDbClusterResourceId())
            {
                context.Writer.WritePropertyName("DbClusterResourceId");
                context.Writer.WriteStringValue(requestObject.DbClusterResourceId);
            }

            if(requestObject.IsSetDbSubnetGroup())
            {
                context.Writer.WritePropertyName("DbSubnetGroup");
                context.Writer.WriteStringValue(requestObject.DbSubnetGroup);
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
                context.Writer.WriteStringValue(requestObject.Endpoint);
            }

            if(requestObject.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.WriteStringValue(requestObject.Engine);
            }

            if(requestObject.IsSetEngineMode())
            {
                context.Writer.WritePropertyName("EngineMode");
                context.Writer.WriteStringValue(requestObject.EngineMode);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(requestObject.EngineVersion);
            }

            if(requestObject.IsSetHostedZoneId())
            {
                context.Writer.WritePropertyName("HostedZoneId");
                context.Writer.WriteStringValue(requestObject.HostedZoneId);
            }

            if(requestObject.IsSetHttpEndpointEnabled())
            {
                context.Writer.WritePropertyName("HttpEndpointEnabled");
                context.Writer.WriteBooleanValue(requestObject.HttpEndpointEnabled.Value);
            }

            if(requestObject.IsSetIamDatabaseAuthenticationEnabled())
            {
                context.Writer.WritePropertyName("IamDatabaseAuthenticationEnabled");
                context.Writer.WriteBooleanValue(requestObject.IamDatabaseAuthenticationEnabled.Value);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetMasterUsername())
            {
                context.Writer.WritePropertyName("MasterUsername");
                context.Writer.WriteStringValue(requestObject.MasterUsername);
            }

            if(requestObject.IsSetMultiAz())
            {
                context.Writer.WritePropertyName("MultiAz");
                context.Writer.WriteBooleanValue(requestObject.MultiAz.Value);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
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

            if(requestObject.IsSetReaderEndpoint())
            {
                context.Writer.WritePropertyName("ReaderEndpoint");
                context.Writer.WriteStringValue(requestObject.ReaderEndpoint);
            }

            if(requestObject.IsSetReadReplicaIdentifiers())
            {
                context.Writer.WritePropertyName("ReadReplicaIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReadReplicaIdentifiersListValue in requestObject.ReadReplicaIdentifiers)
                {
                        context.Writer.WriteStringValue(requestObjectReadReplicaIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetStorageEncrypted())
            {
                context.Writer.WritePropertyName("StorageEncrypted");
                context.Writer.WriteBooleanValue(requestObject.StorageEncrypted.Value);
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
        public readonly static AwsRdsDbClusterDetailsMarshaller Instance = new AwsRdsDbClusterDetailsMarshaller();

    }
}