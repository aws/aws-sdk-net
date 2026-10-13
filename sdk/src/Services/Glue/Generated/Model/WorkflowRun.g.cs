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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A workflow run is an execution of a workflow providing all the runtime information.
    /// </summary>
    public partial class WorkflowRun
    {
        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time when the workflow run completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Checks to see if the CompletedOn property is set.
        /// </summary>
        internal bool IsSetCompletedOn() => this.CompletedOn.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// This error message describes any error that may have occurred in starting the workflow
        /// run. Currently the only error message is "Concurrent runs exceeded for workflow: <c>foo</c>."
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property Graph. 
        /// <para>
        /// The graph representing all the Glue components that belong to the workflow as nodes
        /// and directed connections between them as edges.
        /// </para>
        /// </summary>
        public WorkflowGraph Graph { get; set; }

        /// <summary>
        /// Checks to see if the Graph property is set.
        /// </summary>
        internal bool IsSetGraph() => this.Graph != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the workflow that was run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PreviousRunId. 
        /// <para>
        /// The ID of the previous workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PreviousRunId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousRunId property is set.
        /// </summary>
        internal bool IsSetPreviousRunId() => this.PreviousRunId != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time when the workflow run was started.
        /// </para>
        /// </summary>
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;

        /// <summary>
        /// Gets and sets the property StartingEventBatchCondition. 
        /// <para>
        /// The batch condition that started the workflow run.
        /// </para>
        /// </summary>
        public StartingEventBatchCondition StartingEventBatchCondition { get; set; }

        /// <summary>
        /// Checks to see if the StartingEventBatchCondition property is set.
        /// </summary>
        internal bool IsSetStartingEventBatchCondition() => this.StartingEventBatchCondition != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistics of the run.
        /// </para>
        /// </summary>
        public WorkflowRunStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the workflow run.
        /// </para>
        /// </summary>
        public WorkflowRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The ID of this workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string WorkflowRunId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowRunId property is set.
        /// </summary>
        internal bool IsSetWorkflowRunId() => this.WorkflowRunId != null;

        /// <summary>
        /// Gets and sets the property WorkflowRunProperties. 
        /// <para>
        /// The workflow run properties which were set during the run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> WorkflowRunProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the WorkflowRunProperties property is set.
        /// </summary>
        internal bool IsSetWorkflowRunProperties() => this.WorkflowRunProperties != null && (this.WorkflowRunProperties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
