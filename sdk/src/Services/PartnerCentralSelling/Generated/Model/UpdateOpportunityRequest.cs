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
    /// Container for the parameters to the UpdateOpportunity operation.
    /// Updates the <c>Opportunity</c> record identified by a given <c>Identifier</c>. This
    /// operation allows you to modify the details of an existing opportunity to reflect the
    /// latest information and progress. Use this action to keep the opportunity record up-to-date
    /// and accurate.
    /// 
    ///  
    /// <para>
    /// When you perform updates, include the entire payload with each request. If any field
    /// is omitted, the API assumes that the field is set to <c>null</c>. The best practice
    /// is to always perform a <c>GetOpportunity</c> to retrieve the latest values, then send
    /// the complete payload with the updated values to be changed.
    /// </para>
    /// </summary>
    public partial class UpdateOpportunityRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private Customer _customer;
        private string _identifier;
        private DateTime? _lastModifiedDate;
        private LifeCycle _lifeCycle;
        private Marketing _marketing;
        private NationalSecurity _nationalSecurity;
        private OpportunityType _opportunityType;
        private string _partnerOpportunityIdentifier;
        private List<string> _primaryNeedsFromAws = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Project _project;
        private SoftwareRevenue _softwareRevenue;

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
        /// Gets and sets the property Customer. 
        /// <para>
        /// Specifies details of the customer associated with the <c>Opportunity</c>.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Read-only, system generated <c>Opportunity</c> unique identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        ///  <c>DateTime</c> when the opportunity was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
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
        /// An object that contains marketing details for the <c>Opportunity</c>.
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
        /// Specifies if the opportunity is associated with national security concerns. This flag
        /// is only applicable when the industry is <c>Government</c>. For national-security-related
        /// opportunities, validation and compliance rules may apply, impacting the opportunity's
        /// visibility and processing.
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
        /// Gets and sets the property PartnerOpportunityIdentifier. 
        /// <para>
        /// Specifies the opportunity's unique identifier in the partner's CRM system. This value
        /// is essential to track and reconcile because it's included in the outbound payload
        /// sent back to the partner.
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
        /// An object that contains project details summary for the <c>Opportunity</c>.
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
        /// Specifies details of a customer's procurement terms. Required only for partners in
        /// eligible programs.
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

    }
}