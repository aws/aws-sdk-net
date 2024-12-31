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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
        private string _backupResourceArn;
        private string _backupVaultName;
        private DateTime? _creationTime;
        private string _filePath;
        private long? _fileSize;
        private string _fileSystemIdentifier;
        private DateTime? _lastModifiedTime;
        private string _sourceResourceArn;

        /// <summary>
        /// Gets and sets the property BackupResourceArn. 
        /// <para>
        /// These are one or more items in the results that match values for the Amazon Resource
        /// Name (ARN) of recovery points returned in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public string BackupResourceArn
        {
            get { return this._backupResourceArn; }
            set { this._backupResourceArn = value; }
        }

        // Check to see if BackupResourceArn property is set
        internal bool IsSetBackupResourceArn()
        {
            return this._backupResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the backup vault.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// These are one or more items in the results that match values for creation times returned
        /// in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// These are one or more items in the results that match values for file paths returned
        /// in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// These are one or more items in the results that match values for file sizes returned
        /// in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public long FileSize
        {
            get { return this._fileSize.GetValueOrDefault(); }
            set { this._fileSize = value; }
        }

        // Check to see if FileSize property is set
        internal bool IsSetFileSize()
        {
            return this._fileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileSystemIdentifier. 
        /// <para>
        /// These are one or more items in the results that match values for file systems returned
        /// in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public string FileSystemIdentifier
        {
            get { return this._fileSystemIdentifier; }
            set { this._fileSystemIdentifier = value; }
        }

        // Check to see if FileSystemIdentifier property is set
        internal bool IsSetFileSystemIdentifier()
        {
            return this._fileSystemIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// These are one or more items in the results that match values for Last Modified Time
        /// returned in a search of Amazon EBS backup metadata.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// These are one or more items in the results that match values for the Amazon Resource
        /// Name (ARN) of source resources returned in a search of Amazon EBS backup metadata.
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

    }
}