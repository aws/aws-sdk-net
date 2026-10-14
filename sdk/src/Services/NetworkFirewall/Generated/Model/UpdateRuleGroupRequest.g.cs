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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateRuleGroup operation. Updates the rule settings
    /// for the specified rule group. You use a rule group by reference in one or more firewall
    /// policies. When you modify a rule group, you modify all firewall policies that use
    /// the rule group. <para> To update a rule group, first call <a>DescribeRuleGroup</a>
    /// to retrieve the current <a>RuleGroup</a> object, update the object as needed, and
    /// then provide the updated object to this call. </para>
    /// </summary>
    public partial class UpdateRuleGroupRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property AnalyzeRuleGroup. 
        /// <para>
        /// Indicates whether you want Network Firewall to analyze the stateless rules in the
        /// rule group for rule behavior such as asymmetric routing. If set to <c>TRUE</c>, Network
        /// Firewall runs the analysis and then updates the rule group for you. To run the stateless
        /// rule group analyzer without updating the rule group, set <c>DryRun</c> to <c>TRUE</c>.
        /// 
        /// </para>
        /// </summary>
        public bool? AnalyzeRuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzeRuleGroup property is set.
        /// </summary>
        internal bool IsSetAnalyzeRuleGroup() => this.AnalyzeRuleGroup.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains settings for encryption of your rule group resources.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

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
        public RuleGroup RuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroup property is set.
        /// </summary>
        internal bool IsSetRuleGroup() => this.RuleGroup != null;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string RuleGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupArn property is set.
        /// </summary>
        internal bool IsSetRuleGroupArn() => this.RuleGroupArn != null;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupName property is set.
        /// </summary>
        internal bool IsSetRuleGroupName() => this.RuleGroupName != null;

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
        [AWSProperty(Min = 0, Max = 2000000)]
        public string Rules { get; set; }

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null;

        /// <summary>
        /// Gets and sets the property SourceMetadata. 
        /// <para>
        /// A complex type that contains metadata about the rule group that your own rule group
        /// is copied from. You can use the metadata to keep track of updates made to the originating
        /// rule group.
        /// </para>
        /// </summary>
        public SourceMetadata SourceMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SourceMetadata property is set.
        /// </summary>
        internal bool IsSetSourceMetadata() => this.SourceMetadata != null;

        /// <summary>
        /// Gets and sets the property SummaryConfiguration. 
        /// <para>
        /// Updates the selected summary configuration for a rule group.
        /// </para>
        ///  
        /// <para>
        /// Changes affect subsequent responses from <a>DescribeRuleGroupSummary</a>.
        /// </para>
        /// </summary>
        public SummaryConfiguration SummaryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SummaryConfiguration property is set.
        /// </summary>
        internal bool IsSetSummaryConfiguration() => this.SummaryConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the rule group is stateless or stateful. If the rule group is stateless,
        /// it contains stateless rules. If it is stateful, it contains stateful rules. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is required for requests that do not include the <c>RuleGroupARN</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public RuleGroupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

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
        /// retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the rule group again to get a current copy of it with a
        /// current token. Reapply your changes as needed, then try the operation again using
        /// the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;
    }
}
