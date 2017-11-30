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
    /// Container for the parameters to the GetRuleGroup operation.
    /// Returns the <a>RuleGroup</a> that is specified by the <code>RuleGroupId</code> that
    /// you included in the <code>GetRuleGroup</code> request.
    /// 
    ///  
    /// <para>
    /// To view the rules in a rule group, use <a>ListActivatedRulesInRuleGroup</a>.
    /// </para>
    /// </summary>
    public partial class GetRuleGroupRequest : AmazonWAFRegionalRequest
    {
        private string _ruleGroupId;

        /// <summary>
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// The <code>RuleGroupId</code> of the <a>RuleGroup</a> that you want to get. <code>RuleGroupId</code>
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