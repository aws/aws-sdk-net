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
    /// This is the response object from the ListSnapshotBlocks operation.
    /// </summary>
    public partial class ListSnapshotBlocksResponse : AmazonWebServiceResponse
    {
        private List<Block> _blocks = new List<Block>();
        private int? _blockSize;
        private DateTime? _expiryTime;
        private string _nextToken;
        private long? _volumeSize;

        /// <summary>
        /// Gets and sets the property Blocks. 
        /// <para>
        /// An array of objects containing information about the blocks.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<Block> Blocks
        {
            get { return this._blocks; }
            set { this._blocks = value; }
        }

        // Check to see if Blocks property is set
        internal bool IsSetBlocks()
        {
            return this._blocks != null && this._blocks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BlockSize. 
        /// <para>
        /// The size of the blocks in the snapshot, in bytes.
        /// </para>
        /// </summary>
        public int BlockSize
        {
            get { return this._blockSize.GetValueOrDefault(); }
            set { this._blockSize = value; }
        }

        // Check to see if BlockSize property is set
        internal bool IsSetBlockSize()
        {
            return this._blockSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// The time when the <code>BlockToken</code> expires.
        /// </para>
        /// </summary>
        public DateTime ExpiryTime
        {
            get { return this._expiryTime.GetValueOrDefault(); }
            set { this._expiryTime = value; }
        }

        // Check to see if ExpiryTime property is set
        internal bool IsSetExpiryTime()
        {
            return this._expiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is null when there
        /// are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume in GB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long VolumeSize
        {
            get { return this._volumeSize.GetValueOrDefault(); }
            set { this._volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this._volumeSize.HasValue; 
        }

    }
}