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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Network Firewall stateful rule group, used in a <a>NetworkFirewallPolicyDescription</a>.
    /// </summary>
    public partial class StatefulRuleGroup
    {
        private NetworkFirewallStatefulRuleGroupOverride _override;
        private int? _priority;
        private string _resourceId;
        private string _ruleGroupName;

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// The action that allows the policy owner to override the behavior of the rule group
        /// within a policy.
        /// </para>
        /// </summary>
        public NetworkFirewallStatefulRuleGroupOverride Override
        {
            get { return this._override; }
            set { this._override = value; }
        }

        // Check to see if Override property is set
        internal bool IsSetOverride()
        {
            return this._override != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// An integer setting that indicates the order in which to run the stateful rule groups
        /// in a single Network Firewall firewall policy. This setting only applies to firewall
        /// policies that specify the <c>STRICT_ORDER</c> rule order in the stateful engine options
        /// settings.
        /// </para>
        ///  
        /// <para>
        ///  Network Firewall evalutes each stateful rule group against a packet starting with
        /// the group that has the lowest priority setting. You must ensure that the priority
        /// settings are unique within each policy. For information about 
        /// </para>
        ///  
        /// <para>
        ///  You can change the priority settings of your rule groups at any time. To make it
        /// easier to insert rule groups later, number them so there's a wide range in between,
        /// for example use 100, 200, and so on. 
        /// </para>
        /// </summary>
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID of the rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupName. 
        /// <para>
        /// The name of the rule group.
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

    }
}