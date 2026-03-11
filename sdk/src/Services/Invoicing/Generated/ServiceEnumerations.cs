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
    /// Constants used for properties of type BuyerDomain.
    /// </summary>
    public class BuyerDomain : ConstantClass
    {

        /// <summary>
        /// Constant NetworkID for BuyerDomain
        /// </summary>
        public static readonly BuyerDomain NetworkID = new BuyerDomain("NetworkID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuyerDomain(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuyerDomain FindValue(string value)
        {
            return FindValue<BuyerDomain>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuyerDomain(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionTestingMethod.
    /// </summary>
    public class ConnectionTestingMethod : ConstantClass
    {

        /// <summary>
        /// Constant PROD_ENV_DOLLAR_TEST for ConnectionTestingMethod
        /// </summary>
        public static readonly ConnectionTestingMethod PROD_ENV_DOLLAR_TEST = new ConnectionTestingMethod("PROD_ENV_DOLLAR_TEST");
        /// <summary>
        /// Constant TEST_ENV_REPLAY_TEST for ConnectionTestingMethod
        /// </summary>
        public static readonly ConnectionTestingMethod TEST_ENV_REPLAY_TEST = new ConnectionTestingMethod("TEST_ENV_REPLAY_TEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionTestingMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionTestingMethod FindValue(string value)
        {
            return FindValue<ConnectionTestingMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionTestingMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EinvoiceDeliveryAttachmentType.
    /// </summary>
    public class EinvoiceDeliveryAttachmentType : ConstantClass
    {

        /// <summary>
        /// Constant INVOICE_PDF for EinvoiceDeliveryAttachmentType
        /// </summary>
        public static readonly EinvoiceDeliveryAttachmentType INVOICE_PDF = new EinvoiceDeliveryAttachmentType("INVOICE_PDF");
        /// <summary>
        /// Constant RFP_PDF for EinvoiceDeliveryAttachmentType
        /// </summary>
        public static readonly EinvoiceDeliveryAttachmentType RFP_PDF = new EinvoiceDeliveryAttachmentType("RFP_PDF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EinvoiceDeliveryAttachmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EinvoiceDeliveryAttachmentType FindValue(string value)
        {
            return FindValue<EinvoiceDeliveryAttachmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EinvoiceDeliveryAttachmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EinvoiceDeliveryDocumentType.
    /// </summary>
    public class EinvoiceDeliveryDocumentType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_CLOUD_CREDIT_MEMO for EinvoiceDeliveryDocumentType
        /// </summary>
        public static readonly EinvoiceDeliveryDocumentType AWS_CLOUD_CREDIT_MEMO = new EinvoiceDeliveryDocumentType("AWS_CLOUD_CREDIT_MEMO");
        /// <summary>
        /// Constant AWS_CLOUD_INVOICE for EinvoiceDeliveryDocumentType
        /// </summary>
        public static readonly EinvoiceDeliveryDocumentType AWS_CLOUD_INVOICE = new EinvoiceDeliveryDocumentType("AWS_CLOUD_INVOICE");
        /// <summary>
        /// Constant AWS_MARKETPLACE_CREDIT_MEMO for EinvoiceDeliveryDocumentType
        /// </summary>
        public static readonly EinvoiceDeliveryDocumentType AWS_MARKETPLACE_CREDIT_MEMO = new EinvoiceDeliveryDocumentType("AWS_MARKETPLACE_CREDIT_MEMO");
        /// <summary>
        /// Constant AWS_MARKETPLACE_INVOICE for EinvoiceDeliveryDocumentType
        /// </summary>
        public static readonly EinvoiceDeliveryDocumentType AWS_MARKETPLACE_INVOICE = new EinvoiceDeliveryDocumentType("AWS_MARKETPLACE_INVOICE");
        /// <summary>
        /// Constant AWS_REQUEST_FOR_PAYMENT for EinvoiceDeliveryDocumentType
        /// </summary>
        public static readonly EinvoiceDeliveryDocumentType AWS_REQUEST_FOR_PAYMENT = new EinvoiceDeliveryDocumentType("AWS_REQUEST_FOR_PAYMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EinvoiceDeliveryDocumentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EinvoiceDeliveryDocumentType FindValue(string value)
        {
            return FindValue<EinvoiceDeliveryDocumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EinvoiceDeliveryDocumentType(string value)
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
    /// Constants used for properties of type ProcurementPortalName.
    /// </summary>
    public class ProcurementPortalName : ConstantClass
    {

        /// <summary>
        /// Constant COUPA for ProcurementPortalName
        /// </summary>
        public static readonly ProcurementPortalName COUPA = new ProcurementPortalName("COUPA");
        /// <summary>
        /// Constant SAP_BUSINESS_NETWORK for ProcurementPortalName
        /// </summary>
        public static readonly ProcurementPortalName SAP_BUSINESS_NETWORK = new ProcurementPortalName("SAP_BUSINESS_NETWORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcurementPortalName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcurementPortalName FindValue(string value)
        {
            return FindValue<ProcurementPortalName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcurementPortalName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcurementPortalPreferenceStatus.
    /// </summary>
    public class ProcurementPortalPreferenceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ProcurementPortalPreferenceStatus
        /// </summary>
        public static readonly ProcurementPortalPreferenceStatus ACTIVE = new ProcurementPortalPreferenceStatus("ACTIVE");
        /// <summary>
        /// Constant PENDING_VERIFICATION for ProcurementPortalPreferenceStatus
        /// </summary>
        public static readonly ProcurementPortalPreferenceStatus PENDING_VERIFICATION = new ProcurementPortalPreferenceStatus("PENDING_VERIFICATION");
        /// <summary>
        /// Constant SUSPENDED for ProcurementPortalPreferenceStatus
        /// </summary>
        public static readonly ProcurementPortalPreferenceStatus SUSPENDED = new ProcurementPortalPreferenceStatus("SUSPENDED");
        /// <summary>
        /// Constant TEST_FAILED for ProcurementPortalPreferenceStatus
        /// </summary>
        public static readonly ProcurementPortalPreferenceStatus TEST_FAILED = new ProcurementPortalPreferenceStatus("TEST_FAILED");
        /// <summary>
        /// Constant TEST_INITIALIZATION_FAILED for ProcurementPortalPreferenceStatus
        /// </summary>
        public static readonly ProcurementPortalPreferenceStatus TEST_INITIALIZATION_FAILED = new ProcurementPortalPreferenceStatus("TEST_INITIALIZATION_FAILED");
        /// <summary>
        /// Constant TEST_INITIALIZED for ProcurementPortalPreferenceStatus
        /// </summary>
        public static readonly ProcurementPortalPreferenceStatus TEST_INITIALIZED = new ProcurementPortalPreferenceStatus("TEST_INITIALIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcurementPortalPreferenceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcurementPortalPreferenceStatus FindValue(string value)
        {
            return FindValue<ProcurementPortalPreferenceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcurementPortalPreferenceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant CXML for Protocol
        /// </summary>
        public static readonly Protocol CXML = new Protocol("CXML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PurchaseOrderDataSourceType.
    /// </summary>
    public class PurchaseOrderDataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATED_PURCHASE_ORDER_REQUIRED for PurchaseOrderDataSourceType
        /// </summary>
        public static readonly PurchaseOrderDataSourceType ASSOCIATED_PURCHASE_ORDER_REQUIRED = new PurchaseOrderDataSourceType("ASSOCIATED_PURCHASE_ORDER_REQUIRED");
        /// <summary>
        /// Constant PURCHASE_ORDER_NOT_REQUIRED for PurchaseOrderDataSourceType
        /// </summary>
        public static readonly PurchaseOrderDataSourceType PURCHASE_ORDER_NOT_REQUIRED = new PurchaseOrderDataSourceType("PURCHASE_ORDER_NOT_REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PurchaseOrderDataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PurchaseOrderDataSourceType FindValue(string value)
        {
            return FindValue<PurchaseOrderDataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PurchaseOrderDataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupplierDomain.
    /// </summary>
    public class SupplierDomain : ConstantClass
    {

        /// <summary>
        /// Constant NetworkID for SupplierDomain
        /// </summary>
        public static readonly SupplierDomain NetworkID = new SupplierDomain("NetworkID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupplierDomain(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupplierDomain FindValue(string value)
        {
            return FindValue<SupplierDomain>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupplierDomain(string value)
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