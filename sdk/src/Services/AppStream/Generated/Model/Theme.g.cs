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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// The custom branding theme, which might include a custom logo, website links, and other
    /// branding to display to users.
    /// </summary>
    public partial class Theme
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time the theme was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The stack that has the custom branding theme.
        /// </para>
        /// </summary>
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the theme.
        /// </para>
        /// </summary>
        public ThemeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property ThemeFaviconURL. 
        /// <para>
        /// The URL of the icon that displays at the top of a user's browser tab during streaming
        /// sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ThemeFaviconURL { get; set; }

        /// <summary>
        /// Checks to see if the ThemeFaviconURL property is set.
        /// </summary>
        internal bool IsSetThemeFaviconURL() => this.ThemeFaviconURL != null;

        /// <summary>
        /// Gets and sets the property ThemeFooterLinks. 
        /// <para>
        /// The website links that display in the catalog page footer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThemeFooterLink> ThemeFooterLinks { get; set; } = AWSConfigs.InitializeCollections ? new List<ThemeFooterLink>() : null;

        /// <summary>
        /// Checks to see if the ThemeFooterLinks property is set.
        /// </summary>
        internal bool IsSetThemeFooterLinks() => this.ThemeFooterLinks != null && (this.ThemeFooterLinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThemeOrganizationLogoURL. 
        /// <para>
        /// The URL of the logo that displays in the catalog page header.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ThemeOrganizationLogoURL { get; set; }

        /// <summary>
        /// Checks to see if the ThemeOrganizationLogoURL property is set.
        /// </summary>
        internal bool IsSetThemeOrganizationLogoURL() => this.ThemeOrganizationLogoURL != null;

        /// <summary>
        /// Gets and sets the property ThemeStyling. 
        /// <para>
        /// The color that is used for the website links, text, buttons, and catalog page background.
        /// </para>
        /// </summary>
        public ThemeStyling ThemeStyling { get; set; }

        /// <summary>
        /// Checks to see if the ThemeStyling property is set.
        /// </summary>
        internal bool IsSetThemeStyling() => this.ThemeStyling != null;

        /// <summary>
        /// Gets and sets the property ThemeTitleText. 
        /// <para>
        /// The browser tab page title.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string ThemeTitleText { get; set; }

        /// <summary>
        /// Checks to see if the ThemeTitleText property is set.
        /// </summary>
        internal bool IsSetThemeTitleText() => this.ThemeTitleText != null;
    }
}
