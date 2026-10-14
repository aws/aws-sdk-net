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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The optional response-caching configuration shared by the HTTP-based function types
    /// (<c>HTTP_REQUEST</c>, <c>AWS_SERVICE_REQUEST</c>, and <c>VAST_REQUEST</c>). When you
    /// provide this configuration, MediaTailor caches the function's responses that have
    /// one of the following HTTP status codes: <c>200</c>, <c>203</c>, <c>204</c>, <c>404</c>,
    /// <c>405</c>, <c>410</c>, <c>414</c>, and <c>501</c>. For a cacheable response, MediaTailor
    /// caches it for the number of seconds given by the response's <c>Cache-Control</c> <c>max-age</c>
    /// directive, limited to the range between <c>TtlMinimumSeconds</c> and <c>TtlMaximumSeconds</c>.
    /// If the response has no <c>Cache-Control</c> <c>max-age</c> directive, MediaTailor
    /// caches it for <c>TtlMinimumSeconds</c> seconds. Cached HTTP responses are scoped per
    /// playback configuration, not per function.
    /// </summary>
    public partial class HttpRequestCacheConfiguration
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// A JSONata expression that MediaTailor evaluates to a custom cache key. By default,
        /// the cache key is a hash of the HTTP URL, the request body, and the HTTP method; request
        /// headers are not included. You can specify a custom cache key expression to vary caching
        /// by request headers and more. The evaluated key must be smaller than 1 KB; otherwise
        /// the HTTP function will fail.
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property TtlMaximumSeconds. 
        /// <para>
        /// The upper bound, in seconds, on how long MediaTailor caches a response. This value
        /// must be greater than or equal to <c>TtlMinimumSeconds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? TtlMaximumSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TtlMaximumSeconds property is set.
        /// </summary>
        internal bool IsSetTtlMaximumSeconds() => this.TtlMaximumSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TtlMinimumSeconds. 
        /// <para>
        /// The lower bound, in seconds, on how long MediaTailor caches a response. MediaTailor
        /// also uses this value as the cache duration when a response has no <c>Cache-Control</c>
        /// <c>max-age</c> directive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? TtlMinimumSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TtlMinimumSeconds property is set.
        /// </summary>
        internal bool IsSetTtlMinimumSeconds() => this.TtlMinimumSeconds.HasValue;
    }
}
