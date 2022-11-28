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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudWatch
{

    /// <summary>
    /// Constants used for properties of type ActionsSuppressedBy.
    /// </summary>
    public class ActionsSuppressedBy : ConstantClass
    {

        /// <summary>
        /// Constant Alarm for ActionsSuppressedBy
        /// </summary>
        public static readonly ActionsSuppressedBy Alarm = new ActionsSuppressedBy("Alarm");
        /// <summary>
        /// Constant ExtensionPeriod for ActionsSuppressedBy
        /// </summary>
        public static readonly ActionsSuppressedBy ExtensionPeriod = new ActionsSuppressedBy("ExtensionPeriod");
        /// <summary>
        /// Constant WaitPeriod for ActionsSuppressedBy
        /// </summary>
        public static readonly ActionsSuppressedBy WaitPeriod = new ActionsSuppressedBy("WaitPeriod");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionsSuppressedBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionsSuppressedBy FindValue(string value)
        {
            return FindValue<ActionsSuppressedBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionsSuppressedBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlarmType.
    /// </summary>
    public class AlarmType : ConstantClass
    {

        /// <summary>
        /// Constant CompositeAlarm for AlarmType
        /// </summary>
        public static readonly AlarmType CompositeAlarm = new AlarmType("CompositeAlarm");
        /// <summary>
        /// Constant MetricAlarm for AlarmType
        /// </summary>
        public static readonly AlarmType MetricAlarm = new AlarmType("MetricAlarm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlarmType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlarmType FindValue(string value)
        {
            return FindValue<AlarmType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlarmType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnomalyDetectorStateValue.
    /// </summary>
    public class AnomalyDetectorStateValue : ConstantClass
    {

        /// <summary>
        /// Constant PENDING_TRAINING for AnomalyDetectorStateValue
        /// </summary>
        public static readonly AnomalyDetectorStateValue PENDING_TRAINING = new AnomalyDetectorStateValue("PENDING_TRAINING");
        /// <summary>
        /// Constant TRAINED for AnomalyDetectorStateValue
        /// </summary>
        public static readonly AnomalyDetectorStateValue TRAINED = new AnomalyDetectorStateValue("TRAINED");
        /// <summary>
        /// Constant TRAINED_INSUFFICIENT_DATA for AnomalyDetectorStateValue
        /// </summary>
        public static readonly AnomalyDetectorStateValue TRAINED_INSUFFICIENT_DATA = new AnomalyDetectorStateValue("TRAINED_INSUFFICIENT_DATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyDetectorStateValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyDetectorStateValue FindValue(string value)
        {
            return FindValue<AnomalyDetectorStateValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyDetectorStateValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnomalyDetectorType.
    /// </summary>
    public class AnomalyDetectorType : ConstantClass
    {

        /// <summary>
        /// Constant METRIC_MATH for AnomalyDetectorType
        /// </summary>
        public static readonly AnomalyDetectorType METRIC_MATH = new AnomalyDetectorType("METRIC_MATH");
        /// <summary>
        /// Constant SINGLE_METRIC for AnomalyDetectorType
        /// </summary>
        public static readonly AnomalyDetectorType SINGLE_METRIC = new AnomalyDetectorType("SINGLE_METRIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyDetectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyDetectorType FindValue(string value)
        {
            return FindValue<AnomalyDetectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyDetectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant GreaterThanOrEqualToThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanOrEqualToThreshold = new ComparisonOperator("GreaterThanOrEqualToThreshold");
        /// <summary>
        /// Constant GreaterThanThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanThreshold = new ComparisonOperator("GreaterThanThreshold");
        /// <summary>
        /// Constant GreaterThanUpperThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanUpperThreshold = new ComparisonOperator("GreaterThanUpperThreshold");
        /// <summary>
        /// Constant LessThanLowerOrGreaterThanUpperThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanLowerOrGreaterThanUpperThreshold = new ComparisonOperator("LessThanLowerOrGreaterThanUpperThreshold");
        /// <summary>
        /// Constant LessThanLowerThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanLowerThreshold = new ComparisonOperator("LessThanLowerThreshold");
        /// <summary>
        /// Constant LessThanOrEqualToThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanOrEqualToThreshold = new ComparisonOperator("LessThanOrEqualToThreshold");
        /// <summary>
        /// Constant LessThanThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanThreshold = new ComparisonOperator("LessThanThreshold");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HistoryItemType.
    /// </summary>
    public class HistoryItemType : ConstantClass
    {

        /// <summary>
        /// Constant Action for HistoryItemType
        /// </summary>
        public static readonly HistoryItemType Action = new HistoryItemType("Action");
        /// <summary>
        /// Constant ConfigurationUpdate for HistoryItemType
        /// </summary>
        public static readonly HistoryItemType ConfigurationUpdate = new HistoryItemType("ConfigurationUpdate");
        /// <summary>
        /// Constant StateUpdate for HistoryItemType
        /// </summary>
        public static readonly HistoryItemType StateUpdate = new HistoryItemType("StateUpdate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HistoryItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HistoryItemType FindValue(string value)
        {
            return FindValue<HistoryItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HistoryItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricStreamOutputFormat.
    /// </summary>
    public class MetricStreamOutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant Json for MetricStreamOutputFormat
        /// </summary>
        public static readonly MetricStreamOutputFormat Json = new MetricStreamOutputFormat("json");
        /// <summary>
        /// Constant Opentelemetry07 for MetricStreamOutputFormat
        /// </summary>
        public static readonly MetricStreamOutputFormat Opentelemetry07 = new MetricStreamOutputFormat("opentelemetry0.7");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricStreamOutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricStreamOutputFormat FindValue(string value)
        {
            return FindValue<MetricStreamOutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricStreamOutputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecentlyActive.
    /// </summary>
    public class RecentlyActive : ConstantClass
    {

        /// <summary>
        /// Constant PT3H for RecentlyActive
        /// </summary>
        public static readonly RecentlyActive PT3H = new RecentlyActive("PT3H");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecentlyActive(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecentlyActive FindValue(string value)
        {
            return FindValue<RecentlyActive>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecentlyActive(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanBy.
    /// </summary>
    public class ScanBy : ConstantClass
    {

        /// <summary>
        /// Constant TimestampAscending for ScanBy
        /// </summary>
        public static readonly ScanBy TimestampAscending = new ScanBy("TimestampAscending");
        /// <summary>
        /// Constant TimestampDescending for ScanBy
        /// </summary>
        public static readonly ScanBy TimestampDescending = new ScanBy("TimestampDescending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanBy FindValue(string value)
        {
            return FindValue<ScanBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanBy(string value)
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


    /// <summary>
    /// Constants used for properties of type StateValue.
    /// </summary>
    public class StateValue : ConstantClass
    {

        /// <summary>
        /// Constant ALARM for StateValue
        /// </summary>
        public static readonly StateValue ALARM = new StateValue("ALARM");
        /// <summary>
        /// Constant INSUFFICIENT_DATA for StateValue
        /// </summary>
        public static readonly StateValue INSUFFICIENT_DATA = new StateValue("INSUFFICIENT_DATA");
        /// <summary>
        /// Constant OK for StateValue
        /// </summary>
        public static readonly StateValue OK = new StateValue("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StateValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StateValue FindValue(string value)
        {
            return FindValue<StateValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StateValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Statistic.
    /// </summary>
    public class Statistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for Statistic
        /// </summary>
        public static readonly Statistic Average = new Statistic("Average");
        /// <summary>
        /// Constant Maximum for Statistic
        /// </summary>
        public static readonly Statistic Maximum = new Statistic("Maximum");
        /// <summary>
        /// Constant Minimum for Statistic
        /// </summary>
        public static readonly Statistic Minimum = new Statistic("Minimum");
        /// <summary>
        /// Constant SampleCount for Statistic
        /// </summary>
        public static readonly Statistic SampleCount = new Statistic("SampleCount");
        /// <summary>
        /// Constant Sum for Statistic
        /// </summary>
        public static readonly Statistic Sum = new Statistic("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Statistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Statistic FindValue(string value)
        {
            return FindValue<Statistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Statistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusCode.
    /// </summary>
    public class StatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Complete for StatusCode
        /// </summary>
        public static readonly StatusCode Complete = new StatusCode("Complete");
        /// <summary>
        /// Constant Forbidden for StatusCode
        /// </summary>
        public static readonly StatusCode Forbidden = new StatusCode("Forbidden");
        /// <summary>
        /// Constant InternalError for StatusCode
        /// </summary>
        public static readonly StatusCode InternalError = new StatusCode("InternalError");
        /// <summary>
        /// Constant PartialData for StatusCode
        /// </summary>
        public static readonly StatusCode PartialData = new StatusCode("PartialData");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusCode FindValue(string value)
        {
            return FindValue<StatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusCode(string value)
        {
            return FindValue(value);
        }
    }

}