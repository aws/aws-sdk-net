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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the DNS options for an endpoint.
    /// </summary>
    public partial class DnsOptionsSpecification
    {
        private DnsRecordIpType _dnsRecordIpType;
        private bool? _privateDnsOnlyForInboundResolverEndpoint;
        private string _privateDnsPreference;
        private List<string> _privateDnsSpecifiedDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DnsRecordIpType. 
        /// <para>
        /// The DNS records created for the endpoint.
        /// </para>
        /// </summary>
        public DnsRecordIpType DnsRecordIpType
        {
            get { return this._dnsRecordIpType; }
            set { this._dnsRecordIpType = value; }
        }

        // Check to see if DnsRecordIpType property is set
        internal bool IsSetDnsRecordIpType()
        {
            return this._dnsRecordIpType != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsOnlyForInboundResolverEndpoint. 
        /// <para>
        /// Indicates whether to enable private DNS only for inbound endpoints. This option is
        /// available only for services that support both gateway and interface endpoints. It
        /// routes traffic that originates from the VPC to the gateway endpoint and traffic that
        /// originates from on-premises to the interface endpoint.
        /// </para>
        /// </summary>
        public bool PrivateDnsOnlyForInboundResolverEndpoint
        {
            get { return this._privateDnsOnlyForInboundResolverEndpoint.GetValueOrDefault(); }
            set { this._privateDnsOnlyForInboundResolverEndpoint = value; }
        }

        // Check to see if PrivateDnsOnlyForInboundResolverEndpoint property is set
        internal bool IsSetPrivateDnsOnlyForInboundResolverEndpoint()
        {
            return this._privateDnsOnlyForInboundResolverEndpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsPreference. 
        /// <para>
        ///  The preference for which private domains have a private hosted zone created for and
        /// associated with the specified VPC. Only supported when private DNS is enabled and
        /// when the VPC endpoint type is ServiceNetwork or Resource. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_DOMAINS</c> - VPC Lattice provisions private hosted zones for all custom domain
        /// names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VERIFIED_DOMAINS_ONLY</c> - VPC Lattice provisions a private hosted zone only
        /// if custom domain name has been verified by the provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VERIFIED_DOMAINS_AND_SPECIFIED_DOMAINS</c> - VPC Lattice provisions private hosted
        /// zones for all verified custom domain names and other domain names that the resource
        /// consumer specifies. The resource consumer specifies the domain names in the PrivateDnsSpecifiedDomains
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPECIFIED_DOMAINS_ONLY</c> - VPC Lattice provisions a private hosted zone for
        /// domain names specified by the resource consumer. The resource consumer specifies the
        /// domain names in the PrivateDnsSpecifiedDomains parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PrivateDnsPreference
        {
            get { return this._privateDnsPreference; }
            set { this._privateDnsPreference = value; }
        }

        // Check to see if PrivateDnsPreference property is set
        internal bool IsSetPrivateDnsPreference()
        {
            return this._privateDnsPreference != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsSpecifiedDomains. 
        /// <para>
        ///  Indicates which of the private domains to create private hosted zones for and associate
        /// with the specified VPC. Only supported when private DNS is enabled and the private
        /// DNS preference is verified-domains-and-specified-domains or specified-domains-only.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> PrivateDnsSpecifiedDomains
        {
            get { return this._privateDnsSpecifiedDomains; }
            set { this._privateDnsSpecifiedDomains = value; }
        }

        // Check to see if PrivateDnsSpecifiedDomains property is set
        internal bool IsSetPrivateDnsSpecifiedDomains()
        {
            return this._privateDnsSpecifiedDomains != null && (this._privateDnsSpecifiedDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}