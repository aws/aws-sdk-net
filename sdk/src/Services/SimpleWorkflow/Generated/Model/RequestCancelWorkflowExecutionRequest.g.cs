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
    /// Container for the parameters to the RequestCancelWorkflowExecution operation. Records
    /// a <c>WorkflowExecutionCancelRequested</c> event in the currently running workflow
    /// execution identified by the given domain, workflowId, and runId. This logically requests
    /// the cancellation of the workflow execution as a whole. It is up to the decider to
    /// take appropriate actions when it receives an execution history with this event. <note>
    /// <para> If the runId isn't specified, the <c>WorkflowExecutionCancelRequested</c> event
    /// is recorded in the history of the current open workflow execution with the specified
    /// workflowId in the domain. </para> </note> <note> <para> Because this action allows
    /// the workflow to properly clean up and gracefully close, it should be used instead
    /// of <a>TerminateWorkflowExecution</a> when possible. </para> </note> <para> <b>Access
    /// Control</b> </para> <para> You can use IAM policies to control this action's access
    /// to Amazon SWF resources as follows: </para> <ul> <li> <para> Use a <c>Resource</c>
    /// element with the domain name to limit the action to only specified domains. </para>
    /// </li> <li> <para> Use an <c>Action</c> element to allow or deny permission to call
    /// this action. </para> </li> <li> <para> You cannot use an IAM policy to constrain this
    /// action's parameters. </para> </li> </ul> <para> If the caller doesn't have sufficient
    /// permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails. The associated event attribute's <c>cause</c> parameter
    /// is set to <c>OPERATION_NOT_PERMITTED</c>. For details and example IAM policies, see
    /// <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RequestCancelWorkflowExecutionRequest : AmazonSimpleWorkflowRequest
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain containing the workflow execution to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The runId of the workflow execution to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The workflowId of the workflow execution to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;
    }
}
