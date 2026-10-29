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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the MergeShards operation. Merges two adjacent shards
    /// in a Kinesis data stream and combines them into a single shard to reduce the stream's
    /// capacity to ingest and transport data. This API is only supported for the data streams
    /// with the provisioned capacity mode. Two shards are considered adjacent if the union
    /// of the hash key ranges for the two shards form a contiguous set with no gaps. For
    /// example, if you have two shards, one with a hash key range of 276...381 and the other
    /// with a hash key range of 382...454, then you could merge these two shards into a single
    /// shard that would have a hash key range of 276...454. After the merge, the single child
    /// shard receives data for all hash key values covered by the two parent shards. <note>
    /// <para> When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
    /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
    /// when you invoke this API. </para> </note> <para> <c>MergeShards</c> is called when
    /// there is a need to reduce the overall capacity of a stream because of excess capacity
    /// that is not being used. You must specify the shard to be merged and the adjacent shard
    /// for a stream. For more information about merging shards, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-merge.html">Merge
    /// Two Shards</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>. </para>
    /// <para> If the stream is in the <c>ACTIVE</c> state, you can call <c>MergeShards</c>.
    /// If a stream is in the <c>CREATING</c>, <c>UPDATING</c>, or <c>DELETING</c> state,
    /// <c>MergeShards</c> returns a <c>ResourceInUseException</c>. If the specified stream
    /// does not exist, <c>MergeShards</c> returns a <c>ResourceNotFoundException</c>. </para>
    /// <para> You can use <a>DescribeStreamSummary</a> to check the state of the stream,
    /// which is returned in <c>StreamStatus</c>. </para> <para> <c>MergeShards</c> is an
    /// asynchronous operation. Upon receiving a <c>MergeShards</c> request, Amazon Kinesis
    /// Data Streams immediately returns a response and sets the <c>StreamStatus</c> to <c>UPDATING</c>.
    /// After the operation is completed, Kinesis Data Streams sets the <c>StreamStatus</c>
    /// to <c>ACTIVE</c>. Read and write operations continue to work while the stream is in
    /// the <c>UPDATING</c> state. </para> <para> You use <a>DescribeStreamSummary</a> and
    /// the <a>ListShards</a> APIs to determine the shard IDs that are specified in the <c>MergeShards</c>
    /// request. </para> <para> If you try to operate on too many streams in parallel using
    /// <a>CreateStream</a>, <a>DeleteStream</a>, <c>MergeShards</c>, or <a>SplitShard</a>,
    /// you receive a <c>LimitExceededException</c>. </para> <para> <c>MergeShards</c> has
    /// a limit of five transactions per second per account. </para>
    /// </summary>
    public partial class MergeShardsRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property AdjacentShardToMerge. 
        /// <para>
        /// The shard ID of the adjacent shard for the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AdjacentShardToMerge { get; set; }

        /// <summary>
        /// Checks to see if the AdjacentShardToMerge property is set.
        /// </summary>
        internal bool IsSetAdjacentShardToMerge() => this.AdjacentShardToMerge != null;

        /// <summary>
        /// Gets and sets the property ShardToMerge. 
        /// <para>
        /// The shard ID of the shard to combine with the adjacent shard for the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ShardToMerge { get; set; }

        /// <summary>
        /// Checks to see if the ShardToMerge property is set.
        /// </summary>
        internal bool IsSetShardToMerge() => this.ShardToMerge != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// Not Implemented. Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 24)]
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream for the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
