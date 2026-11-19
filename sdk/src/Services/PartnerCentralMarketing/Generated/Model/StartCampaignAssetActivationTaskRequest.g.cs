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
    /// Container for the parameters to the StartCampaignAssetActivationTask operation. Activates
    /// 1–25 of a campaign's assets as one ordered unit, and returns a task to poll. Takes
    /// a **list** because the service owns the ordering. Assets link to one another by URL
    /// — an email's call-to-action carries the landing page's URL, the landing page's download
    /// field carries the document's — and a URL does not exist until the asset it points
    /// at is activated. Those edges are derived by the service from the campaign's pinned
    /// template, so reconstructing and topologically sorting them is work the service has
    /// already done, and getting it wrong arms an email with a dead link. Name every asset
    /// you want live and the service sequences them; "activate everything" is the list with
    /// every id in it, which ListCampaignAssets already gave you. Asynchronous, because activating
    /// an asset installs or arms behaviour that runs later and an email activation bulk-loads
    /// its audience into the delivery platform. Everything decidable **without** a write
    /// to the delivery platform is evaluated before this returns; everything else lands on
    /// the task. A refusal that applies to one asset does not fail the request: that asset
    /// is on the task already FAILED, with its reason, and the rest run. A refusal that applies
    /// to the whole request — a malformed list, an unknown campaign, another task already
    /// running on this campaign, this service's service-linked role being deleted (ConflictException
    /// `SERVICE_LINKED_ROLE_DELETION_IN_PROGRESS`), a campaign setting an asset in the request
    /// needs (ValidationException `CAMPAIGN_INCOMPLETE`), a campaign sender that no longer
    /// passes `CreateCampaign`'s sender rules while the request names an email (ValidationException
    /// with no `FieldList`, whose message ends with one `Reason: &lt;c&gt;` token per failed
    /// rule: `PATTERN_MISMATCH`, `SENDER_DOMAIN_NOT_ALLIANCE_LEAD`, or `SENDER_DOMAIN_DKIM_MISSING`
    /// and/or `SENDER_DOMAIN_DMARC_MISSING`) — is thrown, and nothing starts. One task runs
    /// on a campaign at a time. A second concurrent call is refused with ConflictException
    /// / CAMPAIGN_ACTIVATION_IN_PROGRESS, whose `ResourceId` names the task already holding
    /// the campaign. Two tasks over *disjoint* asset sets are refused too: the guard is deliberately
    /// campaign-wide, because overlapping runs made the per-asset status misleading rather
    /// than merely contended.
    /// </summary>
    public partial class StartCampaignAssetActivationTaskRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignAssetIdentifiers. The assets to activate, in any
        /// order — the service derives the dependency order and ignores the order given here.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public List<string> CampaignAssetIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CampaignAssetIdentifiers property is set.
        /// </summary>
        internal bool IsSetCampaignAssetIdentifiers() => this.CampaignAssetIdentifiers != null && (this.CampaignAssetIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CampaignIdentifier. The campaign identifier, which also
        /// authorizes the call.
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
        /// Gets and sets the property ClientToken. Idempotency token. Two requests carrying the
        /// same token are one request, and the second returns the first one's task rather than
        /// starting a second. The deduplication window is the **life of the task record**, not
        /// a fixed number of hours: replaying a token after the task has expired starts a new
        /// task. Stated because a caller would otherwise assume the usual few-hour guarantee.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;
    }
}
