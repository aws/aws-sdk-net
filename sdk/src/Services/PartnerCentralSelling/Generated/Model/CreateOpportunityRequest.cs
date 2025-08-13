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
    /// Container for the parameters to the CreateOpportunity operation.
    /// Creates an <c>Opportunity</c> record in Partner Central. Use this operation to create
    /// a potential business opportunity for submission to Amazon Web Services. Creating an
    /// opportunity sets <c>Lifecycle.ReviewStatus</c> to <c>Pending Submission</c>.
    /// 
    ///  
    /// <para>
    /// To submit an opportunity, follow these steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// To create the opportunity, use <c>CreateOpportunity</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To associate a solution with the opportunity, use <c>AssociateOpportunity</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To start the engagement with AWS, use <c>StartEngagementFromOpportunity</c>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// After submission, you can't edit the opportunity until the review is complete. But
    /// opportunities in the <c>Pending Submission</c> state must have complete details. You
    /// can update the opportunity while it's in the <c>Pending Submission</c> state.
    /// </para>
    ///  
    /// <para>
    /// There's a set of mandatory fields to create opportunities, but consider providing
    /// optional fields to enrich the opportunity record.
    /// </para>
    /// </summary>
    public partial class CreateOpportunityRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _clientToken;
        private Customer _customer;
        private LifeCycle _lifeCycle;
        private Marketing _marketing;
        private NationalSecurity _nationalSecurity;
        private List<Contact> _opportunityTeam = AWSConfigs.InitializeCollections ? new List<Contact>() : null;
        private OpportunityType _opportunityType;
        private OpportunityOrigin _origin;
        private string _partnerOpportunityIdentifier;
        private List<string> _primaryNeedsFromAws = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Project _project;
        private SoftwareRevenue _softwareRevenue;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        [AWSProperty(Min=1)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Specifies customer details associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public Customer Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }

        // Check to see if Customer property is set
        internal bool IsSetCustomer()
        {
            return this._customer != null;
        }

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// An object that contains lifecycle details for the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public LifeCycle LifeCycle
        {
            get { return this._lifeCycle; }
            set { this._lifeCycle = value; }
        }

        // Check to see if LifeCycle property is set
        internal bool IsSetLifeCycle()
        {
            return this._lifeCycle != null;
        }

        /// <summary>
        /// Gets and sets the property Marketing. 
        /// <para>
        /// This object contains marketing details and is optional for an opportunity.
        /// </para>
        /// </summary>
        public Marketing Marketing
        {
            get { return this._marketing; }
            set { this._marketing = value; }
        }

        // Check to see if Marketing property is set
        internal bool IsSetMarketing()
        {
            return this._marketing != null;
        }

        /// <summary>
        /// Gets and sets the property NationalSecurity. 
        /// <para>
        /// Indicates whether the <c>Opportunity</c> pertains to a national security project.
        /// This field must be set to <c>true</c> only when the customer's industry is <i>Government</i>.
        /// Additional privacy and security measures apply during the review and management process
        /// for opportunities marked as <c>NationalSecurity</c>.
        /// </para>
        /// </summary>
        public NationalSecurity NationalSecurity
        {
            get { return this._nationalSecurity; }
            set { this._nationalSecurity = value; }
        }

        // Check to see if NationalSecurity property is set
        internal bool IsSetNationalSecurity()
        {
            return this._nationalSecurity != null;
        }

        /// <summary>
        /// Gets and sets the property OpportunityTeam. 
        /// <para>
        /// Represents the internal team handling the opportunity. Specify collaborating members
        /// of this opportunity who are within the partner's organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<Contact> OpportunityTeam
        {
            get { return this._opportunityTeam; }
            set { this._opportunityTeam = value; }
        }

        // Check to see if OpportunityTeam property is set
        internal bool IsSetOpportunityTeam()
        {
            return this._opportunityTeam != null && (this._opportunityTeam.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public OpportunityType OpportunityType
        {
            get { return this._opportunityType; }
            set { this._opportunityType = value; }
        }

        // Check to see if OpportunityType property is set
        internal bool IsSetOpportunityType()
        {
            return this._opportunityType != null;
        }

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
        public OpportunityOrigin Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

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
        [AWSProperty(Min=0, Max=64)]
        public string PartnerOpportunityIdentifier
        {
            get { return this._partnerOpportunityIdentifier; }
            set { this._partnerOpportunityIdentifier = value; }
        }

        // Check to see if PartnerOpportunityIdentifier property is set
        internal bool IsSetPartnerOpportunityIdentifier()
        {
            return this._partnerOpportunityIdentifier != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrimaryNeedsFromAws
        {
            get { return this._primaryNeedsFromAws; }
            set { this._primaryNeedsFromAws = value; }
        }

        // Check to see if PrimaryNeedsFromAws property is set
        internal bool IsSetPrimaryNeedsFromAws()
        {
            return this._primaryNeedsFromAws != null && (this._primaryNeedsFromAws.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// An object that contains project details for the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public Project Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareRevenue. 
        /// <para>
        /// Specifies details of a customer's procurement terms. This is required only for partners
        /// in eligible programs.
        /// </para>
        /// </summary>
        public SoftwareRevenue SoftwareRevenue
        {
            get { return this._softwareRevenue; }
            set { this._softwareRevenue = value; }
        }

        // Check to see if SoftwareRevenue property is set
        internal bool IsSetSoftwareRevenue()
        {
            return this._softwareRevenue != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}