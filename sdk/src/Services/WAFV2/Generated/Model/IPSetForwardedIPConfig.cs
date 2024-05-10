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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The configuration for inspecting IP addresses in an HTTP header that you specify,
    /// instead of using the IP address that's reported by the web request origin. Commonly,
    /// this is the X-Forwarded-For (XFF) header, but you can specify any header name. 
    /// 
    ///  <note> 
    /// <para>
    /// If the specified header isn't present in the request, WAF doesn't apply the rule to
    /// the web request at all.
    /// </para>
    ///  </note> 
    /// <para>
    /// This configuration is used only for <a>IPSetReferenceStatement</a>. For <a>GeoMatchStatement</a>
    /// and <a>RateBasedStatement</a>, use <a>ForwardedIPConfig</a> instead. 
    /// </para>
    /// </summary>
    public partial class IPSetForwardedIPConfig
    {
        private FallbackBehavior _fallbackBehavior;
        private string _headerName;
        private ForwardedIPPosition _position;

        /// <summary>
        /// Gets and sets the property FallbackBehavior. 
        /// <para>
        /// The match status to assign to the web request if the request doesn't have a valid
        /// IP address in the specified position.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the specified header isn't present in the request, WAF doesn't apply the rule to
        /// the web request at all.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify the following fallback behaviors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MATCH</c> - Treat the web request as matching the rule statement. WAF applies
        /// the rule action to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_MATCH</c> - Treat the web request as not matching the rule statement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FallbackBehavior FallbackBehavior
        {
            get { return this._fallbackBehavior; }
            set { this._fallbackBehavior = value; }
        }

        // Check to see if FallbackBehavior property is set
        internal bool IsSetFallbackBehavior()
        {
            return this._fallbackBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderName. 
        /// <para>
        /// The name of the HTTP header to use for the IP address. For example, to use the X-Forwarded-For
        /// (XFF) header, set this to <c>X-Forwarded-For</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the specified header isn't present in the request, WAF doesn't apply the rule to
        /// the web request at all.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string HeaderName
        {
            get { return this._headerName; }
            set { this._headerName = value; }
        }

        // Check to see if HeaderName property is set
        internal bool IsSetHeaderName()
        {
            return this._headerName != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position in the header to search for the IP address. The header can contain IP
        /// addresses of the original client and also of proxies. For example, the header value
        /// could be <c>10.1.1.1, 127.0.0.0, 10.10.10.10</c> where the first IP address identifies
        /// the original client and the rest identify proxies that the request went through. 
        /// </para>
        ///  
        /// <para>
        /// The options for this setting are the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FIRST - Inspect the first IP address in the list of IP addresses in the header. This
        /// is usually the client's original IP.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LAST - Inspect the last IP address in the list of IP addresses in the header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ANY - Inspect all IP addresses in the header for a match. If the header contains more
        /// than 10 IP addresses, WAF inspects the last 10.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ForwardedIPPosition Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

    }
}