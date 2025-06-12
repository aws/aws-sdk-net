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
    /// This is the response object from the GetAwsOpportunitySummary operation.
    /// </summary>
    public partial class GetAwsOpportunitySummaryResponse : AmazonWebServiceResponse
    {
        private string _catalog;
        private AwsOpportunityCustomer _customer;
        private AwsOpportunityInsights _insights;
        private SalesInvolvementType _involvementType;
        private InvolvementTypeChangeReason _involvementTypeChangeReason;
        private AwsOpportunityLifeCycle _lifeCycle;
        private List<AwsTeamMember> _opportunityTeam = AWSConfigs.InitializeCollections ? new List<AwsTeamMember>() : null;
        private OpportunityOrigin _origin;
        private AwsOpportunityProject _project;
        private AwsOpportunityRelatedEntities _relatedEntityIds;
        private string _relatedOpportunityId;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which the AWS Opportunity exists. This is the environment
        /// (e.g., <c>AWS</c> or <c>Sandbox</c>) where the opportunity is being managed.
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
        /// Provides details about the customer associated with the AWS Opportunity, including
        /// account information, industry, and other customer data. These details help partners
        /// understand the business context of the opportunity.
        /// </para>
        /// </summary>
        public AwsOpportunityCustomer Customer
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
        /// Gets and sets the property Insights. 
        /// <para>
        /// Provides insights into the AWS Opportunity, including engagement score and recommended
        /// actions that AWS suggests for the partner.
        /// </para>
        /// </summary>
        public AwsOpportunityInsights Insights
        {
            get { return this._insights; }
            set { this._insights = value; }
        }

        // Check to see if Insights property is set
        internal bool IsSetInsights()
        {
            return this._insights != null;
        }

        /// <summary>
        /// Gets and sets the property InvolvementType. 
        /// <para>
        /// Specifies the type of involvement AWS has in the opportunity, such as direct cosell
        /// or advisory support. This field helps partners understand the role AWS plays in advancing
        /// the opportunity.
        /// </para>
        /// </summary>
        public SalesInvolvementType InvolvementType
        {
            get { return this._involvementType; }
            set { this._involvementType = value; }
        }

        // Check to see if InvolvementType property is set
        internal bool IsSetInvolvementType()
        {
            return this._involvementType != null;
        }

        /// <summary>
        /// Gets and sets the property InvolvementTypeChangeReason. 
        /// <para>
        /// Provides a reason for any changes in the involvement type of AWS in the opportunity.
        /// This field is used to track why the level of AWS engagement has changed from <c>For
        /// Visibility Only</c> to <c>Co-sell</c> offering transparency into the partnership dynamics.
        /// </para>
        /// </summary>
        public InvolvementTypeChangeReason InvolvementTypeChangeReason
        {
            get { return this._involvementTypeChangeReason; }
            set { this._involvementTypeChangeReason = value; }
        }

        // Check to see if InvolvementTypeChangeReason property is set
        internal bool IsSetInvolvementTypeChangeReason()
        {
            return this._involvementTypeChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// Contains lifecycle information for the AWS Opportunity, including review status, stage,
        /// and target close date. This field is crucial for partners to monitor the progression
        /// of the opportunity.
        /// </para>
        /// </summary>
        public AwsOpportunityLifeCycle LifeCycle
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
        /// Gets and sets the property OpportunityTeam. 
        /// <para>
        /// Details the AWS opportunity team, including members involved. This information helps
        /// partners know who from AWS is engaged and what their role is.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsTeamMember> OpportunityTeam
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
        /// Gets and sets the property Origin. 
        /// <para>
        /// Specifies whether the AWS Opportunity originated from AWS or the partner. This helps
        /// distinguish between opportunities that were sourced by AWS and those referred by the
        /// partner.
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
        /// Gets and sets the property Project. 
        /// <para>
        /// Provides details about the project associated with the AWS Opportunity, including
        /// the customer’s business problem, expected outcomes, and project scope. This information
        /// is crucial for understanding the broader context of the opportunity.
        /// </para>
        /// </summary>
        public AwsOpportunityProject Project
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
        /// Gets and sets the property RelatedEntityIds. 
        /// <para>
        /// Lists related entity identifiers, such as AWS products or partner solutions, associated
        /// with the AWS Opportunity. These identifiers provide additional context and help partners
        /// understand which AWS services are involved.
        /// </para>
        /// </summary>
        public AwsOpportunityRelatedEntities RelatedEntityIds
        {
            get { return this._relatedEntityIds; }
            set { this._relatedEntityIds = value; }
        }

        // Check to see if RelatedEntityIds property is set
        internal bool IsSetRelatedEntityIds()
        {
            return this._relatedEntityIds != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedOpportunityId. 
        /// <para>
        /// Provides the unique identifier of the related partner opportunity, allowing partners
        /// to link the AWS Opportunity to their corresponding opportunity in their CRM system.
        /// </para>
        /// </summary>
        public string RelatedOpportunityId
        {
            get { return this._relatedOpportunityId; }
            set { this._relatedOpportunityId = value; }
        }

        // Check to see if RelatedOpportunityId property is set
        internal bool IsSetRelatedOpportunityId()
        {
            return this._relatedOpportunityId != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Defines the visibility level for the AWS Opportunity. Use <c>Full</c> visibility for
        /// most cases, while <c>Limited</c> visibility is reserved for special programs or sensitive
        /// opportunities.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}