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
    /// Container for the parameters to the TerminateWorkflowExecution operation.
    /// <para> Records a <c>WorkflowExecutionTerminated</c> event and forces closure of the workflow execution identified by the given domain,
    /// runId, and workflowId. The child policy, registered with the workflow type or specified when starting this execution, is applied to any open
    /// child workflow executions of this workflow execution. </para> <para><b>IMPORTANT:</b> If the identified workflow execution was in progress,
    /// it is terminated immediately. </para> <para><b>NOTE:</b> If a runId is not specified, then the WorkflowExecutionTerminated event is recorded
    /// in the history of the current open workflow with the matching workflowId in the domain. </para> <para><b>NOTE:</b> You should consider using
    /// RequestCancelWorkflowExecution action instead because it allows the workflow to gracefully close while TerminateWorkflowExecution does not.
    /// </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
    /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
    /// .</para>
    /// </summary>
    public partial class TerminateWorkflowExecutionRequest : AmazonWebServiceRequest
    {
        private string domain;
        private string workflowId;
        private string runId;
        private string reason;
        private string details;
        private ChildPolicy childPolicy;

        /// <summary>
        /// The domain of the workflow execution to terminate.
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

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// The workflowId of the workflow execution to terminate.
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
        public string WorkflowId
        {
            get { return this.workflowId; }
            set { this.workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this.workflowId != null;
        }

        /// <summary>
        /// The runId of the workflow execution to terminate.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RunId
        {
            get { return this.runId; }
            set { this.runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this.runId != null;
        }

        /// <summary>
        /// An optional descriptive reason for terminating the workflow execution.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this.reason; }
            set { this.reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this.reason != null;
        }

        /// <summary>
        /// Optional details for terminating the workflow execution.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this.details != null;
        }

        /// <summary>
        /// If set, specifies the policy to use for the child workflow executions of the workflow execution being terminated. This policy overrides the
        /// child policy specified for the workflow execution at registration time or when starting the execution. The supported child policies are:
        /// <ul> <li><b>TERMINATE:</b> the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b> a request to cancel will be attempted
        /// for each child execution by recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is up to the decider to take
        /// appropriate actions when it receives an execution history with this event. </li> <li><b>ABANDON:</b> no action will be taken. The child
        /// executions will continue to run.</li> </ul> <note>A child policy for this workflow execution must be specified either as a default for the
        /// workflow type or through this parameter. If neither this parameter is set nor a default child policy was specified at registration time, a
        /// fault will be returned.</note>
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
        public ChildPolicy ChildPolicy
        {
            get { return this.childPolicy; }
            set { this.childPolicy = value; }
        }

        // Check to see if ChildPolicy property is set
        internal bool IsSetChildPolicy()
        {
            return this.childPolicy != null;
        }

    }
}
    
