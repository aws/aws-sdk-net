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
    /// Container for the parameters to the CreateCampaign operation. Creates a new marketing
    /// campaign. Returns the identity of the new campaign, not the campaign. Growing a response
    /// is backward compatible and shrinking one is not, and the caller's next step is a `GetCampaign`
    /// anyway — a write that supplies an audience cannot report its scan verdict, because
    /// that is decided after it commits.
    /// </summary>
    public partial class CreateCampaignRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignTemplateId. The campaign template this campaign
        /// draws its assets from. 
        /// &lt;para&gt;
        /// Binds the campaign to a single source template: every asset must come from this template's
        /// asset templates, and one from another template is refused at `BatchCreateCampaignAsset`.
        /// Immutable once set. Every campaign has one: a campaign's language and its assets'
        /// blueprints both come from its template. 
        /// &lt;para&gt;
        /// Templates are AWS-authored and read-only — they are discovered through `SearchCampaignTemplates`
        /// and `GetCampaignTemplate`, and there is no create, update or delete operation for
        /// one. 
        /// &lt;para&gt;
        /// The template's id only: a campaign template has no ARN (DG-084). The member keeps
        /// the `&lt;Resource&gt;Id` name, which is the convention for referencing another resource
        /// from a body.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string CampaignTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignTemplateId property is set.
        /// </summary>
        internal bool IsSetCampaignTemplateId() => this.CampaignTemplateId != null;

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
        /// Gets and sets the property ClientToken. Idempotency token. Same token within 24h returns
        /// existing resource.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EmailTarget. The campaign's send audience — a CSV of recipient
        /// email addresses. 
        /// &lt;para&gt;
        /// The campaign's *target*: who the campaign is sent to, as distinct from a `CampaignAsset`,
        /// which is the content that is sent. It sits on the campaign and not on the activation
        /// call because a partner assembles it in the same wizard flow that sets the name and
        /// the dates — and because attaching it here means it is validated, staged and resolved
        /// to a count before anything is activated, rather than at the last click. 
        /// &lt;para&gt;
        /// Required format: a header row naming the email column `Email`, `E-mail`, `Email Address`
        /// or `E-mail Address` — compared without case, spaces or punctuation. Other columns
        /// are permitted and ignored, and with two email columns the first is used. A file without
        /// such a header is refused with field code `EMAIL_COLUMN_MISSING`: the address column
        /// is never guessed. The rows reach the delivery platform's importer as the partner wrote
        /// them — a partner's audience is never rewritten. 
        /// &lt;para&gt;
        /// At most 5 MB, checked against the object's size before anything is copied, and at
        /// most 10,000 distinct addresses, refused with `RECIPIENT_LIST_TOO_LARGE`. A file with
        /// no valid address at all is refused with `RECIPIENT_LIST_EMPTY`; otherwise rows without
        /// a usable address are not a refusal: they are skipped and counted, and `GetCampaign`
        /// reports the counts. Optional here, because a campaign is a container and holds no
        /// state to be incomplete in — but an email asset cannot be activated without it, so
        /// the requirement moved to the point of activation. 
        /// &lt;para&gt;
        /// Editable at any time, and an edit reaches the delivery platform only when an asset
        /// is activated after it. Each email activation loads the audience into a contact list
        /// of its own, so an address taken off the file is not sent to by the next activation.
        /// 
        /// &lt;para&gt;
        /// The bytes are write-only. No response returns a URL or an `S3Uri` for this file; `GetCampaign`
        /// returns the scan verdict, when the list was attached and how its rows resolved, and
        /// nothing more.
        /// </summary>
        public FileRef EmailTarget { get; set; }

        /// <summary>
        /// Checks to see if the EmailTarget property is set.
        /// </summary>
        internal bool IsSetEmailTarget() => this.EmailTarget != null;

        /// <summary>
        /// Gets and sets the property EmailTargetEngagementGroupIds. Engagement groups whose
        /// contacts the campaign's emails will also go to: the `Id`s `ListEngagementGroups` returns
        /// (AWS Partner Central Selling). 1–10, each named once. 
        /// &lt;para&gt;
        /// Each group is named once: a repeated id is refused with field code `INVALID_VALUE`.
        /// Not checked against your groups when saved. StartCampaignAssetActivationTask resolves
        /// them to recipients. On a stage that can't resolve groups yet, Start refuses an email
        /// while groups are set (`ENGAGEMENT_GROUPS_UNAVAILABLE`), rather than send to `EmailTarget`
        /// alone.
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
        /// and in UTC. Not in the past: the campaign completes at the UTC midnight after it (see
        /// `CampaignState`). A scheduled send must fall on or before it. Optional here, but required
        /// before any asset activates: until it is set, GetCampaign's `ActivationIssues` reports
        /// `END_ON_MISSING` and StartCampaignAssetActivationTask refuses (`CAMPAIGN_INCOMPLETE`).
        /// Set it with UpdateCampaign.
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
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PartnerAddress. The partner's physical postal address,
        /// shown in every email footer and as a landing page's contact line. Optional here: an
        /// email that shows it cannot activate until one is set. A landing page that shows it
        /// publishes it empty when it is unset, and a document's footer then prints the partner's
        /// name alone.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string PartnerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PartnerAddress property is set.
        /// </summary>
        internal bool IsSetPartnerAddress() => this.PartnerAddress != null;

        /// <summary>
        /// Gets and sets the property PartnerBadge. The partner's badge — a tier or designation
        /// badge from AWS Partner Badge Manager — shown in every badge slot of the campaign's
        /// emails, landing pages and documents. Optional: until one is set, every badge slot
        /// shows the Standalone AWS Partner badge. 
        /// &lt;para&gt;
        /// A PNG or JPEG of at most 2 MB, staged like an asset image and checked the same way:
        /// it must have passed the staging scan (`SCAN_REJECTED`, or `SCAN_IN_PROGRESS` while
        /// it is pending), and its bytes must be the format its name says (`IMAGE_FORMAT_NOT_SUPPORTED`).
        /// Any shape is accepted: a badge is drawn whole, never cropped. Content moderation judges
        /// it when an asset that shows it is activated.
        /// </summary>
        public FileRef PartnerBadge { get; set; }

        /// <summary>
        /// Checks to see if the PartnerBadge property is set.
        /// </summary>
        internal bool IsSetPartnerBadge() => this.PartnerBadge != null;

        /// <summary>
        /// Gets and sets the property PrivacyPolicyUrl. The URL of the partner's privacy policy,
        /// linked from every email and landing page footer. Optional here: a campaign whose emails
        /// or landing pages show it cannot activate them until one is set.
        /// </summary>
        [AWSProperty(Min = 9, Max = 2048)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyPolicyUrl property is set.
        /// </summary>
        internal bool IsSetPrivacyPolicyUrl() => this.PrivacyPolicyUrl != null;

        /// <summary>
        /// Gets and sets the property SenderEmail. The address every email of this campaign is
        /// sent from. 
        /// &lt;para&gt;
        /// Printable ASCII only, with no spaces or line breaks, or field code `PATTERN_MISMATCH`.
        /// Then three rules, all checked when the sender is set. Its domain must exactly match,
        /// ignoring case, the domain of the partner's alliance lead email in AWS Partner Central
        /// (a subdomain does not), or field code `SENDER_DOMAIN_NOT_ALLIANCE_LEAD`. Then, for
        /// a sender at example.com, DNS must hold the CNAME `dkim._domainkey.example.com` → `dkim._domainkey.md02.com`
        /// (field code `SENDER_DOMAIN_DKIM_MISSING`) and a DMARC record, one TXT `_dmarc.example.com`
        /// starting `v=DMARC1` with a `p` of `none`, `quarantine` or `reject` (field code `SENDER_DOMAIN_DMARC_MISSING`).
        /// Both DNS codes are reported together when both records are missing. 
        /// &lt;para&gt;
        /// A partner who can't satisfy them can't set a sender, so can't run email campaigns.
        /// A shared mail provider's domain, such as gmail.com, can't carry the records. Optional
        /// here: a campaign with no sender can be created and edited, but its email assets cannot
        /// be activated until one is set.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 254)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Checks to see if the SenderEmail property is set.
        /// </summary>
        internal bool IsSetSenderEmail() => this.SenderEmail != null;

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
        /// Gets and sets the property Tags. Tags to apply at creation. Tag-on-create rather than
        /// create-then-tag is a Tagris requirement, not a convenience: it is what lets a tag-based
        /// access control policy govern the creation itself. A campaign created untagged and
        /// tagged a moment later is briefly outside any such policy. 
        /// &lt;para&gt;
        /// A key beginning `aws:` (any case) is reserved for AWS-applied system tags and is refused
        /// with `ValidationException`, as is a key repeated in the list; nothing is created.
        /// The tags are recorded before the campaign is written, so a create that cannot record
        /// them fails and creates nothing. A retry with the same `ClientToken` returns the campaign
        /// the first attempt created and does not re-apply tags — use `TagResource` to change
        /// them afterwards. `ListTagsForResource` returns them.
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

        /// <summary>
        /// Gets and sets the property TargetAudience. Advisory targeting metadata. Refined later,
        /// and not validated here.
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
