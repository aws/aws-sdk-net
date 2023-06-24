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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the GetWorkflowExecution operation.
    /// Get the runtime information that was logged for a specific runtime instance of the
    /// workflow.
    /// </summary>
    public partial class GetWorkflowExecutionRequest : AmazonImagebuilderRequest
    {
        private string _workflowExecutionId;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionId. 
        /// <para>
        /// Use the unique identifier for a runtime instance of the workflow to get runtime details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkflowExecutionId
        {
            get { return this._workflowExecutionId; }
            set { this._workflowExecutionId = value; }
        }

        // Check to see if WorkflowExecutionId property is set
        internal bool IsSetWorkflowExecutionId()
        {
            return this._workflowExecutionId != null;
        }

    }
}