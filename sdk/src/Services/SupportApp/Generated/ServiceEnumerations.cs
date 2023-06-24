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
 * Do not modify this file. This file is generated from the support-app-2021-08-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SupportApp
{

    /// <summary>
    /// Constants used for properties of type AccountType.
    /// </summary>
    public class AccountType : ConstantClass
    {

        /// <summary>
        /// Constant Management for AccountType
        /// </summary>
        public static readonly AccountType Management = new AccountType("management");
        /// <summary>
        /// Constant Member for AccountType
        /// </summary>
        public static readonly AccountType Member = new AccountType("member");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountType FindValue(string value)
        {
            return FindValue<AccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationSeverityLevel.
    /// </summary>
    public class NotificationSeverityLevel : ConstantClass
    {

        /// <summary>
        /// Constant All for NotificationSeverityLevel
        /// </summary>
        public static readonly NotificationSeverityLevel All = new NotificationSeverityLevel("all");
        /// <summary>
        /// Constant High for NotificationSeverityLevel
        /// </summary>
        public static readonly NotificationSeverityLevel High = new NotificationSeverityLevel("high");
        /// <summary>
        /// Constant None for NotificationSeverityLevel
        /// </summary>
        public static readonly NotificationSeverityLevel None = new NotificationSeverityLevel("none");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationSeverityLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationSeverityLevel FindValue(string value)
        {
            return FindValue<NotificationSeverityLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationSeverityLevel(string value)
        {
            return FindValue(value);
        }
    }

}