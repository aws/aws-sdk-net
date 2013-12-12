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
    /// Container for the parameters to the GetShardIterator operation.
    /// <para>This operation returns a shard iterator in <c>ShardIterator</c> . The shard iterator specifies the position in the shard from which
    /// you want to start reading data records sequentially. A shard iterator specifies this position using the sequence number of a data record in
    /// a shard. A sequence number is the identifier associated with every record ingested in the Amazon Kinesis stream. The sequence number is
    /// assigned by the Amazon Kinesis service when a record is put into the stream. </para> <para>You must specify the shard iterator type in the
    /// <c>GetShardIterator</c> request. For example, you can set the <c>ShardIteratorType</c> parameter to read exactly from the position denoted
    /// by a specific sequence number by using the AT_SEQUENCE_NUMBER shard iterator type, or right after the sequence number by using the
    /// AFTER_SEQUENCE_NUMBER shard iterator type, using sequence numbers returned by earlier PutRecord, GetRecords or DescribeStream requests. You
    /// can specify the shard iterator type TRIM_HORIZON in the request to cause <c>ShardIterator</c> to point to the last untrimmed record in the
    /// shard in the system, which is the oldest data record in the shard. Or you can point to just after the most recent record in the shard, by
    /// using the shard iterator type LATEST, so that you always read the most recent data in the shard. </para> <para> <b>Note:</b> Each shard
    /// iterator expires five minutes after it is returned to the requester.</para> <para>When you repeatedly read from an Amazon Kinesis stream use
    /// a GetShardIterator request to get the first shard iterator to to use in your first <c>GetRecords</c> request and then use the shard iterator
    /// returned by the <c>GetRecords</c> request in <c>NextShardIterator</c> for subsequent reads. A new shard iterator is returned by every
    /// <c>GetRecords</c> request in <c>NextShardIterator</c> ,
    /// which you use in the <c>ShardIterator</c> parameter of the next <c>GetRecords</c> request. </para> <para>If a
    /// <c>GetShardIterator</c> request is made too often, you will receive a <c>ProvisionedThroughputExceededException</c> .
    /// For more information about throughput limits, see the <a href="http://docs.aws.amazon.com/kinesis/latest/dev/" >Amazon Kinesis
    /// Developer Guide</a> . </para> <para> <c>GetShardIterator</c> can return <c>null</c> for its <c>ShardIterator</c> to indicate that the shard
    /// has been closed and that the requested iterator will return no more data. A shard can be closed by a SplitShard or MergeShards
    /// operation.</para> <para> <c>GetShardIterator</c> has a limit of 5 transactions per second per account per shard.</para>
    /// </summary>
    public partial class GetShardIteratorRequest : AmazonKinesisRequest
    {
        private string streamName;
        private string shardId;
        private ShardIteratorType shardIteratorType;
        private string startingSequenceNumber;


        /// <summary>
        /// The name of the stream.
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
        /// The shard ID of the shard to get the iterator for.
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
        public string ShardId
        {
            get { return this.shardId; }
            set { this.shardId = value; }
        }

        // Check to see if ShardId property is set
        internal bool IsSetShardId()
        {
            return this.shardId != null;
        }

        /// <summary>
        /// Determines how the shard iterator is used to start reading data records from the shard. The following are the valid shard iterator types:
        /// <ul> <li>AT_SEQUENCE_NUMBER - Start reading exactly from the position denoted by a specific sequence number.</li> <li>AFTER_SEQUENCE_NUMBER
        /// - Start reading right after the position denoted by a specific sequence number.</li> <li>TRIM_HORIZON - Start reading at the last untrimmed
        /// record in the shard in the system, which is the oldest data record in the shard.</li> <li>LATEST - Start reading just after the most recent
        /// record in the shard, so that you always read the most recent data in the shard.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>AT_SEQUENCE_NUMBER, AFTER_SEQUENCE_NUMBER, TRIM_HORIZON, LATEST</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ShardIteratorType ShardIteratorType
        {
            get { return this.shardIteratorType; }
            set { this.shardIteratorType = value; }
        }

        // Check to see if ShardIteratorType property is set
        internal bool IsSetShardIteratorType()
        {
            return this.shardIteratorType != null;
        }

        /// <summary>
        /// The sequence number of the data record in the shard from which to start reading from.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>0|([1-9]\d{0,128})</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StartingSequenceNumber
        {
            get { return this.startingSequenceNumber; }
            set { this.startingSequenceNumber = value; }
        }

        // Check to see if StartingSequenceNumber property is set
        internal bool IsSetStartingSequenceNumber()
        {
            return this.startingSequenceNumber != null;
        }

    }
}
    
