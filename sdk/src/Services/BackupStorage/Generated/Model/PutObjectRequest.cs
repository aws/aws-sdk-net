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
 * Do not modify this file. This file is generated from the backupstorage-2018-04-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// Container for the parameters to the PutObject operation.
    /// Upload object that can store object metadata String and data blob in single API call
    /// using inline chunk field.
    /// </summary>
    public partial class PutObjectRequest : AmazonBackupStorageRequest
    {
        private string _backupJobId;
        private Stream _inlineChunk;
        private string _inlineChunkChecksum;
        private string _inlineChunkChecksumAlgorithm;
        private long? _inlineChunkLength;
        private string _metadataString;
        private string _objectChecksum;
        private SummaryChecksumAlgorithm _objectChecksumAlgorithm;
        private string _objectName;
        private bool? _throwOnDuplicate;

        /// <summary>
        /// Gets and sets the property BackupJobId. Backup job Id for the in-progress backup.
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupJobId
        {
            get { return this._backupJobId; }
            set { this._backupJobId = value; }
        }

        // Check to see if BackupJobId property is set
        internal bool IsSetBackupJobId()
        {
            return this._backupJobId != null;
        }

        /// <summary>
        /// Gets and sets the property InlineChunk. Inline chunk data to be uploaded.
        /// </summary>
        public Stream InlineChunk
        {
            get { return this._inlineChunk; }
            set { this._inlineChunk = value; }
        }

        // Check to see if InlineChunk property is set
        internal bool IsSetInlineChunk()
        {
            return this._inlineChunk != null;
        }

        /// <summary>
        /// Gets and sets the property InlineChunkChecksum. Inline chunk checksum
        /// </summary>
        public string InlineChunkChecksum
        {
            get { return this._inlineChunkChecksum; }
            set { this._inlineChunkChecksum = value; }
        }

        // Check to see if InlineChunkChecksum property is set
        internal bool IsSetInlineChunkChecksum()
        {
            return this._inlineChunkChecksum != null;
        }

        /// <summary>
        /// Gets and sets the property InlineChunkChecksumAlgorithm. Inline chunk checksum algorithm
        /// </summary>
        public string InlineChunkChecksumAlgorithm
        {
            get { return this._inlineChunkChecksumAlgorithm; }
            set { this._inlineChunkChecksumAlgorithm = value; }
        }

        // Check to see if InlineChunkChecksumAlgorithm property is set
        internal bool IsSetInlineChunkChecksumAlgorithm()
        {
            return this._inlineChunkChecksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property InlineChunkLength. Length of the inline chunk data.
        /// </summary>
        public long? InlineChunkLength
        {
            get { return this._inlineChunkLength; }
            set { this._inlineChunkLength = value; }
        }

        // Check to see if InlineChunkLength property is set
        internal bool IsSetInlineChunkLength()
        {
            return this._inlineChunkLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataString. Store user defined metadata like backup
        /// checksum, disk ids, restore metadata etc.
        /// </summary>
        public string MetadataString
        {
            get { return this._metadataString; }
            set { this._metadataString = value; }
        }

        // Check to see if MetadataString property is set
        internal bool IsSetMetadataString()
        {
            return this._metadataString != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectChecksum. object checksum
        /// </summary>
        public string ObjectChecksum
        {
            get { return this._objectChecksum; }
            set { this._objectChecksum = value; }
        }

        // Check to see if ObjectChecksum property is set
        internal bool IsSetObjectChecksum()
        {
            return this._objectChecksum != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectChecksumAlgorithm. object checksum algorithm
        /// </summary>
        public SummaryChecksumAlgorithm ObjectChecksumAlgorithm
        {
            get { return this._objectChecksumAlgorithm; }
            set { this._objectChecksumAlgorithm = value; }
        }

        // Check to see if ObjectChecksumAlgorithm property is set
        internal bool IsSetObjectChecksumAlgorithm()
        {
            return this._objectChecksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectName. The name of the Object to be uploaded.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectName
        {
            get { return this._objectName; }
            set { this._objectName = value; }
        }

        // Check to see if ObjectName property is set
        internal bool IsSetObjectName()
        {
            return this._objectName != null;
        }

        /// <summary>
        /// Gets and sets the property ThrowOnDuplicate. Throw an exception if Object name is
        /// already exist.
        /// </summary>
        public bool? ThrowOnDuplicate
        {
            get { return this._throwOnDuplicate; }
            set { this._throwOnDuplicate = value; }
        }

        // Check to see if ThrowOnDuplicate property is set
        internal bool IsSetThrowOnDuplicate()
        {
            return this._throwOnDuplicate.HasValue; 
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer(false);
        }
    }
}