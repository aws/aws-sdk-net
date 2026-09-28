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
    /// These are the items returned in the results of a search of Amazon S3 backup metadata.
    /// </summary>
    public partial class S3ResultItem
    {
        /// <summary>
        /// Gets and sets the property BackupResourceArn. 
        /// <para>
        /// These are items in the returned results that match recovery point Amazon Resource
        /// Names (ARN) input during a search of Amazon S3 backup metadata.
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
        /// These are one or more items in the returned results that match values for item creation
        /// time input during a search of Amazon S3 backup metadata.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// These are one or more items in the returned results that match values for ETags input
        /// during a search of Amazon S3 backup metadata.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property ObjectKey. 
        /// <para>
        /// This is one or more items returned in the results of a search of Amazon S3 backup
        /// metadata that match the values input for object key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// Checks to see if the ObjectKey property is set.
        /// </summary>
        internal bool IsSetObjectKey() => this.ObjectKey != null;

        /// <summary>
        /// Gets and sets the property ObjectSize. 
        /// <para>
        /// These are items in the returned results that match values for object size(s) input
        /// during a search of Amazon S3 backup metadata.
        /// </para>
        /// </summary>
        public long? ObjectSize { get; set; }

        /// <summary>
        /// Checks to see if the ObjectSize property is set.
        /// </summary>
        internal bool IsSetObjectSize() => this.ObjectSize.HasValue;

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// These are items in the returned results that match source Amazon Resource Names (ARN)
        /// input during a search of Amazon S3 backup metadata.
        /// </para>
        /// </summary>
        public string SourceResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceArn property is set.
        /// </summary>
        internal bool IsSetSourceResourceArn() => this.SourceResourceArn != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// These are one or more items in the returned results that match values for version
        /// IDs input during a search of Amazon S3 backup metadata.
        /// </para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
