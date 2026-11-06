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
    /// Determines whether CloudFront includes the <c>Strict-Transport-Security</c> HTTP response
    /// header and the header's value.
    /// 
    ///  
    /// <para>
    /// For more information about the <c>Strict-Transport-Security</c> HTTP response header,
    /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Strict-Transport-Security">Strict-Transport-Security</a>
    /// in the MDN Web Docs.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyStrictTransportSecurity
    {
        /// <summary>
        /// Gets and sets the property AccessControlMaxAgeSec. 
        /// <para>
        /// A number that CloudFront uses as the value for the <c>max-age</c> directive in the
        /// <c>Strict-Transport-Security</c> HTTP response header.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AccessControlMaxAgeSec { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlMaxAgeSec property is set.
        /// </summary>
        internal bool IsSetAccessControlMaxAgeSec() => this.AccessControlMaxAgeSec.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeSubdomains. 
        /// <para>
        /// A Boolean that determines whether CloudFront includes the <c>includeSubDomains</c>
        /// directive in the <c>Strict-Transport-Security</c> HTTP response header.
        /// </para>
        /// </summary>
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// Checks to see if the IncludeSubdomains property is set.
        /// </summary>
        internal bool IsSetIncludeSubdomains() => this.IncludeSubdomains.HasValue;

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// A Boolean that determines whether CloudFront overrides the <c>Strict-Transport-Security</c>
        /// HTTP response header received from the origin with the one specified in this response
        /// headers policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Override { get; set; }

        /// <summary>
        /// Checks to see if the Override property is set.
        /// </summary>
        internal bool IsSetOverride() => this.Override.HasValue;

        /// <summary>
        /// Gets and sets the property Preload. 
        /// <para>
        /// A Boolean that determines whether CloudFront includes the <c>preload</c> directive
        /// in the <c>Strict-Transport-Security</c> HTTP response header.
        /// </para>
        /// </summary>
        public bool? Preload { get; set; }

        /// <summary>
        /// Checks to see if the Preload property is set.
        /// </summary>
        internal bool IsSetPreload() => this.Preload.HasValue;
    }
}
