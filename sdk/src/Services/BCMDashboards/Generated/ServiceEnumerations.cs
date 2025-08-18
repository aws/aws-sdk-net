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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BCMDashboards
{

    /// <summary>
    /// Constants used for properties of type DashboardType.
    /// </summary>
    public class DashboardType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for DashboardType
        /// </summary>
        public static readonly DashboardType CUSTOM = new DashboardType("CUSTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardType FindValue(string value)
        {
            return FindValue<DashboardType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DateTimeType.
    /// </summary>
    public class DateTimeType : ConstantClass
    {

        /// <summary>
        /// Constant ABSOLUTE for DateTimeType
        /// </summary>
        public static readonly DateTimeType ABSOLUTE = new DateTimeType("ABSOLUTE");
        /// <summary>
        /// Constant RELATIVE for DateTimeType
        /// </summary>
        public static readonly DateTimeType RELATIVE = new DateTimeType("RELATIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DateTimeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DateTimeType FindValue(string value)
        {
            return FindValue<DateTimeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DateTimeType(string value)
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
        /// Constant COST_CATEGORY_NAME for Dimension
        /// </summary>
        public static readonly Dimension COST_CATEGORY_NAME = new Dimension("COST_CATEGORY_NAME");
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
        /// Constant LEGAL_ENTITY_NAME for Dimension
        /// </summary>
        public static readonly Dimension LEGAL_ENTITY_NAME = new Dimension("LEGAL_ENTITY_NAME");
        /// <summary>
        /// Constant LINKED_ACCOUNT for Dimension
        /// </summary>
        public static readonly Dimension LINKED_ACCOUNT = new Dimension("LINKED_ACCOUNT");
        /// <summary>
        /// Constant OPERATING_SYSTEM for Dimension
        /// </summary>
        public static readonly Dimension OPERATING_SYSTEM = new Dimension("OPERATING_SYSTEM");
        /// <summary>
        /// Constant OPERATION for Dimension
        /// </summary>
        public static readonly Dimension OPERATION = new Dimension("OPERATION");
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
        /// Constant SUBSCRIPTION_ID for Dimension
        /// </summary>
        public static readonly Dimension SUBSCRIPTION_ID = new Dimension("SUBSCRIPTION_ID");
        /// <summary>
        /// Constant TAG_KEY for Dimension
        /// </summary>
        public static readonly Dimension TAG_KEY = new Dimension("TAG_KEY");
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
    /// Constants used for properties of type MetricName.
    /// </summary>
    public class MetricName : ConstantClass
    {

        /// <summary>
        /// Constant AmortizedCost for MetricName
        /// </summary>
        public static readonly MetricName AmortizedCost = new MetricName("AmortizedCost");
        /// <summary>
        /// Constant BlendedCost for MetricName
        /// </summary>
        public static readonly MetricName BlendedCost = new MetricName("BlendedCost");
        /// <summary>
        /// Constant Cost for MetricName
        /// </summary>
        public static readonly MetricName Cost = new MetricName("Cost");
        /// <summary>
        /// Constant Hour for MetricName
        /// </summary>
        public static readonly MetricName Hour = new MetricName("Hour");
        /// <summary>
        /// Constant NetAmortizedCost for MetricName
        /// </summary>
        public static readonly MetricName NetAmortizedCost = new MetricName("NetAmortizedCost");
        /// <summary>
        /// Constant NetUnblendedCost for MetricName
        /// </summary>
        public static readonly MetricName NetUnblendedCost = new MetricName("NetUnblendedCost");
        /// <summary>
        /// Constant NormalizedUsageAmount for MetricName
        /// </summary>
        public static readonly MetricName NormalizedUsageAmount = new MetricName("NormalizedUsageAmount");
        /// <summary>
        /// Constant SpendCoveredBySavingsPlans for MetricName
        /// </summary>
        public static readonly MetricName SpendCoveredBySavingsPlans = new MetricName("SpendCoveredBySavingsPlans");
        /// <summary>
        /// Constant UnblendedCost for MetricName
        /// </summary>
        public static readonly MetricName UnblendedCost = new MetricName("UnblendedCost");
        /// <summary>
        /// Constant Unit for MetricName
        /// </summary>
        public static readonly MetricName Unit = new MetricName("Unit");
        /// <summary>
        /// Constant UsageQuantity for MetricName
        /// </summary>
        public static readonly MetricName UsageQuantity = new MetricName("UsageQuantity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricName FindValue(string value)
        {
            return FindValue<MetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VisualType.
    /// </summary>
    public class VisualType : ConstantClass
    {

        /// <summary>
        /// Constant BAR for VisualType
        /// </summary>
        public static readonly VisualType BAR = new VisualType("BAR");
        /// <summary>
        /// Constant LINE for VisualType
        /// </summary>
        public static readonly VisualType LINE = new VisualType("LINE");
        /// <summary>
        /// Constant STACK for VisualType
        /// </summary>
        public static readonly VisualType STACK = new VisualType("STACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VisualType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VisualType FindValue(string value)
        {
            return FindValue<VisualType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VisualType(string value)
        {
            return FindValue(value);
        }
    }

}