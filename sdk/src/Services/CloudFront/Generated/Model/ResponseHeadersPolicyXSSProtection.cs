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
    /// Determines whether CloudFront includes the <c>X-XSS-Protection</c> HTTP response header
    /// and the header's value.
    /// 
    ///  
    /// <para>
    /// For more information about the <c>X-XSS-Protection</c> HTTP response header, see <a
    /// href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-XSS-Protection">X-XSS-Protection</a>
    /// in the MDN Web Docs.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyXSSProtection
    {
        private bool? _modeBlock;
        private bool? _override;
        private bool? _protection;
        private string _reportUri;

        /// <summary>
        /// Gets and sets the property ModeBlock. 
        /// <para>
        /// A Boolean that determines whether CloudFront includes the <c>mode=block</c> directive
        /// in the <c>X-XSS-Protection</c> header.
        /// </para>
        ///  
        /// <para>
        /// For more information about this directive, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-XSS-Protection">X-XSS-Protection</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public bool? ModeBlock
        {
            get { return this._modeBlock; }
            set { this._modeBlock = value; }
        }

        // Check to see if ModeBlock property is set
        internal bool IsSetModeBlock()
        {
            return this._modeBlock.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// A Boolean that determines whether CloudFront overrides the <c>X-XSS-Protection</c>
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

        /// <summary>
        /// Gets and sets the property Protection. 
        /// <para>
        /// A Boolean that determines the value of the <c>X-XSS-Protection</c> HTTP response header.
        /// When this setting is <c>true</c>, the value of the <c>X-XSS-Protection</c> header
        /// is <c>1</c>. When this setting is <c>false</c>, the value of the <c>X-XSS-Protection</c>
        /// header is <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about these settings, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-XSS-Protection">X-XSS-Protection</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Protection
        {
            get { return this._protection; }
            set { this._protection = value; }
        }

        // Check to see if Protection property is set
        internal bool IsSetProtection()
        {
            return this._protection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportUri. 
        /// <para>
        /// A reporting URI, which CloudFront uses as the value of the <c>report</c> directive
        /// in the <c>X-XSS-Protection</c> header.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify a <c>ReportUri</c> when <c>ModeBlock</c> is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using a reporting URL, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-XSS-Protection">X-XSS-Protection</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        public string ReportUri
        {
            get { return this._reportUri; }
            set { this._reportUri = value; }
        }

        // Check to see if ReportUri property is set
        internal bool IsSetReportUri()
        {
            return this._reportUri != null;
        }

    }
}