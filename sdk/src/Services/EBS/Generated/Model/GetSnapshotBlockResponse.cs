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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EBS.Model
{
    /// <summary>
    /// This is the response object from the GetSnapshotBlock operation.
    /// </summary>
    public partial class GetSnapshotBlockResponse : AmazonWebServiceResponse, IDisposable
    {
        private Stream _blockData;
        private string _checksum;
        private ChecksumAlgorithm _checksumAlgorithm;
        private int? _dataLength;

        /// <summary>
        /// Gets and sets the property BlockData. 
        /// <para>
        /// The data content of the block.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Stream BlockData
        {
            get { return this._blockData; }
            set { this._blockData = value; }
        }

        // Check to see if BlockData property is set
        internal bool IsSetBlockData()
        {
            return this._blockData != null;
        }

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum generated for the block, which is Base64 encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm used to generate the checksum for the block, such as SHA256.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public ChecksumAlgorithm ChecksumAlgorithm
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
        /// Gets and sets the property DataLength. 
        /// <para>
        /// The size of the data in the block.
        /// </para>
        /// </summary>
        public int DataLength
        {
            get { return this._dataLength.GetValueOrDefault(); }
            set { this._dataLength = value; }
        }

        // Check to see if DataLength property is set
        internal bool IsSetDataLength()
        {
            return this._dataLength.HasValue; 
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
                this._blockData?.Dispose();
                this._blockData = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}