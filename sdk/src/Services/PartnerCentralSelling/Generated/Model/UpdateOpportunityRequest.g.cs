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
    /// Container for the parameters to the UpdateOpportunity operation. Updates the <c>Opportunity</c>
    /// record identified by a given <c>Identifier</c>. This operation allows you to modify
    /// the details of an existing opportunity to reflect the latest information and progress.
    /// Use this action to keep the opportunity record up-to-date and accurate. <para> When
    /// you perform updates, include the entire payload with each request. If any field is
    /// omitted, the API assumes that the field is set to <c>null</c>. The best practice is
    /// to always perform a <c>GetOpportunity</c> to retrieve the latest values, then send
    /// the complete payload with the updated values to be changed. </para>
    /// </summary>
    public partial class UpdateOpportunityRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the request. This field takes a string value
        /// from a predefined list: <c>AWS</c> or <c>Sandbox</c>. The catalog determines which
        /// environment the opportunity is updated in. Use <c>AWS</c> to update real opportunities
        /// in the production environment, and <c>Sandbox</c> for testing in secure, isolated
        /// environments. When you use the <c>Sandbox</c> catalog, it allows you to simulate and
        /// validate your interactions with Amazon Web Services services without affecting live
        /// data or operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Specifies details of the customer associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Read-only, system generated <c>Opportunity</c> unique identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        ///  <c>DateTime</c> when the opportunity was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// An object that contains lifecycle details for the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public LifeCycle LifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycle property is set.
        /// </summary>
        internal bool IsSetLifeCycle() => this.LifeCycle != null;

        /// <summary>
        /// Gets and sets the property Marketing. 
        /// <para>
        /// An object that contains marketing details for the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public Marketing Marketing { get; set; }

        /// <summary>
        /// Checks to see if the Marketing property is set.
        /// </summary>
        internal bool IsSetMarketing() => this.Marketing != null;

        /// <summary>
        /// Gets and sets the property NationalSecurity. 
        /// <para>
        /// Specifies if the opportunity is associated with national security concerns. This flag
        /// is only applicable when the industry is <c>Government</c>. For national-security-related
        /// opportunities, validation and compliance rules may apply, impacting the opportunity's
        /// visibility and processing.
        /// </para>
        /// </summary>
        public NationalSecurity NationalSecurity { get; set; }

        /// <summary>
        /// Checks to see if the NationalSecurity property is set.
        /// </summary>
        internal bool IsSetNationalSecurity() => this.NationalSecurity != null;

        /// <summary>
        /// Gets and sets the property OpportunityType. 
        /// <para>
        /// Specifies the opportunity type as a renewal, new, or expansion.
        /// </para>
        ///  
        /// <para>
        /// Opportunity types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// New opportunity: Represents a new business opportunity with a potential customer that's
        /// not previously engaged with your solutions or services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Renewal opportunity: Represents an opportunity to renew an existing contract or subscription
        /// with a current customer, ensuring continuity of service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Expansion opportunity: Represents an opportunity to expand the scope of an existing
        /// contract or subscription, either by adding new services or increasing the volume of
        /// existing services for a current customer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OpportunityType OpportunityType { get; set; }

        /// <summary>
        /// Checks to see if the OpportunityType property is set.
        /// </summary>
        internal bool IsSetOpportunityType() => this.OpportunityType != null;

        /// <summary>
        /// Gets and sets the property PartnerOpportunityIdentifier. 
        /// <para>
        /// Specifies the opportunity's unique identifier in the partner's CRM system. This value
        /// is essential to track and reconcile because it's included in the outbound payload
        /// sent back to the partner.
        /// </para>
        /// </summary>
        public string PartnerOpportunityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PartnerOpportunityIdentifier property is set.
        /// </summary>
        internal bool IsSetPartnerOpportunityIdentifier() => this.PartnerOpportunityIdentifier != null;

        /// <summary>
        /// Gets and sets the property PrimaryNeedsFromAws. 
        /// <para>
        /// Identifies the type of support the partner needs from Amazon Web Services.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cosell—Architectural Validation: Confirmation from Amazon Web Services that the partner's
        /// proposed solution architecture is aligned with Amazon Web Services best practices
        /// and poses minimal architectural risks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cosell—Business Presentation: Request Amazon Web Services seller's participation in
        /// a joint customer presentation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cosell—Competitive Information: Access to Amazon Web Services competitive resources
        /// and support for the partner's proposed solution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cosell—Pricing Assistance: Connect with an AWS seller for support situations where
        /// a partner may be receiving an upfront discount on a service (for example: EDP deals).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cosell—Technical Consultation: Connection with an Amazon Web Services Solutions Architect
        /// to address the partner's questions about the proposed solution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cosell—Total Cost of Ownership Evaluation: Assistance with quoting different cost
        /// savings of proposed solutions on Amazon Web Services versus on-premises or a traditional
        /// hosting environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cosell—Deal Support: Request Amazon Web Services seller's support to progress the
        /// opportunity (for example: joint customer call, strategic positioning).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cosell—Support for Public Tender/RFx: Opportunity related to the public sector where
        /// the partner needs RFx support from Amazon Web Services.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrimaryNeedsFromAws { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PrimaryNeedsFromAws property is set.
        /// </summary>
        internal bool IsSetPrimaryNeedsFromAws() => this.PrimaryNeedsFromAws != null && (this.PrimaryNeedsFromAws.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// An object that contains project details summary for the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Checks to see if the Project property is set.
        /// </summary>
        internal bool IsSetProject() => this.Project != null;

        /// <summary>
        /// Gets and sets the property SoftwareRevenue. 
        /// <para>
        /// Specifies details of a customer's procurement terms. Required only for partners in
        /// eligible programs.
        /// </para>
        /// </summary>
        public SoftwareRevenue SoftwareRevenue { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareRevenue property is set.
        /// </summary>
        internal bool IsSetSoftwareRevenue() => this.SoftwareRevenue != null;
    }
}
