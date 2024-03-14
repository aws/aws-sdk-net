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

namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// This is the response object from the GetObjectMetadata operation.
    /// </summary>
    public partial class GetObjectMetadataResponse : AmazonWebServiceResponse, IDisposable
    {
        private Stream _metadataBlob;
        private string _metadataBlobChecksum;
        private DataChecksumAlgorithm _metadataBlobChecksumAlgorithm;
        private long? _metadataBlobLength;
        private string _metadataString;

        /// <summary>
        /// Gets and sets the property MetadataBlob. Metadata blob.
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
        /// Gets and sets the property MetadataBlobChecksum. MetadataBlob checksum.
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
        public long? MetadataBlobLength
        {
            get { return this._metadataBlobLength; }
            set { this._metadataBlobLength = value; }
        }

        // Check to see if MetadataBlobLength property is set
        internal bool IsSetMetadataBlobLength()
        {
            return this._metadataBlobLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataString. Metadata string.
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

        #region Dispose Pattern

        private bool _disposed;

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                this._metadataBlob?.Dispose();
                this._metadataBlob = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}