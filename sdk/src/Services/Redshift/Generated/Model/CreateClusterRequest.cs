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
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a new cluster with the specified parameters.
    /// 
    ///  
    /// <para>
    /// To create a cluster in Virtual Private Cloud (VPC), you must provide a cluster subnet
    /// group name. The cluster subnet group identifies the subnets of your VPC that Amazon
    /// Redshift uses when creating the cluster. For more information about managing clusters,
    /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateClusterRequest : AmazonRedshiftRequest
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
        private string _clusterType;
        private string _clusterVersion;
        private string _dbName;
        private string _defaultIamRoleArn;
        private string _elasticIp;
        private bool? _encrypted;
        private bool? _enhancedVpcRouting;
        private string _hsmClientCertificateIdentifier;
        private string _hsmConfigurationIdentifier;
        private List<string> _iamRoles = new List<string>();
        private string _kmsKeyId;
        private string _loadSampleData;
        private string _maintenanceTrackName;
        private int? _manualSnapshotRetentionPeriod;
        private string _masterUsername;
        private string _masterUserPassword;
        private string _nodeType;
        private int? _numberOfNodes;
        private int? _port;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _snapshotScheduleIdentifier;
        private List<Tag> _tags = new List<Tag>();
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
        /// When a new major version of the Amazon Redshift engine is released, you can request
        /// that the service automatically apply upgrades during the maintenance window to the
        /// Amazon Redshift engine that is running on your cluster.
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
        /// Default: <code>1</code> 
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
        /// The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the
        /// cluster. For example, if you have several EC2 instances running in a specific Availability
        /// Zone, then you might want the cluster to be provisioned in the same zone in order
        /// to decrease network latency.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the region that is specified
        /// by the endpoint.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>us-east-2d</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraint: The specified Availability Zone must be in the same region as the current
        /// endpoint.
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
        /// Zones after the cluster is created.
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
        /// A unique identifier for the cluster. You use this identifier to refer to the cluster
        /// for any subsequent cluster operations such as deleting or modifying. The identifier
        /// also appears in the Amazon Redshift console.
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
        /// <para>
        /// Example: <code>myexamplecluster</code> 
        /// </para>
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
        /// with Amazon Redshift Parameter Groups</a> 
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
        /// The name of a cluster subnet group to be associated with this cluster.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is not provided the resulting cluster will be deployed outside virtual
        /// private cloud (VPC).
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
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The type of the cluster. When cluster type is specified as
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>single-node</code>, the <b>NumberOfNodes</b> parameter is not required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>multi-node</code>, the <b>NumberOfNodes</b> parameter is required.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid Values: <code>multi-node</code> | <code>single-node</code> 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>multi-node</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The version of the Amazon Redshift engine software that you want to deploy on the
        /// cluster.
        /// </para>
        ///  
        /// <para>
        /// The version selected runs on all the nodes in the cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Only version 1.0 is currently available.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>1.0</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property DBName. 
        /// <para>
        /// The name of the first database to be created when the cluster is created.
        /// </para>
        ///  
        /// <para>
        /// To create additional databases after the cluster is created, connect to the cluster
        /// with a SQL client and use SQL commands to create a database. For more information,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/dg/t_creating_database.html">Create
        /// a Database</a> in the Amazon Redshift Database Developer Guide. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>dev</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1 to 64 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain only lowercase letters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a word that is reserved by the service. A list of reserved words can be
        /// found in <a href="https://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved
        /// Words</a> in the Amazon Redshift Database Developer Guide. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DBName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role that was set as default for the cluster
        /// when the cluster was created. 
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
        /// The Elastic IP (EIP) address for the cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The cluster must be provisioned in EC2-VPC and publicly-accessible through
        /// an Internet gateway. Don't specify the Elastic IP address for a publicly accessible
        /// cluster with availability zone relocation turned on. For more information about provisioning
        /// clusters in EC2-VPC, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#cluster-platforms">Supported
        /// Platforms to Launch Your Cluster</a> in the Amazon Redshift Cluster Management Guide.
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
        /// If <code>true</code>, the data in the cluster is encrypted at rest. 
        /// </para>
        ///  
        /// <para>
        /// Default: false
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
        /// The Key Management Service (KMS) key ID of the encryption key that you want to use
        /// to encrypt data in the cluster.
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
        /// Gets and sets the property LoadSampleData. 
        /// <para>
        /// A flag that specifies whether to load sample data once the cluster is created.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string LoadSampleData
        {
            get { return this._loadSampleData; }
            set { this._loadSampleData = value; }
        }

        // Check to see if LoadSampleData property is set
        internal bool IsSetLoadSampleData()
        {
            return this._loadSampleData != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// An optional parameter for the name of the maintenance track for the cluster. If you
        /// don't provide a maintenance track name, the cluster is assigned to the <code>current</code>
        /// track.
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
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The user name associated with the admin user for the cluster that is being created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 - 128 alphanumeric characters or hyphens. The user name can't be <code>PUBLIC</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain only lowercase letters, numbers, underscore, plus sign, period (dot),
        /// at symbol (@), or hyphen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not contain a colon (:) or a slash (/).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a reserved word. A list of reserved words can be found in <a href="https://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved
        /// Words</a> in the Amazon Redshift Database Developer Guide. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The password associated with the admin user for the cluster that is being created.
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
        /// Can be any printable ASCII character (ASCII code 33-126) except <code>'</code> (single
        /// quote), <code>"</code> (double quote), <code>\</code>, <code>/</code>, or <code>@</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type to be provisioned for the cluster. For information about node types,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#how-many-nodes">
        /// Working with Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>ds2.xlarge</code> | <code>ds2.8xlarge</code> | <code>dc1.large</code>
        /// | <code>dc1.8xlarge</code> | <code>dc2.large</code> | <code>dc2.8xlarge</code> | <code>ra3.xlplus</code>
        /// | <code>ra3.4xlarge</code> | <code>ra3.16xlarge</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// The number of compute nodes in the cluster. This parameter is required when the <b>ClusterType</b>
        /// parameter is specified as <code>multi-node</code>. 
        /// </para>
        ///  
        /// <para>
        /// For information about determining how many nodes you need, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#how-many-nodes">
        /// Working with Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, you get a single-node cluster. When requesting
        /// a multi-node cluster, you must specify the number of nodes that you want in the cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>1</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value must be at least 1 and no more than 100.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the cluster accepts incoming connections.
        /// </para>
        ///  
        /// <para>
        /// The cluster is accessible only via the JDBC and ODBC connection strings. Part of the
        /// connection string requires the port on which the cluster will listen for incoming
        /// connections.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>5439</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>1150-65535</code> 
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
        ///  Default: A 30-minute window selected at random from an 8-hour block of time per region,
        /// occurring on a random day of the week. For more information about the time blocks
        /// for each region, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#rs-maintenance-windows">Maintenance
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag instances.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
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