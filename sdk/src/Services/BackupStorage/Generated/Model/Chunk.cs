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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// Chunk
    /// </summary>
    public partial class Chunk
    {
        private string _checksum;
        private DataChecksumAlgorithm _checksumAlgorithm;
        private string _chunkToken;
        private long? _index;
        private long? _length;

        /// <summary>
        /// Gets and sets the property Checksum. Chunk checksum
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
        /// Gets and sets the property ChunkToken. Chunk token
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChunkToken
        {
            get { return this._chunkToken; }
            set { this._chunkToken = value; }
        }

        // Check to see if ChunkToken property is set
        internal bool IsSetChunkToken()
        {
            return this._chunkToken != null;
        }

        /// <summary>
        /// Gets and sets the property Index. Chunk index
        /// </summary>
        [AWSProperty(Required=true)]
        public long Index
        {
            get { return this._index.GetValueOrDefault(); }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Length. Chunk length
        /// </summary>
        [AWSProperty(Required=true)]
        public long Length
        {
            get { return this._length.GetValueOrDefault(); }
            set { this._length = value; }
        }

        // Check to see if Length property is set
        internal bool IsSetLength()
        {
            return this._length.HasValue; 
        }

    }
}