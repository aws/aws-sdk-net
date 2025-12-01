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
    /// Container for the parameters to the CreateDNSView operation.
    /// Creates a DNS view within a Route 53 Global Resolver. A DNS view models end users,
    /// user groups, networks, and devices, and serves as a parent resource that holds configurations
    /// controlling access, authorization, DNS firewall rules, and forwarding rules.
    /// </summary>
    public partial class CreateDNSViewRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _clientToken;
        private string _description;
        private DnsSecValidationType _dnssecValidation;
        private EdnsClientSubnetType _ednsClientSubnet;
        private FirewallRulesFailOpenType _firewallRulesFailOpen;
        private string _globalResolverId;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique string that identifies the request and ensures idempotency.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the DNS view.
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
        /// Gets and sets the property DnssecValidation. 
        /// <para>
        /// Whether to enable DNSSEC validation for DNS queries in this DNS view. When enabled,
        /// the resolver verifies the authenticity and integrity of DNS responses from public
        /// name servers for DNSSEC-signed domains.
        /// </para>
        /// </summary>
        public DnsSecValidationType DnssecValidation
        {
            get { return this._dnssecValidation; }
            set { this._dnssecValidation = value; }
        }

        // Check to see if DnssecValidation property is set
        internal bool IsSetDnssecValidation()
        {
            return this._dnssecValidation != null;
        }

        /// <summary>
        /// Gets and sets the property EdnsClientSubnet. 
        /// <para>
        /// Whether to enable EDNS Client Subnet injection for DNS queries in this DNS view. When
        /// enabled, client subnet information is forwarded to provide more accurate geographic-based
        /// DNS responses.
        /// </para>
        /// </summary>
        public EdnsClientSubnetType EdnsClientSubnet
        {
            get { return this._ednsClientSubnet; }
            set { this._ednsClientSubnet = value; }
        }

        // Check to see if EdnsClientSubnet property is set
        internal bool IsSetEdnsClientSubnet()
        {
            return this._ednsClientSubnet != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRulesFailOpen. 
        /// <para>
        /// Determines the behavior when Route 53 Global Resolver cannot apply DNS firewall rules
        /// due to service impairment. When enabled, DNS queries are allowed through; when disabled,
        /// queries are blocked.
        /// </para>
        /// </summary>
        public FirewallRulesFailOpenType FirewallRulesFailOpen
        {
            get { return this._firewallRulesFailOpen; }
            set { this._firewallRulesFailOpen = value; }
        }

        // Check to see if FirewallRulesFailOpen property is set
        internal bool IsSetFirewallRulesFailOpen()
        {
            return this._firewallRulesFailOpen != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalResolverId. 
        /// <para>
        /// The ID of the Route 53 Global Resolver to associate with this DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string GlobalResolverId
        {
            get { return this._globalResolverId; }
            set { this._globalResolverId = value; }
        }

        // Check to see if GlobalResolverId property is set
        internal bool IsSetGlobalResolverId()
        {
            return this._globalResolverId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the DNS view.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}