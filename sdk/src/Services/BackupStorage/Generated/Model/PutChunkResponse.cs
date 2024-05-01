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
    /// This is the response object from the PutChunk operation.
    /// </summary>
    public partial class PutChunkResponse : AmazonWebServiceResponse
    {
        private string _chunkChecksum;
        private DataChecksumAlgorithm _chunkChecksumAlgorithm;

        /// <summary>
        /// Gets and sets the property ChunkChecksum. Chunk checksum
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChunkChecksum
        {
            get { return this._chunkChecksum; }
            set { this._chunkChecksum = value; }
        }

        // Check to see if ChunkChecksum property is set
        internal bool IsSetChunkChecksum()
        {
            return this._chunkChecksum != null;
        }

        /// <summary>
        /// Gets and sets the property ChunkChecksumAlgorithm. Checksum algorithm
        /// </summary>
        [AWSProperty(Required=true)]
        public DataChecksumAlgorithm ChunkChecksumAlgorithm
        {
            get { return this._chunkChecksumAlgorithm; }
            set { this._chunkChecksumAlgorithm = value; }
        }

        // Check to see if ChunkChecksumAlgorithm property is set
        internal bool IsSetChunkChecksumAlgorithm()
        {
            return this._chunkChecksumAlgorithm != null;
        }

    }
}