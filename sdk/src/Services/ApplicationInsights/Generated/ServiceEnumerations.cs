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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApplicationInsights
{

    /// <summary>
    /// Constants used for properties of type FeedbackKey.
    /// </summary>
    public class FeedbackKey : ConstantClass
    {

        /// <summary>
        /// Constant INSIGHTS_FEEDBACK for FeedbackKey
        /// </summary>
        public static readonly FeedbackKey INSIGHTS_FEEDBACK = new FeedbackKey("INSIGHTS_FEEDBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeedbackKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedbackKey FindValue(string value)
        {
            return FindValue<FeedbackKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedbackKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeedbackValue.
    /// </summary>
    public class FeedbackValue : ConstantClass
    {

        /// <summary>
        /// Constant NOT_SPECIFIED for FeedbackValue
        /// </summary>
        public static readonly FeedbackValue NOT_SPECIFIED = new FeedbackValue("NOT_SPECIFIED");
        /// <summary>
        /// Constant NOT_USEFUL for FeedbackValue
        /// </summary>
        public static readonly FeedbackValue NOT_USEFUL = new FeedbackValue("NOT_USEFUL");
        /// <summary>
        /// Constant USEFUL for FeedbackValue
        /// </summary>
        public static readonly FeedbackValue USEFUL = new FeedbackValue("USEFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeedbackValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedbackValue FindValue(string value)
        {
            return FindValue<FeedbackValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedbackValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogFilter.
    /// </summary>
    public class LogFilter : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for LogFilter
        /// </summary>
        public static readonly LogFilter ERROR = new LogFilter("ERROR");
        /// <summary>
        /// Constant INFO for LogFilter
        /// </summary>
        public static readonly LogFilter INFO = new LogFilter("INFO");
        /// <summary>
        /// Constant WARN for LogFilter
        /// </summary>
        public static readonly LogFilter WARN = new LogFilter("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogFilter FindValue(string value)
        {
            return FindValue<LogFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SeverityLevel.
    /// </summary>
    public class SeverityLevel : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for SeverityLevel
        /// </summary>
        public static readonly SeverityLevel HIGH = new SeverityLevel("HIGH");
        /// <summary>
        /// Constant LOW for SeverityLevel
        /// </summary>
        public static readonly SeverityLevel LOW = new SeverityLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for SeverityLevel
        /// </summary>
        public static readonly SeverityLevel MEDIUM = new SeverityLevel("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SeverityLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SeverityLevel FindValue(string value)
        {
            return FindValue<SeverityLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SeverityLevel(string value)
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
        /// Constant IGNORE for Status
        /// </summary>
        public static readonly Status IGNORE = new Status("IGNORE");
        /// <summary>
        /// Constant PENDING for Status
        /// </summary>
        public static readonly Status PENDING = new Status("PENDING");
        /// <summary>
        /// Constant RESOLVED for Status
        /// </summary>
        public static readonly Status RESOLVED = new Status("RESOLVED");

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