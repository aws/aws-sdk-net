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
 * Do not modify this file. This file is generated from the uxc-2024-07-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Uxc
{

    /// <summary>
    /// Constants used for properties of type AccountColor.
    /// </summary>
    public class AccountColor : ConstantClass
    {

        /// <summary>
        /// Constant DarkBlue for AccountColor
        /// </summary>
        public static readonly AccountColor DarkBlue = new AccountColor("darkBlue");
        /// <summary>
        /// Constant Green for AccountColor
        /// </summary>
        public static readonly AccountColor Green = new AccountColor("green");
        /// <summary>
        /// Constant LightBlue for AccountColor
        /// </summary>
        public static readonly AccountColor LightBlue = new AccountColor("lightBlue");
        /// <summary>
        /// Constant None for AccountColor
        /// </summary>
        public static readonly AccountColor None = new AccountColor("none");
        /// <summary>
        /// Constant Orange for AccountColor
        /// </summary>
        public static readonly AccountColor Orange = new AccountColor("orange");
        /// <summary>
        /// Constant Pink for AccountColor
        /// </summary>
        public static readonly AccountColor Pink = new AccountColor("pink");
        /// <summary>
        /// Constant Purple for AccountColor
        /// </summary>
        public static readonly AccountColor Purple = new AccountColor("purple");
        /// <summary>
        /// Constant Red for AccountColor
        /// </summary>
        public static readonly AccountColor Red = new AccountColor("red");
        /// <summary>
        /// Constant Teal for AccountColor
        /// </summary>
        public static readonly AccountColor Teal = new AccountColor("teal");
        /// <summary>
        /// Constant Yellow for AccountColor
        /// </summary>
        public static readonly AccountColor Yellow = new AccountColor("yellow");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountColor FindValue(string value)
        {
            return FindValue<AccountColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountColor(string value)
        {
            return FindValue(value);
        }
    }

}