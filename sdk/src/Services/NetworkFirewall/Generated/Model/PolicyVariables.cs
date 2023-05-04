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
    /// Contains variables that you can use to override default Suricata settings in your
    /// firewall policy.
    /// </summary>
    public partial class PolicyVariables
    {
        private Dictionary<string, IPSet> _ruleVariables = new Dictionary<string, IPSet>();

        /// <summary>
        /// Gets and sets the property RuleVariables. 
        /// <para>
        /// The IPv4 or IPv6 addresses in CIDR notation to use for the Suricata <code>HOME_NET</code>
        /// variable. If your firewall uses an inspection VPC, you might want to override the
        /// <code>HOME_NET</code> variable with the CIDRs of your home networks. If you don't
        /// override <code>HOME_NET</code> with your own CIDRs, Network Firewall by default uses
        /// the CIDR of your inspection VPC.
        /// </para>
        /// </summary>
        public Dictionary<string, IPSet> RuleVariables
        {
            get { return this._ruleVariables; }
            set { this._ruleVariables = value; }
        }

        // Check to see if RuleVariables property is set
        internal bool IsSetRuleVariables()
        {
            return this._ruleVariables != null && this._ruleVariables.Count > 0; 
        }

    }
}