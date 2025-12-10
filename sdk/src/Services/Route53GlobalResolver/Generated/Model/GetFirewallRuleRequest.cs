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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
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
namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the GetFirewallRule operation.
    /// Retrieves information about a DNS firewall rule.
    /// </summary>
    public partial class GetFirewallRuleRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _firewallRuleId;

        /// <summary>
        /// Gets and sets the property FirewallRuleId. 
        /// <para>
        /// ID of the DNS Firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FirewallRuleId
        {
            get { return this._firewallRuleId; }
            set { this._firewallRuleId = value; }
        }

        // Check to see if FirewallRuleId property is set
        internal bool IsSetFirewallRuleId()
        {
            return this._firewallRuleId != null;
        }

    }
}