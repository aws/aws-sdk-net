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
    /// This is the response object from the GetProduct operation.
    /// </summary>
    public partial class GetProductResponse : AmazonWebServiceResponse
    {
        private string _catalog;
        private List<Category> _categories = AWSConfigs.InitializeCollections ? new List<Category>() : null;
        private DeployedOnAwsStatus _deployedOnAws;
        private List<FulfillmentOptionSummary> _fulfillmentOptionSummaries = AWSConfigs.InitializeCollections ? new List<FulfillmentOptionSummary>() : null;
        private List<string> _highlights = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _logoThumbnailUrl;
        private string _longDescription;
        private SellerInformation _manufacturer;
        private string _productId;
        private string _productName;
        private List<PromotionalMedia> _promotionalMedia = AWSConfigs.InitializeCollections ? new List<PromotionalMedia>() : null;
        private List<Resource> _resources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private List<SellerEngagement> _sellerEngagements = AWSConfigs.InitializeCollections ? new List<SellerEngagement>() : null;
        private string _shortDescription;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The name of the catalog that the product belongs to.
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
        /// The categories used to classify this product into logical groups.
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
        /// Gets and sets the property DeployedOnAws. 
        /// <para>
        /// Indicates whether the product is deployed on AWS infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeployedOnAwsStatus DeployedOnAws
        {
            get { return this._deployedOnAws; }
            set { this._deployedOnAws = value; }
        }

        // Check to see if DeployedOnAws property is set
        internal bool IsSetDeployedOnAws()
        {
            return this._deployedOnAws != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionSummaries. 
        /// <para>
        /// A summary of fulfillment options available for deploying or accessing the product,
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
        /// A list of key features that the product offers to customers.
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
        /// Gets and sets the property LogoThumbnailUrl. 
        /// <para>
        /// The URL of the logo thumbnail image for the product.
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
        /// A detailed description of what the product does, in paragraph format.
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
        /// Gets and sets the property Manufacturer. 
        /// <para>
        /// The entity who manufactured the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SellerInformation Manufacturer
        {
            get { return this._manufacturer; }
            set { this._manufacturer = value; }
        }

        // Check to see if Manufacturer property is set
        internal bool IsSetManufacturer()
        {
            return this._manufacturer != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The unique identifier of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The human-readable display name of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
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
        /// A 1–3 sentence summary describing the key aspects of the product.
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