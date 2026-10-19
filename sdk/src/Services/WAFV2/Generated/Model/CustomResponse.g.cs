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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A custom response to send to the client. You can define a custom response for rule
    /// actions and default web ACL actions that are set to <a>BlockAction</a>. 
    /// 
    ///  
    /// <para>
    /// For information about customizing web requests and responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html">Customizing
    /// web requests and responses in WAF</a> in the <i>WAF Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CustomResponse
    {
        /// <summary>
        /// Gets and sets the property CustomResponseBodyKey. 
        /// <para>
        /// References the response body that you want WAF to return to the web request client.
        /// You can define a custom response for a rule action or a default web ACL action that
        /// is set to block. To do this, you first define the response body key and value in the
        /// <c>CustomResponseBodies</c> setting for the <a>WebACL</a> or <a>RuleGroup</a> where
        /// you want to use it. Then, in the rule action or web ACL default action <c>BlockAction</c>
        /// setting, you reference the response body using this key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string CustomResponseBodyKey { get; set; }

        /// <summary>
        /// Checks to see if the CustomResponseBodyKey property is set.
        /// </summary>
        internal bool IsSetCustomResponseBodyKey() => this.CustomResponseBodyKey != null;

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// The HTTP status code to return to the client. 
        /// </para>
        ///  
        /// <para>
        /// For a list of status codes that you can use in your custom responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/customizing-the-response-status-codes.html">Supported
        /// status codes for custom response</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 200, Max = 599)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCode property is set.
        /// </summary>
        internal bool IsSetResponseCode() => this.ResponseCode.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseHeaders. 
        /// <para>
        /// The HTTP headers to use in the response. You can specify any header name except for
        /// <c>content-type</c>. Duplicate header names are not allowed.
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on count and size for custom request and response
        /// settings, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<CustomHTTPHeader> ResponseHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomHTTPHeader>() : null;

        /// <summary>
        /// Checks to see if the ResponseHeaders property is set.
        /// </summary>
        internal bool IsSetResponseHeaders() => this.ResponseHeaders != null && (this.ResponseHeaders.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
