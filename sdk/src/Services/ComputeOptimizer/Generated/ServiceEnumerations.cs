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
    /// Constants used for properties of type AllocationStrategy.
    /// </summary>
    public class AllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant LowestPrice for AllocationStrategy
        /// </summary>
        public static readonly AllocationStrategy LowestPrice = new AllocationStrategy("LowestPrice");
        /// <summary>
        /// Constant Prioritized for AllocationStrategy
        /// </summary>
        public static readonly AllocationStrategy Prioritized = new AllocationStrategy("Prioritized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllocationStrategy FindValue(string value)
        {
            return FindValue<AllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AsgType.
    /// </summary>
    public class AsgType : ConstantClass
    {

        /// <summary>
        /// Constant MixedInstanceTypes for AsgType
        /// </summary>
        public static readonly AsgType MixedInstanceTypes = new AsgType("MixedInstanceTypes");
        /// <summary>
        /// Constant SingleInstanceType for AsgType
        /// </summary>
        public static readonly AsgType SingleInstanceType = new AsgType("SingleInstanceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AsgType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AsgType FindValue(string value)
        {
            return FindValue<AsgType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AsgType(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type CustomizableMetricHeadroom.
    /// </summary>
    public class CustomizableMetricHeadroom : ConstantClass
    {

        /// <summary>
        /// Constant PERCENT_0 for CustomizableMetricHeadroom
        /// </summary>
        public static readonly CustomizableMetricHeadroom PERCENT_0 = new CustomizableMetricHeadroom("PERCENT_0");
        /// <summary>
        /// Constant PERCENT_10 for CustomizableMetricHeadroom
        /// </summary>
        public static readonly CustomizableMetricHeadroom PERCENT_10 = new CustomizableMetricHeadroom("PERCENT_10");
        /// <summary>
        /// Constant PERCENT_20 for CustomizableMetricHeadroom
        /// </summary>
        public static readonly CustomizableMetricHeadroom PERCENT_20 = new CustomizableMetricHeadroom("PERCENT_20");
        /// <summary>
        /// Constant PERCENT_30 for CustomizableMetricHeadroom
        /// </summary>
        public static readonly CustomizableMetricHeadroom PERCENT_30 = new CustomizableMetricHeadroom("PERCENT_30");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomizableMetricHeadroom(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomizableMetricHeadroom FindValue(string value)
        {
            return FindValue<CustomizableMetricHeadroom>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomizableMetricHeadroom(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomizableMetricName.
    /// </summary>
    public class CustomizableMetricName : ConstantClass
    {

        /// <summary>
        /// Constant CpuUtilization for CustomizableMetricName
        /// </summary>
        public static readonly CustomizableMetricName CpuUtilization = new CustomizableMetricName("CpuUtilization");
        /// <summary>
        /// Constant MemoryUtilization for CustomizableMetricName
        /// </summary>
        public static readonly CustomizableMetricName MemoryUtilization = new CustomizableMetricName("MemoryUtilization");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomizableMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomizableMetricName FindValue(string value)
        {
            return FindValue<CustomizableMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomizableMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomizableMetricThreshold.
    /// </summary>
    public class CustomizableMetricThreshold : ConstantClass
    {

        /// <summary>
        /// Constant P90 for CustomizableMetricThreshold
        /// </summary>
        public static readonly CustomizableMetricThreshold P90 = new CustomizableMetricThreshold("P90");
        /// <summary>
        /// Constant P95 for CustomizableMetricThreshold
        /// </summary>
        public static readonly CustomizableMetricThreshold P95 = new CustomizableMetricThreshold("P95");
        /// <summary>
        /// Constant P99_5 for CustomizableMetricThreshold
        /// </summary>
        public static readonly CustomizableMetricThreshold P99_5 = new CustomizableMetricThreshold("P99_5");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomizableMetricThreshold(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomizableMetricThreshold FindValue(string value)
        {
            return FindValue<CustomizableMetricThreshold>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomizableMetricThreshold(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Dimension.
    /// </summary>
    public class Dimension : ConstantClass
    {

        /// <summary>
        /// Constant SavingsValue for Dimension
        /// </summary>
        public static readonly Dimension SavingsValue = new Dimension("SavingsValue");
        /// <summary>
        /// Constant SavingsValueAfterDiscount for Dimension
        /// </summary>
        public static readonly Dimension SavingsValueAfterDiscount = new Dimension("SavingsValueAfterDiscount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Dimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Dimension FindValue(string value)
        {
            return FindValue<Dimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Dimension(string value)
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
    /// Constants used for properties of type EBSSavingsEstimationModeSource.
    /// </summary>
    public class EBSSavingsEstimationModeSource : ConstantClass
    {

        /// <summary>
        /// Constant CostExplorerRightsizing for EBSSavingsEstimationModeSource
        /// </summary>
        public static readonly EBSSavingsEstimationModeSource CostExplorerRightsizing = new EBSSavingsEstimationModeSource("CostExplorerRightsizing");
        /// <summary>
        /// Constant CostOptimizationHub for EBSSavingsEstimationModeSource
        /// </summary>
        public static readonly EBSSavingsEstimationModeSource CostOptimizationHub = new EBSSavingsEstimationModeSource("CostOptimizationHub");
        /// <summary>
        /// Constant PublicPricing for EBSSavingsEstimationModeSource
        /// </summary>
        public static readonly EBSSavingsEstimationModeSource PublicPricing = new EBSSavingsEstimationModeSource("PublicPricing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EBSSavingsEstimationModeSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EBSSavingsEstimationModeSource FindValue(string value)
        {
            return FindValue<EBSSavingsEstimationModeSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EBSSavingsEstimationModeSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ECSSavingsEstimationModeSource.
    /// </summary>
    public class ECSSavingsEstimationModeSource : ConstantClass
    {

        /// <summary>
        /// Constant CostExplorerRightsizing for ECSSavingsEstimationModeSource
        /// </summary>
        public static readonly ECSSavingsEstimationModeSource CostExplorerRightsizing = new ECSSavingsEstimationModeSource("CostExplorerRightsizing");
        /// <summary>
        /// Constant CostOptimizationHub for ECSSavingsEstimationModeSource
        /// </summary>
        public static readonly ECSSavingsEstimationModeSource CostOptimizationHub = new ECSSavingsEstimationModeSource("CostOptimizationHub");
        /// <summary>
        /// Constant PublicPricing for ECSSavingsEstimationModeSource
        /// </summary>
        public static readonly ECSSavingsEstimationModeSource PublicPricing = new ECSSavingsEstimationModeSource("PublicPricing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ECSSavingsEstimationModeSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ECSSavingsEstimationModeSource FindValue(string value)
        {
            return FindValue<ECSSavingsEstimationModeSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ECSSavingsEstimationModeSource(string value)
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
        /// Constant CurrentConfigurationAllocationStrategy for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentConfigurationAllocationStrategy = new ExportableAutoScalingGroupField("CurrentConfigurationAllocationStrategy");
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
        /// Constant CurrentConfigurationMixedInstanceTypes for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentConfigurationMixedInstanceTypes = new ExportableAutoScalingGroupField("CurrentConfigurationMixedInstanceTypes");
        /// <summary>
        /// Constant CurrentConfigurationType for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentConfigurationType = new ExportableAutoScalingGroupField("CurrentConfigurationType");
        /// <summary>
        /// Constant CurrentInstanceGpuInfo for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField CurrentInstanceGpuInfo = new ExportableAutoScalingGroupField("CurrentInstanceGpuInfo");
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
        /// Constant EffectiveRecommendationPreferencesLookBackPeriod for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField EffectiveRecommendationPreferencesLookBackPeriod = new ExportableAutoScalingGroupField("EffectiveRecommendationPreferencesLookBackPeriod");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesPreferredResources for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField EffectiveRecommendationPreferencesPreferredResources = new ExportableAutoScalingGroupField("EffectiveRecommendationPreferencesPreferredResources");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesSavingsEstimationMode for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField EffectiveRecommendationPreferencesSavingsEstimationMode = new ExportableAutoScalingGroupField("EffectiveRecommendationPreferencesSavingsEstimationMode");
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
        /// Constant RecommendationOptionsConfigurationAllocationStrategy for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationAllocationStrategy = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationAllocationStrategy");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationDesiredCapacity for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationDesiredCapacity = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationDesiredCapacity");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationEstimatedInstanceHourReductionPercentage for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationEstimatedInstanceHourReductionPercentage = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationEstimatedInstanceHourReductionPercentage");
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
        /// Constant RecommendationOptionsConfigurationMixedInstanceTypes for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationMixedInstanceTypes = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationMixedInstanceTypes");
        /// <summary>
        /// Constant RecommendationOptionsConfigurationType for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsConfigurationType = new ExportableAutoScalingGroupField("RecommendationOptionsConfigurationType");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableAutoScalingGroupField("RecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts = new ExportableAutoScalingGroupField("RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableAutoScalingGroupField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts = new ExportableAutoScalingGroupField("RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts");
        /// <summary>
        /// Constant RecommendationOptionsInstanceGpuInfo for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsInstanceGpuInfo = new ExportableAutoScalingGroupField("RecommendationOptionsInstanceGpuInfo");
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
        /// Constant RecommendationOptionsProjectedUtilizationMetricsGpuMemoryPercentageMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsProjectedUtilizationMetricsGpuMemoryPercentageMaximum = new ExportableAutoScalingGroupField("RecommendationOptionsProjectedUtilizationMetricsGpuMemoryPercentageMaximum");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsGpuPercentageMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsProjectedUtilizationMetricsGpuPercentageMaximum = new ExportableAutoScalingGroupField("RecommendationOptionsProjectedUtilizationMetricsGpuPercentageMaximum");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum = new ExportableAutoScalingGroupField("RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage = new ExportableAutoScalingGroupField("RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage");
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
        /// Constant UtilizationMetricsGpuMemoryPercentageMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsGpuMemoryPercentageMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsGpuMemoryPercentageMaximum");
        /// <summary>
        /// Constant UtilizationMetricsGpuPercentageMaximum for ExportableAutoScalingGroupField
        /// </summary>
        public static readonly ExportableAutoScalingGroupField UtilizationMetricsGpuPercentageMaximum = new ExportableAutoScalingGroupField("UtilizationMetricsGpuPercentageMaximum");
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
        /// Constant EffectiveRecommendationPreferencesSavingsEstimationMode for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField EffectiveRecommendationPreferencesSavingsEstimationMode = new ExportableECSServiceField("EffectiveRecommendationPreferencesSavingsEstimationMode");
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
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts = new ExportableECSServiceField("RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableECSServiceField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts = new ExportableECSServiceField("RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts");
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
        /// Constant RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage = new ExportableECSServiceField("RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField RecommendationOptionsSavingsOpportunityPercentage = new ExportableECSServiceField("RecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant ServiceArn for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField ServiceArn = new ExportableECSServiceField("ServiceArn");
        /// <summary>
        /// Constant Tags for ExportableECSServiceField
        /// </summary>
        public static readonly ExportableECSServiceField Tags = new ExportableECSServiceField("Tags");
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
    /// Constants used for properties of type ExportableIdleField.
    /// </summary>
    public class ExportableIdleField : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField AccountId = new ExportableIdleField("AccountId");
        /// <summary>
        /// Constant Finding for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField Finding = new ExportableIdleField("Finding");
        /// <summary>
        /// Constant FindingDescription for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField FindingDescription = new ExportableIdleField("FindingDescription");
        /// <summary>
        /// Constant LastRefreshTimestamp for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField LastRefreshTimestamp = new ExportableIdleField("LastRefreshTimestamp");
        /// <summary>
        /// Constant LookbackPeriodInDays for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField LookbackPeriodInDays = new ExportableIdleField("LookbackPeriodInDays");
        /// <summary>
        /// Constant ResourceArn for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField ResourceArn = new ExportableIdleField("ResourceArn");
        /// <summary>
        /// Constant ResourceId for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField ResourceId = new ExportableIdleField("ResourceId");
        /// <summary>
        /// Constant ResourceType for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField ResourceType = new ExportableIdleField("ResourceType");
        /// <summary>
        /// Constant SavingsOpportunity for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField SavingsOpportunity = new ExportableIdleField("SavingsOpportunity");
        /// <summary>
        /// Constant SavingsOpportunityAfterDiscount for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField SavingsOpportunityAfterDiscount = new ExportableIdleField("SavingsOpportunityAfterDiscount");
        /// <summary>
        /// Constant Tags for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField Tags = new ExportableIdleField("Tags");
        /// <summary>
        /// Constant UtilizationMetricsCpuMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsCpuMaximum = new ExportableIdleField("UtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant UtilizationMetricsDatabaseConnectionsMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsDatabaseConnectionsMaximum = new ExportableIdleField("UtilizationMetricsDatabaseConnectionsMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEBSVolumeReadIOPSMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsEBSVolumeReadIOPSMaximum = new ExportableIdleField("UtilizationMetricsEBSVolumeReadIOPSMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEBSVolumeWriteIOPSMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsEBSVolumeWriteIOPSMaximum = new ExportableIdleField("UtilizationMetricsEBSVolumeWriteIOPSMaximum");
        /// <summary>
        /// Constant UtilizationMetricsMemoryMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsMemoryMaximum = new ExportableIdleField("UtilizationMetricsMemoryMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkInBytesPerSecondMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsNetworkInBytesPerSecondMaximum = new ExportableIdleField("UtilizationMetricsNetworkInBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkOutBytesPerSecondMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsNetworkOutBytesPerSecondMaximum = new ExportableIdleField("UtilizationMetricsNetworkOutBytesPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsVolumeReadOpsPerSecondMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsVolumeReadOpsPerSecondMaximum = new ExportableIdleField("UtilizationMetricsVolumeReadOpsPerSecondMaximum");
        /// <summary>
        /// Constant UtilizationMetricsVolumeWriteOpsPerSecondMaximum for ExportableIdleField
        /// </summary>
        public static readonly ExportableIdleField UtilizationMetricsVolumeWriteOpsPerSecondMaximum = new ExportableIdleField("UtilizationMetricsVolumeWriteOpsPerSecondMaximum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportableIdleField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportableIdleField FindValue(string value)
        {
            return FindValue<ExportableIdleField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportableIdleField(string value)
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
        /// Constant CurrentInstanceGpuInfo for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField CurrentInstanceGpuInfo = new ExportableInstanceField("CurrentInstanceGpuInfo");
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
        /// Constant EffectiveRecommendationPreferencesLookBackPeriod for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField EffectiveRecommendationPreferencesLookBackPeriod = new ExportableInstanceField("EffectiveRecommendationPreferencesLookBackPeriod");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesPreferredResources for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField EffectiveRecommendationPreferencesPreferredResources = new ExportableInstanceField("EffectiveRecommendationPreferencesPreferredResources");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesSavingsEstimationMode for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField EffectiveRecommendationPreferencesSavingsEstimationMode = new ExportableInstanceField("EffectiveRecommendationPreferencesSavingsEstimationMode");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesUtilizationPreferences for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField EffectiveRecommendationPreferencesUtilizationPreferences = new ExportableInstanceField("EffectiveRecommendationPreferencesUtilizationPreferences");
        /// <summary>
        /// Constant ExternalMetricStatusCode for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField ExternalMetricStatusCode = new ExportableInstanceField("ExternalMetricStatusCode");
        /// <summary>
        /// Constant ExternalMetricStatusReason for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField ExternalMetricStatusReason = new ExportableInstanceField("ExternalMetricStatusReason");
        /// <summary>
        /// Constant Finding for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField Finding = new ExportableInstanceField("Finding");
        /// <summary>
        /// Constant FindingReasonCodes for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField FindingReasonCodes = new ExportableInstanceField("FindingReasonCodes");
        /// <summary>
        /// Constant Idle for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField Idle = new ExportableInstanceField("Idle");
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
        /// Constant InstanceState for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField InstanceState = new ExportableInstanceField("InstanceState");
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
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts = new ExportableInstanceField("RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableInstanceField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts = new ExportableInstanceField("RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts");
        /// <summary>
        /// Constant RecommendationOptionsInstanceGpuInfo for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsInstanceGpuInfo = new ExportableInstanceField("RecommendationOptionsInstanceGpuInfo");
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
        /// Constant RecommendationOptionsProjectedUtilizationMetricsGpuMemoryPercentageMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsProjectedUtilizationMetricsGpuMemoryPercentageMaximum = new ExportableInstanceField("RecommendationOptionsProjectedUtilizationMetricsGpuMemoryPercentageMaximum");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsGpuPercentageMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsProjectedUtilizationMetricsGpuPercentageMaximum = new ExportableInstanceField("RecommendationOptionsProjectedUtilizationMetricsGpuPercentageMaximum");
        /// <summary>
        /// Constant RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum = new ExportableInstanceField("RecommendationOptionsProjectedUtilizationMetricsMemoryMaximum");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage = new ExportableInstanceField("RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage");
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
        /// Constant Tags for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField Tags = new ExportableInstanceField("Tags");
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
        /// Constant UtilizationMetricsGpuMemoryPercentageMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsGpuMemoryPercentageMaximum = new ExportableInstanceField("UtilizationMetricsGpuMemoryPercentageMaximum");
        /// <summary>
        /// Constant UtilizationMetricsGpuPercentageMaximum for ExportableInstanceField
        /// </summary>
        public static readonly ExportableInstanceField UtilizationMetricsGpuPercentageMaximum = new ExportableInstanceField("UtilizationMetricsGpuPercentageMaximum");
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
        /// Constant EffectiveRecommendationPreferencesSavingsEstimationMode for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField EffectiveRecommendationPreferencesSavingsEstimationMode = new ExportableLambdaFunctionField("EffectiveRecommendationPreferencesSavingsEstimationMode");
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
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts = new ExportableLambdaFunctionField("RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableLambdaFunctionField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts = new ExportableLambdaFunctionField("RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts");
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
        /// Constant RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage = new ExportableLambdaFunctionField("RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField RecommendationOptionsSavingsOpportunityPercentage = new ExportableLambdaFunctionField("RecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant Tags for ExportableLambdaFunctionField
        /// </summary>
        public static readonly ExportableLambdaFunctionField Tags = new ExportableLambdaFunctionField("Tags");
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
    /// Constants used for properties of type ExportableLicenseField.
    /// </summary>
    public class ExportableLicenseField : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField AccountId = new ExportableLicenseField("AccountId");
        /// <summary>
        /// Constant CurrentLicenseConfigurationInstanceType for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField CurrentLicenseConfigurationInstanceType = new ExportableLicenseField("CurrentLicenseConfigurationInstanceType");
        /// <summary>
        /// Constant CurrentLicenseConfigurationLicenseEdition for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField CurrentLicenseConfigurationLicenseEdition = new ExportableLicenseField("CurrentLicenseConfigurationLicenseEdition");
        /// <summary>
        /// Constant CurrentLicenseConfigurationLicenseModel for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField CurrentLicenseConfigurationLicenseModel = new ExportableLicenseField("CurrentLicenseConfigurationLicenseModel");
        /// <summary>
        /// Constant CurrentLicenseConfigurationLicenseName for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField CurrentLicenseConfigurationLicenseName = new ExportableLicenseField("CurrentLicenseConfigurationLicenseName");
        /// <summary>
        /// Constant CurrentLicenseConfigurationLicenseVersion for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField CurrentLicenseConfigurationLicenseVersion = new ExportableLicenseField("CurrentLicenseConfigurationLicenseVersion");
        /// <summary>
        /// Constant CurrentLicenseConfigurationMetricsSource for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField CurrentLicenseConfigurationMetricsSource = new ExportableLicenseField("CurrentLicenseConfigurationMetricsSource");
        /// <summary>
        /// Constant CurrentLicenseConfigurationNumberOfCores for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField CurrentLicenseConfigurationNumberOfCores = new ExportableLicenseField("CurrentLicenseConfigurationNumberOfCores");
        /// <summary>
        /// Constant CurrentLicenseConfigurationOperatingSystem for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField CurrentLicenseConfigurationOperatingSystem = new ExportableLicenseField("CurrentLicenseConfigurationOperatingSystem");
        /// <summary>
        /// Constant Finding for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField Finding = new ExportableLicenseField("Finding");
        /// <summary>
        /// Constant FindingReasonCodes for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField FindingReasonCodes = new ExportableLicenseField("FindingReasonCodes");
        /// <summary>
        /// Constant LastRefreshTimestamp for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField LastRefreshTimestamp = new ExportableLicenseField("LastRefreshTimestamp");
        /// <summary>
        /// Constant LookbackPeriodInDays for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField LookbackPeriodInDays = new ExportableLicenseField("LookbackPeriodInDays");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField RecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableLicenseField("RecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableLicenseField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsLicenseEdition for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField RecommendationOptionsLicenseEdition = new ExportableLicenseField("RecommendationOptionsLicenseEdition");
        /// <summary>
        /// Constant RecommendationOptionsLicenseModel for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField RecommendationOptionsLicenseModel = new ExportableLicenseField("RecommendationOptionsLicenseModel");
        /// <summary>
        /// Constant RecommendationOptionsOperatingSystem for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField RecommendationOptionsOperatingSystem = new ExportableLicenseField("RecommendationOptionsOperatingSystem");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField RecommendationOptionsSavingsOpportunityPercentage = new ExportableLicenseField("RecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant ResourceArn for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField ResourceArn = new ExportableLicenseField("ResourceArn");
        /// <summary>
        /// Constant Tags for ExportableLicenseField
        /// </summary>
        public static readonly ExportableLicenseField Tags = new ExportableLicenseField("Tags");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportableLicenseField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportableLicenseField FindValue(string value)
        {
            return FindValue<ExportableLicenseField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportableLicenseField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportableRDSDBField.
    /// </summary>
    public class ExportableRDSDBField : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField AccountId = new ExportableRDSDBField("AccountId");
        /// <summary>
        /// Constant ClusterWriter for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField ClusterWriter = new ExportableRDSDBField("ClusterWriter");
        /// <summary>
        /// Constant CurrentDBInstanceClass for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentDBInstanceClass = new ExportableRDSDBField("CurrentDBInstanceClass");
        /// <summary>
        /// Constant CurrentInstanceOnDemandHourlyPrice for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentInstanceOnDemandHourlyPrice = new ExportableRDSDBField("CurrentInstanceOnDemandHourlyPrice");
        /// <summary>
        /// Constant CurrentInstancePerformanceRisk for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentInstancePerformanceRisk = new ExportableRDSDBField("CurrentInstancePerformanceRisk");
        /// <summary>
        /// Constant CurrentStorageConfigurationAllocatedStorage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageConfigurationAllocatedStorage = new ExportableRDSDBField("CurrentStorageConfigurationAllocatedStorage");
        /// <summary>
        /// Constant CurrentStorageConfigurationIOPS for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageConfigurationIOPS = new ExportableRDSDBField("CurrentStorageConfigurationIOPS");
        /// <summary>
        /// Constant CurrentStorageConfigurationMaxAllocatedStorage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageConfigurationMaxAllocatedStorage = new ExportableRDSDBField("CurrentStorageConfigurationMaxAllocatedStorage");
        /// <summary>
        /// Constant CurrentStorageConfigurationStorageThroughput for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageConfigurationStorageThroughput = new ExportableRDSDBField("CurrentStorageConfigurationStorageThroughput");
        /// <summary>
        /// Constant CurrentStorageConfigurationStorageType for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageConfigurationStorageType = new ExportableRDSDBField("CurrentStorageConfigurationStorageType");
        /// <summary>
        /// Constant CurrentStorageEstimatedClusterInstanceOnDemandMonthlyCost for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageEstimatedClusterInstanceOnDemandMonthlyCost = new ExportableRDSDBField("CurrentStorageEstimatedClusterInstanceOnDemandMonthlyCost");
        /// <summary>
        /// Constant CurrentStorageEstimatedClusterStorageIOOnDemandMonthlyCost for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageEstimatedClusterStorageIOOnDemandMonthlyCost = new ExportableRDSDBField("CurrentStorageEstimatedClusterStorageIOOnDemandMonthlyCost");
        /// <summary>
        /// Constant CurrentStorageEstimatedClusterStorageOnDemandMonthlyCost for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageEstimatedClusterStorageOnDemandMonthlyCost = new ExportableRDSDBField("CurrentStorageEstimatedClusterStorageOnDemandMonthlyCost");
        /// <summary>
        /// Constant CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation = new ExportableRDSDBField("CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation");
        /// <summary>
        /// Constant CurrentStorageOnDemandMonthlyPrice for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField CurrentStorageOnDemandMonthlyPrice = new ExportableRDSDBField("CurrentStorageOnDemandMonthlyPrice");
        /// <summary>
        /// Constant DBClusterIdentifier for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField DBClusterIdentifier = new ExportableRDSDBField("DBClusterIdentifier");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesCpuVendorArchitectures for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField EffectiveRecommendationPreferencesCpuVendorArchitectures = new ExportableRDSDBField("EffectiveRecommendationPreferencesCpuVendorArchitectures");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics = new ExportableRDSDBField("EffectiveRecommendationPreferencesEnhancedInfrastructureMetrics");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesLookBackPeriod for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField EffectiveRecommendationPreferencesLookBackPeriod = new ExportableRDSDBField("EffectiveRecommendationPreferencesLookBackPeriod");
        /// <summary>
        /// Constant EffectiveRecommendationPreferencesSavingsEstimationMode for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField EffectiveRecommendationPreferencesSavingsEstimationMode = new ExportableRDSDBField("EffectiveRecommendationPreferencesSavingsEstimationMode");
        /// <summary>
        /// Constant Engine for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField Engine = new ExportableRDSDBField("Engine");
        /// <summary>
        /// Constant EngineVersion for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField EngineVersion = new ExportableRDSDBField("EngineVersion");
        /// <summary>
        /// Constant Idle for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField Idle = new ExportableRDSDBField("Idle");
        /// <summary>
        /// Constant InstanceFinding for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceFinding = new ExportableRDSDBField("InstanceFinding");
        /// <summary>
        /// Constant InstanceFindingReasonCodes for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceFindingReasonCodes = new ExportableRDSDBField("InstanceFindingReasonCodes");
        /// <summary>
        /// Constant InstanceRecommendationOptionsDBInstanceClass for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsDBInstanceClass = new ExportableRDSDBField("InstanceRecommendationOptionsDBInstanceClass");
        /// <summary>
        /// Constant InstanceRecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableRDSDBField("InstanceRecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant InstanceRecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts = new ExportableRDSDBField("InstanceRecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts");
        /// <summary>
        /// Constant InstanceRecommendationOptionsEstimatedMonthlySavingsValue for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsEstimatedMonthlySavingsValue = new ExportableRDSDBField("InstanceRecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant InstanceRecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts = new ExportableRDSDBField("InstanceRecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts");
        /// <summary>
        /// Constant InstanceRecommendationOptionsInstanceOnDemandHourlyPrice for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsInstanceOnDemandHourlyPrice = new ExportableRDSDBField("InstanceRecommendationOptionsInstanceOnDemandHourlyPrice");
        /// <summary>
        /// Constant InstanceRecommendationOptionsPerformanceRisk for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsPerformanceRisk = new ExportableRDSDBField("InstanceRecommendationOptionsPerformanceRisk");
        /// <summary>
        /// Constant InstanceRecommendationOptionsProjectedUtilizationMetricsCpuMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsProjectedUtilizationMetricsCpuMaximum = new ExportableRDSDBField("InstanceRecommendationOptionsProjectedUtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant InstanceRecommendationOptionsRank for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsRank = new ExportableRDSDBField("InstanceRecommendationOptionsRank");
        /// <summary>
        /// Constant InstanceRecommendationOptionsSavingsOpportunityAfterDiscountsPercentage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsSavingsOpportunityAfterDiscountsPercentage = new ExportableRDSDBField("InstanceRecommendationOptionsSavingsOpportunityAfterDiscountsPercentage");
        /// <summary>
        /// Constant InstanceRecommendationOptionsSavingsOpportunityPercentage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField InstanceRecommendationOptionsSavingsOpportunityPercentage = new ExportableRDSDBField("InstanceRecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant LastRefreshTimestamp for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField LastRefreshTimestamp = new ExportableRDSDBField("LastRefreshTimestamp");
        /// <summary>
        /// Constant LookbackPeriodInDays for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField LookbackPeriodInDays = new ExportableRDSDBField("LookbackPeriodInDays");
        /// <summary>
        /// Constant MultiAZDBInstance for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField MultiAZDBInstance = new ExportableRDSDBField("MultiAZDBInstance");
        /// <summary>
        /// Constant PromotionTier for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField PromotionTier = new ExportableRDSDBField("PromotionTier");
        /// <summary>
        /// Constant ResourceArn for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField ResourceArn = new ExportableRDSDBField("ResourceArn");
        /// <summary>
        /// Constant StorageFinding for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageFinding = new ExportableRDSDBField("StorageFinding");
        /// <summary>
        /// Constant StorageFindingReasonCodes for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageFindingReasonCodes = new ExportableRDSDBField("StorageFindingReasonCodes");
        /// <summary>
        /// Constant StorageRecommendationOptionsAllocatedStorage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsAllocatedStorage = new ExportableRDSDBField("StorageRecommendationOptionsAllocatedStorage");
        /// <summary>
        /// Constant StorageRecommendationOptionsEstimatedClusterInstanceOnDemandMonthlyCost for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsEstimatedClusterInstanceOnDemandMonthlyCost = new ExportableRDSDBField("StorageRecommendationOptionsEstimatedClusterInstanceOnDemandMonthlyCost");
        /// <summary>
        /// Constant StorageRecommendationOptionsEstimatedClusterStorageIOOnDemandMonthlyCost for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsEstimatedClusterStorageIOOnDemandMonthlyCost = new ExportableRDSDBField("StorageRecommendationOptionsEstimatedClusterStorageIOOnDemandMonthlyCost");
        /// <summary>
        /// Constant StorageRecommendationOptionsEstimatedClusterStorageOnDemandMonthlyCost for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsEstimatedClusterStorageOnDemandMonthlyCost = new ExportableRDSDBField("StorageRecommendationOptionsEstimatedClusterStorageOnDemandMonthlyCost");
        /// <summary>
        /// Constant StorageRecommendationOptionsEstimatedMonthlySavingsCurrency for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsEstimatedMonthlySavingsCurrency = new ExportableRDSDBField("StorageRecommendationOptionsEstimatedMonthlySavingsCurrency");
        /// <summary>
        /// Constant StorageRecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts = new ExportableRDSDBField("StorageRecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts");
        /// <summary>
        /// Constant StorageRecommendationOptionsEstimatedMonthlySavingsValue for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsEstimatedMonthlySavingsValue = new ExportableRDSDBField("StorageRecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant StorageRecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts = new ExportableRDSDBField("StorageRecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts");
        /// <summary>
        /// Constant StorageRecommendationOptionsEstimatedMonthlyVolumeIOPsCostVariation for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsEstimatedMonthlyVolumeIOPsCostVariation = new ExportableRDSDBField("StorageRecommendationOptionsEstimatedMonthlyVolumeIOPsCostVariation");
        /// <summary>
        /// Constant StorageRecommendationOptionsIOPS for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsIOPS = new ExportableRDSDBField("StorageRecommendationOptionsIOPS");
        /// <summary>
        /// Constant StorageRecommendationOptionsMaxAllocatedStorage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsMaxAllocatedStorage = new ExportableRDSDBField("StorageRecommendationOptionsMaxAllocatedStorage");
        /// <summary>
        /// Constant StorageRecommendationOptionsOnDemandMonthlyPrice for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsOnDemandMonthlyPrice = new ExportableRDSDBField("StorageRecommendationOptionsOnDemandMonthlyPrice");
        /// <summary>
        /// Constant StorageRecommendationOptionsRank for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsRank = new ExportableRDSDBField("StorageRecommendationOptionsRank");
        /// <summary>
        /// Constant StorageRecommendationOptionsSavingsOpportunityAfterDiscountsPercentage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsSavingsOpportunityAfterDiscountsPercentage = new ExportableRDSDBField("StorageRecommendationOptionsSavingsOpportunityAfterDiscountsPercentage");
        /// <summary>
        /// Constant StorageRecommendationOptionsSavingsOpportunityPercentage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsSavingsOpportunityPercentage = new ExportableRDSDBField("StorageRecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant StorageRecommendationOptionsStorageThroughput for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsStorageThroughput = new ExportableRDSDBField("StorageRecommendationOptionsStorageThroughput");
        /// <summary>
        /// Constant StorageRecommendationOptionsStorageType for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField StorageRecommendationOptionsStorageType = new ExportableRDSDBField("StorageRecommendationOptionsStorageType");
        /// <summary>
        /// Constant Tags for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField Tags = new ExportableRDSDBField("Tags");
        /// <summary>
        /// Constant UtilizationMetricsAuroraMemoryHealthStateMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsAuroraMemoryHealthStateMaximum = new ExportableRDSDBField("UtilizationMetricsAuroraMemoryHealthStateMaximum");
        /// <summary>
        /// Constant UtilizationMetricsAuroraMemoryNumDeclinedSqlTotalMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsAuroraMemoryNumDeclinedSqlTotalMaximum = new ExportableRDSDBField("UtilizationMetricsAuroraMemoryNumDeclinedSqlTotalMaximum");
        /// <summary>
        /// Constant UtilizationMetricsAuroraMemoryNumKillConnTotalMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsAuroraMemoryNumKillConnTotalMaximum = new ExportableRDSDBField("UtilizationMetricsAuroraMemoryNumKillConnTotalMaximum");
        /// <summary>
        /// Constant UtilizationMetricsAuroraMemoryNumKillQueryTotalMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsAuroraMemoryNumKillQueryTotalMaximum = new ExportableRDSDBField("UtilizationMetricsAuroraMemoryNumKillQueryTotalMaximum");
        /// <summary>
        /// Constant UtilizationMetricsCpuMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsCpuMaximum = new ExportableRDSDBField("UtilizationMetricsCpuMaximum");
        /// <summary>
        /// Constant UtilizationMetricsDatabaseConnectionsMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsDatabaseConnectionsMaximum = new ExportableRDSDBField("UtilizationMetricsDatabaseConnectionsMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEBSVolumeReadIOPSMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsEBSVolumeReadIOPSMaximum = new ExportableRDSDBField("UtilizationMetricsEBSVolumeReadIOPSMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEBSVolumeReadThroughputMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsEBSVolumeReadThroughputMaximum = new ExportableRDSDBField("UtilizationMetricsEBSVolumeReadThroughputMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEBSVolumeStorageSpaceUtilizationMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsEBSVolumeStorageSpaceUtilizationMaximum = new ExportableRDSDBField("UtilizationMetricsEBSVolumeStorageSpaceUtilizationMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEBSVolumeWriteIOPSMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsEBSVolumeWriteIOPSMaximum = new ExportableRDSDBField("UtilizationMetricsEBSVolumeWriteIOPSMaximum");
        /// <summary>
        /// Constant UtilizationMetricsEBSVolumeWriteThroughputMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsEBSVolumeWriteThroughputMaximum = new ExportableRDSDBField("UtilizationMetricsEBSVolumeWriteThroughputMaximum");
        /// <summary>
        /// Constant UtilizationMetricsMemoryMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsMemoryMaximum = new ExportableRDSDBField("UtilizationMetricsMemoryMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkReceiveThroughputMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsNetworkReceiveThroughputMaximum = new ExportableRDSDBField("UtilizationMetricsNetworkReceiveThroughputMaximum");
        /// <summary>
        /// Constant UtilizationMetricsNetworkTransmitThroughputMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsNetworkTransmitThroughputMaximum = new ExportableRDSDBField("UtilizationMetricsNetworkTransmitThroughputMaximum");
        /// <summary>
        /// Constant UtilizationMetricsReadIOPSEphemeralStorageMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsReadIOPSEphemeralStorageMaximum = new ExportableRDSDBField("UtilizationMetricsReadIOPSEphemeralStorageMaximum");
        /// <summary>
        /// Constant UtilizationMetricsStorageNetworkReceiveThroughputMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsStorageNetworkReceiveThroughputMaximum = new ExportableRDSDBField("UtilizationMetricsStorageNetworkReceiveThroughputMaximum");
        /// <summary>
        /// Constant UtilizationMetricsStorageNetworkTransmitThroughputMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsStorageNetworkTransmitThroughputMaximum = new ExportableRDSDBField("UtilizationMetricsStorageNetworkTransmitThroughputMaximum");
        /// <summary>
        /// Constant UtilizationMetricsVolumeBytesUsedAverage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsVolumeBytesUsedAverage = new ExportableRDSDBField("UtilizationMetricsVolumeBytesUsedAverage");
        /// <summary>
        /// Constant UtilizationMetricsVolumeReadIOPsAverage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsVolumeReadIOPsAverage = new ExportableRDSDBField("UtilizationMetricsVolumeReadIOPsAverage");
        /// <summary>
        /// Constant UtilizationMetricsVolumeWriteIOPsAverage for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsVolumeWriteIOPsAverage = new ExportableRDSDBField("UtilizationMetricsVolumeWriteIOPsAverage");
        /// <summary>
        /// Constant UtilizationMetricsWriteIOPSEphemeralStorageMaximum for ExportableRDSDBField
        /// </summary>
        public static readonly ExportableRDSDBField UtilizationMetricsWriteIOPSEphemeralStorageMaximum = new ExportableRDSDBField("UtilizationMetricsWriteIOPSEphemeralStorageMaximum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportableRDSDBField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportableRDSDBField FindValue(string value)
        {
            return FindValue<ExportableRDSDBField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportableRDSDBField(string value)
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
        /// Constant CurrentConfigurationRootVolume for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField CurrentConfigurationRootVolume = new ExportableVolumeField("CurrentConfigurationRootVolume");
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
        /// Constant EffectiveRecommendationPreferencesSavingsEstimationMode for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField EffectiveRecommendationPreferencesSavingsEstimationMode = new ExportableVolumeField("EffectiveRecommendationPreferencesSavingsEstimationMode");
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
        /// Constant RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts = new ExportableVolumeField("RecommendationOptionsEstimatedMonthlySavingsCurrencyAfterDiscounts");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValue for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsEstimatedMonthlySavingsValue = new ExportableVolumeField("RecommendationOptionsEstimatedMonthlySavingsValue");
        /// <summary>
        /// Constant RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts = new ExportableVolumeField("RecommendationOptionsEstimatedMonthlySavingsValueAfterDiscounts");
        /// <summary>
        /// Constant RecommendationOptionsMonthlyPrice for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsMonthlyPrice = new ExportableVolumeField("RecommendationOptionsMonthlyPrice");
        /// <summary>
        /// Constant RecommendationOptionsPerformanceRisk for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsPerformanceRisk = new ExportableVolumeField("RecommendationOptionsPerformanceRisk");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage = new ExportableVolumeField("RecommendationOptionsSavingsOpportunityAfterDiscountsPercentage");
        /// <summary>
        /// Constant RecommendationOptionsSavingsOpportunityPercentage for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RecommendationOptionsSavingsOpportunityPercentage = new ExportableVolumeField("RecommendationOptionsSavingsOpportunityPercentage");
        /// <summary>
        /// Constant RootVolume for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField RootVolume = new ExportableVolumeField("RootVolume");
        /// <summary>
        /// Constant Tags for ExportableVolumeField
        /// </summary>
        public static readonly ExportableVolumeField Tags = new ExportableVolumeField("Tags");
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
    /// Constants used for properties of type ExternalMetricStatusCode.
    /// </summary>
    public class ExternalMetricStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant DATADOG_INTEGRATION_ERROR for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode DATADOG_INTEGRATION_ERROR = new ExternalMetricStatusCode("DATADOG_INTEGRATION_ERROR");
        /// <summary>
        /// Constant DYNATRACE_INTEGRATION_ERROR for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode DYNATRACE_INTEGRATION_ERROR = new ExternalMetricStatusCode("DYNATRACE_INTEGRATION_ERROR");
        /// <summary>
        /// Constant INSTANA_INTEGRATION_ERROR for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode INSTANA_INTEGRATION_ERROR = new ExternalMetricStatusCode("INSTANA_INTEGRATION_ERROR");
        /// <summary>
        /// Constant INSUFFICIENT_DATADOG_METRICS for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode INSUFFICIENT_DATADOG_METRICS = new ExternalMetricStatusCode("INSUFFICIENT_DATADOG_METRICS");
        /// <summary>
        /// Constant INSUFFICIENT_DYNATRACE_METRICS for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode INSUFFICIENT_DYNATRACE_METRICS = new ExternalMetricStatusCode("INSUFFICIENT_DYNATRACE_METRICS");
        /// <summary>
        /// Constant INSUFFICIENT_INSTANA_METRICS for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode INSUFFICIENT_INSTANA_METRICS = new ExternalMetricStatusCode("INSUFFICIENT_INSTANA_METRICS");
        /// <summary>
        /// Constant INSUFFICIENT_NEWRELIC_METRICS for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode INSUFFICIENT_NEWRELIC_METRICS = new ExternalMetricStatusCode("INSUFFICIENT_NEWRELIC_METRICS");
        /// <summary>
        /// Constant INTEGRATION_SUCCESS for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode INTEGRATION_SUCCESS = new ExternalMetricStatusCode("INTEGRATION_SUCCESS");
        /// <summary>
        /// Constant NEWRELIC_INTEGRATION_ERROR for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode NEWRELIC_INTEGRATION_ERROR = new ExternalMetricStatusCode("NEWRELIC_INTEGRATION_ERROR");
        /// <summary>
        /// Constant NO_EXTERNAL_METRIC_SET for ExternalMetricStatusCode
        /// </summary>
        public static readonly ExternalMetricStatusCode NO_EXTERNAL_METRIC_SET = new ExternalMetricStatusCode("NO_EXTERNAL_METRIC_SET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExternalMetricStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExternalMetricStatusCode FindValue(string value)
        {
            return FindValue<ExternalMetricStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExternalMetricStatusCode(string value)
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
        /// Constant InferredWorkloadTypes for FilterName
        /// </summary>
        public static readonly FilterName InferredWorkloadTypes = new FilterName("InferredWorkloadTypes");
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
    /// Constants used for properties of type Idle.
    /// </summary>
    public class Idle : ConstantClass
    {

        /// <summary>
        /// Constant False for Idle
        /// </summary>
        public static readonly Idle False = new Idle("False");
        /// <summary>
        /// Constant True for Idle
        /// </summary>
        public static readonly Idle True = new Idle("True");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Idle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Idle FindValue(string value)
        {
            return FindValue<Idle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Idle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdleFinding.
    /// </summary>
    public class IdleFinding : ConstantClass
    {

        /// <summary>
        /// Constant Idle for IdleFinding
        /// </summary>
        public static readonly IdleFinding Idle = new IdleFinding("Idle");
        /// <summary>
        /// Constant Unattached for IdleFinding
        /// </summary>
        public static readonly IdleFinding Unattached = new IdleFinding("Unattached");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdleFinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdleFinding FindValue(string value)
        {
            return FindValue<IdleFinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdleFinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdleMetricName.
    /// </summary>
    public class IdleMetricName : ConstantClass
    {

        /// <summary>
        /// Constant CPU for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName CPU = new IdleMetricName("CPU");
        /// <summary>
        /// Constant DatabaseConnections for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName DatabaseConnections = new IdleMetricName("DatabaseConnections");
        /// <summary>
        /// Constant EBSVolumeReadIOPS for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName EBSVolumeReadIOPS = new IdleMetricName("EBSVolumeReadIOPS");
        /// <summary>
        /// Constant EBSVolumeWriteIOPS for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName EBSVolumeWriteIOPS = new IdleMetricName("EBSVolumeWriteIOPS");
        /// <summary>
        /// Constant Memory for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName Memory = new IdleMetricName("Memory");
        /// <summary>
        /// Constant NetworkInBytesPerSecond for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName NetworkInBytesPerSecond = new IdleMetricName("NetworkInBytesPerSecond");
        /// <summary>
        /// Constant NetworkOutBytesPerSecond for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName NetworkOutBytesPerSecond = new IdleMetricName("NetworkOutBytesPerSecond");
        /// <summary>
        /// Constant VolumeReadOpsPerSecond for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName VolumeReadOpsPerSecond = new IdleMetricName("VolumeReadOpsPerSecond");
        /// <summary>
        /// Constant VolumeWriteOpsPerSecond for IdleMetricName
        /// </summary>
        public static readonly IdleMetricName VolumeWriteOpsPerSecond = new IdleMetricName("VolumeWriteOpsPerSecond");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdleMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdleMetricName FindValue(string value)
        {
            return FindValue<IdleMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdleMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdleRecommendationFilterName.
    /// </summary>
    public class IdleRecommendationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Finding for IdleRecommendationFilterName
        /// </summary>
        public static readonly IdleRecommendationFilterName Finding = new IdleRecommendationFilterName("Finding");
        /// <summary>
        /// Constant ResourceType for IdleRecommendationFilterName
        /// </summary>
        public static readonly IdleRecommendationFilterName ResourceType = new IdleRecommendationFilterName("ResourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdleRecommendationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdleRecommendationFilterName FindValue(string value)
        {
            return FindValue<IdleRecommendationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdleRecommendationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdleRecommendationResourceType.
    /// </summary>
    public class IdleRecommendationResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AutoScalingGroup for IdleRecommendationResourceType
        /// </summary>
        public static readonly IdleRecommendationResourceType AutoScalingGroup = new IdleRecommendationResourceType("AutoScalingGroup");
        /// <summary>
        /// Constant EBSVolume for IdleRecommendationResourceType
        /// </summary>
        public static readonly IdleRecommendationResourceType EBSVolume = new IdleRecommendationResourceType("EBSVolume");
        /// <summary>
        /// Constant EC2Instance for IdleRecommendationResourceType
        /// </summary>
        public static readonly IdleRecommendationResourceType EC2Instance = new IdleRecommendationResourceType("EC2Instance");
        /// <summary>
        /// Constant ECSService for IdleRecommendationResourceType
        /// </summary>
        public static readonly IdleRecommendationResourceType ECSService = new IdleRecommendationResourceType("ECSService");
        /// <summary>
        /// Constant RDSDBInstance for IdleRecommendationResourceType
        /// </summary>
        public static readonly IdleRecommendationResourceType RDSDBInstance = new IdleRecommendationResourceType("RDSDBInstance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdleRecommendationResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdleRecommendationResourceType FindValue(string value)
        {
            return FindValue<IdleRecommendationResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdleRecommendationResourceType(string value)
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
        /// Constant SQLServer for InferredWorkloadType
        /// </summary>
        public static readonly InferredWorkloadType SQLServer = new InferredWorkloadType("SQLServer");

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
    /// Constants used for properties of type InstanceIdle.
    /// </summary>
    public class InstanceIdle : ConstantClass
    {

        /// <summary>
        /// Constant False for InstanceIdle
        /// </summary>
        public static readonly InstanceIdle False = new InstanceIdle("False");
        /// <summary>
        /// Constant True for InstanceIdle
        /// </summary>
        public static readonly InstanceIdle True = new InstanceIdle("True");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceIdle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceIdle FindValue(string value)
        {
            return FindValue<InstanceIdle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceIdle(string value)
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
        /// Constant GPUMemoryOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode GPUMemoryOverprovisioned = new InstanceRecommendationFindingReasonCode("GPUMemoryOverprovisioned");
        /// <summary>
        /// Constant GPUMemoryUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode GPUMemoryUnderprovisioned = new InstanceRecommendationFindingReasonCode("GPUMemoryUnderprovisioned");
        /// <summary>
        /// Constant GPUOverprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode GPUOverprovisioned = new InstanceRecommendationFindingReasonCode("GPUOverprovisioned");
        /// <summary>
        /// Constant GPUUnderprovisioned for InstanceRecommendationFindingReasonCode
        /// </summary>
        public static readonly InstanceRecommendationFindingReasonCode GPUUnderprovisioned = new InstanceRecommendationFindingReasonCode("GPUUnderprovisioned");
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
    /// Constants used for properties of type InstanceSavingsEstimationModeSource.
    /// </summary>
    public class InstanceSavingsEstimationModeSource : ConstantClass
    {

        /// <summary>
        /// Constant CostExplorerRightsizing for InstanceSavingsEstimationModeSource
        /// </summary>
        public static readonly InstanceSavingsEstimationModeSource CostExplorerRightsizing = new InstanceSavingsEstimationModeSource("CostExplorerRightsizing");
        /// <summary>
        /// Constant CostOptimizationHub for InstanceSavingsEstimationModeSource
        /// </summary>
        public static readonly InstanceSavingsEstimationModeSource CostOptimizationHub = new InstanceSavingsEstimationModeSource("CostOptimizationHub");
        /// <summary>
        /// Constant PublicPricing for InstanceSavingsEstimationModeSource
        /// </summary>
        public static readonly InstanceSavingsEstimationModeSource PublicPricing = new InstanceSavingsEstimationModeSource("PublicPricing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceSavingsEstimationModeSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceSavingsEstimationModeSource FindValue(string value)
        {
            return FindValue<InstanceSavingsEstimationModeSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceSavingsEstimationModeSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceState.
    /// </summary>
    public class InstanceState : ConstantClass
    {

        /// <summary>
        /// Constant Pending for InstanceState
        /// </summary>
        public static readonly InstanceState Pending = new InstanceState("pending");
        /// <summary>
        /// Constant Running for InstanceState
        /// </summary>
        public static readonly InstanceState Running = new InstanceState("running");
        /// <summary>
        /// Constant ShuttingDown for InstanceState
        /// </summary>
        public static readonly InstanceState ShuttingDown = new InstanceState("shutting-down");
        /// <summary>
        /// Constant Stopped for InstanceState
        /// </summary>
        public static readonly InstanceState Stopped = new InstanceState("stopped");
        /// <summary>
        /// Constant Stopping for InstanceState
        /// </summary>
        public static readonly InstanceState Stopping = new InstanceState("stopping");
        /// <summary>
        /// Constant Terminated for InstanceState
        /// </summary>
        public static readonly InstanceState Terminated = new InstanceState("terminated");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceState(string value)
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
    /// Constants used for properties of type LambdaSavingsEstimationModeSource.
    /// </summary>
    public class LambdaSavingsEstimationModeSource : ConstantClass
    {

        /// <summary>
        /// Constant CostExplorerRightsizing for LambdaSavingsEstimationModeSource
        /// </summary>
        public static readonly LambdaSavingsEstimationModeSource CostExplorerRightsizing = new LambdaSavingsEstimationModeSource("CostExplorerRightsizing");
        /// <summary>
        /// Constant CostOptimizationHub for LambdaSavingsEstimationModeSource
        /// </summary>
        public static readonly LambdaSavingsEstimationModeSource CostOptimizationHub = new LambdaSavingsEstimationModeSource("CostOptimizationHub");
        /// <summary>
        /// Constant PublicPricing for LambdaSavingsEstimationModeSource
        /// </summary>
        public static readonly LambdaSavingsEstimationModeSource PublicPricing = new LambdaSavingsEstimationModeSource("PublicPricing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaSavingsEstimationModeSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaSavingsEstimationModeSource FindValue(string value)
        {
            return FindValue<LambdaSavingsEstimationModeSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaSavingsEstimationModeSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseEdition.
    /// </summary>
    public class LicenseEdition : ConstantClass
    {

        /// <summary>
        /// Constant Enterprise for LicenseEdition
        /// </summary>
        public static readonly LicenseEdition Enterprise = new LicenseEdition("Enterprise");
        /// <summary>
        /// Constant Free for LicenseEdition
        /// </summary>
        public static readonly LicenseEdition Free = new LicenseEdition("Free");
        /// <summary>
        /// Constant NoLicenseEditionFound for LicenseEdition
        /// </summary>
        public static readonly LicenseEdition NoLicenseEditionFound = new LicenseEdition("NoLicenseEditionFound");
        /// <summary>
        /// Constant Standard for LicenseEdition
        /// </summary>
        public static readonly LicenseEdition Standard = new LicenseEdition("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseEdition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseEdition FindValue(string value)
        {
            return FindValue<LicenseEdition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseEdition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseFinding.
    /// </summary>
    public class LicenseFinding : ConstantClass
    {

        /// <summary>
        /// Constant InsufficientMetrics for LicenseFinding
        /// </summary>
        public static readonly LicenseFinding InsufficientMetrics = new LicenseFinding("InsufficientMetrics");
        /// <summary>
        /// Constant NotOptimized for LicenseFinding
        /// </summary>
        public static readonly LicenseFinding NotOptimized = new LicenseFinding("NotOptimized");
        /// <summary>
        /// Constant Optimized for LicenseFinding
        /// </summary>
        public static readonly LicenseFinding Optimized = new LicenseFinding("Optimized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseFinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseFinding FindValue(string value)
        {
            return FindValue<LicenseFinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseFinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseFindingReasonCode.
    /// </summary>
    public class LicenseFindingReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CloudWatchApplicationInsightsError for LicenseFindingReasonCode
        /// </summary>
        public static readonly LicenseFindingReasonCode CloudWatchApplicationInsightsError = new LicenseFindingReasonCode("CloudWatchApplicationInsightsError");
        /// <summary>
        /// Constant InvalidCloudWatchApplicationInsightsSetup for LicenseFindingReasonCode
        /// </summary>
        public static readonly LicenseFindingReasonCode InvalidCloudWatchApplicationInsightsSetup = new LicenseFindingReasonCode("InvalidCloudWatchApplicationInsightsSetup");
        /// <summary>
        /// Constant LicenseOverprovisioned for LicenseFindingReasonCode
        /// </summary>
        public static readonly LicenseFindingReasonCode LicenseOverprovisioned = new LicenseFindingReasonCode("LicenseOverprovisioned");
        /// <summary>
        /// Constant Optimized for LicenseFindingReasonCode
        /// </summary>
        public static readonly LicenseFindingReasonCode Optimized = new LicenseFindingReasonCode("Optimized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseFindingReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseFindingReasonCode FindValue(string value)
        {
            return FindValue<LicenseFindingReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseFindingReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseModel.
    /// </summary>
    public class LicenseModel : ConstantClass
    {

        /// <summary>
        /// Constant BringYourOwnLicense for LicenseModel
        /// </summary>
        public static readonly LicenseModel BringYourOwnLicense = new LicenseModel("BringYourOwnLicense");
        /// <summary>
        /// Constant LicenseIncluded for LicenseModel
        /// </summary>
        public static readonly LicenseModel LicenseIncluded = new LicenseModel("LicenseIncluded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseModel FindValue(string value)
        {
            return FindValue<LicenseModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseName.
    /// </summary>
    public class LicenseName : ConstantClass
    {

        /// <summary>
        /// Constant SQLServer for LicenseName
        /// </summary>
        public static readonly LicenseName SQLServer = new LicenseName("SQLServer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseName FindValue(string value)
        {
            return FindValue<LicenseName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseRecommendationFilterName.
    /// </summary>
    public class LicenseRecommendationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Finding for LicenseRecommendationFilterName
        /// </summary>
        public static readonly LicenseRecommendationFilterName Finding = new LicenseRecommendationFilterName("Finding");
        /// <summary>
        /// Constant FindingReasonCode for LicenseRecommendationFilterName
        /// </summary>
        public static readonly LicenseRecommendationFilterName FindingReasonCode = new LicenseRecommendationFilterName("FindingReasonCode");
        /// <summary>
        /// Constant LicenseName for LicenseRecommendationFilterName
        /// </summary>
        public static readonly LicenseRecommendationFilterName LicenseName = new LicenseRecommendationFilterName("LicenseName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseRecommendationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseRecommendationFilterName FindValue(string value)
        {
            return FindValue<LicenseRecommendationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseRecommendationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LookBackPeriodPreference.
    /// </summary>
    public class LookBackPeriodPreference : ConstantClass
    {

        /// <summary>
        /// Constant DAYS_14 for LookBackPeriodPreference
        /// </summary>
        public static readonly LookBackPeriodPreference DAYS_14 = new LookBackPeriodPreference("DAYS_14");
        /// <summary>
        /// Constant DAYS_32 for LookBackPeriodPreference
        /// </summary>
        public static readonly LookBackPeriodPreference DAYS_32 = new LookBackPeriodPreference("DAYS_32");
        /// <summary>
        /// Constant DAYS_93 for LookBackPeriodPreference
        /// </summary>
        public static readonly LookBackPeriodPreference DAYS_93 = new LookBackPeriodPreference("DAYS_93");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LookBackPeriodPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LookBackPeriodPreference FindValue(string value)
        {
            return FindValue<LookBackPeriodPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LookBackPeriodPreference(string value)
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
        /// Constant GPU_MEMORY_PERCENTAGE for MetricName
        /// </summary>
        public static readonly MetricName GPU_MEMORY_PERCENTAGE = new MetricName("GPU_MEMORY_PERCENTAGE");
        /// <summary>
        /// Constant GPU_PERCENTAGE for MetricName
        /// </summary>
        public static readonly MetricName GPU_PERCENTAGE = new MetricName("GPU_PERCENTAGE");
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
    /// Constants used for properties of type MetricSourceProvider.
    /// </summary>
    public class MetricSourceProvider : ConstantClass
    {

        /// <summary>
        /// Constant CloudWatchApplicationInsights for MetricSourceProvider
        /// </summary>
        public static readonly MetricSourceProvider CloudWatchApplicationInsights = new MetricSourceProvider("CloudWatchApplicationInsights");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricSourceProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricSourceProvider FindValue(string value)
        {
            return FindValue<MetricSourceProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricSourceProvider(string value)
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
    /// Constants used for properties of type Order.
    /// </summary>
    public class Order : ConstantClass
    {

        /// <summary>
        /// Constant Asc for Order
        /// </summary>
        public static readonly Order Asc = new Order("Asc");
        /// <summary>
        /// Constant Desc for Order
        /// </summary>
        public static readonly Order Desc = new Order("Desc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Order(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Order FindValue(string value)
        {
            return FindValue<Order>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Order(string value)
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
    /// Constants used for properties of type PreferredResourceName.
    /// </summary>
    public class PreferredResourceName : ConstantClass
    {

        /// <summary>
        /// Constant Ec2InstanceTypes for PreferredResourceName
        /// </summary>
        public static readonly PreferredResourceName Ec2InstanceTypes = new PreferredResourceName("Ec2InstanceTypes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreferredResourceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreferredResourceName FindValue(string value)
        {
            return FindValue<PreferredResourceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreferredResourceName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSCurrentInstancePerformanceRisk.
    /// </summary>
    public class RDSCurrentInstancePerformanceRisk : ConstantClass
    {

        /// <summary>
        /// Constant High for RDSCurrentInstancePerformanceRisk
        /// </summary>
        public static readonly RDSCurrentInstancePerformanceRisk High = new RDSCurrentInstancePerformanceRisk("High");
        /// <summary>
        /// Constant Low for RDSCurrentInstancePerformanceRisk
        /// </summary>
        public static readonly RDSCurrentInstancePerformanceRisk Low = new RDSCurrentInstancePerformanceRisk("Low");
        /// <summary>
        /// Constant Medium for RDSCurrentInstancePerformanceRisk
        /// </summary>
        public static readonly RDSCurrentInstancePerformanceRisk Medium = new RDSCurrentInstancePerformanceRisk("Medium");
        /// <summary>
        /// Constant VeryLow for RDSCurrentInstancePerformanceRisk
        /// </summary>
        public static readonly RDSCurrentInstancePerformanceRisk VeryLow = new RDSCurrentInstancePerformanceRisk("VeryLow");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSCurrentInstancePerformanceRisk(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSCurrentInstancePerformanceRisk FindValue(string value)
        {
            return FindValue<RDSCurrentInstancePerformanceRisk>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSCurrentInstancePerformanceRisk(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSDBMetricName.
    /// </summary>
    public class RDSDBMetricName : ConstantClass
    {

        /// <summary>
        /// Constant AuroraMemoryHealthState for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName AuroraMemoryHealthState = new RDSDBMetricName("AuroraMemoryHealthState");
        /// <summary>
        /// Constant AuroraMemoryNumDeclinedSql for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName AuroraMemoryNumDeclinedSql = new RDSDBMetricName("AuroraMemoryNumDeclinedSql");
        /// <summary>
        /// Constant AuroraMemoryNumKillConnTotal for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName AuroraMemoryNumKillConnTotal = new RDSDBMetricName("AuroraMemoryNumKillConnTotal");
        /// <summary>
        /// Constant AuroraMemoryNumKillQueryTotal for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName AuroraMemoryNumKillQueryTotal = new RDSDBMetricName("AuroraMemoryNumKillQueryTotal");
        /// <summary>
        /// Constant CPU for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName CPU = new RDSDBMetricName("CPU");
        /// <summary>
        /// Constant DatabaseConnections for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName DatabaseConnections = new RDSDBMetricName("DatabaseConnections");
        /// <summary>
        /// Constant EBSVolumeReadIOPS for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName EBSVolumeReadIOPS = new RDSDBMetricName("EBSVolumeReadIOPS");
        /// <summary>
        /// Constant EBSVolumeReadThroughput for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName EBSVolumeReadThroughput = new RDSDBMetricName("EBSVolumeReadThroughput");
        /// <summary>
        /// Constant EBSVolumeStorageSpaceUtilization for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName EBSVolumeStorageSpaceUtilization = new RDSDBMetricName("EBSVolumeStorageSpaceUtilization");
        /// <summary>
        /// Constant EBSVolumeWriteIOPS for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName EBSVolumeWriteIOPS = new RDSDBMetricName("EBSVolumeWriteIOPS");
        /// <summary>
        /// Constant EBSVolumeWriteThroughput for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName EBSVolumeWriteThroughput = new RDSDBMetricName("EBSVolumeWriteThroughput");
        /// <summary>
        /// Constant Memory for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName Memory = new RDSDBMetricName("Memory");
        /// <summary>
        /// Constant NetworkReceiveThroughput for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName NetworkReceiveThroughput = new RDSDBMetricName("NetworkReceiveThroughput");
        /// <summary>
        /// Constant NetworkTransmitThroughput for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName NetworkTransmitThroughput = new RDSDBMetricName("NetworkTransmitThroughput");
        /// <summary>
        /// Constant ReadIOPSEphemeralStorage for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName ReadIOPSEphemeralStorage = new RDSDBMetricName("ReadIOPSEphemeralStorage");
        /// <summary>
        /// Constant StorageNetworkReceiveThroughput for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName StorageNetworkReceiveThroughput = new RDSDBMetricName("StorageNetworkReceiveThroughput");
        /// <summary>
        /// Constant StorageNetworkTransmitThroughput for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName StorageNetworkTransmitThroughput = new RDSDBMetricName("StorageNetworkTransmitThroughput");
        /// <summary>
        /// Constant VolumeBytesUsed for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName VolumeBytesUsed = new RDSDBMetricName("VolumeBytesUsed");
        /// <summary>
        /// Constant VolumeReadIOPs for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName VolumeReadIOPs = new RDSDBMetricName("VolumeReadIOPs");
        /// <summary>
        /// Constant VolumeWriteIOPs for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName VolumeWriteIOPs = new RDSDBMetricName("VolumeWriteIOPs");
        /// <summary>
        /// Constant WriteIOPSEphemeralStorage for RDSDBMetricName
        /// </summary>
        public static readonly RDSDBMetricName WriteIOPSEphemeralStorage = new RDSDBMetricName("WriteIOPSEphemeralStorage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSDBMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSDBMetricName FindValue(string value)
        {
            return FindValue<RDSDBMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSDBMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSDBMetricStatistic.
    /// </summary>
    public class RDSDBMetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for RDSDBMetricStatistic
        /// </summary>
        public static readonly RDSDBMetricStatistic Average = new RDSDBMetricStatistic("Average");
        /// <summary>
        /// Constant Maximum for RDSDBMetricStatistic
        /// </summary>
        public static readonly RDSDBMetricStatistic Maximum = new RDSDBMetricStatistic("Maximum");
        /// <summary>
        /// Constant Minimum for RDSDBMetricStatistic
        /// </summary>
        public static readonly RDSDBMetricStatistic Minimum = new RDSDBMetricStatistic("Minimum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSDBMetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSDBMetricStatistic FindValue(string value)
        {
            return FindValue<RDSDBMetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSDBMetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSDBRecommendationFilterName.
    /// </summary>
    public class RDSDBRecommendationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Idle for RDSDBRecommendationFilterName
        /// </summary>
        public static readonly RDSDBRecommendationFilterName Idle = new RDSDBRecommendationFilterName("Idle");
        /// <summary>
        /// Constant InstanceFinding for RDSDBRecommendationFilterName
        /// </summary>
        public static readonly RDSDBRecommendationFilterName InstanceFinding = new RDSDBRecommendationFilterName("InstanceFinding");
        /// <summary>
        /// Constant InstanceFindingReasonCode for RDSDBRecommendationFilterName
        /// </summary>
        public static readonly RDSDBRecommendationFilterName InstanceFindingReasonCode = new RDSDBRecommendationFilterName("InstanceFindingReasonCode");
        /// <summary>
        /// Constant StorageFinding for RDSDBRecommendationFilterName
        /// </summary>
        public static readonly RDSDBRecommendationFilterName StorageFinding = new RDSDBRecommendationFilterName("StorageFinding");
        /// <summary>
        /// Constant StorageFindingReasonCode for RDSDBRecommendationFilterName
        /// </summary>
        public static readonly RDSDBRecommendationFilterName StorageFindingReasonCode = new RDSDBRecommendationFilterName("StorageFindingReasonCode");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSDBRecommendationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSDBRecommendationFilterName FindValue(string value)
        {
            return FindValue<RDSDBRecommendationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSDBRecommendationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSEstimatedMonthlyVolumeIOPsCostVariation.
    /// </summary>
    public class RDSEstimatedMonthlyVolumeIOPsCostVariation : ConstantClass
    {

        /// <summary>
        /// Constant High for RDSEstimatedMonthlyVolumeIOPsCostVariation
        /// </summary>
        public static readonly RDSEstimatedMonthlyVolumeIOPsCostVariation High = new RDSEstimatedMonthlyVolumeIOPsCostVariation("High");
        /// <summary>
        /// Constant Low for RDSEstimatedMonthlyVolumeIOPsCostVariation
        /// </summary>
        public static readonly RDSEstimatedMonthlyVolumeIOPsCostVariation Low = new RDSEstimatedMonthlyVolumeIOPsCostVariation("Low");
        /// <summary>
        /// Constant Medium for RDSEstimatedMonthlyVolumeIOPsCostVariation
        /// </summary>
        public static readonly RDSEstimatedMonthlyVolumeIOPsCostVariation Medium = new RDSEstimatedMonthlyVolumeIOPsCostVariation("Medium");
        /// <summary>
        /// Constant None for RDSEstimatedMonthlyVolumeIOPsCostVariation
        /// </summary>
        public static readonly RDSEstimatedMonthlyVolumeIOPsCostVariation None = new RDSEstimatedMonthlyVolumeIOPsCostVariation("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSEstimatedMonthlyVolumeIOPsCostVariation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSEstimatedMonthlyVolumeIOPsCostVariation FindValue(string value)
        {
            return FindValue<RDSEstimatedMonthlyVolumeIOPsCostVariation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSEstimatedMonthlyVolumeIOPsCostVariation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSInstanceFinding.
    /// </summary>
    public class RDSInstanceFinding : ConstantClass
    {

        /// <summary>
        /// Constant Optimized for RDSInstanceFinding
        /// </summary>
        public static readonly RDSInstanceFinding Optimized = new RDSInstanceFinding("Optimized");
        /// <summary>
        /// Constant Overprovisioned for RDSInstanceFinding
        /// </summary>
        public static readonly RDSInstanceFinding Overprovisioned = new RDSInstanceFinding("Overprovisioned");
        /// <summary>
        /// Constant Underprovisioned for RDSInstanceFinding
        /// </summary>
        public static readonly RDSInstanceFinding Underprovisioned = new RDSInstanceFinding("Underprovisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSInstanceFinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSInstanceFinding FindValue(string value)
        {
            return FindValue<RDSInstanceFinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSInstanceFinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSInstanceFindingReasonCode.
    /// </summary>
    public class RDSInstanceFindingReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CPUOverprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode CPUOverprovisioned = new RDSInstanceFindingReasonCode("CPUOverprovisioned");
        /// <summary>
        /// Constant CPUUnderprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode CPUUnderprovisioned = new RDSInstanceFindingReasonCode("CPUUnderprovisioned");
        /// <summary>
        /// Constant DBClusterWriterUnderprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode DBClusterWriterUnderprovisioned = new RDSInstanceFindingReasonCode("DBClusterWriterUnderprovisioned");
        /// <summary>
        /// Constant EBSIOPSOverprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode EBSIOPSOverprovisioned = new RDSInstanceFindingReasonCode("EBSIOPSOverprovisioned");
        /// <summary>
        /// Constant EBSIOPSUnderprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode EBSIOPSUnderprovisioned = new RDSInstanceFindingReasonCode("EBSIOPSUnderprovisioned");
        /// <summary>
        /// Constant EBSThroughputOverprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode EBSThroughputOverprovisioned = new RDSInstanceFindingReasonCode("EBSThroughputOverprovisioned");
        /// <summary>
        /// Constant EBSThroughputUnderprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode EBSThroughputUnderprovisioned = new RDSInstanceFindingReasonCode("EBSThroughputUnderprovisioned");
        /// <summary>
        /// Constant InstanceStorageReadIOPSUnderprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode InstanceStorageReadIOPSUnderprovisioned = new RDSInstanceFindingReasonCode("InstanceStorageReadIOPSUnderprovisioned");
        /// <summary>
        /// Constant InstanceStorageWriteIOPSUnderprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode InstanceStorageWriteIOPSUnderprovisioned = new RDSInstanceFindingReasonCode("InstanceStorageWriteIOPSUnderprovisioned");
        /// <summary>
        /// Constant MemoryUnderprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode MemoryUnderprovisioned = new RDSInstanceFindingReasonCode("MemoryUnderprovisioned");
        /// <summary>
        /// Constant NetworkBandwidthOverprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode NetworkBandwidthOverprovisioned = new RDSInstanceFindingReasonCode("NetworkBandwidthOverprovisioned");
        /// <summary>
        /// Constant NetworkBandwidthUnderprovisioned for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode NetworkBandwidthUnderprovisioned = new RDSInstanceFindingReasonCode("NetworkBandwidthUnderprovisioned");
        /// <summary>
        /// Constant NewEngineVersionAvailable for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode NewEngineVersionAvailable = new RDSInstanceFindingReasonCode("NewEngineVersionAvailable");
        /// <summary>
        /// Constant NewGenerationDBInstanceClassAvailable for RDSInstanceFindingReasonCode
        /// </summary>
        public static readonly RDSInstanceFindingReasonCode NewGenerationDBInstanceClassAvailable = new RDSInstanceFindingReasonCode("NewGenerationDBInstanceClassAvailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSInstanceFindingReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSInstanceFindingReasonCode FindValue(string value)
        {
            return FindValue<RDSInstanceFindingReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSInstanceFindingReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSSavingsEstimationModeSource.
    /// </summary>
    public class RDSSavingsEstimationModeSource : ConstantClass
    {

        /// <summary>
        /// Constant CostExplorerRightsizing for RDSSavingsEstimationModeSource
        /// </summary>
        public static readonly RDSSavingsEstimationModeSource CostExplorerRightsizing = new RDSSavingsEstimationModeSource("CostExplorerRightsizing");
        /// <summary>
        /// Constant CostOptimizationHub for RDSSavingsEstimationModeSource
        /// </summary>
        public static readonly RDSSavingsEstimationModeSource CostOptimizationHub = new RDSSavingsEstimationModeSource("CostOptimizationHub");
        /// <summary>
        /// Constant PublicPricing for RDSSavingsEstimationModeSource
        /// </summary>
        public static readonly RDSSavingsEstimationModeSource PublicPricing = new RDSSavingsEstimationModeSource("PublicPricing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSSavingsEstimationModeSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSSavingsEstimationModeSource FindValue(string value)
        {
            return FindValue<RDSSavingsEstimationModeSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSSavingsEstimationModeSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSStorageFinding.
    /// </summary>
    public class RDSStorageFinding : ConstantClass
    {

        /// <summary>
        /// Constant NotOptimized for RDSStorageFinding
        /// </summary>
        public static readonly RDSStorageFinding NotOptimized = new RDSStorageFinding("NotOptimized");
        /// <summary>
        /// Constant Optimized for RDSStorageFinding
        /// </summary>
        public static readonly RDSStorageFinding Optimized = new RDSStorageFinding("Optimized");
        /// <summary>
        /// Constant Overprovisioned for RDSStorageFinding
        /// </summary>
        public static readonly RDSStorageFinding Overprovisioned = new RDSStorageFinding("Overprovisioned");
        /// <summary>
        /// Constant Underprovisioned for RDSStorageFinding
        /// </summary>
        public static readonly RDSStorageFinding Underprovisioned = new RDSStorageFinding("Underprovisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSStorageFinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSStorageFinding FindValue(string value)
        {
            return FindValue<RDSStorageFinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSStorageFinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RDSStorageFindingReasonCode.
    /// </summary>
    public class RDSStorageFindingReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant DBClusterStorageOptionAvailable for RDSStorageFindingReasonCode
        /// </summary>
        public static readonly RDSStorageFindingReasonCode DBClusterStorageOptionAvailable = new RDSStorageFindingReasonCode("DBClusterStorageOptionAvailable");
        /// <summary>
        /// Constant DBClusterStorageSavingsAvailable for RDSStorageFindingReasonCode
        /// </summary>
        public static readonly RDSStorageFindingReasonCode DBClusterStorageSavingsAvailable = new RDSStorageFindingReasonCode("DBClusterStorageSavingsAvailable");
        /// <summary>
        /// Constant EBSVolumeAllocatedStorageUnderprovisioned for RDSStorageFindingReasonCode
        /// </summary>
        public static readonly RDSStorageFindingReasonCode EBSVolumeAllocatedStorageUnderprovisioned = new RDSStorageFindingReasonCode("EBSVolumeAllocatedStorageUnderprovisioned");
        /// <summary>
        /// Constant EBSVolumeIOPSOverprovisioned for RDSStorageFindingReasonCode
        /// </summary>
        public static readonly RDSStorageFindingReasonCode EBSVolumeIOPSOverprovisioned = new RDSStorageFindingReasonCode("EBSVolumeIOPSOverprovisioned");
        /// <summary>
        /// Constant EBSVolumeThroughputOverprovisioned for RDSStorageFindingReasonCode
        /// </summary>
        public static readonly RDSStorageFindingReasonCode EBSVolumeThroughputOverprovisioned = new RDSStorageFindingReasonCode("EBSVolumeThroughputOverprovisioned");
        /// <summary>
        /// Constant EBSVolumeThroughputUnderprovisioned for RDSStorageFindingReasonCode
        /// </summary>
        public static readonly RDSStorageFindingReasonCode EBSVolumeThroughputUnderprovisioned = new RDSStorageFindingReasonCode("EBSVolumeThroughputUnderprovisioned");
        /// <summary>
        /// Constant NewGenerationStorageTypeAvailable for RDSStorageFindingReasonCode
        /// </summary>
        public static readonly RDSStorageFindingReasonCode NewGenerationStorageTypeAvailable = new RDSStorageFindingReasonCode("NewGenerationStorageTypeAvailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RDSStorageFindingReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RDSStorageFindingReasonCode FindValue(string value)
        {
            return FindValue<RDSStorageFindingReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RDSStorageFindingReasonCode(string value)
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
        /// Constant LookBackPeriodPreference for RecommendationPreferenceName
        /// </summary>
        public static readonly RecommendationPreferenceName LookBackPeriodPreference = new RecommendationPreferenceName("LookBackPeriodPreference");
        /// <summary>
        /// Constant PreferredResources for RecommendationPreferenceName
        /// </summary>
        public static readonly RecommendationPreferenceName PreferredResources = new RecommendationPreferenceName("PreferredResources");
        /// <summary>
        /// Constant UtilizationPreferences for RecommendationPreferenceName
        /// </summary>
        public static readonly RecommendationPreferenceName UtilizationPreferences = new RecommendationPreferenceName("UtilizationPreferences");

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
        /// Constant AuroraDBClusterStorage for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType AuroraDBClusterStorage = new RecommendationSourceType("AuroraDBClusterStorage");
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
        /// Constant License for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType License = new RecommendationSourceType("License");
        /// <summary>
        /// Constant RdsDBInstance for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType RdsDBInstance = new RecommendationSourceType("RdsDBInstance");
        /// <summary>
        /// Constant RdsDBInstanceStorage for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType RdsDBInstanceStorage = new RecommendationSourceType("RdsDBInstanceStorage");

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
        /// Constant AuroraDBClusterStorage for ResourceType
        /// </summary>
        public static readonly ResourceType AuroraDBClusterStorage = new ResourceType("AuroraDBClusterStorage");
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
        /// Constant Idle for ResourceType
        /// </summary>
        public static readonly ResourceType Idle = new ResourceType("Idle");
        /// <summary>
        /// Constant LambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType LambdaFunction = new ResourceType("LambdaFunction");
        /// <summary>
        /// Constant License for ResourceType
        /// </summary>
        public static readonly ResourceType License = new ResourceType("License");
        /// <summary>
        /// Constant NotApplicable for ResourceType
        /// </summary>
        public static readonly ResourceType NotApplicable = new ResourceType("NotApplicable");
        /// <summary>
        /// Constant RdsDBInstance for ResourceType
        /// </summary>
        public static readonly ResourceType RdsDBInstance = new ResourceType("RdsDBInstance");

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
    /// Constants used for properties of type SavingsEstimationMode.
    /// </summary>
    public class SavingsEstimationMode : ConstantClass
    {

        /// <summary>
        /// Constant AfterDiscounts for SavingsEstimationMode
        /// </summary>
        public static readonly SavingsEstimationMode AfterDiscounts = new SavingsEstimationMode("AfterDiscounts");
        /// <summary>
        /// Constant BeforeDiscounts for SavingsEstimationMode
        /// </summary>
        public static readonly SavingsEstimationMode BeforeDiscounts = new SavingsEstimationMode("BeforeDiscounts");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsEstimationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsEstimationMode FindValue(string value)
        {
            return FindValue<SavingsEstimationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsEstimationMode(string value)
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