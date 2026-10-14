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
    /// Container for the parameters to the AssociateOpportunity operation. Enables you to
    /// create a formal association between an <c>Opportunity</c> and various related entities,
    /// enriching the context and details of the opportunity for better collaboration and
    /// decision making. You can associate an opportunity with the following entity types:
    /// <ul> <li> <para> Partner Solution: A software product or consulting practice created
    /// and delivered by Partners. Partner Solutions help customers address business challenges
    /// using Amazon Web Services services. </para> </li> <li> <para> Amazon Web Services
    /// Products: Amazon Web Services offers many products and services that provide scalable,
    /// reliable, and cost-effective infrastructure solutions. For the latest list of Amazon
    /// Web Services products, see <a href="https://github.com/aws-samples/partner-crm-integration-samples/blob/main/resources/aws_products.json">Amazon
    /// Web Services products</a>. </para> </li> <li> <para> Amazon Web Services Marketplace
    /// private offer: Allows Amazon Web Services Marketplace sellers to extend custom pricing
    /// and terms to individual Amazon Web Services customers. Sellers can negotiate custom
    /// prices, payment schedules, and end user license terms through private offers, enabling
    /// Amazon Web Services customers to acquire software solutions tailored to their specific
    /// needs. For more information, see <a href="https://docs.aws.amazon.com/marketplace/latest/buyerguide/buyer-private-offers.html">Private
    /// offers in Amazon Web Services Marketplace</a>. </para> </li> </ul> <para> To obtain
    /// identifiers for these entities, use the following methods: </para> <ul> <li> <para>
    /// Solution: Use the <c>ListSolutions</c> operation. </para> </li> <li> <para> AWS Products:
    /// For the latest list of Amazon Web Services products, see <a href="https://github.com/aws-samples/partner-crm-integration-samples/blob/main/resources/aws_products.json">Amazon
    /// Web Services products</a>. </para> </li> <li> <para> Amazon Web Services Marketplace
    /// private offer: Use the <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/catalog-apis.html">Using
    /// the Amazon Web Services Marketplace Catalog API</a> to list entities. Specifically,
    /// use the <c>ListEntities</c> operation to retrieve a list of private offers. The request
    /// returns the details of available private offers. For more information, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_ListEntities.html">ListEntities</a>.
    /// </para> </li> </ul>
    /// </summary>
    public partial class AssociateOpportunityRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the request. This field takes a string value
        /// from a predefined list: <c>AWS</c> or <c>Sandbox</c>. The catalog determines which
        /// environment the opportunity association is made in. Use <c>AWS</c> to associate opportunities
        /// in the Amazon Web Services catalog, and <c>Sandbox</c> for testing in secure, isolated
        /// environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property OpportunityIdentifier. 
        /// <para>
        /// Requires the <c>Opportunity</c>'s unique identifier when you want to associate it
        /// with a related entity. Provide the correct identifier so the intended opportunity
        /// is updated with the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OpportunityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OpportunityIdentifier property is set.
        /// </summary>
        internal bool IsSetOpportunityIdentifier() => this.OpportunityIdentifier != null;

        /// <summary>
        /// Gets and sets the property RelatedEntityIdentifier. 
        /// <para>
        /// Requires the related entity's unique identifier when you want to associate it with
        /// the <c> Opportunity</c>. For Amazon Web Services Marketplace entities, provide the
        /// Amazon Resource Name (ARN). Use the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html">
        /// Amazon Web Services Marketplace API</a> to obtain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelatedEntityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RelatedEntityIdentifier property is set.
        /// </summary>
        internal bool IsSetRelatedEntityIdentifier() => this.RelatedEntityIdentifier != null;

        /// <summary>
        /// Gets and sets the property RelatedEntityType. 
        /// <para>
        /// Specifies the entity type that you're associating with the <c> Opportunity</c>. This
        /// helps to categorize and properly process the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelatedEntityType RelatedEntityType { get; set; }

        /// <summary>
        /// Checks to see if the RelatedEntityType property is set.
        /// </summary>
        internal bool IsSetRelatedEntityType() => this.RelatedEntityType != null;
    }
}
