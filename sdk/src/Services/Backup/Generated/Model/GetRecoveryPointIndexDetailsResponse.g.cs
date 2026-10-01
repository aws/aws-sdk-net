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
    /// This is the response object from the GetRecoveryPointIndexDetails operation.
    /// </summary>
    public partial class GetRecoveryPointIndexDetailsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An ARN that uniquely identifies the backup vault where the recovery point index is
        /// stored.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// </para>
        /// </summary>
        public string BackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultArn property is set.
        /// </summary>
        internal bool IsSetBackupVaultArn() => this.BackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property IndexCompletionDate. 
        /// <para>
        /// The date and time that a backup index finished creation, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? IndexCompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the IndexCompletionDate property is set.
        /// </summary>
        internal bool IsSetIndexCompletionDate() => this.IndexCompletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property IndexCreationDate. 
        /// <para>
        /// The date and time that a backup index was created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? IndexCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the IndexCreationDate property is set.
        /// </summary>
        internal bool IsSetIndexCreationDate() => this.IndexCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property IndexDeletionDate. 
        /// <para>
        /// The date and time that a backup index was deleted, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? IndexDeletionDate { get; set; }

        /// <summary>
        /// Checks to see if the IndexDeletionDate property is set.
        /// </summary>
        internal bool IsSetIndexDeletionDate() => this.IndexDeletionDate.HasValue;

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
        /// A detailed message explaining the status of a backup index associated with the recovery
        /// point.
        /// </para>
        /// </summary>
        public string IndexStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatusMessage property is set.
        /// </summary>
        internal bool IsSetIndexStatusMessage() => this.IndexStatusMessage != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        public string RecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPointArn() => this.RecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// A string of the Amazon Resource Name (ARN) that uniquely identifies the source resource.
        /// </para>
        /// </summary>
        public string SourceResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceArn property is set.
        /// </summary>
        internal bool IsSetSourceResourceArn() => this.SourceResourceArn != null;

        /// <summary>
        /// Gets and sets the property TotalItemsIndexed. 
        /// <para>
        /// Count of items within the backup index associated with the recovery point.
        /// </para>
        /// </summary>
        public long? TotalItemsIndexed { get; set; }

        /// <summary>
        /// Checks to see if the TotalItemsIndexed property is set.
        /// </summary>
        internal bool IsSetTotalItemsIndexed() => this.TotalItemsIndexed.HasValue;
    }
}
