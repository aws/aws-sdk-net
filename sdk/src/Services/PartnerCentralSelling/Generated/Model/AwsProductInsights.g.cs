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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Comprehensive spend analysis for a single source (AWS or Partner) including total
    /// amounts, optimization savings, program category breakdowns, and detailed product-level
    /// insights.
    /// </summary>
    public partial class AwsProductInsights
    {
        /// <summary>
        /// Gets and sets the property AwsProducts. 
        /// <para>
        /// Product-level details including costs and optimization recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public List<AwsProductDetails> AwsProducts { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsProductDetails>() : null;

        /// <summary>
        /// Checks to see if the AwsProducts property is set.
        /// </summary>
        internal bool IsSetAwsProducts() => this.AwsProducts != null && (this.AwsProducts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// ISO 4217 currency code. Supported values are <c>USD</c> and <c>EUR</c>. Returns <c>EUR</c>
        /// when the opportunity is in the <c>aws-eusc</c> (AWS European Sovereign Cloud) partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public CurrencyCode CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// Time period for spend amounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentFrequency Frequency { get; set; }

        /// <summary>
        /// Checks to see if the Frequency property is set.
        /// </summary>
        internal bool IsSetFrequency() => this.Frequency != null;

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        /// Total estimated spend for this source before optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Checks to see if the TotalAmount property is set.
        /// </summary>
        internal bool IsSetTotalAmount() => this.TotalAmount != null;

        /// <summary>
        /// Gets and sets the property TotalAmountByCategory. 
        /// <para>
        /// Spend amounts mapped to AWS programs and modernization pathways.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> TotalAmountByCategory { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TotalAmountByCategory property is set.
        /// </summary>
        internal bool IsSetTotalAmountByCategory() => this.TotalAmountByCategory != null && (this.TotalAmountByCategory.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalOptimizedAmount. 
        /// <para>
        /// Total estimated spend after applying recommended optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string TotalOptimizedAmount { get; set; }

        /// <summary>
        /// Checks to see if the TotalOptimizedAmount property is set.
        /// </summary>
        internal bool IsSetTotalOptimizedAmount() => this.TotalOptimizedAmount != null;

        /// <summary>
        /// Gets and sets the property TotalPotentialSavingsAmount. 
        /// <para>
        /// Quantified savings achievable through implementing optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string TotalPotentialSavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the TotalPotentialSavingsAmount property is set.
        /// </summary>
        internal bool IsSetTotalPotentialSavingsAmount() => this.TotalPotentialSavingsAmount != null;
    }
}
