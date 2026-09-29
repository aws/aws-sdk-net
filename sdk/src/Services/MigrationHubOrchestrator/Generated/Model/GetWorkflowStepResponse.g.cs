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

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// This is the response object from the GetWorkflowStep operation.
    /// </summary>
    public partial class GetWorkflowStepResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the step was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the step.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the step ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastStartTime. 
        /// <para>
        /// The time at which the workflow was last started.
        /// </para>
        /// </summary>
        public DateTime? LastStartTime { get; set; }

        /// <summary>
        /// Checks to see if the LastStartTime property is set.
        /// </summary>
        internal bool IsSetLastStartTime() => this.LastStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the step.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Next. 
        /// <para>
        /// The next step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Next { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Next property is set.
        /// </summary>
        internal bool IsSetNext() => this.Next != null && (this.Next.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NoOfSrvCompleted. 
        /// <para>
        /// The number of servers that have been migrated.
        /// </para>
        /// </summary>
        public int? NoOfSrvCompleted { get; set; }

        /// <summary>
        /// Checks to see if the NoOfSrvCompleted property is set.
        /// </summary>
        internal bool IsSetNoOfSrvCompleted() => this.NoOfSrvCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property NoOfSrvFailed. 
        /// <para>
        /// The number of servers that have failed to migrate.
        /// </para>
        /// </summary>
        public int? NoOfSrvFailed { get; set; }

        /// <summary>
        /// Checks to see if the NoOfSrvFailed property is set.
        /// </summary>
        internal bool IsSetNoOfSrvFailed() => this.NoOfSrvFailed.HasValue;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The outputs of the step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<WorkflowStepOutput> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkflowStepOutput>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the step.
        /// </para>
        /// </summary>
        public Owner Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Previous. 
        /// <para>
        /// The previous step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Previous { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Previous property is set.
        /// </summary>
        internal bool IsSetPrevious() => this.Previous != null && (this.Previous.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScriptOutputLocation. 
        /// <para>
        /// The output location of the script.
        /// </para>
        /// </summary>
        public string ScriptOutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the ScriptOutputLocation property is set.
        /// </summary>
        internal bool IsSetScriptOutputLocation() => this.ScriptOutputLocation != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the step.
        /// </para>
        /// </summary>
        public StepStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the migration workflow.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StepActionType. 
        /// <para>
        /// The action type of the step. You must run and update the status of a manual step for
        /// the workflow to continue after the completion of the step.
        /// </para>
        /// </summary>
        public StepActionType StepActionType { get; set; }

        /// <summary>
        /// Checks to see if the StepActionType property is set.
        /// </summary>
        internal bool IsSetStepActionType() => this.StepActionType != null;

        /// <summary>
        /// Gets and sets the property StepGroupId. 
        /// <para>
        /// The ID of the step group.
        /// </para>
        /// </summary>
        public string StepGroupId { get; set; }

        /// <summary>
        /// Checks to see if the StepGroupId property is set.
        /// </summary>
        internal bool IsSetStepGroupId() => this.StepGroupId != null;

        /// <summary>
        /// Gets and sets the property StepId. 
        /// <para>
        /// The ID of the step.
        /// </para>
        /// </summary>
        public string StepId { get; set; }

        /// <summary>
        /// Checks to see if the StepId property is set.
        /// </summary>
        internal bool IsSetStepId() => this.StepId != null;

        /// <summary>
        /// Gets and sets the property StepTarget. 
        /// <para>
        /// The servers on which a step will be run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StepTarget { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StepTarget property is set.
        /// </summary>
        internal bool IsSetStepTarget() => this.StepTarget != null && (this.StepTarget.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalNoOfSrv. 
        /// <para>
        /// The total number of servers that have been migrated.
        /// </para>
        /// </summary>
        public int? TotalNoOfSrv { get; set; }

        /// <summary>
        /// Checks to see if the TotalNoOfSrv property is set.
        /// </summary>
        internal bool IsSetTotalNoOfSrv() => this.TotalNoOfSrv.HasValue;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The ID of the migration workflow.
        /// </para>
        /// </summary>
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;

        /// <summary>
        /// Gets and sets the property WorkflowStepAutomationConfiguration. 
        /// <para>
        /// The custom script to run tests on source or target environments.
        /// </para>
        /// </summary>
        public WorkflowStepAutomationConfiguration WorkflowStepAutomationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowStepAutomationConfiguration property is set.
        /// </summary>
        internal bool IsSetWorkflowStepAutomationConfiguration() => this.WorkflowStepAutomationConfiguration != null;
    }
}
