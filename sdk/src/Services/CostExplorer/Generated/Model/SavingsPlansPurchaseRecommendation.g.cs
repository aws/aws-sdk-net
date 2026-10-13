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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Contains your request parameters, Savings Plan Recommendations Summary, and Details.
    /// </summary>
    public partial class SavingsPlansPurchaseRecommendation
    {
        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your recommendations for. Amazon Web Services calculates
        /// recommendations that include the management account and member accounts if the value
        /// is set to <c>PAYER</c>. If the value is <c>LINKED</c>, recommendations are calculated
        /// for individual member accounts only.
        /// </para>
        /// </summary>
        public AccountScope AccountScope { get; set; }

        /// <summary>
        /// Checks to see if the AccountScope property is set.
        /// </summary>
        internal bool IsSetAccountScope() => this.AccountScope != null;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The lookback period in days that's used to generate the recommendation.
        /// </para>
        /// </summary>
        public LookbackPeriodInDays LookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInDays() => this.LookbackPeriodInDays != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option that's used to generate the recommendation.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansPurchaseRecommendationDetails. 
        /// <para>
        /// Details for the Savings Plans that we recommend that you purchase to cover existing
        /// Savings Plans eligible workloads.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SavingsPlansPurchaseRecommendationDetail> SavingsPlansPurchaseRecommendationDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<SavingsPlansPurchaseRecommendationDetail>() : null;

        /// <summary>
        /// Checks to see if the SavingsPlansPurchaseRecommendationDetails property is set.
        /// </summary>
        internal bool IsSetSavingsPlansPurchaseRecommendationDetails() => this.SavingsPlansPurchaseRecommendationDetails != null && (this.SavingsPlansPurchaseRecommendationDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SavingsPlansPurchaseRecommendationSummary. 
        /// <para>
        /// Summary metrics for your Savings Plans Recommendations. 
        /// </para>
        /// </summary>
        public SavingsPlansPurchaseRecommendationSummary SavingsPlansPurchaseRecommendationSummary { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansPurchaseRecommendationSummary property is set.
        /// </summary>
        internal bool IsSetSavingsPlansPurchaseRecommendationSummary() => this.SavingsPlansPurchaseRecommendationSummary != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansType. 
        /// <para>
        /// The requested Savings Plans recommendation type.
        /// </para>
        /// </summary>
        public SupportedSavingsPlansType SavingsPlansType { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansType property is set.
        /// </summary>
        internal bool IsSetSavingsPlansType() => this.SavingsPlansType != null;

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The Savings Plans recommendation term in years. It's used to generate the recommendation.
        /// </para>
        /// </summary>
        public TermInYears TermInYears { get; set; }

        /// <summary>
        /// Checks to see if the TermInYears property is set.
        /// </summary>
        internal bool IsSetTermInYears() => this.TermInYears != null;
    }
}
