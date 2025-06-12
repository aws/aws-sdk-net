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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
        private DateTime? _createdTime;
        private string _stackName;
        private ThemeState _state;
        private string _themeFaviconURL;
        private List<ThemeFooterLink> _themeFooterLinks = AWSConfigs.InitializeCollections ? new List<ThemeFooterLink>() : null;
        private string _themeOrganizationLogoURL;
        private ThemeStyling _themeStyling;
        private string _themeTitleText;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time the theme was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The stack that has the custom branding theme.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the theme.
        /// </para>
        /// </summary>
        public ThemeState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property ThemeFaviconURL. 
        /// <para>
        /// The URL of the icon that displays at the top of a user's browser tab during streaming
        /// sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ThemeFaviconURL
        {
            get { return this._themeFaviconURL; }
            set { this._themeFaviconURL = value; }
        }

        // Check to see if ThemeFaviconURL property is set
        internal bool IsSetThemeFaviconURL()
        {
            return this._themeFaviconURL != null;
        }

        /// <summary>
        /// Gets and sets the property ThemeFooterLinks. 
        /// <para>
        /// The website links that display in the catalog page footer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThemeFooterLink> ThemeFooterLinks
        {
            get { return this._themeFooterLinks; }
            set { this._themeFooterLinks = value; }
        }

        // Check to see if ThemeFooterLinks property is set
        internal bool IsSetThemeFooterLinks()
        {
            return this._themeFooterLinks != null && (this._themeFooterLinks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThemeOrganizationLogoURL. 
        /// <para>
        /// The URL of the logo that displays in the catalog page header.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ThemeOrganizationLogoURL
        {
            get { return this._themeOrganizationLogoURL; }
            set { this._themeOrganizationLogoURL = value; }
        }

        // Check to see if ThemeOrganizationLogoURL property is set
        internal bool IsSetThemeOrganizationLogoURL()
        {
            return this._themeOrganizationLogoURL != null;
        }

        /// <summary>
        /// Gets and sets the property ThemeStyling. 
        /// <para>
        /// The color that is used for the website links, text, buttons, and catalog page background.
        /// </para>
        /// </summary>
        public ThemeStyling ThemeStyling
        {
            get { return this._themeStyling; }
            set { this._themeStyling = value; }
        }

        // Check to see if ThemeStyling property is set
        internal bool IsSetThemeStyling()
        {
            return this._themeStyling != null;
        }

        /// <summary>
        /// Gets and sets the property ThemeTitleText. 
        /// <para>
        /// The browser tab page title.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string ThemeTitleText
        {
            get { return this._themeTitleText; }
            set { this._themeTitleText = value; }
        }

        // Check to see if ThemeTitleText property is set
        internal bool IsSetThemeTitleText()
        {
            return this._themeTitleText != null;
        }

    }
}