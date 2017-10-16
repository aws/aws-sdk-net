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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Returned by <a>ListRegexPatternSets</a>. Each <code>RegexPatternSetSummary</code>
    /// object includes the <code>Name</code> and <code>RegexPatternSetId</code> for one <a>RegexPatternSet</a>.
    /// </summary>
    public partial class RegexPatternSetSummary
    {
        private string _name;
        private string _regexPatternSetId;

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
        /// The <code>RegexPatternSetId</code> for a <code>RegexPatternSet</code>. You use <code>RegexPatternSetId</code>
        /// to get information about a <code>RegexPatternSet</code>, update a <code>RegexPatternSet</code>,
        /// remove a <code>RegexPatternSet</code> from a <code>RegexMatchSet</code>, and delete
        /// a <code>RegexPatternSet</code> from AWS WAF.
        /// </para>
        ///  
        /// <para>
        ///  <code>RegexPatternSetId</code> is returned by <a>CreateRegexPatternSet</a> and by
        /// <a>ListRegexPatternSets</a>.
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

    }
}