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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
    /// The configuration that specifies which cookies should be synchronized from the end
    /// user's local browser to the remote browser.
    /// </summary>
    public partial class CookieSynchronizationConfiguration
    {
        private List<CookieSpecification> _allowlist = AWSConfigs.InitializeCollections ? new List<CookieSpecification>() : null;
        private List<CookieSpecification> _blocklist = AWSConfigs.InitializeCollections ? new List<CookieSpecification>() : null;

        /// <summary>
        /// Gets and sets the property Allowlist. 
        /// <para>
        /// The list of cookie specifications that are allowed to be synchronized to the remote
        /// browser.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<CookieSpecification> Allowlist
        {
            get { return this._allowlist; }
            set { this._allowlist = value; }
        }

        // Check to see if Allowlist property is set
        internal bool IsSetAllowlist()
        {
            return this._allowlist != null && (this._allowlist.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Blocklist. 
        /// <para>
        /// The list of cookie specifications that are blocked from being synchronized to the
        /// remote browser.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<CookieSpecification> Blocklist
        {
            get { return this._blocklist; }
            set { this._blocklist = value; }
        }

        // Check to see if Blocklist property is set
        internal bool IsSetBlocklist()
        {
            return this._blocklist != null && (this._blocklist.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}