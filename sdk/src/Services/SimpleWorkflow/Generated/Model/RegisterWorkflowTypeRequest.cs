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
    /// Container for the parameters to the RegisterWorkflowType operation.
    /// Registers a new <i>workflow type</i> and its configuration settings in the specified
    /// domain.
    /// 
    ///  
    /// <para>
    /// The retention period for the workflow history is set by the <a>RegisterDomain</a>
    /// action.
    /// </para>
    ///  <important> 
    /// <para>
    /// If the type already exists, then a <c>TypeAlreadyExists</c> fault is returned. You
    /// cannot change the configuration settings of a workflow type once it is registered
    /// and it must be registered as a new version.
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
    public partial class RegisterWorkflowTypeRequest : AmazonSimpleWorkflowRequest
    {
        private ChildPolicy _defaultChildPolicy;
        private string _defaultExecutionStartToCloseTimeout;
        private string _defaultLambdaRole;
        private TaskList _defaultTaskList;
        private string _defaultTaskPriority;
        private string _defaultTaskStartToCloseTimeout;
        private string _description;
        private string _domain;
        private string _name;
        private string _version;

        /// <summary>
        /// Gets and sets the property DefaultChildPolicy. 
        /// <para>
        /// If set, specifies the default policy to use for the child workflow executions when
        /// a workflow execution of this type is terminated, by calling the <a>TerminateWorkflowExecution</a>
        /// action explicitly or due to an expired timeout. This default can be overridden when
        /// starting a workflow execution using the <a>StartWorkflowExecution</a> action or the
        /// <c>StartChildWorkflowExecution</c> <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The supported child policies are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TERMINATE</c> – The child executions are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REQUEST_CANCEL</c> – A request to cancel is attempted for each child execution
        /// by recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is
        /// up to the decider to take appropriate actions when it receives an execution history
        /// with this event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ABANDON</c> – No action is taken. The child executions continue to run.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChildPolicy DefaultChildPolicy
        {
            get { return this._defaultChildPolicy; }
            set { this._defaultChildPolicy = value; }
        }

        // Check to see if DefaultChildPolicy property is set
        internal bool IsSetDefaultChildPolicy()
        {
            return this._defaultChildPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultExecutionStartToCloseTimeout. 
        /// <para>
        /// If set, specifies the default maximum duration for executions of this workflow type.
        /// You can override this default when starting an execution through the <a>StartWorkflowExecution</a>
        /// Action or <c>StartChildWorkflowExecution</c> <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds; an integer greater than or equal to 0. Unlike
        /// some of the other timeout parameters in Amazon SWF, you cannot specify a value of
        /// "NONE" for <c>defaultExecutionStartToCloseTimeout</c>; there is a one-year max limit
        /// on the time that a workflow execution can run. Exceeding this limit always causes
        /// the workflow execution to time out.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
        public string DefaultExecutionStartToCloseTimeout
        {
            get { return this._defaultExecutionStartToCloseTimeout; }
            set { this._defaultExecutionStartToCloseTimeout = value; }
        }

        // Check to see if DefaultExecutionStartToCloseTimeout property is set
        internal bool IsSetDefaultExecutionStartToCloseTimeout()
        {
            return this._defaultExecutionStartToCloseTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultLambdaRole. 
        /// <para>
        /// The default IAM role attached to this workflow type.
        /// </para>
        ///  <note> 
        /// <para>
        /// Executions of this workflow type need IAM roles to invoke Lambda functions. If you
        /// don't specify an IAM role when you start this workflow type, the default Lambda role
        /// is attached to the execution. For more information, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/lambda-task.html">https://docs.aws.amazon.com/amazonswf/latest/developerguide/lambda-task.html</a>
        /// in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string DefaultLambdaRole
        {
            get { return this._defaultLambdaRole; }
            set { this._defaultLambdaRole = value; }
        }

        // Check to see if DefaultLambdaRole property is set
        internal bool IsSetDefaultLambdaRole()
        {
            return this._defaultLambdaRole != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskList. 
        /// <para>
        /// If set, specifies the default task list to use for scheduling decision tasks for executions
        /// of this workflow type. This default is used only if a task list isn't provided when
        /// starting the execution through the <a>StartWorkflowExecution</a> Action or <c>StartChildWorkflowExecution</c>
        /// <a>Decision</a>.
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
        /// The default task priority to assign to the workflow type. If not assigned, then <c>0</c>
        /// is used. Valid values are integers that range from Java's <c>Integer.MIN_VALUE</c>
        /// (-2147483648) to <c>Integer.MAX_VALUE</c> (2147483647). Higher numbers indicate higher
        /// priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>Amazon SWF Developer Guide</i>.
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
        /// Gets and sets the property DefaultTaskStartToCloseTimeout. 
        /// <para>
        /// If set, specifies the default maximum duration of decision tasks for this workflow
        /// type. This default can be overridden when starting a workflow execution using the
        /// <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c> <a>Decision</a>.
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
        /// Textual description of the workflow type.
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
        /// The name of the domain in which to register the workflow type.
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
        /// The name of the workflow type.
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
        /// The version of the workflow type.
        /// </para>
        ///  <note> 
        /// <para>
        /// The workflow type consists of the name and version, the combination of which must
        /// be unique within the domain. To get a list of all currently registered workflow types,
        /// use the <a>ListWorkflowTypes</a> action.
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