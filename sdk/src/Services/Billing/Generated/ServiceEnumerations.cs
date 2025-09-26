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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Billing
{

    /// <summary>
    /// Constants used for properties of type BillingViewStatus.
    /// </summary>
    public class BillingViewStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for BillingViewStatus
        /// </summary>
        public static readonly BillingViewStatus CREATING = new BillingViewStatus("CREATING");
        /// <summary>
        /// Constant HEALTHY for BillingViewStatus
        /// </summary>
        public static readonly BillingViewStatus HEALTHY = new BillingViewStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for BillingViewStatus
        /// </summary>
        public static readonly BillingViewStatus UNHEALTHY = new BillingViewStatus("UNHEALTHY");
        /// <summary>
        /// Constant UPDATING for BillingViewStatus
        /// </summary>
        public static readonly BillingViewStatus UPDATING = new BillingViewStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingViewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingViewStatus FindValue(string value)
        {
            return FindValue<BillingViewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingViewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillingViewStatusReason.
    /// </summary>
    public class BillingViewStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant AGGREGATE_SOURCE for BillingViewStatusReason
        /// </summary>
        public static readonly BillingViewStatusReason AGGREGATE_SOURCE = new BillingViewStatusReason("AGGREGATE_SOURCE");
        /// <summary>
        /// Constant CYCLIC_DEPENDENCY for BillingViewStatusReason
        /// </summary>
        public static readonly BillingViewStatusReason CYCLIC_DEPENDENCY = new BillingViewStatusReason("CYCLIC_DEPENDENCY");
        /// <summary>
        /// Constant SOURCE_VIEW_ACCESS_DENIED for BillingViewStatusReason
        /// </summary>
        public static readonly BillingViewStatusReason SOURCE_VIEW_ACCESS_DENIED = new BillingViewStatusReason("SOURCE_VIEW_ACCESS_DENIED");
        /// <summary>
        /// Constant SOURCE_VIEW_DEPTH_EXCEEDED for BillingViewStatusReason
        /// </summary>
        public static readonly BillingViewStatusReason SOURCE_VIEW_DEPTH_EXCEEDED = new BillingViewStatusReason("SOURCE_VIEW_DEPTH_EXCEEDED");
        /// <summary>
        /// Constant SOURCE_VIEW_NOT_FOUND for BillingViewStatusReason
        /// </summary>
        public static readonly BillingViewStatusReason SOURCE_VIEW_NOT_FOUND = new BillingViewStatusReason("SOURCE_VIEW_NOT_FOUND");
        /// <summary>
        /// Constant SOURCE_VIEW_UNHEALTHY for BillingViewStatusReason
        /// </summary>
        public static readonly BillingViewStatusReason SOURCE_VIEW_UNHEALTHY = new BillingViewStatusReason("SOURCE_VIEW_UNHEALTHY");
        /// <summary>
        /// Constant SOURCE_VIEW_UPDATING for BillingViewStatusReason
        /// </summary>
        public static readonly BillingViewStatusReason SOURCE_VIEW_UPDATING = new BillingViewStatusReason("SOURCE_VIEW_UPDATING");
        /// <summary>
        /// Constant VIEW_OWNER_NOT_MANAGEMENT_ACCOUNT for BillingViewStatusReason
        /// </summary>
        public static readonly BillingViewStatusReason VIEW_OWNER_NOT_MANAGEMENT_ACCOUNT = new BillingViewStatusReason("VIEW_OWNER_NOT_MANAGEMENT_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingViewStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingViewStatusReason FindValue(string value)
        {
            return FindValue<BillingViewStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingViewStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillingViewType.
    /// </summary>
    public class BillingViewType : ConstantClass
    {

        /// <summary>
        /// Constant BILLING_GROUP for BillingViewType
        /// </summary>
        public static readonly BillingViewType BILLING_GROUP = new BillingViewType("BILLING_GROUP");
        /// <summary>
        /// Constant CUSTOM for BillingViewType
        /// </summary>
        public static readonly BillingViewType CUSTOM = new BillingViewType("CUSTOM");
        /// <summary>
        /// Constant PRIMARY for BillingViewType
        /// </summary>
        public static readonly BillingViewType PRIMARY = new BillingViewType("PRIMARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingViewType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingViewType FindValue(string value)
        {
            return FindValue<BillingViewType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingViewType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Dimension.
    /// </summary>
    public class Dimension : ConstantClass
    {

        /// <summary>
        /// Constant LINKED_ACCOUNT for Dimension
        /// </summary>
        public static readonly Dimension LINKED_ACCOUNT = new Dimension("LINKED_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Dimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Dimension FindValue(string value)
        {
            return FindValue<Dimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Dimension(string value)
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
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

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