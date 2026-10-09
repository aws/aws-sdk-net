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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// This is the response object from the GetPlanExecution operation.
    /// </summary>
    public partial class GetPlanExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActualRecoveryTime. 
        /// <para>
        /// The actual recovery time that Region switch calculates for a plan execution. Actual
        /// recovery time includes the time for the plan to run added to the time elapsed until
        /// the application health alarms that you've specified are healthy again.
        /// </para>
        /// </summary>
        public string ActualRecoveryTime { get; set; }

        /// <summary>
        /// Checks to see if the ActualRecoveryTime property is set.
        /// </summary>
        internal bool IsSetActualRecoveryTime() => this.ActualRecoveryTime != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment included on the plan execution.
        /// </para>
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time (UTC) when the plan execution ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionAction. 
        /// <para>
        /// The plan execution action. Valid values are <c>activate</c>, to activate an Amazon
        /// Web Services Region, or <c>deactivate</c>, to deactivate a Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionAction ExecutionAction { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionAction property is set.
        /// </summary>
        internal bool IsSetExecutionAction() => this.ExecutionAction != null;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution identifier of a plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property ExecutionRegion. 
        /// <para>
        /// The Amazon Web Services Region for a plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExecutionRegion { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRegion property is set.
        /// </summary>
        internal bool IsSetExecutionRegion() => this.ExecutionRegion != null;

        /// <summary>
        /// Gets and sets the property ExecutionState. 
        /// <para>
        /// The plan execution state. Provides the state of a plan execution, for example, In
        /// Progress or Paused by Operator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionState ExecutionState { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionState property is set.
        /// </summary>
        internal bool IsSetExecutionState() => this.ExecutionState != null;

        /// <summary>
        /// Gets and sets the property GeneratedReportDetails. 
        /// <para>
        /// Information about the location of a generated report, or the cause of its failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<GeneratedReport> GeneratedReportDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<GeneratedReport>() : null;

        /// <summary>
        /// Checks to see if the GeneratedReportDetails property is set.
        /// </summary>
        internal bool IsSetGeneratedReportDetails() => this.GeneratedReportDetails != null && (this.GeneratedReportDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The plan execution mode. Valid values are <c>graceful</c>, for graceful executions,
        /// or <c>ungraceful</c>, for ungraceful executions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>nextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>nextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Plan. 
        /// <para>
        /// The details of the Region switch plan.
        /// </para>
        /// </summary>
        public Plan Plan { get; set; }

        /// <summary>
        /// Checks to see if the Plan property is set.
        /// </summary>
        internal bool IsSetPlan() => this.Plan != null;

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanArn { get; set; }

        /// <summary>
        /// Checks to see if the PlanArn property is set.
        /// </summary>
        internal bool IsSetPlanArn() => this.PlanArn != null;

        /// <summary>
        /// Gets and sets the property RecoveryExecutionId. 
        /// <para>
        /// The unique identifier of the most recent recovery execution. Required when starting
        /// a post-recovery execution.
        /// </para>
        /// </summary>
        public string RecoveryExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryExecutionId property is set.
        /// </summary>
        internal bool IsSetRecoveryExecutionId() => this.RecoveryExecutionId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time (UTC) when the plan execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StepStates. 
        /// <para>
        /// The states of the steps in the plan execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StepState> StepStates { get; set; } = AWSConfigs.InitializeCollections ? new List<StepState>() : null;

        /// <summary>
        /// Checks to see if the StepStates property is set.
        /// </summary>
        internal bool IsSetStepStates() => this.StepStates != null && (this.StepStates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the plan execution was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version for the plan.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
