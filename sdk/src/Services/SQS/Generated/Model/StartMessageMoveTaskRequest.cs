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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the StartMessageMoveTask operation.
    /// Starts an asynchronous task to move messages from a specified source queue to a specified
    /// destination queue.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// This action is currently limited to supporting message redrive from dead-letter queues
    /// (DLQs) only. In this context, the source queue is the dead-letter queue (DLQ), while
    /// the destination queue can be the original source queue (from which the messages were
    /// driven to the dead-letter-queue), or a custom destination queue. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Currently, only standard queues are supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only one active message movement task is supported per queue at any given time.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class StartMessageMoveTaskRequest : AmazonSQSRequest
    {
        private string _destinationArn;
        private int? _maxNumberOfMessagesPerSecond;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the queue that receives the moved messages. You can use this field to specify
        /// the destination queue where you would like to redrive messages. If this field is left
        /// blank, the messages will be redriven back to their respective original source queues.
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
        /// Gets and sets the property MaxNumberOfMessagesPerSecond. 
        /// <para>
        /// The number of messages to be moved per second (the message movement rate). You can
        /// use this field to define a fixed message movement rate. The maximum value for messages
        /// per second is 500. If this field is left blank, the system will optimize the rate
        /// based on the queue message backlog size, which may vary throughout the duration of
        /// the message movement task.
        /// </para>
        /// </summary>
        public int MaxNumberOfMessagesPerSecond
        {
            get { return this._maxNumberOfMessagesPerSecond.GetValueOrDefault(); }
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
        /// The ARN of the queue that contains the messages to be moved to another queue. Currently,
        /// only dead-letter queue (DLQ) ARNs are accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}