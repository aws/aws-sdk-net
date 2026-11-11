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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the queue and channel for which priority and delay can
    /// be set.
    /// </summary>
    public partial class RoutingProfileQueueConfig
    {
        /// <summary>
        /// Gets and sets the property Delay. 
        /// <para>
        /// The delay, in seconds, a contact should be in the queue before they are routed to
        /// an available agent. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-routing-profiles-priority.html">Queues:
        /// priority and delay</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 9999)]
        public int? Delay { get; set; }

        /// <summary>
        /// Checks to see if the Delay property is set.
        /// </summary>
        internal bool IsSetDelay() => this.Delay.HasValue;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The order in which contacts are to be handled for the queue. For more information,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-routing-profiles-priority.html">Queues:
        /// priority and delay</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 99)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property QueueReference. 
        /// <para>
        /// Contains information about a queue resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RoutingProfileQueueReference QueueReference { get; set; }

        /// <summary>
        /// Checks to see if the QueueReference property is set.
        /// </summary>
        internal bool IsSetQueueReference() => this.QueueReference != null;
    }
}
