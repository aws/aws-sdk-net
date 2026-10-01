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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Contains the configuration information to customize the logo, font, and color of an
    /// Amazon Q Business web experience with individual files for each property or a CSS
    /// file for them all.
    /// </summary>
    public partial class CustomizationConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomCSSUrl. 
        /// <para>
        /// Provides the URL where the custom CSS file is hosted for an Amazon Q web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string CustomCSSUrl { get; set; }

        /// <summary>
        /// Checks to see if the CustomCSSUrl property is set.
        /// </summary>
        internal bool IsSetCustomCSSUrl() => this.CustomCSSUrl != null;

        /// <summary>
        /// Gets and sets the property FaviconUrl. 
        /// <para>
        /// Provides the URL where the custom favicon file is hosted for an Amazon Q web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string FaviconUrl { get; set; }

        /// <summary>
        /// Checks to see if the FaviconUrl property is set.
        /// </summary>
        internal bool IsSetFaviconUrl() => this.FaviconUrl != null;

        /// <summary>
        /// Gets and sets the property FontUrl. 
        /// <para>
        /// Provides the URL where the custom font file is hosted for an Amazon Q web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string FontUrl { get; set; }

        /// <summary>
        /// Checks to see if the FontUrl property is set.
        /// </summary>
        internal bool IsSetFontUrl() => this.FontUrl != null;

        /// <summary>
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// Provides the URL where the custom logo file is hosted for an Amazon Q web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogoUrl property is set.
        /// </summary>
        internal bool IsSetLogoUrl() => this.LogoUrl != null;
    }
}
