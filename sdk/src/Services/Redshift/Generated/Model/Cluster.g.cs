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
    /// Describes a cluster.
    /// </summary>
    public partial class Cluster
    {
        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        /// A boolean value that, if <c>true</c>, indicates that major version upgrades will be
        /// applied automatically to the cluster during the maintenance window. 
        /// </para>
        /// </summary>
        public bool? AllowVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AllowVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAllowVersionUpgrade() => this.AllowVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property AquaConfiguration. 
        /// <para>
        /// This field is retired. Amazon Redshift automatically determines whether to use AQUA
        /// (Advanced Query Accelerator).
        /// </para>
        /// </summary>
        public AquaConfiguration AquaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AquaConfiguration property is set.
        /// </summary>
        internal bool IsSetAquaConfiguration() => this.AquaConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that automatic cluster snapshots are retained.
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
        /// The name of the Availability Zone in which the cluster is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneRelocationStatus. 
        /// <para>
        /// Describes the status of the Availability Zone relocation operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string AvailabilityZoneRelocationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneRelocationStatus property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneRelocationStatus() => this.AvailabilityZoneRelocationStatus != null;

        /// <summary>
        /// Gets and sets the property CatalogArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Glue data catalog associated with the cluster
        /// enabled with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CatalogArn { get; set; }

        /// <summary>
        /// Checks to see if the CatalogArn property is set.
        /// </summary>
        internal bool IsSetCatalogArn() => this.CatalogArn != null;

        /// <summary>
        /// Gets and sets the property ClusterAvailabilityStatus. 
        /// <para>
        /// The availability status of the cluster for queries. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Available - The cluster is available for queries. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unavailable - The cluster is not available for queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maintenance - The cluster is intermittently available for queries due to maintenance
        /// activities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying - The cluster is intermittently available for queries due to changes that
        /// modify the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed - The cluster failed and is not available for queries.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterAvailabilityStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterAvailabilityStatus property is set.
        /// </summary>
        internal bool IsSetClusterAvailabilityStatus() => this.ClusterAvailabilityStatus != null;

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// The date and time that the cluster was created.
        /// </para>
        /// </summary>
        public DateTime? ClusterCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the ClusterCreateTime property is set.
        /// </summary>
        internal bool IsSetClusterCreateTime() => this.ClusterCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClusterNamespaceArn. 
        /// <para>
        /// The namespace Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterNamespaceArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterNamespaceArn property is set.
        /// </summary>
        internal bool IsSetClusterNamespaceArn() => this.ClusterNamespaceArn != null;

        /// <summary>
        /// Gets and sets the property ClusterNodes. 
        /// <para>
        /// The nodes in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterNode> ClusterNodes { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterNode>() : null;

        /// <summary>
        /// Checks to see if the ClusterNodes property is set.
        /// </summary>
        internal bool IsSetClusterNodes() => this.ClusterNodes != null && (this.ClusterNodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterParameterGroups. 
        /// <para>
        /// The list of cluster parameter groups that are associated with this cluster. Each parameter
        /// group in the list is returned with its status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterParameterGroupStatus> ClusterParameterGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterParameterGroupStatus>() : null;

        /// <summary>
        /// Checks to see if the ClusterParameterGroups property is set.
        /// </summary>
        internal bool IsSetClusterParameterGroups() => this.ClusterParameterGroups != null && (this.ClusterParameterGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterPublicKey. 
        /// <para>
        /// The public key for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterPublicKey { get; set; }

        /// <summary>
        /// Checks to see if the ClusterPublicKey property is set.
        /// </summary>
        internal bool IsSetClusterPublicKey() => this.ClusterPublicKey != null;

        /// <summary>
        /// Gets and sets the property ClusterRevisionNumber. 
        /// <para>
        /// The specific revision number of the database in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterRevisionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ClusterRevisionNumber property is set.
        /// </summary>
        internal bool IsSetClusterRevisionNumber() => this.ClusterRevisionNumber != null;

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroups. 
        /// <para>
        /// A list of cluster security group that are associated with the cluster. Each security
        /// group is represented by an element that contains <c>ClusterSecurityGroup.Name</c>
        /// and <c>ClusterSecurityGroup.Status</c> subelements. 
        /// </para>
        ///  
        /// <para>
        /// Cluster security groups are used when the cluster is not created in an Amazon Virtual
        /// Private Cloud (VPC). Clusters that are created in a VPC use VPC security groups, which
        /// are listed by the <b>VpcSecurityGroups</b> parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterSecurityGroupMembership> ClusterSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the ClusterSecurityGroups property is set.
        /// </summary>
        internal bool IsSetClusterSecurityGroups() => this.ClusterSecurityGroups != null && (this.ClusterSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterSnapshotCopyStatus. 
        /// <para>
        /// A value that returns the destination region and retention period that are configured
        /// for cross-region snapshot copy.
        /// </para>
        /// </summary>
        public ClusterSnapshotCopyStatus ClusterSnapshotCopyStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSnapshotCopyStatus property is set.
        /// </summary>
        internal bool IsSetClusterSnapshotCopyStatus() => this.ClusterSnapshotCopyStatus != null;

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        ///  The current state of the cluster. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>available</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available, prep-for-resize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available, resize-cleanup</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelling-resize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>creating</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>final-snapshot</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hardware-failure</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>incompatible-hsm</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>incompatible-network</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>incompatible-parameters</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>incompatible-restore</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modifying</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>paused</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rebooting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>renaming</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resizing</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rotating-keys</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>storage-full</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>updating-hsm</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterStatus property is set.
        /// </summary>
        internal bool IsSetClusterStatus() => this.ClusterStatus != null;

        /// <summary>
        /// Gets and sets the property ClusterSubnetGroupName. 
        /// <para>
        /// The name of the subnet group that is associated with the cluster. This parameter is
        /// valid only when the cluster is in a VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetClusterSubnetGroupName() => this.ClusterSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        /// The version ID of the Amazon Redshift engine that is running on the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClusterVersion property is set.
        /// </summary>
        internal bool IsSetClusterVersion() => this.ClusterVersion != null;

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateArn. 
        /// <para>
        /// The certificate Amazon Resource Name (ARN) for the custom domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CustomDomainCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainCertificateArn property is set.
        /// </summary>
        internal bool IsSetCustomDomainCertificateArn() => this.CustomDomainCertificateArn != null;

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateExpiryDate. 
        /// <para>
        /// The expiration date for the certificate associated with the custom domain name.
        /// </para>
        /// </summary>
        public DateTime? CustomDomainCertificateExpiryDate { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainCertificateExpiryDate property is set.
        /// </summary>
        internal bool IsSetCustomDomainCertificateExpiryDate() => this.CustomDomainCertificateExpiryDate.HasValue;

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name associated with the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The name of the initial database that was created when the cluster was created. This
        /// same name is returned for the life of the cluster. If an initial database was not
        /// specified, a database named <c>dev</c>dev was created by default. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DBName { get; set; }

        /// <summary>
        /// Checks to see if the DBName property is set.
        /// </summary>
        internal bool IsSetDBName() => this.DBName != null;

        /// <summary>
        /// Gets and sets the property DataTransferProgress. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public DataTransferProgress DataTransferProgress { get; set; }

        /// <summary>
        /// Checks to see if the DataTransferProgress property is set.
        /// </summary>
        internal bool IsSetDataTransferProgress() => this.DataTransferProgress != null;

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role set as default for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DefaultIamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DefaultIamRoleArn property is set.
        /// </summary>
        internal bool IsSetDefaultIamRoleArn() => this.DefaultIamRoleArn != null;

        /// <summary>
        /// Gets and sets the property DeferredMaintenanceWindows. 
        /// <para>
        /// Describes a group of <c>DeferredMaintenanceWindow</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeferredMaintenanceWindow> DeferredMaintenanceWindows { get; set; } = AWSConfigs.InitializeCollections ? new List<DeferredMaintenanceWindow>() : null;

        /// <summary>
        /// Checks to see if the DeferredMaintenanceWindows property is set.
        /// </summary>
        internal bool IsSetDeferredMaintenanceWindows() => this.DeferredMaintenanceWindows != null && (this.DeferredMaintenanceWindows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ElasticIpStatus. 
        /// <para>
        /// The status of the elastic IP (EIP) address.
        /// </para>
        /// </summary>
        public ElasticIpStatus ElasticIpStatus { get; set; }

        /// <summary>
        /// Checks to see if the ElasticIpStatus property is set.
        /// </summary>
        internal bool IsSetElasticIpStatus() => this.ElasticIpStatus != null;

        /// <summary>
        /// Gets and sets the property ElasticResizeNumberOfNodeOptions. 
        /// <para>
        /// The number of nodes that you can resize the cluster to with the elastic resize method.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ElasticResizeNumberOfNodeOptions { get; set; }

        /// <summary>
        /// Checks to see if the ElasticResizeNumberOfNodeOptions property is set.
        /// </summary>
        internal bool IsSetElasticResizeNumberOfNodeOptions() => this.ElasticResizeNumberOfNodeOptions != null;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// A boolean value that, if <c>true</c>, indicates that data in the cluster is encrypted
        /// at rest.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint.
        /// </para>
        /// </summary>
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

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
        /// Gets and sets the property ExpectedNextSnapshotScheduleTime. 
        /// <para>
        /// The date and time when the next snapshot is expected to be taken for clusters with
        /// a valid snapshot schedule and backups enabled. 
        /// </para>
        /// </summary>
        public DateTime? ExpectedNextSnapshotScheduleTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedNextSnapshotScheduleTime property is set.
        /// </summary>
        internal bool IsSetExpectedNextSnapshotScheduleTime() => this.ExpectedNextSnapshotScheduleTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedNextSnapshotScheduleTimeStatus. 
        /// <para>
        ///  The status of next expected snapshot for clusters having a valid snapshot schedule
        /// and backups enabled. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// OnTrack - The next snapshot is expected to be taken on time. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending - The next snapshot is pending to be taken. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ExpectedNextSnapshotScheduleTimeStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedNextSnapshotScheduleTimeStatus property is set.
        /// </summary>
        internal bool IsSetExpectedNextSnapshotScheduleTimeStatus() => this.ExpectedNextSnapshotScheduleTimeStatus != null;

        /// <summary>
        /// Gets and sets the property ExtraComputeForAutomaticOptimization. 
        /// <para>
        /// A boolean value that, if <c>true</c>, indicates that the cluster allocates additional
        /// compute resources to run automatic optimization operations.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ExtraComputeForAutomaticOptimization { get; set; }

        /// <summary>
        /// Checks to see if the ExtraComputeForAutomaticOptimization property is set.
        /// </summary>
        internal bool IsSetExtraComputeForAutomaticOptimization() => this.ExtraComputeForAutomaticOptimization != null;

        /// <summary>
        /// Gets and sets the property HsmStatus. 
        /// <para>
        /// A value that reports whether the Amazon Redshift cluster has finished applying any
        /// hardware security module (HSM) settings changes specified in a modify cluster command.
        /// </para>
        ///  
        /// <para>
        /// Values: active, applying
        /// </para>
        /// </summary>
        public HsmStatus HsmStatus { get; set; }

        /// <summary>
        /// Checks to see if the HsmStatus property is set.
        /// </summary>
        internal bool IsSetHsmStatus() => this.HsmStatus != null;

        /// <summary>
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// A list of Identity and Access Management (IAM) roles that can be used by the cluster
        /// to access other Amazon Web Services services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterIamRole> IamRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterIamRole>() : null;

        /// <summary>
        /// Checks to see if the IamRoles property is set.
        /// </summary>
        internal bool IsSetIamRoles() => this.IamRoles != null && (this.IamRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the cluster. Possible values are <c>ipv4</c> and <c>dualstack</c>.
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
        /// The Key Management Service (KMS) key ID of the encryption key used to encrypt data
        /// in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LakehouseRegistrationStatus. 
        /// <para>
        /// The status of the lakehouse registration for the cluster. Indicates whether the cluster
        /// is successfully registered with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string LakehouseRegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseRegistrationStatus property is set.
        /// </summary>
        internal bool IsSetLakehouseRegistrationStatus() => this.LakehouseRegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property LoggingPublishStatus. 
        /// <para>
        /// The status of system table publishing for the cluster. This field is present only
        /// when system table publishing is configured.
        /// </para>
        /// </summary>
        public LoggingPublishStatus LoggingPublishStatus { get; set; }

        /// <summary>
        /// Checks to see if the LoggingPublishStatus property is set.
        /// </summary>
        internal bool IsSetLoggingPublishStatus() => this.LoggingPublishStatus != null;

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the maintenance track for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MaintenanceTrackName { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceTrackName property is set.
        /// </summary>
        internal bool IsSetMaintenanceTrackName() => this.MaintenanceTrackName != null;

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
        /// Gets and sets the property MasterPasswordSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the cluster's admin user credentials secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MasterPasswordSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the MasterPasswordSecretArn property is set.
        /// </summary>
        internal bool IsSetMasterPasswordSecretArn() => this.MasterPasswordSecretArn != null;

        /// <summary>
        /// Gets and sets the property MasterPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the cluster's
        /// admin credentials secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MasterPasswordSecretKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the MasterPasswordSecretKmsKeyId property is set.
        /// </summary>
        internal bool IsSetMasterPasswordSecretKmsKeyId() => this.MasterPasswordSecretKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The admin user name for the cluster. This name is used to connect to the database
        /// that is specified in the <b>DBName</b> parameter. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property ModifyStatus. 
        /// <para>
        /// The status of a modify operation, if any, initiated for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ModifyStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModifyStatus property is set.
        /// </summary>
        internal bool IsSetModifyStatus() => this.ModifyStatus != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// A boolean value that, if true, indicates that the cluster is deployed in two Availability
        /// Zones.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ != null;

        /// <summary>
        /// Gets and sets the property MultiAZSecondary. 
        /// <para>
        /// The secondary compute unit of a cluster, if Multi-AZ deployment is turned on.
        /// </para>
        /// </summary>
        public SecondaryClusterInfo MultiAZSecondary { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZSecondary property is set.
        /// </summary>
        internal bool IsSetMultiAZSecondary() => this.MultiAZSecondary != null;

        /// <summary>
        /// Gets and sets the property NextMaintenanceWindowStartTime. 
        /// <para>
        /// The date and time in UTC when system maintenance can begin.
        /// </para>
        /// </summary>
        public DateTime? NextMaintenanceWindowStartTime { get; set; }

        /// <summary>
        /// Checks to see if the NextMaintenanceWindowStartTime property is set.
        /// </summary>
        internal bool IsSetNextMaintenanceWindowStartTime() => this.NextMaintenanceWindowStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the nodes in the cluster.
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
        /// The number of compute nodes in the cluster.
        /// </para>
        /// </summary>
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;

        /// <summary>
        /// Gets and sets the property PendingActions. 
        /// <para>
        /// Cluster operations that are waiting to be started.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PendingActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PendingActions property is set.
        /// </summary>
        internal bool IsSetPendingActions() => this.PendingActions != null && (this.PendingActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// A value that, if present, indicates that changes to the cluster are pending. Specific
        /// pending changes are identified by subelements.
        /// </para>
        /// </summary>
        public PendingModifiedValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range, in Universal Coordinated Time (UTC), during which system maintenance
        /// can occur.
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
        /// A boolean value that, if <c>true</c>, indicates that the cluster can be accessed from
        /// a public network.
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
        /// Gets and sets the property ReservedNodeExchangeStatus. 
        /// <para>
        /// The status of the reserved-node exchange request. Statuses include in-progress and
        /// requested.
        /// </para>
        /// </summary>
        public ReservedNodeExchangeStatus ReservedNodeExchangeStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodeExchangeStatus property is set.
        /// </summary>
        internal bool IsSetReservedNodeExchangeStatus() => this.ReservedNodeExchangeStatus != null;

        /// <summary>
        /// Gets and sets the property ResizeInfo. 
        /// <para>
        /// Returns the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AllowCancelResize: a boolean value indicating if the resize operation can be cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ResizeType: Returns ClassicResize
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResizeInfo ResizeInfo { get; set; }

        /// <summary>
        /// Checks to see if the ResizeInfo property is set.
        /// </summary>
        internal bool IsSetResizeInfo() => this.ResizeInfo != null;

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// A value that describes the status of a cluster restore action. This parameter returns
        /// null if the cluster was not created by restoring a snapshot.
        /// </para>
        /// </summary>
        public RestoreStatus RestoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the RestoreStatus property is set.
        /// </summary>
        internal bool IsSetRestoreStatus() => this.RestoreStatus != null;

        /// <summary>
        /// Gets and sets the property SnapshotScheduleIdentifier. 
        /// <para>
        /// A unique identifier for the cluster snapshot schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotScheduleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotScheduleIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotScheduleIdentifier() => this.SnapshotScheduleIdentifier != null;

        /// <summary>
        /// Gets and sets the property SnapshotScheduleState. 
        /// <para>
        /// The current state of the cluster snapshot schedule.
        /// </para>
        /// </summary>
        public ScheduleState SnapshotScheduleState { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotScheduleState property is set.
        /// </summary>
        internal bool IsSetSnapshotScheduleState() => this.SnapshotScheduleState != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the cluster.
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
        /// Gets and sets the property TotalStorageCapacityInMegaBytes. 
        /// <para>
        /// The total storage capacity of the cluster in megabytes. 
        /// </para>
        /// </summary>
        public long? TotalStorageCapacityInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalStorageCapacityInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalStorageCapacityInMegaBytes() => this.TotalStorageCapacityInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC the cluster is in, if the cluster is in a VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// A list of Amazon Virtual Private Cloud (Amazon VPC) security groups that are associated
        /// with the cluster. This parameter is returned only if the cluster is in a VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroups() => this.VpcSecurityGroups != null && (this.VpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
