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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Contains the details of a message movement task.
    /// </summary>
    public partial class ListMessageMoveTasksResultEntry
    {
        /// <summary>
        /// Gets and sets the property ApproximateNumberOfMessagesMoved. 
        /// <para>
        /// The approximate number of messages already moved to the destination queue.
        /// </para>
        /// </summary>
        public long? ApproximateNumberOfMessagesMoved { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateNumberOfMessagesMoved property is set.
        /// </summary>
        internal bool IsSetApproximateNumberOfMessagesMoved() => this.ApproximateNumberOfMessagesMoved.HasValue;

        /// <summary>
        /// Gets and sets the property ApproximateNumberOfMessagesToMove. 
        /// <para>
        /// The number of messages to be moved from the source queue. This number is obtained
        /// at the time of starting the message movement task and is only included after the message
        /// movement task is selected to start.
        /// </para>
        /// </summary>
        public long? ApproximateNumberOfMessagesToMove { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateNumberOfMessagesToMove property is set.
        /// </summary>
        internal bool IsSetApproximateNumberOfMessagesToMove() => this.ApproximateNumberOfMessagesToMove.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the destination queue if it has been specified in the <c>StartMessageMoveTask</c>
        /// request. If a <c>DestinationArn</c> has not been specified in the <c>StartMessageMoveTask</c>
        /// request, this field value will be NULL.
        /// </para>
        /// </summary>
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The task failure reason (only included if the task status is FAILED).
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property MaxNumberOfMessagesPerSecond. 
        /// <para>
        /// The number of messages to be moved per second (the message movement rate), if it has
        /// been specified in the <c>StartMessageMoveTask</c> request. If a <c>MaxNumberOfMessagesPerSecond</c>
        /// has not been specified in the <c>StartMessageMoveTask</c> request, this field value
        /// will be NULL.
        /// </para>
        /// </summary>
        public int? MaxNumberOfMessagesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the MaxNumberOfMessagesPerSecond property is set.
        /// </summary>
        internal bool IsSetMaxNumberOfMessagesPerSecond() => this.MaxNumberOfMessagesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the queue that contains the messages to be moved to another queue.
        /// </para>
        /// </summary>
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property StartedTimestamp. 
        /// <para>
        /// The timestamp of starting the message movement task.
        /// </para>
        /// </summary>
        public long? StartedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartedTimestamp property is set.
        /// </summary>
        internal bool IsSetStartedTimestamp() => this.StartedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the message movement task. Possible values are: RUNNING, COMPLETED,
        /// CANCELLING, CANCELLED, and FAILED.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskHandle. 
        /// <para>
        /// An identifier associated with a message movement task. When this field is returned
        /// in the response of the <c>ListMessageMoveTasks</c> action, it is only populated for
        /// tasks that are in RUNNING status.
        /// </para>
        /// </summary>
        public string TaskHandle { get; set; }

        /// <summary>
        /// Checks to see if the TaskHandle property is set.
        /// </summary>
        internal bool IsSetTaskHandle() => this.TaskHandle != null;
    }
}
