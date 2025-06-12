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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the PutRecordBatch operation.
    /// Writes multiple data records into a Firehose stream in a single call, which can achieve
    /// higher throughput per producer than when writing single records. To write single data
    /// records into a Firehose stream, use <a>PutRecord</a>. Applications using these operations
    /// are referred to as producers.
    /// 
    ///  
    /// <para>
    /// Firehose accumulates and publishes a particular metric for a customer account in one
    /// minute intervals. It is possible that the bursts of incoming bytes/records ingested
    /// to a Firehose stream last only for a few seconds. Due to this, the actual spikes in
    /// the traffic might not be fully visible in the customer's 1 minute CloudWatch metrics.
    /// </para>
    ///  
    /// <para>
    /// For information about service quota, see <a href="https://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
    /// Firehose Quota</a>.
    /// </para>
    ///  
    /// <para>
    /// Each <a>PutRecordBatch</a> request supports up to 500 records. Each record in the
    /// request can be as large as 1,000 KB (before base64 encoding), up to a limit of 4 MB
    /// for the entire request. These limits cannot be changed.
    /// </para>
    ///  
    /// <para>
    /// You must specify the name of the Firehose stream and the data record when using <a>PutRecord</a>.
    /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
    /// kind of data. For example, it could be a segment from a log file, geographic location
    /// data, website clickstream data, and so on.
    /// </para>
    ///  
    /// <para>
    /// For multi record de-aggregation, you can not put more than 500 records even if the
    /// data blob length is less than 1000 KiB. If you include more than 500 records, the
    /// request succeeds but the record de-aggregation doesn't work as expected and transformation
    /// lambda is invoked with the complete base64 encoded data blob instead of de-aggregated
    /// base64 decoded records.
    /// </para>
    ///  
    /// <para>
    /// Firehose buffers records before delivering them to the destination. To disambiguate
    /// the data blobs at the destination, a common solution is to use delimiters in the data,
    /// such as a newline (<c>\n</c>) or some other character unique within the data. This
    /// allows the consumer application to parse individual data items when reading the data
    /// from the destination.
    /// </para>
    ///  
    /// <para>
    /// The <a>PutRecordBatch</a> response includes a count of failed records, <c>FailedPutCount</c>,
    /// and an array of responses, <c>RequestResponses</c>. Even if the <a>PutRecordBatch</a>
    /// call succeeds, the value of <c>FailedPutCount</c> may be greater than 0, indicating
    /// that there are records for which the operation didn't succeed. Each entry in the <c>RequestResponses</c>
    /// array provides additional information about the processed record. It directly correlates
    /// with a record in the request array using the same ordering, from the top to the bottom.
    /// The response array always includes the same number of records as the request array.
    /// <c>RequestResponses</c> includes both successfully and unsuccessfully processed records.
    /// Firehose tries to process all records in each <a>PutRecordBatch</a> request. A single
    /// record failure does not stop the processing of subsequent records. 
    /// </para>
    ///  
    /// <para>
    /// A successfully processed record includes a <c>RecordId</c> value, which is unique
    /// for the record. An unsuccessfully processed record includes <c>ErrorCode</c> and <c>ErrorMessage</c>
    /// values. <c>ErrorCode</c> reflects the type of error, and is one of the following values:
    /// <c>ServiceUnavailableException</c> or <c>InternalFailure</c>. <c>ErrorMessage</c>
    /// provides more detailed information about the error.
    /// </para>
    ///  
    /// <para>
    /// If there is an internal server error or a timeout, the write might have completed
    /// or it might have failed. If <c>FailedPutCount</c> is greater than 0, retry the request,
    /// resending only those records that might have failed processing. This minimizes the
    /// possible duplicate records and also reduces the total bytes sent (and corresponding
    /// charges). We recommend that you handle any duplicates at the destination.
    /// </para>
    ///  
    /// <para>
    /// If <a>PutRecordBatch</a> throws <c>ServiceUnavailableException</c>, the API is automatically
    /// reinvoked (retried) 3 times. If the exception persists, it is possible that the throughput
    /// limits have been exceeded for the Firehose stream.
    /// </para>
    ///  
    /// <para>
    /// Re-invoking the Put API operations (for example, PutRecord and PutRecordBatch) can
    /// result in data duplicates. For larger data assets, allow for a longer time out before
    /// retrying Put API operations.
    /// </para>
    ///  
    /// <para>
    /// Data records sent to Firehose are stored for 24 hours from the time they are added
    /// to a Firehose stream as it attempts to send the records to the destination. If the
    /// destination is unreachable for more than 24 hours, the data is no longer available.
    /// </para>
    ///  <important> 
    /// <para>
    /// Don't concatenate two or more base64 strings to form the data fields of your records.
    /// Instead, concatenate the raw data, then perform base64 encoding.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutRecordBatchRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;
        private List<Record> _records = AWSConfigs.InitializeCollections ? new List<Record>() : null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public List<Record> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}