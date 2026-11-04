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
    /// Provides the details of the <c>TimerCanceled</c> event.
    /// </summary>
    public partial class TimerCanceledEventAttributes
    {
        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskCompleted</c> event corresponding to the decision task
        /// that resulted in the <c>CancelTimer</c> decision to cancel this timer. This information
        /// can be useful for diagnosing problems by tracing back the chain of events leading
        /// up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? DecisionTaskCompletedEventId { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskCompletedEventId property is set.
        /// </summary>
        internal bool IsSetDecisionTaskCompletedEventId() => this.DecisionTaskCompletedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        /// The ID of the <c>TimerStarted</c> event that was recorded when this timer was started.
        /// This information can be useful for diagnosing problems by tracing back the chain of
        /// events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StartedEventId { get; set; }

        /// <summary>
        /// Checks to see if the StartedEventId property is set.
        /// </summary>
        internal bool IsSetStartedEventId() => this.StartedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property TimerId. 
        /// <para>
        /// The unique ID of the timer that was canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TimerId { get; set; }

        /// <summary>
        /// Checks to see if the TimerId property is set.
        /// </summary>
        internal bool IsSetTimerId() => this.TimerId != null;
    }
}
