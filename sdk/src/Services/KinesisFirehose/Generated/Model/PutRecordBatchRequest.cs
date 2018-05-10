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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the PutRecordBatch operation.
    /// Writes multiple data records into a delivery stream in a single call, which can achieve
    /// higher throughput per producer than when writing single records. To write single data
    /// records into a delivery stream, use <a>PutRecord</a>. Applications using these operations
    /// are referred to as producers.
    /// 
    ///  
    /// <para>
    /// By default, each delivery stream can take in up to 2,000 transactions per second,
    /// 5,000 records per second, or 5 MB per second. If you use <a>PutRecord</a> and <a>PutRecordBatch</a>,
    /// the limits are an aggregate across these two operations for each delivery stream.
    /// For more information about limits, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
    /// Kinesis Data Firehose Limits</a>.
    /// </para>
    ///  
    /// <para>
    /// Each <a>PutRecordBatch</a> request supports up to 500 records. Each record in the
    /// request can be as large as 1,000 KB (before 64-bit encoding), up to a limit of 4 MB
    /// for the entire request. These limits cannot be changed.
    /// </para>
    ///  
    /// <para>
    /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
    /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
    /// kind of data. For example, it could be a segment from a log file, geographic location
    /// data, website clickstream data, and so on.
    /// </para>
    ///  
    /// <para>
    /// Kinesis Data Firehose buffers records before delivering them to the destination. To
    /// disambiguate the data blobs at the destination, a common solution is to use delimiters
    /// in the data, such as a newline (<code>\n</code>) or some other character unique within
    /// the data. This allows the consumer application to parse individual data items when
    /// reading the data from the destination.
    /// </para>
    ///  
    /// <para>
    /// The <a>PutRecordBatch</a> response includes a count of failed records, <b>FailedPutCount</b>,
    /// and an array of responses, <b>RequestResponses</b>. Each entry in the <b>RequestResponses</b>
    /// array provides additional information about the processed record. It directly correlates
    /// with a record in the request array using the same ordering, from the top to the bottom.
    /// The response array always includes the same number of records as the request array.
    /// <b>RequestResponses</b> includes both successfully and unsuccessfully processed records.
    /// Kinesis Data Firehose tries to process all records in each <a>PutRecordBatch</a> request.
    /// A single record failure does not stop the processing of subsequent records.
    /// </para>
    ///  
    /// <para>
    /// A successfully processed record includes a <b>RecordId</b> value, which is unique
    /// for the record. An unsuccessfully processed record includes <b>ErrorCode</b> and <b>ErrorMessage</b>
    /// values. <b>ErrorCode</b> reflects the type of error, and is one of the following values:
    /// <code>ServiceUnavailable</code> or <code>InternalFailure</code>. <b>ErrorMessage</b>
    /// provides more detailed information about the error.
    /// </para>
    ///  
    /// <para>
    /// If there is an internal server error or a timeout, the write might have completed
    /// or it might have failed. If <b>FailedPutCount</b> is greater than 0, retry the request,
    /// resending only those records that might have failed processing. This minimizes the
    /// possible duplicate records and also reduces the total bytes sent (and corresponding
    /// charges). We recommend that you handle any duplicates at the destination.
    /// </para>
    ///  
    /// <para>
    /// If <a>PutRecordBatch</a> throws <b>ServiceUnavailableException</b>, back off and retry.
    /// If the exception persists, it is possible that the throughput limits have been exceeded
    /// for the delivery stream.
    /// </para>
    ///  
    /// <para>
    /// Data records sent to Kinesis Data Firehose are stored for 24 hours from the time they
    /// are added to a delivery stream as it attempts to send the records to the destination.
    /// If the destination is unreachable for more than 24 hours, the data is no longer available.
    /// </para>
    /// </summary>
    public partial class PutRecordBatchRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;
        private List<Record> _records = new List<Record>();

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream.
        /// </para>
        /// </summary>
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// One or more records.
        /// </para>
        /// </summary>
        public List<Record> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && this._records.Count > 0; 
        }

    }
}