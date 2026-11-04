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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <c>DecisionTaskTimedOut</c> event.
    /// </summary>
    public partial class DecisionTaskTimedOutEventAttributes
    {
        /// <summary>
        /// Gets and sets the property ScheduledEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskScheduled</c> event that was recorded when this decision
        /// task was scheduled. This information can be useful for diagnosing problems by tracing
        /// back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ScheduledEventId { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledEventId property is set.
        /// </summary>
        internal bool IsSetScheduledEventId() => this.ScheduledEventId.HasValue;

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskStarted</c> event recorded when this decision task was
        /// started. This information can be useful for diagnosing problems by tracing back the
        /// chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StartedEventId { get; set; }

        /// <summary>
        /// Checks to see if the StartedEventId property is set.
        /// </summary>
        internal bool IsSetStartedEventId() => this.StartedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutType. 
        /// <para>
        /// The type of timeout that expired before the decision task could be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DecisionTaskTimeoutType TimeoutType { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutType property is set.
        /// </summary>
        internal bool IsSetTimeoutType() => this.TimeoutType != null;
    }
}
