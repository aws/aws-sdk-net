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
    /// Container for the parameters to the UpdateWebAppCustomization operation. Assigns new
    /// customization properties to a web app. You can modify the icon file, logo file, and
    /// title.
    /// </summary>
    public partial class UpdateWebAppCustomizationRequest : AmazonTransferRequest
    {
        /// <summary>
        /// Gets and sets the property FaviconFile. 
        /// <para>
        /// Specify an icon file data string (in base64 encoding).
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
        /// Specify logo file data string (in base64 encoding).
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
        /// Provide an updated title.
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
        /// Provide the identifier of the web app that you are updating.
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
