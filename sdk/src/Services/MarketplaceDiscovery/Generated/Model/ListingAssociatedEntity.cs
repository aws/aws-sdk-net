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
    /// A product and offer associated with a listing.
    /// </summary>
    public partial class ListingAssociatedEntity
    {
        private OfferInformation _offer;
        private ProductInformation _product;

        /// <summary>
        /// Gets and sets the property Offer. 
        /// <para>
        /// Information about the default offer associated with the listing.
        /// </para>
        /// </summary>
        public OfferInformation Offer
        {
            get { return this._offer; }
            set { this._offer = value; }
        }

        // Check to see if Offer property is set
        internal bool IsSetOffer()
        {
            return this._offer != null;
        }

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// Information about the product associated with the listing.
        /// </para>
        /// </summary>
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