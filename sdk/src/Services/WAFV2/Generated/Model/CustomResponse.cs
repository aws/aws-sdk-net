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
    /// A custom response to send to the client. You can define a custom response for rule
    /// actions and default web ACL actions that are set to <a>BlockAction</a>. 
    /// 
    ///  
    /// <para>
    /// For information about customizing web requests and responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html">Customizing
    /// web requests and responses in WAF</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
    /// Developer Guide</a>. 
    /// </para>
    /// </summary>
    public partial class CustomResponse
    {
        private string _customResponseBodyKey;
        private int? _responseCode;
        private List<CustomHTTPHeader> _responseHeaders = new List<CustomHTTPHeader>();

        /// <summary>
        /// Gets and sets the property CustomResponseBodyKey. 
        /// <para>
        /// References the response body that you want WAF to return to the web request client.
        /// You can define a custom response for a rule action or a default web ACL action that
        /// is set to block. To do this, you first define the response body key and value in the
        /// <code>CustomResponseBodies</code> setting for the <a>WebACL</a> or <a>RuleGroup</a>
        /// where you want to use it. Then, in the rule action or web ACL default action <code>BlockAction</code>
        /// setting, you reference the response body using this key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string CustomResponseBodyKey
        {
            get { return this._customResponseBodyKey; }
            set { this._customResponseBodyKey = value; }
        }

        // Check to see if CustomResponseBodyKey property is set
        internal bool IsSetCustomResponseBodyKey()
        {
            return this._customResponseBodyKey != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// The HTTP status code to return to the client. 
        /// </para>
        ///  
        /// <para>
        /// For a list of status codes that you can use in your custom responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/customizing-the-response-status-codes.html">Supported
        /// status codes for custom response</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
        /// Developer Guide</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=200, Max=599)]
        public int ResponseCode
        {
            get { return this._responseCode.GetValueOrDefault(); }
            set { this._responseCode = value; }
        }

        // Check to see if ResponseCode property is set
        internal bool IsSetResponseCode()
        {
            return this._responseCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseHeaders. 
        /// <para>
        /// The HTTP headers to use in the response. Duplicate header names are not allowed. 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on count and size for custom request and response
        /// settings, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
        /// Developer Guide</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<CustomHTTPHeader> ResponseHeaders
        {
            get { return this._responseHeaders; }
            set { this._responseHeaders = value; }
        }

        // Check to see if ResponseHeaders property is set
        internal bool IsSetResponseHeaders()
        {
            return this._responseHeaders != null && this._responseHeaders.Count > 0; 
        }

    }
}