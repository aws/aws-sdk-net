/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// This object determines the values that CloudFront includes in the cache key. These
    /// values can include HTTP headers, cookies, and URL query strings. CloudFront uses the
    /// cache key to find an object in its cache that it can return to the viewer.
    /// 
    ///  
    /// <para>
    /// The headers, cookies, and query strings that are included in the cache key are automatically
    /// included in requests that CloudFront sends to the origin. CloudFront sends a request
    /// when it can’t find an object in its cache that matches the request’s cache key. If
    /// you want to send values to the origin but <i>not</i> include them in the cache key,
    /// use <code>CreateOriginRequestPolicy</code>.
    /// </para>
    /// </summary>
    public partial class ParametersInCacheKeyAndForwardedToOrigin
    {
        private CachePolicyCookiesConfig _cookiesConfig;
        private bool? _enableAcceptEncodingGzip;
        private CachePolicyHeadersConfig _headersConfig;
        private CachePolicyQueryStringsConfig _queryStringsConfig;

        /// <summary>
        /// Gets and sets the property CookiesConfig. 
        /// <para>
        /// An object that determines whether any cookies in viewer requests (and if so, which
        /// cookies) are included in the cache key and automatically included in requests that
        /// CloudFront sends to the origin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CachePolicyCookiesConfig CookiesConfig
        {
            get { return this._cookiesConfig; }
            set { this._cookiesConfig = value; }
        }

        // Check to see if CookiesConfig property is set
        internal bool IsSetCookiesConfig()
        {
            return this._cookiesConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EnableAcceptEncodingGzip. 
        /// <para>
        /// A flag that determines whether the <code>Accept-Encoding</code> HTTP header is included
        /// in the cache key and included in requests that CloudFront sends to the origin.
        /// </para>
        ///  
        /// <para>
        /// If this field is <code>true</code> <i>and</i> the viewer request includes the <code>Accept-Encoding</code>
        /// header, then CloudFront normalizes the value of the viewer’s <code>Accept-Encoding</code>
        /// header to one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Accept-Encoding: gzip</code> (if <code>gzip</code> is in the viewer’s <code>Accept-Encoding</code>
        /// header)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Accept-Encoding: identity</code> (if <code>gzip</code> is <i>not</i> in the
        /// viewer’s <code>Accept-Encoding</code> header)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// CloudFront includes the normalized header in the cache key and includes it in requests
        /// that CloudFront sends to the origin.
        /// </para>
        ///  
        /// <para>
        /// If this field is <code>false</code>, then CloudFront treats the <code>Accept-Encoding</code>
        /// header the same as any other HTTP header in the viewer request. By default, it’s not
        /// included in the cache key and it’s not included in origin requests. You can manually
        /// add <code>Accept-Encoding</code> to the headers whitelist like any other HTTP header.
        /// </para>
        ///  
        /// <para>
        /// When this field is <code>true</code>, you should not whitelist the <code>Accept-Encoding</code>
        /// header in the cache policy or in an origin request policy attached to the same cache
        /// behavior.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-policy-compressed-objects">Cache
        /// compressed objects</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableAcceptEncodingGzip
        {
            get { return this._enableAcceptEncodingGzip.GetValueOrDefault(); }
            set { this._enableAcceptEncodingGzip = value; }
        }

        // Check to see if EnableAcceptEncodingGzip property is set
        internal bool IsSetEnableAcceptEncodingGzip()
        {
            return this._enableAcceptEncodingGzip.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeadersConfig. 
        /// <para>
        /// An object that determines whether any HTTP headers (and if so, which headers) are
        /// included in the cache key and automatically included in requests that CloudFront sends
        /// to the origin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CachePolicyHeadersConfig HeadersConfig
        {
            get { return this._headersConfig; }
            set { this._headersConfig = value; }
        }

        // Check to see if HeadersConfig property is set
        internal bool IsSetHeadersConfig()
        {
            return this._headersConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStringsConfig. 
        /// <para>
        /// An object that determines whether any URL query strings in viewer requests (and if
        /// so, which query strings) are included in the cache key and automatically included
        /// in requests that CloudFront sends to the origin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CachePolicyQueryStringsConfig QueryStringsConfig
        {
            get { return this._queryStringsConfig; }
            set { this._queryStringsConfig = value; }
        }

        // Check to see if QueryStringsConfig property is set
        internal bool IsSetQueryStringsConfig()
        {
            return this._queryStringsConfig != null;
        }

    }
}