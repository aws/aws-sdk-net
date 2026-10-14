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
    /// A summary about this recommendation, such as the currency code, the amount that Amazon
    /// Web Services estimates that you could save, and the total amount of reservation to
    /// purchase.
    /// </summary>
    public partial class ReservationPurchaseRecommendationSummary
    {
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code used for this recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property TotalEstimatedMonthlySavingsAmount. 
        /// <para>
        /// The total amount that Amazon Web Services estimates that this recommendation could
        /// save you in a month.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalEstimatedMonthlySavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the TotalEstimatedMonthlySavingsAmount property is set.
        /// </summary>
        internal bool IsSetTotalEstimatedMonthlySavingsAmount() => this.TotalEstimatedMonthlySavingsAmount != null;

        /// <summary>
        /// Gets and sets the property TotalEstimatedMonthlySavingsPercentage. 
        /// <para>
        /// The total amount that Amazon Web Services estimates that this recommendation could
        /// save you in a month, as a percentage of your costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalEstimatedMonthlySavingsPercentage { get; set; }

        /// <summary>
        /// Checks to see if the TotalEstimatedMonthlySavingsPercentage property is set.
        /// </summary>
        internal bool IsSetTotalEstimatedMonthlySavingsPercentage() => this.TotalEstimatedMonthlySavingsPercentage != null;
    }
}
