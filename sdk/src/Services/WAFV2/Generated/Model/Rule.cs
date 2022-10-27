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
    /// A single rule, which you can use in a <a>WebACL</a> or <a>RuleGroup</a> to identify
    /// web requests that you want to allow, block, or count. Each rule includes one top-level
    /// <a>Statement</a> that WAF uses to identify matching web requests, and parameters that
    /// govern how WAF handles them.
    /// </summary>
    public partial class Rule
    {
        private RuleAction _action;
        private CaptchaConfig _captchaConfig;
        private ChallengeConfig _challengeConfig;
        private string _name;
        private OverrideAction _overrideAction;
        private int? _priority;
        private List<Label> _ruleLabels = new List<Label>();
        private Statement _statement;
        private VisibilityConfig _visibilityConfig;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that WAF should take on a web request when it matches the rule statement.
        /// Settings at the web ACL level can override the rule action setting. 
        /// </para>
        ///  
        /// <para>
        /// This is used only for rules whose statements do not reference a rule group. Rule statements
        /// that reference a rule group include <code>RuleGroupReferenceStatement</code> and <code>ManagedRuleGroupStatement</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must specify either this <code>Action</code> setting or the rule <code>OverrideAction</code>
        /// setting, but not both:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the rule statement does not reference a rule group, use this rule action setting
        /// and not the rule override action setting. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the rule statement references a rule group, use the override action setting and
        /// not this action setting. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RuleAction Action
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
        /// Gets and sets the property CaptchaConfig. 
        /// <para>
        /// Specifies how WAF should handle <code>CAPTCHA</code> evaluations. If you don't specify
        /// this, WAF uses the <code>CAPTCHA</code> configuration that's defined for the web ACL.
        /// 
        /// </para>
        /// </summary>
        public CaptchaConfig CaptchaConfig
        {
            get { return this._captchaConfig; }
            set { this._captchaConfig = value; }
        }

        // Check to see if CaptchaConfig property is set
        internal bool IsSetCaptchaConfig()
        {
            return this._captchaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeConfig. 
        /// <para>
        /// Specifies how WAF should handle <code>Challenge</code> evaluations. If you don't specify
        /// this, WAF uses the challenge configuration that's defined for the web ACL. 
        /// </para>
        /// </summary>
        public ChallengeConfig ChallengeConfig
        {
            get { return this._challengeConfig; }
            set { this._challengeConfig = value; }
        }

        // Check to see if ChallengeConfig property is set
        internal bool IsSetChallengeConfig()
        {
            return this._challengeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule. You can't change the name of a <code>Rule</code> after you create
        /// it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property OverrideAction. 
        /// <para>
        /// The action to use in the place of the action that results from the rule group evaluation.
        /// Set the override action to none to leave the result of the rule group alone. Set it
        /// to count to override the result to count only. 
        /// </para>
        ///  
        /// <para>
        /// You can only use this for rule statements that reference a rule group, like <code>RuleGroupReferenceStatement</code>
        /// and <code>ManagedRuleGroupStatement</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This option is usually set to none. It does not affect how the rules in the rule group
        /// are evaluated. If you want the rules in the rule group to only count matches, do not
        /// use this and instead use the rule action override option, with <code>Count</code>
        /// action, in your rule group reference statement settings. 
        /// </para>
        ///  </note>
        /// </summary>
        public OverrideAction OverrideAction
        {
            get { return this._overrideAction; }
            set { this._overrideAction = value; }
        }

        // Check to see if OverrideAction property is set
        internal bool IsSetOverrideAction()
        {
            return this._overrideAction != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// If you define more than one <code>Rule</code> in a <code>WebACL</code>, WAF evaluates
        /// each request against the <code>Rules</code> in order based on the value of <code>Priority</code>.
        /// WAF processes rules with lower priority first. The priorities don't need to be consecutive,
        /// but they must all be different.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleLabels. 
        /// <para>
        /// Labels to apply to web requests that match the rule match statement. WAF applies fully
        /// qualified labels to matching web requests. A fully qualified label is the concatenation
        /// of a label namespace and a rule label. The rule's rule group or web ACL defines the
        /// label namespace. 
        /// </para>
        ///  
        /// <para>
        /// Rules that run after this rule in the web ACL can match against these labels using
        /// a <code>LabelMatchStatement</code>.
        /// </para>
        ///  
        /// <para>
        /// For each label, provide a case-sensitive string containing optional namespaces and
        /// a label name, according to the following guidelines:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Separate each component of the label with a colon. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each namespace or name can have up to 128 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can specify up to 5 namespaces in a label.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don't use the following reserved words in your label specification: <code>aws</code>,
        /// <code>waf</code>, <code>managed</code>, <code>rulegroup</code>, <code>webacl</code>,
        /// <code>regexpatternset</code>, or <code>ipset</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <code>myLabelName</code> or <code>nameSpace1:nameSpace2:myLabelName</code>.
        /// 
        /// </para>
        /// </summary>
        public List<Label> RuleLabels
        {
            get { return this._ruleLabels; }
            set { this._ruleLabels = value; }
        }

        // Check to see if RuleLabels property is set
        internal bool IsSetRuleLabels()
        {
            return this._ruleLabels != null && this._ruleLabels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// The WAF processing statement for the rule, for example <a>ByteMatchStatement</a> or
        /// <a>SizeConstraintStatement</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Statement Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

        /// <summary>
        /// Gets and sets the property VisibilityConfig. 
        /// <para>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VisibilityConfig VisibilityConfig
        {
            get { return this._visibilityConfig; }
            set { this._visibilityConfig = value; }
        }

        // Check to see if VisibilityConfig property is set
        internal bool IsSetVisibilityConfig()
        {
            return this._visibilityConfig != null;
        }

    }
}