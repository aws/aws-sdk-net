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
    /// This is the response object from the GetEnterpriseSupportContractDetails operation.
    /// </summary>
    public partial class GetEnterpriseSupportContractDetailsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalSupportCharge. 
        /// <para>
        /// Any Additional support charges applied to the contract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<AdditionalCharge> AdditionalSupportCharge { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalCharge>() : null;

        /// <summary>
        /// Checks to see if the AdditionalSupportCharge property is set.
        /// </summary>
        internal bool IsSetAdditionalSupportCharge() => this.AdditionalSupportCharge != null && (this.AdditionalSupportCharge.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalSupportEligibleUsageSpend. 
        /// <para>
        /// Any Additional support-eligible usage spend charges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<AdditionalCharge> AdditionalSupportEligibleUsageSpend { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalCharge>() : null;

        /// <summary>
        /// Checks to see if the AdditionalSupportEligibleUsageSpend property is set.
        /// </summary>
        internal bool IsSetAdditionalSupportEligibleUsageSpend() => this.AdditionalSupportEligibleUsageSpend != null && (this.AdditionalSupportEligibleUsageSpend.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChargedPayerAccountIds. 
        /// <para>
        /// The list of payer accounts and their charge allocation percentages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public List<ChargeAccount> ChargedPayerAccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<ChargeAccount>() : null;

        /// <summary>
        /// Checks to see if the ChargedPayerAccountIds property is set.
        /// </summary>
        internal bool IsSetChargedPayerAccountIds() => this.ChargedPayerAccountIds != null && (this.ChargedPayerAccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContractPayerAccountIds. 
        /// <para>
        /// The list of accounts covered by the Enterprise Support contract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 2000)]
        public List<ContractAccount> ContractPayerAccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<ContractAccount>() : null;

        /// <summary>
        /// Checks to see if the ContractPayerAccountIds property is set.
        /// </summary>
        internal bool IsSetContractPayerAccountIds() => this.ContractPayerAccountIds != null && (this.ContractPayerAccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsContractActive. 
        /// <para>
        /// When true, the Enterprise Support contract is active. When false, the Enterprise Support
        /// Contract is inactive.
        /// </para>
        /// </summary>
        public bool? IsContractActive { get; set; }

        /// <summary>
        /// Checks to see if the IsContractActive property is set.
        /// </summary>
        internal bool IsSetIsContractActive() => this.IsContractActive.HasValue;

        /// <summary>
        /// Gets and sets the property PricingPlans. 
        /// <para>
        /// The pricing plans associated with this Enterprise Support contract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public List<PricingPlan> PricingPlans { get; set; } = AWSConfigs.InitializeCollections ? new List<PricingPlan>() : null;

        /// <summary>
        /// Checks to see if the PricingPlans property is set.
        /// </summary>
        internal bool IsSetPricingPlans() => this.PricingPlans != null && (this.PricingPlans.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportAllocationMethod. 
        /// <para>
        /// The method used to distribute the total Support charge amount across each account
        /// in the Support profile. Valid values: Proportional, Fixed_Percentage. Proportional
        /// means support charges are distributed to each account in proportion to its eligible
        /// Spend. Fixed_Percentage means support charges are distributed across accounts according
        /// to pre-configured percentages from the contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SupportAllocationMethod { get; set; }

        /// <summary>
        /// Checks to see if the SupportAllocationMethod property is set.
        /// </summary>
        internal bool IsSetSupportAllocationMethod() => this.SupportAllocationMethod != null;

        /// <summary>
        /// Gets and sets the property SupportProrateStartDate. 
        /// <para>
        /// The start date for accounts subscribed or unsubscribed to Support billing during the
        /// billing month.
        /// </para>
        /// </summary>
        public DateTime? SupportProrateStartDate { get; set; }

        /// <summary>
        /// Checks to see if the SupportProrateStartDate property is set.
        /// </summary>
        internal bool IsSetSupportProrateStartDate() => this.SupportProrateStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property SupportReservedInstanceAmortizationStartDate. 
        /// <para>
        /// When supportReservedInstanceTreatmentMethod = AmortizedCustom, only amortized fees
        /// for Reserved Instances purchased on or after this date are included in the calculation.
        /// This field is Null for all other treatment methods.
        /// </para>
        /// </summary>
        public DateTime? SupportReservedInstanceAmortizationStartDate { get; set; }

        /// <summary>
        /// Checks to see if the SupportReservedInstanceAmortizationStartDate property is set.
        /// </summary>
        internal bool IsSetSupportReservedInstanceAmortizationStartDate() => this.SupportReservedInstanceAmortizationStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property SupportReservedInstanceTreatmentMethod. 
        /// <para>
        /// The method used to include Reserved Instance (RI) fees in the Enterprise Support charge
        /// calculation. Valid values: None (RI fees excluded from Support-eligible spend), Upfront
        /// (full upfront RI fees included in month of purchase), Amortized (RI fees spread over
        /// commitment term for RIs purchased on or after Support subscription start date), AmortizedCustom
        /// (same as Amortized but only for RIs purchased on or after a specified custom start
        /// date), AmortizedAll (RI fees amortized for all active RIs including those purchased
        /// before Support subscription started).
        /// </para>
        /// </summary>
        public string SupportReservedInstanceTreatmentMethod { get; set; }

        /// <summary>
        /// Checks to see if the SupportReservedInstanceTreatmentMethod property is set.
        /// </summary>
        internal bool IsSetSupportReservedInstanceTreatmentMethod() => this.SupportReservedInstanceTreatmentMethod != null;

        /// <summary>
        /// Gets and sets the property SupportSavingsPlansAmortizationStartDate. 
        /// <para>
        /// This is applicable when supportSavingsPlansTreatmentMethod = Amortized and is Null
        /// for all other methods. It shows the start date from which Savings Plan fees are included
        /// in Support Eligible Spend.
        /// </para>
        /// </summary>
        public DateTime? SupportSavingsPlansAmortizationStartDate { get; set; }

        /// <summary>
        /// Checks to see if the SupportSavingsPlansAmortizationStartDate property is set.
        /// </summary>
        internal bool IsSetSupportSavingsPlansAmortizationStartDate() => this.SupportSavingsPlansAmortizationStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property SupportSavingsPlansTreatmentMethod. 
        /// <para>
        /// The method used to include Savings Plans fees in Enterprise Support charge calculations.
        /// Valid values: None (Savings Plan fees excluded from Support-eligible spend), Upfront
        /// (full upfront Savings Plan fees included in month of purchase), Amortized (Savings
        /// Plan fees spread over commitment term for Savings Plans purchased on or after Support
        /// subscription start date), AmortizedCustom (same as Amortized but only for Savings
        /// Plans purchased on or after a specified custom start date), AmortizedAll (Savings
        /// Plan fees amortized for all active Savings Plans including those purchased before
        /// Support subscription started).
        /// </para>
        /// </summary>
        public string SupportSavingsPlansTreatmentMethod { get; set; }

        /// <summary>
        /// Checks to see if the SupportSavingsPlansTreatmentMethod property is set.
        /// </summary>
        internal bool IsSetSupportSavingsPlansTreatmentMethod() => this.SupportSavingsPlansTreatmentMethod != null;
    }
}
