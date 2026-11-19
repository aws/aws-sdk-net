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
    /// Container for the parameters to the ReceiveQueueRecords operation. Receives up to
    /// 10 records from the specified queue. Each record is returned with a receipt handle,
    /// which is the identifier you use to acknowledge the record or change its visibility.
    /// <para> A record returned by <c>ReceiveQueueRecords</c> becomes in flight: it is not
    /// visible to any consumer instance for the duration of its visibility timeout, so subsequent
    /// receive requests do not return it while your queue consumer processes it. Acknowledge
    /// the record with <a>AcknowledgeQueueRecords</a> when you finish processing it. A record
    /// that is not acknowledged before its visibility timeout expires becomes visible in
    /// the queue again and can be received by any consumer instance. </para> <para> Use <c>WaitTimeSeconds</c>
    /// to control how long the call waits for a record to become visible before returning.
    /// If a record becomes visible sooner, the call returns sooner. If the wait time expires
    /// and no records are visible, the call returns an empty list of records. </para> <para>
    /// Records are not necessarily received in the order they were written to the data stream.
    /// </para> <para> A queue delivers records while it is in the <c>ACTIVE</c> state. </para>
    /// <para> On rare occasions, a queue can deliver a record more than once. Design your
    /// queue consumer to be idempotent, so that processing the same record more than once
    /// is safe. </para>
    /// </summary>
    public partial class ReceiveQueueRecordsRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of records to return. The queue never returns more records than
        /// this value, and might return fewer. The default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property QueueARN. 
        /// <para>
        /// The ARN of the queue to receive records from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string QueueARN { get; set; }

        /// <summary>
        /// Checks to see if the QueueARN property is set.
        /// </summary>
        internal bool IsSetQueueARN() => this.QueueARN != null;

        /// <summary>
        /// Gets and sets the property VisibilityTimeoutSeconds. 
        /// <para>
        /// The duration, in seconds, that the records returned by this request are in flight
        /// and not visible to any consumer instance. If you do not specify this value, the queue's
        /// visibility timeout is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 43200)]
        public int? VisibilityTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetVisibilityTimeoutSeconds() => this.VisibilityTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property WaitTimeSeconds. 
        /// <para>
        /// The duration, in seconds, that the call waits for a record to become visible before
        /// returning. The default is 9.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? WaitTimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the WaitTimeSeconds property is set.
        /// </summary>
        internal bool IsSetWaitTimeSeconds() => this.WaitTimeSeconds.HasValue;
    }
}
