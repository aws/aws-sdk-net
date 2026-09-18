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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// This is the response object from the GetAgentRecommendation operation.
    /// </summary>
    public partial class GetAgentRecommendationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications that the recommendation targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Applications { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null && (this.Applications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsServices. 
        /// <para>
        /// The Amazon Web Services services that the recommendation applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsServices property is set.
        /// </summary>
        internal bool IsSetAwsServices() => this.AwsServices != null && (this.AwsServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BusinessUnits. 
        /// <para>
        /// The business units that own the affected resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BusinessUnits { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BusinessUnits property is set.
        /// </summary>
        internal bool IsSetBusinessUnits() => this.BusinessUnits != null && (this.BusinessUnits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the recommendation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user or system that created this recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CrossPillarBenefits. 
        /// <para>
        /// Cross-pillar benefits of acting on the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CrossPillarBenefit> CrossPillarBenefits { get; set; } = AWSConfigs.InitializeCollections ? new List<CrossPillarBenefit>() : null;

        /// <summary>
        /// Checks to see if the CrossPillarBenefits property is set.
        /// </summary>
        internal bool IsSetCrossPillarBenefits() => this.CrossPillarBenefits != null && (this.CrossPillarBenefits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 80, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Effort. 
        /// <para>
        /// The effort required to implement the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Effort Effort { get; set; }

        /// <summary>
        /// Checks to see if the Effort property is set.
        /// </summary>
        internal bool IsSetEffort() => this.Effort != null;

        /// <summary>
        /// Gets and sets the property Goals. 
        /// <para>
        /// Goals that this recommendation targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationGoal> Goals { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendationGoal>() : null;

        /// <summary>
        /// Checks to see if the Goals property is set.
        /// </summary>
        internal bool IsSetGoals() => this.Goals != null && (this.Goals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Highlights. 
        /// <para>
        /// Highlights describing what was detected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<string> Highlights { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Highlights property is set.
        /// </summary>
        internal bool IsSetHighlights() => this.Highlights != null && (this.Highlights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The severity of the recommendation's impact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImpactCategory Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact != null;

        /// <summary>
        /// Gets and sets the property ImpactDetails. 
        /// <para>
        /// Detailed impact information for the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 3)]
        public List<string> ImpactDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactDetails property is set.
        /// </summary>
        internal bool IsSetImpactDetails() => this.ImpactDetails != null && (this.ImpactDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// A list of insights about the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<Insight> Insights { get; set; } = AWSConfigs.InitializeCollections ? new List<Insight>() : null;

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null && (this.Insights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The timestamp when the recommendation was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The identifier of the user or system that last modified this recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property NumberOfResources. 
        /// <para>
        /// The number of Amazon Web Services resources this recommendation affects.
        /// </para>
        /// </summary>
        public int? NumberOfResources { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfResources property is set.
        /// </summary>
        internal bool IsSetNumberOfResources() => this.NumberOfResources.HasValue;

        /// <summary>
        /// Gets and sets the property Pillar. 
        /// <para>
        /// The Well-Architected Tool Framework pillar that the recommendation addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Pillar Pillar { get; set; }

        /// <summary>
        /// Checks to see if the Pillar property is set.
        /// </summary>
        internal bool IsSetPillar() => this.Pillar != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Priority Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileArn property is set.
        /// </summary>
        internal bool IsSetProfileArn() => this.ProfileArn != null;

        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RecommendationArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationArn property is set.
        /// </summary>
        internal bool IsSetRecommendationArn() => this.RecommendationArn != null;

        /// <summary>
        /// Gets and sets the property RemediationSummary. 
        /// <para>
        /// A high-level summary of the recommended remediation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationSummary RemediationSummary { get; set; }

        /// <summary>
        /// Checks to see if the RemediationSummary property is set.
        /// </summary>
        internal bool IsSetRemediationSummary() => this.RemediationSummary != null;

        /// <summary>
        /// Gets and sets the property Remediations. 
        /// <para>
        /// A list of remediations for the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentRecommendationRemediation> Remediations { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentRecommendationRemediation>() : null;

        /// <summary>
        /// Checks to see if the Remediations property is set.
        /// </summary>
        internal bool IsSetRemediations() => this.Remediations != null && (this.Remediations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Roi. 
        /// <para>
        /// The return on investment estimate for the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Roi Roi { get; set; }

        /// <summary>
        /// Checks to see if the Roi property is set.
        /// </summary>
        internal bool IsSetRoi() => this.Roi != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Sources that generated this recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key-value pairs associated with the recommendation, used for cost allocation
        /// and access control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 3, Max = 120)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property TradeOffs. 
        /// <para>
        /// Trade-offs of acting on the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TradeOff> TradeOffs { get; set; } = AWSConfigs.InitializeCollections ? new List<TradeOff>() : null;

        /// <summary>
        /// Checks to see if the TradeOffs property is set.
        /// </summary>
        internal bool IsSetTradeOffs() => this.TradeOffs != null && (this.TradeOffs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdateReason. 
        /// <para>
        /// The free-text reason associated with the recommendation's most recent status update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string UpdateReason { get; set; }

        /// <summary>
        /// Checks to see if the UpdateReason property is set.
        /// </summary>
        internal bool IsSetUpdateReason() => this.UpdateReason != null;
    }
}
