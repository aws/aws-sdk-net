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
    /// Information about a DNS Firewall rule to create in a batch operation.
    /// </summary>
    public partial class BatchCreateFirewallRuleInputItem
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
        private string _dnsViewId;
        private string _firewallDomainListId;
        private string _name;
        private long? _priority;
        private string _qType;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take when a DNS query matches the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The DNS record type for the custom response when the action is BLOCK.
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
        /// The custom domain name for the BLOCK response.
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
        /// The TTL value for the custom response when the action is BLOCK.
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
        /// The type of block response to return when the action is BLOCK.
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
        /// A unique string that identifies the request and ensures idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The confidence threshold for advanced threat detection.
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
        /// A description of the firewall rule.
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
        /// Whether to enable advanced DNS threat protection for the firewall rule.
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
        /// Gets and sets the property DnsViewId. 
        /// <para>
        /// The ID of the DNS view to associate the firewall rule with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DnsViewId
        {
            get { return this._dnsViewId; }
            set { this._dnsViewId = value; }
        }

        // Check to see if DnsViewId property is set
        internal bool IsSetDnsViewId()
        {
            return this._dnsViewId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the firewall domain list to associate with the rule.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// The priority of the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public long? Priority
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
        /// Gets and sets the property QType. 
        /// <para>
        /// The DNS query type that the firewall rule should match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public string QType
        {
            get { return this._qType; }
            set { this._qType = value; }
        }

        // Check to see if QType property is set
        internal bool IsSetQType()
        {
            return this._qType != null;
        }

    }
}