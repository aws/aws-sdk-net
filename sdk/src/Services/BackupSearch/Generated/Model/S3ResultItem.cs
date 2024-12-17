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
    /// These are the items returned in the results of a search of Amazon S3 backup metadata.
    /// </summary>
    public partial class S3ResultItem
    {
        private string _backupResourceArn;
        private string _backupVaultName;
        private DateTime? _creationTime;
        private string _eTag;
        private string _objectKey;
        private long? _objectSize;
        private string _sourceResourceArn;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BackupResourceArn. 
        /// <para>
        /// These are items in the returned results that match recovery point Amazon Resource
        /// Names (ARN) input during a search of Amazon S3 backup metadata.
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
        /// These are one or more items in the returned results that match values for item creation
        /// time input during a search of Amazon S3 backup metadata.
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// These are one or more items in the returned results that match values for ETags input
        /// during a search of Amazon S3 backup metadata.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectKey. 
        /// <para>
        /// This is one or more items returned in the results of a search of Amazon S3 backup
        /// metadata that match the values input for object key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ObjectKey
        {
            get { return this._objectKey; }
            set { this._objectKey = value; }
        }

        // Check to see if ObjectKey property is set
        internal bool IsSetObjectKey()
        {
            return this._objectKey != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectSize. 
        /// <para>
        /// These are items in the returned results that match values for object size(s) input
        /// during a search of Amazon S3 backup metadata.
        /// </para>
        /// </summary>
        public long ObjectSize
        {
            get { return this._objectSize.GetValueOrDefault(); }
            set { this._objectSize = value; }
        }

        // Check to see if ObjectSize property is set
        internal bool IsSetObjectSize()
        {
            return this._objectSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// These are items in the returned results that match source Amazon Resource Names (ARN)
        /// input during a search of Amazon S3 backup metadata.
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// These are one or more items in the returned results that match values for version
        /// IDs input during a search of Amazon S3 backup metadata.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}