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
    /// Each <a>PutRecordBatch</a> request supports up to 500 records. Each record in the
    /// request can be as large as 1,000 KB (before 64-bit encoding), up to a limit of 4 MB
    /// for the entire request. By default, each delivery stream can take in up to 2,000 transactions
    /// per second, 5,000 records per second, or 5 MB per second. Note that if you use <a>PutRecord</a>
    /// and <a>PutRecordBatch</a>, the limits are an aggregate across these two operations
    /// for each delivery stream. For more information about limits and how to request an
    /// increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
    /// Kinesis Firehose Limits</a>. 
    /// </para>
    ///  
    /// <para>
    /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
    /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
    /// kind of data, for example, a segment from a log file, geographic location data, web
    /// site clickstream data, and so on.
    /// </para>
    ///  
    /// <para>
    /// Amazon Kinesis Firehose buffers records before delivering them to the destination.
    /// To disambiguate the data blobs at the destination, a common solution is to use delimiters
    /// in the data, such as a newline (<code>\n</code>) or some other character unique within
    /// the data. This allows the consumer application(s) to parse individual data items when
    /// reading the data from the destination.
    /// </para>
    ///  
    /// <para>
    /// The <a>PutRecordBatch</a> response includes a count of any failed records, <code>FailedPutCount</code>,
    /// and an array of responses, <code>RequestResponses</code>. The <code>FailedPutCount</code>
    /// value is a count of records that failed. Each entry in the <code>RequestResponses</code>
    /// array gives additional information of the processed record. Each entry in <code>RequestResponses</code>
    /// directly correlates with a record in the request array using the same ordering, from
    /// the top to the bottom of the request and response. <code>RequestResponses</code> always
    /// includes the same number of records as the request array. <code>RequestResponses</code>
    /// both successfully and unsuccessfully processed records. Amazon Kinesis Firehose attempts
    /// to process all records in each <a>PutRecordBatch</a> request. A single record failure
    /// does not stop the processing of subsequent records.
    /// </para>
    ///  
    /// <para>
    /// A successfully processed record includes a <code>RecordId</code> value, which is a
    /// unique value identified for the record. An unsuccessfully processed record includes
    /// <code>ErrorCode</code> and <code>ErrorMessage</code> values. <code>ErrorCode</code>
    /// reflects the type of error and is one of the following values: <code>ServiceUnavailable</code>
    /// or <code>InternalFailure</code>. <code>ErrorMessage</code> provides more detailed
    /// information about the error.
    /// </para>
    ///  
    /// <para>
    /// If <code>FailedPutCount</code> is greater than 0 (zero), retry the request. A retry
    /// of the entire batch of records is possible; however, we strongly recommend that you
    /// inspect the entire response and resend only those records that failed processing.
    /// This minimizes duplicate records and also reduces the total bytes sent (and corresponding
    /// charges).
    /// </para>
    ///  
    /// <para>
    /// If the <a>PutRecordBatch</a> operation throws a <code>ServiceUnavailableException</code>,
    /// back off and retry. If the exception persists, it is possible that the throughput
    /// limits have been exceeded for the delivery stream.
    /// </para>
    ///  
    /// <para>
    /// Data records sent to Amazon Kinesis Firehose are stored for 24 hours from the time
    /// they are added to a delivery stream as it attempts to send the records to the destination.
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