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
    /// Container for the parameters to the UpdateCampaign operation. Edits a campaign in
    /// place. Partial update: an omitted field is left unchanged, which is the standard meaning
    /// of an `Update` verb — a full replacement would be a `Put`. Change-only, with no way
    /// to clear a field back to empty, because the campaign's file members cannot round-trip:
    /// they are written as an `s3://` reference and read back as a URL or as metadata, so
    /// a replacement payload could not resend an unchanged recipient list without re-uploading
    /// it. Refused while an activation task runs (`CAMPAIGN_ACTIVATION_IN_PROGRESS`) and
    /// once the campaign is completed (`CAMPAIGN_COMPLETED`, the UTC date is after its `EndOn`).
    /// Last-writer-wins, with no concurrency token: this is low-contention metadata owned
    /// by one partner.
    /// </summary>
    public partial class UpdateCampaignRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignIdentifier. The campaign identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 200)]
        public string CampaignIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CampaignIdentifier property is set.
        /// </summary>
        internal bool IsSetCampaignIdentifier() => this.CampaignIdentifier != null;

        /// <summary>
        /// Gets and sets the property Catalog. The catalog (AWS or Sandbox).
        /// </summary>
        [AWSProperty(Required = true)]
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. Idempotency token. Accepted and not stored:
        /// this is a change-only partial update with last-writer-wins, so re-applying the same
        /// call produces the same result and the same response. There is nothing a replay cache
        /// would protect.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EmailTarget. Replaces the campaign's attached recipient
        /// list. 
        /// &lt;para&gt;
        /// The referenced object is copied and pinned again on every call that supplies it, so
        /// the pinned copy always reflects the *last* `UpdateCampaign` that named one. Editing
        /// the source object in your own bucket without calling this operation again has no effect.
        /// 
        /// &lt;para&gt;
        /// Replaces, never detaches: a partner can swap the list but cannot remove it.
        /// </summary>
        public FileRef EmailTarget { get; set; }

        /// <summary>
        /// Checks to see if the EmailTarget property is set.
        /// </summary>
        internal bool IsSetEmailTarget() => this.EmailTarget != null;

        /// <summary>
        /// Gets and sets the property EmailTargetEngagementGroupIds. Engagement groups whose
        /// contacts the campaign's emails will also go to (see `CreateCampaign`). Replaces the
        /// stored list; never clears it. 
        /// &lt;para&gt;
        /// As on `CreateCampaign`: each group once (`INVALID_VALUE` otherwise), not checked against
        /// your groups when saved, and resolved at Start where the stage can (`ENGAGEMENT_GROUPS_UNAVAILABLE`
        /// where it can't).
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
        /// Gets and sets the property EndOn. The last day of the campaign's run window, inclusive
        /// and in UTC. Editable only while the campaign is open, like everything else here: once
        /// the stored `EndOn` has passed the campaign is completed and this update is refused
        /// (`CAMPAIGN_COMPLETED`). Refused with `ValidationException` (`INVALID_VALUE`) when
        /// it is in the past, or earlier than the day of a scheduled send on one of the campaign's
        /// assets: move or cancel that send first. Setting it to today ends the campaign at the
        /// next UTC midnight.
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
        /// Gets and sets the property Name. The display name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PartnerAddress. Sets or replaces the partner's postal address.
        /// Replaces, never clears.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string PartnerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PartnerAddress property is set.
        /// </summary>
        internal bool IsSetPartnerAddress() => this.PartnerAddress != null;

        /// <summary>
        /// Gets and sets the property PartnerBadge. Sets or replaces the partner's badge, checked
        /// exactly as on `CreateCampaign`. Replaces, never clears: upload the Standalone AWS
        /// Partner badge to show it again. The badge an asset already published keeps showing
        /// on it until that asset is activated again.
        /// </summary>
        public FileRef PartnerBadge { get; set; }

        /// <summary>
        /// Checks to see if the PartnerBadge property is set.
        /// </summary>
        internal bool IsSetPartnerBadge() => this.PartnerBadge != null;

        /// <summary>
        /// Gets and sets the property PrivacyPolicyUrl. Sets or replaces the URL of the partner's
        /// privacy policy. Replaces, never clears.
        /// </summary>
        [AWSProperty(Min = 9, Max = 2048)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyPolicyUrl property is set.
        /// </summary>
        internal bool IsSetPrivacyPolicyUrl() => this.PrivacyPolicyUrl != null;

        /// <summary>
        /// Gets and sets the property SenderEmail. Sets or replaces the address the campaign's
        /// emails are sent from. Checked by the same three rules as on `CreateCampaign`, with
        /// the same codes, but only when it differs, ignoring case, from the stored sender: re-sending
        /// the stored one is not checked, and `StartCampaignAssetActivationTask` re-checks it
        /// before an email activates. 
        /// &lt;para&gt;
        /// Replaces, never clears: like every member of this operation, an omitted value leaves
        /// the sender as it was, and there is no way to remove one once set.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 254)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Checks to see if the SenderEmail property is set.
        /// </summary>
        internal bool IsSetSenderEmail() => this.SenderEmail != null;

        /// <summary>
        /// Gets and sets the property SocialConnections. Sets the account the campaign's social
        /// posts publish from, per platform. Each platform named replaces that platform's choice;
        /// a platform not named keeps its own. Replaces, never clears. 
        /// &lt;para&gt;
        /// Not checked against your connections here: a connection can be deleted at any time,
        /// so the activation checks the choice. See `Campaign$SocialConnections`.
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
        /// Gets and sets the property StartOn. The first day of the campaign's run window. Not
        /// after `EndOn` (`ValidationException`, `INVALID_VALUE`).
        /// </summary>
        public string StartOn { get; set; }

        /// <summary>
        /// Checks to see if the StartOn property is set.
        /// </summary>
        internal bool IsSetStartOn() => this.StartOn != null;

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
    }
}
