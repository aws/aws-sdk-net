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
    /// The response structure for GetEnterpriseSupportContractDetails.
    /// </summary>
    public partial class GetEnterpriseSupportContractDetailsResponse : AmazonWebServiceResponse
    {
        private List<AdditionalCharge> _additionalSupportCharge = AWSConfigs.InitializeCollections ? new List<AdditionalCharge>() : null;
        private List<AdditionalCharge> _additionalSupportEligibleUsageSpend = AWSConfigs.InitializeCollections ? new List<AdditionalCharge>() : null;
        private List<ChargeAccount> _chargedPayerAccountIds = AWSConfigs.InitializeCollections ? new List<ChargeAccount>() : null;
        private List<ContractAccount> _contractPayerAccountIds = AWSConfigs.InitializeCollections ? new List<ContractAccount>() : null;
        private bool? _isContractActive;
        private List<PricingPlan> _pricingPlans = AWSConfigs.InitializeCollections ? new List<PricingPlan>() : null;
        private string _supportAllocationMethod;
        private DateTime? _supportProrateStartDate;
        private DateTime? _supportReservedInstanceAmortizationStartDate;
        private string _supportReservedInstanceTreatmentMethod;
        private DateTime? _supportSavingsPlansAmortizationStartDate;
        private string _supportSavingsPlansTreatmentMethod;

        /// <summary>
        /// Gets and sets the property AdditionalSupportCharge. 
        /// <para>
        /// Any Additional support charges applied to the contract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<AdditionalCharge> AdditionalSupportCharge
        {
            get { return this._additionalSupportCharge; }
            set { this._additionalSupportCharge = value; }
        }

        // Check to see if AdditionalSupportCharge property is set
        internal bool IsSetAdditionalSupportCharge()
        {
            return this._additionalSupportCharge != null && (this._additionalSupportCharge.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdditionalSupportEligibleUsageSpend. 
        /// <para>
        /// Any Additional support-eligible usage spend charges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<AdditionalCharge> AdditionalSupportEligibleUsageSpend
        {
            get { return this._additionalSupportEligibleUsageSpend; }
            set { this._additionalSupportEligibleUsageSpend = value; }
        }

        // Check to see if AdditionalSupportEligibleUsageSpend property is set
        internal bool IsSetAdditionalSupportEligibleUsageSpend()
        {
            return this._additionalSupportEligibleUsageSpend != null && (this._additionalSupportEligibleUsageSpend.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChargedPayerAccountIds. 
        /// <para>
        /// The list of payer accounts and their charge allocation percentages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<ChargeAccount> ChargedPayerAccountIds
        {
            get { return this._chargedPayerAccountIds; }
            set { this._chargedPayerAccountIds = value; }
        }

        // Check to see if ChargedPayerAccountIds property is set
        internal bool IsSetChargedPayerAccountIds()
        {
            return this._chargedPayerAccountIds != null && (this._chargedPayerAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContractPayerAccountIds. 
        /// <para>
        /// The list of accounts covered by the Enterprise Support contract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2000)]
        public List<ContractAccount> ContractPayerAccountIds
        {
            get { return this._contractPayerAccountIds; }
            set { this._contractPayerAccountIds = value; }
        }

        // Check to see if ContractPayerAccountIds property is set
        internal bool IsSetContractPayerAccountIds()
        {
            return this._contractPayerAccountIds != null && (this._contractPayerAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsContractActive. 
        /// <para>
        /// When true, the Enterprise Support contract is active. When false, the Enterprise Support
        /// Contract is inactive.
        /// </para>
        /// </summary>
        public bool? IsContractActive
        {
            get { return this._isContractActive; }
            set { this._isContractActive = value; }
        }

        // Check to see if IsContractActive property is set
        internal bool IsSetIsContractActive()
        {
            return this._isContractActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PricingPlans. 
        /// <para>
        /// The pricing plans associated with this Enterprise Support contract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<PricingPlan> PricingPlans
        {
            get { return this._pricingPlans; }
            set { this._pricingPlans = value; }
        }

        // Check to see if PricingPlans property is set
        internal bool IsSetPricingPlans()
        {
            return this._pricingPlans != null && (this._pricingPlans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true)]
        public string SupportAllocationMethod
        {
            get { return this._supportAllocationMethod; }
            set { this._supportAllocationMethod = value; }
        }

        // Check to see if SupportAllocationMethod property is set
        internal bool IsSetSupportAllocationMethod()
        {
            return this._supportAllocationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property SupportProrateStartDate. 
        /// <para>
        /// The start date for accounts subscribed or unsubscribed to Support billing during the
        /// billing month.
        /// </para>
        /// </summary>
        public DateTime? SupportProrateStartDate
        {
            get { return this._supportProrateStartDate; }
            set { this._supportProrateStartDate = value; }
        }

        // Check to see if SupportProrateStartDate property is set
        internal bool IsSetSupportProrateStartDate()
        {
            return this._supportProrateStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportReservedInstanceAmortizationStartDate. 
        /// <para>
        /// When supportReservedInstanceTreatmentMethod = AmortizedCustom, only amortized fees
        /// for Reserved Instances purchased on or after this date are included in the calculation.
        /// This field is Null for all other treatment methods.
        /// </para>
        /// </summary>
        public DateTime? SupportReservedInstanceAmortizationStartDate
        {
            get { return this._supportReservedInstanceAmortizationStartDate; }
            set { this._supportReservedInstanceAmortizationStartDate = value; }
        }

        // Check to see if SupportReservedInstanceAmortizationStartDate property is set
        internal bool IsSetSupportReservedInstanceAmortizationStartDate()
        {
            return this._supportReservedInstanceAmortizationStartDate.HasValue; 
        }

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
        public string SupportReservedInstanceTreatmentMethod
        {
            get { return this._supportReservedInstanceTreatmentMethod; }
            set { this._supportReservedInstanceTreatmentMethod = value; }
        }

        // Check to see if SupportReservedInstanceTreatmentMethod property is set
        internal bool IsSetSupportReservedInstanceTreatmentMethod()
        {
            return this._supportReservedInstanceTreatmentMethod != null;
        }

        /// <summary>
        /// Gets and sets the property SupportSavingsPlansAmortizationStartDate. 
        /// <para>
        /// This is applicable when supportSavingsPlansTreatmentMethod = Amortized and is Null
        /// for all other methods. It shows the start date from which Savings Plan fees are included
        /// in Support Eligible Spend.
        /// </para>
        /// </summary>
        public DateTime? SupportSavingsPlansAmortizationStartDate
        {
            get { return this._supportSavingsPlansAmortizationStartDate; }
            set { this._supportSavingsPlansAmortizationStartDate = value; }
        }

        // Check to see if SupportSavingsPlansAmortizationStartDate property is set
        internal bool IsSetSupportSavingsPlansAmortizationStartDate()
        {
            return this._supportSavingsPlansAmortizationStartDate.HasValue; 
        }

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
        public string SupportSavingsPlansTreatmentMethod
        {
            get { return this._supportSavingsPlansTreatmentMethod; }
            set { this._supportSavingsPlansTreatmentMethod = value; }
        }

        // Check to see if SupportSavingsPlansTreatmentMethod property is set
        internal bool IsSetSupportSavingsPlansTreatmentMethod()
        {
            return this._supportSavingsPlansTreatmentMethod != null;
        }

    }
}