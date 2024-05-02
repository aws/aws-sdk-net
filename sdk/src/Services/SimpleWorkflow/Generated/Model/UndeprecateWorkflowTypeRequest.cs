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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the UndeprecateWorkflowType operation.
    /// Undeprecates a previously deprecated <i>workflow type</i>. After a workflow type has
    /// been undeprecated, you can create new executions of that type. 
    /// 
    ///  <note> 
    /// <para>
    /// This operation is eventually consistent. The results are best effort and may not exactly
    /// reflect recent updates and changes.
    /// </para>
    ///  </note> 
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
    /// Use a <c>Resource</c> element with the domain name to limit the action to only specified
    /// domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <c>Action</c> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Constrain the following parameters by using a <c>Condition</c> element with the appropriate
    /// keys.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>workflowType.name</c>: String constraint. The key is <c>swf:workflowType.name</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>workflowType.version</c>: String constraint. The key is <c>swf:workflowType.version</c>.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <c>cause</c> parameter is set to <c>OPERATION_NOT_PERMITTED</c>. For details
    /// and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class UndeprecateWorkflowTypeRequest : AmazonSimpleWorkflowRequest
    {
        private string _domain;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain of the deprecated workflow type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The name of the domain of the deprecated workflow type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowType WorkflowType
        {
            get { return this._workflowType; }
            set { this._workflowType = value; }
        }

        // Check to see if WorkflowType property is set
        internal bool IsSetWorkflowType()
        {
            return this._workflowType != null;
        }

    }
}