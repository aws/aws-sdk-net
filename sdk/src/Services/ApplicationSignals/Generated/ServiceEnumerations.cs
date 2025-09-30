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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApplicationSignals
{

    /// <summary>
    /// Constants used for properties of type ChangeEventType.
    /// </summary>
    public class ChangeEventType : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYMENT for ChangeEventType
        /// </summary>
        public static readonly ChangeEventType DEPLOYMENT = new ChangeEventType("DEPLOYMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeEventType FindValue(string value)
        {
            return FindValue<ChangeEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionType.
    /// </summary>
    public class ConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT for ConnectionType
        /// </summary>
        public static readonly ConnectionType DIRECT = new ConnectionType("DIRECT");
        /// <summary>
        /// Constant INDIRECT for ConnectionType
        /// </summary>
        public static readonly ConnectionType INDIRECT = new ConnectionType("INDIRECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionType FindValue(string value)
        {
            return FindValue<ConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DurationUnit.
    /// </summary>
    public class DurationUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAY for DurationUnit
        /// </summary>
        public static readonly DurationUnit DAY = new DurationUnit("DAY");
        /// <summary>
        /// Constant HOUR for DurationUnit
        /// </summary>
        public static readonly DurationUnit HOUR = new DurationUnit("HOUR");
        /// <summary>
        /// Constant MINUTE for DurationUnit
        /// </summary>
        public static readonly DurationUnit MINUTE = new DurationUnit("MINUTE");
        /// <summary>
        /// Constant MONTH for DurationUnit
        /// </summary>
        public static readonly DurationUnit MONTH = new DurationUnit("MONTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DurationUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DurationUnit FindValue(string value)
        {
            return FindValue<DurationUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DurationUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationType.
    /// </summary>
    public class EvaluationType : ConstantClass
    {

        /// <summary>
        /// Constant PeriodBased for EvaluationType
        /// </summary>
        public static readonly EvaluationType PeriodBased = new EvaluationType("PeriodBased");
        /// <summary>
        /// Constant RequestBased for EvaluationType
        /// </summary>
        public static readonly EvaluationType RequestBased = new EvaluationType("RequestBased");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationType FindValue(string value)
        {
            return FindValue<EvaluationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricSourceType.
    /// </summary>
    public class MetricSourceType : ConstantClass
    {

        /// <summary>
        /// Constant CloudWatchMetric for MetricSourceType
        /// </summary>
        public static readonly MetricSourceType CloudWatchMetric = new MetricSourceType("CloudWatchMetric");
        /// <summary>
        /// Constant ServiceDependency for MetricSourceType
        /// </summary>
        public static readonly MetricSourceType ServiceDependency = new MetricSourceType("ServiceDependency");
        /// <summary>
        /// Constant ServiceOperation for MetricSourceType
        /// </summary>
        public static readonly MetricSourceType ServiceOperation = new MetricSourceType("ServiceOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricSourceType FindValue(string value)
        {
            return FindValue<MetricSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceLevelIndicatorComparisonOperator.
    /// </summary>
    public class ServiceLevelIndicatorComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant GreaterThan for ServiceLevelIndicatorComparisonOperator
        /// </summary>
        public static readonly ServiceLevelIndicatorComparisonOperator GreaterThan = new ServiceLevelIndicatorComparisonOperator("GreaterThan");
        /// <summary>
        /// Constant GreaterThanOrEqualTo for ServiceLevelIndicatorComparisonOperator
        /// </summary>
        public static readonly ServiceLevelIndicatorComparisonOperator GreaterThanOrEqualTo = new ServiceLevelIndicatorComparisonOperator("GreaterThanOrEqualTo");
        /// <summary>
        /// Constant LessThan for ServiceLevelIndicatorComparisonOperator
        /// </summary>
        public static readonly ServiceLevelIndicatorComparisonOperator LessThan = new ServiceLevelIndicatorComparisonOperator("LessThan");
        /// <summary>
        /// Constant LessThanOrEqualTo for ServiceLevelIndicatorComparisonOperator
        /// </summary>
        public static readonly ServiceLevelIndicatorComparisonOperator LessThanOrEqualTo = new ServiceLevelIndicatorComparisonOperator("LessThanOrEqualTo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceLevelIndicatorComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceLevelIndicatorComparisonOperator FindValue(string value)
        {
            return FindValue<ServiceLevelIndicatorComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceLevelIndicatorComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceLevelIndicatorMetricType.
    /// </summary>
    public class ServiceLevelIndicatorMetricType : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABILITY for ServiceLevelIndicatorMetricType
        /// </summary>
        public static readonly ServiceLevelIndicatorMetricType AVAILABILITY = new ServiceLevelIndicatorMetricType("AVAILABILITY");
        /// <summary>
        /// Constant LATENCY for ServiceLevelIndicatorMetricType
        /// </summary>
        public static readonly ServiceLevelIndicatorMetricType LATENCY = new ServiceLevelIndicatorMetricType("LATENCY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceLevelIndicatorMetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceLevelIndicatorMetricType FindValue(string value)
        {
            return FindValue<ServiceLevelIndicatorMetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceLevelIndicatorMetricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceLevelObjectiveBudgetStatus.
    /// </summary>
    public class ServiceLevelObjectiveBudgetStatus : ConstantClass
    {

        /// <summary>
        /// Constant BREACHED for ServiceLevelObjectiveBudgetStatus
        /// </summary>
        public static readonly ServiceLevelObjectiveBudgetStatus BREACHED = new ServiceLevelObjectiveBudgetStatus("BREACHED");
        /// <summary>
        /// Constant INSUFFICIENT_DATA for ServiceLevelObjectiveBudgetStatus
        /// </summary>
        public static readonly ServiceLevelObjectiveBudgetStatus INSUFFICIENT_DATA = new ServiceLevelObjectiveBudgetStatus("INSUFFICIENT_DATA");
        /// <summary>
        /// Constant OK for ServiceLevelObjectiveBudgetStatus
        /// </summary>
        public static readonly ServiceLevelObjectiveBudgetStatus OK = new ServiceLevelObjectiveBudgetStatus("OK");
        /// <summary>
        /// Constant WARNING for ServiceLevelObjectiveBudgetStatus
        /// </summary>
        public static readonly ServiceLevelObjectiveBudgetStatus WARNING = new ServiceLevelObjectiveBudgetStatus("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceLevelObjectiveBudgetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceLevelObjectiveBudgetStatus FindValue(string value)
        {
            return FindValue<ServiceLevelObjectiveBudgetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceLevelObjectiveBudgetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Severity.
    /// </summary>
    public class Severity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for Severity
        /// </summary>
        public static readonly Severity CRITICAL = new Severity("CRITICAL");
        /// <summary>
        /// Constant HIGH for Severity
        /// </summary>
        public static readonly Severity HIGH = new Severity("HIGH");
        /// <summary>
        /// Constant LOW for Severity
        /// </summary>
        public static readonly Severity LOW = new Severity("LOW");
        /// <summary>
        /// Constant MEDIUM for Severity
        /// </summary>
        public static readonly Severity MEDIUM = new Severity("MEDIUM");
        /// <summary>
        /// Constant NONE for Severity
        /// </summary>
        public static readonly Severity NONE = new Severity("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Severity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Severity FindValue(string value)
        {
            return FindValue<Severity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Severity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandardUnit.
    /// </summary>
    public class StandardUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Bits = new StandardUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit BitsSecond = new StandardUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Bytes = new StandardUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit BytesSecond = new StandardUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for StandardUnit
        /// </summary>
        public static readonly StandardUnit Count = new StandardUnit("Count");
        /// <summary>
        /// Constant CountSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit CountSecond = new StandardUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Gigabits = new StandardUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit GigabitsSecond = new StandardUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Gigabytes = new StandardUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit GigabytesSecond = new StandardUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Kilobits = new StandardUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit KilobitsSecond = new StandardUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Kilobytes = new StandardUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit KilobytesSecond = new StandardUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Megabits = new StandardUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit MegabitsSecond = new StandardUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Megabytes = new StandardUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit MegabytesSecond = new StandardUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Microseconds = new StandardUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Milliseconds = new StandardUnit("Milliseconds");
        /// <summary>
        /// Constant None for StandardUnit
        /// </summary>
        public static readonly StandardUnit None = new StandardUnit("None");
        /// <summary>
        /// Constant Percent for StandardUnit
        /// </summary>
        public static readonly StandardUnit Percent = new StandardUnit("Percent");
        /// <summary>
        /// Constant Seconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Seconds = new StandardUnit("Seconds");
        /// <summary>
        /// Constant Terabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Terabits = new StandardUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit TerabitsSecond = new StandardUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Terabytes = new StandardUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit TerabytesSecond = new StandardUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandardUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardUnit FindValue(string value)
        {
            return FindValue<StandardUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandardUnit(string value)
        {
            return FindValue(value);
        }
    }

}