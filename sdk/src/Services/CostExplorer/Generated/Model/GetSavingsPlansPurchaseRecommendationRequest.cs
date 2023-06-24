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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetSavingsPlansPurchaseRecommendation operation.
    /// Retrieves the Savings Plans recommendations for your account. First use <code>StartSavingsPlansPurchaseRecommendationGeneration</code>
    /// to generate a new set of recommendations, and then use <code>GetSavingsPlansPurchaseRecommendation</code>
    /// to retrieve them.
    /// </summary>
    public partial class GetSavingsPlansPurchaseRecommendationRequest : AmazonCostExplorerRequest
    {
        private AccountScope _accountScope;
        private Expression _filter;
        private LookbackPeriodInDays _lookbackPeriodInDays;
        private string _nextPageToken;
        private int? _pageSize;
        private PaymentOption _paymentOption;
        private SupportedSavingsPlansType _savingsPlansType;
        private TermInYears _termInYears;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your recommendations for. Amazon Web Services calculates
        /// recommendations including the management account and member accounts if the value
        /// is set to <code>PAYER</code>. If the value is <code>LINKED</code>, recommendations
        /// are calculated for individual member accounts only.
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
        /// Gets and sets the property Filter. 
        /// <para>
        /// You can filter your recommendations by Account ID with the <code>LINKED_ACCOUNT</code>
        /// dimension. To filter your recommendations by Account ID, specify <code>Key</code>
        /// as <code>LINKED_ACCOUNT</code> and <code>Value</code> as the comma-separated Acount
        /// ID(s) that you want to see Savings Plans purchase recommendations for.
        /// </para>
        ///  
        /// <para>
        /// For GetSavingsPlansPurchaseRecommendation, the <code>Filter</code> doesn't include
        /// <code>CostCategories</code> or <code>Tags</code>. It only includes <code>Dimensions</code>.
        /// With <code>Dimensions</code>, <code>Key</code> must be <code>LINKED_ACCOUNT</code>
        /// and <code>Value</code> can be a single Account ID or multiple comma-separated Account
        /// IDs that you want to see Savings Plans Purchase Recommendations for. <code>AND</code>
        /// and <code>OR</code> operators are not supported.
        /// </para>
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The lookback period that's used to generate the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of recommendations that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option that's used to generate these recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SavingsPlansType. 
        /// <para>
        /// The Savings Plans recommendation type that's requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The savings plan recommendation term that's used to generate these recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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