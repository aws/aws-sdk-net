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
    /// An image field's constraints and default.
    /// </summary>
    public partial class ImageFieldType
    {
        /// <summary>
        /// Gets and sets the property AllowedFormats. Accepted image formats.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> AllowedFormats { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedFormats property is set.
        /// </summary>
        internal bool IsSetAllowedFormats() => this.AllowedFormats != null && (this.AllowedFormats.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultValue. The AWS-authored image the asset uses until
        /// the partner sets one: shown in previews and published in an empty slot of an email,
        /// landing page, banner ad or social post. It fills a required image field. A document
        /// leaves an empty image slot blank.
        /// </summary>
        public LayoutPreview DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property MaxSizeBytes. Maximum accepted file size in bytes.
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the MaxSizeBytes property is set.
        /// </summary>
        internal bool IsSetMaxSizeBytes() => this.MaxSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendedHeightPixels. The image height, in pixels, that
        /// fills this slot. Present exactly when `RecommendedWidthPixels` is.
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? RecommendedHeightPixels { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedHeightPixels property is set.
        /// </summary>
        internal bool IsSetRecommendedHeightPixels() => this.RecommendedHeightPixels.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendedWidthPixels. The image size, in pixels, that
        /// fills this slot and prints sharply, for example 1920 x 301 for a full-width header.
        /// Shown to the partner as "Recommended: W x H px". Present, together with `RecommendedHeightPixels`,
        /// on document (PDF) image slots only, where the slot is a fixed rectangle. Such a slot
        /// is always filled: the image is scaled to cover it, centred, and clipped to it, the
        /// same as CSS `object-fit: cover`. An image whose shape is too far from W:H is refused
        /// with `IMAGE_ASPECT_RATIO_MISMATCH`; one narrower than W is accepted. A slot showing
        /// the partner's logo or badge, and a slot without the two members (every slot from before
        /// sizes existed), fits the image inside instead (`object-fit: contain`): a logo or a
        /// badge is never cropped. Email and landing-page image slots are laid out by HTML and
        /// carry neither.
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? RecommendedWidthPixels { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedWidthPixels property is set.
        /// </summary>
        internal bool IsSetRecommendedWidthPixels() => this.RecommendedWidthPixels.HasValue;
    }
}
