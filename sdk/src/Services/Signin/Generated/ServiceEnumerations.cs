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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Signin
{

    /// <summary>
    /// Constants used for properties of type OAuth2ErrorCode.
    /// </summary>
    public class OAuth2ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AUTHCODE_EXPIRED for OAuth2ErrorCode
        /// </summary>
        public static readonly OAuth2ErrorCode AUTHCODE_EXPIRED = new OAuth2ErrorCode("AUTHCODE_EXPIRED");
        /// <summary>
        /// Constant INSUFFICIENT_PERMISSIONS for OAuth2ErrorCode
        /// </summary>
        public static readonly OAuth2ErrorCode INSUFFICIENT_PERMISSIONS = new OAuth2ErrorCode("INSUFFICIENT_PERMISSIONS");
        /// <summary>
        /// Constant INVALID_REQUEST for OAuth2ErrorCode
        /// </summary>
        public static readonly OAuth2ErrorCode INVALID_REQUEST = new OAuth2ErrorCode("INVALID_REQUEST");
        /// <summary>
        /// Constant Server_error for OAuth2ErrorCode
        /// </summary>
        public static readonly OAuth2ErrorCode Server_error = new OAuth2ErrorCode("server_error");
        /// <summary>
        /// Constant TOKEN_EXPIRED for OAuth2ErrorCode
        /// </summary>
        public static readonly OAuth2ErrorCode TOKEN_EXPIRED = new OAuth2ErrorCode("TOKEN_EXPIRED");
        /// <summary>
        /// Constant USER_CREDENTIALS_CHANGED for OAuth2ErrorCode
        /// </summary>
        public static readonly OAuth2ErrorCode USER_CREDENTIALS_CHANGED = new OAuth2ErrorCode("USER_CREDENTIALS_CHANGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OAuth2ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuth2ErrorCode FindValue(string value)
        {
            return FindValue<OAuth2ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuth2ErrorCode(string value)
        {
            return FindValue(value);
        }
    }

}