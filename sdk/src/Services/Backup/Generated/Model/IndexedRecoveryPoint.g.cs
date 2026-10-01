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
    /// This is a recovery point that has an associated backup index.
    /// 
    ///  
    /// <para>
    /// Only recovery points with a backup index can be included in a search.
    /// </para>
    /// </summary>
    public partial class IndexedRecoveryPoint
    {
        /// <summary>
        /// Gets and sets the property BackupCreationDate. 
        /// <para>
        /// The date and time that a backup was created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? BackupCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the BackupCreationDate property is set.
        /// </summary>
        internal bool IsSetBackupCreationDate() => this.BackupCreationDate.HasValue;

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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// This specifies the IAM role ARN used for this operation.
        /// </para>
        ///  
        /// <para>
        /// For example, arn:aws:iam::123456789012:role/S3Access
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

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
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>
        /// 
        /// </para>
        /// </summary>
        public string RecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPointArn() => this.RecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type of the indexed recovery point.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EBS</c> for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> for Amazon Simple Storage Service (Amazon S3)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

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
    }
}
