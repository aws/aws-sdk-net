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
    /// <para> Configuration settings registered with the activity type. </para>
    /// </summary>
    public class ActivityTypeConfiguration
    {
        
        private string defaultTaskStartToCloseTimeout;
        private string defaultTaskHeartbeatTimeout;
        private TaskList defaultTaskList;
        private string defaultTaskScheduleToStartTimeout;
        private string defaultTaskScheduleToCloseTimeout;

        /// <summary>
        /// The optional default maximum duration for tasks of an activity type specified when registering the activity type. You can override this
        /// default when scheduling a task through the <c>ScheduleActivityTask</c> <a>Decision</a>. The valid values are integers greater than or equal
        /// to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskStartToCloseTimeout
        {
            get { return this.defaultTaskStartToCloseTimeout; }
            set { this.defaultTaskStartToCloseTimeout = value; }
        }

        // Check to see if DefaultTaskStartToCloseTimeout property is set
        internal bool IsSetDefaultTaskStartToCloseTimeout()
        {
            return this.defaultTaskStartToCloseTimeout != null;
        }

        /// <summary>
        /// The optional default maximum time, specified when registering the activity type, before which a worker processing a task must report
        /// progress by calling <a>RecordActivityTaskHeartbeat</a>. You can override this default when scheduling a task through the
        /// <c>ScheduleActivityTask</c> <a>Decision</a>. If the activity worker subsequently attempts to record a heartbeat or returns a result, the
        /// activity worker receives an <c>UnknownResource</c> fault. In this case, Amazon SWF no longer considers the activity task to be valid; the
        /// activity worker should clean up the activity task. The valid values are integers greater than or equal to <c>0</c>. An integer value can be
        /// used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskHeartbeatTimeout
        {
            get { return this.defaultTaskHeartbeatTimeout; }
            set { this.defaultTaskHeartbeatTimeout = value; }
        }

        // Check to see if DefaultTaskHeartbeatTimeout property is set
        internal bool IsSetDefaultTaskHeartbeatTimeout()
        {
            return this.defaultTaskHeartbeatTimeout != null;
        }

        /// <summary>
        /// The optional default task list specified for this activity type at registration. This default task list is used if a task list is not
        /// provided when a task is scheduled through the <c>ScheduleActivityTask</c> <a>Decision</a>. You can override this default when scheduling a
        /// task through the <c>ScheduleActivityTask</c> <a>Decision</a>.
        ///  
        /// </summary>
        public TaskList DefaultTaskList
        {
            get { return this.defaultTaskList; }
            set { this.defaultTaskList = value; }
        }

        // Check to see if DefaultTaskList property is set
        internal bool IsSetDefaultTaskList()
        {
            return this.defaultTaskList != null;
        }

        /// <summary>
        /// The optional default maximum duration, specified when registering the activity type, that a task of an activity type can wait before being
        /// assigned to a worker. You can override this default when scheduling a task through the <c>ScheduleActivityTask</c> <a>Decision</a>. The
        /// valid values are integers greater than or equal to <c>0</c>. An integer value can be used to specify the duration in seconds while
        /// <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskScheduleToStartTimeout
        {
            get { return this.defaultTaskScheduleToStartTimeout; }
            set { this.defaultTaskScheduleToStartTimeout = value; }
        }

        // Check to see if DefaultTaskScheduleToStartTimeout property is set
        internal bool IsSetDefaultTaskScheduleToStartTimeout()
        {
            return this.defaultTaskScheduleToStartTimeout != null;
        }

        /// <summary>
        /// The optional default maximum duration, specified when registering the activity type, for tasks of this activity type. You can override this
        /// default when scheduling a task through the <c>ScheduleActivityTask</c> <a>Decision</a>. The valid values are integers greater than or equal
        /// to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskScheduleToCloseTimeout
        {
            get { return this.defaultTaskScheduleToCloseTimeout; }
            set { this.defaultTaskScheduleToCloseTimeout = value; }
        }

        // Check to see if DefaultTaskScheduleToCloseTimeout property is set
        internal bool IsSetDefaultTaskScheduleToCloseTimeout()
        {
            return this.defaultTaskScheduleToCloseTimeout != null;
        }
    }
}
