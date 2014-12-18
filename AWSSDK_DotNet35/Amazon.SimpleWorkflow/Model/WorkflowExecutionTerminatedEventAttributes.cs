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
    /// Provides details of the <code>WorkflowExecutionTerminated</code> event.
    /// </summary>
    public partial class WorkflowExecutionTerminatedEventAttributes
    {
        private WorkflowExecutionTerminatedCause _cause;
        private ChildPolicy _childPolicy;
        private string _details;
        private string _reason;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// If set, indicates that the workflow execution was automatically terminated, and specifies
        /// the cause. This happens if the parent workflow execution times out or is terminated
        /// and the child policy is set to terminate child executions.
        /// </para>
        /// </summary>
        public WorkflowExecutionTerminatedCause Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        /// The policy used for the child workflow executions of this workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The supported child policies are:
        /// </para>
        ///  <ul> <li><b>TERMINATE:</b> the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b>
        /// a request to cancel will be attempted for each child execution by recording a <code>WorkflowExecutionCancelRequested</code>
        /// event in its history. It is up to the decider to take appropriate actions when it
        /// receives an execution history with this event.</li> <li><b>ABANDON:</b> no action
        /// will be taken. The child executions will continue to run.</li> </ul>
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
        /// The details provided for the termination (if any).
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason provided for the termination (if any).
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

    }
}