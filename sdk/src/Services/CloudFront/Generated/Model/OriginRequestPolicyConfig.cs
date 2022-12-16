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
    /// An origin request policy configuration.
    /// 
    ///  
    /// <para>
    /// This configuration determines the values that CloudFront includes in requests that
    /// it sends to the origin. Each request that CloudFront sends to the origin includes
    /// the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The request body and the URL path (without the domain name) from the viewer request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The headers that CloudFront automatically includes in every origin request, including
    /// <code>Host</code>, <code>User-Agent</code>, and <code>X-Amz-Cf-Id</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All HTTP headers, cookies, and URL query strings that are specified in the cache policy
    /// or the origin request policy. These can include items from the viewer request and,
    /// in the case of headers, additional ones that are added by CloudFront.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// CloudFront sends a request when it can't find an object in its cache that matches
    /// the request. If you want to send values to the origin and also include them in the
    /// cache key, use <code>CachePolicy</code>.
    /// </para>
    /// </summary>
    public partial class OriginRequestPolicyConfig
    {
        private string _comment;
        private OriginRequestPolicyCookiesConfig _cookiesConfig;
        private OriginRequestPolicyHeadersConfig _headersConfig;
        private string _name;
        private OriginRequestPolicyQueryStringsConfig _queryStringsConfig;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment to describe the origin request policy. The comment cannot be longer than
        /// 128 characters.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property CookiesConfig. 
        /// <para>
        /// The cookies from viewer requests to include in origin requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginRequestPolicyCookiesConfig CookiesConfig
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
        /// Gets and sets the property HeadersConfig. 
        /// <para>
        /// The HTTP headers to include in origin requests. These can include headers from viewer
        /// requests and additional headers added by CloudFront.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginRequestPolicyHeadersConfig HeadersConfig
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name to identify the origin request policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStringsConfig. 
        /// <para>
        /// The URL query strings from viewer requests to include in origin requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginRequestPolicyQueryStringsConfig QueryStringsConfig
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