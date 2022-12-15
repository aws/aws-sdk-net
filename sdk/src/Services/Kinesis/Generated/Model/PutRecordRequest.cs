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
    /// Container for the parameters to the PutRecord operation.
    /// Writes a single data record into an Amazon Kinesis data stream. Call <code>PutRecord</code>
    /// to send data into the stream for real-time ingestion and subsequent processing, one
    /// record at a time. Each shard can support writes up to 1,000 records per second, up
    /// to a maximum data write total of 1 MiB per second.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, it is recommended you use the <code>StreamARN</code> input
    /// parameter rather than the <code>StreamName</code> input parameter.
    /// </para>
    ///  </note> 
    /// <para>
    /// You must specify the name of the stream that captures, stores, and transports the
    /// data; a partition key; and the data blob itself.
    /// </para>
    ///  
    /// <para>
    /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
    /// data, website clickstream data, and so on.
    /// </para>
    ///  
    /// <para>
    /// The partition key is used by Kinesis Data Streams to distribute data across shards.
    /// Kinesis Data Streams segregates the data records that belong to a stream into multiple
    /// shards, using the partition key associated with each data record to determine the
    /// shard to which a given data record belongs.
    /// </para>
    ///  
    /// <para>
    /// Partition keys are Unicode strings, with a maximum length limit of 256 characters
    /// for each key. An MD5 hash function is used to map partition keys to 128-bit integer
    /// values and to map associated data records to shards using the hash key ranges of the
    /// shards. You can override hashing the partition key to determine the shard by explicitly
    /// specifying a hash value using the <code>ExplicitHashKey</code> parameter. For more
    /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
    /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <code>PutRecord</code> returns the shard ID of where the data record was placed and
    /// the sequence number that was assigned to the data record.
    /// </para>
    ///  
    /// <para>
    /// Sequence numbers increase over time and are specific to a shard within a stream, not
    /// across all shards within a stream. To guarantee strictly increasing ordering, write
    /// serially to a shard and use the <code>SequenceNumberForOrdering</code> parameter.
    /// For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
    /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// After you write a record to a stream, you cannot modify that record or its order within
    /// the stream.
    /// </para>
    ///  </important> 
    /// <para>
    /// If a <code>PutRecord</code> request cannot be processed because of insufficient provisioned
    /// throughput on the shard involved in the request, <code>PutRecord</code> throws <code>ProvisionedThroughputExceededException</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// By default, data records are accessible for 24 hours from the time that they are added
    /// to a stream. You can use <a>IncreaseStreamRetentionPeriod</a> or <a>DecreaseStreamRetentionPeriod</a>
    /// to modify this retention period.
    /// </para>
    /// </summary>
    public partial class PutRecordRequest : AmazonKinesisRequest
    {
        private MemoryStream _data;
        private string _explicitHashKey;
        private string _partitionKey;
        private string _sequenceNumberForOrdering;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data blob to put into the record, which is base64-encoded when the blob is serialized.
        /// When the data blob (the payload before base64-encoding) is added to the partition
        /// key size, the total size must not exceed the maximum record size (1 MiB).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1048576)]
        public MemoryStream Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property ExplicitHashKey. 
        /// <para>
        /// The hash value used to explicitly determine the shard the data record is assigned
        /// to by overriding the partition key hash.
        /// </para>
        /// </summary>
        public string ExplicitHashKey
        {
            get { return this._explicitHashKey; }
            set { this._explicitHashKey = value; }
        }

        // Check to see if ExplicitHashKey property is set
        internal bool IsSetExplicitHashKey()
        {
            return this._explicitHashKey != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// Determines which shard in the stream the data record is assigned to. Partition keys
        /// are Unicode strings with a maximum length limit of 256 characters for each key. Amazon
        /// Kinesis Data Streams uses the partition key as input to a hash function that maps
        /// the partition key and associated data to a specific shard. Specifically, an MD5 hash
        /// function is used to map partition keys to 128-bit integer values and to map associated
        /// data records to shards. As a result of this hashing mechanism, all data records with
        /// the same partition key map to the same shard within the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PartitionKey
        {
            get { return this._partitionKey; }
            set { this._partitionKey = value; }
        }

        // Check to see if PartitionKey property is set
        internal bool IsSetPartitionKey()
        {
            return this._partitionKey != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceNumberForOrdering. 
        /// <para>
        /// Guarantees strictly increasing sequence numbers, for puts from the same client and
        /// to the same partition key. Usage: set the <code>SequenceNumberForOrdering</code> of
        /// record <i>n</i> to the sequence number of record <i>n-1</i> (as returned in the result
        /// when putting record <i>n-1</i>). If this parameter is not set, records are coarsely
        /// ordered based on arrival time.
        /// </para>
        /// </summary>
        public string SequenceNumberForOrdering
        {
            get { return this._sequenceNumberForOrdering; }
            set { this._sequenceNumberForOrdering = value; }
        }

        // Check to see if SequenceNumberForOrdering property is set
        internal bool IsSetSequenceNumberForOrdering()
        {
            return this._sequenceNumberForOrdering != null;
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
        /// The name of the stream to put the data record into.
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