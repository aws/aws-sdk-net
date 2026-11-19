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
    /// A platform-managed campaign template — an AWS-authored kit of asset blueprints a partner
    /// creates a campaign from.
    /// </summary>
    public partial class CampaignTemplate
    {
        /// <summary>
        /// Gets and sets the property AssetTemplates. The ordered asset blueprints. One call
        /// serves both template browsing and server-side copy-at-create.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 25)]
        public List<CampaignAssetTemplate> AssetTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<CampaignAssetTemplate>() : null;

        /// <summary>
        /// Checks to see if the AssetTemplates property is set.
        /// </summary>
        internal bool IsSetAssetTemplates() => this.AssetTemplates != null && (this.AssetTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsServices. AWS services the template promotes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> AwsServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsServices property is set.
        /// </summary>
        internal bool IsSetAwsServices() => this.AwsServices != null && (this.AwsServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Collection. The browsing context the template is listed
        /// in. Every template has exactly one.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignTemplateCollection Collection { get; set; }

        /// <summary>
        /// Checks to see if the Collection property is set.
        /// </summary>
        internal bool IsSetCollection() => this.Collection != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. Creation timestamp.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerSegments. The customer segments the template is
        /// written for. Absent when the template names none, in which case it matches every `CustomerSegments`
        /// search filter.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> CustomerSegments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomerSegments property is set.
        /// </summary>
        internal bool IsSetCustomerSegments() => this.CustomerSegments != null && (this.CustomerSegments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. A short overview of the campaign, as plain
        /// text in the template's language: no HTML and no character entities. Absent when the
        /// template has none; never an empty string.
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EffectiveDateBegin. The instant the template becomes available
        /// to partners. Until then the template does not exist to a partner: SearchCampaignTemplates
        /// omits it and GetCampaignTemplate returns ResourceNotFoundException.
        /// </summary>
        public DateTime? EffectiveDateBegin { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDateBegin property is set.
        /// </summary>
        internal bool IsSetEffectiveDateBegin() => this.EffectiveDateBegin.HasValue;

        /// <summary>
        /// Gets and sets the property Id. The campaign template identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Industry. Target industry for filtering or categorization.
        /// </summary>
        public Industry Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. Language the template is authored in, which
        /// a campaign created from it takes. A template has one language; the same content in
        /// another language is another template.
        /// </summary>
        public AssetLanguage LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

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
        /// Gets and sets the property ReferenceMaterials. The template's reference materials:
        /// guides, briefs, copy blocks and other files a partner downloads and uses in their
        /// own channels. Kept apart from `AssetTemplates` because none of them can become a campaign
        /// asset — they have no editable field and nothing to activate — and listing them beside
        /// the blueprints invited a `BatchCreateCampaignAsset` that could only fail. Absent when
        /// the template has none.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 30)]
        public List<ReferenceMaterial> ReferenceMaterials { get; set; } = AWSConfigs.InitializeCollections ? new List<ReferenceMaterial>() : null;

        /// <summary>
        /// Checks to see if the ReferenceMaterials property is set.
        /// </summary>
        internal bool IsSetReferenceMaterials() => this.ReferenceMaterials != null && (this.ReferenceMaterials.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SetupDuration. Estimated setup time.
        /// </summary>
        public string SetupDuration { get; set; }

        /// <summary>
        /// Checks to see if the SetupDuration property is set.
        /// </summary>
        internal bool IsSetSetupDuration() => this.SetupDuration != null;

        /// <summary>
        /// Gets and sets the property Themes. The template's marketing themes. Absent when the
        /// template names none, in which case it matches every `Themes` search filter.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> Themes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Themes property is set.
        /// </summary>
        internal bool IsSetThemes() => this.Themes != null && (this.Themes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThumbnailUrl. Thumbnail URL.
        /// </summary>
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Checks to see if the ThumbnailUrl property is set.
        /// </summary>
        internal bool IsSetThumbnailUrl() => this.ThumbnailUrl != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. Last update timestamp.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UseCase. Campaign use case for filtering or categorization.
        /// </summary>
        public string UseCase { get; set; }

        /// <summary>
        /// Checks to see if the UseCase property is set.
        /// </summary>
        internal bool IsSetUseCase() => this.UseCase != null;
    }
}
