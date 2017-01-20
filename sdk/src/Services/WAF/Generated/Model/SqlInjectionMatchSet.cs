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
    /// A complex type that contains <code>SqlInjectionMatchTuple</code> objects, which specify
    /// the parts of web requests that you want AWS WAF to inspect for snippets of malicious
    /// SQL code and, if you want AWS WAF to inspect a header, the name of the header. If
    /// a <code>SqlInjectionMatchSet</code> contains more than one <code>SqlInjectionMatchTuple</code>
    /// object, a request needs to include snippets of SQL code in only one of the specified
    /// parts of the request to be considered a match.
    /// </summary>
    public partial class SqlInjectionMatchSet
    {
        private string _name;
        private string _sqlInjectionMatchSetId;
        private List<SqlInjectionMatchTuple> _sqlInjectionMatchTuples = new List<SqlInjectionMatchTuple>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name, if any, of the <code>SqlInjectionMatchSet</code>.
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
        /// Gets and sets the property SqlInjectionMatchSetId. 
        /// <para>
        /// A unique identifier for a <code>SqlInjectionMatchSet</code>. You use <code>SqlInjectionMatchSetId</code>
        /// to get information about a <code>SqlInjectionMatchSet</code> (see <a>GetSqlInjectionMatchSet</a>),
        /// update a <code>SqlInjectionMatchSet</code> (see <a>UpdateSqlInjectionMatchSet</a>),
        /// insert a <code>SqlInjectionMatchSet</code> into a <code>Rule</code> or delete one
        /// from a <code>Rule</code> (see <a>UpdateRule</a>), and delete a <code>SqlInjectionMatchSet</code>
        /// from AWS WAF (see <a>DeleteSqlInjectionMatchSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a>
        /// and by <a>ListSqlInjectionMatchSets</a>.
        /// </para>
        /// </summary>
        public string SqlInjectionMatchSetId
        {
            get { return this._sqlInjectionMatchSetId; }
            set { this._sqlInjectionMatchSetId = value; }
        }

        // Check to see if SqlInjectionMatchSetId property is set
        internal bool IsSetSqlInjectionMatchSetId()
        {
            return this._sqlInjectionMatchSetId != null;
        }

        /// <summary>
        /// Gets and sets the property SqlInjectionMatchTuples. 
        /// <para>
        /// Specifies the parts of web requests that you want to inspect for snippets of malicious
        /// SQL code.
        /// </para>
        /// </summary>
        public List<SqlInjectionMatchTuple> SqlInjectionMatchTuples
        {
            get { return this._sqlInjectionMatchTuples; }
            set { this._sqlInjectionMatchTuples = value; }
        }

        // Check to see if SqlInjectionMatchTuples property is set
        internal bool IsSetSqlInjectionMatchTuples()
        {
            return this._sqlInjectionMatchTuples != null && this._sqlInjectionMatchTuples.Count > 0; 
        }

    }
}