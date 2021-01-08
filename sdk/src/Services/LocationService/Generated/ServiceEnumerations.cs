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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LocationService
{

    /// <summary>
    /// Constants used for properties of type BatchItemErrorCode.
    /// </summary>
    public class BatchItemErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode AccessDeniedError = new BatchItemErrorCode("AccessDeniedError");
        /// <summary>
        /// Constant ConflictError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode ConflictError = new BatchItemErrorCode("ConflictError");
        /// <summary>
        /// Constant InternalServerError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode InternalServerError = new BatchItemErrorCode("InternalServerError");
        /// <summary>
        /// Constant ResourceNotFoundError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode ResourceNotFoundError = new BatchItemErrorCode("ResourceNotFoundError");
        /// <summary>
        /// Constant ThrottlingError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode ThrottlingError = new BatchItemErrorCode("ThrottlingError");
        /// <summary>
        /// Constant ValidationError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode ValidationError = new BatchItemErrorCode("ValidationError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchItemErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchItemErrorCode FindValue(string value)
        {
            return FindValue<BatchItemErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchItemErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntendedUse.
    /// </summary>
    public class IntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for IntendedUse
        /// </summary>
        public static readonly IntendedUse SingleUse = new IntendedUse("SingleUse");
        /// <summary>
        /// Constant Storage for IntendedUse
        /// </summary>
        public static readonly IntendedUse Storage = new IntendedUse("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntendedUse FindValue(string value)
        {
            return FindValue<IntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PricingPlan.
    /// </summary>
    public class PricingPlan : ConstantClass
    {

        /// <summary>
        /// Constant MobileAssetManagement for PricingPlan
        /// </summary>
        public static readonly PricingPlan MobileAssetManagement = new PricingPlan("MobileAssetManagement");
        /// <summary>
        /// Constant MobileAssetTracking for PricingPlan
        /// </summary>
        public static readonly PricingPlan MobileAssetTracking = new PricingPlan("MobileAssetTracking");
        /// <summary>
        /// Constant RequestBasedUsage for PricingPlan
        /// </summary>
        public static readonly PricingPlan RequestBasedUsage = new PricingPlan("RequestBasedUsage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PricingPlan(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PricingPlan FindValue(string value)
        {
            return FindValue<PricingPlan>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PricingPlan(string value)
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
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("CannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");
        /// <summary>
        /// Constant Missing for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Missing = new ValidationExceptionReason("Missing");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("Other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("UnknownOperation");

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