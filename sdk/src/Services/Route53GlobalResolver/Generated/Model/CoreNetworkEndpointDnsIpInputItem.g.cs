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
    /// A DNS IP address configuration that you provide when you create a core network endpoint.
    /// Each item specifies an IP address for the endpoint to receive DNS queries, along with
    /// its DNS label, and the scope and Amazon Web Services Regions in which the address
    /// applies.
    /// </summary>
    public partial class CoreNetworkEndpointDnsIpInputItem
    {
        /// <summary>
        /// Gets and sets the property DnsLabel. 
        /// <para>
        /// The DNS label to associate with the IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string DnsLabel { get; set; }

        /// <summary>
        /// Checks to see if the DnsLabel property is set.
        /// </summary>
        internal bool IsSetDnsLabel() => this.DnsLabel != null;

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// The IPv4 address for the core network endpoint to receive DNS queries.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public string Ipv4Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4Address property is set.
        /// </summary>
        internal bool IsSetIpv4Address() => this.Ipv4Address != null;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 address for the core network endpoint to receive DNS queries.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 39)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property RegionScope. 
        /// <para>
        /// Indicates whether the IP address applies to all Amazon Web Services Regions or only
        /// to the specific Regions that you identify. When the value is <c>REGIONAL</c>, the
        /// Regions are listed in the <c>regions</c> field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegionScopeType RegionScope { get; set; }

        /// <summary>
        /// Checks to see if the RegionScope property is set.
        /// </summary>
        internal bool IsSetRegionScope() => this.RegionScope != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Amazon Web Services Regions in which the IP address applies when the region scope
        /// is <c>REGIONAL</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
