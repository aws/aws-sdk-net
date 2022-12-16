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
    /// Container for the parameters to the CreateCachePolicy operation.
    /// Creates a cache policy.
    /// 
    ///  
    /// <para>
    /// After you create a cache policy, you can attach it to one or more cache behaviors.
    /// When it's attached to a cache behavior, the cache policy determines the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The values that CloudFront includes in the <i>cache key</i>. These values can include
    /// HTTP headers, cookies, and URL query strings. CloudFront uses the cache key to find
    /// an object in its cache that it can return to the viewer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The default, minimum, and maximum time to live (TTL) values that you want objects
    /// to stay in the CloudFront cache.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The headers, cookies, and query strings that are included in the cache key are automatically
    /// included in requests that CloudFront sends to the origin. CloudFront sends a request
    /// when it can't find an object in its cache that matches the request's cache key. If
    /// you want to send values to the origin but <i>not</i> include them in the cache key,
    /// use <code>OriginRequestPolicy</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information about cache policies, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html">Controlling
    /// the cache key</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateCachePolicyRequest : AmazonCloudFrontRequest
    {
        private CachePolicyConfig _cachePolicyConfig;

        /// <summary>
        /// Gets and sets the property CachePolicyConfig. 
        /// <para>
        /// A cache policy configuration.
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

    }
}