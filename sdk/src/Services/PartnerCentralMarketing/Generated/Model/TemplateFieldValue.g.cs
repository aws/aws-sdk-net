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
    /// The value of a template field. Exactly one variant is set, matching the field's type:
    /// text and RichText fields use text, image fields use ImageReference (or, on a write,
    /// CampaignAssetImage), AssetLink fields use LinkedAssetId.
    /// </summary>
    public partial class TemplateFieldValue
    {
        /// <summary>
        /// Gets and sets the property CampaignAssetImage. Write only. Copies an image stored
        /// on another of your assets into this image field. The image is checked against this
        /// field's constraints and not scanned again. Also requires `partnercentral:GetCampaignAsset`
        /// on the source campaign. Reads return the copy as `ImageReference`.
        /// </summary>
        public CampaignAssetImageSource CampaignAssetImage { get; set; }

        /// <summary>
        /// Checks to see if the CampaignAssetImage property is set.
        /// </summary>
        internal bool IsSetCampaignAssetImage() => this.CampaignAssetImage != null;

        /// <summary>
        /// Gets and sets the property ImageReference. Image reference (image fields). On a write,
        /// one of exactly two forms: - the `s3://` URI of a file you staged in the Partner Central
        /// file staging bucket. It is scanned, then copied into this asset. - the URL Build with
        /// AI returned for a suggested image, unchanged. It is copied into this asset and not
        /// scanned. Any other URL is refused with `FILE_REFERENCE_INVALID`, including one a read
        /// returned: to keep the current image, omit the field; to put it on another asset, use
        /// `CampaignAssetImage`. On a read, a URL the caller can fetch: an image in the asset's
        /// own storage comes back as a presigned GET that expires one hour after the read, so
        /// fetch it again with `GetCampaignAsset` when it returns 403; an image already on DG's
        /// public CDN comes back as that stable URL. A stored reference outside this asset's
        /// storage, or not a raster image, is never signed, and the value is omitted. The signed
        /// URL serves the image as its image type, whatever the upload declared.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ImageReference { get; set; }

        /// <summary>
        /// Checks to see if the ImageReference property is set.
        /// </summary>
        internal bool IsSetImageReference() => this.ImageReference != null;

        /// <summary>
        /// Gets and sets the property LinkedAssetId. The asset an `AssetLink` field names: the
        /// id of an asset on the same campaign, of the field's category. It is a prerequisite
        /// of this asset while linked, so it activates first, this asset cannot start until it
        /// is live, and it cannot be deleted.
        /// </summary>
        [AWSProperty(Min = 17, Max = 17)]
        public string LinkedAssetId { get; set; }

        /// <summary>
        /// Checks to see if the LinkedAssetId property is set.
        /// </summary>
        internal bool IsSetLinkedAssetId() => this.LinkedAssetId != null;

        /// <summary>
        /// Gets and sets the property Text. Text value — for both text and RichText fields. A
        /// RichText value is a markup fragment restricted to the field's AllowedTags.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 100000)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
