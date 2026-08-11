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
 * Do not modify this file. This file is generated from the account-access-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AccountAccess
{

    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AUTHORIZATION_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode AUTHORIZATION_ERROR = new ErrorCode("AUTHORIZATION_ERROR");
        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_SERVICE_ERROR = new ErrorCode("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_NOT_FOUND_ERROR = new ErrorCode("RESOURCE_NOT_FOUND_ERROR");
        /// <summary>
        /// Constant SERVICE_QUOTA_EXCEEDED_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode SERVICE_QUOTA_EXCEEDED_ERROR = new ErrorCode("SERVICE_QUOTA_EXCEEDED_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
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
        /// Constant ACTIVE for Status
        /// </summary>
        public static readonly Status ACTIVE = new Status("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for Status
        /// </summary>
        public static readonly Status CREATE_FAILED = new Status("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for Status
        /// </summary>
        public static readonly Status CREATE_IN_PROGRESS = new Status("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for Status
        /// </summary>
        public static readonly Status DELETE_FAILED = new Status("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for Status
        /// </summary>
        public static readonly Status DELETE_IN_PROGRESS = new Status("DELETE_IN_PROGRESS");

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