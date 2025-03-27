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
    /// Inspect fragments of the request URI. You can specify the parts of the URI fragment
    /// to inspect and you can narrow the set of URI fragments to inspect by including or
    /// excluding specific keys. 
    /// 
    ///  
    /// <para>
    /// This is used to indicate the web request component to inspect, in the <a>FieldToMatch</a>
    /// specification. 
    /// </para>
    ///  
    /// <para>
    /// Example JSON: <c>"UriFragment": { "MatchPattern": { "All": {} }, "MatchScope": "KEY",
    /// "OversizeHandling": "MATCH" }</c> 
    /// </para>
    /// </summary>
    public partial class UriFragment
    {
        private FallbackBehavior _fallbackBehavior;

        /// <summary>
        /// Gets and sets the property FallbackBehavior. 
        /// <para>
        /// What WAF should do if it fails to completely parse the JSON body. The options are
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EVALUATE_AS_STRING</c> - Inspect the body as plain text. WAF applies the text
        /// transformations and inspection criteria that you defined for the JSON inspection to
        /// the body text string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MATCH</c> - Treat the web request as matching the rule statement. WAF applies
        /// the rule action to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_MATCH</c> - Treat the web request as not matching the rule statement.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't provide this setting, WAF parses and evaluates the content only up to
        /// the first parsing failure that it encounters. 
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <c>{ "UriFragment": { "FallbackBehavior": "MATCH"} }</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// WAF parsing doesn't fully validate the input JSON string, so parsing can succeed even
        /// for invalid JSON. When parsing succeeds, WAF doesn't apply the fallback behavior.
        /// For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body">JSON
        /// body</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
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

    }
}