/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Provides details of the <c>DecisionTaskTimedOut</c> event. </para>
    /// </summary>
    public class DecisionTaskTimedOutEventAttributes  
    {
        
        private string timeoutType;
        private long? scheduledEventId;
        private long? startedEventId;

        /// <summary>
        /// The type of timeout that expired before the decision task could be completed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>START_TO_CLOSE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TimeoutType
        {
            get { return this.timeoutType; }
            set { this.timeoutType = value; }
        }

        /// <summary>
        /// Sets the TimeoutType property
        /// </summary>
        /// <param name="timeoutType">The value to set for the TimeoutType property </param>
        /// <returns>this instance</returns>
        public DecisionTaskTimedOutEventAttributes WithTimeoutType(string timeoutType)
        {
            this.timeoutType = timeoutType;
            return this;
        }
            

        // Check to see if TimeoutType property is set
        internal bool IsSetTimeoutType()
        {
            return this.timeoutType != null;       
        }

        /// <summary>
        /// The id of the <c>DecisionTaskScheduled</c> event that was recorded when this decision task was scheduled. This information can be useful for
        /// diagnosing problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long ScheduledEventId
        {
            get { return this.scheduledEventId ?? default(long); }
            set { this.scheduledEventId = value; }
        }

        /// <summary>
        /// Sets the ScheduledEventId property
        /// </summary>
        /// <param name="scheduledEventId">The value to set for the ScheduledEventId property </param>
        /// <returns>this instance</returns>
        public DecisionTaskTimedOutEventAttributes WithScheduledEventId(long scheduledEventId)
        {
            this.scheduledEventId = scheduledEventId;
            return this;
        }
            

        // Check to see if ScheduledEventId property is set
        internal bool IsSetScheduledEventId()
        {
            return this.scheduledEventId.HasValue;       
        }

        /// <summary>
        /// The Id of the <c>DecisionTaskStarted</c> event recorded when this decision task was started. This information can be useful for diagnosing
        /// problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long StartedEventId
        {
            get { return this.startedEventId ?? default(long); }
            set { this.startedEventId = value; }
        }

        /// <summary>
        /// Sets the StartedEventId property
        /// </summary>
        /// <param name="startedEventId">The value to set for the StartedEventId property </param>
        /// <returns>this instance</returns>
        public DecisionTaskTimedOutEventAttributes WithStartedEventId(long startedEventId)
        {
            this.startedEventId = startedEventId;
            return this;
        }
            

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this.startedEventId.HasValue;       
        }
    }
}
