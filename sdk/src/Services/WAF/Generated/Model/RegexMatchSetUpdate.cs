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
    /// In an <a>UpdateRegexMatchSet</a> request, <code>RegexMatchSetUpdate</code> specifies
    /// whether to insert or delete a <a>RegexMatchTuple</a> and includes the settings for
    /// the <code>RegexMatchTuple</code>.
    /// </summary>
    public partial class RegexMatchSetUpdate
    {
        private ChangeAction _action;
        private RegexMatchTuple _regexMatchTuple;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies whether to insert or delete a <a>RegexMatchTuple</a>.
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
        /// Gets and sets the property RegexMatchTuple. 
        /// <para>
        /// Information about the part of a web request that you want AWS WAF to inspect and the
        /// identifier of the regular expression (regex) pattern that you want AWS WAF to search
        /// for. If you specify <code>DELETE</code> for the value of <code>Action</code>, the
        /// <code>RegexMatchTuple</code> values must exactly match the values in the <code>RegexMatchTuple</code>
        /// that you want to delete from the <code>RegexMatchSet</code>.
        /// </para>
        /// </summary>
        public RegexMatchTuple RegexMatchTuple
        {
            get { return this._regexMatchTuple; }
            set { this._regexMatchTuple = value; }
        }

        // Check to see if RegexMatchTuple property is set
        internal bool IsSetRegexMatchTuple()
        {
            return this._regexMatchTuple != null;
        }

    }
}