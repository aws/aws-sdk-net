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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
        private string _description;
        private string _displayName;
        private List<string> _industrySegments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<LocalizedContent> _localizedContents = AWSConfigs.InitializeCollections ? new List<LocalizedContent>() : null;
        private string _logoUrl;
        private PrimarySolutionType _primarySolutionType;
        private string _translationSourceLocale;
        private string _websiteUrl;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=600)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The updated display name for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IndustrySegments. 
        /// <para>
        /// The updated industry segments for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<string> IndustrySegments
        {
            get { return this._industrySegments; }
            set { this._industrySegments = value; }
        }

        // Check to see if IndustrySegments property is set
        internal bool IsSetIndustrySegments()
        {
            return this._industrySegments != null && (this._industrySegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocalizedContents. 
        /// <para>
        /// The updated localized content for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<LocalizedContent> LocalizedContents
        {
            get { return this._localizedContents; }
            set { this._localizedContents = value; }
        }

        // Check to see if LocalizedContents property is set
        internal bool IsSetLocalizedContents()
        {
            return this._localizedContents != null && (this._localizedContents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// The updated logo URL for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string LogoUrl
        {
            get { return this._logoUrl; }
            set { this._logoUrl = value; }
        }

        // Check to see if LogoUrl property is set
        internal bool IsSetLogoUrl()
        {
            return this._logoUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PrimarySolutionType. 
        /// <para>
        /// The updated primary solution type for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrimarySolutionType PrimarySolutionType
        {
            get { return this._primarySolutionType; }
            set { this._primarySolutionType = value; }
        }

        // Check to see if PrimarySolutionType property is set
        internal bool IsSetPrimarySolutionType()
        {
            return this._primarySolutionType != null;
        }

        /// <summary>
        /// Gets and sets the property TranslationSourceLocale. 
        /// <para>
        /// The updated translation source locale for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TranslationSourceLocale
        {
            get { return this._translationSourceLocale; }
            set { this._translationSourceLocale = value; }
        }

        // Check to see if TranslationSourceLocale property is set
        internal bool IsSetTranslationSourceLocale()
        {
            return this._translationSourceLocale != null;
        }

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The updated website URL for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string WebsiteUrl
        {
            get { return this._websiteUrl; }
            set { this._websiteUrl = value; }
        }

        // Check to see if WebsiteUrl property is set
        internal bool IsSetWebsiteUrl()
        {
            return this._websiteUrl != null;
        }

    }
}