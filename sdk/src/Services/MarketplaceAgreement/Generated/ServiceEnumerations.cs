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
    /// Constants used for properties of type AgreementCancellationRequestReasonCode.
    /// </summary>
    public class AgreementCancellationRequestReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant ALTERNATIVE_PROCUREMENT_CHANNEL for AgreementCancellationRequestReasonCode
        /// </summary>
        public static readonly AgreementCancellationRequestReasonCode ALTERNATIVE_PROCUREMENT_CHANNEL = new AgreementCancellationRequestReasonCode("ALTERNATIVE_PROCUREMENT_CHANNEL");
        /// <summary>
        /// Constant BUYER_DISSATISFACTION for AgreementCancellationRequestReasonCode
        /// </summary>
        public static readonly AgreementCancellationRequestReasonCode BUYER_DISSATISFACTION = new AgreementCancellationRequestReasonCode("BUYER_DISSATISFACTION");
        /// <summary>
        /// Constant INCORRECT_TERMS_ACCEPTED for AgreementCancellationRequestReasonCode
        /// </summary>
        public static readonly AgreementCancellationRequestReasonCode INCORRECT_TERMS_ACCEPTED = new AgreementCancellationRequestReasonCode("INCORRECT_TERMS_ACCEPTED");
        /// <summary>
        /// Constant OTHER for AgreementCancellationRequestReasonCode
        /// </summary>
        public static readonly AgreementCancellationRequestReasonCode OTHER = new AgreementCancellationRequestReasonCode("OTHER");
        /// <summary>
        /// Constant PRODUCT_DISCONTINUED for AgreementCancellationRequestReasonCode
        /// </summary>
        public static readonly AgreementCancellationRequestReasonCode PRODUCT_DISCONTINUED = new AgreementCancellationRequestReasonCode("PRODUCT_DISCONTINUED");
        /// <summary>
        /// Constant REPLACING_AGREEMENT for AgreementCancellationRequestReasonCode
        /// </summary>
        public static readonly AgreementCancellationRequestReasonCode REPLACING_AGREEMENT = new AgreementCancellationRequestReasonCode("REPLACING_AGREEMENT");
        /// <summary>
        /// Constant TEST_AGREEMENT for AgreementCancellationRequestReasonCode
        /// </summary>
        public static readonly AgreementCancellationRequestReasonCode TEST_AGREEMENT = new AgreementCancellationRequestReasonCode("TEST_AGREEMENT");
        /// <summary>
        /// Constant UNINTENDED_RENEWAL for AgreementCancellationRequestReasonCode
        /// </summary>
        public static readonly AgreementCancellationRequestReasonCode UNINTENDED_RENEWAL = new AgreementCancellationRequestReasonCode("UNINTENDED_RENEWAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgreementCancellationRequestReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgreementCancellationRequestReasonCode FindValue(string value)
        {
            return FindValue<AgreementCancellationRequestReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgreementCancellationRequestReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgreementCancellationRequestStatus.
    /// </summary>
    public class AgreementCancellationRequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for AgreementCancellationRequestStatus
        /// </summary>
        public static readonly AgreementCancellationRequestStatus APPROVED = new AgreementCancellationRequestStatus("APPROVED");
        /// <summary>
        /// Constant CANCELLED for AgreementCancellationRequestStatus
        /// </summary>
        public static readonly AgreementCancellationRequestStatus CANCELLED = new AgreementCancellationRequestStatus("CANCELLED");
        /// <summary>
        /// Constant PENDING_APPROVAL for AgreementCancellationRequestStatus
        /// </summary>
        public static readonly AgreementCancellationRequestStatus PENDING_APPROVAL = new AgreementCancellationRequestStatus("PENDING_APPROVAL");
        /// <summary>
        /// Constant REJECTED for AgreementCancellationRequestStatus
        /// </summary>
        public static readonly AgreementCancellationRequestStatus REJECTED = new AgreementCancellationRequestStatus("REJECTED");
        /// <summary>
        /// Constant VALIDATION_FAILED for AgreementCancellationRequestStatus
        /// </summary>
        public static readonly AgreementCancellationRequestStatus VALIDATION_FAILED = new AgreementCancellationRequestStatus("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgreementCancellationRequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgreementCancellationRequestStatus FindValue(string value)
        {
            return FindValue<AgreementCancellationRequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgreementCancellationRequestStatus(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type BillingAdjustmentErrorCode.
    /// </summary>
    public class BillingAdjustmentErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CONFLICT_EXCEPTION for BillingAdjustmentErrorCode
        /// </summary>
        public static readonly BillingAdjustmentErrorCode CONFLICT_EXCEPTION = new BillingAdjustmentErrorCode("CONFLICT_EXCEPTION");
        /// <summary>
        /// Constant INTERNAL_FAILURE for BillingAdjustmentErrorCode
        /// </summary>
        public static readonly BillingAdjustmentErrorCode INTERNAL_FAILURE = new BillingAdjustmentErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND_EXCEPTION for BillingAdjustmentErrorCode
        /// </summary>
        public static readonly BillingAdjustmentErrorCode RESOURCE_NOT_FOUND_EXCEPTION = new BillingAdjustmentErrorCode("RESOURCE_NOT_FOUND_EXCEPTION");
        /// <summary>
        /// Constant VALIDATION_EXCEPTION for BillingAdjustmentErrorCode
        /// </summary>
        public static readonly BillingAdjustmentErrorCode VALIDATION_EXCEPTION = new BillingAdjustmentErrorCode("VALIDATION_EXCEPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingAdjustmentErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingAdjustmentErrorCode FindValue(string value)
        {
            return FindValue<BillingAdjustmentErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingAdjustmentErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillingAdjustmentReasonCode.
    /// </summary>
    public class BillingAdjustmentReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant ALTERNATIVE_PROCUREMENT_CHANNEL for BillingAdjustmentReasonCode
        /// </summary>
        public static readonly BillingAdjustmentReasonCode ALTERNATIVE_PROCUREMENT_CHANNEL = new BillingAdjustmentReasonCode("ALTERNATIVE_PROCUREMENT_CHANNEL");
        /// <summary>
        /// Constant BUYER_DISSATISFACTION for BillingAdjustmentReasonCode
        /// </summary>
        public static readonly BillingAdjustmentReasonCode BUYER_DISSATISFACTION = new BillingAdjustmentReasonCode("BUYER_DISSATISFACTION");
        /// <summary>
        /// Constant INCORRECT_METERING for BillingAdjustmentReasonCode
        /// </summary>
        public static readonly BillingAdjustmentReasonCode INCORRECT_METERING = new BillingAdjustmentReasonCode("INCORRECT_METERING");
        /// <summary>
        /// Constant INCORRECT_TERMS_ACCEPTED for BillingAdjustmentReasonCode
        /// </summary>
        public static readonly BillingAdjustmentReasonCode INCORRECT_TERMS_ACCEPTED = new BillingAdjustmentReasonCode("INCORRECT_TERMS_ACCEPTED");
        /// <summary>
        /// Constant OTHER for BillingAdjustmentReasonCode
        /// </summary>
        public static readonly BillingAdjustmentReasonCode OTHER = new BillingAdjustmentReasonCode("OTHER");
        /// <summary>
        /// Constant TEST_ENVIRONMENT_CHARGES for BillingAdjustmentReasonCode
        /// </summary>
        public static readonly BillingAdjustmentReasonCode TEST_ENVIRONMENT_CHARGES = new BillingAdjustmentReasonCode("TEST_ENVIRONMENT_CHARGES");
        /// <summary>
        /// Constant UNINTENDED_RENEWAL for BillingAdjustmentReasonCode
        /// </summary>
        public static readonly BillingAdjustmentReasonCode UNINTENDED_RENEWAL = new BillingAdjustmentReasonCode("UNINTENDED_RENEWAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingAdjustmentReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingAdjustmentReasonCode FindValue(string value)
        {
            return FindValue<BillingAdjustmentReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingAdjustmentReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillingAdjustmentStatus.
    /// </summary>
    public class BillingAdjustmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for BillingAdjustmentStatus
        /// </summary>
        public static readonly BillingAdjustmentStatus COMPLETED = new BillingAdjustmentStatus("COMPLETED");
        /// <summary>
        /// Constant PENDING for BillingAdjustmentStatus
        /// </summary>
        public static readonly BillingAdjustmentStatus PENDING = new BillingAdjustmentStatus("PENDING");
        /// <summary>
        /// Constant VALIDATION_FAILED for BillingAdjustmentStatus
        /// </summary>
        public static readonly BillingAdjustmentStatus VALIDATION_FAILED = new BillingAdjustmentStatus("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingAdjustmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingAdjustmentStatus FindValue(string value)
        {
            return FindValue<BillingAdjustmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingAdjustmentStatus(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type LineItemGroupBy.
    /// </summary>
    public class LineItemGroupBy : ConstantClass
    {

        /// <summary>
        /// Constant INVOICE_ID for LineItemGroupBy
        /// </summary>
        public static readonly LineItemGroupBy INVOICE_ID = new LineItemGroupBy("INVOICE_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineItemGroupBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineItemGroupBy FindValue(string value)
        {
            return FindValue<LineItemGroupBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineItemGroupBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaymentRequestApprovalStrategy.
    /// </summary>
    public class PaymentRequestApprovalStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_APPROVE_ON_EXPIRATION for PaymentRequestApprovalStrategy
        /// </summary>
        public static readonly PaymentRequestApprovalStrategy AUTO_APPROVE_ON_EXPIRATION = new PaymentRequestApprovalStrategy("AUTO_APPROVE_ON_EXPIRATION");
        /// <summary>
        /// Constant WAIT_FOR_APPROVAL for PaymentRequestApprovalStrategy
        /// </summary>
        public static readonly PaymentRequestApprovalStrategy WAIT_FOR_APPROVAL = new PaymentRequestApprovalStrategy("WAIT_FOR_APPROVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentRequestApprovalStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentRequestApprovalStrategy FindValue(string value)
        {
            return FindValue<PaymentRequestApprovalStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentRequestApprovalStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaymentRequestStatus.
    /// </summary>
    public class PaymentRequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for PaymentRequestStatus
        /// </summary>
        public static readonly PaymentRequestStatus APPROVED = new PaymentRequestStatus("APPROVED");
        /// <summary>
        /// Constant CANCELLED for PaymentRequestStatus
        /// </summary>
        public static readonly PaymentRequestStatus CANCELLED = new PaymentRequestStatus("CANCELLED");
        /// <summary>
        /// Constant PENDING_APPROVAL for PaymentRequestStatus
        /// </summary>
        public static readonly PaymentRequestStatus PENDING_APPROVAL = new PaymentRequestStatus("PENDING_APPROVAL");
        /// <summary>
        /// Constant REJECTED for PaymentRequestStatus
        /// </summary>
        public static readonly PaymentRequestStatus REJECTED = new PaymentRequestStatus("REJECTED");
        /// <summary>
        /// Constant VALIDATING for PaymentRequestStatus
        /// </summary>
        public static readonly PaymentRequestStatus VALIDATING = new PaymentRequestStatus("VALIDATING");
        /// <summary>
        /// Constant VALIDATION_FAILED for PaymentRequestStatus
        /// </summary>
        public static readonly PaymentRequestStatus VALIDATION_FAILED = new PaymentRequestStatus("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentRequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentRequestStatus FindValue(string value)
        {
            return FindValue<PaymentRequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentRequestStatus(string value)
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
        /// Constant Charge for ResourceType
        /// </summary>
        public static readonly ResourceType Charge = new ResourceType("Charge");
        /// <summary>
        /// Constant PaymentRequest for ResourceType
        /// </summary>
        public static readonly ResourceType PaymentRequest = new ResourceType("PaymentRequest");

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
        /// Constant INVALID_CHARGE_AMOUNT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CHARGE_AMOUNT = new ValidationExceptionReason("INVALID_CHARGE_AMOUNT");
        /// <summary>
        /// Constant INVALID_DESCRIPTION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_DESCRIPTION = new ValidationExceptionReason("INVALID_DESCRIPTION");
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
        /// Constant INVALID_NAME for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_NAME = new ValidationExceptionReason("INVALID_NAME");
        /// <summary>
        /// Constant INVALID_NEXT_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_NEXT_TOKEN = new ValidationExceptionReason("INVALID_NEXT_TOKEN");
        /// <summary>
        /// Constant INVALID_PARTY_TYPE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PARTY_TYPE = new ValidationExceptionReason("INVALID_PARTY_TYPE");
        /// <summary>
        /// Constant INVALID_PAYMENT_REQUEST_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PAYMENT_REQUEST_ID = new ValidationExceptionReason("INVALID_PAYMENT_REQUEST_ID");
        /// <summary>
        /// Constant INVALID_PAYMENT_REQUEST_STATUS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PAYMENT_REQUEST_STATUS = new ValidationExceptionReason("INVALID_PAYMENT_REQUEST_STATUS");
        /// <summary>
        /// Constant INVALID_REJECTION_REASON for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_REJECTION_REASON = new ValidationExceptionReason("INVALID_REJECTION_REASON");
        /// <summary>
        /// Constant INVALID_SORT_BY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_SORT_BY = new ValidationExceptionReason("INVALID_SORT_BY");
        /// <summary>
        /// Constant INVALID_SORT_ORDER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_SORT_ORDER = new ValidationExceptionReason("INVALID_SORT_ORDER");
        /// <summary>
        /// Constant INVALID_TERM_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_TERM_ID = new ValidationExceptionReason("INVALID_TERM_ID");
        /// <summary>
        /// Constant MISSING_AGREEMENT_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_AGREEMENT_ID = new ValidationExceptionReason("MISSING_AGREEMENT_ID");
        /// <summary>
        /// Constant MISSING_CHARGE_AMOUNT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_CHARGE_AMOUNT = new ValidationExceptionReason("MISSING_CHARGE_AMOUNT");
        /// <summary>
        /// Constant MISSING_NAME for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_NAME = new ValidationExceptionReason("MISSING_NAME");
        /// <summary>
        /// Constant MISSING_PARTY_TYPE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_PARTY_TYPE = new ValidationExceptionReason("MISSING_PARTY_TYPE");
        /// <summary>
        /// Constant MISSING_PAYMENT_REQUEST_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_PAYMENT_REQUEST_ID = new ValidationExceptionReason("MISSING_PAYMENT_REQUEST_ID");
        /// <summary>
        /// Constant MISSING_TERM_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_TERM_ID = new ValidationExceptionReason("MISSING_TERM_ID");
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