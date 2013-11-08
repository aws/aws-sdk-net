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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para>Provides details of the <c>SignalExternalWorkflowExecution</c> decision.</para> <para> <b>Access Control</b> </para> <para>You can use
    /// IAM policies to control this decision's access to Amazon SWF in much the same way as for the regular API:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the decision to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to specify this decision.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails. The associated event attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage
    /// Access to Amazon SWF Workflows</a> .</para>
    /// </summary>
    public class SignalExternalWorkflowExecutionDecisionAttributes
    {
        
        private string workflowId;
        private string runId;
        private string signalName;
        private string input;
        private string control;

        /// <summary>
        /// The <c>workflowId</c> of the workflow execution to be signaled. This field is required.
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
        /// The <c>runId</c> of the workflow execution to be signaled.
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
        /// The name of the signal.The target workflow execution will use the signal name and input to process the signal. This field is required.
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
        public string SignalName
        {
            get { return this.signalName; }
            set { this.signalName = value; }
        }

        // Check to see if SignalName property is set
        internal bool IsSetSignalName()
        {
            return this.signalName != null;
        }

        /// <summary>
        /// Optional input to be provided with the signal.The target workflow execution will use the signal name and input to process the signal.
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
        public string Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this.input != null;
        }

        /// <summary>
        /// Optional data attached to the event that can be used by the decider in subsequent decision tasks.
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
        public string Control
        {
            get { return this.control; }
            set { this.control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this.control != null;
        }
    }
}
