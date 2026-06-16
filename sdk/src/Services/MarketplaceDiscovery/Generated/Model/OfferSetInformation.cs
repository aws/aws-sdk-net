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
    /// Summary information about an offer set, including the identifier and seller of record.
    /// </summary>
    public partial class OfferSetInformation
    {
        private string _offerSetId;
        private SellerInformation _sellerOfRecord;

        /// <summary>
        /// Gets and sets the property OfferSetId. 
        /// <para>
        /// The unique identifier of the offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string OfferSetId
        {
            get { return this._offerSetId; }
            set { this._offerSetId = value; }
        }

        // Check to see if OfferSetId property is set
        internal bool IsSetOfferSetId()
        {
            return this._offerSetId != null;
        }

        /// <summary>
        /// Gets and sets the property SellerOfRecord. 
        /// <para>
        /// The entity responsible for selling the products under this offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SellerInformation SellerOfRecord
        {
            get { return this._sellerOfRecord; }
            set { this._sellerOfRecord = value; }
        }

        // Check to see if SellerOfRecord property is set
        internal bool IsSetSellerOfRecord()
        {
            return this._sellerOfRecord != null;
        }

    }
}