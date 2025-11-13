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
    /// The policy that specifies which URLs end users are allowed to access or which URLs
    /// or domain categories they are restricted from accessing for enhanced security.
    /// </summary>
    public partial class WebContentFilteringPolicy
    {
        private List<string> _allowedUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _blockedCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _blockedUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedUrls. 
        /// <para>
        /// URLs and domains that are always accessible to end users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<string> AllowedUrls
        {
            get { return this._allowedUrls; }
            set { this._allowedUrls = value; }
        }

        // Check to see if AllowedUrls property is set
        internal bool IsSetAllowedUrls()
        {
            return this._allowedUrls != null && (this._allowedUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BlockedCategories. 
        /// <para>
        /// Categories of websites that are blocked on the end user’s browsers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> BlockedCategories
        {
            get { return this._blockedCategories; }
            set { this._blockedCategories = value; }
        }

        // Check to see if BlockedCategories property is set
        internal bool IsSetBlockedCategories()
        {
            return this._blockedCategories != null && (this._blockedCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BlockedUrls. 
        /// <para>
        /// URLs and domains that end users cannot access.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<string> BlockedUrls
        {
            get { return this._blockedUrls; }
            set { this._blockedUrls = value; }
        }

        // Check to see if BlockedUrls property is set
        internal bool IsSetBlockedUrls()
        {
            return this._blockedUrls != null && (this._blockedUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}