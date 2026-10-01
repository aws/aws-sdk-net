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

namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFirewallRule operation. Creates a DNS firewall
    /// rule. Firewall rules define actions (ALLOW, BLOCK, or ALERT) to take on DNS queries
    /// that match specified domain lists, managed domain lists, or advanced threat protections.
    /// <important> <para> Route 53 Global Resolver is a global service that supports resolvers
    /// in multiple Amazon Web Services Regions but you must specify the US East (Ohio) Region
    /// to create, update, or otherwise work with Route 53 Global Resolver resources. That
    /// is, for example, specify <c>--region us-east-2</c> on Amazon Web Services CLI commands.
    /// </para> </important>
    /// </summary>
    public partial class CreateFirewallRuleRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that DNS Firewall should take on a DNS query when it matches one of the
        /// domains in the rule's domain list:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW</c> - Permit the request to go through.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALERT</c> - Permit the request and send metrics and logs to CloudWatch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BLOCK</c> - Disallow the request. This option requires additional details in the
        /// rule's <c>BlockResponse</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallRuleAction Action { get; set; }

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
        ///  
        /// <para>
        /// This setting is required if the <c>BlockResponse</c> setting is <c>OVERRIDE</c>.
        /// </para>
        /// </summary>
        public BlockOverrideDnsQueryType BlockOverrideDnsType { get; set; }

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
        ///  
        /// <para>
        /// This setting is required if the <c>BlockResponse</c> setting is <c>OVERRIDE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
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
        ///  
        /// <para>
        /// This setting is required if the <c>BlockResponse</c> setting is <c>OVERRIDE</c>.
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
        /// The response to return when the action is BLOCK. Valid values are NXDOMAIN (domain
        /// does not exist), NODATA (domain exists but no records), or OVERRIDE (return custom
        /// response).
        /// </para>
        /// </summary>
        public FirewallBlockResponse BlockResponse { get; set; }

        /// <summary>
        /// Checks to see if the BlockResponse property is set.
        /// </summary>
        internal bool IsSetBlockResponse() => this.BlockResponse != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency. This means that making
        /// the same request multiple times with the same <c>clientToken</c> has the same result
        /// every time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        /// The confidence threshold for advanced threat detection. Valid values are HIGH, MEDIUM,
        /// or LOW, indicating the accuracy level required for threat detection.
        /// </para>
        /// </summary>
        public ConfidenceThreshold ConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetConfidenceThreshold() => this.ConfidenceThreshold != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DnsAdvancedProtection. 
        /// <para>
        /// Whether to enable advanced DNS threat protection for this rule. Advanced protection
        /// can detect and block DNS tunneling and Domain Generation Algorithm (DGA) threats.
        /// </para>
        /// </summary>
        public DnsAdvancedProtection DnsAdvancedProtection { get; set; }

        /// <summary>
        /// Checks to see if the DnsAdvancedProtection property is set.
        /// </summary>
        internal bool IsSetDnsAdvancedProtection() => this.DnsAdvancedProtection != null;

        /// <summary>
        /// Gets and sets the property DnsViewId. 
        /// <para>
        /// The ID of the DNS view to associate with this firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DnsViewId { get; set; }

        /// <summary>
        /// Checks to see if the DnsViewId property is set.
        /// </summary>
        internal bool IsSetDnsViewId() => this.DnsViewId != null;

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the firewall domain list to use in this rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallDomainListId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallDomainListId property is set.
        /// </summary>
        internal bool IsSetFirewallDomainListId() => this.FirewallDomainListId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of this rule. Rules are evaluated in priority order, with lower numbers
        /// having higher priority. When a DNS query matches multiple rules, the rule with the
        /// highest priority (lowest number) is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public long? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property QType. 
        /// <para>
        /// The DNS query type to match for this rule. Examples include A (IPv4 address), AAAA
        /// (IPv6 address), MX (mail exchange), or TXT (text record).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string QType { get; set; }

        /// <summary>
        /// Checks to see if the QType property is set.
        /// </summary>
        internal bool IsSetQType() => this.QType != null;
    }
}
