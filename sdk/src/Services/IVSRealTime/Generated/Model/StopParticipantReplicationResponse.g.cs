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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// This is the response object from the StopParticipantReplication operation.
    /// </summary>
    public partial class StopParticipantReplicationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessControlAllowOrigin. 
        /// <para>
        /// See <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Access-Control-Allow-Origin">Access-Control-Allow-Origin</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public string AccessControlAllowOrigin { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlAllowOrigin property is set.
        /// </summary>
        internal bool IsSetAccessControlAllowOrigin() => this.AccessControlAllowOrigin != null;

        /// <summary>
        /// Gets and sets the property AccessControlExposeHeaders. 
        /// <para>
        /// See <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Access-Control-Expose-Headers">Access-Control-Expose-Headers</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public string AccessControlExposeHeaders { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlExposeHeaders property is set.
        /// </summary>
        internal bool IsSetAccessControlExposeHeaders() => this.AccessControlExposeHeaders != null;

        /// <summary>
        /// Gets and sets the property CacheControl. 
        /// <para>
        /// See <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Cache-Control">Cache-Control</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public string CacheControl { get; set; }

        /// <summary>
        /// Checks to see if the CacheControl property is set.
        /// </summary>
        internal bool IsSetCacheControl() => this.CacheControl != null;

        /// <summary>
        /// Gets and sets the property ContentSecurityPolicy. 
        /// <para>
        /// See <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Content-Security-Policy">Content-Security-Policy</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public string ContentSecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ContentSecurityPolicy property is set.
        /// </summary>
        internal bool IsSetContentSecurityPolicy() => this.ContentSecurityPolicy != null;

        /// <summary>
        /// Gets and sets the property StrictTransportSecurity. 
        /// <para>
        /// See <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Strict-Transport-Security">Strict-Transport-Security</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public string StrictTransportSecurity { get; set; }

        /// <summary>
        /// Checks to see if the StrictTransportSecurity property is set.
        /// </summary>
        internal bool IsSetStrictTransportSecurity() => this.StrictTransportSecurity != null;

        /// <summary>
        /// Gets and sets the property XContentTypeOptions. 
        /// <para>
        /// See <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/X-Content-Type-Options">X-Content-Type-Options</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public string XContentTypeOptions { get; set; }

        /// <summary>
        /// Checks to see if the XContentTypeOptions property is set.
        /// </summary>
        internal bool IsSetXContentTypeOptions() => this.XContentTypeOptions != null;

        /// <summary>
        /// Gets and sets the property XFrameOptions. 
        /// <para>
        /// See <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/X-Frame-Options">X-Frame-Options</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public string XFrameOptions { get; set; }

        /// <summary>
        /// Checks to see if the XFrameOptions property is set.
        /// </summary>
        internal bool IsSetXFrameOptions() => this.XFrameOptions != null;
    }
}
