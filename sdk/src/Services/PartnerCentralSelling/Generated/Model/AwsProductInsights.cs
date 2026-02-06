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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
        private List<AwsProductDetails> _awsProducts = AWSConfigs.InitializeCollections ? new List<AwsProductDetails>() : null;
        private AwsProductInsightsCurrencyCodeEnum _currencyCode;
        private PaymentFrequency _frequency;
        private string _totalAmount;
        private Dictionary<string, string> _totalAmountByCategory = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _totalOptimizedAmount;
        private string _totalPotentialSavingsAmount;

        /// <summary>
        /// Gets and sets the property AwsProducts. 
        /// <para>
        /// Product-level details including costs and optimization recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<AwsProductDetails> AwsProducts
        {
            get { return this._awsProducts; }
            set { this._awsProducts = value; }
        }

        // Check to see if AwsProducts property is set
        internal bool IsSetAwsProducts()
        {
            return this._awsProducts != null && (this._awsProducts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// ISO 4217 currency code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public AwsProductInsightsCurrencyCodeEnum CurrencyCode
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
        /// Gets and sets the property Frequency. 
        /// <para>
        /// Time period for spend amounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        /// Total estimated spend for this source before optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string TotalAmount
        {
            get { return this._totalAmount; }
            set { this._totalAmount = value; }
        }

        // Check to see if TotalAmount property is set
        internal bool IsSetTotalAmount()
        {
            return this._totalAmount != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAmountByCategory. 
        /// <para>
        /// Spend amounts mapped to AWS programs and modernization pathways.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> TotalAmountByCategory
        {
            get { return this._totalAmountByCategory; }
            set { this._totalAmountByCategory = value; }
        }

        // Check to see if TotalAmountByCategory property is set
        internal bool IsSetTotalAmountByCategory()
        {
            return this._totalAmountByCategory != null && (this._totalAmountByCategory.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalOptimizedAmount. 
        /// <para>
        /// Total estimated spend after applying recommended optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string TotalOptimizedAmount
        {
            get { return this._totalOptimizedAmount; }
            set { this._totalOptimizedAmount = value; }
        }

        // Check to see if TotalOptimizedAmount property is set
        internal bool IsSetTotalOptimizedAmount()
        {
            return this._totalOptimizedAmount != null;
        }

        /// <summary>
        /// Gets and sets the property TotalPotentialSavingsAmount. 
        /// <para>
        /// Quantified savings achievable through implementing optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string TotalPotentialSavingsAmount
        {
            get { return this._totalPotentialSavingsAmount; }
            set { this._totalPotentialSavingsAmount = value; }
        }

        // Check to see if TotalPotentialSavingsAmount property is set
        internal bool IsSetTotalPotentialSavingsAmount()
        {
            return this._totalPotentialSavingsAmount != null;
        }

    }
}