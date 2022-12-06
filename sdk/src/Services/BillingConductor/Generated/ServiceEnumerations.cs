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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BillingConductor
{

    /// <summary>
    /// Constants used for properties of type AssociateResourceErrorReason.
    /// </summary>
    public class AssociateResourceErrorReason : ConstantClass
    {

        /// <summary>
        /// Constant ILLEGAL_CUSTOMLINEITEM for AssociateResourceErrorReason
        /// </summary>
        public static readonly AssociateResourceErrorReason ILLEGAL_CUSTOMLINEITEM = new AssociateResourceErrorReason("ILLEGAL_CUSTOMLINEITEM");
        /// <summary>
        /// Constant INTERNAL_SERVER_EXCEPTION for AssociateResourceErrorReason
        /// </summary>
        public static readonly AssociateResourceErrorReason INTERNAL_SERVER_EXCEPTION = new AssociateResourceErrorReason("INTERNAL_SERVER_EXCEPTION");
        /// <summary>
        /// Constant INVALID_ARN for AssociateResourceErrorReason
        /// </summary>
        public static readonly AssociateResourceErrorReason INVALID_ARN = new AssociateResourceErrorReason("INVALID_ARN");
        /// <summary>
        /// Constant INVALID_BILLING_PERIOD_RANGE for AssociateResourceErrorReason
        /// </summary>
        public static readonly AssociateResourceErrorReason INVALID_BILLING_PERIOD_RANGE = new AssociateResourceErrorReason("INVALID_BILLING_PERIOD_RANGE");
        /// <summary>
        /// Constant SERVICE_LIMIT_EXCEEDED for AssociateResourceErrorReason
        /// </summary>
        public static readonly AssociateResourceErrorReason SERVICE_LIMIT_EXCEEDED = new AssociateResourceErrorReason("SERVICE_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociateResourceErrorReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociateResourceErrorReason FindValue(string value)
        {
            return FindValue<AssociateResourceErrorReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociateResourceErrorReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillingGroupStatus.
    /// </summary>
    public class BillingGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for BillingGroupStatus
        /// </summary>
        public static readonly BillingGroupStatus ACTIVE = new BillingGroupStatus("ACTIVE");
        /// <summary>
        /// Constant PRIMARY_ACCOUNT_MISSING for BillingGroupStatus
        /// </summary>
        public static readonly BillingGroupStatus PRIMARY_ACCOUNT_MISSING = new BillingGroupStatus("PRIMARY_ACCOUNT_MISSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingGroupStatus FindValue(string value)
        {
            return FindValue<BillingGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant PRICING_PLAN_ATTACHED_TO_BILLING_GROUP_DELETE_CONFLICT for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PRICING_PLAN_ATTACHED_TO_BILLING_GROUP_DELETE_CONFLICT = new ConflictExceptionReason("PRICING_PLAN_ATTACHED_TO_BILLING_GROUP_DELETE_CONFLICT");
        /// <summary>
        /// Constant PRICING_RULE_ATTACHED_TO_PRICING_PLAN_DELETE_CONFLICT for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PRICING_RULE_ATTACHED_TO_PRICING_PLAN_DELETE_CONFLICT = new ConflictExceptionReason("PRICING_RULE_ATTACHED_TO_PRICING_PLAN_DELETE_CONFLICT");
        /// <summary>
        /// Constant PRICING_RULE_IN_PRICING_PLAN_CONFLICT for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PRICING_RULE_IN_PRICING_PLAN_CONFLICT = new ConflictExceptionReason("PRICING_RULE_IN_PRICING_PLAN_CONFLICT");
        /// <summary>
        /// Constant RESOURCE_NAME_CONFLICT for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_NAME_CONFLICT = new ConflictExceptionReason("RESOURCE_NAME_CONFLICT");
        /// <summary>
        /// Constant WRITE_CONFLICT_RETRY for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason WRITE_CONFLICT_RETRY = new ConflictExceptionReason("WRITE_CONFLICT_RETRY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrencyCode.
    /// </summary>
    public class CurrencyCode : ConstantClass
    {

        /// <summary>
        /// Constant CNY for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CNY = new CurrencyCode("CNY");
        /// <summary>
        /// Constant USD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode USD = new CurrencyCode("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrencyCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrencyCode FindValue(string value)
        {
            return FindValue<CurrencyCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrencyCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomLineItemRelationship.
    /// </summary>
    public class CustomLineItemRelationship : ConstantClass
    {

        /// <summary>
        /// Constant CHILD for CustomLineItemRelationship
        /// </summary>
        public static readonly CustomLineItemRelationship CHILD = new CustomLineItemRelationship("CHILD");
        /// <summary>
        /// Constant PARENT for CustomLineItemRelationship
        /// </summary>
        public static readonly CustomLineItemRelationship PARENT = new CustomLineItemRelationship("PARENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomLineItemRelationship(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomLineItemRelationship FindValue(string value)
        {
            return FindValue<CustomLineItemRelationship>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomLineItemRelationship(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomLineItemType.
    /// </summary>
    public class CustomLineItemType : ConstantClass
    {

        /// <summary>
        /// Constant CREDIT for CustomLineItemType
        /// </summary>
        public static readonly CustomLineItemType CREDIT = new CustomLineItemType("CREDIT");
        /// <summary>
        /// Constant FEE for CustomLineItemType
        /// </summary>
        public static readonly CustomLineItemType FEE = new CustomLineItemType("FEE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomLineItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomLineItemType FindValue(string value)
        {
            return FindValue<CustomLineItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomLineItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PricingRuleScope.
    /// </summary>
    public class PricingRuleScope : ConstantClass
    {

        /// <summary>
        /// Constant BILLING_ENTITY for PricingRuleScope
        /// </summary>
        public static readonly PricingRuleScope BILLING_ENTITY = new PricingRuleScope("BILLING_ENTITY");
        /// <summary>
        /// Constant GLOBAL for PricingRuleScope
        /// </summary>
        public static readonly PricingRuleScope GLOBAL = new PricingRuleScope("GLOBAL");
        /// <summary>
        /// Constant SERVICE for PricingRuleScope
        /// </summary>
        public static readonly PricingRuleScope SERVICE = new PricingRuleScope("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PricingRuleScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PricingRuleScope FindValue(string value)
        {
            return FindValue<PricingRuleScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PricingRuleScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PricingRuleType.
    /// </summary>
    public class PricingRuleType : ConstantClass
    {

        /// <summary>
        /// Constant DISCOUNT for PricingRuleType
        /// </summary>
        public static readonly PricingRuleType DISCOUNT = new PricingRuleType("DISCOUNT");
        /// <summary>
        /// Constant MARKUP for PricingRuleType
        /// </summary>
        public static readonly PricingRuleType MARKUP = new PricingRuleType("MARKUP");
        /// <summary>
        /// Constant TIERING for PricingRuleType
        /// </summary>
        public static readonly PricingRuleType TIERING = new PricingRuleType("TIERING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PricingRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PricingRuleType FindValue(string value)
        {
            return FindValue<PricingRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PricingRuleType(string value)
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
        /// Constant ACCOUNTS_ALREADY_ASSOCIATED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ACCOUNTS_ALREADY_ASSOCIATED = new ValidationExceptionReason("ACCOUNTS_ALREADY_ASSOCIATED");
        /// <summary>
        /// Constant ACCOUNTS_NOT_ASSOCIATED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ACCOUNTS_NOT_ASSOCIATED = new ValidationExceptionReason("ACCOUNTS_NOT_ASSOCIATED");
        /// <summary>
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant CUSTOM_LINE_ITEM_ASSOCIATION_EXISTS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CUSTOM_LINE_ITEM_ASSOCIATION_EXISTS = new ValidationExceptionReason("CUSTOM_LINE_ITEM_ASSOCIATION_EXISTS");
        /// <summary>
        /// Constant DUPLICATE_ACCOUNT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DUPLICATE_ACCOUNT = new ValidationExceptionReason("DUPLICATE_ACCOUNT");
        /// <summary>
        /// Constant DUPLICATE_PRICINGRULE_ARNS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DUPLICATE_PRICINGRULE_ARNS = new ValidationExceptionReason("DUPLICATE_PRICINGRULE_ARNS");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant ILLEGAL_ACCOUNTS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_ACCOUNTS = new ValidationExceptionReason("ILLEGAL_ACCOUNTS");
        /// <summary>
        /// Constant ILLEGAL_BILLING_ENTITY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_BILLING_ENTITY = new ValidationExceptionReason("ILLEGAL_BILLING_ENTITY");
        /// <summary>
        /// Constant ILLEGAL_BILLING_PERIOD for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_BILLING_PERIOD = new ValidationExceptionReason("ILLEGAL_BILLING_PERIOD");
        /// <summary>
        /// Constant ILLEGAL_BILLING_PERIOD_RANGE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_BILLING_PERIOD_RANGE = new ValidationExceptionReason("ILLEGAL_BILLING_PERIOD_RANGE");
        /// <summary>
        /// Constant ILLEGAL_CHARGE_DETAILS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_CHARGE_DETAILS = new ValidationExceptionReason("ILLEGAL_CHARGE_DETAILS");
        /// <summary>
        /// Constant ILLEGAL_CHILD_ASSOCIATE_RESOURCE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_CHILD_ASSOCIATE_RESOURCE = new ValidationExceptionReason("ILLEGAL_CHILD_ASSOCIATE_RESOURCE");
        /// <summary>
        /// Constant ILLEGAL_CUSTOMLINEITEM for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_CUSTOMLINEITEM = new ValidationExceptionReason("ILLEGAL_CUSTOMLINEITEM");
        /// <summary>
        /// Constant ILLEGAL_CUSTOMLINEITEM_MODIFICATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_CUSTOMLINEITEM_MODIFICATION = new ValidationExceptionReason("ILLEGAL_CUSTOMLINEITEM_MODIFICATION");
        /// <summary>
        /// Constant ILLEGAL_CUSTOMLINEITEM_UPDATE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_CUSTOMLINEITEM_UPDATE = new ValidationExceptionReason("ILLEGAL_CUSTOMLINEITEM_UPDATE");
        /// <summary>
        /// Constant ILLEGAL_ENDED_BILLINGGROUP for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_ENDED_BILLINGGROUP = new ValidationExceptionReason("ILLEGAL_ENDED_BILLINGGROUP");
        /// <summary>
        /// Constant ILLEGAL_EXPRESSION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_EXPRESSION = new ValidationExceptionReason("ILLEGAL_EXPRESSION");
        /// <summary>
        /// Constant ILLEGAL_MODIFIER_PERCENTAGE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_MODIFIER_PERCENTAGE = new ValidationExceptionReason("ILLEGAL_MODIFIER_PERCENTAGE");
        /// <summary>
        /// Constant ILLEGAL_PRIMARY_ACCOUNT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_PRIMARY_ACCOUNT = new ValidationExceptionReason("ILLEGAL_PRIMARY_ACCOUNT");
        /// <summary>
        /// Constant ILLEGAL_RESOURCE_ARNS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_RESOURCE_ARNS = new ValidationExceptionReason("ILLEGAL_RESOURCE_ARNS");
        /// <summary>
        /// Constant ILLEGAL_SCOPE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_SCOPE = new ValidationExceptionReason("ILLEGAL_SCOPE");
        /// <summary>
        /// Constant ILLEGAL_SERVICE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_SERVICE = new ValidationExceptionReason("ILLEGAL_SERVICE");
        /// <summary>
        /// Constant ILLEGAL_TIERING_INPUT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_TIERING_INPUT = new ValidationExceptionReason("ILLEGAL_TIERING_INPUT");
        /// <summary>
        /// Constant ILLEGAL_TYPE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_TYPE = new ValidationExceptionReason("ILLEGAL_TYPE");
        /// <summary>
        /// Constant ILLEGAL_UPDATE_CHARGE_DETAILS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_UPDATE_CHARGE_DETAILS = new ValidationExceptionReason("ILLEGAL_UPDATE_CHARGE_DETAILS");
        /// <summary>
        /// Constant INVALID_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ARN = new ValidationExceptionReason("INVALID_ARN");
        /// <summary>
        /// Constant INVALID_BILLING_GROUP for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_BILLING_GROUP = new ValidationExceptionReason("INVALID_BILLING_GROUP");
        /// <summary>
        /// Constant INVALID_BILLING_GROUP_STATUS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_BILLING_GROUP_STATUS = new ValidationExceptionReason("INVALID_BILLING_GROUP_STATUS");
        /// <summary>
        /// Constant INVALID_BILLING_PERIOD_FOR_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_BILLING_PERIOD_FOR_OPERATION = new ValidationExceptionReason("INVALID_BILLING_PERIOD_FOR_OPERATION");
        /// <summary>
        /// Constant INVALID_BILLINGVIEW_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_BILLINGVIEW_ARN = new ValidationExceptionReason("INVALID_BILLINGVIEW_ARN");
        /// <summary>
        /// Constant INVALID_TIME_RANGE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_TIME_RANGE = new ValidationExceptionReason("INVALID_TIME_RANGE");
        /// <summary>
        /// Constant MISMATCHED_BILLINGGROUP_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISMATCHED_BILLINGGROUP_ARN = new ValidationExceptionReason("MISMATCHED_BILLINGGROUP_ARN");
        /// <summary>
        /// Constant MISMATCHED_BILLINGVIEW_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISMATCHED_BILLINGVIEW_ARN = new ValidationExceptionReason("MISMATCHED_BILLINGVIEW_ARN");
        /// <summary>
        /// Constant MISMATCHED_CUSTOMLINEITEM_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISMATCHED_CUSTOMLINEITEM_ARN = new ValidationExceptionReason("MISMATCHED_CUSTOMLINEITEM_ARN");
        /// <summary>
        /// Constant MISMATCHED_PRICINGPLAN_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISMATCHED_PRICINGPLAN_ARN = new ValidationExceptionReason("MISMATCHED_PRICINGPLAN_ARN");
        /// <summary>
        /// Constant MISMATCHED_PRICINGRULE_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISMATCHED_PRICINGRULE_ARN = new ValidationExceptionReason("MISMATCHED_PRICINGRULE_ARN");
        /// <summary>
        /// Constant MISSING_BILLINGGROUP for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_BILLINGGROUP = new ValidationExceptionReason("MISSING_BILLINGGROUP");
        /// <summary>
        /// Constant MISSING_CUSTOMLINEITEM for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_CUSTOMLINEITEM = new ValidationExceptionReason("MISSING_CUSTOMLINEITEM");
        /// <summary>
        /// Constant MISSING_LINKED_ACCOUNT_IDS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_LINKED_ACCOUNT_IDS = new ValidationExceptionReason("MISSING_LINKED_ACCOUNT_IDS");
        /// <summary>
        /// Constant MISSING_PRICING_PLAN_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_PRICING_PLAN_ARN = new ValidationExceptionReason("MISSING_PRICING_PLAN_ARN");
        /// <summary>
        /// Constant MISSING_PRICINGPLAN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_PRICINGPLAN = new ValidationExceptionReason("MISSING_PRICINGPLAN");
        /// <summary>
        /// Constant MULTIPLE_LINKED_ACCOUNT_IDS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MULTIPLE_LINKED_ACCOUNT_IDS = new ValidationExceptionReason("MULTIPLE_LINKED_ACCOUNT_IDS");
        /// <summary>
        /// Constant MULTIPLE_PRICING_PLAN_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MULTIPLE_PRICING_PLAN_ARN = new ValidationExceptionReason("MULTIPLE_PRICING_PLAN_ARN");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant PRICINGRULES_ALREADY_ASSOCIATED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PRICINGRULES_ALREADY_ASSOCIATED = new ValidationExceptionReason("PRICINGRULES_ALREADY_ASSOCIATED");
        /// <summary>
        /// Constant PRICINGRULES_NOT_ASSOCIATED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PRICINGRULES_NOT_ASSOCIATED = new ValidationExceptionReason("PRICINGRULES_NOT_ASSOCIATED");
        /// <summary>
        /// Constant PRICINGRULES_NOT_EXIST for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PRICINGRULES_NOT_EXIST = new ValidationExceptionReason("PRICINGRULES_NOT_EXIST");
        /// <summary>
        /// Constant PRIMARY_CANNOT_DISASSOCIATE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PRIMARY_CANNOT_DISASSOCIATE = new ValidationExceptionReason("PRIMARY_CANNOT_DISASSOCIATE");
        /// <summary>
        /// Constant PRIMARY_NOT_ASSOCIATED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PRIMARY_NOT_ASSOCIATED = new ValidationExceptionReason("PRIMARY_NOT_ASSOCIATED");
        /// <summary>
        /// Constant TOO_MANY_ACCOUNTS_IN_REQUEST for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason TOO_MANY_ACCOUNTS_IN_REQUEST = new ValidationExceptionReason("TOO_MANY_ACCOUNTS_IN_REQUEST");
        /// <summary>
        /// Constant TOO_MANY_CUSTOMLINEITEMS_IN_REQUEST for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason TOO_MANY_CUSTOMLINEITEMS_IN_REQUEST = new ValidationExceptionReason("TOO_MANY_CUSTOMLINEITEMS_IN_REQUEST");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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