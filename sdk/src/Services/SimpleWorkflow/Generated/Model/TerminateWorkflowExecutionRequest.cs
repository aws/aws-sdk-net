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
    /// Container for the parameters to the TerminateWorkflowExecution operation.
    /// Records a <code>WorkflowExecutionTerminated</code> event and forces closure of the
    /// workflow execution identified by the given domain, runId, and workflowId. The child
    /// policy, registered with the workflow type or specified when starting this execution,
    /// is applied to any open child workflow executions of this workflow execution.
    /// 
    ///  <important> If the identified workflow execution was in progress, it is terminated
    /// immediately.</important> <note> If a runId is not specified, then the <code>WorkflowExecutionTerminated</code>
    /// event is recorded in the history of the current open workflow with the matching workflowId
    /// in the domain.</note> <note> You should consider using <a>RequestCancelWorkflowExecution</a>
    /// action instead because it allows the workflow to gracefully close while <a>TerminateWorkflowExecution</a>
    /// does not.</note> 
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
    /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
    /// this action's parameters.</li> </ul> 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class TerminateWorkflowExecutionRequest : AmazonSimpleWorkflowRequest
    {
        private ChildPolicy _childPolicy;
        private string _details;
        private string _domain;
        private string _reason;
        private string _runId;
        private string _workflowId;

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        /// If set, specifies the policy to use for the child workflow executions of the workflow
        /// execution being terminated. This policy overrides the child policy specified for the
        /// workflow execution at registration time or when starting the execution.
        /// </para>
        ///  
        /// <para>
        /// The supported child policies are:
        /// </para>
        ///  <ul> <li><b>TERMINATE:</b> the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b>
        /// a request to cancel will be attempted for each child execution by recording a <code>WorkflowExecutionCancelRequested</code>
        /// event in its history. It is up to the decider to take appropriate actions when it
        /// receives an execution history with this event.</li> <li><b>ABANDON:</b> no action
        /// will be taken. The child executions will continue to run.</li> </ul> <note>A child
        /// policy for this workflow execution must be specified either as a default for the workflow
        /// type or through this parameter. If neither this parameter is set nor a default child
        /// policy was specified at registration time then a fault will be returned.</note>
        /// </summary>
        public ChildPolicy ChildPolicy
        {
            get { return this._childPolicy; }
            set { this._childPolicy = value; }
        }

        // Check to see if ChildPolicy property is set
        internal bool IsSetChildPolicy()
        {
            return this._childPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// <i>Optional.</i> Details for terminating the workflow execution.
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain of the workflow execution to terminate.
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// <i>Optional.</i> A descriptive reason for terminating the workflow execution.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The runId of the workflow execution to terminate.
        /// </para>
        /// </summary>
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The workflowId of the workflow execution to terminate.
        /// </para>
        /// </summary>
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

    }
}