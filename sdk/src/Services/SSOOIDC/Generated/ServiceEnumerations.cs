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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SSOOIDC
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant KMS_AccessDeniedException for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason KMS_AccessDeniedException = new AccessDeniedExceptionReason("KMS_AccessDeniedException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedExceptionReason FindValue(string value)
        {
            return FindValue<AccessDeniedExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvalidRequestExceptionReason.
    /// </summary>
    public class InvalidRequestExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant KMS_DisabledException for InvalidRequestExceptionReason
        /// </summary>
        public static readonly InvalidRequestExceptionReason KMS_DisabledException = new InvalidRequestExceptionReason("KMS_DisabledException");
        /// <summary>
        /// Constant KMS_InvalidKeyUsageException for InvalidRequestExceptionReason
        /// </summary>
        public static readonly InvalidRequestExceptionReason KMS_InvalidKeyUsageException = new InvalidRequestExceptionReason("KMS_InvalidKeyUsageException");
        /// <summary>
        /// Constant KMS_InvalidStateException for InvalidRequestExceptionReason
        /// </summary>
        public static readonly InvalidRequestExceptionReason KMS_InvalidStateException = new InvalidRequestExceptionReason("KMS_InvalidStateException");
        /// <summary>
        /// Constant KMS_NotFoundException for InvalidRequestExceptionReason
        /// </summary>
        public static readonly InvalidRequestExceptionReason KMS_NotFoundException = new InvalidRequestExceptionReason("KMS_NotFoundException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvalidRequestExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvalidRequestExceptionReason FindValue(string value)
        {
            return FindValue<InvalidRequestExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvalidRequestExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}