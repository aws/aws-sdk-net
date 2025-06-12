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
    /// Defines a prepaid pricing model where the customers are charged a fixed upfront amount.
    /// </summary>
    public partial class FixedUpfrontPricingTerm
    {
        private string _currencyCode;
        private string _duration;
        private List<GrantItem> _grants = AWSConfigs.InitializeCollections ? new List<GrantItem>() : null;
        private string _price;
        private string _type;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// Defines the currency for the prices mentioned in this term. 
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
        /// Gets and sets the property Duration. 
        /// <para>
        /// Contract duration for the terms.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property Grants. 
        /// <para>
        /// Entitlements granted to the acceptor of fixed upfront as part of agreement execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GrantItem> Grants
        {
            get { return this._grants; }
            set { this._grants = value; }
        }

        // Check to see if Grants property is set
        internal bool IsSetGrants()
        {
            return this._grants != null && (this._grants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// Fixed amount to be charged to the customer when this term is accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        // Check to see if Price property is set
        internal bool IsSetPrice()
        {
            return this._price != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Category of the term being updated.
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