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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An object that determines whether any cookies in viewer requests (and if so, which
    /// cookies) are included in requests that CloudFront sends to the origin.
    /// </summary>
    public partial class OriginRequestPolicyCookiesConfig
    {
        private OriginRequestPolicyCookieBehavior _cookieBehavior;
        private CookieNames _cookies;

        /// <summary>
        /// Gets and sets the property CookieBehavior. 
        /// <para>
        /// Determines whether cookies in viewer requests are included in requests that CloudFront
        /// sends to the origin. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>none</c> – No cookies in viewer requests are included in requests that CloudFront
        /// sends to the origin. Even when this field is set to <c>none</c>, any cookies that
        /// are listed in a <c>CachePolicy</c> <i>are</i> included in origin requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>whitelist</c> – Only the cookies in viewer requests that are listed in the <c>CookieNames</c>
        /// type are included in requests that CloudFront sends to the origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>all</c> – All cookies in viewer requests are included in requests that CloudFront
        /// sends to the origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>allExcept</c> – All cookies in viewer requests are included in requests that CloudFront
        /// sends to the origin, <i> <b>except</b> </i> for those listed in the <c>CookieNames</c>
        /// type, which are not included.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginRequestPolicyCookieBehavior CookieBehavior
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