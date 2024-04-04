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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreFromClusterSnapshot Request Marshaller
    /// </summary>       
    public class RestoreFromClusterSnapshotRequestMarshaller : IMarshaller<IRequest, RestoreFromClusterSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreFromClusterSnapshotRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreFromClusterSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "RestoreFromClusterSnapshot");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAdditionalInfo())
                {
                    request.Parameters.Add("AdditionalInfo", StringUtils.FromString(publicRequest.AdditionalInfo));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAllowVersionUpgrade())
                {
                    request.Parameters.Add("AllowVersionUpgrade", StringUtils.FromBool(publicRequest.AllowVersionUpgrade));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAquaConfigurationStatus())
                {
                    request.Parameters.Add("AquaConfigurationStatus", StringUtils.FromString(publicRequest.AquaConfigurationStatus));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAutomatedSnapshotRetentionPeriod())
                {
                    request.Parameters.Add("AutomatedSnapshotRetentionPeriod", StringUtils.FromInt(publicRequest.AutomatedSnapshotRetentionPeriod));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAvailabilityZoneRelocation())
                {
                    request.Parameters.Add("AvailabilityZoneRelocation", StringUtils.FromBool(publicRequest.AvailabilityZoneRelocation));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetClusterParameterGroupName())
                {
                    request.Parameters.Add("ClusterParameterGroupName", StringUtils.FromString(publicRequest.ClusterParameterGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetClusterSecurityGroups())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ClusterSecurityGroups)
                    {
                        request.Parameters.Add("ClusterSecurityGroups" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetClusterSubnetGroupName())
                {
                    request.Parameters.Add("ClusterSubnetGroupName", StringUtils.FromString(publicRequest.ClusterSubnetGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDefaultIamRoleArn())
                {
                    request.Parameters.Add("DefaultIamRoleArn", StringUtils.FromString(publicRequest.DefaultIamRoleArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetElasticIp())
                {
                    request.Parameters.Add("ElasticIp", StringUtils.FromString(publicRequest.ElasticIp));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEncrypted())
                {
                    request.Parameters.Add("Encrypted", StringUtils.FromBool(publicRequest.Encrypted));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnhancedVpcRouting())
                {
                    request.Parameters.Add("EnhancedVpcRouting", StringUtils.FromBool(publicRequest.EnhancedVpcRouting));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetHsmClientCertificateIdentifier())
                {
                    request.Parameters.Add("HsmClientCertificateIdentifier", StringUtils.FromString(publicRequest.HsmClientCertificateIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetHsmConfigurationIdentifier())
                {
                    request.Parameters.Add("HsmConfigurationIdentifier", StringUtils.FromString(publicRequest.HsmConfigurationIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIamRoles())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.IamRoles)
                    {
                        request.Parameters.Add("IamRoles" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIpAddressType())
                {
                    request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetKmsKeyId())
                {
                    request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaintenanceTrackName())
                {
                    request.Parameters.Add("MaintenanceTrackName", StringUtils.FromString(publicRequest.MaintenanceTrackName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetManageMasterPassword())
                {
                    request.Parameters.Add("ManageMasterPassword", StringUtils.FromBool(publicRequest.ManageMasterPassword));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetManualSnapshotRetentionPeriod())
                {
                    request.Parameters.Add("ManualSnapshotRetentionPeriod", StringUtils.FromInt(publicRequest.ManualSnapshotRetentionPeriod));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMasterPasswordSecretKmsKeyId())
                {
                    request.Parameters.Add("MasterPasswordSecretKmsKeyId", StringUtils.FromString(publicRequest.MasterPasswordSecretKmsKeyId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMultiAZ())
                {
                    request.Parameters.Add("MultiAZ", StringUtils.FromBool(publicRequest.MultiAZ));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNodeType())
                {
                    request.Parameters.Add("NodeType", StringUtils.FromString(publicRequest.NodeType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNumberOfNodes())
                {
                    request.Parameters.Add("NumberOfNodes", StringUtils.FromInt(publicRequest.NumberOfNodes));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOwnerAccount())
                {
                    request.Parameters.Add("OwnerAccount", StringUtils.FromString(publicRequest.OwnerAccount));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPubliclyAccessible())
                {
                    request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetReservedNodeId())
                {
                    request.Parameters.Add("ReservedNodeId", StringUtils.FromString(publicRequest.ReservedNodeId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshotArn())
                {
                    request.Parameters.Add("SnapshotArn", StringUtils.FromString(publicRequest.SnapshotArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshotClusterIdentifier())
                {
                    request.Parameters.Add("SnapshotClusterIdentifier", StringUtils.FromString(publicRequest.SnapshotClusterIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshotIdentifier())
                {
                    request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(publicRequest.SnapshotIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshotScheduleIdentifier())
                {
                    request.Parameters.Add("SnapshotScheduleIdentifier", StringUtils.FromString(publicRequest.SnapshotScheduleIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTargetReservedNodeOfferingId())
                {
                    request.Parameters.Add("TargetReservedNodeOfferingId", StringUtils.FromString(publicRequest.TargetReservedNodeOfferingId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static RestoreFromClusterSnapshotRequestMarshaller _instance = new RestoreFromClusterSnapshotRequestMarshaller();        

        internal static RestoreFromClusterSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreFromClusterSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}