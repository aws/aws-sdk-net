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
    /// Container for the parameters to the CreateAccessSource operation.
    /// Creates an access source for a DNS view. Access sources define IP addresses or CIDR
    /// ranges that are allowed to send DNS queries to the Route 53 Global Resolver, along
    /// with the permitted DNS protocols.
    /// </summary>
    public partial class CreateAccessSourceRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _cidr;
        private string _clientToken;
        private string _dnsViewId;
        private IpAddressType _ipAddressType;
        private string _name;
        private DnsProtocol _protocol;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP address or CIDR range that is allowed to send DNS queries to the Route 53 Global
        /// Resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=42)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

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
        /// Gets and sets the property DnsViewId. 
        /// <para>
        /// The ID of the DNS view to associate with this access source.
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
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for this access source. Valid values are IPv4 and IPv6 (if the
        /// Route 53 Global Resolver supports dual-stack).
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the access source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The DNS protocol that is permitted for this access source. Valid values are Do53 (DNS
        /// over port 53), DoT (DNS over TLS), and DoH (DNS over HTTPS).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DnsProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the access source.
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