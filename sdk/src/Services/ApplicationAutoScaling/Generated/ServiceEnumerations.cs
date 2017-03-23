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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApplicationAutoScaling
{

    /// <summary>
    /// Constants used for properties of type AdjustmentType.
    /// </summary>
    public class AdjustmentType : ConstantClass
    {

        /// <summary>
        /// Constant ChangeInCapacity for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType ChangeInCapacity = new AdjustmentType("ChangeInCapacity");
        /// <summary>
        /// Constant ExactCapacity for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType ExactCapacity = new AdjustmentType("ExactCapacity");
        /// <summary>
        /// Constant PercentChangeInCapacity for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType PercentChangeInCapacity = new AdjustmentType("PercentChangeInCapacity");

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
    /// Constants used for properties of type MetricAggregationType.
    /// </summary>
    public class MetricAggregationType : ConstantClass
    {

        /// <summary>
        /// Constant Average for MetricAggregationType
        /// </summary>
        public static readonly MetricAggregationType Average = new MetricAggregationType("Average");
        /// <summary>
        /// Constant Maximum for MetricAggregationType
        /// </summary>
        public static readonly MetricAggregationType Maximum = new MetricAggregationType("Maximum");
        /// <summary>
        /// Constant Minimum for MetricAggregationType
        /// </summary>
        public static readonly MetricAggregationType Minimum = new MetricAggregationType("Minimum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricAggregationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricAggregationType FindValue(string value)
        {
            return FindValue<MetricAggregationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricAggregationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant StepScaling for PolicyType
        /// </summary>
        public static readonly PolicyType StepScaling = new PolicyType("StepScaling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalableDimension.
    /// </summary>
    public class ScalableDimension : ConstantClass
    {

        /// <summary>
        /// Constant AppstreamFleetDesiredCapacity for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension AppstreamFleetDesiredCapacity = new ScalableDimension("appstream:fleet:DesiredCapacity");
        /// <summary>
        /// Constant Ec2SpotFleetRequestTargetCapacity for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension Ec2SpotFleetRequestTargetCapacity = new ScalableDimension("ec2:spot-fleet-request:TargetCapacity");
        /// <summary>
        /// Constant EcsServiceDesiredCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension EcsServiceDesiredCount = new ScalableDimension("ecs:service:DesiredCount");
        /// <summary>
        /// Constant ElasticmapreduceInstancegroupInstanceCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension ElasticmapreduceInstancegroupInstanceCount = new ScalableDimension("elasticmapreduce:instancegroup:InstanceCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalableDimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalableDimension FindValue(string value)
        {
            return FindValue<ScalableDimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalableDimension(string value)
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
        /// Constant Failed for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Failed = new ScalingActivityStatusCode("Failed");
        /// <summary>
        /// Constant InProgress for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode InProgress = new ScalingActivityStatusCode("InProgress");
        /// <summary>
        /// Constant Overridden for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Overridden = new ScalingActivityStatusCode("Overridden");
        /// <summary>
        /// Constant Pending for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Pending = new ScalingActivityStatusCode("Pending");
        /// <summary>
        /// Constant Successful for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Successful = new ScalingActivityStatusCode("Successful");
        /// <summary>
        /// Constant Unfulfilled for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Unfulfilled = new ScalingActivityStatusCode("Unfulfilled");

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


    /// <summary>
    /// Constants used for properties of type ServiceNamespace.
    /// </summary>
    public class ServiceNamespace : ConstantClass
    {

        /// <summary>
        /// Constant Appstream for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Appstream = new ServiceNamespace("appstream");
        /// <summary>
        /// Constant Ec2 for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Ec2 = new ServiceNamespace("ec2");
        /// <summary>
        /// Constant Ecs for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Ecs = new ServiceNamespace("ecs");
        /// <summary>
        /// Constant Elasticmapreduce for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Elasticmapreduce = new ServiceNamespace("elasticmapreduce");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNamespace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNamespace FindValue(string value)
        {
            return FindValue<ServiceNamespace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNamespace(string value)
        {
            return FindValue(value);
        }
    }

}