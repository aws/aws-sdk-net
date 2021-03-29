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
    /// The body of a web request, inspected as JSON. The body immediately follows the request
    /// headers. This is used in the <a>FieldToMatch</a> specification.
    /// 
    ///  
    /// <para>
    /// Use the specifications in this object to indicate which parts of the JSON body to
    /// inspect using the rule's inspection criteria. AWS WAF inspects only the parts of the
    /// JSON that result from the matches that you indicate. 
    /// </para>
    /// </summary>
    public partial class JsonBody
    {
        private BodyParsingFallbackBehavior _invalidFallbackBehavior;
        private JsonMatchPattern _matchPattern;
        private JsonMatchScope _matchScope;

        /// <summary>
        /// Gets and sets the property InvalidFallbackBehavior. 
        /// <para>
        /// The inspection behavior to fall back to if the JSON in the request body is invalid.
        /// For AWS WAF, invalid JSON is any content that isn't complete syntactical JSON, content
        /// whose root node isn't an object or an array, and duplicate keys in the content. 
        /// </para>
        ///  
        /// <para>
        /// You can specify the following fallback behaviors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MATCH</code> - Treat the web request as matching the rule statement. AWS WAF
        /// applies the rule action to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NO_MATCH</code> - Treat the web request as not matching the rule statement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EVALUATE_AS_STRING</code> - Inspect the body as plain text. This option applies
        /// the text transformations and inspection criteria that you defined for the JSON inspection
        /// to the body text string. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't provide this setting, when AWS WAF encounters invalid JSON, it parses
        /// and inspects what it can, up to the first invalid JSON that it encounters. 
        /// </para>
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
        /// The patterns to look for in the JSON body. AWS WAF inspects the results of these pattern
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
        /// specify <code>All</code>, AWS WAF matches against keys and values. 
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

    }
}