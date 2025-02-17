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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SageMakerMetrics
{

    /// <summary>
    /// Constants used for properties of type MetricQueryResultStatus.
    /// </summary>
    public class MetricQueryResultStatus : ConstantClass
    {

        /// <summary>
        /// Constant Complete for MetricQueryResultStatus
        /// </summary>
        public static readonly MetricQueryResultStatus Complete = new MetricQueryResultStatus("Complete");
        /// <summary>
        /// Constant InternalError for MetricQueryResultStatus
        /// </summary>
        public static readonly MetricQueryResultStatus InternalError = new MetricQueryResultStatus("InternalError");
        /// <summary>
        /// Constant Truncated for MetricQueryResultStatus
        /// </summary>
        public static readonly MetricQueryResultStatus Truncated = new MetricQueryResultStatus("Truncated");
        /// <summary>
        /// Constant ValidationError for MetricQueryResultStatus
        /// </summary>
        public static readonly MetricQueryResultStatus ValidationError = new MetricQueryResultStatus("ValidationError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricQueryResultStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricQueryResultStatus FindValue(string value)
        {
            return FindValue<MetricQueryResultStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricQueryResultStatus(string value)
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
        /// Constant Avg for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Avg = new MetricStatistic("Avg");
        /// <summary>
        /// Constant Count for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Count = new MetricStatistic("Count");
        /// <summary>
        /// Constant Last for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Last = new MetricStatistic("Last");
        /// <summary>
        /// Constant Max for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Max = new MetricStatistic("Max");
        /// <summary>
        /// Constant Min for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Min = new MetricStatistic("Min");
        /// <summary>
        /// Constant StdDev for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic StdDev = new MetricStatistic("StdDev");

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
    /// Constants used for properties of type Period.
    /// </summary>
    public class Period : ConstantClass
    {

        /// <summary>
        /// Constant FiveMinute for Period
        /// </summary>
        public static readonly Period FiveMinute = new Period("FiveMinute");
        /// <summary>
        /// Constant IterationNumber for Period
        /// </summary>
        public static readonly Period IterationNumber = new Period("IterationNumber");
        /// <summary>
        /// Constant OneHour for Period
        /// </summary>
        public static readonly Period OneHour = new Period("OneHour");
        /// <summary>
        /// Constant OneMinute for Period
        /// </summary>
        public static readonly Period OneMinute = new Period("OneMinute");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Period(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Period FindValue(string value)
        {
            return FindValue<Period>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Period(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PutMetricsErrorCode.
    /// </summary>
    public class PutMetricsErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CONFLICT_ERROR for PutMetricsErrorCode
        /// </summary>
        public static readonly PutMetricsErrorCode CONFLICT_ERROR = new PutMetricsErrorCode("CONFLICT_ERROR");
        /// <summary>
        /// Constant INTERNAL_ERROR for PutMetricsErrorCode
        /// </summary>
        public static readonly PutMetricsErrorCode INTERNAL_ERROR = new PutMetricsErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant METRIC_LIMIT_EXCEEDED for PutMetricsErrorCode
        /// </summary>
        public static readonly PutMetricsErrorCode METRIC_LIMIT_EXCEEDED = new PutMetricsErrorCode("METRIC_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant VALIDATION_ERROR for PutMetricsErrorCode
        /// </summary>
        public static readonly PutMetricsErrorCode VALIDATION_ERROR = new PutMetricsErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PutMetricsErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PutMetricsErrorCode FindValue(string value)
        {
            return FindValue<PutMetricsErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PutMetricsErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XAxisType.
    /// </summary>
    public class XAxisType : ConstantClass
    {

        /// <summary>
        /// Constant IterationNumber for XAxisType
        /// </summary>
        public static readonly XAxisType IterationNumber = new XAxisType("IterationNumber");
        /// <summary>
        /// Constant Timestamp for XAxisType
        /// </summary>
        public static readonly XAxisType Timestamp = new XAxisType("Timestamp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XAxisType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XAxisType FindValue(string value)
        {
            return FindValue<XAxisType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XAxisType(string value)
        {
            return FindValue(value);
        }
    }

}