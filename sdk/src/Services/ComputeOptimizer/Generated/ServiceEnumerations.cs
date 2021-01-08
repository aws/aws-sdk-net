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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ComputeOptimizer
{

    /// <summary>
    /// Constants used for properties of type EBSFilterName.
    /// </summary>
    public class EBSFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Finding for EBSFilterName
        /// </summary>
        public static readonly EBSFilterName Finding = new EBSFilterName("Finding");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EBSFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EBSFilterName FindValue(string value)
        {
            return FindValue<EBSFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EBSFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EBSFinding.
    /// </summary>
    public class EBSFinding : ConstantClass
    {

        /// <summary>
        /// Constant NotOptimized for EBSFinding
        /// </summary>
        public static readonly EBSFinding NotOptimized = new EBSFinding("NotOptimized");
        /// <summary>
        /// Constant Optimized for EBSFinding
        /// </summary>
        public static readonly EBSFinding Optimized = new EBSFinding("Optimized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EBSFinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EBSFinding FindValue(string value)
        {
            return FindValue<EBSFinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EBSFinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EBSMetricName.
    /// </summary>
    public class EBSMetricName : ConstantClass
    {

        /// <summary>
        /// Constant VolumeReadBytesPerSecond for EBSMetricName
        /// </summary>
        public static readonly EBSMetricName VolumeReadBytesPerSecond = new EBSMetricName("VolumeReadBytesPerSecond");
        /// <summary>
        /// Constant VolumeReadOpsPerSecond for EBSMetricName
        /// </summary>
        public static readonly EBSMetricName VolumeReadOpsPerSecond = new EBSMetricName("VolumeReadOpsPerSecond");
        /// <summary>
        /// Constant VolumeWriteBytesPerSecond for EBSMetricName
        /// </summary>
        public static readonly EBSMetricName VolumeWriteBytesPerSecond = new EBSMetricName("VolumeWriteBytesPerSecond");
        /// <summary>
        /// Constant VolumeWriteOpsPerSecond for EBSMetricName
        /// </summary>
        public static readonly EBSMetricName VolumeWriteOpsPerSecond = new EBSMetricName("VolumeWriteOpsPerSecond");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EBSMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EBSMetricName FindValue(string value)
        {
            return FindValue<EBSMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EBSMetricName(string value)
        {
            return FindValue(value);
        }
    }


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
        /// Constant UtilizationMetricsEbsReadBytesPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsEbsReadBytesPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsEbsReadBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEbsReadOpsPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsEbsReadOpsPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsEbsReadOpsPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEbsWriteBytesPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsEbsWriteBytesPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsEbsWriteBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEbsWriteOpsPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsEbsWriteOpsPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsEbsWriteOpsPerSecondMaximum");
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
        /// Constant UtilizationMetricsEbsReadBytesPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsEbsReadBytesPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsEbsReadBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEbsReadOpsPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsEbsReadOpsPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsEbsReadOpsPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEbsWriteBytesPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsEbsWriteBytesPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsEbsWriteBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEbsWriteOpsPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsEbsWriteOpsPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsEbsWriteOpsPerSecondMaximum");
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
    /// Constants used for properties of type FindingReasonCode.
    /// </summary>
    public class FindingReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant MemoryOverprovisioned for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode MemoryOverprovisioned = new FindingReasonCode("MemoryOverprovisioned");
        /// <summary>
        /// Constant MemoryUnderprovisioned for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode MemoryUnderprovisioned = new FindingReasonCode("MemoryUnderprovisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingReasonCode FindValue(string value)
        {
            return FindValue<FindingReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingReasonCode(string value)
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
    /// Constants used for properties of type LambdaFunctionMemoryMetricName.
    /// </summary>
    public class LambdaFunctionMemoryMetricName : ConstantClass
    {

        /// <summary>
        /// Constant Duration for LambdaFunctionMemoryMetricName
        /// </summary>
        public static readonly LambdaFunctionMemoryMetricName Duration = new LambdaFunctionMemoryMetricName("Duration");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionMemoryMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionMemoryMetricName FindValue(string value)
        {
            return FindValue<LambdaFunctionMemoryMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionMemoryMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaFunctionMemoryMetricStatistic.
    /// </summary>
    public class LambdaFunctionMemoryMetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Expected for LambdaFunctionMemoryMetricStatistic
        /// </summary>
        public static readonly LambdaFunctionMemoryMetricStatistic Expected = new LambdaFunctionMemoryMetricStatistic("Expected");
        /// <summary>
        /// Constant LowerBound for LambdaFunctionMemoryMetricStatistic
        /// </summary>
        public static readonly LambdaFunctionMemoryMetricStatistic LowerBound = new LambdaFunctionMemoryMetricStatistic("LowerBound");
        /// <summary>
        /// Constant UpperBound for LambdaFunctionMemoryMetricStatistic
        /// </summary>
        public static readonly LambdaFunctionMemoryMetricStatistic UpperBound = new LambdaFunctionMemoryMetricStatistic("UpperBound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionMemoryMetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionMemoryMetricStatistic FindValue(string value)
        {
            return FindValue<LambdaFunctionMemoryMetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionMemoryMetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaFunctionMetricName.
    /// </summary>
    public class LambdaFunctionMetricName : ConstantClass
    {

        /// <summary>
        /// Constant Duration for LambdaFunctionMetricName
        /// </summary>
        public static readonly LambdaFunctionMetricName Duration = new LambdaFunctionMetricName("Duration");
        /// <summary>
        /// Constant Memory for LambdaFunctionMetricName
        /// </summary>
        public static readonly LambdaFunctionMetricName Memory = new LambdaFunctionMetricName("Memory");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionMetricName FindValue(string value)
        {
            return FindValue<LambdaFunctionMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaFunctionMetricStatistic.
    /// </summary>
    public class LambdaFunctionMetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for LambdaFunctionMetricStatistic
        /// </summary>
        public static readonly LambdaFunctionMetricStatistic Average = new LambdaFunctionMetricStatistic("Average");
        /// <summary>
        /// Constant Maximum for LambdaFunctionMetricStatistic
        /// </summary>
        public static readonly LambdaFunctionMetricStatistic Maximum = new LambdaFunctionMetricStatistic("Maximum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionMetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionMetricStatistic FindValue(string value)
        {
            return FindValue<LambdaFunctionMetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionMetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaFunctionRecommendationFilterName.
    /// </summary>
    public class LambdaFunctionRecommendationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Finding for LambdaFunctionRecommendationFilterName
        /// </summary>
        public static readonly LambdaFunctionRecommendationFilterName Finding = new LambdaFunctionRecommendationFilterName("Finding");
        /// <summary>
        /// Constant FindingReasonCode for LambdaFunctionRecommendationFilterName
        /// </summary>
        public static readonly LambdaFunctionRecommendationFilterName FindingReasonCode = new LambdaFunctionRecommendationFilterName("FindingReasonCode");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionRecommendationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionRecommendationFilterName FindValue(string value)
        {
            return FindValue<LambdaFunctionRecommendationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionRecommendationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaFunctionRecommendationFinding.
    /// </summary>
    public class LambdaFunctionRecommendationFinding : ConstantClass
    {

        /// <summary>
        /// Constant NotOptimized for LambdaFunctionRecommendationFinding
        /// </summary>
        public static readonly LambdaFunctionRecommendationFinding NotOptimized = new LambdaFunctionRecommendationFinding("NotOptimized");
        /// <summary>
        /// Constant Optimized for LambdaFunctionRecommendationFinding
        /// </summary>
        public static readonly LambdaFunctionRecommendationFinding Optimized = new LambdaFunctionRecommendationFinding("Optimized");
        /// <summary>
        /// Constant Unavailable for LambdaFunctionRecommendationFinding
        /// </summary>
        public static readonly LambdaFunctionRecommendationFinding Unavailable = new LambdaFunctionRecommendationFinding("Unavailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionRecommendationFinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionRecommendationFinding FindValue(string value)
        {
            return FindValue<LambdaFunctionRecommendationFinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionRecommendationFinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaFunctionRecommendationFindingReasonCode.
    /// </summary>
    public class LambdaFunctionRecommendationFindingReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant Inconclusive for LambdaFunctionRecommendationFindingReasonCode
        /// </summary>
        public static readonly LambdaFunctionRecommendationFindingReasonCode Inconclusive = new LambdaFunctionRecommendationFindingReasonCode("Inconclusive");
        /// <summary>
        /// Constant InsufficientData for LambdaFunctionRecommendationFindingReasonCode
        /// </summary>
        public static readonly LambdaFunctionRecommendationFindingReasonCode InsufficientData = new LambdaFunctionRecommendationFindingReasonCode("InsufficientData");
        /// <summary>
        /// Constant MemoryOverprovisioned for LambdaFunctionRecommendationFindingReasonCode
        /// </summary>
        public static readonly LambdaFunctionRecommendationFindingReasonCode MemoryOverprovisioned = new LambdaFunctionRecommendationFindingReasonCode("MemoryOverprovisioned");
        /// <summary>
        /// Constant MemoryUnderprovisioned for LambdaFunctionRecommendationFindingReasonCode
        /// </summary>
        public static readonly LambdaFunctionRecommendationFindingReasonCode MemoryUnderprovisioned = new LambdaFunctionRecommendationFindingReasonCode("MemoryUnderprovisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionRecommendationFindingReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionRecommendationFindingReasonCode FindValue(string value)
        {
            return FindValue<LambdaFunctionRecommendationFindingReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionRecommendationFindingReasonCode(string value)
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
        /// Constant EBS_READ_BYTES_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName EBS_READ_BYTES_PER_SECOND = new MetricName("EBS_READ_BYTES_PER_SECOND");
        /// <summary>
        /// Constant EBS_READ_OPS_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName EBS_READ_OPS_PER_SECOND = new MetricName("EBS_READ_OPS_PER_SECOND");
        /// <summary>
        /// Constant EBS_WRITE_BYTES_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName EBS_WRITE_BYTES_PER_SECOND = new MetricName("EBS_WRITE_BYTES_PER_SECOND");
        /// <summary>
        /// Constant EBS_WRITE_OPS_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName EBS_WRITE_OPS_PER_SECOND = new MetricName("EBS_WRITE_OPS_PER_SECOND");
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
        /// Constant EbsVolume for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType EbsVolume = new RecommendationSourceType("EbsVolume");
        /// <summary>
        /// Constant Ec2Instance for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType Ec2Instance = new RecommendationSourceType("Ec2Instance");
        /// <summary>
        /// Constant LambdaFunction for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType LambdaFunction = new RecommendationSourceType("LambdaFunction");

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