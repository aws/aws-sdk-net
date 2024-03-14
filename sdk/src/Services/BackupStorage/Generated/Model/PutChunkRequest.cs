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
    /// Container for the parameters to the PutChunk operation.
    /// Upload chunk.
    /// </summary>
    public partial class PutChunkRequest : AmazonBackupStorageRequest
    {
        private string _backupJobId;
        private string _checksum;
        private DataChecksumAlgorithm _checksumAlgorithm;
        private long? _chunkIndex;
        private Stream _data;
        private long? _length;
        private string _uploadId;

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
        /// Gets and sets the property Checksum. Data checksum
        /// </summary>
        [AWSProperty(Required=true)]
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. Checksum algorithm
        /// </summary>
        [AWSProperty(Required=true)]
        public DataChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ChunkIndex. Describes this chunk's position relative to
        /// the other chunks
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ChunkIndex
        {
            get { return this._chunkIndex; }
            set { this._chunkIndex = value; }
        }

        // Check to see if ChunkIndex property is set
        internal bool IsSetChunkIndex()
        {
            return this._chunkIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Data. Data to be uploaded
        /// </summary>
        [AWSProperty(Required=true)]
        public Stream Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property Length. Data length
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        // Check to see if Length property is set
        internal bool IsSetLength()
        {
            return this._length.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadId. Upload Id for the in-progress upload.
        /// </summary>
        [AWSProperty(Required=true)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
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