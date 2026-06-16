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
    /// Configuration for URL redirection in a specific direction (host-to-client or client-to-host).
    /// When enabled, URLs matching the allowed or denied patterns are redirected accordingly.
    /// The denied list takes precedence over the allowed list.
    /// </summary>
    public partial class UrlRedirectionConfig
    {
        private List<string> _allowedUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _deniedUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property AllowedUrls. 
        /// <para>
        /// List of URL patterns that are allowed to be redirected. URLs matching these patterns
        /// will be redirected unless they also match a pattern in the denied list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property DeniedUrls. 
        /// <para>
        /// List of URL patterns that are denied from redirection. This list takes precedence
        /// over the allowed list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> DeniedUrls
        {
            get { return this._deniedUrls; }
            set { this._deniedUrls = value; }
        }

        // Check to see if DeniedUrls property is set
        internal bool IsSetDeniedUrls()
        {
            return this._deniedUrls != null && (this._deniedUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether URL redirection is enabled for this direction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}