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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreFromClusterSnapshot operation.
    /// Creates a new cluster from a snapshot. By default, Amazon Redshift creates the resulting
    /// cluster with the same configuration as the original cluster from which the snapshot
    /// was created, except that the new cluster is created with the default cluster security
    /// and parameter groups. After Amazon Redshift creates the cluster, you can use the <a>ModifyCluster</a>
    /// API to associate a different security group and different parameter group with the
    /// restored cluster. If you are using a DS node type, you can also choose to change to
    /// another DS node type of the same size during restore.
    /// 
    ///  
    /// <para>
    /// If you restore a cluster into a VPC, you must provide a cluster subnet group where
    /// you want the cluster restored.
    /// </para>
    ///  
    /// <para>
    ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
    /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class RestoreFromClusterSnapshotRequest : AmazonRedshiftRequest
    {
        private string _additionalInfo;
        private bool? _allowVersionUpgrade;
        private AquaConfigurationStatus _aquaConfigurationStatus;
        private int? _automatedSnapshotRetentionPeriod;
        private string _availabilityZone;
        private bool? _availabilityZoneRelocation;
        private string _clusterIdentifier;
        private string _clusterParameterGroupName;
        private List<string> _clusterSecurityGroups = new List<string>();
        private string _clusterSubnetGroupName;
        private string _defaultIamRoleArn;
        private string _elasticIp;
        private bool? _encrypted;
        private bool? _enhancedVpcRouting;
        private string _hsmClientCertificateIdentifier;
        private string _hsmConfigurationIdentifier;
        private List<string> _iamRoles = new List<string>();
        private string _kmsKeyId;
        private string _maintenanceTrackName;
        private int? _manualSnapshotRetentionPeriod;
        private string _nodeType;
        private int? _numberOfNodes;
        private string _ownerAccount;
        private int? _port;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _reservedNodeId;
        private string _snapshotArn;
        private string _snapshotClusterIdentifier;
        private string _snapshotIdentifier;
        private string _snapshotScheduleIdentifier;
        private string _targetReservedNodeOfferingId;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        /// If <code>true</code>, major version upgrades can be applied during the maintenance
        /// window to the Amazon Redshift engine that is running on the cluster. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code> 
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
        /// Gets and sets the property AquaConfigurationStatus. 
        /// <para>
        /// This parameter is retired. It does not set the AQUA configuration status. Amazon Redshift
        /// automatically determines whether to use AQUA (Advanced Query Accelerator).
        /// </para>
        /// </summary>
        public AquaConfigurationStatus AquaConfigurationStatus
        {
            get { return this._aquaConfigurationStatus; }
            set { this._aquaConfigurationStatus = value; }
        }

        // Check to see if AquaConfigurationStatus property is set
        internal bool IsSetAquaConfigurationStatus()
        {
            return this._aquaConfigurationStatus != null;
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
        /// You can't disable automated snapshots for RA3 node types. Set the automated retention
        /// period from 1-35 days.
        /// </para>
        ///  
        /// <para>
        /// Default: The value selected for the cluster from which the snapshot was taken.
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
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon EC2 Availability Zone in which to restore the cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>us-east-2a</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneRelocation. 
        /// <para>
        /// The option to enable relocation for an Amazon Redshift cluster between Availability
        /// Zones after the cluster is restored.
        /// </para>
        /// </summary>
        public bool AvailabilityZoneRelocation
        {
            get { return this._availabilityZoneRelocation.GetValueOrDefault(); }
            set { this._availabilityZoneRelocation = value; }
        }

        // Check to see if AvailabilityZoneRelocation property is set
        internal bool IsSetAvailabilityZoneRelocation()
        {
            return this._availabilityZoneRelocation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster that will be created from restoring the snapshot.
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
        /// Must be unique for all clusters within an Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// The name of the parameter group to be associated with this cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: The default Amazon Redshift cluster parameter group. For information about
        /// the default parameter group, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Working
        /// with Amazon Redshift Parameter Groups</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// A list of security groups to be associated with this cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: The default cluster security group for Amazon Redshift.
        /// </para>
        ///  
        /// <para>
        /// Cluster security groups only apply to clusters outside of VPCs.
        /// </para>
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
        /// Gets and sets the property ClusterSubnetGroupName. 
        /// <para>
        /// The name of the subnet group where you want to cluster restored.
        /// </para>
        ///  
        /// <para>
        /// A snapshot of cluster in VPC can be restored only in VPC. Therefore, you must provide
        /// subnet group name where you want the cluster restored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterSubnetGroupName
        {
            get { return this._clusterSubnetGroupName; }
            set { this._clusterSubnetGroupName = value; }
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this._clusterSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role that was set as default for the cluster
        /// when the cluster was last modified while it was restored from a snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DefaultIamRoleArn
        {
            get { return this._defaultIamRoleArn; }
            set { this._defaultIamRoleArn = value; }
        }

        // Check to see if DefaultIamRoleArn property is set
        internal bool IsSetDefaultIamRoleArn()
        {
            return this._defaultIamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticIp. 
        /// <para>
        /// The Elastic IP (EIP) address for the cluster. Don't specify the Elastic IP address
        /// for a publicly accessible cluster with availability zone relocation turned on.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Enables support for restoring an unencrypted snapshot to a cluster encrypted with
        /// Key Management Service (KMS) and a customer managed key.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// An option that specifies whether to create the cluster with enhanced VPC routing enabled.
        /// To create a cluster that uses enhanced VPC routing, the cluster must be in a VPC.
        /// For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/enhanced-vpc-routing.html">Enhanced
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
        [AWSProperty(Max=2147483647)]
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
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// A list of Identity and Access Management (IAM) roles that can be used by the cluster
        /// to access other Amazon Web Services services. You must supply the IAM roles in their
        /// Amazon Resource Name (ARN) format. 
        /// </para>
        ///  
        /// <para>
        /// The maximum number of IAM roles that you can associate is subject to a quota. For
        /// more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Quotas
        /// and limits</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        public List<string> IamRoles
        {
            get { return this._iamRoles; }
            set { this._iamRoles = value; }
        }

        // Check to see if IamRoles property is set
        internal bool IsSetIamRoles()
        {
            return this._iamRoles != null && this._iamRoles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Key Management Service (KMS) key ID of the encryption key that encrypts data in
        /// the cluster restored from a shared snapshot. You can also provide the key ID when
        /// you restore from an unencrypted snapshot to an encrypted cluster in the same account.
        /// Additionally, you can specify a new KMS key ID when you restore from an encrypted
        /// snapshot in the same account in order to change it. In that case, the restored cluster
        /// is encrypted with the new KMS key ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the maintenance track for the restored cluster. When you take a snapshot,
        /// the snapshot inherits the <code>MaintenanceTrack</code> value from the cluster. The
        /// snapshot might be on a different track than the cluster that was the source for the
        /// snapshot. For example, suppose that you take a snapshot of a cluster that is on the
        /// current track and then change the cluster to be on the trailing track. In this case,
        /// the snapshot and the source cluster are on different tracks.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MaintenanceTrackName
        {
            get { return this._maintenanceTrackName; }
            set { this._maintenanceTrackName = value; }
        }

        // Check to see if MaintenanceTrackName property is set
        internal bool IsSetMaintenanceTrackName()
        {
            return this._maintenanceTrackName != null;
        }

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The default number of days to retain a manual snapshot. If the value is -1, the snapshot
        /// is retained indefinitely. This setting doesn't change the retention period of existing
        /// snapshots.
        /// </para>
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </summary>
        public int ManualSnapshotRetentionPeriod
        {
            get { return this._manualSnapshotRetentionPeriod.GetValueOrDefault(); }
            set { this._manualSnapshotRetentionPeriod = value; }
        }

        // Check to see if ManualSnapshotRetentionPeriod property is set
        internal bool IsSetManualSnapshotRetentionPeriod()
        {
            return this._manualSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type that the restored cluster will be provisioned with.
        /// </para>
        ///  
        /// <para>
        /// Default: The node type of the cluster from which the snapshot was taken. You can modify
        /// this if you are using any DS node type. In that case, you can choose to restore into
        /// another DS node type of the same size. For example, you can restore ds1.8xlarge into
        /// ds2.8xlarge, or ds1.xlarge into ds2.xlarge. If you have a DC instance type, you must
        /// restore into that same instance type and size. In other words, you can only restore
        /// a dc1.large instance type into another dc1.large instance type or dc2.large instance
        /// type. You can't restore dc1.8xlarge to dc2.8xlarge. First restore to a dc1.8xlarge
        /// cluster, then resize to a dc2.8large cluster. For more information about node types,
        /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#rs-about-clusters-and-nodes">
        /// About Clusters and Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The number of nodes specified when provisioning the restored cluster.
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
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The Amazon Web Services account used to create or copy the snapshot. Required if you
        /// are restoring a snapshot you do not own, optional if you own the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Default: The same port as the original cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be between <code>1115</code> and <code>65535</code>.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range (in UTC) during which automated cluster maintenance can occur.
        /// </para>
        ///  
        /// <para>
        ///  Format: <code>ddd:hh24:mi-ddd:hh24:mi</code> 
        /// </para>
        ///  
        /// <para>
        ///  Default: The value selected for the cluster from which the snapshot was taken. For
        /// more information about the time blocks for each region, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#rs-maintenance-windows">Maintenance
        /// Windows</a> in Amazon Redshift Cluster Management Guide. 
        /// </para>
        ///  
        /// <para>
        /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 30-minute window.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// If <code>true</code>, the cluster can be accessed from a public network. 
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
        /// Gets and sets the property ReservedNodeId. 
        /// <para>
        /// The identifier of the target reserved node offering.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ReservedNodeId
        {
            get { return this._reservedNodeId; }
            set { this._reservedNodeId = value; }
        }

        // Check to see if ReservedNodeId property is set
        internal bool IsSetReservedNodeId()
        {
            return this._reservedNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot associated with the message to restore
        /// from a cluster. You must specify this parameter or <code>snapshotIdentifier</code>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotClusterIdentifier. 
        /// <para>
        /// The name of the cluster the source snapshot was created from. This parameter is required
        /// if your IAM user has a policy containing a snapshot resource element that specifies
        /// anything other than * for the cluster name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotClusterIdentifier
        {
            get { return this._snapshotClusterIdentifier; }
            set { this._snapshotClusterIdentifier = value; }
        }

        // Check to see if SnapshotClusterIdentifier property is set
        internal bool IsSetSnapshotClusterIdentifier()
        {
            return this._snapshotClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The name of the snapshot from which to create the new cluster. This parameter isn't
        /// case sensitive. You must specify this parameter or <code>snapshotArn</code>, but not
        /// both.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>my-snapshot-id</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotScheduleIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotScheduleIdentifier
        {
            get { return this._snapshotScheduleIdentifier; }
            set { this._snapshotScheduleIdentifier = value; }
        }

        // Check to see if SnapshotScheduleIdentifier property is set
        internal bool IsSetSnapshotScheduleIdentifier()
        {
            return this._snapshotScheduleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TargetReservedNodeOfferingId. 
        /// <para>
        /// The identifier of the target reserved node offering.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string TargetReservedNodeOfferingId
        {
            get { return this._targetReservedNodeOfferingId; }
            set { this._targetReservedNodeOfferingId = value; }
        }

        // Check to see if TargetReservedNodeOfferingId property is set
        internal bool IsSetTargetReservedNodeOfferingId()
        {
            return this._targetReservedNodeOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: The default VPC security group is associated with the cluster.
        /// </para>
        ///  
        /// <para>
        /// VPC security groups only apply to clusters in VPCs.
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