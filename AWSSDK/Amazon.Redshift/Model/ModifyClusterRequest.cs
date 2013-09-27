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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCluster operation.
    /// <para> Modifies the settings for a cluster. For example, you can add another security or parameter group, update the preferred maintenance
    /// window, or change the master user password. Resetting a cluster password or modifying the security groups associated with a cluster do not
    /// need a reboot. However, modifying parameter group requires a reboot for parameters to take effect. For more information about managing
    /// clusters, go to Amazon Redshift Clusters in the <i>Amazon Redshift Management Guide</i> </para> <para>You can also change node type and the
    /// number of nodes to scale up or down the cluster. When resizing a cluster, you must specify both the number of nodes and the node type even
    /// if one of the parameters does not change. If you specify the same number of nodes and node type that are already configured for the cluster,
    /// an error is returned.</para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.ModifyCluster"/>
    public class ModifyClusterRequest : AmazonWebServiceRequest
    {
        private string clusterIdentifier;
        private string clusterType;
        private string nodeType;
        private int? numberOfNodes;
        private List<string> clusterSecurityGroups = new List<string>();
        private List<string> vpcSecurityGroupIds = new List<string>();
        private string masterUserPassword;
        private string clusterParameterGroupName;
        private int? automatedSnapshotRetentionPeriod;
        private string preferredMaintenanceWindow;
        private string clusterVersion;
        private bool? allowVersionUpgrade;

        /// <summary>
        /// The unique identifier of the cluster to be modified. Example: <c>examplecluster</c>
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        /// <summary>
        /// Sets the ClusterIdentifier property
        /// </summary>
        /// <param name="clusterIdentifier">The value to set for the ClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithClusterIdentifier(string clusterIdentifier)
        {
            this.clusterIdentifier = clusterIdentifier;
            return this;
        }
            

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

        /// <summary>
        /// The new cluster type. When you submit your cluster resize request, your existing cluster goes into a read-only mode. After Amazon Redshift
        /// provisions a new cluster based on your resize requirements, there will be outage for a period while the old cluster is deleted and your
        /// connection is switched to the new cluster. You can use <a>DescribeResize</a> to track the progress of the resize request. Valid Values: <c>
        /// multi-node | single-node </c>
        ///  
        /// </summary>
        public string ClusterType
        {
            get { return this.clusterType; }
            set { this.clusterType = value; }
        }

        /// <summary>
        /// Sets the ClusterType property
        /// </summary>
        /// <param name="clusterType">The value to set for the ClusterType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithClusterType(string clusterType)
        {
            this.clusterType = clusterType;
            return this;
        }
            

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this.clusterType != null;
        }

        /// <summary>
        /// The new node type of the cluster. If you specify a new node type, you must also specify the number of nodes parameter also. When you submit
        /// your request to resize a cluster, Amazon Redshift sets access permissions for the cluster to read-only. After Amazon Redshift provisions a
        /// new cluster according to your resize requirements, there will be a temporary outage while the old cluster is deleted and your connection is
        /// switched to the new cluster. When the new connection is complete, the original access permissions for the cluster are restored. You can use
        /// the <a>DescribeResize</a> to track the progress of the resize request. Valid Values: <c> dw.hs1.xlarge</c> | <c>dw.hs1.8xlarge</c>
        ///  
        /// </summary>
        public string NodeType
        {
            get { return this.nodeType; }
            set { this.nodeType = value; }
        }

        /// <summary>
        /// Sets the NodeType property
        /// </summary>
        /// <param name="nodeType">The value to set for the NodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithNodeType(string nodeType)
        {
            this.nodeType = nodeType;
            return this;
        }
            

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this.nodeType != null;
        }

        /// <summary>
        /// The new number of nodes of the cluster. If you specify a new number of nodes, you must also specify the node type parameter also. When you
        /// submit your request to resize a cluster, Amazon Redshift sets access permissions for the cluster to read-only. After Amazon Redshift
        /// provisions a new cluster according to your resize requirements, there will be a temporary outage while the old cluster is deleted and your
        /// connection is switched to the new cluster. When the new connection is complete, the original access permissions for the cluster are
        /// restored. You can use <a>DescribeResize</a> to track the progress of the resize request. Valid Values: Integer greater than <c>0</c>.
        ///  
        /// </summary>
        public int NumberOfNodes
        {
            get { return this.numberOfNodes ?? default(int); }
            set { this.numberOfNodes = value; }
        }

        /// <summary>
        /// Sets the NumberOfNodes property
        /// </summary>
        /// <param name="numberOfNodes">The value to set for the NumberOfNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithNumberOfNodes(int numberOfNodes)
        {
            this.numberOfNodes = numberOfNodes;
            return this;
        }
            

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this.numberOfNodes.HasValue;
        }

        /// <summary>
        /// A list of cluster security groups to be authorized on this cluster. This change is asynchronously applied as soon as possible. Security
        /// groups currently associated with the cluster and not in the list of groups to apply, will be revoked from the cluster. Constraints: <ul>
        /// <li>Must be 1 to 255 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or
        /// contain two consecutive hyphens</li> </ul>
        ///  
        /// </summary>
        public List<string> ClusterSecurityGroups
        {
            get { return this.clusterSecurityGroups; }
            set { this.clusterSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the ClusterSecurityGroups collection
        /// </summary>
        /// <param name="clusterSecurityGroups">The values to add to the ClusterSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithClusterSecurityGroups(params string[] clusterSecurityGroups)
        {
            foreach (string element in clusterSecurityGroups)
            {
                this.clusterSecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ClusterSecurityGroups collection
        /// </summary>
        /// <param name="clusterSecurityGroups">The values to add to the ClusterSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithClusterSecurityGroups(IEnumerable<string> clusterSecurityGroups)
        {
            foreach (string element in clusterSecurityGroups)
            {
                this.clusterSecurityGroups.Add(element);
            }

            return this;
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this.clusterSecurityGroups.Count > 0;
        }

        /// <summary>
        /// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.
        ///  
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this.vpcSecurityGroupIds; }
            set { this.vpcSecurityGroupIds = value; }
        }
        /// <summary>
        /// Adds elements to the VpcSecurityGroupIds collection
        /// </summary>
        /// <param name="vpcSecurityGroupIds">The values to add to the VpcSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithVpcSecurityGroupIds(params string[] vpcSecurityGroupIds)
        {
            foreach (string element in vpcSecurityGroupIds)
            {
                this.vpcSecurityGroupIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VpcSecurityGroupIds collection
        /// </summary>
        /// <param name="vpcSecurityGroupIds">The values to add to the VpcSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithVpcSecurityGroupIds(IEnumerable<string> vpcSecurityGroupIds)
        {
            foreach (string element in vpcSecurityGroupIds)
            {
                this.vpcSecurityGroupIds.Add(element);
            }

            return this;
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this.vpcSecurityGroupIds.Count > 0;
        }

        /// <summary>
        /// The new password for the cluster master user. This change is asynchronously applied as soon as possible. Between the time of the request and
        /// the completion of the request, the <c>MasterUserPassword</c> element exists in the <c>PendingModifiedValues</c> element of the operation
        /// response. <note> Operations never return the password, so this operation provides a way to regain access to the master user account for a
        /// cluster if the password is lost. </note> Default: Uses existing setting. Constraints: <ul> <li>Must be between 8 and 64 characters in
        /// length.</li> <li>Must contain at least one uppercase letter.</li> <li>Must contain at least one lowercase letter.</li> <li>Must contain one
        /// number.</li> <li>Can be any printable ASCII character (ASCII code 33 to 126) except ' (single quote), " (double quote), \, /, @, or
        /// space.</li> </ul>
        ///  
        /// </summary>
        public string MasterUserPassword
        {
            get { return this.masterUserPassword; }
            set { this.masterUserPassword = value; }
        }

        /// <summary>
        /// Sets the MasterUserPassword property
        /// </summary>
        /// <param name="masterUserPassword">The value to set for the MasterUserPassword property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithMasterUserPassword(string masterUserPassword)
        {
            this.masterUserPassword = masterUserPassword;
            return this;
        }
            

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this.masterUserPassword != null;
        }

        /// <summary>
        /// The name of the cluster parameter group to apply to this cluster. This change is applied only after the cluster is rebooted. To reboot a
        /// cluster use <a>RebootCluster</a>. Default: Uses existing setting. Constraints: The cluster parameter group must be in the same parameter
        /// group family that matches the cluster version.
        ///  
        /// </summary>
        public string ClusterParameterGroupName
        {
            get { return this.clusterParameterGroupName; }
            set { this.clusterParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the ClusterParameterGroupName property
        /// </summary>
        /// <param name="clusterParameterGroupName">The value to set for the ClusterParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithClusterParameterGroupName(string clusterParameterGroupName)
        {
            this.clusterParameterGroupName = clusterParameterGroupName;
            return this;
        }
            

        // Check to see if ClusterParameterGroupName property is set
        internal bool IsSetClusterParameterGroupName()
        {
            return this.clusterParameterGroupName != null;
        }

        /// <summary>
        /// The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots
        /// are disabled, you can still create manual snapshots when you want with <a>CreateClusterSnapshot</a>. If you decrease the automated snapshot
        /// retention period from its current value, existing automated snapshots which fall outside of the new retention period will be immediately
        /// deleted. Default: Uses existing setting. Constraints: Must be a value from 0 to 35.
        ///  
        /// </summary>
        public int AutomatedSnapshotRetentionPeriod
        {
            get { return this.automatedSnapshotRetentionPeriod ?? default(int); }
            set { this.automatedSnapshotRetentionPeriod = value; }
        }

        /// <summary>
        /// Sets the AutomatedSnapshotRetentionPeriod property
        /// </summary>
        /// <param name="automatedSnapshotRetentionPeriod">The value to set for the AutomatedSnapshotRetentionPeriod property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithAutomatedSnapshotRetentionPeriod(int automatedSnapshotRetentionPeriod)
        {
            this.automatedSnapshotRetentionPeriod = automatedSnapshotRetentionPeriod;
            return this;
        }
            

        // Check to see if AutomatedSnapshotRetentionPeriod property is set
        internal bool IsSetAutomatedSnapshotRetentionPeriod()
        {
            return this.automatedSnapshotRetentionPeriod.HasValue;
        }

        /// <summary>
        /// The weekly time range (in UTC) during which system maintenance can occur, if necessary. If system maintenance is necessary during the
        /// window, it may result in an outage. This maintenance window change is made immediately. If the new maintenance window indicates the current
        /// time, there must be at least 120 minutes between the current time and end of the window in order to ensure that pending changes are applied.
        /// Default: Uses existing setting. Format: ddd:hh24:mi-ddd:hh24:mi, for example <c>wed:07:30-wed:08:00</c>. Valid Days: Mon | Tue | Wed | Thu |
        /// Fri | Sat | Sun Constraints: Must be at least 30 minutes.
        ///  
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this.preferredMaintenanceWindow; }
            set { this.preferredMaintenanceWindow = value; }
        }

        /// <summary>
        /// Sets the PreferredMaintenanceWindow property
        /// </summary>
        /// <param name="preferredMaintenanceWindow">The value to set for the PreferredMaintenanceWindow property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
        {
            this.preferredMaintenanceWindow = preferredMaintenanceWindow;
            return this;
        }
            

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this.preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// The new version number of the Amazon Redshift engine to upgrade to. For major version upgrades, if a non-default cluster parameter group is
        /// currently in use, a new cluster parameter group in the cluster parameter group family for the new version must be specified. The new cluster
        /// parameter group can be the default for that cluster parameter group family. For more information about managing parameter groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i>. Example: <c>1.0</c>
        ///  
        /// </summary>
        public string ClusterVersion
        {
            get { return this.clusterVersion; }
            set { this.clusterVersion = value; }
        }

        /// <summary>
        /// Sets the ClusterVersion property
        /// </summary>
        /// <param name="clusterVersion">The value to set for the ClusterVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithClusterVersion(string clusterVersion)
        {
            this.clusterVersion = clusterVersion;
            return this;
        }
            

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this.clusterVersion != null;
        }

        /// <summary>
        /// If <c>true</c>, upgrades will be applied automatically to the cluster during the maintenance window. Default: <c>false</c>
        ///  
        /// </summary>
        public bool AllowVersionUpgrade
        {
            get { return this.allowVersionUpgrade ?? default(bool); }
            set { this.allowVersionUpgrade = value; }
        }

        /// <summary>
        /// Sets the AllowVersionUpgrade property
        /// </summary>
        /// <param name="allowVersionUpgrade">The value to set for the AllowVersionUpgrade property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithAllowVersionUpgrade(bool allowVersionUpgrade)
        {
            this.allowVersionUpgrade = allowVersionUpgrade;
            return this;
        }
            

        // Check to see if AllowVersionUpgrade property is set
        internal bool IsSetAllowVersionUpgrade()
        {
            return this.allowVersionUpgrade.HasValue;
        }
    }
}
    
