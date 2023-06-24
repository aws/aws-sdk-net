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
    /// A configuration for a set of security-related HTTP response headers. CloudFront adds
    /// these headers to HTTP responses that it sends for requests that match a cache behavior
    /// associated with this response headers policy.
    /// </summary>
    public partial class ResponseHeadersPolicySecurityHeadersConfig
    {
        private ResponseHeadersPolicyContentSecurityPolicy _contentSecurityPolicy;
        private ResponseHeadersPolicyContentTypeOptions _contentTypeOptions;
        private ResponseHeadersPolicyFrameOptions _frameOptions;
        private ResponseHeadersPolicyReferrerPolicy _referrerPolicy;
        private ResponseHeadersPolicyStrictTransportSecurity _strictTransportSecurity;
        private ResponseHeadersPolicyXSSProtection _xssProtection;

        /// <summary>
        /// Gets and sets the property ContentSecurityPolicy. 
        /// <para>
        /// The policy directives and their values that CloudFront includes as values for the
        /// <code>Content-Security-Policy</code> HTTP response header.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>Content-Security-Policy</code> HTTP response
        /// header, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy">Content-Security-Policy</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyContentSecurityPolicy ContentSecurityPolicy
        {
            get { return this._contentSecurityPolicy; }
            set { this._contentSecurityPolicy = value; }
        }

        // Check to see if ContentSecurityPolicy property is set
        internal bool IsSetContentSecurityPolicy()
        {
            return this._contentSecurityPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ContentTypeOptions. 
        /// <para>
        /// Determines whether CloudFront includes the <code>X-Content-Type-Options</code> HTTP
        /// response header with its value set to <code>nosniff</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>X-Content-Type-Options</code> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Content-Type-Options">X-Content-Type-Options</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyContentTypeOptions ContentTypeOptions
        {
            get { return this._contentTypeOptions; }
            set { this._contentTypeOptions = value; }
        }

        // Check to see if ContentTypeOptions property is set
        internal bool IsSetContentTypeOptions()
        {
            return this._contentTypeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FrameOptions. 
        /// <para>
        /// Determines whether CloudFront includes the <code>X-Frame-Options</code> HTTP response
        /// header and the header's value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>X-Frame-Options</code> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Frame-Options">X-Frame-Options</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyFrameOptions FrameOptions
        {
            get { return this._frameOptions; }
            set { this._frameOptions = value; }
        }

        // Check to see if FrameOptions property is set
        internal bool IsSetFrameOptions()
        {
            return this._frameOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ReferrerPolicy. 
        /// <para>
        /// Determines whether CloudFront includes the <code>Referrer-Policy</code> HTTP response
        /// header and the header's value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>Referrer-Policy</code> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Referrer-Policy">Referrer-Policy</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyReferrerPolicy ReferrerPolicy
        {
            get { return this._referrerPolicy; }
            set { this._referrerPolicy = value; }
        }

        // Check to see if ReferrerPolicy property is set
        internal bool IsSetReferrerPolicy()
        {
            return this._referrerPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property StrictTransportSecurity. 
        /// <para>
        /// Determines whether CloudFront includes the <code>Strict-Transport-Security</code>
        /// HTTP response header and the header's value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>Strict-Transport-Security</code> HTTP response
        /// header, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Strict-Transport-Security">Strict-Transport-Security</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyStrictTransportSecurity StrictTransportSecurity
        {
            get { return this._strictTransportSecurity; }
            set { this._strictTransportSecurity = value; }
        }

        // Check to see if StrictTransportSecurity property is set
        internal bool IsSetStrictTransportSecurity()
        {
            return this._strictTransportSecurity != null;
        }

        /// <summary>
        /// Gets and sets the property XSSProtection. 
        /// <para>
        /// Determines whether CloudFront includes the <code>X-XSS-Protection</code> HTTP response
        /// header and the header's value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>X-XSS-Protection</code> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-XSS-Protection">X-XSS-Protection</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyXSSProtection XSSProtection
        {
            get { return this._xssProtection; }
            set { this._xssProtection = value; }
        }

        // Check to see if XSSProtection property is set
        internal bool IsSetXSSProtection()
        {
            return this._xssProtection != null;
        }

    }
}