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
    /// Summary representation of a campaign template, returned by search.
    /// </summary>
    public partial class CampaignTemplateSummary
    {
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
        /// in. See `CampaignTemplate$Collection`.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignTemplateCollection Collection { get; set; }

        /// <summary>
        /// Checks to see if the Collection property is set.
        /// </summary>
        internal bool IsSetCollection() => this.Collection != null;

        /// <summary>
        /// Gets and sets the property CustomerSegments. The customer segments the template is
        /// written for. See `CampaignTemplate$CustomerSegments`.
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
        /// Gets and sets the property Description. The campaign overview. See `CampaignTemplate$Description`.
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property LanguageCode. Language the template is authored in. See
        /// `CampaignTemplate$LanguageCode`.
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
        /// Gets and sets the property Themes. The template's marketing themes. See `CampaignTemplate$Themes`.
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
        /// Gets and sets the property UseCase. Campaign use case for filtering or categorization.
        /// </summary>
        public string UseCase { get; set; }

        /// <summary>
        /// Checks to see if the UseCase property is set.
        /// </summary>
        internal bool IsSetUseCase() => this.UseCase != null;
    }
}
