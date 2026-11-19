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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// key, use <c>OriginRequestPolicy</c>.
    /// </para>
    /// </summary>
    public partial class CachePolicy
    {
        /// <summary>
        /// Gets and sets the property CachePolicyConfig. 
        /// <para>
        /// The cache policy configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CachePolicyConfig CachePolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the CachePolicyConfig property is set.
        /// </summary>
        internal bool IsSetCachePolicyConfig() => this.CachePolicyConfig != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the cache policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time when the cache policy was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;
    }
}
