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
    /// Example JSON: <code>"JsonBody": { "MatchPattern": { "All": {} }, "MatchScope": "ALL"
    /// }</code> 
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
        ///  <code>EVALUATE_AS_STRING</code> - Inspect the body as plain text. WAF applies the
        /// text transformations and inspection criteria that you defined for the JSON inspection
        /// to the body text string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MATCH</code> - Treat the web request as matching the rule statement. WAF applies
        /// the rule action to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NO_MATCH</code> - Treat the web request as not matching the rule statement.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't provide this setting, WAF parses and evaluates the content only up to
        /// the first parsing failure that it encounters. 
        /// </para>
        ///  
        /// <para>
        /// WAF does its best to parse the entire JSON body, but might be forced to stop for reasons
        /// such as invalid characters, duplicate keys, truncation, and any content whose root
        /// node isn't an object or an array. 
        /// </para>
        ///  
        /// <para>
        /// WAF parses the JSON in the following examples as two valid key, value pairs: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Missing comma: <code>{"key1":"value1""key2":"value2"}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Missing colon: <code>{"key1":"value1","key2""value2"}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Extra colons: <code>{"key1"::"value1","key2""value2"}</code> 
        /// </para>
        ///  </li> </ul>
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
        /// The parts of the JSON to match against using the <code>MatchPattern</code>. If you
        /// specify <code>All</code>, WAF matches against keys and values. 
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
        /// What WAF should do if the body is larger than WAF can inspect. WAF does not support
        /// inspecting the entire contents of the body of a web request when the body exceeds
        /// 8 KB (8192 bytes). Only the first 8 KB of the request body are forwarded to WAF by
        /// the underlying host service. 
        /// </para>
        ///  
        /// <para>
        /// The options for oversize handling are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CONTINUE</code> - Inspect the body normally, according to the rule inspection
        /// criteria. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MATCH</code> - Treat the web request as matching the rule statement. WAF applies
        /// the rule action to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NO_MATCH</code> - Treat the web request as not matching the rule statement.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can combine the <code>MATCH</code> or <code>NO_MATCH</code> settings for oversize
        /// handling with your rule and web ACL action settings, so that you block any request
        /// whose body is over 8 KB. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>CONTINUE</code> 
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