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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ComputeOptimizer
{

    /// <summary>
    /// Constants used for properties of type ExportableAutoScalingGroupField.
    /// </summary>
    public class ExportableAutoScalingGroupField : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField AccountId = new ExportableAutoScalingGroupField("AccountId");
        /// <summary>
        /// Constant AutoScalingGroupArn for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField AutoScalingGroupArn = new ExportableAutoScalingGroupField("AutoScalingGroupArn");
        /// <summary>
        /// Constant AutoScalingGroupName for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField AutoScalingGroupName = new ExportableAutoScalingGroupField("AutoScalingGroupName");
        /// <summary>
        /// Constant CurrentConfigurationDesiredCapacity for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentConfigurationDesiredCapacity = new ExportableAutoScalingGroupField("CurrentConfigurationDesiredCapacity");
        /// <summary>
        /// Constant CurrentConfigurationInstanceType for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentConfigurationInstanceType = new ExportableAutoScalingGroupField("CurrentConfigurationInstanceType");
        /// <summary>
        /// Constant CurrentConfigurationMaxSize for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentConfigurationMaxSize = new ExportableAutoScalingGroupField("CurrentConfigurationMaxSize");
        /// <summary>
        /// Constant CurrentConfigurationMinSize for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentConfigurationMinSize = new ExportableAutoScalingGroupField("CurrentConfigurationMinSize");
        /// <summary>
        /// Constant CurrentMemory for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentMemory = new ExportableAutoScalingGroupField("CurrentMemory");
        /// <summary>
        /// Constant CurrentNetwork for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentNetwork = new ExportableAutoScalingGroupField("CurrentNetwork");
        /// <summary>
        /// Constant CurrentOnDemandPrice for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentOnDemandPrice = new ExportableAutoScalingGroupField("CurrentOnDemandPrice");
        /// <summary>
        /// Constant CurrentStandardOneYearNoUpfrontReservedPrice for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentStandardOneYearNoUpfrontReservedPrice = new ExportableAutoScalingGroupField("CurrentStandardOneYearNoUpfrontReservedPrice");
        /// <summary>
        /// Constant CurrentStandardThreeYearNoUpfrontReservedPrice for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentStandardThreeYearNoUpfrontReservedPrice = new ExportableAutoScalingGroupField("CurrentStandardThreeYearNoUpfrontReservedPrice");
        /// <summary>
        /// Constant CurrentStorage for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentStorage = new ExportableAutoScalingGroupField("CurrentStorage");
        /// <summary>
        /// Constant CurrentVCpus for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentVCpus = new ExportableAutoScalingGroupField("CurrentVCpus");
        /// <summary>
        /// Constant Finding for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField Finding = new ExportableAutoScalingGroupField("Finding");
        /// <summary>
        /// Constant LastRefreshTimestamp for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField LastRefreshTimestamp = new ExportableAutoScalingGroupField("LastRefreshTimestamp");
        /// <summary>
        /// Constant LookbackPeriodInDays for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField LookbackPeriodInDays = new ExportableAutoScalingGroupField("LookbackPeriodInDays");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationDesiredCapacity for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationDesiredCapacity = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationDesiredCapacity");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationInstanceType for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationInstanceType = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationInstanceType");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationMaxSize for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationMaxSize = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationMaxSize");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationMinSize for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationMinSize = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationMinSize");
        /// <summary>
        /// Constant RecommendationOptionsMemory for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsMemory = new ExportableAutoScalingGroupField("RecommendationOptionsMemory");
        /// <summary>
        /// Constant RecommendationOptionsNetwork for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsNetwork = new ExportableAutoScalingGroupField("RecommendationOptionsNetwork");
        /// <summary>
        /// Constant RecommendationOptionsOnDemandPrice for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsOnDemandPrice = new ExportableAutoScalingGroupField("RecommendationOptionsOnDemandPrice");
        /// <summary>
        /// Constant RecommendationOptionsPerformanceRisk for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsPerformanceRisk = new ExportableAutoScalingGroupField("RecommendationOptionsPerformanceRisk");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsCpuMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsProjectedUtilizationMetricsCpuMaximum = new ExportableAutoScalingGroupField("RecommendationOptionsProjectedUtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum = new ExportableAutoScalingGroupField("RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum");
        /// <summary>
        /// Constant RecommendationOptionsStandardOneYearNoUpfrontReservedPrice for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsStandardOneYearNoUpfrontReservedPrice = new ExportableAutoScalingGroupField("RecommendationOptionsStandardOneYearNoUpfrontReservedPrice");
        /// <summary>
        /// Constant RecommendationOptionsStandardThreeYearNoUpfrontReservedPrice for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsStandardThreeYearNoUpfrontReservedPrice = new ExportableAutoScalingGroupField("RecommendationOptionsStandardThreeYearNoUpfrontReservedPrice");
        /// <summary>
        /// Constant RecommendationOptionsStorage for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsStorage = new ExportableAutoScalingGroupField("RecommendationOptionsStorage");
        /// <summary>
        /// Constant RecommendationOptionsVcpus for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsVcpus = new ExportableAutoScalingGroupField("RecommendationOptionsVcpus");
        /// <summary>
        /// Constant UtilizationMetricsCpuMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsCpuMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant UtilizationMetricsMemoryMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsMemoryMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsMemoryMaximum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportableAutoScalingGroupField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportableAutoScalingGroupField FindValue(string value)
        {
            return FindValue<ExportableAutoScalingGroupField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportableAutoScalingGroupField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportableInstanceField.
    /// </summary>
    public class ExportableInstanceField : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField AccountId = new ExportableInstanceField("AccountId");
        /// <summary>
        /// Constant CurrentInstanceType for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentInstanceType = new ExportableInstanceField("CurrentInstanceType");
        /// <summary>
        /// Constant CurrentMemory for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentMemory = new ExportableInstanceField("CurrentMemory");
        /// <summary>
        /// Constant CurrentNetwork for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentNetwork = new ExportableInstanceField("CurrentNetwork");
        /// <summary>
        /// Constant CurrentOnDemandPrice for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentOnDemandPrice = new ExportableInstanceField("CurrentOnDemandPrice");
        /// <summary>
        /// Constant CurrentStandardOneYearNoUpfrontReservedPrice for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentStandardOneYearNoUpfrontReservedPrice = new ExportableInstanceField("CurrentStandardOneYearNoUpfrontReservedPrice");
        /// <summary>
        /// Constant CurrentStandardThreeYearNoUpfrontReservedPrice for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentStandardThreeYearNoUpfrontReservedPrice = new ExportableInstanceField("CurrentStandardThreeYearNoUpfrontReservedPrice");
        /// <summary>
        /// Constant CurrentStorage for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentStorage = new ExportableInstanceField("CurrentStorage");
        /// <summary>
        /// Constant CurrentVCpus for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentVCpus = new ExportableInstanceField("CurrentVCpus");
        /// <summary>
        /// Constant Finding for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField Finding = new ExportableInstanceField("Finding");
        /// <summary>
        /// Constant InstanceArn for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField InstanceArn = new ExportableInstanceField("InstanceArn");
        /// <summary>
        /// Constant InstanceName for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField InstanceName = new ExportableInstanceField("InstanceName");
        /// <summary>
        /// Constant LastRefreshTimestamp for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField LastRefreshTimestamp = new ExportableInstanceField("LastRefreshTimestamp");
        /// <summary>
        /// Constant LookbackPeriodInDays for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField LookbackPeriodInDays = new ExportableInstanceField("LookbackPeriodInDays");
        /// <summary>
        /// Constant RecommendationOptionsInstanceType for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsInstanceType = new ExportableInstanceField("RecommendationOptionsInstanceType");
        /// <summary>
        /// Constant RecommendationOptionsMemory for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsMemory = new ExportableInstanceField("RecommendationOptionsMemory");
        /// <summary>
        /// Constant RecommendationOptionsNetwork for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsNetwork = new ExportableInstanceField("RecommendationOptionsNetwork");
        /// <summary>
        /// Constant RecommendationOptionsOnDemandPrice for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsOnDemandPrice = new ExportableInstanceField("RecommendationOptionsOnDemandPrice");
        /// <summary>
        /// Constant RecommendationOptionsPerformanceRisk for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsPerformanceRisk = new ExportableInstanceField("RecommendationOptionsPerformanceRisk");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsCpuMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsProjectedUtilizationMetricsCpuMaximum = new ExportableInstanceField("RecommendationOptionsProjectedUtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum = new ExportableInstanceField("RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum");
        /// <summary>
        /// Constant RecommendationOptionsStandardOneYearNoUpfrontReservedPrice for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsStandardOneYearNoUpfrontReservedPrice = new ExportableInstanceField("RecommendationOptionsStandardOneYearNoUpfrontReservedPrice");
        /// <summary>
        /// Constant RecommendationOptionsStandardThreeYearNoUpfrontReservedPrice for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsStandardThreeYearNoUpfrontReservedPrice = new ExportableInstanceField("RecommendationOptionsStandardThreeYearNoUpfrontReservedPrice");
        /// <summary>
        /// Constant RecommendationOptionsStorage for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsStorage = new ExportableInstanceField("RecommendationOptionsStorage");
        /// <summary>
        /// Constant RecommendationOptionsVcpus for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsVcpus = new ExportableInstanceField("RecommendationOptionsVcpus");
        /// <summary>
        /// Constant RecommendationsSourcesRecommendationSourceArn for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationsSourcesRecommendationSourceArn = new ExportableInstanceField("RecommendationsSourcesRecommendationSourceArn");
        /// <summary>
        /// Constant RecommendationsSourcesRecommendationSourceType for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationsSourcesRecommendationSourceType = new ExportableInstanceField("RecommendationsSourcesRecommendationSourceType");
        /// <summary>
        /// Constant UtilizationMetricsCpuMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsCpuMaximum = new ExportableInstanceField("UtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant UtilizationMetricsMemoryMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsMemoryMaximum = new ExportableInstanceField("UtilizationMetricsMemoryMaximum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportableInstanceField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportableInstanceField FindValue(string value)
        {
            return FindValue<ExportableInstanceField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportableInstanceField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileFormat.
    /// </summary>
    public class FileFormat : ConstantClass
    {

        /// <summary>
        /// Constant Csv for FileFormat
        /// </summary>
        public static readonly FileFormat Csv = new FileFormat("Csv");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileFormat FindValue(string value)
        {
            return FindValue<FileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterName.
    /// </summary>
    public class FilterName : ConstantClass
    {

        /// <summary>
        /// Constant Finding for FilterName
        /// </summary>
        public static readonly FilterName Finding = new FilterName("Finding");
        /// <summary>
        /// Constant RecommendationSourceType for FilterName
        /// </summary>
        public static readonly FilterName RecommendationSourceType = new FilterName("RecommendationSourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterName FindValue(string value)
        {
            return FindValue<FilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Finding.
    /// </summary>
    public class Finding : ConstantClass
    {

        /// <summary>
        /// Constant NotOptimized for Finding
        /// </summary>
        public static readonly Finding NotOptimized = new Finding("NotOptimized");
        /// <summary>
        /// Constant Optimized for Finding
        /// </summary>
        public static readonly Finding Optimized = new Finding("Optimized");
        /// <summary>
        /// Constant Overprovisioned for Finding
        /// </summary>
        public static readonly Finding Overprovisioned = new Finding("Overprovisioned");
        /// <summary>
        /// Constant Underprovisioned for Finding
        /// </summary>
        public static readonly Finding Underprovisioned = new Finding("Underprovisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Finding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Finding FindValue(string value)
        {
            return FindValue<Finding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Finding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobFilterName.
    /// </summary>
    public class JobFilterName : ConstantClass
    {

        /// <summary>
        /// Constant JobStatus for JobFilterName
        /// </summary>
        public static readonly JobFilterName JobStatus = new JobFilterName("JobStatus");
        /// <summary>
        /// Constant ResourceType for JobFilterName
        /// </summary>
        public static readonly JobFilterName ResourceType = new JobFilterName("ResourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobFilterName FindValue(string value)
        {
            return FindValue<JobFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Complete for JobStatus
        /// </summary>
        public static readonly JobStatus Complete = new JobStatus("Complete");
        /// <summary>
        /// Constant Failed for JobStatus
        /// </summary>
        public static readonly JobStatus Failed = new JobStatus("Failed");
        /// <summary>
        /// Constant InProgress for JobStatus
        /// </summary>
        public static readonly JobStatus InProgress = new JobStatus("InProgress");
        /// <summary>
        /// Constant Queued for JobStatus
        /// </summary>
        public static readonly JobStatus Queued = new JobStatus("Queued");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricName.
    /// </summary>
    public class MetricName : ConstantClass
    {

        /// <summary>
        /// Constant Cpu for MetricName
        /// </summary>
        public static readonly MetricName Cpu = new MetricName("Cpu");
        /// <summary>
        /// Constant Memory for MetricName
        /// </summary>
        public static readonly MetricName Memory = new MetricName("Memory");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricName FindValue(string value)
        {
            return FindValue<MetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricName(string value)
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
    /// Constants used for properties of type RecommendationSourceType.
    /// </summary>
    public class RecommendationSourceType : ConstantClass
    {

        /// <summary>
        /// Constant AutoScalingGroup for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType AutoScalingGroup = new RecommendationSourceType("AutoScalingGroup");
        /// <summary>
        /// Constant Ec2Instance for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType Ec2Instance = new RecommendationSourceType("Ec2Instance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationSourceType FindValue(string value)
        {
            return FindValue<RecommendationSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AutoScalingGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AutoScalingGroup = new ResourceType("AutoScalingGroup");
        /// <summary>
        /// Constant Ec2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType Ec2Instance = new ResourceType("Ec2Instance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant Active for Status
        /// </summary>
        public static readonly Status Active = new Status("Active");
        /// <summary>
        /// Constant Failed for Status
        /// </summary>
        public static readonly Status Failed = new Status("Failed");
        /// <summary>
        /// Constant Inactive for Status
        /// </summary>
        public static readonly Status Inactive = new Status("Inactive");
        /// <summary>
        /// Constant Pending for Status
        /// </summary>
        public static readonly Status Pending = new Status("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }

}