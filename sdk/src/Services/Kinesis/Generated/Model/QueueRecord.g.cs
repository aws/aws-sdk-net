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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// A data stream record, as delivered through a queue.
    /// </summary>
    public partial class QueueRecord
    {
        /// <summary>
        /// Gets and sets the property ApproximateArrivalTimestamp. 
        /// <para>
        /// The approximate time the record arrived in the data stream. The difference between
        /// this value and the current time is how long the record took to reach your queue consumer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ApproximateArrivalTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateArrivalTimestamp property is set.
        /// </summary>
        internal bool IsSetApproximateArrivalTimestamp() => this.ApproximateArrivalTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data blob of the record. Amazon Kinesis Data Streams does not inspect, interpret,
        /// or change the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10485760)]
        public MemoryStream Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property FirstReceiveTimestamp. 
        /// <para>
        /// The approximate time the record was first received from the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? FirstReceiveTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the FirstReceiveTimestamp property is set.
        /// </summary>
        internal bool IsSetFirstReceiveTimestamp() => this.FirstReceiveTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// The partition key the record was written to the data stream with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PartitionKey { get; set; }

        /// <summary>
        /// Checks to see if the PartitionKey property is set.
        /// </summary>
        internal bool IsSetPartitionKey() => this.PartitionKey != null;

        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// <para>
        /// The identifier you use to acknowledge this record, change its visibility, or restore
        /// it after it becomes a dead-letter record. A new receipt handle is issued each time
        /// the record is received.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ReceiptHandle { get; set; }

        /// <summary>
        /// Checks to see if the ReceiptHandle property is set.
        /// </summary>
        internal bool IsSetReceiptHandle() => this.ReceiptHandle != null;

        /// <summary>
        /// Gets and sets the property ReceiveCount. 
        /// <para>
        /// The number of times this record has been received without being acknowledged.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? ReceiveCount { get; set; }

        /// <summary>
        /// Checks to see if the ReceiveCount property is set.
        /// </summary>
        internal bool IsSetReceiveCount() => this.ReceiveCount.HasValue;

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The unique identifier of the record. This value stays the same across every delivery
        /// of the record, and it is the same in every queue on the stream that delivers the record.
        /// To identify a single delivery, use <c>ReceiptHandle</c> instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;
    }
}
