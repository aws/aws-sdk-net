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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// The queue information for the specified quantum task.
    /// </summary>
    public partial class QuantumTaskQueueInfo
    {
        private string _message;
        private string _position;
        private QueueName _queue;
        private QueuePriority _queuePriority;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Optional. Provides more information about the queue position. For example, if the
        /// quantum task is complete and no longer in the queue, the message field contains that
        /// information.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Current position of the quantum task in the quantum tasks queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property Queue. 
        /// <para>
        /// The name of the queue. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueueName Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

        /// <summary>
        /// Gets and sets the property QueuePriority. 
        /// <para>
        /// Optional. Specifies the priority of the queue. Quantum tasks in a priority queue are
        /// processed before the quantum tasks in a normal queue.
        /// </para>
        /// </summary>
        public QueuePriority QueuePriority
        {
            get { return this._queuePriority; }
            set { this._queuePriority = value; }
        }

        // Check to see if QueuePriority property is set
        internal bool IsSetQueuePriority()
        {
            return this._queuePriority != null;
        }

    }
}