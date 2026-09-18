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
    /// Contains detailed information about the recovery points stored in an Backup backup
    /// vault. A backup, or recovery point, represents the content of a resource at a specified
    /// time.
    /// </summary>
    public partial class AwsBackupRecoveryPointDetails
    {
        /// <summary>
        /// Gets and sets the property BackupSizeInBytes. 
        /// <para>
        /// The size, in bytes, of a backup. 
        /// </para>
        /// </summary>
        public long? BackupSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackupSizeInBytes property is set.
        /// </summary>
        internal bool IsSetBackupSizeInBytes() => this.BackupSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault. 
        /// </para>
        /// </summary>
        public string BackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultArn property is set.
        /// </summary>
        internal bool IsSetBackupVaultArn() => this.BackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the Amazon Web Services account used to create them and
        /// the Amazon Web Services Region where they are created. They consist of lowercase letters,
        /// numbers, and hyphens. 
        /// </para>
        /// </summary>
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property CalculatedLifecycle. 
        /// <para>
        /// A <c>CalculatedLifecycle</c> object containing <c>DeleteAt</c> and <c>MoveToColdStorageAt</c>
        /// timestamps. 
        /// </para>
        /// </summary>
        public AwsBackupRecoveryPointCalculatedLifecycleDetails CalculatedLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the CalculatedLifecycle property is set.
        /// </summary>
        internal bool IsSetCalculatedLifecycle() => this.CalculatedLifecycle != null;

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time that a job to create a recovery point is completed, in Unix format
        /// and UTC. The value of <c>CompletionDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM. 
        /// </para>
        /// </summary>
        public string CompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDate property is set.
        /// </summary>
        internal bool IsSetCompletionDate() => this.CompletionDate != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Contains identifying information about the creation of a recovery point, including
        /// the <c>BackupPlanArn</c>, <c>BackupPlanId</c>, <c>BackupPlanVersion</c>, and <c>BackupRuleId</c>
        /// of the backup plan that is used to create it. 
        /// </para>
        /// </summary>
        public AwsBackupRecoveryPointCreatedByDetails CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time a recovery point is created, in Unix format and UTC. The value of
        /// <c>CreationDate</c> is accurate to milliseconds. For example, the value 1516925490.087
        /// represents Friday, January 26, 2018 12:11:30.087 AM. 
        /// </para>
        /// </summary>
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN for the server-side encryption key that is used to protect your backups. 
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to create the target recovery point 
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property IsEncrypted. 
        /// <para>
        /// A Boolean value that is returned as <c>TRUE</c> if the specified recovery point is
        /// encrypted, or <c>FALSE</c> if the recovery point is not encrypted. 
        /// </para>
        /// </summary>
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the IsEncrypted property is set.
        /// </summary>
        internal bool IsSetIsEncrypted() => this.IsEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property LastRestoreTime. 
        /// <para>
        /// The date and time that a recovery point was last restored, in Unix format and UTC.
        /// The value of <c>LastRestoreTime</c> is accurate to milliseconds. For example, the
        /// value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM. 
        /// </para>
        /// </summary>
        public string LastRestoreTime { get; set; }

        /// <summary>
        /// Checks to see if the LastRestoreTime property is set.
        /// </summary>
        internal bool IsSetLastRestoreTime() => this.LastRestoreTime != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. Backup transitions and expires backups automatically according to
        /// the lifecycle that you define 
        /// </para>
        /// </summary>
        public AwsBackupRecoveryPointLifecycleDetails Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point. 
        /// </para>
        /// </summary>
        public string RecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPointArn() => this.RecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An ARN that uniquely identifies a resource. The format of the ARN depends on the resource
        /// type. 
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource saved as a recovery point, such as an Amazon
        /// EBS volume or an Amazon RDS database. 
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceBackupVaultArn. 
        /// <para>
        /// The ARN for the backup vault where the recovery point was originally copied from.
        /// If the recovery point is restored to the same account, this value will be null. 
        /// </para>
        /// </summary>
        public string SourceBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetSourceBackupVaultArn() => this.SourceBackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code specifying the state of the recovery point. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIAL</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining the reason of the recovery point deletion failure. 
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Specifies the storage class of the recovery point. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COLD</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARM</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;
    }
}
