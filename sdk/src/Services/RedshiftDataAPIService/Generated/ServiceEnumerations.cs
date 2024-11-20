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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RedshiftDataAPIService
{

    /// <summary>
    /// Constants used for properties of type ResultFormatString.
    /// </summary>
    public class ResultFormatString : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ResultFormatString
        /// </summary>
        public static readonly ResultFormatString CSV = new ResultFormatString("CSV");
        /// <summary>
        /// Constant JSON for ResultFormatString
        /// </summary>
        public static readonly ResultFormatString JSON = new ResultFormatString("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResultFormatString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResultFormatString FindValue(string value)
        {
            return FindValue<ResultFormatString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResultFormatString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatementStatusString.
    /// </summary>
    public class StatementStatusString : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for StatementStatusString
        /// </summary>
        public static readonly StatementStatusString ABORTED = new StatementStatusString("ABORTED");
        /// <summary>
        /// Constant FAILED for StatementStatusString
        /// </summary>
        public static readonly StatementStatusString FAILED = new StatementStatusString("FAILED");
        /// <summary>
        /// Constant FINISHED for StatementStatusString
        /// </summary>
        public static readonly StatementStatusString FINISHED = new StatementStatusString("FINISHED");
        /// <summary>
        /// Constant PICKED for StatementStatusString
        /// </summary>
        public static readonly StatementStatusString PICKED = new StatementStatusString("PICKED");
        /// <summary>
        /// Constant STARTED for StatementStatusString
        /// </summary>
        public static readonly StatementStatusString STARTED = new StatementStatusString("STARTED");
        /// <summary>
        /// Constant SUBMITTED for StatementStatusString
        /// </summary>
        public static readonly StatementStatusString SUBMITTED = new StatementStatusString("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatementStatusString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatementStatusString FindValue(string value)
        {
            return FindValue<StatementStatusString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatementStatusString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusString.
    /// </summary>
    public class StatusString : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for StatusString
        /// </summary>
        public static readonly StatusString ABORTED = new StatusString("ABORTED");
        /// <summary>
        /// Constant ALL for StatusString
        /// </summary>
        public static readonly StatusString ALL = new StatusString("ALL");
        /// <summary>
        /// Constant FAILED for StatusString
        /// </summary>
        public static readonly StatusString FAILED = new StatusString("FAILED");
        /// <summary>
        /// Constant FINISHED for StatusString
        /// </summary>
        public static readonly StatusString FINISHED = new StatusString("FINISHED");
        /// <summary>
        /// Constant PICKED for StatusString
        /// </summary>
        public static readonly StatusString PICKED = new StatusString("PICKED");
        /// <summary>
        /// Constant STARTED for StatusString
        /// </summary>
        public static readonly StatusString STARTED = new StatusString("STARTED");
        /// <summary>
        /// Constant SUBMITTED for StatusString
        /// </summary>
        public static readonly StatusString SUBMITTED = new StatusString("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusString FindValue(string value)
        {
            return FindValue<StatusString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusString(string value)
        {
            return FindValue(value);
        }
    }

}