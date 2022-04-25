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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RDSDataService
{

    /// <summary>
    /// Constants used for properties of type DecimalReturnType.
    /// </summary>
    public class DecimalReturnType : ConstantClass
    {

        /// <summary>
        /// Constant DOUBLE_OR_LONG for DecimalReturnType
        /// </summary>
        public static readonly DecimalReturnType DOUBLE_OR_LONG = new DecimalReturnType("DOUBLE_OR_LONG");
        /// <summary>
        /// Constant STRING for DecimalReturnType
        /// </summary>
        public static readonly DecimalReturnType STRING = new DecimalReturnType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DecimalReturnType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DecimalReturnType FindValue(string value)
        {
            return FindValue<DecimalReturnType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DecimalReturnType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LongReturnType.
    /// </summary>
    public class LongReturnType : ConstantClass
    {

        /// <summary>
        /// Constant LONG for LongReturnType
        /// </summary>
        public static readonly LongReturnType LONG = new LongReturnType("LONG");
        /// <summary>
        /// Constant STRING for LongReturnType
        /// </summary>
        public static readonly LongReturnType STRING = new LongReturnType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LongReturnType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LongReturnType FindValue(string value)
        {
            return FindValue<LongReturnType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LongReturnType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordsFormatType.
    /// </summary>
    public class RecordsFormatType : ConstantClass
    {

        /// <summary>
        /// Constant JSON for RecordsFormatType
        /// </summary>
        public static readonly RecordsFormatType JSON = new RecordsFormatType("JSON");
        /// <summary>
        /// Constant NONE for RecordsFormatType
        /// </summary>
        public static readonly RecordsFormatType NONE = new RecordsFormatType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordsFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordsFormatType FindValue(string value)
        {
            return FindValue<RecordsFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordsFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TypeHint.
    /// </summary>
    public class TypeHint : ConstantClass
    {

        /// <summary>
        /// Constant DATE for TypeHint
        /// </summary>
        public static readonly TypeHint DATE = new TypeHint("DATE");
        /// <summary>
        /// Constant DECIMAL for TypeHint
        /// </summary>
        public static readonly TypeHint DECIMAL = new TypeHint("DECIMAL");
        /// <summary>
        /// Constant JSON for TypeHint
        /// </summary>
        public static readonly TypeHint JSON = new TypeHint("JSON");
        /// <summary>
        /// Constant TIME for TypeHint
        /// </summary>
        public static readonly TypeHint TIME = new TypeHint("TIME");
        /// <summary>
        /// Constant TIMESTAMP for TypeHint
        /// </summary>
        public static readonly TypeHint TIMESTAMP = new TypeHint("TIMESTAMP");
        /// <summary>
        /// Constant UUID for TypeHint
        /// </summary>
        public static readonly TypeHint UUID = new TypeHint("UUID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TypeHint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TypeHint FindValue(string value)
        {
            return FindValue<TypeHint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TypeHint(string value)
        {
            return FindValue(value);
        }
    }

}