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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeGuruProfiler
{

    /// <summary>
    /// Constants used for properties of type ActionGroup.
    /// </summary>
    public class ActionGroup : ConstantClass
    {

        /// <summary>
        /// Constant AgentPermissions for ActionGroup
        /// </summary>
        public static readonly ActionGroup AgentPermissions = new ActionGroup("agentPermissions");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionGroup(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionGroup FindValue(string value)
        {
            return FindValue<ActionGroup>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionGroup(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentParameterField.
    /// </summary>
    public class AgentParameterField : ConstantClass
    {

        /// <summary>
        /// Constant MaxStackDepth for AgentParameterField
        /// </summary>
        public static readonly AgentParameterField MaxStackDepth = new AgentParameterField("MaxStackDepth");
        /// <summary>
        /// Constant MemoryUsageLimitPercent for AgentParameterField
        /// </summary>
        public static readonly AgentParameterField MemoryUsageLimitPercent = new AgentParameterField("MemoryUsageLimitPercent");
        /// <summary>
        /// Constant MinimumTimeForReportingInMilliseconds for AgentParameterField
        /// </summary>
        public static readonly AgentParameterField MinimumTimeForReportingInMilliseconds = new AgentParameterField("MinimumTimeForReportingInMilliseconds");
        /// <summary>
        /// Constant ReportingIntervalInMilliseconds for AgentParameterField
        /// </summary>
        public static readonly AgentParameterField ReportingIntervalInMilliseconds = new AgentParameterField("ReportingIntervalInMilliseconds");
        /// <summary>
        /// Constant SamplingIntervalInMilliseconds for AgentParameterField
        /// </summary>
        public static readonly AgentParameterField SamplingIntervalInMilliseconds = new AgentParameterField("SamplingIntervalInMilliseconds");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentParameterField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentParameterField FindValue(string value)
        {
            return FindValue<AgentParameterField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentParameterField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregationPeriod.
    /// </summary>
    public class AggregationPeriod : ConstantClass
    {

        /// <summary>
        /// Constant P1D for AggregationPeriod
        /// </summary>
        public static readonly AggregationPeriod P1D = new AggregationPeriod("P1D");
        /// <summary>
        /// Constant PT1H for AggregationPeriod
        /// </summary>
        public static readonly AggregationPeriod PT1H = new AggregationPeriod("PT1H");
        /// <summary>
        /// Constant PT5M for AggregationPeriod
        /// </summary>
        public static readonly AggregationPeriod PT5M = new AggregationPeriod("PT5M");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationPeriod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationPeriod FindValue(string value)
        {
            return FindValue<AggregationPeriod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationPeriod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputePlatform.
    /// </summary>
    public class ComputePlatform : ConstantClass
    {

        /// <summary>
        /// Constant AWSLambda for ComputePlatform
        /// </summary>
        public static readonly ComputePlatform AWSLambda = new ComputePlatform("AWSLambda");
        /// <summary>
        /// Constant Default for ComputePlatform
        /// </summary>
        public static readonly ComputePlatform Default = new ComputePlatform("Default");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputePlatform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputePlatform FindValue(string value)
        {
            return FindValue<ComputePlatform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputePlatform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventPublisher.
    /// </summary>
    public class EventPublisher : ConstantClass
    {

        /// <summary>
        /// Constant AnomalyDetection for EventPublisher
        /// </summary>
        public static readonly EventPublisher AnomalyDetection = new EventPublisher("AnomalyDetection");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventPublisher(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventPublisher FindValue(string value)
        {
            return FindValue<EventPublisher>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventPublisher(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeedbackType.
    /// </summary>
    public class FeedbackType : ConstantClass
    {

        /// <summary>
        /// Constant Negative for FeedbackType
        /// </summary>
        public static readonly FeedbackType Negative = new FeedbackType("Negative");
        /// <summary>
        /// Constant Positive for FeedbackType
        /// </summary>
        public static readonly FeedbackType Positive = new FeedbackType("Positive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeedbackType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedbackType FindValue(string value)
        {
            return FindValue<FeedbackType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedbackType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetadataField.
    /// </summary>
    public class MetadataField : ConstantClass
    {

        /// <summary>
        /// Constant AgentId for MetadataField
        /// </summary>
        public static readonly MetadataField AgentId = new MetadataField("AgentId");
        /// <summary>
        /// Constant AwsRequestId for MetadataField
        /// </summary>
        public static readonly MetadataField AwsRequestId = new MetadataField("AwsRequestId");
        /// <summary>
        /// Constant ComputePlatform for MetadataField
        /// </summary>
        public static readonly MetadataField ComputePlatform = new MetadataField("ComputePlatform");
        /// <summary>
        /// Constant ExecutionEnvironment for MetadataField
        /// </summary>
        public static readonly MetadataField ExecutionEnvironment = new MetadataField("ExecutionEnvironment");
        /// <summary>
        /// Constant LambdaFunctionArn for MetadataField
        /// </summary>
        public static readonly MetadataField LambdaFunctionArn = new MetadataField("LambdaFunctionArn");
        /// <summary>
        /// Constant LambdaMemoryLimitInMB for MetadataField
        /// </summary>
        public static readonly MetadataField LambdaMemoryLimitInMB = new MetadataField("LambdaMemoryLimitInMB");
        /// <summary>
        /// Constant LambdaPreviousExecutionTimeInMilliseconds for MetadataField
        /// </summary>
        public static readonly MetadataField LambdaPreviousExecutionTimeInMilliseconds = new MetadataField("LambdaPreviousExecutionTimeInMilliseconds");
        /// <summary>
        /// Constant LambdaRemainingTimeInMilliseconds for MetadataField
        /// </summary>
        public static readonly MetadataField LambdaRemainingTimeInMilliseconds = new MetadataField("LambdaRemainingTimeInMilliseconds");
        /// <summary>
        /// Constant LambdaTimeGapBetweenInvokesInMilliseconds for MetadataField
        /// </summary>
        public static readonly MetadataField LambdaTimeGapBetweenInvokesInMilliseconds = new MetadataField("LambdaTimeGapBetweenInvokesInMilliseconds");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetadataField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataField FindValue(string value)
        {
            return FindValue<MetadataField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataField(string value)
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
        /// Constant AggregatedRelativeTotalTime for MetricType
        /// </summary>
        public static readonly MetricType AggregatedRelativeTotalTime = new MetricType("AggregatedRelativeTotalTime");

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
    /// Constants used for properties of type OrderBy.
    /// </summary>
    public class OrderBy : ConstantClass
    {

        /// <summary>
        /// Constant TimestampAscending for OrderBy
        /// </summary>
        public static readonly OrderBy TimestampAscending = new OrderBy("TimestampAscending");
        /// <summary>
        /// Constant TimestampDescending for OrderBy
        /// </summary>
        public static readonly OrderBy TimestampDescending = new OrderBy("TimestampDescending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderBy FindValue(string value)
        {
            return FindValue<OrderBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderBy(string value)
        {
            return FindValue(value);
        }
    }

}