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
    /// Container for the parameters to the RegisterDomain operation.
    /// Registers a new domain.
    /// 
    ///  
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li>You cannot use an IAM policy to control domain access for this action. The
    /// name of the domain being registered is available as the resource of this action.</li>
    /// <li>Use an <code>Action</code> element to allow or deny permission to call this action.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li> </ul>
    /// 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class RegisterDomainRequest : AmazonSimpleWorkflowRequest
    {
        private string _description;
        private string _name;
        private string _workflowExecutionRetentionPeriodInDays;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A text description of the domain.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the domain to register. The name must be unique in the region that the domain
        /// is registered in.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain
        /// the literal string quotarnquot.
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
        /// Gets and sets the property WorkflowExecutionRetentionPeriodInDays. 
        /// <para>
        /// The duration (in days) that records and histories of workflow executions on the domain
        /// should be kept by the service. After the retention period, the workflow execution
        /// is not available in the results of visibility calls.
        /// </para>
        ///  
        /// <para>
        /// If you pass the value <code>NONE</code> or <code>0</code> (zero), then the workflow
        /// execution history will not be retained. As soon as the workflow execution completes,
        /// the execution record and its history are deleted.
        /// </para>
        ///  
        /// <para>
        /// The maximum workflow execution retention period is 90 days. For more information about
        /// Amazon SWF service limits, see: <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-limits.html">Amazon
        /// SWF Service Limits</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        public string WorkflowExecutionRetentionPeriodInDays
        {
            get { return this._workflowExecutionRetentionPeriodInDays; }
            set { this._workflowExecutionRetentionPeriodInDays = value; }
        }

        // Check to see if WorkflowExecutionRetentionPeriodInDays property is set
        internal bool IsSetWorkflowExecutionRetentionPeriodInDays()
        {
            return this._workflowExecutionRetentionPeriodInDays != null;
        }

    }
}