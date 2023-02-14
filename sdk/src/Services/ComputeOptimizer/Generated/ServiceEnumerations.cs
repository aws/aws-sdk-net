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
    /// Constants used for properties of type AutoScalingConfiguration.
    /// </summary>
    public class AutoScalingConfiguration : ConstantClass
    {

        /// <summary>
        /// Constant TargetTrackingScalingCpu for AutoScalingConfiguration
        /// </summary>
        public static readonly AutoScalingConfiguration TargetTrackingScalingCpu = new AutoScalingConfiguration("TargetTrackingScalingCpu");
        /// <summary>
        /// Constant TargetTrackingScalingMemory for AutoScalingConfiguration
        /// </summary>
        public static readonly AutoScalingConfiguration TargetTrackingScalingMemory = new AutoScalingConfiguration("TargetTrackingScalingMemory");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingConfiguration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingConfiguration FindValue(string value)
        {
            return FindValue<AutoScalingConfiguration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingConfiguration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CpuVendorArchitecture.
    /// </summary>
    public class CpuVendorArchitecture : ConstantClass
    {

        /// <summary>
        /// Constant AWS_ARM64 for CpuVendorArchitecture
        /// </summary>
        public static readonly CpuVendorArchitecture AWS_ARM64 = new CpuVendorArchitecture("AWS_ARM64");
        /// <summary>
        /// Constant CURRENT for CpuVendorArchitecture
        /// </summary>
        public static readonly CpuVendorArchitecture CURRENT = new CpuVendorArchitecture("CURRENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CpuVendorArchitecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CpuVendorArchitecture FindValue(string value)
        {
            return FindValue<CpuVendorArchitecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CpuVendorArchitecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Currency.
    /// </summary>
    public class Currency : ConstantClass
    {

        /// <summary>
        /// Constant CNY for Currency
        /// </summary>
        public static readonly Currency CNY = new Currency("CNY");
        /// <summary>
        /// Constant USD for Currency
        /// </summary>
        public static readonly Currency USD = new Currency("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Currency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Currency FindValue(string value)
        {
            return FindValue<Currency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Currency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrentPerformanceRisk.
    /// </summary>
    public class CurrentPerformanceRisk : ConstantClass
    {

        /// <summary>
        /// Constant High for CurrentPerformanceRisk
        /// </summary>
        public static readonly CurrentPerformanceRisk High = new CurrentPerformanceRisk("High");
        /// <summary>
        /// Constant Low for CurrentPerformanceRisk
        /// </summary>
        public static readonly CurrentPerformanceRisk Low = new CurrentPerformanceRisk("Low");
        /// <summary>
        /// Constant Medium for CurrentPerformanceRisk
        /// </summary>
        public static readonly CurrentPerformanceRisk Medium = new CurrentPerformanceRisk("Medium");
        /// <summary>
        /// Constant VeryLow for CurrentPerformanceRisk
        /// </summary>
        public static readonly CurrentPerformanceRisk VeryLow = new CurrentPerformanceRisk("VeryLow");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrentPerformanceRisk(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrentPerformanceRisk FindValue(string value)
        {
            return FindValue<CurrentPerformanceRisk>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrentPerformanceRisk(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type ECSServiceLaunchType.
    /// </summary>
    public class ECSServiceLaunchType : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for ECSServiceLaunchType
        /// </summary>
        public static readonly ECSServiceLaunchType EC2 = new ECSServiceLaunchType("EC2");
        /// <summary>
        /// Constant Fargate for ECSServiceLaunchType
        /// </summary>
        public static readonly ECSServiceLaunchType Fargate = new ECSServiceLaunchType("Fargate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ECSServiceLaunchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ECSServiceLaunchType FindValue(string value)
        {
            return FindValue<ECSServiceLaunchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ECSServiceLaunchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ECSServiceMetricName.
    /// </summary>
    public class ECSServiceMetricName : ConstantClass
    {

        /// <summary>
        /// Constant Cpu for ECSServiceMetricName
        /// </summary>
        public static readonly ECSServiceMetricName Cpu = new ECSServiceMetricName("Cpu");
        /// <summary>
        /// Constant Memory for ECSServiceMetricName
        /// </summary>
        public static readonly ECSServiceMetricName Memory = new ECSServiceMetricName("Memory");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ECSServiceMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ECSServiceMetricName FindValue(string value)
        {
            return FindValue<ECSServiceMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ECSServiceMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ECSServiceMetricStatistic.
    /// </summary>
    public class ECSServiceMetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for ECSServiceMetricStatistic
        /// </summary>
        public static readonly ECSServiceMetricStatistic Average = new ECSServiceMetricStatistic("Average");
        /// <summary>
        /// Constant Maximum for ECSServiceMetricStatistic
        /// </summary>
        public static readonly ECSServiceMetricStatistic Maximum = new ECSServiceMetricStatistic("Maximum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ECSServiceMetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ECSServiceMetricStatistic FindValue(string value)
        {
            return FindValue<ECSServiceMetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ECSServiceMetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ECSServiceRecommendationFilterName.
    /// </summary>
    public class ECSServiceRecommendationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Finding for ECSServiceRecommendationFilterName
        /// </summary>
        public static readonly ECSServiceRecommendationFilterName Finding = new ECSServiceRecommendationFilterName("Finding");
        /// <summary>
        /// Constant FindingReasonCode for ECSServiceRecommendationFilterName
        /// </summary>
        public static readonly ECSServiceRecommendationFilterName FindingReasonCode = new ECSServiceRecommendationFilterName("FindingReasonCode");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ECSServiceRecommendationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ECSServiceRecommendationFilterName FindValue(string value)
        {
            return FindValue<ECSServiceRecommendationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ECSServiceRecommendationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ECSServiceRecommendationFinding.
    /// </summary>
    public class ECSServiceRecommendationFinding : ConstantClass
    {

        /// <summary>
        /// Constant Optimized for ECSServiceRecommendationFinding
        /// </summary>
        public static readonly ECSServiceRecommendationFinding Optimized = new ECSServiceRecommendationFinding("Optimized");
        /// <summary>
        /// Constant Overprovisioned for ECSServiceRecommendationFinding
        /// </summary>
        public static readonly ECSServiceRecommendationFinding Overprovisioned = new ECSServiceRecommendationFinding("Overprovisioned");
        /// <summary>
        /// Constant Underprovisioned for ECSServiceRecommendationFinding
        /// </summary>
        public static readonly ECSServiceRecommendationFinding Underprovisioned = new ECSServiceRecommendationFinding("Underprovisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ECSServiceRecommendationFinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ECSServiceRecommendationFinding FindValue(string value)
        {
            return FindValue<ECSServiceRecommendationFinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ECSServiceRecommendationFinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ECSServiceRecommendationFindingReasonCode.
    /// </summary>
    public class ECSServiceRecommendationFindingReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CPUOverprovisioned for ECSServiceRecommendationFindingReasonCode
        /// </summary>
        public static readonly ECSServiceRecommendationFindingReasonCode CPUOverprovisioned = new ECSServiceRecommendationFindingReasonCode("CPUOverprovisioned");
        /// <summary>
        /// Constant CPUUnderprovisioned for ECSServiceRecommendationFindingReasonCode
        /// </summary>
        public static readonly ECSServiceRecommendationFindingReasonCode CPUUnderprovisioned = new ECSServiceRecommendationFindingReasonCode("CPUUnderprovisioned");
        /// <summary>
        /// Constant MemoryOverprovisioned for ECSServiceRecommendationFindingReasonCode
        /// </summary>
        public static readonly ECSServiceRecommendationFindingReasonCode MemoryOverprovisioned = new ECSServiceRecommendationFindingReasonCode("MemoryOverprovisioned");
        /// <summary>
        /// Constant MemoryUnderprovisioned for ECSServiceRecommendationFindingReasonCode
        /// </summary>
        public static readonly ECSServiceRecommendationFindingReasonCode MemoryUnderprovisioned = new ECSServiceRecommendationFindingReasonCode("MemoryUnderprovisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ECSServiceRecommendationFindingReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ECSServiceRecommendationFindingReasonCode FindValue(string value)
        {
            return FindValue<ECSServiceRecommendationFindingReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ECSServiceRecommendationFindingReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnhancedInfrastructureMetrics.
    /// </summary>
    public class EnhancedInfrastructureMetrics : ConstantClass
    {

        /// <summary>
        /// Constant Active for EnhancedInfrastructureMetrics
        /// </summary>
        public static readonly EnhancedInfrastructureMetrics Active = new EnhancedInfrastructureMetrics("Active");
        /// <summary>
        /// Constant Inactive for EnhancedInfrastructureMetrics
        /// </summary>
        public static readonly EnhancedInfrastructureMetrics Inactive = new EnhancedInfrastructureMetrics("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnhancedInfrastructureMetrics(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnhancedInfrastructureMetrics FindValue(string value)
        {
            return FindValue<EnhancedInfrastructureMetrics>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnhancedInfrastructureMetrics(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnrollmentFilterName.
    /// </summary>
    public class EnrollmentFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Status for EnrollmentFilterName
        /// </summary>
        public static readonly EnrollmentFilterName Status = new EnrollmentFilterName("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnrollmentFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnrollmentFilterName FindValue(string value)
        {
            return FindValue<EnrollmentFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnrollmentFilterName(string value)
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
        /// Constant CurrentPerformanceRisk for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentPerformanceRisk = new ExportableAutoScalingGroupField("CurrentPerformanceRisk");
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
        /// Constant EffectiveRecommendationPreferencesCpuVendorArchitectures for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField EffectiveRecommendationPreferencesCpuVendorArchitectures = new ExportableAutoScalingGroupField("EffectiveRecommendationPreferencesCpuVendorArchitectures");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics = new ExportableAutoScalingGroupField("EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesInferredWorkloadTypes for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField EffectiveRecommendationPreferencesInferredWorkloadTypes = new ExportableAutoScalingGroupField("EffectiveRecommendationPreferencesInferredWorkloadTypes");
        /// <summary>
        /// Constant Finding for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField Finding = new ExportableAutoScalingGroupField("Finding");
        /// <summary>
        /// Constant InferredWorkloadTypes for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField InferredWorkloadTypes = new ExportableAutoScalingGroupField("InferredWorkloadTypes");
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
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableAutoScalingGroupField("RecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableAutoScalingGroupField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsMemory for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsMemory = new ExportableAutoScalingGroupField("RecommendationOptionsMemory");
        /// <summary>
        /// Constant RecommendationOptionsMigrationEffort for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsMigrationEffort = new ExportableAutoScalingGroupField("RecommendationOptionsMigrationEffort");
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
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsSavingsOpportunityPercentage = new ExportableAutoScalingGroupField("RecommendationOptionsSavingsOpportunityPercentage");
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
        /// Constant UtilizationMetricsDiskReadBytesPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsDiskReadBytesPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsDiskReadBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsDiskReadOpsPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsDiskReadOpsPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsDiskReadOpsPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsDiskWriteBytesPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsDiskWriteBytesPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsDiskWriteBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsDiskWriteOpsPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsDiskWriteOpsPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsDiskWriteOpsPerSecondMaximum");
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
        /// Constant UtilizationMetricsNetworkInBytesPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsNetworkInBytesPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsNetworkInBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkOutBytesPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsNetworkOutBytesPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsNetworkOutBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkPacketsInPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsNetworkPacketsInPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsNetworkPacketsInPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkPacketsOutPerSecondMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsNetworkPacketsOutPerSecondMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsNetworkPacketsOutPerSecondMaximum");

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
    /// Constants used for properties of type ExportableECSServiceField.
    /// </summary>
    public class ExportableECSServiceField : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField AccountId = new ExportableECSServiceField("AccountId");
        /// <summary>
        /// Constant CurrentPerformanceRisk for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField CurrentPerformanceRisk = new ExportableECSServiceField("CurrentPerformanceRisk");
        /// <summary>
        /// Constant CurrentServiceConfigurationAutoScalingConfiguration for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField CurrentServiceConfigurationAutoScalingConfiguration = new ExportableECSServiceField("CurrentServiceConfigurationAutoScalingConfiguration");
        /// <summary>
        /// Constant CurrentServiceConfigurationCpu for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField CurrentServiceConfigurationCpu = new ExportableECSServiceField("CurrentServiceConfigurationCpu");
        /// <summary>
        /// Constant CurrentServiceConfigurationMemory for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField CurrentServiceConfigurationMemory = new ExportableECSServiceField("CurrentServiceConfigurationMemory");
        /// <summary>
        /// Constant CurrentServiceConfigurationTaskDefinitionArn for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField CurrentServiceConfigurationTaskDefinitionArn = new ExportableECSServiceField("CurrentServiceConfigurationTaskDefinitionArn");
        /// <summary>
        /// Constant CurrentServiceContainerConfigurations for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField CurrentServiceContainerConfigurations = new ExportableECSServiceField("CurrentServiceContainerConfigurations");
        /// <summary>
        /// Constant Finding for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField Finding = new ExportableECSServiceField("Finding");
        /// <summary>
        /// Constant FindingReasonCodes for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField FindingReasonCodes = new ExportableECSServiceField("FindingReasonCodes");
        /// <summary>
        /// Constant LastRefreshTimestamp for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField LastRefreshTimestamp = new ExportableECSServiceField("LastRefreshTimestamp");
        /// <summary>
        /// Constant LaunchType for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField LaunchType = new ExportableECSServiceField("LaunchType");
        /// <summary>
        /// Constant LookbackPeriodInDays for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField LookbackPeriodInDays = new ExportableECSServiceField("LookbackPeriodInDays");
        /// <summary>
        /// Constant RecommendationOptionsContainerRecommendations for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsContainerRecommendations = new ExportableECSServiceField("RecommendationOptionsContainerRecommendations");
        /// <summary>
        /// Constant RecommendationOptionsCpu for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsCpu = new ExportableECSServiceField("RecommendationOptionsCpu");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableECSServiceField("RecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableECSServiceField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsMemory for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsMemory = new ExportableECSServiceField("RecommendationOptionsMemory");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsCpuMaximum for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsProjectedUtilizationMetricsCpuMaximum = new ExportableECSServiceField("RecommendationOptionsProjectedUtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum = new ExportableECSServiceField("RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsSavingsOpportunityPercentage = new ExportableECSServiceField("RecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant ServiceArn for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField ServiceArn = new ExportableECSServiceField("ServiceArn");
        /// <summary>
        /// Constant UtilizationMetricsCpuMaximum for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField UtilizationMetricsCpuMaximum = new ExportableECSServiceField("UtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant UtilizationMetricsMemoryMaximum for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField UtilizationMetricsMemoryMaximum = new ExportableECSServiceField("UtilizationMetricsMemoryMaximum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportableECSServiceField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportableECSServiceField FindValue(string value)
        {
            return FindValue<ExportableECSServiceField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportableECSServiceField(string value)
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
        /// Constant CurrentPerformanceRisk for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentPerformanceRisk = new ExportableInstanceField("CurrentPerformanceRisk");
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
        /// Constant EffectiveRecommendationPreferencesCpuVendorArchitectures for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField EffectiveRecommendationPreferencesCpuVendorArchitectures = new ExportableInstanceField("EffectiveRecommendationPreferencesCpuVendorArchitectures");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics = new ExportableInstanceField("EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesExternalMetricsSource for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField EffectiveRecommendationPreferencesExternalMetricsSource = new ExportableInstanceField("EffectiveRecommendationPreferencesExternalMetricsSource");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesInferredWorkloadTypes for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField EffectiveRecommendationPreferencesInferredWorkloadTypes = new ExportableInstanceField("EffectiveRecommendationPreferencesInferredWorkloadTypes");
        /// <summary>
        /// Constant Finding for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField Finding = new ExportableInstanceField("Finding");
        /// <summary>
        /// Constant FindingReasonCodes for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField FindingReasonCodes = new ExportableInstanceField("FindingReasonCodes");
        /// <summary>
        /// Constant InferredWorkloadTypes for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField InferredWorkloadTypes = new ExportableInstanceField("InferredWorkloadTypes");
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
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableInstanceField("RecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableInstanceField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsInstanceType for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsInstanceType = new ExportableInstanceField("RecommendationOptionsInstanceType");
        /// <summary>
        /// Constant RecommendationOptionsMemory for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsMemory = new ExportableInstanceField("RecommendationOptionsMemory");
        /// <summary>
        /// Constant RecommendationOptionsMigrationEffort for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsMigrationEffort = new ExportableInstanceField("RecommendationOptionsMigrationEffort");
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
        /// Constant RecommendationOptionsPlatformDifferences for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsPlatformDifferences = new ExportableInstanceField("RecommendationOptionsPlatformDifferences");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsCpuMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsProjectedUtilizationMetricsCpuMaximum = new ExportableInstanceField("RecommendationOptionsProjectedUtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum = new ExportableInstanceField("RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsSavingsOpportunityPercentage = new ExportableInstanceField("RecommendationOptionsSavingsOpportunityPercentage");
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
        /// Constant UtilizationMetricsDiskReadBytesPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsDiskReadBytesPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsDiskReadBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsDiskReadOpsPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsDiskReadOpsPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsDiskReadOpsPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsDiskWriteBytesPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsDiskWriteBytesPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsDiskWriteBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsDiskWriteOpsPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsDiskWriteOpsPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsDiskWriteOpsPerSecondMaximum");
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
        /// Constant UtilizationMetricsNetworkInBytesPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsNetworkInBytesPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsNetworkInBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkOutBytesPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsNetworkOutBytesPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsNetworkOutBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkPacketsInPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsNetworkPacketsInPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsNetworkPacketsInPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkPacketsOutPerSecondMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsNetworkPacketsOutPerSecondMaximum = new ExportableInstanceField("UtilizationMetricsNetworkPacketsOutPerSecondMaximum");

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
    /// Constants used for properties of type ExportableLambdaFunctionField.
    /// </summary>
    public class ExportableLambdaFunctionField : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField AccountId = new ExportableLambdaFunctionField("AccountId");
        /// <summary>
        /// Constant CurrentConfigurationMemorySize for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField CurrentConfigurationMemorySize = new ExportableLambdaFunctionField("CurrentConfigurationMemorySize");
        /// <summary>
        /// Constant CurrentConfigurationTimeout for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField CurrentConfigurationTimeout = new ExportableLambdaFunctionField("CurrentConfigurationTimeout");
        /// <summary>
        /// Constant CurrentCostAverage for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField CurrentCostAverage = new ExportableLambdaFunctionField("CurrentCostAverage");
        /// <summary>
        /// Constant CurrentCostTotal for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField CurrentCostTotal = new ExportableLambdaFunctionField("CurrentCostTotal");
        /// <summary>
        /// Constant CurrentPerformanceRisk for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField CurrentPerformanceRisk = new ExportableLambdaFunctionField("CurrentPerformanceRisk");
        /// <summary>
        /// Constant Finding for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField Finding = new ExportableLambdaFunctionField("Finding");
        /// <summary>
        /// Constant FindingReasonCodes for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField FindingReasonCodes = new ExportableLambdaFunctionField("FindingReasonCodes");
        /// <summary>
        /// Constant FunctionArn for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField FunctionArn = new ExportableLambdaFunctionField("FunctionArn");
        /// <summary>
        /// Constant FunctionVersion for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField FunctionVersion = new ExportableLambdaFunctionField("FunctionVersion");
        /// <summary>
        /// Constant LastRefreshTimestamp for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField LastRefreshTimestamp = new ExportableLambdaFunctionField("LastRefreshTimestamp");
        /// <summary>
        /// Constant LookbackPeriodInDays for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField LookbackPeriodInDays = new ExportableLambdaFunctionField("LookbackPeriodInDays");
        /// <summary>
        /// Constant NumberOfInvocations for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField NumberOfInvocations = new ExportableLambdaFunctionField("NumberOfInvocations");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationMemorySize for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsConfigurationMemorySize = new ExportableLambdaFunctionField("RecommendationOptionsConfigurationMemorySize");
        /// <summary>
        /// Constant RecommendationOptionsCostHigh for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsCostHigh = new ExportableLambdaFunctionField("RecommendationOptionsCostHigh");
        /// <summary>
        /// Constant RecommendationOptionsCostLow for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsCostLow = new ExportableLambdaFunctionField("RecommendationOptionsCostLow");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableLambdaFunctionField("RecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableLambdaFunctionField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsDurationExpected for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsProjectedUtilizationMetricsDurationExpected = new ExportableLambdaFunctionField("RecommendationOptionsProjectedUtilizationMetricsDurationExpected");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsDurationLowerBound for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsProjectedUtilizationMetricsDurationLowerBound = new ExportableLambdaFunctionField("RecommendationOptionsProjectedUtilizationMetricsDurationLowerBound");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsDurationUpperBound for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsProjectedUtilizationMetricsDurationUpperBound = new ExportableLambdaFunctionField("RecommendationOptionsProjectedUtilizationMetricsDurationUpperBound");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsSavingsOpportunityPercentage = new ExportableLambdaFunctionField("RecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant UtilizationMetricsDurationAverage for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField UtilizationMetricsDurationAverage = new ExportableLambdaFunctionField("UtilizationMetricsDurationAverage");
        /// <summary>
        /// Constant UtilizationMetricsDurationMaximum for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField UtilizationMetricsDurationMaximum = new ExportableLambdaFunctionField("UtilizationMetricsDurationMaximum");
        /// <summary>
        /// Constant UtilizationMetricsMemoryAverage for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField UtilizationMetricsMemoryAverage = new ExportableLambdaFunctionField("UtilizationMetricsMemoryAverage");
        /// <summary>
        /// Constant UtilizationMetricsMemoryMaximum for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField UtilizationMetricsMemoryMaximum = new ExportableLambdaFunctionField("UtilizationMetricsMemoryMaximum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportableLambdaFunctionField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportableLambdaFunctionField FindValue(string value)
        {
            return FindValue<ExportableLambdaFunctionField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportableLambdaFunctionField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportableVolumeField.
    /// </summary>
    public class ExportableVolumeField : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField AccountId = new ExportableVolumeField("AccountId");
        /// <summary>
        /// Constant CurrentConfigurationVolumeBaselineIOPS for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentConfigurationVolumeBaselineIOPS = new ExportableVolumeField("CurrentConfigurationVolumeBaselineIOPS");
        /// <summary>
        /// Constant CurrentConfigurationVolumeBaselineThroughput for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentConfigurationVolumeBaselineThroughput = new ExportableVolumeField("CurrentConfigurationVolumeBaselineThroughput");
        /// <summary>
        /// Constant CurrentConfigurationVolumeBurstIOPS for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentConfigurationVolumeBurstIOPS = new ExportableVolumeField("CurrentConfigurationVolumeBurstIOPS");
        /// <summary>
        /// Constant CurrentConfigurationVolumeBurstThroughput for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentConfigurationVolumeBurstThroughput = new ExportableVolumeField("CurrentConfigurationVolumeBurstThroughput");
        /// <summary>
        /// Constant CurrentConfigurationVolumeSize for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentConfigurationVolumeSize = new ExportableVolumeField("CurrentConfigurationVolumeSize");
        /// <summary>
        /// Constant CurrentConfigurationVolumeType for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentConfigurationVolumeType = new ExportableVolumeField("CurrentConfigurationVolumeType");
        /// <summary>
        /// Constant CurrentMonthlyPrice for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentMonthlyPrice = new ExportableVolumeField("CurrentMonthlyPrice");
        /// <summary>
        /// Constant CurrentPerformanceRisk for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentPerformanceRisk = new ExportableVolumeField("CurrentPerformanceRisk");
        /// <summary>
        /// Constant Finding for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField Finding = new ExportableVolumeField("Finding");
        /// <summary>
        /// Constant LastRefreshTimestamp for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField LastRefreshTimestamp = new ExportableVolumeField("LastRefreshTimestamp");
        /// <summary>
        /// Constant LookbackPeriodInDays for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField LookbackPeriodInDays = new ExportableVolumeField("LookbackPeriodInDays");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationVolumeBaselineIOPS for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsConfigurationVolumeBaselineIOPS = new ExportableVolumeField("RecommendationOptionsConfigurationVolumeBaselineIOPS");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationVolumeBaselineThroughput for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsConfigurationVolumeBaselineThroughput = new ExportableVolumeField("RecommendationOptionsConfigurationVolumeBaselineThroughput");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationVolumeBurstIOPS for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsConfigurationVolumeBurstIOPS = new ExportableVolumeField("RecommendationOptionsConfigurationVolumeBurstIOPS");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationVolumeBurstThroughput for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsConfigurationVolumeBurstThroughput = new ExportableVolumeField("RecommendationOptionsConfigurationVolumeBurstThroughput");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationVolumeSize for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsConfigurationVolumeSize = new ExportableVolumeField("RecommendationOptionsConfigurationVolumeSize");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationVolumeType for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsConfigurationVolumeType = new ExportableVolumeField("RecommendationOptionsConfigurationVolumeType");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableVolumeField("RecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableVolumeField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsMonthlyPrice for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsMonthlyPrice = new ExportableVolumeField("RecommendationOptionsMonthlyPrice");
        /// <summary>
        /// Constant RecommendationOptionsPerformanceRisk for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsPerformanceRisk = new ExportableVolumeField("RecommendationOptionsPerformanceRisk");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsSavingsOpportunityPercentage = new ExportableVolumeField("RecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant UtilizationMetricsVolumeReadBytesPerSecondMaximum for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField UtilizationMetricsVolumeReadBytesPerSecondMaximum = new ExportableVolumeField("UtilizationMetricsVolumeReadBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsVolumeReadOpsPerSecondMaximum for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField UtilizationMetricsVolumeReadOpsPerSecondMaximum = new ExportableVolumeField("UtilizationMetricsVolumeReadOpsPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsVolumeWriteBytesPerSecondMaximum for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField UtilizationMetricsVolumeWriteBytesPerSecondMaximum = new ExportableVolumeField("UtilizationMetricsVolumeWriteBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsVolumeWriteOpsPerSecondMaximum for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField UtilizationMetricsVolumeWriteOpsPerSecondMaximum = new ExportableVolumeField("UtilizationMetricsVolumeWriteOpsPerSecondMaximum");
        /// <summary>
        /// Constant VolumeArn for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField VolumeArn = new ExportableVolumeField("VolumeArn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportableVolumeField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportableVolumeField FindValue(string value)
        {
            return FindValue<ExportableVolumeField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportableVolumeField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExternalMetricsSource.
    /// </summary>
    public class ExternalMetricsSource : ConstantClass
    {

        /// <summary>
        /// Constant Datadog for ExternalMetricsSource
        /// </summary>
        public static readonly ExternalMetricsSource Datadog = new ExternalMetricsSource("Datadog");
        /// <summary>
        /// Constant Dynatrace for ExternalMetricsSource
        /// </summary>
        public static readonly ExternalMetricsSource Dynatrace = new ExternalMetricsSource("Dynatrace");
        /// <summary>
        /// Constant Instana for ExternalMetricsSource
        /// </summary>
        public static readonly ExternalMetricsSource Instana = new ExternalMetricsSource("Instana");
        /// <summary>
        /// Constant NewRelic for ExternalMetricsSource
        /// </summary>
        public static readonly ExternalMetricsSource NewRelic = new ExternalMetricsSource("NewRelic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExternalMetricsSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExternalMetricsSource FindValue(string value)
        {
            return FindValue<ExternalMetricsSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExternalMetricsSource(string value)
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
        /// Constant FindingReasonCodes for FilterName
        /// </summary>
        public static readonly FilterName FindingReasonCodes = new FilterName("FindingReasonCodes");
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
    /// Constants used for properties of type InferredWorkloadType.
    /// </summary>
    public class InferredWorkloadType : ConstantClass
    {

        /// <summary>
        /// Constant AmazonEmr for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType AmazonEmr = new InferredWorkloadType("AmazonEmr");
        /// <summary>
        /// Constant ApacheCassandra for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType ApacheCassandra = new InferredWorkloadType("ApacheCassandra");
        /// <summary>
        /// Constant ApacheHadoop for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType ApacheHadoop = new InferredWorkloadType("ApacheHadoop");
        /// <summary>
        /// Constant Kafka for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType Kafka = new InferredWorkloadType("Kafka");
        /// <summary>
        /// Constant Memcached for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType Memcached = new InferredWorkloadType("Memcached");
        /// <summary>
        /// Constant Nginx for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType Nginx = new InferredWorkloadType("Nginx");
        /// <summary>
        /// Constant PostgreSql for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType PostgreSql = new InferredWorkloadType("PostgreSql");
        /// <summary>
        /// Constant Redis for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType Redis = new InferredWorkloadType("Redis");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferredWorkloadType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferredWorkloadType FindValue(string value)
        {
            return FindValue<InferredWorkloadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferredWorkloadType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferredWorkloadTypesPreference.
    /// </summary>
    public class InferredWorkloadTypesPreference : ConstantClass
    {

        /// <summary>
        /// Constant Active for InferredWorkloadTypesPreference
        /// </summary>
        public static readonly InferredWorkloadTypesPreference Active = new InferredWorkloadTypesPreference("Active");
        /// <summary>
        /// Constant Inactive for InferredWorkloadTypesPreference
        /// </summary>
        public static readonly InferredWorkloadTypesPreference Inactive = new InferredWorkloadTypesPreference("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferredWorkloadTypesPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferredWorkloadTypesPreference FindValue(string value)
        {
            return FindValue<InferredWorkloadTypesPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferredWorkloadTypesPreference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceRecommendationFindingReasonCode.
    /// </summary>
    public class InstanceRecommendationFindingReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CPUOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode CPUOverprovisioned = new InstanceRecommendationFindingReasonCode("CPUOverprovisioned");
        /// <summary>
        /// Constant CPUUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode CPUUnderprovisioned = new InstanceRecommendationFindingReasonCode("CPUUnderprovisioned");
        /// <summary>
        /// Constant DiskIOPSOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode DiskIOPSOverprovisioned = new InstanceRecommendationFindingReasonCode("DiskIOPSOverprovisioned");
        /// <summary>
        /// Constant DiskIOPSUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode DiskIOPSUnderprovisioned = new InstanceRecommendationFindingReasonCode("DiskIOPSUnderprovisioned");
        /// <summary>
        /// Constant DiskThroughputOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode DiskThroughputOverprovisioned = new InstanceRecommendationFindingReasonCode("DiskThroughputOverprovisioned");
        /// <summary>
        /// Constant DiskThroughputUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode DiskThroughputUnderprovisioned = new InstanceRecommendationFindingReasonCode("DiskThroughputUnderprovisioned");
        /// <summary>
        /// Constant EBSIOPSOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode EBSIOPSOverprovisioned = new InstanceRecommendationFindingReasonCode("EBSIOPSOverprovisioned");
        /// <summary>
        /// Constant EBSIOPSUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode EBSIOPSUnderprovisioned = new InstanceRecommendationFindingReasonCode("EBSIOPSUnderprovisioned");
        /// <summary>
        /// Constant EBSThroughputOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode EBSThroughputOverprovisioned = new InstanceRecommendationFindingReasonCode("EBSThroughputOverprovisioned");
        /// <summary>
        /// Constant EBSThroughputUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode EBSThroughputUnderprovisioned = new InstanceRecommendationFindingReasonCode("EBSThroughputUnderprovisioned");
        /// <summary>
        /// Constant MemoryOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode MemoryOverprovisioned = new InstanceRecommendationFindingReasonCode("MemoryOverprovisioned");
        /// <summary>
        /// Constant MemoryUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode MemoryUnderprovisioned = new InstanceRecommendationFindingReasonCode("MemoryUnderprovisioned");
        /// <summary>
        /// Constant NetworkBandwidthOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode NetworkBandwidthOverprovisioned = new InstanceRecommendationFindingReasonCode("NetworkBandwidthOverprovisioned");
        /// <summary>
        /// Constant NetworkBandwidthUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode NetworkBandwidthUnderprovisioned = new InstanceRecommendationFindingReasonCode("NetworkBandwidthUnderprovisioned");
        /// <summary>
        /// Constant NetworkPPSOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode NetworkPPSOverprovisioned = new InstanceRecommendationFindingReasonCode("NetworkPPSOverprovisioned");
        /// <summary>
        /// Constant NetworkPPSUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode NetworkPPSUnderprovisioned = new InstanceRecommendationFindingReasonCode("NetworkPPSUnderprovisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceRecommendationFindingReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceRecommendationFindingReasonCode FindValue(string value)
        {
            return FindValue<InstanceRecommendationFindingReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceRecommendationFindingReasonCode(string value)
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
        /// Constant DISK_READ_BYTES_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName DISK_READ_BYTES_PER_SECOND = new MetricName("DISK_READ_BYTES_PER_SECOND");
        /// <summary>
        /// Constant DISK_READ_OPS_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName DISK_READ_OPS_PER_SECOND = new MetricName("DISK_READ_OPS_PER_SECOND");
        /// <summary>
        /// Constant DISK_WRITE_BYTES_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName DISK_WRITE_BYTES_PER_SECOND = new MetricName("DISK_WRITE_BYTES_PER_SECOND");
        /// <summary>
        /// Constant DISK_WRITE_OPS_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName DISK_WRITE_OPS_PER_SECOND = new MetricName("DISK_WRITE_OPS_PER_SECOND");
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
        /// Constant NETWORK_IN_BYTES_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName NETWORK_IN_BYTES_PER_SECOND = new MetricName("NETWORK_IN_BYTES_PER_SECOND");
        /// <summary>
        /// Constant NETWORK_OUT_BYTES_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName NETWORK_OUT_BYTES_PER_SECOND = new MetricName("NETWORK_OUT_BYTES_PER_SECOND");
        /// <summary>
        /// Constant NETWORK_PACKETS_IN_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName NETWORK_PACKETS_IN_PER_SECOND = new MetricName("NETWORK_PACKETS_IN_PER_SECOND");
        /// <summary>
        /// Constant NETWORK_PACKETS_OUT_PER_SECOND for MetricName
        /// </summary>
        public static readonly MetricName NETWORK_PACKETS_OUT_PER_SECOND = new MetricName("NETWORK_PACKETS_OUT_PER_SECOND");

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
    /// Constants used for properties of type MigrationEffort.
    /// </summary>
    public class MigrationEffort : ConstantClass
    {

        /// <summary>
        /// Constant High for MigrationEffort
        /// </summary>
        public static readonly MigrationEffort High = new MigrationEffort("High");
        /// <summary>
        /// Constant Low for MigrationEffort
        /// </summary>
        public static readonly MigrationEffort Low = new MigrationEffort("Low");
        /// <summary>
        /// Constant Medium for MigrationEffort
        /// </summary>
        public static readonly MigrationEffort Medium = new MigrationEffort("Medium");
        /// <summary>
        /// Constant VeryLow for MigrationEffort
        /// </summary>
        public static readonly MigrationEffort VeryLow = new MigrationEffort("VeryLow");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationEffort(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationEffort FindValue(string value)
        {
            return FindValue<MigrationEffort>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationEffort(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformDifference.
    /// </summary>
    public class PlatformDifference : ConstantClass
    {

        /// <summary>
        /// Constant Architecture for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference Architecture = new PlatformDifference("Architecture");
        /// <summary>
        /// Constant Hypervisor for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference Hypervisor = new PlatformDifference("Hypervisor");
        /// <summary>
        /// Constant InstanceStoreAvailability for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference InstanceStoreAvailability = new PlatformDifference("InstanceStoreAvailability");
        /// <summary>
        /// Constant NetworkInterface for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference NetworkInterface = new PlatformDifference("NetworkInterface");
        /// <summary>
        /// Constant StorageInterface for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference StorageInterface = new PlatformDifference("StorageInterface");
        /// <summary>
        /// Constant VirtualizationType for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference VirtualizationType = new PlatformDifference("VirtualizationType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformDifference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformDifference FindValue(string value)
        {
            return FindValue<PlatformDifference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformDifference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationPreferenceName.
    /// </summary>
    public class RecommendationPreferenceName : ConstantClass
    {

        /// <summary>
        /// Constant EnhancedInfrastructureMetrics for RecommendationPreferenceName
        /// </summary>
        public static readonly RecommendationPreferenceName EnhancedInfrastructureMetrics = new RecommendationPreferenceName("EnhancedInfrastructureMetrics");
        /// <summary>
        /// Constant ExternalMetricsPreference for RecommendationPreferenceName
        /// </summary>
        public static readonly RecommendationPreferenceName ExternalMetricsPreference = new RecommendationPreferenceName("ExternalMetricsPreference");
        /// <summary>
        /// Constant InferredWorkloadTypes for RecommendationPreferenceName
        /// </summary>
        public static readonly RecommendationPreferenceName InferredWorkloadTypes = new RecommendationPreferenceName("InferredWorkloadTypes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationPreferenceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationPreferenceName FindValue(string value)
        {
            return FindValue<RecommendationPreferenceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationPreferenceName(string value)
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
        /// Constant EcsService for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType EcsService = new RecommendationSourceType("EcsService");
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
        /// Constant EbsVolume for ResourceType
        /// </summary>
        public static readonly ResourceType EbsVolume = new ResourceType("EbsVolume");
        /// <summary>
        /// Constant Ec2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType Ec2Instance = new ResourceType("Ec2Instance");
        /// <summary>
        /// Constant EcsService for ResourceType
        /// </summary>
        public static readonly ResourceType EcsService = new ResourceType("EcsService");
        /// <summary>
        /// Constant LambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType LambdaFunction = new ResourceType("LambdaFunction");
        /// <summary>
        /// Constant NotApplicable for ResourceType
        /// </summary>
        public static readonly ResourceType NotApplicable = new ResourceType("NotApplicable");

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
    /// Constants used for properties of type ScopeName.
    /// </summary>
    public class ScopeName : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ScopeName
        /// </summary>
        public static readonly ScopeName AccountId = new ScopeName("AccountId");
        /// <summary>
        /// Constant Organization for ScopeName
        /// </summary>
        public static readonly ScopeName Organization = new ScopeName("Organization");
        /// <summary>
        /// Constant ResourceArn for ScopeName
        /// </summary>
        public static readonly ScopeName ResourceArn = new ScopeName("ResourceArn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScopeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScopeName FindValue(string value)
        {
            return FindValue<ScopeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScopeName(string value)
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