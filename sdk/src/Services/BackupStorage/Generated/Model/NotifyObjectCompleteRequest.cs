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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// Container for the parameters to the NotifyObjectComplete operation.
    /// Complete upload
    /// </summary>
    public partial class NotifyObjectCompleteRequest : AmazonBackupStorageRequest
    {
        private string _backupJobId;
        private Stream _metadataBlob;
        private string _metadataBlobChecksum;
        private DataChecksumAlgorithm _metadataBlobChecksumAlgorithm;
        private long? _metadataBlobLength;
        private string _metadataString;
        private string _objectChecksum;
        private SummaryChecksumAlgorithm _objectChecksumAlgorithm;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property BackupJobId. Backup job Id for the in-progress backup
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
        /// Gets and sets the property MetadataBlob. Optional metadata associated with an Object.
        /// Maximum length is 4MB.
        /// </summary>
        public Stream MetadataBlob
        {
            get { return this._metadataBlob; }
            set { this._metadataBlob = value; }
        }

        // Check to see if MetadataBlob property is set
        internal bool IsSetMetadataBlob()
        {
            return this._metadataBlob != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataBlobChecksum. Checksum of MetadataBlob.
        /// </summary>
        public string MetadataBlobChecksum
        {
            get { return this._metadataBlobChecksum; }
            set { this._metadataBlobChecksum = value; }
        }

        // Check to see if MetadataBlobChecksum property is set
        internal bool IsSetMetadataBlobChecksum()
        {
            return this._metadataBlobChecksum != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataBlobChecksumAlgorithm. Checksum algorithm.
        /// </summary>
        public DataChecksumAlgorithm MetadataBlobChecksumAlgorithm
        {
            get { return this._metadataBlobChecksumAlgorithm; }
            set { this._metadataBlobChecksumAlgorithm = value; }
        }

        // Check to see if MetadataBlobChecksumAlgorithm property is set
        internal bool IsSetMetadataBlobChecksumAlgorithm()
        {
            return this._metadataBlobChecksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataBlobLength. The size of MetadataBlob.
        /// </summary>
        public long MetadataBlobLength
        {
            get { return this._metadataBlobLength.GetValueOrDefault(); }
            set { this._metadataBlobLength = value; }
        }

        // Check to see if MetadataBlobLength property is set
        internal bool IsSetMetadataBlobLength()
        {
            return this._metadataBlobLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataString. Optional metadata associated with an Object.
        /// Maximum string length is 256 bytes.
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
        /// Gets and sets the property ObjectChecksum. Object checksum
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ObjectChecksumAlgorithm. Checksum algorithm
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UploadId. Upload Id for the in-progress upload
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