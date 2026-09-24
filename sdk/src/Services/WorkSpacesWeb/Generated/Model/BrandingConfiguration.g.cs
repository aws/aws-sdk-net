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
    /// The branding configuration output including custom images metadata, localized strings,
    /// color theme, and terms of service.
    /// </summary>
    public partial class BrandingConfiguration
    {
        /// <summary>
        /// Gets and sets the property ColorTheme. 
        /// <para>
        /// The color theme for components on the web portal.
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
        /// Metadata for the favicon image file, including the MIME type, file extension, and
        /// upload timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageMetadata Favicon { get; set; }

        /// <summary>
        /// Checks to see if the Favicon property is set.
        /// </summary>
        internal bool IsSetFavicon() => this.Favicon != null;

        /// <summary>
        /// Gets and sets the property LocalizedStrings. 
        /// <para>
        /// A map of localized text strings for different languages, allowing the portal to display
        /// content in the user's preferred language.
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
        /// Metadata for the logo image file, including the MIME type, file extension, and upload
        /// timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageMetadata Logo { get; set; }

        /// <summary>
        /// Checks to see if the Logo property is set.
        /// </summary>
        internal bool IsSetLogo() => this.Logo != null;

        /// <summary>
        /// Gets and sets the property TermsOfService. 
        /// <para>
        /// The terms of service text in Markdown format that users must accept before accessing
        /// the portal.
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
        /// Metadata for the wallpaper image file, including the MIME type, file extension, and
        /// upload timestamp.
        /// </para>
        /// </summary>
        public ImageMetadata Wallpaper { get; set; }

        /// <summary>
        /// Checks to see if the Wallpaper property is set.
        /// </summary>
        internal bool IsSetWallpaper() => this.Wallpaper != null;
    }
}
