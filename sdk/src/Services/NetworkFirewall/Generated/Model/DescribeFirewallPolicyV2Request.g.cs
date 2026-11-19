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
    /// Container for the parameters to the DescribeFirewallPolicyV2 operation. Returns the
    /// data objects for the specified Next Generation policy.
    /// </summary>
    public partial class DescribeFirewallPolicyV2Request : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property FirewallPolicyV2Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Next Generation policy.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FirewallPolicyV2Arn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyV2Arn property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyV2Arn() => this.FirewallPolicyV2Arn != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyV2Name. 
        /// <para>
        /// The descriptive name of the Next Generation policy. You can't change the name of a
        /// firewall policy after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FirewallPolicyV2Name { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyV2Name property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyV2Name() => this.FirewallPolicyV2Name != null;

        /// <summary>
        /// Gets and sets the property RuleOutputFormat. 
        /// <para>
        /// The format in which to return the rules of any firewall engine rule groups that are
        /// embedded in the policy. Specify <c>FIREWALL_RULES</c> for structured <c>FirewallRule</c>
        /// objects or <c>RULES_STRING</c> for a Suricata-compatible firewall-mode rule string.
        /// If you don't specify a format, Network Firewall returns each embedded rule group in
        /// the format you provided it in. Referenced rule groups aren't affected.
        /// </para>
        /// </summary>
        public RuleOutputFormat RuleOutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the RuleOutputFormat property is set.
        /// </summary>
        internal bool IsSetRuleOutputFormat() => this.RuleOutputFormat != null;
    }
}
