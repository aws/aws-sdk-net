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
    /// This is the response object from the GetProduct operation.
    /// </summary>
    public partial class GetProductResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The name of the catalog that the product belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories used to classify this product into logical groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 30)]
        public List<Category> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<Category>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeployedOnAws. 
        /// <para>
        /// Indicates whether the product is deployed on AWS infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeployedOnAwsStatus DeployedOnAws { get; set; }

        /// <summary>
        /// Checks to see if the DeployedOnAws property is set.
        /// </summary>
        internal bool IsSetDeployedOnAws() => this.DeployedOnAws != null;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionSummaries. 
        /// <para>
        /// A summary of fulfillment options available for deploying or accessing the product,
        /// such as AMI, SaaS, or Container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public List<FulfillmentOptionSummary> FulfillmentOptionSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<FulfillmentOptionSummary>() : null;

        /// <summary>
        /// Checks to see if the FulfillmentOptionSummaries property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionSummaries() => this.FulfillmentOptionSummaries != null && (this.FulfillmentOptionSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Highlights. 
        /// <para>
        /// A list of key features that the product offers to customers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public List<string> Highlights { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Highlights property is set.
        /// </summary>
        internal bool IsSetHighlights() => this.Highlights != null && (this.Highlights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListingId. 
        /// <para>
        /// The default listing identifier associated with the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ListingId { get; set; }

        /// <summary>
        /// Checks to see if the ListingId property is set.
        /// </summary>
        internal bool IsSetListingId() => this.ListingId != null;

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
        /// Gets and sets the property LogoThumbnailUrl. 
        /// <para>
        /// The URL of the logo thumbnail image for the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string LogoThumbnailUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogoThumbnailUrl property is set.
        /// </summary>
        internal bool IsSetLogoThumbnailUrl() => this.LogoThumbnailUrl != null;

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// A detailed description of what the product does, in paragraph format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 32768)]
        public string LongDescription { get; set; }

        /// <summary>
        /// Checks to see if the LongDescription property is set.
        /// </summary>
        internal bool IsSetLongDescription() => this.LongDescription != null;

        /// <summary>
        /// Gets and sets the property Manufacturer. 
        /// <para>
        /// The entity who manufactured the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SellerInformation Manufacturer { get; set; }

        /// <summary>
        /// Checks to see if the Manufacturer property is set.
        /// </summary>
        internal bool IsSetManufacturer() => this.Manufacturer != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The unique identifier of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The human-readable display name of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property PromotionalMedia. 
        /// <para>
        /// Embedded promotional media provided by the creator of the product, such as images
        /// and videos.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<PromotionalMedia> PromotionalMedia { get; set; } = AWSConfigs.InitializeCollections ? new List<PromotionalMedia>() : null;

        /// <summary>
        /// Checks to see if the PromotionalMedia property is set.
        /// </summary>
        internal bool IsSetPromotionalMedia() => this.PromotionalMedia != null && (this.PromotionalMedia.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Resources that provide further information about using the product or requesting support,
        /// such as documentation links, support contacts, and usage instructions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<Resource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SellerEngagements. 
        /// <para>
        /// Engagement options available to potential buyers, such as requesting a private offer
        /// or requesting a demo.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<SellerEngagement> SellerEngagements { get; set; } = AWSConfigs.InitializeCollections ? new List<SellerEngagement>() : null;

        /// <summary>
        /// Checks to see if the SellerEngagements property is set.
        /// </summary>
        internal bool IsSetSellerEngagements() => this.SellerEngagements != null && (this.SellerEngagements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A 1–3 sentence summary describing the key aspects of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;
    }
}
