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
    /// This is the response object from the GetListing operation.
    /// </summary>
    public partial class GetListingResponse : AmazonWebServiceResponse
    {
        private List<ListingAssociatedEntity> _associatedEntities = AWSConfigs.InitializeCollections ? new List<ListingAssociatedEntity>() : null;
        private List<ListingBadge> _badges = AWSConfigs.InitializeCollections ? new List<ListingBadge>() : null;
        private string _catalog;
        private List<Category> _categories = AWSConfigs.InitializeCollections ? new List<Category>() : null;
        private List<FulfillmentOptionSummary> _fulfillmentOptionSummaries = AWSConfigs.InitializeCollections ? new List<FulfillmentOptionSummary>() : null;
        private List<string> _highlights = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _integrationGuide;
        private string _listingId;
        private string _listingName;
        private string _logoThumbnailUrl;
        private string _longDescription;
        private List<PricingModel> _pricingModels = AWSConfigs.InitializeCollections ? new List<PricingModel>() : null;
        private List<PricingUnit> _pricingUnits = AWSConfigs.InitializeCollections ? new List<PricingUnit>() : null;
        private List<PromotionalMedia> _promotionalMedia = AWSConfigs.InitializeCollections ? new List<PromotionalMedia>() : null;
        private SellerInformation _publisher;
        private List<Resource> _resources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private ReviewSummary _reviewSummary;
        private List<SellerEngagement> _sellerEngagements = AWSConfigs.InitializeCollections ? new List<SellerEngagement>() : null;
        private string _shortDescription;
        private List<UseCaseEntry> _useCases = AWSConfigs.InitializeCollections ? new List<UseCaseEntry>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedEntities. 
        /// <para>
        /// The products and offers associated with this listing. Each entity contains product
        /// and offer information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<ListingAssociatedEntity> AssociatedEntities
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
        /// Gets and sets the property Badges. 
        /// <para>
        /// Badges indicating special attributes of the listing, such as free tier eligibility,
        /// free trial availability, or Quick Launch support.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<ListingBadge> Badges
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
        /// The name of the catalog that the listing belongs to.
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
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories used to classify this listing into logical groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=30)]
        public List<Category> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionSummaries. 
        /// <para>
        /// A summary of fulfillment options available for deploying or accessing the listing,
        /// such as AMI, SaaS, or Container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<FulfillmentOptionSummary> FulfillmentOptionSummaries
        {
            get { return this._fulfillmentOptionSummaries; }
            set { this._fulfillmentOptionSummaries = value; }
        }

        // Check to see if FulfillmentOptionSummaries property is set
        internal bool IsSetFulfillmentOptionSummaries()
        {
            return this._fulfillmentOptionSummaries != null && (this._fulfillmentOptionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Highlights. 
        /// <para>
        /// A list of key features that the listing offers to customers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<string> Highlights
        {
            get { return this._highlights; }
            set { this._highlights = value; }
        }

        // Check to see if Highlights property is set
        internal bool IsSetHighlights()
        {
            return this._highlights != null && (this._highlights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegrationGuide. 
        /// <para>
        /// Optional guidance explaining how to use data in this listing. Primarily defines how
        /// to integrate with a multi-product listing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string IntegrationGuide
        {
            get { return this._integrationGuide; }
            set { this._integrationGuide = value; }
        }

        // Check to see if IntegrationGuide property is set
        internal bool IsSetIntegrationGuide()
        {
            return this._integrationGuide != null;
        }

        /// <summary>
        /// Gets and sets the property ListingId. 
        /// <para>
        /// The unique identifier of the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ListingId
        {
            get { return this._listingId; }
            set { this._listingId = value; }
        }

        // Check to see if ListingId property is set
        internal bool IsSetListingId()
        {
            return this._listingId != null;
        }

        /// <summary>
        /// Gets and sets the property ListingName. 
        /// <para>
        /// The human-readable display name of the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ListingName
        {
            get { return this._listingName; }
            set { this._listingName = value; }
        }

        // Check to see if ListingName property is set
        internal bool IsSetListingName()
        {
            return this._listingName != null;
        }

        /// <summary>
        /// Gets and sets the property LogoThumbnailUrl. 
        /// <para>
        /// The URL of the logo thumbnail image for the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string LogoThumbnailUrl
        {
            get { return this._logoThumbnailUrl; }
            set { this._logoThumbnailUrl = value; }
        }

        // Check to see if LogoThumbnailUrl property is set
        internal bool IsSetLogoThumbnailUrl()
        {
            return this._logoThumbnailUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// A detailed description of what the listing offers, in paragraph format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32768)]
        public string LongDescription
        {
            get { return this._longDescription; }
            set { this._longDescription = value; }
        }

        // Check to see if LongDescription property is set
        internal bool IsSetLongDescription()
        {
            return this._longDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PricingModels. 
        /// <para>
        /// The pricing models for offers associated with this listing, such as usage-based, contract,
        /// BYOL, or free.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<PricingModel> PricingModels
        {
            get { return this._pricingModels; }
            set { this._pricingModels = value; }
        }

        // Check to see if PricingModels property is set
        internal bool IsSetPricingModels()
        {
            return this._pricingModels != null && (this._pricingModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PricingUnits. 
        /// <para>
        /// The pricing units that define the billing dimensions for offers associated with this
        /// listing, such as users, hosts, or data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<PricingUnit> PricingUnits
        {
            get { return this._pricingUnits; }
            set { this._pricingUnits = value; }
        }

        // Check to see if PricingUnits property is set
        internal bool IsSetPricingUnits()
        {
            return this._pricingUnits != null && (this._pricingUnits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PromotionalMedia. 
        /// <para>
        /// Embedded promotional media provided by the creator of the product, such as images
        /// and videos.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<PromotionalMedia> PromotionalMedia
        {
            get { return this._promotionalMedia; }
            set { this._promotionalMedia = value; }
        }

        // Check to see if PromotionalMedia property is set
        internal bool IsSetPromotionalMedia()
        {
            return this._promotionalMedia != null && (this._promotionalMedia.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Publisher. 
        /// <para>
        /// The entity who created and published the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SellerInformation Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }

        // Check to see if Publisher property is set
        internal bool IsSetPublisher()
        {
            return this._publisher != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Resources that provide further information about using the product or requesting support,
        /// such as documentation links, support contacts, and usage instructions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReviewSummary. 
        /// <para>
        /// A summary of customer reviews available for the listing, including average rating
        /// and total review count by source.
        /// </para>
        /// </summary>
        public ReviewSummary ReviewSummary
        {
            get { return this._reviewSummary; }
            set { this._reviewSummary = value; }
        }

        // Check to see if ReviewSummary property is set
        internal bool IsSetReviewSummary()
        {
            return this._reviewSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SellerEngagements. 
        /// <para>
        /// Engagement options available to potential buyers, such as requesting a private offer
        /// or requesting a demo.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<SellerEngagement> SellerEngagements
        {
            get { return this._sellerEngagements; }
            set { this._sellerEngagements = value; }
        }

        // Check to see if SellerEngagements property is set
        internal bool IsSetSellerEngagements()
        {
            return this._sellerEngagements != null && (this._sellerEngagements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A 1–3 sentence summary describing the key aspects of the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ShortDescription
        {
            get { return this._shortDescription; }
            set { this._shortDescription = value; }
        }

        // Check to see if ShortDescription property is set
        internal bool IsSetShortDescription()
        {
            return this._shortDescription != null;
        }

        /// <summary>
        /// Gets and sets the property UseCases. 
        /// <para>
        /// Use cases associated with the listing, describing scenarios where the product can
        /// be applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<UseCaseEntry> UseCases
        {
            get { return this._useCases; }
            set { this._useCases = value; }
        }

        // Check to see if UseCases property is set
        internal bool IsSetUseCases()
        {
            return this._useCases != null && (this._useCases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}