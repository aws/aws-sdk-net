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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AutoScaling
{

    /// <summary>
    /// Constants used for properties of type InstanceMetadataEndpointState.
    /// </summary>
    public class InstanceMetadataEndpointState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for InstanceMetadataEndpointState
        /// </summary>
        public static readonly InstanceMetadataEndpointState Disabled = new InstanceMetadataEndpointState("disabled");
        /// <summary>
        /// Constant Enabled for InstanceMetadataEndpointState
        /// </summary>
        public static readonly InstanceMetadataEndpointState Enabled = new InstanceMetadataEndpointState("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceMetadataEndpointState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMetadataEndpointState FindValue(string value)
        {
            return FindValue<InstanceMetadataEndpointState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMetadataEndpointState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceMetadataHttpTokensState.
    /// </summary>
    public class InstanceMetadataHttpTokensState : ConstantClass
    {

        /// <summary>
        /// Constant Optional for InstanceMetadataHttpTokensState
        /// </summary>
        public static readonly InstanceMetadataHttpTokensState Optional = new InstanceMetadataHttpTokensState("optional");
        /// <summary>
        /// Constant Required for InstanceMetadataHttpTokensState
        /// </summary>
        public static readonly InstanceMetadataHttpTokensState Required = new InstanceMetadataHttpTokensState("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceMetadataHttpTokensState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMetadataHttpTokensState FindValue(string value)
        {
            return FindValue<InstanceMetadataHttpTokensState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMetadataHttpTokensState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceRefreshStatus.
    /// </summary>
    public class InstanceRefreshStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for InstanceRefreshStatus
        /// </summary>
        public static readonly InstanceRefreshStatus Cancelled = new InstanceRefreshStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for InstanceRefreshStatus
        /// </summary>
        public static readonly InstanceRefreshStatus Cancelling = new InstanceRefreshStatus("Cancelling");
        /// <summary>
        /// Constant Failed for InstanceRefreshStatus
        /// </summary>
        public static readonly InstanceRefreshStatus Failed = new InstanceRefreshStatus("Failed");
        /// <summary>
        /// Constant InProgress for InstanceRefreshStatus
        /// </summary>
        public static readonly InstanceRefreshStatus InProgress = new InstanceRefreshStatus("InProgress");
        /// <summary>
        /// Constant Pending for InstanceRefreshStatus
        /// </summary>
        public static readonly InstanceRefreshStatus Pending = new InstanceRefreshStatus("Pending");
        /// <summary>
        /// Constant Successful for InstanceRefreshStatus
        /// </summary>
        public static readonly InstanceRefreshStatus Successful = new InstanceRefreshStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceRefreshStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceRefreshStatus FindValue(string value)
        {
            return FindValue<InstanceRefreshStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceRefreshStatus(string value)
        {
            return FindValue(value);
        }
    }


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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricStatistic.
    /// </summary>
    public class MetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Average = new MetricStatistic("Average");
        /// <summary>
        /// Constant Maximum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Maximum = new MetricStatistic("Maximum");
        /// <summary>
        /// Constant Minimum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Minimum = new MetricStatistic("Minimum");
        /// <summary>
        /// Constant SampleCount for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic SampleCount = new MetricStatistic("SampleCount");
        /// <summary>
        /// Constant Sum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Sum = new MetricStatistic("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricStatistic FindValue(string value)
        {
            return FindValue<MetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricType.
    /// </summary>
    public class MetricType : ConstantClass
    {

        /// <summary>
        /// Constant ALBRequestCountPerTarget for MetricType
        /// </summary>
        public static readonly MetricType ALBRequestCountPerTarget = new MetricType("ALBRequestCountPerTarget");
        /// <summary>
        /// Constant ASGAverageCPUUtilization for MetricType
        /// </summary>
        public static readonly MetricType ASGAverageCPUUtilization = new MetricType("ASGAverageCPUUtilization");
        /// <summary>
        /// Constant ASGAverageNetworkIn for MetricType
        /// </summary>
        public static readonly MetricType ASGAverageNetworkIn = new MetricType("ASGAverageNetworkIn");
        /// <summary>
        /// Constant ASGAverageNetworkOut for MetricType
        /// </summary>
        public static readonly MetricType ASGAverageNetworkOut = new MetricType("ASGAverageNetworkOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricType FindValue(string value)
        {
            return FindValue<MetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RefreshStrategy.
    /// </summary>
    public class RefreshStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Rolling for RefreshStrategy
        /// </summary>
        public static readonly RefreshStrategy Rolling = new RefreshStrategy("Rolling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RefreshStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RefreshStrategy FindValue(string value)
        {
            return FindValue<RefreshStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RefreshStrategy(string value)
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
        /// Constant PendingSpotBidPlacement for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode PendingSpotBidPlacement = new ScalingActivityStatusCode("PendingSpotBidPlacement");
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
        /// Constant WaitingForInstanceWarmup for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode WaitingForInstanceWarmup = new ScalingActivityStatusCode("WaitingForInstanceWarmup");
        /// <summary>
        /// Constant WaitingForSpotInstanceId for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode WaitingForSpotInstanceId = new ScalingActivityStatusCode("WaitingForSpotInstanceId");
        /// <summary>
        /// Constant WaitingForSpotInstanceRequestId for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode WaitingForSpotInstanceRequestId = new ScalingActivityStatusCode("WaitingForSpotInstanceRequestId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingActivityStatusCode(string value)
        {
            return FindValue(value);
        }
    }

}