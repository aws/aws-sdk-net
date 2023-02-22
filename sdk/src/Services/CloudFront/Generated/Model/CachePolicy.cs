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
    /// A cache policy.
    /// 
    ///  
    /// <para>
    /// When it's attached to a cache behavior, the cache policy determines the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The values that CloudFront includes in the cache key. These values can include HTTP
    /// headers, cookies, and URL query strings. CloudFront uses the cache key to find an
    /// object in its cache that it can return to the viewer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The default, minimum, and maximum time to live (TTL) values that you want objects
    /// to stay in the CloudFront cache.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The headers, cookies, and query strings that are included in the cache key are also
    /// included in requests that CloudFront sends to the origin. CloudFront sends a request
    /// when it can't find a valid object in its cache that matches the request's cache key.
    /// If you want to send values to the origin but <i>not</i> include them in the cache
    /// key, use <code>OriginRequestPolicy</code>.
    /// </para>
    /// </summary>
    public partial class CachePolicy
    {
        private CachePolicyConfig _cachePolicyConfig;
        private string _id;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property CachePolicyConfig. 
        /// <para>
        /// The cache policy configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CachePolicyConfig CachePolicyConfig
        {
            get { return this._cachePolicyConfig; }
            set { this._cachePolicyConfig = value; }
        }

        // Check to see if CachePolicyConfig property is set
        internal bool IsSetCachePolicyConfig()
        {
            return this._cachePolicyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the cache policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time when the cache policy was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}