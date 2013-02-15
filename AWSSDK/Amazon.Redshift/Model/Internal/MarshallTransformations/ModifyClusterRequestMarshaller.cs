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
    /// Modify Cluster Request Marshaller
    /// </summary>       
    public class ModifyClusterRequestMarshaller : IMarshaller<IRequest, ModifyClusterRequest>
    {
        public IRequest Marshall(ModifyClusterRequest modifyClusterRequest)
        {
            IRequest request = new DefaultRequest(modifyClusterRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "ModifyCluster");
            request.Parameters.Add("Version", "2012-12-01");
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(modifyClusterRequest.ClusterIdentifier));
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetClusterType())
            {
                request.Parameters.Add("ClusterType", StringUtils.FromString(modifyClusterRequest.ClusterType));
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetNodeType())
            {
                request.Parameters.Add("NodeType", StringUtils.FromString(modifyClusterRequest.NodeType));
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetNumberOfNodes())
            {
                request.Parameters.Add("NumberOfNodes", StringUtils.FromInt(modifyClusterRequest.NumberOfNodes));
            }
            if (modifyClusterRequest != null)
            {
                List<string> clusterSecurityGroupsList = modifyClusterRequest.ClusterSecurityGroups;

                int clusterSecurityGroupsListIndex = 1;
                foreach (string clusterSecurityGroupsListValue in clusterSecurityGroupsList)
                { 
                    request.Parameters.Add("ClusterSecurityGroups.member." + clusterSecurityGroupsListIndex, StringUtils.FromString(clusterSecurityGroupsListValue));
                    clusterSecurityGroupsListIndex++;
                }
            }
            if (modifyClusterRequest != null)
            {
                List<string> vpcSecurityGroupIdsList = modifyClusterRequest.VpcSecurityGroupIds;

                int vpcSecurityGroupIdsListIndex = 1;
                foreach (string vpcSecurityGroupIdsListValue in vpcSecurityGroupIdsList)
                { 
                    request.Parameters.Add("VpcSecurityGroupIds.member." + vpcSecurityGroupIdsListIndex, StringUtils.FromString(vpcSecurityGroupIdsListValue));
                    vpcSecurityGroupIdsListIndex++;
                }
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetMasterUserPassword())
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(modifyClusterRequest.MasterUserPassword));
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetClusterParameterGroupName())
            {
                request.Parameters.Add("ClusterParameterGroupName", StringUtils.FromString(modifyClusterRequest.ClusterParameterGroupName));
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetAutomatedSnapshotRetentionPeriod())
            {
                request.Parameters.Add("AutomatedSnapshotRetentionPeriod", StringUtils.FromInt(modifyClusterRequest.AutomatedSnapshotRetentionPeriod));
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(modifyClusterRequest.PreferredMaintenanceWindow));
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetClusterVersion())
            {
                request.Parameters.Add("ClusterVersion", StringUtils.FromString(modifyClusterRequest.ClusterVersion));
            }
            if (modifyClusterRequest != null && modifyClusterRequest.IsSetAllowVersionUpgrade())
            {
                request.Parameters.Add("AllowVersionUpgrade", StringUtils.FromBool(modifyClusterRequest.AllowVersionUpgrade));
            }

            return request;
        }
    }
}
