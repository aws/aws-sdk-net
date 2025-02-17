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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudControlApi
{

    /// <summary>
    /// Constants used for properties of type HandlerErrorCode.
    /// </summary>
    public class HandlerErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode AccessDenied = new HandlerErrorCode("AccessDenied");
        /// <summary>
        /// Constant AlreadyExists for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode AlreadyExists = new HandlerErrorCode("AlreadyExists");
        /// <summary>
        /// Constant GeneralServiceException for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode GeneralServiceException = new HandlerErrorCode("GeneralServiceException");
        /// <summary>
        /// Constant InternalFailure for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode InternalFailure = new HandlerErrorCode("InternalFailure");
        /// <summary>
        /// Constant InvalidCredentials for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode InvalidCredentials = new HandlerErrorCode("InvalidCredentials");
        /// <summary>
        /// Constant InvalidRequest for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode InvalidRequest = new HandlerErrorCode("InvalidRequest");
        /// <summary>
        /// Constant NetworkFailure for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NetworkFailure = new HandlerErrorCode("NetworkFailure");
        /// <summary>
        /// Constant NotFound for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NotFound = new HandlerErrorCode("NotFound");
        /// <summary>
        /// Constant NotStabilized for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NotStabilized = new HandlerErrorCode("NotStabilized");
        /// <summary>
        /// Constant NotUpdatable for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NotUpdatable = new HandlerErrorCode("NotUpdatable");
        /// <summary>
        /// Constant ResourceConflict for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode ResourceConflict = new HandlerErrorCode("ResourceConflict");
        /// <summary>
        /// Constant ServiceInternalError for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode ServiceInternalError = new HandlerErrorCode("ServiceInternalError");
        /// <summary>
        /// Constant ServiceLimitExceeded for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode ServiceLimitExceeded = new HandlerErrorCode("ServiceLimitExceeded");
        /// <summary>
        /// Constant ServiceTimeout for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode ServiceTimeout = new HandlerErrorCode("ServiceTimeout");
        /// <summary>
        /// Constant Throttling for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode Throttling = new HandlerErrorCode("Throttling");
        /// <summary>
        /// Constant UnauthorizedTaggingOperation for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode UnauthorizedTaggingOperation = new HandlerErrorCode("UnauthorizedTaggingOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandlerErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandlerErrorCode FindValue(string value)
        {
            return FindValue<HandlerErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandlerErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operation.
    /// </summary>
    public class Operation : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for Operation
        /// </summary>
        public static readonly Operation CREATE = new Operation("CREATE");
        /// <summary>
        /// Constant DELETE for Operation
        /// </summary>
        public static readonly Operation DELETE = new Operation("DELETE");
        /// <summary>
        /// Constant UPDATE for Operation
        /// </summary>
        public static readonly Operation UPDATE = new Operation("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operation FindValue(string value)
        {
            return FindValue<Operation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationStatus.
    /// </summary>
    public class OperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL_COMPLETE for OperationStatus
        /// </summary>
        public static readonly OperationStatus CANCEL_COMPLETE = new OperationStatus("CANCEL_COMPLETE");
        /// <summary>
        /// Constant CANCEL_IN_PROGRESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus CANCEL_IN_PROGRESS = new OperationStatus("CANCEL_IN_PROGRESS");
        /// <summary>
        /// Constant FAILED for OperationStatus
        /// </summary>
        public static readonly OperationStatus FAILED = new OperationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus IN_PROGRESS = new OperationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for OperationStatus
        /// </summary>
        public static readonly OperationStatus PENDING = new OperationStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUCCESS = new OperationStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationStatus FindValue(string value)
        {
            return FindValue<OperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationStatus(string value)
        {
            return FindValue(value);
        }
    }

}