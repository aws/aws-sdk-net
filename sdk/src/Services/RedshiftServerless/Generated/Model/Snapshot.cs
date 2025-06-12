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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
        private List<string> _accountsWithProvisionedRestoreAccess = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _accountsWithRestoreAccess = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _actualIncrementalBackupSizeInMegaBytes;
        private string _adminPasswordSecretArn;
        private string _adminPasswordSecretKmsKeyId;
        private string _adminUsername;
        private double? _backupProgressInMegaBytes;
        private double? _currentBackupRateInMegaBytesPerSecond;
        private long? _elapsedTimeInSeconds;
        private long? _estimatedSecondsToCompletion;
        private string _kmsKeyId;
        private string _namespaceArn;
        private string _namespaceName;
        private string _ownerAccount;
        private string _snapshotArn;
        private DateTime? _snapshotCreateTime;
        private string _snapshotName;
        private int? _snapshotRemainingDays;
        private int? _snapshotRetentionPeriod;
        private DateTime? _snapshotRetentionStartTime;
        private SnapshotStatus _status;
        private double? _totalBackupSizeInMegaBytes;

        /// <summary>
        /// Gets and sets the property AccountsWithProvisionedRestoreAccess. 
        /// <para>
        /// All of the Amazon Web Services accounts that have access to restore a snapshot to
        /// a provisioned cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountsWithProvisionedRestoreAccess
        {
            get { return this._accountsWithProvisionedRestoreAccess; }
            set { this._accountsWithProvisionedRestoreAccess = value; }
        }

        // Check to see if AccountsWithProvisionedRestoreAccess property is set
        internal bool IsSetAccountsWithProvisionedRestoreAccess()
        {
            return this._accountsWithProvisionedRestoreAccess != null && (this._accountsWithProvisionedRestoreAccess.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AccountsWithRestoreAccess. 
        /// <para>
        /// All of the Amazon Web Services accounts that have access to restore a snapshot to
        /// a namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountsWithRestoreAccess
        {
            get { return this._accountsWithRestoreAccess; }
            set { this._accountsWithRestoreAccess = value; }
        }

        // Check to see if AccountsWithRestoreAccess property is set
        internal bool IsSetAccountsWithRestoreAccess()
        {
            return this._accountsWithRestoreAccess != null && (this._accountsWithRestoreAccess.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ActualIncrementalBackupSizeInMegaBytes. 
        /// <para>
        /// The size of the incremental backup in megabytes.
        /// </para>
        /// </summary>
        public double? ActualIncrementalBackupSizeInMegaBytes
        {
            get { return this._actualIncrementalBackupSizeInMegaBytes; }
            set { this._actualIncrementalBackupSizeInMegaBytes = value; }
        }

        // Check to see if ActualIncrementalBackupSizeInMegaBytes property is set
        internal bool IsSetActualIncrementalBackupSizeInMegaBytes()
        {
            return this._actualIncrementalBackupSizeInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the namespace's admin user credentials secret.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretArn
        {
            get { return this._adminPasswordSecretArn; }
            set { this._adminPasswordSecretArn = value; }
        }

        // Check to see if AdminPasswordSecretArn property is set
        internal bool IsSetAdminPasswordSecretArn()
        {
            return this._adminPasswordSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the namespace's
        /// admin credentials secret.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretKmsKeyId
        {
            get { return this._adminPasswordSecretKmsKeyId; }
            set { this._adminPasswordSecretKmsKeyId = value; }
        }

        // Check to see if AdminPasswordSecretKmsKeyId property is set
        internal bool IsSetAdminPasswordSecretKmsKeyId()
        {
            return this._adminPasswordSecretKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property AdminUsername. 
        /// <para>
        /// The username of the database within a snapshot.
        /// </para>
        /// </summary>
        public string AdminUsername
        {
            get { return this._adminUsername; }
            set { this._adminUsername = value; }
        }

        // Check to see if AdminUsername property is set
        internal bool IsSetAdminUsername()
        {
            return this._adminUsername != null;
        }

        /// <summary>
        /// Gets and sets the property BackupProgressInMegaBytes. 
        /// <para>
        /// The size in megabytes of the data that has been backed up to a snapshot.
        /// </para>
        /// </summary>
        public double? BackupProgressInMegaBytes
        {
            get { return this._backupProgressInMegaBytes; }
            set { this._backupProgressInMegaBytes = value; }
        }

        // Check to see if BackupProgressInMegaBytes property is set
        internal bool IsSetBackupProgressInMegaBytes()
        {
            return this._backupProgressInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentBackupRateInMegaBytesPerSecond. 
        /// <para>
        /// The rate at which data is backed up into a snapshot in megabytes per second.
        /// </para>
        /// </summary>
        public double? CurrentBackupRateInMegaBytesPerSecond
        {
            get { return this._currentBackupRateInMegaBytesPerSecond; }
            set { this._currentBackupRateInMegaBytesPerSecond = value; }
        }

        // Check to see if CurrentBackupRateInMegaBytesPerSecond property is set
        internal bool IsSetCurrentBackupRateInMegaBytesPerSecond()
        {
            return this._currentBackupRateInMegaBytesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// The amount of time it took to back up data into a snapshot.
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds
        {
            get { return this._elapsedTimeInSeconds; }
            set { this._elapsedTimeInSeconds = value; }
        }

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this._elapsedTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedSecondsToCompletion. 
        /// <para>
        /// The estimated amount of seconds until the snapshot completes backup.
        /// </para>
        /// </summary>
        public long? EstimatedSecondsToCompletion
        {
            get { return this._estimatedSecondsToCompletion; }
            set { this._estimatedSecondsToCompletion = value; }
        }

        // Check to see if EstimatedSecondsToCompletion property is set
        internal bool IsSetEstimatedSecondsToCompletion()
        {
            return this._estimatedSecondsToCompletion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The unique identifier of the KMS key used to encrypt the snapshot.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the namespace the snapshot was created from.
        /// </para>
        /// </summary>
        public string NamespaceArn
        {
            get { return this._namespaceArn; }
            set { this._namespaceArn = value; }
        }

        // Check to see if NamespaceArn property is set
        internal bool IsSetNamespaceArn()
        {
            return this._namespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namepsace.
        /// </para>
        /// </summary>
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The owner Amazon Web Services; account of the snapshot.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// The timestamp of when the snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreateTime
        {
            get { return this._snapshotCreateTime; }
            set { this._snapshotCreateTime = value; }
        }

        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this._snapshotCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotRemainingDays. 
        /// <para>
        /// The amount of days until the snapshot is deleted.
        /// </para>
        /// </summary>
        public int? SnapshotRemainingDays
        {
            get { return this._snapshotRemainingDays; }
            set { this._snapshotRemainingDays = value; }
        }

        // Check to see if SnapshotRemainingDays property is set
        internal bool IsSetSnapshotRemainingDays()
        {
            return this._snapshotRemainingDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionPeriod. 
        /// <para>
        /// The period of time, in days, of how long the snapshot is retained.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionPeriod
        {
            get { return this._snapshotRetentionPeriod; }
            set { this._snapshotRetentionPeriod = value; }
        }

        // Check to see if SnapshotRetentionPeriod property is set
        internal bool IsSetSnapshotRetentionPeriod()
        {
            return this._snapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionStartTime. 
        /// <para>
        /// The timestamp of when data within the snapshot started getting retained.
        /// </para>
        /// </summary>
        public DateTime? SnapshotRetentionStartTime
        {
            get { return this._snapshotRetentionStartTime; }
            set { this._snapshotRetentionStartTime = value; }
        }

        // Check to see if SnapshotRetentionStartTime property is set
        internal bool IsSetSnapshotRetentionStartTime()
        {
            return this._snapshotRetentionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the snapshot.
        /// </para>
        /// </summary>
        public SnapshotStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TotalBackupSizeInMegaBytes. 
        /// <para>
        /// The total size, in megabytes, of how big the snapshot is.
        /// </para>
        /// </summary>
        public double? TotalBackupSizeInMegaBytes
        {
            get { return this._totalBackupSizeInMegaBytes; }
            set { this._totalBackupSizeInMegaBytes = value; }
        }

        // Check to see if TotalBackupSizeInMegaBytes property is set
        internal bool IsSetTotalBackupSizeInMegaBytes()
        {
            return this._totalBackupSizeInMegaBytes.HasValue; 
        }

    }
}