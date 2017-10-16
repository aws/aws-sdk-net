/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
    /// In a <a>GetRegexMatchSet</a> request, <code>RegexMatchSet</code> is a complex type
    /// that contains the <code>RegexMatchSetId</code> and <code>Name</code> of a <code>RegexMatchSet</code>,
    /// and the values that you specified when you updated the <code>RegexMatchSet</code>.
    /// 
    ///  
    /// <para>
    ///  The values are contained in a <code>RegexMatchTuple</code> object, which specify
    /// the parts of web requests that you want AWS WAF to inspect and the values that you
    /// want AWS WAF to search for. If a <code>RegexMatchSet</code> contains more than one
    /// <code>RegexMatchTuple</code> object, a request needs to match the settings in only
    /// one <code>ByteMatchTuple</code> to be considered a match.
    /// </para>
    /// </summary>
    public partial class RegexMatchSet
    {
        private string _name;
        private string _regexMatchSetId;
        private List<RegexMatchTuple> _regexMatchTuples = new List<RegexMatchTuple>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>RegexMatchSet</a>. You can't change <code>Name</code>
        /// after you create a <code>RegexMatchSet</code>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RegexMatchSetId. 
        /// <para>
        /// The <code>RegexMatchSetId</code> for a <code>RegexMatchSet</code>. You use <code>RegexMatchSetId</code>
        /// to get information about a <code>RegexMatchSet</code> (see <a>GetRegexMatchSet</a>),
        /// update a <code>RegexMatchSet</code> (see <a>UpdateRegexMatchSet</a>), insert a <code>RegexMatchSet</code>
        /// into a <code>Rule</code> or delete one from a <code>Rule</code> (see <a>UpdateRule</a>),
        /// and delete a <code>RegexMatchSet</code> from AWS WAF (see <a>DeleteRegexMatchSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <code>RegexMatchSetId</code> is returned by <a>CreateRegexMatchSet</a> and by <a>ListRegexMatchSets</a>.
        /// </para>
        /// </summary>
        public string RegexMatchSetId
        {
            get { return this._regexMatchSetId; }
            set { this._regexMatchSetId = value; }
        }

        // Check to see if RegexMatchSetId property is set
        internal bool IsSetRegexMatchSetId()
        {
            return this._regexMatchSetId != null;
        }

        /// <summary>
        /// Gets and sets the property RegexMatchTuples. 
        /// <para>
        /// Contains an array of <a>RegexMatchTuple</a> objects. Each <code>RegexMatchTuple</code>
        /// object contains: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <code>User-Agent</code> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The identifier of the pattern (a regular expression) that you want AWS WAF to look
        /// for. For more information, see <a>RegexPatternSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any conversions on the request, such as converting it to lowercase,
        /// before inspecting it for the specified string.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<RegexMatchTuple> RegexMatchTuples
        {
            get { return this._regexMatchTuples; }
            set { this._regexMatchTuples = value; }
        }

        // Check to see if RegexMatchTuples property is set
        internal bool IsSetRegexMatchTuples()
        {
            return this._regexMatchTuples != null && this._regexMatchTuples.Count > 0; 
        }

    }
}