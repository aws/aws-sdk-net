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
    /// Container for the parameters to the RegisterActivityType operation.
    /// Registers a new <i>activity type</i> along with its configuration settings in the
    /// specified domain. 
    /// 
    ///  <important> A <code>TypeAlreadyExists</code> fault is returned if the type already
    /// exists in the domain. You cannot change any configuration settings of the type after
    /// its registration, and it must be registered as a new version. </important> 
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
    /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
    /// deny permission to call this action.</li> <li>Constrain the following parameters by
    /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>defaultTaskList.name</code>:
    /// String constraint. The key is <code>swf:defaultTaskList.name</code>.</li> <li> <code>name</code>:
    /// String constraint. The key is <code>swf:name</code>.</li> <li> <code>version</code>:
    /// String constraint. The key is <code>swf:version</code>.</li> </ul> </li> </ul> 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
    /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class RegisterActivityTypeRequest : AmazonSimpleWorkflowRequest
    {
        private string _defaultTaskHeartbeatTimeout;
        private TaskList _defaultTaskList;
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
        ///  If set, specifies the default maximum time before which a worker processing a task
        /// of this type must report progress by calling <a>RecordActivityTaskHeartbeat</a>. If
        /// the timeout is exceeded, the activity task is automatically timed out. This default
        /// can be overridden when scheduling an activity task using the <code>ScheduleActivityTask</code>
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
        ///  If set, specifies the default task list to use for scheduling tasks of this activity
        /// type. This default task list is used if a task list is not provided when a task is
        /// scheduled through the <code>ScheduleActivityTask</code> <a>Decision</a>. 
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
        ///  If set, specifies the default maximum duration for a task of this activity type.
        /// This default can be overridden when scheduling an activity task using the <code>ScheduleActivityTask</code>
        /// <a>Decision</a>. 
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
        ///  If set, specifies the default maximum duration that a task of this activity type
        /// can wait before being assigned to a worker. This default can be overridden when scheduling
        /// an activity task using the <code>ScheduleActivityTask</code> <a>Decision</a>. 
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
        ///  If set, specifies the default maximum duration that a worker can take to process
        /// tasks of this activity type. This default can be overridden when scheduling an activity
        /// task using the <code>ScheduleActivityTask</code> <a>Decision</a>. 
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

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A textual description of the activity type. 
        /// </para>
        /// </summary>
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
        ///  The name of the domain in which this activity is to be registered. 
        /// </para>
        /// </summary>
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
        ///  The name of the activity type within the domain. 
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain
        /// the literal string &quot;arn&quot;.
        /// </para>
        /// </summary>
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
        ///  The version of the activity type. 
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain
        /// the literal string &quot;arn&quot;.
        /// </para>
        /// </summary>
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