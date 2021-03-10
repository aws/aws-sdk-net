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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the StartCopyJob operation.
    /// Starts a job to create a one-time copy of the specified resource.
    /// 
    ///  
    /// <para>
    /// Does not support continuous backups.
    /// </para>
    /// </summary>
    public partial class StartCopyJobRequest : AmazonBackupRequest
    {
        private string _destinationBackupVaultArn;
        private string _iamRoleArn;
        private string _idempotencyToken;
        private Lifecycle _lifecycle;
        private string _recoveryPointArn;
        private string _sourceBackupVaultName;

        /// <summary>
        /// Gets and sets the property DestinationBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a destination backup vault
        /// to copy to; for example, <code>arn:aws:backup:us-east-1:123456789012:vault:aBackupVault</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationBackupVaultArn
        {
            get { return this._destinationBackupVaultArn; }
            set { this._destinationBackupVaultArn = value; }
        }

        // Check to see if DestinationBackupVaultArn property is set
        internal bool IsSetDestinationBackupVaultArn()
        {
            return this._destinationBackupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to copy the target recovery point; for example, <code>arn:aws:iam::123456789012:role/S3Access</code>.
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
        /// A customer chosen string that can be used to distinguish between calls to <code>StartCopyJob</code>.
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
        /// Gets and sets the property Lifecycle.
        /// </summary>
        public Lifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point to use for the copy job; for example,
        /// arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45.
        /// 
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
        /// Gets and sets the property SourceBackupVaultName. 
        /// <para>
        /// The name of a logical source container where backups are stored. Backup vaults are
        /// identified by names that are unique to the account used to create them and the AWS
        /// Region where they are created. They consist of lowercase letters, numbers, and hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceBackupVaultName
        {
            get { return this._sourceBackupVaultName; }
            set { this._sourceBackupVaultName = value; }
        }

        // Check to see if SourceBackupVaultName property is set
        internal bool IsSetSourceBackupVaultName()
        {
            return this._sourceBackupVaultName != null;
        }

    }
}