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
    /// A configuration for a set of security-related HTTP response headers. CloudFront adds
    /// these headers to HTTP responses that it sends for requests that match a cache behavior
    /// associated with this response headers policy.
    /// </summary>
    public partial class ResponseHeadersPolicySecurityHeadersConfig
    {
        /// <summary>
        /// Gets and sets the property ContentSecurityPolicy. 
        /// <para>
        /// The policy directives and their values that CloudFront includes as values for the
        /// <c>Content-Security-Policy</c> HTTP response header.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Content-Security-Policy</c> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy">Content-Security-Policy</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyContentSecurityPolicy ContentSecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ContentSecurityPolicy property is set.
        /// </summary>
        internal bool IsSetContentSecurityPolicy() => this.ContentSecurityPolicy != null;

        /// <summary>
        /// Gets and sets the property ContentTypeOptions. 
        /// <para>
        /// Determines whether CloudFront includes the <c>X-Content-Type-Options</c> HTTP response
        /// header with its value set to <c>nosniff</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>X-Content-Type-Options</c> HTTP response header,
        /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Content-Type-Options">X-Content-Type-Options</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyContentTypeOptions ContentTypeOptions { get; set; }

        /// <summary>
        /// Checks to see if the ContentTypeOptions property is set.
        /// </summary>
        internal bool IsSetContentTypeOptions() => this.ContentTypeOptions != null;

        /// <summary>
        /// Gets and sets the property FrameOptions. 
        /// <para>
        /// Determines whether CloudFront includes the <c>X-Frame-Options</c> HTTP response header
        /// and the header's value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>X-Frame-Options</c> HTTP response header, see <a
        /// href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Frame-Options">X-Frame-Options</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyFrameOptions FrameOptions { get; set; }

        /// <summary>
        /// Checks to see if the FrameOptions property is set.
        /// </summary>
        internal bool IsSetFrameOptions() => this.FrameOptions != null;

        /// <summary>
        /// Gets and sets the property ReferrerPolicy. 
        /// <para>
        /// Determines whether CloudFront includes the <c>Referrer-Policy</c> HTTP response header
        /// and the header's value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Referrer-Policy</c> HTTP response header, see <a
        /// href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Referrer-Policy">Referrer-Policy</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyReferrerPolicy ReferrerPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ReferrerPolicy property is set.
        /// </summary>
        internal bool IsSetReferrerPolicy() => this.ReferrerPolicy != null;

        /// <summary>
        /// Gets and sets the property StrictTransportSecurity. 
        /// <para>
        /// Determines whether CloudFront includes the <c>Strict-Transport-Security</c> HTTP response
        /// header and the header's value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>Strict-Transport-Security</c> HTTP response header,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/understanding-response-headers-policies.html#understanding-response-headers-policies-security">Security
        /// headers</a> in the <i>Amazon CloudFront Developer Guide</i> and <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Strict-Transport-Security">Strict-Transport-Security</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyStrictTransportSecurity StrictTransportSecurity { get; set; }

        /// <summary>
        /// Checks to see if the StrictTransportSecurity property is set.
        /// </summary>
        internal bool IsSetStrictTransportSecurity() => this.StrictTransportSecurity != null;

        /// <summary>
        /// Gets and sets the property XSSProtection. 
        /// <para>
        /// Determines whether CloudFront includes the <c>X-XSS-Protection</c> HTTP response header
        /// and the header's value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>X-XSS-Protection</c> HTTP response header, see <a
        /// href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-XSS-Protection">X-XSS-Protection</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public ResponseHeadersPolicyXSSProtection XSSProtection { get; set; }

        /// <summary>
        /// Checks to see if the XSSProtection property is set.
        /// </summary>
        internal bool IsSetXSSProtection() => this.XSSProtection != null;
    }
}
