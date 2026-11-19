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
    /// One slot in an asset template's layout: addressing key, placement, and the field kind
    /// carrying its own constraints, placeholder or default.
    /// </summary>
    public partial class CampaignAssetTemplateField
    {
        /// <summary>
        /// Gets and sets the property CampaignSetting. The campaign setting this field shows,
        /// when it shows one: the partner sets it once on the campaign and every asset displays
        /// it. Present only on such fields. A client shows the field as "Set on the campaign",
        /// linking to the campaign, rather than as an input. `UpdateCampaignAsset` refuses a
        /// value for it with `FIELD_SET_ON_CAMPAIGN`, and on an asset the field carries no value:
        /// read it from the named member of `GetCampaign`'s `Campaign`.
        /// </summary>
        public CampaignSetting CampaignSetting { get; set; }

        /// <summary>
        /// Checks to see if the CampaignSetting property is set.
        /// </summary>
        internal bool IsSetCampaignSetting() => this.CampaignSetting != null;

        /// <summary>
        /// Gets and sets the property Description. What belongs in this field, in English: its
        /// role in the asset and what good content for it is (for example "Headline that names
        /// the customer and leads with a source-backed statistic"). AWS-authored with the template;
        /// never written by a partner. Absent when the template carries none, never empty. Pinned
        /// onto the asset with the field, so a corrected description reaches assets created after
        /// the correction.
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FieldId. The field identifier; matches a {{fieldId}} slot
        /// in the layout.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property Label. Human-readable name for the field, for display.
        /// Authored in the template policy, never derived from the field id or the source layout's
        /// field name: the id is a slug (`Page_2_Title`) and is not meant to be shown to a partner.
        /// Absent on fields imported before labels existed.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property Page. One-based page number, for paginated layouts (print
        /// documents).
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Page { get; set; }

        /// <summary>
        /// Checks to see if the Page property is set.
        /// </summary>
        internal bool IsSetPage() => this.Page.HasValue;

        /// <summary>
        /// Gets and sets the property PartnerProfileField. The partner-profile value this field
        /// shows, when it shows one: the partner's AWS Partner Central profile supplies it, and
        /// every asset of every campaign displays it. Present only on such fields. A client shows
        /// the field as "From your Partner Central profile" rather than as an input. `UpdateCampaignAsset`
        /// refuses a value for it with `FIELD_FROM_PARTNER_PROFILE`. On a read the field carries
        /// the partner's resolved value — the logo as its URL, the name and website as text —
        /// so a slot renders from this list alone; `GetCampaign`'s `Campaign$PartnerProfile`
        /// carries the same three values.
        /// </summary>
        public PartnerProfileField PartnerProfileField { get; set; }

        /// <summary>
        /// Checks to see if the PartnerProfileField property is set.
        /// </summary>
        internal bool IsSetPartnerProfileField() => this.PartnerProfileField != null;

        /// <summary>
        /// Gets and sets the property Required. Whether the field must be filled before the asset
        /// can be activated. Derived from DG policy — never inherited from an upstream authoring
        /// system. Required for activation, not for saving: `UpdateCampaignAsset` accepts partial
        /// content and may clear a required field. An unfilled required field appears in the
        /// asset's `ActivationIssues` as `REQUIRED_FIELD_MISSING`, and activation refuses the
        /// asset with the same code. A text field is filled only by a non-blank value, and a
        /// rich-text field only by a value with non-blank text; a `Placeholder` never fills one.
        /// An image field is filled by the partner's image or by the template's `DefaultValue`.
        /// A field the campaign fills (`CampaignSetting`) or the partner's profile fills (`PartnerProfileField`)
        /// is never unfilled on the asset.
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;

        /// <summary>
        /// Gets and sets the property Section. Layout section the field belongs to.
        /// </summary>
        public TemplateFieldSection Section { get; set; }

        /// <summary>
        /// Checks to see if the Section property is set.
        /// </summary>
        internal bool IsSetSection() => this.Section != null;

        /// <summary>
        /// Gets and sets the property Type. The field kind, with that kind's constraints, placeholder
        /// or default.
        /// </summary>
        [AWSProperty(Required = true)]
        public FieldType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
