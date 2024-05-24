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
    /// This is the response object from the ListChunks operation.
    /// </summary>
    public partial class ListChunksResponse : AmazonWebServiceResponse
    {
        private List<Chunk> _chunkList = AWSConfigs.InitializeCollections ? new List<Chunk>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ChunkList. List of chunks
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Chunk> ChunkList
        {
            get { return this._chunkList; }
            set { this._chunkList = value; }
        }

        // Check to see if ChunkList property is set
        internal bool IsSetChunkList()
        {
            return this._chunkList != null && (this._chunkList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. Pagination token
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}