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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The <code>ActivatedRule</code> object in an <a>UpdateWebACL</a> request specifies
    /// a <code>Rule</code> that you want to insert or delete, the priority of the <code>Rule</code>
    /// in the <code>WebACL</code>, and the action that you want AWS WAF to take when a web
    /// request matches the <code>Rule</code> (<code>ALLOW</code>, <code>BLOCK</code>, or
    /// <code>COUNT</code>).
    /// </para>
    ///  
    /// <para>
    /// To specify whether to insert or delete a <code>Rule</code>, use the <code>Action</code>
    /// parameter in the <a>WebACLUpdate</a> data type.
    /// </para>
    /// </summary>
    public partial class ActivatedRule
    {
        private WafAction _action;
        private List<ExcludedRule> _excludedRules = new List<ExcludedRule>();
        private WafOverrideAction _overrideAction;
        private int? _priority;
        private string _ruleId;
        private WafRuleType _type;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action that CloudFront or AWS WAF takes when a web request matches the
        /// conditions in the <code>Rule</code>. Valid values for <code>Action</code> include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALLOW</code>: CloudFront responds with the requested object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BLOCK</code>: CloudFront responds with an HTTP 403 (Forbidden) status code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COUNT</code>: AWS WAF increments a counter of requests that match the conditions
        /// in the rule and then continues to inspect the web request based on the remaining rules
        /// in the web ACL. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>ActivatedRule|OverrideAction</code> applies only when updating or adding a
        /// <code>RuleGroup</code> to a <code>WebACL</code>. In this case, you do not use <code>ActivatedRule|Action</code>.
        /// For all other update requests, <code>ActivatedRule|Action</code> is used instead of
        /// <code>ActivatedRule|OverrideAction</code>.
        /// </para>
        /// </summary>
        public WafAction Action
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
        /// Gets and sets the property ExcludedRules. 
        /// <para>
        /// An array of rules to exclude from a rule group. This is applicable only when the <code>ActivatedRule</code>
        /// refers to a <code>RuleGroup</code>.
        /// </para>
        ///  
        /// <para>
        /// Sometimes it is necessary to troubleshoot rule groups that are blocking traffic unexpectedly
        /// (false positives). One troubleshooting technique is to identify the specific rule
        /// within the rule group that is blocking the legitimate traffic and then disable (exclude)
        /// that particular rule. You can exclude rules from both your own rule groups and AWS
        /// Marketplace rule groups that have been associated with a web ACL.
        /// </para>
        ///  
        /// <para>
        /// Specifying <code>ExcludedRules</code> does not remove those rules from the rule group.
        /// Rather, it changes the action for the rules to <code>COUNT</code>. Therefore, requests
        /// that match an <code>ExcludedRule</code> are counted but not blocked. The <code>RuleGroup</code>
        /// owner will receive COUNT metrics for each <code>ExcludedRule</code>.
        /// </para>
        ///  
        /// <para>
        /// If you want to exclude rules from a rule group that is already associated with a web
        /// ACL, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the AWS WAF logs to identify the IDs of the rules that you want to exclude. For
        /// more information about the logs, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// Web ACL Traffic Information</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateWebACL</a> request that has two actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The first action deletes the existing rule group from the web ACL. That is, in the
        /// <a>UpdateWebACL</a> request, the first <code>Updates:Action</code> should be <code>DELETE</code>
        /// and <code>Updates:ActivatedRule:RuleId</code> should be the rule group that contains
        /// the rules that you want to exclude.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The second action inserts the same rule group back in, but specifying the rules to
        /// exclude. That is, the second <code>Updates:Action</code> should be <code>INSERT</code>,
        /// <code>Updates:ActivatedRule:RuleId</code> should be the rule group that you just removed,
        /// and <code>ExcludedRules</code> should contain the rules that you want to exclude.
        /// </para>
        ///  </li> </ul> </li> </ol>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property OverrideAction. 
        /// <para>
        /// Use the <code>OverrideAction</code> to test your <code>RuleGroup</code>.
        /// </para>
        ///  
        /// <para>
        /// Any rule in a <code>RuleGroup</code> can potentially block a request. If you set the
        /// <code>OverrideAction</code> to <code>None</code>, the <code>RuleGroup</code> will
        /// block a request if any individual rule in the <code>RuleGroup</code> matches the request
        /// and is configured to block that request. However if you first want to test the <code>RuleGroup</code>,
        /// set the <code>OverrideAction</code> to <code>Count</code>. The <code>RuleGroup</code>
        /// will then override any block action specified by individual rules contained within
        /// the group. Instead of blocking matching requests, those requests will be counted.
        /// You can view a record of counted requests using <a>GetSampledRequests</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <code>ActivatedRule|OverrideAction</code> applies only when updating or adding a
        /// <code>RuleGroup</code> to a <code>WebACL</code>. In this case you do not use <code>ActivatedRule|Action</code>.
        /// For all other update requests, <code>ActivatedRule|Action</code> is used instead of
        /// <code>ActivatedRule|OverrideAction</code>.
        /// </para>
        /// </summary>
        public WafOverrideAction OverrideAction
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
        /// Specifies the order in which the <code>Rules</code> in a <code>WebACL</code> are evaluated.
        /// Rules with a lower value for <code>Priority</code> are evaluated before <code>Rules</code>
        /// with a higher value. The value must be a unique integer. If you add multiple <code>Rules</code>
        /// to a <code>WebACL</code>, the values don't need to be consecutive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The <code>RuleId</code> for a <code>Rule</code>. You use <code>RuleId</code> to get
        /// more information about a <code>Rule</code> (see <a>GetRule</a>), update a <code>Rule</code>
        /// (see <a>UpdateRule</a>), insert a <code>Rule</code> into a <code>WebACL</code> or
        /// delete a one from a <code>WebACL</code> (see <a>UpdateWebACL</a>), or delete a <code>Rule</code>
        /// from AWS WAF (see <a>DeleteRule</a>).
        /// </para>
        ///  
        /// <para>
        ///  <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The rule type, either <code>REGULAR</code>, as defined by <a>Rule</a>, <code>RATE_BASED</code>,
        /// as defined by <a>RateBasedRule</a>, or <code>GROUP</code>, as defined by <a>RuleGroup</a>.
        /// The default is REGULAR. Although this field is optional, be aware that if you try
        /// to add a RATE_BASED rule to a web ACL without setting the type, the <a>UpdateWebACL</a>
        /// request will fail because the request tries to add a REGULAR rule with the specified
        /// ID, which does not exist. 
        /// </para>
        /// </summary>
        public WafRuleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}