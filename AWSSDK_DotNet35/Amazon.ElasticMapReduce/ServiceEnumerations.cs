/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.ElasticMapReduce
{


    /// <summary>Action On Failure
    /// </summary>
    public class ActionOnFailure : ConstantClass
    {


       /// <summary>Constant CANCEL_AND_WAIT for ActionOnFailure
       /// </summary>
        public static readonly ActionOnFailure CANCEL_AND_WAIT = new ActionOnFailure("CANCEL_AND_WAIT");
    

       /// <summary>Constant CONTINUE for ActionOnFailure
       /// </summary>
        public static readonly ActionOnFailure CONTINUE = new ActionOnFailure("CONTINUE");
    

       /// <summary>Constant TERMINATE_CLUSTER for ActionOnFailure
       /// </summary>
        public static readonly ActionOnFailure TERMINATE_CLUSTER = new ActionOnFailure("TERMINATE_CLUSTER");
    

       /// <summary>Constant TERMINATE_JOB_FLOW for ActionOnFailure
       /// </summary>
        public static readonly ActionOnFailure TERMINATE_JOB_FLOW = new ActionOnFailure("TERMINATE_JOB_FLOW");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator ActionOnFailure(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Cluster State
    /// </summary>
    public class ClusterState : ConstantClass
    {


       /// <summary>Constant BOOTSTRAPPING for ClusterState
       /// </summary>
        public static readonly ClusterState BOOTSTRAPPING = new ClusterState("BOOTSTRAPPING");
    

       /// <summary>Constant RUNNING for ClusterState
       /// </summary>
        public static readonly ClusterState RUNNING = new ClusterState("RUNNING");
    

       /// <summary>Constant STARTING for ClusterState
       /// </summary>
        public static readonly ClusterState STARTING = new ClusterState("STARTING");
    

       /// <summary>Constant TERMINATED for ClusterState
       /// </summary>
        public static readonly ClusterState TERMINATED = new ClusterState("TERMINATED");
    

       /// <summary>Constant TERMINATED_WITH_ERRORS for ClusterState
       /// </summary>
        public static readonly ClusterState TERMINATED_WITH_ERRORS = new ClusterState("TERMINATED_WITH_ERRORS");
    

       /// <summary>Constant TERMINATING for ClusterState
       /// </summary>
        public static readonly ClusterState TERMINATING = new ClusterState("TERMINATING");
    

       /// <summary>Constant WAITING for ClusterState
       /// </summary>
        public static readonly ClusterState WAITING = new ClusterState("WAITING");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator ClusterState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Cluster State Change Reason Code
    /// </summary>
    public class ClusterStateChangeReasonCode : ConstantClass
    {


       /// <summary>Constant ALL_STEPS_COMPLETED for ClusterStateChangeReasonCode
       /// </summary>
        public static readonly ClusterStateChangeReasonCode ALL_STEPS_COMPLETED = new ClusterStateChangeReasonCode("ALL_STEPS_COMPLETED");
    

       /// <summary>Constant BOOTSTRAP_FAILURE for ClusterStateChangeReasonCode
       /// </summary>
        public static readonly ClusterStateChangeReasonCode BOOTSTRAP_FAILURE = new ClusterStateChangeReasonCode("BOOTSTRAP_FAILURE");
    

       /// <summary>Constant INSTANCE_FAILURE for ClusterStateChangeReasonCode
       /// </summary>
        public static readonly ClusterStateChangeReasonCode INSTANCE_FAILURE = new ClusterStateChangeReasonCode("INSTANCE_FAILURE");
    

       /// <summary>Constant INTERNAL_ERROR for ClusterStateChangeReasonCode
       /// </summary>
        public static readonly ClusterStateChangeReasonCode INTERNAL_ERROR = new ClusterStateChangeReasonCode("INTERNAL_ERROR");
    

       /// <summary>Constant STEP_FAILURE for ClusterStateChangeReasonCode
       /// </summary>
        public static readonly ClusterStateChangeReasonCode STEP_FAILURE = new ClusterStateChangeReasonCode("STEP_FAILURE");
    

       /// <summary>Constant USER_REQUEST for ClusterStateChangeReasonCode
       /// </summary>
        public static readonly ClusterStateChangeReasonCode USER_REQUEST = new ClusterStateChangeReasonCode("USER_REQUEST");
    

       /// <summary>Constant VALIDATION_ERROR for ClusterStateChangeReasonCode
       /// </summary>
        public static readonly ClusterStateChangeReasonCode VALIDATION_ERROR = new ClusterStateChangeReasonCode("VALIDATION_ERROR");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator ClusterStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance Group State
    /// </summary>
    public class InstanceGroupState : ConstantClass
    {


       /// <summary>Constant ARRESTED for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState ARRESTED = new InstanceGroupState("ARRESTED");
    

       /// <summary>Constant BOOTSTRAPPING for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState BOOTSTRAPPING = new InstanceGroupState("BOOTSTRAPPING");
    

       /// <summary>Constant ENDED for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState ENDED = new InstanceGroupState("ENDED");
    

       /// <summary>Constant PROVISIONING for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState PROVISIONING = new InstanceGroupState("PROVISIONING");
    

       /// <summary>Constant RESIZING for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState RESIZING = new InstanceGroupState("RESIZING");
    

       /// <summary>Constant RUNNING for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState RUNNING = new InstanceGroupState("RUNNING");
    

       /// <summary>Constant SHUTTING_DOWN for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState SHUTTING_DOWN = new InstanceGroupState("SHUTTING_DOWN");
    

       /// <summary>Constant SUSPENDED for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState SUSPENDED = new InstanceGroupState("SUSPENDED");
    

       /// <summary>Constant TERMINATED for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState TERMINATED = new InstanceGroupState("TERMINATED");
    

       /// <summary>Constant TERMINATING for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState TERMINATING = new InstanceGroupState("TERMINATING");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator InstanceGroupState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance Group State Change Reason Code
    /// </summary>
    public class InstanceGroupStateChangeReasonCode : ConstantClass
    {


       /// <summary>Constant CLUSTER_TERMINATED for InstanceGroupStateChangeReasonCode
       /// </summary>
        public static readonly InstanceGroupStateChangeReasonCode CLUSTER_TERMINATED = new InstanceGroupStateChangeReasonCode("CLUSTER_TERMINATED");
    

       /// <summary>Constant INSTANCE_FAILURE for InstanceGroupStateChangeReasonCode
       /// </summary>
        public static readonly InstanceGroupStateChangeReasonCode INSTANCE_FAILURE = new InstanceGroupStateChangeReasonCode("INSTANCE_FAILURE");
    

       /// <summary>Constant INTERNAL_ERROR for InstanceGroupStateChangeReasonCode
       /// </summary>
        public static readonly InstanceGroupStateChangeReasonCode INTERNAL_ERROR = new InstanceGroupStateChangeReasonCode("INTERNAL_ERROR");
    

       /// <summary>Constant VALIDATION_ERROR for InstanceGroupStateChangeReasonCode
       /// </summary>
        public static readonly InstanceGroupStateChangeReasonCode VALIDATION_ERROR = new InstanceGroupStateChangeReasonCode("VALIDATION_ERROR");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator InstanceGroupStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance Group Type
    /// </summary>
    public class InstanceGroupType : ConstantClass
    {


       /// <summary>Constant CORE for InstanceGroupType
       /// </summary>
        public static readonly InstanceGroupType CORE = new InstanceGroupType("CORE");
    

       /// <summary>Constant MASTER for InstanceGroupType
       /// </summary>
        public static readonly InstanceGroupType MASTER = new InstanceGroupType("MASTER");
    

       /// <summary>Constant TASK for InstanceGroupType
       /// </summary>
        public static readonly InstanceGroupType TASK = new InstanceGroupType("TASK");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator InstanceGroupType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance Role Type
    /// </summary>
    public class InstanceRoleType : ConstantClass
    {


       /// <summary>Constant CORE for InstanceRoleType
       /// </summary>
        public static readonly InstanceRoleType CORE = new InstanceRoleType("CORE");
    

       /// <summary>Constant MASTER for InstanceRoleType
       /// </summary>
        public static readonly InstanceRoleType MASTER = new InstanceRoleType("MASTER");
    

       /// <summary>Constant TASK for InstanceRoleType
       /// </summary>
        public static readonly InstanceRoleType TASK = new InstanceRoleType("TASK");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator InstanceRoleType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance State
    /// </summary>
    public class InstanceState : ConstantClass
    {


       /// <summary>Constant AWAITING_FULFILLMENT for InstanceState
       /// </summary>
        public static readonly InstanceState AWAITING_FULFILLMENT = new InstanceState("AWAITING_FULFILLMENT");
    

       /// <summary>Constant BOOTSTRAPPING for InstanceState
       /// </summary>
        public static readonly InstanceState BOOTSTRAPPING = new InstanceState("BOOTSTRAPPING");
    

       /// <summary>Constant PROVISIONING for InstanceState
       /// </summary>
        public static readonly InstanceState PROVISIONING = new InstanceState("PROVISIONING");
    

       /// <summary>Constant RUNNING for InstanceState
       /// </summary>
        public static readonly InstanceState RUNNING = new InstanceState("RUNNING");
    

       /// <summary>Constant TERMINATED for InstanceState
       /// </summary>
        public static readonly InstanceState TERMINATED = new InstanceState("TERMINATED");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator InstanceState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance State Change Reason Code
    /// </summary>
    public class InstanceStateChangeReasonCode : ConstantClass
    {


       /// <summary>Constant BOOTSTRAP_FAILURE for InstanceStateChangeReasonCode
       /// </summary>
        public static readonly InstanceStateChangeReasonCode BOOTSTRAP_FAILURE = new InstanceStateChangeReasonCode("BOOTSTRAP_FAILURE");
    

       /// <summary>Constant CLUSTER_TERMINATED for InstanceStateChangeReasonCode
       /// </summary>
        public static readonly InstanceStateChangeReasonCode CLUSTER_TERMINATED = new InstanceStateChangeReasonCode("CLUSTER_TERMINATED");
    

       /// <summary>Constant INSTANCE_FAILURE for InstanceStateChangeReasonCode
       /// </summary>
        public static readonly InstanceStateChangeReasonCode INSTANCE_FAILURE = new InstanceStateChangeReasonCode("INSTANCE_FAILURE");
    

       /// <summary>Constant INTERNAL_ERROR for InstanceStateChangeReasonCode
       /// </summary>
        public static readonly InstanceStateChangeReasonCode INTERNAL_ERROR = new InstanceStateChangeReasonCode("INTERNAL_ERROR");
    

       /// <summary>Constant VALIDATION_ERROR for InstanceStateChangeReasonCode
       /// </summary>
        public static readonly InstanceStateChangeReasonCode VALIDATION_ERROR = new InstanceStateChangeReasonCode("VALIDATION_ERROR");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator InstanceStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Job Flow Execution State
    /// </summary>
    public class JobFlowExecutionState : ConstantClass
    {


       /// <summary>Constant BOOTSTRAPPING for JobFlowExecutionState
       /// </summary>
        public static readonly JobFlowExecutionState BOOTSTRAPPING = new JobFlowExecutionState("BOOTSTRAPPING");
    

       /// <summary>Constant COMPLETED for JobFlowExecutionState
       /// </summary>
        public static readonly JobFlowExecutionState COMPLETED = new JobFlowExecutionState("COMPLETED");
    

       /// <summary>Constant FAILED for JobFlowExecutionState
       /// </summary>
        public static readonly JobFlowExecutionState FAILED = new JobFlowExecutionState("FAILED");
    

       /// <summary>Constant RUNNING for JobFlowExecutionState
       /// </summary>
        public static readonly JobFlowExecutionState RUNNING = new JobFlowExecutionState("RUNNING");
    

       /// <summary>Constant SHUTTING_DOWN for JobFlowExecutionState
       /// </summary>
        public static readonly JobFlowExecutionState SHUTTING_DOWN = new JobFlowExecutionState("SHUTTING_DOWN");
    

       /// <summary>Constant STARTING for JobFlowExecutionState
       /// </summary>
        public static readonly JobFlowExecutionState STARTING = new JobFlowExecutionState("STARTING");
    

       /// <summary>Constant TERMINATED for JobFlowExecutionState
       /// </summary>
        public static readonly JobFlowExecutionState TERMINATED = new JobFlowExecutionState("TERMINATED");
    

       /// <summary>Constant WAITING for JobFlowExecutionState
       /// </summary>
        public static readonly JobFlowExecutionState WAITING = new JobFlowExecutionState("WAITING");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator JobFlowExecutionState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Market Type
    /// </summary>
    public class MarketType : ConstantClass
    {


       /// <summary>Constant ON_DEMAND for MarketType
       /// </summary>
        public static readonly MarketType ON_DEMAND = new MarketType("ON_DEMAND");
    

       /// <summary>Constant SPOT for MarketType
       /// </summary>
        public static readonly MarketType SPOT = new MarketType("SPOT");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator MarketType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Step Execution State
    /// </summary>
    public class StepExecutionState : ConstantClass
    {


       /// <summary>Constant CANCELLED for StepExecutionState
       /// </summary>
        public static readonly StepExecutionState CANCELLED = new StepExecutionState("CANCELLED");
    

       /// <summary>Constant COMPLETED for StepExecutionState
       /// </summary>
        public static readonly StepExecutionState COMPLETED = new StepExecutionState("COMPLETED");
    

       /// <summary>Constant CONTINUE for StepExecutionState
       /// </summary>
        public static readonly StepExecutionState CONTINUE = new StepExecutionState("CONTINUE");
    

       /// <summary>Constant FAILED for StepExecutionState
       /// </summary>
        public static readonly StepExecutionState FAILED = new StepExecutionState("FAILED");
    

       /// <summary>Constant INTERRUPTED for StepExecutionState
       /// </summary>
        public static readonly StepExecutionState INTERRUPTED = new StepExecutionState("INTERRUPTED");
    

       /// <summary>Constant PENDING for StepExecutionState
       /// </summary>
        public static readonly StepExecutionState PENDING = new StepExecutionState("PENDING");
    

       /// <summary>Constant RUNNING for StepExecutionState
       /// </summary>
        public static readonly StepExecutionState RUNNING = new StepExecutionState("RUNNING");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator StepExecutionState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Step State
    /// </summary>
    public class StepState : ConstantClass
    {


       /// <summary>Constant CANCELLED for StepState
       /// </summary>
        public static readonly StepState CANCELLED = new StepState("CANCELLED");
    

       /// <summary>Constant COMPLETED for StepState
       /// </summary>
        public static readonly StepState COMPLETED = new StepState("COMPLETED");
    

       /// <summary>Constant FAILED for StepState
       /// </summary>
        public static readonly StepState FAILED = new StepState("FAILED");
    

       /// <summary>Constant INTERRUPTED for StepState
       /// </summary>
        public static readonly StepState INTERRUPTED = new StepState("INTERRUPTED");
    

       /// <summary>Constant PENDING for StepState
       /// </summary>
        public static readonly StepState PENDING = new StepState("PENDING");
    

       /// <summary>Constant RUNNING for StepState
       /// </summary>
        public static readonly StepState RUNNING = new StepState("RUNNING");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator StepState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Step State Change Reason Code
    /// </summary>
    public class StepStateChangeReasonCode : ConstantClass
    {


       /// <summary>Constant NONE for StepStateChangeReasonCode
       /// </summary>
        public static readonly StepStateChangeReasonCode NONE = new StepStateChangeReasonCode("NONE");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator StepStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
