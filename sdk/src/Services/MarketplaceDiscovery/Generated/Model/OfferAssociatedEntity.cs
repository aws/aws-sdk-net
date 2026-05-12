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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A product and optional offer set associated with an offer.
    /// </summary>
    public partial class OfferAssociatedEntity
    {
        private OfferSetInformation _offerSet;
        private ProductInformation _product;

        /// <summary>
        /// Gets and sets the property OfferSet. 
        /// <para>
        /// Information about the offer set, if the offer is part of a bundled offer set.
        /// </para>
        /// </summary>
        public OfferSetInformation OfferSet
        {
            get { return this._offerSet; }
            set { this._offerSet = value; }
        }

        // Check to see if OfferSet property is set
        internal bool IsSetOfferSet()
        {
            return this._offerSet != null;
        }

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// Information about the product associated with the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProductInformation Product
        {
            get { return this._product; }
            set { this._product = value; }
        }

        // Check to see if Product property is set
        internal bool IsSetProduct()
        {
            return this._product != null;
        }

    }
}