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
    /// Container for the parameters to the SplitShard operation.
    /// <para>This operation splits a shard into two new shards in the stream, to increase the stream's capacity to ingest and transport data.
    /// <c>SplitShard</c> is called when there is a need to increase the overall capacity of stream because of an expected increase in the volume of
    /// data records being ingested. </para> <para> <c>SplitShard</c> can also be used when a given shard appears to be approaching its maximum
    /// utilization, for example, when the set of producers sending data into the specific shard are suddenly sending more than previously
    /// anticipated. You can also call the <c>SplitShard</c> operation to increase stream capacity, so that more Amazon Kinesis applications can
    /// simultaneously read data from the stream for real-time processing. </para> <para>The <c>SplitShard</c> operation requires that you specify
    /// the shard to be split and the new hash key, which is the position in the shard where the shard gets split in two. In many cases, the new
    /// hash key might simply be the average of the beginning and ending hash key, but it can be any hash key value in the range being mapped into
    /// the shard. For more information about splitting shards, see the <a href="http://docs.aws.amazon.com/kinesis/latest/dev/" >Amazon Kinesis
    /// Developer Guide</a> .
    /// </para> <para>You can use the DescribeStream operation to determine the shard ID and hash key values for the <c>ShardToSplit</c>
    /// and <c>NewStartingHashKey</c> parameters that are specified in the <c>SplitShard</c> request.</para> <para> <c>SplitShard</c> is an
    /// asynchronous operation. Upon receiving a <c>SplitShard</c> request, Amazon Kinesis immediately returns a response and sets the stream status
    /// to UPDATING. After the operation is completed, Amazon Kinesis sets the stream status to ACTIVE. Read and write operations continue to work
    /// while the stream is in the UPDATING state. </para> <para>You can use <c>DescribeStream</c> to check the status of the stream, which is
    /// returned in <c>StreamStatus</c> .
    /// If the stream is in the ACTIVE state, you can call <c>SplitShard</c> .
    /// If a stream is in CREATING or UPDATING or DELETING states, then Amazon Kinesis returns a <c>ResourceInUseException</c> .</para>
    /// <para>If the specified stream does not exist, Amazon Kinesis returns a <c>ResourceNotFoundException</c> .
    /// If you try to create more shards than are authorized for your account, you receive a <c>LimitExceededException</c> .
    /// </para> <para> <b>Note:</b> The default limit for an AWS account is two shards per stream. If you need to create a stream with more than two
    /// shards, contact AWS Support to increase the limit on your account.</para> <para>If you try to operate on too many streams in parallel using
    /// CreateStream, DeleteStream, MergeShards or SplitShard, you will receive a <c>LimitExceededException</c> . </para> <para> <c>SplitShard</c>
    /// has limit of 5 transactions per second per account.</para>
    /// </summary>
    public partial class SplitShardRequest : AmazonKinesisRequest
    {
        private string streamName;
        private string shardToSplit;
        private string newStartingHashKey;


        /// <summary>
        /// The name of the stream for the shard split.
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
        /// The shard ID of the shard to split.
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
        public string ShardToSplit
        {
            get { return this.shardToSplit; }
            set { this.shardToSplit = value; }
        }

        // Check to see if ShardToSplit property is set
        internal bool IsSetShardToSplit()
        {
            return this.shardToSplit != null;
        }

        /// <summary>
        /// A hash key value for the starting hash key of one of the child shards created by the split. The hash key range for a given shard constitutes
        /// a set of ordered contiguous positive integers. The value for <c>NewStartingHashKey</c> must be in the range of hash keys being mapped into
        /// the shard. The <c>NewStartingHashKey</c> hash key value and all higher hash key values in hash key range are distributed to one of the child
        /// shards. All the lower hash key values in the range are distributed to the other child shard.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>0|([1-9]\d{0,38})</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NewStartingHashKey
        {
            get { return this.newStartingHashKey; }
            set { this.newStartingHashKey = value; }
        }

        // Check to see if NewStartingHashKey property is set
        internal bool IsSetNewStartingHashKey()
        {
            return this.newStartingHashKey != null;
        }

    }
}
    
