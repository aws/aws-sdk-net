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
    /// Container for the parameters to the CancelMessageMoveTask operation.
    /// Cancels a specified message movement task. A message movement can only be cancelled
    /// when the current status is RUNNING. Cancelling a message movement task does not revert
    /// the messages that have already been moved. It can only stop the messages that have
    /// not been moved yet.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// This action is currently limited to supporting message redrive from <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter
    /// queues (DLQs)</a> only. In this context, the source queue is the dead-letter queue
    /// (DLQ), while the destination queue can be the original source queue (from which the
    /// messages were driven to the dead-letter-queue), or a custom destination queue. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only one active message movement task is supported per queue at any given time.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CancelMessageMoveTaskRequest : AmazonSQSRequest
    {
        private string _taskHandle;

        /// <summary>
        /// Gets and sets the property TaskHandle. 
        /// <para>
        /// An identifier associated with a message movement task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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