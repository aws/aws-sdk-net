/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rule statement used to run the rules that are defined in a <a>RuleGroup</a>. To
    /// use this, create a rule group with your rules, then provide the ARN of the rule group
    /// in this statement.
    /// 
    ///  
    /// <para>
    /// You cannot nest a <code>RuleGroupReferenceStatement</code>, for example for use inside
    /// a <code>NotStatement</code> or <code>OrStatement</code>. You can only use a rule group
    /// reference statement at the top level inside a web ACL. 
    /// </para>
    /// </summary>
    public partial class RuleGroupReferenceStatement
    {
        private string _arn;
        private List<ExcludedRule> _excludedRules = new List<ExcludedRule>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedRules. 
        /// <para>
        /// The rules in the referenced rule group whose actions are set to <code>Count</code>.
        /// When you exclude a rule, WAF evaluates it exactly as it would if the rule action setting
        /// were <code>Count</code>. This is a useful option for testing the rules in a rule group
        /// without modifying how they handle your web traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<ExcludedRule> ExcludedRules
        {
            get { return this._excludedRules; }
            set { this._excludedRules = value; }
        }

        // Check to see if ExcludedRules property is set
        internal bool IsSetExcludedRules()
        {
            return this._excludedRules != null && this._excludedRules.Count > 0; 
        }

    }
}