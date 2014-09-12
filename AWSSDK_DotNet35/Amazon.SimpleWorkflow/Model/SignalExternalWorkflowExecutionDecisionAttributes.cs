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
    /// Provides details of the <code>SignalExternalWorkflowExecution</code> decision.
    /// 
    ///  
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this decision's access to Amazon SWF in much the
    /// same way as for the regular API:
    /// </para>
    ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the decision
    /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
    /// deny permission to specify this decision.</li> <li>You cannot use an IAM policy to
    /// constrain this action's parameters.</li> </ul> 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class SignalExternalWorkflowExecutionDecisionAttributes
    {
        private string _control;
        private string _input;
        private string _runId;
        private string _signalName;
        private string _workflowId;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        ///  Optional data attached to the event that can be used by the decider in subsequent
        /// decision tasks. 
        /// </para>
        /// </summary>
        public string Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        ///  Optional input to be provided with the signal.The target workflow execution will
        /// use the signal name and input to process the signal. 
        /// </para>
        /// </summary>
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        ///  The <code>runId</code> of the workflow execution to be signaled. 
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
        /// Gets and sets the property SignalName. 
        /// <para>
        ///  The name of the signal.The target workflow execution will use the signal name and
        /// input to process the signal. This field is required. 
        /// </para>
        /// </summary>
        public string SignalName
        {
            get { return this._signalName; }
            set { this._signalName = value; }
        }

        // Check to see if SignalName property is set
        internal bool IsSetSignalName()
        {
            return this._signalName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        ///  The <code>workflowId</code> of the workflow execution to be signaled. This field
        /// is required. 
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