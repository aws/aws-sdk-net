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
    /// Container for the parameters to the CreateCluster operation. Creates a new cluster
    /// with the specified parameters. <para> To create a cluster in Virtual Private Cloud
    /// (VPC), you must provide a cluster subnet group name. The cluster subnet group identifies
    /// the subnets of your VPC that Amazon Redshift uses when creating the cluster. For more
    /// information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>. </para>
    /// <para> VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets
    /// that you own in a Region from reaching or being reached from the internet through
    /// internet gateways and egress-only internet gateways. If a subnet group for a provisioned
    /// cluster is in an account with VPC BPA turned on, the following capabilities are blocked:
    /// </para> <ul> <li> <para> Creating a public cluster </para> </li> <li> <para> Restoring
    /// a public cluster </para> </li> <li> <para> Modifying a private cluster to be public
    /// </para> </li> <li> <para> Adding a subnet with VPC BPA turned on to the subnet group
    /// when there's at least one public cluster within the group </para> </li> </ul> <para>
    /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
    /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>. </para>
    /// </summary>
    public partial class CreateClusterRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInfo property is set.
        /// </summary>
        internal bool IsSetAdditionalInfo() => this.AdditionalInfo != null;

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
        public bool? AllowVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AllowVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAllowVersionUpgrade() => this.AllowVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property AquaConfigurationStatus. 
        /// <para>
        /// This parameter is retired. It does not set the AQUA configuration status. Amazon Redshift
        /// automatically determines whether to use AQUA (Advanced Query Accelerator).
        /// </para>
        /// </summary>
        public AquaConfigurationStatus AquaConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AquaConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetAquaConfigurationStatus() => this.AquaConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that automated snapshots are retained. If the value is 0, automated
        /// snapshots are disabled. Even if automated snapshots are disabled, you can still create
        /// manual snapshots when you want with <a>CreateClusterSnapshot</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can't disable automated snapshots for RG or RA3 node types. Set the automated
        /// retention period from 1-35 days.
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
        public int? AutomatedSnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedSnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetAutomatedSnapshotRetentionPeriod() => this.AutomatedSnapshotRetentionPeriod.HasValue;

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneRelocation. 
        /// <para>
        /// The option to enable relocation for an Amazon Redshift cluster between Availability
        /// Zones after the cluster is created.
        /// </para>
        /// </summary>
        public bool? AvailabilityZoneRelocation { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneRelocation property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneRelocation() => this.AvailabilityZoneRelocation.HasValue;

        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The name of the Glue data catalog that will be associated with the cluster enabled
        /// with Amazon Redshift federated permissions.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain at least one lowercase letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can only contain lowercase letters (a-z), numbers (0-9), underscores (_), and hyphens
        /// (-).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Pattern: <c>^[a-z0-9_-]*[a-z]+[a-z0-9_-]*$</c> 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>my-catalog_01</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CatalogName { get; set; }

        /// <summary>
        /// Checks to see if the CatalogName property is set.
        /// </summary>
        internal bool IsSetCatalogName() => this.CatalogName != null;

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
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterParameterGroupName property is set.
        /// </summary>
        internal bool IsSetClusterParameterGroupName() => this.ClusterParameterGroupName != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClusterSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClusterSecurityGroups property is set.
        /// </summary>
        internal bool IsSetClusterSecurityGroups() => this.ClusterSecurityGroups != null && (this.ClusterSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetClusterSubnetGroupName() => this.ClusterSubnetGroupName != null;

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterType property is set.
        /// </summary>
        internal bool IsSetClusterType() => this.ClusterType != null;

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClusterVersion property is set.
        /// </summary>
        internal bool IsSetClusterVersion() => this.ClusterVersion != null;

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DBName { get; set; }

        /// <summary>
        /// Checks to see if the DBName property is set.
        /// </summary>
        internal bool IsSetDBName() => this.DBName != null;

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role that was set as default for the cluster
        /// when the cluster was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DefaultIamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DefaultIamRoleArn property is set.
        /// </summary>
        internal bool IsSetDefaultIamRoleArn() => this.DefaultIamRoleArn != null;

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ElasticIp { get; set; }

        /// <summary>
        /// Checks to see if the ElasticIp property is set.
        /// </summary>
        internal bool IsSetElasticIp() => this.ElasticIp != null;

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
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

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
        public bool? EnhancedVpcRouting { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedVpcRouting property is set.
        /// </summary>
        internal bool IsSetEnhancedVpcRouting() => this.EnhancedVpcRouting.HasValue;

        /// <summary>
        /// Gets and sets the property ExtraComputeForAutomaticOptimization. 
        /// <para>
        /// If <c>true</c>, allocates additional compute resources for running automatic optimization
        /// operations.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? ExtraComputeForAutomaticOptimization { get; set; }

        /// <summary>
        /// Checks to see if the ExtraComputeForAutomaticOptimization property is set.
        /// </summary>
        internal bool IsSetExtraComputeForAutomaticOptimization() => this.ExtraComputeForAutomaticOptimization.HasValue;

        /// <summary>
        /// Gets and sets the property HsmClientCertificateIdentifier. 
        /// <para>
        /// Specifies the name of the HSM client certificate the Amazon Redshift cluster uses
        /// to retrieve the data encryption keys stored in an HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string HsmClientCertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the HsmClientCertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetHsmClientCertificateIdentifier() => this.HsmClientCertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// Specifies the name of the HSM configuration that contains the information the Amazon
        /// Redshift cluster can use to retrieve and store keys in an HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string HsmConfigurationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the HsmConfigurationIdentifier property is set.
        /// </summary>
        internal bool IsSetHsmConfigurationIdentifier() => this.HsmConfigurationIdentifier != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IamRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IamRoles property is set.
        /// </summary>
        internal bool IsSetIamRoles() => this.IamRoles != null && (this.IamRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address types that the cluster supports. Possible values are <c>ipv4</c> and
        /// <c>dualstack</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Key Management Service (KMS) key ID of the encryption key that you want to use
        /// to encrypt data in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LoadSampleData. 
        /// <para>
        /// A flag that specifies whether to load sample data once the cluster is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string LoadSampleData { get; set; }

        /// <summary>
        /// Checks to see if the LoadSampleData property is set.
        /// </summary>
        internal bool IsSetLoadSampleData() => this.LoadSampleData != null;

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// An optional parameter for the name of the maintenance track for the cluster. If you
        /// don't provide a maintenance track name, the cluster is assigned to the <c>current</c>
        /// track.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MaintenanceTrackName { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceTrackName property is set.
        /// </summary>
        internal bool IsSetMaintenanceTrackName() => this.MaintenanceTrackName != null;

        /// <summary>
        /// Gets and sets the property ManageMasterPassword. 
        /// <para>
        /// If <c>true</c>, Amazon Redshift uses Secrets Manager to manage this cluster's admin
        /// credentials. You can't use <c>MasterUserPassword</c> if <c>ManageMasterPassword</c>
        /// is true. If <c>ManageMasterPassword</c> is false or not set, Amazon Redshift uses
        /// <c>MasterUserPassword</c> for the admin user account's password. 
        /// </para>
        /// </summary>
        public bool? ManageMasterPassword { get; set; }

        /// <summary>
        /// Checks to see if the ManageMasterPassword property is set.
        /// </summary>
        internal bool IsSetManageMasterPassword() => this.ManageMasterPassword.HasValue;

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
        public int? ManualSnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ManualSnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetManualSnapshotRetentionPeriod() => this.ManualSnapshotRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property MasterPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the cluster's
        /// admin credentials secret. You can only use this parameter if <c>ManageMasterPassword</c>
        /// is true.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MasterPasswordSecretKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the MasterPasswordSecretKmsKeyId property is set.
        /// </summary>
        internal bool IsSetMasterPasswordSecretKmsKeyId() => this.MasterPasswordSecretKmsKeyId != null;

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
        [AWSProperty(Sensitive = true)]
        public string MasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserPassword property is set.
        /// </summary>
        internal bool IsSetMasterUserPassword() => this.MasterUserPassword != null;

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
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// If true, Amazon Redshift will deploy the cluster in two Availability Zones (AZ).
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

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
        /// Valid Values: <c>dc2.large</c> | <c>dc2.8xlarge</c> | <c>rg.large</c> | <c>rg.xlarge</c>
        /// | <c>rg.4xlarge</c> | <c>rg.12xlarge</c> | <c>ra3.large</c> | <c>ra3.xlplus</c> |
        /// <c>ra3.4xlarge</c> | <c>ra3.16xlarge</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

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
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;

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
        /// For clusters with RG or RA3 nodes - Select a port within the ranges <c>5431-5455</c>
        /// or <c>8191-8215</c>. (If you have an existing cluster with RG or RA3 nodes, it isn't
        /// required that you change the port to these ranges.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For clusters with dc2 nodes - Select a port within the range <c>1150-65535</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

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
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property RedshiftIdcApplicationArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the Amazon Redshift IAM Identity Center application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string RedshiftIdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftIdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetRedshiftIdcApplicationArn() => this.RedshiftIdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotScheduleIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotScheduleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotScheduleIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotScheduleIdentifier() => this.SnapshotScheduleIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupIds() => this.VpcSecurityGroupIds != null && (this.VpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
