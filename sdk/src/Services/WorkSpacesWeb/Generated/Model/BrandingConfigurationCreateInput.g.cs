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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The input configuration for creating branding settings.
    /// </summary>
    public partial class BrandingConfigurationCreateInput
    {
        /// <summary>
        /// Gets and sets the property ColorTheme. 
        /// <para>
        /// The color theme for components on the web portal. Choose <c>Light</c> if you upload
        /// a dark wallpaper, or <c>Dark</c> for a light wallpaper.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColorTheme ColorTheme { get; set; }

        /// <summary>
        /// Checks to see if the ColorTheme property is set.
        /// </summary>
        internal bool IsSetColorTheme() => this.ColorTheme != null;

        /// <summary>
        /// Gets and sets the property Favicon. 
        /// <para>
        /// The favicon image for the portal. Provide either a binary image file or an S3 URI
        /// pointing to the image file. Maximum 100 KB in JPEG, PNG, or ICO format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IconImageInput Favicon { get; set; }

        /// <summary>
        /// Checks to see if the Favicon property is set.
        /// </summary>
        internal bool IsSetFavicon() => this.Favicon != null;

        /// <summary>
        /// Gets and sets the property LocalizedStrings. 
        /// <para>
        /// A map of localized text strings for different supported languages. Each locale must
        /// provide the required fields <c>browserTabTitle</c> and <c>welcomeText</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, LocalizedBrandingStrings> LocalizedStrings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, LocalizedBrandingStrings>() : null;

        /// <summary>
        /// Checks to see if the LocalizedStrings property is set.
        /// </summary>
        internal bool IsSetLocalizedStrings() => this.LocalizedStrings != null && (this.LocalizedStrings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Logo. 
        /// <para>
        /// The logo image for the portal. Provide either a binary image file or an S3 URI pointing
        /// to the image file. Maximum 100 KB in JPEG, PNG, or ICO format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IconImageInput Logo { get; set; }

        /// <summary>
        /// Checks to see if the Logo property is set.
        /// </summary>
        internal bool IsSetLogo() => this.Logo != null;

        /// <summary>
        /// Gets and sets the property TermsOfService. 
        /// <para>
        /// The terms of service text in Markdown format. Users will be presented with the terms
        /// of service after successfully signing in.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 153600)]
        public string TermsOfService { get; set; }

        /// <summary>
        /// Checks to see if the TermsOfService property is set.
        /// </summary>
        internal bool IsSetTermsOfService() => this.TermsOfService != null;

        /// <summary>
        /// Gets and sets the property Wallpaper. 
        /// <para>
        /// The wallpaper image for the portal. Provide either a binary image file or an S3 URI
        /// pointing to the image file. Maximum 5 MB in JPEG or PNG format. If not provided, a
        /// default wallpaper will be used as the background image.
        /// </para>
        /// </summary>
        public WallpaperImageInput Wallpaper { get; set; }

        /// <summary>
        /// Checks to see if the Wallpaper property is set.
        /// </summary>
        internal bool IsSetWallpaper() => this.Wallpaper != null;
    }
}
