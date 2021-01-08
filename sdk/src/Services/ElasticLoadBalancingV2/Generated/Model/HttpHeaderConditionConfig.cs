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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about an HTTP header condition.
    /// 
    ///  
    /// <para>
    /// There is a set of standard HTTP header fields. You can also define custom HTTP header
    /// fields.
    /// </para>
    /// </summary>
    public partial class HttpHeaderConditionConfig
    {
        private string _httpHeaderName;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property HttpHeaderName. 
        /// <para>
        /// The name of the HTTP header field. The maximum size is 40 characters. The header name
        /// is case insensitive. The allowed characters are specified by RFC 7230. Wildcards are
        /// not supported.
        /// </para>
        ///  
        /// <para>
        /// You can't use an HTTP header condition to specify the host header. Use <a>HostHeaderConditionConfig</a>
        /// to specify a host header condition.
        /// </para>
        /// </summary>
        public string HttpHeaderName
        {
            get { return this._httpHeaderName; }
            set { this._httpHeaderName = value; }
        }

        // Check to see if HttpHeaderName property is set
        internal bool IsSetHttpHeaderName()
        {
            return this._httpHeaderName != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// One or more strings to compare against the value of the HTTP header. The maximum size
        /// of each string is 128 characters. The comparison strings are case insensitive. The
        /// following wildcard characters are supported: * (matches 0 or more characters) and
        /// ? (matches exactly 1 character).
        /// </para>
        ///  
        /// <para>
        /// If the same header appears multiple times in the request, we search them in order
        /// until a match is found.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple strings, the condition is satisfied if one of the strings
        /// matches the value of the HTTP header. To require that all of the strings are a match,
        /// create one condition per string.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}