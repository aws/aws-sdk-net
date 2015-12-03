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
    /// Specifies the part of a web request that you want to inspect for snippets of malicious
    /// SQL code and indicates whether you want to add the specification to a <a>SqlInjectionMatchSet</a>
    /// or delete it from a <code>SqlInjectionMatchSet</code>.
    /// </summary>
    public partial class SqlInjectionMatchSetUpdate
    {
        private ChangeAction _action;
        private SqlInjectionMatchTuple _sqlInjectionMatchTuple;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specify <code>INSERT</code> to add a <a>SqlInjectionMatchSetUpdate</a> to a <a>SqlInjectionMatchSet</a>.
        /// Use <code>DELETE</code> to remove a <code>SqlInjectionMatchSetUpdate</code> from a
        /// <code>SqlInjectionMatchSet</code>.
        /// </para>
        /// </summary>
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property SqlInjectionMatchTuple. 
        /// <para>
        /// Specifies the part of a web request that you want AWS WAF to inspect for snippets
        /// of malicious SQL code and, if you want AWS WAF to inspect a header, the name of the
        /// header.
        /// </para>
        /// </summary>
        public SqlInjectionMatchTuple SqlInjectionMatchTuple
        {
            get { return this._sqlInjectionMatchTuple; }
            set { this._sqlInjectionMatchTuple = value; }
        }

        // Check to see if SqlInjectionMatchTuple property is set
        internal bool IsSetSqlInjectionMatchTuple()
        {
            return this._sqlInjectionMatchTuple != null;
        }

    }
}