/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        /// Constant MonthlyRevenueAnnualSubscriptions for DataSetType
        /// </summary>
        public static readonly DataSetType MonthlyRevenueAnnualSubscriptions = new DataSetType("monthly_revenue_annual_subscriptions");
        /// <summary>
        /// Constant MonthlyRevenueBillingAndRevenueData for DataSetType
        /// </summary>
        public static readonly DataSetType MonthlyRevenueBillingAndRevenueData = new DataSetType("monthly_revenue_billing_and_revenue_data");

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

}