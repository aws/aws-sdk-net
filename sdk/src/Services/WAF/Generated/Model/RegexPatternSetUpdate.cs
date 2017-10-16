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
    /// In an <a>UpdateRegexPatternSet</a> request, <code>RegexPatternSetUpdate</code> specifies
    /// whether to insert or delete a <code>RegexPatternString</code> and includes the settings
    /// for the <code>RegexPatternString</code>.
    /// </summary>
    public partial class RegexPatternSetUpdate
    {
        private ChangeAction _action;
        private string _regexPatternString;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies whether to insert or delete a <code>RegexPatternString</code>.
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
        /// Gets and sets the property RegexPatternString. 
        /// <para>
        /// Specifies the regular expression (regex) pattern that you want AWS WAF to search for,
        /// such as <code>B[a@]dB[o0]t</code>.
        /// </para>
        /// </summary>
        public string RegexPatternString
        {
            get { return this._regexPatternString; }
            set { this._regexPatternString = value; }
        }

        // Check to see if RegexPatternString property is set
        internal bool IsSetRegexPatternString()
        {
            return this._regexPatternString != null;
        }

    }
}