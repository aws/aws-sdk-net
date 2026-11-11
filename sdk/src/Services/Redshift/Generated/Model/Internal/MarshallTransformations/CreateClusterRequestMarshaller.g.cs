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

using Amazon.Redshift.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCluster Request Marshaller
    /// </summary>
    public partial class CreateClusterRequestMarshaller : IMarshaller<IRequest, CreateClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateCluster");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetAdditionalInfo())
            {
                request.Parameters.Add("AdditionalInfo", StringUtils.FromString(publicRequest.AdditionalInfo));
            }
            if (publicRequest.IsSetAllowVersionUpgrade())
            {
                request.Parameters.Add("AllowVersionUpgrade", StringUtils.FromBool(publicRequest.AllowVersionUpgrade.Value));
            }
            if (publicRequest.IsSetAquaConfigurationStatus())
            {
                request.Parameters.Add("AquaConfigurationStatus", StringUtils.FromString(publicRequest.AquaConfigurationStatus));
            }
            if (publicRequest.IsSetAutomatedSnapshotRetentionPeriod())
            {
                request.Parameters.Add("AutomatedSnapshotRetentionPeriod", StringUtils.FromInt(publicRequest.AutomatedSnapshotRetentionPeriod.Value));
            }
            if (publicRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
            }
            if (publicRequest.IsSetAvailabilityZoneRelocation())
            {
                request.Parameters.Add("AvailabilityZoneRelocation", StringUtils.FromBool(publicRequest.AvailabilityZoneRelocation.Value));
            }
            if (publicRequest.IsSetCatalogName())
            {
                request.Parameters.Add("CatalogName", StringUtils.FromString(publicRequest.CatalogName));
            }
            if (publicRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
            }
            if (publicRequest.IsSetClusterParameterGroupName())
            {
                request.Parameters.Add("ClusterParameterGroupName", StringUtils.FromString(publicRequest.ClusterParameterGroupName));
            }
            if (publicRequest.IsSetClusterSecurityGroups())
            {
                if (publicRequest.ClusterSecurityGroups.Count == 0)
                {
                    request.Parameters.Add("ClusterSecurityGroups", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ClusterSecurityGroups)
                    {
                        request.Parameters.Add("ClusterSecurityGroups" + ".ClusterSecurityGroupName" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetClusterSubnetGroupName())
            {
                request.Parameters.Add("ClusterSubnetGroupName", StringUtils.FromString(publicRequest.ClusterSubnetGroupName));
            }
            if (publicRequest.IsSetClusterType())
            {
                request.Parameters.Add("ClusterType", StringUtils.FromString(publicRequest.ClusterType));
            }
            if (publicRequest.IsSetClusterVersion())
            {
                request.Parameters.Add("ClusterVersion", StringUtils.FromString(publicRequest.ClusterVersion));
            }
            if (publicRequest.IsSetDBName())
            {
                request.Parameters.Add("DBName", StringUtils.FromString(publicRequest.DBName));
            }
            if (publicRequest.IsSetDefaultIamRoleArn())
            {
                request.Parameters.Add("DefaultIamRoleArn", StringUtils.FromString(publicRequest.DefaultIamRoleArn));
            }
            if (publicRequest.IsSetElasticIp())
            {
                request.Parameters.Add("ElasticIp", StringUtils.FromString(publicRequest.ElasticIp));
            }
            if (publicRequest.IsSetEncrypted())
            {
                request.Parameters.Add("Encrypted", StringUtils.FromBool(publicRequest.Encrypted.Value));
            }
            if (publicRequest.IsSetEnhancedVpcRouting())
            {
                request.Parameters.Add("EnhancedVpcRouting", StringUtils.FromBool(publicRequest.EnhancedVpcRouting.Value));
            }
            if (publicRequest.IsSetExtraComputeForAutomaticOptimization())
            {
                request.Parameters.Add("ExtraComputeForAutomaticOptimization", StringUtils.FromBool(publicRequest.ExtraComputeForAutomaticOptimization.Value));
            }
            if (publicRequest.IsSetHsmClientCertificateIdentifier())
            {
                request.Parameters.Add("HsmClientCertificateIdentifier", StringUtils.FromString(publicRequest.HsmClientCertificateIdentifier));
            }
            if (publicRequest.IsSetHsmConfigurationIdentifier())
            {
                request.Parameters.Add("HsmConfigurationIdentifier", StringUtils.FromString(publicRequest.HsmConfigurationIdentifier));
            }
            if (publicRequest.IsSetIamRoles())
            {
                if (publicRequest.IamRoles.Count == 0)
                {
                    request.Parameters.Add("IamRoles", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.IamRoles)
                    {
                        request.Parameters.Add("IamRoles" + ".IamRoleArn" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetIpAddressType())
            {
                request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
            }
            if (publicRequest.IsSetKmsKeyId())
            {
                request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
            }
            if (publicRequest.IsSetLoadSampleData())
            {
                request.Parameters.Add("LoadSampleData", StringUtils.FromString(publicRequest.LoadSampleData));
            }
            if (publicRequest.IsSetMaintenanceTrackName())
            {
                request.Parameters.Add("MaintenanceTrackName", StringUtils.FromString(publicRequest.MaintenanceTrackName));
            }
            if (publicRequest.IsSetManageMasterPassword())
            {
                request.Parameters.Add("ManageMasterPassword", StringUtils.FromBool(publicRequest.ManageMasterPassword.Value));
            }
            if (publicRequest.IsSetManualSnapshotRetentionPeriod())
            {
                request.Parameters.Add("ManualSnapshotRetentionPeriod", StringUtils.FromInt(publicRequest.ManualSnapshotRetentionPeriod.Value));
            }
            if (publicRequest.IsSetMasterPasswordSecretKmsKeyId())
            {
                request.Parameters.Add("MasterPasswordSecretKmsKeyId", StringUtils.FromString(publicRequest.MasterPasswordSecretKmsKeyId));
            }
            if (publicRequest.IsSetMasterUserPassword())
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
            }
            if (publicRequest.IsSetMasterUsername())
            {
                request.Parameters.Add("MasterUsername", StringUtils.FromString(publicRequest.MasterUsername));
            }
            if (publicRequest.IsSetMultiAZ())
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(publicRequest.MultiAZ.Value));
            }
            if (publicRequest.IsSetNodeType())
            {
                request.Parameters.Add("NodeType", StringUtils.FromString(publicRequest.NodeType));
            }
            if (publicRequest.IsSetNumberOfNodes())
            {
                request.Parameters.Add("NumberOfNodes", StringUtils.FromInt(publicRequest.NumberOfNodes.Value));
            }
            if (publicRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port.Value));
            }
            if (publicRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
            }
            if (publicRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible.Value));
            }
            if (publicRequest.IsSetRedshiftIdcApplicationArn())
            {
                request.Parameters.Add("RedshiftIdcApplicationArn", StringUtils.FromString(publicRequest.RedshiftIdcApplicationArn));
            }
            if (publicRequest.IsSetSnapshotScheduleIdentifier())
            {
                request.Parameters.Add("SnapshotScheduleIdentifier", StringUtils.FromString(publicRequest.SnapshotScheduleIdentifier));
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

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateClusterRequestMarshaller _instance = new();

        internal static CreateClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateClusterRequestMarshaller Instance => _instance;
    }
}
