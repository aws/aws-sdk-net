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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <code>ActivityTaskCompleted</code> event.
    /// </summary>
    public partial class ActivityTaskCompletedEventAttributes
    {
        private string _result;
        private long? _scheduledEventId;
        private long? _startedEventId;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The results of the activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledEventId. 
        /// <para>
        /// The ID of the <code>ActivityTaskScheduled</code> event that was recorded when this
        /// activity task was scheduled. This information can be useful for diagnosing problems
        /// by tracing back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the <code>ActivityTaskStarted</code> event recorded when this activity task
        /// was started. This information can be useful for diagnosing problems by tracing back
        /// the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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