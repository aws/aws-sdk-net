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
    /// Contains metadata about a scan job, including information about the scanning process,
    /// results, and associated resources.
    /// </summary>
    public partial class ScanJob
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the scan job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultArn property is set.
        /// </summary>
        internal bool IsSetBackupVaultArn() => this.BackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time that a scan job is completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CompletionDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDate property is set.
        /// </summary>
        internal bool IsSetCompletionDate() => this.CompletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property ContinuousScanEndTime. 
        /// <para>
        /// The point in time the scan job scanned up to for a continuous backup.
        /// </para>
        /// </summary>
        public DateTime? ContinuousScanEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ContinuousScanEndTime property is set.
        /// </summary>
        internal bool IsSetContinuousScanEndTime() => this.ContinuousScanEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ContinuousScanStartTime. 
        /// <para>
        /// The point in time the scan job started scan from for a continuous backup.
        /// </para>
        /// </summary>
        public DateTime? ContinuousScanStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ContinuousScanStartTime property is set.
        /// </summary>
        internal bool IsSetContinuousScanStartTime() => this.ContinuousScanStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Contains identifying information about the creation of a scan job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScanJobCreator CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a scan job is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to create the scan job; for example, <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// The scanning engine used for the scan job. Currently only <c>GUARDDUTY</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MalwareScanner MalwareScanner { get; set; }

        /// <summary>
        /// Checks to see if the MalwareScanner property is set.
        /// </summary>
        internal bool IsSetMalwareScanner() => this.MalwareScanner != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies the recovery point being scanned; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPointArn() => this.RecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An ARN that uniquely identifies the source resource of the recovery point being scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The non-unique name of the resource that belongs to the specified backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource being scanned; for example, an Amazon Elastic
        /// Block Store (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS)
        /// database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScanResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ScanBaseRecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies the base recovery point for scanning. This field is
        /// populated when an incremental scan job has taken place.
        /// </para>
        /// </summary>
        public string ScanBaseRecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanBaseRecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetScanBaseRecoveryPointArn() => this.ScanBaseRecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property ScanId. 
        /// <para>
        /// The scan ID generated by the malware scanner for the corresponding scan job.
        /// </para>
        /// </summary>
        public string ScanId { get; set; }

        /// <summary>
        /// Checks to see if the ScanId property is set.
        /// </summary>
        internal bool IsSetScanId() => this.ScanId != null;

        /// <summary>
        /// Gets and sets the property ScanJobId. 
        /// <para>
        /// The unique identifier that identifies the scan job request to Backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanJobId { get; set; }

        /// <summary>
        /// Checks to see if the ScanJobId property is set.
        /// </summary>
        internal bool IsSetScanJobId() => this.ScanJobId != null;

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// Specifies the scan type use for the scan job.
        /// </para>
        ///  
        /// <para>
        /// Includes:
        /// </para>
        ///  
        /// <para>
        ///  <c>FULL_SCAN</c> will scan the entire data lineage within the backup.
        /// </para>
        ///  
        /// <para>
        ///  <c>INCREMENTAL_SCAN</c> will scan the data difference between the target recovery
        /// point and base recovery point ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScanMode ScanMode { get; set; }

        /// <summary>
        /// Checks to see if the ScanMode property is set.
        /// </summary>
        internal bool IsSetScanMode() => this.ScanMode != null;

        /// <summary>
        /// Gets and sets the property ScanResult. 
        /// <para>
        /// Contains the scan results information, including the status of threats found during
        /// scanning.
        /// </para>
        /// </summary>
        public ScanResultInfo ScanResult { get; set; }

        /// <summary>
        /// Checks to see if the ScanResult property is set.
        /// </summary>
        internal bool IsSetScanResult() => this.ScanResult != null;

        /// <summary>
        /// Gets and sets the property ScannerRoleArn. 
        /// <para>
        /// Specifies the scanner IAM role ARN used for the scan job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScannerRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ScannerRoleArn property is set.
        /// </summary>
        internal bool IsSetScannerRoleArn() => this.ScannerRoleArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the scan job.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>CREATED</c> | <c>RUNNING</c> | <c>COMPLETED</c> | <c>COMPLETED_WITH_ISSUES</c>
        /// | <c>FAILED</c> | <c>CANCELED</c>.
        /// </para>
        /// </summary>
        public ScanState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed message explaining the status of the scan job.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
