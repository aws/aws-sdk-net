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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterDomain operation.
    /// Registers a new domain.
    /// 
    ///  
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
    /// You cannot use an IAM policy to control domain access for this action. The name of
    /// the domain being registered is available as the resource of this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <code>Action</code> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot use an IAM policy to constrain this action's parameters.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
    /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterDomainRequest : AmazonSimpleWorkflowRequest
    {
        private string _description;
        private string _name;
        private List<ResourceTag> _tags = new List<ResourceTag>();
        private string _workflowExecutionRetentionPeriodInDays;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A text description of the domain.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the domain to register. The name must be unique in the region that the domain
        /// is registered in.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (<code>\u0000-\u001f</code> | <code>\u007f-\u009f</code>).
        /// Also, it must not <i>be</i> the literal string <code>arn</code>.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be added when registering a domain.
        /// </para>
        ///  
        /// <para>
        /// Tags may only contain unicode letters, digits, whitespace, or these symbols: <code>_
        /// . : / = + - @</code>.
        /// </para>
        /// </summary>
        public List<ResourceTag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionRetentionPeriodInDays. 
        /// <para>
        /// The duration (in days) that records and histories of workflow executions on the domain
        /// should be kept by the service. After the retention period, the workflow execution
        /// isn't available in the results of visibility calls.
        /// </para>
        ///  
        /// <para>
        /// If you pass the value <code>NONE</code> or <code>0</code> (zero), then the workflow
        /// execution history isn't retained. As soon as the workflow execution completes, the
        /// execution record and its history are deleted.
        /// </para>
        ///  
        /// <para>
        /// The maximum workflow execution retention period is 90 days. For more information about
        /// Amazon SWF service limits, see: <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-limits.html">Amazon
        /// SWF Service Limits</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
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