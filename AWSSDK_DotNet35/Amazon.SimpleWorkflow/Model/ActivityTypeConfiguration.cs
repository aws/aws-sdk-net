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
    /// Configuration settings registered with the activity type.
    /// </summary>
    public partial class ActivityTypeConfiguration
    {
        private string _defaultTaskHeartbeatTimeout;
        private TaskList _defaultTaskList;
        private string _defaultTaskScheduleToCloseTimeout;
        private string _defaultTaskScheduleToStartTimeout;
        private string _defaultTaskStartToCloseTimeout;

        /// <summary>
        /// Gets and sets the property DefaultTaskHeartbeatTimeout. 
        /// <para>
        ///  The optional default maximum time, specified when registering the activity type,
        /// before which a worker processing a task must report progress by calling <a>RecordActivityTaskHeartbeat</a>.
        /// You can override this default when scheduling a task through the <code>ScheduleActivityTask</code>
        /// <a>Decision</a>. If the activity worker subsequently attempts to record a heartbeat
        /// or returns a result, the activity worker receives an <code>UnknownResource</code>
        /// fault. In this case, Amazon SWF no longer considers the activity task to be valid;
        /// the activity worker should clean up the activity task. 
        /// </para>
        ///  
        /// <para>
        /// The valid values are integers greater than or equal to <code>0</code>. An integer
        /// value can be used to specify the duration in seconds while <code>NONE</code> can be
        /// used to specify unlimited duration.
        /// </para>
        /// </summary>
        public string DefaultTaskHeartbeatTimeout
        {
            get { return this._defaultTaskHeartbeatTimeout; }
            set { this._defaultTaskHeartbeatTimeout = value; }
        }

        // Check to see if DefaultTaskHeartbeatTimeout property is set
        internal bool IsSetDefaultTaskHeartbeatTimeout()
        {
            return this._defaultTaskHeartbeatTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskList. 
        /// <para>
        ///  The optional default task list specified for this activity type at registration.
        /// This default task list is used if a task list is not provided when a task is scheduled
        /// through the <code>ScheduleActivityTask</code> <a>Decision</a>. You can override this
        /// default when scheduling a task through the <code>ScheduleActivityTask</code> <a>Decision</a>.
        /// 
        /// </para>
        /// </summary>
        public TaskList DefaultTaskList
        {
            get { return this._defaultTaskList; }
            set { this._defaultTaskList = value; }
        }

        // Check to see if DefaultTaskList property is set
        internal bool IsSetDefaultTaskList()
        {
            return this._defaultTaskList != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskScheduleToCloseTimeout. 
        /// <para>
        ///  The optional default maximum duration, specified when registering the activity type,
        /// for tasks of this activity type. You can override this default when scheduling a task
        /// through the <code>ScheduleActivityTask</code> <a>Decision</a>. 
        /// </para>
        ///  
        /// <para>
        /// The valid values are integers greater than or equal to <code>0</code>. An integer
        /// value can be used to specify the duration in seconds while <code>NONE</code> can be
        /// used to specify unlimited duration.
        /// </para>
        /// </summary>
        public string DefaultTaskScheduleToCloseTimeout
        {
            get { return this._defaultTaskScheduleToCloseTimeout; }
            set { this._defaultTaskScheduleToCloseTimeout = value; }
        }

        // Check to see if DefaultTaskScheduleToCloseTimeout property is set
        internal bool IsSetDefaultTaskScheduleToCloseTimeout()
        {
            return this._defaultTaskScheduleToCloseTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskScheduleToStartTimeout. 
        /// <para>
        ///  The optional default maximum duration, specified when registering the activity type,
        /// that a task of an activity type can wait before being assigned to a worker. You can
        /// override this default when scheduling a task through the <code>ScheduleActivityTask</code>
        /// <a>Decision</a>. 
        /// </para>
        ///  
        /// <para>
        /// The valid values are integers greater than or equal to <code>0</code>. An integer
        /// value can be used to specify the duration in seconds while <code>NONE</code> can be
        /// used to specify unlimited duration.
        /// </para>
        /// </summary>
        public string DefaultTaskScheduleToStartTimeout
        {
            get { return this._defaultTaskScheduleToStartTimeout; }
            set { this._defaultTaskScheduleToStartTimeout = value; }
        }

        // Check to see if DefaultTaskScheduleToStartTimeout property is set
        internal bool IsSetDefaultTaskScheduleToStartTimeout()
        {
            return this._defaultTaskScheduleToStartTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskStartToCloseTimeout. 
        /// <para>
        ///  The optional default maximum duration for tasks of an activity type specified when
        /// registering the activity type. You can override this default when scheduling a task
        /// through the <code>ScheduleActivityTask</code> <a>Decision</a>. 
        /// </para>
        ///  
        /// <para>
        /// The valid values are integers greater than or equal to <code>0</code>. An integer
        /// value can be used to specify the duration in seconds while <code>NONE</code> can be
        /// used to specify unlimited duration.
        /// </para>
        /// </summary>
        public string DefaultTaskStartToCloseTimeout
        {
            get { return this._defaultTaskStartToCloseTimeout; }
            set { this._defaultTaskStartToCloseTimeout = value; }
        }

        // Check to see if DefaultTaskStartToCloseTimeout property is set
        internal bool IsSetDefaultTaskStartToCloseTimeout()
        {
            return this._defaultTaskStartToCloseTimeout != null;
        }

    }
}