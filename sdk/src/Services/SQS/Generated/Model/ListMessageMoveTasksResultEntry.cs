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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
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
        private long? _approximateNumberOfMessagesMoved;
        private long? _approximateNumberOfMessagesToMove;
        private string _destinationArn;
        private string _failureReason;
        private int? _maxNumberOfMessagesPerSecond;
        private string _sourceArn;
        private long? _startedTimestamp;
        private string _status;
        private string _taskHandle;

        /// <summary>
        /// Gets and sets the property ApproximateNumberOfMessagesMoved. 
        /// <para>
        /// The approximate number of messages already moved to the destination queue.
        /// </para>
        /// </summary>
        public long? ApproximateNumberOfMessagesMoved
        {
            get { return this._approximateNumberOfMessagesMoved; }
            set { this._approximateNumberOfMessagesMoved = value; }
        }

        // Check to see if ApproximateNumberOfMessagesMoved property is set
        internal bool IsSetApproximateNumberOfMessagesMoved()
        {
            return this._approximateNumberOfMessagesMoved.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApproximateNumberOfMessagesToMove. 
        /// <para>
        /// The number of messages to be moved from the source queue. This number is obtained
        /// at the time of starting the message movement task and is only included after the message
        /// movement task is selected to start.
        /// </para>
        /// </summary>
        public long? ApproximateNumberOfMessagesToMove
        {
            get { return this._approximateNumberOfMessagesToMove; }
            set { this._approximateNumberOfMessagesToMove = value; }
        }

        // Check to see if ApproximateNumberOfMessagesToMove property is set
        internal bool IsSetApproximateNumberOfMessagesToMove()
        {
            return this._approximateNumberOfMessagesToMove.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the destination queue if it has been specified in the <c>StartMessageMoveTask</c>
        /// request. If a <c>DestinationArn</c> has not been specified in the <c>StartMessageMoveTask</c>
        /// request, this field value will be NULL.
        /// </para>
        /// </summary>
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The task failure reason (only included if the task status is FAILED).
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property MaxNumberOfMessagesPerSecond. 
        /// <para>
        /// The number of messages to be moved per second (the message movement rate), if it has
        /// been specified in the <c>StartMessageMoveTask</c> request. If a <c>MaxNumberOfMessagesPerSecond</c>
        /// has not been specified in the <c>StartMessageMoveTask</c> request, this field value
        /// will be NULL.
        /// </para>
        /// </summary>
        public int? MaxNumberOfMessagesPerSecond
        {
            get { return this._maxNumberOfMessagesPerSecond; }
            set { this._maxNumberOfMessagesPerSecond = value; }
        }

        // Check to see if MaxNumberOfMessagesPerSecond property is set
        internal bool IsSetMaxNumberOfMessagesPerSecond()
        {
            return this._maxNumberOfMessagesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the queue that contains the messages to be moved to another queue.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedTimestamp. 
        /// <para>
        /// The timestamp of starting the message movement task.
        /// </para>
        /// </summary>
        public long? StartedTimestamp
        {
            get { return this._startedTimestamp; }
            set { this._startedTimestamp = value; }
        }

        // Check to see if StartedTimestamp property is set
        internal bool IsSetStartedTimestamp()
        {
            return this._startedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the message movement task. Possible values are: RUNNING, COMPLETED,
        /// CANCELLING, CANCELLED, and FAILED.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaskHandle. 
        /// <para>
        /// An identifier associated with a message movement task. When this field is returned
        /// in the response of the <c>ListMessageMoveTasks</c> action, it is only populated for
        /// tasks that are in RUNNING status.
        /// </para>
        /// </summary>
        public string TaskHandle
        {
            get { return this._taskHandle; }
            set { this._taskHandle = value; }
        }

        // Check to see if TaskHandle property is set
        internal bool IsSetTaskHandle()
        {
            return this._taskHandle != null;
        }

    }
}