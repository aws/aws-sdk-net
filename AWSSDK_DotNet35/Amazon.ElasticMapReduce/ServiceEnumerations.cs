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
    

       /// <summary>Constant FAILED for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState FAILED = new InstanceGroupState("FAILED");
    

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
    

       /// <summary>Constant STARTING for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState STARTING = new InstanceGroupState("STARTING");
    

       /// <summary>Constant TERMINATED for InstanceGroupState
       /// </summary>
        public static readonly InstanceGroupState TERMINATED = new InstanceGroupState("TERMINATED");
    

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
    

}
        
