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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Invoicing
{

    /// <summary>
    /// Constants used for properties of type InvoiceType.
    /// </summary>
    public class InvoiceType : ConstantClass
    {

        /// <summary>
        /// Constant CREDIT_MEMO for InvoiceType
        /// </summary>
        public static readonly InvoiceType CREDIT_MEMO = new InvoiceType("CREDIT_MEMO");
        /// <summary>
        /// Constant INVOICE for InvoiceType
        /// </summary>
        public static readonly InvoiceType INVOICE = new InvoiceType("INVOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvoiceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvoiceType FindValue(string value)
        {
            return FindValue<InvoiceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvoiceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListInvoiceSummariesResourceType.
    /// </summary>
    public class ListInvoiceSummariesResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for ListInvoiceSummariesResourceType
        /// </summary>
        public static readonly ListInvoiceSummariesResourceType ACCOUNT_ID = new ListInvoiceSummariesResourceType("ACCOUNT_ID");
        /// <summary>
        /// Constant INVOICE_ID for ListInvoiceSummariesResourceType
        /// </summary>
        public static readonly ListInvoiceSummariesResourceType INVOICE_ID = new ListInvoiceSummariesResourceType("INVOICE_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListInvoiceSummariesResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListInvoiceSummariesResourceType FindValue(string value)
        {
            return FindValue<ListInvoiceSummariesResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListInvoiceSummariesResourceType(string value)
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
        /// Constant AccountMembershipError for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason AccountMembershipError = new ValidationExceptionReason("accountMembershipError");
        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant DuplicateInvoiceUnit for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DuplicateInvoiceUnit = new ValidationExceptionReason("duplicateInvoiceUnit");
        /// <summary>
        /// Constant ExpiredNextToken for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ExpiredNextToken = new ValidationExceptionReason("expiredNextToken");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant InvalidInput for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidInput = new ValidationExceptionReason("invalidInput");
        /// <summary>
        /// Constant InvalidNextToken for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidNextToken = new ValidationExceptionReason("invalidNextToken");
        /// <summary>
        /// Constant MaxAccountsExceeded for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MaxAccountsExceeded = new ValidationExceptionReason("maxAccountsExceeded");
        /// <summary>
        /// Constant MaxInvoiceUnitsExceeded for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MaxInvoiceUnitsExceeded = new ValidationExceptionReason("maxInvoiceUnitsExceeded");
        /// <summary>
        /// Constant MutualExclusionError for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MutualExclusionError = new ValidationExceptionReason("mutualExclusionError");
        /// <summary>
        /// Constant NonMemberPresent for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason NonMemberPresent = new ValidationExceptionReason("nonMemberPresent");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant TaxSettingsError for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason TaxSettingsError = new ValidationExceptionReason("taxSettingsError");
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