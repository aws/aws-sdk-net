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
    /// Describes a snapshot.
    /// </summary>
    public partial class Snapshot
    {
        /// <summary>
        /// Gets and sets the property AccountsWithRestoreAccess. 
        /// <para>
        /// A list of the Amazon Web Services accounts authorized to restore the snapshot. Returns
        /// <c>null</c> if no accounts are authorized. Visible only to the snapshot owner. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccountWithRestoreAccess> AccountsWithRestoreAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<AccountWithRestoreAccess>() : null;

        /// <summary>
        /// Checks to see if the AccountsWithRestoreAccess property is set.
        /// </summary>
        internal bool IsSetAccountsWithRestoreAccess() => this.AccountsWithRestoreAccess != null && (this.AccountsWithRestoreAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ActualIncrementalBackupSizeInMegaBytes. 
        /// <para>
        /// The size of the incremental backup.
        /// </para>
        /// </summary>
        public double? ActualIncrementalBackupSizeInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the ActualIncrementalBackupSizeInMegaBytes property is set.
        /// </summary>
        internal bool IsSetActualIncrementalBackupSizeInMegaBytes() => this.ActualIncrementalBackupSizeInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the cluster was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property BackupProgressInMegaBytes. 
        /// <para>
        /// The number of megabytes that have been transferred to the snapshot backup.
        /// </para>
        /// </summary>
        public double? BackupProgressInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackupProgressInMegaBytes property is set.
        /// </summary>
        internal bool IsSetBackupProgressInMegaBytes() => this.BackupProgressInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// The time (UTC) when the cluster was originally created.
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
        /// The identifier of the cluster for which the snapshot was taken.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

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
        /// Gets and sets the property CurrentBackupRateInMegaBytesPerSecond. 
        /// <para>
        /// The number of megabytes per second being transferred to the snapshot backup. Returns
        /// <c>0</c> for a completed backup. 
        /// </para>
        /// </summary>
        public double? CurrentBackupRateInMegaBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the CurrentBackupRateInMegaBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetCurrentBackupRateInMegaBytesPerSecond() => this.CurrentBackupRateInMegaBytesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The name of the database that was created when the cluster was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DBName { get; set; }

        /// <summary>
        /// Checks to see if the DBName property is set.
        /// </summary>
        internal bool IsSetDBName() => this.DBName != null;

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// The amount of time an in-progress snapshot backup has been running, or the amount
        /// of time it took a completed backup to finish.
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetElapsedTimeInSeconds() => this.ElapsedTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// If <c>true</c>, the data in the snapshot is encrypted at rest.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptedWithHSM. 
        /// <para>
        /// A boolean that indicates whether the snapshot data is encrypted using the HSM keys
        /// of the source cluster. <c>true</c> indicates that the data is encrypted using HSM
        /// keys.
        /// </para>
        /// </summary>
        public bool? EncryptedWithHSM { get; set; }

        /// <summary>
        /// Checks to see if the EncryptedWithHSM property is set.
        /// </summary>
        internal bool IsSetEncryptedWithHSM() => this.EncryptedWithHSM.HasValue;

        /// <summary>
        /// Gets and sets the property EngineFullVersion. 
        /// <para>
        /// The cluster version of the cluster used to create the snapshot. For example, 1.0.15503.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string EngineFullVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineFullVersion property is set.
        /// </summary>
        internal bool IsSetEngineFullVersion() => this.EngineFullVersion != null;

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
        /// Gets and sets the property EstimatedSecondsToCompletion. 
        /// <para>
        /// The estimate of the time remaining before the snapshot backup will complete. Returns
        /// <c>0</c> for a completed backup. 
        /// </para>
        /// </summary>
        public long? EstimatedSecondsToCompletion { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedSecondsToCompletion property is set.
        /// </summary>
        internal bool IsSetEstimatedSecondsToCompletion() => this.EstimatedSecondsToCompletion.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Key Management Service (KMS) key ID of the encryption key that was used to encrypt
        /// data in the cluster from which the snapshot was taken.
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
        /// The name of the maintenance track for the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MaintenanceTrackName { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceTrackName property is set.
        /// </summary>
        internal bool IsSetMaintenanceTrackName() => this.MaintenanceTrackName != null;

        /// <summary>
        /// Gets and sets the property ManualSnapshotRemainingDays. 
        /// <para>
        /// The number of days until a manual snapshot will pass its retention period.
        /// </para>
        /// </summary>
        public int? ManualSnapshotRemainingDays { get; set; }

        /// <summary>
        /// Checks to see if the ManualSnapshotRemainingDays property is set.
        /// </summary>
        internal bool IsSetManualSnapshotRemainingDays() => this.ManualSnapshotRemainingDays.HasValue;

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that a manual snapshot is retained. If the value is -1, the manual
        /// snapshot is retained indefinitely. 
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
        /// The admin user name for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type of the nodes in the cluster.
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
        /// The number of nodes in the cluster.
        /// </para>
        /// </summary>
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// For manual snapshots, the Amazon Web Services account used to create or copy the snapshot.
        /// For automatic snapshots, the owner of the cluster. The owner can perform all snapshot
        /// actions, such as sharing a manual snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the cluster is listening on.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property RestorableNodeTypes. 
        /// <para>
        /// The list of node types that this cluster snapshot is able to restore into.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RestorableNodeTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RestorableNodeTypes property is set.
        /// </summary>
        internal bool IsSetRestorableNodeTypes() => this.RestorableNodeTypes != null && (this.RestorableNodeTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotArn property is set.
        /// </summary>
        internal bool IsSetSnapshotArn() => this.SnapshotArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// The time (in UTC format) when Amazon Redshift began the snapshot. A snapshot contains
        /// a copy of the cluster data as of this exact time.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreateTime property is set.
        /// </summary>
        internal bool IsSetSnapshotCreateTime() => this.SnapshotCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The snapshot identifier that is provided in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotIdentifier() => this.SnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionStartTime. 
        /// <para>
        /// A timestamp representing the start of the retention period for the snapshot.
        /// </para>
        /// </summary>
        public DateTime? SnapshotRetentionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionStartTime property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionStartTime() => this.SnapshotRetentionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The snapshot type. Snapshots created using <a>CreateClusterSnapshot</a> and <a>CopyClusterSnapshot</a>
        /// are of type "manual". 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The source region from which the snapshot was copied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The snapshot status. The value of the status depends on the API operation used: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateClusterSnapshot</a> and <a>CopyClusterSnapshot</a> returns status as "creating".
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeClusterSnapshots</a> returns status as "creating", "available", "final
        /// snapshot", or "failed".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteClusterSnapshot</a> returns status as "deleted".
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the cluster snapshot.
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
        /// Gets and sets the property TotalBackupSizeInMegaBytes. 
        /// <para>
        /// The size of the complete set of backup data that would be used to restore the cluster.
        /// </para>
        /// </summary>
        public double? TotalBackupSizeInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalBackupSizeInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalBackupSizeInMegaBytes() => this.TotalBackupSizeInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC identifier of the cluster if the snapshot is from a cluster in a VPC. Otherwise,
        /// this field is not in the output.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
