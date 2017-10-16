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
    /// The <code>RegexPatternSet</code> specifies the regular expression (regex) pattern
    /// that you want AWS WAF to search for, such as <code>B[a@]dB[o0]t</code>. You can then
    /// configure AWS WAF to reject those requests.
    /// </summary>
    public partial class RegexPatternSet
    {
        private string _name;
        private string _regexPatternSetId;
        private List<string> _regexPatternStrings = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>RegexPatternSet</a>. You can't change <code>Name</code>
        /// after you create a <code>RegexPatternSet</code>.
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
        /// Gets and sets the property RegexPatternSetId. 
        /// <para>
        /// The identifier for the <code>RegexPatternSet</code>. You use <code>RegexPatternSetId</code>
        /// to get information about a <code>RegexPatternSet</code>, update a <code>RegexPatternSet</code>,
        /// remove a <code>RegexPatternSet</code> from a <code>RegexMatchSet</code>, and delete
        /// a <code>RegexPatternSet</code> from AWS WAF.
        /// </para>
        ///  
        /// <para>
        ///  <code>RegexMatchSetId</code> is returned by <a>CreateRegexPatternSet</a> and by <a>ListRegexPatternSets</a>.
        /// </para>
        /// </summary>
        public string RegexPatternSetId
        {
            get { return this._regexPatternSetId; }
            set { this._regexPatternSetId = value; }
        }

        // Check to see if RegexPatternSetId property is set
        internal bool IsSetRegexPatternSetId()
        {
            return this._regexPatternSetId != null;
        }

        /// <summary>
        /// Gets and sets the property RegexPatternStrings. 
        /// <para>
        /// Specifies the regular expression (regex) patterns that you want AWS WAF to search
        /// for, such as <code>B[a@]dB[o0]t</code>.
        /// </para>
        /// </summary>
        public List<string> RegexPatternStrings
        {
            get { return this._regexPatternStrings; }
            set { this._regexPatternStrings = value; }
        }

        // Check to see if RegexPatternStrings property is set
        internal bool IsSetRegexPatternStrings()
        {
            return this._regexPatternStrings != null && this._regexPatternStrings.Count > 0; 
        }

    }
}