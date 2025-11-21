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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
    /// This is the response object from the DescribeScanJob operation.
    /// </summary>
    public partial class DescribeScanJobResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private string _backupVaultArn;
        private string _backupVaultName;
        private DateTime? _completionDate;
        private ScanJobCreator _createdBy;
        private DateTime? _creationDate;
        private string _iamRoleArn;
        private MalwareScanner _malwareScanner;
        private string _recoveryPointArn;
        private string _resourceArn;
        private string _resourceName;
        private ScanResourceType _resourceType;
        private string _scanBaseRecoveryPointArn;
        private string _scanId;
        private string _scanJobId;
        private ScanMode _scanMode;
        private string _scannerRoleArn;
        private ScanResultInfo _scanResult;
        private ScanState _state;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Returns the account ID that owns the scan job.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>^[0-9]{12}$</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupVaultArn
        {
            get { return this._backupVaultArn; }
            set { this._backupVaultArn = value; }
        }

        // Check to see if BackupVaultArn property is set
        internal bool IsSetBackupVaultArn()
        {
            return this._backupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>^[a-zA-Z0-9\-\_\.]{2,50}$</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupVaultName
        {
            get { return this._backupVaultName; }
            set { this._backupVaultName = value; }
        }

        // Check to see if BackupVaultName property is set
        internal bool IsSetBackupVaultName()
        {
            return this._backupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time that a backup index finished creation, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CompletionDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate
        {
            get { return this._completionDate; }
            set { this._completionDate = value; }
        }

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this._completionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanJobCreator CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a backup index finished creation, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault; for example,
        /// <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// The scanning engine used for the corresponding scan job. Currently only <c>GUARDUTY</c>
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MalwareScanner MalwareScanner
        {
            get { return this._malwareScanner; }
            set { this._malwareScanner = value; }
        }

        // Check to see if MalwareScanner property is set
        internal bool IsSetMalwareScanner()
        {
            return this._malwareScanner != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies the target recovery point for scanning.; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecoveryPointArn
        {
            get { return this._recoveryPointArn; }
            set { this._recoveryPointArn = value; }
        }

        // Check to see if RecoveryPointArn property is set
        internal bool IsSetRecoveryPointArn()
        {
            return this._recoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An ARN that uniquely identifies the source resource of the corresponding recovery
        /// point ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The non-unique name of the resource that belongs to the specified backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services Resource to be backed up; for example, an Amazon Elastic
        /// Block Store (Amazon EBS) volume.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>^[a-zA-Z0-9\-\_\.]{1,50}$</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ScanBaseRecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies the base recovery point for scanning. This field will
        /// only be populated when an incremental scan job has taken place.
        /// </para>
        /// </summary>
        public string ScanBaseRecoveryPointArn
        {
            get { return this._scanBaseRecoveryPointArn; }
            set { this._scanBaseRecoveryPointArn = value; }
        }

        // Check to see if ScanBaseRecoveryPointArn property is set
        internal bool IsSetScanBaseRecoveryPointArn()
        {
            return this._scanBaseRecoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScanId. 
        /// <para>
        /// The scan ID generated by Amazon GuardDuty for the corresponding Scan Job ID request
        /// from Backup.
        /// </para>
        /// </summary>
        public string ScanId
        {
            get { return this._scanId; }
            set { this._scanId = value; }
        }

        // Check to see if ScanId property is set
        internal bool IsSetScanId()
        {
            return this._scanId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanJobId. 
        /// <para>
        /// The scan job ID that uniquely identified the request to Backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanJobId
        {
            get { return this._scanJobId; }
            set { this._scanJobId = value; }
        }

        // Check to see if ScanJobId property is set
        internal bool IsSetScanJobId()
        {
            return this._scanJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// Specifies the scan type used for the scan job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanMode ScanMode
        {
            get { return this._scanMode; }
            set { this._scanMode = value; }
        }

        // Check to see if ScanMode property is set
        internal bool IsSetScanMode()
        {
            return this._scanMode != null;
        }

        /// <summary>
        /// Gets and sets the property ScannerRoleArn. 
        /// <para>
        /// Specifies the scanner IAM role ARN used to for the scan job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScannerRoleArn
        {
            get { return this._scannerRoleArn; }
            set { this._scannerRoleArn = value; }
        }

        // Check to see if ScannerRoleArn property is set
        internal bool IsSetScannerRoleArn()
        {
            return this._scannerRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScanResult. 
        /// <para>
        ///  Contains the <c>ScanResultsStatus</c> for the scanning job and returns <c>THREATS_FOUND</c>
        /// or <c>NO_THREATS_FOUND</c> for completed jobs.
        /// </para>
        /// </summary>
        public ScanResultInfo ScanResult
        {
            get { return this._scanResult; }
            set { this._scanResult = value; }
        }

        // Check to see if ScanResult property is set
        internal bool IsSetScanResult()
        {
            return this._scanResult != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of a scan job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed message explaining the status of the job to back up a resource.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}