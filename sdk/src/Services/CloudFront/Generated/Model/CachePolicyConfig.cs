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
    /// A cache policy configuration.
    /// 
    ///  
    /// <para>
    /// This configuration determines the following:
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
    /// The headers, cookies, and query strings that are included in the cache key are automatically
    /// included in requests that CloudFront sends to the origin. CloudFront sends a request
    /// when it can't find a valid object in its cache that matches the request's cache key.
    /// If you want to send values to the origin but <i>not</i> include them in the cache
    /// key, use <code>OriginRequestPolicy</code>.
    /// </para>
    /// </summary>
    public partial class CachePolicyConfig
    {
        private string _comment;
        private long? _defaultTTL;
        private long? _maxTTL;
        private long? _minTTL;
        private string _name;
        private ParametersInCacheKeyAndForwardedToOrigin _parametersInCacheKeyAndForwardedToOrigin;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment to describe the cache policy. The comment cannot be longer than 128 characters.
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
        /// Gets and sets the property DefaultTTL. 
        /// <para>
        /// The default amount of time, in seconds, that you want objects to stay in the CloudFront
        /// cache before CloudFront sends another request to the origin to see if the object has
        /// been updated. CloudFront uses this value as the object's time to live (TTL) only when
        /// the origin does <i>not</i> send <code>Cache-Control</code> or <code>Expires</code>
        /// headers with the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Managing
        /// How Long Content Stays in an Edge Cache (Expiration)</a> in the <i>Amazon CloudFront
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The default value for this field is 86400 seconds (one day). If the value of <code>MinTTL</code>
        /// is more than 86400 seconds, then the default value for this field is the same as the
        /// value of <code>MinTTL</code>.
        /// </para>
        /// </summary>
        public long DefaultTTL
        {
            get { return this._defaultTTL.GetValueOrDefault(); }
            set { this._defaultTTL = value; }
        }

        // Check to see if DefaultTTL property is set
        internal bool IsSetDefaultTTL()
        {
            return this._defaultTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxTTL. 
        /// <para>
        /// The maximum amount of time, in seconds, that objects stay in the CloudFront cache
        /// before CloudFront sends another request to the origin to see if the object has been
        /// updated. CloudFront uses this value only when the origin sends <code>Cache-Control</code>
        /// or <code>Expires</code> headers with the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Managing
        /// How Long Content Stays in an Edge Cache (Expiration)</a> in the <i>Amazon CloudFront
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The default value for this field is 31536000 seconds (one year). If the value of <code>MinTTL</code>
        /// or <code>DefaultTTL</code> is more than 31536000 seconds, then the default value for
        /// this field is the same as the value of <code>DefaultTTL</code>.
        /// </para>
        /// </summary>
        public long MaxTTL
        {
            get { return this._maxTTL.GetValueOrDefault(); }
            set { this._maxTTL = value; }
        }

        // Check to see if MaxTTL property is set
        internal bool IsSetMaxTTL()
        {
            return this._maxTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinTTL. 
        /// <para>
        /// The minimum amount of time, in seconds, that you want objects to stay in the CloudFront
        /// cache before CloudFront sends another request to the origin to see if the object has
        /// been updated. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Managing
        /// How Long Content Stays in an Edge Cache (Expiration)</a> in the <i>Amazon CloudFront
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long MinTTL
        {
            get { return this._minTTL.GetValueOrDefault(); }
            set { this._minTTL = value; }
        }

        // Check to see if MinTTL property is set
        internal bool IsSetMinTTL()
        {
            return this._minTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name to identify the cache policy.
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
        /// Gets and sets the property ParametersInCacheKeyAndForwardedToOrigin. 
        /// <para>
        /// The HTTP headers, cookies, and URL query strings to include in the cache key. The
        /// values included in the cache key are automatically included in requests that CloudFront
        /// sends to the origin.
        /// </para>
        /// </summary>
        public ParametersInCacheKeyAndForwardedToOrigin ParametersInCacheKeyAndForwardedToOrigin
        {
            get { return this._parametersInCacheKeyAndForwardedToOrigin; }
            set { this._parametersInCacheKeyAndForwardedToOrigin = value; }
        }

        // Check to see if ParametersInCacheKeyAndForwardedToOrigin property is set
        internal bool IsSetParametersInCacheKeyAndForwardedToOrigin()
        {
            return this._parametersInCacheKeyAndForwardedToOrigin != null;
        }

    }
}