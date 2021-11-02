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
    /// A response headers policy configuration.
    /// 
    ///  
    /// <para>
    /// A response headers policy configuration contains metadata about the response headers
    /// policy, and configurations for sets of HTTP response headers and their values. CloudFront
    /// adds the headers in the policy to HTTP responses that it sends for requests that match
    /// a cache behavior associated with the policy.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyConfig
    {
        private string _comment;
        private ResponseHeadersPolicyCorsConfig _corsConfig;
        private ResponseHeadersPolicyCustomHeadersConfig _customHeadersConfig;
        private string _name;
        private ResponseHeadersPolicySecurityHeadersConfig _securityHeadersConfig;

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
        /// Gets and sets the property CorsConfig. 
        /// <para>
        /// A configuration for a set of HTTP response headers that are used for cross-origin
        /// resource sharing (CORS).
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyCorsConfig CorsConfig
        {
            get { return this._corsConfig; }
            set { this._corsConfig = value; }
        }

        // Check to see if CorsConfig property is set
        internal bool IsSetCorsConfig()
        {
            return this._corsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CustomHeadersConfig. 
        /// <para>
        /// A configuration for a set of custom HTTP response headers.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyCustomHeadersConfig CustomHeadersConfig
        {
            get { return this._customHeadersConfig; }
            set { this._customHeadersConfig = value; }
        }

        // Check to see if CustomHeadersConfig property is set
        internal bool IsSetCustomHeadersConfig()
        {
            return this._customHeadersConfig != null;
        }

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
        /// Gets and sets the property SecurityHeadersConfig. 
        /// <para>
        /// A configuration for a set of security-related HTTP response headers.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicySecurityHeadersConfig SecurityHeadersConfig
        {
            get { return this._securityHeadersConfig; }
            set { this._securityHeadersConfig = value; }
        }

        // Check to see if SecurityHeadersConfig property is set
        internal bool IsSetSecurityHeadersConfig()
        {
            return this._securityHeadersConfig != null;
        }

    }
}