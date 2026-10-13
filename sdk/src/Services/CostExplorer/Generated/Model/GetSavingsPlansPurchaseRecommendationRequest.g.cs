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
    /// Container for the parameters to the GetSavingsPlansPurchaseRecommendation operation.
    /// Retrieves the Savings Plans recommendations for your account. First use <c>StartSavingsPlansPurchaseRecommendationGeneration</c>
    /// to generate a new set of recommendations, and then use <c>GetSavingsPlansPurchaseRecommendation</c>
    /// to retrieve them.
    /// </summary>
    public partial class GetSavingsPlansPurchaseRecommendationRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your recommendations for. Amazon Web Services calculates
        /// recommendations including the management account and member accounts if the value
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
        /// Gets and sets the property Filter. 
        /// <para>
        /// You can filter your recommendations by Account ID with the <c>LINKED_ACCOUNT</c> dimension.
        /// To filter your recommendations by Account ID, specify <c>Key</c> as <c>LINKED_ACCOUNT</c>
        /// and <c>Value</c> as the comma-separated Acount ID(s) that you want to see Savings
        /// Plans purchase recommendations for.
        /// </para>
        ///  
        /// <para>
        /// For GetSavingsPlansPurchaseRecommendation, the <c>Filter</c> doesn't include <c>CostCategories</c>
        /// or <c>Tags</c>. It only includes <c>Dimensions</c>. With <c>Dimensions</c>, <c>Key</c>
        /// must be <c>LINKED_ACCOUNT</c> and <c>Value</c> can be a single Account ID or multiple
        /// comma-separated Account IDs that you want to see Savings Plans Purchase Recommendations
        /// for. <c>AND</c> and <c>OR</c> operators are not supported.
        /// </para>
        /// </summary>
        public Expression Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The lookback period that's used to generate the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LookbackPeriodInDays LookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInDays() => this.LookbackPeriodInDays != null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of recommendations that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6000)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option that's used to generate these recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansType. 
        /// <para>
        /// The Savings Plans recommendation type that's requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SupportedSavingsPlansType SavingsPlansType { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansType property is set.
        /// </summary>
        internal bool IsSetSavingsPlansType() => this.SavingsPlansType != null;

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The savings plan recommendation term that's used to generate these recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TermInYears TermInYears { get; set; }

        /// <summary>
        /// Checks to see if the TermInYears property is set.
        /// </summary>
        internal bool IsSetTermInYears() => this.TermInYears != null;
    }
}
