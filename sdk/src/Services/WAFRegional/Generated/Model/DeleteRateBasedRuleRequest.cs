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
    /// Container for the parameters to the DeleteRateBasedRule operation.
    /// Permanently deletes a <a>RateBasedRule</a>. You can't delete a rule if it's still
    /// used in any <code>WebACL</code> objects or if it still includes any predicates, such
    /// as <code>ByteMatchSet</code> objects.
    /// 
    ///  
    /// <para>
    /// If you just want to remove a rule from a <code>WebACL</code>, use <a>UpdateWebACL</a>.
    /// </para>
    ///  
    /// <para>
    /// To permanently delete a <code>RateBasedRule</code> from AWS WAF, perform the following
    /// steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Update the <code>RateBasedRule</code> to remove predicates, if any. For more information,
    /// see <a>UpdateRateBasedRule</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>DeleteRateBasedRule</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <code>DeleteRateBasedRule</code> request.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class DeleteRateBasedRuleRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _ruleId;

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
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The <code>RuleId</code> of the <a>RateBasedRule</a> that you want to delete. <code>RuleId</code>
        /// is returned by <a>CreateRateBasedRule</a> and by <a>ListRateBasedRules</a>.
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