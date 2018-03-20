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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// A summary about this recommendation, such as the currency code, the amount that AWS
    /// estimates you could save, and the total amount of reservation to purchase.
    /// </summary>
    public partial class ReservationPurchaseRecommendationSummary
    {
        private string _currencyCode;
        private string _totalEstimatedMonthlySavingsAmount;
        private string _totalEstimatedMonthlySavingsPercentage;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code used for this recommendation.
        /// </para>
        /// </summary>
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property TotalEstimatedMonthlySavingsAmount. 
        /// <para>
        /// The total amount that AWS estimates that this recommendation could save you in a month.
        /// </para>
        /// </summary>
        public string TotalEstimatedMonthlySavingsAmount
        {
            get { return this._totalEstimatedMonthlySavingsAmount; }
            set { this._totalEstimatedMonthlySavingsAmount = value; }
        }

        // Check to see if TotalEstimatedMonthlySavingsAmount property is set
        internal bool IsSetTotalEstimatedMonthlySavingsAmount()
        {
            return this._totalEstimatedMonthlySavingsAmount != null;
        }

        /// <summary>
        /// Gets and sets the property TotalEstimatedMonthlySavingsPercentage. 
        /// <para>
        /// The total amount that AWS estimates that this recommendation could save you in a month,
        /// as a percentage of your costs.
        /// </para>
        /// </summary>
        public string TotalEstimatedMonthlySavingsPercentage
        {
            get { return this._totalEstimatedMonthlySavingsPercentage; }
            set { this._totalEstimatedMonthlySavingsPercentage = value; }
        }

        // Check to see if TotalEstimatedMonthlySavingsPercentage property is set
        internal bool IsSetTotalEstimatedMonthlySavingsPercentage()
        {
            return this._totalEstimatedMonthlySavingsPercentage != null;
        }

    }
}