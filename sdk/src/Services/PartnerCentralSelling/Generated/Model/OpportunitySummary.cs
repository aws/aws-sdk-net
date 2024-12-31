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
    /// An object that contains an <c>Opportunity</c>'s subset of fields.
    /// </summary>
    public partial class OpportunitySummary
    {
        private string _arn;
        private string _catalog;
        private DateTime? _createdDate;
        private CustomerSummary _customer;
        private string _id;
        private DateTime? _lastModifiedDate;
        private LifeCycleSummary _lifeCycle;
        private OpportunityType _opportunityType;
        private string _partnerOpportunityIdentifier;
        private ProjectSummary _project;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the opportunity. This globally unique identifier
        /// can be used for IAM policies and cross-service references. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the opportunity, either <c>AWS</c> or <c>Sandbox</c>.
        /// This indicates the environment in which the opportunity is managed.
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        ///  <c>DateTime</c> when the <c>Opportunity</c> was last created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// An object that contains the <c>Opportunity</c>'s customer details.
        /// </para>
        /// </summary>
        public CustomerSummary Customer
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
        /// Gets and sets the property Id. 
        /// <para>
        /// Read-only, system-generated <c>Opportunity</c> unique identifier.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        ///  <c>DateTime</c> when the <c>Opportunity</c> was last modified.
        /// </para>
        /// </summary>
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
        /// An object that contains the <c>Opportunity</c>'s lifecycle details.
        /// </para>
        /// </summary>
        public LifeCycleSummary LifeCycle
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
        /// Gets and sets the property OpportunityType. 
        /// <para>
        /// Specifies opportunity type as a renewal, new, or expansion.
        /// </para>
        ///  
        /// <para>
        /// Opportunity types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// New Opportunity: Represents a new business opportunity with a potential customer that's
        /// not previously engaged with your solutions or services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Renewal Opportunity: Represents an opportunity to renew an existing contract or subscription
        /// with a current customer, ensuring continuity of service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Expansion Opportunity: Represents an opportunity to expand the scope of an existing
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
        /// Specifies the <c>Opportunity</c>'s unique identifier in the partner's CRM system.
        /// This value is essential to track and reconcile because it's included in the outbound
        /// payload sent back to the partner. It allows partners to link an opportunity to their
        /// CRM.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Project. 
        /// <para>
        /// An object that contains the <c>Opportunity</c>'s project details summary.
        /// </para>
        /// </summary>
        public ProjectSummary Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

    }
}