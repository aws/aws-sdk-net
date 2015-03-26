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
    /// Container for the parameters to the PutRecord operation.
    /// Puts (writes) a single data record from a producer into an Amazon Kinesis stream.
    /// Call <code>PutRecord</code> to send data from the producer into the Amazon Kinesis
    /// stream for real-time ingestion and subsequent processing, one record at a time. Each
    /// shard can support up to 1000 records written per second, up to a maximum total of
    /// 1 MB data written per second.
    /// 
    ///  
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
    /// The partition key is used by Amazon Kinesis to distribute data across shards. Amazon
    /// Kinesis segregates the data records that belong to a data stream into multiple shards,
    /// using the partition key associated with each data record to determine which shard
    /// a given data record belongs to. 
    /// </para>
    ///  
    /// <para>
    /// Partition keys are Unicode strings, with a maximum length limit of 256 bytes. An MD5
    /// hash function is used to map partition keys to 128-bit integer values and to map associated
    /// data records to shards using the hash key ranges of the shards. You can override hashing
    /// the partition key to determine the shard by explicitly specifying a hash value using
    /// the <code>ExplicitHashKey</code> parameter. For more information, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-defn-partition-key">Partition
    /// Key</a> in the <i>Amazon Kinesis Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// <code>PutRecord</code> returns the shard ID of where the data record was placed and
    /// the sequence number that was assigned to the data record.
    /// </para>
    ///  
    /// <para>
    /// Sequence numbers generally increase over time. To guarantee strictly increasing ordering,
    /// use the <code>SequenceNumberForOrdering</code> parameter. For more information, see
    /// <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-defn-sequence-number">Sequence
    /// Number</a> in the <i>Amazon Kinesis Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If a <code>PutRecord</code> request cannot be processed because of insufficient provisioned
    /// throughput on the shard involved in the request, <code>PutRecord</code> throws <code>ProvisionedThroughputExceededException</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Data records are accessible for only 24 hours from the time that they are added to
    /// an Amazon Kinesis stream.
    /// </para>
    /// </summary>
    public partial class PutRecordRequest : AmazonKinesisRequest
    {
        private MemoryStream _data;
        private string _explicitHashKey;
        private string _partitionKey;
        private string _sequenceNumberForOrdering;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data blob to put into the record, which is base64-encoded when the blob is serialized.
        /// The maximum size of the data blob (the payload before base64-encoding) is 50 kilobytes
        /// (KB) 
        /// </para>
        /// </summary>
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
        /// are Unicode strings with a maximum length limit of 256 bytes. Amazon Kinesis uses
        /// the partition key as input to a hash function that maps the partition key and associated
        /// data to a specific shard. Specifically, an MD5 hash function is used to map partition
        /// keys to 128-bit integer values and to map associated data records to shards. As a
        /// result of this hashing mechanism, all data records with the same partition key will
        /// map to the same shard within the stream.
        /// </para>
        /// </summary>
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
        /// record <i>n</i> to the sequence number of record <i>n-1</i> (as returned in the <a>PutRecordResult</a>
        /// when putting record <i>n-1</i>). If this parameter is not set, records will be coarsely
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
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream to put the data record into.
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