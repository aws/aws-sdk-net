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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Contains your request parameters, Savings Plan Recommendations Summary, and Details.
    /// </summary>
    public partial class SavingsPlansPurchaseRecommendation
    {
        private AccountScope _accountScope;
        private LookbackPeriodInDays _lookbackPeriodInDays;
        private PaymentOption _paymentOption;
        private List<SavingsPlansPurchaseRecommendationDetail> _savingsPlansPurchaseRecommendationDetails = AWSConfigs.InitializeCollections ? new List<SavingsPlansPurchaseRecommendationDetail>() : null;
        private SavingsPlansPurchaseRecommendationSummary _savingsPlansPurchaseRecommendationSummary;
        private SupportedSavingsPlansType _savingsPlansType;
        private TermInYears _termInYears;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your recommendations for. Amazon Web Services calculates
        /// recommendations that include the management account and member accounts if the value
        /// is set to <c>PAYER</c>. If the value is <c>LINKED</c>, recommendations are calculated
        /// for individual member accounts only.
        /// </para>
        /// </summary>
        public AccountScope AccountScope
        {
            get { return this._accountScope; }
            set { this._accountScope = value; }
        }

        // Check to see if AccountScope property is set
        internal bool IsSetAccountScope()
        {
            return this._accountScope != null;
        }

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The lookback period in days that's used to generate the recommendation.
        /// </para>
        /// </summary>
        public LookbackPeriodInDays LookbackPeriodInDays
        {
            get { return this._lookbackPeriodInDays; }
            set { this._lookbackPeriodInDays = value; }
        }

        // Check to see if LookbackPeriodInDays property is set
        internal bool IsSetLookbackPeriodInDays()
        {
            return this._lookbackPeriodInDays != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option that's used to generate the recommendation.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansPurchaseRecommendationDetails. 
        /// <para>
        /// Details for the Savings Plans that we recommend that you purchase to cover existing
        /// Savings Plans eligible workloads.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SavingsPlansPurchaseRecommendationDetail> SavingsPlansPurchaseRecommendationDetails
        {
            get { return this._savingsPlansPurchaseRecommendationDetails; }
            set { this._savingsPlansPurchaseRecommendationDetails = value; }
        }

        // Check to see if SavingsPlansPurchaseRecommendationDetails property is set
        internal bool IsSetSavingsPlansPurchaseRecommendationDetails()
        {
            return this._savingsPlansPurchaseRecommendationDetails != null && (this._savingsPlansPurchaseRecommendationDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansPurchaseRecommendationSummary. 
        /// <para>
        /// Summary metrics for your Savings Plans Recommendations. 
        /// </para>
        /// </summary>
        public SavingsPlansPurchaseRecommendationSummary SavingsPlansPurchaseRecommendationSummary
        {
            get { return this._savingsPlansPurchaseRecommendationSummary; }
            set { this._savingsPlansPurchaseRecommendationSummary = value; }
        }

        // Check to see if SavingsPlansPurchaseRecommendationSummary property is set
        internal bool IsSetSavingsPlansPurchaseRecommendationSummary()
        {
            return this._savingsPlansPurchaseRecommendationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansType. 
        /// <para>
        /// The requested Savings Plans recommendation type.
        /// </para>
        /// </summary>
        public SupportedSavingsPlansType SavingsPlansType
        {
            get { return this._savingsPlansType; }
            set { this._savingsPlansType = value; }
        }

        // Check to see if SavingsPlansType property is set
        internal bool IsSetSavingsPlansType()
        {
            return this._savingsPlansType != null;
        }

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The Savings Plans recommendation term in years. It's used to generate the recommendation.
        /// </para>
        /// </summary>
        public TermInYears TermInYears
        {
            get { return this._termInYears; }
            set { this._termInYears = value; }
        }

        // Check to see if TermInYears property is set
        internal bool IsSetTermInYears()
        {
            return this._termInYears != null;
        }

    }
}