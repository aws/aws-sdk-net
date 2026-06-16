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
    /// Summary information about a purchase option (offer or offer set) available to the
    /// buyer, including the seller, badges, and associated products.
    /// </summary>
    public partial class PurchaseOptionSummary
    {
        private List<PurchaseOptionAssociatedEntity> _associatedEntities = AWSConfigs.InitializeCollections ? new List<PurchaseOptionAssociatedEntity>() : null;
        private DateTime? _availableFromTime;
        private List<PurchaseOptionBadge> _badges = AWSConfigs.InitializeCollections ? new List<PurchaseOptionBadge>() : null;
        private string _catalog;
        private DateTime? _expirationTime;
        private string _purchaseOptionId;
        private string _purchaseOptionName;
        private PurchaseOptionType _purchaseOptionType;
        private SellerInformation _sellerOfRecord;

        /// <summary>
        /// Gets and sets the property AssociatedEntities. 
        /// <para>
        /// The products, offers, and offer sets associated with this purchase option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<PurchaseOptionAssociatedEntity> AssociatedEntities
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
        /// The date and time when the purchase option became available to the buyer.
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
        /// Badges indicating special attributes of the purchase option, such as private pricing
        /// or future dated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
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
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The name of the catalog that the purchase option belongs to.
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
        /// The date and time when the purchase option expires and is no longer available for
        /// procurement.
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
        /// Gets and sets the property PurchaseOptionId. 
        /// <para>
        /// The unique identifier of the purchase option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string PurchaseOptionId
        {
            get { return this._purchaseOptionId; }
            set { this._purchaseOptionId = value; }
        }

        // Check to see if PurchaseOptionId property is set
        internal bool IsSetPurchaseOptionId()
        {
            return this._purchaseOptionId != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseOptionName. 
        /// <para>
        /// The display name of the purchase option.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PurchaseOptionName
        {
            get { return this._purchaseOptionName; }
            set { this._purchaseOptionName = value; }
        }

        // Check to see if PurchaseOptionName property is set
        internal bool IsSetPurchaseOptionName()
        {
            return this._purchaseOptionName != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseOptionType. 
        /// <para>
        /// The type of purchase option. Values are <c>OFFER</c> for a single-product offer or
        /// <c>OFFERSET</c> for a bundled offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PurchaseOptionType PurchaseOptionType
        {
            get { return this._purchaseOptionType; }
            set { this._purchaseOptionType = value; }
        }

        // Check to see if PurchaseOptionType property is set
        internal bool IsSetPurchaseOptionType()
        {
            return this._purchaseOptionType != null;
        }

        /// <summary>
        /// Gets and sets the property SellerOfRecord. 
        /// <para>
        /// The entity responsible for selling the product under this purchase option.
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