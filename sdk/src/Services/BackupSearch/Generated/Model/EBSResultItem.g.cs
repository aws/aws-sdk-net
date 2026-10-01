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

namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// These are the items returned in the results of a search of Amazon EBS backup metadata.
    /// </summary>
    public partial class EBSResultItem
    {
        /// <summary>
        /// Gets and sets the property BackupResourceArn. 
        /// <para>
        /// These are one or more items in the results that match values for the Amazon Resource
        /// Name (ARN) of recovery points returned in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public string BackupResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupResourceArn property is set.
        /// </summary>
        internal bool IsSetBackupResourceArn() => this.BackupResourceArn != null;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the backup vault.
        /// </para>
        /// </summary>
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// These are one or more items in the results that match values for creation times returned
        /// in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// These are one or more items in the results that match values for file paths returned
        /// in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// These are one or more items in the results that match values for file sizes returned
        /// in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public long? FileSize { get; set; }

        /// <summary>
        /// Checks to see if the FileSize property is set.
        /// </summary>
        internal bool IsSetFileSize() => this.FileSize.HasValue;

        /// <summary>
        /// Gets and sets the property FileSystemIdentifier. 
        /// <para>
        /// These are one or more items in the results that match values for file systems returned
        /// in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public string FileSystemIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemIdentifier property is set.
        /// </summary>
        internal bool IsSetFileSystemIdentifier() => this.FileSystemIdentifier != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// These are one or more items in the results that match values for Last Modified Time
        /// returned in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// These are one or more items in the results that match values for the Amazon Resource
        /// Name (ARN) of source resources returned in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public string SourceResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceArn property is set.
        /// </summary>
        internal bool IsSetSourceResourceArn() => this.SourceResourceArn != null;
    }
}
