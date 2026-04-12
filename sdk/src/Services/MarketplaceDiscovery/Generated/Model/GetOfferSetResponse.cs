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
    /// This is the response object from the GetOfferSet operation.
    /// </summary>
    public partial class GetOfferSetResponse : AmazonWebServiceResponse
    {
        private List<OfferSetAssociatedEntity> _associatedEntities = AWSConfigs.InitializeCollections ? new List<OfferSetAssociatedEntity>() : null;
        private DateTime? _availableFromTime;
        private List<PurchaseOptionBadge> _badges = AWSConfigs.InitializeCollections ? new List<PurchaseOptionBadge>() : null;
        private string _buyerNotes;
        private string _catalog;
        private DateTime? _expirationTime;
        private string _offerSetId;
        private string _offerSetName;
        private SellerInformation _sellerOfRecord;

        /// <summary>
        /// Gets and sets the property AssociatedEntities. 
        /// <para>
        /// The products and offers included in this offer set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<OfferSetAssociatedEntity> AssociatedEntities
        {
            get { return this._associatedEntities; }
            set { this._associatedEntities = value; }
        }

        // Check to see if AssociatedEntities property is set
        internal bool IsSetAssociatedEntities()
        {
            return this._associatedEntities != null && (this._associatedEntities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailableFromTime. 
        /// <para>
        /// The date and time when the offer set became available to the buyer.
        /// </para>
        /// </summary>
        public DateTime? AvailableFromTime
        {
            get { return this._availableFromTime; }
            set { this._availableFromTime = value; }
        }

        // Check to see if AvailableFromTime property is set
        internal bool IsSetAvailableFromTime()
        {
            return this._availableFromTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Badges. 
        /// <para>
        /// Badges indicating special attributes of the offer set, such as private pricing or
        /// future dated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<PurchaseOptionBadge> Badges
        {
            get { return this._badges; }
            set { this._badges = value; }
        }

        // Check to see if Badges property is set
        internal bool IsSetBadges()
        {
            return this._badges != null && (this._badges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BuyerNotes. 
        /// <para>
        /// Detailed information about the offer set that helps buyers understand its purpose
        /// and contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string BuyerNotes
        {
            get { return this._buyerNotes; }
            set { this._buyerNotes = value; }
        }

        // Check to see if BuyerNotes property is set
        internal bool IsSetBuyerNotes()
        {
            return this._buyerNotes != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The name of the catalog that the offer set belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The date and time when the offer set expires and is no longer available for procurement.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

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
        /// Gets and sets the property OfferSetName. 
        /// <para>
        /// The display name of the offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string OfferSetName
        {
            get { return this._offerSetName; }
            set { this._offerSetName = value; }
        }

        // Check to see if OfferSetName property is set
        internal bool IsSetOfferSetName()
        {
            return this._offerSetName != null;
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