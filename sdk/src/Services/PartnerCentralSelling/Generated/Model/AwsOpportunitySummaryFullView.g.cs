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
    /// Provides a comprehensive view of AwsOpportunitySummaryFullView template.
    /// </summary>
    public partial class AwsOpportunitySummaryFullView
    {
        /// <summary>
        /// Gets and sets the property CosellMotion. 
        /// <para>
        /// Engagement classification for this opportunity. Read-only. Null before scoring. Known
        /// values: <c>AWS Field-engaged</c>, <c>Agent-engaged</c>, <c>Partner-led</c>.
        /// </para>
        /// </summary>
        public string CosellMotion { get; set; }

        /// <summary>
        /// Checks to see if the CosellMotion property is set.
        /// </summary>
        internal bool IsSetCosellMotion() => this.CosellMotion != null;

        /// <summary>
        /// Gets and sets the property Customer.
        /// </summary>
        public AwsOpportunityCustomer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property Insights.
        /// </summary>
        public AwsOpportunityInsights Insights { get; set; }

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null;

        /// <summary>
        /// Gets and sets the property InvolvementType. 
        /// <para>
        /// Type of AWS involvement in the opportunity.
        /// </para>
        /// </summary>
        public SalesInvolvementType InvolvementType { get; set; }

        /// <summary>
        /// Checks to see if the InvolvementType property is set.
        /// </summary>
        internal bool IsSetInvolvementType() => this.InvolvementType != null;

        /// <summary>
        /// Gets and sets the property InvolvementTypeChangeReason. 
        /// <para>
        /// Reason for changes in AWS involvement type for the opportunity.
        /// </para>
        /// </summary>
        public InvolvementTypeChangeReason InvolvementTypeChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the InvolvementTypeChangeReason property is set.
        /// </summary>
        internal bool IsSetInvolvementTypeChangeReason() => this.InvolvementTypeChangeReason != null;

        /// <summary>
        /// Gets and sets the property LifeCycle.
        /// </summary>
        public AwsOpportunityLifeCycle LifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycle property is set.
        /// </summary>
        internal bool IsSetLifeCycle() => this.LifeCycle != null;

        /// <summary>
        /// Gets and sets the property OpportunityTeam. 
        /// <para>
        /// AWS team members involved in the opportunity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsTeamMember> OpportunityTeam { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsTeamMember>() : null;

        /// <summary>
        /// Checks to see if the OpportunityTeam property is set.
        /// </summary>
        internal bool IsSetOpportunityTeam() => this.OpportunityTeam != null && (this.OpportunityTeam.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// Source origin of the AWS opportunity.
        /// </para>
        /// </summary>
        public OpportunityOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property Project.
        /// </summary>
        public AwsOpportunityProject Project { get; set; }

        /// <summary>
        /// Checks to see if the Project property is set.
        /// </summary>
        internal bool IsSetProject() => this.Project != null;

        /// <summary>
        /// Gets and sets the property RelatedEntityIds.
        /// </summary>
        public AwsOpportunityRelatedEntities RelatedEntityIds { get; set; }

        /// <summary>
        /// Checks to see if the RelatedEntityIds property is set.
        /// </summary>
        internal bool IsSetRelatedEntityIds() => this.RelatedEntityIds != null;

        /// <summary>
        /// Gets and sets the property RelatedOpportunityId. 
        /// <para>
        /// Identifier of the related partner opportunity.
        /// </para>
        /// </summary>
        public string RelatedOpportunityId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedOpportunityId property is set.
        /// </summary>
        internal bool IsSetRelatedOpportunityId() => this.RelatedOpportunityId != null;

        /// <summary>
        /// Gets and sets the property SoftwareRevenue. 
        /// <para>
        /// Seller-provided PARC deal terms: commitment value, discount, and contract dates.
        /// </para>
        /// </summary>
        public AwsSoftwareRevenue SoftwareRevenue { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareRevenue property is set.
        /// </summary>
        internal bool IsSetSoftwareRevenue() => this.SoftwareRevenue != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Visibility level for the AWS opportunity.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
