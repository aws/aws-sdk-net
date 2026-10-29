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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Detailed information about an the execution state of an Automation step.
    /// </summary>
    public partial class StepExecution
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action this step performs. The action determines the behavior of the step.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ExecutionEndTime. 
        /// <para>
        /// If a step has finished execution, this contains the time the execution ended. If the
        /// step hasn't yet concluded, this field isn't populated.
        /// </para>
        /// </summary>
        public DateTime? ExecutionEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEndTime property is set.
        /// </summary>
        internal bool IsSetExecutionEndTime() => this.ExecutionEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionStartTime. 
        /// <para>
        /// If a step has begun execution, this contains the time the step started. If the step
        /// is in Pending status, this field isn't populated.
        /// </para>
        /// </summary>
        public DateTime? ExecutionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartTime property is set.
        /// </summary>
        internal bool IsSetExecutionStartTime() => this.ExecutionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Information about the Automation failure.
        /// </para>
        /// </summary>
        public FailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// If a step failed, this message explains why the execution failed.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Fully-resolved values passed into the step before execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Inputs { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Inputs property is set.
        /// </summary>
        internal bool IsSetInputs() => this.Inputs != null && (this.Inputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsCritical. 
        /// <para>
        /// The flag which can be used to help decide whether the failure of current step leads
        /// to the Automation failure.
        /// </para>
        /// </summary>
        public bool? IsCritical { get; set; }

        /// <summary>
        /// Checks to see if the IsCritical property is set.
        /// </summary>
        internal bool IsSetIsCritical() => this.IsCritical.HasValue;

        /// <summary>
        /// Gets and sets the property IsEnd. 
        /// <para>
        /// The flag which can be used to end automation no matter whether the step succeeds or
        /// fails.
        /// </para>
        /// </summary>
        public bool? IsEnd { get; set; }

        /// <summary>
        /// Checks to see if the IsEnd property is set.
        /// </summary>
        internal bool IsSetIsEnd() => this.IsEnd.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAttempts. 
        /// <para>
        /// The maximum number of tries to run the action of the step. The default value is <c>1</c>.
        /// </para>
        /// </summary>
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// Checks to see if the MaxAttempts property is set.
        /// </summary>
        internal bool IsSetMaxAttempts() => this.MaxAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property NextStep. 
        /// <para>
        /// The next step after the step succeeds.
        /// </para>
        /// </summary>
        public string NextStep { get; set; }

        /// <summary>
        /// Checks to see if the NextStep property is set.
        /// </summary>
        internal bool IsSetNextStep() => this.NextStep != null;

        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// The action to take if the step fails. The default value is <c>Abort</c>.
        /// </para>
        /// </summary>
        public string OnFailure { get; set; }

        /// <summary>
        /// Checks to see if the OnFailure property is set.
        /// </summary>
        internal bool IsSetOnFailure() => this.OnFailure != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// Returned values from the execution of the step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, List<string>> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OverriddenParameters. 
        /// <para>
        /// A user-specified list of parameters to override when running a step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, List<string>> OverriddenParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the OverriddenParameters property is set.
        /// </summary>
        internal bool IsSetOverriddenParameters() => this.OverriddenParameters != null && (this.OverriddenParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentStepDetails. 
        /// <para>
        /// Information about the parent step.
        /// </para>
        /// </summary>
        public ParentStepDetails ParentStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the ParentStepDetails property is set.
        /// </summary>
        internal bool IsSetParentStepDetails() => this.ParentStepDetails != null;

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// A message associated with the response code for an execution.
        /// </para>
        /// </summary>
        public string Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// The response code returned by the execution of the step.
        /// </para>
        /// </summary>
        public string ResponseCode { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCode property is set.
        /// </summary>
        internal bool IsSetResponseCode() => this.ResponseCode != null;

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// The unique ID of a step execution.
        /// </para>
        /// </summary>
        public string StepExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the StepExecutionId property is set.
        /// </summary>
        internal bool IsSetStepExecutionId() => this.StepExecutionId != null;

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of this execution step.
        /// </para>
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;

        /// <summary>
        /// Gets and sets the property StepStatus. 
        /// <para>
        /// The execution status for this step.
        /// </para>
        /// </summary>
        public AutomationExecutionStatus StepStatus { get; set; }

        /// <summary>
        /// Checks to see if the StepStatus property is set.
        /// </summary>
        internal bool IsSetStepStatus() => this.StepStatus != null;

        /// <summary>
        /// Gets and sets the property TargetLocation. 
        /// <para>
        /// The combination of Amazon Web Services Regions and Amazon Web Services accounts targeted
        /// by the current Automation execution.
        /// </para>
        /// </summary>
        public TargetLocation TargetLocation { get; set; }

        /// <summary>
        /// Checks to see if the TargetLocation property is set.
        /// </summary>
        internal bool IsSetTargetLocation() => this.TargetLocation != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets for the step execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Target> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The timeout seconds of the step.
        /// </para>
        /// </summary>
        public long? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarms that were invoked by the automation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<AlarmStateInformation> TriggeredAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<AlarmStateInformation>() : null;

        /// <summary>
        /// Checks to see if the TriggeredAlarms property is set.
        /// </summary>
        internal bool IsSetTriggeredAlarms() => this.TriggeredAlarms != null && (this.TriggeredAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidNextSteps. 
        /// <para>
        /// Strategies used when step fails, we support Continue and Abort. Abort will fail the
        /// automation when the step fails. Continue will ignore the failure of current step and
        /// allow automation to run the next step. With conditional branching, we add step:stepName
        /// to support the automation to go to another specific step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidNextSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ValidNextSteps property is set.
        /// </summary>
        internal bool IsSetValidNextSteps() => this.ValidNextSteps != null && (this.ValidNextSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// A message that describes a non-critical issue that occurred during the step execution.
        /// Present only if the step status includes a warning.
        /// </para>
        /// </summary>
        public string WarningMessage { get; set; }

        /// <summary>
        /// Checks to see if the WarningMessage property is set.
        /// </summary>
        internal bool IsSetWarningMessage() => this.WarningMessage != null;
    }
}
