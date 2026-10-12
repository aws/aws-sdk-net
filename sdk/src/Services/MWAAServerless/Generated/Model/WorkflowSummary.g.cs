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

namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Summary information about a workflow, including basic identification and metadata.
    /// </summary>
    public partial class WorkflowSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow was created, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the workflow was last modified, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TriggerMode. 
        /// <para>
        /// The trigger mode for the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TriggerMode { get; set; }

        /// <summary>
        /// Checks to see if the TriggerMode property is set.
        /// </summary>
        internal bool IsSetTriggerMode() => this.TriggerMode != null;

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowStatus. 
        /// <para>
        /// The current status of the workflow.
        /// </para>
        /// </summary>
        public WorkflowStatus WorkflowStatus { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowStatus property is set.
        /// </summary>
        internal bool IsSetWorkflowStatus() => this.WorkflowStatus != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version identifier of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string WorkflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowVersion property is set.
        /// </summary>
        internal bool IsSetWorkflowVersion() => this.WorkflowVersion != null;
    }
}
