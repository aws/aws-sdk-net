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
    /// An origin request policy.
    /// 
    ///  
    /// <para>
    /// When it's attached to a cache behavior, the origin request policy determines the values
    /// that CloudFront includes in requests that it sends to the origin. Each request that
    /// CloudFront sends to the origin includes the following:
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
    public partial class OriginRequestPolicy
    {
        private string _id;
        private DateTime? _lastModifiedTime;
        private OriginRequestPolicyConfig _originRequestPolicyConfig;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the origin request policy.
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
        /// The date and time when the origin request policy was last modified.
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

        /// <summary>
        /// Gets and sets the property OriginRequestPolicyConfig. 
        /// <para>
        /// The origin request policy configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginRequestPolicyConfig OriginRequestPolicyConfig
        {
            get { return this._originRequestPolicyConfig; }
            set { this._originRequestPolicyConfig = value; }
        }

        // Check to see if OriginRequestPolicyConfig property is set
        internal bool IsSetOriginRequestPolicyConfig()
        {
            return this._originRequestPolicyConfig != null;
        }

    }
}