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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.TimestreamQuery
{

    /// <summary>
    /// Constants used for properties of type ScalarType.
    /// </summary>
    public class ScalarType : ConstantClass
    {

        /// <summary>
        /// Constant BIGINT for ScalarType
        /// </summary>
        public static readonly ScalarType BIGINT = new ScalarType("BIGINT");
        /// <summary>
        /// Constant BOOLEAN for ScalarType
        /// </summary>
        public static readonly ScalarType BOOLEAN = new ScalarType("BOOLEAN");
        /// <summary>
        /// Constant DATE for ScalarType
        /// </summary>
        public static readonly ScalarType DATE = new ScalarType("DATE");
        /// <summary>
        /// Constant DOUBLE for ScalarType
        /// </summary>
        public static readonly ScalarType DOUBLE = new ScalarType("DOUBLE");
        /// <summary>
        /// Constant INTEGER for ScalarType
        /// </summary>
        public static readonly ScalarType INTEGER = new ScalarType("INTEGER");
        /// <summary>
        /// Constant INTERVAL_DAY_TO_SECOND for ScalarType
        /// </summary>
        public static readonly ScalarType INTERVAL_DAY_TO_SECOND = new ScalarType("INTERVAL_DAY_TO_SECOND");
        /// <summary>
        /// Constant INTERVAL_YEAR_TO_MONTH for ScalarType
        /// </summary>
        public static readonly ScalarType INTERVAL_YEAR_TO_MONTH = new ScalarType("INTERVAL_YEAR_TO_MONTH");
        /// <summary>
        /// Constant TIME for ScalarType
        /// </summary>
        public static readonly ScalarType TIME = new ScalarType("TIME");
        /// <summary>
        /// Constant TIMESTAMP for ScalarType
        /// </summary>
        public static readonly ScalarType TIMESTAMP = new ScalarType("TIMESTAMP");
        /// <summary>
        /// Constant UNKNOWN for ScalarType
        /// </summary>
        public static readonly ScalarType UNKNOWN = new ScalarType("UNKNOWN");
        /// <summary>
        /// Constant VARCHAR for ScalarType
        /// </summary>
        public static readonly ScalarType VARCHAR = new ScalarType("VARCHAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalarType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalarType FindValue(string value)
        {
            return FindValue<ScalarType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalarType(string value)
        {
            return FindValue(value);
        }
    }

}