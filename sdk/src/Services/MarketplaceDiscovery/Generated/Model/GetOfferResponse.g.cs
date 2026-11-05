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
    /// This is the response object from the GetOffer operation.
    /// </summary>
    public partial class GetOfferResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgreementProposalId. 
        /// <para>
        /// An encoded string to be passed by the acceptor of the terms when creating an agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementProposalId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementProposalId property is set.
        /// </summary>
        internal bool IsSetAgreementProposalId() => this.AgreementProposalId != null;

        /// <summary>
        /// Gets and sets the property AssociatedEntities. 
        /// <para>
        /// The products and offer sets associated with this offer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<OfferAssociatedEntity> AssociatedEntities { get; set; } = AWSConfigs.InitializeCollections ? new List<OfferAssociatedEntity>() : null;

        /// <summary>
        /// Checks to see if the AssociatedEntities property is set.
        /// </summary>
        internal bool IsSetAssociatedEntities() => this.AssociatedEntities != null && (this.AssociatedEntities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailableFromTime. 
        /// <para>
        /// The date and time when the offer became available to the buyer.
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
        /// Badges indicating special attributes of the offer, such as private pricing, future
        /// dated, or replacement offer.
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
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The name of the catalog that the offer belongs to.
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
        /// The date and time until when the offer can be procured. This value is null for offers
        /// that never expire.
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
        /// Gets and sets the property OfferId. 
        /// <para>
        /// The unique identifier of the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string OfferId { get; set; }

        /// <summary>
        /// Checks to see if the OfferId property is set.
        /// </summary>
        internal bool IsSetOfferId() => this.OfferId != null;

        /// <summary>
        /// Gets and sets the property OfferName. 
        /// <para>
        /// The display name of the offer. This is free-form text provided by the seller.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string OfferName { get; set; }

        /// <summary>
        /// Checks to see if the OfferName property is set.
        /// </summary>
        internal bool IsSetOfferName() => this.OfferName != null;

        /// <summary>
        /// Gets and sets the property PricingModel. 
        /// <para>
        /// The pricing model that determines how buyers are charged, such as usage-based, contract,
        /// BYOL, or free.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PricingModel PricingModel { get; set; }

        /// <summary>
        /// Checks to see if the PricingModel property is set.
        /// </summary>
        internal bool IsSetPricingModel() => this.PricingModel != null;

        /// <summary>
        /// Gets and sets the property ReplacementAgreementId. 
        /// <para>
        /// The identifier of the existing agreement that this offer would replace. Enables agreement-based
        /// offer functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ReplacementAgreementId { get; set; }

        /// <summary>
        /// Checks to see if the ReplacementAgreementId property is set.
        /// </summary>
        internal bool IsSetReplacementAgreementId() => this.ReplacementAgreementId != null;

        /// <summary>
        /// Gets and sets the property SellerOfRecord. 
        /// <para>
        /// The entity responsible for selling the product under this offer.
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
