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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRuleGroup operation.
    /// Creates the specified stateless or stateful rule group, which includes the rules for
    /// network traffic inspection, a capacity setting, and tags. 
    /// 
    ///  
    /// <para>
    /// You provide your rule group specification in your request using either <c>RuleGroup</c>
    /// or <c>Rules</c>.
    /// </para>
    /// </summary>
    public partial class CreateRuleGroupRequest : AmazonNetworkFirewallRequest
    {
        private bool? _analyzeRuleGroup;
        private int? _capacity;
        private string _description;
        private bool? _dryRun;
        private EncryptionConfiguration _encryptionConfiguration;
        private RuleGroup _ruleGroup;
        private string _ruleGroupName;
        private string _rules;
        private SourceMetadata _sourceMetadata;
        private SummaryConfiguration _summaryConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private RuleGroupType _type;

        /// <summary>
        /// Gets and sets the property AnalyzeRuleGroup. 
        /// <para>
        /// Indicates whether you want Network Firewall to analyze the stateless rules in the
        /// rule group for rule behavior such as asymmetric routing. If set to <c>TRUE</c>, Network
        /// Firewall runs the analysis and then creates the rule group for you. To run the stateless
        /// rule group analyzer without creating the rule group, set <c>DryRun</c> to <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? AnalyzeRuleGroup
        {
            get { return this._analyzeRuleGroup; }
            set { this._analyzeRuleGroup = value; }
        }

        // Check to see if AnalyzeRuleGroup property is set
        internal bool IsSetAnalyzeRuleGroup()
        {
            return this._analyzeRuleGroup.HasValue; 
        }

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
        /// the rule group by calling <a>CreateRuleGroup</a> with <c>DryRun</c> set to <c>TRUE</c>.
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
        /// A match setting with <c>Any</c> specified has a value of 1. 
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
        public int? Capacity
        {
            get { return this._capacity; }
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
        /// If set to <c>TRUE</c>, Network Firewall checks whether the request can run successfully,
        /// but doesn't actually make the requested changes. The call returns the value that the
        /// request would return if you ran it with dry run set to <c>FALSE</c>, but doesn't make
        /// additions or changes to your resources. This option allows you to make sure that you
        /// have the required permissions to run the request and that your request parameters
        /// are valid. 
        /// </para>
        ///  
        /// <para>
        /// If set to <c>FALSE</c>, Network Firewall makes the requested changes to your resources.
        /// 
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains settings for encryption of your rule group resources.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroup. 
        /// <para>
        /// An object that defines the rule group rules. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must provide either this rule group setting or a <c>Rules</c> setting, but not
        /// both. 
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
        /// A string containing stateful rule group rules specifications in Suricata flat format,
        /// with one rule per line. Use this to import your existing Suricata compatible rule
        /// groups. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must provide either this rules setting or a populated <c>RuleGroup</c> setting,
        /// but not both. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can provide your rule group specification in Suricata flat format through this
        /// setting when you create or update your rule group. The call response returns a <a>RuleGroup</a>
        /// object that Network Firewall has populated from your string. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000000)]
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
        /// Gets and sets the property SourceMetadata. 
        /// <para>
        /// A complex type that contains metadata about the rule group that your own rule group
        /// is copied from. You can use the metadata to keep track of updates made to the originating
        /// rule group.
        /// </para>
        /// </summary>
        public SourceMetadata SourceMetadata
        {
            get { return this._sourceMetadata; }
            set { this._sourceMetadata = value; }
        }

        // Check to see if SourceMetadata property is set
        internal bool IsSetSourceMetadata()
        {
            return this._sourceMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryConfiguration. 
        /// <para>
        /// An object that contains a <c>RuleOptions</c> array of strings. You use <c>RuleOptions</c>
        /// to determine which of the following <a>RuleSummary</a> values are returned in response
        /// to <c>DescribeRuleGroupSummary</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Metadata</c> - returns
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Msg</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SID</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SummaryConfiguration SummaryConfiguration
        {
            get { return this._summaryConfiguration; }
            set { this._summaryConfiguration = value; }
        }

        // Check to see if SummaryConfiguration property is set
        internal bool IsSetSummaryConfiguration()
        {
            return this._summaryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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