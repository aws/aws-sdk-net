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
    /// Container for the parameters to the UpdateDNSView operation.
    /// Updates the configuration of a DNS view.
    /// </summary>
    public partial class UpdateDNSViewRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _description;
        private DnsSecValidationType _dnssecValidation;
        private string _dnsViewId;
        private EdnsClientSubnetType _ednsClientSubnet;
        private FirewallRulesFailOpenType _firewallRulesFailOpen;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the DNS view.
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
        /// Whether to enable DNSSEC validation for the DNS view.
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
        /// Gets and sets the property DnsViewId. 
        /// <para>
        /// The unique identifier of the DNS view to update.
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
        /// Gets and sets the property EdnsClientSubnet. 
        /// <para>
        /// Whether to enable EDNS Client Subnet injection for the DNS view.
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
        /// Whether firewall rules should fail open when they cannot be evaluated.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the DNS view.
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

    }
}