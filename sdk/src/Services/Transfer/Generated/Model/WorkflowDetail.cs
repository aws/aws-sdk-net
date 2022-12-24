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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the workflow ID for the workflow to assign and the execution role that's
    /// used for executing the workflow.
    /// 
    ///  
    /// <para>
    /// In additon to a workflow to execute when a file is uploaded completely, <code>WorkflowDeatails</code>
    /// can also contain a workflow ID (and execution role) for a workflow to execute on partial
    /// upload. A partial upload occurs when a file is open when the session disconnects.
    /// </para>
    /// </summary>
    public partial class WorkflowDetail
    {
        private string _executionRole;
        private string _workflowId;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// Includes the necessary permissions for S3, EFS, and Lambda operations that Transfer
        /// can assume, so that all workflow steps can operate on the required resources
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// A unique identifier for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
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