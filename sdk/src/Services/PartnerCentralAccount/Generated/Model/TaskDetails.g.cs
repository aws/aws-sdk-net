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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Contains detailed information about a profile update task including the changes to
    /// be made.
    /// </summary>
    public partial class TaskDetails
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 600)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The updated display name for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 80)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Headquarters. 
        /// <para>
        /// The ISO 3166 country and subdivision codes for the partner's headquarters location.
        /// If you omit this field, the service retains the existing headquarters value.
        /// </para>
        /// </summary>
        public Headquarters Headquarters { get; set; }

        /// <summary>
        /// Checks to see if the Headquarters property is set.
        /// </summary>
        internal bool IsSetHeadquarters() => this.Headquarters != null;

        /// <summary>
        /// Gets and sets the property IndustrySegments. 
        /// <para>
        /// The updated industry segments for the partner profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 3)]
        public List<string> IndustrySegments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IndustrySegments property is set.
        /// </summary>
        internal bool IsSetIndustrySegments() => this.IndustrySegments != null && (this.IndustrySegments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocalizedContents. 
        /// <para>
        /// The updated localized content for the partner profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<LocalizedContent> LocalizedContents { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalizedContent>() : null;

        /// <summary>
        /// Checks to see if the LocalizedContents property is set.
        /// </summary>
        internal bool IsSetLocalizedContents() => this.LocalizedContents != null && (this.LocalizedContents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// The updated logo URL for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogoUrl property is set.
        /// </summary>
        internal bool IsSetLogoUrl() => this.LogoUrl != null;

        /// <summary>
        /// Gets and sets the property PrimarySolutionType. 
        /// <para>
        /// The updated primary solution type for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrimarySolutionType PrimarySolutionType { get; set; }

        /// <summary>
        /// Checks to see if the PrimarySolutionType property is set.
        /// </summary>
        internal bool IsSetPrimarySolutionType() => this.PrimarySolutionType != null;

        /// <summary>
        /// Gets and sets the property TranslationSourceLocale. 
        /// <para>
        /// The updated translation source locale for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TranslationSourceLocale { get; set; }

        /// <summary>
        /// Checks to see if the TranslationSourceLocale property is set.
        /// </summary>
        internal bool IsSetTranslationSourceLocale() => this.TranslationSourceLocale != null;

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The updated website URL for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebsiteUrl property is set.
        /// </summary>
        internal bool IsSetWebsiteUrl() => this.WebsiteUrl != null;
    }
}
