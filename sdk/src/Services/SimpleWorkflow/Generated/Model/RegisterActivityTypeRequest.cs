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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterActivityType operation.
    /// Registers a new <i>activity type</i> along with its configuration settings in the
    /// specified domain.
    /// 
    ///  <important> 
    /// <para>
    /// A <c>TypeAlreadyExists</c> fault is returned if the type already exists in the domain.
    /// You cannot change any configuration settings of the type after its registration, and
    /// it must be registered as a new version.
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a <c>Resource</c> element with the domain name to limit the action to only specified
    /// domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <c>Action</c> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Constrain the following parameters by using a <c>Condition</c> element with the appropriate
    /// keys.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>defaultTaskList.name</c>: String constraint. The key is <c>swf:defaultTaskList.name</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>name</c>: String constraint. The key is <c>swf:name</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>version</c>: String constraint. The key is <c>swf:version</c>.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <c>cause</c> parameter is set to <c>OPERATION_NOT_PERMITTED</c>. For details
    /// and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterActivityTypeRequest : AmazonSimpleWorkflowRequest
    {
        private string _defaultTaskHeartbeatTimeout;
        private TaskList _defaultTaskList;
        private string _defaultTaskPriority;
        private string _defaultTaskScheduleToCloseTimeout;
        private string _defaultTaskScheduleToStartTimeout;
        private string _defaultTaskStartToCloseTimeout;
        private string _description;
        private string _domain;
        private string _name;
        private string _version;

        /// <summary>
        /// Gets and sets the property DefaultTaskHeartbeatTimeout. 
        /// <para>
        /// If set, specifies the default maximum time before which a worker processing a task
        /// of this type must report progress by calling <a>RecordActivityTaskHeartbeat</a>. If
        /// the timeout is exceeded, the activity task is automatically timed out. This default
        /// can be overridden when scheduling an activity task using the <c>ScheduleActivityTask</c>
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
        [AWSProperty(Max=8)]
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
        /// If set, specifies the default task list to use for scheduling tasks of this activity
        /// type. This default task list is used if a task list isn't provided when a task is
        /// scheduled through the <c>ScheduleActivityTask</c> <a>Decision</a>.
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
        /// Gets and sets the property DefaultTaskPriority. 
        /// <para>
        /// The default task priority to assign to the activity type. If not assigned, then <c>0</c>
        /// is used. Valid values are integers that range from Java's <c>Integer.MIN_VALUE</c>
        /// (-2147483648) to <c>Integer.MAX_VALUE</c> (2147483647). Higher numbers indicate higher
        /// priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>in the <i>Amazon SWF Developer Guide</i>.</i>.
        /// </para>
        /// </summary>
        public string DefaultTaskPriority
        {
            get { return this._defaultTaskPriority; }
            set { this._defaultTaskPriority = value; }
        }

        // Check to see if DefaultTaskPriority property is set
        internal bool IsSetDefaultTaskPriority()
        {
            return this._defaultTaskPriority != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskScheduleToCloseTimeout. 
        /// <para>
        /// If set, specifies the default maximum duration for a task of this activity type. This
        /// default can be overridden when scheduling an activity task using the <c>ScheduleActivityTask</c>
        /// <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
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
        /// If set, specifies the default maximum duration that a task of this activity type can
        /// wait before being assigned to a worker. This default can be overridden when scheduling
        /// an activity task using the <c>ScheduleActivityTask</c> <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
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
        /// If set, specifies the default maximum duration that a worker can take to process tasks
        /// of this activity type. This default can be overridden when scheduling an activity
        /// task using the <c>ScheduleActivityTask</c> <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
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

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A textual description of the activity type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain in which this activity is to be registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the activity type within the domain.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c>
        /// (vertical bar), or any control characters (<c>\u0000-\u001f</c> | <c>\u007f-\u009f</c>).
        /// Also, it must <i>not</i> be the literal string <c>arn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the activity type.
        /// </para>
        ///  <note> 
        /// <para>
        /// The activity type consists of the name and version, the combination of which must
        /// be unique within the domain.
        /// </para>
        ///  </note> 
        /// <para>
        /// The specified string must not contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c>
        /// (vertical bar), or any control characters (<c>\u0000-\u001f</c> | <c>\u007f-\u009f</c>).
        /// Also, it must <i>not</i> be the literal string <c>arn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}