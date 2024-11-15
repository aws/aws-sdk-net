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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFirewallRule operation.
    /// Deletes the specified firewall rule.
    /// </summary>
    public partial class DeleteFirewallRuleRequest : AmazonRoute53ResolverRequest
    {
        private string _firewallDomainListId;
        private string _firewallRuleGroupId;
        private string _firewallThreatProtectionId;
        private string _qtype;

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the domain list that's used in the rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FirewallDomainListId
        {
            get { return this._firewallDomainListId; }
            set { this._firewallDomainListId = value; }
        }

        // Check to see if FirewallDomainListId property is set
        internal bool IsSetFirewallDomainListId()
        {
            return this._firewallDomainListId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group that you want to delete the rule
        /// from. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FirewallRuleGroupId
        {
            get { return this._firewallRuleGroupId; }
            set { this._firewallRuleGroupId = value; }
        }

        // Check to see if FirewallRuleGroupId property is set
        internal bool IsSetFirewallRuleGroupId()
        {
            return this._firewallRuleGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallThreatProtectionId. 
        /// <para>
        ///  The ID that is created for a DNS Firewall Advanced rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FirewallThreatProtectionId
        {
            get { return this._firewallThreatProtectionId; }
            set { this._firewallThreatProtectionId = value; }
        }

        // Check to see if FirewallThreatProtectionId property is set
        internal bool IsSetFirewallThreatProtectionId()
        {
            return this._firewallThreatProtectionId != null;
        }

        /// <summary>
        /// Gets and sets the property Qtype. 
        /// <para>
        ///  The DNS query type that the rule you are deleting evaluates. Allowed values are;
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A: Returns an IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AAAA: Returns an Ipv6 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CAA: Restricts CAs that can create SSL/TLS certifications for the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CNAME: Returns another domain name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DS: Record that identifies the DNSSEC signing key of a delegated zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MX: Specifies mail servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NAPTR: Regular-expression-based rewriting of domain names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NS: Authoritative name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PTR: Maps an IP address to a domain name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SOA: Start of authority record for the zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SPF: Lists the servers authorized to send emails from a domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SRV: Application specific values that identify servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TXT: Verifies email senders and application-specific values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A query type you define by using the DNS type ID, for example 28 for AAAA. The values
        /// must be defined as TYPENUMBER, where the NUMBER can be 1-65334, for example, TYPE28.
        /// For more information, see <a href="https://en.wikipedia.org/wiki/List_of_DNS_record_types">List
        /// of DNS record types</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string Qtype
        {
            get { return this._qtype; }
            set { this._qtype = value; }
        }

        // Check to see if Qtype property is set
        internal bool IsSetQtype()
        {
            return this._qtype != null;
        }

    }
}