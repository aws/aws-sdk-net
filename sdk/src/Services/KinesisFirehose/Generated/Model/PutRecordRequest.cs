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
    /// Container for the parameters to the PutRecord operation.
    /// Writes a single data record into an Firehose stream. To write multiple data records
    /// into a Firehose stream, use <a>PutRecordBatch</a>. Applications using these operations
    /// are referred to as producers.
    /// 
    ///  
    /// <para>
    /// By default, each Firehose stream can take in up to 2,000 transactions per second,
    /// 5,000 records per second, or 5 MB per second. If you use <a>PutRecord</a> and <a>PutRecordBatch</a>,
    /// the limits are an aggregate across these two operations for each Firehose stream.
    /// For more information about limits and how to request an increase, see <a href="https://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
    /// Firehose Limits</a>. 
    /// </para>
    ///  
    /// <para>
    /// Firehose accumulates and publishes a particular metric for a customer account in one
    /// minute intervals. It is possible that the bursts of incoming bytes/records ingested
    /// to a Firehose stream last only for a few seconds. Due to this, the actual spikes in
    /// the traffic might not be fully visible in the customer's 1 minute CloudWatch metrics.
    /// </para>
    ///  
    /// <para>
    /// You must specify the name of the Firehose stream and the data record when using <a>PutRecord</a>.
    /// The data record consists of a data blob that can be up to 1,000 KiB in size, and any
    /// kind of data. For example, it can be a segment from a log file, geographic location
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
    /// The <c>PutRecord</c> operation returns a <c>RecordId</c>, which is a unique string
    /// assigned to each record. Producer applications can use this ID for purposes such as
    /// auditability and investigation.
    /// </para>
    ///  
    /// <para>
    /// If the <c>PutRecord</c> operation throws a <c>ServiceUnavailableException</c>, the
    /// API is automatically reinvoked (retried) 3 times. If the exception persists, it is
    /// possible that the throughput limits have been exceeded for the Firehose stream. 
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
    /// to a Firehose stream as it tries to send the records to the destination. If the destination
    /// is unreachable for more than 24 hours, the data is no longer available.
    /// </para>
    ///  <important> 
    /// <para>
    /// Don't concatenate two or more base64 strings to form the data fields of your records.
    /// Instead, concatenate the raw data, then perform base64 encoding.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutRecordRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;
        private Record _record;

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
        /// Gets and sets the property Record. 
        /// <para>
        /// The record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Record Record
        {
            get { return this._record; }
            set { this._record = value; }
        }

        // Check to see if Record property is set
        internal bool IsSetRecord()
        {
            return this._record != null;
        }

    }
}