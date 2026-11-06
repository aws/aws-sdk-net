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
    /// A response headers policy configuration.
    /// 
    ///  
    /// <para>
    /// A response headers policy configuration contains metadata about the response headers
    /// policy, and configurations for sets of HTTP response headers.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyConfig
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment to describe the response headers policy.
        /// </para>
        ///  
        /// <para>
        /// The comment cannot be longer than 128 characters.
        /// </para>
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property CorsConfig. 
        /// <para>
        /// A configuration for a set of HTTP response headers that are used for cross-origin
        /// resource sharing (CORS).
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyCorsConfig CorsConfig { get; set; }

        /// <summary>
        /// Checks to see if the CorsConfig property is set.
        /// </summary>
        internal bool IsSetCorsConfig() => this.CorsConfig != null;

        /// <summary>
        /// Gets and sets the property CustomHeadersConfig. 
        /// <para>
        /// A configuration for a set of custom HTTP response headers.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyCustomHeadersConfig CustomHeadersConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomHeadersConfig property is set.
        /// </summary>
        internal bool IsSetCustomHeadersConfig() => this.CustomHeadersConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name to identify the response headers policy.
        /// </para>
        ///  
        /// <para>
        /// The name must be unique for response headers policies in this Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RemoveHeadersConfig. 
        /// <para>
        /// A configuration for a set of HTTP headers to remove from the HTTP response.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyRemoveHeadersConfig RemoveHeadersConfig { get; set; }

        /// <summary>
        /// Checks to see if the RemoveHeadersConfig property is set.
        /// </summary>
        internal bool IsSetRemoveHeadersConfig() => this.RemoveHeadersConfig != null;

        /// <summary>
        /// Gets and sets the property SecurityHeadersConfig. 
        /// <para>
        /// A configuration for a set of security-related HTTP response headers.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicySecurityHeadersConfig SecurityHeadersConfig { get; set; }

        /// <summary>
        /// Checks to see if the SecurityHeadersConfig property is set.
        /// </summary>
        internal bool IsSetSecurityHeadersConfig() => this.SecurityHeadersConfig != null;

        /// <summary>
        /// Gets and sets the property ServerTimingHeadersConfig. 
        /// <para>
        /// A configuration for enabling the <c>Server-Timing</c> header in HTTP responses sent
        /// from CloudFront.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyServerTimingHeadersConfig ServerTimingHeadersConfig { get; set; }

        /// <summary>
        /// Checks to see if the ServerTimingHeadersConfig property is set.
        /// </summary>
        internal bool IsSetServerTimingHeadersConfig() => this.ServerTimingHeadersConfig != null;
    }
}
