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
    /// Detailed information about a workflow run execution, including timing, status, error
    /// information, and associated task instances. This structure provides comprehensive
    /// visibility into the workflow execution lifecycle within the Amazon Managed Workflows
    /// for Apache Airflow Serverless serverless environment. The service tracks execution
    /// across distributed ECS worker tasks and provides detailed timing information, error
    /// diagnostics, and task instance relationships to support effective monitoring and troubleshooting
    /// of complex workflow executions.
    /// </summary>
    public partial class WorkflowRunDetail
    {
        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The timestamp when the workflow run completed execution, in ISO 8601 date-time format.
        /// This value is null if the run is not complete.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Checks to see if the CompletedOn property is set.
        /// </summary>
        internal bool IsSetCompletedOn() => this.CompletedOn.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow run was created, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The total duration of the workflow run execution in seconds. This value is null if
        /// the run is not complete.
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message if the workflow run failed. This value is null if the run completed
        /// successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the workflow run was last modified, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of this workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property RunState. 
        /// <para>
        /// The current execution state of the workflow run.
        /// </para>
        /// </summary>
        public WorkflowRunStatus RunState { get; set; }

        /// <summary>
        /// Checks to see if the RunState property is set.
        /// </summary>
        internal bool IsSetRunState() => this.RunState != null;

        /// <summary>
        /// Gets and sets the property RunType. 
        /// <para>
        /// The type of workflow run.
        /// </para>
        /// </summary>
        public RunType RunType { get; set; }

        /// <summary>
        /// Checks to see if the RunType property is set.
        /// </summary>
        internal bool IsSetRunType() => this.RunType != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The timestamp when the workflow run started execution, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;

        /// <summary>
        /// Gets and sets the property TaskInstances. 
        /// <para>
        /// A list of task instance IDs that are part of this workflow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TaskInstances { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TaskInstances property is set.
        /// </summary>
        internal bool IsSetTaskInstances() => this.TaskInstances != null && (this.TaskInstances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version of the workflow used for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WorkflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowVersion property is set.
        /// </summary>
        internal bool IsSetWorkflowVersion() => this.WorkflowVersion != null;
    }
}
