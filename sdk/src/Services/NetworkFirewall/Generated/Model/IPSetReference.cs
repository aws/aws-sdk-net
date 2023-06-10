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
    /// Configures one or more IP set references for a Suricata-compatible rule group. This
    /// is used in <a>CreateRuleGroup</a> or <a>UpdateRuleGroup</a>. An IP set reference is
    /// a rule variable that references resources that you create and manage in another Amazon
    /// Web Services service, such as an Amazon VPC prefix list. Network Firewall IP set references
    /// enable you to dynamically update the contents of your rules. When you create, update,
    /// or delete the resource you are referencing in your rule, Network Firewall automatically
    /// updates the rule's content with the changes. For more information about IP set references
    /// in Network Firewall, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-ip-set-references">Using
    /// IP set references</a> in the <i>Network Firewall Developer Guide</i>.
    /// 
    ///  
    /// <para>
    ///  Network Firewall currently supports <a href="https://docs.aws.amazon.com/vpc/latest/userguide/managed-prefix-lists.html">Amazon
    /// VPC prefix lists</a> and <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-ip-set-references.html#rule-groups-referencing-resource-groups">resource
    /// groups</a> in IP set references. 
    /// </para>
    /// </summary>
    public partial class IPSetReference
    {
        private string _referenceArn;

        /// <summary>
        /// Gets and sets the property ReferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that you are referencing in your rule
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ReferenceArn
        {
            get { return this._referenceArn; }
            set { this._referenceArn = value; }
        }

        // Check to see if ReferenceArn property is set
        internal bool IsSetReferenceArn()
        {
            return this._referenceArn != null;
        }

    }
}