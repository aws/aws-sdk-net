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
    /// Container for the parameters to the DisassociateOpportunity operation.
    /// Allows you to remove an existing association between an <c>Opportunity</c> and related
    /// entities, such as a Partner Solution, Amazon Web Services product, or an Amazon Web
    /// Services Marketplace offer. This operation is the counterpart to <c>AssociateOpportunity</c>,
    /// and it provides flexibility to manage associations as business needs change.
    /// 
    ///  
    /// <para>
    /// Use this operation to update the associations of an <c>Opportunity</c> due to changes
    /// in the related entities, or if an association was made in error. Ensuring accurate
    /// associations helps maintain clarity and accuracy to track and manage business opportunities.
    /// When you replace an entity, first attach the new entity and then disassociate the
    /// one to be removed, especially if it's the last remaining entity that's required.
    /// </para>
    /// </summary>
    public partial class DisassociateOpportunityRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _opportunityIdentifier;
        private string _relatedEntityIdentifier;
        private RelatedEntityType _relatedEntityType;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the request. This field takes a string value
        /// from a predefined list: <c>AWS</c> or <c>Sandbox</c>. The catalog determines which
        /// environment the opportunity disassociation is made in. Use <c>AWS</c> to disassociate
        /// opportunities in the Amazon Web Services catalog, and <c>Sandbox</c> for testing in
        /// secure, isolated environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OpportunityIdentifier. 
        /// <para>
        /// The opportunity's unique identifier for when you want to disassociate it from related
        /// entities. This identifier helps to ensure that the correct opportunity is updated.
        /// </para>
        ///  
        /// <para>
        /// Validation: Ensure that the provided identifier corresponds to an existing opportunity
        /// in the Amazon Web Services system because incorrect identifiers result in an error
        /// and no changes are made.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OpportunityIdentifier
        {
            get { return this._opportunityIdentifier; }
            set { this._opportunityIdentifier = value; }
        }

        // Check to see if OpportunityIdentifier property is set
        internal bool IsSetOpportunityIdentifier()
        {
            return this._opportunityIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedEntityIdentifier. 
        /// <para>
        /// The related entity's identifier that you want to disassociate from the opportunity.
        /// Depending on the type of entity, this could be a simple identifier or an Amazon Resource
        /// Name (ARN) for entities managed through Amazon Web Services Marketplace.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services Marketplace entities, use the Amazon Web Services Marketplace
        /// API to obtain the necessary ARNs. For guidance on retrieving these ARNs, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html">
        /// Amazon Web Services MarketplaceUsing the Amazon Web Services Marketplace Catalog API</a>.
        /// </para>
        ///  
        /// <para>
        /// Validation: Ensure the identifier or ARN is valid and corresponds to an existing entity.
        /// An incorrect or invalid identifier results in an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RelatedEntityIdentifier
        {
            get { return this._relatedEntityIdentifier; }
            set { this._relatedEntityIdentifier = value; }
        }

        // Check to see if RelatedEntityIdentifier property is set
        internal bool IsSetRelatedEntityIdentifier()
        {
            return this._relatedEntityIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedEntityType. 
        /// <para>
        /// The type of the entity that you're disassociating from the opportunity. When you specify
        /// the entity type, it helps the system correctly process the disassociation request
        /// to ensure that the right connections are removed.
        /// </para>
        ///  
        /// <para>
        /// Examples of entity types include Partner Solution, Amazon Web Services product, and
        /// Amazon Web Services Marketplaceoffer. Ensure that the value matches one of the expected
        /// entity types.
        /// </para>
        ///  
        /// <para>
        /// Validation: Provide a valid entity type to help ensure successful disassociation.
        /// An invalid or incorrect entity type results in an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelatedEntityType RelatedEntityType
        {
            get { return this._relatedEntityType; }
            set { this._relatedEntityType = value; }
        }

        // Check to see if RelatedEntityType property is set
        internal bool IsSetRelatedEntityType()
        {
            return this._relatedEntityType != null;
        }

    }
}