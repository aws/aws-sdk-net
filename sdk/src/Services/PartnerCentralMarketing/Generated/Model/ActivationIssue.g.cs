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
    /// One thing that must be fixed before activation.
    /// </summary>
    public partial class ActivationIssue
    {
        /// <summary>
        /// Gets and sets the property AffectedAssetIds. The assets this campaign-level issue
        /// blocks.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 25)]
        public List<string> AffectedAssetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AffectedAssetIds property is set.
        /// </summary>
        internal bool IsSetAffectedAssetIds() => this.AffectedAssetIds != null && (this.AffectedAssetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CampaignSetting. The `UpdateCampaign` member to set. Present
        /// for campaign-level issues.
        /// </summary>
        public CampaignSetting CampaignSetting { get; set; }

        /// <summary>
        /// Checks to see if the CampaignSetting property is set.
        /// </summary>
        internal bool IsSetCampaignSetting() => this.CampaignSetting != null;

        /// <summary>
        /// Gets and sets the property Code. What is wrong. Branch on this, not on `Message`.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetStateReason Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property FieldId. The asset field to fix. Present for asset-level
        /// issues, except `SEND_MODE_MISSING` and a `CONTENT_REJECTED` that refused the asset's
        /// text as a whole rather than one field.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property Message. A description for display. Don't parse it.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property PartnerProfileField. The partner-profile value to set or
        /// shorten, in AWS Partner Central, or the derived value whose input it is. Present on
        /// `PARTNER_PROFILE_FIELD_MISSING` and `PARTNER_PROFILE_FIELD_DOES_NOT_FIT`.
        /// </summary>
        public PartnerProfileField PartnerProfileField { get; set; }

        /// <summary>
        /// Checks to see if the PartnerProfileField property is set.
        /// </summary>
        internal bool IsSetPartnerProfileField() => this.PartnerProfileField != null;
    }
}
