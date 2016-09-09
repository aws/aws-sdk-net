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
    /// Container for the parameters to the ModifyRule operation.
    /// Modifies the specified rule.
    /// 
    ///  
    /// <para>
    /// Any existing properties that you do not modify retain their current values.
    /// </para>
    ///  
    /// <para>
    /// To modify the default action, use <a>ModifyListener</a>.
    /// </para>
    /// </summary>
    public partial class ModifyRuleRequest : AmazonElasticLoadBalancingV2Request
    {
        private List<Action> _actions = new List<Action>();
        private List<RuleCondition> _conditions = new List<RuleCondition>();
        private string _ruleArn;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions.
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
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule.
        /// </para>
        /// </summary>
        public string RuleArn
        {
            get { return this._ruleArn; }
            set { this._ruleArn = value; }
        }

        // Check to see if RuleArn property is set
        internal bool IsSetRuleArn()
        {
            return this._ruleArn != null;
        }

    }
}