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
    /// A rule statement used to detect web requests coming from particular IP addresses or
    /// address ranges. To use this, create an <a>IPSet</a> that specifies the addresses you
    /// want to detect, then use the ARN of that set in this statement. To create an IP set,
    /// see <a>CreateIPSet</a>.
    /// 
    ///  
    /// <para>
    /// Each IP set rule statement references an IP set. You create and maintain the set independent
    /// of your rules. This allows you to use the single set in multiple rules. When you update
    /// the referenced set, WAF automatically updates all rules that reference it.
    /// </para>
    /// </summary>
    public partial class IPSetReferenceStatement
    {
        private string _arn;
        private IPSetForwardedIPConfig _ipSetForwardedIPConfig;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a>IPSet</a> that this statement references.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property IPSetForwardedIPConfig. 
        /// <para>
        /// The configuration for inspecting IP addresses in an HTTP header that you specify,
        /// instead of using the IP address that's reported by the web request origin. Commonly,
        /// this is the X-Forwarded-For (XFF) header, but you can specify any header name. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the specified header isn't present in the request, WAF doesn't apply the rule to
        /// the web request at all.
        /// </para>
        ///  </note>
        /// </summary>
        public IPSetForwardedIPConfig IPSetForwardedIPConfig
        {
            get { return this._ipSetForwardedIPConfig; }
            set { this._ipSetForwardedIPConfig = value; }
        }

        // Check to see if IPSetForwardedIPConfig property is set
        internal bool IsSetIPSetForwardedIPConfig()
        {
            return this._ipSetForwardedIPConfig != null;
        }

    }
}