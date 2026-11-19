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
    /// One asset blueprint inside a campaign template. The id is template-local — an asset
    /// template is not a standalone resource and has no ARN.
    /// </summary>
    public partial class CampaignAssetTemplate
    {
        /// <summary>
        /// Gets and sets the property DisplayOrder. Ordering for preview and instantiation.
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Checks to see if the DisplayOrder property is set.
        /// </summary>
        internal bool IsSetDisplayOrder() => this.DisplayOrder.HasValue;

        /// <summary>
        /// Gets and sets the property Fields. The editable-field schema, copied and pinned onto
        /// each campaign asset at create. Fields the service fills itself are not listed.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 150)]
        public List<CampaignAssetTemplateField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<CampaignAssetTemplateField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. The template-local asset template identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Label. Display label; becomes the instantiated asset's
        /// name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property LayoutPreviews. Previews of the AWS-authored layout skeleton.
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
        /// Gets and sets the property PrerequisiteAssetTemplateIds. The asset templates this
        /// one embeds output from, such as an email's landing page. Each must be in the same
        /// `BatchCreateCampaignAsset` request or already an asset on the campaign, else the create
        /// is refused `PREREQUISITE_ASSET_MISSING`; include them when the partner picks this
        /// one. Absent when there are none. A link the partner chooses, such as a landing page's
        /// download button, is not listed here: it is an `AssetLink` field and needs nothing
        /// at create.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<string> PrerequisiteAssetTemplateIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PrerequisiteAssetTemplateIds property is set.
        /// </summary>
        internal bool IsSetPrerequisiteAssetTemplateIds() => this.PrerequisiteAssetTemplateIds != null && (this.PrerequisiteAssetTemplateIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SocialPlatform. SOCIAL_POST only: the platform an asset
        /// made from this blueprint posts to, which the asset reports as `SocialPlatform`. Fixed
        /// by the template, so a client can show which social connection the post needs before
        /// it is created. Absent for every other type.
        /// </summary>
        public Platform SocialPlatform { get; set; }

        /// <summary>
        /// Checks to see if the SocialPlatform property is set.
        /// </summary>
        internal bool IsSetSocialPlatform() => this.SocialPlatform != null;

        /// <summary>
        /// Gets and sets the property Type. The kind of asset this blueprint instantiates as.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetTemplateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
