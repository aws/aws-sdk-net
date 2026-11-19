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
    /// Container for the parameters to the UpdateQueue operation. Updates the configuration
    /// attributes of the specified queue. You can change the queue's visibility timeout,
    /// its dead-letter handling configuration, or both. <para> A new visibility timeout applies
    /// to records received after the update completes. Records that are already in flight
    /// keep the visibility timeout they were received with. To change the visibility timeout
    /// of a record that is already in flight, use <a>UpdateQueueRecordsVisibility</a>. </para>
    /// <para> <c>UpdateQueue</c> is an asynchronous operation. Upon receiving an <c>UpdateQueue</c>
    /// request, Amazon Kinesis Data Streams sets the <c>QueueStatus</c> to <c>UPDATING</c>,
    /// and sets it back to <c>ACTIVE</c> when the update is complete. You can continue to
    /// receive and acknowledge records while the queue is <c>UPDATING</c>. </para> <para>
    /// You can't change the data stream or the starting position of a queue after you create
    /// it. To read from a different stream or position, create a new queue. </para>
    /// </summary>
    public partial class UpdateQueueRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property QueueARN. 
        /// <para>
        /// The ARN of the queue to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string QueueARN { get; set; }

        /// <summary>
        /// Checks to see if the QueueARN property is set.
        /// </summary>
        internal bool IsSetQueueARN() => this.QueueARN != null;

        /// <summary>
        /// Gets and sets the property QueueAttributes. 
        /// <para>
        /// The configuration attributes to apply to the queue. Attributes you do not specify
        /// are left unchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueueAttributes QueueAttributes { get; set; }

        /// <summary>
        /// Checks to see if the QueueAttributes property is set.
        /// </summary>
        internal bool IsSetQueueAttributes() => this.QueueAttributes != null;
    }
}
