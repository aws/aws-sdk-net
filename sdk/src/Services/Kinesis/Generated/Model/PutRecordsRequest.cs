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
    /// Container for the parameters to the PutRecords operation.
    /// Writes multiple data records into a Kinesis data stream in a single call (also referred
    /// to as a <code>PutRecords</code> request). Use this operation to send data into the
    /// stream for data ingestion and processing. 
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, it is recommended you use the <code>StreamARN</code> input
    /// parameter rather than the <code>StreamName</code> input parameter.
    /// </para>
    ///  </note> 
    /// <para>
    /// Each <code>PutRecords</code> request can support up to 500 records. Each record in
    /// the request can be as large as 1 MiB, up to a limit of 5 MiB for the entire request,
    /// including partition keys. Each shard can support writes up to 1,000 records per second,
    /// up to a maximum data write total of 1 MiB per second.
    /// </para>
    ///  
    /// <para>
    /// You must specify the name of the stream that captures, stores, and transports the
    /// data; and an array of request <code>Records</code>, with each record in the array
    /// requiring a partition key and data blob. The record size limit applies to the total
    /// size of the partition key and data blob.
    /// </para>
    ///  
    /// <para>
    /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
    /// data, website clickstream data, and so on.
    /// </para>
    ///  
    /// <para>
    /// The partition key is used by Kinesis Data Streams as input to a hash function that
    /// maps the partition key and associated data to a specific shard. An MD5 hash function
    /// is used to map partition keys to 128-bit integer values and to map associated data
    /// records to shards. As a result of this hashing mechanism, all data records with the
    /// same partition key map to the same shard within the stream. For more information,
    /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
    /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Each record in the <code>Records</code> array may include an optional parameter, <code>ExplicitHashKey</code>,
    /// which overrides the partition key to shard mapping. This parameter allows a data producer
    /// to determine explicitly the shard where the record is stored. For more information,
    /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-putrecords">Adding
    /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Data Streams Developer
    /// Guide</i>.
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
    /// processed records. Kinesis Data Streams attempts to process all records in each <code>PutRecords</code>
    /// request. A single record failure does not stop the processing of subsequent records.
    /// As a result, PutRecords doesn't guarantee the ordering of records. If you need to
    /// read records in the same order they are written to the stream, use <a>PutRecord</a>
    /// instead of <code>PutRecords</code>, and write to the same shard.
    /// </para>
    ///  
    /// <para>
    /// A successfully processed record includes <code>ShardId</code> and <code>SequenceNumber</code>
    /// values. The <code>ShardId</code> parameter identifies the shard in the stream where
    /// the record is stored. The <code>SequenceNumber</code> parameter is an identifier assigned
    /// to the put record, unique to all records in the stream.
    /// </para>
    ///  
    /// <para>
    /// An unsuccessfully processed record includes <code>ErrorCode</code> and <code>ErrorMessage</code>
    /// values. <code>ErrorCode</code> reflects the type of error and can be one of the following
    /// values: <code>ProvisionedThroughputExceededException</code> or <code>InternalFailure</code>.
    /// <code>ErrorMessage</code> provides more detailed information about the <code>ProvisionedThroughputExceededException</code>
    /// exception including the account ID, stream name, and shard ID of the record that was
    /// throttled. For more information about partially successful responses, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-add-data-to-stream.html#kinesis-using-sdk-java-putrecords">Adding
    /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Data Streams Developer
    /// Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// After you write a record to a stream, you cannot modify that record or its order within
    /// the stream.
    /// </para>
    ///  </important> 
    /// <para>
    /// By default, data records are accessible for 24 hours from the time that they are added
    /// to a stream. You can use <a>IncreaseStreamRetentionPeriod</a> or <a>DecreaseStreamRetentionPeriod</a>
    /// to modify this retention period.
    /// </para>
    /// </summary>
    public partial class PutRecordsRequest : AmazonKinesisRequest
    {
        private List<PutRecordsRequestEntry> _records = new List<PutRecordsRequestEntry>();
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The records associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
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
        /// The stream name associated with the request.
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