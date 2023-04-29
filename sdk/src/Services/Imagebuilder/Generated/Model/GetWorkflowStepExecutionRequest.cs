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
    /// Container for the parameters to the GetWorkflowStepExecution operation.
    /// Get the runtime information that was logged for a specific runtime instance of the
    /// workflow step.
    /// </summary>
    public partial class GetWorkflowStepExecutionRequest : AmazonImagebuilderRequest
    {
        private string _stepExecutionId;

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// Use the unique identifier for a specific runtime instance of the workflow step to
        /// get runtime details for that step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StepExecutionId
        {
            get { return this._stepExecutionId; }
            set { this._stepExecutionId = value; }
        }

        // Check to see if StepExecutionId property is set
        internal bool IsSetStepExecutionId()
        {
            return this._stepExecutionId != null;
        }

    }
}