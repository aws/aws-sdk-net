/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Cluster Request Marshaller
    /// </summary>       
    public class CreateClusterRequestMarshaller : IMarshaller<IRequest, CreateClusterRequest>
    {
        public IRequest Marshall(CreateClusterRequest createClusterRequest)
        {
            IRequest request = new DefaultRequest(createClusterRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "CreateCluster");
            request.Parameters.Add("Version", "2012-12-01");
            if (createClusterRequest != null && createClusterRequest.IsSetDBName())
            {
                request.Parameters.Add("DBName", StringUtils.FromString(createClusterRequest.DBName));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(createClusterRequest.ClusterIdentifier));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetClusterType())
            {
                request.Parameters.Add("ClusterType", StringUtils.FromString(createClusterRequest.ClusterType));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetNodeType())
            {
                request.Parameters.Add("NodeType", StringUtils.FromString(createClusterRequest.NodeType));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetMasterUsername())
            {
                request.Parameters.Add("MasterUsername", StringUtils.FromString(createClusterRequest.MasterUsername));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetMasterUserPassword())
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(createClusterRequest.MasterUserPassword));
            }
            if (createClusterRequest != null)
            {
                List<string> clusterSecurityGroupsList = createClusterRequest.ClusterSecurityGroups;

                int clusterSecurityGroupsListIndex = 1;
                foreach (string clusterSecurityGroupsListValue in clusterSecurityGroupsList)
                { 
                    request.Parameters.Add("ClusterSecurityGroups.member." + clusterSecurityGroupsListIndex, StringUtils.FromString(clusterSecurityGroupsListValue));
                    clusterSecurityGroupsListIndex++;
                }
            }
            if (createClusterRequest != null)
            {
                List<string> vpcSecurityGroupIdsList = createClusterRequest.VpcSecurityGroupIds;

                int vpcSecurityGroupIdsListIndex = 1;
                foreach (string vpcSecurityGroupIdsListValue in vpcSecurityGroupIdsList)
                { 
                    request.Parameters.Add("VpcSecurityGroupIds.member." + vpcSecurityGroupIdsListIndex, StringUtils.FromString(vpcSecurityGroupIdsListValue));
                    vpcSecurityGroupIdsListIndex++;
                }
            }
            if (createClusterRequest != null && createClusterRequest.IsSetClusterSubnetGroupName())
            {
                request.Parameters.Add("ClusterSubnetGroupName", StringUtils.FromString(createClusterRequest.ClusterSubnetGroupName));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(createClusterRequest.AvailabilityZone));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(createClusterRequest.PreferredMaintenanceWindow));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetClusterParameterGroupName())
            {
                request.Parameters.Add("ClusterParameterGroupName", StringUtils.FromString(createClusterRequest.ClusterParameterGroupName));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetAutomatedSnapshotRetentionPeriod())
            {
                request.Parameters.Add("AutomatedSnapshotRetentionPeriod", StringUtils.FromInt(createClusterRequest.AutomatedSnapshotRetentionPeriod));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(createClusterRequest.Port));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetClusterVersion())
            {
                request.Parameters.Add("ClusterVersion", StringUtils.FromString(createClusterRequest.ClusterVersion));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetAllowVersionUpgrade())
            {
                request.Parameters.Add("AllowVersionUpgrade", StringUtils.FromBool(createClusterRequest.AllowVersionUpgrade));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetNumberOfNodes())
            {
                request.Parameters.Add("NumberOfNodes", StringUtils.FromInt(createClusterRequest.NumberOfNodes));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(createClusterRequest.PubliclyAccessible));
            }
            if (createClusterRequest != null && createClusterRequest.IsSetEncrypted())
            {
                request.Parameters.Add("Encrypted", StringUtils.FromBool(createClusterRequest.Encrypted));
            }

            return request;
        }
    }
}
