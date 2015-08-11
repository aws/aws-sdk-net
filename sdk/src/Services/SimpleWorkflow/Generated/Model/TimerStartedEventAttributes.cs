/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides details of the <code>TimerStarted</code> event.
    /// </summary>
    public partial class TimerStartedEventAttributes
    {
        private string _control;
        private long? _decisionTaskCompletedEventId;
        private string _startToFireTimeout;
        private string _timerId;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// <i>Optional.</i> Data attached to the event that can be used by the decider in subsequent
        /// workflow tasks.
        /// </para>
        /// </summary>
        public string Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <code>DecisionTaskCompleted</code> event corresponding to the decision
        /// task that resulted in the <code>StartTimer</code> decision for this activity task.
        /// This information can be useful for diagnosing problems by tracing back the chain of
        /// events leading up to this event.
        /// </para>
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId.GetValueOrDefault(); }
            set { this._decisionTaskCompletedEventId = value; }
        }

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this._decisionTaskCompletedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartToFireTimeout. 
        /// <para>
        /// The duration of time after which the timer will fire.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds; an integer greater than or equal to 0.
        /// </para>
        /// </summary>
        public string StartToFireTimeout
        {
            get { return this._startToFireTimeout; }
            set { this._startToFireTimeout = value; }
        }

        // Check to see if StartToFireTimeout property is set
        internal bool IsSetStartToFireTimeout()
        {
            return this._startToFireTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property TimerId. 
        /// <para>
        /// The unique ID of the timer that was started.
        /// </para>
        /// </summary>
        public string TimerId
        {
            get { return this._timerId; }
            set { this._timerId = value; }
        }

        // Check to see if TimerId property is set
        internal bool IsSetTimerId()
        {
            return this._timerId != null;
        }

    }
}