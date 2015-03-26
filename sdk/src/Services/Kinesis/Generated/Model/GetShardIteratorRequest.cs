/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the GetShardIterator operation.
    /// Gets a shard iterator. A shard iterator expires five minutes after it is returned
    /// to the requester.
    /// 
    ///  
    /// <para>
    /// A shard iterator specifies the position in the shard from which to start reading data
    /// records sequentially. A shard iterator specifies this position using the sequence
    /// number of a data record in a shard. A sequence number is the identifier associated
    /// with every record ingested in the Amazon Kinesis stream. The sequence number is assigned
    /// when a record is put into the stream. 
    /// </para>
    ///  
    /// <para>
    /// You must specify the shard iterator type. For example, you can set the <code>ShardIteratorType</code>
    /// parameter to read exactly from the position denoted by a specific sequence number
    /// by using the <code>AT_SEQUENCE_NUMBER</code> shard iterator type, or right after the
    /// sequence number by using the <code>AFTER_SEQUENCE_NUMBER</code> shard iterator type,
    /// using sequence numbers returned by earlier calls to <a>PutRecord</a>, <a>PutRecords</a>,
    /// <a>GetRecords</a>, or <a>DescribeStream</a>. You can specify the shard iterator type
    /// <code>TRIM_HORIZON</code> in the request to cause <code>ShardIterator</code> to point
    /// to the last untrimmed record in the shard in the system, which is the oldest data
    /// record in the shard. Or you can point to just after the most recent record in the
    /// shard, by using the shard iterator type <code>LATEST</code>, so that you always read
    /// the most recent data in the shard. 
    /// </para>
    ///  
    /// <para>
    /// When you repeatedly read from an Amazon Kinesis stream use a <a>GetShardIterator</a>
    /// request to get the first shard iterator to to use in your first <code>GetRecords</code>
    /// request and then use the shard iterator returned by the <code>GetRecords</code> request
    /// in <code>NextShardIterator</code> for subsequent reads. A new shard iterator is returned
    /// by every <code>GetRecords</code> request in <code>NextShardIterator</code>, which
    /// you use in the <code>ShardIterator</code> parameter of the next <code>GetRecords</code>
    /// request. 
    /// </para>
    ///  
    /// <para>
    /// If a <code>GetShardIterator</code> request is made too often, you receive a <code>ProvisionedThroughputExceededException</code>.
    /// For more information about throughput limits, see <a>GetRecords</a>.
    /// </para>
    ///  
    /// <para>
    /// If the shard is closed, the iterator can't return more data, and <code>GetShardIterator</code>
    /// returns <code>null</code> for its <code>ShardIterator</code>. A shard can be closed
    /// using <a>SplitShard</a> or <a>MergeShards</a>.
    /// </para>
    ///  
    /// <para>
    /// <code>GetShardIterator</code> has a limit of 5 transactions per second per account
    /// per open shard.
    /// </para>
    /// </summary>
    public partial class GetShardIteratorRequest : AmazonKinesisRequest
    {
        private string _shardId;
        private ShardIteratorType _shardIteratorType;
        private string _startingSequenceNumber;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The shard ID of the shard to get the iterator for.
        /// </para>
        /// </summary>
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
        /// The following are the valid shard iterator types:
        /// </para>
        ///  <ul> <li>AT_SEQUENCE_NUMBER - Start reading exactly from the position denoted by
        /// a specific sequence number.</li> <li>AFTER_SEQUENCE_NUMBER - Start reading right after
        /// the position denoted by a specific sequence number.</li> <li>TRIM_HORIZON - Start
        /// reading at the last untrimmed record in the shard in the system, which is the oldest
        /// data record in the shard.</li> <li>LATEST - Start reading just after the most recent
        /// record in the shard, so that you always read the most recent data in the shard.</li>
        /// </ul>
        /// </summary>
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
        /// The sequence number of the data record in the shard from which to start reading from.
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
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream.
        /// </para>
        /// </summary>
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