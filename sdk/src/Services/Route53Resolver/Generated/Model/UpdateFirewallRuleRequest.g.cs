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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFirewallRule operation. Updates the specified
    /// firewall rule. The rule's <c>FirewallRuleType</c>, <c>FirewallDomainListId</c>, and
    /// top-level <c>DnsThreatProtection</c> match source cannot be changed after creation.
    /// Rules whose <c>Status</c> is <c>CREATING</c> or <c>CREATION_FAILED</c> cannot be updated;
    /// remove a failed rule with <a>DeleteFirewallRule</a>.
    /// </summary>
    public partial class UpdateFirewallRuleRequest : AmazonRoute53ResolverRequest
    {
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
        public Action Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property BlockOverrideDnsType. 
        /// <para>
        /// The DNS record's type. This determines the format of the record value that you provided
        /// in <c>BlockOverrideDomain</c>. Used for the rule action <c>BLOCK</c> with a <c>BlockResponse</c>
        /// setting of <c>OVERRIDE</c>.
        /// </para>
        /// </summary>
        public BlockOverrideDnsType BlockOverrideDnsType { get; set; }

        /// <summary>
        /// Checks to see if the BlockOverrideDnsType property is set.
        /// </summary>
        internal bool IsSetBlockOverrideDnsType() => this.BlockOverrideDnsType != null;

        /// <summary>
        /// Gets and sets the property BlockOverrideDomain. 
        /// <para>
        /// The custom DNS record to send back in response to the query. Used for the rule action
        /// <c>BLOCK</c> with a <c>BlockResponse</c> setting of <c>OVERRIDE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string BlockOverrideDomain { get; set; }

        /// <summary>
        /// Checks to see if the BlockOverrideDomain property is set.
        /// </summary>
        internal bool IsSetBlockOverrideDomain() => this.BlockOverrideDomain != null;

        /// <summary>
        /// Gets and sets the property BlockOverrideTtl. 
        /// <para>
        /// The recommended amount of time, in seconds, for the DNS resolver or web browser to
        /// cache the provided override record. Used for the rule action <c>BLOCK</c> with a <c>BlockResponse</c>
        /// setting of <c>OVERRIDE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 604800)]
        public int? BlockOverrideTtl { get; set; }

        /// <summary>
        /// Checks to see if the BlockOverrideTtl property is set.
        /// </summary>
        internal bool IsSetBlockOverrideTtl() => this.BlockOverrideTtl.HasValue;

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
        public BlockResponse BlockResponse { get; set; }

        /// <summary>
        /// Checks to see if the BlockResponse property is set.
        /// </summary>
        internal bool IsSetBlockResponse() => this.BlockResponse != null;

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
        public ConfidenceThreshold ConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetConfidenceThreshold() => this.ConfidenceThreshold != null;

        /// <summary>
        /// Gets and sets the property DnsThreatProtection. 
        /// <para>
        ///  The type of the DNS Firewall Advanced rule. This setting is mutually exclusive with
        /// <c>FirewallDomainListId</c> and <c>FirewallRuleType</c>. Valid values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DGA</c>: Domain generation algorithms detection. DGAs are used by attackers to
        /// generate a large number of domains to launch malware attacks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DNS_TUNNELING</c>: DNS tunneling detection. DNS tunneling is used by attackers
        /// to exfiltrate data from the client by using the DNS tunnel without making a network
        /// connection to the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DICTIONARY_DGA</c>: Dictionary-based domain generation algorithms detection. Dictionary
        /// DGAs use wordlists to generate domains that appear more legitimate, making them harder
        /// to detect than traditional DGAs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DnsThreatProtection DnsThreatProtection { get; set; }

        /// <summary>
        /// Checks to see if the DnsThreatProtection property is set.
        /// </summary>
        internal bool IsSetDnsThreatProtection() => this.DnsThreatProtection != null;

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the domain list to use in the rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallDomainListId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallDomainListId property is set.
        /// </summary>
        internal bool IsSetFirewallDomainListId() => this.FirewallDomainListId != null;

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
        public FirewallDomainRedirectionAction FirewallDomainRedirectionAction { get; set; }

        /// <summary>
        /// Checks to see if the FirewallDomainRedirectionAction property is set.
        /// </summary>
        internal bool IsSetFirewallDomainRedirectionAction() => this.FirewallDomainRedirectionAction != null;

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group for the rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FirewallRuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRuleGroupId property is set.
        /// </summary>
        internal bool IsSetFirewallRuleGroupId() => this.FirewallRuleGroupId != null;

        /// <summary>
        /// Gets and sets the property FirewallRuleType. 
        /// <para>
        /// The rule type configuration for the firewall rule. This is a tagged union — set exactly
        /// one of its members. This setting is mutually exclusive with the top-level <c>FirewallDomainListId</c>
        /// and <c>DnsThreatProtection</c> fields. Use one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FirewallAdvancedContentCategory</c> — match an Amazon Web Services-managed content
        /// category (for example, <c>VIOLENCE_AND_HATE_SPEECH</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FirewallAdvancedThreatCategory</c> — match an Amazon Web Services-managed advanced
        /// threat category (for example, <c>PHISHING</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DnsThreatProtection</c> — match a built-in DNS Firewall Advanced threat detector
        /// (<c>DGA</c>, <c>DNS_TUNNELING</c>, or <c>DICTIONARY_DGA</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartnerThreatProtection</c> — match a third-party threat feed delivered through
        /// Amazon Web Services Marketplace. The selected partner must be an active subscription
        /// on the calling account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enumerate the values supported in your account, call <a>ListFirewallRuleTypes</a>.
        /// </para>
        /// </summary>
        public FirewallRuleType FirewallRuleType { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRuleType property is set.
        /// </summary>
        internal bool IsSetFirewallRuleType() => this.FirewallRuleType != null;

        /// <summary>
        /// Gets and sets the property FirewallThreatProtectionId. 
        /// <para>
        ///  The DNS Firewall Advanced rule ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallThreatProtectionId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallThreatProtectionId property is set.
        /// </summary>
        internal bool IsSetFirewallThreatProtectionId() => this.FirewallThreatProtectionId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

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
        /// must be defined as TYPENUMBER, where the NUMBER can be 1-65534, for example, TYPE28.
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
        [AWSProperty(Min = 1, Max = 16)]
        public string Qtype { get; set; }

        /// <summary>
        /// Checks to see if the Qtype property is set.
        /// </summary>
        internal bool IsSetQtype() => this.Qtype != null;
    }
}
