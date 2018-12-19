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
    /// Specifies the part of a web request that you want to inspect for cross-site scripting
    /// attacks and indicates whether you want to add the specification to an <a>XssMatchSet</a>
    /// or delete it from an <code>XssMatchSet</code>.
    /// </summary>
    public partial class XssMatchSetUpdate
    {
        private ChangeAction _action;
        private XssMatchTuple _xssMatchTuple;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specify <code>INSERT</code> to add an <a>XssMatchSetUpdate</a> to an <a>XssMatchSet</a>.
        /// Use <code>DELETE</code> to remove an <code>XssMatchSetUpdate</code> from an <code>XssMatchSet</code>.
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
        /// Gets and sets the property XssMatchTuple. 
        /// <para>
        /// Specifies the part of a web request that you want AWS WAF to inspect for cross-site
        /// scripting attacks and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        /// </summary>
        public XssMatchTuple XssMatchTuple
        {
            get { return this._xssMatchTuple; }
            set { this._xssMatchTuple = value; }
        }

        // Check to see if XssMatchTuple property is set
        internal bool IsSetXssMatchTuple()
        {
            return this._xssMatchTuple != null;
        }

    }
}