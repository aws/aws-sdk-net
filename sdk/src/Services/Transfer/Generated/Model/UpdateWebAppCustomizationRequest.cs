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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
    /// Container for the parameters to the UpdateWebAppCustomization operation.
    /// Assigns new customization properties to a web app. You can modify the icon file, logo
    /// file, and title.
    /// </summary>
    public partial class UpdateWebAppCustomizationRequest : AmazonTransferRequest
    {
        private MemoryStream _faviconFile;
        private MemoryStream _logoFile;
        private string _title;
        private string _webAppId;

        /// <summary>
        /// Gets and sets the property FaviconFile. 
        /// <para>
        /// Specify an icon file data string (in base64 encoding).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=20960)]
        public MemoryStream FaviconFile
        {
            get { return this._faviconFile; }
            set { this._faviconFile = value; }
        }

        // Check to see if FaviconFile property is set
        internal bool IsSetFaviconFile()
        {
            return this._faviconFile != null;
        }

        /// <summary>
        /// Gets and sets the property LogoFile. 
        /// <para>
        /// Specify logo file data string (in base64 encoding).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=51200)]
        public MemoryStream LogoFile
        {
            get { return this._logoFile; }
            set { this._logoFile = value; }
        }

        // Check to see if LogoFile property is set
        internal bool IsSetLogoFile()
        {
            return this._logoFile != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Provide an updated title.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property WebAppId. 
        /// <para>
        /// Provide the identifier of the web app that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string WebAppId
        {
            get { return this._webAppId; }
            set { this._webAppId = value; }
        }

        // Check to see if WebAppId property is set
        internal bool IsSetWebAppId()
        {
            return this._webAppId != null;
        }

    }
}