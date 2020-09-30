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
            if(requestObject.IsSetAllowVersionUpgrade())
            {
                context.Writer.WritePropertyName("AllowVersionUpgrade");
                context.Writer.Write(requestObject.AllowVersionUpgrade);
            }

            if(requestObject.IsSetAutomatedSnapshotRetentionPeriod())
            {
                context.Writer.WritePropertyName("AutomatedSnapshotRetentionPeriod");
                context.Writer.Write(requestObject.AutomatedSnapshotRetentionPeriod);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.Write(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetClusterAvailabilityStatus())
            {
                context.Writer.WritePropertyName("ClusterAvailabilityStatus");
                context.Writer.Write(requestObject.ClusterAvailabilityStatus);
            }

            if(requestObject.IsSetClusterCreateTime())
            {
                context.Writer.WritePropertyName("ClusterCreateTime");
                context.Writer.Write(requestObject.ClusterCreateTime);
            }

            if(requestObject.IsSetClusterIdentifier())
            {
                context.Writer.WritePropertyName("ClusterIdentifier");
                context.Writer.Write(requestObject.ClusterIdentifier);
            }

            if(requestObject.IsSetClusterNodes())
            {
                context.Writer.WritePropertyName("ClusterNodes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectClusterNodesListValue in requestObject.ClusterNodes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRedshiftClusterClusterNodeMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterNodesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetClusterParameterGroups())
            {
                context.Writer.WritePropertyName("ClusterParameterGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectClusterParameterGroupsListValue in requestObject.ClusterParameterGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRedshiftClusterClusterParameterGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterParameterGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetClusterPublicKey())
            {
                context.Writer.WritePropertyName("ClusterPublicKey");
                context.Writer.Write(requestObject.ClusterPublicKey);
            }

            if(requestObject.IsSetClusterRevisionNumber())
            {
                context.Writer.WritePropertyName("ClusterRevisionNumber");
                context.Writer.Write(requestObject.ClusterRevisionNumber);
            }

            if(requestObject.IsSetClusterSecurityGroups())
            {
                context.Writer.WritePropertyName("ClusterSecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectClusterSecurityGroupsListValue in requestObject.ClusterSecurityGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRedshiftClusterClusterSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterSecurityGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetClusterSnapshotCopyStatus())
            {
                context.Writer.WritePropertyName("ClusterSnapshotCopyStatus");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRedshiftClusterClusterSnapshotCopyStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.ClusterSnapshotCopyStatus, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetClusterStatus())
            {
                context.Writer.WritePropertyName("ClusterStatus");
                context.Writer.Write(requestObject.ClusterStatus);
            }

            if(requestObject.IsSetClusterSubnetGroupName())
            {
                context.Writer.WritePropertyName("ClusterSubnetGroupName");
                context.Writer.Write(requestObject.ClusterSubnetGroupName);
            }

            if(requestObject.IsSetClusterVersion())
            {
                context.Writer.WritePropertyName("ClusterVersion");
                context.Writer.Write(requestObject.ClusterVersion);
            }

            if(requestObject.IsSetDBName())
            {
                context.Writer.WritePropertyName("DBName");
                context.Writer.Write(requestObject.DBName);
            }

            if(requestObject.IsSetDeferredMaintenanceWindows())
            {
                context.Writer.WritePropertyName("DeferredMaintenanceWindows");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDeferredMaintenanceWindowsListValue in requestObject.DeferredMaintenanceWindows)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRedshiftClusterDeferredMaintenanceWindowMarshaller.Instance;
                    marshaller.Marshall(requestObjectDeferredMaintenanceWindowsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetElasticIpStatus())
            {
                context.Writer.WritePropertyName("ElasticIpStatus");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRedshiftClusterElasticIpStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.ElasticIpStatus, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetElasticResizeNumberOfNodeOptions())
            {
                context.Writer.WritePropertyName("ElasticResizeNumberOfNodeOptions");
                context.Writer.Write(requestObject.ElasticResizeNumberOfNodeOptions);
            }

            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("Encrypted");
                context.Writer.Write(requestObject.Encrypted);
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("Endpoint");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRedshiftClusterEndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.Endpoint, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnhancedVpcRouting())
            {
                context.Writer.WritePropertyName("EnhancedVpcRouting");
                context.Writer.Write(requestObject.EnhancedVpcRouting);
            }

            if(requestObject.IsSetExpectedNextSnapshotScheduleTime())
            {
                context.Writer.WritePropertyName("ExpectedNextSnapshotScheduleTime");
                context.Writer.Write(requestObject.ExpectedNextSnapshotScheduleTime);
            }

            if(requestObject.IsSetExpectedNextSnapshotScheduleTimeStatus())
            {
                context.Writer.WritePropertyName("ExpectedNextSnapshotScheduleTimeStatus");
                context.Writer.Write(requestObject.ExpectedNextSnapshotScheduleTimeStatus);
            }

            if(requestObject.IsSetHsmStatus())
            {
                context.Writer.WritePropertyName("HsmStatus");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRedshiftClusterHsmStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.HsmStatus, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIamRoles())
            {
                context.Writer.WritePropertyName("IamRoles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIamRolesListValue in requestObject.IamRoles)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRedshiftClusterIamRoleMarshaller.Instance;
                    marshaller.Marshall(requestObjectIamRolesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetMaintenanceTrackName())
            {
                context.Writer.WritePropertyName("MaintenanceTrackName");
                context.Writer.Write(requestObject.MaintenanceTrackName);
            }

            if(requestObject.IsSetManualSnapshotRetentionPeriod())
            {
                context.Writer.WritePropertyName("ManualSnapshotRetentionPeriod");
                context.Writer.Write(requestObject.ManualSnapshotRetentionPeriod);
            }

            if(requestObject.IsSetMasterUsername())
            {
                context.Writer.WritePropertyName("MasterUsername");
                context.Writer.Write(requestObject.MasterUsername);
            }

            if(requestObject.IsSetNextMaintenanceWindowStartTime())
            {
                context.Writer.WritePropertyName("NextMaintenanceWindowStartTime");
                context.Writer.Write(requestObject.NextMaintenanceWindowStartTime);
            }

            if(requestObject.IsSetNodeType())
            {
                context.Writer.WritePropertyName("NodeType");
                context.Writer.Write(requestObject.NodeType);
            }

            if(requestObject.IsSetNumberOfNodes())
            {
                context.Writer.WritePropertyName("NumberOfNodes");
                context.Writer.Write(requestObject.NumberOfNodes);
            }

            if(requestObject.IsSetPendingActions())
            {
                context.Writer.WritePropertyName("PendingActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPendingActionsListValue in requestObject.PendingActions)
                {
                        context.Writer.Write(requestObjectPendingActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPendingModifiedValues())
            {
                context.Writer.WritePropertyName("PendingModifiedValues");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRedshiftClusterPendingModifiedValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.PendingModifiedValues, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                context.Writer.Write(requestObject.PreferredMaintenanceWindow);
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.Write(requestObject.PubliclyAccessible);
            }

            if(requestObject.IsSetResizeInfo())
            {
                context.Writer.WritePropertyName("ResizeInfo");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRedshiftClusterResizeInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.ResizeInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRestoreStatus())
            {
                context.Writer.WritePropertyName("RestoreStatus");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRedshiftClusterRestoreStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.RestoreStatus, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSnapshotScheduleIdentifier())
            {
                context.Writer.WritePropertyName("SnapshotScheduleIdentifier");
                context.Writer.Write(requestObject.SnapshotScheduleIdentifier);
            }

            if(requestObject.IsSetSnapshotScheduleState())
            {
                context.Writer.WritePropertyName("SnapshotScheduleState");
                context.Writer.Write(requestObject.SnapshotScheduleState);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

            if(requestObject.IsSetVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("VpcSecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVpcSecurityGroupsListValue in requestObject.VpcSecurityGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRedshiftClusterVpcSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcSecurityGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsRedshiftClusterDetailsMarshaller Instance = new AwsRedshiftClusterDetailsMarshaller();

    }
}