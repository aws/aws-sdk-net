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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
    /// The response structure for GetEnterpriseSupportChargeSummary.
    /// </summary>
    public partial class GetEnterpriseSupportChargeSummaryResponse : AmazonWebServiceResponse
    {
        private DateTime? _billDate;
        private string _billingMonth;
        private DateTime? _billingPeriodEndDate;
        private DateTime? _billingPeriodStartDate;
        private bool? _isEstimated;
        private string _payerAccountId;
        private string _supportCharge;
        private string _supportChargePercentage;
        private string _supportDiscount;
        private PricingPlan _supportEffectivePricingPlan;
        private string _totalSupportCharge;
        private string _totalSupportEligibleReservedInstanceSpend;
        private string _totalSupportEligibleSavingsPlanSpend;
        private string _totalSupportEligibleSpend;
        private string _totalSupportEligibleUsageSpend;

        /// <summary>
        /// Gets and sets the property BillDate. 
        /// <para>
        /// The date the bill was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? BillDate
        {
            get { return this._billDate; }
            set { this._billDate = value; }
        }

        // Check to see if BillDate property is set
        internal bool IsSetBillDate()
        {
            return this._billDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BillingMonth. 
        /// <para>
        /// The billing month in YYYY-MM format. This must be a month in the past.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BillingMonth
        {
            get { return this._billingMonth; }
            set { this._billingMonth = value; }
        }

        // Check to see if BillingMonth property is set
        internal bool IsSetBillingMonth()
        {
            return this._billingMonth != null;
        }

        /// <summary>
        /// Gets and sets the property BillingPeriodEndDate. 
        /// <para>
        /// The end date of the billing period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? BillingPeriodEndDate
        {
            get { return this._billingPeriodEndDate; }
            set { this._billingPeriodEndDate = value; }
        }

        // Check to see if BillingPeriodEndDate property is set
        internal bool IsSetBillingPeriodEndDate()
        {
            return this._billingPeriodEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BillingPeriodStartDate. 
        /// <para>
        /// The start date of the billing period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? BillingPeriodStartDate
        {
            get { return this._billingPeriodStartDate; }
            set { this._billingPeriodStartDate = value; }
        }

        // Check to see if BillingPeriodStartDate property is set
        internal bool IsSetBillingPeriodStartDate()
        {
            return this._billingPeriodStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsEstimated. 
        /// <para>
        /// When true, the Support charge amount is estimated. When false, the Support charge
        /// amount is finalized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsEstimated
        {
            get { return this._isEstimated; }
            set { this._isEstimated = value; }
        }

        // Check to see if IsEstimated property is set
        internal bool IsSetIsEstimated()
        {
            return this._isEstimated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PayerAccountId. 
        /// <para>
        /// The payer account ID that is authorized to view Enterprise Support data for all accounts
        /// in its Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PayerAccountId
        {
            get { return this._payerAccountId; }
            set { this._payerAccountId = value; }
        }

        // Check to see if PayerAccountId property is set
        internal bool IsSetPayerAccountId()
        {
            return this._payerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCharge. 
        /// <para>
        /// The Support charge amount for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SupportCharge
        {
            get { return this._supportCharge; }
            set { this._supportCharge = value; }
        }

        // Check to see if SupportCharge property is set
        internal bool IsSetSupportCharge()
        {
            return this._supportCharge != null;
        }

        /// <summary>
        /// Gets and sets the property SupportChargePercentage. 
        /// <para>
        /// The percentage applied to the total Support-eligible spend to calculate the total
        /// Support charge across all accounts in the Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SupportChargePercentage
        {
            get { return this._supportChargePercentage; }
            set { this._supportChargePercentage = value; }
        }

        // Check to see if SupportChargePercentage property is set
        internal bool IsSetSupportChargePercentage()
        {
            return this._supportChargePercentage != null;
        }

        /// <summary>
        /// Gets and sets the property SupportDiscount. 
        /// <para>
        /// The support discount amount.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SupportDiscount
        {
            get { return this._supportDiscount; }
            set { this._supportDiscount = value; }
        }

        // Check to see if SupportDiscount property is set
        internal bool IsSetSupportDiscount()
        {
            return this._supportDiscount != null;
        }

        /// <summary>
        /// Gets and sets the property SupportEffectivePricingPlan. 
        /// <para>
        /// The effective pricing plan used for the support charge calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingPlan SupportEffectivePricingPlan
        {
            get { return this._supportEffectivePricingPlan; }
            set { this._supportEffectivePricingPlan = value; }
        }

        // Check to see if SupportEffectivePricingPlan property is set
        internal bool IsSetSupportEffectivePricingPlan()
        {
            return this._supportEffectivePricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportCharge. 
        /// <para>
        /// The total Support charge amount for all accounts in the Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSupportCharge
        {
            get { return this._totalSupportCharge; }
            set { this._totalSupportCharge = value; }
        }

        // Check to see if TotalSupportCharge property is set
        internal bool IsSetTotalSupportCharge()
        {
            return this._totalSupportCharge != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleReservedInstanceSpend. 
        /// <para>
        /// The total Support-eligible Reserved Instance spend from all accounts in the Support
        /// profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSupportEligibleReservedInstanceSpend
        {
            get { return this._totalSupportEligibleReservedInstanceSpend; }
            set { this._totalSupportEligibleReservedInstanceSpend = value; }
        }

        // Check to see if TotalSupportEligibleReservedInstanceSpend property is set
        internal bool IsSetTotalSupportEligibleReservedInstanceSpend()
        {
            return this._totalSupportEligibleReservedInstanceSpend != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSavingsPlanSpend. 
        /// <para>
        /// The total Support-eligible Savings Plan spend from all accounts in the Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSupportEligibleSavingsPlanSpend
        {
            get { return this._totalSupportEligibleSavingsPlanSpend; }
            set { this._totalSupportEligibleSavingsPlanSpend = value; }
        }

        // Check to see if TotalSupportEligibleSavingsPlanSpend property is set
        internal bool IsSetTotalSupportEligibleSavingsPlanSpend()
        {
            return this._totalSupportEligibleSavingsPlanSpend != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSpend. 
        /// <para>
        /// The total Support-eligible Spend from all accounts in the Support profile. This includes
        /// eligible spend from usage of Amazon Web Services, Reserved Instances, and Savings
        /// Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSupportEligibleSpend
        {
            get { return this._totalSupportEligibleSpend; }
            set { this._totalSupportEligibleSpend = value; }
        }

        // Check to see if TotalSupportEligibleSpend property is set
        internal bool IsSetTotalSupportEligibleSpend()
        {
            return this._totalSupportEligibleSpend != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleUsageSpend. 
        /// <para>
        /// The total Support-eligible spend from usage of Amazon Web Services from all accounts
        /// in the Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSupportEligibleUsageSpend
        {
            get { return this._totalSupportEligibleUsageSpend; }
            set { this._totalSupportEligibleUsageSpend = value; }
        }

        // Check to see if TotalSupportEligibleUsageSpend property is set
        internal bool IsSetTotalSupportEligibleUsageSpend()
        {
            return this._totalSupportEligibleUsageSpend != null;
        }

    }
}