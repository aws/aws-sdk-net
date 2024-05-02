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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The policy directives and their values that CloudFront includes as values for the
    /// <c>Content-Security-Policy</c> HTTP response header.
    /// 
    ///  
    /// <para>
    /// For more information about the <c>Content-Security-Policy</c> HTTP response header,
    /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy">Content-Security-Policy</a>
    /// in the MDN Web Docs.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyContentSecurityPolicy
    {
        private string _contentSecurityPolicy;
        private bool? _override;

        /// <summary>
        /// Gets and sets the property ContentSecurityPolicy. 
        /// <para>
        /// The policy directives and their values that CloudFront includes as values for the
        /// <c>Content-Security-Policy</c> HTTP response header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentSecurityPolicy
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
        /// Gets and sets the property Override. 
        /// <para>
        /// A Boolean that determines whether CloudFront overrides the <c>Content-Security-Policy</c>
        /// HTTP response header received from the origin with the one specified in this response
        /// headers policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Override
        {
            get { return this._override; }
            set { this._override = value; }
        }

        // Check to see if Override property is set
        internal bool IsSetOverride()
        {
            return this._override.HasValue; 
        }

    }
}