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
    /// Container for the parameters to the GetShardIterator operation.
    /// Gets an Amazon Kinesis shard iterator. A shard iterator expires 5 minutes after it
    /// is returned to the requester.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, it is recommended you use the <code>StreamARN</code> input
    /// parameter rather than the <code>StreamName</code> input parameter.
    /// </para>
    ///  </note> 
    /// <para>
    /// A shard iterator specifies the shard position from which to start reading data records
    /// sequentially. The position is specified using the sequence number of a data record
    /// in a shard. A sequence number is the identifier associated with every record ingested
    /// in the stream, and is assigned when a record is put into the stream. Each stream has
    /// one or more shards.
    /// </para>
    ///  
    /// <para>
    /// You must specify the shard iterator type. For example, you can set the <code>ShardIteratorType</code>
    /// parameter to read exactly from the position denoted by a specific sequence number
    /// by using the <code>AT_SEQUENCE_NUMBER</code> shard iterator type. Alternatively, the
    /// parameter can read right after the sequence number by using the <code>AFTER_SEQUENCE_NUMBER</code>
    /// shard iterator type, using sequence numbers returned by earlier calls to <a>PutRecord</a>,
    /// <a>PutRecords</a>, <a>GetRecords</a>, or <a>DescribeStream</a>. In the request, you
    /// can specify the shard iterator type <code>AT_TIMESTAMP</code> to read records from
    /// an arbitrary point in time, <code>TRIM_HORIZON</code> to cause <code>ShardIterator</code>
    /// to point to the last untrimmed record in the shard in the system (the oldest data
    /// record in the shard), or <code>LATEST</code> so that you always read the most recent
    /// data in the shard. 
    /// </para>
    ///  
    /// <para>
    /// When you read repeatedly from a stream, use a <a>GetShardIterator</a> request to get
    /// the first shard iterator for use in your first <a>GetRecords</a> request and for subsequent
    /// reads use the shard iterator returned by the <a>GetRecords</a> request in <code>NextShardIterator</code>.
    /// A new shard iterator is returned by every <a>GetRecords</a> request in <code>NextShardIterator</code>,
    /// which you use in the <code>ShardIterator</code> parameter of the next <a>GetRecords</a>
    /// request. 
    /// </para>
    ///  
    /// <para>
    /// If a <a>GetShardIterator</a> request is made too often, you receive a <code>ProvisionedThroughputExceededException</code>.
    /// For more information about throughput limits, see <a>GetRecords</a>, and <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
    /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the shard is closed, <a>GetShardIterator</a> returns a valid iterator for the last
    /// sequence number of the shard. A shard can be closed as a result of using <a>SplitShard</a>
    /// or <a>MergeShards</a>.
    /// </para>
    ///  
    /// <para>
    ///  <a>GetShardIterator</a> has a limit of five transactions per second per account per
    /// open shard.
    /// </para>
    /// </summary>
    public partial class GetShardIteratorRequest : AmazonKinesisRequest
    {
        private string _shardId;
        private ShardIteratorType _shardIteratorType;
        private string _startingSequenceNumber;
        private string _streamARN;
        private string _streamName;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The shard ID of the Kinesis Data Streams shard to get the iterator for.
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

        /// <summary>
        /// Gets and sets the property ShardIteratorType. 
        /// <para>
        /// Determines how the shard iterator is used to start reading data records from the shard.
        /// </para>
        ///  
        /// <para>
        /// The following are the valid Amazon Kinesis shard iterator types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AT_SEQUENCE_NUMBER - Start reading from the position denoted by a specific sequence
        /// number, provided in the value <code>StartingSequenceNumber</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AFTER_SEQUENCE_NUMBER - Start reading right after the position denoted by a specific
        /// sequence number, provided in the value <code>StartingSequenceNumber</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AT_TIMESTAMP - Start reading from the position denoted by a specific time stamp, provided
        /// in the value <code>Timestamp</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TRIM_HORIZON - Start reading at the last untrimmed record in the shard in the system,
        /// which is the oldest data record in the shard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LATEST - Start reading just after the most recent record in the shard, so that you
        /// always read the most recent data in the shard.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ShardIteratorType ShardIteratorType
        {
            get { return this._shardIteratorType; }
            set { this._shardIteratorType = value; }
        }

        // Check to see if ShardIteratorType property is set
        internal bool IsSetShardIteratorType()
        {
            return this._shardIteratorType != null;
        }

        /// <summary>
        /// Gets and sets the property StartingSequenceNumber. 
        /// <para>
        /// The sequence number of the data record in the shard from which to start reading. Used
        /// with shard iterator type AT_SEQUENCE_NUMBER and AFTER_SEQUENCE_NUMBER.
        /// </para>
        /// </summary>
        public string StartingSequenceNumber
        {
            get { return this._startingSequenceNumber; }
            set { this._startingSequenceNumber = value; }
        }

        // Check to see if StartingSequenceNumber property is set
        internal bool IsSetStartingSequenceNumber()
        {
            return this._startingSequenceNumber != null;
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
        /// The name of the Amazon Kinesis data stream.
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

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time stamp of the data record from which to start reading. Used with shard iterator
        /// type AT_TIMESTAMP. A time stamp is the Unix epoch date with precision in milliseconds.
        /// For example, <code>2016-04-04T19:58:46.480-00:00</code> or <code>1459799926.480</code>.
        /// If a record with this exact time stamp does not exist, the iterator returned is for
        /// the next (later) record. If the time stamp is older than the current trim horizon,
        /// the iterator returned is for the oldest untrimmed data record (TRIM_HORIZON).
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}