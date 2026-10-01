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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains detailed information about a saved recovery point.
    /// </summary>
    public partial class RecoveryPointByResource
    {
        /// <summary>
        /// Gets and sets the property AggregatedScanResult. 
        /// <para>
        /// Contains the latest scanning results against the recovery point and currently include
        /// <c>FailedScan</c>, <c>Findings</c>, <c>LastComputed</c>.
        /// </para>
        /// </summary>
        public AggregatedScanResult AggregatedScanResult { get; set; }

        /// <summary>
        /// Checks to see if the AggregatedScanResult property is set.
        /// </summary>
        internal bool IsSetAggregatedScanResult() => this.AggregatedScanResult != null;

        /// <summary>
        /// Gets and sets the property BackupSizeBytes. 
        /// <para>
        /// The size, in bytes, of a backup.
        /// </para>
        /// </summary>
        public long? BackupSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackupSizeBytes property is set.
        /// </summary>
        internal bool IsSetBackupSizeBytes() => this.BackupSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        /// </summary>
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time a recovery point is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The server-side encryption key that is used to protect your backups; for example,
        /// <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyType. 
        /// <para>
        /// The type of encryption key used for the recovery point. Valid values are CUSTOMER_MANAGED_KMS_KEY
        /// for customer-managed keys or Amazon Web Services_OWNED_KMS_KEY for Amazon Web Services-owned
        /// keys.
        /// </para>
        /// </summary>
        public EncryptionKeyType EncryptionKeyType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyType property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyType() => this.EncryptionKeyType != null;

        /// <summary>
        /// Gets and sets the property IndexStatus. 
        /// <para>
        /// This is the current status for the backup index associated with the specified recovery
        /// point.
        /// </para>
        ///  
        /// <para>
        /// Statuses are: <c>PENDING</c> | <c>ACTIVE</c> | <c>FAILED</c> | <c>DELETING</c> 
        /// </para>
        ///  
        /// <para>
        /// A recovery point with an index that has the status of <c>ACTIVE</c> can be included
        /// in a search.
        /// </para>
        /// </summary>
        public IndexStatus IndexStatus { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatus property is set.
        /// </summary>
        internal bool IsSetIndexStatus() => this.IndexStatus != null;

        /// <summary>
        /// Gets and sets the property IndexStatusMessage. 
        /// <para>
        /// A string in the form of a detailed message explaining the status of a backup index
        /// associated with the recovery point.
        /// </para>
        /// </summary>
        public string IndexStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatusMessage property is set.
        /// </summary>
        internal bool IsSetIndexStatusMessage() => this.IndexStatusMessage != null;

        /// <summary>
        /// Gets and sets the property IsParent. 
        /// <para>
        /// This is a boolean value indicating this is a parent (composite) recovery point.
        /// </para>
        /// </summary>
        public bool? IsParent { get; set; }

        /// <summary>
        /// Checks to see if the IsParent property is set.
        /// </summary>
        internal bool IsSetIsParent() => this.IsParent.HasValue;

        /// <summary>
        /// Gets and sets the property ParentRecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parent (composite) recovery point.
        /// </para>
        /// </summary>
        public string ParentRecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the ParentRecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetParentRecoveryPointArn() => this.ParentRecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a recovery point; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        public string RecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPointArn() => this.RecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The non-unique name of the resource that belongs to the specified backup.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code specifying the state of the recovery point.
        /// </para>
        /// </summary>
        public RecoveryPointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining the current status of the recovery point.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property VaultType. 
        /// <para>
        /// The type of vault in which the described recovery point is stored.
        /// </para>
        /// </summary>
        public VaultType VaultType { get; set; }

        /// <summary>
        /// Checks to see if the VaultType property is set.
        /// </summary>
        internal bool IsSetVaultType() => this.VaultType != null;
    }
}
