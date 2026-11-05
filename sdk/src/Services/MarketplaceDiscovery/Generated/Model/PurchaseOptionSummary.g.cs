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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Summary information about a purchase option (offer or offer set) available to the
    /// buyer, including the seller, badges, and associated products.
    /// </summary>
    public partial class PurchaseOptionSummary
    {
        /// <summary>
        /// Gets and sets the property AssociatedEntities. 
        /// <para>
        /// The products, offers, and offer sets associated with this purchase option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<PurchaseOptionAssociatedEntity> AssociatedEntities { get; set; } = AWSConfigs.InitializeCollections ? new List<PurchaseOptionAssociatedEntity>() : null;

        /// <summary>
        /// Checks to see if the AssociatedEntities property is set.
        /// </summary>
        internal bool IsSetAssociatedEntities() => this.AssociatedEntities != null && (this.AssociatedEntities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailableFromTime. 
        /// <para>
        /// The date and time when the purchase option became available to the buyer.
        /// </para>
        /// </summary>
        public DateTime? AvailableFromTime { get; set; }

        /// <summary>
        /// Checks to see if the AvailableFromTime property is set.
        /// </summary>
        internal bool IsSetAvailableFromTime() => this.AvailableFromTime.HasValue;

        /// <summary>
        /// Gets and sets the property Badges. 
        /// <para>
        /// Badges indicating special attributes of the purchase option, such as private pricing
        /// or future dated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<PurchaseOptionBadge> Badges { get; set; } = AWSConfigs.InitializeCollections ? new List<PurchaseOptionBadge>() : null;

        /// <summary>
        /// Checks to see if the Badges property is set.
        /// </summary>
        internal bool IsSetBadges() => this.Badges != null && (this.Badges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The name of the catalog that the purchase option belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The date and time when the purchase option expires and is no longer available for
        /// procurement.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property PurchaseOptionId. 
        /// <para>
        /// The unique identifier of the purchase option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string PurchaseOptionId { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOptionId property is set.
        /// </summary>
        internal bool IsSetPurchaseOptionId() => this.PurchaseOptionId != null;

        /// <summary>
        /// Gets and sets the property PurchaseOptionName. 
        /// <para>
        /// The display name of the purchase option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PurchaseOptionName { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOptionName property is set.
        /// </summary>
        internal bool IsSetPurchaseOptionName() => this.PurchaseOptionName != null;

        /// <summary>
        /// Gets and sets the property PurchaseOptionType. 
        /// <para>
        /// The type of purchase option. Values are <c>OFFER</c> for a single-product offer or
        /// <c>OFFERSET</c> for a bundled offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PurchaseOptionType PurchaseOptionType { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOptionType property is set.
        /// </summary>
        internal bool IsSetPurchaseOptionType() => this.PurchaseOptionType != null;

        /// <summary>
        /// Gets and sets the property SellerOfRecord. 
        /// <para>
        /// The entity responsible for selling the product under this purchase option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SellerInformation SellerOfRecord { get; set; }

        /// <summary>
        /// Checks to see if the SellerOfRecord property is set.
        /// </summary>
        internal bool IsSetSellerOfRecord() => this.SellerOfRecord != null;
    }
}
