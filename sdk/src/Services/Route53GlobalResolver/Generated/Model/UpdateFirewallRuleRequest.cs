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
    /// Container for the parameters to the UpdateFirewallRule operation.
    /// Updates the configuration of a DNS firewall rule.
    /// </summary>
    public partial class UpdateFirewallRuleRequest : AmazonRoute53GlobalResolverRequest
    {
        private FirewallRuleAction _action;
        private BlockOverrideDnsQueryType _blockOverrideDnsType;
        private string _blockOverrideDomain;
        private int? _blockOverrideTtl;
        private FirewallBlockResponse _blockResponse;
        private string _clientToken;
        private ConfidenceThreshold _confidenceThreshold;
        private string _description;
        private DnsAdvancedProtection _dnsAdvancedProtection;
        private string _firewallRuleId;
        private string _name;
        private long? _priority;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that DNS Firewall should take on a DNS query when it matches one of the
        /// domains in the rule's domain list, or a threat in a DNS Firewall Advanced rule.
        /// </para>
        /// </summary>
        public FirewallRuleAction Action
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
        public BlockOverrideDnsQueryType BlockOverrideDnsType
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
        [AWSProperty(Min=1, Max=256)]
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
        public int BlockOverrideTtl
        {
            get { return this._blockOverrideTtl.GetValueOrDefault(); }
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
        /// </summary>
        public FirewallBlockResponse BlockResponse
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency. This means that making
        /// the same request multiple times with the same <c>clientToken</c> has the same result
        /// every time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        /// The confidence threshold for DNS Firewall Advanced. You must provide this value when
        /// you create a DNS Firewall Advanced rule.
        /// </para>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the Firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DnsAdvancedProtection. 
        /// <para>
        /// The type of the DNS Firewall Advanced rule. Valid values are DGA and DNS_TUNNELING.
        /// </para>
        /// </summary>
        public DnsAdvancedProtection DnsAdvancedProtection
        {
            get { return this._dnsAdvancedProtection; }
            set { this._dnsAdvancedProtection = value; }
        }

        // Check to see if DnsAdvancedProtection property is set
        internal bool IsSetDnsAdvancedProtection()
        {
            return this._dnsAdvancedProtection != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRuleId. 
        /// <para>
        /// The ID of the DNS Firewall rule.
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the DNS Firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public long Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

    }
}