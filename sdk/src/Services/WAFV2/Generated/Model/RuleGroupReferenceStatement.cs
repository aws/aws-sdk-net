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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rule statement used to run the rules that are defined in a <a>RuleGroup</a>. To
    /// use this, create a rule group with your rules, then provide the ARN of the rule group
    /// in this statement.
    /// 
    ///  
    /// <para>
    /// You cannot nest a <c>RuleGroupReferenceStatement</c>, for example for use inside a
    /// <c>NotStatement</c> or <c>OrStatement</c>. You cannot use a rule group reference statement
    /// inside another rule group. You can only reference a rule group as a top-level statement
    /// within a rule that you define in a web ACL.
    /// </para>
    /// </summary>
    public partial class RuleGroupReferenceStatement
    {
        private string _arn;
        private List<ExcludedRule> _excludedRules = AWSConfigs.InitializeCollections ? new List<ExcludedRule>() : null;
        private List<RuleActionOverride> _ruleActionOverrides = AWSConfigs.InitializeCollections ? new List<RuleActionOverride>() : null;

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
        /// Rules in the referenced rule group whose actions are set to <c>Count</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instead of this option, use <c>RuleActionOverrides</c>. It accepts any valid action
        /// setting, including <c>Count</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._excludedRules != null && (this._excludedRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleActionOverrides. 
        /// <para>
        /// Action settings to use in the place of the rule actions that are configured inside
        /// the rule group. You specify one override for each rule whose action you want to change.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Verify the rule names in your overrides carefully. With managed rule groups, WAF silently
        /// ignores any override that uses an invalid rule name. With customer-owned rule groups,
        /// invalid rule names in your overrides will cause web ACL updates to fail. An invalid
        /// rule name is any name that doesn't exactly match the case-sensitive name of an existing
        /// rule in the rule group.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use overrides for testing, for example you can override all of rule actions
        /// to <c>Count</c> and then monitor the resulting count metrics to understand how the
        /// rule group would handle your web traffic. You can also permanently override some or
        /// all actions, to modify how the rule group manages your web traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<RuleActionOverride> RuleActionOverrides
        {
            get { return this._ruleActionOverrides; }
            set { this._ruleActionOverrides = value; }
        }

        // Check to see if RuleActionOverrides property is set
        internal bool IsSetRuleActionOverrides()
        {
            return this._ruleActionOverrides != null && (this._ruleActionOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}