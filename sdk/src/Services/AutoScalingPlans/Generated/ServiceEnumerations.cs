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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AutoScalingPlans
{

    /// <summary>
    /// Constants used for properties of type ForecastDataType.
    /// </summary>
    public class ForecastDataType : ConstantClass
    {

        /// <summary>
        /// Constant CapacityForecast for ForecastDataType
        /// </summary>
        public static readonly ForecastDataType CapacityForecast = new ForecastDataType("CapacityForecast");
        /// <summary>
        /// Constant LoadForecast for ForecastDataType
        /// </summary>
        public static readonly ForecastDataType LoadForecast = new ForecastDataType("LoadForecast");
        /// <summary>
        /// Constant ScheduledActionMaxCapacity for ForecastDataType
        /// </summary>
        public static readonly ForecastDataType ScheduledActionMaxCapacity = new ForecastDataType("ScheduledActionMaxCapacity");
        /// <summary>
        /// Constant ScheduledActionMinCapacity for ForecastDataType
        /// </summary>
        public static readonly ForecastDataType ScheduledActionMinCapacity = new ForecastDataType("ScheduledActionMinCapacity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ForecastDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ForecastDataType FindValue(string value)
        {
            return FindValue<ForecastDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ForecastDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadMetricType.
    /// </summary>
    public class LoadMetricType : ConstantClass
    {

        /// <summary>
        /// Constant ALBTargetGroupRequestCount for LoadMetricType
        /// </summary>
        public static readonly LoadMetricType ALBTargetGroupRequestCount = new LoadMetricType("ALBTargetGroupRequestCount");
        /// <summary>
        /// Constant ASGTotalCPUUtilization for LoadMetricType
        /// </summary>
        public static readonly LoadMetricType ASGTotalCPUUtilization = new LoadMetricType("ASGTotalCPUUtilization");
        /// <summary>
        /// Constant ASGTotalNetworkIn for LoadMetricType
        /// </summary>
        public static readonly LoadMetricType ASGTotalNetworkIn = new LoadMetricType("ASGTotalNetworkIn");
        /// <summary>
        /// Constant ASGTotalNetworkOut for LoadMetricType
        /// </summary>
        public static readonly LoadMetricType ASGTotalNetworkOut = new LoadMetricType("ASGTotalNetworkOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadMetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadMetricType FindValue(string value)
        {
            return FindValue<LoadMetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadMetricType(string value)
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
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant TargetTrackingScaling for PolicyType
        /// </summary>
        public static readonly PolicyType TargetTrackingScaling = new PolicyType("TargetTrackingScaling");

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
    /// Constants used for properties of type PredictiveScalingMaxCapacityBehavior.
    /// </summary>
    public class PredictiveScalingMaxCapacityBehavior : ConstantClass
    {

        /// <summary>
        /// Constant SetForecastCapacityToMaxCapacity for PredictiveScalingMaxCapacityBehavior
        /// </summary>
        public static readonly PredictiveScalingMaxCapacityBehavior SetForecastCapacityToMaxCapacity = new PredictiveScalingMaxCapacityBehavior("SetForecastCapacityToMaxCapacity");
        /// <summary>
        /// Constant SetMaxCapacityAboveForecastCapacity for PredictiveScalingMaxCapacityBehavior
        /// </summary>
        public static readonly PredictiveScalingMaxCapacityBehavior SetMaxCapacityAboveForecastCapacity = new PredictiveScalingMaxCapacityBehavior("SetMaxCapacityAboveForecastCapacity");
        /// <summary>
        /// Constant SetMaxCapacityToForecastCapacity for PredictiveScalingMaxCapacityBehavior
        /// </summary>
        public static readonly PredictiveScalingMaxCapacityBehavior SetMaxCapacityToForecastCapacity = new PredictiveScalingMaxCapacityBehavior("SetMaxCapacityToForecastCapacity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PredictiveScalingMaxCapacityBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PredictiveScalingMaxCapacityBehavior FindValue(string value)
        {
            return FindValue<PredictiveScalingMaxCapacityBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PredictiveScalingMaxCapacityBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PredictiveScalingMode.
    /// </summary>
    public class PredictiveScalingMode : ConstantClass
    {

        /// <summary>
        /// Constant ForecastAndScale for PredictiveScalingMode
        /// </summary>
        public static readonly PredictiveScalingMode ForecastAndScale = new PredictiveScalingMode("ForecastAndScale");
        /// <summary>
        /// Constant ForecastOnly for PredictiveScalingMode
        /// </summary>
        public static readonly PredictiveScalingMode ForecastOnly = new PredictiveScalingMode("ForecastOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PredictiveScalingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PredictiveScalingMode FindValue(string value)
        {
            return FindValue<PredictiveScalingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PredictiveScalingMode(string value)
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
        /// Constant AutoscalingAutoScalingGroupDesiredCapacity for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension AutoscalingAutoScalingGroupDesiredCapacity = new ScalableDimension("autoscaling:autoScalingGroup:DesiredCapacity");
        /// <summary>
        /// Constant DynamodbIndexReadCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension DynamodbIndexReadCapacityUnits = new ScalableDimension("dynamodb:index:ReadCapacityUnits");
        /// <summary>
        /// Constant DynamodbIndexWriteCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension DynamodbIndexWriteCapacityUnits = new ScalableDimension("dynamodb:index:WriteCapacityUnits");
        /// <summary>
        /// Constant DynamodbTableReadCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension DynamodbTableReadCapacityUnits = new ScalableDimension("dynamodb:table:ReadCapacityUnits");
        /// <summary>
        /// Constant DynamodbTableWriteCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension DynamodbTableWriteCapacityUnits = new ScalableDimension("dynamodb:table:WriteCapacityUnits");
        /// <summary>
        /// Constant Ec2SpotFleetRequestTargetCapacity for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension Ec2SpotFleetRequestTargetCapacity = new ScalableDimension("ec2:spot-fleet-request:TargetCapacity");
        /// <summary>
        /// Constant EcsServiceDesiredCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension EcsServiceDesiredCount = new ScalableDimension("ecs:service:DesiredCount");
        /// <summary>
        /// Constant RdsClusterReadReplicaCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension RdsClusterReadReplicaCount = new ScalableDimension("rds:cluster:ReadReplicaCount");

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
    /// Constants used for properties of type ScalingMetricType.
    /// </summary>
    public class ScalingMetricType : ConstantClass
    {

        /// <summary>
        /// Constant ALBRequestCountPerTarget for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType ALBRequestCountPerTarget = new ScalingMetricType("ALBRequestCountPerTarget");
        /// <summary>
        /// Constant ASGAverageCPUUtilization for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType ASGAverageCPUUtilization = new ScalingMetricType("ASGAverageCPUUtilization");
        /// <summary>
        /// Constant ASGAverageNetworkIn for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType ASGAverageNetworkIn = new ScalingMetricType("ASGAverageNetworkIn");
        /// <summary>
        /// Constant ASGAverageNetworkOut for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType ASGAverageNetworkOut = new ScalingMetricType("ASGAverageNetworkOut");
        /// <summary>
        /// Constant DynamoDBReadCapacityUtilization for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType DynamoDBReadCapacityUtilization = new ScalingMetricType("DynamoDBReadCapacityUtilization");
        /// <summary>
        /// Constant DynamoDBWriteCapacityUtilization for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType DynamoDBWriteCapacityUtilization = new ScalingMetricType("DynamoDBWriteCapacityUtilization");
        /// <summary>
        /// Constant EC2SpotFleetRequestAverageCPUUtilization for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType EC2SpotFleetRequestAverageCPUUtilization = new ScalingMetricType("EC2SpotFleetRequestAverageCPUUtilization");
        /// <summary>
        /// Constant EC2SpotFleetRequestAverageNetworkIn for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType EC2SpotFleetRequestAverageNetworkIn = new ScalingMetricType("EC2SpotFleetRequestAverageNetworkIn");
        /// <summary>
        /// Constant EC2SpotFleetRequestAverageNetworkOut for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType EC2SpotFleetRequestAverageNetworkOut = new ScalingMetricType("EC2SpotFleetRequestAverageNetworkOut");
        /// <summary>
        /// Constant ECSServiceAverageCPUUtilization for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType ECSServiceAverageCPUUtilization = new ScalingMetricType("ECSServiceAverageCPUUtilization");
        /// <summary>
        /// Constant ECSServiceAverageMemoryUtilization for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType ECSServiceAverageMemoryUtilization = new ScalingMetricType("ECSServiceAverageMemoryUtilization");
        /// <summary>
        /// Constant RDSReaderAverageCPUUtilization for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType RDSReaderAverageCPUUtilization = new ScalingMetricType("RDSReaderAverageCPUUtilization");
        /// <summary>
        /// Constant RDSReaderAverageDatabaseConnections for ScalingMetricType
        /// </summary>
        public static readonly ScalingMetricType RDSReaderAverageDatabaseConnections = new ScalingMetricType("RDSReaderAverageDatabaseConnections");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingMetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingMetricType FindValue(string value)
        {
            return FindValue<ScalingMetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingMetricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingPlanStatusCode.
    /// </summary>
    public class ScalingPlanStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Active for ScalingPlanStatusCode
        /// </summary>
        public static readonly ScalingPlanStatusCode Active = new ScalingPlanStatusCode("Active");
        /// <summary>
        /// Constant ActiveWithProblems for ScalingPlanStatusCode
        /// </summary>
        public static readonly ScalingPlanStatusCode ActiveWithProblems = new ScalingPlanStatusCode("ActiveWithProblems");
        /// <summary>
        /// Constant CreationFailed for ScalingPlanStatusCode
        /// </summary>
        public static readonly ScalingPlanStatusCode CreationFailed = new ScalingPlanStatusCode("CreationFailed");
        /// <summary>
        /// Constant CreationInProgress for ScalingPlanStatusCode
        /// </summary>
        public static readonly ScalingPlanStatusCode CreationInProgress = new ScalingPlanStatusCode("CreationInProgress");
        /// <summary>
        /// Constant DeletionFailed for ScalingPlanStatusCode
        /// </summary>
        public static readonly ScalingPlanStatusCode DeletionFailed = new ScalingPlanStatusCode("DeletionFailed");
        /// <summary>
        /// Constant DeletionInProgress for ScalingPlanStatusCode
        /// </summary>
        public static readonly ScalingPlanStatusCode DeletionInProgress = new ScalingPlanStatusCode("DeletionInProgress");
        /// <summary>
        /// Constant UpdateFailed for ScalingPlanStatusCode
        /// </summary>
        public static readonly ScalingPlanStatusCode UpdateFailed = new ScalingPlanStatusCode("UpdateFailed");
        /// <summary>
        /// Constant UpdateInProgress for ScalingPlanStatusCode
        /// </summary>
        public static readonly ScalingPlanStatusCode UpdateInProgress = new ScalingPlanStatusCode("UpdateInProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingPlanStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingPlanStatusCode FindValue(string value)
        {
            return FindValue<ScalingPlanStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingPlanStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingPolicyUpdateBehavior.
    /// </summary>
    public class ScalingPolicyUpdateBehavior : ConstantClass
    {

        /// <summary>
        /// Constant KeepExternalPolicies for ScalingPolicyUpdateBehavior
        /// </summary>
        public static readonly ScalingPolicyUpdateBehavior KeepExternalPolicies = new ScalingPolicyUpdateBehavior("KeepExternalPolicies");
        /// <summary>
        /// Constant ReplaceExternalPolicies for ScalingPolicyUpdateBehavior
        /// </summary>
        public static readonly ScalingPolicyUpdateBehavior ReplaceExternalPolicies = new ScalingPolicyUpdateBehavior("ReplaceExternalPolicies");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingPolicyUpdateBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingPolicyUpdateBehavior FindValue(string value)
        {
            return FindValue<ScalingPolicyUpdateBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingPolicyUpdateBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingStatusCode.
    /// </summary>
    public class ScalingStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Active for ScalingStatusCode
        /// </summary>
        public static readonly ScalingStatusCode Active = new ScalingStatusCode("Active");
        /// <summary>
        /// Constant Inactive for ScalingStatusCode
        /// </summary>
        public static readonly ScalingStatusCode Inactive = new ScalingStatusCode("Inactive");
        /// <summary>
        /// Constant PartiallyActive for ScalingStatusCode
        /// </summary>
        public static readonly ScalingStatusCode PartiallyActive = new ScalingStatusCode("PartiallyActive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingStatusCode FindValue(string value)
        {
            return FindValue<ScalingStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingStatusCode(string value)
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
        /// Constant Autoscaling for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Autoscaling = new ServiceNamespace("autoscaling");
        /// <summary>
        /// Constant Dynamodb for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Dynamodb = new ServiceNamespace("dynamodb");
        /// <summary>
        /// Constant Ec2 for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Ec2 = new ServiceNamespace("ec2");
        /// <summary>
        /// Constant Ecs for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Ecs = new ServiceNamespace("ecs");
        /// <summary>
        /// Constant Rds for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Rds = new ServiceNamespace("rds");

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