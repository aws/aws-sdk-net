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
    /// Container for the parameters to the RegisterDomain operation.
    /// <para> Registers a new domain. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access
    /// to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>You cannot use an IAM policy to control domain access for this action. The name of the domain being registered is available as the
    /// resource of this action.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
    /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
    /// .</para>
    /// </summary>
    public partial class RegisterDomainRequest : AmazonWebServiceRequest
    {
        private string name;
        private string description;
        private string workflowExecutionRetentionPeriodInDays;

        /// <summary>
        /// Name of the domain to register. The name must be unique. The specified string must not start or end with whitespace. It must not contain a
        /// <c>:</c> (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not
        /// contain the literal string "arn".
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

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// Textual description of the domain.
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

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// Specifies the duration--<b><i>in days</i></b>--for which the record (including the history) of workflow executions in this domain should be
        /// kept by the service. After the retention period, the workflow execution will not be available in the results of visibility calls. If a
        /// duration of <c>NONE</c> is specified, the records for workflow executions in this domain are not retained at all.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string WorkflowExecutionRetentionPeriodInDays
        {
            get { return this.workflowExecutionRetentionPeriodInDays; }
            set { this.workflowExecutionRetentionPeriodInDays = value; }
        }

        // Check to see if WorkflowExecutionRetentionPeriodInDays property is set
        internal bool IsSetWorkflowExecutionRetentionPeriodInDays()
        {
            return this.workflowExecutionRetentionPeriodInDays != null;
        }

    }
}
    
