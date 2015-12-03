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
    /// Contains the identifier and the friendly name or description of the <code>Rule</code>.
    /// </summary>
    public partial class RuleSummary
    {
        private string _name;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>Rule</a>. You can't change the name of a
        /// <code>Rule</code> after you create it.
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
        /// Gets and sets the property RuleId. 
        /// <para>
        /// A unique identifier for a <code>Rule</code>. You use <code>RuleId</code> to get more
        /// information about a <code>Rule</code> (see <a>GetRule</a>), update a <code>Rule</code>
        /// (see <a>UpdateRule</a>), insert a <code>Rule</code> into a <code>WebACL</code> or
        /// delete one from a <code>WebACL</code> (see <a>UpdateWebACL</a>), or delete a <code>Rule</code>
        /// from AWS WAF (see <a>DeleteRule</a>).
        /// </para>
        ///  
        /// <para>
        /// <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.
        /// </para>
        /// </summary>
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

    }
}