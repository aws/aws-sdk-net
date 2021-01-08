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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRuleGroup operation.
    /// Updates the rule settings for the specified rule group. You use a rule group by reference
    /// in one or more firewall policies. When you modify a rule group, you modify all firewall
    /// policies that use the rule group. 
    /// 
    ///  
    /// <para>
    /// To update a rule group, first call <a>DescribeRuleGroup</a> to retrieve the current
    /// <a>RuleGroup</a> object, update the object as needed, and then provide the updated
    /// object to this call. 
    /// </para>
    /// </summary>
    public partial class UpdateRuleGroupRequest : AmazonNetworkFirewallRequest
    {
        private string _description;
        private bool? _dryRun;
        private RuleGroup _ruleGroup;
        private string _ruleGroupArn;
        private string _ruleGroupName;
        private string _rules;
        private RuleGroupType _type;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Indicates whether you want Network Firewall to just check the validity of the request,
        /// rather than run the request. 
        /// </para>
        ///  
        /// <para>
        /// If set to <code>TRUE</code>, Network Firewall checks whether the request can run successfully,
        /// but doesn't actually make the requested changes. The call returns the value that the
        /// request would return if you ran it with dry run set to <code>FALSE</code>, but doesn't
        /// make additions or changes to your resources. This option allows you to make sure that
        /// you have the required permissions to run the request and that your request parameters
        /// are valid. 
        /// </para>
        ///  
        /// <para>
        /// If set to <code>FALSE</code>, Network Firewall makes the requested changes to your
        /// resources. 
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleGroup. 
        /// <para>
        /// An object that defines the rule group rules. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must provide either this rule group setting or a <code>Rules</code> setting, but
        /// not both. 
        /// </para>
        ///  </note>
        /// </summary>
        public RuleGroup RuleGroup
        {
            get { return this._ruleGroup; }
            set { this._ruleGroup = value; }
        }

        // Check to see if RuleGroup property is set
        internal bool IsSetRuleGroup()
        {
            return this._ruleGroup != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule group.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RuleGroupArn
        {
            get { return this._ruleGroupArn; }
            set { this._ruleGroupArn = value; }
        }

        // Check to see if RuleGroupArn property is set
        internal bool IsSetRuleGroupArn()
        {
            return this._ruleGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupName. 
        /// <para>
        /// The descriptive name of the rule group. You can't change the name of a rule group
        /// after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RuleGroupName
        {
            get { return this._ruleGroupName; }
            set { this._ruleGroupName = value; }
        }

        // Check to see if RuleGroupName property is set
        internal bool IsSetRuleGroupName()
        {
            return this._ruleGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The name of a file containing stateful rule group rules specifications in Suricata
        /// flat format, with one rule per line. Use this to import your existing Suricata compatible
        /// rule groups. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must provide either this rules setting or a populated <code>RuleGroup</code> setting,
        /// but not both. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can provide your rule group specification in a file through this setting when
        /// you create or update your rule group. The call response returns a <a>RuleGroup</a>
        /// object that Network Firewall has populated from your file. Network Firewall uses the
        /// file contents to populate the rule group rules, but does not maintain a reference
        /// to the file or use the file in any way after performing the create or update. If you
        /// call <a>DescribeRuleGroup</a> to retrieve the rule group, Network Firewall returns
        /// rules settings inside a <a>RuleGroup</a> object. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public string Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the rule group is stateless or stateful. If the rule group is stateless,
        /// it contains stateless rules. If it is stateful, it contains stateful rules. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is required for requests that do not include the <code>RuleGroupARN</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public RuleGroupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the rule group. The token marks the state of the rule group resource at
        /// the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the rule group, you provide the token in your request. Network
        /// Firewall uses the token to ensure that the rule group hasn't changed since you last
        /// retrieved it. If it has changed, the operation fails with an <code>InvalidTokenException</code>.
        /// If this happens, retrieve the rule group again to get a current copy of it with a
        /// current token. Reapply your changes as needed, then try the operation again using
        /// the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}