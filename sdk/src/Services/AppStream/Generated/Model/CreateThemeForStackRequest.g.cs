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
    /// Container for the parameters to the CreateThemeForStack operation. Creates custom
    /// branding that customizes the appearance of the streaming application catalog page.
    /// </summary>
    public partial class CreateThemeForStackRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property FaviconS3Location. 
        /// <para>
        /// The S3 location of the favicon. The favicon enables users to recognize their application
        /// streaming site in a browser full of tabs or bookmarks. It is displayed at the top
        /// of the browser tab for the application streaming site during users' streaming sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Location FaviconS3Location { get; set; }

        /// <summary>
        /// Checks to see if the FaviconS3Location property is set.
        /// </summary>
        internal bool IsSetFaviconS3Location() => this.FaviconS3Location != null;

        /// <summary>
        /// Gets and sets the property FooterLinks. 
        /// <para>
        /// The links that are displayed in the footer of the streaming application catalog page.
        /// These links are helpful resources for users, such as the organization's IT support
        /// and product marketing sites.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThemeFooterLink> FooterLinks { get; set; } = AWSConfigs.InitializeCollections ? new List<ThemeFooterLink>() : null;

        /// <summary>
        /// Checks to see if the FooterLinks property is set.
        /// </summary>
        internal bool IsSetFooterLinks() => this.FooterLinks != null && (this.FooterLinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationLogoS3Location. 
        /// <para>
        /// The organization logo that appears on the streaming application catalog page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Location OrganizationLogoS3Location { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationLogoS3Location property is set.
        /// </summary>
        internal bool IsSetOrganizationLogoS3Location() => this.OrganizationLogoS3Location != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack for the theme.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property ThemeStyling. 
        /// <para>
        /// The color theme that is applied to website links, text, and buttons. These colors
        /// are also applied as accents in the background for the streaming application catalog
        /// page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ThemeStyling ThemeStyling { get; set; }

        /// <summary>
        /// Checks to see if the ThemeStyling property is set.
        /// </summary>
        internal bool IsSetThemeStyling() => this.ThemeStyling != null;

        /// <summary>
        /// Gets and sets the property TitleText. 
        /// <para>
        /// The title that is displayed at the top of the browser tab during users' application
        /// streaming sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string TitleText { get; set; }

        /// <summary>
        /// Checks to see if the TitleText property is set.
        /// </summary>
        internal bool IsSetTitleText() => this.TitleText != null;
    }
}
