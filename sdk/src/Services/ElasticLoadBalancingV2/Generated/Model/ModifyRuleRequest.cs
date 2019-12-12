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
    /// Replaces the specified properties of the specified rule. Any properties that you do
    /// not specify are unchanged.
    /// 
    ///  
    /// <para>
    /// To add an item to a list, remove an item from a list, or update an item in a list,
    /// you must provide the entire list. For example, to add an action, specify a list with
    /// the current actions plus the new action.
    /// </para>
    ///  
    /// <para>
    /// To modify the actions for the default rule, use <a>ModifyListener</a>.
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
        /// The actions. Each rule must include exactly one of the following types of actions:
        /// <code>forward</code>, <code>fixed-response</code>, or <code>redirect</code>, and it
        /// must be the last action to be performed.
        /// </para>
        ///  
        /// <para>
        /// If the action type is <code>forward</code>, you specify one or more target groups.
        /// The protocol of the target group must be HTTP or HTTPS for an Application Load Balancer.
        /// The protocol of the target group must be TCP, TLS, UDP, or TCP_UDP for a Network Load
        /// Balancer.
        /// </para>
        ///  
        /// <para>
        /// [HTTPS listeners] If the action type is <code>authenticate-oidc</code>, you authenticate
        /// users through an identity provider that is OpenID Connect (OIDC) compliant.
        /// </para>
        ///  
        /// <para>
        /// [HTTPS listeners] If the action type is <code>authenticate-cognito</code>, you authenticate
        /// users through the user pools supported by Amazon Cognito.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancer] If the action type is <code>redirect</code>, you redirect
        /// specified client requests from one URL to another.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancer] If the action type is <code>fixed-response</code>, you
        /// drop specified client requests and return a custom HTTP response.
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
        /// The conditions. Each rule can include zero or one of the following conditions: <code>http-request-method</code>,
        /// <code>host-header</code>, <code>path-pattern</code>, and <code>source-ip</code>, and
        /// zero or more of the following conditions: <code>http-header</code> and <code>query-string</code>.
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
        [AWSProperty(Required=true)]
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