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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request. You
    /// can add custom request handling for WAF to use when the rule action doesn't block
    /// the request. For example, <code>CaptchaAction</code> for requests with valid t okens,
    /// and <code>AllowAction</code>. 
    /// 
    ///  
    /// <para>
    /// For information about customizing web requests and responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html">Customizing
    /// web requests and responses in WAF</a> in the <i>WAF Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CustomRequestHandling
    {
        private List<CustomHTTPHeader> _insertHeaders = new List<CustomHTTPHeader>();

        /// <summary>
        /// Gets and sets the property InsertHeaders. 
        /// <para>
        /// The HTTP headers to insert into the request. Duplicate header names are not allowed.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on count and size for custom request and response
        /// settings, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<CustomHTTPHeader> InsertHeaders
        {
            get { return this._insertHeaders; }
            set { this._insertHeaders = value; }
        }

        // Check to see if InsertHeaders property is set
        internal bool IsSetInsertHeaders()
        {
            return this._insertHeaders != null && this._insertHeaders.Count > 0; 
        }

    }
}