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
    /// Container for the parameters to the StartCopyJob operation. Starts a job to create
    /// a one-time copy of the specified resource. <para> Does not support continuous backups.
    /// </para> <para> See <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/recov-point-create-a-copy.html#backup-copy-retry">Copy
    /// job retry</a> for information on how Backup retries copy job operations. </para>
    /// </summary>
    public partial class StartCopyJobRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a destination backup vault
        /// to copy to; for example, <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetDestinationBackupVaultArn() => this.DestinationBackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to copy the target recovery point; for example, <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <c>StartCopyJob</c>. Retrying a successful request with the same idempotency
        /// token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property Lifecycle.
        /// </summary>
        public Lifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point to use for the copy job; for example,
        /// arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPointArn() => this.RecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property SourceBackupVaultName. 
        /// <para>
        /// The name of a logical source container where backups are stored. Backup vaults are
        /// identified by names that are unique to the account used to create them and the Amazon
        /// Web Services Region where they are created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceBackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupVaultName property is set.
        /// </summary>
        internal bool IsSetSourceBackupVaultName() => this.SourceBackupVaultName != null;
    }
}
