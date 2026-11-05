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
    /// This is the response object from the GetOfferSet operation.
    /// </summary>
    public partial class GetOfferSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociatedEntities. 
        /// <para>
        /// The products and offers included in this offer set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<OfferSetAssociatedEntity> AssociatedEntities { get; set; } = AWSConfigs.InitializeCollections ? new List<OfferSetAssociatedEntity>() : null;

        /// <summary>
        /// Checks to see if the AssociatedEntities property is set.
        /// </summary>
        internal bool IsSetAssociatedEntities() => this.AssociatedEntities != null && (this.AssociatedEntities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailableFromTime. 
        /// <para>
        /// The date and time when the offer set became available to the buyer.
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
        /// Badges indicating special attributes of the offer set, such as private pricing or
        /// future dated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public List<PurchaseOptionBadge> Badges { get; set; } = AWSConfigs.InitializeCollections ? new List<PurchaseOptionBadge>() : null;

        /// <summary>
        /// Checks to see if the Badges property is set.
        /// </summary>
        internal bool IsSetBadges() => this.Badges != null && (this.Badges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BuyerNotes. 
        /// <para>
        /// Detailed information about the offer set that helps buyers understand its purpose
        /// and contents.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string BuyerNotes { get; set; }

        /// <summary>
        /// Checks to see if the BuyerNotes property is set.
        /// </summary>
        internal bool IsSetBuyerNotes() => this.BuyerNotes != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The name of the catalog that the offer set belongs to.
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
        /// The date and time when the offer set expires and is no longer available for procurement.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the returned content. Indicates whether the response contains content
        /// in the requested locale, or fell back to the default locale. See <c>Locale</c> for
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property OfferSetId. 
        /// <para>
        /// The unique identifier of the offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string OfferSetId { get; set; }

        /// <summary>
        /// Checks to see if the OfferSetId property is set.
        /// </summary>
        internal bool IsSetOfferSetId() => this.OfferSetId != null;

        /// <summary>
        /// Gets and sets the property OfferSetName. 
        /// <para>
        /// The display name of the offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string OfferSetName { get; set; }

        /// <summary>
        /// Checks to see if the OfferSetName property is set.
        /// </summary>
        internal bool IsSetOfferSetName() => this.OfferSetName != null;

        /// <summary>
        /// Gets and sets the property SellerOfRecord. 
        /// <para>
        /// The entity responsible for selling the products under this offer set.
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
