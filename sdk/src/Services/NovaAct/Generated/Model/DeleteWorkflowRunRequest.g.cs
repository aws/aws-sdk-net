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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWorkflowRun operation. Terminates and cleans
    /// up a workflow run, stopping all associated acts and sessions.
    /// </summary>
    public partial class DeleteWorkflowRunRequest : AmazonNovaActRequest
    {
        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition containing the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public string WorkflowDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowDefinitionName property is set.
        /// </summary>
        internal bool IsSetWorkflowDefinitionName() => this.WorkflowDefinitionName != null;

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The unique identifier of the workflow run to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkflowRunId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowRunId property is set.
        /// </summary>
        internal bool IsSetWorkflowRunId() => this.WorkflowRunId != null;
    }
}
