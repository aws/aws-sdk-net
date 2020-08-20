/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            if(requestObject.IsSetActivityStreamStatus())
            {
                context.Writer.WritePropertyName("ActivityStreamStatus");
                context.Writer.Write(requestObject.ActivityStreamStatus);
            }

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

                    var marshaller = AwsRdsDbClusterAssociatedRoleMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssociatedRolesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.Write(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBackupRetentionPeriod())
            {
                context.Writer.WritePropertyName("BackupRetentionPeriod");
                context.Writer.Write(requestObject.BackupRetentionPeriod);
            }

            if(requestObject.IsSetClusterCreateTime())
            {
                context.Writer.WritePropertyName("ClusterCreateTime");
                context.Writer.Write(requestObject.ClusterCreateTime);
            }

            if(requestObject.IsSetCopyTagsToSnapshot())
            {
                context.Writer.WritePropertyName("CopyTagsToSnapshot");
                context.Writer.Write(requestObject.CopyTagsToSnapshot);
            }

            if(requestObject.IsSetCrossAccountClone())
            {
                context.Writer.WritePropertyName("CrossAccountClone");
                context.Writer.Write(requestObject.CrossAccountClone);
            }

            if(requestObject.IsSetCustomEndpoints())
            {
                context.Writer.WritePropertyName("CustomEndpoints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCustomEndpointsListValue in requestObject.CustomEndpoints)
                {
                        context.Writer.Write(requestObjectCustomEndpointsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDbClusterIdentifier())
            {
                context.Writer.WritePropertyName("DbClusterIdentifier");
                context.Writer.Write(requestObject.DbClusterIdentifier);
            }

            if(requestObject.IsSetDbClusterMembers())
            {
                context.Writer.WritePropertyName("DbClusterMembers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDbClusterMembersListValue in requestObject.DbClusterMembers)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbClusterMemberMarshaller.Instance;
                    marshaller.Marshall(requestObjectDbClusterMembersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDbClusterOptionGroupMemberships())
            {
                context.Writer.WritePropertyName("DbClusterOptionGroupMemberships");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDbClusterOptionGroupMembershipsListValue in requestObject.DbClusterOptionGroupMemberships)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbClusterOptionGroupMembershipMarshaller.Instance;
                    marshaller.Marshall(requestObjectDbClusterOptionGroupMembershipsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDbClusterParameterGroup())
            {
                context.Writer.WritePropertyName("DbClusterParameterGroup");
                context.Writer.Write(requestObject.DbClusterParameterGroup);
            }

            if(requestObject.IsSetDbClusterResourceId())
            {
                context.Writer.WritePropertyName("DbClusterResourceId");
                context.Writer.Write(requestObject.DbClusterResourceId);
            }

            if(requestObject.IsSetDbSubnetGroup())
            {
                context.Writer.WritePropertyName("DbSubnetGroup");
                context.Writer.Write(requestObject.DbSubnetGroup);
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
                context.Writer.Write(requestObject.Endpoint);
            }

            if(requestObject.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.Write(requestObject.Engine);
            }

            if(requestObject.IsSetEngineMode())
            {
                context.Writer.WritePropertyName("EngineMode");
                context.Writer.Write(requestObject.EngineMode);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.Write(requestObject.EngineVersion);
            }

            if(requestObject.IsSetHostedZoneId())
            {
                context.Writer.WritePropertyName("HostedZoneId");
                context.Writer.Write(requestObject.HostedZoneId);
            }

            if(requestObject.IsSetHttpEndpointEnabled())
            {
                context.Writer.WritePropertyName("HttpEndpointEnabled");
                context.Writer.Write(requestObject.HttpEndpointEnabled);
            }

            if(requestObject.IsSetIamDatabaseAuthenticationEnabled())
            {
                context.Writer.WritePropertyName("IamDatabaseAuthenticationEnabled");
                context.Writer.Write(requestObject.IamDatabaseAuthenticationEnabled);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetMasterUsername())
            {
                context.Writer.WritePropertyName("MasterUsername");
                context.Writer.Write(requestObject.MasterUsername);
            }

            if(requestObject.IsSetMultiAz())
            {
                context.Writer.WritePropertyName("MultiAz");
                context.Writer.Write(requestObject.MultiAz);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
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

            if(requestObject.IsSetReaderEndpoint())
            {
                context.Writer.WritePropertyName("ReaderEndpoint");
                context.Writer.Write(requestObject.ReaderEndpoint);
            }

            if(requestObject.IsSetReadReplicaIdentifiers())
            {
                context.Writer.WritePropertyName("ReadReplicaIdentifiers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReadReplicaIdentifiersListValue in requestObject.ReadReplicaIdentifiers)
                {
                        context.Writer.Write(requestObjectReadReplicaIdentifiersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetStorageEncrypted())
            {
                context.Writer.WritePropertyName("StorageEncrypted");
                context.Writer.Write(requestObject.StorageEncrypted);
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
        public readonly static AwsRdsDbClusterDetailsMarshaller Instance = new AwsRdsDbClusterDetailsMarshaller();

    }
}