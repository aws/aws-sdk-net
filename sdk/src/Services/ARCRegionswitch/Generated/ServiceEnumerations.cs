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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ARCRegionswitch
{

    /// <summary>
    /// Constants used for properties of type AlarmCondition.
    /// </summary>
    public class AlarmCondition : ConstantClass
    {

        /// <summary>
        /// Constant Green for AlarmCondition
        /// </summary>
        public static readonly AlarmCondition Green = new AlarmCondition("green");
        /// <summary>
        /// Constant Red for AlarmCondition
        /// </summary>
        public static readonly AlarmCondition Red = new AlarmCondition("red");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlarmCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlarmCondition FindValue(string value)
        {
            return FindValue<AlarmCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlarmCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlarmType.
    /// </summary>
    public class AlarmType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationHealth for AlarmType
        /// </summary>
        public static readonly AlarmType ApplicationHealth = new AlarmType("applicationHealth");
        /// <summary>
        /// Constant Trigger for AlarmType
        /// </summary>
        public static readonly AlarmType Trigger = new AlarmType("trigger");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlarmType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlarmType FindValue(string value)
        {
            return FindValue<AlarmType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlarmType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Approval.
    /// </summary>
    public class Approval : ConstantClass
    {

        /// <summary>
        /// Constant Approve for Approval
        /// </summary>
        public static readonly Approval Approve = new Approval("approve");
        /// <summary>
        /// Constant Decline for Approval
        /// </summary>
        public static readonly Approval Decline = new Approval("decline");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Approval(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Approval FindValue(string value)
        {
            return FindValue<Approval>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Approval(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ec2AsgCapacityMonitoringApproach.
    /// </summary>
    public class Ec2AsgCapacityMonitoringApproach : ConstantClass
    {

        /// <summary>
        /// Constant AutoscalingMaxInLast24Hours for Ec2AsgCapacityMonitoringApproach
        /// </summary>
        public static readonly Ec2AsgCapacityMonitoringApproach AutoscalingMaxInLast24Hours = new Ec2AsgCapacityMonitoringApproach("autoscalingMaxInLast24Hours");
        /// <summary>
        /// Constant SampledMaxInLast24Hours for Ec2AsgCapacityMonitoringApproach
        /// </summary>
        public static readonly Ec2AsgCapacityMonitoringApproach SampledMaxInLast24Hours = new Ec2AsgCapacityMonitoringApproach("sampledMaxInLast24Hours");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ec2AsgCapacityMonitoringApproach(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ec2AsgCapacityMonitoringApproach FindValue(string value)
        {
            return FindValue<Ec2AsgCapacityMonitoringApproach>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ec2AsgCapacityMonitoringApproach(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EcsCapacityMonitoringApproach.
    /// </summary>
    public class EcsCapacityMonitoringApproach : ConstantClass
    {

        /// <summary>
        /// Constant ContainerInsightsMaxInLast24Hours for EcsCapacityMonitoringApproach
        /// </summary>
        public static readonly EcsCapacityMonitoringApproach ContainerInsightsMaxInLast24Hours = new EcsCapacityMonitoringApproach("containerInsightsMaxInLast24Hours");
        /// <summary>
        /// Constant SampledMaxInLast24Hours for EcsCapacityMonitoringApproach
        /// </summary>
        public static readonly EcsCapacityMonitoringApproach SampledMaxInLast24Hours = new EcsCapacityMonitoringApproach("sampledMaxInLast24Hours");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EcsCapacityMonitoringApproach(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EcsCapacityMonitoringApproach FindValue(string value)
        {
            return FindValue<EcsCapacityMonitoringApproach>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EcsCapacityMonitoringApproach(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EksCapacityMonitoringApproach.
    /// </summary>
    public class EksCapacityMonitoringApproach : ConstantClass
    {

        /// <summary>
        /// Constant SampledMaxInLast24Hours for EksCapacityMonitoringApproach
        /// </summary>
        public static readonly EksCapacityMonitoringApproach SampledMaxInLast24Hours = new EksCapacityMonitoringApproach("sampledMaxInLast24Hours");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EksCapacityMonitoringApproach(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EksCapacityMonitoringApproach FindValue(string value)
        {
            return FindValue<EksCapacityMonitoringApproach>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EksCapacityMonitoringApproach(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationStatus.
    /// </summary>
    public class EvaluationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ActionRequired for EvaluationStatus
        /// </summary>
        public static readonly EvaluationStatus ActionRequired = new EvaluationStatus("actionRequired");
        /// <summary>
        /// Constant Passed for EvaluationStatus
        /// </summary>
        public static readonly EvaluationStatus Passed = new EvaluationStatus("passed");
        /// <summary>
        /// Constant PendingEvaluation for EvaluationStatus
        /// </summary>
        public static readonly EvaluationStatus PendingEvaluation = new EvaluationStatus("pendingEvaluation");
        /// <summary>
        /// Constant Unknown for EvaluationStatus
        /// </summary>
        public static readonly EvaluationStatus Unknown = new EvaluationStatus("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationStatus FindValue(string value)
        {
            return FindValue<EvaluationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionAction.
    /// </summary>
    public class ExecutionAction : ConstantClass
    {

        /// <summary>
        /// Constant Activate for ExecutionAction
        /// </summary>
        public static readonly ExecutionAction Activate = new ExecutionAction("activate");
        /// <summary>
        /// Constant Deactivate for ExecutionAction
        /// </summary>
        public static readonly ExecutionAction Deactivate = new ExecutionAction("deactivate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionAction FindValue(string value)
        {
            return FindValue<ExecutionAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionBlockType.
    /// </summary>
    public class ExecutionBlockType : ConstantClass
    {

        /// <summary>
        /// Constant ARCRegionSwitchPlan for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType ARCRegionSwitchPlan = new ExecutionBlockType("ARCRegionSwitchPlan");
        /// <summary>
        /// Constant ARCRoutingControl for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType ARCRoutingControl = new ExecutionBlockType("ARCRoutingControl");
        /// <summary>
        /// Constant AuroraGlobalDatabase for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType AuroraGlobalDatabase = new ExecutionBlockType("AuroraGlobalDatabase");
        /// <summary>
        /// Constant CustomActionLambda for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType CustomActionLambda = new ExecutionBlockType("CustomActionLambda");
        /// <summary>
        /// Constant EC2AutoScaling for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType EC2AutoScaling = new ExecutionBlockType("EC2AutoScaling");
        /// <summary>
        /// Constant ECSServiceScaling for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType ECSServiceScaling = new ExecutionBlockType("ECSServiceScaling");
        /// <summary>
        /// Constant EKSResourceScaling for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType EKSResourceScaling = new ExecutionBlockType("EKSResourceScaling");
        /// <summary>
        /// Constant ManualApproval for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType ManualApproval = new ExecutionBlockType("ManualApproval");
        /// <summary>
        /// Constant Parallel for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType Parallel = new ExecutionBlockType("Parallel");
        /// <summary>
        /// Constant Route53HealthCheck for ExecutionBlockType
        /// </summary>
        public static readonly ExecutionBlockType Route53HealthCheck = new ExecutionBlockType("Route53HealthCheck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionBlockType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionBlockType FindValue(string value)
        {
            return FindValue<ExecutionBlockType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionBlockType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionEventType.
    /// </summary>
    public class ExecutionEventType : ConstantClass
    {

        /// <summary>
        /// Constant ExecutionBehaviorChangedToGraceful for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionBehaviorChangedToGraceful = new ExecutionEventType("executionBehaviorChangedToGraceful");
        /// <summary>
        /// Constant ExecutionBehaviorChangedToUngraceful for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionBehaviorChangedToUngraceful = new ExecutionEventType("executionBehaviorChangedToUngraceful");
        /// <summary>
        /// Constant ExecutionCanceled for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionCanceled = new ExecutionEventType("executionCanceled");
        /// <summary>
        /// Constant ExecutionCanceling for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionCanceling = new ExecutionEventType("executionCanceling");
        /// <summary>
        /// Constant ExecutionFailed for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionFailed = new ExecutionEventType("executionFailed");
        /// <summary>
        /// Constant ExecutionPaused for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionPaused = new ExecutionEventType("executionPaused");
        /// <summary>
        /// Constant ExecutionPausing for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionPausing = new ExecutionEventType("executionPausing");
        /// <summary>
        /// Constant ExecutionPending for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionPending = new ExecutionEventType("executionPending");
        /// <summary>
        /// Constant ExecutionPendingApproval for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionPendingApproval = new ExecutionEventType("executionPendingApproval");
        /// <summary>
        /// Constant ExecutionPendingChildPlanManualApproval for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionPendingChildPlanManualApproval = new ExecutionEventType("executionPendingChildPlanManualApproval");
        /// <summary>
        /// Constant ExecutionStarted for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionStarted = new ExecutionEventType("executionStarted");
        /// <summary>
        /// Constant ExecutionSucceeded for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionSucceeded = new ExecutionEventType("executionSucceeded");
        /// <summary>
        /// Constant ExecutionSuccessMonitoringApplicationHealth for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType ExecutionSuccessMonitoringApplicationHealth = new ExecutionEventType("executionSuccessMonitoringApplicationHealth");
        /// <summary>
        /// Constant StepCanceled for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepCanceled = new ExecutionEventType("stepCanceled");
        /// <summary>
        /// Constant StepExecutionBehaviorChangedToUngraceful for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepExecutionBehaviorChangedToUngraceful = new ExecutionEventType("stepExecutionBehaviorChangedToUngraceful");
        /// <summary>
        /// Constant StepFailed for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepFailed = new ExecutionEventType("stepFailed");
        /// <summary>
        /// Constant StepPausedByError for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepPausedByError = new ExecutionEventType("stepPausedByError");
        /// <summary>
        /// Constant StepPausedByOperator for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepPausedByOperator = new ExecutionEventType("stepPausedByOperator");
        /// <summary>
        /// Constant StepPendingApplicationHealthMonitor for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepPendingApplicationHealthMonitor = new ExecutionEventType("stepPendingApplicationHealthMonitor");
        /// <summary>
        /// Constant StepPendingApproval for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepPendingApproval = new ExecutionEventType("stepPendingApproval");
        /// <summary>
        /// Constant StepSkipped for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepSkipped = new ExecutionEventType("stepSkipped");
        /// <summary>
        /// Constant StepStarted for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepStarted = new ExecutionEventType("stepStarted");
        /// <summary>
        /// Constant StepSucceeded for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepSucceeded = new ExecutionEventType("stepSucceeded");
        /// <summary>
        /// Constant StepUpdate for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType StepUpdate = new ExecutionEventType("stepUpdate");
        /// <summary>
        /// Constant Unknown for ExecutionEventType
        /// </summary>
        public static readonly ExecutionEventType Unknown = new ExecutionEventType("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionEventType FindValue(string value)
        {
            return FindValue<ExecutionEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionMode.
    /// </summary>
    public class ExecutionMode : ConstantClass
    {

        /// <summary>
        /// Constant Graceful for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode Graceful = new ExecutionMode("graceful");
        /// <summary>
        /// Constant Ungraceful for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode Ungraceful = new ExecutionMode("ungraceful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionMode FindValue(string value)
        {
            return FindValue<ExecutionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionState.
    /// </summary>
    public class ExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant Canceled for ExecutionState
        /// </summary>
        public static readonly ExecutionState Canceled = new ExecutionState("canceled");
        /// <summary>
        /// Constant Completed for ExecutionState
        /// </summary>
        public static readonly ExecutionState Completed = new ExecutionState("completed");
        /// <summary>
        /// Constant CompletedMonitoringApplicationHealth for ExecutionState
        /// </summary>
        public static readonly ExecutionState CompletedMonitoringApplicationHealth = new ExecutionState("completedMonitoringApplicationHealth");
        /// <summary>
        /// Constant CompletedWithExceptions for ExecutionState
        /// </summary>
        public static readonly ExecutionState CompletedWithExceptions = new ExecutionState("completedWithExceptions");
        /// <summary>
        /// Constant Failed for ExecutionState
        /// </summary>
        public static readonly ExecutionState Failed = new ExecutionState("failed");
        /// <summary>
        /// Constant InProgress for ExecutionState
        /// </summary>
        public static readonly ExecutionState InProgress = new ExecutionState("inProgress");
        /// <summary>
        /// Constant PausedByFailedStep for ExecutionState
        /// </summary>
        public static readonly ExecutionState PausedByFailedStep = new ExecutionState("pausedByFailedStep");
        /// <summary>
        /// Constant PausedByOperator for ExecutionState
        /// </summary>
        public static readonly ExecutionState PausedByOperator = new ExecutionState("pausedByOperator");
        /// <summary>
        /// Constant Pending for ExecutionState
        /// </summary>
        public static readonly ExecutionState Pending = new ExecutionState("pending");
        /// <summary>
        /// Constant PendingManualApproval for ExecutionState
        /// </summary>
        public static readonly ExecutionState PendingManualApproval = new ExecutionState("pendingManualApproval");
        /// <summary>
        /// Constant PlanExecutionTimedOut for ExecutionState
        /// </summary>
        public static readonly ExecutionState PlanExecutionTimedOut = new ExecutionState("planExecutionTimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionState FindValue(string value)
        {
            return FindValue<ExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlobalAuroraDefaultBehavior.
    /// </summary>
    public class GlobalAuroraDefaultBehavior : ConstantClass
    {

        /// <summary>
        /// Constant Failover for GlobalAuroraDefaultBehavior
        /// </summary>
        public static readonly GlobalAuroraDefaultBehavior Failover = new GlobalAuroraDefaultBehavior("failover");
        /// <summary>
        /// Constant SwitchoverOnly for GlobalAuroraDefaultBehavior
        /// </summary>
        public static readonly GlobalAuroraDefaultBehavior SwitchoverOnly = new GlobalAuroraDefaultBehavior("switchoverOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalAuroraDefaultBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalAuroraDefaultBehavior FindValue(string value)
        {
            return FindValue<GlobalAuroraDefaultBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalAuroraDefaultBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlobalAuroraUngracefulBehavior.
    /// </summary>
    public class GlobalAuroraUngracefulBehavior : ConstantClass
    {

        /// <summary>
        /// Constant Failover for GlobalAuroraUngracefulBehavior
        /// </summary>
        public static readonly GlobalAuroraUngracefulBehavior Failover = new GlobalAuroraUngracefulBehavior("failover");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalAuroraUngracefulBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalAuroraUngracefulBehavior FindValue(string value)
        {
            return FindValue<GlobalAuroraUngracefulBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalAuroraUngracefulBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaUngracefulBehavior.
    /// </summary>
    public class LambdaUngracefulBehavior : ConstantClass
    {

        /// <summary>
        /// Constant Skip for LambdaUngracefulBehavior
        /// </summary>
        public static readonly LambdaUngracefulBehavior Skip = new LambdaUngracefulBehavior("skip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaUngracefulBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaUngracefulBehavior FindValue(string value)
        {
            return FindValue<LambdaUngracefulBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaUngracefulBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecoveryApproach.
    /// </summary>
    public class RecoveryApproach : ConstantClass
    {

        /// <summary>
        /// Constant ActiveActive for RecoveryApproach
        /// </summary>
        public static readonly RecoveryApproach ActiveActive = new RecoveryApproach("activeActive");
        /// <summary>
        /// Constant ActivePassive for RecoveryApproach
        /// </summary>
        public static readonly RecoveryApproach ActivePassive = new RecoveryApproach("activePassive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecoveryApproach(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecoveryApproach FindValue(string value)
        {
            return FindValue<RecoveryApproach>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecoveryApproach(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionToRunIn.
    /// </summary>
    public class RegionToRunIn : ConstantClass
    {

        /// <summary>
        /// Constant ActivatingRegion for RegionToRunIn
        /// </summary>
        public static readonly RegionToRunIn ActivatingRegion = new RegionToRunIn("activatingRegion");
        /// <summary>
        /// Constant DeactivatingRegion for RegionToRunIn
        /// </summary>
        public static readonly RegionToRunIn DeactivatingRegion = new RegionToRunIn("deactivatingRegion");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionToRunIn(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionToRunIn FindValue(string value)
        {
            return FindValue<RegionToRunIn>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionToRunIn(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceWarningStatus.
    /// </summary>
    public class ResourceWarningStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for ResourceWarningStatus
        /// </summary>
        public static readonly ResourceWarningStatus Active = new ResourceWarningStatus("active");
        /// <summary>
        /// Constant Resolved for ResourceWarningStatus
        /// </summary>
        public static readonly ResourceWarningStatus Resolved = new ResourceWarningStatus("resolved");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceWarningStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceWarningStatus FindValue(string value)
        {
            return FindValue<ResourceWarningStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceWarningStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutingControlStateChange.
    /// </summary>
    public class RoutingControlStateChange : ConstantClass
    {

        /// <summary>
        /// Constant Off for RoutingControlStateChange
        /// </summary>
        public static readonly RoutingControlStateChange Off = new RoutingControlStateChange("Off");
        /// <summary>
        /// Constant On for RoutingControlStateChange
        /// </summary>
        public static readonly RoutingControlStateChange On = new RoutingControlStateChange("On");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingControlStateChange(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingControlStateChange FindValue(string value)
        {
            return FindValue<RoutingControlStateChange>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingControlStateChange(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepStatus.
    /// </summary>
    public class StepStatus : ConstantClass
    {

        /// <summary>
        /// Constant Canceled for StepStatus
        /// </summary>
        public static readonly StepStatus Canceled = new StepStatus("canceled");
        /// <summary>
        /// Constant Completed for StepStatus
        /// </summary>
        public static readonly StepStatus Completed = new StepStatus("completed");
        /// <summary>
        /// Constant Failed for StepStatus
        /// </summary>
        public static readonly StepStatus Failed = new StepStatus("failed");
        /// <summary>
        /// Constant NotStarted for StepStatus
        /// </summary>
        public static readonly StepStatus NotStarted = new StepStatus("notStarted");
        /// <summary>
        /// Constant PendingApproval for StepStatus
        /// </summary>
        public static readonly StepStatus PendingApproval = new StepStatus("pendingApproval");
        /// <summary>
        /// Constant Running for StepStatus
        /// </summary>
        public static readonly StepStatus Running = new StepStatus("running");
        /// <summary>
        /// Constant Skipped for StepStatus
        /// </summary>
        public static readonly StepStatus Skipped = new StepStatus("skipped");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepStatus FindValue(string value)
        {
            return FindValue<StepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdatePlanExecutionAction.
    /// </summary>
    public class UpdatePlanExecutionAction : ConstantClass
    {

        /// <summary>
        /// Constant Pause for UpdatePlanExecutionAction
        /// </summary>
        public static readonly UpdatePlanExecutionAction Pause = new UpdatePlanExecutionAction("pause");
        /// <summary>
        /// Constant Resume for UpdatePlanExecutionAction
        /// </summary>
        public static readonly UpdatePlanExecutionAction Resume = new UpdatePlanExecutionAction("resume");
        /// <summary>
        /// Constant SwitchToGraceful for UpdatePlanExecutionAction
        /// </summary>
        public static readonly UpdatePlanExecutionAction SwitchToGraceful = new UpdatePlanExecutionAction("switchToGraceful");
        /// <summary>
        /// Constant SwitchToUngraceful for UpdatePlanExecutionAction
        /// </summary>
        public static readonly UpdatePlanExecutionAction SwitchToUngraceful = new UpdatePlanExecutionAction("switchToUngraceful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdatePlanExecutionAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdatePlanExecutionAction FindValue(string value)
        {
            return FindValue<UpdatePlanExecutionAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdatePlanExecutionAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdatePlanExecutionStepAction.
    /// </summary>
    public class UpdatePlanExecutionStepAction : ConstantClass
    {

        /// <summary>
        /// Constant Skip for UpdatePlanExecutionStepAction
        /// </summary>
        public static readonly UpdatePlanExecutionStepAction Skip = new UpdatePlanExecutionStepAction("skip");
        /// <summary>
        /// Constant SwitchToUngraceful for UpdatePlanExecutionStepAction
        /// </summary>
        public static readonly UpdatePlanExecutionStepAction SwitchToUngraceful = new UpdatePlanExecutionStepAction("switchToUngraceful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdatePlanExecutionStepAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdatePlanExecutionStepAction FindValue(string value)
        {
            return FindValue<UpdatePlanExecutionStepAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdatePlanExecutionStepAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowTargetAction.
    /// </summary>
    public class WorkflowTargetAction : ConstantClass
    {

        /// <summary>
        /// Constant Activate for WorkflowTargetAction
        /// </summary>
        public static readonly WorkflowTargetAction Activate = new WorkflowTargetAction("activate");
        /// <summary>
        /// Constant Deactivate for WorkflowTargetAction
        /// </summary>
        public static readonly WorkflowTargetAction Deactivate = new WorkflowTargetAction("deactivate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowTargetAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowTargetAction FindValue(string value)
        {
            return FindValue<WorkflowTargetAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowTargetAction(string value)
        {
            return FindValue(value);
        }
    }

}