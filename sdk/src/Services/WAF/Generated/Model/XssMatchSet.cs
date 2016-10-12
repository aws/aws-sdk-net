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
    /// A complex type that contains <code>XssMatchTuple</code> objects, which specify the
    /// parts of web requests that you want AWS WAF to inspect for cross-site scripting attacks
    /// and, if you want AWS WAF to inspect a header, the name of the header. If a <code>XssMatchSet</code>
    /// contains more than one <code>XssMatchTuple</code> object, a request needs to include
    /// cross-site scripting attacks in only one of the specified parts of the request to
    /// be considered a match.
    /// </summary>
    public partial class XssMatchSet
    {
        private string _name;
        private string _xssMatchSetId;
        private List<XssMatchTuple> _xssMatchTuples = new List<XssMatchTuple>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name, if any, of the <code>XssMatchSet</code>.
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
        /// Gets and sets the property XssMatchSetId. 
        /// <para>
        /// A unique identifier for an <code>XssMatchSet</code>. You use <code>XssMatchSetId</code>
        /// to get information about an <code>XssMatchSet</code> (see <a>GetXssMatchSet</a>),
        /// update an <code>XssMatchSet</code> (see <a>UpdateXssMatchSet</a>), insert an <code>XssMatchSet</code>
        /// into a <code>Rule</code> or delete one from a <code>Rule</code> (see <a>UpdateRule</a>),
        /// and delete an <code>XssMatchSet</code> from AWS WAF (see <a>DeleteXssMatchSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <code>XssMatchSetId</code> is returned by <a>CreateXssMatchSet</a> and by <a>ListXssMatchSets</a>.
        /// </para>
        /// </summary>
        public string XssMatchSetId
        {
            get { return this._xssMatchSetId; }
            set { this._xssMatchSetId = value; }
        }

        // Check to see if XssMatchSetId property is set
        internal bool IsSetXssMatchSetId()
        {
            return this._xssMatchSetId != null;
        }

        /// <summary>
        /// Gets and sets the property XssMatchTuples. 
        /// <para>
        /// Specifies the parts of web requests that you want to inspect for cross-site scripting
        /// attacks.
        /// </para>
        /// </summary>
        public List<XssMatchTuple> XssMatchTuples
        {
            get { return this._xssMatchTuples; }
            set { this._xssMatchTuples = value; }
        }

        // Check to see if XssMatchTuples property is set
        internal bool IsSetXssMatchTuples()
        {
            return this._xssMatchTuples != null && this._xssMatchTuples.Count > 0; 
        }

    }
}