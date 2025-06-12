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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Defines a usage-based pricing model (typically, pay-as-you-go pricing), where the
    /// customers are charged based on product usage.
    /// </summary>
    public partial class UsageBasedPricingTerm
    {
        private string _currencyCode;
        private List<UsageBasedRateCardItem> _rateCards = AWSConfigs.InitializeCollections ? new List<UsageBasedRateCardItem>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// Defines the currency for the prices mentioned in the term. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
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
        /// Gets and sets the property RateCards. 
        /// <para>
        /// List of rate cards.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageBasedRateCardItem> RateCards
        {
            get { return this._rateCards; }
            set { this._rateCards = value; }
        }

        // Check to see if RateCards property is set
        internal bool IsSetRateCards()
        {
            return this._rateCards != null && (this._rateCards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Category of the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}