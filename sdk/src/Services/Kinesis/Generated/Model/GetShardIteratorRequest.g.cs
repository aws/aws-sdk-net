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
    /// Container for the parameters to the GetShardIterator operation. Gets an Amazon Kinesis
    /// shard iterator. A shard iterator expires 5 minutes after it is returned to the requester.
    /// <note> <para> When invoking this API, you must use either the <c>StreamARN</c> or
    /// the <c>StreamName</c> parameter, or both. It is recommended that you use the <c>StreamARN</c>
    /// input parameter when you invoke this API. </para> </note> <para> A shard iterator
    /// specifies the shard position from which to start reading data records sequentially.
    /// The position is specified using the sequence number of a data record in a shard. A
    /// sequence number is the identifier associated with every record ingested in the stream,
    /// and is assigned when a record is put into the stream. Each stream has one or more
    /// shards. </para> <para> You must specify the shard iterator type. For example, you
    /// can set the <c>ShardIteratorType</c> parameter to read exactly from the position denoted
    /// by a specific sequence number by using the <c>AT_SEQUENCE_NUMBER</c> shard iterator
    /// type. Alternatively, the parameter can read right after the sequence number by using
    /// the <c>AFTER_SEQUENCE_NUMBER</c> shard iterator type, using sequence numbers returned
    /// by earlier calls to <a>PutRecord</a>, <a>PutRecords</a>, <a>GetRecords</a>, or <a>DescribeStream</a>.
    /// In the request, you can specify the shard iterator type <c>AT_TIMESTAMP</c> to read
    /// records from an arbitrary point in time, <c>TRIM_HORIZON</c> to cause <c>ShardIterator</c>
    /// to point to the last untrimmed record in the shard in the system (the oldest data
    /// record in the shard), or <c>LATEST</c> so that you always read the most recent data
    /// in the shard. </para> <para> When you read repeatedly from a stream, use a <a>GetShardIterator</a>
    /// request to get the first shard iterator for use in your first <a>GetRecords</a> request
    /// and for subsequent reads use the shard iterator returned by the <a>GetRecords</a>
    /// request in <c>NextShardIterator</c>. A new shard iterator is returned by every <a>GetRecords</a>
    /// request in <c>NextShardIterator</c>, which you use in the <c>ShardIterator</c> parameter
    /// of the next <a>GetRecords</a> request. </para> <para> If a <a>GetShardIterator</a>
    /// request is made too often, you receive a <c>ProvisionedThroughputExceededException</c>.
    /// For more information about throughput limits, see <a>GetRecords</a>, and <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
    /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>. </para> <para>
    /// If the shard is closed, <a>GetShardIterator</a> returns a valid iterator for the last
    /// sequence number of the shard. A shard can be closed as a result of using <a>SplitShard</a>
    /// or <a>MergeShards</a>. </para> <para> <a>GetShardIterator</a> has a limit of five
    /// transactions per second per account per open shard. </para>
    /// </summary>
    public partial class GetShardIteratorRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks if your request will succeed. <c>DryRun</c> is an optional parameter.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The shard ID of the Kinesis Data Streams shard to get the iterator for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ShardId { get; set; }

        /// <summary>
        /// Checks to see if the ShardId property is set.
        /// </summary>
        internal bool IsSetShardId() => this.ShardId != null;

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
        /// number, provided in the value <c>StartingSequenceNumber</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AFTER_SEQUENCE_NUMBER - Start reading right after the position denoted by a specific
        /// sequence number, provided in the value <c>StartingSequenceNumber</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AT_TIMESTAMP - Start reading from the position denoted by a specific time stamp, provided
        /// in the value <c>Timestamp</c>.
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
        [AWSProperty(Required = true)]
        public ShardIteratorType ShardIteratorType { get; set; }

        /// <summary>
        /// Checks to see if the ShardIteratorType property is set.
        /// </summary>
        internal bool IsSetShardIteratorType() => this.ShardIteratorType != null;

        /// <summary>
        /// Gets and sets the property StartingSequenceNumber. 
        /// <para>
        /// The sequence number of the data record in the shard from which to start reading. Used
        /// with shard iterator type AT_SEQUENCE_NUMBER and AFTER_SEQUENCE_NUMBER.
        /// </para>
        /// </summary>
        public string StartingSequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the StartingSequenceNumber property is set.
        /// </summary>
        internal bool IsSetStartingSequenceNumber() => this.StartingSequenceNumber != null;

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
        /// The name of the Amazon Kinesis data stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time stamp of the data record from which to start reading. Used with shard iterator
        /// type AT_TIMESTAMP. A time stamp is the Unix epoch date with precision in milliseconds.
        /// For example, <c>2016-04-04T19:58:46.480-00:00</c> or <c>1459799926.480</c>. If a record
        /// with this exact time stamp does not exist, the iterator returned is for the next (later)
        /// record. If the time stamp is older than the current trim horizon, the iterator returned
        /// is for the oldest untrimmed data record (TRIM_HORIZON).
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
