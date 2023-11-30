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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MarketplaceAgreement
{

    /// <summary>
    /// Constants used for properties of type AgreementStatus.
    /// </summary>
    public class AgreementStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus ACTIVE = new AgreementStatus("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus ARCHIVED = new AgreementStatus("ARCHIVED");
        /// <summary>
        /// Constant CANCELLED for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus CANCELLED = new AgreementStatus("CANCELLED");
        /// <summary>
        /// Constant EXPIRED for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus EXPIRED = new AgreementStatus("EXPIRED");
        /// <summary>
        /// Constant RENEWED for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus RENEWED = new AgreementStatus("RENEWED");
        /// <summary>
        /// Constant REPLACED for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus REPLACED = new AgreementStatus("REPLACED");
        /// <summary>
        /// Constant ROLLED_BACK for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus ROLLED_BACK = new AgreementStatus("ROLLED_BACK");
        /// <summary>
        /// Constant SUPERSEDED for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus SUPERSEDED = new AgreementStatus("SUPERSEDED");
        /// <summary>
        /// Constant TERMINATED for AgreementStatus
        /// </summary>
        public static readonly AgreementStatus TERMINATED = new AgreementStatus("TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgreementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgreementStatus FindValue(string value)
        {
            return FindValue<AgreementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgreementStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Agreement for ResourceType
        /// </summary>
        public static readonly ResourceType Agreement = new ResourceType("Agreement");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
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
        /// Constant INVALID_AGREEMENT_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_AGREEMENT_ID = new ValidationExceptionReason("INVALID_AGREEMENT_ID");
        /// <summary>
        /// Constant INVALID_CATALOG for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CATALOG = new ValidationExceptionReason("INVALID_CATALOG");
        /// <summary>
        /// Constant INVALID_FILTER_NAME for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_FILTER_NAME = new ValidationExceptionReason("INVALID_FILTER_NAME");
        /// <summary>
        /// Constant INVALID_FILTER_VALUES for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_FILTER_VALUES = new ValidationExceptionReason("INVALID_FILTER_VALUES");
        /// <summary>
        /// Constant INVALID_MAX_RESULTS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_MAX_RESULTS = new ValidationExceptionReason("INVALID_MAX_RESULTS");
        /// <summary>
        /// Constant INVALID_NEXT_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_NEXT_TOKEN = new ValidationExceptionReason("INVALID_NEXT_TOKEN");
        /// <summary>
        /// Constant INVALID_SORT_BY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_SORT_BY = new ValidationExceptionReason("INVALID_SORT_BY");
        /// <summary>
        /// Constant INVALID_SORT_ORDER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_SORT_ORDER = new ValidationExceptionReason("INVALID_SORT_ORDER");
        /// <summary>
        /// Constant MISSING_AGREEMENT_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_AGREEMENT_ID = new ValidationExceptionReason("MISSING_AGREEMENT_ID");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNSUPPORTED_FILTERS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNSUPPORTED_FILTERS = new ValidationExceptionReason("UNSUPPORTED_FILTERS");

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