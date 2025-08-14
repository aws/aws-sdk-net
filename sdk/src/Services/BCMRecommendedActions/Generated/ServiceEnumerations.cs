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
 * Do not modify this file. This file is generated from the bcm-recommended-actions-2024-11-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BCMRecommendedActions
{

    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant ADD_ALTERNATE_BILLING_CONTACT for ActionType
        /// </summary>
        public static readonly ActionType ADD_ALTERNATE_BILLING_CONTACT = new ActionType("ADD_ALTERNATE_BILLING_CONTACT");
        /// <summary>
        /// Constant CREATE_ANOMALY_MONITOR for ActionType
        /// </summary>
        public static readonly ActionType CREATE_ANOMALY_MONITOR = new ActionType("CREATE_ANOMALY_MONITOR");
        /// <summary>
        /// Constant CREATE_BUDGET for ActionType
        /// </summary>
        public static readonly ActionType CREATE_BUDGET = new ActionType("CREATE_BUDGET");
        /// <summary>
        /// Constant ENABLE_COST_OPTIMIZATION_HUB for ActionType
        /// </summary>
        public static readonly ActionType ENABLE_COST_OPTIMIZATION_HUB = new ActionType("ENABLE_COST_OPTIMIZATION_HUB");
        /// <summary>
        /// Constant MIGRATE_TO_GRANULAR_PERMISSIONS for ActionType
        /// </summary>
        public static readonly ActionType MIGRATE_TO_GRANULAR_PERMISSIONS = new ActionType("MIGRATE_TO_GRANULAR_PERMISSIONS");
        /// <summary>
        /// Constant PAYMENTS_DUE for ActionType
        /// </summary>
        public static readonly ActionType PAYMENTS_DUE = new ActionType("PAYMENTS_DUE");
        /// <summary>
        /// Constant PAYMENTS_PAST_DUE for ActionType
        /// </summary>
        public static readonly ActionType PAYMENTS_PAST_DUE = new ActionType("PAYMENTS_PAST_DUE");
        /// <summary>
        /// Constant REVIEW_ANOMALIES for ActionType
        /// </summary>
        public static readonly ActionType REVIEW_ANOMALIES = new ActionType("REVIEW_ANOMALIES");
        /// <summary>
        /// Constant REVIEW_BUDGET_ALERTS for ActionType
        /// </summary>
        public static readonly ActionType REVIEW_BUDGET_ALERTS = new ActionType("REVIEW_BUDGET_ALERTS");
        /// <summary>
        /// Constant REVIEW_BUDGETS_EXCEEDED for ActionType
        /// </summary>
        public static readonly ActionType REVIEW_BUDGETS_EXCEEDED = new ActionType("REVIEW_BUDGETS_EXCEEDED");
        /// <summary>
        /// Constant REVIEW_EXPIRING_RI for ActionType
        /// </summary>
        public static readonly ActionType REVIEW_EXPIRING_RI = new ActionType("REVIEW_EXPIRING_RI");
        /// <summary>
        /// Constant REVIEW_EXPIRING_SP for ActionType
        /// </summary>
        public static readonly ActionType REVIEW_EXPIRING_SP = new ActionType("REVIEW_EXPIRING_SP");
        /// <summary>
        /// Constant REVIEW_FREETIER_USAGE_ALERTS for ActionType
        /// </summary>
        public static readonly ActionType REVIEW_FREETIER_USAGE_ALERTS = new ActionType("REVIEW_FREETIER_USAGE_ALERTS");
        /// <summary>
        /// Constant REVIEW_SAVINGS_OPPORTUNITY_RECOMMENDATIONS for ActionType
        /// </summary>
        public static readonly ActionType REVIEW_SAVINGS_OPPORTUNITY_RECOMMENDATIONS = new ActionType("REVIEW_SAVINGS_OPPORTUNITY_RECOMMENDATIONS");
        /// <summary>
        /// Constant UPDATE_EXPIRED_PAYMENT_METHOD for ActionType
        /// </summary>
        public static readonly ActionType UPDATE_EXPIRED_PAYMENT_METHOD = new ActionType("UPDATE_EXPIRED_PAYMENT_METHOD");
        /// <summary>
        /// Constant UPDATE_INVALID_PAYMENT_METHOD for ActionType
        /// </summary>
        public static readonly ActionType UPDATE_INVALID_PAYMENT_METHOD = new ActionType("UPDATE_INVALID_PAYMENT_METHOD");
        /// <summary>
        /// Constant UPDATE_TAX_EXEMPTION_CERTIFICATE for ActionType
        /// </summary>
        public static readonly ActionType UPDATE_TAX_EXEMPTION_CERTIFICATE = new ActionType("UPDATE_TAX_EXEMPTION_CERTIFICATE");
        /// <summary>
        /// Constant UPDATE_TAX_REGISTRATION_NUMBER for ActionType
        /// </summary>
        public static readonly ActionType UPDATE_TAX_REGISTRATION_NUMBER = new ActionType("UPDATE_TAX_REGISTRATION_NUMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Feature.
    /// </summary>
    public class Feature : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for Feature
        /// </summary>
        public static readonly Feature ACCOUNT = new Feature("ACCOUNT");
        /// <summary>
        /// Constant BUDGETS for Feature
        /// </summary>
        public static readonly Feature BUDGETS = new Feature("BUDGETS");
        /// <summary>
        /// Constant COST_ANOMALY_DETECTION for Feature
        /// </summary>
        public static readonly Feature COST_ANOMALY_DETECTION = new Feature("COST_ANOMALY_DETECTION");
        /// <summary>
        /// Constant COST_OPTIMIZATION_HUB for Feature
        /// </summary>
        public static readonly Feature COST_OPTIMIZATION_HUB = new Feature("COST_OPTIMIZATION_HUB");
        /// <summary>
        /// Constant FREE_TIER for Feature
        /// </summary>
        public static readonly Feature FREE_TIER = new Feature("FREE_TIER");
        /// <summary>
        /// Constant IAM for Feature
        /// </summary>
        public static readonly Feature IAM = new Feature("IAM");
        /// <summary>
        /// Constant PAYMENTS for Feature
        /// </summary>
        public static readonly Feature PAYMENTS = new Feature("PAYMENTS");
        /// <summary>
        /// Constant RESERVATIONS for Feature
        /// </summary>
        public static readonly Feature RESERVATIONS = new Feature("RESERVATIONS");
        /// <summary>
        /// Constant SAVINGS_PLANS for Feature
        /// </summary>
        public static readonly Feature SAVINGS_PLANS = new Feature("SAVINGS_PLANS");
        /// <summary>
        /// Constant TAX_SETTINGS for Feature
        /// </summary>
        public static readonly Feature TAX_SETTINGS = new Feature("TAX_SETTINGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Feature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Feature FindValue(string value)
        {
            return FindValue<Feature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Feature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterName.
    /// </summary>
    public class FilterName : ConstantClass
    {

        /// <summary>
        /// Constant FEATURE for FilterName
        /// </summary>
        public static readonly FilterName FEATURE = new FilterName("FEATURE");
        /// <summary>
        /// Constant SEVERITY for FilterName
        /// </summary>
        public static readonly FilterName SEVERITY = new FilterName("SEVERITY");
        /// <summary>
        /// Constant TYPE for FilterName
        /// </summary>
        public static readonly FilterName TYPE = new FilterName("TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterName FindValue(string value)
        {
            return FindValue<FilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterName(string value)
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
        /// Constant EQUALS for MatchOption
        /// </summary>
        public static readonly MatchOption EQUALS = new MatchOption("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for MatchOption
        /// </summary>
        public static readonly MatchOption NOT_EQUALS = new MatchOption("NOT_EQUALS");

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
    /// Constants used for properties of type Severity.
    /// </summary>
    public class Severity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for Severity
        /// </summary>
        public static readonly Severity CRITICAL = new Severity("CRITICAL");
        /// <summary>
        /// Constant INFO for Severity
        /// </summary>
        public static readonly Severity INFO = new Severity("INFO");
        /// <summary>
        /// Constant WARNING for Severity
        /// </summary>
        public static readonly Severity WARNING = new Severity("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Severity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Severity FindValue(string value)
        {
            return FindValue<Severity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Severity(string value)
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