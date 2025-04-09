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
    /// Inspect the body of the web request as JSON. The body immediately follows the request
    /// headers. 
    /// 
    ///  
    /// <para>
    /// This is used to indicate the web request component to inspect, in the <a>FieldToMatch</a>
    /// specification. 
    /// </para>
    ///  
    /// <para>
    /// Use the specifications in this object to indicate which parts of the JSON body to
    /// inspect using the rule's inspection criteria. WAF inspects only the parts of the JSON
    /// that result from the matches that you indicate. 
    /// </para>
    ///  
    /// <para>
    /// Example JSON: <c>"JsonBody": { "MatchPattern": { "All": {} }, "MatchScope": "ALL"
    /// }</c> 
    /// </para>
    ///  
    /// <para>
    /// For additional information about this request component option, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body">JSON
    /// body</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class JsonBody
    {
        private BodyParsingFallbackBehavior _invalidFallbackBehavior;
        private JsonMatchPattern _matchPattern;
        private JsonMatchScope _matchScope;
        private OversizeHandling _oversizeHandling;

        /// <summary>
        /// Gets and sets the property InvalidFallbackBehavior. 
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
        ///  <note> 
        /// <para>
        /// WAF parsing doesn't fully validate the input JSON string, so parsing can succeed even
        /// for invalid JSON. When parsing succeeds, WAF doesn't apply the fallback behavior.
        /// For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body">JSON
        /// body</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public BodyParsingFallbackBehavior InvalidFallbackBehavior
        {
            get { return this._invalidFallbackBehavior; }
            set { this._invalidFallbackBehavior = value; }
        }

        // Check to see if InvalidFallbackBehavior property is set
        internal bool IsSetInvalidFallbackBehavior()
        {
            return this._invalidFallbackBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property MatchPattern. 
        /// <para>
        /// The patterns to look for in the JSON body. WAF inspects the results of these pattern
        /// matches against the rule inspection criteria. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JsonMatchPattern MatchPattern
        {
            get { return this._matchPattern; }
            set { this._matchPattern = value; }
        }

        // Check to see if MatchPattern property is set
        internal bool IsSetMatchPattern()
        {
            return this._matchPattern != null;
        }

        /// <summary>
        /// Gets and sets the property MatchScope. 
        /// <para>
        /// The parts of the JSON to match against using the <c>MatchPattern</c>. If you specify
        /// <c>ALL</c>, WAF matches against keys and values. 
        /// </para>
        ///  
        /// <para>
        ///  <c>All</c> does not require a match to be found in the keys and a match to be found
        /// in the values. It requires a match to be found in the keys or the values or both.
        /// To require a match in the keys and in the values, use a logical <c>AND</c> statement
        /// to combine two match rules, one that inspects the keys and another that inspects the
        /// values. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JsonMatchScope MatchScope
        {
            get { return this._matchScope; }
            set { this._matchScope = value; }
        }

        // Check to see if MatchScope property is set
        internal bool IsSetMatchScope()
        {
            return this._matchScope != null;
        }

        /// <summary>
        /// Gets and sets the property OversizeHandling. 
        /// <para>
        /// What WAF should do if the body is larger than WAF can inspect. 
        /// </para>
        ///  
        /// <para>
        /// WAF does not support inspecting the entire contents of the web request body if the
        /// body exceeds the limit for the resource type. When a web request body is larger than
        /// the limit, the underlying host service only forwards the contents that are within
        /// the limit to WAF for inspection. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Application Load Balancer and AppSync, the limit is fixed at 8 KB (8,192 bytes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For CloudFront, API Gateway, Amazon Cognito, App Runner, and Verified Access, the
        /// default limit is 16 KB (16,384 bytes), and you can increase the limit for each resource
        /// type in the web ACL <c>AssociationConfig</c>, for additional processing fees. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amplify, use the CloudFront limit.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The options for oversize handling are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONTINUE</c> - Inspect the available body contents normally, according to the
        /// rule inspection criteria. 
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
        /// You can combine the <c>MATCH</c> or <c>NO_MATCH</c> settings for oversize handling
        /// with your rule and web ACL action settings, so that you block any request whose body
        /// is over the limit. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>CONTINUE</c> 
        /// </para>
        /// </summary>
        public OversizeHandling OversizeHandling
        {
            get { return this._oversizeHandling; }
            set { this._oversizeHandling = value; }
        }

        // Check to see if OversizeHandling property is set
        internal bool IsSetOversizeHandling()
        {
            return this._oversizeHandling != null;
        }

    }
}