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
    /// This field is deprecated. We recommend that you use a cache policy or an origin request
    /// policy instead of this field.
    /// 
    ///  
    /// <para>
    /// If you want to include values in the cache key, use a <code>CachePolicy</code>. See
    /// <code>CreateCachePolicy</code>.
    /// </para>
    ///  
    /// <para>
    /// If you want to send values to the origin but not include them in the cache key, use
    /// an <code>OriginRequestPolicy</code>. See <code>CreateOriginRequestPolicy</code>.
    /// </para>
    ///  
    /// <para>
    /// A complex type that specifies how CloudFront handles query strings, cookies, and HTTP
    /// headers.
    /// </para>
    /// </summary>
    public partial class ForwardedValues
    {
        private CookiePreference _cookies;
        private Headers _headers;
        private bool? _queryString;
        private QueryStringCacheKeys _queryStringCacheKeys;

        /// <summary>
        /// Gets and sets the property Cookies. 
        /// <para>
        /// This field is deprecated. We recommend that you use a cache policy or an origin request
        /// policy instead of this field.
        /// </para>
        ///  
        /// <para>
        /// If you want to include cookies in the cache key, use <code>CookiesConfig</code> in
        /// a cache policy. See <code>CreateCachePolicy</code>.
        /// </para>
        ///  
        /// <para>
        /// If you want to send cookies to the origin but not include them in the cache key, use
        /// <code>CookiesConfig</code> in an origin request policy. See <code>CreateOriginRequestPolicy</code>.
        /// </para>
        ///  
        /// <para>
        /// A complex type that specifies whether you want CloudFront to forward cookies to the
        /// origin and, if so, which ones. For more information about forwarding cookies to the
        /// origin, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Cookies.html">How
        /// CloudFront Forwards, Caches, and Logs Cookies</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CookiePreference Cookies
        {
            get { return this._cookies; }
            set { this._cookies = value; }
        }

        // Check to see if Cookies property is set
        internal bool IsSetCookies()
        {
            return this._cookies != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// This field is deprecated. We recommend that you use a cache policy or an origin request
        /// policy instead of this field.
        /// </para>
        ///  
        /// <para>
        /// If you want to include headers in the cache key, use <code>HeadersConfig</code> in
        /// a cache policy. See <code>CreateCachePolicy</code>.
        /// </para>
        ///  
        /// <para>
        /// If you want to send headers to the origin but not include them in the cache key, use
        /// <code>HeadersConfig</code> in an origin request policy. See <code>CreateOriginRequestPolicy</code>.
        /// </para>
        ///  
        /// <para>
        /// A complex type that specifies the <code>Headers</code>, if any, that you want CloudFront
        /// to forward to the origin for this cache behavior (whitelisted headers). For the headers
        /// that you specify, CloudFront also caches separate versions of a specified object that
        /// is based on the header values in viewer requests.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/header-caching.html">
        /// Caching Content Based on Request Headers</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// This field is deprecated. We recommend that you use a cache policy or an origin request
        /// policy instead of this field.
        /// </para>
        ///  
        /// <para>
        /// If you want to include query strings in the cache key, use <code>QueryStringsConfig</code>
        /// in a cache policy. See <code>CreateCachePolicy</code>.
        /// </para>
        ///  
        /// <para>
        /// If you want to send query strings to the origin but not include them in the cache
        /// key, use <code>QueryStringsConfig</code> in an origin request policy. See <code>CreateOriginRequestPolicy</code>.
        /// </para>
        ///  
        /// <para>
        /// Indicates whether you want CloudFront to forward query strings to the origin that
        /// is associated with this cache behavior and cache based on the query string parameters.
        /// CloudFront behavior depends on the value of <code>QueryString</code> and on the values
        /// that you specify for <code>QueryStringCacheKeys</code>, if any:
        /// </para>
        ///  
        /// <para>
        /// If you specify true for <code>QueryString</code> and you don't specify any values
        /// for <code>QueryStringCacheKeys</code>, CloudFront forwards all query string parameters
        /// to the origin and caches based on all query string parameters. Depending on how many
        /// query string parameters and values you have, this can adversely affect performance
        /// because CloudFront must forward more requests to the origin.
        /// </para>
        ///  
        /// <para>
        /// If you specify true for <code>QueryString</code> and you specify one or more values
        /// for <code>QueryStringCacheKeys</code>, CloudFront forwards all query string parameters
        /// to the origin, but it only caches based on the query string parameters that you specify.
        /// </para>
        ///  
        /// <para>
        /// If you specify false for <code>QueryString</code>, CloudFront doesn't forward any
        /// query string parameters to the origin, and doesn't cache based on query string parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/QueryStringParameters.html">Configuring
        /// CloudFront to Cache Based on Query String Parameters</a> in the <i>Amazon CloudFront
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool QueryString
        {
            get { return this._queryString.GetValueOrDefault(); }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryStringCacheKeys. 
        /// <para>
        /// This field is deprecated. We recommend that you use a cache policy or an origin request
        /// policy instead of this field.
        /// </para>
        ///  
        /// <para>
        /// If you want to include query strings in the cache key, use <code>QueryStringsConfig</code>
        /// in a cache policy. See <code>CreateCachePolicy</code>.
        /// </para>
        ///  
        /// <para>
        /// If you want to send query strings to the origin but not include them in the cache
        /// key, use an <code>QueryStringsConfig</code> in an origin request policy. See <code>CreateOriginRequestPolicy</code>.
        /// </para>
        ///  
        /// <para>
        /// A complex type that contains information about the query string parameters that you
        /// want CloudFront to use for caching for this cache behavior.
        /// </para>
        /// </summary>
        public QueryStringCacheKeys QueryStringCacheKeys
        {
            get { return this._queryStringCacheKeys; }
            set { this._queryStringCacheKeys = value; }
        }

        // Check to see if QueryStringCacheKeys property is set
        internal bool IsSetQueryStringCacheKeys()
        {
            return this._queryStringCacheKeys != null;
        }

    }
}