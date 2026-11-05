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

namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// Container for the parameters to the GetShardIterator operation. Returns a shard iterator.
    /// A shard iterator provides information about how to retrieve the stream records from
    /// within a shard. Use the shard iterator in a subsequent <c>GetRecords</c> request to
    /// read the stream records from the shard. <note> <para> A shard iterator expires 15
    /// minutes after it is returned to the requester. </para> </note>
    /// </summary>
    public partial class GetShardIteratorRequest : AmazonDynamoDBStreamsRequest
    {
        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number of a stream record in the shard from which to start reading.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 40)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber != null;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The identifier of the shard. The iterator will be returned for this shard ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 28, Max = 65)]
        public string ShardId { get; set; }

        /// <summary>
        /// Checks to see if the ShardId property is set.
        /// </summary>
        internal bool IsSetShardId() => this.ShardId != null;

        /// <summary>
        /// Gets and sets the property ShardIteratorType. 
        /// <para>
        /// Determines how the shard iterator is used to start reading stream records from the
        /// shard:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AT_SEQUENCE_NUMBER</c> - Start reading exactly from the position denoted by a
        /// specific sequence number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AFTER_SEQUENCE_NUMBER</c> - Start reading right after the position denoted by
        /// a specific sequence number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRIM_HORIZON</c> - Start reading at the last (untrimmed) stream record, which
        /// is the oldest record in the shard. In DynamoDB Streams, there is a 24 hour limit on
        /// data retention. Stream records whose age exceeds this limit are subject to removal
        /// (trimming) from the stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LATEST</c> - Start reading just after the most recent stream record in the shard,
        /// so that you always read the most recent data in the shard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AT_TIMESTAMP</c> - Start reading from the position denoted by a specific timestamp,
        /// provided in the parameter <c>Timestamp</c>.
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
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 37, Max = 1024)]
        public string StreamArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamArn property is set.
        /// </summary>
        internal bool IsSetStreamArn() => this.StreamArn != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the stream record from which to start reading. Used with shard iterator
        /// type <c>AT_TIMESTAMP</c>. A timestamp is the Unix epoch date with precision in milliseconds.
        /// For example, <c>1791316726.480</c>. The iterator points to the first stream record
        /// whose <c>ApproximateCreationDateTime</c> is at or after the specified timestamp. If
        /// no record with that exact timestamp exists, the iterator points to the next (later)
        /// record. If the timestamp is older than the current trim horizon, the iterator points
        /// to the oldest untrimmed stream record (<c>TRIM_HORIZON</c>). If the timestamp is in
        /// the future, the request returns a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
