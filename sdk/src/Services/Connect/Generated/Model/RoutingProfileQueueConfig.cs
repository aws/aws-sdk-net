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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the queue and channel for which priority and delay can
    /// be set.
    /// </summary>
    public partial class RoutingProfileQueueConfig
    {
        private int? _delay;
        private int? _priority;
        private RoutingProfileQueueReference _queueReference;

        /// <summary>
        /// Gets and sets the property Delay. 
        /// <para>
        /// The delay, in seconds, a contact should be in the queue before they are routed to
        /// an available agent. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-routing-profiles-priority.html">Queues:
        /// priority and delay</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=9999)]
        public int? Delay
        {
            get { return this._delay; }
            set { this._delay = value; }
        }

        // Check to see if Delay property is set
        internal bool IsSetDelay()
        {
            return this._delay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The order in which contacts are to be handled for the queue. For more information,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-routing-profiles-priority.html">Queues:
        /// priority and delay</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=99)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueReference. 
        /// <para>
        /// Contains information about a queue resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutingProfileQueueReference QueueReference
        {
            get { return this._queueReference; }
            set { this._queueReference = value; }
        }

        // Check to see if QueueReference property is set
        internal bool IsSetQueueReference()
        {
            return this._queueReference != null;
        }

    }
}