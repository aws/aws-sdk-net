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
    /// Container for the parameters to the DescribeRuleGroupSummary operation.
    /// Returns detailed information for a stateful rule group.
    /// 
    ///  
    /// <para>
    /// For active threat defense Amazon Web Services managed rule groups, this operation
    /// provides insight into the protections enabled by the rule group, based on Suricata
    /// rule metadata fields. Summaries are available for rule groups you manage and for active
    /// threat defense Amazon Web Services managed rule groups.
    /// </para>
    ///  
    /// <para>
    /// To modify how threat information appears in summaries, use the <c>SummaryConfiguration</c>
    /// parameter in <a>UpdateRuleGroup</a>.
    /// </para>
    /// </summary>
    public partial class DescribeRuleGroupSummaryRequest : AmazonNetworkFirewallRequest
    {
        private string _ruleGroupArn;
        private string _ruleGroupName;
        private RuleGroupType _type;

        /// <summary>
        /// Gets and sets the property RuleGroupArn. 
        /// <para>
        /// Required. The Amazon Resource Name (ARN) of the rule group.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of rule group you want a summary for. This is a required field.
        /// </para>
        ///  
        /// <para>
        /// Valid value: <c>STATEFUL</c> 
        /// </para>
        ///  
        /// <para>
        /// Note that <c>STATELESS</c> exists but is not currently supported. If you provide <c>STATELESS</c>,
        /// an exception is returned.
        /// </para>
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

    }
}