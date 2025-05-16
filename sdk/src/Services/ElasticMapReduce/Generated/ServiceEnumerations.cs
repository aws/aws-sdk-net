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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElasticMapReduce
{

    /// <summary>
    /// Constants used for properties of type ActionOnFailure.
    /// </summary>
    public class ActionOnFailure : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL_AND_WAIT for ActionOnFailure
        /// </summary>
        public static readonly ActionOnFailure CANCEL_AND_WAIT = new ActionOnFailure("CANCEL_AND_WAIT");
        /// <summary>
        /// Constant CONTINUE for ActionOnFailure
        /// </summary>
        public static readonly ActionOnFailure CONTINUE = new ActionOnFailure("CONTINUE");
        /// <summary>
        /// Constant TERMINATE_CLUSTER for ActionOnFailure
        /// </summary>
        public static readonly ActionOnFailure TERMINATE_CLUSTER = new ActionOnFailure("TERMINATE_CLUSTER");
        /// <summary>
        /// Constant TERMINATE_JOB_FLOW for ActionOnFailure
        /// </summary>
        public static readonly ActionOnFailure TERMINATE_JOB_FLOW = new ActionOnFailure("TERMINATE_JOB_FLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionOnFailure(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionOnFailure FindValue(string value)
        {
            return FindValue<ActionOnFailure>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionOnFailure(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdjustmentType.
    /// </summary>
    public class AdjustmentType : ConstantClass
    {

        /// <summary>
        /// Constant CHANGE_IN_CAPACITY for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType CHANGE_IN_CAPACITY = new AdjustmentType("CHANGE_IN_CAPACITY");
        /// <summary>
        /// Constant EXACT_CAPACITY for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType EXACT_CAPACITY = new AdjustmentType("EXACT_CAPACITY");
        /// <summary>
        /// Constant PERCENT_CHANGE_IN_CAPACITY for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType PERCENT_CHANGE_IN_CAPACITY = new AdjustmentType("PERCENT_CHANGE_IN_CAPACITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdjustmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdjustmentType FindValue(string value)
        {
            return FindValue<AdjustmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdjustmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthMode.
    /// </summary>
    public class AuthMode : ConstantClass
    {

        /// <summary>
        /// Constant IAM for AuthMode
        /// </summary>
        public static readonly AuthMode IAM = new AuthMode("IAM");
        /// <summary>
        /// Constant SSO for AuthMode
        /// </summary>
        public static readonly AuthMode SSO = new AuthMode("SSO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthMode FindValue(string value)
        {
            return FindValue<AuthMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoScalingPolicyState.
    /// </summary>
    public class AutoScalingPolicyState : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHED for AutoScalingPolicyState
        /// </summary>
        public static readonly AutoScalingPolicyState ATTACHED = new AutoScalingPolicyState("ATTACHED");
        /// <summary>
        /// Constant ATTACHING for AutoScalingPolicyState
        /// </summary>
        public static readonly AutoScalingPolicyState ATTACHING = new AutoScalingPolicyState("ATTACHING");
        /// <summary>
        /// Constant DETACHED for AutoScalingPolicyState
        /// </summary>
        public static readonly AutoScalingPolicyState DETACHED = new AutoScalingPolicyState("DETACHED");
        /// <summary>
        /// Constant DETACHING for AutoScalingPolicyState
        /// </summary>
        public static readonly AutoScalingPolicyState DETACHING = new AutoScalingPolicyState("DETACHING");
        /// <summary>
        /// Constant FAILED for AutoScalingPolicyState
        /// </summary>
        public static readonly AutoScalingPolicyState FAILED = new AutoScalingPolicyState("FAILED");
        /// <summary>
        /// Constant PENDING for AutoScalingPolicyState
        /// </summary>
        public static readonly AutoScalingPolicyState PENDING = new AutoScalingPolicyState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingPolicyState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingPolicyState FindValue(string value)
        {
            return FindValue<AutoScalingPolicyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingPolicyState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoScalingPolicyStateChangeReasonCode.
    /// </summary>
    public class AutoScalingPolicyStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CLEANUP_FAILURE for AutoScalingPolicyStateChangeReasonCode
        /// </summary>
        public static readonly AutoScalingPolicyStateChangeReasonCode CLEANUP_FAILURE = new AutoScalingPolicyStateChangeReasonCode("CLEANUP_FAILURE");
        /// <summary>
        /// Constant PROVISION_FAILURE for AutoScalingPolicyStateChangeReasonCode
        /// </summary>
        public static readonly AutoScalingPolicyStateChangeReasonCode PROVISION_FAILURE = new AutoScalingPolicyStateChangeReasonCode("PROVISION_FAILURE");
        /// <summary>
        /// Constant USER_REQUEST for AutoScalingPolicyStateChangeReasonCode
        /// </summary>
        public static readonly AutoScalingPolicyStateChangeReasonCode USER_REQUEST = new AutoScalingPolicyStateChangeReasonCode("USER_REQUEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingPolicyStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingPolicyStateChangeReasonCode FindValue(string value)
        {
            return FindValue<AutoScalingPolicyStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingPolicyStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CancelStepsRequestStatus.
    /// </summary>
    public class CancelStepsRequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CancelStepsRequestStatus
        /// </summary>
        public static readonly CancelStepsRequestStatus FAILED = new CancelStepsRequestStatus("FAILED");
        /// <summary>
        /// Constant SUBMITTED for CancelStepsRequestStatus
        /// </summary>
        public static readonly CancelStepsRequestStatus SUBMITTED = new CancelStepsRequestStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CancelStepsRequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CancelStepsRequestStatus FindValue(string value)
        {
            return FindValue<CancelStepsRequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CancelStepsRequestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterState.
    /// </summary>
    public class ClusterState : ConstantClass
    {

        /// <summary>
        /// Constant BOOTSTRAPPING for ClusterState
        /// </summary>
        public static readonly ClusterState BOOTSTRAPPING = new ClusterState("BOOTSTRAPPING");
        /// <summary>
        /// Constant RUNNING for ClusterState
        /// </summary>
        public static readonly ClusterState RUNNING = new ClusterState("RUNNING");
        /// <summary>
        /// Constant STARTING for ClusterState
        /// </summary>
        public static readonly ClusterState STARTING = new ClusterState("STARTING");
        /// <summary>
        /// Constant TERMINATED for ClusterState
        /// </summary>
        public static readonly ClusterState TERMINATED = new ClusterState("TERMINATED");
        /// <summary>
        /// Constant TERMINATED_WITH_ERRORS for ClusterState
        /// </summary>
        public static readonly ClusterState TERMINATED_WITH_ERRORS = new ClusterState("TERMINATED_WITH_ERRORS");
        /// <summary>
        /// Constant TERMINATING for ClusterState
        /// </summary>
        public static readonly ClusterState TERMINATING = new ClusterState("TERMINATING");
        /// <summary>
        /// Constant WAITING for ClusterState
        /// </summary>
        public static readonly ClusterState WAITING = new ClusterState("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterState FindValue(string value)
        {
            return FindValue<ClusterState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterStateChangeReasonCode.
    /// </summary>
    public class ClusterStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant ALL_STEPS_COMPLETED for ClusterStateChangeReasonCode
        /// </summary>
        public static readonly ClusterStateChangeReasonCode ALL_STEPS_COMPLETED = new ClusterStateChangeReasonCode("ALL_STEPS_COMPLETED");
        /// <summary>
        /// Constant BOOTSTRAP_FAILURE for ClusterStateChangeReasonCode
        /// </summary>
        public static readonly ClusterStateChangeReasonCode BOOTSTRAP_FAILURE = new ClusterStateChangeReasonCode("BOOTSTRAP_FAILURE");
        /// <summary>
        /// Constant INSTANCE_FAILURE for ClusterStateChangeReasonCode
        /// </summary>
        public static readonly ClusterStateChangeReasonCode INSTANCE_FAILURE = new ClusterStateChangeReasonCode("INSTANCE_FAILURE");
        /// <summary>
        /// Constant INSTANCE_FLEET_TIMEOUT for ClusterStateChangeReasonCode
        /// </summary>
        public static readonly ClusterStateChangeReasonCode INSTANCE_FLEET_TIMEOUT = new ClusterStateChangeReasonCode("INSTANCE_FLEET_TIMEOUT");
        /// <summary>
        /// Constant INTERNAL_ERROR for ClusterStateChangeReasonCode
        /// </summary>
        public static readonly ClusterStateChangeReasonCode INTERNAL_ERROR = new ClusterStateChangeReasonCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant STEP_FAILURE for ClusterStateChangeReasonCode
        /// </summary>
        public static readonly ClusterStateChangeReasonCode STEP_FAILURE = new ClusterStateChangeReasonCode("STEP_FAILURE");
        /// <summary>
        /// Constant USER_REQUEST for ClusterStateChangeReasonCode
        /// </summary>
        public static readonly ClusterStateChangeReasonCode USER_REQUEST = new ClusterStateChangeReasonCode("USER_REQUEST");
        /// <summary>
        /// Constant VALIDATION_ERROR for ClusterStateChangeReasonCode
        /// </summary>
        public static readonly ClusterStateChangeReasonCode VALIDATION_ERROR = new ClusterStateChangeReasonCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterStateChangeReasonCode FindValue(string value)
        {
            return FindValue<ClusterStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant GREATER_THAN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_THAN = new ComparisonOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_THAN_OR_EQUAL = new ComparisonOperator("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant LESS_THAN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_THAN = new ComparisonOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_THAN_OR_EQUAL = new ComparisonOperator("LESS_THAN_OR_EQUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeLimitsUnitType.
    /// </summary>
    public class ComputeLimitsUnitType : ConstantClass
    {

        /// <summary>
        /// Constant InstanceFleetUnits for ComputeLimitsUnitType
        /// </summary>
        public static readonly ComputeLimitsUnitType InstanceFleetUnits = new ComputeLimitsUnitType("InstanceFleetUnits");
        /// <summary>
        /// Constant Instances for ComputeLimitsUnitType
        /// </summary>
        public static readonly ComputeLimitsUnitType Instances = new ComputeLimitsUnitType("Instances");
        /// <summary>
        /// Constant VCPU for ComputeLimitsUnitType
        /// </summary>
        public static readonly ComputeLimitsUnitType VCPU = new ComputeLimitsUnitType("VCPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeLimitsUnitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeLimitsUnitType FindValue(string value)
        {
            return FindValue<ComputeLimitsUnitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeLimitsUnitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionEngineType.
    /// </summary>
    public class ExecutionEngineType : ConstantClass
    {

        /// <summary>
        /// Constant EMR for ExecutionEngineType
        /// </summary>
        public static readonly ExecutionEngineType EMR = new ExecutionEngineType("EMR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionEngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionEngineType FindValue(string value)
        {
            return FindValue<ExecutionEngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionEngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdcUserAssignment.
    /// </summary>
    public class IdcUserAssignment : ConstantClass
    {

        /// <summary>
        /// Constant OPTIONAL for IdcUserAssignment
        /// </summary>
        public static readonly IdcUserAssignment OPTIONAL = new IdcUserAssignment("OPTIONAL");
        /// <summary>
        /// Constant REQUIRED for IdcUserAssignment
        /// </summary>
        public static readonly IdcUserAssignment REQUIRED = new IdcUserAssignment("REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdcUserAssignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdcUserAssignment FindValue(string value)
        {
            return FindValue<IdcUserAssignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdcUserAssignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityType.
    /// </summary>
    public class IdentityType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for IdentityType
        /// </summary>
        public static readonly IdentityType GROUP = new IdentityType("GROUP");
        /// <summary>
        /// Constant USER for IdentityType
        /// </summary>
        public static readonly IdentityType USER = new IdentityType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityType FindValue(string value)
        {
            return FindValue<IdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceCollectionType.
    /// </summary>
    public class InstanceCollectionType : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE_FLEET for InstanceCollectionType
        /// </summary>
        public static readonly InstanceCollectionType INSTANCE_FLEET = new InstanceCollectionType("INSTANCE_FLEET");
        /// <summary>
        /// Constant INSTANCE_GROUP for InstanceCollectionType
        /// </summary>
        public static readonly InstanceCollectionType INSTANCE_GROUP = new InstanceCollectionType("INSTANCE_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceCollectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceCollectionType FindValue(string value)
        {
            return FindValue<InstanceCollectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceCollectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceFleetState.
    /// </summary>
    public class InstanceFleetState : ConstantClass
    {

        /// <summary>
        /// Constant BOOTSTRAPPING for InstanceFleetState
        /// </summary>
        public static readonly InstanceFleetState BOOTSTRAPPING = new InstanceFleetState("BOOTSTRAPPING");
        /// <summary>
        /// Constant PROVISIONING for InstanceFleetState
        /// </summary>
        public static readonly InstanceFleetState PROVISIONING = new InstanceFleetState("PROVISIONING");
        /// <summary>
        /// Constant RESIZING for InstanceFleetState
        /// </summary>
        public static readonly InstanceFleetState RESIZING = new InstanceFleetState("RESIZING");
        /// <summary>
        /// Constant RUNNING for InstanceFleetState
        /// </summary>
        public static readonly InstanceFleetState RUNNING = new InstanceFleetState("RUNNING");
        /// <summary>
        /// Constant SUSPENDED for InstanceFleetState
        /// </summary>
        public static readonly InstanceFleetState SUSPENDED = new InstanceFleetState("SUSPENDED");
        /// <summary>
        /// Constant TERMINATED for InstanceFleetState
        /// </summary>
        public static readonly InstanceFleetState TERMINATED = new InstanceFleetState("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for InstanceFleetState
        /// </summary>
        public static readonly InstanceFleetState TERMINATING = new InstanceFleetState("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceFleetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceFleetState FindValue(string value)
        {
            return FindValue<InstanceFleetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceFleetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceFleetStateChangeReasonCode.
    /// </summary>
    public class InstanceFleetStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER_TERMINATED for InstanceFleetStateChangeReasonCode
        /// </summary>
        public static readonly InstanceFleetStateChangeReasonCode CLUSTER_TERMINATED = new InstanceFleetStateChangeReasonCode("CLUSTER_TERMINATED");
        /// <summary>
        /// Constant INSTANCE_FAILURE for InstanceFleetStateChangeReasonCode
        /// </summary>
        public static readonly InstanceFleetStateChangeReasonCode INSTANCE_FAILURE = new InstanceFleetStateChangeReasonCode("INSTANCE_FAILURE");
        /// <summary>
        /// Constant INTERNAL_ERROR for InstanceFleetStateChangeReasonCode
        /// </summary>
        public static readonly InstanceFleetStateChangeReasonCode INTERNAL_ERROR = new InstanceFleetStateChangeReasonCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant VALIDATION_ERROR for InstanceFleetStateChangeReasonCode
        /// </summary>
        public static readonly InstanceFleetStateChangeReasonCode VALIDATION_ERROR = new InstanceFleetStateChangeReasonCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceFleetStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceFleetStateChangeReasonCode FindValue(string value)
        {
            return FindValue<InstanceFleetStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceFleetStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceFleetType.
    /// </summary>
    public class InstanceFleetType : ConstantClass
    {

        /// <summary>
        /// Constant CORE for InstanceFleetType
        /// </summary>
        public static readonly InstanceFleetType CORE = new InstanceFleetType("CORE");
        /// <summary>
        /// Constant MASTER for InstanceFleetType
        /// </summary>
        public static readonly InstanceFleetType MASTER = new InstanceFleetType("MASTER");
        /// <summary>
        /// Constant TASK for InstanceFleetType
        /// </summary>
        public static readonly InstanceFleetType TASK = new InstanceFleetType("TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceFleetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceFleetType FindValue(string value)
        {
            return FindValue<InstanceFleetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceFleetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceGroupState.
    /// </summary>
    public class InstanceGroupState : ConstantClass
    {

        /// <summary>
        /// Constant ARRESTED for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState ARRESTED = new InstanceGroupState("ARRESTED");
        /// <summary>
        /// Constant BOOTSTRAPPING for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState BOOTSTRAPPING = new InstanceGroupState("BOOTSTRAPPING");
        /// <summary>
        /// Constant ENDED for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState ENDED = new InstanceGroupState("ENDED");
        /// <summary>
        /// Constant PROVISIONING for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState PROVISIONING = new InstanceGroupState("PROVISIONING");
        /// <summary>
        /// Constant RECONFIGURING for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState RECONFIGURING = new InstanceGroupState("RECONFIGURING");
        /// <summary>
        /// Constant RESIZING for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState RESIZING = new InstanceGroupState("RESIZING");
        /// <summary>
        /// Constant RUNNING for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState RUNNING = new InstanceGroupState("RUNNING");
        /// <summary>
        /// Constant SHUTTING_DOWN for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState SHUTTING_DOWN = new InstanceGroupState("SHUTTING_DOWN");
        /// <summary>
        /// Constant SUSPENDED for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState SUSPENDED = new InstanceGroupState("SUSPENDED");
        /// <summary>
        /// Constant TERMINATED for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState TERMINATED = new InstanceGroupState("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for InstanceGroupState
        /// </summary>
        public static readonly InstanceGroupState TERMINATING = new InstanceGroupState("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceGroupState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceGroupState FindValue(string value)
        {
            return FindValue<InstanceGroupState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceGroupState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceGroupStateChangeReasonCode.
    /// </summary>
    public class InstanceGroupStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER_TERMINATED for InstanceGroupStateChangeReasonCode
        /// </summary>
        public static readonly InstanceGroupStateChangeReasonCode CLUSTER_TERMINATED = new InstanceGroupStateChangeReasonCode("CLUSTER_TERMINATED");
        /// <summary>
        /// Constant INSTANCE_FAILURE for InstanceGroupStateChangeReasonCode
        /// </summary>
        public static readonly InstanceGroupStateChangeReasonCode INSTANCE_FAILURE = new InstanceGroupStateChangeReasonCode("INSTANCE_FAILURE");
        /// <summary>
        /// Constant INTERNAL_ERROR for InstanceGroupStateChangeReasonCode
        /// </summary>
        public static readonly InstanceGroupStateChangeReasonCode INTERNAL_ERROR = new InstanceGroupStateChangeReasonCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant VALIDATION_ERROR for InstanceGroupStateChangeReasonCode
        /// </summary>
        public static readonly InstanceGroupStateChangeReasonCode VALIDATION_ERROR = new InstanceGroupStateChangeReasonCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceGroupStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceGroupStateChangeReasonCode FindValue(string value)
        {
            return FindValue<InstanceGroupStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceGroupStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceGroupType.
    /// </summary>
    public class InstanceGroupType : ConstantClass
    {

        /// <summary>
        /// Constant CORE for InstanceGroupType
        /// </summary>
        public static readonly InstanceGroupType CORE = new InstanceGroupType("CORE");
        /// <summary>
        /// Constant MASTER for InstanceGroupType
        /// </summary>
        public static readonly InstanceGroupType MASTER = new InstanceGroupType("MASTER");
        /// <summary>
        /// Constant TASK for InstanceGroupType
        /// </summary>
        public static readonly InstanceGroupType TASK = new InstanceGroupType("TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceGroupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceGroupType FindValue(string value)
        {
            return FindValue<InstanceGroupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceGroupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceRoleType.
    /// </summary>
    public class InstanceRoleType : ConstantClass
    {

        /// <summary>
        /// Constant CORE for InstanceRoleType
        /// </summary>
        public static readonly InstanceRoleType CORE = new InstanceRoleType("CORE");
        /// <summary>
        /// Constant MASTER for InstanceRoleType
        /// </summary>
        public static readonly InstanceRoleType MASTER = new InstanceRoleType("MASTER");
        /// <summary>
        /// Constant TASK for InstanceRoleType
        /// </summary>
        public static readonly InstanceRoleType TASK = new InstanceRoleType("TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceRoleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceRoleType FindValue(string value)
        {
            return FindValue<InstanceRoleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceRoleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceState.
    /// </summary>
    public class InstanceState : ConstantClass
    {

        /// <summary>
        /// Constant AWAITING_FULFILLMENT for InstanceState
        /// </summary>
        public static readonly InstanceState AWAITING_FULFILLMENT = new InstanceState("AWAITING_FULFILLMENT");
        /// <summary>
        /// Constant BOOTSTRAPPING for InstanceState
        /// </summary>
        public static readonly InstanceState BOOTSTRAPPING = new InstanceState("BOOTSTRAPPING");
        /// <summary>
        /// Constant PROVISIONING for InstanceState
        /// </summary>
        public static readonly InstanceState PROVISIONING = new InstanceState("PROVISIONING");
        /// <summary>
        /// Constant RUNNING for InstanceState
        /// </summary>
        public static readonly InstanceState RUNNING = new InstanceState("RUNNING");
        /// <summary>
        /// Constant TERMINATED for InstanceState
        /// </summary>
        public static readonly InstanceState TERMINATED = new InstanceState("TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceState FindValue(string value)
        {
            return FindValue<InstanceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceStateChangeReasonCode.
    /// </summary>
    public class InstanceStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant BOOTSTRAP_FAILURE for InstanceStateChangeReasonCode
        /// </summary>
        public static readonly InstanceStateChangeReasonCode BOOTSTRAP_FAILURE = new InstanceStateChangeReasonCode("BOOTSTRAP_FAILURE");
        /// <summary>
        /// Constant CLUSTER_TERMINATED for InstanceStateChangeReasonCode
        /// </summary>
        public static readonly InstanceStateChangeReasonCode CLUSTER_TERMINATED = new InstanceStateChangeReasonCode("CLUSTER_TERMINATED");
        /// <summary>
        /// Constant INSTANCE_FAILURE for InstanceStateChangeReasonCode
        /// </summary>
        public static readonly InstanceStateChangeReasonCode INSTANCE_FAILURE = new InstanceStateChangeReasonCode("INSTANCE_FAILURE");
        /// <summary>
        /// Constant INTERNAL_ERROR for InstanceStateChangeReasonCode
        /// </summary>
        public static readonly InstanceStateChangeReasonCode INTERNAL_ERROR = new InstanceStateChangeReasonCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant VALIDATION_ERROR for InstanceStateChangeReasonCode
        /// </summary>
        public static readonly InstanceStateChangeReasonCode VALIDATION_ERROR = new InstanceStateChangeReasonCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStateChangeReasonCode FindValue(string value)
        {
            return FindValue<InstanceStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobFlowExecutionState.
    /// </summary>
    public class JobFlowExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant BOOTSTRAPPING for JobFlowExecutionState
        /// </summary>
        public static readonly JobFlowExecutionState BOOTSTRAPPING = new JobFlowExecutionState("BOOTSTRAPPING");
        /// <summary>
        /// Constant COMPLETED for JobFlowExecutionState
        /// </summary>
        public static readonly JobFlowExecutionState COMPLETED = new JobFlowExecutionState("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobFlowExecutionState
        /// </summary>
        public static readonly JobFlowExecutionState FAILED = new JobFlowExecutionState("FAILED");
        /// <summary>
        /// Constant RUNNING for JobFlowExecutionState
        /// </summary>
        public static readonly JobFlowExecutionState RUNNING = new JobFlowExecutionState("RUNNING");
        /// <summary>
        /// Constant SHUTTING_DOWN for JobFlowExecutionState
        /// </summary>
        public static readonly JobFlowExecutionState SHUTTING_DOWN = new JobFlowExecutionState("SHUTTING_DOWN");
        /// <summary>
        /// Constant STARTING for JobFlowExecutionState
        /// </summary>
        public static readonly JobFlowExecutionState STARTING = new JobFlowExecutionState("STARTING");
        /// <summary>
        /// Constant TERMINATED for JobFlowExecutionState
        /// </summary>
        public static readonly JobFlowExecutionState TERMINATED = new JobFlowExecutionState("TERMINATED");
        /// <summary>
        /// Constant WAITING for JobFlowExecutionState
        /// </summary>
        public static readonly JobFlowExecutionState WAITING = new JobFlowExecutionState("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobFlowExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobFlowExecutionState FindValue(string value)
        {
            return FindValue<JobFlowExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobFlowExecutionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketType.
    /// </summary>
    public class MarketType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for MarketType
        /// </summary>
        public static readonly MarketType ON_DEMAND = new MarketType("ON_DEMAND");
        /// <summary>
        /// Constant SPOT for MarketType
        /// </summary>
        public static readonly MarketType SPOT = new MarketType("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketType FindValue(string value)
        {
            return FindValue<MarketType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookExecutionStatus.
    /// </summary>
    public class NotebookExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus FAILED = new NotebookExecutionStatus("FAILED");
        /// <summary>
        /// Constant FAILING for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus FAILING = new NotebookExecutionStatus("FAILING");
        /// <summary>
        /// Constant FINISHED for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus FINISHED = new NotebookExecutionStatus("FINISHED");
        /// <summary>
        /// Constant FINISHING for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus FINISHING = new NotebookExecutionStatus("FINISHING");
        /// <summary>
        /// Constant RUNNING for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus RUNNING = new NotebookExecutionStatus("RUNNING");
        /// <summary>
        /// Constant START_PENDING for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus START_PENDING = new NotebookExecutionStatus("START_PENDING");
        /// <summary>
        /// Constant STARTING for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus STARTING = new NotebookExecutionStatus("STARTING");
        /// <summary>
        /// Constant STOP_PENDING for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus STOP_PENDING = new NotebookExecutionStatus("STOP_PENDING");
        /// <summary>
        /// Constant STOPPED for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus STOPPED = new NotebookExecutionStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for NotebookExecutionStatus
        /// </summary>
        public static readonly NotebookExecutionStatus STOPPING = new NotebookExecutionStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookExecutionStatus FindValue(string value)
        {
            return FindValue<NotebookExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnClusterAppUIType.
    /// </summary>
    public class OnClusterAppUIType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationMaster for OnClusterAppUIType
        /// </summary>
        public static readonly OnClusterAppUIType ApplicationMaster = new OnClusterAppUIType("ApplicationMaster");
        /// <summary>
        /// Constant JobHistoryServer for OnClusterAppUIType
        /// </summary>
        public static readonly OnClusterAppUIType JobHistoryServer = new OnClusterAppUIType("JobHistoryServer");
        /// <summary>
        /// Constant ResourceManager for OnClusterAppUIType
        /// </summary>
        public static readonly OnClusterAppUIType ResourceManager = new OnClusterAppUIType("ResourceManager");
        /// <summary>
        /// Constant SparkHistoryServer for OnClusterAppUIType
        /// </summary>
        public static readonly OnClusterAppUIType SparkHistoryServer = new OnClusterAppUIType("SparkHistoryServer");
        /// <summary>
        /// Constant TezUI for OnClusterAppUIType
        /// </summary>
        public static readonly OnClusterAppUIType TezUI = new OnClusterAppUIType("TezUI");
        /// <summary>
        /// Constant YarnTimelineService for OnClusterAppUIType
        /// </summary>
        public static readonly OnClusterAppUIType YarnTimelineService = new OnClusterAppUIType("YarnTimelineService");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnClusterAppUIType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnClusterAppUIType FindValue(string value)
        {
            return FindValue<OnClusterAppUIType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnClusterAppUIType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnDemandCapacityReservationPreference.
    /// </summary>
    public class OnDemandCapacityReservationPreference : ConstantClass
    {

        /// <summary>
        /// Constant None for OnDemandCapacityReservationPreference
        /// </summary>
        public static readonly OnDemandCapacityReservationPreference None = new OnDemandCapacityReservationPreference("none");
        /// <summary>
        /// Constant Open for OnDemandCapacityReservationPreference
        /// </summary>
        public static readonly OnDemandCapacityReservationPreference Open = new OnDemandCapacityReservationPreference("open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnDemandCapacityReservationPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnDemandCapacityReservationPreference FindValue(string value)
        {
            return FindValue<OnDemandCapacityReservationPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnDemandCapacityReservationPreference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnDemandCapacityReservationUsageStrategy.
    /// </summary>
    public class OnDemandCapacityReservationUsageStrategy : ConstantClass
    {

        /// <summary>
        /// Constant UseCapacityReservationsFirst for OnDemandCapacityReservationUsageStrategy
        /// </summary>
        public static readonly OnDemandCapacityReservationUsageStrategy UseCapacityReservationsFirst = new OnDemandCapacityReservationUsageStrategy("use-capacity-reservations-first");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnDemandCapacityReservationUsageStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnDemandCapacityReservationUsageStrategy FindValue(string value)
        {
            return FindValue<OnDemandCapacityReservationUsageStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnDemandCapacityReservationUsageStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnDemandProvisioningAllocationStrategy.
    /// </summary>
    public class OnDemandProvisioningAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant LowestPrice for OnDemandProvisioningAllocationStrategy
        /// </summary>
        public static readonly OnDemandProvisioningAllocationStrategy LowestPrice = new OnDemandProvisioningAllocationStrategy("lowest-price");
        /// <summary>
        /// Constant Prioritized for OnDemandProvisioningAllocationStrategy
        /// </summary>
        public static readonly OnDemandProvisioningAllocationStrategy Prioritized = new OnDemandProvisioningAllocationStrategy("prioritized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnDemandProvisioningAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnDemandProvisioningAllocationStrategy FindValue(string value)
        {
            return FindValue<OnDemandProvisioningAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnDemandProvisioningAllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputNotebookFormat.
    /// </summary>
    public class OutputNotebookFormat : ConstantClass
    {

        /// <summary>
        /// Constant HTML for OutputNotebookFormat
        /// </summary>
        public static readonly OutputNotebookFormat HTML = new OutputNotebookFormat("HTML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputNotebookFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputNotebookFormat FindValue(string value)
        {
            return FindValue<OutputNotebookFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputNotebookFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PersistentAppUIType.
    /// </summary>
    public class PersistentAppUIType : ConstantClass
    {

        /// <summary>
        /// Constant SHS for PersistentAppUIType
        /// </summary>
        public static readonly PersistentAppUIType SHS = new PersistentAppUIType("SHS");
        /// <summary>
        /// Constant TEZ for PersistentAppUIType
        /// </summary>
        public static readonly PersistentAppUIType TEZ = new PersistentAppUIType("TEZ");
        /// <summary>
        /// Constant YTS for PersistentAppUIType
        /// </summary>
        public static readonly PersistentAppUIType YTS = new PersistentAppUIType("YTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PersistentAppUIType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PersistentAppUIType FindValue(string value)
        {
            return FindValue<PersistentAppUIType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PersistentAppUIType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementGroupStrategy.
    /// </summary>
    public class PlacementGroupStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER for PlacementGroupStrategy
        /// </summary>
        public static readonly PlacementGroupStrategy CLUSTER = new PlacementGroupStrategy("CLUSTER");
        /// <summary>
        /// Constant NONE for PlacementGroupStrategy
        /// </summary>
        public static readonly PlacementGroupStrategy NONE = new PlacementGroupStrategy("NONE");
        /// <summary>
        /// Constant PARTITION for PlacementGroupStrategy
        /// </summary>
        public static readonly PlacementGroupStrategy PARTITION = new PlacementGroupStrategy("PARTITION");
        /// <summary>
        /// Constant SPREAD for PlacementGroupStrategy
        /// </summary>
        public static readonly PlacementGroupStrategy SPREAD = new PlacementGroupStrategy("SPREAD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementGroupStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementGroupStrategy FindValue(string value)
        {
            return FindValue<PlacementGroupStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementGroupStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfilerType.
    /// </summary>
    public class ProfilerType : ConstantClass
    {

        /// <summary>
        /// Constant SHS for ProfilerType
        /// </summary>
        public static readonly ProfilerType SHS = new ProfilerType("SHS");
        /// <summary>
        /// Constant TEZUI for ProfilerType
        /// </summary>
        public static readonly ProfilerType TEZUI = new ProfilerType("TEZUI");
        /// <summary>
        /// Constant YTS for ProfilerType
        /// </summary>
        public static readonly ProfilerType YTS = new ProfilerType("YTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfilerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfilerType FindValue(string value)
        {
            return FindValue<ProfilerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfilerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReconfigurationType.
    /// </summary>
    public class ReconfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant MERGE for ReconfigurationType
        /// </summary>
        public static readonly ReconfigurationType MERGE = new ReconfigurationType("MERGE");
        /// <summary>
        /// Constant OVERWRITE for ReconfigurationType
        /// </summary>
        public static readonly ReconfigurationType OVERWRITE = new ReconfigurationType("OVERWRITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReconfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReconfigurationType FindValue(string value)
        {
            return FindValue<ReconfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReconfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepoUpgradeOnBoot.
    /// </summary>
    public class RepoUpgradeOnBoot : ConstantClass
    {

        /// <summary>
        /// Constant NONE for RepoUpgradeOnBoot
        /// </summary>
        public static readonly RepoUpgradeOnBoot NONE = new RepoUpgradeOnBoot("NONE");
        /// <summary>
        /// Constant SECURITY for RepoUpgradeOnBoot
        /// </summary>
        public static readonly RepoUpgradeOnBoot SECURITY = new RepoUpgradeOnBoot("SECURITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepoUpgradeOnBoot(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepoUpgradeOnBoot FindValue(string value)
        {
            return FindValue<RepoUpgradeOnBoot>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepoUpgradeOnBoot(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScaleDownBehavior.
    /// </summary>
    public class ScaleDownBehavior : ConstantClass
    {

        /// <summary>
        /// Constant TERMINATE_AT_INSTANCE_HOUR for ScaleDownBehavior
        /// </summary>
        public static readonly ScaleDownBehavior TERMINATE_AT_INSTANCE_HOUR = new ScaleDownBehavior("TERMINATE_AT_INSTANCE_HOUR");
        /// <summary>
        /// Constant TERMINATE_AT_TASK_COMPLETION for ScaleDownBehavior
        /// </summary>
        public static readonly ScaleDownBehavior TERMINATE_AT_TASK_COMPLETION = new ScaleDownBehavior("TERMINATE_AT_TASK_COMPLETION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScaleDownBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScaleDownBehavior FindValue(string value)
        {
            return FindValue<ScaleDownBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScaleDownBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingStrategy.
    /// </summary>
    public class ScalingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ADVANCED for ScalingStrategy
        /// </summary>
        public static readonly ScalingStrategy ADVANCED = new ScalingStrategy("ADVANCED");
        /// <summary>
        /// Constant DEFAULT for ScalingStrategy
        /// </summary>
        public static readonly ScalingStrategy DEFAULT = new ScalingStrategy("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingStrategy FindValue(string value)
        {
            return FindValue<ScalingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpotProvisioningAllocationStrategy.
    /// </summary>
    public class SpotProvisioningAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CapacityOptimized for SpotProvisioningAllocationStrategy
        /// </summary>
        public static readonly SpotProvisioningAllocationStrategy CapacityOptimized = new SpotProvisioningAllocationStrategy("capacity-optimized");
        /// <summary>
        /// Constant CapacityOptimizedPrioritized for SpotProvisioningAllocationStrategy
        /// </summary>
        public static readonly SpotProvisioningAllocationStrategy CapacityOptimizedPrioritized = new SpotProvisioningAllocationStrategy("capacity-optimized-prioritized");
        /// <summary>
        /// Constant Diversified for SpotProvisioningAllocationStrategy
        /// </summary>
        public static readonly SpotProvisioningAllocationStrategy Diversified = new SpotProvisioningAllocationStrategy("diversified");
        /// <summary>
        /// Constant LowestPrice for SpotProvisioningAllocationStrategy
        /// </summary>
        public static readonly SpotProvisioningAllocationStrategy LowestPrice = new SpotProvisioningAllocationStrategy("lowest-price");
        /// <summary>
        /// Constant PriceCapacityOptimized for SpotProvisioningAllocationStrategy
        /// </summary>
        public static readonly SpotProvisioningAllocationStrategy PriceCapacityOptimized = new SpotProvisioningAllocationStrategy("price-capacity-optimized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpotProvisioningAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotProvisioningAllocationStrategy FindValue(string value)
        {
            return FindValue<SpotProvisioningAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpotProvisioningAllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpotProvisioningTimeoutAction.
    /// </summary>
    public class SpotProvisioningTimeoutAction : ConstantClass
    {

        /// <summary>
        /// Constant SWITCH_TO_ON_DEMAND for SpotProvisioningTimeoutAction
        /// </summary>
        public static readonly SpotProvisioningTimeoutAction SWITCH_TO_ON_DEMAND = new SpotProvisioningTimeoutAction("SWITCH_TO_ON_DEMAND");
        /// <summary>
        /// Constant TERMINATE_CLUSTER for SpotProvisioningTimeoutAction
        /// </summary>
        public static readonly SpotProvisioningTimeoutAction TERMINATE_CLUSTER = new SpotProvisioningTimeoutAction("TERMINATE_CLUSTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpotProvisioningTimeoutAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotProvisioningTimeoutAction FindValue(string value)
        {
            return FindValue<SpotProvisioningTimeoutAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpotProvisioningTimeoutAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Statistic.
    /// </summary>
    public class Statistic : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for Statistic
        /// </summary>
        public static readonly Statistic AVERAGE = new Statistic("AVERAGE");
        /// <summary>
        /// Constant MAXIMUM for Statistic
        /// </summary>
        public static readonly Statistic MAXIMUM = new Statistic("MAXIMUM");
        /// <summary>
        /// Constant MINIMUM for Statistic
        /// </summary>
        public static readonly Statistic MINIMUM = new Statistic("MINIMUM");
        /// <summary>
        /// Constant SAMPLE_COUNT for Statistic
        /// </summary>
        public static readonly Statistic SAMPLE_COUNT = new Statistic("SAMPLE_COUNT");
        /// <summary>
        /// Constant SUM for Statistic
        /// </summary>
        public static readonly Statistic SUM = new Statistic("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Statistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Statistic FindValue(string value)
        {
            return FindValue<Statistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Statistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepCancellationOption.
    /// </summary>
    public class StepCancellationOption : ConstantClass
    {

        /// <summary>
        /// Constant SEND_INTERRUPT for StepCancellationOption
        /// </summary>
        public static readonly StepCancellationOption SEND_INTERRUPT = new StepCancellationOption("SEND_INTERRUPT");
        /// <summary>
        /// Constant TERMINATE_PROCESS for StepCancellationOption
        /// </summary>
        public static readonly StepCancellationOption TERMINATE_PROCESS = new StepCancellationOption("TERMINATE_PROCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepCancellationOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepCancellationOption FindValue(string value)
        {
            return FindValue<StepCancellationOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepCancellationOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepExecutionState.
    /// </summary>
    public class StepExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for StepExecutionState
        /// </summary>
        public static readonly StepExecutionState CANCELLED = new StepExecutionState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for StepExecutionState
        /// </summary>
        public static readonly StepExecutionState COMPLETED = new StepExecutionState("COMPLETED");
        /// <summary>
        /// Constant CONTINUE for StepExecutionState
        /// </summary>
        public static readonly StepExecutionState CONTINUE = new StepExecutionState("CONTINUE");
        /// <summary>
        /// Constant FAILED for StepExecutionState
        /// </summary>
        public static readonly StepExecutionState FAILED = new StepExecutionState("FAILED");
        /// <summary>
        /// Constant INTERRUPTED for StepExecutionState
        /// </summary>
        public static readonly StepExecutionState INTERRUPTED = new StepExecutionState("INTERRUPTED");
        /// <summary>
        /// Constant PENDING for StepExecutionState
        /// </summary>
        public static readonly StepExecutionState PENDING = new StepExecutionState("PENDING");
        /// <summary>
        /// Constant RUNNING for StepExecutionState
        /// </summary>
        public static readonly StepExecutionState RUNNING = new StepExecutionState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepExecutionState FindValue(string value)
        {
            return FindValue<StepExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepExecutionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepState.
    /// </summary>
    public class StepState : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL_PENDING for StepState
        /// </summary>
        public static readonly StepState CANCEL_PENDING = new StepState("CANCEL_PENDING");
        /// <summary>
        /// Constant CANCELLED for StepState
        /// </summary>
        public static readonly StepState CANCELLED = new StepState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for StepState
        /// </summary>
        public static readonly StepState COMPLETED = new StepState("COMPLETED");
        /// <summary>
        /// Constant FAILED for StepState
        /// </summary>
        public static readonly StepState FAILED = new StepState("FAILED");
        /// <summary>
        /// Constant INTERRUPTED for StepState
        /// </summary>
        public static readonly StepState INTERRUPTED = new StepState("INTERRUPTED");
        /// <summary>
        /// Constant PENDING for StepState
        /// </summary>
        public static readonly StepState PENDING = new StepState("PENDING");
        /// <summary>
        /// Constant RUNNING for StepState
        /// </summary>
        public static readonly StepState RUNNING = new StepState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepState FindValue(string value)
        {
            return FindValue<StepState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepStateChangeReasonCode.
    /// </summary>
    public class StepStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant NONE for StepStateChangeReasonCode
        /// </summary>
        public static readonly StepStateChangeReasonCode NONE = new StepStateChangeReasonCode("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepStateChangeReasonCode FindValue(string value)
        {
            return FindValue<StepStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {

        /// <summary>
        /// Constant BITS for Unit
        /// </summary>
        public static readonly Unit BITS = new Unit("BITS");
        /// <summary>
        /// Constant BITS_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit BITS_PER_SECOND = new Unit("BITS_PER_SECOND");
        /// <summary>
        /// Constant BYTES for Unit
        /// </summary>
        public static readonly Unit BYTES = new Unit("BYTES");
        /// <summary>
        /// Constant BYTES_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit BYTES_PER_SECOND = new Unit("BYTES_PER_SECOND");
        /// <summary>
        /// Constant COUNT for Unit
        /// </summary>
        public static readonly Unit COUNT = new Unit("COUNT");
        /// <summary>
        /// Constant COUNT_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit COUNT_PER_SECOND = new Unit("COUNT_PER_SECOND");
        /// <summary>
        /// Constant GIGA_BITS for Unit
        /// </summary>
        public static readonly Unit GIGA_BITS = new Unit("GIGA_BITS");
        /// <summary>
        /// Constant GIGA_BITS_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit GIGA_BITS_PER_SECOND = new Unit("GIGA_BITS_PER_SECOND");
        /// <summary>
        /// Constant GIGA_BYTES for Unit
        /// </summary>
        public static readonly Unit GIGA_BYTES = new Unit("GIGA_BYTES");
        /// <summary>
        /// Constant GIGA_BYTES_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit GIGA_BYTES_PER_SECOND = new Unit("GIGA_BYTES_PER_SECOND");
        /// <summary>
        /// Constant KILO_BITS for Unit
        /// </summary>
        public static readonly Unit KILO_BITS = new Unit("KILO_BITS");
        /// <summary>
        /// Constant KILO_BITS_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit KILO_BITS_PER_SECOND = new Unit("KILO_BITS_PER_SECOND");
        /// <summary>
        /// Constant KILO_BYTES for Unit
        /// </summary>
        public static readonly Unit KILO_BYTES = new Unit("KILO_BYTES");
        /// <summary>
        /// Constant KILO_BYTES_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit KILO_BYTES_PER_SECOND = new Unit("KILO_BYTES_PER_SECOND");
        /// <summary>
        /// Constant MEGA_BITS for Unit
        /// </summary>
        public static readonly Unit MEGA_BITS = new Unit("MEGA_BITS");
        /// <summary>
        /// Constant MEGA_BITS_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit MEGA_BITS_PER_SECOND = new Unit("MEGA_BITS_PER_SECOND");
        /// <summary>
        /// Constant MEGA_BYTES for Unit
        /// </summary>
        public static readonly Unit MEGA_BYTES = new Unit("MEGA_BYTES");
        /// <summary>
        /// Constant MEGA_BYTES_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit MEGA_BYTES_PER_SECOND = new Unit("MEGA_BYTES_PER_SECOND");
        /// <summary>
        /// Constant MICRO_SECONDS for Unit
        /// </summary>
        public static readonly Unit MICRO_SECONDS = new Unit("MICRO_SECONDS");
        /// <summary>
        /// Constant MILLI_SECONDS for Unit
        /// </summary>
        public static readonly Unit MILLI_SECONDS = new Unit("MILLI_SECONDS");
        /// <summary>
        /// Constant NONE for Unit
        /// </summary>
        public static readonly Unit NONE = new Unit("NONE");
        /// <summary>
        /// Constant PERCENT for Unit
        /// </summary>
        public static readonly Unit PERCENT = new Unit("PERCENT");
        /// <summary>
        /// Constant SECONDS for Unit
        /// </summary>
        public static readonly Unit SECONDS = new Unit("SECONDS");
        /// <summary>
        /// Constant TERA_BITS for Unit
        /// </summary>
        public static readonly Unit TERA_BITS = new Unit("TERA_BITS");
        /// <summary>
        /// Constant TERA_BITS_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit TERA_BITS_PER_SECOND = new Unit("TERA_BITS_PER_SECOND");
        /// <summary>
        /// Constant TERA_BYTES for Unit
        /// </summary>
        public static readonly Unit TERA_BYTES = new Unit("TERA_BYTES");
        /// <summary>
        /// Constant TERA_BYTES_PER_SECOND for Unit
        /// </summary>
        public static readonly Unit TERA_BYTES_PER_SECOND = new Unit("TERA_BYTES_PER_SECOND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Unit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
        {
            return FindValue(value);
        }
    }

}