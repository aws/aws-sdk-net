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
    /// Container for the parameters to the CreateOpportunity operation. Creates an <c>Opportunity</c>
    /// record in Partner Central. Use this operation to create a potential business opportunity
    /// for submission to Amazon Web Services. Creating an opportunity sets <c>Lifecycle.ReviewStatus</c>
    /// to <c>Pending Submission</c>. <para> To submit an opportunity, follow these steps:
    /// </para> <ol> <li> <para> To create the opportunity, use <c>CreateOpportunity</c>.
    /// </para> </li> <li> <para> To associate a solution with the opportunity, use <c>AssociateOpportunity</c>.
    /// </para> </li> <li> <para> To start the engagement with AWS, use <c>StartEngagementFromOpportunity</c>.
    /// </para> </li> </ol> <para> After submission, you can't edit the opportunity until
    /// the review is complete. But opportunities in the <c>Pending Submission</c> state must
    /// have complete details. You can update the opportunity while it's in the <c>Pending
    /// Submission</c> state. </para> <para> There's a set of mandatory fields to create opportunities,
    /// but consider providing optional fields to enrich the opportunity record. </para>
    /// </summary>
    public partial class CreateOpportunityRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the request. This field takes a string value
        /// from a predefined list: <c>AWS</c> or <c>Sandbox</c>. The catalog determines which
        /// environment the opportunity is created in. Use <c>AWS</c> to create opportunities
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Required to be unique, and should be unchanging, it can be randomly generated or a
        /// meaningful string.
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Best practice: To help ensure uniqueness and avoid conflicts, use a Universally Unique
        /// Identifier (UUID) as the <c>ClientToken</c>. You can use standard libraries from most
        /// programming languages to generate this. If you use the same client token, the API
        /// returns the following error: "Conflicting client token submitted for a new request
        /// body."
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Specifies customer details associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

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
        /// This object contains marketing details and is optional for an opportunity.
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
        /// Indicates whether the <c>Opportunity</c> pertains to a national security project.
        /// This field must be set to <c>true</c> only when the customer's industry is <i>Government</i>.
        /// Additional privacy and security measures apply during the review and management process
        /// for opportunities marked as <c>NationalSecurity</c>.
        /// </para>
        /// </summary>
        public NationalSecurity NationalSecurity { get; set; }

        /// <summary>
        /// Checks to see if the NationalSecurity property is set.
        /// </summary>
        internal bool IsSetNationalSecurity() => this.NationalSecurity != null;

        /// <summary>
        /// Gets and sets the property OpportunityTeam. 
        /// <para>
        /// Represents the internal team handling the opportunity. Specify collaborating members
        /// of this opportunity who are within the partner's organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<Contact> OpportunityTeam { get; set; } = AWSConfigs.InitializeCollections ? new List<Contact>() : null;

        /// <summary>
        /// Checks to see if the OpportunityTeam property is set.
        /// </summary>
        internal bool IsSetOpportunityTeam() => this.OpportunityTeam != null && (this.OpportunityTeam.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Origin. 
        /// <para>
        /// Specifies the origin of the opportunity, indicating if it was sourced from Amazon
        /// Web Services or the partner. For all opportunities created with <c>Catalog: AWS</c>,
        /// this field must only be <c>Partner Referral</c>. However, when using <c>Catalog: Sandbox</c>,
        /// you can set this field to <c>AWS Referral</c> to simulate Amazon Web Services referral
        /// creation. This allows Amazon Web Services-originated flows testing in the sandbox
        /// catalog.
        /// </para>
        /// </summary>
        public OpportunityOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property PartnerOpportunityIdentifier. 
        /// <para>
        /// Specifies the opportunity's unique identifier in the partner's CRM system. This value
        /// is essential to track and reconcile because it's included in the outbound payload
        /// to the partner.
        /// </para>
        ///  
        /// <para>
        /// This field allows partners to link an opportunity to their CRM, which helps to ensure
        /// seamless integration and accurate synchronization between the Partner Central API
        /// and the partner's internal systems.
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
        /// Cosell—Pricing Assistance: Connect with an Amazon Web Services seller for support
        /// situations where a partner may be receiving an upfront discount on a service (for
        /// example: EDP deals).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cosell—Technical Consultation: Connect with an Amazon Web Services Solutions Architect
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
        /// the partner needs Amazon Web Services RFx support.
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
        /// An object that contains project details for the <c>Opportunity</c>.
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
        /// Specifies details of a customer's procurement terms. This is required only for partners
        /// in eligible programs.
        /// </para>
        /// </summary>
        public SoftwareRevenue SoftwareRevenue { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareRevenue property is set.
        /// </summary>
        internal bool IsSetSoftwareRevenue() => this.SoftwareRevenue != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
