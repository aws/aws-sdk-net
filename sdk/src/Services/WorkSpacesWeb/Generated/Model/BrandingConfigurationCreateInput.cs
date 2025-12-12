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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
        private ColorTheme _colorTheme;
        private IconImageInput _favicon;
        private Dictionary<string, LocalizedBrandingStrings> _localizedStrings = AWSConfigs.InitializeCollections ? new Dictionary<string, LocalizedBrandingStrings>() : null;
        private IconImageInput _logo;
        private string _termsOfService;
        private WallpaperImageInput _wallpaper;

        /// <summary>
        /// Gets and sets the property ColorTheme. 
        /// <para>
        /// The color theme for components on the web portal. Choose <c>Light</c> if you upload
        /// a dark wallpaper, or <c>Dark</c> for a light wallpaper.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColorTheme ColorTheme
        {
            get { return this._colorTheme; }
            set { this._colorTheme = value; }
        }

        // Check to see if ColorTheme property is set
        internal bool IsSetColorTheme()
        {
            return this._colorTheme != null;
        }

        /// <summary>
        /// Gets and sets the property Favicon. 
        /// <para>
        /// The favicon image for the portal. Provide either a binary image file or an S3 URI
        /// pointing to the image file. Maximum 100 KB in JPEG, PNG, or ICO format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IconImageInput Favicon
        {
            get { return this._favicon; }
            set { this._favicon = value; }
        }

        // Check to see if Favicon property is set
        internal bool IsSetFavicon()
        {
            return this._favicon != null;
        }

        /// <summary>
        /// Gets and sets the property LocalizedStrings. 
        /// <para>
        /// A map of localized text strings for different supported languages. Each locale must
        /// provide the required fields <c>browserTabTitle</c> and <c>welcomeText</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, LocalizedBrandingStrings> LocalizedStrings
        {
            get { return this._localizedStrings; }
            set { this._localizedStrings = value; }
        }

        // Check to see if LocalizedStrings property is set
        internal bool IsSetLocalizedStrings()
        {
            return this._localizedStrings != null && (this._localizedStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Logo. 
        /// <para>
        /// The logo image for the portal. Provide either a binary image file or an S3 URI pointing
        /// to the image file. Maximum 100 KB in JPEG, PNG, or ICO format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IconImageInput Logo
        {
            get { return this._logo; }
            set { this._logo = value; }
        }

        // Check to see if Logo property is set
        internal bool IsSetLogo()
        {
            return this._logo != null;
        }

        /// <summary>
        /// Gets and sets the property TermsOfService. 
        /// <para>
        /// The terms of service text in Markdown format. Users will be presented with the terms
        /// of service after successfully signing in.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=153600)]
        public string TermsOfService
        {
            get { return this._termsOfService; }
            set { this._termsOfService = value; }
        }

        // Check to see if TermsOfService property is set
        internal bool IsSetTermsOfService()
        {
            return this._termsOfService != null;
        }

        /// <summary>
        /// Gets and sets the property Wallpaper. 
        /// <para>
        /// The wallpaper image for the portal. Provide either a binary image file or an S3 URI
        /// pointing to the image file. Maximum 5 MB in JPEG or PNG format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WallpaperImageInput Wallpaper
        {
            get { return this._wallpaper; }
            set { this._wallpaper = value; }
        }

        // Check to see if Wallpaper property is set
        internal bool IsSetWallpaper()
        {
            return this._wallpaper != null;
        }

    }
}