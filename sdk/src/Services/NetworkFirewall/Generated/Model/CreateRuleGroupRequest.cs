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
    /// Container for the parameters to the CreateRuleGroup operation.
    /// Creates the specified stateless or stateful rule group, which includes the rules for
    /// network traffic inspection, a capacity setting, and tags. 
    /// 
    ///  
    /// <para>
    /// You provide your rule group specification in your request using either <code>RuleGroup</code>
    /// or <code>Rules</code>.
    /// </para>
    /// </summary>
    public partial class CreateRuleGroupRequest : AmazonNetworkFirewallRequest
    {
        private int? _capacity;
        private string _description;
        private bool? _dryRun;
        private RuleGroup _ruleGroup;
        private string _ruleGroupName;
        private string _rules;
        private List<Tag> _tags = new List<Tag>();
        private RuleGroupType _type;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The maximum operating resources that this rule group can use. Rule group capacity
        /// is fixed at creation. When you update a rule group, you are limited to this capacity.
        /// When you reference a rule group from a firewall policy, Network Firewall reserves
        /// this capacity for the rule group. 
        /// </para>
        ///  
        /// <para>
        /// You can retrieve the capacity that would be required for a rule group before you create
        /// the rule group by calling <a>CreateRuleGroup</a> with <code>DryRun</code> set to <code>TRUE</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't change or exceed this capacity when you update the rule group, so leave
        /// room for your rule group to grow. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Capacity for a stateless rule group</b> 
        /// </para>
        ///  
        /// <para>
        /// For a stateless rule group, the capacity required is the sum of the capacity requirements
        /// of the individual rules that you expect to have in the rule group. 
        /// </para>
        ///  
        /// <para>
        /// To calculate the capacity requirement of a single rule, multiply the capacity requirement
        /// values of each of the rule's match settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A match setting with no criteria specified has a value of 1. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A match setting with <code>Any</code> specified has a value of 1. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All other match settings have a value equal to the number of elements provided in
        /// the setting. For example, a protocol setting ["UDP"] and a source setting ["10.0.0.0/24"]
        /// each have a value of 1. A protocol setting ["UDP","TCP"] has a value of 2. A source
        /// setting ["10.0.0.0/24","10.0.0.1/24","10.0.0.2/24"] has a value of 3. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A rule with no criteria specified in any of its match settings has a capacity requirement
        /// of 1. A rule with protocol setting ["UDP","TCP"], source setting ["10.0.0.0/24","10.0.0.1/24","10.0.0.2/24"],
        /// and a single specification or no specification for each of the other match settings
        /// has a capacity requirement of 6. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Capacity for a stateful rule group</b> 
        /// </para>
        ///  
        /// <para>
        /// For a stateful rule group, the minimum capacity required is the number of individual
        /// rules that you expect to have in the rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Capacity
        {
            get { return this._capacity.GetValueOrDefault(); }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

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
        /// Gets and sets the property RuleGroupName. 
        /// <para>
        /// The descriptive name of the rule group. You can't change the name of a rule group
        /// after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the rule group is stateless or stateful. If the rule group is stateless,
        /// it contains stateless rules. If it is stateful, it contains stateful rules. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}