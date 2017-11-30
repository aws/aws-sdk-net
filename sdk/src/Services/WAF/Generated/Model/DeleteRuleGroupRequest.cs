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
    /// Container for the parameters to the DeleteRuleGroup operation.
    /// Permanently deletes a <a>RuleGroup</a>. You can't delete a <code>RuleGroup</code>
    /// if it's still used in any <code>WebACL</code> objects or if it still includes any
    /// rules.
    /// 
    ///  
    /// <para>
    /// If you just want to remove a <code>RuleGroup</code> from a <code>WebACL</code>, use
    /// <a>UpdateWebACL</a>.
    /// </para>
    ///  
    /// <para>
    /// To permanently delete a <code>RuleGroup</code> from AWS WAF, perform the following
    /// steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Update the <code>RuleGroup</code> to remove rules, if any. For more information, see
    /// <a>UpdateRuleGroup</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>DeleteRuleGroup</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <code>DeleteRuleGroup</code> request.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class DeleteRuleGroupRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _ruleGroupId;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// The <code>RuleGroupId</code> of the <a>RuleGroup</a> that you want to delete. <code>RuleGroupId</code>
        /// is returned by <a>CreateRuleGroup</a> and by <a>ListRuleGroups</a>.
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