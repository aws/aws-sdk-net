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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// A uniquely identified group of data records in a Kinesis data stream.
    /// </summary>
    public partial class Shard
    {
        private string _adjacentParentShardId;
        private HashKeyRange _hashKeyRange;
        private string _parentShardId;
        private SequenceNumberRange _sequenceNumberRange;
        private string _shardId;

        /// <summary>
        /// Gets and sets the property AdjacentParentShardId. 
        /// <para>
        /// The shard ID of the shard adjacent to the shard's parent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AdjacentParentShardId
        {
            get { return this._adjacentParentShardId; }
            set { this._adjacentParentShardId = value; }
        }

        // Check to see if AdjacentParentShardId property is set
        internal bool IsSetAdjacentParentShardId()
        {
            return this._adjacentParentShardId != null;
        }

        /// <summary>
        /// Gets and sets the property HashKeyRange. 
        /// <para>
        /// The range of possible hash key values for the shard, which is a set of ordered contiguous
        /// positive integers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HashKeyRange HashKeyRange
        {
            get { return this._hashKeyRange; }
            set { this._hashKeyRange = value; }
        }

        // Check to see if HashKeyRange property is set
        internal bool IsSetHashKeyRange()
        {
            return this._hashKeyRange != null;
        }

        /// <summary>
        /// Gets and sets the property ParentShardId. 
        /// <para>
        /// The shard ID of the shard's parent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ParentShardId
        {
            get { return this._parentShardId; }
            set { this._parentShardId = value; }
        }

        // Check to see if ParentShardId property is set
        internal bool IsSetParentShardId()
        {
            return this._parentShardId != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceNumberRange. 
        /// <para>
        /// The range of possible sequence numbers for the shard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SequenceNumberRange SequenceNumberRange
        {
            get { return this._sequenceNumberRange; }
            set { this._sequenceNumberRange = value; }
        }

        // Check to see if SequenceNumberRange property is set
        internal bool IsSetSequenceNumberRange()
        {
            return this._sequenceNumberRange != null;
        }

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The unique identifier of the shard within the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ShardId
        {
            get { return this._shardId; }
            set { this._shardId = value; }
        }

        // Check to see if ShardId property is set
        internal bool IsSetShardId()
        {
            return this._shardId != null;
        }

    }
}