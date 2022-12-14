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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CostExplorer
{

    /// <summary>
    /// Constants used for properties of type AccountScope.
    /// </summary>
    public class AccountScope : ConstantClass
    {

        /// <summary>
        /// Constant LINKED for AccountScope
        /// </summary>
        public static readonly AccountScope LINKED = new AccountScope("LINKED");
        /// <summary>
        /// Constant PAYER for AccountScope
        /// </summary>
        public static readonly AccountScope PAYER = new AccountScope("PAYER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountScope FindValue(string value)
        {
            return FindValue<AccountScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnomalyFeedbackType.
    /// </summary>
    public class AnomalyFeedbackType : ConstantClass
    {

        /// <summary>
        /// Constant NO for AnomalyFeedbackType
        /// </summary>
        public static readonly AnomalyFeedbackType NO = new AnomalyFeedbackType("NO");
        /// <summary>
        /// Constant PLANNED_ACTIVITY for AnomalyFeedbackType
        /// </summary>
        public static readonly AnomalyFeedbackType PLANNED_ACTIVITY = new AnomalyFeedbackType("PLANNED_ACTIVITY");
        /// <summary>
        /// Constant YES for AnomalyFeedbackType
        /// </summary>
        public static readonly AnomalyFeedbackType YES = new AnomalyFeedbackType("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyFeedbackType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyFeedbackType FindValue(string value)
        {
            return FindValue<AnomalyFeedbackType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyFeedbackType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnomalySubscriptionFrequency.
    /// </summary>
    public class AnomalySubscriptionFrequency : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for AnomalySubscriptionFrequency
        /// </summary>
        public static readonly AnomalySubscriptionFrequency DAILY = new AnomalySubscriptionFrequency("DAILY");
        /// <summary>
        /// Constant IMMEDIATE for AnomalySubscriptionFrequency
        /// </summary>
        public static readonly AnomalySubscriptionFrequency IMMEDIATE = new AnomalySubscriptionFrequency("IMMEDIATE");
        /// <summary>
        /// Constant WEEKLY for AnomalySubscriptionFrequency
        /// </summary>
        public static readonly AnomalySubscriptionFrequency WEEKLY = new AnomalySubscriptionFrequency("WEEKLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalySubscriptionFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalySubscriptionFrequency FindValue(string value)
        {
            return FindValue<AnomalySubscriptionFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalySubscriptionFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Context.
    /// </summary>
    public class Context : ConstantClass
    {

        /// <summary>
        /// Constant COST_AND_USAGE for Context
        /// </summary>
        public static readonly Context COST_AND_USAGE = new Context("COST_AND_USAGE");
        /// <summary>
        /// Constant RESERVATIONS for Context
        /// </summary>
        public static readonly Context RESERVATIONS = new Context("RESERVATIONS");
        /// <summary>
        /// Constant SAVINGS_PLANS for Context
        /// </summary>
        public static readonly Context SAVINGS_PLANS = new Context("SAVINGS_PLANS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Context(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Context FindValue(string value)
        {
            return FindValue<Context>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Context(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostAllocationTagStatus.
    /// </summary>
    public class CostAllocationTagStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for CostAllocationTagStatus
        /// </summary>
        public static readonly CostAllocationTagStatus Active = new CostAllocationTagStatus("Active");
        /// <summary>
        /// Constant Inactive for CostAllocationTagStatus
        /// </summary>
        public static readonly CostAllocationTagStatus Inactive = new CostAllocationTagStatus("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostAllocationTagStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostAllocationTagStatus FindValue(string value)
        {
            return FindValue<CostAllocationTagStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostAllocationTagStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostAllocationTagType.
    /// </summary>
    public class CostAllocationTagType : ConstantClass
    {

        /// <summary>
        /// Constant AWSGenerated for CostAllocationTagType
        /// </summary>
        public static readonly CostAllocationTagType AWSGenerated = new CostAllocationTagType("AWSGenerated");
        /// <summary>
        /// Constant UserDefined for CostAllocationTagType
        /// </summary>
        public static readonly CostAllocationTagType UserDefined = new CostAllocationTagType("UserDefined");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostAllocationTagType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostAllocationTagType FindValue(string value)
        {
            return FindValue<CostAllocationTagType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostAllocationTagType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostCategoryInheritedValueDimensionName.
    /// </summary>
    public class CostCategoryInheritedValueDimensionName : ConstantClass
    {

        /// <summary>
        /// Constant LINKED_ACCOUNT_NAME for CostCategoryInheritedValueDimensionName
        /// </summary>
        public static readonly CostCategoryInheritedValueDimensionName LINKED_ACCOUNT_NAME = new CostCategoryInheritedValueDimensionName("LINKED_ACCOUNT_NAME");
        /// <summary>
        /// Constant TAG for CostCategoryInheritedValueDimensionName
        /// </summary>
        public static readonly CostCategoryInheritedValueDimensionName TAG = new CostCategoryInheritedValueDimensionName("TAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostCategoryInheritedValueDimensionName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostCategoryInheritedValueDimensionName FindValue(string value)
        {
            return FindValue<CostCategoryInheritedValueDimensionName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostCategoryInheritedValueDimensionName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostCategoryRuleType.
    /// </summary>
    public class CostCategoryRuleType : ConstantClass
    {

        /// <summary>
        /// Constant INHERITED_VALUE for CostCategoryRuleType
        /// </summary>
        public static readonly CostCategoryRuleType INHERITED_VALUE = new CostCategoryRuleType("INHERITED_VALUE");
        /// <summary>
        /// Constant REGULAR for CostCategoryRuleType
        /// </summary>
        public static readonly CostCategoryRuleType REGULAR = new CostCategoryRuleType("REGULAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostCategoryRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostCategoryRuleType FindValue(string value)
        {
            return FindValue<CostCategoryRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostCategoryRuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostCategoryRuleVersion.
    /// </summary>
    public class CostCategoryRuleVersion : ConstantClass
    {

        /// <summary>
        /// Constant CostCategoryExpressionV1 for CostCategoryRuleVersion
        /// </summary>
        public static readonly CostCategoryRuleVersion CostCategoryExpressionV1 = new CostCategoryRuleVersion("CostCategoryExpression.v1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostCategoryRuleVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostCategoryRuleVersion FindValue(string value)
        {
            return FindValue<CostCategoryRuleVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostCategoryRuleVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostCategorySplitChargeMethod.
    /// </summary>
    public class CostCategorySplitChargeMethod : ConstantClass
    {

        /// <summary>
        /// Constant EVEN for CostCategorySplitChargeMethod
        /// </summary>
        public static readonly CostCategorySplitChargeMethod EVEN = new CostCategorySplitChargeMethod("EVEN");
        /// <summary>
        /// Constant FIXED for CostCategorySplitChargeMethod
        /// </summary>
        public static readonly CostCategorySplitChargeMethod FIXED = new CostCategorySplitChargeMethod("FIXED");
        /// <summary>
        /// Constant PROPORTIONAL for CostCategorySplitChargeMethod
        /// </summary>
        public static readonly CostCategorySplitChargeMethod PROPORTIONAL = new CostCategorySplitChargeMethod("PROPORTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostCategorySplitChargeMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostCategorySplitChargeMethod FindValue(string value)
        {
            return FindValue<CostCategorySplitChargeMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostCategorySplitChargeMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostCategorySplitChargeRuleParameterType.
    /// </summary>
    public class CostCategorySplitChargeRuleParameterType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOCATION_PERCENTAGES for CostCategorySplitChargeRuleParameterType
        /// </summary>
        public static readonly CostCategorySplitChargeRuleParameterType ALLOCATION_PERCENTAGES = new CostCategorySplitChargeRuleParameterType("ALLOCATION_PERCENTAGES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostCategorySplitChargeRuleParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostCategorySplitChargeRuleParameterType FindValue(string value)
        {
            return FindValue<CostCategorySplitChargeRuleParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostCategorySplitChargeRuleParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostCategoryStatus.
    /// </summary>
    public class CostCategoryStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPLIED for CostCategoryStatus
        /// </summary>
        public static readonly CostCategoryStatus APPLIED = new CostCategoryStatus("APPLIED");
        /// <summary>
        /// Constant PROCESSING for CostCategoryStatus
        /// </summary>
        public static readonly CostCategoryStatus PROCESSING = new CostCategoryStatus("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostCategoryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostCategoryStatus FindValue(string value)
        {
            return FindValue<CostCategoryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostCategoryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostCategoryStatusComponent.
    /// </summary>
    public class CostCategoryStatusComponent : ConstantClass
    {

        /// <summary>
        /// Constant COST_EXPLORER for CostCategoryStatusComponent
        /// </summary>
        public static readonly CostCategoryStatusComponent COST_EXPLORER = new CostCategoryStatusComponent("COST_EXPLORER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostCategoryStatusComponent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostCategoryStatusComponent FindValue(string value)
        {
            return FindValue<CostCategoryStatusComponent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostCategoryStatusComponent(string value)
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
        /// Constant AGREEMENT_END_DATE_TIME_AFTER for Dimension
        /// </summary>
        public static readonly Dimension AGREEMENT_END_DATE_TIME_AFTER = new Dimension("AGREEMENT_END_DATE_TIME_AFTER");
        /// <summary>
        /// Constant AGREEMENT_END_DATE_TIME_BEFORE for Dimension
        /// </summary>
        public static readonly Dimension AGREEMENT_END_DATE_TIME_BEFORE = new Dimension("AGREEMENT_END_DATE_TIME_BEFORE");
        /// <summary>
        /// Constant ANOMALY_TOTAL_IMPACT_ABSOLUTE for Dimension
        /// </summary>
        public static readonly Dimension ANOMALY_TOTAL_IMPACT_ABSOLUTE = new Dimension("ANOMALY_TOTAL_IMPACT_ABSOLUTE");
        /// <summary>
        /// Constant ANOMALY_TOTAL_IMPACT_PERCENTAGE for Dimension
        /// </summary>
        public static readonly Dimension ANOMALY_TOTAL_IMPACT_PERCENTAGE = new Dimension("ANOMALY_TOTAL_IMPACT_PERCENTAGE");
        /// <summary>
        /// Constant AZ for Dimension
        /// </summary>
        public static readonly Dimension AZ = new Dimension("AZ");
        /// <summary>
        /// Constant BILLING_ENTITY for Dimension
        /// </summary>
        public static readonly Dimension BILLING_ENTITY = new Dimension("BILLING_ENTITY");
        /// <summary>
        /// Constant CACHE_ENGINE for Dimension
        /// </summary>
        public static readonly Dimension CACHE_ENGINE = new Dimension("CACHE_ENGINE");
        /// <summary>
        /// Constant DATABASE_ENGINE for Dimension
        /// </summary>
        public static readonly Dimension DATABASE_ENGINE = new Dimension("DATABASE_ENGINE");
        /// <summary>
        /// Constant DEPLOYMENT_OPTION for Dimension
        /// </summary>
        public static readonly Dimension DEPLOYMENT_OPTION = new Dimension("DEPLOYMENT_OPTION");
        /// <summary>
        /// Constant INSTANCE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension INSTANCE_TYPE = new Dimension("INSTANCE_TYPE");
        /// <summary>
        /// Constant INSTANCE_TYPE_FAMILY for Dimension
        /// </summary>
        public static readonly Dimension INSTANCE_TYPE_FAMILY = new Dimension("INSTANCE_TYPE_FAMILY");
        /// <summary>
        /// Constant INVOICING_ENTITY for Dimension
        /// </summary>
        public static readonly Dimension INVOICING_ENTITY = new Dimension("INVOICING_ENTITY");
        /// <summary>
        /// Constant LEGAL_ENTITY_NAME for Dimension
        /// </summary>
        public static readonly Dimension LEGAL_ENTITY_NAME = new Dimension("LEGAL_ENTITY_NAME");
        /// <summary>
        /// Constant LINKED_ACCOUNT for Dimension
        /// </summary>
        public static readonly Dimension LINKED_ACCOUNT = new Dimension("LINKED_ACCOUNT");
        /// <summary>
        /// Constant LINKED_ACCOUNT_NAME for Dimension
        /// </summary>
        public static readonly Dimension LINKED_ACCOUNT_NAME = new Dimension("LINKED_ACCOUNT_NAME");
        /// <summary>
        /// Constant OPERATING_SYSTEM for Dimension
        /// </summary>
        public static readonly Dimension OPERATING_SYSTEM = new Dimension("OPERATING_SYSTEM");
        /// <summary>
        /// Constant OPERATION for Dimension
        /// </summary>
        public static readonly Dimension OPERATION = new Dimension("OPERATION");
        /// <summary>
        /// Constant PAYMENT_OPTION for Dimension
        /// </summary>
        public static readonly Dimension PAYMENT_OPTION = new Dimension("PAYMENT_OPTION");
        /// <summary>
        /// Constant PLATFORM for Dimension
        /// </summary>
        public static readonly Dimension PLATFORM = new Dimension("PLATFORM");
        /// <summary>
        /// Constant PURCHASE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension PURCHASE_TYPE = new Dimension("PURCHASE_TYPE");
        /// <summary>
        /// Constant RECORD_TYPE for Dimension
        /// </summary>
        public static readonly Dimension RECORD_TYPE = new Dimension("RECORD_TYPE");
        /// <summary>
        /// Constant REGION for Dimension
        /// </summary>
        public static readonly Dimension REGION = new Dimension("REGION");
        /// <summary>
        /// Constant RESERVATION_ID for Dimension
        /// </summary>
        public static readonly Dimension RESERVATION_ID = new Dimension("RESERVATION_ID");
        /// <summary>
        /// Constant RESOURCE_ID for Dimension
        /// </summary>
        public static readonly Dimension RESOURCE_ID = new Dimension("RESOURCE_ID");
        /// <summary>
        /// Constant RIGHTSIZING_TYPE for Dimension
        /// </summary>
        public static readonly Dimension RIGHTSIZING_TYPE = new Dimension("RIGHTSIZING_TYPE");
        /// <summary>
        /// Constant SAVINGS_PLAN_ARN for Dimension
        /// </summary>
        public static readonly Dimension SAVINGS_PLAN_ARN = new Dimension("SAVINGS_PLAN_ARN");
        /// <summary>
        /// Constant SAVINGS_PLANS_TYPE for Dimension
        /// </summary>
        public static readonly Dimension SAVINGS_PLANS_TYPE = new Dimension("SAVINGS_PLANS_TYPE");
        /// <summary>
        /// Constant SCOPE for Dimension
        /// </summary>
        public static readonly Dimension SCOPE = new Dimension("SCOPE");
        /// <summary>
        /// Constant SERVICE for Dimension
        /// </summary>
        public static readonly Dimension SERVICE = new Dimension("SERVICE");
        /// <summary>
        /// Constant SERVICE_CODE for Dimension
        /// </summary>
        public static readonly Dimension SERVICE_CODE = new Dimension("SERVICE_CODE");
        /// <summary>
        /// Constant SUBSCRIPTION_ID for Dimension
        /// </summary>
        public static readonly Dimension SUBSCRIPTION_ID = new Dimension("SUBSCRIPTION_ID");
        /// <summary>
        /// Constant TENANCY for Dimension
        /// </summary>
        public static readonly Dimension TENANCY = new Dimension("TENANCY");
        /// <summary>
        /// Constant USAGE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension USAGE_TYPE = new Dimension("USAGE_TYPE");
        /// <summary>
        /// Constant USAGE_TYPE_GROUP for Dimension
        /// </summary>
        public static readonly Dimension USAGE_TYPE_GROUP = new Dimension("USAGE_TYPE_GROUP");

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
    /// Constants used for properties of type FindingReasonCode.
    /// </summary>
    public class FindingReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CPU_OVER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode CPU_OVER_PROVISIONED = new FindingReasonCode("CPU_OVER_PROVISIONED");
        /// <summary>
        /// Constant CPU_UNDER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode CPU_UNDER_PROVISIONED = new FindingReasonCode("CPU_UNDER_PROVISIONED");
        /// <summary>
        /// Constant DISK_IOPS_OVER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode DISK_IOPS_OVER_PROVISIONED = new FindingReasonCode("DISK_IOPS_OVER_PROVISIONED");
        /// <summary>
        /// Constant DISK_IOPS_UNDER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode DISK_IOPS_UNDER_PROVISIONED = new FindingReasonCode("DISK_IOPS_UNDER_PROVISIONED");
        /// <summary>
        /// Constant DISK_THROUGHPUT_OVER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode DISK_THROUGHPUT_OVER_PROVISIONED = new FindingReasonCode("DISK_THROUGHPUT_OVER_PROVISIONED");
        /// <summary>
        /// Constant DISK_THROUGHPUT_UNDER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode DISK_THROUGHPUT_UNDER_PROVISIONED = new FindingReasonCode("DISK_THROUGHPUT_UNDER_PROVISIONED");
        /// <summary>
        /// Constant EBS_IOPS_OVER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode EBS_IOPS_OVER_PROVISIONED = new FindingReasonCode("EBS_IOPS_OVER_PROVISIONED");
        /// <summary>
        /// Constant EBS_IOPS_UNDER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode EBS_IOPS_UNDER_PROVISIONED = new FindingReasonCode("EBS_IOPS_UNDER_PROVISIONED");
        /// <summary>
        /// Constant EBS_THROUGHPUT_OVER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode EBS_THROUGHPUT_OVER_PROVISIONED = new FindingReasonCode("EBS_THROUGHPUT_OVER_PROVISIONED");
        /// <summary>
        /// Constant EBS_THROUGHPUT_UNDER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode EBS_THROUGHPUT_UNDER_PROVISIONED = new FindingReasonCode("EBS_THROUGHPUT_UNDER_PROVISIONED");
        /// <summary>
        /// Constant MEMORY_OVER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode MEMORY_OVER_PROVISIONED = new FindingReasonCode("MEMORY_OVER_PROVISIONED");
        /// <summary>
        /// Constant MEMORY_UNDER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode MEMORY_UNDER_PROVISIONED = new FindingReasonCode("MEMORY_UNDER_PROVISIONED");
        /// <summary>
        /// Constant NETWORK_BANDWIDTH_OVER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode NETWORK_BANDWIDTH_OVER_PROVISIONED = new FindingReasonCode("NETWORK_BANDWIDTH_OVER_PROVISIONED");
        /// <summary>
        /// Constant NETWORK_BANDWIDTH_UNDER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode NETWORK_BANDWIDTH_UNDER_PROVISIONED = new FindingReasonCode("NETWORK_BANDWIDTH_UNDER_PROVISIONED");
        /// <summary>
        /// Constant NETWORK_PPS_OVER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode NETWORK_PPS_OVER_PROVISIONED = new FindingReasonCode("NETWORK_PPS_OVER_PROVISIONED");
        /// <summary>
        /// Constant NETWORK_PPS_UNDER_PROVISIONED for FindingReasonCode
        /// </summary>
        public static readonly FindingReasonCode NETWORK_PPS_UNDER_PROVISIONED = new FindingReasonCode("NETWORK_PPS_UNDER_PROVISIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingReasonCode FindValue(string value)
        {
            return FindValue<FindingReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GenerationStatus.
    /// </summary>
    public class GenerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for GenerationStatus
        /// </summary>
        public static readonly GenerationStatus FAILED = new GenerationStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for GenerationStatus
        /// </summary>
        public static readonly GenerationStatus PROCESSING = new GenerationStatus("PROCESSING");
        /// <summary>
        /// Constant SUCCEEDED for GenerationStatus
        /// </summary>
        public static readonly GenerationStatus SUCCEEDED = new GenerationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GenerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GenerationStatus FindValue(string value)
        {
            return FindValue<GenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GenerationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Granularity.
    /// </summary>
    public class Granularity : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for Granularity
        /// </summary>
        public static readonly Granularity DAILY = new Granularity("DAILY");
        /// <summary>
        /// Constant HOURLY for Granularity
        /// </summary>
        public static readonly Granularity HOURLY = new Granularity("HOURLY");
        /// <summary>
        /// Constant MONTHLY for Granularity
        /// </summary>
        public static readonly Granularity MONTHLY = new Granularity("MONTHLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Granularity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Granularity FindValue(string value)
        {
            return FindValue<Granularity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Granularity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupDefinitionType.
    /// </summary>
    public class GroupDefinitionType : ConstantClass
    {

        /// <summary>
        /// Constant COST_CATEGORY for GroupDefinitionType
        /// </summary>
        public static readonly GroupDefinitionType COST_CATEGORY = new GroupDefinitionType("COST_CATEGORY");
        /// <summary>
        /// Constant DIMENSION for GroupDefinitionType
        /// </summary>
        public static readonly GroupDefinitionType DIMENSION = new GroupDefinitionType("DIMENSION");
        /// <summary>
        /// Constant TAG for GroupDefinitionType
        /// </summary>
        public static readonly GroupDefinitionType TAG = new GroupDefinitionType("TAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupDefinitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupDefinitionType FindValue(string value)
        {
            return FindValue<GroupDefinitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupDefinitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LookbackPeriodInDays.
    /// </summary>
    public class LookbackPeriodInDays : ConstantClass
    {

        /// <summary>
        /// Constant SEVEN_DAYS for LookbackPeriodInDays
        /// </summary>
        public static readonly LookbackPeriodInDays SEVEN_DAYS = new LookbackPeriodInDays("SEVEN_DAYS");
        /// <summary>
        /// Constant SIXTY_DAYS for LookbackPeriodInDays
        /// </summary>
        public static readonly LookbackPeriodInDays SIXTY_DAYS = new LookbackPeriodInDays("SIXTY_DAYS");
        /// <summary>
        /// Constant THIRTY_DAYS for LookbackPeriodInDays
        /// </summary>
        public static readonly LookbackPeriodInDays THIRTY_DAYS = new LookbackPeriodInDays("THIRTY_DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LookbackPeriodInDays(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LookbackPeriodInDays FindValue(string value)
        {
            return FindValue<LookbackPeriodInDays>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LookbackPeriodInDays(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchOption.
    /// </summary>
    public class MatchOption : ConstantClass
    {

        /// <summary>
        /// Constant ABSENT for MatchOption
        /// </summary>
        public static readonly MatchOption ABSENT = new MatchOption("ABSENT");
        /// <summary>
        /// Constant CASE_INSENSITIVE for MatchOption
        /// </summary>
        public static readonly MatchOption CASE_INSENSITIVE = new MatchOption("CASE_INSENSITIVE");
        /// <summary>
        /// Constant CASE_SENSITIVE for MatchOption
        /// </summary>
        public static readonly MatchOption CASE_SENSITIVE = new MatchOption("CASE_SENSITIVE");
        /// <summary>
        /// Constant CONTAINS for MatchOption
        /// </summary>
        public static readonly MatchOption CONTAINS = new MatchOption("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for MatchOption
        /// </summary>
        public static readonly MatchOption ENDS_WITH = new MatchOption("ENDS_WITH");
        /// <summary>
        /// Constant EQUALS for MatchOption
        /// </summary>
        public static readonly MatchOption EQUALS = new MatchOption("EQUALS");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for MatchOption
        /// </summary>
        public static readonly MatchOption GREATER_THAN_OR_EQUAL = new MatchOption("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant STARTS_WITH for MatchOption
        /// </summary>
        public static readonly MatchOption STARTS_WITH = new MatchOption("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchOption FindValue(string value)
        {
            return FindValue<MatchOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Metric.
    /// </summary>
    public class Metric : ConstantClass
    {

        /// <summary>
        /// Constant AMORTIZED_COST for Metric
        /// </summary>
        public static readonly Metric AMORTIZED_COST = new Metric("AMORTIZED_COST");
        /// <summary>
        /// Constant BLENDED_COST for Metric
        /// </summary>
        public static readonly Metric BLENDED_COST = new Metric("BLENDED_COST");
        /// <summary>
        /// Constant NET_AMORTIZED_COST for Metric
        /// </summary>
        public static readonly Metric NET_AMORTIZED_COST = new Metric("NET_AMORTIZED_COST");
        /// <summary>
        /// Constant NET_UNBLENDED_COST for Metric
        /// </summary>
        public static readonly Metric NET_UNBLENDED_COST = new Metric("NET_UNBLENDED_COST");
        /// <summary>
        /// Constant NORMALIZED_USAGE_AMOUNT for Metric
        /// </summary>
        public static readonly Metric NORMALIZED_USAGE_AMOUNT = new Metric("NORMALIZED_USAGE_AMOUNT");
        /// <summary>
        /// Constant UNBLENDED_COST for Metric
        /// </summary>
        public static readonly Metric UNBLENDED_COST = new Metric("UNBLENDED_COST");
        /// <summary>
        /// Constant USAGE_QUANTITY for Metric
        /// </summary>
        public static readonly Metric USAGE_QUANTITY = new Metric("USAGE_QUANTITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Metric(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Metric FindValue(string value)
        {
            return FindValue<Metric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Metric(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorDimension.
    /// </summary>
    public class MonitorDimension : ConstantClass
    {

        /// <summary>
        /// Constant SERVICE for MonitorDimension
        /// </summary>
        public static readonly MonitorDimension SERVICE = new MonitorDimension("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorDimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorDimension FindValue(string value)
        {
            return FindValue<MonitorDimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorDimension(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorType.
    /// </summary>
    public class MonitorType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for MonitorType
        /// </summary>
        public static readonly MonitorType CUSTOM = new MonitorType("CUSTOM");
        /// <summary>
        /// Constant DIMENSIONAL for MonitorType
        /// </summary>
        public static readonly MonitorType DIMENSIONAL = new MonitorType("DIMENSIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorType FindValue(string value)
        {
            return FindValue<MonitorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumericOperator.
    /// </summary>
    public class NumericOperator : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for NumericOperator
        /// </summary>
        public static readonly NumericOperator BETWEEN = new NumericOperator("BETWEEN");
        /// <summary>
        /// Constant EQUAL for NumericOperator
        /// </summary>
        public static readonly NumericOperator EQUAL = new NumericOperator("EQUAL");
        /// <summary>
        /// Constant GREATER_THAN for NumericOperator
        /// </summary>
        public static readonly NumericOperator GREATER_THAN = new NumericOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for NumericOperator
        /// </summary>
        public static readonly NumericOperator GREATER_THAN_OR_EQUAL = new NumericOperator("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant LESS_THAN for NumericOperator
        /// </summary>
        public static readonly NumericOperator LESS_THAN = new NumericOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL for NumericOperator
        /// </summary>
        public static readonly NumericOperator LESS_THAN_OR_EQUAL = new NumericOperator("LESS_THAN_OR_EQUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumericOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumericOperator FindValue(string value)
        {
            return FindValue<NumericOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumericOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferingClass.
    /// </summary>
    public class OfferingClass : ConstantClass
    {

        /// <summary>
        /// Constant CONVERTIBLE for OfferingClass
        /// </summary>
        public static readonly OfferingClass CONVERTIBLE = new OfferingClass("CONVERTIBLE");
        /// <summary>
        /// Constant STANDARD for OfferingClass
        /// </summary>
        public static readonly OfferingClass STANDARD = new OfferingClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferingClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingClass FindValue(string value)
        {
            return FindValue<OfferingClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferingClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaymentOption.
    /// </summary>
    public class PaymentOption : ConstantClass
    {

        /// <summary>
        /// Constant ALL_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption ALL_UPFRONT = new PaymentOption("ALL_UPFRONT");
        /// <summary>
        /// Constant HEAVY_UTILIZATION for PaymentOption
        /// </summary>
        public static readonly PaymentOption HEAVY_UTILIZATION = new PaymentOption("HEAVY_UTILIZATION");
        /// <summary>
        /// Constant LIGHT_UTILIZATION for PaymentOption
        /// </summary>
        public static readonly PaymentOption LIGHT_UTILIZATION = new PaymentOption("LIGHT_UTILIZATION");
        /// <summary>
        /// Constant MEDIUM_UTILIZATION for PaymentOption
        /// </summary>
        public static readonly PaymentOption MEDIUM_UTILIZATION = new PaymentOption("MEDIUM_UTILIZATION");
        /// <summary>
        /// Constant NO_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption NO_UPFRONT = new PaymentOption("NO_UPFRONT");
        /// <summary>
        /// Constant PARTIAL_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption PARTIAL_UPFRONT = new PaymentOption("PARTIAL_UPFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentOption FindValue(string value)
        {
            return FindValue<PaymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformDifference.
    /// </summary>
    public class PlatformDifference : ConstantClass
    {

        /// <summary>
        /// Constant HYPERVISOR for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference HYPERVISOR = new PlatformDifference("HYPERVISOR");
        /// <summary>
        /// Constant INSTANCE_STORE_AVAILABILITY for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference INSTANCE_STORE_AVAILABILITY = new PlatformDifference("INSTANCE_STORE_AVAILABILITY");
        /// <summary>
        /// Constant NETWORK_INTERFACE for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference NETWORK_INTERFACE = new PlatformDifference("NETWORK_INTERFACE");
        /// <summary>
        /// Constant STORAGE_INTERFACE for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference STORAGE_INTERFACE = new PlatformDifference("STORAGE_INTERFACE");
        /// <summary>
        /// Constant VIRTUALIZATION_TYPE for PlatformDifference
        /// </summary>
        public static readonly PlatformDifference VIRTUALIZATION_TYPE = new PlatformDifference("VIRTUALIZATION_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformDifference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformDifference FindValue(string value)
        {
            return FindValue<PlatformDifference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformDifference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationTarget.
    /// </summary>
    public class RecommendationTarget : ConstantClass
    {

        /// <summary>
        /// Constant CROSS_INSTANCE_FAMILY for RecommendationTarget
        /// </summary>
        public static readonly RecommendationTarget CROSS_INSTANCE_FAMILY = new RecommendationTarget("CROSS_INSTANCE_FAMILY");
        /// <summary>
        /// Constant SAME_INSTANCE_FAMILY for RecommendationTarget
        /// </summary>
        public static readonly RecommendationTarget SAME_INSTANCE_FAMILY = new RecommendationTarget("SAME_INSTANCE_FAMILY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationTarget(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationTarget FindValue(string value)
        {
            return FindValue<RecommendationTarget>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationTarget(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RightsizingType.
    /// </summary>
    public class RightsizingType : ConstantClass
    {

        /// <summary>
        /// Constant MODIFY for RightsizingType
        /// </summary>
        public static readonly RightsizingType MODIFY = new RightsizingType("MODIFY");
        /// <summary>
        /// Constant TERMINATE for RightsizingType
        /// </summary>
        public static readonly RightsizingType TERMINATE = new RightsizingType("TERMINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RightsizingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RightsizingType FindValue(string value)
        {
            return FindValue<RightsizingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RightsizingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlansDataType.
    /// </summary>
    public class SavingsPlansDataType : ConstantClass
    {

        /// <summary>
        /// Constant AMORTIZED_COMMITMENT for SavingsPlansDataType
        /// </summary>
        public static readonly SavingsPlansDataType AMORTIZED_COMMITMENT = new SavingsPlansDataType("AMORTIZED_COMMITMENT");
        /// <summary>
        /// Constant ATTRIBUTES for SavingsPlansDataType
        /// </summary>
        public static readonly SavingsPlansDataType ATTRIBUTES = new SavingsPlansDataType("ATTRIBUTES");
        /// <summary>
        /// Constant SAVINGS for SavingsPlansDataType
        /// </summary>
        public static readonly SavingsPlansDataType SAVINGS = new SavingsPlansDataType("SAVINGS");
        /// <summary>
        /// Constant UTILIZATION for SavingsPlansDataType
        /// </summary>
        public static readonly SavingsPlansDataType UTILIZATION = new SavingsPlansDataType("UTILIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlansDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlansDataType FindValue(string value)
        {
            return FindValue<SavingsPlansDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlansDataType(string value)
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
    /// Constants used for properties of type SubscriberStatus.
    /// </summary>
    public class SubscriberStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONFIRMED for SubscriberStatus
        /// </summary>
        public static readonly SubscriberStatus CONFIRMED = new SubscriberStatus("CONFIRMED");
        /// <summary>
        /// Constant DECLINED for SubscriberStatus
        /// </summary>
        public static readonly SubscriberStatus DECLINED = new SubscriberStatus("DECLINED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriberStatus FindValue(string value)
        {
            return FindValue<SubscriberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriberStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriberType.
    /// </summary>
    public class SubscriberType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for SubscriberType
        /// </summary>
        public static readonly SubscriberType EMAIL = new SubscriberType("EMAIL");
        /// <summary>
        /// Constant SNS for SubscriberType
        /// </summary>
        public static readonly SubscriberType SNS = new SubscriberType("SNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriberType FindValue(string value)
        {
            return FindValue<SubscriberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupportedSavingsPlansType.
    /// </summary>
    public class SupportedSavingsPlansType : ConstantClass
    {

        /// <summary>
        /// Constant COMPUTE_SP for SupportedSavingsPlansType
        /// </summary>
        public static readonly SupportedSavingsPlansType COMPUTE_SP = new SupportedSavingsPlansType("COMPUTE_SP");
        /// <summary>
        /// Constant EC2_INSTANCE_SP for SupportedSavingsPlansType
        /// </summary>
        public static readonly SupportedSavingsPlansType EC2_INSTANCE_SP = new SupportedSavingsPlansType("EC2_INSTANCE_SP");
        /// <summary>
        /// Constant SAGEMAKER_SP for SupportedSavingsPlansType
        /// </summary>
        public static readonly SupportedSavingsPlansType SAGEMAKER_SP = new SupportedSavingsPlansType("SAGEMAKER_SP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupportedSavingsPlansType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupportedSavingsPlansType FindValue(string value)
        {
            return FindValue<SupportedSavingsPlansType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupportedSavingsPlansType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TermInYears.
    /// </summary>
    public class TermInYears : ConstantClass
    {

        /// <summary>
        /// Constant ONE_YEAR for TermInYears
        /// </summary>
        public static readonly TermInYears ONE_YEAR = new TermInYears("ONE_YEAR");
        /// <summary>
        /// Constant THREE_YEARS for TermInYears
        /// </summary>
        public static readonly TermInYears THREE_YEARS = new TermInYears("THREE_YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TermInYears(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TermInYears FindValue(string value)
        {
            return FindValue<TermInYears>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TermInYears(string value)
        {
            return FindValue(value);
        }
    }

}