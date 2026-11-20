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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.Payments
{
    /// <summary>
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {
        /// <summary>
        /// Constant INVALID_ACCOUNT_STATE for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason INVALID_ACCOUNT_STATE = new AccessDeniedExceptionReason("INVALID_ACCOUNT_STATE");

        /// <summary>
        /// Constant NOT_AUTHORIZED for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason NOT_AUTHORIZED = new AccessDeniedExceptionReason("NOT_AUTHORIZED");

        /// <summary>
        /// Constant OTHER for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason OTHER = new AccessDeniedExceptionReason("OTHER");

        /// <summary>
        /// Constructs a custom AccessDeniedExceptionReason for a value not among the defined constants.
        /// </summary>
        public AccessDeniedExceptionReason(string value) : base(value) { }

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
    /// Constants used for properties of type BalanceType.
    /// </summary>
    public class BalanceType : ConstantClass
    {
        /// <summary>
        /// Constant INVOICES_DUE for BalanceType
        /// </summary>
        public static readonly BalanceType INVOICES_DUE = new BalanceType("INVOICES_DUE");

        /// <summary>
        /// Constant INVOICES_PAST_DUE for BalanceType
        /// </summary>
        public static readonly BalanceType INVOICES_PAST_DUE = new BalanceType("INVOICES_PAST_DUE");

        /// <summary>
        /// Constant OUTSTANDING_CREDIT_MEMOS for BalanceType
        /// </summary>
        public static readonly BalanceType OUTSTANDING_CREDIT_MEMOS = new BalanceType("OUTSTANDING_CREDIT_MEMOS");

        /// <summary>
        /// Constructs a custom BalanceType for a value not among the defined constants.
        /// </summary>
        public BalanceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BalanceType FindValue(string value)
        {
            return FindValue<BalanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BalanceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BankAccountType.
    /// </summary>
    public class BankAccountType : ConstantClass
    {
        /// <summary>
        /// Constant CHECKING for BankAccountType
        /// </summary>
        public static readonly BankAccountType CHECKING = new BankAccountType("CHECKING");

        /// <summary>
        /// Constant SAVINGS for BankAccountType
        /// </summary>
        public static readonly BankAccountType SAVINGS = new BankAccountType("SAVINGS");

        /// <summary>
        /// Constructs a custom BankAccountType for a value not among the defined constants.
        /// </summary>
        public BankAccountType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BankAccountType FindValue(string value)
        {
            return FindValue<BankAccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BankAccountType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BatchErrorCode.
    /// </summary>
    public class BatchErrorCode : ConstantClass
    {
        /// <summary>
        /// Constant INTERNAL_ERROR for BatchErrorCode
        /// </summary>
        public static readonly BatchErrorCode INTERNAL_ERROR = new BatchErrorCode("INTERNAL_ERROR");

        /// <summary>
        /// Constant NOT_FOUND for BatchErrorCode
        /// </summary>
        public static readonly BatchErrorCode NOT_FOUND = new BatchErrorCode("NOT_FOUND");

        /// <summary>
        /// Constructs a custom BatchErrorCode for a value not among the defined constants.
        /// </summary>
        public BatchErrorCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchErrorCode FindValue(string value)
        {
            return FindValue<BatchErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchErrorCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CardBrand.
    /// </summary>
    public class CardBrand : ConstantClass
    {
        /// <summary>
        /// Constant AMEX for CardBrand
        /// </summary>
        public static readonly CardBrand AMEX = new CardBrand("AMEX");

        /// <summary>
        /// Constant CHINA_UNIONPAY for CardBrand
        /// </summary>
        public static readonly CardBrand CHINA_UNIONPAY = new CardBrand("CHINA_UNIONPAY");

        /// <summary>
        /// Constant DISCOVER for CardBrand
        /// </summary>
        public static readonly CardBrand DISCOVER = new CardBrand("DISCOVER");

        /// <summary>
        /// Constant JCB for CardBrand
        /// </summary>
        public static readonly CardBrand JCB = new CardBrand("JCB");

        /// <summary>
        /// Constant MASTERCARD for CardBrand
        /// </summary>
        public static readonly CardBrand MASTERCARD = new CardBrand("MASTERCARD");

        /// <summary>
        /// Constant RUPAY for CardBrand
        /// </summary>
        public static readonly CardBrand RUPAY = new CardBrand("RUPAY");

        /// <summary>
        /// Constant VISA for CardBrand
        /// </summary>
        public static readonly CardBrand VISA = new CardBrand("VISA");

        /// <summary>
        /// Constructs a custom CardBrand for a value not among the defined constants.
        /// </summary>
        public CardBrand(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CardBrand FindValue(string value)
        {
            return FindValue<CardBrand>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CardBrand(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CardType.
    /// </summary>
    public class CardType : ConstantClass
    {
        /// <summary>
        /// Constant CREDIT for CardType
        /// </summary>
        public static readonly CardType CREDIT = new CardType("CREDIT");

        /// <summary>
        /// Constant DEBIT for CardType
        /// </summary>
        public static readonly CardType DEBIT = new CardType("DEBIT");

        /// <summary>
        /// Constructs a custom CardType for a value not among the defined constants.
        /// </summary>
        public CardType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CardType FindValue(string value)
        {
            return FindValue<CardType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CardType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DueStatus.
    /// </summary>
    public class DueStatus : ConstantClass
    {
        /// <summary>
        /// Constant DUE for DueStatus
        /// </summary>
        public static readonly DueStatus DUE = new DueStatus("DUE");

        /// <summary>
        /// Constant PAST_DUE for DueStatus
        /// </summary>
        public static readonly DueStatus PAST_DUE = new DueStatus("PAST_DUE");

        /// <summary>
        /// Constructs a custom DueStatus for a value not among the defined constants.
        /// </summary>
        public DueStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DueStatus FindValue(string value)
        {
            return FindValue<DueStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DueStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FinancialRecordSortField.
    /// </summary>
    public class FinancialRecordSortField : ConstantClass
    {
        /// <summary>
        /// Constant ISSUED_AT for FinancialRecordSortField
        /// </summary>
        public static readonly FinancialRecordSortField ISSUED_AT = new FinancialRecordSortField("ISSUED_AT");

        /// <summary>
        /// Constructs a custom FinancialRecordSortField for a value not among the defined constants.
        /// </summary>
        public FinancialRecordSortField(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FinancialRecordSortField FindValue(string value)
        {
            return FindValue<FinancialRecordSortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FinancialRecordSortField(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FinancialRecordStatus.
    /// </summary>
    public class FinancialRecordStatus : ConstantClass
    {
        /// <summary>
        /// Constant CANCELED for FinancialRecordStatus
        /// </summary>
        public static readonly FinancialRecordStatus CANCELED = new FinancialRecordStatus("CANCELED");

        /// <summary>
        /// Constant OUTSTANDING for FinancialRecordStatus
        /// </summary>
        public static readonly FinancialRecordStatus OUTSTANDING = new FinancialRecordStatus("OUTSTANDING");

        /// <summary>
        /// Constant PROCESSING for FinancialRecordStatus
        /// </summary>
        public static readonly FinancialRecordStatus PROCESSING = new FinancialRecordStatus("PROCESSING");

        /// <summary>
        /// Constant SETTLED for FinancialRecordStatus
        /// </summary>
        public static readonly FinancialRecordStatus SETTLED = new FinancialRecordStatus("SETTLED");

        /// <summary>
        /// Constructs a custom FinancialRecordStatus for a value not among the defined constants.
        /// </summary>
        public FinancialRecordStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FinancialRecordStatus FindValue(string value)
        {
            return FindValue<FinancialRecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FinancialRecordStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FinancialRecordType.
    /// </summary>
    public class FinancialRecordType : ConstantClass
    {
        /// <summary>
        /// Constant CREDIT_MEMO for FinancialRecordType
        /// </summary>
        public static readonly FinancialRecordType CREDIT_MEMO = new FinancialRecordType("CREDIT_MEMO");

        /// <summary>
        /// Constant INVOICE for FinancialRecordType
        /// </summary>
        public static readonly FinancialRecordType INVOICE = new FinancialRecordType("INVOICE");

        /// <summary>
        /// Constructs a custom FinancialRecordType for a value not among the defined constants.
        /// </summary>
        public FinancialRecordType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FinancialRecordType FindValue(string value)
        {
            return FindValue<FinancialRecordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FinancialRecordType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InvoiceFrequency.
    /// </summary>
    public class InvoiceFrequency : ConstantClass
    {
        /// <summary>
        /// Constant ONE_TIME for InvoiceFrequency
        /// </summary>
        public static readonly InvoiceFrequency ONE_TIME = new InvoiceFrequency("ONE_TIME");

        /// <summary>
        /// Constant RECURRING for InvoiceFrequency
        /// </summary>
        public static readonly InvoiceFrequency RECURRING = new InvoiceFrequency("RECURRING");

        /// <summary>
        /// Constructs a custom InvoiceFrequency for a value not among the defined constants.
        /// </summary>
        public InvoiceFrequency(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvoiceFrequency FindValue(string value)
        {
            return FindValue<InvoiceFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvoiceFrequency(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LineOfBusiness.
    /// </summary>
    public class LineOfBusiness : ConstantClass
    {
        /// <summary>
        /// Constant AWS_CLOUD_SERVICES for LineOfBusiness
        /// </summary>
        public static readonly LineOfBusiness AWS_CLOUD_SERVICES = new LineOfBusiness("AWS_CLOUD_SERVICES");

        /// <summary>
        /// Constant AWS_MARKETPLACE for LineOfBusiness
        /// </summary>
        public static readonly LineOfBusiness AWS_MARKETPLACE = new LineOfBusiness("AWS_MARKETPLACE");

        /// <summary>
        /// Constant PROSERVE_MARKETING_AND_TRAINING for LineOfBusiness
        /// </summary>
        public static readonly LineOfBusiness PROSERVE_MARKETING_AND_TRAINING = new LineOfBusiness("PROSERVE_MARKETING_AND_TRAINING");

        /// <summary>
        /// Constructs a custom LineOfBusiness for a value not among the defined constants.
        /// </summary>
        public LineOfBusiness(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineOfBusiness FindValue(string value)
        {
            return FindValue<LineOfBusiness>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineOfBusiness(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PaymentInstrumentStatus.
    /// </summary>
    public class PaymentInstrumentStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus ACTIVE = new PaymentInstrumentStatus("ACTIVE");

        /// <summary>
        /// Constant INVALID for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus INVALID = new PaymentInstrumentStatus("INVALID");

        /// <summary>
        /// Constant PENDING_SETUP for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus PENDING_SETUP = new PaymentInstrumentStatus("PENDING_SETUP");

        /// <summary>
        /// Constant SETUP_IN_PROGRESS for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus SETUP_IN_PROGRESS = new PaymentInstrumentStatus("SETUP_IN_PROGRESS");

        /// <summary>
        /// Constructs a custom PaymentInstrumentStatus for a value not among the defined constants.
        /// </summary>
        public PaymentInstrumentStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentInstrumentStatus FindValue(string value)
        {
            return FindValue<PaymentInstrumentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentInstrumentStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PaymentMethod.
    /// </summary>
    public class PaymentMethod : ConstantClass
    {
        /// <summary>
        /// Constant CARD for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod CARD = new PaymentMethod("CARD");

        /// <summary>
        /// Constant CN_BANK_REDIRECT for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod CN_BANK_REDIRECT = new PaymentMethod("CN_BANK_REDIRECT");

        /// <summary>
        /// Constant IN_NET_BANKING for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod IN_NET_BANKING = new PaymentMethod("IN_NET_BANKING");

        /// <summary>
        /// Constant PAY_BY_INVOICE for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod PAY_BY_INVOICE = new PaymentMethod("PAY_BY_INVOICE");

        /// <summary>
        /// Constant PIX for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod PIX = new PaymentMethod("PIX");

        /// <summary>
        /// Constant SEPA_BANK_ACCOUNT for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod SEPA_BANK_ACCOUNT = new PaymentMethod("SEPA_BANK_ACCOUNT");

        /// <summary>
        /// Constant UK_BACS_BANK_ACCOUNT for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod UK_BACS_BANK_ACCOUNT = new PaymentMethod("UK_BACS_BANK_ACCOUNT");

        /// <summary>
        /// Constant UPI for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod UPI = new PaymentMethod("UPI");

        /// <summary>
        /// Constant US_ACH_BANK_ACCOUNT for PaymentMethod
        /// </summary>
        public static readonly PaymentMethod US_ACH_BANK_ACCOUNT = new PaymentMethod("US_ACH_BANK_ACCOUNT");

        /// <summary>
        /// Constructs a custom PaymentMethod for a value not among the defined constants.
        /// </summary>
        public PaymentMethod(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentMethod FindValue(string value)
        {
            return FindValue<PaymentMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentMethod(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SettlementStatus.
    /// </summary>
    public class SettlementStatus : ConstantClass
    {
        /// <summary>
        /// Constant CLOSED for SettlementStatus
        /// </summary>
        public static readonly SettlementStatus CLOSED = new SettlementStatus("CLOSED");

        /// <summary>
        /// Constant OPEN for SettlementStatus
        /// </summary>
        public static readonly SettlementStatus OPEN = new SettlementStatus("OPEN");

        /// <summary>
        /// Constructs a custom SettlementStatus for a value not among the defined constants.
        /// </summary>
        public SettlementStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SettlementStatus FindValue(string value)
        {
            return FindValue<SettlementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SettlementStatus(string value)
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
        /// Constructs a custom SortOrder for a value not among the defined constants.
        /// </summary>
        public SortOrder(string value) : base(value) { }

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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");

        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");

        /// <summary>
        /// Constant INVALID_PAGINATION_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PAGINATION_TOKEN = new ValidationExceptionReason("INVALID_PAGINATION_TOKEN");

        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");

        /// <summary>
        /// Constant UNSUPPORTED_ACTION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNSUPPORTED_ACTION = new ValidationExceptionReason("UNSUPPORTED_ACTION");

        /// <summary>
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

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
