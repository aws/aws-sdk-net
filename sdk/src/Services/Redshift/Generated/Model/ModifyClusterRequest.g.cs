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
    /// Container for the parameters to the ModifyCluster operation. Modifies the settings
    /// for a cluster. <para> You can also change node type and the number of nodes to scale
    /// up or down the cluster. When resizing a cluster, you must specify both the number
    /// of nodes and the node type even if one of the parameters does not change. </para>
    /// <para> You can add another security or parameter group, or change the admin user password.
    /// Resetting a cluster password or modifying the security groups associated with a cluster
    /// do not need a reboot. However, modifying a parameter group requires a reboot for parameters
    /// to take effect. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
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
    public partial class ModifyClusterRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        /// If <c>true</c>, major version upgrades will be applied automatically to the cluster
        /// during the maintenance window. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? AllowVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AllowVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAllowVersionUpgrade() => this.AllowVersionUpgrade.HasValue;

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
        /// You can't disable automated snapshots for RG or RA3 node types. Set the automated
        /// retention period from 1-35 days.
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
        public int? AutomatedSnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedSnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetAutomatedSnapshotRetentionPeriod() => this.AutomatedSnapshotRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The option to initiate relocation for an Amazon Redshift cluster to the target Availability
        /// Zone.
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
        /// Zones after the cluster modification is complete.
        /// </para>
        /// </summary>
        public bool? AvailabilityZoneRelocation { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneRelocation property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneRelocation() => this.AvailabilityZoneRelocation.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster to be modified.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>examplecluster</c> 
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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterParameterGroupName property is set.
        /// </summary>
        internal bool IsSetClusterParameterGroupName() => this.ClusterParameterGroupName != null;

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
        /// Valid Values: <c> multi-node | single-node </c> 
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
        /// The new version number of the Amazon Redshift engine to upgrade to.
        /// </para>
        ///  
        /// <para>
        /// For major version upgrades, if a non-default cluster parameter group is currently
        /// in use, a new cluster parameter group in the cluster parameter group family for the
        /// new version must be specified. The new cluster parameter group can be the default
        /// for that cluster parameter group family. For more information about parameters and
        /// parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
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
        /// Gets and sets the property ElasticIp. 
        /// <para>
        /// The Elastic IP (EIP) address for the cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The cluster must be provisioned in EC2-VPC and publicly-accessible through
        /// an Internet gateway. For more information about provisioning clusters in EC2-VPC,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#cluster-platforms">Supported
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
        /// Indicates whether the cluster is encrypted. If the value is encrypted (true) and you
        /// provide a value for the <c>KmsKeyId</c> parameter, we encrypt the cluster with the
        /// provided <c>KmsKeyId</c>. If you don't provide a <c>KmsKeyId</c>, we encrypt with
        /// the default key. 
        /// </para>
        ///  
        /// <para>
        /// If the value is not encrypted (false), then the cluster is decrypted. 
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
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name for the maintenance track that you want to assign for the cluster. This name
        /// change is asynchronous. The new track name stays in the <c>PendingModifiedValues</c>
        /// for the cluster until the next maintenance window. When the maintenance track changes,
        /// the cluster is switched to the latest cluster release available for the maintenance
        /// track. At this point, the maintenance track name is applied.
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
        /// The default for number of days that a newly created manual snapshot is retained. If
        /// the value is -1, the manual snapshot is retained indefinitely. This value doesn't
        /// retroactively change the retention periods of existing manual snapshots.
        /// </para>
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        ///  
        /// <para>
        /// The default value is -1.
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
        /// The new password for the cluster admin user. This change is asynchronously applied
        /// as soon as possible. Between the time of the request and the completion of the request,
        /// the <c>MasterUserPassword</c> element exists in the <c>PendingModifiedValues</c> element
        /// of the operation response. 
        /// </para>
        ///  
        /// <para>
        /// You can't use <c>MasterUserPassword</c> if <c>ManageMasterPassword</c> is <c>true</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Operations never return the password, so this operation provides a way to regain access
        /// to the admin user account for a cluster if the password is lost.
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
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// If true and the cluster is currently only deployed in a single Availability Zone,
        /// the cluster will be modified to be deployed in two Availability Zones.
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

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
        /// Must be unique for all clusters within an Amazon Web Services account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>examplecluster</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string NewClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the NewClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetNewClusterIdentifier() => this.NewClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The new node type of the cluster. If you specify a new node type, you must also specify
        /// the number of nodes parameter.
        /// </para>
        ///  
        /// <para>
        ///  For more information about resizing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/rs-resize-tutorial.html">Resizing
        /// Clusters in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>dc2.large</c> | <c>dc2.8xlarge</c> | <c>rg.large</c> | <c>rg.xlarge</c>
        /// | <c>rg.4xlarge</c> | <c>rg.12xlarge</c> | <c>ra3.large</c> | <c>ra3.xlplus</c> |
        /// <c>ra3.4xlarge</c> | <c>ra3.16xlarge</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The new number of nodes of the cluster. If you specify a new number of nodes, you
        /// must also specify the node type parameter.
        /// </para>
        ///  
        /// <para>
        ///  For more information about resizing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/rs-resize-tutorial.html">Resizing
        /// Clusters in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: Integer greater than <c>0</c>.
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
        /// The option to change the port of an Amazon Redshift cluster.
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
        /// Format: ddd:hh24:mi-ddd:hh24:mi, for example <c>wed:07:30-wed:08:00</c>.
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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// If <c>true</c>, the cluster can be accessed from a public network. Only clusters in
        /// VPCs can be set to be publicly available.
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of virtual private cloud (VPC) security groups to be associated with the cluster.
        /// This change is asynchronously applied as soon as possible.
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
