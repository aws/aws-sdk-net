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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// A snapshot object that contains databases.
    /// </summary>
    public partial class Snapshot
    {
        /// <summary>
        /// Gets and sets the property AccountsWithProvisionedRestoreAccess. 
        /// <para>
        /// All of the Amazon Web Services accounts that have access to restore a snapshot to
        /// a provisioned cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountsWithProvisionedRestoreAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountsWithProvisionedRestoreAccess property is set.
        /// </summary>
        internal bool IsSetAccountsWithProvisionedRestoreAccess() => this.AccountsWithProvisionedRestoreAccess != null && (this.AccountsWithProvisionedRestoreAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AccountsWithRestoreAccess. 
        /// <para>
        /// All of the Amazon Web Services accounts that have access to restore a snapshot to
        /// a namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountsWithRestoreAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountsWithRestoreAccess property is set.
        /// </summary>
        internal bool IsSetAccountsWithRestoreAccess() => this.AccountsWithRestoreAccess != null && (this.AccountsWithRestoreAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ActualIncrementalBackupSizeInMegaBytes. 
        /// <para>
        /// The size of the incremental backup in megabytes.
        /// </para>
        /// </summary>
        public double? ActualIncrementalBackupSizeInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the ActualIncrementalBackupSizeInMegaBytes property is set.
        /// </summary>
        internal bool IsSetActualIncrementalBackupSizeInMegaBytes() => this.ActualIncrementalBackupSizeInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the namespace's admin user credentials secret.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the AdminPasswordSecretArn property is set.
        /// </summary>
        internal bool IsSetAdminPasswordSecretArn() => this.AdminPasswordSecretArn != null;

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the namespace's
        /// admin credentials secret.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AdminPasswordSecretKmsKeyId property is set.
        /// </summary>
        internal bool IsSetAdminPasswordSecretKmsKeyId() => this.AdminPasswordSecretKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property AdminUsername. 
        /// <para>
        /// The username of the database within a snapshot.
        /// </para>
        /// </summary>
        public string AdminUsername { get; set; }

        /// <summary>
        /// Checks to see if the AdminUsername property is set.
        /// </summary>
        internal bool IsSetAdminUsername() => this.AdminUsername != null;

        /// <summary>
        /// Gets and sets the property BackupProgressInMegaBytes. 
        /// <para>
        /// The size in megabytes of the data that has been backed up to a snapshot.
        /// </para>
        /// </summary>
        public double? BackupProgressInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackupProgressInMegaBytes property is set.
        /// </summary>
        internal bool IsSetBackupProgressInMegaBytes() => this.BackupProgressInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentBackupRateInMegaBytesPerSecond. 
        /// <para>
        /// The rate at which data is backed up into a snapshot in megabytes per second.
        /// </para>
        /// </summary>
        public double? CurrentBackupRateInMegaBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the CurrentBackupRateInMegaBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetCurrentBackupRateInMegaBytesPerSecond() => this.CurrentBackupRateInMegaBytesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// The amount of time it took to back up data into a snapshot.
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetElapsedTimeInSeconds() => this.ElapsedTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedSecondsToCompletion. 
        /// <para>
        /// The estimated amount of seconds until the snapshot completes backup.
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
        /// The unique identifier of the KMS key used to encrypt the snapshot.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the namespace the snapshot was created from.
        /// </para>
        /// </summary>
        public string NamespaceArn { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceArn property is set.
        /// </summary>
        internal bool IsSetNamespaceArn() => this.NamespaceArn != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namepsace.
        /// </para>
        /// </summary>
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The owner Amazon Web Services; account of the snapshot.
        /// </para>
        /// </summary>
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotArn property is set.
        /// </summary>
        internal bool IsSetSnapshotArn() => this.SnapshotArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// The timestamp of when the snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreateTime property is set.
        /// </summary>
        internal bool IsSetSnapshotCreateTime() => this.SnapshotCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property SnapshotRemainingDays. 
        /// <para>
        /// The amount of days until the snapshot is deleted.
        /// </para>
        /// </summary>
        public int? SnapshotRemainingDays { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRemainingDays property is set.
        /// </summary>
        internal bool IsSetSnapshotRemainingDays() => this.SnapshotRemainingDays.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionPeriod. 
        /// <para>
        /// The period of time, in days, of how long the snapshot is retained.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionPeriod() => this.SnapshotRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionStartTime. 
        /// <para>
        /// The timestamp of when data within the snapshot started getting retained.
        /// </para>
        /// </summary>
        public DateTime? SnapshotRetentionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionStartTime property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionStartTime() => this.SnapshotRetentionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the snapshot.
        /// </para>
        /// </summary>
        public SnapshotStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalBackupSizeInMegaBytes. 
        /// <para>
        /// The total size, in megabytes, of how big the snapshot is.
        /// </para>
        /// </summary>
        public double? TotalBackupSizeInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalBackupSizeInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalBackupSizeInMegaBytes() => this.TotalBackupSizeInMegaBytes.HasValue;
    }
}
