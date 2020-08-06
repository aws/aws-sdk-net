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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// The bytes (typically a string that corresponds with ASCII characters) that you want
    /// AWS WAF to search for in web requests, the location in requests that you want AWS
    /// WAF to search, and other settings.
    /// </summary>
    public partial class ByteMatchTuple
    {
        /// <summary>
        /// Gets and sets the property TargetString. Setting the value of TargetString will
        /// update the value of TargetStream and vice versa.
        /// <para>
        /// The value that you want AWS WAF to search for. AWS WAF searches for the specified
        /// string in the part of web requests that you specified in <code>FieldToMatch</code>.
        /// The maximum length of the value is 50 bytes.
        /// </para>
        /// <para>
        /// Valid values depend on the values that you specified for <code>FieldToMatch</code>:
        /// </para>
        ///  <ul> <li> <code>HEADER</code>: The value that you want AWS WAF to search for in the
        /// request header that you specified in <a>FieldToMatch</a>, for example, the value of
        /// the <code>User-Agent</code> or <code>Referer</code> header.</li> <li> <code>METHOD</code>:
        /// The HTTP method, which indicates the type of operation specified in the request. CloudFront
        /// supports the following methods: <code>DELETE</code>, <code>GET</code>, <code>HEAD</code>,
        /// <code>OPTIONS</code>, <code>PATCH</code>, <code>POST</code>, and <code>PUT</code>.</li>
        /// <li> <code>QUERY_STRING</code>: The value that you want AWS WAF to search for in the
        /// query string, which is the part of a URL that appears after a <code>?</code> character.</li>
        /// <li> <code>URI</code>: The value that you want AWS WAF to search for in the part of
        /// a URL that identifies a resource, for example, <code>/images/daily-ad.jpg</code>.</li>
        /// </ul> 
        /// <para>
        /// If <code>TargetString</code> includes alphabetic characters A-Z and a-z, note that
        /// the value is case sensitive.
        /// </para>
        /// </summary>
        public string TargetString
        {
            get
            {
                if (TargetStream == null)
                {
                    return null;
                }
                else if (TargetStream.Length == 0)
                {
                    return string.Empty;
                }
                else
                {
                    var bytes = TargetStream.ToArray();
                    var text = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    return text;
                }
            }
            set
            {
                if (value == null)
                {
                    TargetStream = null;
                }
                else if (value.Length == 0)
                {
                    TargetStream = new MemoryStream();
                }
                else
                {
                    var bytes = Encoding.UTF8.GetBytes(value);
                    var stream = new MemoryStream(bytes);
                    TargetStream = stream;
                }
            }
        }
    }
}