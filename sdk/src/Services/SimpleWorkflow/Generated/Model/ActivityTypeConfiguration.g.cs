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
    /// Configuration settings registered with the activity type.
    /// </summary>
    public partial class ActivityTypeConfiguration
    {
        /// <summary>
        /// Gets and sets the property DefaultTaskHeartbeatTimeout. 
        /// <para>
        ///  The default maximum time, in seconds, before which a worker processing a task must
        /// report progress by calling <a>RecordActivityTaskHeartbeat</a>.
        /// </para>
        ///  
        /// <para>
        /// You can specify this value only when <i>registering</i> an activity type. The registered
        /// default value can be overridden when you schedule a task through the <c>ScheduleActivityTask</c>
        /// <a>Decision</a>. If the activity worker subsequently attempts to record a heartbeat
        /// or returns a result, the activity worker receives an <c>UnknownResource</c> fault.
        /// In this case, Amazon SWF no longer considers the activity task to be valid; the activity
        /// worker should clean up the activity task.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string DefaultTaskHeartbeatTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTaskHeartbeatTimeout property is set.
        /// </summary>
        internal bool IsSetDefaultTaskHeartbeatTimeout() => this.DefaultTaskHeartbeatTimeout != null;

        /// <summary>
        /// Gets and sets the property DefaultTaskList. 
        /// <para>
        ///  The default task list specified for this activity type at registration. This default
        /// is used if a task list isn't provided when a task is scheduled through the <c>ScheduleActivityTask</c>
        /// <a>Decision</a>. You can override the default registered task list when scheduling
        /// a task through the <c>ScheduleActivityTask</c> <a>Decision</a>.
        /// </para>
        /// </summary>
        public TaskList DefaultTaskList { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTaskList property is set.
        /// </summary>
        internal bool IsSetDefaultTaskList() => this.DefaultTaskList != null;

        /// <summary>
        /// Gets and sets the property DefaultTaskPriority. 
        /// <para>
        ///  The default task priority for tasks of this activity type, specified at registration.
        /// If not set, then <c>0</c> is used as the default priority. This default can be overridden
        /// when scheduling an activity task.
        /// </para>
        ///  
        /// <para>
        /// Valid values are integers that range from Java's <c>Integer.MIN_VALUE</c> (-2147483648)
        /// to <c>Integer.MAX_VALUE</c> (2147483647). Higher numbers indicate higher priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        public string DefaultTaskPriority { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTaskPriority property is set.
        /// </summary>
        internal bool IsSetDefaultTaskPriority() => this.DefaultTaskPriority != null;

        /// <summary>
        /// Gets and sets the property DefaultTaskScheduleToCloseTimeout. 
        /// <para>
        ///  The default maximum duration, specified when registering the activity type, for tasks
        /// of this activity type. You can override this default when scheduling a task through
        /// the <c>ScheduleActivityTask</c> <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string DefaultTaskScheduleToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTaskScheduleToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetDefaultTaskScheduleToCloseTimeout() => this.DefaultTaskScheduleToCloseTimeout != null;

        /// <summary>
        /// Gets and sets the property DefaultTaskScheduleToStartTimeout. 
        /// <para>
        ///  The default maximum duration, specified when registering the activity type, that
        /// a task of an activity type can wait before being assigned to a worker. You can override
        /// this default when scheduling a task through the <c>ScheduleActivityTask</c> <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string DefaultTaskScheduleToStartTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTaskScheduleToStartTimeout property is set.
        /// </summary>
        internal bool IsSetDefaultTaskScheduleToStartTimeout() => this.DefaultTaskScheduleToStartTimeout != null;

        /// <summary>
        /// Gets and sets the property DefaultTaskStartToCloseTimeout. 
        /// <para>
        ///  The default maximum duration for tasks of an activity type specified when registering
        /// the activity type. You can override this default when scheduling a task through the
        /// <c>ScheduleActivityTask</c> <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string DefaultTaskStartToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTaskStartToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetDefaultTaskStartToCloseTimeout() => this.DefaultTaskStartToCloseTimeout != null;
    }
}
