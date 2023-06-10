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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ForecastService
{

    /// <summary>
    /// Constants used for properties of type AttributeType.
    /// </summary>
    public class AttributeType : ConstantClass
    {

        /// <summary>
        /// Constant Float for AttributeType
        /// </summary>
        public static readonly AttributeType Float = new AttributeType("float");
        /// <summary>
        /// Constant Geolocation for AttributeType
        /// </summary>
        public static readonly AttributeType Geolocation = new AttributeType("geolocation");
        /// <summary>
        /// Constant Integer for AttributeType
        /// </summary>
        public static readonly AttributeType Integer = new AttributeType("integer");
        /// <summary>
        /// Constant String for AttributeType
        /// </summary>
        public static readonly AttributeType String = new AttributeType("string");
        /// <summary>
        /// Constant Timestamp for AttributeType
        /// </summary>
        public static readonly AttributeType Timestamp = new AttributeType("timestamp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeType FindValue(string value)
        {
            return FindValue<AttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLOverrideStrategy.
    /// </summary>
    public class AutoMLOverrideStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AccuracyOptimized for AutoMLOverrideStrategy
        /// </summary>
        public static readonly AutoMLOverrideStrategy AccuracyOptimized = new AutoMLOverrideStrategy("AccuracyOptimized");
        /// <summary>
        /// Constant LatencyOptimized for AutoMLOverrideStrategy
        /// </summary>
        public static readonly AutoMLOverrideStrategy LatencyOptimized = new AutoMLOverrideStrategy("LatencyOptimized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLOverrideStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLOverrideStrategy FindValue(string value)
        {
            return FindValue<AutoMLOverrideStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLOverrideStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Condition.
    /// </summary>
    public class Condition : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for Condition
        /// </summary>
        public static readonly Condition EQUALS = new Condition("EQUALS");
        /// <summary>
        /// Constant GREATER_THAN for Condition
        /// </summary>
        public static readonly Condition GREATER_THAN = new Condition("GREATER_THAN");
        /// <summary>
        /// Constant LESS_THAN for Condition
        /// </summary>
        public static readonly Condition LESS_THAN = new Condition("LESS_THAN");
        /// <summary>
        /// Constant NOT_EQUALS for Condition
        /// </summary>
        public static readonly Condition NOT_EQUALS = new Condition("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Condition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Condition FindValue(string value)
        {
            return FindValue<Condition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Condition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetType.
    /// </summary>
    public class DatasetType : ConstantClass
    {

        /// <summary>
        /// Constant ITEM_METADATA for DatasetType
        /// </summary>
        public static readonly DatasetType ITEM_METADATA = new DatasetType("ITEM_METADATA");
        /// <summary>
        /// Constant RELATED_TIME_SERIES for DatasetType
        /// </summary>
        public static readonly DatasetType RELATED_TIME_SERIES = new DatasetType("RELATED_TIME_SERIES");
        /// <summary>
        /// Constant TARGET_TIME_SERIES for DatasetType
        /// </summary>
        public static readonly DatasetType TARGET_TIME_SERIES = new DatasetType("TARGET_TIME_SERIES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetType FindValue(string value)
        {
            return FindValue<DatasetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DayOfWeek.
    /// </summary>
    public class DayOfWeek : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek FRIDAY = new DayOfWeek("FRIDAY");
        /// <summary>
        /// Constant MONDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek MONDAY = new DayOfWeek("MONDAY");
        /// <summary>
        /// Constant SATURDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SATURDAY = new DayOfWeek("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SUNDAY = new DayOfWeek("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek THURSDAY = new DayOfWeek("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek TUESDAY = new DayOfWeek("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek WEDNESDAY = new DayOfWeek("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeek FindValue(string value)
        {
            return FindValue<DayOfWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeek(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Domain.
    /// </summary>
    public class Domain : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for Domain
        /// </summary>
        public static readonly Domain CUSTOM = new Domain("CUSTOM");
        /// <summary>
        /// Constant EC2_CAPACITY for Domain
        /// </summary>
        public static readonly Domain EC2_CAPACITY = new Domain("EC2_CAPACITY");
        /// <summary>
        /// Constant INVENTORY_PLANNING for Domain
        /// </summary>
        public static readonly Domain INVENTORY_PLANNING = new Domain("INVENTORY_PLANNING");
        /// <summary>
        /// Constant METRICS for Domain
        /// </summary>
        public static readonly Domain METRICS = new Domain("METRICS");
        /// <summary>
        /// Constant RETAIL for Domain
        /// </summary>
        public static readonly Domain RETAIL = new Domain("RETAIL");
        /// <summary>
        /// Constant WEB_TRAFFIC for Domain
        /// </summary>
        public static readonly Domain WEB_TRAFFIC = new Domain("WEB_TRAFFIC");
        /// <summary>
        /// Constant WORK_FORCE for Domain
        /// </summary>
        public static readonly Domain WORK_FORCE = new Domain("WORK_FORCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Domain(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Domain FindValue(string value)
        {
            return FindValue<Domain>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Domain(string value)
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
        /// Constant COMPUTED for EvaluationType
        /// </summary>
        public static readonly EvaluationType COMPUTED = new EvaluationType("COMPUTED");
        /// <summary>
        /// Constant SUMMARY for EvaluationType
        /// </summary>
        public static readonly EvaluationType SUMMARY = new EvaluationType("SUMMARY");

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
    /// Constants used for properties of type FeaturizationMethodName.
    /// </summary>
    public class FeaturizationMethodName : ConstantClass
    {

        /// <summary>
        /// Constant Filling for FeaturizationMethodName
        /// </summary>
        public static readonly FeaturizationMethodName Filling = new FeaturizationMethodName("filling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeaturizationMethodName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeaturizationMethodName FindValue(string value)
        {
            return FindValue<FeaturizationMethodName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeaturizationMethodName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterConditionString.
    /// </summary>
    public class FilterConditionString : ConstantClass
    {

        /// <summary>
        /// Constant IS for FilterConditionString
        /// </summary>
        public static readonly FilterConditionString IS = new FilterConditionString("IS");
        /// <summary>
        /// Constant IS_NOT for FilterConditionString
        /// </summary>
        public static readonly FilterConditionString IS_NOT = new FilterConditionString("IS_NOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterConditionString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterConditionString FindValue(string value)
        {
            return FindValue<FilterConditionString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterConditionString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportMode.
    /// </summary>
    public class ImportMode : ConstantClass
    {

        /// <summary>
        /// Constant FULL for ImportMode
        /// </summary>
        public static readonly ImportMode FULL = new ImportMode("FULL");
        /// <summary>
        /// Constant INCREMENTAL for ImportMode
        /// </summary>
        public static readonly ImportMode INCREMENTAL = new ImportMode("INCREMENTAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportMode FindValue(string value)
        {
            return FindValue<ImportMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Month.
    /// </summary>
    public class Month : ConstantClass
    {

        /// <summary>
        /// Constant APRIL for Month
        /// </summary>
        public static readonly Month APRIL = new Month("APRIL");
        /// <summary>
        /// Constant AUGUST for Month
        /// </summary>
        public static readonly Month AUGUST = new Month("AUGUST");
        /// <summary>
        /// Constant DECEMBER for Month
        /// </summary>
        public static readonly Month DECEMBER = new Month("DECEMBER");
        /// <summary>
        /// Constant FEBRUARY for Month
        /// </summary>
        public static readonly Month FEBRUARY = new Month("FEBRUARY");
        /// <summary>
        /// Constant JANUARY for Month
        /// </summary>
        public static readonly Month JANUARY = new Month("JANUARY");
        /// <summary>
        /// Constant JULY for Month
        /// </summary>
        public static readonly Month JULY = new Month("JULY");
        /// <summary>
        /// Constant JUNE for Month
        /// </summary>
        public static readonly Month JUNE = new Month("JUNE");
        /// <summary>
        /// Constant MARCH for Month
        /// </summary>
        public static readonly Month MARCH = new Month("MARCH");
        /// <summary>
        /// Constant MAY for Month
        /// </summary>
        public static readonly Month MAY = new Month("MAY");
        /// <summary>
        /// Constant NOVEMBER for Month
        /// </summary>
        public static readonly Month NOVEMBER = new Month("NOVEMBER");
        /// <summary>
        /// Constant OCTOBER for Month
        /// </summary>
        public static readonly Month OCTOBER = new Month("OCTOBER");
        /// <summary>
        /// Constant SEPTEMBER for Month
        /// </summary>
        public static readonly Month SEPTEMBER = new Month("SEPTEMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Month(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Month FindValue(string value)
        {
            return FindValue<Month>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Month(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operation.
    /// </summary>
    public class Operation : ConstantClass
    {

        /// <summary>
        /// Constant ADD for Operation
        /// </summary>
        public static readonly Operation ADD = new Operation("ADD");
        /// <summary>
        /// Constant DIVIDE for Operation
        /// </summary>
        public static readonly Operation DIVIDE = new Operation("DIVIDE");
        /// <summary>
        /// Constant MULTIPLY for Operation
        /// </summary>
        public static readonly Operation MULTIPLY = new Operation("MULTIPLY");
        /// <summary>
        /// Constant SUBTRACT for Operation
        /// </summary>
        public static readonly Operation SUBTRACT = new Operation("SUBTRACT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operation FindValue(string value)
        {
            return FindValue<Operation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptimizationMetric.
    /// </summary>
    public class OptimizationMetric : ConstantClass
    {

        /// <summary>
        /// Constant AverageWeightedQuantileLoss for OptimizationMetric
        /// </summary>
        public static readonly OptimizationMetric AverageWeightedQuantileLoss = new OptimizationMetric("AverageWeightedQuantileLoss");
        /// <summary>
        /// Constant MAPE for OptimizationMetric
        /// </summary>
        public static readonly OptimizationMetric MAPE = new OptimizationMetric("MAPE");
        /// <summary>
        /// Constant MASE for OptimizationMetric
        /// </summary>
        public static readonly OptimizationMetric MASE = new OptimizationMetric("MASE");
        /// <summary>
        /// Constant RMSE for OptimizationMetric
        /// </summary>
        public static readonly OptimizationMetric RMSE = new OptimizationMetric("RMSE");
        /// <summary>
        /// Constant WAPE for OptimizationMetric
        /// </summary>
        public static readonly OptimizationMetric WAPE = new OptimizationMetric("WAPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptimizationMetric(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptimizationMetric FindValue(string value)
        {
            return FindValue<OptimizationMetric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptimizationMetric(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingType.
    /// </summary>
    public class ScalingType : ConstantClass
    {

        /// <summary>
        /// Constant Auto for ScalingType
        /// </summary>
        public static readonly ScalingType Auto = new ScalingType("Auto");
        /// <summary>
        /// Constant Linear for ScalingType
        /// </summary>
        public static readonly ScalingType Linear = new ScalingType("Linear");
        /// <summary>
        /// Constant Logarithmic for ScalingType
        /// </summary>
        public static readonly ScalingType Logarithmic = new ScalingType("Logarithmic");
        /// <summary>
        /// Constant ReverseLogarithmic for ScalingType
        /// </summary>
        public static readonly ScalingType ReverseLogarithmic = new ScalingType("ReverseLogarithmic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingType FindValue(string value)
        {
            return FindValue<ScalingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant Active for State
        /// </summary>
        public static readonly State Active = new State("Active");
        /// <summary>
        /// Constant Deleted for State
        /// </summary>
        public static readonly State Deleted = new State("Deleted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimePointGranularity.
    /// </summary>
    public class TimePointGranularity : ConstantClass
    {

        /// <summary>
        /// Constant ALL for TimePointGranularity
        /// </summary>
        public static readonly TimePointGranularity ALL = new TimePointGranularity("ALL");
        /// <summary>
        /// Constant SPECIFIC for TimePointGranularity
        /// </summary>
        public static readonly TimePointGranularity SPECIFIC = new TimePointGranularity("SPECIFIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimePointGranularity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimePointGranularity FindValue(string value)
        {
            return FindValue<TimePointGranularity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimePointGranularity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeSeriesGranularity.
    /// </summary>
    public class TimeSeriesGranularity : ConstantClass
    {

        /// <summary>
        /// Constant ALL for TimeSeriesGranularity
        /// </summary>
        public static readonly TimeSeriesGranularity ALL = new TimeSeriesGranularity("ALL");
        /// <summary>
        /// Constant SPECIFIC for TimeSeriesGranularity
        /// </summary>
        public static readonly TimeSeriesGranularity SPECIFIC = new TimeSeriesGranularity("SPECIFIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeSeriesGranularity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeSeriesGranularity FindValue(string value)
        {
            return FindValue<TimeSeriesGranularity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeSeriesGranularity(string value)
        {
            return FindValue(value);
        }
    }

}