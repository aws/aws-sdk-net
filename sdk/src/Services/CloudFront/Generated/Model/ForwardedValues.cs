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
 * Do not modify this file. This file is generated from the cloudfront-2016-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that specifies how CloudFront handles query strings, cookies and headers.
    /// </summary>
    public partial class ForwardedValues
    {
        private CookiePreference _cookies;
        private Headers _headers;
        private bool? _queryString;
        private QueryStringCacheKeys _queryStringCacheKeys;

        /// <summary>
        /// Gets and sets the property Cookies. A complex type that specifies how CloudFront handles
        /// cookies.
        /// </summary>
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
        /// Gets and sets the property Headers. A complex type that specifies the Headers, if
        /// any, that you want CloudFront to vary upon for this cache behavior.
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
        /// Indicates whether you want CloudFront to forward query strings to the origin that
        /// is associated with this cache behavior and cache based on the query string parameters.
        /// CloudFront behavior depends on the value of QueryString and on the values that you
        /// specify for QueryStringCacheKeys, if any:
        /// </para>
        ///  <ul> <li>If you specify true for QueryString and you don't specify any values for
        /// QueryStringCacheKeys, CloudFront forwards all query string parameters to the origin
        /// and caches based on all query string parameters. Depending on how many query string
        /// parameters and values you have, this can adversely affect performance because CloudFront
        /// must forward more requests to the origin.</li> <li>If you specify true for QueryString
        /// and you specify one or more values for QueryStringCacheKeys, CloudFront forwards all
        /// query string parameters to the origin, but it only caches based on the query string
        /// parameters that you specify.</li> <li>If you specify false for QueryString, CloudFront
        /// doesn't forward any query string parameters to the origin, and doesn't cache based
        /// on query string parameters.</li> </ul>
        /// </summary>
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