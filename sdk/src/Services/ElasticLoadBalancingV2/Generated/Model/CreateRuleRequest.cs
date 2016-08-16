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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRule operation.
    /// Creates a rule for the specified listener.
    /// 
    ///  
    /// <para>
    /// A rule consists conditions and actions. Rules are evaluated in priority order, from
    /// the lowest value to the highest value. When the conditions for a rule are met, the
    /// specified actions are taken. If no rule's conditions are met, the default actions
    /// for the listener are taken.
    /// </para>
    ///  
    /// <para>
    /// To view your current rules, use <a>DescribeRules</a>. To update a rule, use <a>ModifyRule</a>.
    /// To set the priorities of your rules, use <a>SetRulePriorities</a>. To delete a rule,
    /// use <a>DeleteRule</a>.
    /// </para>
    /// </summary>
    public partial class CreateRuleRequest : AmazonElasticLoadBalancingV2Request
    {
        private List<Action> _actions = new List<Action>();
        private List<RuleCondition> _conditions = new List<RuleCondition>();
        private string _listenerArn;
        private int? _priority;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions for the rule.
        /// </para>
        /// </summary>
        public List<Action> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The conditions.
        /// </para>
        /// </summary>
        public List<RuleCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && this._conditions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        public string ListenerArn
        {
            get { return this._listenerArn; }
            set { this._listenerArn = value; }
        }

        // Check to see if ListenerArn property is set
        internal bool IsSetListenerArn()
        {
            return this._listenerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority for the rule. A listener can't have multiple rules with the same priority.
        /// </para>
        /// </summary>
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

    }
}