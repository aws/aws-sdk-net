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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// This field provides the associations' information for other entities with the opportunity.
    /// These entities include identifiers for <c>AWSProducts</c>, <c>Partner Solutions</c>,
    /// and <c>AWSMarketplaceOffers</c>.
    /// </summary>
    public partial class RelatedEntityIdentifiers
    {
        /// <summary>
        /// Gets and sets the property AwsMarketplaceOfferSets. 
        /// <para>
        /// Enables the association of AWS Marketplace offer sets with the <c>Opportunity</c>.
        /// Offer sets allow grouping multiple related marketplace offers together for comprehensive
        /// solution packaging. Each value is an Amazon Resource Name (ARN) in this format: <c>arn:aws:aws-marketplace:us-east-1:999999999999:AWSMarketplace/OfferSet/offerset-sampleOfferSet32</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsMarketplaceOfferSets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsMarketplaceOfferSets property is set.
        /// </summary>
        internal bool IsSetAwsMarketplaceOfferSets() => this.AwsMarketplaceOfferSets != null && (this.AwsMarketplaceOfferSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsMarketplaceOffers. 
        /// <para>
        /// Takes one value per opportunity. Each value is an Amazon Resource Name (ARN), in this
        /// format: <c>"offers": ["arn:aws:aws-marketplace:us-east-1:999999999999:AWSMarketplace/Offer/offer-sampleOffer32"]</c>.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_ListEntities.html">ListEntities</a>
        /// action in the Marketplace Catalog APIs for a list of offers in the associated Marketplace
        /// seller account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsMarketplaceOffers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsMarketplaceOffers property is set.
        /// </summary>
        internal bool IsSetAwsMarketplaceOffers() => this.AwsMarketplaceOffers != null && (this.AwsMarketplaceOffers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsMarketplaceProducts. 
        /// <para>
        /// Specifies the AWS Marketplace products to associate with the <c>Opportunity</c>. Each
        /// value is an Amazon Resource Name (ARN) that identifies a product listing in AWS Marketplace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsMarketplaceProducts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsMarketplaceProducts property is set.
        /// </summary>
        internal bool IsSetAwsMarketplaceProducts() => this.AwsMarketplaceProducts != null && (this.AwsMarketplaceProducts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsMarketplaceSolutions. 
        /// <para>
        /// Specifies the AWS Marketplace solutions to associate with the <c>Opportunity</c>.
        /// Each value is an Amazon Resource Name (ARN) that identifies a solution listing in
        /// AWS Marketplace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsMarketplaceSolutions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsMarketplaceSolutions property is set.
        /// </summary>
        internal bool IsSetAwsMarketplaceSolutions() => this.AwsMarketplaceSolutions != null && (this.AwsMarketplaceSolutions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsProducts. 
        /// <para>
        /// Enables the association of specific Amazon Web Services products with the <c>Opportunity</c>.
        /// Partners can indicate the relevant Amazon Web Services products for the <c>Opportunity</c>'s
        /// solution and align with the customer's needs. Returns multiple values separated by
        /// commas. For example, <c>"AWSProducts" : ["AmazonRedshift", "AWSAppFabric", "AWSCleanRooms"]</c>.
        /// </para>
        ///  
        /// <para>
        /// Use the file with the list of Amazon Web Services products hosted on GitHub: <a href="https://github.com/aws-samples/partner-crm-integration-samples/blob/main/resources/aws_products.json">
        /// Amazon Web Services products</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsProducts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsProducts property is set.
        /// </summary>
        internal bool IsSetAwsProducts() => this.AwsProducts != null && (this.AwsProducts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Solutions. 
        /// <para>
        /// Enables partner solutions or offerings' association with an opportunity. To associate
        /// a solution, provide the solution's unique identifier, which you can obtain with the
        /// <c>ListSolutions</c> operation.
        /// </para>
        ///  
        /// <para>
        /// If the specific solution identifier is not available, you can use the value <c>Other</c>
        /// and provide details about the solution in the <c>otherSolutionOffered</c> field. But
        /// when the opportunity reaches the <c>Committed</c> stage or beyond, the <c>Other</c>
        /// value cannot be used, and a valid solution identifier must be provided.
        /// </para>
        ///  
        /// <para>
        /// By associating the relevant solutions with the opportunity, you can communicate the
        /// offerings that are being considered or implemented to address the customer's business
        /// problem.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Solutions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Solutions property is set.
        /// </summary>
        internal bool IsSetSolutions() => this.Solutions != null && (this.Solutions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
