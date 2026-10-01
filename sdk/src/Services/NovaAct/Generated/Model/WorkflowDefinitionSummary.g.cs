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
    /// Summary information about a workflow definition, used in list operations.
    /// </summary>
    public partial class WorkflowDefinitionSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow definition was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the workflow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowDefinitionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkflowDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowDefinitionArn property is set.
        /// </summary>
        internal bool IsSetWorkflowDefinitionArn() => this.WorkflowDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public string WorkflowDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowDefinitionName property is set.
        /// </summary>
        internal bool IsSetWorkflowDefinitionName() => this.WorkflowDefinitionName != null;
    }
}
