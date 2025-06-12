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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
        private List<string> _awsMarketplaceOffers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _awsProducts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _solutions = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsMarketplaceOffers
        {
            get { return this._awsMarketplaceOffers; }
            set { this._awsMarketplaceOffers = value; }
        }

        // Check to see if AwsMarketplaceOffers property is set
        internal bool IsSetAwsMarketplaceOffers()
        {
            return this._awsMarketplaceOffers != null && (this._awsMarketplaceOffers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsProducts
        {
            get { return this._awsProducts; }
            set { this._awsProducts = value; }
        }

        // Check to see if AwsProducts property is set
        internal bool IsSetAwsProducts()
        {
            return this._awsProducts != null && (this._awsProducts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Solutions
        {
            get { return this._solutions; }
            set { this._solutions = value; }
        }

        // Check to see if Solutions property is set
        internal bool IsSetSolutions()
        {
            return this._solutions != null && (this._solutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}