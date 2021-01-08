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

}