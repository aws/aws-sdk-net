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
    /// A curated summary view of an opportunity returned by a search. It holds the fields
    /// needed to render a search result row, take action, and run follow-up filters.
    /// </summary>
    public partial class OpportunitySearchSummary
    {
        /// <summary>
        /// Gets and sets the property AwsOpportunitySummary. 
        /// <para>
        /// The AWS-side view of this opportunity. Absent when no AWS opportunity summary record
        /// exists yet.
        /// </para>
        /// </summary>
        public OpportunitySearchAwsSummary AwsOpportunitySummary { get; set; }

        /// <summary>
        /// Checks to see if the AwsOpportunitySummary property is set.
        /// </summary>
        internal bool IsSetAwsOpportunitySummary() => this.AwsOpportunitySummary != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the opportunity was created, in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// A curated customer view: company name, industry, AWS account, and country.
        /// </para>
        /// </summary>
        public OpportunitySearchCustomer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The read-only, system-generated unique identifier of the opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the opportunity was last modified, in UTC.
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
        /// A curated lifecycle view: review status, stage, next steps, and target close date.
        /// </para>
        /// </summary>
        public OpportunitySearchLifeCycle LifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycle property is set.
        /// </summary>
        internal bool IsSetLifeCycle() => this.LifeCycle != null;

        /// <summary>
        /// Gets and sets the property OpportunityTeam. 
        /// <para>
        /// The opportunity owner and team members. Search results include only each member's
        /// name and business title, and exclude contact email and phone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<OpportunitySearchTeamMember> OpportunityTeam { get; set; } = AWSConfigs.InitializeCollections ? new List<OpportunitySearchTeamMember>() : null;

        /// <summary>
        /// Checks to see if the OpportunityTeam property is set.
        /// </summary>
        internal bool IsSetOpportunityTeam() => this.OpportunityTeam != null && (this.OpportunityTeam.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OpportunityType. 
        /// <para>
        /// Specifies whether the opportunity is a new business opportunity, a renewal, or an
        /// expansion.
        /// </para>
        /// </summary>
        public OpportunityType OpportunityType { get; set; }

        /// <summary>
        /// Checks to see if the OpportunityType property is set.
        /// </summary>
        internal bool IsSetOpportunityType() => this.OpportunityType != null;

        /// <summary>
        /// Gets and sets the property PartnerOpportunityIdentifier. 
        /// <para>
        /// The unique identifier of the opportunity in your customer relationship management
        /// (CRM) system. This value lets you link the opportunity to your CRM.
        /// </para>
        /// </summary>
        public string PartnerOpportunityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PartnerOpportunityIdentifier property is set.
        /// </summary>
        internal bool IsSetPartnerOpportunityIdentifier() => this.PartnerOpportunityIdentifier != null;

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// A curated project view: title, AWS Partner Network (APN) programs, and expected customer
        /// spend.
        /// </para>
        /// </summary>
        public OpportunitySearchProject Project { get; set; }

        /// <summary>
        /// Checks to see if the Project property is set.
        /// </summary>
        internal bool IsSetProject() => this.Project != null;

        /// <summary>
        /// Gets and sets the property RelatedEntityIdentifiers. 
        /// <para>
        /// Curated related-entity identifiers surfaced in search: AWS Marketplace offers, offer
        /// sets, and solutions.
        /// </para>
        /// </summary>
        public OpportunitySearchRelatedEntityIdentifiers RelatedEntityIdentifiers { get; set; }

        /// <summary>
        /// Checks to see if the RelatedEntityIdentifiers property is set.
        /// </summary>
        internal bool IsSetRelatedEntityIdentifiers() => this.RelatedEntityIdentifiers != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the opportunity, returned as key-value pairs.
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
