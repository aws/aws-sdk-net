/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AutoScaling
{

    /// <summary>
    /// Constants used for properties of type LifecycleState.
    /// </summary>
    public class LifecycleState : ConstantClass
    {

        /// <summary>
        /// Constant Detached for LifecycleState
        /// </summary>
        public static readonly LifecycleState Detached = new LifecycleState("Detached");
        /// <summary>
        /// Constant Detaching for LifecycleState
        /// </summary>
        public static readonly LifecycleState Detaching = new LifecycleState("Detaching");
        /// <summary>
        /// Constant EnteringStandby for LifecycleState
        /// </summary>
        public static readonly LifecycleState EnteringStandby = new LifecycleState("EnteringStandby");
        /// <summary>
        /// Constant InService for LifecycleState
        /// </summary>
        public static readonly LifecycleState InService = new LifecycleState("InService");
        /// <summary>
        /// Constant Pending for LifecycleState
        /// </summary>
        public static readonly LifecycleState Pending = new LifecycleState("Pending");
        /// <summary>
        /// Constant PendingProceed for LifecycleState
        /// </summary>
        public static readonly LifecycleState PendingProceed = new LifecycleState("Pending:Proceed");
        /// <summary>
        /// Constant PendingWait for LifecycleState
        /// </summary>
        public static readonly LifecycleState PendingWait = new LifecycleState("Pending:Wait");
        /// <summary>
        /// Constant Quarantined for LifecycleState
        /// </summary>
        public static readonly LifecycleState Quarantined = new LifecycleState("Quarantined");
        /// <summary>
        /// Constant Standby for LifecycleState
        /// </summary>
        public static readonly LifecycleState Standby = new LifecycleState("Standby");
        /// <summary>
        /// Constant Terminated for LifecycleState
        /// </summary>
        public static readonly LifecycleState Terminated = new LifecycleState("Terminated");
        /// <summary>
        /// Constant Terminating for LifecycleState
        /// </summary>
        public static readonly LifecycleState Terminating = new LifecycleState("Terminating");
        /// <summary>
        /// Constant TerminatingProceed for LifecycleState
        /// </summary>
        public static readonly LifecycleState TerminatingProceed = new LifecycleState("Terminating:Proceed");
        /// <summary>
        /// Constant TerminatingWait for LifecycleState
        /// </summary>
        public static readonly LifecycleState TerminatingWait = new LifecycleState("Terminating:Wait");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LifecycleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleState FindValue(string value)
        {
            return FindValue<LifecycleState>(value);
        }

        public static implicit operator LifecycleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingActivityStatusCode.
    /// </summary>
    public class ScalingActivityStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Cancelled = new ScalingActivityStatusCode("Cancelled");
        /// <summary>
        /// Constant Failed for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Failed = new ScalingActivityStatusCode("Failed");
        /// <summary>
        /// Constant InProgress for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode InProgress = new ScalingActivityStatusCode("InProgress");
        /// <summary>
        /// Constant MidLifecycleAction for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode MidLifecycleAction = new ScalingActivityStatusCode("MidLifecycleAction");
        /// <summary>
        /// Constant PreInService for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode PreInService = new ScalingActivityStatusCode("PreInService");
        /// <summary>
        /// Constant Successful for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Successful = new ScalingActivityStatusCode("Successful");
        /// <summary>
        /// Constant WaitingForELBConnectionDraining for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode WaitingForELBConnectionDraining = new ScalingActivityStatusCode("WaitingForELBConnectionDraining");
        /// <summary>
        /// Constant WaitingForInstanceId for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode WaitingForInstanceId = new ScalingActivityStatusCode("WaitingForInstanceId");
        /// <summary>
        /// Constant WaitingForSpotInstanceId for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode WaitingForSpotInstanceId = new ScalingActivityStatusCode("WaitingForSpotInstanceId");
        /// <summary>
        /// Constant WaitingForSpotInstanceRequestId for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode WaitingForSpotInstanceRequestId = new ScalingActivityStatusCode("WaitingForSpotInstanceRequestId");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ScalingActivityStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingActivityStatusCode FindValue(string value)
        {
            return FindValue<ScalingActivityStatusCode>(value);
        }

        public static implicit operator ScalingActivityStatusCode(string value)
        {
            return FindValue(value);
        }
    }

}