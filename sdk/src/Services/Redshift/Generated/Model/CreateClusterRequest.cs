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

#pragma warning disable CS0612,CS0618,CS1570
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
    ///  
    /// <para>
    /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
    /// you own in a Region from reaching or being reached from the internet through internet
    /// gateways and egress-only internet gateways. If a subnet group for a provisioned cluster
    /// is in an account with VPC BPA turned on, the following capabilities are blocked:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creating a public cluster
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Restoring a public cluster
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Modifying a private cluster to be public
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Adding a subnet with VPC BPA turned on to the subnet group when there's at least one
    /// public cluster within the group
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
    /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
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
        private List<string> _clusterSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        private List<string> _iamRoles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ipAddressType;
        private string _kmsKeyId;
        private string _loadSampleData;
        private string _maintenanceTrackName;
        private bool? _manageMasterPassword;
        private int? _manualSnapshotRetentionPeriod;
        private string _masterPasswordSecretKmsKeyId;
        private string _masterUsername;
        private string _masterUserPassword;
        private bool? _multiAZ;
        private string _nodeType;
        private int? _numberOfNodes;
        private int? _port;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _redshiftIdcApplicationArn;
        private string _snapshotScheduleIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// If <c>true</c>, major version upgrades can be applied during the maintenance window
        /// to the Amazon Redshift engine that is running on the cluster.
        /// </para>
        ///  
        /// <para>
        /// When a new major version of the Amazon Redshift engine is released, you can request
        /// that the service automatically apply upgrades during the maintenance window to the
        /// Amazon Redshift engine that is running on your cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? AllowVersionUpgrade
        {
            get { return this._allowVersionUpgrade; }
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
        /// Default: <c>1</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be a value from 0 to 35.
        /// </para>
        /// </summary>
        public int? AutomatedSnapshotRetentionPeriod
        {
            get { return this._automatedSnapshotRetentionPeriod; }
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
        /// Example: <c>us-east-2d</c> 
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
        public bool? AvailabilityZoneRelocation
        {
            get { return this._availabilityZoneRelocation; }
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
        /// Example: <c>myexamplecluster</c> 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClusterSecurityGroups
        {
            get { return this._clusterSecurityGroups; }
            set { this._clusterSecurityGroups = value; }
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this._clusterSecurityGroups != null && (this._clusterSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  <c>single-node</c>, the <b>NumberOfNodes</b> parameter is not required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>multi-node</c>, the <b>NumberOfNodes</b> parameter is required.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid Values: <c>multi-node</c> | <c>single-node</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>multi-node</c> 
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
        /// Example: <c>1.0</c> 
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
        /// Default: <c>dev</c> 
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
        /// If <c>true</c>, the data in the cluster is encrypted at rest. If you set the value
        /// on this parameter to <c>false</c>, the request will fail.
        /// </para>
        ///  
        /// <para>
        /// Default: true
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
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
        /// If this option is <c>true</c>, enhanced VPC routing is enabled. 
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? EnhancedVpcRouting
        {
            get { return this._enhancedVpcRouting; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IamRoles
        {
            get { return this._iamRoles; }
            set { this._iamRoles = value; }
        }

        // Check to see if IamRoles property is set
        internal bool IsSetIamRoles()
        {
            return this._iamRoles != null && (this._iamRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address types that the cluster supports. Possible values are <c>ipv4</c> and
        /// <c>dualstack</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
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
        /// don't provide a maintenance track name, the cluster is assigned to the <c>current</c>
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
        /// Gets and sets the property ManageMasterPassword. 
        /// <para>
        /// If <c>true</c>, Amazon Redshift uses Secrets Manager to manage this cluster's admin
        /// credentials. You can't use <c>MasterUserPassword</c> if <c>ManageMasterPassword</c>
        /// is true. If <c>ManageMasterPassword</c> is false or not set, Amazon Redshift uses
        /// <c>MasterUserPassword</c> for the admin user account's password. 
        /// </para>
        /// </summary>
        public bool? ManageMasterPassword
        {
            get { return this._manageMasterPassword; }
            set { this._manageMasterPassword = value; }
        }

        // Check to see if ManageMasterPassword property is set
        internal bool IsSetManageMasterPassword()
        {
            return this._manageMasterPassword.HasValue; 
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
        public int? ManualSnapshotRetentionPeriod
        {
            get { return this._manualSnapshotRetentionPeriod; }
            set { this._manualSnapshotRetentionPeriod = value; }
        }

        // Check to see if ManualSnapshotRetentionPeriod property is set
        internal bool IsSetManualSnapshotRetentionPeriod()
        {
            return this._manualSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the cluster's
        /// admin credentials secret. You can only use this parameter if <c>ManageMasterPassword</c>
        /// is true.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MasterPasswordSecretKmsKeyId
        {
            get { return this._masterPasswordSecretKmsKeyId; }
            set { this._masterPasswordSecretKmsKeyId = value; }
        }

        // Check to see if MasterPasswordSecretKmsKeyId property is set
        internal bool IsSetMasterPasswordSecretKmsKeyId()
        {
            return this._masterPasswordSecretKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The user name associated with the admin user account for the cluster that is being
        /// created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 - 128 alphanumeric characters or hyphens. The user name can't be <c>PUBLIC</c>.
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
        /// The password associated with the admin user account for the cluster that is being
        /// created.
        /// </para>
        ///  
        /// <para>
        /// You can't use <c>MasterUserPassword</c> if <c>ManageMasterPassword</c> is <c>true</c>.
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
        /// Can be any printable ASCII character (ASCII code 33-126) except <c>'</c> (single quote),
        /// <c>"</c> (double quote), <c>\</c>, <c>/</c>, or <c>@</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// If true, Amazon Redshift will deploy the cluster in two Availability Zones (AZ).
        /// </para>
        /// </summary>
        public bool? MultiAZ
        {
            get { return this._multiAZ; }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
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
        /// Valid Values: <c>dc2.large</c> | <c>dc2.8xlarge</c> | <c>ra3.large</c> | <c>ra3.xlplus</c>
        /// | <c>ra3.4xlarge</c> | <c>ra3.16xlarge</c> 
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
        /// parameter is specified as <c>multi-node</c>. 
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
        /// Default: <c>1</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value must be at least 1 and no more than 100.
        /// </para>
        /// </summary>
        public int? NumberOfNodes
        {
            get { return this._numberOfNodes; }
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
        /// Default: <c>5439</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For clusters with ra3 nodes - Select a port within the ranges <c>5431-5455</c> or
        /// <c>8191-8215</c>. (If you have an existing cluster with ra3 nodes, it isn't required
        /// that you change the port to these ranges.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For clusters with dc2 nodes - Select a port within the range <c>1150-65535</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
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
        ///  Format: <c>ddd:hh24:mi-ddd:hh24:mi</c> 
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
        /// If <c>true</c>, the cluster can be accessed from a public network. 
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedshiftIdcApplicationArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the Amazon Redshift IAM Identity Center application.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string RedshiftIdcApplicationArn
        {
            get { return this._redshiftIdcApplicationArn; }
            set { this._redshiftIdcApplicationArn = value; }
        }

        // Check to see if RedshiftIdcApplicationArn property is set
        internal bool IsSetRedshiftIdcApplicationArn()
        {
            return this._redshiftIdcApplicationArn != null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}