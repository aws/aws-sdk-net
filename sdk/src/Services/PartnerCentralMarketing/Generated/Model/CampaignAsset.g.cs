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
    /// A marketing asset resource within a campaign.
    /// </summary>
    public partial class CampaignAsset
    {
        /// <summary>
        /// Gets and sets the property ActivationIssues. What must be fixed on this asset before
        /// it can be activated. Empty when the asset is ready. Issues don't block saving: an
        /// asset can be saved incomplete and fixed over several updates. `StartCampaignAssetActivationTask`
        /// refuses an asset that still has issues: an issue blocks activation when only an edit
        /// to the asset can change the outcome. Most issues name the field to fix in `FieldId`.
        /// Fix it with `UpdateCampaignAsset`, then read this list again. Besides the issues computed
        /// from the asset's content, the list carries what the last activation found: `CONTENT_REJECTED`
        /// and `PARTNER_IMAGE_REJECTED` when moderation refused a field. Editing that field removes
        /// its issue. A `CONTENT_REJECTED` without a `FieldId` means the text was refused as
        /// a whole; editing any text field removes it. Problems with the campaign's own settings,
        /// such as a missing recipient list, and with the partner's profile, such as a missing
        /// logo, are reported on `Campaign.ActivationIssues`, not here.
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
        /// Gets and sets the property CampaignId. The campaign identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;

        /// <summary>
        /// Gets and sets the property Category. The asset category.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. Creation timestamp.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeliveryStatus. What the platform did with the artifact
        /// after accepting it. EMAIL and SOCIAL_POST only — absent on every other category, which
        /// has no delivery event. See the DeliveryStatus docs.
        /// </summary>
        public DeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStatus property is set.
        /// </summary>
        internal bool IsSetDeliveryStatus() => this.DeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property DeliveryStatusReason. Why delivery failed. Present only
        /// when DeliveryStatus is FAILED. For an email the platform rejected: SENDER_EMAIL_INVALID,
        /// RECIPIENT_LIST_EMPTY, MAILING_CREDITS_EXHAUSTED or RECIPIENT_LIMIT_EXCEEDED. Otherwise
        /// DELIVERY_FAILED. A Facebook post refused because its connection has no Page is FAILED
        /// with SOCIAL_CONNECTION_PAGE_REQUIRED, and withdrawn: reconnect Facebook with a Page
        /// selected. A social post the platform stopped retrying, because it could not publish
        /// within 12 hours of its scheduled time, is FAILED with DELIVERY_FAILED. Any other social
        /// post that could not be published stays PENDING while it is investigated, and is reported
        /// FAILED with DELIVERY_FAILED once it is confirmed it will not go out. Deactivate and
        /// activate the asset again to retry.
        /// </summary>
        public CampaignAssetStateReason DeliveryStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStatusReason property is set.
        /// </summary>
        internal bool IsSetDeliveryStatusReason() => this.DeliveryStatusReason != null;

        /// <summary>
        /// Gets and sets the property FieldValues. The asset's pinned template fields — the field
        /// schema copied from the blueprint at instantiation, each paired with the partner's
        /// current value. Present on every asset instantiated from a blueprint that offers editable
        /// fields, whatever its category (design section 3.1); absent on one whose blueprint
        /// offers none.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 150)]
        public List<CampaignAssetFieldValue> FieldValues { get; set; } = AWSConfigs.InitializeCollections ? new List<CampaignAssetFieldValue>() : null;

        /// <summary>
        /// Checks to see if the FieldValues property is set.
        /// </summary>
        internal bool IsSetFieldValues() => this.FieldValues != null && (this.FieldValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FileFormat. Concrete file format of the finished artifact.
        /// For `DOWNLOAD_ONLY` this is the format of the object export copies through verbatim.
        /// </summary>
        public FileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property Id. The asset identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastActivationStatus. How the most recent hand-over to
        /// the delivery platform ended. The hand-over, not the delivery: if DG got the artifact
        /// scheduled at the platform this is SUCCEEDED, and whether the platform then delivered
        /// is `DeliveryStatus`. Per category the hand-over point is — email: the mailing armed;
        /// social: the create, which *is* the schedule; landing page: create plus publish-personalisation;
        /// document: bytes written. Read with `State` this is what separates a stopped asset
        /// (INACTIVE with SUCCEEDED here) from one never activated (INACTIVE with this member
        /// absent) — a stop does not change how the last *activation* went. There is no public
        /// UNKNOWN. A hand-over whose outcome DG cannot yet determine reports IN_PROGRESS, because
        /// a partner's action is identical either way and there is nothing to do with "unknown".
        /// Reporting it as FAILED would be the harmful collapse: that reads as safe to retry,
        /// and a retry on an at-most-once create publishes a second live object. Omitted before
        /// the first activation attempt.
        /// </summary>
        public AttemptStatus LastActivationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastActivationStatus property is set.
        /// </summary>
        internal bool IsSetLastActivationStatus() => this.LastActivationStatus != null;

        /// <summary>
        /// Gets and sets the property Layout. A multi-layout asset's layout choice (DG-044):
        /// the selection once made, and every option the asset was created with. Absent for a
        /// single-layout asset. FieldValues is always the union of every option's fields, selected
        /// or not, so a client can switch layouts without a round trip: each option lists its
        /// own FieldIds. The selection drives layout.selected and the top-level LayoutPreviews
        /// only.
        /// </summary>
        public CampaignAssetLayout Layout { get; set; }

        /// <summary>
        /// Checks to see if the Layout property is set.
        /// </summary>
        internal bool IsSetLayout() => this.Layout != null;

        /// <summary>
        /// Gets and sets the property LayoutPreviews. The asset's AWS-authored layout, as stable
        /// public CDN URLs composed from the fileKeys copied off the blueprint at instantiation.
        /// Together with FieldValues this makes the asset self-describing: a client renders the
        /// edit form and shows the real layout while editing, with no template lookup. The stored
        /// form is a bare object key and the URL is composed on read. The key is revision-addressed
        /// and prior revisions are retained, so the key IS the pin — nothing is copied into the
        /// asset bucket, and there is no version parameter to carry (DG-038). One entry for every
        /// category except LANDING_PAGE, which has two and distinguishes them with PageType.
        /// On a multi-layout asset, the SELECTED option's pages only (its first option when none
        /// is stored); each option's own previews are on layout.options.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<LayoutPreview> LayoutPreviews { get; set; } = AWSConfigs.InitializeCollections ? new List<LayoutPreview>() : null;

        /// <summary>
        /// Checks to see if the LayoutPreviews property is set.
        /// </summary>
        internal bool IsSetLayoutPreviews() => this.LayoutPreviews != null && (this.LayoutPreviews.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LinkLabel. DOCUMENT only: the words a page uses for this
        /// document, such as "eBook". Fill an `AssetLink` field's `LabelFieldId` with it when
        /// the partner picks this asset.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string LinkLabel { get; set; }

        /// <summary>
        /// Checks to see if the LinkLabel property is set.
        /// </summary>
        internal bool IsSetLinkLabel() => this.LinkLabel != null;

        /// <summary>
        /// Gets and sets the property Name. The display name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PublicUrl. The live public address this asset's activation
        /// produced. A landing page's page URL, read back from the delivery platform at activation
        /// and preserved across every convergence; a document's public CDN URL, composed on read
        /// from the key the publish wrote. Absent until the asset activates, and absent for EMAIL
        /// and SOCIAL_POST, which produce no partner-addressable URL of their own. For a landing
        /// page this is the entire deliverable — without it a partner has no way to learn where
        /// their live page is. A WIDGET landing page reports none: it is embedded rather than
        /// standalone, so absence there is expected rather than a fault.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PublicUrl { get; set; }

        /// <summary>
        /// Checks to see if the PublicUrl property is set.
        /// </summary>
        internal bool IsSetPublicUrl() => this.PublicUrl != null;

        /// <summary>
        /// Gets and sets the property ScheduledSendAt. The send time, present only when `SendMode`
        /// is `SCHEDULED`. It reaches the delivery platform at the asset's next activation. Was
        /// `scheduleDate: UtcDate`; retyped with the write member of the same name.
        /// </summary>
        public DateTime? ScheduledSendAt { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledSendAt property is set.
        /// </summary>
        internal bool IsSetScheduledSendAt() => this.ScheduledSendAt.HasValue;

        /// <summary>
        /// Gets and sets the property SendMode. When this asset sends, as chosen with UpdateCampaignAsset.
        /// `EMAIL` and `SOCIAL_POST` only — the two categories whose delivery platform holds
        /// a schedule of its own. Absent until chosen, and then the asset reports `SEND_MODE_MISSING`.
        /// </summary>
        public SendMode SendMode { get; set; }

        /// <summary>
        /// Checks to see if the SendMode property is set.
        /// </summary>
        internal bool IsSetSendMode() => this.SendMode != null;

        /// <summary>
        /// Gets and sets the property SocialPlatform. SOCIAL_POST only: the platform the post
        /// goes to, set from its template and never writable. The same value `CampaignAssetSummary.SocialPlatform`
        /// reports. Absent for every other category.
        /// </summary>
        public Platform SocialPlatform { get; set; }

        /// <summary>
        /// Checks to see if the SocialPlatform property is set.
        /// </summary>
        internal bool IsSetSocialPlatform() => this.SocialPlatform != null;

        /// <summary>
        /// Gets and sets the property SourceAssetTemplateId. The asset template this asset was
        /// created from: the `SourceAssetTemplateIdentifier` its `BatchCreateCampaignAsset` entry
        /// named, one of `GetCampaignTemplate`'s `CampaignTemplate.AssetTemplates[].Id`. Set
        /// at create and never writable. Absent on an asset created before DG recorded it, which
        /// can't be activated either. A campaign holds at most one asset per asset template,
        /// so this is how a client matches a campaign's assets to its template's asset templates,
        /// for example to create the same assets in another campaign. Names don't identify one:
        /// two asset templates can share a name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SourceAssetTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAssetTemplateId property is set.
        /// </summary>
        internal bool IsSetSourceAssetTemplateId() => this.SourceAssetTemplateId != null;

        /// <summary>
        /// Gets and sets the property State. Whether the asset is live. Reports current truth
        /// only, and nothing else on this shape overrides it. During an *initial* publication
        /// it stays INACTIVE until the delivery platform holds the object; during a *re*-publication
        /// it stays ACTIVE, because the previously published content is still serving. A stopped
        /// asset and one never started both read INACTIVE; `LastActivationStatus` tells them
        /// apart, because a stop does not change how the last activation went — stopped is INACTIVE
        /// with that member `SUCCEEDED`, never started is INACTIVE with it absent. An update
        /// never moves this member.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

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
