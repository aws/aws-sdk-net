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
    /// Container for the parameters to the ReceiveDeadLetterQueueRecords operation. Receives
    /// up to 10 dead-letter records from the specified queue. Each queue has built-in dead-letter
    /// handling: when a record has been received <c>MaxReceiveCount</c> times without being
    /// acknowledged, it becomes a dead-letter record, which usually means your queue consumer
    /// could not process it. The dead-letter record stays in the same queue, and <a>ReceiveQueueRecords</a>
    /// no longer returns it. <para> Dead-letter records carry the same data and partition
    /// key as when they were first delivered, and are returned with a receipt handle. Use
    /// the receipt handle to acknowledge the record with <a>AcknowledgeDeadLetterQueueRecords</a>,
    /// which discards it, to change its visibility with <a>UpdateDeadLetterQueueRecordsVisibility</a>,
    /// or to restore it with <a>RestoreDeadLetterQueueRecords</a>, which returns it to the
    /// normal receive path so that <a>ReceiveQueueRecords</a> can return it again. </para>
    /// <para> Use this operation to inspect the records your queue consumer could not process,
    /// so you can correct the cause and then either acknowledge or restore them. </para>
    /// <para> A queue delivers dead-letter records while it is in the <c>ACTIVE</c> state.
    /// </para>
    /// </summary>
    public partial class ReceiveDeadLetterQueueRecordsRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of records to return. The queue never returns more dead-letter
        /// records than this value, and might return fewer. The default is 10.
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
        /// The ARN of the queue whose dead-letter records are received.
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
