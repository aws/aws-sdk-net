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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Account
{

    /// <summary>
    /// Constants used for properties of type AlternateContactType.
    /// </summary>
    public class AlternateContactType : ConstantClass
    {

        /// <summary>
        /// Constant BILLING for AlternateContactType
        /// </summary>
        public static readonly AlternateContactType BILLING = new AlternateContactType("BILLING");
        /// <summary>
        /// Constant OPERATIONS for AlternateContactType
        /// </summary>
        public static readonly AlternateContactType OPERATIONS = new AlternateContactType("OPERATIONS");
        /// <summary>
        /// Constant SECURITY for AlternateContactType
        /// </summary>
        public static readonly AlternateContactType SECURITY = new AlternateContactType("SECURITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlternateContactType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlternateContactType FindValue(string value)
        {
            return FindValue<AlternateContactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlternateContactType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionOptStatus.
    /// </summary>
    public class RegionOptStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RegionOptStatus
        /// </summary>
        public static readonly RegionOptStatus DISABLED = new RegionOptStatus("DISABLED");
        /// <summary>
        /// Constant DISABLING for RegionOptStatus
        /// </summary>
        public static readonly RegionOptStatus DISABLING = new RegionOptStatus("DISABLING");
        /// <summary>
        /// Constant ENABLED for RegionOptStatus
        /// </summary>
        public static readonly RegionOptStatus ENABLED = new RegionOptStatus("ENABLED");
        /// <summary>
        /// Constant ENABLED_BY_DEFAULT for RegionOptStatus
        /// </summary>
        public static readonly RegionOptStatus ENABLED_BY_DEFAULT = new RegionOptStatus("ENABLED_BY_DEFAULT");
        /// <summary>
        /// Constant ENABLING for RegionOptStatus
        /// </summary>
        public static readonly RegionOptStatus ENABLING = new RegionOptStatus("ENABLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionOptStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionOptStatus FindValue(string value)
        {
            return FindValue<RegionOptStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionOptStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant InvalidRegionOptTarget for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidRegionOptTarget = new ValidationExceptionReason("invalidRegionOptTarget");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}