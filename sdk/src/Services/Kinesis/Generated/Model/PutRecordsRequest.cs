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
    /// Container for the parameters to the PutRecords operation.
    /// Puts (writes) multiple data records from a producer into an Amazon Kinesis stream
    /// in a single call (also referred to as a <code>PutRecords</code> request). Use this
    /// operation to send data from a data producer into the Amazon Kinesis stream for real-time
    /// ingestion and processing. Each shard can support up to 1000 records written per second,
    /// up to a maximum total of 1 MB data written per second.
    /// 
    ///  
    /// <para>
    /// You must specify the name of the stream that captures, stores, and transports the
    /// data; and an array of request <code>Records</code>, with each record in the array
    /// requiring a partition key and data blob. 
    /// </para>
    ///  
    /// <para>
    /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
    /// data, website clickstream data, and so on.
    /// </para>
    ///  
    /// <para>
    /// The partition key is used by Amazon Kinesis as input to a hash function that maps
    /// the partition key and associated data to a specific shard. An MD5 hash function is
    /// used to map partition keys to 128-bit integer values and to map associated data records
    /// to shards. As a result of this hashing mechanism, all data records with the same partition
    /// key map to the same shard within the stream. For more information, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-defn-partition-key">Partition
    /// Key</a> in the <i>Amazon Kinesis Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Each record in the <code>Records</code> array may include an optional parameter, <code>ExplicitHashKey</code>,
    /// which overrides the partition key to shard mapping. This parameter allows a data producer
    /// to determine explicitly the shard where the record is stored. For more information,
    /// see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-putrecords">Adding
    /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The <code>PutRecords</code> response includes an array of response <code>Records</code>.
    /// Each record in the response array directly correlates with a record in the request
    /// array using natural ordering, from the top to the bottom of the request and response.
    /// The response <code>Records</code> array always includes the same number of records
    /// as the request array.
    /// </para>
    ///  
    /// <para>
    /// The response <code>Records</code> array includes both successfully and unsuccessfully
    /// processed records. Amazon Kinesis attempts to process all records in each <code>PutRecords</code>
    /// request. A single record failure does not stop the processing of subsequent records.
    /// </para>
    ///  
    /// <para>
    /// A successfully-processed record includes <code>ShardId</code> and <code>SequenceNumber</code>
    /// values. The <code>ShardId</code> parameter identifies the shard in the stream where
    /// the record is stored. The <code>SequenceNumber</code> parameter is an identifier assigned
    /// to the put record, unique to all records in the stream.
    /// </para>
    ///  
    /// <para>
    /// An unsuccessfully-processed record includes <code>ErrorCode</code> and <code>ErrorMessage</code>
    /// values. <code>ErrorCode</code> reflects the type of error and can be one of the following
    /// values: <code>ProvisionedThroughputExceededException</code> or <code>InternalFailure</code>.
    /// <code>ErrorMessage</code> provides more detailed information about the <code>ProvisionedThroughputExceededException</code>
    /// exception including the account ID, stream name, and shard ID of the record that was
    /// throttled.
    /// </para>
    ///  
    /// <para>
    /// Data records are accessible for only 24 hours from the time that they are added to
    /// an Amazon Kinesis stream.
    /// </para>
    /// </summary>
    public partial class PutRecordsRequest : AmazonKinesisRequest
    {
        private List<PutRecordsRequestEntry> _records = new List<PutRecordsRequestEntry>();
        private string _streamName;

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The records associated with the request.
        /// </para>
        /// </summary>
        public List<PutRecordsRequestEntry> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && this._records.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The stream name associated with the request.
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