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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Billing.Model
{
    /// <summary>
    /// This is the response object from the GetEnterpriseSupportChargeSummary operation.
    /// </summary>
    public partial class GetEnterpriseSupportChargeSummaryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BillDate. 
        /// <para>
        /// The date the bill was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? BillDate { get; set; }

        /// <summary>
        /// Checks to see if the BillDate property is set.
        /// </summary>
        internal bool IsSetBillDate() => this.BillDate.HasValue;

        /// <summary>
        /// Gets and sets the property BillingMonth. 
        /// <para>
        /// The billing month in YYYY-MM format. This must be a month in the past.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BillingMonth { get; set; }

        /// <summary>
        /// Checks to see if the BillingMonth property is set.
        /// </summary>
        internal bool IsSetBillingMonth() => this.BillingMonth != null;

        /// <summary>
        /// Gets and sets the property BillingPeriodEndDate. 
        /// <para>
        /// The end date of the billing period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? BillingPeriodEndDate { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriodEndDate property is set.
        /// </summary>
        internal bool IsSetBillingPeriodEndDate() => this.BillingPeriodEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property BillingPeriodStartDate. 
        /// <para>
        /// The start date of the billing period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? BillingPeriodStartDate { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriodStartDate property is set.
        /// </summary>
        internal bool IsSetBillingPeriodStartDate() => this.BillingPeriodStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property IsEstimated. 
        /// <para>
        /// Specifies whether the Support charge amount is estimated. When false, the charge amount
        /// is finalized.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsEstimated { get; set; }

        /// <summary>
        /// Checks to see if the IsEstimated property is set.
        /// </summary>
        internal bool IsSetIsEstimated() => this.IsEstimated.HasValue;

        /// <summary>
        /// Gets and sets the property PayerAccountId. 
        /// <para>
        /// The payer account ID that is authorized to view Enterprise Support data for all accounts
        /// in its Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the PayerAccountId property is set.
        /// </summary>
        internal bool IsSetPayerAccountId() => this.PayerAccountId != null;

        /// <summary>
        /// Gets and sets the property SupportCharge. 
        /// <para>
        /// The Support charge amount for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SupportCharge { get; set; }

        /// <summary>
        /// Checks to see if the SupportCharge property is set.
        /// </summary>
        internal bool IsSetSupportCharge() => this.SupportCharge != null;

        /// <summary>
        /// Gets and sets the property SupportChargePercentage. 
        /// <para>
        /// The percentage applied to the total Support-eligible spend to calculate the total
        /// Support charge across all accounts in the Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SupportChargePercentage { get; set; }

        /// <summary>
        /// Checks to see if the SupportChargePercentage property is set.
        /// </summary>
        internal bool IsSetSupportChargePercentage() => this.SupportChargePercentage != null;

        /// <summary>
        /// Gets and sets the property SupportDiscount. 
        /// <para>
        /// The support discount amount.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SupportDiscount { get; set; }

        /// <summary>
        /// Checks to see if the SupportDiscount property is set.
        /// </summary>
        internal bool IsSetSupportDiscount() => this.SupportDiscount != null;

        /// <summary>
        /// Gets and sets the property SupportEffectivePricingPlan. 
        /// <para>
        /// The effective pricing plan used for the support charge calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PricingPlan SupportEffectivePricingPlan { get; set; }

        /// <summary>
        /// Checks to see if the SupportEffectivePricingPlan property is set.
        /// </summary>
        internal bool IsSetSupportEffectivePricingPlan() => this.SupportEffectivePricingPlan != null;

        /// <summary>
        /// Gets and sets the property TotalSupportCharge. 
        /// <para>
        /// The total Support charge amount for all accounts in the Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSupportCharge { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportCharge property is set.
        /// </summary>
        internal bool IsSetTotalSupportCharge() => this.TotalSupportCharge != null;

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleReservedInstanceSpend. 
        /// <para>
        /// The total Support-eligible Reserved Instance spend from all accounts in the Support
        /// profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSupportEligibleReservedInstanceSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportEligibleReservedInstanceSpend property is set.
        /// </summary>
        internal bool IsSetTotalSupportEligibleReservedInstanceSpend() => this.TotalSupportEligibleReservedInstanceSpend != null;

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSavingsPlanSpend. 
        /// <para>
        /// The total Support-eligible Savings Plan spend from all accounts in the Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSupportEligibleSavingsPlanSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportEligibleSavingsPlanSpend property is set.
        /// </summary>
        internal bool IsSetTotalSupportEligibleSavingsPlanSpend() => this.TotalSupportEligibleSavingsPlanSpend != null;

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSpend. 
        /// <para>
        /// The total Support-eligible Spend from all accounts in the Support profile. This includes
        /// eligible spend from usage of Amazon Web Services, Reserved Instances, and Savings
        /// Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSupportEligibleSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportEligibleSpend property is set.
        /// </summary>
        internal bool IsSetTotalSupportEligibleSpend() => this.TotalSupportEligibleSpend != null;

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleUsageSpend. 
        /// <para>
        /// The total Support-eligible spend from usage of Amazon Web Services from all accounts
        /// in the Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSupportEligibleUsageSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportEligibleUsageSpend property is set.
        /// </summary>
        internal bool IsSetTotalSupportEligibleUsageSpend() => this.TotalSupportEligibleUsageSpend != null;
    }
}
