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
    /// Provides details of the <code>ActivityTaskCanceled</code> event.
    /// </summary>
    public partial class ActivityTaskCanceledEventAttributes
    {
        private string _details;
        private long? _latestCancelRequestedEventId;
        private long? _scheduledEventId;
        private long? _startedEventId;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        ///  Details of the cancellation (if any). 
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property LatestCancelRequestedEventId. 
        /// <para>
        ///  If set, contains the Id of the last <code>ActivityTaskCancelRequested</code> event
        /// recorded for this activity task. This information can be useful for diagnosing problems
        /// by tracing back the chain of events leading up to this event. 
        /// </para>
        /// </summary>
        public long LatestCancelRequestedEventId
        {
            get { return this._latestCancelRequestedEventId.GetValueOrDefault(); }
            set { this._latestCancelRequestedEventId = value; }
        }

        // Check to see if LatestCancelRequestedEventId property is set
        internal bool IsSetLatestCancelRequestedEventId()
        {
            return this._latestCancelRequestedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledEventId. 
        /// <para>
        ///  The id of the <code>ActivityTaskScheduled</code> event that was recorded when this
        /// activity task was scheduled. This information can be useful for diagnosing problems
        /// by tracing back the chain of events leading up to this event. 
        /// </para>
        /// </summary>
        public long ScheduledEventId
        {
            get { return this._scheduledEventId.GetValueOrDefault(); }
            set { this._scheduledEventId = value; }
        }

        // Check to see if ScheduledEventId property is set
        internal bool IsSetScheduledEventId()
        {
            return this._scheduledEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        ///  The Id of the <code>ActivityTaskStarted</code> event recorded when this activity
        /// task was started. This information can be useful for diagnosing problems by tracing
        /// back the chain of events leading up to this event. 
        /// </para>
        /// </summary>
        public long StartedEventId
        {
            get { return this._startedEventId.GetValueOrDefault(); }
            set { this._startedEventId = value; }
        }

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this._startedEventId.HasValue; 
        }

    }
}