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
    /// This is the response object from the UpdateRecoveryPointLifecycle operation.
    /// </summary>
    public partial class UpdateRecoveryPointLifecycleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An ARN that uniquely identifies a backup vault; for example, <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// </para>
        /// </summary>
        public string BackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultArn property is set.
        /// </summary>
        internal bool IsSetBackupVaultArn() => this.BackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property CalculatedLifecycle. 
        /// <para>
        /// A <c>CalculatedLifecycle</c> object containing <c>DeleteAt</c> and <c>MoveToColdStorageAt</c>
        /// timestamps.
        /// </para>
        /// </summary>
        public CalculatedLifecycle CalculatedLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the CalculatedLifecycle property is set.
        /// </summary>
        internal bool IsSetCalculatedLifecycle() => this.CalculatedLifecycle != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. Backup transitions and expires backups automatically according to
        /// the lifecycle that you define.
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “retention” setting must be 90 days greater than the “transition
        /// to cold after days” setting. The “transition to cold after days” setting cannot be
        /// changed after a backup has been transitioned to cold.
        /// </para>
        ///  
        /// <para>
        /// Resource types that can transition to cold storage are listed in the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
        /// availability by resource</a> table. Backup ignores this expression for other resource
        /// types.
        /// </para>
        /// </summary>
        public Lifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

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
    }
}
