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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Determines whether CloudFront includes the <code>Strict-Transport-Security</code>
    /// HTTP response header and the header's value.
    /// 
    ///  
    /// <para>
    /// For more information about the <code>Strict-Transport-Security</code> HTTP response
    /// header, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Strict-Transport-Security">Strict-Transport-Security</a>
    /// in the MDN Web Docs.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyStrictTransportSecurity
    {
        private int? _accessControlMaxAgeSec;
        private bool? _includeSubdomains;
        private bool? _override;
        private bool? _preload;

        /// <summary>
        /// Gets and sets the property AccessControlMaxAgeSec. 
        /// <para>
        /// A number that CloudFront uses as the value for the <code>max-age</code> directive
        /// in the <code>Strict-Transport-Security</code> HTTP response header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int AccessControlMaxAgeSec
        {
            get { return this._accessControlMaxAgeSec.GetValueOrDefault(); }
            set { this._accessControlMaxAgeSec = value; }
        }

        // Check to see if AccessControlMaxAgeSec property is set
        internal bool IsSetAccessControlMaxAgeSec()
        {
            return this._accessControlMaxAgeSec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeSubdomains. 
        /// <para>
        /// A Boolean that determines whether CloudFront includes the <code>includeSubDomains</code>
        /// directive in the <code>Strict-Transport-Security</code> HTTP response header.
        /// </para>
        /// </summary>
        public bool IncludeSubdomains
        {
            get { return this._includeSubdomains.GetValueOrDefault(); }
            set { this._includeSubdomains = value; }
        }

        // Check to see if IncludeSubdomains property is set
        internal bool IsSetIncludeSubdomains()
        {
            return this._includeSubdomains.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// A Boolean that determines whether CloudFront overrides the <code>Strict-Transport-Security</code>
        /// HTTP response header received from the origin with the one specified in this response
        /// headers policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Override
        {
            get { return this._override.GetValueOrDefault(); }
            set { this._override = value; }
        }

        // Check to see if Override property is set
        internal bool IsSetOverride()
        {
            return this._override.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Preload. 
        /// <para>
        /// A Boolean that determines whether CloudFront includes the <code>preload</code> directive
        /// in the <code>Strict-Transport-Security</code> HTTP response header.
        /// </para>
        /// </summary>
        public bool Preload
        {
            get { return this._preload.GetValueOrDefault(); }
            set { this._preload = value; }
        }

        // Check to see if Preload property is set
        internal bool IsSetPreload()
        {
            return this._preload.HasValue; 
        }

    }
}