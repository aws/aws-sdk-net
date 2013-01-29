/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Provides details of the <c>ActivityTaskStarted</c> event. </para>
    /// </summary>
    public class ActivityTaskStartedEventAttributes
    {
        
        private string identity;
        private long? scheduledEventId;

        /// <summary>
        /// Identity of the worker that was assigned this task. This aids diagnostics when problems arise. The form of this identity is user defined.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Identity
        {
            get { return this.identity; }
            set { this.identity = value; }
        }

        /// <summary>
        /// Sets the Identity property
        /// </summary>
        /// <param name="identity">The value to set for the Identity property </param>
        /// <returns>this instance</returns>
        public ActivityTaskStartedEventAttributes WithIdentity(string identity)
        {
            this.identity = identity;
            return this;
        }
            

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this.identity != null;
        }

        /// <summary>
        /// The id of the <c>ActivityTaskScheduled</c> event that was recorded when this activity task was scheduled. This information can be useful for
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
        public ActivityTaskStartedEventAttributes WithScheduledEventId(long scheduledEventId)
        {
            this.scheduledEventId = scheduledEventId;
            return this;
        }
            

        // Check to see if ScheduledEventId property is set
        internal bool IsSetScheduledEventId()
        {
            return this.scheduledEventId.HasValue;
        }
    }
}
