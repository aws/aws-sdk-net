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
    /// The response body to use in a custom response to a web request. This is referenced
    /// by key from <a>CustomResponse</a> <c>CustomResponseBodyKey</c>.
    /// </summary>
    public partial class CustomResponseBody
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The payload of the custom response. 
        /// </para>
        ///  
        /// <para>
        /// You can use JSON escape strings in JSON content. To do this, you must specify JSON
        /// content in the <c>ContentType</c> setting. 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on count and size for custom request and response
        /// settings, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10240)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of content in the payload that you are defining in the <c>Content</c> string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResponseContentType ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;
    }
}
