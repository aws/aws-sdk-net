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
    /// This is the response object from the GetRecoveryPointIndexDetails operation.
    /// </summary>
    public partial class GetRecoveryPointIndexDetailsResponse : AmazonWebServiceResponse
    {
        private string _backupVaultArn;
        private DateTime? _indexCompletionDate;
        private DateTime? _indexCreationDate;
        private DateTime? _indexDeletionDate;
        private IndexStatus _indexStatus;
        private string _indexStatusMessage;
        private string _recoveryPointArn;
        private string _sourceResourceArn;
        private long? _totalItemsIndexed;

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
        /// Gets and sets the property IndexCompletionDate. 
        /// <para>
        /// The date and time that a backup index finished creation, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime IndexCompletionDate
        {
            get { return this._indexCompletionDate.GetValueOrDefault(); }
            set { this._indexCompletionDate = value; }
        }

        // Check to see if IndexCompletionDate property is set
        internal bool IsSetIndexCompletionDate()
        {
            return this._indexCompletionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IndexCreationDate. 
        /// <para>
        /// The date and time that a backup index was created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime IndexCreationDate
        {
            get { return this._indexCreationDate.GetValueOrDefault(); }
            set { this._indexCreationDate = value; }
        }

        // Check to see if IndexCreationDate property is set
        internal bool IsSetIndexCreationDate()
        {
            return this._indexCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IndexDeletionDate. 
        /// <para>
        /// The date and time that a backup index was deleted, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime IndexDeletionDate
        {
            get { return this._indexDeletionDate.GetValueOrDefault(); }
            set { this._indexDeletionDate = value; }
        }

        // Check to see if IndexDeletionDate property is set
        internal bool IsSetIndexDeletionDate()
        {
            return this._indexDeletionDate.HasValue; 
        }

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
        public IndexStatus IndexStatus
        {
            get { return this._indexStatus; }
            set { this._indexStatus = value; }
        }

        // Check to see if IndexStatus property is set
        internal bool IsSetIndexStatus()
        {
            return this._indexStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IndexStatusMessage. 
        /// <para>
        /// A detailed message explaining the status of a backup index associated with the recovery
        /// point.
        /// </para>
        /// </summary>
        public string IndexStatusMessage
        {
            get { return this._indexStatusMessage; }
            set { this._indexStatusMessage = value; }
        }

        // Check to see if IndexStatusMessage property is set
        internal bool IsSetIndexStatusMessage()
        {
            return this._indexStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// A string of the Amazon Resource Name (ARN) that uniquely identifies the source resource.
        /// </para>
        /// </summary>
        public string SourceResourceArn
        {
            get { return this._sourceResourceArn; }
            set { this._sourceResourceArn = value; }
        }

        // Check to see if SourceResourceArn property is set
        internal bool IsSetSourceResourceArn()
        {
            return this._sourceResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TotalItemsIndexed. 
        /// <para>
        /// Count of items within the backup index associated with the recovery point.
        /// </para>
        /// </summary>
        public long TotalItemsIndexed
        {
            get { return this._totalItemsIndexed.GetValueOrDefault(); }
            set { this._totalItemsIndexed = value; }
        }

        // Check to see if TotalItemsIndexed property is set
        internal bool IsSetTotalItemsIndexed()
        {
            return this._totalItemsIndexed.HasValue; 
        }

    }
}