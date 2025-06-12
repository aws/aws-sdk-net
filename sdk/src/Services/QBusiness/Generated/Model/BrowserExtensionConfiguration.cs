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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
    /// The container for browser extension configuration for an Amazon Q Business web experience.
    /// </summary>
    public partial class BrowserExtensionConfiguration
    {
        private List<string> _enabledBrowserExtensions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EnabledBrowserExtensions. 
        /// <para>
        /// Specify the browser extensions allowed for your Amazon Q web experience.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CHROME</c> — Enables the extension for Chromium-based browsers (Google Chrome,
        /// Microsoft Edge, Opera, etc.).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIREFOX</c> — Enables the extension for Mozilla Firefox.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHROME</c> and <c>FIREFOX</c> — Enable the extension for Chromium-based browsers
        /// and Mozilla Firefox.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2)]
        public List<string> EnabledBrowserExtensions
        {
            get { return this._enabledBrowserExtensions; }
            set { this._enabledBrowserExtensions = value; }
        }

        // Check to see if EnabledBrowserExtensions property is set
        internal bool IsSetEnabledBrowserExtensions()
        {
            return this._enabledBrowserExtensions != null && (this._enabledBrowserExtensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}