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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Modifies the settings for a cluster. For example, you can add another security or
    /// parameter group, update the preferred maintenance window, or change the master user
    /// password. Resetting a cluster password or modifying the security groups associated
    /// with a cluster do not need a reboot. However, modifying a parameter group requires
    /// a reboot for parameters to take effect. For more information about managing clusters,
    /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can also change node type and the number of nodes to scale up or down the cluster.
    /// When resizing a cluster, you must specify both the number of nodes and the node type
    /// even if one of the parameters does not change.
    /// </para>
    /// </summary>
    public partial class ModifyClusterRequest : AmazonRedshiftRequest
    {
        private bool? _allowVersionUpgrade;
        private int? _automatedSnapshotRetentionPeriod;
        private string _clusterIdentifier;
        private string _clusterParameterGroupName;
        private List<string> _clusterSecurityGroups = new List<string>();
        private string _clusterType;
        private string _clusterVersion;
        private string _elasticIp;
        private bool? _enhancedVpcRouting;
        private string _hsmClientCertificateIdentifier;
        private string _hsmConfigurationIdentifier;
        private string _masterUserPassword;
        private string _newClusterIdentifier;
        private string _nodeType;
        private int? _numberOfNodes;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        /// If <code>true</code>, major version upgrades will be applied automatically to the
        /// cluster during the maintenance window. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool AllowVersionUpgrade
        {
            get { return this._allowVersionUpgrade.GetValueOrDefault(); }
            set { this._allowVersionUpgrade = value; }
        }

        // Check to see if AllowVersionUpgrade property is set
        internal bool IsSetAllowVersionUpgrade()
        {
            return this._allowVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that automated snapshots are retained. If the value is 0, automated
        /// snapshots are disabled. Even if automated snapshots are disabled, you can still create
        /// manual snapshots when you want with <a>CreateClusterSnapshot</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you decrease the automated snapshot retention period from its current value, existing
        /// automated snapshots that fall outside of the new retention period will be immediately
        /// deleted.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be a value from 0 to 35.
        /// </para>
        /// </summary>
        public int AutomatedSnapshotRetentionPeriod
        {
            get { return this._automatedSnapshotRetentionPeriod.GetValueOrDefault(); }
            set { this._automatedSnapshotRetentionPeriod = value; }
        }

        // Check to see if AutomatedSnapshotRetentionPeriod property is set
        internal bool IsSetAutomatedSnapshotRetentionPeriod()
        {
            return this._automatedSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster to be modified.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>examplecluster</code> 
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterParameterGroupName. 
        /// <para>
        /// The name of the cluster parameter group to apply to this cluster. This change is applied
        /// only after the cluster is rebooted. To reboot a cluster use <a>RebootCluster</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The cluster parameter group must be in the same parameter group family
        /// that matches the cluster version.
        /// </para>
        /// </summary>
        public string ClusterParameterGroupName
        {
            get { return this._clusterParameterGroupName; }
            set { this._clusterParameterGroupName = value; }
        }

        // Check to see if ClusterParameterGroupName property is set
        internal bool IsSetClusterParameterGroupName()
        {
            return this._clusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroups. 
        /// <para>
        /// A list of cluster security groups to be authorized on this cluster. This change is
        /// asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// Security groups currently associated with the cluster, and not in the list of groups
        /// to apply, will be revoked from the cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 alphanumeric characters or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> ClusterSecurityGroups
        {
            get { return this._clusterSecurityGroups; }
            set { this._clusterSecurityGroups = value; }
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this._clusterSecurityGroups != null && this._clusterSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The new cluster type.
        /// </para>
        ///  
        /// <para>
        /// When you submit your cluster resize request, your existing cluster goes into a read-only
        /// mode. After Amazon Redshift provisions a new cluster based on your resize requirements,
        /// there will be outage for a period while the old cluster is deleted and your connection
        /// is switched to the new cluster. You can use <a>DescribeResize</a> to track the progress
        /// of the resize request. 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code> multi-node | single-node </code> 
        /// </para>
        /// </summary>
        public string ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        /// The new version number of the Amazon Redshift engine to upgrade to.
        /// </para>
        ///  
        /// <para>
        /// For major version upgrades, if a non-default cluster parameter group is currently
        /// in use, a new cluster parameter group in the cluster parameter group family for the
        /// new version must be specified. The new cluster parameter group can be the default
        /// for that cluster parameter group family. For more information about parameters and
        /// parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>1.0</code> 
        /// </para>
        /// </summary>
        public string ClusterVersion
        {
            get { return this._clusterVersion; }
            set { this._clusterVersion = value; }
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this._clusterVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticIp. 
        /// <para>
        /// The Elastic IP (EIP) address for the cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The cluster must be provisioned in EC2-VPC and publicly-accessible through
        /// an Internet gateway. For more information about provisioning clusters in EC2-VPC,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#cluster-platforms">Supported
        /// Platforms to Launch Your Cluster</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        public string ElasticIp
        {
            get { return this._elasticIp; }
            set { this._elasticIp = value; }
        }

        // Check to see if ElasticIp property is set
        internal bool IsSetElasticIp()
        {
            return this._elasticIp != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// An option that specifies whether to create the cluster with enhanced VPC routing enabled.
        /// To create a cluster that uses enhanced VPC routing, the cluster must be in a VPC.
        /// For more information, see <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/enhanced-vpc-routing.html">Enhanced
        /// VPC Routing</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        ///  
        /// <para>
        /// If this option is <code>true</code>, enhanced VPC routing is enabled. 
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool EnhancedVpcRouting
        {
            get { return this._enhancedVpcRouting.GetValueOrDefault(); }
            set { this._enhancedVpcRouting = value; }
        }

        // Check to see if EnhancedVpcRouting property is set
        internal bool IsSetEnhancedVpcRouting()
        {
            return this._enhancedVpcRouting.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HsmClientCertificateIdentifier. 
        /// <para>
        /// Specifies the name of the HSM client certificate the Amazon Redshift cluster uses
        /// to retrieve the data encryption keys stored in an HSM.
        /// </para>
        /// </summary>
        public string HsmClientCertificateIdentifier
        {
            get { return this._hsmClientCertificateIdentifier; }
            set { this._hsmClientCertificateIdentifier = value; }
        }

        // Check to see if HsmClientCertificateIdentifier property is set
        internal bool IsSetHsmClientCertificateIdentifier()
        {
            return this._hsmClientCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// Specifies the name of the HSM configuration that contains the information the Amazon
        /// Redshift cluster can use to retrieve and store keys in an HSM.
        /// </para>
        /// </summary>
        public string HsmConfigurationIdentifier
        {
            get { return this._hsmConfigurationIdentifier; }
            set { this._hsmConfigurationIdentifier = value; }
        }

        // Check to see if HsmConfigurationIdentifier property is set
        internal bool IsSetHsmConfigurationIdentifier()
        {
            return this._hsmConfigurationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The new password for the cluster master user. This change is asynchronously applied
        /// as soon as possible. Between the time of the request and the completion of the request,
        /// the <code>MasterUserPassword</code> element exists in the <code>PendingModifiedValues</code>
        /// element of the operation response. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Operations never return the password, so this operation provides a way to regain access
        /// to the master user account for a cluster if the password is lost.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be between 8 and 64 characters in length.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain at least one uppercase letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain at least one lowercase letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain one number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can be any printable ASCII character (ASCII code 33 to 126) except ' (single quote),
        /// " (double quote), \, /, @, or space.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MasterUserPassword
        {
            get { return this._masterUserPassword; }
            set { this._masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this._masterUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property NewClusterIdentifier. 
        /// <para>
        /// The new identifier for the cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alphabetic characters must be lowercase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be unique for all clusters within an AWS account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>examplecluster</code> 
        /// </para>
        /// </summary>
        public string NewClusterIdentifier
        {
            get { return this._newClusterIdentifier; }
            set { this._newClusterIdentifier = value; }
        }

        // Check to see if NewClusterIdentifier property is set
        internal bool IsSetNewClusterIdentifier()
        {
            return this._newClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The new node type of the cluster. If you specify a new node type, you must also specify
        /// the number of nodes parameter.
        /// </para>
        ///  
        /// <para>
        /// When you submit your request to resize a cluster, Amazon Redshift sets access permissions
        /// for the cluster to read-only. After Amazon Redshift provisions a new cluster according
        /// to your resize requirements, there will be a temporary outage while the old cluster
        /// is deleted and your connection is switched to the new cluster. When the new connection
        /// is complete, the original access permissions for the cluster are restored. You can
        /// use <a>DescribeResize</a> to track the progress of the resize request. 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code> ds1.xlarge</code> | <code>ds1.8xlarge</code> | <code> ds2.xlarge</code>
        /// | <code>ds2.8xlarge</code> | <code>dc1.large</code> | <code>dc1.8xlarge</code>.
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The new number of nodes of the cluster. If you specify a new number of nodes, you
        /// must also specify the node type parameter.
        /// </para>
        ///  
        /// <para>
        /// When you submit your request to resize a cluster, Amazon Redshift sets access permissions
        /// for the cluster to read-only. After Amazon Redshift provisions a new cluster according
        /// to your resize requirements, there will be a temporary outage while the old cluster
        /// is deleted and your connection is switched to the new cluster. When the new connection
        /// is complete, the original access permissions for the cluster are restored. You can
        /// use <a>DescribeResize</a> to track the progress of the resize request. 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: Integer greater than <code>0</code>.
        /// </para>
        /// </summary>
        public int NumberOfNodes
        {
            get { return this._numberOfNodes.GetValueOrDefault(); }
            set { this._numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range (in UTC) during which system maintenance can occur, if necessary.
        /// If system maintenance is necessary during the window, it may result in an outage.
        /// </para>
        ///  
        /// <para>
        /// This maintenance window change is made immediately. If the new maintenance window
        /// indicates the current time, there must be at least 120 minutes between the current
        /// time and end of the window in order to ensure that pending changes are applied.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        ///  
        /// <para>
        /// Format: ddd:hh24:mi-ddd:hh24:mi, for example <code>wed:07:30-wed:08:00</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be at least 30 minutes.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// If <code>true</code>, the cluster can be accessed from a public network. Only clusters
        /// in VPCs can be set to be publicly available.
        /// </para>
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of virtual private cloud (VPC) security groups to be associated with the cluster.
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

    }
}