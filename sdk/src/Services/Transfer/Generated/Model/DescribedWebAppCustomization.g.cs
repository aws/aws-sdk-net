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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// A structure that contains the customization fields for the web app. You can provide
    /// a title, logo, and icon to customize the appearance of your web app.
    /// </summary>
    public partial class DescribedWebAppCustomization
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Returns the Amazon Resource Name (ARN) for the web app.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property FaviconFile. 
        /// <para>
        /// Returns an icon file data string (in base64 encoding).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 20960)]
        public MemoryStream FaviconFile { get; set; }

        /// <summary>
        /// Checks to see if the FaviconFile property is set.
        /// </summary>
        internal bool IsSetFaviconFile() => this.FaviconFile != null;

        /// <summary>
        /// Gets and sets the property LogoFile. 
        /// <para>
        /// Returns a logo file data string (in base64 encoding).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public MemoryStream LogoFile { get; set; }

        /// <summary>
        /// Checks to see if the LogoFile property is set.
        /// </summary>
        internal bool IsSetLogoFile() => this.LogoFile != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Returns the page title that you defined for your web app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property WebAppId. 
        /// <para>
        /// Returns the unique identifier for your web app.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 24, Max = 24)]
        public string WebAppId { get; set; }

        /// <summary>
        /// Checks to see if the WebAppId property is set.
        /// </summary>
        internal bool IsSetWebAppId() => this.WebAppId != null;
    }
}
