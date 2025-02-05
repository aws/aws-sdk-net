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
    /// AwsRedshiftClusterDetails Marshaller
    /// </summary>
    public class AwsRedshiftClusterDetailsMarshaller : IRequestMarshaller<AwsRedshiftClusterDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRedshiftClusterDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowVersionUpgrade())
            {
                context.Writer.WritePropertyName("AllowVersionUpgrade");
                context.Writer.WriteBooleanValue(requestObject.AllowVersionUpgrade.Value);
            }

            if(requestObject.IsSetAutomatedSnapshotRetentionPeriod())
            {
                context.Writer.WritePropertyName("AutomatedSnapshotRetentionPeriod");
                context.Writer.WriteNumberValue(requestObject.AutomatedSnapshotRetentionPeriod.Value);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.WriteStringValue(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetClusterAvailabilityStatus())
            {
                context.Writer.WritePropertyName("ClusterAvailabilityStatus");
                context.Writer.WriteStringValue(requestObject.ClusterAvailabilityStatus);
            }

            if(requestObject.IsSetClusterCreateTime())
            {
                context.Writer.WritePropertyName("ClusterCreateTime");
                context.Writer.WriteStringValue(requestObject.ClusterCreateTime);
            }

            if(requestObject.IsSetClusterIdentifier())
            {
                context.Writer.WritePropertyName("ClusterIdentifier");
                context.Writer.WriteStringValue(requestObject.ClusterIdentifier);
            }

            if(requestObject.IsSetClusterNodes())
            {
                context.Writer.WritePropertyName("ClusterNodes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClusterNodesListValue in requestObject.ClusterNodes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRedshiftClusterClusterNodeMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterNodesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetClusterParameterGroups())
            {
                context.Writer.WritePropertyName("ClusterParameterGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClusterParameterGroupsListValue in requestObject.ClusterParameterGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRedshiftClusterClusterParameterGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterParameterGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetClusterPublicKey())
            {
                context.Writer.WritePropertyName("ClusterPublicKey");
                context.Writer.WriteStringValue(requestObject.ClusterPublicKey);
            }

            if(requestObject.IsSetClusterRevisionNumber())
            {
                context.Writer.WritePropertyName("ClusterRevisionNumber");
                context.Writer.WriteStringValue(requestObject.ClusterRevisionNumber);
            }

            if(requestObject.IsSetClusterSecurityGroups())
            {
                context.Writer.WritePropertyName("ClusterSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClusterSecurityGroupsListValue in requestObject.ClusterSecurityGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRedshiftClusterClusterSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterSecurityGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetClusterSnapshotCopyStatus())
            {
                context.Writer.WritePropertyName("ClusterSnapshotCopyStatus");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterClusterSnapshotCopyStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.ClusterSnapshotCopyStatus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClusterStatus())
            {
                context.Writer.WritePropertyName("ClusterStatus");
                context.Writer.WriteStringValue(requestObject.ClusterStatus);
            }

            if(requestObject.IsSetClusterSubnetGroupName())
            {
                context.Writer.WritePropertyName("ClusterSubnetGroupName");
                context.Writer.WriteStringValue(requestObject.ClusterSubnetGroupName);
            }

            if(requestObject.IsSetClusterVersion())
            {
                context.Writer.WritePropertyName("ClusterVersion");
                context.Writer.WriteStringValue(requestObject.ClusterVersion);
            }

            if(requestObject.IsSetDBName())
            {
                context.Writer.WritePropertyName("DBName");
                context.Writer.WriteStringValue(requestObject.DBName);
            }

            if(requestObject.IsSetDeferredMaintenanceWindows())
            {
                context.Writer.WritePropertyName("DeferredMaintenanceWindows");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDeferredMaintenanceWindowsListValue in requestObject.DeferredMaintenanceWindows)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRedshiftClusterDeferredMaintenanceWindowMarshaller.Instance;
                    marshaller.Marshall(requestObjectDeferredMaintenanceWindowsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetElasticIpStatus())
            {
                context.Writer.WritePropertyName("ElasticIpStatus");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterElasticIpStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.ElasticIpStatus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetElasticResizeNumberOfNodeOptions())
            {
                context.Writer.WritePropertyName("ElasticResizeNumberOfNodeOptions");
                context.Writer.WriteStringValue(requestObject.ElasticResizeNumberOfNodeOptions);
            }

            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("Encrypted");
                context.Writer.WriteBooleanValue(requestObject.Encrypted.Value);
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("Endpoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterEndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.Endpoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnhancedVpcRouting())
            {
                context.Writer.WritePropertyName("EnhancedVpcRouting");
                context.Writer.WriteBooleanValue(requestObject.EnhancedVpcRouting.Value);
            }

            if(requestObject.IsSetExpectedNextSnapshotScheduleTime())
            {
                context.Writer.WritePropertyName("ExpectedNextSnapshotScheduleTime");
                context.Writer.WriteStringValue(requestObject.ExpectedNextSnapshotScheduleTime);
            }

            if(requestObject.IsSetExpectedNextSnapshotScheduleTimeStatus())
            {
                context.Writer.WritePropertyName("ExpectedNextSnapshotScheduleTimeStatus");
                context.Writer.WriteStringValue(requestObject.ExpectedNextSnapshotScheduleTimeStatus);
            }

            if(requestObject.IsSetHsmStatus())
            {
                context.Writer.WritePropertyName("HsmStatus");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterHsmStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.HsmStatus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamRoles())
            {
                context.Writer.WritePropertyName("IamRoles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIamRolesListValue in requestObject.IamRoles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRedshiftClusterIamRoleMarshaller.Instance;
                    marshaller.Marshall(requestObjectIamRolesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLoggingStatus())
            {
                context.Writer.WritePropertyName("LoggingStatus");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterLoggingStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.LoggingStatus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaintenanceTrackName())
            {
                context.Writer.WritePropertyName("MaintenanceTrackName");
                context.Writer.WriteStringValue(requestObject.MaintenanceTrackName);
            }

            if(requestObject.IsSetManualSnapshotRetentionPeriod())
            {
                context.Writer.WritePropertyName("ManualSnapshotRetentionPeriod");
                context.Writer.WriteNumberValue(requestObject.ManualSnapshotRetentionPeriod.Value);
            }

            if(requestObject.IsSetMasterUsername())
            {
                context.Writer.WritePropertyName("MasterUsername");
                context.Writer.WriteStringValue(requestObject.MasterUsername);
            }

            if(requestObject.IsSetNextMaintenanceWindowStartTime())
            {
                context.Writer.WritePropertyName("NextMaintenanceWindowStartTime");
                context.Writer.WriteStringValue(requestObject.NextMaintenanceWindowStartTime);
            }

            if(requestObject.IsSetNodeType())
            {
                context.Writer.WritePropertyName("NodeType");
                context.Writer.WriteStringValue(requestObject.NodeType);
            }

            if(requestObject.IsSetNumberOfNodes())
            {
                context.Writer.WritePropertyName("NumberOfNodes");
                context.Writer.WriteNumberValue(requestObject.NumberOfNodes.Value);
            }

            if(requestObject.IsSetPendingActions())
            {
                context.Writer.WritePropertyName("PendingActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPendingActionsListValue in requestObject.PendingActions)
                {
                        context.Writer.WriteStringValue(requestObjectPendingActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPendingModifiedValues())
            {
                context.Writer.WritePropertyName("PendingModifiedValues");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterPendingModifiedValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.PendingModifiedValues, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                context.Writer.WriteStringValue(requestObject.PreferredMaintenanceWindow);
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.WriteBooleanValue(requestObject.PubliclyAccessible.Value);
            }

            if(requestObject.IsSetResizeInfo())
            {
                context.Writer.WritePropertyName("ResizeInfo");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterResizeInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.ResizeInfo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRestoreStatus())
            {
                context.Writer.WritePropertyName("RestoreStatus");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterRestoreStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.RestoreStatus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnapshotScheduleIdentifier())
            {
                context.Writer.WritePropertyName("SnapshotScheduleIdentifier");
                context.Writer.WriteStringValue(requestObject.SnapshotScheduleIdentifier);
            }

            if(requestObject.IsSetSnapshotScheduleState())
            {
                context.Writer.WritePropertyName("SnapshotScheduleState");
                context.Writer.WriteStringValue(requestObject.SnapshotScheduleState);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.WriteStringValue(requestObject.VpcId);
            }

            if(requestObject.IsSetVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("VpcSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVpcSecurityGroupsListValue in requestObject.VpcSecurityGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRedshiftClusterVpcSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcSecurityGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsRedshiftClusterDetailsMarshaller Instance = new AwsRedshiftClusterDetailsMarshaller();

    }
}