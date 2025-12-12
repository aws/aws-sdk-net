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
    /// The branding configuration output including custom images metadata, localized strings,
    /// color theme, and terms of service.
    /// </summary>
    public partial class BrandingConfiguration
    {
        private ColorTheme _colorTheme;
        private ImageMetadata _favicon;
        private Dictionary<string, LocalizedBrandingStrings> _localizedStrings = AWSConfigs.InitializeCollections ? new Dictionary<string, LocalizedBrandingStrings>() : null;
        private ImageMetadata _logo;
        private string _termsOfService;
        private ImageMetadata _wallpaper;

        /// <summary>
        /// Gets and sets the property ColorTheme. 
        /// <para>
        /// The color theme for components on the web portal.
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
        /// Metadata for the favicon image file, including the MIME type, file extension, and
        /// upload timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageMetadata Favicon
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
        /// A map of localized text strings for different languages, allowing the portal to display
        /// content in the user's preferred language.
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
        /// Metadata for the logo image file, including the MIME type, file extension, and upload
        /// timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageMetadata Logo
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
        /// The terms of service text in Markdown format that users must accept before accessing
        /// the portal.
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
        /// Metadata for the wallpaper image file, including the MIME type, file extension, and
        /// upload timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageMetadata Wallpaper
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