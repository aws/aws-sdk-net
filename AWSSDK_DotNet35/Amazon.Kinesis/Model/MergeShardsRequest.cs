/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the MergeShards operation.
    /// <para>This operation merges two adjacent shards in a stream and combines them into a single shard to reduce the stream's capacity to ingest
    /// and transport data. Two shards are considered adjacent if the union of the hash key ranges for the two shards form a contiguous set with no
    /// gaps. For example, if you have two shards, one with a hash key range of 276...381 and the other with a hash key range of 382...454, then you
    /// could merge these two shards into a single shard that would have a hash key range of 276...454. After the merge, the single child shard
    /// receives data for all hash key values covered by the two parent shards.</para> <para> <c>MergeShards</c> is called when there is a need to
    /// reduce the overall capacity of a stream because of excess capacity that is not being used. The operation requires that you specify the shard
    /// to be merged and the adjacent shard for a given stream. For more information about merging shards, see the <a
    /// href="http://docs.aws.amazon.com/kinesis/latest/dev/" >Amazon Kinesis Developer Guide</a> .</para> <para>If the stream is in the ACTIVE
    /// state, you can call <c>MergeShards</c> . If a stream is in CREATING or UPDATING or DELETING states, then Amazon Kinesis returns a
    /// <c>ResourceInUseException</c> .
    /// If the specified stream does not exist, Amazon Kinesis returns a <c>ResourceNotFoundException</c> . </para> <para>You can use
    /// the DescribeStream operation to check the state of the stream, which is returned in <c>StreamStatus</c> .</para> <para> <c>MergeShards</c>
    /// is an asynchronous operation. Upon receiving a <c>MergeShards</c> request, Amazon Kinesis immediately returns a response and sets the
    /// <c>StreamStatus</c> to UPDATING. After the operation is completed, Amazon Kinesis sets the <c>StreamStatus</c> to ACTIVE. Read and write
    /// operations continue to work while the stream is in the UPDATING state. </para> <para>You use the DescribeStream operation to determine the
    /// shard IDs that are specified in the <c>MergeShards</c> request. </para> <para>If you try to operate on too many streams in parallel using
    /// CreateStream, DeleteStream, <c>MergeShards</c> or SplitShard, you will receive a <c>LimitExceededException</c> . </para> <para>
    /// <c>MergeShards</c> has limit of 5 transactions per second per account.</para>
    /// </summary>
    public partial class MergeShardsRequest : AmazonKinesisRequest
    {
        private string streamName;
        private string shardToMerge;
        private string adjacentShardToMerge;


        /// <summary>
        /// The name of the stream for the merge.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this.streamName; }
            set { this.streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this.streamName != null;
        }

        /// <summary>
        /// The shard ID of the shard to combine with the adjacent shard for the merge.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ShardToMerge
        {
            get { return this.shardToMerge; }
            set { this.shardToMerge = value; }
        }

        // Check to see if ShardToMerge property is set
        internal bool IsSetShardToMerge()
        {
            return this.shardToMerge != null;
        }

        /// <summary>
        /// The shard ID of the adjacent shard for the merge.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AdjacentShardToMerge
        {
            get { return this.adjacentShardToMerge; }
            set { this.adjacentShardToMerge = value; }
        }

        // Check to see if AdjacentShardToMerge property is set
        internal bool IsSetAdjacentShardToMerge()
        {
            return this.adjacentShardToMerge != null;
        }

    }
}
    
