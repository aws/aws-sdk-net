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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Amazon Redshift cluster.
    /// </summary>
    public partial class AwsRedshiftClusterDetails
    {
        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        /// Indicates whether major version upgrades are applied automatically to the cluster
        /// during the maintenance window.
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
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property ClusterAvailabilityStatus. 
        /// <para>
        /// The availability status of the cluster for queries. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Available</c> - The cluster is available for queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Unavailable</c> - The cluster is not available for queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Maintenance</c> - The cluster is intermittently available for queries due to maintenance
        /// activities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Modifying</c> -The cluster is intermittently available for queries due to changes
        /// that modify the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - The cluster failed and is not available for queries.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ClusterAvailabilityStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterAvailabilityStatus property is set.
        /// </summary>
        internal bool IsSetClusterAvailabilityStatus() => this.ClusterAvailabilityStatus != null;

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// Indicates when the cluster was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ClusterCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the ClusterCreateTime property is set.
        /// </summary>
        internal bool IsSetClusterCreateTime() => this.ClusterCreateTime != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster.
        /// </para>
        /// </summary>
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

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
        public List<AwsRedshiftClusterClusterNode> ClusterNodes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRedshiftClusterClusterNode>() : null;

        /// <summary>
        /// Checks to see if the ClusterNodes property is set.
        /// </summary>
        internal bool IsSetClusterNodes() => this.ClusterNodes != null && (this.ClusterNodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterParameterGroups. 
        /// <para>
        /// The list of cluster parameter groups that are associated with this cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRedshiftClusterClusterParameterGroup> ClusterParameterGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRedshiftClusterClusterParameterGroup>() : null;

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
        public string ClusterRevisionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ClusterRevisionNumber property is set.
        /// </summary>
        internal bool IsSetClusterRevisionNumber() => this.ClusterRevisionNumber != null;

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroups. 
        /// <para>
        /// A list of cluster security groups that are associated with the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRedshiftClusterClusterSecurityGroup> ClusterSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRedshiftClusterClusterSecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the ClusterSecurityGroups property is set.
        /// </summary>
        internal bool IsSetClusterSecurityGroups() => this.ClusterSecurityGroups != null && (this.ClusterSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterSnapshotCopyStatus. 
        /// <para>
        /// Information about the destination Region and retention period for the cross-Region
        /// snapshot copy.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterClusterSnapshotCopyStatus ClusterSnapshotCopyStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSnapshotCopyStatus property is set.
        /// </summary>
        internal bool IsSetClusterSnapshotCopyStatus() => this.ClusterSnapshotCopyStatus != null;

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The current status of the cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>available</c> | <c>available, prep-for-resize</c> | <c>available,
        /// resize-cleanup</c> |<c> cancelling-resize</c> | <c>creating</c> | <c>deleting</c>
        /// | <c>final-snapshot</c> | <c>hardware-failure</c> | <c>incompatible-hsm</c> |<c> incompatible-network</c>
        /// | <c>incompatible-parameters</c> | <c>incompatible-restore</c> | <c>modifying</c>
        /// | <c>paused</c> | <c>rebooting</c> | <c>renaming</c> | <c>resizing</c> | <c>rotating-keys</c>
        /// | <c>storage-full</c> | <c>updating-hsm</c> 
        /// </para>
        /// </summary>
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
        public string ClusterSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetClusterSubnetGroupName() => this.ClusterSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        /// The version ID of the Amazon Redshift engine that runs on the cluster.
        /// </para>
        /// </summary>
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClusterVersion property is set.
        /// </summary>
        internal bool IsSetClusterVersion() => this.ClusterVersion != null;

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The name of the initial database that was created when the cluster was created.
        /// </para>
        ///  
        /// <para>
        /// The same name is returned for the life of the cluster.
        /// </para>
        ///  
        /// <para>
        /// If an initial database is not specified, a database named <c>devdev</c> is created
        /// by default.
        /// </para>
        /// </summary>
        public string DBName { get; set; }

        /// <summary>
        /// Checks to see if the DBName property is set.
        /// </summary>
        internal bool IsSetDBName() => this.DBName != null;

        /// <summary>
        /// Gets and sets the property DeferredMaintenanceWindows. 
        /// <para>
        /// List of time windows during which maintenance was deferred.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRedshiftClusterDeferredMaintenanceWindow> DeferredMaintenanceWindows { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRedshiftClusterDeferredMaintenanceWindow>() : null;

        /// <summary>
        /// Checks to see if the DeferredMaintenanceWindows property is set.
        /// </summary>
        internal bool IsSetDeferredMaintenanceWindows() => this.DeferredMaintenanceWindows != null && (this.DeferredMaintenanceWindows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ElasticIpStatus. 
        /// <para>
        /// Information about the status of the Elastic IP (EIP) address.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterElasticIpStatus ElasticIpStatus { get; set; }

        /// <summary>
        /// Checks to see if the ElasticIpStatus property is set.
        /// </summary>
        internal bool IsSetElasticIpStatus() => this.ElasticIpStatus != null;

        /// <summary>
        /// Gets and sets the property ElasticResizeNumberOfNodeOptions. 
        /// <para>
        /// The number of nodes that you can use the elastic resize method to resize the cluster
        /// to.
        /// </para>
        /// </summary>
        public string ElasticResizeNumberOfNodeOptions { get; set; }

        /// <summary>
        /// Checks to see if the ElasticResizeNumberOfNodeOptions property is set.
        /// </summary>
        internal bool IsSetElasticResizeNumberOfNodeOptions() => this.ElasticResizeNumberOfNodeOptions != null;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the data in the cluster is encrypted at rest.
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
        public AwsRedshiftClusterEndpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// Indicates whether to create the cluster with enhanced VPC routing enabled.
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
        /// Indicates when the next snapshot is expected to be taken. The cluster must have a
        /// valid snapshot schedule and have backups enabled.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ExpectedNextSnapshotScheduleTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedNextSnapshotScheduleTime property is set.
        /// </summary>
        internal bool IsSetExpectedNextSnapshotScheduleTime() => this.ExpectedNextSnapshotScheduleTime != null;

        /// <summary>
        /// Gets and sets the property ExpectedNextSnapshotScheduleTimeStatus. 
        /// <para>
        /// The status of the next expected snapshot.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>OnTrack</c> | <c>Pending</c> 
        /// </para>
        /// </summary>
        public string ExpectedNextSnapshotScheduleTimeStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedNextSnapshotScheduleTimeStatus property is set.
        /// </summary>
        internal bool IsSetExpectedNextSnapshotScheduleTimeStatus() => this.ExpectedNextSnapshotScheduleTimeStatus != null;

        /// <summary>
        /// Gets and sets the property HsmStatus. 
        /// <para>
        /// Information about whether the Amazon Redshift cluster finished applying any changes
        /// to hardware security module (HSM) settings that were specified in a modify cluster
        /// command.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterHsmStatus HsmStatus { get; set; }

        /// <summary>
        /// Checks to see if the HsmStatus property is set.
        /// </summary>
        internal bool IsSetHsmStatus() => this.HsmStatus != null;

        /// <summary>
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// A list of IAM roles that the cluster can use to access other Amazon Web Services services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRedshiftClusterIamRole> IamRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRedshiftClusterIamRole>() : null;

        /// <summary>
        /// Checks to see if the IamRoles property is set.
        /// </summary>
        internal bool IsSetIamRoles() => this.IamRoles != null && (this.IamRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the KMS encryption key that is used to encrypt data in the cluster.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LoggingStatus. 
        /// <para>
        /// Information about the logging status of the cluster.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterLoggingStatus LoggingStatus { get; set; }

        /// <summary>
        /// Checks to see if the LoggingStatus property is set.
        /// </summary>
        internal bool IsSetLoggingStatus() => this.LoggingStatus != null;

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the maintenance track for the cluster.
        /// </para>
        /// </summary>
        public string MaintenanceTrackName { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceTrackName property is set.
        /// </summary>
        internal bool IsSetMaintenanceTrackName() => this.MaintenanceTrackName != null;

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The default number of days to retain a manual snapshot.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>-1</c>, the snapshot is retained indefinitely.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't change the retention period of existing snapshots.
        /// </para>
        ///  
        /// <para>
        /// Valid values: Either <c>-1</c> or an integer between 1 and 3,653
        /// </para>
        /// </summary>
        public int? ManualSnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ManualSnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetManualSnapshotRetentionPeriod() => this.ManualSnapshotRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name for the cluster. This name is used to connect to the database
        /// that is specified in as the value of <c>DBName</c>.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property NextMaintenanceWindowStartTime. 
        /// <para>
        /// Indicates the start of the next maintenance window.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string NextMaintenanceWindowStartTime { get; set; }

        /// <summary>
        /// Checks to see if the NextMaintenanceWindowStartTime property is set.
        /// </summary>
        internal bool IsSetNextMaintenanceWindowStartTime() => this.NextMaintenanceWindowStartTime != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the nodes in the cluster.
        /// </para>
        /// </summary>
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
        /// A list of cluster operations that are waiting to start.
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
        /// A list of changes to the cluster that are currently pending.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterPendingModifiedValues PendingModifiedValues { get; set; }

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
        ///  
        /// <para>
        /// Format: <c> <i>&lt;day&gt;</i>:HH:MM-<i>&lt;day&gt;</i>:HH:MM</c> 
        /// </para>
        ///  
        /// <para>
        /// For the day values, use <c>mon</c> | <c>tue</c> | <c>wed</c> | <c>thu</c> | <c>fri</c>
        /// | <c>sat</c> | <c>sun</c> 
        /// </para>
        ///  
        /// <para>
        /// For example, <c>sun:09:32-sun:10:02</c> 
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Whether the cluster can be accessed from a public network.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property ResizeInfo. 
        /// <para>
        /// Information about the resize operation for the cluster.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterResizeInfo ResizeInfo { get; set; }

        /// <summary>
        /// Checks to see if the ResizeInfo property is set.
        /// </summary>
        internal bool IsSetResizeInfo() => this.ResizeInfo != null;

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// Information about the status of a cluster restore action. Only applies to a cluster
        /// that was created by restoring a snapshot.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterRestoreStatus RestoreStatus { get; set; }

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
        ///  
        /// <para>
        /// Valid values: <c>MODIFYING</c> | <c>ACTIVE</c> | <c>FAILED</c> 
        /// </para>
        /// </summary>
        public string SnapshotScheduleState { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotScheduleState property is set.
        /// </summary>
        internal bool IsSetSnapshotScheduleState() => this.SnapshotScheduleState != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the cluster is in, if the cluster is in a VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// The list of VPC security groups that the cluster belongs to, if the cluster is in
        /// a VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRedshiftClusterVpcSecurityGroup> VpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRedshiftClusterVpcSecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroups() => this.VpcSecurityGroups != null && (this.VpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
