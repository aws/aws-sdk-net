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
    /// Specifies that WAF should run a <code>CAPTCHA</code> check against the request: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If the request includes a valid, unexpired <code>CAPTCHA</code> token, WAF applies
    /// any custom request handling and labels that you've configured and then allows the
    /// web request inspection to proceed to the next rule, similar to a <code>CountAction</code>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the request doesn't include a valid, unexpired token, WAF discontinues the web
    /// ACL evaluation of the request and blocks it from going to its intended destination.
    /// </para>
    ///  
    /// <para>
    /// WAF generates a response that it sends back to the client, which includes the following:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The header <code>x-amzn-waf-action</code> with a value of <code>captcha</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The HTTP status code <code>405 Method Not Allowed</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the request contains an <code>Accept</code> header with a value of <code>text/html</code>,
    /// the response includes a <code>CAPTCHA</code> JavaScript page interstitial. 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// You can configure the expiration time in the <code>CaptchaConfig</code> <code>ImmunityTimeProperty</code>
    /// setting at the rule and web ACL level. The rule setting overrides the web ACL setting.
    /// 
    /// </para>
    ///  
    /// <para>
    /// This action option is available for rules. It isn't available for web ACL default
    /// actions. 
    /// </para>
    /// </summary>
    public partial class CaptchaAction
    {
        private CustomRequestHandling _customRequestHandling;

        /// <summary>
        /// Gets and sets the property CustomRequestHandling. 
        /// <para>
        /// Defines custom handling for the web request, used when the <code>CAPTCHA</code> inspection
        /// determines that the request's token is valid and unexpired.
        /// </para>
        ///  
        /// <para>
        /// For information about customizing web requests and responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html">Customizing
        /// web requests and responses in WAF</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        public CustomRequestHandling CustomRequestHandling
        {
            get { return this._customRequestHandling; }
            set { this._customRequestHandling = value; }
        }

        // Check to see if CustomRequestHandling property is set
        internal bool IsSetCustomRequestHandling()
        {
            return this._customRequestHandling != null;
        }

    }
}