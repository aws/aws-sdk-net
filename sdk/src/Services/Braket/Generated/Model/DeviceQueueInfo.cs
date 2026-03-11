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
    /// Information about quantum tasks and hybrid jobs queued on a device.
    /// </summary>
    public partial class DeviceQueueInfo
    {
        private QueueName _queue;
        private QueuePriority _queuePriority;
        private string _queueSize;

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

        /// <summary>
        /// Gets and sets the property QueueSize. 
        /// <para>
        /// The number of hybrid jobs or quantum tasks in the queue for a given device. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueSize
        {
            get { return this._queueSize; }
            set { this._queueSize = value; }
        }

        // Check to see if QueueSize property is set
        internal bool IsSetQueueSize()
        {
            return this._queueSize != null;
        }

    }
}