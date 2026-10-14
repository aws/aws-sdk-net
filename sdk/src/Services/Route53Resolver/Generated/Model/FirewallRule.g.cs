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
    /// A single firewall rule in a rule group.
    /// </summary>
    public partial class FirewallRule
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
        ///  <c>BLOCK</c> - Disallow the request. If this is specified, additional handling details
        /// are provided in the rule's <c>BlockResponse</c> setting. 
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the rule was created, in Unix time format and Coordinated Universal
        /// Time (UTC). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string defined by you to identify the request. This allows you to retry failed
        /// requests without the risk of executing the operation twice. This can be any unique
        /// string, for example, a timestamp. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property DnsThreatProtection. 
        /// <para>
        ///  The type of the DNS Firewall Advanced rule. Valid values are: 
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
        /// The ID of the domain list that's used in the rule. 
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
        /// The unique identifier of the Firewall rule group of the rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallRuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRuleGroupId property is set.
        /// </summary>
        internal bool IsSetFirewallRuleGroupId() => this.FirewallRuleGroupId != null;

        /// <summary>
        /// Gets and sets the property FirewallRuleType. 
        /// <para>
        /// The rule type configuration for the firewall rule. This is a tagged union — exactly
        /// one of its members will be populated. Possible members are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FirewallAdvancedContentCategory</c> — an Amazon Web Services-managed content category
        /// (for example, <c>VIOLENCE_AND_HATE_SPEECH</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FirewallAdvancedThreatCategory</c> — an Amazon Web Services-managed advanced threat
        /// category (for example, <c>PHISHING</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DnsThreatProtection</c> — a built-in DNS Firewall Advanced threat detector (<c>DGA</c>,
        /// <c>DNS_TUNNELING</c>, or <c>DICTIONARY_DGA</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartnerThreatProtection</c> — a third-party threat feed delivered through Amazon
        /// Web Services Marketplace.
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
        ///  ID of the DNS Firewall Advanced rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallThreatProtectionId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallThreatProtectionId property is set.
        /// </summary>
        internal bool IsSetFirewallThreatProtectionId() => this.FirewallThreatProtectionId != null;

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the rule was last modified, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the ModificationTime property is set.
        /// </summary>
        internal bool IsSetModificationTime() => this.ModificationTime != null;

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
        /// The priority of the rule in the rule group. This value must be unique within the rule
        /// group. DNS Firewall processes the rules in a rule group by order of priority, starting
        /// from the lowest setting.
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
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public string Qtype { get; set; }

        /// <summary>
        /// Checks to see if the Qtype property is set.
        /// </summary>
        internal bool IsSetQtype() => this.Qtype != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The lifecycle state of the firewall rule. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> — DNS Firewall is provisioning the rule. Rules created with the <c>PartnerThreatProtection</c>
        /// rule type begin in this state while DNS Firewall verifies the calling account's Amazon
        /// Web Services Marketplace entitlement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> — The rule is provisioned and enforcing matches.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_FAILED</c> — Provisioning failed. <c>StatusMessage</c> contains a human-readable
        /// reason. A rule in this state is immutable: <a>UpdateFirewallRule</a> rejects the request,
        /// and the rule must be removed with <a>DeleteFirewallRule</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For rules that do not require asynchronous provisioning, this field may be absent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// An additional message about the rule's lifecycle state. Populated when <c>Status</c>
        /// is <c>CREATION_FAILED</c> to describe why provisioning failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
