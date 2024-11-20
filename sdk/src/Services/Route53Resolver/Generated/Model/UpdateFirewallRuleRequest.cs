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
    /// Container for the parameters to the UpdateFirewallRule operation.
    /// Updates the specified firewall rule.
    /// </summary>
    public partial class UpdateFirewallRuleRequest : AmazonRoute53ResolverRequest
    {
        private Action _action;
        private BlockOverrideDnsType _blockOverrideDnsType;
        private string _blockOverrideDomain;
        private int? _blockOverrideTtl;
        private BlockResponse _blockResponse;
        private ConfidenceThreshold _confidenceThreshold;
        private DnsThreatProtection _dnsThreatProtection;
        private string _firewallDomainListId;
        private FirewallDomainRedirectionAction _firewallDomainRedirectionAction;
        private string _firewallRuleGroupId;
        private string _firewallThreatProtectionId;
        private string _name;
        private int? _priority;
        private string _qtype;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that DNS Firewall should take on a DNS query when it matches one of the
        /// domains in the rule's domain list, or a threat in a DNS Firewall Advanced rule:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW</c> - Permit the request to go through. Not available for DNS Firewall Advanced
        /// rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALERT</c> - Permit the request to go through but send an alert to the logs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BLOCK</c> - Disallow the request. This option requires additional details in the
        /// rule's <c>BlockResponse</c>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property BlockOverrideDnsType. 
        /// <para>
        /// The DNS record's type. This determines the format of the record value that you provided
        /// in <c>BlockOverrideDomain</c>. Used for the rule action <c>BLOCK</c> with a <c>BlockResponse</c>
        /// setting of <c>OVERRIDE</c>.
        /// </para>
        /// </summary>
        public BlockOverrideDnsType BlockOverrideDnsType
        {
            get { return this._blockOverrideDnsType; }
            set { this._blockOverrideDnsType = value; }
        }

        // Check to see if BlockOverrideDnsType property is set
        internal bool IsSetBlockOverrideDnsType()
        {
            return this._blockOverrideDnsType != null;
        }

        /// <summary>
        /// Gets and sets the property BlockOverrideDomain. 
        /// <para>
        /// The custom DNS record to send back in response to the query. Used for the rule action
        /// <c>BLOCK</c> with a <c>BlockResponse</c> setting of <c>OVERRIDE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string BlockOverrideDomain
        {
            get { return this._blockOverrideDomain; }
            set { this._blockOverrideDomain = value; }
        }

        // Check to see if BlockOverrideDomain property is set
        internal bool IsSetBlockOverrideDomain()
        {
            return this._blockOverrideDomain != null;
        }

        /// <summary>
        /// Gets and sets the property BlockOverrideTtl. 
        /// <para>
        /// The recommended amount of time, in seconds, for the DNS resolver or web browser to
        /// cache the provided override record. Used for the rule action <c>BLOCK</c> with a <c>BlockResponse</c>
        /// setting of <c>OVERRIDE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=604800)]
        public int? BlockOverrideTtl
        {
            get { return this._blockOverrideTtl; }
            set { this._blockOverrideTtl = value; }
        }

        // Check to see if BlockOverrideTtl property is set
        internal bool IsSetBlockOverrideTtl()
        {
            return this._blockOverrideTtl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlockResponse. 
        /// <para>
        /// The way that you want DNS Firewall to block the request. Used for the rule action
        /// setting <c>BLOCK</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NODATA</c> - Respond indicating that the query was successful, but no response
        /// is available for it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NXDOMAIN</c> - Respond indicating that the domain name that's in the query doesn't
        /// exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OVERRIDE</c> - Provide a custom override in the response. This option requires
        /// custom handling details in the rule's <c>BlockOverride*</c> settings. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BlockResponse BlockResponse
        {
            get { return this._blockResponse; }
            set { this._blockResponse = value; }
        }

        // Check to see if BlockResponse property is set
        internal bool IsSetBlockResponse()
        {
            return this._blockResponse != null;
        }

        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        ///  The confidence threshold for DNS Firewall Advanced. You must provide this value when
        /// you create a DNS Firewall Advanced rule. The confidence level values mean: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LOW</c>: Provides the highest detection rate for threats, but also increases false
        /// positives.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c>: Provides a balance between detecting threats and false positives.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HIGH</c>: Detects only the most well corroborated threats with a low rate of false
        /// positives. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConfidenceThreshold ConfidenceThreshold
        {
            get { return this._confidenceThreshold; }
            set { this._confidenceThreshold = value; }
        }

        // Check to see if ConfidenceThreshold property is set
        internal bool IsSetConfidenceThreshold()
        {
            return this._confidenceThreshold != null;
        }

        /// <summary>
        /// Gets and sets the property DnsThreatProtection. 
        /// <para>
        ///  The type of the DNS Firewall Advanced rule. Valid values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DGA</c>: Domain generation algorithms detection. DGAs are used by attackers to
        /// generate a large number of domains to to launch malware attacks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DNS_TUNNELING</c>: DNS tunneling detection. DNS tunneling is used by attackers
        /// to exfiltrate data from the client by using the DNS tunnel without making a network
        /// connection to the client.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DnsThreatProtection DnsThreatProtection
        {
            get { return this._dnsThreatProtection; }
            set { this._dnsThreatProtection = value; }
        }

        // Check to see if DnsThreatProtection property is set
        internal bool IsSetDnsThreatProtection()
        {
            return this._dnsThreatProtection != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the domain list to use in the rule. 
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
        /// Gets and sets the property FirewallDomainRedirectionAction. 
        /// <para>
        ///  How you want the the rule to evaluate DNS redirection in the DNS redirection chain,
        /// such as CNAME or DNAME. 
        /// </para>
        ///  
        /// <para>
        ///  <c>INSPECT_REDIRECTION_DOMAIN</c>: (Default) inspects all domains in the redirection
        /// chain. The individual domains in the redirection chain must be added to the domain
        /// list.
        /// </para>
        ///  
        /// <para>
        ///  <c>TRUST_REDIRECTION_DOMAIN</c>: Inspects only the first domain in the redirection
        /// chain. You don't need to add the subsequent domains in the domain in the redirection
        /// list to the domain list.
        /// </para>
        /// </summary>
        public FirewallDomainRedirectionAction FirewallDomainRedirectionAction
        {
            get { return this._firewallDomainRedirectionAction; }
            set { this._firewallDomainRedirectionAction = value; }
        }

        // Check to see if FirewallDomainRedirectionAction property is set
        internal bool IsSetFirewallDomainRedirectionAction()
        {
            return this._firewallDomainRedirectionAction != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group for the rule. 
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
        ///  The DNS Firewall Advanced rule ID. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The setting that determines the processing order of the rule in the rule group. DNS
        /// Firewall processes the rules in a rule group by order of priority, starting from the
        /// lowest setting.
        /// </para>
        ///  
        /// <para>
        /// You must specify a unique priority for each rule in a rule group. To make it easier
        /// to insert rules later, leave space between the numbers, for example, use 100, 200,
        /// and so on. You can change the priority setting for the rules in a rule group at any
        /// time.
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
        /// Gets and sets the property Qtype. 
        /// <para>
        ///  The DNS query type you want the rule to evaluate. Allowed values are; 
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
        ///  <note> 
        /// <para>
        /// If you set up a firewall BLOCK rule with action NXDOMAIN on query type equals AAAA,
        /// this action will not be applied to synthetic IPv6 addresses generated when DNS64 is
        /// enabled. 
        /// </para>
        ///  </note> </li> </ul>
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