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
    /// A configuration for a set of HTTP response headers that are used for cross-origin
    /// resource sharing (CORS). CloudFront adds these headers to HTTP responses that it sends
    /// for CORS requests that match a cache behavior associated with this response headers
    /// policy.
    /// 
    ///  
    /// <para>
    /// For more information about CORS, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS">Cross-Origin
    /// Resource Sharing (CORS)</a> in the MDN Web Docs.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyCorsConfig
    {
        /// <summary>
        /// Gets and sets the property AccessControlAllowCredentials. 
        /// <para>
        /// A Boolean that CloudFront uses as the value for the <c>Access-Control-Allow-Credentials</c>
        /// HTTP response header.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Access-Control-Allow-Credentials</c> HTTP response
        /// header, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Credentials">Access-Control-Allow-Credentials</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AccessControlAllowCredentials { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlAllowCredentials property is set.
        /// </summary>
        internal bool IsSetAccessControlAllowCredentials() => this.AccessControlAllowCredentials.HasValue;

        /// <summary>
        /// Gets and sets the property AccessControlAllowHeaders. 
        /// <para>
        /// A list of HTTP header names that CloudFront includes as values for the <c>Access-Control-Allow-Headers</c>
        /// HTTP response header.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Access-Control-Allow-Headers</c> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Headers">Access-Control-Allow-Headers</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResponseHeadersPolicyAccessControlAllowHeaders AccessControlAllowHeaders { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlAllowHeaders property is set.
        /// </summary>
        internal bool IsSetAccessControlAllowHeaders() => this.AccessControlAllowHeaders != null;

        /// <summary>
        /// Gets and sets the property AccessControlAllowMethods. 
        /// <para>
        /// A list of HTTP methods that CloudFront includes as values for the <c>Access-Control-Allow-Methods</c>
        /// HTTP response header.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Access-Control-Allow-Methods</c> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Methods">Access-Control-Allow-Methods</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResponseHeadersPolicyAccessControlAllowMethods AccessControlAllowMethods { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlAllowMethods property is set.
        /// </summary>
        internal bool IsSetAccessControlAllowMethods() => this.AccessControlAllowMethods != null;

        /// <summary>
        /// Gets and sets the property AccessControlAllowOrigins. 
        /// <para>
        /// A list of origins (domain names) that CloudFront can use as the value for the <c>Access-Control-Allow-Origin</c>
        /// HTTP response header.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Access-Control-Allow-Origin</c> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Origin">Access-Control-Allow-Origin</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResponseHeadersPolicyAccessControlAllowOrigins AccessControlAllowOrigins { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlAllowOrigins property is set.
        /// </summary>
        internal bool IsSetAccessControlAllowOrigins() => this.AccessControlAllowOrigins != null;

        /// <summary>
        /// Gets and sets the property AccessControlExposeHeaders. 
        /// <para>
        /// A list of HTTP headers that CloudFront includes as values for the <c>Access-Control-Expose-Headers</c>
        /// HTTP response header.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Access-Control-Expose-Headers</c> HTTP response
        /// header, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Expose-Headers">Access-Control-Expose-Headers</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyAccessControlExposeHeaders AccessControlExposeHeaders { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlExposeHeaders property is set.
        /// </summary>
        internal bool IsSetAccessControlExposeHeaders() => this.AccessControlExposeHeaders != null;

        /// <summary>
        /// Gets and sets the property AccessControlMaxAgeSec. 
        /// <para>
        /// A number that CloudFront uses as the value for the <c>Access-Control-Max-Age</c> HTTP
        /// response header.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Access-Control-Max-Age</c> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Max-Age">Access-Control-Max-Age</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public int? AccessControlMaxAgeSec { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlMaxAgeSec property is set.
        /// </summary>
        internal bool IsSetAccessControlMaxAgeSec() => this.AccessControlMaxAgeSec.HasValue;

        /// <summary>
        /// Gets and sets the property OriginOverride. 
        /// <para>
        /// A Boolean that determines whether CloudFront overrides HTTP response headers received
        /// from the origin with the ones specified in this response headers policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? OriginOverride { get; set; }

        /// <summary>
        /// Checks to see if the OriginOverride property is set.
        /// </summary>
        internal bool IsSetOriginOverride() => this.OriginOverride.HasValue;
    }
}
