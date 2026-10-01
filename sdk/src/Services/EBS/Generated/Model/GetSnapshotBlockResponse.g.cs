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

namespace Amazon.EBS.Model
{
    /// <summary>
    /// This is the response object from the GetSnapshotBlock operation.
    /// </summary>
    public partial class GetSnapshotBlockResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property BlockData. 
        /// <para>
        /// The data content of the block.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Stream BlockData { get; set; }

        /// <summary>
        /// Checks to see if the BlockData property is set.
        /// </summary>
        internal bool IsSetBlockData() => this.BlockData != null;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum generated for the block, which is Base64 encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm used to generate the checksum for the block, such as SHA256.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public ChecksumAlgorithm ChecksumAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the ChecksumAlgorithm property is set.
        /// </summary>
        internal bool IsSetChecksumAlgorithm() => this.ChecksumAlgorithm != null;

        /// <summary>
        /// Gets and sets the property DataLength. 
        /// <para>
        /// The size of the data in the block.
        /// </para>
        /// </summary>
        public int? DataLength { get; set; }

        /// <summary>
        /// Checks to see if the DataLength property is set.
        /// </summary>
        internal bool IsSetDataLength() => this.DataLength.HasValue;

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

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                this.BlockData?.Dispose();
                this.BlockData = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
