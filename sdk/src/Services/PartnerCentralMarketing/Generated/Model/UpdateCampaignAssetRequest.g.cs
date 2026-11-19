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
    /// Container for the parameters to the UpdateCampaignAsset operation. Updates an asset's
    /// field values, layout or send time. Refused with `ConflictException` while the campaign's
    /// running activation task still owns the asset (`ASSET_START_IN_PROGRESS`), and for
    /// a live email or social post (`ASSET_ALREADY_ACTIVE`): deactivate it first.
    /// </summary>
    public partial class UpdateCampaignAssetRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignAssetIdentifier. The asset identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string CampaignAssetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CampaignAssetIdentifier property is set.
        /// </summary>
        internal bool IsSetCampaignAssetIdentifier() => this.CampaignAssetIdentifier != null;

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
        /// Gets and sets the property ClientToken. Idempotency token. Retry-safety only — this
        /// is **not** a concurrency token, and sequential edits to one field are last-writer-wins.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property FieldValues. Value-only updates to the asset's pinned template
        /// fields, keyed by FieldId. The field schema (labels, descriptions, constraints, placeholders,
        /// image defaults) is service-owned and pinned at instantiation, so clients send only
        /// the values they are changing. Fields omitted keep their stored values; send the entry
        /// with `Value` omitted to clear one. Named `FieldValues` to match the member it edits
        /// on `CampaignAsset`, which is the same concept read back. It was `templateFieldUpdates`;
        /// the two names for one concept were the defect, not the length.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 150)]
        public List<FieldValueInput> FieldValues { get; set; } = AWSConfigs.InitializeCollections ? new List<FieldValueInput>() : null;

        /// <summary>
        /// Checks to see if the FieldValues property is set.
        /// </summary>
        internal bool IsSetFieldValues() => this.FieldValues != null && (this.FieldValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Layout. Selects a multi-layout asset's layout: one of the
        /// values in `CampaignAsset.layout.options`. PATCH: omitted leaves the selection unchanged,
        /// and there is no way to clear it. A value that is not one of the asset's options —
        /// or any value on a single-layout asset — is a plain `ValidationException`, and nothing
        /// in the call is applied. Every pinned field stays writable whichever layout is selected.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Layout { get; set; }

        /// <summary>
        /// Checks to see if the Layout property is set.
        /// </summary>
        internal bool IsSetLayout() => this.Layout != null;

        /// <summary>
        /// Gets and sets the property ScheduledSendAt. The send time, with `SendMode: SCHEDULED`
        /// and only then. See `SendMode`. Must be at least an hour out (`SEND_WINDOW_TOO_SOON`),
        /// unless it is the time already stored: resending the stored mode and time changes nothing
        /// and is accepted, so a form that always resubmits does not trip the window. Must also
        /// fall on or before the campaign's `EndOn` (by the end of that UTC day): refused with
        /// `ValidationException` (`INVALID_VALUE`) otherwise, so nothing is scheduled to send
        /// after the campaign completes. Was `scheduleDate`, a `YYYY-MM-DD` string. Retyped because
        /// a date alone cannot express a send *time*, which is the whole point of a schedule
        /// — and because the resource already spelled the same concept `ScheduledSendAt` on the
        /// activation responses. Two spellings of one concept on one resource was the defect.
        /// </summary>
        public DateTime? ScheduledSendAt { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledSendAt property is set.
        /// </summary>
        internal bool IsSetScheduledSendAt() => this.ScheduledSendAt.HasValue;

        /// <summary>
        /// Gets and sets the property SendMode. When a **sendable** asset (`EMAIL`, `SOCIAL_POST`)
        /// sends: on activation, or at `ScheduledSendAt`. A mode beside a value rather than a
        /// union, on purpose: `ScheduledSendAt` stays a plain `Timestamp`, and the precedent
        /// is EventBridge Scheduler's `FlexibleTimeWindow { Mode, MaximumWindowInMinutes }`.
        /// The pair is checked as one, and a request where they disagree is refused with `ValidationException`
        /// (`INVALID_VALUE`, naming the member) and applies nothing: - `SCHEDULED` requires `ScheduledSendAt`;
        /// a reschedule resends `SCHEDULED` with the new time; - `ON_ACTIVATION` forbids `ScheduledSendAt`,
        /// and drops any time already stored; - `ScheduledSendAt` without `SendMode` is refused.
        /// PATCH: omitted leaves both unchanged. Until a mode is chosen the asset reports `SEND_MODE_MISSING`
        /// and does not activate: no default, because an unchosen send mails the real audience.
        /// Rejected with `ValidationException` (`NOT_SUPPORTED_FOR_CATEGORY`) for a category
        /// that has no send (`LANDING_PAGE`, `DOCUMENT`, `BANNER_AD`). Like every other edit,
        /// it reaches the delivery platform at the asset's next activation, and a live email
        /// or social post refuses it (`ASSET_ALREADY_ACTIVE`): deactivate first.
        /// </summary>
        public SendMode SendMode { get; set; }

        /// <summary>
        /// Checks to see if the SendMode property is set.
        /// </summary>
        internal bool IsSetSendMode() => this.SendMode != null;
    }
}
