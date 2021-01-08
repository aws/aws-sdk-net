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
 * Do not modify this file. This file is generated from the marketplacecommerceanalytics-2015-07-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AWSMarketplaceCommerceAnalytics
{

    /// <summary>
    /// Constants used for properties of type DataSetType.
    /// </summary>
    public class DataSetType : ConstantClass
    {

        /// <summary>
        /// Constant Customer_profile_by_geography for DataSetType
        /// </summary>
        public static readonly DataSetType Customer_profile_by_geography = new DataSetType("customer_profile_by_geography");
        /// <summary>
        /// Constant CustomerProfileByIndustry for DataSetType
        /// </summary>
        public static readonly DataSetType CustomerProfileByIndustry = new DataSetType("customer_profile_by_industry");
        /// <summary>
        /// Constant CustomerProfileByRevenue for DataSetType
        /// </summary>
        public static readonly DataSetType CustomerProfileByRevenue = new DataSetType("customer_profile_by_revenue");
        /// <summary>
        /// Constant CustomerSubscriberAnnualSubscriptions for DataSetType
        /// </summary>
        public static readonly DataSetType CustomerSubscriberAnnualSubscriptions = new DataSetType("customer_subscriber_annual_subscriptions");
        /// <summary>
        /// Constant CustomerSubscriberHourlyMonthlySubscriptions for DataSetType
        /// </summary>
        public static readonly DataSetType CustomerSubscriberHourlyMonthlySubscriptions = new DataSetType("customer_subscriber_hourly_monthly_subscriptions");
        /// <summary>
        /// Constant DailyBusinessCanceledProductSubscribers for DataSetType
        /// </summary>
        public static readonly DataSetType DailyBusinessCanceledProductSubscribers = new DataSetType("daily_business_canceled_product_subscribers");
        /// <summary>
        /// Constant DailyBusinessFees for DataSetType
        /// </summary>
        public static readonly DataSetType DailyBusinessFees = new DataSetType("daily_business_fees");
        /// <summary>
        /// Constant DailyBusinessFreeTrialConversions for DataSetType
        /// </summary>
        public static readonly DataSetType DailyBusinessFreeTrialConversions = new DataSetType("daily_business_free_trial_conversions");
        /// <summary>
        /// Constant DailyBusinessNewInstances for DataSetType
        /// </summary>
        public static readonly DataSetType DailyBusinessNewInstances = new DataSetType("daily_business_new_instances");
        /// <summary>
        /// Constant DailyBusinessNewProductSubscribers for DataSetType
        /// </summary>
        public static readonly DataSetType DailyBusinessNewProductSubscribers = new DataSetType("daily_business_new_product_subscribers");
        /// <summary>
        /// Constant DailyBusinessUsageByInstanceType for DataSetType
        /// </summary>
        public static readonly DataSetType DailyBusinessUsageByInstanceType = new DataSetType("daily_business_usage_by_instance_type");
        /// <summary>
        /// Constant Disbursed_amount_by_age_of_past_due_funds for DataSetType
        /// </summary>
        public static readonly DataSetType Disbursed_amount_by_age_of_past_due_funds = new DataSetType("disbursed_amount_by_age_of_past_due_funds");
        /// <summary>
        /// Constant Disbursed_amount_by_instance_hours for DataSetType
        /// </summary>
        public static readonly DataSetType Disbursed_amount_by_instance_hours = new DataSetType("disbursed_amount_by_instance_hours");
        /// <summary>
        /// Constant Disbursed_amount_by_product_with_uncollected_funds for DataSetType
        /// </summary>
        public static readonly DataSetType Disbursed_amount_by_product_with_uncollected_funds = new DataSetType("disbursed_amount_by_product_with_uncollected_funds");
        /// <summary>
        /// Constant Disbursed_amount_by_uncollected_funds_breakdown for DataSetType
        /// </summary>
        public static readonly DataSetType Disbursed_amount_by_uncollected_funds_breakdown = new DataSetType("disbursed_amount_by_uncollected_funds_breakdown");
        /// <summary>
        /// Constant DisbursedAmountByAgeOfDisbursedFunds for DataSetType
        /// </summary>
        public static readonly DataSetType DisbursedAmountByAgeOfDisbursedFunds = new DataSetType("disbursed_amount_by_age_of_disbursed_funds");
        /// <summary>
        /// Constant DisbursedAmountByAgeOfUncollectedFunds for DataSetType
        /// </summary>
        public static readonly DataSetType DisbursedAmountByAgeOfUncollectedFunds = new DataSetType("disbursed_amount_by_age_of_uncollected_funds");
        /// <summary>
        /// Constant DisbursedAmountByCustomerGeo for DataSetType
        /// </summary>
        public static readonly DataSetType DisbursedAmountByCustomerGeo = new DataSetType("disbursed_amount_by_customer_geo");
        /// <summary>
        /// Constant DisbursedAmountByProduct for DataSetType
        /// </summary>
        public static readonly DataSetType DisbursedAmountByProduct = new DataSetType("disbursed_amount_by_product");
        /// <summary>
        /// Constant Monthly_revenue_field_demonstration_usage for DataSetType
        /// </summary>
        public static readonly DataSetType Monthly_revenue_field_demonstration_usage = new DataSetType("monthly_revenue_field_demonstration_usage");
        /// <summary>
        /// Constant Monthly_revenue_flexible_payment_schedule for DataSetType
        /// </summary>
        public static readonly DataSetType Monthly_revenue_flexible_payment_schedule = new DataSetType("monthly_revenue_flexible_payment_schedule");
        /// <summary>
        /// Constant MonthlyRevenueAnnualSubscriptions for DataSetType
        /// </summary>
        public static readonly DataSetType MonthlyRevenueAnnualSubscriptions = new DataSetType("monthly_revenue_annual_subscriptions");
        /// <summary>
        /// Constant MonthlyRevenueBillingAndRevenueData for DataSetType
        /// </summary>
        public static readonly DataSetType MonthlyRevenueBillingAndRevenueData = new DataSetType("monthly_revenue_billing_and_revenue_data");
        /// <summary>
        /// Constant Sales_compensation_billed_revenue for DataSetType
        /// </summary>
        public static readonly DataSetType Sales_compensation_billed_revenue = new DataSetType("sales_compensation_billed_revenue");
        /// <summary>
        /// Constant Us_sales_and_use_tax_records for DataSetType
        /// </summary>
        public static readonly DataSetType Us_sales_and_use_tax_records = new DataSetType("us_sales_and_use_tax_records");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSetType FindValue(string value)
        {
            return FindValue<DataSetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupportDataSetType.
    /// </summary>
    public class SupportDataSetType : ConstantClass
    {

        /// <summary>
        /// Constant Customer_support_contacts_data for SupportDataSetType
        /// </summary>
        public static readonly SupportDataSetType Customer_support_contacts_data = new SupportDataSetType("customer_support_contacts_data");
        /// <summary>
        /// Constant Test_customer_support_contacts_data for SupportDataSetType
        /// </summary>
        public static readonly SupportDataSetType Test_customer_support_contacts_data = new SupportDataSetType("test_customer_support_contacts_data");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupportDataSetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupportDataSetType FindValue(string value)
        {
            return FindValue<SupportDataSetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupportDataSetType(string value)
        {
            return FindValue(value);
        }
    }

}