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
    /// This is the response object from the DescribeRuleGroupMetadata operation.
    /// </summary>
    public partial class DescribeRuleGroupMetadataResponse : AmazonWebServiceResponse
    {
        private int? _capacity;
        private string _description;
        private DateTime? _lastModifiedTime;
        private string _ruleGroupArn;
        private string _ruleGroupName;
        private StatefulRuleOptions _statefulRuleOptions;
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
        /// the rule group by calling <a>CreateRuleGroup</a> with <c>DryRun</c> set to <c>TRUE</c>.
        /// 
        /// </para>
        /// </summary>
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
        /// Returns the metadata objects for the specified rule group. 
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp indicating when the rule group was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleGroupArn. 
        /// <para>
        /// The descriptive name of the rule group. You can't change the name of a rule group
        /// after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property StatefulRuleOptions.
        /// </summary>
        public StatefulRuleOptions StatefulRuleOptions
        {
            get { return this._statefulRuleOptions; }
            set { this._statefulRuleOptions = value; }
        }

        // Check to see if StatefulRuleOptions property is set
        internal bool IsSetStatefulRuleOptions()
        {
            return this._statefulRuleOptions != null;
        }

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