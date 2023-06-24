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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the MergeShards operation.
    /// Merges two adjacent shards in a Kinesis data stream and combines them into a single
    /// shard to reduce the stream's capacity to ingest and transport data. This API is only
    /// supported for the data streams with the provisioned capacity mode. Two shards are
    /// considered adjacent if the union of the hash key ranges for the two shards form a
    /// contiguous set with no gaps. For example, if you have two shards, one with a hash
    /// key range of 276...381 and the other with a hash key range of 382...454, then you
    /// could merge these two shards into a single shard that would have a hash key range
    /// of 276...454. After the merge, the single child shard receives data for all hash key
    /// values covered by the two parent shards.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, it is recommended you use the <code>StreamARN</code> input
    /// parameter rather than the <code>StreamName</code> input parameter.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <code>MergeShards</code> is called when there is a need to reduce the overall capacity
    /// of a stream because of excess capacity that is not being used. You must specify the
    /// shard to be merged and the adjacent shard for a stream. For more information about
    /// merging shards, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-merge.html">Merge
    /// Two Shards</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the stream is in the <code>ACTIVE</code> state, you can call <code>MergeShards</code>.
    /// If a stream is in the <code>CREATING</code>, <code>UPDATING</code>, or <code>DELETING</code>
    /// state, <code>MergeShards</code> returns a <code>ResourceInUseException</code>. If
    /// the specified stream does not exist, <code>MergeShards</code> returns a <code>ResourceNotFoundException</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can use <a>DescribeStreamSummary</a> to check the state of the stream, which is
    /// returned in <code>StreamStatus</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>MergeShards</code> is an asynchronous operation. Upon receiving a <code>MergeShards</code>
    /// request, Amazon Kinesis Data Streams immediately returns a response and sets the <code>StreamStatus</code>
    /// to <code>UPDATING</code>. After the operation is completed, Kinesis Data Streams sets
    /// the <code>StreamStatus</code> to <code>ACTIVE</code>. Read and write operations continue
    /// to work while the stream is in the <code>UPDATING</code> state. 
    /// </para>
    ///  
    /// <para>
    /// You use <a>DescribeStreamSummary</a> and the <a>ListShards</a> APIs to determine the
    /// shard IDs that are specified in the <code>MergeShards</code> request. 
    /// </para>
    ///  
    /// <para>
    /// If you try to operate on too many streams in parallel using <a>CreateStream</a>, <a>DeleteStream</a>,
    /// <code>MergeShards</code>, or <a>SplitShard</a>, you receive a <code>LimitExceededException</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <code>MergeShards</code> has a limit of five transactions per second per account.
    /// </para>
    /// </summary>
    public partial class MergeShardsRequest : AmazonKinesisRequest
    {
        private string _adjacentShardToMerge;
        private string _shardToMerge;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property AdjacentShardToMerge. 
        /// <para>
        /// The shard ID of the adjacent shard for the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AdjacentShardToMerge
        {
            get { return this._adjacentShardToMerge; }
            set { this._adjacentShardToMerge = value; }
        }

        // Check to see if AdjacentShardToMerge property is set
        internal bool IsSetAdjacentShardToMerge()
        {
            return this._adjacentShardToMerge != null;
        }

        /// <summary>
        /// Gets and sets the property ShardToMerge. 
        /// <para>
        /// The shard ID of the shard to combine with the adjacent shard for the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ShardToMerge
        {
            get { return this._shardToMerge; }
            set { this._shardToMerge = value; }
        }

        // Check to see if ShardToMerge property is set
        internal bool IsSetShardToMerge()
        {
            return this._shardToMerge != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream for the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}