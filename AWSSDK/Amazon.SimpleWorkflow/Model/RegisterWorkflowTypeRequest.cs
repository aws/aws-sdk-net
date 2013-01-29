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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterWorkflowType operation.
    /// <para> Registers a new <i>workflow type</i> and its configuration settings in the specified domain. </para> <para> The retention period for
    /// the workflow history is set by the RegisterDomain action. </para> <para><b>IMPORTANT:</b> If the type already exists, then a
    /// TypeAlreadyExists fault is returned. You cannot change the configuration settings of a workflow type once it is registered and it must be
    /// registered as a new version. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to
    /// Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
    /// <ul>
    /// <li> <c>defaultTaskList</c> : String constraint. The key is <c>swf:defaultTaskList.name</c> .</li>
    /// <li> <c>name</c> : String constraint. The key is <c>swf:name</c> .</li>
    /// <li> <c>version</c> : String constraint. The key is <c>swf:version</c> .</li>
    /// 
    /// </ul>
    /// </li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see Using IAM to Manage
    /// Access to Amazon SWF Workflows.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.RegisterWorkflowType"/>
    public class RegisterWorkflowTypeRequest : AmazonWebServiceRequest
    {
        private string domain;
        private string name;
        private string version;
        private string description;
        private string defaultTaskStartToCloseTimeout;
        private string defaultExecutionStartToCloseTimeout;
        private TaskList defaultTaskList;
        private string defaultChildPolicy;

        /// <summary>
        /// The name of the domain in which to register the workflow type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        public RegisterWorkflowTypeRequest WithDomain(string domain)
        {
            this.domain = domain;
            return this;
        }
            

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// The name of the workflow type. The specified string must not start or end with whitespace. It must not contain a <c>:</c> (colon), <c>/</c>
        /// (slash), <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain the literal string
        /// "arn".
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public RegisterWorkflowTypeRequest WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The version of the workflow type. <note> The workflow type consists of the name and version, the combination of which must be unique within
        /// the domain. To get a list of all currently registered workflow types, use the <a>ListWorkflowTypes</a> action. </note> The specified string
        /// must not start or end with whitespace. It must not contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control
        /// characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain the literal string "arn".
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this.version; }
            set { this.version = value; }
        }

        /// <summary>
        /// Sets the Version property
        /// </summary>
        /// <param name="version">The value to set for the Version property </param>
        /// <returns>this instance</returns>
        public RegisterWorkflowTypeRequest WithVersion(string version)
        {
            this.version = version;
            return this;
        }
            

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this.version != null;
        }

        /// <summary>
        /// Textual description of the workflow type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public RegisterWorkflowTypeRequest WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// If set, specifies the default maximum duration of decision tasks for this workflow type. This default can be overridden when starting a
        /// workflow execution using the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c> <a>Decision</a>. The valid
        /// values are integers greater than or equal to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can
        /// be used to specify unlimited duration.
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

        /// <summary>
        /// Sets the DefaultTaskStartToCloseTimeout property
        /// </summary>
        /// <param name="defaultTaskStartToCloseTimeout">The value to set for the DefaultTaskStartToCloseTimeout property </param>
        /// <returns>this instance</returns>
        public RegisterWorkflowTypeRequest WithDefaultTaskStartToCloseTimeout(string defaultTaskStartToCloseTimeout)
        {
            this.defaultTaskStartToCloseTimeout = defaultTaskStartToCloseTimeout;
            return this;
        }
            

        // Check to see if DefaultTaskStartToCloseTimeout property is set
        internal bool IsSetDefaultTaskStartToCloseTimeout()
        {
            return this.defaultTaskStartToCloseTimeout != null;
        }

        /// <summary>
        /// If set, specifies the default maximum duration for executions of this workflow type. You can override this default when starting an
        /// execution through the <a>StartWorkflowExecution</a> Action or <c>StartChildWorkflowExecution</c> <a>Decision</a>. The duration is specified
        /// in seconds. The valid values are integers greater than or equal to 0. Unlike some of the other timeout parameters in Amazon SWF, you cannot
        /// specify a value of "NONE" for <c>defaultExecutionStartToCloseTimeout</c>; there is a one-year max limit on the time that a workflow
        /// execution can run. Exceeding this limit will always cause the workflow execution to time out.
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
        public string DefaultExecutionStartToCloseTimeout
        {
            get { return this.defaultExecutionStartToCloseTimeout; }
            set { this.defaultExecutionStartToCloseTimeout = value; }
        }

        /// <summary>
        /// Sets the DefaultExecutionStartToCloseTimeout property
        /// </summary>
        /// <param name="defaultExecutionStartToCloseTimeout">The value to set for the DefaultExecutionStartToCloseTimeout property </param>
        /// <returns>this instance</returns>
        public RegisterWorkflowTypeRequest WithDefaultExecutionStartToCloseTimeout(string defaultExecutionStartToCloseTimeout)
        {
            this.defaultExecutionStartToCloseTimeout = defaultExecutionStartToCloseTimeout;
            return this;
        }
            

        // Check to see if DefaultExecutionStartToCloseTimeout property is set
        internal bool IsSetDefaultExecutionStartToCloseTimeout()
        {
            return this.defaultExecutionStartToCloseTimeout != null;
        }

        /// <summary>
        /// If set, specifies the default task list to use for scheduling decision tasks for executions of this workflow type. This default is used only
        /// if a task list is not provided when starting the execution through the <a>StartWorkflowExecution</a> Action or
        /// <c>StartChildWorkflowExecution</c> <a>Decision</a>.
        ///  
        /// </summary>
        public TaskList DefaultTaskList
        {
            get { return this.defaultTaskList; }
            set { this.defaultTaskList = value; }
        }

        /// <summary>
        /// Sets the DefaultTaskList property
        /// </summary>
        /// <param name="defaultTaskList">The value to set for the DefaultTaskList property </param>
        /// <returns>this instance</returns>
        public RegisterWorkflowTypeRequest WithDefaultTaskList(TaskList defaultTaskList)
        {
            this.defaultTaskList = defaultTaskList;
            return this;
        }
            

        // Check to see if DefaultTaskList property is set
        internal bool IsSetDefaultTaskList()
        {
            return this.defaultTaskList != null;
        }

        /// <summary>
        /// If set, specifies the default policy to use for the child workflow executions when a workflow execution of this type is terminated, by
        /// calling the <a>TerminateWorkflowExecution</a> action explicitly or due to an expired timeout. This default can be overridden when starting a
        /// workflow execution using the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c> <a>Decision</a>. The supported
        /// child policies are: <ul> <li><b>TERMINATE:</b> the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b> a request to cancel
        /// will be attempted for each child execution by recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is up to the
        /// decider to take appropriate actions when it receives an execution history with this event. </li> <li><b>ABANDON:</b> no action will be
        /// taken. The child executions will continue to run.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TERMINATE, REQUEST_CANCEL, ABANDON</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultChildPolicy
        {
            get { return this.defaultChildPolicy; }
            set { this.defaultChildPolicy = value; }
        }

        /// <summary>
        /// Sets the DefaultChildPolicy property
        /// </summary>
        /// <param name="defaultChildPolicy">The value to set for the DefaultChildPolicy property </param>
        /// <returns>this instance</returns>
        public RegisterWorkflowTypeRequest WithDefaultChildPolicy(string defaultChildPolicy)
        {
            this.defaultChildPolicy = defaultChildPolicy;
            return this;
        }
            

        // Check to see if DefaultChildPolicy property is set
        internal bool IsSetDefaultChildPolicy()
        {
            return this.defaultChildPolicy != null;
        }
    }
}
    
