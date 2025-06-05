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
    /// This configuration is used for <a>GeoMatchStatement</a>, <a>AsnMatchStatement</a>,
    /// and <a>RateBasedStatement</a>. For <a>IPSetReferenceStatement</a>, use <a>IPSetForwardedIPConfig</a>
    /// instead. 
    /// </para>
    ///  
    /// <para>
    /// WAF only evaluates the first IP address found in the specified HTTP header. 
    /// </para>
    /// </summary>
    public partial class ForwardedIPConfig
    {
        private FallbackBehavior _fallbackBehavior;
        private string _headerName;

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

    }
}