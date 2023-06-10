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
    /// An object that determines whether any HTTP headers (and if so, which headers) are
    /// included in requests that CloudFront sends to the origin.
    /// </summary>
    public partial class OriginRequestPolicyHeadersConfig
    {
        private OriginRequestPolicyHeaderBehavior _headerBehavior;
        private Headers _headers;

        /// <summary>
        /// Gets and sets the property HeaderBehavior. 
        /// <para>
        /// Determines whether any HTTP headers are included in requests that CloudFront sends
        /// to the origin. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>none</code> – No HTTP headers in viewer requests are included in requests that
        /// CloudFront sends to the origin. Even when this field is set to <code>none</code>,
        /// any headers that are listed in a <code>CachePolicy</code> <i>are</i> included in origin
        /// requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>whitelist</code> – Only the HTTP headers that are listed in the <code>Headers</code>
        /// type are included in requests that CloudFront sends to the origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>allViewer</code> – All HTTP headers in viewer requests are included in requests
        /// that CloudFront sends to the origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>allViewerAndWhitelistCloudFront</code> – All HTTP headers in viewer requests
        /// and the additional CloudFront headers that are listed in the <code>Headers</code>
        /// type are included in requests that CloudFront sends to the origin. The additional
        /// headers are added by CloudFront.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>allExcept</code> – All HTTP headers in viewer requests are included in requests
        /// that CloudFront sends to the origin, <i> <b>except</b> </i> for those listed in the
        /// <code>Headers</code> type, which are not included.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginRequestPolicyHeaderBehavior HeaderBehavior
        {
            get { return this._headerBehavior; }
            set { this._headerBehavior = value; }
        }

        // Check to see if HeaderBehavior property is set
        internal bool IsSetHeaderBehavior()
        {
            return this._headerBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Headers.
        /// </summary>
        public Headers Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null;
        }

    }
}