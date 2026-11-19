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
    /// This is the response object from the UpdateCampaignAsset operation.
    /// </summary>
    public partial class UpdateCampaignAssetResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property Id. The asset identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property State. The asset's state, **unchanged**. An update never
        /// moves it, so a live asset stays ACTIVE while its edited values take effect for the
        /// next activation. There is no edit-outcome member: a 200 means every submitted value
        /// applied, and every failure is a refusal on the call itself (DG-040 Decision 11).
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
