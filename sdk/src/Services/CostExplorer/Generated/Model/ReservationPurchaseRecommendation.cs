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
    /// A specific reservation that Amazon Web Services recommends for purchase.
    /// </summary>
    public partial class ReservationPurchaseRecommendation
    {
        private AccountScope _accountScope;
        private LookbackPeriodInDays _lookbackPeriodInDays;
        private PaymentOption _paymentOption;
        private List<ReservationPurchaseRecommendationDetail> _recommendationDetails = AWSConfigs.InitializeCollections ? new List<ReservationPurchaseRecommendationDetail>() : null;
        private ReservationPurchaseRecommendationSummary _recommendationSummary;
        private ServiceSpecification _serviceSpecification;
        private TermInYears _termInYears;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that Amazon Web Services recommends that you purchase this instance
        /// for. For example, you can purchase this reservation for an entire organization in
        /// Amazon Web Services Organizations.
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
        /// How many days of previous usage that Amazon Web Services considers when making this
        /// recommendation.
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
        /// The payment option for the reservation (for example, <c>AllUpfront</c> or <c>NoUpfront</c>).
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
        /// Gets and sets the property RecommendationDetails. 
        /// <para>
        /// Details about the recommended purchases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReservationPurchaseRecommendationDetail> RecommendationDetails
        {
            get { return this._recommendationDetails; }
            set { this._recommendationDetails = value; }
        }

        // Check to see if RecommendationDetails property is set
        internal bool IsSetRecommendationDetails()
        {
            return this._recommendationDetails != null && (this._recommendationDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecommendationSummary. 
        /// <para>
        /// A summary about the recommended purchase.
        /// </para>
        /// </summary>
        public ReservationPurchaseRecommendationSummary RecommendationSummary
        {
            get { return this._recommendationSummary; }
            set { this._recommendationSummary = value; }
        }

        // Check to see if RecommendationSummary property is set
        internal bool IsSetRecommendationSummary()
        {
            return this._recommendationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceSpecification. 
        /// <para>
        /// Hardware specifications for the service that you want recommendations for.
        /// </para>
        /// </summary>
        public ServiceSpecification ServiceSpecification
        {
            get { return this._serviceSpecification; }
            set { this._serviceSpecification = value; }
        }

        // Check to see if ServiceSpecification property is set
        internal bool IsSetServiceSpecification()
        {
            return this._serviceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The term of the reservation that you want recommendations for, in years.
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