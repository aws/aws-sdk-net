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
    /// Summary information about a listing returned by search operations, including the listing
    /// name, description, badges, categories, pricing models, reviews, and associated products.
    /// </summary>
    public partial class ListingSummary
    {
        private List<ListingSummaryAssociatedEntity> _associatedEntities = AWSConfigs.InitializeCollections ? new List<ListingSummaryAssociatedEntity>() : null;
        private List<ListingBadge> _badges = AWSConfigs.InitializeCollections ? new List<ListingBadge>() : null;
        private string _catalog;
        private List<Category> _categories = AWSConfigs.InitializeCollections ? new List<Category>() : null;
        private List<FulfillmentOptionSummary> _fulfillmentOptionSummaries = AWSConfigs.InitializeCollections ? new List<FulfillmentOptionSummary>() : null;
        private string _listingId;
        private string _listingName;
        private string _logoThumbnailUrl;
        private List<PricingModel> _pricingModels = AWSConfigs.InitializeCollections ? new List<PricingModel>() : null;
        private List<PricingUnit> _pricingUnits = AWSConfigs.InitializeCollections ? new List<PricingUnit>() : null;
        private SellerInformation _publisher;
        private ReviewSummary _reviewSummary;
        private string _shortDescription;

        /// <summary>
        /// Gets and sets the property AssociatedEntities. 
        /// <para>
        /// The products associated with this listing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<ListingSummaryAssociatedEntity> AssociatedEntities
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
        /// Badges indicating special attributes of the listing.
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
        /// A summary of fulfillment options available for the listing.
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
        /// Gets and sets the property PricingModels. 
        /// <para>
        /// The pricing models for offers associated with this listing.
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
        /// listing.
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
        /// Gets and sets the property ReviewSummary. 
        /// <para>
        /// A summary of customer reviews for the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}