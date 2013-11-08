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
    /// <para> Provides details of the <c>ActivityTaskCanceled</c> event. </para>
    /// </summary>
    public class ActivityTaskCanceledEventAttributes
    {
        
        private string details;
        private long? scheduledEventId;
        private long? startedEventId;
        private long? latestCancelRequestedEventId;

        /// <summary>
        /// Details of the cancellation (if any).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this.details != null;
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

        // Check to see if ScheduledEventId property is set
        internal bool IsSetScheduledEventId()
        {
            return this.scheduledEventId.HasValue;
        }

        /// <summary>
        /// The Id of the <c>ActivityTaskStarted</c> event recorded when this activity task was started. This information can be useful for diagnosing
        /// problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long StartedEventId
        {
            get { return this.startedEventId ?? default(long); }
            set { this.startedEventId = value; }
        }

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this.startedEventId.HasValue;
        }

        /// <summary>
        /// If set, contains the Id of the last <c>ActivityTaskCancelRequested</c> event recorded for this activity task. This information can be useful
        /// for diagnosing problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long LatestCancelRequestedEventId
        {
            get { return this.latestCancelRequestedEventId ?? default(long); }
            set { this.latestCancelRequestedEventId = value; }
        }

        // Check to see if LatestCancelRequestedEventId property is set
        internal bool IsSetLatestCancelRequestedEventId()
        {
            return this.latestCancelRequestedEventId.HasValue;
        }
    }
}
