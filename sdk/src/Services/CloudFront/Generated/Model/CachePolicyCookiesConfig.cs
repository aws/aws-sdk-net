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
    /// An object that determines whether any cookies in viewer requests (and if so, which
    /// cookies) are included in the cache key and in requests that CloudFront sends to the
    /// origin.
    /// </summary>
    public partial class CachePolicyCookiesConfig
    {
        private CachePolicyCookieBehavior _cookieBehavior;
        private CookieNames _cookies;

        /// <summary>
        /// Gets and sets the property CookieBehavior. 
        /// <para>
        /// Determines whether any cookies in viewer requests are included in the cache key and
        /// in requests that CloudFront sends to the origin. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>none</code> – No cookies in viewer requests are included in the cache key or
        /// in requests that CloudFront sends to the origin. Even when this field is set to <code>none</code>,
        /// any cookies that are listed in an <code>OriginRequestPolicy</code> <i>are</i> included
        /// in origin requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>whitelist</code> – Only the cookies in viewer requests that are listed in the
        /// <code>CookieNames</code> type are included in the cache key and in requests that CloudFront
        /// sends to the origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>allExcept</code> – All cookies in viewer requests are included in the cache
        /// key and in requests that CloudFront sends to the origin, <i> <b>except</b> </i> for
        /// those that are listed in the <code>CookieNames</code> type, which are not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>all</code> – All cookies in viewer requests are included in the cache key and
        /// in requests that CloudFront sends to the origin.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public CachePolicyCookieBehavior CookieBehavior
        {
            get { return this._cookieBehavior; }
            set { this._cookieBehavior = value; }
        }

        // Check to see if CookieBehavior property is set
        internal bool IsSetCookieBehavior()
        {
            return this._cookieBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Cookies.
        /// </summary>
        public CookieNames Cookies
        {
            get { return this._cookies; }
            set { this._cookies = value; }
        }

        // Check to see if Cookies property is set
        internal bool IsSetCookies()
        {
            return this._cookies != null;
        }

    }
}