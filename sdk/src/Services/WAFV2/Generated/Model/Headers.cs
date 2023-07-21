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
    /// Inspect all headers in the web request. You can specify the parts of the headers to
    /// inspect and you can narrow the set of headers to inspect by including or excluding
    /// specific keys.
    /// 
    ///  
    /// <para>
    /// This is used to indicate the web request component to inspect, in the <a>FieldToMatch</a>
    /// specification. 
    /// </para>
    ///  
    /// <para>
    /// If you want to inspect just the value of a single header, use the <code>SingleHeader</code>
    /// <code>FieldToMatch</code> setting instead.
    /// </para>
    ///  
    /// <para>
    /// Example JSON: <code>"Headers": { "MatchPattern": { "All": {} }, "MatchScope": "KEY",
    /// "OversizeHandling": "MATCH" }</code> 
    /// </para>
    /// </summary>
    public partial class Headers
    {
        private HeaderMatchPattern _matchPattern;
        private MapMatchScope _matchScope;
        private OversizeHandling _oversizeHandling;

        /// <summary>
        /// Gets and sets the property MatchPattern. 
        /// <para>
        /// The filter to use to identify the subset of headers to inspect in a web request. 
        /// </para>
        ///  
        /// <para>
        /// You must specify exactly one setting: either <code>All</code>, <code>IncludedHeaders</code>,
        /// or <code>ExcludedHeaders</code>.
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <code>"MatchPattern": { "ExcludedHeaders": [ "KeyToExclude1", "KeyToExclude2"
        /// ] }</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HeaderMatchPattern MatchPattern
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
        /// The parts of the headers to match with the rule inspection criteria. If you specify
        /// <code>All</code>, WAF inspects both keys and values. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MapMatchScope MatchScope
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
        /// What WAF should do if the headers of the request are more numerous or larger than
        /// WAF can inspect. WAF does not support inspecting the entire contents of request headers
        /// when they exceed 8 KB (8192 bytes) or 200 total headers. The underlying host service
        /// forwards a maximum of 200 headers and at most 8 KB of header contents to WAF. 
        /// </para>
        ///  
        /// <para>
        /// The options for oversize handling are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CONTINUE</code> - Inspect the available headers normally, according to the
        /// rule inspection criteria. 
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
        /// </summary>
        [AWSProperty(Required=true)]
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