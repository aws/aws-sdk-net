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
    /// Container for the parameters to the PutRecord operation.
    /// Writes a single data record into an Amazon Kinesis Data Firehose delivery stream.
    /// To write multiple data records into a delivery stream, use <a>PutRecordBatch</a>.
    /// Applications using these operations are referred to as producers.
    /// 
    ///  
    /// <para>
    /// By default, each delivery stream can take in up to 2,000 transactions per second,
    /// 5,000 records per second, or 5 MB per second. If you use <a>PutRecord</a> and <a>PutRecordBatch</a>,
    /// the limits are an aggregate across these two operations for each delivery stream.
    /// For more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
    /// Kinesis Data Firehose Limits</a>. 
    /// </para>
    ///  
    /// <para>
    /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
    /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
    /// kind of data. For example, it can be a segment from a log file, geographic location
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
    /// The <code>PutRecord</code> operation returns a <code>RecordId</code>, which is a unique
    /// string assigned to each record. Producer applications can use this ID for purposes
    /// such as auditability and investigation.
    /// </para>
    ///  
    /// <para>
    /// If the <code>PutRecord</code> operation throws a <code>ServiceUnavailableException</code>,
    /// back off and retry. If the exception persists, it is possible that the throughput
    /// limits have been exceeded for the delivery stream. 
    /// </para>
    ///  
    /// <para>
    /// Data records sent to Kinesis Data Firehose are stored for 24 hours from the time they
    /// are added to a delivery stream as it tries to send the records to the destination.
    /// If the destination is unreachable for more than 24 hours, the data is no longer available.
    /// </para>
    /// </summary>
    public partial class PutRecordRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;
        private Record _record;

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
        /// Gets and sets the property Record. 
        /// <para>
        /// The record.
        /// </para>
        /// </summary>
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