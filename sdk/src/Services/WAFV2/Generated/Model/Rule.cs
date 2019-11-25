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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// A single rule, which you can use in a <a>WebACL</a> or <a>RuleGroup</a> to identify
    /// web requests that you want to allow, block, or count. Each rule includes one top-level
    /// <a>Statement</a> that AWS WAF uses to identify matching web requests, and parameters
    /// that govern how AWS WAF handles them. 
    /// </para>
    /// </summary>
    public partial class Rule
    {
        private RuleAction _action;
        private string _name;
        private OverrideAction _overrideAction;
        private int? _priority;
        private Statement _statement;
        private VisibilityConfig _visibilityConfig;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that AWS WAF should take on a web request when it matches the rule's statement.
        /// Settings at the web ACL level can override the rule action setting. 
        /// </para>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name of the rule. You can't change the name of a <code>Rule</code> after
        /// you create it. 
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
        /// The action to use to override the rule's <code>Action</code> setting. You can use
        /// no override action, in which case the rule action is in effect, or count action, in
        /// which case, if the rule matches a web request, it only counts the match.
        /// </para>
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
        /// If you define more than one <code>Rule</code> in a <code>WebACL</code>, AWS WAF evaluates
        /// each request against the <code>Rules</code> in order based on the value of <code>Priority</code>.
        /// AWS WAF processes rules with lower priority first. The priorities don't need to be
        /// consecutive, but they must all be different.
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
        /// Gets and sets the property Statement. 
        /// <para>
        /// The AWS WAF processing statement for the rule, for example <a>ByteMatchStatement</a>
        /// or <a>SizeConstraintStatement</a>. 
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