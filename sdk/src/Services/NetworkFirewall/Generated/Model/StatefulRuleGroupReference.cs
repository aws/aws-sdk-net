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
    /// Identifier for a single stateful rule group, used in a firewall policy to refer to
    /// a rule group.
    /// </summary>
    public partial class StatefulRuleGroupReference
    {
        private StatefulRuleGroupOverride _override;
        private int? _priority;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// The action that allows the policy owner to override the behavior of the rule group
        /// within a policy.
        /// </para>
        /// </summary>
        public StatefulRuleGroupOverride Override
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
        /// in a single <a>FirewallPolicy</a>. This setting only applies to firewall policies
        /// that specify the <code>STRICT_ORDER</code> rule order in the stateful engine options
        /// settings.
        /// </para>
        ///  
        /// <para>
        /// Network Firewall evalutes each stateful rule group against a packet starting with
        /// the group that has the lowest priority setting. You must ensure that the priority
        /// settings are unique within each policy.
        /// </para>
        ///  
        /// <para>
        /// You can change the priority settings of your rule groups at any time. To make it easier
        /// to insert rule groups later, number them so there's a wide range in between, for example
        /// use 100, 200, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stateful rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}