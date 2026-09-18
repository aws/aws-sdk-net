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
    /// A workload return object.
    /// </summary>
    public partial class Workload
    {
        /// <summary>
        /// Gets and sets the property AccountIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// List of AppRegistry application ARNs associated to the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> Applications { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null && (this.Applications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ArchitecturalDesign.
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string ArchitecturalDesign { get; set; }

        /// <summary>
        /// Checks to see if the ArchitecturalDesign property is set.
        /// </summary>
        internal bool IsSetArchitecturalDesign() => this.ArchitecturalDesign != null;

        /// <summary>
        /// Gets and sets the property AwsRegions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> AwsRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsRegions property is set.
        /// </summary>
        internal bool IsSetAwsRegions() => this.AwsRegions != null && (this.AwsRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 3, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiscoveryConfig. 
        /// <para>
        /// Discovery configuration associated to the workload.
        /// </para>
        /// </summary>
        public WorkloadDiscoveryConfig DiscoveryConfig { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryConfig property is set.
        /// </summary>
        internal bool IsSetDiscoveryConfig() => this.DiscoveryConfig != null;

        /// <summary>
        /// Gets and sets the property Environment.
        /// </summary>
        public WorkloadEnvironment Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property ImprovementStatus.
        /// </summary>
        public WorkloadImprovementStatus ImprovementStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImprovementStatus property is set.
        /// </summary>
        internal bool IsSetImprovementStatus() => this.ImprovementStatus != null;

        /// <summary>
        /// Gets and sets the property Industry.
        /// </summary>
        [AWSProperty(Max = 100)]
        public string Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property IndustryType.
        /// </summary>
        [AWSProperty(Max = 100)]
        public string IndustryType { get; set; }

        /// <summary>
        /// Checks to see if the IndustryType property is set.
        /// </summary>
        internal bool IsSetIndustryType() => this.IndustryType != null;

        /// <summary>
        /// Gets and sets the property IsReviewOwnerUpdateAcknowledged. 
        /// <para>
        /// Flag indicating whether the workload owner has acknowledged that the <i>Review owner</i>
        /// field is required.
        /// </para>
        ///  
        /// <para>
        /// If a <b>Review owner</b> is not added to the workload within 60 days of acknowledgement,
        /// access to the workload is restricted until an owner is added.
        /// </para>
        /// </summary>
        public bool? IsReviewOwnerUpdateAcknowledged { get; set; }

        /// <summary>
        /// Checks to see if the IsReviewOwnerUpdateAcknowledged property is set.
        /// </summary>
        internal bool IsSetIsReviewOwnerUpdateAcknowledged() => this.IsReviewOwnerUpdateAcknowledged.HasValue;

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Jira configuration for a specific workload.
        /// </para>
        /// </summary>
        public WorkloadJiraConfigurationOutput JiraConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the JiraConfiguration property is set.
        /// </summary>
        internal bool IsSetJiraConfiguration() => this.JiraConfiguration != null;

        /// <summary>
        /// Gets and sets the property Lenses.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Lenses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Lenses property is set.
        /// </summary>
        internal bool IsSetLenses() => this.Lenses != null && (this.Lenses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NonAwsRegions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<string> NonAwsRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NonAwsRegions property is set.
        /// </summary>
        internal bool IsSetNonAwsRegions() => this.NonAwsRegions != null && (this.NonAwsRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Notes.
        /// </summary>
        [AWSProperty(Max = 2084)]
        public string Notes { get; set; }

        /// <summary>
        /// Checks to see if the Notes property is set.
        /// </summary>
        internal bool IsSetNotes() => this.Notes != null;

        /// <summary>
        /// Gets and sets the property Owner.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property PillarPriorities.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PillarPriorities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PillarPriorities property is set.
        /// </summary>
        internal bool IsSetPillarPriorities() => this.PillarPriorities != null && (this.PillarPriorities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrioritizedRiskCounts.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> PrioritizedRiskCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the PrioritizedRiskCounts property is set.
        /// </summary>
        internal bool IsSetPrioritizedRiskCounts() => this.PrioritizedRiskCounts != null && (this.PrioritizedRiskCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// Profile associated with a workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<WorkloadProfile> Profiles { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkloadProfile>() : null;

        /// <summary>
        /// Checks to see if the Profiles property is set.
        /// </summary>
        internal bool IsSetProfiles() => this.Profiles != null && (this.Profiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReviewOwner.
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string ReviewOwner { get; set; }

        /// <summary>
        /// Checks to see if the ReviewOwner property is set.
        /// </summary>
        internal bool IsSetReviewOwner() => this.ReviewOwner != null;

        /// <summary>
        /// Gets and sets the property ReviewRestrictionDate. 
        /// <para>
        /// The review restriction date for the workload.
        /// </para>
        /// </summary>
        public DateTime? ReviewRestrictionDate { get; set; }

        /// <summary>
        /// Checks to see if the ReviewRestrictionDate property is set.
        /// </summary>
        internal bool IsSetReviewRestrictionDate() => this.ReviewRestrictionDate.HasValue;

        /// <summary>
        /// Gets and sets the property RiskCounts.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> RiskCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the RiskCounts property is set.
        /// </summary>
        internal bool IsSetRiskCounts() => this.RiskCounts != null && (this.RiskCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShareInvitationId. 
        /// <para>
        /// The ID assigned to the share invitation.
        /// </para>
        /// </summary>
        public string ShareInvitationId { get; set; }

        /// <summary>
        /// Checks to see if the ShareInvitationId property is set.
        /// </summary>
        internal bool IsSetShareInvitationId() => this.ShareInvitationId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the workload was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WorkloadArn.
        /// </summary>
        public string WorkloadArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadArn property is set.
        /// </summary>
        internal bool IsSetWorkloadArn() => this.WorkloadArn != null;

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
