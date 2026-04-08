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
    /// This is the response object from the GetOffer operation.
    /// </summary>
    public partial class GetOfferResponse : AmazonWebServiceResponse
    {
        private string _agreementProposalId;
        private List<OfferAssociatedEntity> _associatedEntities = AWSConfigs.InitializeCollections ? new List<OfferAssociatedEntity>() : null;
        private DateTime? _availableFromTime;
        private List<PurchaseOptionBadge> _badges = AWSConfigs.InitializeCollections ? new List<PurchaseOptionBadge>() : null;
        private string _catalog;
        private DateTime? _expirationTime;
        private string _offerId;
        private string _offerName;
        private PricingModel _pricingModel;
        private string _replacementAgreementId;
        private SellerInformation _sellerOfRecord;

        /// <summary>
        /// Gets and sets the property AgreementProposalId. 
        /// <para>
        /// An encoded string to be passed by the acceptor of the terms when creating an agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AgreementProposalId
        {
            get { return this._agreementProposalId; }
            set { this._agreementProposalId = value; }
        }

        // Check to see if AgreementProposalId property is set
        internal bool IsSetAgreementProposalId()
        {
            return this._agreementProposalId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedEntities. 
        /// <para>
        /// The products and offer sets associated with this offer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<OfferAssociatedEntity> AssociatedEntities
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
        /// The date and time when the offer became available to the buyer.
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
        /// Badges indicating special attributes of the offer, such as private pricing, future
        /// dated, or replacement offer.
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
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The name of the catalog that the offer belongs to.
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
        /// The date and time until when the offer can be procured. This value is null for offers
        /// that never expire.
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
        /// Gets and sets the property OfferId. 
        /// <para>
        /// The unique identifier of the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string OfferId
        {
            get { return this._offerId; }
            set { this._offerId = value; }
        }

        // Check to see if OfferId property is set
        internal bool IsSetOfferId()
        {
            return this._offerId != null;
        }

        /// <summary>
        /// Gets and sets the property OfferName. 
        /// <para>
        /// The display name of the offer. This is free-form text provided by the seller.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string OfferName
        {
            get { return this._offerName; }
            set { this._offerName = value; }
        }

        // Check to see if OfferName property is set
        internal bool IsSetOfferName()
        {
            return this._offerName != null;
        }

        /// <summary>
        /// Gets and sets the property PricingModel. 
        /// <para>
        /// The pricing model that determines how buyers are charged, such as usage-based, contract,
        /// BYOL, or free.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingModel PricingModel
        {
            get { return this._pricingModel; }
            set { this._pricingModel = value; }
        }

        // Check to see if PricingModel property is set
        internal bool IsSetPricingModel()
        {
            return this._pricingModel != null;
        }

        /// <summary>
        /// Gets and sets the property ReplacementAgreementId. 
        /// <para>
        /// The identifier of the existing agreement that this offer would replace. Enables agreement-based
        /// offer functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ReplacementAgreementId
        {
            get { return this._replacementAgreementId; }
            set { this._replacementAgreementId = value; }
        }

        // Check to see if ReplacementAgreementId property is set
        internal bool IsSetReplacementAgreementId()
        {
            return this._replacementAgreementId != null;
        }

        /// <summary>
        /// Gets and sets the property SellerOfRecord. 
        /// <para>
        /// The entity responsible for selling the product under this offer.
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