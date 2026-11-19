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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// A marketing campaign resource.
    /// </summary>
    public partial class Campaign
    {
        /// <summary>
        /// Gets and sets the property ActivationIssues. Campaign settings that must be set before
        /// the assets listed in each issue can be activated. Empty when nothing is missing. Each
        /// issue names the setting in `CampaignSetting` — set it with `UpdateCampaign` — or the
        /// profile value in `PartnerProfileField` — set it in Partner Central — and the assets
        /// it blocks in `AffectedAssetIds`. `StartCampaignAssetActivationTask` refuses with `ValidationException`
        /// (`CAMPAIGN_INCOMPLETE`) while a requested asset is affected.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 150)]
        public List<ActivationIssue> ActivationIssues { get; set; } = AWSConfigs.InitializeCollections ? new List<ActivationIssue>() : null;

        /// <summary>
        /// Checks to see if the ActivationIssues property is set.
        /// </summary>
        internal bool IsSetActivationIssues() => this.ActivationIssues != null && (this.ActivationIssues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. The campaign ARN.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CampaignId. The campaign identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;

        /// <summary>
        /// Gets and sets the property CampaignTemplateId. The campaign template this campaign
        /// draws its assets from. Set at create, immutable.
        /// </summary>
        [AWSProperty(Min = 18, Max = 18)]
        public string CampaignTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignTemplateId property is set.
        /// </summary>
        internal bool IsSetCampaignTemplateId() => this.CampaignTemplateId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. Creation timestamp.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EmailTarget. The attached recipient list — metadata only.
        /// There is no read path for the addresses.
        /// </summary>
        public EmailTargetDetail EmailTarget { get; set; }

        /// <summary>
        /// Checks to see if the EmailTarget property is set.
        /// </summary>
        internal bool IsSetEmailTarget() => this.EmailTarget != null;

        /// <summary>
        /// Gets and sets the property EmailTargetEngagementGroupIds. The engagement groups set
        /// by `CreateCampaign` / `UpdateCampaign`. Absent until set. Resolved to recipients at
        /// Start, where the stage can.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> EmailTargetEngagementGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EmailTargetEngagementGroupIds property is set.
        /// </summary>
        internal bool IsSetEmailTargetEngagementGroupIds() => this.EmailTargetEngagementGroupIds != null && (this.EmailTargetEngagementGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndOn. The last day of the campaign's run window.
        /// </summary>
        public string EndOn { get; set; }

        /// <summary>
        /// Checks to see if the EndOn property is set.
        /// </summary>
        internal bool IsSetEndOn() => this.EndOn != null;

        /// <summary>
        /// Gets and sets the property EstimatedBudget. What the partner expects the campaign
        /// to cost.
        /// </summary>
        public MonetaryValue EstimatedBudget { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedBudget property is set.
        /// </summary>
        internal bool IsSetEstimatedBudget() => this.EstimatedBudget != null;

        /// <summary>
        /// Gets and sets the property Language. The language the campaign's assets are written
        /// and typeset in: its template's `LanguageCode`, set at create. To work in another language,
        /// create the campaign from that language's template.
        /// </summary>
        public AssetLanguage Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Name. The display name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PartnerAddress. The partner's postal address. Absent until
        /// one is set.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string PartnerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PartnerAddress property is set.
        /// </summary>
        internal bool IsSetPartnerAddress() => this.PartnerAddress != null;

        /// <summary>
        /// Gets and sets the property PartnerBadge. The partner's badge. Absent until one is
        /// set, and every badge slot shows the Standalone AWS Partner badge while the partner's
        /// primary AWS Partner path is at stage Validated or Differentiated. Below that, no badge
        /// is shown.
        /// </summary>
        public PartnerBadgeDetail PartnerBadge { get; set; }

        /// <summary>
        /// Checks to see if the PartnerBadge property is set.
        /// </summary>
        internal bool IsSetPartnerBadge() => this.PartnerBadge != null;

        /// <summary>
        /// Gets and sets the property PartnerProfile. The partner's branding — display name,
        /// website and logo — from their AWS Partner Central profile, rendered onto every asset
        /// of this campaign. Read-only here: the partner edits it in Partner Central, and the
        /// next activation or export uses the change. Absent only when the partner has no profile.
        /// </summary>
        public PartnerProfileBranding PartnerProfile { get; set; }

        /// <summary>
        /// Checks to see if the PartnerProfile property is set.
        /// </summary>
        internal bool IsSetPartnerProfile() => this.PartnerProfile != null;

        /// <summary>
        /// Gets and sets the property PrivacyPolicyUrl. The URL of the partner's privacy policy.
        /// Absent until one is set.
        /// </summary>
        [AWSProperty(Min = 9, Max = 2048)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyPolicyUrl property is set.
        /// </summary>
        internal bool IsSetPrivacyPolicyUrl() => this.PrivacyPolicyUrl != null;

        /// <summary>
        /// Gets and sets the property SenderEmail. The address the campaign's emails are sent
        /// from. Absent until one is set.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 254)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Checks to see if the SenderEmail property is set.
        /// </summary>
        internal bool IsSetSenderEmail() => this.SenderEmail != null;

        /// <summary>
        /// Gets and sets the property SocialConnections. The account the campaign's social posts
        /// publish from, per platform, as set by `UpdateCampaign`. Absent until one is set. 
        /// &lt;para&gt;
        /// Needed only for a platform where you hold two or more connections. With none set,
        /// a post uses your one connection on its platform, and fails `SOCIAL_CONNECTION_NOT_CHOSEN`
        /// when you hold several. A choice that no longer names a connection on its platform
        /// fails `SOCIAL_CONNECTION_MISSING`. Join with `ListSocialConnections` for each connection's
        /// status.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> SocialConnections { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the SocialConnections property is set.
        /// </summary>
        internal bool IsSetSocialConnections() => this.SocialConnections != null && (this.SocialConnections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartOn. The first day of the campaign's run window.
        /// </summary>
        public string StartOn { get; set; }

        /// <summary>
        /// Checks to see if the StartOn property is set.
        /// </summary>
        internal bool IsSetStartOn() => this.StartOn != null;

        /// <summary>
        /// Gets and sets the property State. The campaign's state, derived on every read from
        /// `EndOn` and its assets. See `CampaignState`.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TargetAudience. Target audience configuration.
        /// </summary>
        public TargetAudience TargetAudience { get; set; }

        /// <summary>
        /// Checks to see if the TargetAudience property is set.
        /// </summary>
        internal bool IsSetTargetAudience() => this.TargetAudience != null;

        /// <summary>
        /// Gets and sets the property TotalBudget. The campaign's total budget.
        /// </summary>
        public MonetaryValue TotalBudget { get; set; }

        /// <summary>
        /// Checks to see if the TotalBudget property is set.
        /// </summary>
        internal bool IsSetTotalBudget() => this.TotalBudget != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. Last update timestamp.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
