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
    /// Contains the identifier and the friendly name or description of the <code>RuleGroup</code>.
    /// </summary>
    public partial class RuleGroupSummary
    {
        private string _name;
        private string _ruleGroupId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>RuleGroup</a>. You can't change the name
        /// of a <code>RuleGroup</code> after you create it.
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
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// A unique identifier for a <code>RuleGroup</code>. You use <code>RuleGroupId</code>
        /// to get more information about a <code>RuleGroup</code> (see <a>GetRuleGroup</a>),
        /// update a <code>RuleGroup</code> (see <a>UpdateRuleGroup</a>), insert a <code>RuleGroup</code>
        /// into a <code>WebACL</code> or delete one from a <code>WebACL</code> (see <a>UpdateWebACL</a>),
        /// or delete a <code>RuleGroup</code> from AWS WAF (see <a>DeleteRuleGroup</a>).
        /// </para>
        ///  
        /// <para>
        ///  <code>RuleGroupId</code> is returned by <a>CreateRuleGroup</a> and by <a>ListRuleGroups</a>.
        /// </para>
        /// </summary>
        public string RuleGroupId
        {
            get { return this._ruleGroupId; }
            set { this._ruleGroupId = value; }
        }

        // Check to see if RuleGroupId property is set
        internal bool IsSetRuleGroupId()
        {
            return this._ruleGroupId != null;
        }

    }
}