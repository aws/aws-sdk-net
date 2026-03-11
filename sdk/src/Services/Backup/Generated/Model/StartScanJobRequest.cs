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
    /// Container for the parameters to the StartScanJob operation.
    /// Starts scanning jobs for specific resources.
    /// </summary>
    public partial class StartScanJobRequest : AmazonBackupRequest
    {
        private string _backupVaultName;
        private string _iamRoleArn;
        private string _idempotencyToken;
        private MalwareScanner _malwareScanner;
        private string _recoveryPointArn;
        private string _scanBaseRecoveryPointArn;
        private ScanMode _scanMode;
        private string _scannerRoleArn;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>^[a-zA-Z0-9\-\_]{2,50}$</c> 
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to create the target recovery point; for example,
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
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <c>StartScanJob</c>. Retrying a successful request with the same idempotency
        /// token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// Specifies the malware scanner used during the scan job. Currently only supports <c>GUARDDUTY</c>.
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
        /// An Amazon Resource Name (ARN) that uniquely identifies a recovery point. This is your
        /// target recovery point for a full scan. If you are running an incremental scan, this
        /// will be your a recovery point which has been created after your base recovery point
        /// selection.
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
        /// Gets and sets the property ScanBaseRecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies the base recovery point to be used for incremental
        /// scanning.
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
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// Specifies the scan type use for the scan job.
        /// </para>
        ///  
        /// <para>
        /// Includes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FULL_SCAN</c> will scan the entire data lineage within the backup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCREMENTAL_SCAN</c> will scan the data difference between the target recovery
        /// point and base recovery point ARN.
        /// </para>
        ///  </li> </ul>
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
        /// Specified the IAM scanner role ARN.
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

    }
}