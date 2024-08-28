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
    /// The website links that display in the catalog page footer.
    /// </summary>
    public partial class ThemeFooterLink
    {
        private string _displayName;
        private string _footerLinkURL;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the websites that display in the catalog page footer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FooterLinkURL. 
        /// <para>
        /// The URL of the websites that display in the catalog page footer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string FooterLinkURL
        {
            get { return this._footerLinkURL; }
            set { this._footerLinkURL = value; }
        }

        // Check to see if FooterLinkURL property is set
        internal bool IsSetFooterLinkURL()
        {
            return this._footerLinkURL != null;
        }

    }
}