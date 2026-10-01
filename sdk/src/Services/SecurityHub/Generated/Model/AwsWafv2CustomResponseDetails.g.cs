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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A custom response to send to the client. You can define a custom response for rule
    /// actions and default web ACL actions that are set to block.
    /// </summary>
    public partial class AwsWafv2CustomResponseDetails
    {
        /// <summary>
        /// Gets and sets the property CustomResponseBodyKey. 
        /// <para>
        ///  References the response body that you want WAF to return to the web request client.
        /// You can define a custom response for a rule action or a default web ACL action that
        /// is set to block. 
        /// </para>
        /// </summary>
        public string CustomResponseBodyKey { get; set; }

        /// <summary>
        /// Checks to see if the CustomResponseBodyKey property is set.
        /// </summary>
        internal bool IsSetCustomResponseBodyKey() => this.CustomResponseBodyKey != null;

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        ///  The HTTP status code to return to the client. For a list of status codes that you
        /// can use in your custom responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/customizing-the-response-status-codes.html">Supported
        /// status codes for custom response</a> in the <i>WAF Developer Guide.</i> 
        /// </para>
        /// </summary>
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCode property is set.
        /// </summary>
        internal bool IsSetResponseCode() => this.ResponseCode.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseHeaders. 
        /// <para>
        ///  The HTTP headers to use in the response. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsWafv2CustomHttpHeader> ResponseHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsWafv2CustomHttpHeader>() : null;

        /// <summary>
        /// Checks to see if the ResponseHeaders property is set.
        /// </summary>
        internal bool IsSetResponseHeaders() => this.ResponseHeaders != null && (this.ResponseHeaders.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
